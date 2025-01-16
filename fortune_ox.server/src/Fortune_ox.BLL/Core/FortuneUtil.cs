using Fortune_ox.BLL.Caching;
using Fortune_ox.DAL;
using TinyFx;
using TinyFx.Data;
using TinyFx.Logging;
using TinyFx.Randoms;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using Xxyy.GameEAPI.Core;

namespace Fortune_ox.BLL
{
    public static partial class FortuneUtil
    {
        /// <summary>
        /// 万能wild 图片id
        /// </summary>
        public const int WILD = 7;
        /// <summary>
        /// 排行最大条数
        /// </summary>
        public const int MAXCOUNT = 20;

        #region Properties
        private static readonly Fox_user_extMO _userExtMo = new();
        private static readonly Fox_bet_detailMO _betMo = new();
        #endregion


        public static async Task AddBetDetail(BetContext context, TransactionManager tm)
        {
            context.RecDate = DateTime.UtcNow;
            var eo = new Fox_bet_detailEO
            {
                BetID = context.BetId,
                GroupId = context.GroupId,
                AppID = context.AppId,
                OperatorID = context.OperatorId,
                UserID = context.UserId,
                ChipsID = context.Ipo.ChipsId,
                BetAmount = context.Chips.BetAmount,
                WinAmount = context.WinAmount,
                BalanceAmountBefore = context.BalanceAmountBefore,
                IsWin = context.IsWin,
                TotalMultip = context.TotalMultip,
                TriggerSM = context.TriggerSM,
                TriggerSE = context.TriggerSE,
                TriggerMaxMultip = context.TriggerMaxMultip,
                HistoryMultip = context.HistoryMultip,
                RewardDetails = SerializerUtil.SerializeJsonNet(context.RewardDetails),
                SlotEleArray = SerializerUtil.SerializeJsonNet(context.SlotEleArray),
                BonusInfo = SerializerUtil.SerializeJsonNet(context.BonusInfo),
                OrderStatus = (int)OrderStatus.Initial,
                BetBonus = context.BetBonus,
                WinBonus = context.WinBonus,
                UserFlag = context.UserFlag,
                PoolType = context.Tag.BID,
                RecDate = context.RecDate
            };
            await _betMo.AddAsync(eo, tm);
        }
        public static async Task AddBetDetail_Batch(List<BetContext> list, TransactionManager tm)
        {
            List<Fox_bet_detailEO> all = new();
            foreach (var context in list)
            {
                context.RecDate = DateTime.UtcNow;
                var eo = new Fox_bet_detailEO
                {
                    BetID = context.BetId,
                    GroupId = context.GroupId,
                    AppID = context.AppId,
                    OperatorID = context.OperatorId,
                    UserID = context.UserId,
                    ChipsID = context.Ipo.ChipsId,
                    BetAmount = context.Chips.BetAmount,
                    WinAmount = context.WinAmount,
                    BalanceAmountBefore = context.BalanceAmountBefore,
                    IsWin = context.IsWin,
                    TotalMultip = context.TotalMultip,
                    TriggerSM = context.TriggerSM,
                    TriggerSE = context.TriggerSE,
                    TriggerMaxMultip = context.TriggerMaxMultip,
                    HistoryMultip = context.HistoryMultip,
                    RewardDetails = SerializerUtil.SerializeJsonNet(context.RewardDetails),
                    SlotEleArray = SerializerUtil.SerializeJsonNet(context.SlotEleArray),
                    BonusInfo = SerializerUtil.SerializeJsonNet(context.BonusInfo),
                    OrderStatus = (int)OrderStatus.Initial,
                    // UserFlag = context.UserFlag,
                    PoolType = context.Tag.BID,
                    RecDate = context.RecDate
                };
                all.Add(eo);
            }

            await _betMo.AddAsync(all, tm);
        }
        public static List<List<int>> DeepClone(List<List<int>> source)
        {
            List<List<int>> clone = new(source.Count);
            foreach (List<int> innerList in source)
            {
                List<int> innerClone = new(innerList.Count);
                foreach (int item in innerList)
                {
                    innerClone.Add(item);
                }
                clone.Add(innerClone);
            }
            return clone;
        }
        /// <summary>
        /// 提取中奖ID集合, 根据生成的tableList 匹配N条中奖线
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>

        public static List<List<int>> BuildIconInLine(BetContext context, List<List<int>> tableList)
        {
            List<List<int>> line_itemList = new();
            if (tableList.Count == 0)
            {
                return line_itemList;
            }
            List<List<int>> _tempList = DeepClone(tableList);
            foreach (var list in _tempList)
            {
                if (list.Count == 3)
                {
                    list.Add(0);
                }
            }
            foreach (var item in context.LineList)
            {
                var lineArr = Array.ConvertAll(item.Line.Split(","), x => int.Parse(x));
                Dictionary<int, int> map = new();
                for (int i = 0; i < lineArr.Length; i++)
                {
                    map.Add(i, lineArr[i]);
                }
                List<int> ItemIdList = new();
                foreach (var k in map.Keys)
                {
                    var v = map[k];
                    var itemId = _tempList[k][v];//v行k列
                    ItemIdList.Add(itemId);
                }
                line_itemList.Add(ItemIdList);
            }

            return line_itemList;
        }
        /// <summary>
        /// 获取 3*3的元素 存放itemId的table
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static List<List<int>> BuildItemTable(BetContext context)
        {
            List<List<int>> tableList = new();
            //触发特殊模式
            if (context.TriggerSM == 1)
            {
                //随机获取
                tableList = GetSymbolBySM(context);
            }
            else
            {
                List<int> cols0 = new();
                List<int> cols1 = new();
                List<int> cols2 = new();
                int _RowNums = 3;//生成3行
                for (int i = 0; i < _RowNums; i++)
                {
                    for (int j = 0; j < context.TagWeightList.Count; j++)
                    {
                        var columnList = context.TagWeightList[j];
                        var itemId = GetItemByWeight(columnList);
                        if (j == 0)
                        {
                            cols0.Add(itemId);
                        }
                        else if (j == 1)
                        {
                            cols1.Add(itemId);
                        }
                        else if (j == 2)
                        {
                            cols2.Add(itemId);
                        }
                    }
                }
                cols1.Add(GetItemByWeight(context.TagWeightList[1]));
                tableList.Add(cols0);
                tableList.Add(cols1);
                tableList.Add(cols2);
            }

            return tableList;
        }

        /// <summary>
        /// 奖池不足构建图标
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<List<int>> BuildTablePoolNo(BetContext context)
        {
            List<List<int>> all = new();
            List<int> ItemIds = new();
            var itemList = context.TagWeightList.First();
            foreach (var item in itemList)
            {
                if (item.SymbolId != WILD && !ItemIds.Contains(item.SymbolId))
                {
                    ItemIds.Add(item.SymbolId);
                }
            }
            var _notRepeat = RandomUtil.RandomNotRepeat(ItemIds.ToArray(), 6);
            var _randomNums = RandomUtil.NextInts(3, 1, 8);
            var allNums = _notRepeat.Concat(_randomNums).ToList();

            List<int> column = new();
            List<int> column2 = new();
            List<int> column3 = new();
            for (int i = 0; i < allNums.Count; i++)
            {
                if (i >= 0 && i < 3)
                {
                    column.Add(allNums[i]);
                }
                else if (i >= 3 && i < 6)
                {
                    column2.Add(allNums[i]);
                }
                else if (i >= 6 && i < 9)
                {
                    column3.Add(allNums[i]);
                }
            }
            column2.Add(column[0]);
            all.Add(column);
            all.Add(column2);
            all.Add(column3);
            LogUtil.Debug($"BuildTablePoolNo:  {SerializerUtil.SerializeJsonNet(all)}");
            return all;
        }
        /// <summary>
        /// 奖池不足构建图标
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<List<int>> BuildTablePoolNo_Bonus(BetContext context)
        {
            List<List<int>> all = new();
            List<int> ItemIds = new();
            var itemList = context.TagWeightList.First();
            foreach (var item in itemList)
            {
                if (item.SymbolId != WILD && !ItemIds.Contains(item.SymbolId))
                {
                    ItemIds.Add(item.SymbolId);
                }
            }
            var allNums = RandomUtil.RandomNotRepeat(ItemIds.ToArray(), 2);

            List<int> column = new();
            List<int> column2 = new();
            for (int i = 0; i < allNums.Length; i++)
            {
                if (i == 0)
                {
                    column.Add(allNums[i]);
                    column.Add(allNums[i]);
                    column.Add(allNums[i]);
                }
                else
                {
                    column2.Add(allNums[i]);
                    column2.Add(allNums[i]);
                    column2.Add(allNums[i]);
                    column2.Add(allNums[i]);
                }
            }
            all.Add(column);
            all.Add(column2);
            all.Add(column);
            return all;
        }
        /// <summary>
        /// 根据权重取图标Item
        /// </summary>
        /// <param name="weightList"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int GetItemByWeight(List<RandomSymbol> weightList)
        {   //中奖几率随机数 [0,100)
            var count = weightList.Sum(x => x.Weight);
            var random = new Random().Next(count);
            int startNum = 0;
            foreach (var item in weightList)
            {
                if (random >= startNum && random < (item.Weight + startNum))
                {
                    return item.SymbolId;
                }
                startNum += item.Weight;
            }
            throw new Exception("权重读取WeightColumn 数据不存在！");
        }

        /// <summary>
        /// 特殊玩法权重取图标
        /// </summary>
        /// <returns></returns>
        public static List<List<int>> GetSymbolBySM(BetContext context)
        {
            List<List<int>> tableList = new();
            List<int> col1_3 = BuildColumn1(context, tableList);
            BuildColumn2(context, tableList);
            tableList.Add(col1_3);
            return tableList;
        }

        public static SpecialMode GetSMByWeight(List<SpecialMode> smList)
        {   //中奖几率随机数 [0,100)
            var count = smList.Sum(x => x.Weight);
            var random = new Random().Next(count);
            int startNum = 0;
            foreach (var item in smList)
            {
                if (random >= startNum && random < (item.Weight + startNum))
                {
                    return item;
                }
                startNum += item.Weight;
            }
            throw new Exception("权重读取WeightColumn 数据不存在！");
        }
        private static List<int> BuildColumn1(BetContext context, List<List<int>> tableList)
        {
            List<int> col1 = new();
            var y1Eo = GetSMByWeight(context.TagSM_Y1);
            var group = y1Eo.SymbolGroup.Split(',');
            foreach (var item in group)
            {
                col1.Add(int.Parse(item));
            }
            tableList.Add(col1);
            return col1;
        }
        private static void BuildColumn2(BetContext context, List<List<int>> tableList)
        {
            List<int> col2 = new();
            var y2Eo = GetSMByWeight(context.TagSM_Y2);
            var group = y2Eo.SymbolGroup.Split(',');
            foreach (var item in group)
            {
                col2.Add(int.Parse(item));
            }
            tableList.Add(col2);
        }

        public static List<GameInfo> BuildGameInfoList(Fox_bet_detailEO detail, string currencyId, out decimal totalwin)
        {
            var _BonusInfo = SerializerUtil.DeserializeJsonNet<List<List<List<int>>>>(detail.BonusInfo);
            totalwin = (detail.WinAmount * detail.IsWin - detail.BetAmount).AToM(currencyId);
            List<GameInfo> _GameInfoList = new();
            GameInfo gameInfo = new()
            {
                TotalReward = detail.WinAmount.AToM(currencyId) * detail.IsWin,
                TotalMulti = detail.TotalMultip * detail.IsWin,
                RewardDetails = SerializerUtil.DeserializeJsonNet<List<RewardDetail>>(detail.RewardDetails),
                SlotEles = SerializerUtil.DeserializeJsonNet<List<List<int>>>(detail.SlotEleArray),
                Cost = _BonusInfo.Count == 0 ? detail.BetAmount.AToM(currencyId) : 0.0m,
                Date = GameEAPIUtil.DataTimeUTCToTimestamp(detail.RecDate, false),
                Balance = detail.BalanceAmountAfter.AToM(currencyId),
                Transactionld = detail.BetID.ToString(),
                IsTrigerBonus = detail.TriggerSM == 1,
                IsBonus = detail.TriggerSE == 1,
                IsBigBonus = detail.TriggerMaxMultip == 10,
            };

            decimal _balance = (detail.BalanceAmountBefore - detail.BetAmount).AToM(currencyId);
            int index = 0;
            foreach (var slotArr in _BonusInfo)
            {
                long dateStamp = GameEAPIUtil.DataTimeUTCToTimestamp(DateTime.UtcNow, false);
                decimal cost = 0.0m;
                if (index == 0)
                {
                    cost = detail.BetAmount.AToM(currencyId);
                }
                _GameInfoList.Add(new GameInfo
                {
                    TotalReward = 0.0m,
                    TotalMulti = 0,
                    RewardDetails = new(),
                    SlotEles = slotArr,
                    Cost = cost,
                    Date = GameEAPIUtil.DataTimeUTCToTimestamp(DateTime.UtcNow, false),
                    Balance = _balance,
                    Transactionld = dateStamp.ToString(),
                    IsTrigerBonus = true,
                    IsBonus = true,
                    IsBigBonus = false,
                });
                index++;
            }
            _GameInfoList.Add(gameInfo);

            return _GameInfoList;
        }

        public static async Task<Fox_user_extEO> InitUserExtAsync(string userId, string operatorId, string appId, string currencyId)
        {
            var count = await _userExtMo.GetCountAsync();
            var userExt = new Fox_user_extEO()
            {
                AppID = appId,
                OperatorID = operatorId,
                UserID = userId,
                UserFlag = count,
                CurrencyID = currencyId,
                LastRecDate = DateTime.UtcNow,
            };
            await _userExtMo.AddAsync(userExt);
            return userExt;
        }

    }
}
