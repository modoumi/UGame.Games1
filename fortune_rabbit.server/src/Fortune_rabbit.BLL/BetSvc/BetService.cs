using Fortune_rabbit.DAL;
using TinyFx;
using TinyFx.Data;
using TinyFx.SnowflakeId;
using TinyFx.Logging;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using static Xxyy.GameEAPI.Core.GameEAPIUtil;
namespace Fortune_rabbit.BLL;

public class BetService : RootService
{
    private readonly Fra_user_extMO _extMO = new();
    private readonly Fra_bet_detailMO _betDetailMo = new();
    private readonly Fra_pool_returnMO _poolReturnMo = new();
    private readonly Slot_pool_change_detailMO _poolChangeMo = new();
    public async Task<BetDto> Bet(BetIpo ipo)
    {
        await CheckIdentityAndMock(ipo.UserId);
        var context = new BetContext(ipo, await CheckUserExtAsync(ipo.UserId));

        var betId = context.BetId = SnowflakeIdUtil.NextId();
        context.GroupId = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff");
        //算法逻辑
        await ExecuteContext(context);
        //先插入数据
        await FortuneUtil.AddBetDetail(context, null);
        var tm = new TransactionManager();
        try
        {
            //调用下注接口
            TimeSpan elapsedTime = await MeasureExecutionTime<BetContext>(async () =>
            {
                context.BalanceAmountAfter = (await BetWin(context.UserId, context.AppId, context.BetId.ToString()
                          , context.Chips.BetAmount, context.RealWinAmount)).Balance;
            });
            context.IsChangeBalance = true;
            TimeSpan elapsedTime2 = await MeasureExecutionTime<BetContext>(async () =>
            {
                //更新基础奖池
                await PutPool(context, tm);
            });
            TimeSpan elapsedTime3 = await MeasureExecutionTime<BetContext>(async () =>
            {
                //更新下注表
                await _betDetailMo.PutByPKAsync(betId,
                  $"OrderStatus={(int)OrderStatus.Success},BalanceAmountAfter={context.BalanceAmountAfter}", tm);
            });
            TimeSpan elapsedTime4 = await MeasureExecutionTime<BetContext>(async () =>
            {
                //更新用户数据
                await _extMO.PutByPKAsync(context.UserId, $"HistoryBetCount=HistoryBetCount+1,HistoryWinAmount=HistoryWinAmount+{context.RealWinAmount - context.Chips.BetAmount}", tm);
            });
            Console.WriteLine($"调用下注接口 BetWin -> 耗时:{elapsedTime.Milliseconds}毫秒");
            Console.WriteLine($"更新基础奖池 PutPool -> 耗时:{elapsedTime2.Milliseconds}毫秒");
            Console.WriteLine($"更新下注表 PutByPKAsync -> 耗时:{elapsedTime3.Milliseconds}毫秒");
            Console.WriteLine($"更新用户数据 PutByPKAsync-> 耗时:{elapsedTime4.Milliseconds}毫秒");
            tm.Commit();
        }
        catch
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
        Console.WriteLine($"调用用户余额 _operatorClient.Balance -> 耗时:{elapsedTime.Milliseconds}毫秒");
        Console.WriteLine($"游戏内算法逻辑 BetProcess -> 耗时:{elapsedTime2.Milliseconds}毫秒");
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
        ret.PlayerInfo.Balance = context.BalanceAmountAfter.AToM(context.CurrencyId);
        ret.ResultInfo.GameInfoList = BuildGameInfoList(context);
        return ret;
    }

    public static List<GameInfo> BuildGameInfoList(BetContext context)
    {
        List<GameInfo> list = new();
        if (context.TriggerSM == 0 || (context.TriggerSM == 1 && context.RealWinAmount == 0L))
        {
            list.Add(new()
            {
                TotalReward = context.WinAmount.AToM(context.CurrencyId) * context.IsWin,
                TotalMulti = context.TotalMultip * context.IsWin,
                RewardDetails = context.RewardDetails,
                SlotEles = context.SlotEleArray,
                Cost = context.Chips.BetAmount.AToM(context.CurrencyId),
                Date = DataTimeUTCToTimestamp(context.RecDate, false),
                Balance = context.BalanceAmountAfter.AToM(context.CurrencyId),
                Transactionld = context.BetId.ToString(),
                TriggerSpecialEffects = context.TriggerSE == 1,
            });
        }
        else
        {
            list = context.BonusDetailList;
        }
        return list;
    }
}