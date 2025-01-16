using Mexico_fortune.BLL.Caching;
using TinyFx.Randoms;

namespace Mexico_fortune.BLL
{
    internal class SlotBonusProcess : SlotProcessBase
    {
        public override async Task Execute(SlotContext context)
        {
            if (!context.IsFreeSpin)
                await ExecBonus(context);
            else
                await ExecRetrigger(context);
        }
        private async Task ExecBonus(SlotContext context)
        {
            var config = GmfDBCacheUtil.GetConfig();
            var bonusData = context.BonusData;
            var userDataDo = context.UserDataDo;

            var outTH = (int)(userDataDo.BonusTotal + context.PartAmount.PartBonusAmount
                - (config.BonusTH * context.BetAmount));
            bonusData.IsOutTH = outTH >= 0;
            var hasBonus = await context.UserSvc.GetBonus() > 0;
            if (bonusData.IsOutTH && !hasBonus)
            {
                userDataDo.BonusTotal = outTH;
                var weightEo = GmfDBCacheUtil.GetBonusWeight();
                bonusData.IsWin = weightEo.SymbolNum >= 3;
                if (bonusData.IsWin)
                {
                    bonusData.WinAmount = weightEo.Multip * context.BetAmount / 10;
                    bonusData.IsWin = await CheckReturnPool(context, bonusData.WinAmount, SlotPartType.Bonus);
                    if (bonusData.IsWin)
                    {
                        bonusData.SymbolNum = weightEo.SymbolNum;
                        bonusData.Multip = weightEo.Multip;
                    }
                }
            }
            else
            {
                userDataDo.BonusTotal += context.PartAmount.PartBonusAmount;
            }

            if (bonusData.IsWin)
            {
                var partAmount = (bonusData.Multip / 10 - 10) * context.BetAmount;
                if (partAmount > 0)
                {
                    userDataDo.BingoTotal += (int)(partAmount * config.BonusBigoRatio);
                    userDataDo.FreeSpinNum = 10;
                    var retraggerTimes = (int)(partAmount * config.BonusRetriggerRatio / context.BetAmount);
                    for (int i = 0; i < retraggerTimes; i++)
                        userDataDo.RetriggerNum += GmfDBCacheUtil.GetRetriggerWeightRandom().Next().RetriggerNum;
                    userDataDo.BonusTotal += (long)((10 + userDataDo.RetriggerNum) * config.BonusRetriggerRatio * context.BetAmount);
                    userDataDo.RetriggerList = GetRetriggerList(userDataDo.RetriggerNum);
                }
            }
        }
        private Task ExecRetrigger(SlotContext context)
        {
            context.UserDataDo.FreeSpinNum -= 1;
            context.BonusData.NewRetriggerNum = context.UserDataDo.RetriggerList.First();
            if (context.BonusData.NewRetriggerNum > 0)
            {
                context.BonusData.SymbolNum = 1;
                context.UserDataDo.FreeSpinNum += context.BonusData.NewRetriggerNum;
            }
            context.UserDataDo.RetriggerList.RemoveAt(0);
            return Task.CompletedTask;
        }
        private List<int> GetRetriggerList(int retriggerSum)
        {
            var ret = new List<int>();
            var freeSpin = 10;
            var retriggerList = new List<int>();
            var retriggerCount = 0;
            while (true)
            {
                var lastNum = retriggerCount - retriggerSum + 3;
                if (lastNum > 0)
                {
                    retriggerList.Add(retriggerSum - retriggerCount);
                    break;
                }
                var rndValue = RandomUtil.NextInt(3) + 1;
                retriggerCount += rndValue;
                retriggerList.Add(rndValue);
            }
            var count = retriggerList.Count;
            for (int i = 0; i < retriggerSum + freeSpin - count; i++)
                retriggerList.Add(0);

            var currNum = freeSpin;
            for (int i = 0; i < retriggerSum + freeSpin - 1; i++)
            {
                currNum--;
                var idx = new Random().Next(retriggerList.Count);
                if (retriggerList[idx] + currNum == 0)
                {
                    for (int j = 0; j < retriggerList.Count; i++)
                    {
                        if (retriggerList[j] > 0)
                        {
                            idx = j;
                            break;
                        }
                    }
                }
                currNum += retriggerList[idx];
                ret.Add(retriggerList[idx]);
                retriggerList.RemoveAt(idx);
            }
            ret.Add(0);
            return ret;
        }
    }
}
