using Fortune_mouse.BLL.Caching;
using TinyFx;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;
using Xxyy.Partners.Model;

namespace Fortune_mouse.BLL
{
    internal class BetInitProcess : IBetProcess
    {
        public async Task Execute(BetContext context)
        {
            var Account = await GameEAPIUtil.GetAccount(context.UserId, context.AppId);
            if (Account == null)
            {
                throw new CustomException(CommonCodes.ACCOUNT_NULL, "调用用户余额接口返回异常, _operatorClient.Balance返回  IS NULL");
            }
            InitConfig(context, Account);

            await Task.CompletedTask;
        }

        public static void InitConfig(BetContext context, BalanceDto Account)
        {
            context.BalanceAmountBefore = Account.Balance;
            context.BonusAmount = Account.Bonus;
            if (context.BalanceAmountBefore < context.Chips.BetAmount)
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
            if (Account.Bonus >= context.Chips.BetAmount)
            {
                partAmount.PartBonusAmount = (long)(poolRatio * context.Chips.BetAmount);
                partAmount.PartMoneyAmount = 0;
            }
            else if (Account.Bonus == 0)
            {
                partAmount.PartBonusAmount = 0;
                partAmount.PartMoneyAmount = (long)(poolRatio * context.Chips.BetAmount);
            }
            else
            {
                var moneyV = context.Chips.BetAmount - Account.Bonus;
                var bonusRatio = (double)Account.Bonus / context.Chips.BetAmount;
                var moneyRatio = (double)moneyV / context.Chips.BetAmount;

                partAmount.PartBonusAmount = (long)(context.Chips.BetAmount * bonusRatio * poolRatio);
                partAmount.PartMoneyAmount = (long)(context.Chips.BetAmount * moneyRatio * poolRatio);
            }
        }
    }


}