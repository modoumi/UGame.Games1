using Super_phoenix.BLL.Core;
using Super_phoenix.DAL;
using TinyFx;
using TinyFx.DbCaching;

namespace Super_phoenix.BLL.Caching
{
    public static class MemoryUtil
    {
        #region gsp_config
        //private static readonly object _syncConfig = new();
        //private static Dictionary<string, Gsp_configEO>? _configDic;
        //private static Dictionary<string, Gsp_configEO> ConfigDic
        //{
        //    get
        //    {

        //        if (_configDic == null)
        //        {
        //            lock (_syncConfig)
        //            {
        //                if (_configDic == null)
        //                {
        //                    var values = new Dictionary<string, Gsp_configEO>();
        //                    foreach (var item in new Gsp_configMO().GetAll())
        //                    {
        //                        var key = item.OperatorID + item.CurrencyID;
        //                        values.Add(key, item);
        //                    }
        //                    _configDic = values;
        //                }
        //            }
        //        }
        //        return _configDic;
        //    }
        //}

        //public static Gsp_configEO GetConfig(string operatorId, string currencyId) => ConfigDic[(operatorId + currencyId)];


        public static Gsp_configPO GetConfig(string operatorId, string currencyId)
        {
            var ret = DbCachingUtil.GetSingle<Gsp_configPO>(it => new { it.OperatorID, it.CurrencyID }, new Gsp_configPO
            {
    
                OperatorID = operatorId,
                CurrencyID = currencyId,
            });
            return ret;
        }

        #endregion

        #region gsp_config_chips
        //private static readonly object _syncChips = new();
        //private static Dictionary<int, Gsp_config_chipsEO>? _chipsDic;
        //public static Dictionary<int, Gsp_config_chipsEO> ChipsDic
        //{
        //    get
        //    {

        //        if (_chipsDic == null)
        //        {
        //            lock (_syncChips)
        //            {
        //                if (_chipsDic == null)
        //                {
        //                    var values = new Dictionary<int, Gsp_config_chipsEO>();
        //                    foreach (var item in new Gsp_config_chipsMO().GetAll())
        //                    {
        //                        values.Add(item.ChipsID, item);
        //                    }
        //                    _chipsDic = values;
        //                }
        //            }
        //        }
        //        return _chipsDic;
        //    }
        //}

        //public static Gsp_config_chipsEO GetChips(int chipsId) => ChipsDic[chipsId];

        //public static List<Gsp_config_chipsEO> GetChipsList() => ChipsDic.Select(x => x.Value).ToList();



        public static Gsp_config_chipsPO GetChips(int chipsId)
        {
            var ret = DbCachingUtil.GetSingle<Gsp_config_chipsPO>(it => new { it.ChipsID }, new Gsp_config_chipsPO
            {
                ChipsID = chipsId
            });
            return ret;
        }

        public static List<Gsp_config_chipsPO> GetChipsList() => DbCachingUtil.GetAllList<Gsp_config_chipsPO>();


        #endregion

        #region gsp_config_line
        
        public static List<Gsp_config_linePO> LineList => DbCachingUtil.GetAllList<Gsp_config_linePO>();

        public static List<Gsp_config_linePO> GetLineList() => LineList.OrderBy(x => x.LineNo).ToList();
        #endregion

        #region gsp_config_multip
        
        public static List<Gsp_config_multipPO> MultipLis=> DbCachingUtil.GetAllList<Gsp_config_multipPO>();

        public static List<Gsp_config_multipPO> GetMultipList() => MultipLis;
        public static Gsp_config_multipPO GetMultip(int itemId)
        {
            try
            {
                return GetMultipList().First(x => x.ItemID == itemId);
            }
            catch (Exception e)
            {
                throw new Exception($"itemId:{itemId},ex:{e}");
            }

        }
        public static Gsp_config_multipPO? GetMaxMultip()
        {
            return GetMultipList().MaxBy(x => x.Multip5);
        }
        #endregion

        #region gsp_config_weight  

        /*private static readonly object _syncWeight = new();
        private static Dictionary<int, Gsp_config_weightEO>? _weightDic;
        public static Dictionary<int, Gsp_config_weightEO> WeightDic
        {
            get
            {
                if (_weightDic == null)
                {
                    lock (_syncWeight)
                    {
                        if (_weightDic == null)
                        {
                            var values = new Dictionary<int, Gsp_config_weightEO>();
                            foreach (var item in new Gsp_config_weightMO().GetAll())
                            {
                                values.Add(item.ItemID, item);
                            }
                            _weightDic = values;
                        }
                    }
                }
                return _weightDic;
            }
        }*/
   
        public static List<Gsp_config_weightPO> WeightAll => DbCachingUtil.GetAllList<Gsp_config_weightPO>();

        public static List<Gsp_config_weightPO> GetWeightList(int itemType)
        {
            return WeightAll.Where(x => x.ItemType == itemType)
                .OrderBy(x => x.ItemID).ToList();
        }

        public static List<List<WeightColumn>> GetBuildWeight(GameItemType itemType)
        {
            var values = GetWeightList((int)itemType);
            return BuildWeight(values);
        }

        private static List<List<WeightColumn>> BuildWeight(List<Gsp_config_weightPO> values)
        {
            List<List<WeightColumn>> list = new();
            var Weight1 = new List<WeightColumn>();
            var Weight2 = new List<WeightColumn>();
            var Weight3 = new List<WeightColumn>();
            var Weight4 = new List<WeightColumn>();
            var Weight5 = new List<WeightColumn>();

            foreach (var item in values)
            {
                Weight1.Add(new WeightColumn { WeightId = item.ItemID, WeightVal = item.Weight1, IconType = item.IconType });
                Weight2.Add(new WeightColumn { WeightId = item.ItemID, WeightVal = item.Weight2, IconType = item.IconType });
                Weight3.Add(new WeightColumn { WeightId = item.ItemID, WeightVal = item.Weight3, IconType = item.IconType });
                Weight4.Add(new WeightColumn { WeightId = item.ItemID, WeightVal = item.Weight4, IconType = item.IconType });
                Weight5.Add(new WeightColumn { WeightId = item.ItemID, WeightVal = item.Weight5, IconType = item.IconType });
            }
            list.Add(Weight1);
            list.Add(Weight2);
            list.Add(Weight3);
            list.Add(Weight4);
            list.Add(Weight5);
            return list;
        }

        #endregion

        #region gsp_user_ext
        private static readonly object _syncExt = new();
        private static Dictionary<string, Gsp_user_dataEO>? _userDataDic;
        private static Dictionary<string, Gsp_user_dataEO> UserDataDic
        {
            get
            {
                if (_userDataDic == null)
                {
                    lock (_syncExt)
                    {
                        if (_userDataDic == null)
                        {
                            var values = new Dictionary<string, Gsp_user_dataEO>();
                            foreach (var item in new Gsp_user_dataMO().GetAll())
                            {
                                string key = item.UserID + "_" + item.ChipsID;
                                if (!values.ContainsKey(key))
                                    values.Add(key, item);
                            }
                            _userDataDic = values;
                        }
                    }
                }
                return _userDataDic;
            }
        }
        public static List<Gsp_user_dataEO> GetUserDataList(string userId)
        {
            Gsp_user_dataMO _userMo = new();
            return _userMo.GetByUserID(userId);
        }
        public static Gsp_user_dataEO? GetUserData(string userId, int chipsId)
        {
            return GetUserDataList(userId).FirstOrDefault(x => x.ChipsID == chipsId);
        }
        #endregion

        #region gsp_user_lamp

        private static List<Gsp_user_lampEO>? _lampList;
        public static List<Gsp_user_lampEO> LampList(string operatorId, string currencyId)
        {
            _lampList ??= new Gsp_user_lampMO().GetTopSort($"OperatorId='{operatorId}' AND CurrencyId='{currencyId}' ", SuperUtil.MAXCOUNT, "RecDate DESC");
            return _lampList;
        }

        public static void PutLampList(Gsp_user_lampEO lampEo, string operatorId, string currencyId)
        {
            var list = LampList(operatorId, currencyId);
            list.Insert(0, lampEo);
            if (list.Count > SuperUtil.MAXCOUNT)
            {
                for (int i = SuperUtil.MAXCOUNT; i < list.Count; i++)
                {
                    list.RemoveAt(i);
                }
            }
        }

        public static Gsp_user_lampEO GetLampFirst(long timestamp, string operatorId, string currencyId)
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
        public static void Clear()
        {
         
            _lampList = null;
            
        }
    }
    public class WeightColumn
    {
        public int WeightId { get; set; }
        public int IconType { get; set; }
        public int WeightVal { get; set; }
    }
}
