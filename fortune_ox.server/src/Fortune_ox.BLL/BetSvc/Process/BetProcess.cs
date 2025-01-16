using Fortune_ox.BLL.Caching;
using Fortune_ox.DAL;
using MathNet.Numerics.Random;
using TinyFx;
using TinyFx.Logging;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;
using static Fortune_ox.BLL.FortuneUtil;

namespace Fortune_ox.BLL
{
    internal class BetProcess : BetProcessBase
    {
        public override async Task Execute(BetContext context)
        {
            RandomSource randomSource = new MersenneTwister(); // 使用 Mersenne Twister 随机数生成器
            double randomNumber = randomSource.NextDouble(); // 生成一个介于 0 到 1 之间的随机数

            if (randomNumber < context.Tag.SpecialModeRatio) //进入福牛模式 
            {
                context.TriggerSM = 1;
            }
            else//主轴下注
            {
                context.TriggerSM = 0;
            }
            await GetIconByWeight(context);
        }

        public async Task GetIconByWeight(BetContext context)
        {
            //行 x 列
            var tableList = BuildItemTable(context);
            List<List<int>> hitLineList = BuildIconInLine(context, tableList);
            List<int> totalMultip = new();
            int lineNo = 1;
            //hitLineList.count 代表中了几条线
            foreach (var ItemIdList in hitLineList)
            {
                //ItemIdList是线上的元素id
                List<int> itemIdResult = new();
                for (int i = 0; i < ItemIdList.Count; i++)//ItemIdList中奖线中的itemId
                {
                    var _itemId = ItemIdList[i];
                    if (i == 0)
                    {
                        itemIdResult.Add(_itemId);
                    }
                    else
                    {
                        if (_itemId == WILD)
                        {
                            itemIdResult.Add(_itemId);
                        }
                        else
                        {
                            if (itemIdResult.First() == WILD)
                            {
                                itemIdResult[0] = _itemId;
                                itemIdResult.Add(_itemId);
                            }
                            else if (itemIdResult.Contains(_itemId))
                            {
                                itemIdResult.Add(_itemId);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                //中奖
                if (itemIdResult.Count >= 3)
                {
                    var itemId = itemIdResult.FirstOrDefault();
                    var multipEo = MemoryUtil.GetItemById(itemId);

                    if (multipEo != null)
                    {
                        int _multip = multipEo.ItemBaseMultip;

                        RewardDetail rewardDetail = new()
                        {
                            Line = lineNo,
                            Reward = (context.Chips.SingleAmount * _multip).AToM(context.CurrencyId),
                            SameUnitCount = itemIdResult.Count,
                            Multi = _multip,
                        };
                        context.RewardDetails.Add(rewardDetail);
                        totalMultip.Add(_multip);
                    }
                }
                lineNo++;
            }


            context.HistoryMultip = string.Join("|", totalMultip);
            context.TriggerMaxMultip = totalMultip.Count >= MemoryUtil.LineList.Count ? 10 : 1;
            context.TotalMultip = totalMultip.Sum() * context.TriggerMaxMultip;
            context.WinAmount = context.TotalMultip * context.Chips.SingleAmount;
            context.SlotEleArray = tableList;

            //查询奖池是否足够
            var flag = await CheckPoolReturn(context, context.WinAmount);
            context.IsWin = flag ? 1 : 0;
            //奖池不足
            if (!flag)
            {
                context.RewardDetails.Clear();
                context.SlotEleArray = ChageTableList(context);
                LogUtil.Info($"奖池不足 走BuildTablePoolNo  :  {SerializerUtil.SerializeJsonNet(context.SlotEleArray)}");
            }
            if (context.TriggerSM == 1 && totalMultip.Count == 0)
            {
                context.SlotEleArray = ChageTableList(context);
                LogUtil.Info($"进入bonus且没中奖 走BuildTablePoolNo :  {SerializerUtil.SerializeJsonNet(context.SlotEleArray)}");
            }
            if (context.TriggerSM == 1 && flag)
            {
                if (totalMultip.Count > 0)//中奖
                {
                    //构建假数据
                    int bonusCount = new Random().Next(1, 4);
                    for (int i = 0; i < bonusCount; i++)
                    {
                        context.BonusInfo.Add(BuildTablePoolNo_Bonus(context));
                    }
                    context.TriggerSE = 1;
                }
                else
                {
                    context.TriggerSE = 0;
                }
            }
        }
    }
}