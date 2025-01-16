using Fortune_mouse.BLL.Caching;
using MathNet.Numerics.Random;
using TinyFx;
using TinyFx.Logging;
using TinyFx.Randoms;
using Xxyy.GameEAPI.Common;
using static Fortune_mouse.BLL.FortuneUtil;

namespace Fortune_mouse.BLL
{
    internal class BetProcess : BetProcessBase
    {
        public override async Task Execute(BetContext context)
        {
            var SpecialModeRatio = context.Tag.SpecialModeRatio;

            if (new MersenneTwister().NextDouble() < SpecialModeRatio)
            {
                context.TriggerSM = 1;
            }
            else
            {
                context.TriggerSM = 0;
                context.TriggerSE = 0;
            }
            await GetIconByWeight(context);
        }

        public async Task GetIconByWeight(BetContext context)
        {
            var tableList = BuildTableList(context);
            List<List<int>> hitLineList = BuildIconInLine(context, tableList);
            List<int> totalMultip = new();
            int lineNo = 1;
            //hitLineList.count 代表出了几个图标
            foreach (var ItemIdList in hitLineList)
            {
                //ItemIdList是线上的元素id
                List<int> itemIdResult = new();
                for (int i = 0; i < ItemIdList.Count; i++)//ItemIdList中奖线中的itemId
                {
                    var _symbolId = ItemIdList[i];
                    if (i == 0)
                    {
                        itemIdResult.Add(_symbolId);
                    }
                    else
                    {
                        if (_symbolId == WILD)
                        {
                            itemIdResult.Add(_symbolId);
                        }
                        else
                        {
                            if (itemIdResult.Count > 0 && itemIdResult.First() == WILD)
                            {
                                itemIdResult[0] = _symbolId;
                                itemIdResult.Add(_symbolId);
                            }
                            else if (itemIdResult.Contains(_symbolId))
                            {
                                itemIdResult.Add(_symbolId);
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
                    var symbolId = itemIdResult.FirstOrDefault();
                    var multipEo = MemoryUtil.GetSymbolById(symbolId);
                    LogUtil.Info($"中奖-----symbolId:{symbolId}, itemEo:{SerializerUtil.SerializeJsonNet(multipEo)}");
                    if (multipEo != null)
                    {
                        int _multip = multipEo.Multip;

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

            context.TotalMultip = totalMultip.Sum();
            context.WinAmount = context.TotalMultip * context.Chips.SingleAmount;
            //未中奖且牌面没有wild,更换牌面逻辑
            var _IsHave = tableList.SelectMany(list => list).Contains(WILD);
            if (totalMultip.Count == 0 && !_IsHave)
            {
                if (RandomUtil.IsOdds(0.25m))
                {
                    //替换牌面
                    //tableList = ChageTableList_B();
                }
            }
            context.SlotEleArray = tableList;
            var tableText = string.Empty;
            for (int i = 0; i < tableList.Count; i++)
            {
                tableText += string.Join("|", tableList[i]) + ",";
            }
            context.HistoryLine = tableText.TrimEnd(',');
            //查询奖池是否足够
            var flag = await CheckPoolReturn(context, context.WinAmount);
            context.IsWin = flag ? 1 : 0;

            //奖池不足
            if (!flag)
            {
                context.RewardDetails.Clear();
                context.BonusInfo.Clear();
                context.SlotEleArray = BuildTablePoolNo(context);
                LogUtil.Info($"奖池不足-RewardDetails: {SerializerUtil.SerializeJsonNet(context.RewardDetails)},context.SlotEleArray:{SerializerUtil.SerializeJsonNet(context.SlotEleArray)}");
            }
            if (context.TriggerSM == 1 && totalMultip.Count == 0)
            {
                context.SlotEleArray = BuildTablePoolNo(context);
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
                        context.BonusInfo.Add(BuildTable_SM_No(context));
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