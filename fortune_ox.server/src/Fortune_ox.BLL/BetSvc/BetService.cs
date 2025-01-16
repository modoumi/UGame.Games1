using Fortune_ox.DAL;
using TinyFx;
using TinyFx.Data;
using TinyFx.SnowflakeId;
using TinyFx.Logging;
using TinyFx.SnowflakeId;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using static Xxyy.GameEAPI.Core.GameEAPIUtil;
namespace Fortune_ox.BLL;

public class BetService : RootService
{
    private readonly Fox_bet_detailMO _betDetailMo = new();
    private readonly Fox_pool_returnMO _poolReturnMo = new();
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
            TimeSpan elapsedTime = await MeasureExecutionTime<BetContext>(async () =>
            {
                var _account = (await BetWin(context.UserId, context.AppId, betId.ToString()
                      , context.Chips.BetAmount, context.RealWinAmount));
                context.BalanceAmountAfter = _account.Balance;
                context.BetBonus = _account.BetBonus;
                context.WinBonus = _account.WinBonus;
                context.IsChangeBalance = true;
            });

            TimeSpan elapsedTime2 = await MeasureExecutionTime<BetContext>(async () =>
            {
                //更新基础奖池
                await PutPool(context, tm);
            });

            TimeSpan elapsedTime3 = await MeasureExecutionTime<BetContext>(async () =>
            {
                //更新下注表
                await _betDetailMo.PutByPKAsync(betId,
                  $"OrderStatus={(int)OrderStatus.Success},BalanceAmountAfter={context.BalanceAmountAfter},BetBonus={context.BetBonus},WinBonus={context.WinBonus}", tm);
            });
            Console.WriteLine($"{context.AppId} 调用下注接口 BetWin -> 耗时:{elapsedTime.Milliseconds} ms");
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
        TimeSpan elapsedTime = await MeasureExecutionTime<BetContext>(async () => await new BetInitProcess().Execute(context));
        TimeSpan elapsedTime2 = await MeasureExecutionTime<BetContext>(async () => await new BetProcess().Execute(context));
        Console.WriteLine($"{context.AppId} 调用用户余额 _operatorClient.Balance -> 耗时:{elapsedTime.Milliseconds} ms");
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
        ret.PlayerInfo.Balance = context.BalanceAmountAfter.AToM(context.CurrencyId);

        ret.ResultInfo.GameInfoList = BuildGameInfoList(context);

        LogUtil.Info($"RewardDetails:  {SerializerUtil.SerializeJsonNet(context.RewardDetails)}");
        LogUtil.Info($"SlotEles:  {SerializerUtil.SerializeJsonNet(context.SlotEleArray)}");
        LogUtil.Info($"BonusInfo:  {SerializerUtil.SerializeJsonNet(context.BonusInfo)}");
        return ret;
    }

    public List<GameInfo> BuildGameInfoList(BetContext context)
    {
        List<GameInfo> list = new();

        GameInfo gameInfo = new()
        {
            TotalReward = context.WinAmount.AToM(context.CurrencyId) * context.IsWin,
            TotalMulti = context.TotalMultip * context.IsWin,
            RewardDetails = context.RewardDetails,
            SlotEles = context.SlotEleArray,
            Cost = context.BonusInfo.Count == 0 ? context.Chips.BetAmount.AToM(context.CurrencyId) : 0.0m,
            Date = DataTimeUTCToTimestamp(context.RecDate, false),
            Balance = context.BalanceAmountAfter.AToM(context.CurrencyId),
            Transactionld = context.BetId.ToString(),
            IsTrigerBonus = context.TriggerSM == 1,
            IsBonus = context.TriggerSE == 1,
            IsBigBonus = context.TriggerMaxMultip == 10,
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
                IsTrigerBonus = true,
                IsBonus = true,
                IsBigBonus = false,
            });
            index++;
        }
        list.Add(gameInfo);
        return list;
    }
}