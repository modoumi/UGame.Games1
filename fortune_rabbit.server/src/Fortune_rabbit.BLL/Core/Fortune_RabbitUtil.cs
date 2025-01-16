using Fortune_rabbit.BLL.Caching;
using Fortune_rabbit.DAL;
using MathNet.Numerics.Random;
using TinyFx;
using TinyFx.Data;
using TinyFx.Logging;
using TinyFx.Randoms;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using Xxyy.GameEAPI.Core;

namespace Fortune_rabbit.BLL
{
    public static partial class FortuneUtil
    {
        /// <summary>
        /// 万能wild 图片id
        /// </summary>
        public const int WILD = 7;
        /// <summary>
        /// 特殊图标id
        /// </summary>
        public const int TICON = 100;

        #region Properties
        private static readonly Fra_user_extMO _userExtMo = new();
        private static readonly Fra_bet_detailMO _betMo = new();
        #endregion


        public static async Task AddBetDetail(BetContext context, TransactionManager tm)
        {
            context.RecDate = DateTime.UtcNow;
            var eo = new Fra_bet_detailEO
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
                RewardDetails = SerializerUtil.SerializeJsonNet(context.RewardDetails),
                SlotEleArray = SerializerUtil.SerializeJsonNet(context.SlotEleArray),
                OrderStatus = (int)OrderStatus.Initial,
                BonusDetailList = SerializerUtil.SerializeJsonNet(context.BonusDetailList),
                UserFlag = context.UserFlag,
                Memo = context.Memo.ToString(),
                RecDate = context.RecDate
            };
            await _betMo.AddAsync(eo, tm);
        }

        public static async Task AddBetDetail_Batch(List<BetContext> list, TransactionManager tm)
        {
            List<Fra_bet_detailEO> all = new();
            foreach (var context in list)
            {
                context.RecDate = DateTime.UtcNow;
                var eo = new Fra_bet_detailEO
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
                    RewardDetails = SerializerUtil.SerializeJsonNet(context.RewardDetails),
                    SlotEleArray = SerializerUtil.SerializeJsonNet(context.SlotEleArray),
                    OrderStatus = (int)OrderStatus.Initial,
                    BonusDetailList = SerializerUtil.SerializeJsonNet(context.BonusDetailList),
                    UserFlag = context.UserFlag,
                    Memo = context.Memo.ToString(),
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
        public static List<List<int>> BuildItemTable()
        {
            List<List<int>> tableList = new();

            //列集合二维数组
            var _WeightColumnList = MemoryUtil.BuildWeight();

            List<int> cols0 = new();
            List<int> cols1 = new();
            List<int> cols2 = new();
            int _RowNums = 4;//生成3行
            for (int i = 0; i < _RowNums; i++)
            {
                for (int j = 0; j < _WeightColumnList.Count; j++)
                {
                    var columnList = _WeightColumnList[j];
                    var itemId = GetItemByWeight(columnList);
                    //如果是特殊Id,按权重取倍率
                    if (itemId > WILD)
                    {
                        itemId = GetTMultip_Main();
                    }
                    if (j == 0 && i < _RowNums - 1)
                    {
                        cols0.Add(itemId);
                    }
                    else if (j == 1)
                    {
                        cols1.Add(itemId);
                    }
                    else if (j == 2 && i < _RowNums - 1)
                    {
                        cols2.Add(itemId);
                    }
                }
            }
            tableList.Add(cols0);
            tableList.Add(cols1);
            tableList.Add(cols2);

            return tableList;
        }

        /// <summary>
        /// 奖池不足构建图标
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<List<int>> BuildTablePoolNo()
        {
            List<List<int>> all = new();
            var ItemList = MemoryUtil.GetWeightList();
            List<int> ItemIds = new();
            foreach (var item in ItemList)
            {
                if (item.ItemID < WILD && !ItemIds.Contains(item.ItemID))
                {
                    ItemIds.Add(item.ItemID);
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
            var ItemList = MemoryUtil.GetWeightList();
            List<int> ItemIds = new();
            foreach (var item in ItemList)
            {
                if (item.ItemID < WILD)
                {
                    ItemIds.Add(item.ItemID);
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
        public static int GetItemByWeight(List<WeightColumn> weightList)
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
        /// 获取特殊图标倍率
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int GetTMultip_Main()
        {   //中奖几率随机数 [0,100)
            var list = MemoryUtil.GetWeightList_t();
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
        public static int GetTMultip_SM()
        {   //中奖几率随机数 [0,100)
            var list = MemoryUtil.GetWeightList_t();
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

        /// <summary>
        /// 特殊模式按权重取图标
        /// </summary>
        /// <returns></returns>
        public static List<List<int>> GetIconBySpecialMode(BetContext context)
        {
            var smArray = SerializerUtil.DeserializeJsonNet<List<double>>(context.Config.SpecialModeArray);
            if (smArray.Count != 3)
            {
                throw new CustomException("SpecialModeArray 配置错误");
            }

            List<List<int>> tableList = new();
            List<int> y1 = new();
            List<int> y2 = new();
            List<int> y3 = new();
            for (int i = 0; i < 3; i++)
            {
                if (new MersenneTwister().NextDouble() < (double)smArray[0])
                {
                    var smId = GetTMultip_SM();
                    y1.Add(smId);
                }
                else
                {
                    y1.Add(0);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (new MersenneTwister().NextDouble() < (double)smArray[1])
                {
                    y2.Add(GetTMultip_SM());
                }
                else
                {
                    y2.Add(0);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (new MersenneTwister().NextDouble() < (double)smArray[2])
                {
                    var smId = GetTMultip_SM();
                    y3.Add(smId);
                }
                else
                {
                    y3.Add(0);
                }
            }
            tableList.Add(y1);
            tableList.Add(y2);
            tableList.Add(y3);
            return tableList;
        }

        public static List<GameInfo> BuildGameInfoList(Fra_bet_detailEO detail, string currencyId, out decimal totalwin)
        {
            int _IsWin = detail.IsWin >= 1 ? 1 : 0;
            var bonusDetailList = SerializerUtil.DeserializeJsonNet<List<GameInfo>>(detail.BonusDetailList);
            totalwin = (detail.WinAmount * _IsWin - detail.BetAmount).AToM(currencyId);
            List<GameInfo> list = new();
            if (detail.TriggerSM == 0 || (detail.TriggerSM == 1 && (detail.WinAmount * _IsWin) == 0L))
            {
                list.Add(new()
                {
                    TotalReward = detail.WinAmount.AToM(currencyId) * _IsWin,
                    TotalMulti = detail.TotalMultip * _IsWin,
                    RewardDetails = SerializerUtil.DeserializeJsonNet<List<RewardDetail>>(detail.RewardDetails),
                    SlotEles = SerializerUtil.DeserializeJsonNet<List<List<int>>>(detail.SlotEleArray),
                    Cost = detail.BetAmount.AToM(currencyId),
                    Date = GameEAPIUtil.DataTimeUTCToTimestamp(detail.RecDate, false),
                    Balance = detail.BalanceAmountAfter.AToM(currencyId),
                    Transactionld = detail.BetID.ToString(),
                    TriggerSpecialEffects = detail.TriggerSE == 1,
                });
            }
            else
            {
                list = bonusDetailList;
            }

            return list;
        }
    }
}
