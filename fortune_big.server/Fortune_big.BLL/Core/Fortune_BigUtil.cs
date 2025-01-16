using Fortune_big.DAL;
using Microsoft.CodeAnalysis;
using Polly;
using System.Collections.Generic;
using TinyFx;
using TinyFx.Data;
using TinyFx.Logging;
using TinyFx.Randoms;
using Xxyy.GameEAPI.Common.Enum;
using static Fortune_big.BLL.Caching.MemoryUtil;

namespace Fortune_big.BLL
{
    public static partial class Fortune_BigUtil
    {
        public const int SAME = 8;
        /// <summary>
        /// 万能wild 图片id
        /// </summary>
        public const int TSYMBOL = 10;
        public const int WILD = 11;
        public const int FREE = 12;
        public const int RESPIN = 13;
        /// <summary>
        /// 特殊图标id
        /// </summary>
        public const int TICON = 100;
        public const int JJ = 99;

        #region Properties
        private static readonly Big_user_extMO _userExtMo = new();
        private static readonly Big_spin_detailMO _betMo = new();
        #endregion

        public static async Task<Big_user_extEO> InitUserExtAsync(string userId, string operatorId, string appId, string currencyId)
        {
            var count = await _userExtMo.GetCountAsync();
            var userExt = new Big_user_extEO()
            {
                AppID = appId,
                OperatorID = operatorId,
                UserID = userId,
                UserFlag = count,
                CurrencyID = currencyId,
                LastRecDate = DateTime.UtcNow,
                FreeSpinNum = 0,
                RespinNum = 0,
                Balance = 0,
                Bonus = 0,

            };
            await _userExtMo.AddAsync(userExt);
            return userExt;
        }

        public static async Task AddBetDetail(SpinContext context, TransactionManager tm)
        {
            context.RecDate = DateTime.UtcNow;
            var item = new Big_spin_detailEO
            {
                AppID = context.AppId,
                BetID = context.BetId,
                OperatorID = context.OperatorId,
                UserID = context.UserId,
                ChipsID = context.Ipo.ChipsId,
                BetAmount = context.Chips.BetAmount,
                BalanceAmountBefore = context.BalanceAmountBefore,
                BalanceAmountAfter = context.BalanceAmountAfter,
                IsWin = context.IsWin,
                WinAmount = context.WinAmount,
                BetBonus = context.BetBonus,
                WinBonus = context.WinBonus,
                TotalMultip = context.TotalMultip,
                TriggerFreeSpin = context.TriggerFreeSpin,
                TriggerRespin = context.TriggerRespin,
                TriggerSE = context.TriggerSE,
                HistoryMultip = context.HistoryMultip,
                RewardDetailList = SerializerUtil.SerializeJsonNet(context.RewardDetailList),
                SlotEleList = SerializerUtil.SerializeJsonNet(context.SlotEleList),
                FreeSpinList = SerializerUtil.SerializeJsonNet(context.FreeSpinList),
                RespinList = SerializerUtil.SerializeJsonNet(context.RespinList),
                SMAmount = context.SMAmount,
                SMMultip = context.SMMultip,
                OrderStatus = (int)OrderStatus.Initial,
                UserFlag = context.UserFlag,
                RecDate = context.RecDate
            };

            await _betMo.AddAsync(item, tm);
        }
        public static async Task AddBetDetail_Batch(List<SpinContext> list, TransactionManager tm)
        {
            List<Big_spin_detailEO> all = new();
            foreach (var context in list)
            {
                context.RecDate = DateTime.UtcNow;
                var eo = new Big_spin_detailEO
                {
                    AppID = context.AppId,
                    BetID = context.BetId,
                    OperatorID = context.OperatorId,
                    UserID = context.UserId,
                    ChipsID = context.Ipo.ChipsId,
                    BetAmount = context.Chips.BetAmount,
                    BalanceAmountBefore = context.BalanceAmountBefore,
                    BalanceAmountAfter = context.BalanceAmountAfter,
                    IsWin = context.IsWin,
                    WinAmount = context.WinAmount,
                    BetBonus = context.BetBonus,
                    WinBonus = context.WinBonus,
                    TotalMultip = context.TotalMultip,
                    TriggerFreeSpin = context.TriggerFreeSpin,
                    TriggerRespin = context.TriggerRespin,
                    TriggerSE = context.TriggerSE,
                    HistoryMultip = context.HistoryMultip,
                    RewardDetailList = SerializerUtil.SerializeJsonNet(context.RewardDetailList),
                    SlotEleList = SerializerUtil.SerializeJsonNet(context.SlotEleList),
                    FreeSpinList = SerializerUtil.SerializeJsonNet(context.FreeSpinList),
                    RespinList = SerializerUtil.SerializeJsonNet(context.RespinList),
                    SMAmount = context.SMAmount,
                    SMMultip = context.SMMultip,
                    OrderStatus = (int)OrderStatus.Initial,
                    UserFlag = context.UserFlag,
                    RecDate = context.RecDate
                };
                all.Add(eo);
            }
            await _betMo.AddAsync(all, tm);
          
        }
        /// <summary>
        /// 提取中奖ID集合, 根据生成的tableList 匹配N条中奖线
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>

        public static Dictionary<int, List<int>> MatchLine(SpinContext context, List<List<int>> tableList)
        {
            Dictionary<int, List<int>> lineDic = new();
            if (tableList.Count == 0)
            {
                return null;
            }
            foreach (var LineInfo in context.LineList)
            {
                var lineArr = Array.ConvertAll(LineInfo.Line.Split(","), x => int.Parse(x));
                Dictionary<int, int> map = new();
                for (int i = 0; i < lineArr.Length; i++)
                {
                    map.Add(i, lineArr[i]);
                }
                List<int> ItemIdList = new();
                foreach (var k in map.Keys)
                {
                    var v = map[k];
                    var itemId = tableList[k][v];//v行k列
                    ItemIdList.Add(itemId);
                }
                lineDic.Add(LineInfo.LineID, ItemIdList);
            }

            return lineDic;
        }

        /// <summary>
        /// 获取 3*5的元素 存放itemId的table
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static List<List<int>> BuildTableList_Main(SpinContext context)
        {
            List<List<int>> tableList = InitTable3_5();
            //列集合二维数组
            var randomSymbolList = context.TagWeight_Main;
            int _RowNums = 3;//生成3行
            List<int> colList_1 = new List<int>();
            List<int> colList_2 = new List<int>();
            List<int> colList_3 = new List<int>();
            for (int row = 0; row < _RowNums; row++)
            {
                int col = 0;
                foreach (var columnList in randomSymbolList)
                {
                    var symbolId = GetItemByWeight(columnList);
                    if (symbolId == TSYMBOL)
                    {
                        symbolId = GetTMultip_Main();
                    }
                    if (symbolId == FREE || symbolId == RESPIN)
                    {

                        if (col == 0)
                        {
                            if (colList_1.Count == 0)
                                colList_1.Add(symbolId);
                            else
                                symbolId = JJ;//重复 BIG 准备替换
                        }

                        if (col == 2)
                        {
                            if (colList_2.Count == 0)
                                colList_2.Add(symbolId);
                            else
                                symbolId = JJ;//重复 BIG 准备替换
                        }

                        if (col == 4)
                        {
                            if (colList_3.Count == 0)
                                colList_3.Add(symbolId);
                            else
                                symbolId = JJ;//重复 BIG 准备替换
                        }
                    }

                    //如果轴2或者4 出现 12 ,那一定是bug
                    if ((col == 1 || col == 3) && symbolId == FREE)
                    {
                        LogUtil.Error($"轴{col + 1}出现了BIG图标.{symbolId}");
                    }
                    tableList[col][row] = symbolId;
                    col++;
                }
            }
            return tableList;
        }

        public static List<List<int>> BuildTableList_Free(SpinContext context)
        {
            List<List<int>> tableList = InitTable3_5();
            //列集合二维数组
            var randomSymbolList = RandomFree(context);
            int _RowNums = 3;//生成3行
            for (int row = 0; row < _RowNums; row++)
            {
                int col = 0;
                foreach (var columnList in randomSymbolList)
                {
                    var symbolId = GetItemByWeight(columnList);
                    if (symbolId == TSYMBOL)
                        symbolId = GetTMultip_SM();
                    tableList[col][row] = symbolId;
                    col++;
                }
            }
            return tableList;
        }
        public static List<List<RandomSymbol>> RandomFree(SpinContext context)
        {
            // 生成随机数，用于选择列表
            int randomNumber = new Random().Next(1, 4); // 生成 1 到 3 之间的随机数
            // 根据随机数选择列表并随机选取一个元素
            List<List<RandomSymbol>> selectedList;
            switch (randomNumber)
            {
                case 1:
                    selectedList = context.TagWeight_Free1;
                    LogUtil.Debug("free1==================");
                    break;
                case 2:
                    selectedList = context.TagWeight_Free2;
                    LogUtil.Debug("free2==================");
                    break;
                case 3:
                    selectedList = context.TagWeight_Free3;
                    LogUtil.Debug("free3==================");
                    break;
                default:
                    selectedList = context.TagWeight_Free1;
                    break;
            }
            return selectedList;
        }
        public static List<List<int>> InitTable3_5()
        {
            List<List<int>> tableList = new();
            int _RowNums = 5;
            for (int i = 0; i < _RowNums; i++)
            {
                List<int> cols = new() { 0, 0, 0 };
                tableList.Add(cols);
            }
            return tableList;
        }
        /// <summary>
        /// 奖池不足构建图标
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<List<int>> BuildTablePoolNo(SpinContext context)
        {
            List<List<int>> all = new();
            List<int> symbolIds = Bulid_SymbolIds(context);
            var _notRepeat = RandomUtil.RandomNotRepeat(symbolIds.ToArray(), 9);
            var _randomNums = RandomUtil.NextInts(6, 1, WILD);
            var allNums = _notRepeat.Concat(_randomNums).ToList();

            List<int> column = new();
            List<int> column2 = new();
            List<int> column3 = new();
            List<int> column4 = new();
            List<int> column5 = new();
            for (int i = 0; i < allNums.Count; i++)
            {
                int symbolId = allNums[i];
                if (symbolId == TSYMBOL)
                {
                    symbolId = GetTMultip_Main();
                }
                if (i >= 0 && i < 3)
                {
                    column.Add(symbolId);
                }
                else if (i >= 3 && i < 6)
                {
                    column2.Add(symbolId);
                }
                else if (i >= 6 && i < 9)
                {
                    column3.Add(symbolId);
                }
                else if (i >= 9 && i < 12)
                {
                    column4.Add(symbolId);
                }
                else if (i >= 12 && i < 15)
                {
                    column5.Add(symbolId);
                }
            }
            all.Add(column);
            all.Add(column2);
            all.Add(column3);
            all.Add(column4);
            all.Add(column5);
            LogUtil.Debug($"{context.AppId}============BuildTablePoolNo:  {SerializerUtil.SerializeJsonNet(all)}");
            return all;
        }
        public static int GetSymbolId_NotRepeat(List<int> list1, List<int> tagList)
        {
            Random random = new Random();

            int randomValue;

            // Check if any value in list1 exists in list2
            var commonValues = list1.Intersect(tagList).ToList();
            if (commonValues.Count > 0)
            {
                // Randomly select a value from list2 that does not exist in list1
                var nonExistingValues = tagList.Except(list1).ToList();
                if (nonExistingValues.Count > 0)
                {
                    randomValue = nonExistingValues[random.Next(nonExistingValues.Count)];
                }
                else
                {
                    randomValue = tagList[random.Next(tagList.Count)];
                }
            }
            else
            {
                // Randomly select a value from list2
                randomValue = tagList[random.Next(tagList.Count)];
            }
            LogUtil.Debug($"财神===========替换99为:  {randomValue}");
            return randomValue;
        }
        public static List<int> Bulid_SymbolIds(SpinContext context)
        {
            List<int> symbolIds = new();
            var itemList = context.TagWeight_Main.First();
            foreach (var item in itemList)
            {
                if (item.SymbolId < WILD - 1 && !symbolIds.Contains(item.SymbolId))
                {
                    symbolIds.Add(item.SymbolId);
                }
            }

            return symbolIds;
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

        public static int GetTMultip_SM()
        {   //中奖几率随机数 [0,100)
            var list = GetWeight_tList();
            var count = list.Sum(x => x.Weight_SM);
            var random = new Random().Next(count);
            int startNum = 0;
            foreach (var item in list)
            {
                if (random >= startNum && random < (item.Weight_SM + startNum))
                {
                    return item.TID;
                }
                startNum += item.Weight_SM;
            }
            throw new Exception("权重读取Fra_config_weight_tEO 数据不存在！");
        }
        public static int GetTMultip_Main()
        {   //中奖几率随机数 [0,100)
            var list = GetWeight_tList();
            var count = list.Sum(x => x.Weight_Main);
            var random = new Random().Next(count);
            int startNum = 0;
            foreach (var item in list)
            {
                if (random >= startNum && random < (item.Weight_Main + startNum))
                {
                    return item.TID;
                }
                startNum += item.Weight_Main;
            }
            throw new Exception("权重读取Fra_config_weight_tEO 数据不存在！");
        }

    }
}
