namespace Super_phoenix.BLL
{
    internal class SlotInitProcess : ISlotProcess
    {
        public Task Execute(SlotContext context)
        {
            var config = context.Config;
            var partAmount = context.PartAmount;
            partAmount.PartIncomeAmount = (long)(config.IncomeRatio * context.Config_Chips.BetAmount);
            partAmount.PartMiniGameTotalVal = (long)(config.MiniGameRatio * context.Config_Chips.BetAmount);
            partAmount.PartBaseAmount = context.Config_Chips.BetAmount - partAmount.PartIncomeAmount;
            if (partAmount.PartBaseAmount < 0)
            {
                throw new Exception("配置PartBaseRatio等数据异常");
            }
            return Task.CompletedTask;
        }
    }


}