using Fortune_mouse.DAL;
using TinyFx;
using TinyFx.Data;
using TinyFx.Logging;
using TinyFx.Randoms;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using Xxyy.GameEAPI.Core;
using static Fortune_mouse.BLL.Caching.MemoryUtil;

namespace Fortune_mouse.BLL
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
        private static readonly Fmo_user_extMO _userExtMo = new();
        private static readonly Fmo_bet_detailMO _betMo = new();
        #endregion

        public static async Task<Fmo_user_extEO> InitUserExtAsync(string userId, string operatorId, string appId, string currencyId)
        {
            var count = await _userExtMo.GetCountAsync();
            var userExt = new Fmo_user_extEO()
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

        public static async Task AddBetDetail(BetContext context, TransactionManager tm)
        {
            context.RecDate = DateTime.UtcNow;
            var item = new Fmo_bet_detailEO
            {
                AppID = context.AppId,
                BetID = context.BetId,
                OperatorID = context.OperatorId,
                UserID = context.UserId,
                ChipsID = context.Ipo.ChipsId,
                BetAmount = context.Chips.BetAmount,
                BalanceAmount = context.BalanceAmount,
                IsWin = context.IsWin,
                WinAmount = context.WinAmount,
                TotalMultip = context.TotalMultip,
                HistoryLine = context.HistoryLine,
                TriggerSM = context.TriggerSM,
                TriggerSE = context.TriggerSE,
                TriggerMaxMultip = 1,
                HistoryMultip = context.HistoryMultip,
                RewardDetails = SerializerUtil.SerializeJsonNet(context.RewardDetails),
                SlotEleArray = SerializerUtil.SerializeJsonNet(context.SlotEleArray),
                BonusInfo = SerializerUtil.SerializeJsonNet(context.BonusInfo),
                OrderStatus = (int)OrderStatus.Initial,
                UserFlag = context.UserFlag,
                RecDate = context.RecDate
            };
            await _betMo.AddAsync(item, tm);
        }

        public static async Task AddBetDetail_Batch(List<BetContext> list, TransactionManager tm)
        {
            List<Fmo_bet_detailEO> all = new();
            foreach (var context in list)
            {
                context.RecDate = DateTime.UtcNow;
                var eo = new Fmo_bet_detailEO
                {
                    AppID = context.AppId,
                    BetID = context.BetId,
                    OperatorID = context.OperatorId,
                    UserID = context.UserId,
                    ChipsID = context.Ipo.ChipsId,
                    BetAmount = context.Chips.BetAmount,
                    BalanceAmount = context.BalanceAmount,
                    IsWin = context.IsWin,
                    WinAmount = context.WinAmount,
                    TotalMultip = context.TotalMultip,
                    HistoryLine = context.HistoryLine,
                    TriggerSM = context.TriggerSM,
                    TriggerSE = context.TriggerSE,
                    TriggerMaxMultip = 1,
                    HistoryMultip = context.HistoryMultip,
                    RewardDetails = SerializerUtil.SerializeJsonNet(context.RewardDetails),
                    SlotEleArray = SerializerUtil.SerializeJsonNet(context.SlotEleArray),
                    BonusInfo = SerializerUtil.SerializeJsonNet(context.BonusInfo),
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
        public static List<List<int>> BuildTableList(BetContext context)
        {
            List<List<int>> tableList = InitTable3_3();
            //列集合二维数组
            var randomSymbolList = context.TriggerSM == 1 ? context.TagWeight_SM : context.TagWeight_Main;
            //列集合二维数组
            int _RowNums = 3;//生成3行
            for (int row = 0; row < _RowNums; row++)
            {
                int col = 0;
                foreach (var columnList in randomSymbolList)
                {
                    var itemId = GetItemByWeight(columnList);
                    tableList[col][row] = itemId;
                    col++;
                }
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

            var itemList = context.TagWeight_Main.First();
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
            all.Add(column);
            all.Add(column2);
            all.Add(column3);
            LogUtil.Debug($"BuildTablePoolNo:  {SerializerUtil.SerializeJsonNet(all)}");
            return all;
        }

        /// <summary>
        /// 构建未中奖信息
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<List<int>> BuildTable_SM_No(BetContext context)
        {
            List<List<int>> all = new();
            List<int> symbolIds = new();

            var itemList = context.TagWeight_Main.First();
            foreach (var item in itemList)
            {
                if (item.SymbolId != WILD && !symbolIds.Contains(item.SymbolId))
                {
                    symbolIds.Add(item.SymbolId);
                }
            }

            var _notRepeat = RandomUtil.RandomNotRepeat(symbolIds.ToArray(), 6);
            var allNums = _notRepeat.ToList();

            List<int> column = new();
            List<int> column3 = new();
            for (int i = 0; i < allNums.Count; i++)
            {
                if (i >= 0 && i < 3)
                {
                    column.Add(allNums[i]);
                }
                else
                {
                    column3.Add(allNums[i]);
                }
            }
            all.Add(column);
            all.Add(new List<int> { WILD, WILD, WILD });
            all.Add(column3);
            LogUtil.Debug($"===={context.AppId}===构建特殊玩法未中奖牌面:  {SerializerUtil.SerializeJsonNet(all)}");
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

        public static List<GameInfo> BuildGameInfoList(Fmo_bet_detailEO detail, string currencyId, out decimal totalwin)
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
                Balance = detail.BalanceAmount.AToM(currencyId),
                Transactionld = detail.BetID.ToString(),
                TriggerSpecialMode = detail.TriggerSM == 1,
                TriggerSpecialEffects = detail.TriggerSE == 1,
                IsBigBonus = detail.TriggerMaxMultip == 10,
            };

            decimal _balance = (detail.BalanceAmount - detail.BetAmount).AToM(currencyId);
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
                    TriggerSpecialMode = true,
                    TriggerSpecialEffects = true,
                    IsBigBonus = false,
                });
                index++;
            }
            _GameInfoList.Add(gameInfo);

            return _GameInfoList;
        }
    }
}
