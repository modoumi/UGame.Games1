using Mexico_fortune.DAL;
using TinyFx.Collections;
using TinyFx.DbCaching;
using TinyFx.Randoms;

namespace Mexico_fortune.BLL.Caching
{
    public static class GmfDBCacheUtil
    {
        #region gmf_config
        //private static Gmf_configEO _config;
        //private static Gmf_configEO Config
        //{
        //    get
        //    {
        //        if (_config == null)
        //        {
        //            _config = new Gmf_configMO().GetSingle();
        //        }
        //        return _config;
        //    }
        //}

        private static Gmf_configPO Config=> DbCachingUtil.GetAllList<Gmf_configPO>().FirstOrDefault();
        public static Gmf_configPO GetConfig() => Config;
        private static int[] _winTypeMulti;
        public static int[] GetWinTypeMulti()
        {
            if (_winTypeMulti == null)
            {
                _winTypeMulti = new int[] { Config.BigWin, Config.MegaWin, Config.SuperWin, Config.EpicWin };
            }
            return _winTypeMulti;
        }

        #endregion

        #region gmf_chips
        private static object _sync = new object();
        //private static Dictionary<int, Gmf_chipsEO> _chipsDic;
        private static Dictionary<int, Gmf_chipsPO> ChipsDic
        {
            get
            {
                //if (_chipsDic == null)
                //{
                //    lock (_sync)
                //    {
                //        if (_chipsDic == null)
                //        {
                Dictionary<int, Gmf_chipsPO> _chipsDic = new Dictionary<int, Gmf_chipsPO>();
                var v= DbCachingUtil.GetAllList<Gmf_chipsPO>();

                var values = new Dictionary<int, Gmf_chipsPO>();
                            foreach (var item in v)
                                values.Add(item.ChipsID, item);
                            _chipsDic = values;
                        //}
                    //}
                //}
                return _chipsDic;
            }
        }
        public static Gmf_chipsPO GetChips(int chipsId)
            => ChipsDic[chipsId];
        //private static Dictionary<string, List<LoadChips>> _loadChipsDic;
        public static List<LoadChips> GetLoadChips(string currencyId)
        {
            //if (_loadChipsDic == null)
            //{
            //    lock (_sync)
            //    {
            //        if (_loadChipsDic == null)
            //        {
            Dictionary<string, List<LoadChips>> _loadChipsDic=new Dictionary<string, List<LoadChips>>();

            var values = new Dictionary<string, List<LoadChips>>();
                        var items = ChipsDic.Values.ToList().OrderBy(x => x.CurrencyID).ThenBy(x => x.BetMoney).ToList();
                        foreach (var item in items)
                        {
                            var newValue = new LoadChips
                            {
                                ChipsId = item.ChipsID,
                                BetMoney = item.BetMoney,
                                JpBonusList = new List<int> { item.JPMini, item.JPMinor, item.JPMajor, item.JPGrand }
                            };
                            if (values.TryGetValue(item.CurrencyID, out var list))
                            {
                                list.Add(newValue);
                            }
                            else
                            {
                                values.Add(item.CurrencyID, new List<LoadChips>() { newValue });
                            }
                        }
                        _loadChipsDic = values;
            //        }
            //    }
            //}
            return _loadChipsDic[currencyId];
        }
        #endregion

        #region gmf_symbol
        //private static Dictionary<int, Gmf_symbolEO> _symbols;
        //private static Dictionary<int, Gmf_symbolEO> Symbols
        //{
        //    get
        //    {
        //        if (_symbols == null)
        //        {
        //            lock (_sync)
        //            {
        //                if (_symbols == null)
        //                {
        //                    var values = new Dictionary<int, Gmf_symbolEO>();
        //                    foreach (var item in new Gmf_symbolMO().GetAll())
        //                        values.Add(item.SymbolID, item);
        //                    _symbols = values;
        //                }
        //            }
        //        }
        //        return _symbols;
        //    }
        //}

        private static List<Gmf_symbolPO> Symbols=> DbCachingUtil.GetAllList<Gmf_symbolPO>();


        public static List<LoadSlotEle> GetSlotEles()
        {
            List<LoadSlotEle> _slotEles = new List<LoadSlotEle>();
            var values = new List<LoadSlotEle>();
            var items = Symbols.OrderBy(x => x.SymbolID);
            foreach (var item in items)
            {
                var value = new LoadSlotEle
                {
                    Id = item.SymbolID,
                    Type = item.Type,
                    MultiList = new List<double>()
                };
                for (int i = 3; i < 6; i++)
                {
                    if (TryGetPayTable(item.SymbolID, i, out Gmf_paytablePO v))
                        value.MultiList.Add(v.Multip);
                }
                values.Add(value);
            }
            _slotEles = values;

            return _slotEles;
        }
        #endregion

        #region gmf_line
        //private static Dictionary<int, Gmf_lineEO> _lineDic;
        //private static Dictionary<int, Gmf_lineEO> LineDic
        //{
        //    get
        //    {
        //        if (_lineDic == null)
        //        {
        //            lock (_sync)
        //            {
        //                if (_lineDic == null)
        //                {
        //                    var values = new Dictionary<int, Gmf_lineEO>();
        //                    foreach (var item in new Gmf_lineMO().GetAll())
        //                        values.Add(item.LineID, item);
        //                    _lineDic = values;
        //                }
        //            }
        //        }
        //        return _lineDic;
        //    }
        //}

        private static List<Gmf_linePO> LineDic=> DbCachingUtil.GetAllList<Gmf_linePO>();
        public static Gmf_linePO GetLine(int lineId)
            => LineDic.FirstOrDefault(c=>c.LineID==lineId);

        public static List<int[]> GetLines()
        {
            List<int[]> _lines = new List<int[]>();
            var values = new List<int[]>();
            var items = LineDic.OrderBy(x => x.LineID);
            foreach (var item in items)
                values.Add(new int[] { item.Row1, item.Row2, item.Row3, item.Row4, item.Row5 });
            _lines = values;

            return _lines;
        }

        #endregion

        #region gmf_paytable
        //private static Dictionary<string, Gmf_paytableEO> _paytableDic;
        private static Dictionary<string, Gmf_paytablePO> PaytableDic
        {
            get
            {
                Dictionary<string, Gmf_paytablePO> _paytableDic = new Dictionary<string, Gmf_paytablePO>();

                var values = new Dictionary<string, Gmf_paytablePO>();
                var v = DbCachingUtil.GetAllList<Gmf_paytablePO>();

                foreach (var item in v)
                    values.Add(GetPaytableKey(item.SymbolID, item.Count), item);

                _paytableDic = values;

                return _paytableDic;
            }
        }
        private static string GetPaytableKey(int sid, int count)
            => $"{sid}|{count}";
        public static bool TryGetPayTable(int sid, int count, out Gmf_paytablePO value)
        {
            return PaytableDic.TryGetValue(GetPaytableKey(sid, count), out value);
        }
        #endregion

        #region gmf_multip_weight
        //private static Dictionary<int, Gmf_multip_weightEO> _multipWeightDic0;
        private static Dictionary<int, Gmf_multip_weightPO> MultipWeightDic0
        {
            get
            {
                Dictionary<int, Gmf_multip_weightPO> _multipWeightDic0 = new Dictionary<int, Gmf_multip_weightPO>();

                var values = new Dictionary<int, Gmf_multip_weightPO>();
                var v = DbCachingUtil.GetAllList<Gmf_multip_weightPO>().Where(c=>c.SNum==0);


                            foreach (var item in v)
                                values.Add(item.Multip, item);
                            _multipWeightDic0 = values;
               
                return _multipWeightDic0;
            }
        }
        private static WeightRandomProvider<Gmf_multip_weightPO> _multipWeightRandom0;
        private static WeightRandomProvider<Gmf_multip_weightPO> GetMultipWeightRandom0()
        {
            if (_multipWeightRandom0 == null)
            {
                lock (_sync)
                {
                    if (_multipWeightRandom0 == null)
                    {
                        _multipWeightRandom0 = new WeightRandomProvider<Gmf_multip_weightPO>();
                        foreach (var item in MultipWeightDic0.Values)
                            _multipWeightRandom0.AddItem(item.Weight, item);
                    }
                }
            }
            return _multipWeightRandom0;
        }

    
        private static Dictionary<int, Gmf_multip_weightPO> MultipWeightDic1
        {
            get
            {
                Dictionary<int, Gmf_multip_weightPO> _multipWeightDic1 = new Dictionary<int, Gmf_multip_weightPO>();
                var values = new Dictionary<int, Gmf_multip_weightPO>();

                var v = DbCachingUtil.GetAllList<Gmf_multip_weightPO>().Where(c => c.SNum == 1);

                foreach (var item in v)
                    values.Add(item.Multip, item);
                _multipWeightDic1 = values;

                return _multipWeightDic1;
            }
        }
        private static WeightRandomProvider<Gmf_multip_weightPO> _multipWeightRandom1;
        private static WeightRandomProvider<Gmf_multip_weightPO> GetMultipWeightRandom1()
        {
            if (_multipWeightRandom1 == null)
            {
                lock (_sync)
                {
                    if (_multipWeightRandom1 == null)
                    {
                        _multipWeightRandom1 = new WeightRandomProvider<Gmf_multip_weightPO>();
                        foreach (var item in MultipWeightDic1.Values)
                            _multipWeightRandom1.AddItem(item.Weight, item);
                    }
                }
            }
            return _multipWeightRandom1;
        }
        public static Gmf_multip_weightPO GetRandomMultip(int snum = 0)
        {
            if (snum == 0)
            {
                return GetMultipWeightRandom0().Next();
            }
            else
            {
                return GetMultipWeightRandom1().Next();
            }
        }
        #endregion

        #region gmf_bingo_weight
        //private static Dictionary<int, Gmf_bingo_weightEO> _bingoWeightDic;
        //private static Dictionary<int, Gmf_bingo_weightEO> BingoWeightDic
        //{
        //    get
        //    {
        //        if (_bingoWeightDic == null)
        //        {
        //            lock (_sync)
        //            {
        //                if (_bingoWeightDic == null)
        //                {
        //                    var values = new Dictionary<int, Gmf_bingo_weightEO>();
        //                    foreach (var item in new Gmf_bingo_weightMO().GetAll())
        //                        values.Add(item.JPPoolID, item);
        //                    _bingoWeightDic = values;
        //                }
        //            }
        //        }
        //        return _bingoWeightDic;
        //    }
        //}

      


        private static WeightRandomProvider<Gmf_bingo_weightPO> _bingoWeightRandom;
        private static WeightRandomProvider<Gmf_bingo_weightPO> GetBingoWeightRandom()
        {
            if (_bingoWeightRandom == null)
            {
                lock (_sync)
                {
                    if (_bingoWeightRandom == null)
                    {
                        _bingoWeightRandom = new WeightRandomProvider<Gmf_bingo_weightPO>();
                        DbCachingUtil.GetAllList<Gmf_bingo_weightPO>().ForEach(x => _bingoWeightRandom.AddItem(x.Weight, x));
                    }
                }
            }
            return _bingoWeightRandom;
        }
        public static Gmf_bingo_weightEO GetBingoJPPool()
        {
            return GetBingoWeightRandom().Next();
        }
        #endregion

        #region gmf_bingo_num_weight
        //private static Dictionary<int, Gmf_bingo_num_weightEO> _bingoNumWeightDic;
        //private static Dictionary<int, Gmf_bingo_num_weightEO> BingoNumWeightDic
        //{
        //    get
        //    {
        //        if (_bingoNumWeightDic == null)
        //        {
        //            lock (_sync)
        //            {
        //                if (_bingoNumWeightDic == null)
        //                {
        //                    var values = new Dictionary<int, Gmf_bingo_num_weightEO>();
        //                    foreach (var item in new Gmf_bingo_num_weightMO().GetAll())
        //                        values.Add(item.BingoNum, item);
        //                    _bingoNumWeightDic = values;
        //                }
        //            }
        //        }
        //        return _bingoNumWeightDic;
        //    }
        //}
        private static WeightRandomProvider<Gmf_bingo_num_weightPO> _bingoNumWeight;
        private static WeightRandomProvider<Gmf_bingo_num_weightPO> GetBingoNumWeight()
        {
            if (_bingoNumWeight == null)
            {
                lock (_sync)
                {
                    if (_bingoNumWeight == null)
                    {
                        _bingoNumWeight = new WeightRandomProvider<Gmf_bingo_num_weightPO>();
                        DbCachingUtil.GetAllList<Gmf_bingo_num_weightPO>().ForEach(x => _bingoNumWeight.AddItem(x.Weight, x));
                    }
                }
            }
            return _bingoNumWeight;
        }
        public static int GetBingoNumCount()
            => GetBingoNumWeight().Next().BingoNum;
        #endregion

        #region gmf_bonus_weight
        //private static Dictionary<int, Gmf_bonus_weightEO> _bonusWeightDic;
        //private static Dictionary<int, Gmf_bonus_weightEO> BonusWeightDic
        //{
        //    get
        //    {
        //        if (_bonusWeightDic == null)
        //        {
        //            lock (_sync)
        //            {
        //                if (_bonusWeightDic == null)
        //                {
        //                    var values = new Dictionary<int, Gmf_bonus_weightEO>();
        //                    foreach (var item in new Gmf_bonus_weightMO().GetAll())
        //                        values.Add(item.WeightID, item);
        //                    _bonusWeightDic = values;
        //                }
        //            }
        //        }
        //        return _bonusWeightDic;
        //    }
        //}
        private static WeightRandomProvider<Gmf_bonus_weightPO> _bonusWeightRandom;
        private static WeightRandomProvider<Gmf_bonus_weightPO> GetBonusWeightRandom()
        {
            if (_bonusWeightRandom == null)
            {
                lock (_sync)
                {
                    if (_bonusWeightRandom == null)
                    {
                        _bonusWeightRandom = new WeightRandomProvider<Gmf_bonus_weightPO>();
                        DbCachingUtil.GetAllList<Gmf_bonus_weightPO>().ForEach(x => _bonusWeightRandom.AddItem(x.Weight, x));
                    }
                }
            }
            return _bonusWeightRandom;
        }
        public static Gmf_bonus_weightEO GetBonusWeight()
        {
            return GetBonusWeightRandom().Next();
        }
        #endregion

        #region gmf_retrigger_weight
        //private static Dictionary<int, Gmf_retrigger_weightEO> _retriggerWeightDic;
        //private static Dictionary<int, Gmf_retrigger_weightEO> RetriggerWeightDic
        //{
        //    get
        //    {
        //        if (_retriggerWeightDic == null)
        //        {
        //            lock (_sync)
        //            {
        //                if (_retriggerWeightDic == null)
        //                {
        //                    var values = new Dictionary<int, Gmf_retrigger_weightEO>();
        //                    foreach (var item in new Gmf_retrigger_weightMO().GetAll())
        //                        values.Add(item.RetriggerNum, item);
        //                    _retriggerWeightDic = values;
        //                }
        //            }
        //        }
        //        return _retriggerWeightDic;
        //    }
        //}
        private static WeightRandomProvider<Gmf_retrigger_weightPO> _retriggerWeightRandom;
        public static WeightRandomProvider<Gmf_retrigger_weightPO> GetRetriggerWeightRandom()
        {
            if (_retriggerWeightRandom == null)
            {
                lock (_sync)
                {
                    if (_retriggerWeightRandom == null)
                    {
                        _retriggerWeightRandom = new WeightRandomProvider<Gmf_retrigger_weightPO>();
                        DbCachingUtil.GetAllList<Gmf_retrigger_weightPO>().ForEach(x => _retriggerWeightRandom.AddItem(x.Weight, x));
                    }
                }
            }
            return _retriggerWeightRandom;
        }
        #endregion

        public static void Clear()
        {
            //_config = null;
            //_chipsDic = null;
            //_loadChipsDic = null;
            //_symbols = null;
            //_slotEles = null;
            //_lineDic = null;
            //_lines = null;
            //_paytableDic = null;
            //_multipWeightDic0 = null;
            _multipWeightRandom0 = null;
            //_multipWeightDic1 = null;
            _multipWeightRandom1 = null;
            //_bingoWeightDic = null;
            _bingoWeightRandom = null;
            //_bingoNumWeightDic = null;
            _bingoNumWeight = null;
            //_bonusWeightDic = null;
            _bonusWeightRandom = null;
            //_retriggerWeightDic = null;
            _retriggerWeightRandom = null;
        }
    }
}
