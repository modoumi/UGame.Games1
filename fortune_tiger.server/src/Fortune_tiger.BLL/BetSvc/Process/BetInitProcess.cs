using Fortune_tiger.BLL.Caching;
using TinyFx;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;

namespace Fortune_tiger.BLL
{
    internal class BetInitProcess : IBetProcess
    {
        public async Task Execute(BetContext context)
        {
            context.BonusAmount = context.UserExt.Bonus;
            if (context.UserExt.Balance < context.Chips.BetAmount)
            {
                throw new CustomException(CommonCodes.RS_NOT_ENOUGH_MONEY, "余额不足");
            }

            context.Tag = MemoryUtil.GetTagByAmount(context.Chips.BetAmount);
            var config = context.Config;
            //奖池增加金额比例
            var poolRatio = 1 - config.IncomeRatio;
            if (poolRatio < 0)
            {
                throw new Exception("IncomeRatio配置不能大于1");
            }
            var partAmount = context.PartAmount;
            //bonus大于下注的钱
            if (context.UserExt.Bonus >= context.Chips.BetAmount)
            {
                partAmount.PartBonusAmount = (long)(poolRatio * context.Chips.BetAmount);
                partAmount.PartMoneyAmount = 0;
            }
            else if (context.UserExt.Bonus == 0)
            {
                partAmount.PartBonusAmount = 0;
                partAmount.PartMoneyAmount = (long)(poolRatio * context.Chips.BetAmount);
            }
            else
            {
                var moneyV = context.Chips.BetAmount - context.UserExt.Bonus;
                var bonusRatio = (double)context.UserExt.Bonus / context.Chips.BetAmount;
                var moneyRatio = (double)moneyV / context.Chips.BetAmount;

                partAmount.PartBonusAmount = (long)(context.Chips.BetAmount * bonusRatio * poolRatio);
                partAmount.PartMoneyAmount = (long)(context.Chips.BetAmount * moneyRatio * poolRatio);
            }

            await Task.CompletedTask;
        }
    }


}