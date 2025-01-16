using Fortune_tiger.DAL;
using TinyFx;
using TinyFx.Data;
using TinyFx.SnowflakeId;
using TinyFx.Logging;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using Xxyy.GameEAPI.MQ;
using static Xxyy.GameEAPI.Core.GameEAPIUtil;
namespace Fortune_tiger.BLL;

public class BetService : RootService
{
    private readonly Slot_bet_detailMO _betDetailMo = new();
    private readonly Slot_pool_returnMO _poolReturnMo = new();
    private readonly Slot_pool_change_detailMO _poolChangeMo = new();
    private readonly Slot_user_extMO _extMO = new();
    public async Task<BetDto> Bet(BetIpo ipo)
    {
        await CheckIdentityAndMock(ipo.UserId);
        var context = new BetContext(ipo, await CheckUserExtAsync(ipo.UserId));

        var betId = context.BetId = SnowflakeIdUtil.NextId();
        //算法逻辑
        await ExecuteContext(context);
        //先插入数据
        await FortuneUtil.AddBetDetail(context, betId, null);
        var tm = new TransactionManager();
        try
        {
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
            TimeSpan elapsedTime4 = await MeasureExecutionTime<BetContext>(async () =>
            {
                if (context.UserExt.Bonus >= context.Chips.BetAmount)
                {
                    context.BetBonus = context.Chips.BetAmount;
                    context.WinBonus = context.RealWinAmount;
                }
                else if (context.UserExt.Bonus <= 0)
                {
                    context.UserExt.Bonus = 0;
                    context.BetBonus = 0;
                    context.WinBonus = 0;
                }
                else
                {
                    double pct = (double)context.BetBonus / context.Chips.BetAmount;
                    context.BetBonus = (long)(context.Chips.BetAmount * pct);
                    context.WinBonus = (long)(context.RealWinAmount * pct);
                }
                context.ChageBalance = context.RealWinAmount - context.Chips.BetAmount;
                context.ChangeBonus = context.WinBonus - context.BetBonus;

                context.BalanceAmount = context.UserExt.Balance + context.ChageBalance;
                //更新用户数据
                await _extMO.PutByPKAsync(context.UserId, $"HistoryBetCount=HistoryBetCount+1,HistoryWinAmount=HistoryWinAmount+{context.RealWinAmount - context.Chips.BetAmount},Balance=Balance+{context.ChageBalance},Bonus=Bonus+{context.ChangeBonus}", tm);
            });
            TimeSpan elapsedTime = await MeasureExecutionTime<BetContext>(async () =>
            {
                await SendMQAsync(new GameBalanceMsg
                {
                    Bet = context.Chips.BetAmount,
                    BetBonus = context.BetBonus,
                    Win = context.RealWinAmount,
                    WinBonus = context.WinBonus,
                    UserId = context.UserId,
                    Balance = context.UserExt.Balance + context.ChageBalance,
                    Bonus = context.UserExt.Bonus + context.ChangeBonus,
                    AppId = context.UserExt.AppID,
                    BetId = context.BetId
                });

                context.IsChangeBalance = true;
            });
            Console.WriteLine($"{context.AppId} 发送MQ BetWin -> 耗时:{elapsedTime.Milliseconds} ms");
            Console.WriteLine($"{context.AppId} 更新基础奖池 PutPool -> 耗时:{elapsedTime2.Milliseconds} ms");
            Console.WriteLine($"{context.AppId} 更新下注表 PutByPKAsync -> 耗时:{elapsedTime3.Milliseconds} ms");
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
        await new BetInitProcess().Execute(context);
        TimeSpan elapsedTime2 = await MeasureExecutionTime<BetContext>(async () => await new BetProcess().Execute(context));
        Console.WriteLine($"{context.AppId} 游戏内算法逻辑 BetProcess -> 耗时:{elapsedTime2.Milliseconds} ms");
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

        ret.ResultInfo.GameInfo.TotalReward = context.WinAmount.AToM(context.CurrencyId) * context.IsWin;
        ret.ResultInfo.GameInfo.TotalMulti = context.TotalMultip * context.IsWin;
        ret.ResultInfo.GameInfo.RewardDetails = context.RewardDetails;
        ret.ResultInfo.GameInfo.SlotEles = context.SlotEleArray;
        ret.ResultInfo.GameInfo.WildNum = context.WildNum;
        ret.ResultInfo.GameInfo.Cost = context.Chips.BetAmount.AToM(context.CurrencyId);
        ret.ResultInfo.GameInfo.Date = DataTimeUTCToTimestamp(DateTime.UtcNow, false);
        ret.ResultInfo.GameInfo.Balance = context.BalanceAmount.AToM(context.CurrencyId);

        ret.ResultInfo.ExtraInfo.IsTrigerBonus = (context.TriggerSM == 1 && context.TriggerSE == 1);
        ret.ResultInfo.ExtraInfo.IsBonus = (context.TriggerMaxMultip == 10 && context.IsWin == 1 && context.TriggerSM == 1);
        ret.ResultInfo.ExtraInfo.BonusInfo = context.BonusInfo;
        ret.ResultInfo.ExtraInfo.BonousItemId = context.BonusItemId;

        LogUtil.Debug($"RewardDetails:  {SerializerUtil.SerializeJsonNet(context.RewardDetails)}");
        LogUtil.Debug($"SlotEles:  {SerializerUtil.SerializeJsonNet(context.SlotEleArray)}");
        LogUtil.Debug($"BonusInfo:  {SerializerUtil.SerializeJsonNet(context.BonusInfo)}");
        return ret;
    }

}