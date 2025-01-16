using Fortune_big.BLL.Caching;
using Fortune_big.DAL;
using TinyFx.Data;
using TinyFx.SnowflakeId;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using Xxyy.GameEAPI.MQ;
using static Xxyy.GameEAPI.Core.GameEAPIUtil;
namespace Fortune_big.BLL;

public class SpinService : RootService
{
    private readonly Big_user_extMO _extMO = new();
    private readonly Big_spin_detailMO _betDetailMo = new();
    private readonly Big_pool_returnMO _poolReturnMo = new();
    private readonly Slot_pool_change_detailMO _poolChangeMo = new();
    public async Task<SpinDto> Spin(SpinIpo ipo)
    {
        await CheckIdentityAndMock(ipo.UserId);
        var context = new SpinContext(ipo)
        {
            BetId = SnowflakeIdUtil.NextId(),
            UserExt = await CheckUserExtAsync(ipo.UserId)
        };
        if (context.UserExt != null)
        {
            context.Config = MemoryUtil.GetConfig(context.UserExt.OperatorID, context.UserExt.CurrencyID);
            context.UserFlag = (int)context.UserExt.UserFlag % 2;
        }
        //算法逻辑
        await ExecuteContext(context);

        //先插入数据
        await Fortune_BigUtil.AddBetDetail(context, null);
        var tm = new TransactionManager();
        try
        {

            TimeSpan elapsedTime2 = await MeasureExecutionTime<SpinContext>(async () =>
            {
                //更新基础奖池,记录奖池变化log
                await PutPool(context, tm);
            });
            TimeSpan elapsedTime3 = await MeasureExecutionTime<SpinContext>(async () =>
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

                context.BalanceAmountAfter = context.UserExt.Balance + context.ChageBalance;
                //更新下注表
                await _betDetailMo.PutByPKAsync(context.BetId,
                  $"OrderStatus={(int)OrderStatus.Success},BalanceAmountAfter={context.BalanceAmountAfter},BetBonus={context.BetBonus},WinBonus={context.WinBonus}", tm);
            });
            TimeSpan elapsedTime4 = await MeasureExecutionTime<SpinContext>(async () =>
            {

                //更新用户数据
                await _extMO.PutByPKAsync(context.UserId, $"HistoryBetCount=HistoryBetCount+1,HistoryWinAmount=HistoryWinAmount+{context.RealWinAmount - context.Chips.BetAmount},Balance=Balance+{context.ChageBalance},Bonus=Bonus+{context.ChangeBonus}", tm);
            });

            TimeSpan elapsedTime = await MeasureExecutionTime<SpinContext>(async () =>
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

                /* var _account = (await BetWin(context.UserId, context.AppId, context.BetId.ToString()
                       , context.Chips.BetAmount, context.RealWinAmount));

                 context.BalanceAmountAfter = _account.Balance;
                 context.BetBonus = _account.BetBonus;
                 context.WinBonus = _account.WinBonus;*/
                context.IsChangeBalance = true;
            });
            Console.WriteLine($"{context.AppId} 发送MQ BetWin -> 耗时:{elapsedTime.Milliseconds}毫秒");
            Console.WriteLine($"{context.AppId} 更新基础奖池 PutPool -> 耗时:{elapsedTime2.Milliseconds}毫秒");
            Console.WriteLine($"{context.AppId} 更新下注表 Detail.PutByPKAsync -> 耗时:{elapsedTime3.Milliseconds}毫秒");
            Console.WriteLine($"{context.AppId} 更新用户数据 UserExt.PutByPKAsync-> 耗时:{elapsedTime4.Milliseconds}毫秒");
            tm.Commit();
        }
        catch (Exception ex)
        {
            tm.Rollback();
            await BetRollback(context, tm);
            throw;
        }
        return await BuildDto(context);
    }

    private async Task BetRollback(SpinContext context, TransactionManager tm)
    {
        var status = context.IsChangeBalance ? OrderStatus.Exception : OrderStatus.Fail;
        await _betDetailMo.PutOrderStatusByPKAsync(context.BetId, (int)status, tm);
    }

    private async Task ExecuteContext(SpinContext context)
    {
        await new SpinInitProcess().Execute(context);
        TimeSpan elapsedTime2 = await MeasureExecutionTime<SpinContext>(async () => await new SpinProcess().Execute(context));
        Console.WriteLine($"{context.AppId} 游戏内算法逻辑 BetProcess -> 耗时:{elapsedTime2.Milliseconds}毫秒");
    }
    public async Task PutPool(SpinContext context, TransactionManager tm)
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
    private async Task<SpinDto> BuildDto(SpinContext context)
    {
        var ret = new SpinDto();
        ret.PlayerInfo.Balance = context.BalanceAmountAfter.AToM(context.CurrencyId);
        ret.ResultInfo.TriggerFreeSpin = context.TriggerFreeSpin > 1 ? true : false;
        ret.ResultInfo.TriggerRespin = context.TriggerRespin > 1 ? true : false;
        ret.ResultInfo.TriggerEffect = context.TriggerSE > 0;

        ret.ResultInfo.GameInfo = new()
        {
            TotalReward = context.WinAmount.AToM(context.CurrencyId) * context.IsWin,
            TotalMultiple = context.TotalMultip * context.IsWin,
            RewardDetailList = context.RewardDetailList,
            SlotEleList = context.SlotEleList,
            Bet = context.Chips.BetAmount.AToM(context.CurrencyId),
            Date = DataTimeUTCToTimestamp(context.RecDate, false),
            Balance = context.BalanceAmountAfter.AToM(context.CurrencyId),
            Transactionld = context.BetId.ToString(),
            N = context.TriggerFreeSpin,
        };
        ret.ResultInfo.FreeSpinList = context.FreeSpinList;
        ret.ResultInfo.RespinList = context.RespinList;
        return ret;
    }
}