using Fortune_mouse.DAL;
using TinyFx;
using static Fortune_mouse.BLL.Caching.MemoryUtil;

namespace Fortune_mouse.BLL
{
    public class BetContext
    {
        public BetIpo Ipo { get; set; }
        public string UserId => Ipo.UserId;

        public long BetId { get; set; }
        /// <summary>
        /// 当前用户身上是bonus
        /// </summary>
        public long BonusAmount { get; set; }
        public BetPartAmount PartAmount { get; } = new();
        public ResultInfo ResultInfo { get; set; } = new();
        /// <summary>
        /// 是否操作过用户账户
        /// </summary>
        public bool IsChangeBalance { get; set; }
        /// <summary>
        /// 每次下注前余额
        /// </summary>
        public long BalanceAmountBefore { get; set; }
        /// <summary>
        /// 赢得总奖金
        /// </summary>
        public long WinAmount { get; set; }
        /// <summary>
        /// 每次下注后的余额
        /// </summary>
        public long BalanceAmount { get; set; }
        /// <summary>
        /// 是否中奖
        /// </summary>
        public int IsWin { get; set; }
        public long RealWinAmount => WinAmount * IsWin;
        public Fmo_configEO Config { get; }
        public Fmo_config_chipsEO Chips { get; set; }
        public Fmo_user_extEO UserExt { get; set; }
        public List<Fmo_config_linePO> LineList { get; set; }
        public Fmo_config_tagEO Tag { get; set; }
        /// <summary>
        /// 用户标签 RandomSymbol
        /// </summary>
        public List<List<RandomSymbol>> TagWeight_SM
        {
            get
            {
                return SerializerUtil.DeserializeJson<List<List<RandomSymbol>>>(Tag.Weight_SM);
            }
        }
        /// <summary>
        /// 用户标签 Weight
        /// </summary>
        public List<List<RandomSymbol>> TagWeight_Main
        {
            get
            {
                return SerializerUtil.DeserializeJson<List<List<RandomSymbol>>>(Tag.Weight_Main);
            }
        }
        public string HistoryMultip { get; set; }
        public string HistoryLine { get; set; }
        public int TotalMultip { get; set; }
        /// <summary>
        /// 是否触发HHSW模式 0-否,1-是
        /// </summary>
        public int TriggerSM { get; set; }
        /// <summary>
        /// 触发HHSW后是否展示特效  0-否,1-是
        /// </summary>
        public int TriggerSE { get; set; }
        public int UserFlag { get; }
        public List<RewardDetail> RewardDetails { get; set; } = new();
        public List<List<int>> SlotEleArray { get; set; } = new();
        public List<List<List<int>>> BonusInfo { get; set; } = new();
        public string CurrencyId => Ipo.CurrencyId;
        public string OperatorId => UserExt.OperatorID;
        public string AppId => UserExt.AppID;

        public DateTime RecDate { get; set; }

        public BetContext(BetIpo ipo, Fmo_user_extEO _ext)
        {
            Ipo = ipo;
            UserExt = _ext;
            if (UserExt != null)
            {
                Config = GetConfig(UserExt.OperatorID, UserExt.CurrencyID);
                Chips = GetChips(ipo.ChipsId);
                UserFlag = (int)UserExt.UserFlag % 2;
                LineList = GetLineList();
            }
        }

        public class BetPartAmount
        {
            public long PartMoneyAmount { get; set; }
            public long PartBonusAmount { get; set; }
        }
    }
}
