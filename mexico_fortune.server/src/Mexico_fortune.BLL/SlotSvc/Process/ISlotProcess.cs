using Mexico_fortune.DAL;
using TinyFx.Data;
using TinyFx.SnowflakeId;
using TinyFx.Logging;

namespace Mexico_fortune.BLL
{
    internal interface ISlotProcess
    {
        Task Execute(SlotContext context);
    }
    internal abstract class SlotProcessBase : ISlotProcess
    {
        private Gmf_return_poolMO _returnPoolMo = new();
        private readonly All_pool_change_detailMO _poolChangeMo = new();
        private Gmf_user_chips_dataMO _userChipsDataMo = new();

        public abstract Task Execute(SlotContext context);

        protected async Task<bool> CheckReturnPool(SlotContext context, long changeAmount, SlotPartType partId)
        {
            var tm = new TransactionManager();
            try
            {
                var beforeAmount = (await _returnPoolMo.GetByPKAsync(context.OperatorId, context.CurrencyId, tm, true)).Value;
                var afterAmount = beforeAmount - changeAmount;
                if (afterAmount < 0)
                {
                    tm.Rollback();
                    return false;
                }
                await _returnPoolMo.PutValueByPKAsync(context.OperatorId, context.CurrencyId, afterAmount, tm);
                var set = string.Empty;
                switch (partId)
                {
                    case SlotPartType.Base:
                        set = $"BaseLock=BaseLock+{changeAmount}";
                        break;
                    case SlotPartType.Bonus:
                        set = $"BonusLock=BonusLock+{changeAmount}";
                        break;
                    case SlotPartType.Bingo:
                        set = $"BingoLock=BingoLock+{changeAmount}";
                        break;
                }
                await _userChipsDataMo.PutByPKAsync(context.UserId, context.ChipsId, set, tm);
                await _poolChangeMo.AddAsync(new All_pool_change_detailEO
                {
                    ChangeID = SnowflakeIdUtil.NextId(),
                    AppID = context.AppId,
                    OperatorID = context.OperatorId,
                    CurrencyID = context.CurrencyId,
                    BetID = context.SlotId,
                    UserID = context.UserId,
                    BeforeAmount = beforeAmount,
                    ChangeAmount = -changeAmount,
                    AfterAmount = afterAmount,
                    RecDate = DateTime.UtcNow,
                }, tm);
                tm.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                LogUtil.Error(ex, $"CheckReturnPool检查锁定奖金池时异常! userId:{context.UserId}");
                return false;
            }
        }
    }
}
