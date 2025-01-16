using Fortune_tiger.DAL;
using System.Collections.Generic;
using TinyFx;
using TinyFx.DbCaching;
using TinyFx.Logging;

namespace Fortune_tiger.BLL.Caching
{
    public static class MemoryUtil
    {
        #region slot_config
        //private static readonly object _syncConfig = new();
        //private static Dictionary<string, Slot_configEO>? _configDic;
        //private static Dictionary<string, Slot_configEO> ConfigDic
        //{
        //    get
        //    {
        //        if (_configDic == null)
        //        {
        //            lock (_syncConfig)
        //            {
        //                if (_configDic == null)
        //                {
        //                    var values = new Dictionary<string, Slot_configEO>();
        //                    foreach (var item in new Slot_configMO().GetAll())
        //                    {
        //                        var key = $"{item.AppID}|{item.OperatorID}|{item.CurrencyID}";
        //                        values.Add(key, item);
        //                    }
        //                    _configDic = values;
        //                }
        //            }
        //        }
        //        return _configDic;
        //    }
        //}

        //public static Slot_configEO GetConfig(string appId, string operatorId, string currencyId) => ConfigDic[$"{appId}|{operatorId}|{currencyId}"];


        public static Slot_configPO GetConfig(string appId, string operatorId, string currencyId)
        {
            var ret = DbCachingUtil.GetSingle<Slot_configPO>(it => new { it.AppID,it.OperatorID, it.CurrencyID }, new Slot_configPO
            {
                AppID = appId,
                OperatorID = operatorId,
                CurrencyID = currencyId,
            });
            return ret;
        }

        #endregion

        #region slot_config_chips
        //private static readonly object _syncChips = new();
        //private static Dictionary<string, Slot_config_chipsEO>? _chipsDic;
        //public static Dictionary<string, Slot_config_chipsEO> ChipsDic
        //{
        //    get
        //    {

        //        if (_chipsDic == null)
        //        {
        //            lock (_syncChips)
        //            {

        //                if (_chipsDic == null)
        //                {
        //                    var values = new Dictionary<string, Slot_config_chipsEO>();
        //                    foreach (var item in new Slot_config_chipsMO().GetAll())
        //                    {
        //                        var key = $"{item.AppID}|{item.ChipsID}";
        //                        values.Add(key, item);
        //                    }
        //                    _chipsDic = values;
        //                }
        //            }
        //        }
        //        return _chipsDic;
        //    }
        //}

        //public static Slot_config_chipsEO GetChips(string appId, int chipsId) => ChipsDic[$"{appId}|{chipsId}"];

        //public static List<Slot_config_chipsEO> GetChipsList(string appId) => ChipsDic.Where(x => x.Value.AppID.Equals(appId)).Select(x => x.Value).ToList();


        public static Slot_config_chipsPO GetChips(string appId, int chipsId)
        {
            var ret = DbCachingUtil.GetSingle<Slot_config_chipsPO>(it => new { it.AppID,it.ChipsID }, new Slot_config_chipsPO
            {
                AppID = appId,
                ChipsID = chipsId
            });
            return ret;
        }

        public static List<Slot_config_chipsPO> GetChipsList(string appId) =>!string.IsNullOrEmpty(appId)? DbCachingUtil.GetAllList<Slot_config_chipsPO>().Where(c=>c.AppID==appId).ToList() : DbCachingUtil.GetAllList<Slot_config_chipsPO>();

        #endregion

        #region slot_config_line
        //private static List<Slot_config_lineEO>? _lineList;
        //public static List<Slot_config_lineEO> LineList
        //{
        //    get
        //    {
        //        _lineList ??= new Slot_config_lineMO().GetAll();
        //        return _lineList;
        //    }
        //}
        //public static List<Slot_config_lineEO> GetLineList(string appId) =>
        //    LineList.Where(x => x.AppID.Equals(appId))
        //    .OrderBy(x => x.LineNo).ToList();



        public static List<Slot_config_linePO> LineList =>   DbCachingUtil.GetAllList<Slot_config_linePO>();
   

        public static List<Slot_config_linePO> GetLineList(string appId) => LineList.Where(x => x.AppID.Equals(appId)).OrderBy(x => x.LineNo).ToList();


        #endregion

        #region slot_config_hhsw
 
        public static List<Slot_config_hhswPO> HhswList=> DbCachingUtil.GetAllList<Slot_config_hhswPO>();

        #endregion

        #region slot_user_lamp

        private static List<Slot_user_lampEO>? _lampList;
        public static List<Slot_user_lampEO> LampList(string operatorId, string currencyId)
        {
            _lampList ??= new Slot_user_lampMO().GetTopSort($"OperatorId='{operatorId}' AND CurrencyId='{currencyId}' ", FortuneUtil.MAXCOUNT, "RecDate DESC");
            return _lampList;
        }

        public static void PutLampList(Slot_user_lampEO lampEo, string operatorId, string currencyId)
        {
            var list = LampList(operatorId, currencyId);
            list.Insert(0, lampEo);
            if (list.Count > FortuneUtil.MAXCOUNT)
            {
                for (int i = FortuneUtil.MAXCOUNT; i < list.Count; i++)
                {
                    list.RemoveAt(i);
                }
            }
        }

        public static Slot_user_lampEO GetLampFirst(long timestamp, string operatorId, string currencyId)
        {
            var list = LampList(operatorId, currencyId).Where(x => x.RecDate.ToTimestamp(true,true) < timestamp)
                .FirstOrDefault();
            return list;
        }

        /// <summary>
        /// List分页处理
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_list"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static List<T> SplitList<T>(List<T> _list, int PageIndex, int PageSize)
        {
            int _PageIndex = PageIndex == 0 ? 1 : PageIndex;
            int _PageSize = PageSize == 0 ? 20 : PageSize;
            int PageConut = (int)Math.Ceiling(Convert.ToDecimal(_list.Count) / _PageSize);
            if (PageConut >= _PageIndex)
            {
                List<T> list = new List<T>();
                list = _list.Skip((_PageIndex - 1) * _PageSize).Take(_PageSize).ToList();
                return list;
            }
            else
                return _list;
        }
        #endregion

        #region slot_config_item
      
        private static List<Slot_config_itemPO> ItemList=> DbCachingUtil.GetAllList<Slot_config_itemPO>();


        public static Slot_config_itemPO? GetItemById(int poolType, int itemId, string appId)
            => GetItemListByPoolType(poolType).Where(x => x.AppID.Equals(appId)
                && x.ItemID == itemId).FirstOrDefault();

        public static List<Slot_config_itemPO> GetItemListByPoolType(int poolType)
            => ItemList.Where(
                x => x.PoolType.Equals(poolType)).ToList();
        #endregion

        /*      #region slot_config_item_weight
              private static List<Slot_config_item_weightEO>? _itemWeightList;
              public static List<Slot_config_item_weightEO> ItemWeightList
              {
                  get
                  {
                      _itemWeightList ??= new Slot_config_item_weightMO().GetAll();
                      return _itemWeightList;
                  }
              }
              public static List<Slot_config_item_weightEO> GetItemWeightList(int itemId, int poolType)
                  => ItemWeightList.Where(o => o.ItemID == itemId && o.PoolType == poolType).ToList();
              #endregion*/

        #region slot_config_base
     
        public static List<Slot_config_basePO> BaseList => DbCachingUtil.GetAllList<Slot_config_basePO>();


        public static List<Slot_config_basePO> GetBaseWeightList(string baseName)
            => BaseList.Where(o => o.BaseName.Equals(baseName)).ToList();
        public static Slot_config_basePO GetBaseWeight(string baseName, int column)
           => GetBaseWeightList(baseName).Where(o => o.BaseColumn == column).First();

        public static List<List<WeightColumn>> BuildBase_B(string baseName)
        {
            List<List<WeightColumn>> list = new();
            var Weight1 = new List<WeightColumn>();
            var Weight2 = new List<WeightColumn>();
            var Weight3 = new List<WeightColumn>();

            var bList = GetBaseWeightList(baseName);
            foreach (var baseEo in bList)
            {
                var weightList = SerializerUtil.DeserializeJsonNet<List<List<int>>>(baseEo.BaseText);
                foreach (var kv in weightList)
                {
                    if (baseEo.BaseColumn == 1)
                    {
                        Weight1.Add(new WeightColumn { WeightId = kv[0], WeightVal = kv[1], IconType = 0 });
                    }
                    else if (baseEo.BaseColumn == 2)
                    {

                        Weight2.Add(new WeightColumn { WeightId = kv[0], WeightVal = kv[1], IconType = 0 });
                    }
                    else if (baseEo.BaseColumn == 3)
                    {
                        Weight3.Add(new WeightColumn { WeightId = kv[0], WeightVal = kv[1], IconType = 0 });
                    }
                }
            }

            list.Add(Weight1);
            list.Add(Weight2);
            list.Add(Weight3);
            return list;
        }
        #endregion

        #region slot_config_item_weight_group
     
        public static List<Slot_config_item_weight_groupPO> ItemWeightGroupList => DbCachingUtil.GetAllList<Slot_config_item_weight_groupPO>();
 
        public static List<Slot_config_item_weight_groupPO> GetWeightGroupList(int lineNum)
            => ItemWeightGroupList.Where(o => o.LineNum == lineNum && o.Weight == 1).ToList();
        public static Slot_config_item_weight_groupPO GetWeightGroup(int lineNum)
        {
            lineNum = lineNum > 5 ? 5 : lineNum;
            return GetWeightGroupList(lineNum).OrderBy(x => Guid.NewGuid()).First();
        }
        #endregion

        #region slot_config_tag
        
        private static List<Slot_config_tagPO> TagList=> DbCachingUtil.GetAllList<Slot_config_tagPO>();

        /*  /// <summary>
          /// 获取用户标签symbol
          /// </summary>
          /// <param name="betAmount"></param>
          /// <returns></returns>
          public static List<RandomSymbol> TagRS(long betAmount)
          {
              var tagEo = GetTagByAmount(betAmount);
              LogUtil.Debug($"用户标签 RandomSymbol -> Bid: {tagEo.BID},betAmount:{betAmount}");
              return SerializerUtil.DeserializeJson<List<RandomSymbol>>(tagEo.RandomSymbol);
          }
          /// <summary>
          /// 获取用户标签倍率
          /// </summary>
          /// <param name="betAmount"></param>
          /// <returns></returns>
          public static List<RandomSymbolMultip> TagRSM(Slot_config_tagEO tagEo)
          {
              var tagEo = GetTagByAmount(betAmount);
              LogUtil.Debug($"用户标签 RandomSymbolMultip -> Bid: {tagEo.BID},betAmount:{betAmount}");
              return SerializerUtil.DeserializeJson<List<RandomSymbolMultip>>(tagEo.RandomSymbolMultip);
          }
          public static List<List<RandomSymbol>> TagWeightList(long betAmount)
          {
              var tagEo = GetTagByAmount(betAmount);
              LogUtil.Debug($"用户标签 Weight -> Bid:{tagEo.BID},betAmount:{betAmount}");
              return SerializerUtil.DeserializeJson<List<List<RandomSymbol>>>(tagEo.WeightList);
          }*/

        public static Slot_config_tagPO GetTagByAmount(long betAmount)
        {
            return TagList.Where(x => x.BetAmount <= betAmount && betAmount < x.BetAmountEnd).First();
        }

        public class RandomSymbol
        {
            public int SymbolId { get; set; }
            public int Weight { get; set; }
        }
        public class RandomSymbolMultip
        {
            public int SymbolId { get; set; }
            public int LineNum { get; set; }
            public int Weight { get; set; }
        }

        #endregion

        #region solt_config_base_other
        //private static List<Slot_config_base_otherEO>? _baseOtherList;
        //private static List<Slot_config_base_otherEO> BaseOtherList
        //{
        //    get
        //    {
        //        _baseOtherList ??= new Slot_config_base_otherMO().GetAll();
        //        return _baseOtherList;
        //    }
        //}
        public static List<Slot_config_base_otherPO> GetBaseOtherList() => DbCachingUtil.GetAllList<Slot_config_base_otherPO>();

        #endregion

        public static void Clear()
        {
            //_configDic = null;
             
            // _itemWeightList = null;
            // _poolTypeList = null;
          
            //_baseOtherList = null;
             
            LogUtil.Debug($"Fortune_tiger 执行clear");
        }
    }
    public class WeightColumn
    {
        public int WeightId { get; set; }
        public int IconType { get; set; }
        public int WeightVal { get; set; }
    }
}
