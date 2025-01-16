using Fortune_ox.DAL;
using System.Diagnostics;
using TinyFx;
using TinyFx.DbCaching;

namespace Fortune_ox.BLL.Caching
{
    public static class MemoryUtil
    {
        #region fox_config
        //private static readonly object _syncConfig = new();
        //private static Dictionary<string, Fox_configEO>? _configDic;
        //private static Dictionary<string, Fox_configEO> ConfigDic
        //{
        //    get
        //    {

        //        if (_configDic == null)
        //        {
        //            lock (_syncConfig)
        //            {
        //                if (_configDic == null)
        //                {
        //                    var values = new Dictionary<string, Fox_configEO>();
        //                    foreach (var item in new Fox_configMO().GetAll())
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

        //public static Fox_configEO GetConfig(string operatorId, string currencyId) => ConfigDic[$"{operatorId}|{currencyId}"];


        public static Fox_configPO GetConfig(string operatorId, string currencyId)
        {
            var ret = DbCachingUtil.GetSingle<Fox_configPO>(it => new { it.OperatorID, it.CurrencyID }, new Fox_configPO
            {
                OperatorID = operatorId,
                CurrencyID = currencyId,
            });
            return ret;
        }

        #endregion

        #region fox_config_chips
        //private static readonly object _syncChips = new();
        //private static Dictionary<string, Fox_config_chipsEO>? _chipsDic;
        //public static Dictionary<string, Fox_config_chipsEO> ChipsDic
        //{
        //    get
        //    {

        //        if (_chipsDic == null)
        //        {
        //            lock (_syncChips)
        //            {

        //                if (_chipsDic == null)
        //                {
        //                    var values = new Dictionary<string, Fox_config_chipsEO>();
        //                    foreach (var item in new Fox_config_chipsMO().GetAll())
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

        //public static Fox_config_chipsEO GetChips(int chipsId) => ChipsDic[$"{chipsId}"];

        public static Fox_config_chipsPO GetChips(int chipsId)
        {
            var ret = DbCachingUtil.GetSingle<Fox_config_chipsPO>(it => new { it.ChipsID }, new Fox_config_chipsPO
            {
                ChipsID = chipsId
            });
            return ret;
        }

        public static List<Fox_config_chipsPO> GetChipsList() => DbCachingUtil.GetAllList<Fox_config_chipsPO>();

        #endregion

        #region fox_config_line
        //private static readonly object _syncLine = new();
        //private static List<Fox_config_lineEO>? _lineList;
        //public static List<Fox_config_lineEO> LineList
        //{
        //    get
        //    {
        //        _lineList ??= new Fox_config_lineMO().GetAll();
        //        return _lineList;
        //    }
        //}
        //public static List<Fox_config_lineEO> GetLineList() => LineList.OrderBy(x => x.LineNo).ToList();


        public static List<Fox_config_linePO> LineList =>  DbCachingUtil.GetAllList<Fox_config_linePO>();


        public static List<Fox_config_linePO> GetLineList() => LineList.OrderBy(x => x.LineNo).ToList();

        #endregion

        #region fox_user_lamp

        private static List<Fox_user_lampEO>? _lampList;
        public static List<Fox_user_lampEO> LampList(string operatorId, string currencyId)
        {
            _lampList ??= new Fox_user_lampMO().GetTopSort($"OperatorId='{operatorId}' AND CurrencyId='{currencyId}' ", FortuneUtil.MAXCOUNT, "RecDate DESC");
            return _lampList;
        }

        public static void PutLampList(Fox_user_lampEO lampEo, string operatorId, string currencyId)
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

        public static Fox_user_lampEO GetLampFirst(long timestamp, string operatorId, string currencyId)
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

        #region fox_config_item
        private static List<Fox_config_itemEO>? _itemList;
        private static List<Fox_config_itemEO> ItemList
        {
            get
            {
                _itemList ??= new Fox_config_itemMO().GetAll();
                return _itemList;
            }
        }
        public static Fox_config_itemEO? GetItemById(int itemId) => ItemList.Where(x => x.ItemID == itemId).FirstOrDefault();

        public static List<Fox_config_itemEO> GetItemList() => ItemList;
        #endregion

        #region fox_config_weight_change
         
        private static List<Fox_config_weight_changePO> WeightAll_change=>DbCachingUtil.GetAllList<Fox_config_weight_changePO>();


        public static List<Fox_config_weight_changePO> GetWeightChange()
        {
            return WeightAll_change;
        }
        #endregion

        #region fox_config_tag

        //private static List<Fox_config_tagEO>? _tagList;
        //private static List<Fox_config_tagEO> TagList
        //{
        //    get
        //    {
        //        _tagList ??= new Fox_config_tagMO().GetAll();
        //        return _tagList;
        //    }
        //}

        private static List<Fox_config_tagPO> TagList => DbCachingUtil.GetAllList<Fox_config_tagPO>();

        public static Fox_config_tagPO GetTagByAmount(long betAmount)
        {
            return TagList.Where(x => x.BetAmount <= betAmount && betAmount < x.BetAmountEnd).First();
        }

        #endregion
       
        public static void Clear()
        {
            //_configDic = null;
            //_chipsDic = null;
            //_lampList = null;
            //_lineList = null;
            //_itemList = null;
            //_weightAll_change = null;
            //_tagList = null;
        }
    }
    public class RandomSymbol
    {
        public int SymbolId { get; set; }
        public int Weight { get; set; }
    }
    public class SpecialMode
    {
        public string SymbolGroup { get; set; }
        public int Weight { get; set; }
    }
}
