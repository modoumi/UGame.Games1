using Mexico_fortune.BLL.Caching;
using Mexico_fortune.DAL;
using TinyFx.Collections;
using Xxyy.GameEAPI.Common;

namespace Mexico_fortune.BLL
{
    internal class SlotQueryProcess : SlotProcessBase
    {
        private Gmf_itemMO _itemMo = new();
        public override async Task Execute(SlotContext context)
        {
            var bingoNum = context.BingoData.NewNums.Count;
            var bonusNum = context.BonusData.SymbolNum;
            var multip = context.BaseData.IsWin ? context.BaseData.Multip : 0;
            //
            var field = SlotItemDCache.GetField(multip, bonusNum, bingoNum);
            var ids = await SlotItemDCache.Create().GetOrLoadAsync(field);
            if (!ids.HasValue)
                throw new Exception($"SlotItemDCache没有数据. multip:{multip} bonusNum:{bonusNum} bingoNum:{bingoNum}");
            var idx = new Random().Next(ids.Value.Count);
            context.QueryData.ItemId = ids.Value[idx];
            //
            var details = await new Gmf_item_detailMO().GetByItemIDAsync(context.QueryData.ItemId);
            context.QueryData.SlotEles = new int[5, 3];
            for (int i = 0; i < 3; i++)
            {
                var item = details[i];
                context.QueryData.SlotEles[0, i] = item.S1;
                context.QueryData.SlotEles[1, i] = item.S2;
                context.QueryData.SlotEles[2, i] = item.S3;
                context.QueryData.SlotEles[3, i] = item.S4;
                context.QueryData.SlotEles[4, i] = item.S5;
            }
            // retrigger
            if (context.IsFreeSpin && bonusNum > 0)
            {
                foreach (var item in context.QueryData.SlotEles.EnumerateTwoD())
                {
                    if (item.value == 10)
                    {
                        // freespin把BONUS图标10换成12
                        context.QueryData.SlotEles[item.point.X, item.point.Y] = 12;
                        break;
                    }
                }
            }
            //
            var rewardLines = await new Gmf_item_lineMO().GetByItemIDAsync(context.QueryData.ItemId);
            if (rewardLines != null)
            {
                foreach (var line in rewardLines)
                {
                    var rewardAmount = context.BetAmount * line.Multip / 50 / 10;
                    context.QueryData.TotalAmount += rewardAmount;
                    context.QueryData.RewardDetails.Add(new SlotRewardDetail
                    {
                        Line = line.LineId,
                        RewardAmount = rewardAmount,
                        Reward = (double)XxyyUtil.AToM(rewardAmount, context.CurrencyId),
                        SameUnitCount = line.HitNum,
                        Multi = line.Multip / 10
                    });
                }
            }
            context.QueryData.TotalReward = context.QueryData.TotalAmount.AToM(context.CurrencyId);
        }
    }
}
