using Mexico_fortune.BLL.Caching;
using Mexico_fortune.DAL;
using Xxyy.Common.Caching.Partner;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Services;

namespace Mexico_fortune.BLL
{
    internal class SlotContext
    {
        public SlotIpo Ipo { get; set; }
        public string UserId => Ipo.UserId;
        public string CurrencyId => Ipo.CurrencyId;
        public AppLoginTokenDO LoginTokenDo { get; }
        public string OperatorId => LoginTokenDo.OperatorId;
        public string AppId => LoginTokenDo.AppId;
        public string ProviderId => LoginTokenDo.ProviderId;
        public Gmf_chipsEO Chips { get; }
        public int ChipsId => Chips.ChipsID;
        public long BetAmount { get; }
        public UserDataDO UserDataDo { get; set; }
        /// <summary>
        /// 当前是否是FreeSpin
        /// </summary>
        public bool IsFreeSpin { get; set; }

        public SlotPartAmount PartAmount { get; } = new();
        public SlotBingoData BingoData { get; } = new();
        public SlotBaseData BaseData { get; } = new();
        public SlotBonusData BonusData { get; } = new();
        public SlotQueryData QueryData { get; } = new();

        /// <summary>
        /// 是否操作过用户账户
        /// </summary>
        public bool IsChangeBalance { get; set; }
        public long TotalAmount { get; set; }
        public long SlotId { get; set; }
        public UserService UserSvc { get; }
        public SlotContext(SlotIpo ipo, AppLoginTokenDO token)
        {
            Ipo = ipo;
            LoginTokenDo = token;
            Chips = GmfDBCacheUtil.GetChips(ipo.ChipsId);
            BetAmount = Chips.BetMoney.MToA(ipo.CurrencyId);
            UserSvc = new(ipo.UserId);
        }
    }
    internal class SlotPartAmount
    {
        public long PartBingoAmount { get; set; }
        public long PartBonusAmount { get; set; }
        public long PartBaseAmount { get; set; }
        public long PartIncomeAmount { get; set; }
        public long PartPoolAmount { get; set; }
    }
    internal class SlotBingoData
    {
        public bool IsOutTH { get; set; }
        public bool IsWin { get; set; }
        public JPPoolType JPPoolType { get; set; }
        public long WinAmount { get; set; }
        public List<int> NewNums { get; set; } = new();
        public int SymbolNum => NewNums.Count;
    }
    internal class SlotBonusData
    {
        public bool IsOutTH { get; set; }
        public long WinAmount { get; set; }
        public bool IsWin { get; set; }
        public int SymbolNum { get; set; }
        public int Multip { get; set; }
        public int NewRetriggerNum { get; set; }
    }
    internal class SlotBaseData
    {
        public bool IsWin { get; set; }
        public long WinAmount { get; set; }
        public int Multip { get; set; }
    }
    internal class SlotQueryData
    {
        public long ItemId { get; set; }
        public int[,] SlotEles { get; set; }
        public decimal TotalReward { get; set; }
        public long TotalAmount { get; set; }
        public List<SlotRewardDetail> RewardDetails { get; set; } = new();
    }
}
