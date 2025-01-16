using Fortune_big.BLL.Caching;
using Fortune_big.DAL;
using TinyFx;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;
using Xxyy.Partners.Model;

namespace Fortune_big.BLL
{
    internal class SpinInitProcess : ISpinProcess
    {
        private readonly Big_user_extMO _extMO = new();


        public async Task Execute(SpinContext context)
        {
            context.BalanceAmountBefore = context.UserExt.Balance;
            if (context.BalanceAmountBefore < context.Chips.BetAmount)
            {
                var _Account = await GameEAPIUtil.GetAccount(context.UserId, context.AppId);

                if (_Account != null)
                {
                    context.BalanceAmountBefore = _Account.Balance;
                    context.UserExt.Balance = _Account.Balance;
                    context.UserExt.Bonus = _Account.Bonus;
                    await _extMO.PutByPKAsync(context.UserId, $"Balance={_Account.Balance},Bonus={_Account.Bonus}");
                    if (_Account.Balance < context.Chips.BetAmount)
                    {
                        throw new CustomException(CommonCodes.RS_NOT_ENOUGH_MONEY, "余额不足");
                    }
                }
            }
            context.Tag = MemoryUtil.GetTagByAmount(context.Chips.BetAmount);
            //奖池增加金额比例
            var poolRatio = 1 - context.Config.IncomeRatio;
            if (poolRatio < 0)
            {
                throw new CustomException(CommonCodes.CONFIG_ERROR, "IncomeRatio配置不能大于1");
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
        public async static void InitConfig(SpinContext context, BalanceDto _Account)
        {
            context.BalanceAmountBefore = context.UserExt.Balance;

            if (_Account != null)
            {
                context.BalanceAmountBefore = _Account.Balance;
                context.UserExt.Balance = _Account.Balance;
                context.UserExt.Bonus = _Account.Bonus;
            }
            context.Tag = MemoryUtil.GetTagByAmount(context.Chips.BetAmount);
            //奖池增加金额比例
            var poolRatio = 1 - context.Config.IncomeRatio;
            if (poolRatio < 0)
            {
                throw new CustomException(CommonCodes.CONFIG_ERROR, "IncomeRatio配置不能大于1");
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
        }

    }
}