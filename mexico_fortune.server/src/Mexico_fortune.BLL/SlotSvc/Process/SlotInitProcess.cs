using Mexico_fortune.BLL.Caching;

namespace Mexico_fortune.BLL
{
    internal class SlotInitProcess : ISlotProcess
    {
        public Task Execute(SlotContext context)
        {
            if (!context.IsFreeSpin)
            {
                // PartAmount
                var config = GmfDBCacheUtil.GetConfig();
                var partAmount = context.PartAmount;
                partAmount.PartBaseAmount = (int)(config.PartBaseRatio * context.BetAmount);
                partAmount.PartBonusAmount = (int)(config.PartBonusRatio * context.BetAmount);
                partAmount.PartBingoAmount = (int)(config.PartBingoRatio * context.BetAmount);
                partAmount.PartPoolAmount = partAmount.PartBaseAmount + partAmount.PartBonusAmount + partAmount.PartBingoAmount;
                partAmount.PartIncomeAmount = context.BetAmount - partAmount.PartPoolAmount;
                if (partAmount.PartIncomeAmount < 0)
                    throw new Exception("配置PartBaseRatio等数据异常");
                //
                context.UserDataDo.FreeSpinNum = 0;
                context.UserDataDo.RetriggerNum = 0;
                context.UserDataDo.FreeSpinAmount = 0;
                context.UserDataDo.RetriggerList = new();
            }
            return Task.CompletedTask;
        }
    }
}
