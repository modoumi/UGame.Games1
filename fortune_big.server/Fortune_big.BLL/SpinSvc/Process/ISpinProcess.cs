using Fortune_big.DAL;
using TinyFx.Data;
using TinyFx.Logging;
using TinyFx.SnowflakeId;

namespace Fortune_big.BLL
{
    internal interface ISpinProcess
    {
        Task Execute(SpinContext context);
    }

    internal abstract class BetProcessBase : ISpinProcess
    {
        private readonly Big_pool_returnMO _poolReturnMo = new();
        private readonly Slot_pool_change_detailMO _poolChangeMo = new();
        public abstract Task Execute(SpinContext context);

        protected async Task<bool> CheckPoolReturn(SpinContext context, long changeAmount)
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

                if (context.UserExt.Bonus >= context.Chips.BetAmount)
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
                else if (context.UserExt.Bonus == 0)
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
                    var moneyV = context.Chips.BetAmount - context.UserExt.Bonus;
                    var bonusRatio = (double)context.UserExt.Bonus / context.Chips.BetAmount;
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
    }
}
