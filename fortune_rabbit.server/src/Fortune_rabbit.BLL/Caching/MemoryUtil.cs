using Fortune_rabbit.DAL;
using TinyFx;
using TinyFx.DbCaching;

namespace Fortune_rabbit.BLL.Caching
{
    public static class MemoryUtil
    {
        #region fra_config
        //private static readonly object _syncConfig = new();
        //private static Dictionary<string, Fra_configEO>? _configDic;
        //private static Dictionary<string, Fra_configEO> ConfigDic
        //{
        //    get
        //    {

        //        if (_configDic == null)
        //        {
        //            lock (_syncConfig)
        //            {
        //                if (_configDic == null)
        //                {
        //                    var values = new Dictionary<string, Fra_configEO>();
        //                    foreach (var item in new Fra_configMO().GetAll())
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

        //public static Fra_configEO GetConfig(string operatorId, string currencyId) => ConfigDic[$"{operatorId}|{currencyId}"];


        public static Fra_configPO GetConfig(string operatorId, string currencyId)
        {
            var ret = DbCachingUtil.GetSingle<Fra_configPO>(it => new { it.OperatorID, it.CurrencyID }, new Fra_configPO
            {
                OperatorID = operatorId,
                CurrencyID = currencyId,
            });
            return ret;
        }

        #endregion

        #region fra_config_chips
        //private static readonly object _syncChips = new();
        //private static Dictionary<string, Fra_config_chipsEO>? _chipsDic;
        //public static Dictionary<string, Fra_config_chipsEO> ChipsDic
        //{
        //    get
        //    {

        //        if (_chipsDic == null)
        //        {
        //            lock (_syncChips)
        //            {

        //                if (_chipsDic == null)
        //                {
        //                    var values = new Dictionary<string, Fra_config_chipsEO>();
        //                    foreach (var item in new Fra_config_chipsMO().GetAll())
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

        //public static Fra_config_chipsEO GetChips(int chipsId) => ChipsDic[$"{chipsId}"];


        public static Fra_config_chipsPO GetChips(int chipsId)
        {
            var ret = DbCachingUtil.GetSingle<Fra_config_chipsPO>(it => new { it.ChipsID }, new Fra_config_chipsPO
            {
                ChipsID = chipsId
            });
            return ret;
        }

        public static List<Fra_config_chipsPO> GetChipsList => DbCachingUtil.GetAllList<Fra_config_chipsPO>();

        #endregion

        #region fra_config_line
        //private static readonly object _syncLine = new();
        //private static List<Fra_config_lineEO>? _lineList;
        //public static List<Fra_config_lineEO> LineList
        //{
        //    get
        //    {
        //        _lineList ??= new Fra_config_lineMO().GetAll();
        //        return _lineList;
        //    }
        //}
        //public static List<Fra_config_lineEO> GetLineList() => LineList.OrderBy(x => x.LineNo).ToList();


        public static List<Fra_config_linePO> LineList()
        {
            return DbCachingUtil.GetAllList<Fra_config_linePO>();
        }

        public static List<Fra_config_linePO> GetLineList() => LineList().OrderBy(x => x.LineNo).ToList();

        #endregion

        #region fra_config_weight_t

        private static List<Fra_config_weight_tPO> WeightAll_t => DbCachingUtil.GetAllList<Fra_config_weight_tPO>();


        public static List<Fra_config_weight_tPO> GetWeightList_t()
        {
            return WeightAll_t.OrderBy(x => x.TID).ToList();
        }
        public static Fra_config_weight_tPO GetWeightList_t_ByID(int itemId)
        {
            return WeightAll_t.Where(x => x.TID == itemId).FirstOrDefault();
        }
        #endregion

        #region fra_config_weight
        
        public static List<Fra_config_weightPO> WeightAll=> DbCachingUtil.GetAllList<Fra_config_weightPO>();

        public static List<Fra_config_weightPO> GetWeightList()
        {
            return WeightAll.OrderBy(x => x.ItemID).ToList();
        }

        /// <summary>
        /// 构建N列对象
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static List<List<WeightColumn>> BuildWeight()
        {
            List<List<WeightColumn>> list = new();
            var Weight1 = new List<WeightColumn>();
            var Weight2 = new List<WeightColumn>();
            var Weight3 = new List<WeightColumn>();

            foreach (var item in GetWeightList())
            {
                Weight1.Add(new WeightColumn { WeightId = item.ItemID, WeightVal = item.Weight1, IconType = item.IconType });
                Weight2.Add(new WeightColumn { WeightId = item.ItemID, WeightVal = item.Weight2, IconType = item.IconType });
                Weight3.Add(new WeightColumn { WeightId = item.ItemID, WeightVal = item.Weight3, IconType = item.IconType });
            }
            list.Add(Weight1);
            list.Add(Weight2);
            list.Add(Weight3);
            return list;
        }

        #endregion

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

        #region fra_config_item
      
        private static List<Fra_config_itemPO> ItemList=> DbCachingUtil.GetAllList<Fra_config_itemPO>();

        public static Fra_config_itemPO? GetItemById(int itemId) => ItemList.Where(x => x.ItemID == itemId).FirstOrDefault();

        public static List<Fra_config_itemPO> GetItemList() => ItemList;
        #endregion

        public static void Clear()
        {
            //_configDic = null;
            //_chipsDic = null;
            //_lineList = null;
            //_weightAll = null;
            //_weightAll_t = null;
            //_itemList = null;
        }
    }
    public class WeightColumn
    {
        public int WeightId { get; set; }
        public int IconType { get; set; }
        public int WeightVal { get; set; }
    }
}
