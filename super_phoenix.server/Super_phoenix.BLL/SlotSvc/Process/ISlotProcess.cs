using Super_phoenix.DAL;
using TinyFx.Data;
using TinyFx.Logging;

namespace Super_phoenix.BLL
{
    internal interface ISlotProcess
    {
        Task Execute(SlotContext context);
    }

    internal abstract class SlotProcessBase : ISlotProcess
    {
        private Gsp_pool_returnMO _poolReturnMo = new();
        public abstract Task Execute(SlotContext context);

        protected async Task<bool> CheckPoolReturn(SlotContext context, long winAmount)
        {
            var tm = new TransactionManager();
            try
            {
                var poolValue = (await _poolReturnMo.GetByPKAsync(context.OperatorId, context.CurrencyId, tm, true)).PoolVal;
                if (poolValue - winAmount < 0)
                {
                    tm.Rollback();
                    return false;
                }
                await _poolReturnMo.PutPoolValByPKAsync(context.OperatorId, context.CurrencyId, poolValue - winAmount, tm);

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
