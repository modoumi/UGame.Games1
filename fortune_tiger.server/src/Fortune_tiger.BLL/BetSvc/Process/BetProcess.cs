using Fortune_tiger.BLL.Caching;
using Fortune_tiger.BLL.Core;
using Fortune_tiger.DAL;
using MathNet.Numerics.Random;
using TinyFx;
using TinyFx.Logging;
using TinyFx.Randoms;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;
using static Fortune_tiger.BLL.FortuneUtil;

namespace Fortune_tiger.BLL
{
    internal class BetProcess : BetProcessBase
    {
        public override async Task Execute(BetContext context)
        {
            var _ConfigWeight = context.UserFlag == 0 ? context.Config.WightB : context.Tag.SpecialModeRatio;
            var weight = SerializerUtil.DeserializeJsonNet<List<double>>(_ConfigWeight);
            RandomSource randomSource = new MersenneTwister(); // 使用 Mersenne Twister 随机数生成器
            double randomNumber = randomSource.NextDouble(); // 生成一个介于 0 到 1 之间的随机数

            if (randomNumber < weight[0]) // 0.01007%的概率进入A
            {
                context.TriggerSM = 1;
            }
            else if (randomNumber < weight[0] + weight[1]) // 4%的概率进入B
            {
                context.TriggerSE = 1;
                context.TriggerSM = 0;
            }
            else // (1-0.99-4)= 95.01%的概率进入C
            {
                context.TriggerSE = 0;
                context.TriggerSM = 0;
            }

            context.PoolType = await GetPoolVal(context);
            await GetIconByWeight(context);
        }

        public static async Task<int> GetPoolVal(BetContext context)
        {
            return 1;
            /* Slot_pool_returnMO _poolReturnMo = new();
             var poolValue = (await _poolReturnMo.GetByPKAsync(context.OperatorId, context.CurrencyId, null, true)).PoolVal;
             var poolMo = MemoryUtil.GetPoolType(poolValue);
             var Account = await GameEAPIUtil.GetAccount(context.UserId, context.AppId);
             if (Account.Bonus > 0)
             {
                 return (int)PoolEnumType.BONUS;
             }
             return poolMo.PoolType;*/
        }

        public async Task GetIconByWeight(BetContext context)
        {
            var tableList = BuildItemTable(context);
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
                    var multipEo = MemoryUtil.GetItemById((int)context.PoolType, itemId, context.AppId);
                    LogUtil.Info($"中奖-----itemId:{itemId}, itemEo:{SerializerUtil.SerializeJsonNet(multipEo)}");
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

            if (totalMultip.Count >= 5) context.TriggerMaxMultip = 10;
            else context.TriggerMaxMultip = 1;
            context.TotalMultip = totalMultip.Sum() * context.TriggerMaxMultip;
            context.WinAmount = context.TotalMultip * context.Chips.SingleAmount;
            //未中奖且牌面没有wild,更换牌面逻辑
            var _IsHave = tableList.SelectMany(list => list).Contains(WILD);
            if (totalMultip.Count == 0 && !_IsHave)
            {
                if (RandomUtil.IsOdds(0.25m))
                {
                    tableList = ChageTableList_B();
                }
            }
            context.SlotEleArray = tableList; //BuildTableByY(tableList);
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
            if (context.TriggerSM == 1)
                context.WildNum = 0;
            else
                foreach (var list in context.SlotEleArray)
                {
                    foreach (var itemId in list)
                    {
                        if (itemId == WILD)
                        {
                            context.WildNum++;
                        }
                    }
                }
        }
        /// <summary>
        /// 触发跑马灯
        /// </summary>
        /// <param name="context"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        private static async Task TriggerLamp(BetContext context, bool flag)
        {
            //总倍数BIG触发跑马灯
            if (context.TotalMultip >= context.Config.BIG && flag)
            {
                Slot_user_lampMO _lampEO = new();
                var lampEo = new Slot_user_lampEO
                {
                    AppID = context.AppId,
                    OperatorID = context.OperatorId,
                    CurrencyID = context.CurrencyId,
                    PlayerName = await GameEAPIUtil.GetNickName(context.UserId),
                    Multip = context.TotalMultip,
                    Reward = context.RealWinAmount,
                    RecDate = DateTime.UtcNow,
                };
                MemoryUtil.PutLampList(lampEo, context.OperatorId, context.CurrencyId);
                await _lampEO.AddAsync(lampEo);
            }
        }
    }
}