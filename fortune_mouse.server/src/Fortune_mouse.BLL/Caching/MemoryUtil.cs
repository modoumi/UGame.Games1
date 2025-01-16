using Fortune_mouse.DAL;
using System.Collections.Generic;
using TinyFx;
using TinyFx.DbCaching;
using TinyFx.Logging;

namespace Fortune_mouse.BLL.Caching
{
    public static class MemoryUtil
    {
        #region fmo_config
        //private static readonly object _syncConfig = new();
        //private static Dictionary<string, Fmo_configEO>? _configDic;
        //private static Dictionary<string, Fmo_configEO> ConfigDic
        //{
        //    get
        //    {
        //        if (_configDic == null)
        //        {
        //            lock (_syncConfig)
        //            {
        //                if (_configDic == null)
        //                {
        //                    var values = new Dictionary<string, Fmo_configEO>();
        //                    foreach (var item in new Fmo_configMO().GetAll())
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

        //public static Fmo_configEO GetConfig(string operatorId, string currencyId) => ConfigDic[$"{operatorId}|{currencyId}"];

        public static Fmo_configPO GetConfig(string operatorId, string currencyId)
        {
            var ret = DbCachingUtil.GetSingle<Fmo_configPO>(it => new { it.OperatorID, it.CurrencyID }, new Fmo_configPO
            {
                OperatorID = operatorId,
                CurrencyID = currencyId,
            });
            return ret;
        }

        #endregion

        #region fmo_config_chips
        //private static readonly object _syncChips = new();
        //private static Dictionary<string, Fmo_config_chipsEO>? _chipsDic;
        //public static Dictionary<string, Fmo_config_chipsEO> ChipsDic
        //{
        //    get
        //    {
        //        if (_chipsDic == null)
        //        {
        //            lock (_syncChips)
        //            {

        //                if (_chipsDic == null)
        //                {
        //                    var values = new Dictionary<string, Fmo_config_chipsEO>();
        //                    foreach (var item in new Fmo_config_chipsMO().GetAll())
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

        //public static Fmo_config_chipsEO GetChips(int chipsId) => ChipsDic[$"{chipsId}"];

        //public static List<Fmo_config_chipsEO> GetChipsList() => ChipsDic.Select(x => x.Value).ToList();


        public static Fmo_config_chipsPO GetChips(int chipsId)
        {
            var ret = DbCachingUtil.GetSingle<Fmo_config_chipsPO>(it => new { it.ChipsID }, new Fmo_config_chipsPO
            {
                ChipsID = chipsId
            });
            return ret;
        }

        public static List<Fmo_config_chipsPO> GetChipsList() => DbCachingUtil.GetAllList<Fmo_config_chipsPO>();

        #endregion

        #region fmo_config_line
        //private static List<Fmo_config_lineEO>? _lineList;
        //public static List<Fmo_config_lineEO> LineList
        //{
        //    get
        //    {
        //        _lineList ??= new Fmo_config_lineMO().GetAll();
        //        return _lineList;
        //    }
        //}
        //public static List<Fmo_config_lineEO> GetLineList() => LineList.OrderBy(x => x.LineNo).ToList();


        public static List<Fmo_config_linePO> LineList()
        {
            return DbCachingUtil.GetAllList<Fmo_config_linePO>();
        }

        public static List<Fmo_config_linePO> GetLineList() => LineList().OrderBy(x => x.LineNo).ToList();

        #endregion

        #region fmo_config_symbol
        //private static List<Fmo_config_symbolEO>? _symbolList;
        //private static List<Fmo_config_symbolEO> SymbolList
        //{
        //    get
        //    {
        //        _symbolList ??= new Fmo_config_symbolMO().GetAll();
        //        return _symbolList;
        //    }
        //}
        //public static Fmo_config_symbolEO? GetSymbolById(int symbolId)
        //    => SymbolList.Where(x => x.SymbolID == symbolId).FirstOrDefault();

        //public static List<Fmo_config_symbolEO> GetSymbolList()
        //    => SymbolList;

        public static Fmo_config_symbolPO? GetSymbolById(int symbolId)
    => DbCachingUtil.GetSingle<Fmo_config_symbolPO>(it => new { it.SymbolID }, new Fmo_config_symbolPO
    {
        SymbolID = symbolId
    });
        public static List<Fmo_config_symbolPO> GetSymbolList()
            => DbCachingUtil.GetAllList<Fmo_config_symbolPO>();

        #endregion

        #region fmo_config_tag
        //private static List<Fmo_config_tagEO>? _tagList;
        //private static List<Fmo_config_tagEO> TagList
        //{
        //    get
        //    {
        //        _tagList ??= new Fmo_config_tagMO().GetAll();
        //        return _tagList;
        //    }
        //}
        private static List<Fmo_config_tagPO> TagList => DbCachingUtil.GetAllList<Fmo_config_tagPO>();
        /*  /// <summary>
          /// 获取用户标签symbol
          /// </summary>
          /// <param name="betAmount"></param>
          /// <returns></returns>
          public static List<RandomSymbol> TagWeight_SM(long betAmount)
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
          public static List<RandomSymbolMultip> TagRSM(Fmo_config_tagEO tagEo)
          {
              var tagEo = GetTagByAmount(betAmount);
              LogUtil.Debug($"用户标签 RandomSymbolMultip -> Bid: {tagEo.BID},betAmount:{betAmount}");
              return SerializerUtil.DeserializeJson<List<RandomSymbolMultip>>(tagEo.RandomSymbolMultip);
          }
          public static List<List<RandomSymbol>> TagWeight_Main(long betAmount)
          {
              var tagEo = GetTagByAmount(betAmount);
              LogUtil.Debug($"用户标签 Weight -> Bid:{tagEo.BID},betAmount:{betAmount}");
              return SerializerUtil.DeserializeJson<List<List<RandomSymbol>>>(tagEo.WeightList);
          }*/

        public static Fmo_config_tagPO GetTagByAmount(long betAmount)
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

        public static void Clear()
        {
            //_configDic = null;
            //_chipsDic = null;
            //_lineList = null;
            //_symbolList = null;
            //_tagList = null;
        }
    }
    public class WeightColumn
    {
        public int WeightId { get; set; }
        public int IconType { get; set; }
        public int WeightVal { get; set; }
    }
}
