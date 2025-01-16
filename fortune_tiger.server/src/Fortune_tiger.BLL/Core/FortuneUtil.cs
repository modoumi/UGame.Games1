using Fortune_tiger.DAL;
using TinyFx;
using TinyFx.Data;
using TinyFx.Logging;
using TinyFx.Randoms;
using Xxyy.GameEAPI.Common.Enum;
using static Fortune_tiger.BLL.Caching.MemoryUtil;

namespace Fortune_tiger.BLL
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
        private static readonly Slot_user_extMO _userExtMo = new();
        private static readonly Slot_bet_detailMO _betMo = new();
        #endregion

        public static async Task<Slot_user_extEO> InitUserExtAsync(string userId, string operatorId, string appId, string currencyId)
        {
            var count = await _userExtMo.GetCountAsync();
            var userExt = new Slot_user_extEO()
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

        public static async Task AddBetDetail(BetContext context, long betId, TransactionManager tm)
        {
            var item = new Slot_bet_detailEO
            {
                AppID = context.AppId,
                BetID = betId,
                OperatorID = context.OperatorId,
                UserID = context.UserId,
                ChipsID = context.Ipo.ChipsId,
                BetBaseAmount = context.Chips.BetAmount,
                BalanceAmount = context.BalanceAmount,
                IsWin = context.IsWin,
                WinAmount = context.WinAmount,
                TotalMultip = context.TotalMultip,
                HistoryLine = context.HistoryLine,
                TriggerHHSW = context.TriggerSM,
                TriggerHHSWIsWin = context.TriggerSE,
                TriggerMaxMultip = context.TriggerMaxMultip,
                HistoryMultip = context.HistoryMultip,
                RewardDetails = SerializerUtil.SerializeJsonNet(context.RewardDetails),
                SlotEleArray = SerializerUtil.SerializeJsonNet(context.SlotEleArray),
                BonusInfo = SerializerUtil.SerializeJsonNet(context.BonusInfo),
                BonusItemId = context.BonusItemId,
                OrderStatus = (int)OrderStatus.Initial,
                WildNum = context.WildNum,
                PoolType = context.PoolType,
                UserFlag = context.UserFlag,
                RecDate = DateTime.UtcNow
            };
            await _betMo.AddAsync(item, tm);
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
                    //var _bonusItemId = tableList[v][k];//v行k列
                    var itemId = tableList[k][v];//v行k列
                    ItemIdList.Add(itemId);
                }
                line_itemList.Add(ItemIdList);
            }

            return line_itemList;
        }
        /// <summary>
        /// 初始化3*3的table
        /// </summary>
        /// <returns></returns>
        public static List<List<int>> InitTable3_3()
        {
            List<List<int>> tableList = new();
            for (int i = 0; i < 3; i++)
            {
                List<int> intss = new() { 0, 0, 0 };
                tableList.Add(intss);
            }
            return tableList;
        }
        /// <summary>
        /// 获取 3*3的元素 存放itemId的table
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static List<List<int>> BuildItemTable(BetContext context)
        {
            var tableText = string.Empty;
            List<List<int>> tableList = new();
            var baseType = context.UserFlag == 0;
            //触发虎虎生威
            if (context.TriggerSM == 1)
            {
                int _lineNum;
                int _bonusItemId;
                if (baseType)// 偶数走btest
                {
                    var ItemEo = GetWeightBaseOther();
                    _bonusItemId = ItemEo.ItemId;
                    _lineNum = ItemEo.LineNum;
                    LogUtil.Debug($"========bonus走权重偶数 LineNum:{ItemEo.LineNum} ");
                }
                else
                {
                    //随机获取
                    var itemEo = RandomSymbolByWeight(context.TagRS);
                    _bonusItemId = itemEo.SymbolId;
                    var itemMultip = RandomSymbolMultipByWeight(context.TagRSM.Where(x => x.SymbolId == itemEo.SymbolId));
                    _lineNum = itemMultip.LineNum;
                    LogUtil.Debug($"========bonus走权重奇数LineNum:{itemMultip.LineNum} ");
                }
                if (_lineNum > 0)//中奖
                {
                    tableList = InitTable3_3();
                    var weightGroup = GetWeightGroup(_lineNum);
                    LogUtil.Debug($"========IconGroup:  {weightGroup.IconGroup}");
                    if (weightGroup != null)
                    {
                        var iconGruop = SerializerUtil.DeserializeJsonNet<List<List<List<int>>>>(weightGroup.IconGroup);

                        foreach (var list1 in iconGruop)
                        {
                            int col = 0;
                            foreach (var list2 in list1)
                            {
                                for (int row = 0; row < list2.Count; row++)
                                {
                                    if (list2[row] >= 99)
                                    {
                                        list2[row] = _bonusItemId;
                                        tableList[col][row] = _bonusItemId;
                                    }
                                }
                                col++;
                            }
                        }

                        LogUtil.Debug($"bnous tableList y:  {SerializerUtil.SerializeJsonNet(tableList)}");
                        context.BonusInfo = iconGruop;
                    }
                    context.BonusItemId = _bonusItemId;
                    context.TriggerSE = 1;
                }
                else//未中奖
                {
                    //40%是否触发虎虎生威特效
                    context.TriggerSE = RandomUtil.IsOdds((decimal)0.4) ? 1 : 0;
                    //tableList = BuildTableByX(BuildTablePoolNo(context));
                    tableList = BuildTablePoolNo(context);
                    context.BonusItemId = 0;
                }
            }
            else
            {
                if (baseType)
                {
                    return GetBaseWeight_B();
                }
                else
                {
                    tableList = InitTable3_3();
                    //列集合二维数组
                    var randomSymbolList = context.TagWeightList;
                    int _RowNums = 3;//生成3行
                    for (int row = 0; row < _RowNums; row++)
                    {
                        //1行context.WeightColumnList.count列 table
                        int col = 0;
                        foreach (var columnList in randomSymbolList)
                        {
                            var itemId = GetItemByWeight(columnList);
                            tableList[col][row] = itemId;
                            col++;
                        }
                    }
                }
                LogUtil.Debug($"========主轴 tableList :  {SerializerUtil.SerializeJsonNet(tableList)}");
            }

            return tableList;
        }
        /// <summary>
        /// 列转行
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<List<int>> BuildTableByX(List<List<int>> table)
        {
            List<List<int>> all = new();
            List<int> row = new();
            List<int> row2 = new();
            List<int> row3 = new();
            for (int i = 0; i < table.Count; i++)
            {
                var col = table[i];
                row.Add(col[0]);
                row2.Add(col[1]);
                row3.Add(col[2]);
            }
            all.Add(row);
            all.Add(row2);
            all.Add(row3);
            return all;
        }
        /// <summary>
        /// 行转列给前端显示用
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<List<int>> BuildTableByY(List<List<int>> table)
        {
            List<List<int>> all = new();
            List<int> column = new();
            List<int> column2 = new();
            List<int> column3 = new();
            for (int i = 0; i < table.Count; i++)
            {
                var row = table[i];
                column.Add(row[0]);
                column2.Add(row[1]);
                column3.Add(row[2]);
            }
            all.Add(column);
            all.Add(column2);
            all.Add(column3);
            return all;
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

            foreach (var item in context.TagWeightList.First())
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
            all.Add(column);
            all.Add(column2);
            all.Add(column3);
            LogUtil.Info($"BuildTablePoolNo - allNums :  {SerializerUtil.SerializeJsonNet(allNums)}");
            LogUtil.Info($"BuildTablePoolNo:  {SerializerUtil.SerializeJsonNet(all)}");
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
        /// 按权重生成值
        /// </summary>
        /// <returns>索引</returns>
        public static int GetWeightByAvg()
        {
            List<int> weightList = new() { 10, 10, 10 };
            //中奖几率随机数 [0,100)
            var count = weightList.Sum();
            var random = new Random().Next(count);
            int startNum = 0;
            int index = 0;
            foreach (var w in weightList)
            {
                if (random >= startNum && random < (w + startNum))
                {
                    return index;
                }
                startNum += w;
                index++;
            }
            return 0;
        }
        /// <summary>
        /// 虎虎生财按权重取图标
        /// </summary>
        /// <returns></returns>
        public static RandomSymbol RandomSymbolByWeight(List<RandomSymbol> list)
        {
            //中奖几率随机数 [0,100)
            var count = list.Sum(x => x.Weight);
            var random = new Random().Next(count);

            int startNum = 0;
            foreach (var w in list)
            {
                if (random >= startNum && random < (w.Weight + startNum))
                {
                    return w;
                }
                startNum += w.Weight;
            }
            return null;
        }
        public static RandomSymbolMultip RandomSymbolMultipByWeight(IEnumerable<RandomSymbolMultip> list)
        {
            //中奖几率随机数 [0,100)
            var count = list.Sum(x => x.Weight);
            var random = new Random().Next(count);
            int startNum = 0;
            foreach (var w in list)
            {
                if (random >= startNum && random < (w.Weight + startNum))
                {
                    return w;
                }
                startNum += w.Weight;
            }
            return null;
        }
    }
}
