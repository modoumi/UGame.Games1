﻿using Fortune_mouse.DAL;
using TinyFx.Data;
using TinyFx.SnowflakeId;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using static Xxyy.GameEAPI.Core.GameEAPIUtil;
namespace Fortune_mouse.BLL;

public class BetService : RootService
{
    private readonly Fmo_bet_detailMO _betDetailMo = new();
    private readonly Fmo_pool_returnMO _poolReturnMo = new();
    private readonly Slot_pool_change_detailMO _poolChangeMo = new();
    public async Task<BetDto> Bet(BetIpo ipo)
    {
        await CheckIdentityAndMock(ipo.UserId);
        var context = new BetContext(ipo, await CheckUserExtAsync(ipo.UserId));

        var betId = context.BetId = SnowflakeIdUtil.NextId();
        //算法逻辑
        await ExecuteContext(context);
        //先插入数据
        await FortuneUtil.AddBetDetail(context, null);
        var tm = new TransactionManager();
        try
        {
            TimeSpan elapsedTime = await MeasureExecutionTime<BetContext>(async () =>
            {
                context.BalanceAmount = (await BetWin(context.UserId, context.AppId, betId.ToString()
                     , context.Chips.BetAmount, context.RealWinAmount)).Balance;
            });
            context.IsChangeBalance = true;
            TimeSpan elapsedTime2 = await MeasureExecutionTime<BetContext>(async () =>
            {
                //更新基础奖池,记录奖池变化log
                await PutPool(context, tm);
            });
            TimeSpan elapsedTime3 = await MeasureExecutionTime<BetContext>(async () =>
            {
                //更新下注表
                await _betDetailMo.PutByPKAsync(betId,
                $"OrderStatus={(int)OrderStatus.Success},BalanceAmount={context.BalanceAmount}", tm);
            });
            Console.WriteLine($"{context.AppId} 调用下注接口 BetWin -> 耗时:{elapsedTime.Milliseconds}毫秒");
            Console.WriteLine($"{context.AppId} 更新基础奖池 PutPool -> 耗时:{elapsedTime2.Milliseconds}毫秒");
            Console.WriteLine($"{context.AppId} 更新下注表 PutByPKAsync -> 耗时:{elapsedTime3.Milliseconds}毫秒");
            tm.Commit();
        }
        catch (Exception ex)
        {
            tm.Rollback();
            await BetRollback(context, betId, tm);
            throw;
        }
        return await BuildDto(context);
    }

    private async Task BetRollback(BetContext context, long betId, TransactionManager tm)
    {
        var status = context.IsChangeBalance ? OrderStatus.Exception : OrderStatus.Fail;
        await _betDetailMo.PutOrderStatusByPKAsync(betId, (int)status, tm);
    }

    private async Task ExecuteContext(BetContext context)
    {
        TimeSpan elapsedTime = await MeasureExecutionTime<BetContext>(async () => await new BetInitProcess().Execute(context));
        TimeSpan elapsedTime2 = await MeasureExecutionTime<BetContext>(async () => await new BetProcess().Execute(context));
        Console.WriteLine($"{context.AppId} 调用用户余额 _operatorClient.Balance -> 耗时:{elapsedTime.Milliseconds}毫秒");
        Console.WriteLine($"{context.AppId} 游戏内算法逻辑 BetProcess -> 耗时:{elapsedTime2.Milliseconds}毫秒");
    }
    public async Task PutPool(BetContext context, TransactionManager tm)
    {
        var poolBeforeEo = await _poolReturnMo.GetByPKAsync(context.OperatorId, context.CurrencyId, tm);
        var beforeAmount = poolBeforeEo.PoolVal;
        var beforeBonus = poolBeforeEo.BonusVal;
        //更新基础奖池
        await _poolReturnMo.PutByPKAsync(context.OperatorId, context.CurrencyId, $"PoolVal=PoolVal+{context.PartAmount.PartMoneyAmount},BonusVal=BonusVal+{context.PartAmount.PartBonusAmount}", tm);
        var poolAfterEo = await _poolReturnMo.GetByPKAsync(context.OperatorId, context.CurrencyId, tm);
        var afterAmount = poolAfterEo.PoolVal;
        var afterBonus = poolAfterEo.BonusVal;
        await _poolChangeMo.AddAsync(new Slot_pool_change_detailEO
        {
            ChangeID = SnowflakeIdUtil.NextId(),
            AppID = context.AppId,
            OperatorID = context.OperatorId,
            CurrencyID = context.CurrencyId,
            BetID = context.BetId,
            UserID = context.UserId,
            BeforeAmount = beforeAmount,
            ChangeAmount = context.PartAmount.PartMoneyAmount,
            AfterAmount = afterAmount,
            BeforeBonus = beforeBonus,
            ChangeBonus = context.PartAmount.PartBonusAmount,
            AfterBonus = afterBonus,
            RecDate = DateTime.UtcNow,
        }, tm);
    }
    private async Task<BetDto> BuildDto(BetContext context)
    {
        var ret = new BetDto();
        ret.PlayerInfo.Balance = context.BalanceAmount.AToM(context.CurrencyId);
        ret.ResultInfo.GameInfoList = BuildGameInfoList(context);
        return ret;
    }

    public static List<GameInfo> BuildGameInfoList(BetContext context)
    {
        List<GameInfo> list = new();
        GameInfo gameInfo = new()
        {
            TotalReward = context.WinAmount.AToM(context.CurrencyId) * context.IsWin,
            TotalMulti = context.TotalMultip * context.IsWin,
            RewardDetails = context.RewardDetails,
            SlotEles = context.SlotEleArray,
            Cost = context.Chips.BetAmount.AToM(context.CurrencyId),
            Date = DataTimeUTCToTimestamp(context.RecDate, false),
            Balance = context.BalanceAmount.AToM(context.CurrencyId),
            Transactionld = context.BetId.ToString(),
            TriggerSpecialMode = context.TriggerSM == 1,
            TriggerSpecialEffects = context.TriggerSE == 1,
            IsBigBonus = false,
        };
        decimal _balance = (context.BalanceAmountBefore - context.Chips.BetAmount).AToM(context.CurrencyId);
        int index = 0;
        foreach (var slotArr in context.BonusInfo)
        {
            long dateStamp = DataTimeUTCToTimestamp(DateTime.UtcNow, false);
            decimal cost = 0.0m;
            if (index == 0)
            {
                cost = context.Chips.BetAmount.AToM(context.CurrencyId);
            }
            list.Add(new GameInfo
            {
                TotalReward = 0.0m,
                TotalMulti = 0,
                RewardDetails = new(),
                SlotEles = slotArr,
                Cost = cost,
                Date = dateStamp,
                Balance = _balance,
                Transactionld = dateStamp.ToString(),
                TriggerSpecialMode = true,
                TriggerSpecialEffects = true,
                IsBigBonus = false,
            });
            index++;
        }
        list.Add(gameInfo);
        return list;
    }

}