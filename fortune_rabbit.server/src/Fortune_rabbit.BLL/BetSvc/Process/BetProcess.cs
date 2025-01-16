using Fortune_rabbit.BLL.Caching;
using MathNet.Numerics.Random;
using TinyFx;
using TinyFx.Logging;
using TinyFx.Randoms;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;
using static Fortune_rabbit.BLL.FortuneUtil;

namespace Fortune_rabbit.BLL
{
    internal class BetProcess : BetProcessBase
    {
        public override async Task Execute(BetContext context)
        {
            RandomSource randomSource = new MersenneTwister(); // 使用 Mersenne Twister 随机数生成器
            double randomNumber = randomSource.NextDouble(); // 生成一个介于 0 到 1 之间的随机数
            //进入特殊模式
            if (randomNumber < context.Config.SpecialModeRatio)
            {
                await EnterSpecialMode(context);
            }
            else//主轴下注
            {
                await EnterMainMode(context);
            }
        }
        /// <summary>
        /// 进入特殊玩法
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task EnterSpecialMode(BetContext context)
        {
            context.TriggerSM = 1;
            context.TriggerSE = 1;
            int count = context.Config.SpecialModeTurnNum;
            while (count > 0)
            {
                var tableList = GetIconBySpecialMode(context);
                //结算bonus奖金
                await Settle_Bonus(tableList, context);
                count--;
            }
            context.WinAmount += context.WinAmount_SpecialIcon;
            if (context.RealWinAmount == 0L)
            {
                context.SlotEleArray = BuildTablePoolNo();
                LogUtil.Info($"进入bonus且没中奖 走BuildTablePoolNo :  {SerializerUtil.SerializeJsonNet(context.SlotEleArray)}");
            }
        }

        public async Task Settle_Bonus(List<List<int>> tableList, BetContext context)
        {
            var t_list = tableList.SelectMany(list => list);
            var tCount = t_list.Count(x => x > TICON);
            List<List<int>> _bonusTableList = tableList;
            List<float> _bonusMultip = new();
            List<long> _bonusWin = new();
            List<RewardDetail> _bonusRewardDetail = new();
            List<int> ItemIdList = new();
            if (tCount >= 5)//中奖
            {
                foreach (var itemId in t_list)
                {
                    if (itemId > TICON)
                    {
                        var tEo = MemoryUtil.GetWeightList_t_ByID(itemId);
                        var bWin = (long)(context.Chips.BetAmount * tEo.Multip);

                        _bonusMultip.Add(tEo.Multip);
                        _bonusWin.Add(bWin);
                        ItemIdList.Add(itemId);
                    }
                }
                var flag = await CheckPoolReturn(context, _bonusWin.Sum());
                int _isWin = flag ? 1 : 0;
                context.IsWin += _isWin;

                if (flag)
                {
                    RewardDetail rewardDetail = new()
                    {
                        ItemIdList = ItemIdList,
                        Line = -1,
                        Reward = _bonusWin.Sum().AToM(context.CurrencyId),
                        SameUnitCount = tCount,
                        Multi = _bonusMultip.Sum(),
                    };
                    _bonusRewardDetail.Add(rewardDetail);
                    context.WinAmount_SpecialIcon += _bonusWin.Sum();
                    context.SpecialModeMultip = _bonusMultip.Sum();
                    context.TotalMultip += _bonusMultip.Sum();
                    context.RewardDetails.Add(rewardDetail);
                }
                else
                {
                    _bonusTableList = BuildTablePoolNo_Bonus(context);
                    _bonusMultip.Clear();
                    _bonusWin.Clear();
                }
            }

            var dateStamp = GameEAPIUtil.DataTimeUTCToTimestamp(DateTime.UtcNow, false);
            GameInfo gameInfo = new()
            {
                Cost = context.BonusDetailList.Count == 0 ? context.Chips.BetAmount.AToM(context.CurrencyId) : 0,
                Date = dateStamp,
                TriggerSpecialEffects = true,
                SlotEles = _bonusTableList,
                Balance = (context.BalanceAmountBefore + _bonusWin.Sum()).AToM(context.CurrencyId),
                Transactionld = dateStamp.ToString(),
                TotalMulti = context.SpecialModeMultip,
                TotalReward = _bonusWin.Sum().AToM(context.CurrencyId),
                RewardDetails = _bonusRewardDetail
            };
            context.BonusDetailList.Add(gameInfo);
            context.TriggerSE = context.RewardDetails.Count > 0 ? 1 : 0;
        }
        public async Task Settle_Main(List<List<int>> tableList, BetContext context)
        {
            var t_list = tableList.SelectMany(list => list);
            var tCount = t_list.Count(x => x > TICON);
            List<float> _bonusMultip = new();
            List<long> _bonusWin = new();
            List<int> ItemIdList = new();
            if (tCount >= 5)//中奖
            {
                foreach (var itemId in t_list)
                {
                    if (itemId > TICON)
                    {
                        var tEo = MemoryUtil.GetWeightList_t_ByID(itemId);
                        var bWin = (long)(context.Chips.BetAmount * tEo.Multip);

                        _bonusMultip.Add(tEo.Multip);
                        _bonusWin.Add(bWin);
                        ItemIdList.Add(itemId);
                    }
                }

                RewardDetail rewardDetail = new()
                {
                    ItemIdList = ItemIdList,
                    Line = -1,
                    Reward = _bonusWin.Sum().AToM(context.CurrencyId),
                    SameUnitCount = tCount,
                    Multi = _bonusMultip.Sum(),
                };
                context.WinAmount_SpecialIcon += _bonusWin.Sum();
                context.SpecialModeMultip = _bonusMultip.Sum();
                context.TotalMultip += _bonusMultip.Sum();
                context.RewardDetails.Add(rewardDetail);
            }
        }
        public async Task EnterMainMode(BetContext context)
        {
            context.TriggerSM = 0;
            //4% 概率播放呼吸特效
            //context.TriggerSE = RandomUtil.IsOdds(0.04m) ? 1 : 0;
            //行 x 列
            var tableList = BuildItemTable();
            await Settle_Main(tableList, context);

            List<List<int>> hitLineList = BuildIconInLine(context, tableList);

            int lineNo = 1;
            //hitLineList.count 代表中了几条线
            foreach (var ItemIdList in hitLineList)
            {
                //ItemIdList是线上的元素id
                List<int> itemIdResult = new();
                for (int i = 0; i < ItemIdList.Count; i++)//ItemIdList中奖线中的itemId
                {
                    var _itemId = ItemIdList[i];
                    if (_itemId > TICON) continue;
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
                            if (itemIdResult.Count > 0)
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
                            ItemIdList = new List<int> { itemId },
                            Line = lineNo,
                            Reward = (context.Chips.SingleAmount * _multip).AToM(context.CurrencyId),
                            SameUnitCount = itemIdResult.Count,
                            Multi = _multip,
                        };
                        context.RewardDetails.Add(rewardDetail);
                        context.TotalMultip += _multip;
                    }
                }
                lineNo++;
            }
            context.WinAmount = (long)(context.TotalMultip - context.SpecialModeMultip) * context.Chips.SingleAmount;
            context.WinAmount += context.WinAmount_SpecialIcon;
            context.SlotEleArray = tableList;

            //查询奖池是否足够
            var flag = await CheckPoolReturn(context, context.WinAmount);
            context.IsWin = flag ? 1 : 0;
            //奖池不足
            if (!flag)
            {
                context.RewardDetails.Clear();
                context.SlotEleArray = BuildTablePoolNo();
                LogUtil.Info($"奖池不足 走BuildTablePoolNo  :  {SerializerUtil.SerializeJsonNet(context.SlotEleArray)}");
            }
        }
    }
}