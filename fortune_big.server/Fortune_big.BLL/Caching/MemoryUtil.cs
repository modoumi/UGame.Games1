using Fortune_big.DAL;
using Google.Protobuf.WellKnownTypes;
using System.Collections.Generic;
using TinyFx;
using TinyFx.Caching;
using TinyFx.DbCaching;
using TinyFx.Logging;
using Xxyy.DAL;

namespace Fortune_big.BLL.Caching
{
    public static class MemoryUtil
    {
        #region big_config
        //private static readonly object _syncConfig = new();
        //private static Dictionary<string, Big_configEO>? _configDic;
        //private static Dictionary<string, Big_configEO> ConfigDic
        //{
        //    get
        //    {
        //        if (_configDic == null)
        //        {
        //            lock (_syncConfig)
        //            {
        //                if (_configDic == null)
        //                {
        //                    var values = new Dictionary<string, Big_configEO>();
        //                    foreach (var item in new Big_configMO().GetAll())
        //                    {
        //                        var key = $"{item.OperatorID}|{item.CurrencyID}";
        //                        values.Add(key, item);
        //                    }
        //                    _configDic = values;
        //                }
        //            }
        //        }
        //        return _configDic;
        //    }
        //}

        //public static Big_configEO GetConfig(string operatorId, string currencyId) => ConfigDic[$"{operatorId}|{currencyId}"];


        public static Big_configPO GetConfig(string operatorId, string currencyId)
        {
            var ret = DbCachingUtil.GetSingle<Big_configPO>(it => new { it.OperatorID, it.CurrencyID }, new Big_configPO
            {
                OperatorID = operatorId,
                CurrencyID = currencyId,
            });
            return ret;
        }


        #endregion

        #region big_config_chips
        //private static readonly object _syncChips = new();
        //private static Dictionary<string, Big_config_chipsEO>? _chipsDic;
        //public static Dictionary<string, Big_config_chipsEO> ChipsDic
        //{
        //    get
        //    {
        //        if (_chipsDic == null)
        //        {
        //            lock (_syncChips)
        //            {

        //                if (_chipsDic == null)
        //                {
        //                    var values = new Dictionary<string, Big_config_chipsEO>();
        //                    foreach (var item in new Big_config_chipsMO().GetAll())
        //                    {
        //                        var key = $"{item.ChipsID}";
        //                        values.Add(key, item);
        //                    }
        //                    _chipsDic = values;
        //                }
        //            }
        //        }
        //        return _chipsDic;
        //    }
        //}

        //public static Big_config_chipsEO GetChips(int chipsId) => ChipsDic[$"{chipsId}"];

        public static Big_config_chipsPO GetChips(int chipsId)
        {
            var ret = DbCachingUtil.GetSingle<Big_config_chipsPO>(it => new { it.ChipsID}, new Big_config_chipsPO
            {
                ChipsID = chipsId
            });
            return ret;
        }

        public static List<Big_config_chipsPO> GetChipsList() => DbCachingUtil.GetAllList<Big_config_chipsPO>();

        #endregion

        #region big_config_line
        //private static List<Big_config_lineEO>? _lineList;
        //public static List<Big_config_lineEO> LineList
        //{
        //    get
        //    {
        //        _lineList ??= new Big_config_lineMO().GetAll();
        //        return _lineList;
        //    }
        //}

        public static List<Big_config_linePO> LineList()
        {
            return DbCachingUtil.GetAllList<Big_config_linePO>();
        }

        public static List<Big_config_linePO> GetLineList() => LineList().OrderBy(x => x.LineID).ToList();

        #endregion

        #region big_config_symbol
        //private static List<Big_config_symbolEO>? _symbolList;
        //private static List<Big_config_symbolEO> SymbolList
        //{
        //    get
        //    {
        //        _symbolList ??= new Big_config_symbolMO().GetAll();
        //        return _symbolList;
        //    }
        //}
        //public static Big_config_symbolEO? GetSymbolById(int symbolId)
        //    => SymbolList.Where(x => x.SymbolID == symbolId).FirstOrDefault();

        //public static List<Big_config_symbolEO> GetSymbolList()
        //    => SymbolList;

        public static Big_config_symbolPO? GetSymbolById(int symbolId)
            => DbCachingUtil.GetSingle<Big_config_symbolPO>(it => new { it.SymbolID }, new Big_config_symbolPO
            {
                SymbolID = symbolId
            });
        public static List<Big_config_symbolPO> GetSymbolList()
            => DbCachingUtil.GetAllList<Big_config_symbolPO>();
        #endregion

        #region big_config_symbol_group
        /* private static List<Big_config_symbol_groupEO>? _itemWeightGroupList;
         public static List<Big_config_symbol_groupEO> ItemWeightGroupList
         {
             get
             {
                 _itemWeightGroupList ??= new Big_config_symbol_groupMO().GetAll();
                 return _itemWeightGroupList;
             }
         }
         public static List<Big_config_symbol_groupEO> GetWeightGroupList(int lineNum)
             => ItemWeightGroupList.Where(o => o.LineNum == lineNum && o.Weight == 1).ToList();
         public static Big_config_symbol_groupEO GetWeightGroup(int lineNum)
         {
             lineNum = lineNum > 5 ? 5 : lineNum;
             return GetWeightGroupList(lineNum).OrderBy(x => Guid.NewGuid()).First();
         }*/
        #endregion

        #region big_config_tag
        //private static List<Big_config_tagEO>? _tagList;
        //private static List<Big_config_tagEO> TagList
        //{
        //    get
        //    {
        //        _tagList ??= new Big_config_tagMO().GetAll();
        //        return _tagList;
        //    }
        //}
       private static List<Big_config_tagPO> TagList=> DbCachingUtil.GetAllList<Big_config_tagPO>();

        public static Big_config_tagPO GetTagByAmount(long betAmount)
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

        #region big_config_weight_t

        public static List<Big_config_weight_tPO> Weight_tList => DbCachingUtil.GetAllList<Big_config_weight_tPO>();


        public static List<Big_config_weight_tPO> GetWeight_tList() => Weight_tList.OrderBy(x => x.TID).ToList();
        public static Big_config_weight_tPO GetWeightList_t_ByID(int itemId)
        {
            return Weight_tList.Where(x => x.TID == itemId).FirstOrDefault();
        }
        #endregion

        public static void Clear()
        {
            //_configDic = null;
            //_chipsDic = null;
            //_lineList = null;
            //_symbolList = null;
            //_tagList = null;
            //_weight_tList = null;
        }
    }
}
