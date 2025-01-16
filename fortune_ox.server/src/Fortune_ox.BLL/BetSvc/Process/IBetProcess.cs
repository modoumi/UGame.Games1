using Fortune_ox.DAL;
using TinyFx.Data;
using TinyFx.SnowflakeId;
using TinyFx.Logging;

namespace Fortune_ox.BLL
{
    internal interface IBetProcess
    {
        Task Execute(BetContext context);
    }

    internal abstract class BetProcessBase : IBetProcess
    {
        private readonly Fox_pool_returnMO _poolReturnMo = new();
        private readonly Slot_pool_change_detailMO _poolChangeMo = new();
        public abstract Task Execute(BetContext context);



        protected async Task<bool> CheckPoolReturn(BetContext context, long changeAmount)
        {
            var tm = new TransactionManager();
            try
            {
                var _poolEo = await _poolReturnMo.GetByPKAsync(context.OperatorId, context.CurrencyId, tm, true);
                var poolBeforeVal = _poolEo.PoolVal;
                var bonusBeforeVal = _poolEo.BonusVal;

                long poolChangeVal;
                long bonusChangeVal;

                long poolAfterVal;
                long bonusAfterVal;

                if (context.BonusAmount >= context.Chips.BetAmount)
                {
                    poolChangeVal = 0;
                    bonusChangeVal = changeAmount;
                    poolAfterVal = poolBeforeVal - poolChangeVal;
                    bonusAfterVal = bonusBeforeVal - bonusChangeVal;
                    if (bonusAfterVal < 0)
                    {
                        tm.Rollback();
                        return false;
                    }
                    await _poolReturnMo.PutBonusValByPKAsync(context.OperatorId, context.CurrencyId, bonusAfterVal, tm);
                }
                else if (context.BonusAmount == 0)
                {
                    poolChangeVal = changeAmount;
                    bonusChangeVal = 0;
                    poolAfterVal = poolBeforeVal - changeAmount;
                    bonusAfterVal = bonusBeforeVal - bonusChangeVal;
                    if (poolAfterVal < 0)
                    {
                        tm.Rollback();
                        return false;
                    }
                    await _poolReturnMo.PutPoolValByPKAsync(context.OperatorId, context.CurrencyId, poolAfterVal, tm);
                }
                else//bonus 不够下注
                {
                    var moneyV = context.Chips.BetAmount - context.BonusAmount;
                    var bonusRatio = (double)context.BonusAmount / context.Chips.BetAmount;
                    var moneyRatio = (double)moneyV / context.Chips.BetAmount;

                    bonusChangeVal = (long)(changeAmount * bonusRatio);
                    poolChangeVal = (long)(changeAmount * moneyRatio);

                    bonusAfterVal = bonusBeforeVal - bonusChangeVal;
                    if (bonusAfterVal < 0)
                    {
                        tm.Rollback();
                        return false;
                    }
                    await _poolReturnMo.PutBonusValByPKAsync(context.OperatorId, context.CurrencyId, bonusAfterVal, tm);

                    poolAfterVal = poolBeforeVal - poolChangeVal;
                    if (poolAfterVal < 0)
                    {
                        tm.Rollback();
                        return false;
                    }
                    await _poolReturnMo.PutPoolValByPKAsync(context.OperatorId, context.CurrencyId, poolAfterVal, tm);
                }
                //奖池变化日志
                await _poolChangeMo.AddAsync(new Slot_pool_change_detailEO
                {
                    ChangeID = SnowflakeIdUtil.NextId(),
                    AppID = context.AppId,
                    OperatorID = context.OperatorId,
                    CurrencyID = context.CurrencyId,
                    BetID = context.BetId,
                    UserID = context.UserId,
                    BeforeAmount = poolBeforeVal,
                    ChangeAmount = -poolChangeVal,
                    AfterAmount = poolAfterVal,
                    BeforeBonus = bonusBeforeVal,
                    ChangeBonus = -bonusChangeVal,
                    AfterBonus = bonusAfterVal,
                    RecDate = DateTime.UtcNow,
                }, tm);

                tm.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                LogUtil.Error(ex, $"CheckPoolReturn检查锁定奖金池时异常! userId:{context.UserId}");
                return false;
            }
        }
        /*
        protected async Task<bool> CheckPoolReturn(BetContext context, long winAmount)
        {
            var tm = new TransactionManager();
            try
            {
                var _poolEo = await _poolReturnMo.GetByPKAsync(context.OperatorId, context.CurrencyId, tm, true);
                var poolValue = _poolEo.PoolVal;
                var bonusVal = _poolEo.BonusVal;
                LogUtil.Info($"奖池:{poolValue},winAmount: {winAmount},poolValue - winAmount:{poolValue - winAmount}");
                if (context.BonusAmount >= context.Chips.BetAmount)
                {
                    var bonusV = bonusVal - winAmount;
                    if (bonusV < 0)
                    {
                        tm.Rollback();
                        return false;
                    }
                    await _poolReturnMo.PutBonusValByPKAsync(context.OperatorId, context.CurrencyId, bonusV, tm);
                }
                else if (context.BonusAmount == 0)
                {
                    var poolV = poolValue - winAmount;
                    if (poolV < 0)
                    {
                        tm.Rollback();
                        return false;
                    }
                    await _poolReturnMo.PutPoolValByPKAsync(context.OperatorId, context.CurrencyId, poolV, tm);
                }
                else//bonus 不够下注
                {
                    var moneyV = context.Chips.BetAmount - context.BonusAmount;
                    var bonusRatio = (double)context.BonusAmount / context.Chips.BetAmount;
                    var moneyRatio = (double)moneyV / context.Chips.BetAmount;

                    var bonusWinAmount = (long)(winAmount * bonusRatio);
                    var moneyWinAmount = (long)(winAmount * moneyRatio);

                    var bonusV = bonusVal - bonusWinAmount;
                    if (bonusV < 0)
                    {
                        tm.Rollback();
                        return false;
                    }
                    await _poolReturnMo.PutBonusValByPKAsync(context.OperatorId, context.CurrencyId, bonusV, tm);

                    var poolV = poolValue - moneyWinAmount;
                    if (poolV < 0)
                    {
                        tm.Rollback();
                        return false;
                    }
                    await _poolReturnMo.PutPoolValByPKAsync(context.OperatorId, context.CurrencyId, poolV, tm);
                }

                tm.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                LogUtil.Error(ex, $"CheckPoolReturn检查锁定奖金池时异常! userId:{context.UserId}");
                return false;
            }
        }*/
    }
}
