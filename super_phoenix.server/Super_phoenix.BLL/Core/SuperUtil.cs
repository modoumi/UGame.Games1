using Super_phoenix.BLL.Caching;
using Super_phoenix.DAL;
using TinyFx.Data;
using TinyFx.Randoms;
using Xxyy.GameEAPI.Common.Enum;

namespace Super_phoenix.BLL
{
    public static class SuperUtil
    {
        /// <summary>
        /// 万能wild 图片id
        /// </summary>
        public const int WILD = 10;
        /// <summary>
        /// scatter 图片id
        /// </summary>
        public const int SCATTER = 11;
        /// <summary>
        /// 排行最大条数
        /// </summary>
        public const int MAXCOUNT = 20;

        #region Properties
        private static readonly Gsp_user_dataMO _userDataMo = new();
        private static readonly Gsp_user_extMO _userExtMo = new();
        private static readonly Gsp_bet_detailMO _betMo = new();
        private static readonly Gsp_pool_returnMO _poolMo = new();
        private static readonly Gsp_config_chipsMO _chipsMo = new();
        #endregion

        public static async Task CheckAndInitUserData(string userId, string operatorId, string currencyId)
        {
            //反奖池
            var poolItem = await _poolMo.GetByPKAsync(operatorId, currencyId);
            if (poolItem == null)
            {
                await _poolMo.AddAsync(new Gsp_pool_returnEO
                {
                    OperatorID = operatorId,
                    CurrencyID = currencyId,
                    PoolVal = 0
                });
            }
            var userExtCount = await _userExtMo.GetCountAsync($"UserID=@UserID", userId);
            if (userExtCount == 0)
            {
                await _userExtMo.AddAsync(new Gsp_user_extEO()
                {
                    UserID = userId,
                    MiniGameTotalVal = 0,
                    LastRecDate = DateTime.UtcNow,
                });

            }
            var count = await _userDataMo.GetCountAsync($"UserID=@UserID", userId);
            var chipsList = await _chipsMo.GetAllAsync();
            if (count == chipsList.Count)
                return;
            if (count != 0)
                throw new Exception($"gsp_user_chips表数据错误。userId:{userId} currencyId:{currencyId} chips: {chipsList.Count} count:{count}");
            var list = new List<Gsp_user_dataEO>();
            foreach (var chips in chipsList)
            {
                var item = new Gsp_user_dataEO
                {
                    UserID = userId,
                    ChipsID = chips.ChipsID,
                    FreeSpinCount = 0,
                    FreeSpinTotalReward = 0,
                    LastRecDate = DateTime.UtcNow,
                };
                list.Add(item);
            }
            await _userDataMo.AddAsync(list);
        }
        public static async Task AddBetDetail(SlotContext context, long betId, TransactionManager tm)
        {
            var item = new Gsp_bet_detailEO
            {
                BetID = betId,
                UserID = context.UserId,
                ChipsID = context.Ipo.ChipsId,
                BetBaseAmount = context.Config_Chips.BetAmount,
                TriggerMiniGame = context.TriggerMiniGame,
                MiniGameTotalVal = context.UserExt.MiniGameTotalVal,
                FreeSpinCount = context.UserData.FreeSpinCount,
                IsWin = context.IsWin,
                WinAmount = context.WinAmount,
                TotalMultip = context.TotalMultip,
                HistoryLine = context.HistoryLine,
                HistoryMultip = context.HistoryMultip,
                OrderStatus = (int)OrderStatus.Initial,
                RecDate = DateTime.UtcNow
            };
            await _betMo.AddAsync(item, tm);
        }
        /// <summary>
        /// 获取中奖倍数
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>

        public static List<List<int>> BuildIconInLine(SlotContext context, int[][] arrays)
        {
            List<List<int>> line_itemList = new();
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
                    var itemId = arrays[v][k];
                    ItemIdList.Add(itemId);
                }
                line_itemList.Add(ItemIdList);
            }

            return line_itemList;
        }

        /// <summary>
        /// 获取 3*5 的元素table
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static List<int[]> BuildTable(SlotContext context)
        {
            var text = string.Empty;
            List<int[]> all = new();
            #region 测试数据
            /* int[] int1 = new int[] { 5, 2, 4, 1, 4 };
             int[] int2 = new int[] { 10, 1, 4, 1, 6 };
             int[] int3 = new int[] { 4, 10, 1, 4, 1 };
             all.Add(int1); all.Add(int2); all.Add(int3);
             text += string.Join("|", int1) + ",";
             text += string.Join("|", int2) + ",";
             text += string.Join("|", int3) + ",";*/
            #endregion
            for (int i = 0; i < 3; i++)
            {
                List<int> ints = new();
                foreach (var WeightColumn in context.WeightColumnList)
                {
                    var itemId = GetWeight(WeightColumn);
                    ints.Add(itemId);
                }

                text += string.Join("|", ints) + ",";
                all.Add(ints.ToArray());
            }
            if (context.TriggerMiniGame > 0)
            {
                all[GetWeightByAvg()][0] = SCATTER;
                all[GetWeightByAvg()][2] = SCATTER;
                all[GetWeightByAvg()][4] = SCATTER;
            }

            /*
            context.SlotEleArray = BuildTableByY(all);
            context.HistoryLine = text.TrimEnd(",");
             */
            return all;
        }
        public static List<int[]> BuildTableByY(List<int[]> table)
        {
            List<int[]> all = new();
            List<int> column = new();
            List<int> column2 = new();
            List<int> column3 = new();
            List<int> column4 = new();
            List<int> column5 = new();
            for (int i = 0; i < table.Count; i++)
            {
                var row = table[i];
                column.Add(row[0]);
                column2.Add(row[1]);
                column3.Add(row[2]);
                column4.Add(row[3]);
                column5.Add(row[4]);
            }
            all.Add(column.ToArray());
            all.Add(column2.ToArray());
            all.Add(column3.ToArray());
            all.Add(column4.ToArray());
            all.Add(column5.ToArray());

            return all;
        }
        /// <summary>
        /// 奖池不足构建图标
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<int[]> BuildTablePoolNo(SlotContext context)
        {
            List<int[]> all = new();
            var ItemList = MemoryUtil.GetWeightList((int)context.ItemType);
            List<int> ItemIds = new();
            foreach (var item in ItemList)
            {
                if (item.ItemID != SCATTER && item.ItemID != WILD)
                {
                    ItemIds.Add(item.ItemID);
                }
            }
            var _notRepeat = RandomUtil.RandomNotRepeat(ItemIds.ToArray(), 9);
            var _randomNums = RandomUtil.NextInts(6, 1, 10);
            var allNums = _notRepeat.Concat(_randomNums).ToList();

            List<int> column = new();
            List<int> column2 = new();
            List<int> column3 = new();
            List<int> column4 = new();
            List<int> column5 = new();
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
                else if (i >= 9 && i < 12)
                {
                    column4.Add(allNums[i]);
                }
                else if (i >= 12 && i < 15)
                {
                    column5.Add(allNums[i]);
                }
            }
            all.Add(column.ToArray());
            all.Add(column2.ToArray());
            all.Add(column3.ToArray());
            all.Add(column4.ToArray());
            all.Add(column5.ToArray());
            if (context.IsFreeSpin)
            {
                int freeIdx = (int)context.ItemType + 1;
                all[freeIdx][0] = WILD;
                all[freeIdx][1] = WILD;
                all[freeIdx][2] = WILD;
            }
            return all;
        }
        public static int GetWeight(List<WeightColumn> weightList)
        {   //中奖几率随机数 [0,100)
            var count = weightList.Sum(x => x.WeightVal);
            var random = new Random().Next(count);
            int startNum = 0;
            foreach (var item in weightList)
            {
                if (random >= startNum && random < (item.WeightVal + startNum))
                {
                    return item.WeightId;
                }
                startNum += item.WeightVal;
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
    }
}
