using Fortune_tiger.DAL;
using TinyFx;
using static Fortune_tiger.BLL.Caching.MemoryUtil;

namespace Fortune_tiger.BLL
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
        /// 赢得总奖金
        /// </summary>
        public long WinAmount { get; set; }
        /// <summary>
        /// 每次下注后的余额
        /// </summary>
        public long BalanceAmount { get; set; }
        /// <summary>
        /// 下注bonus,由接口返回
        /// </summary>
        public long BetBonus { get; set; }
        /// <summary>
        /// 返奖bonus,由接口返回
        /// </summary>
        public long WinBonus { get; set; }
        /// <summary>
        /// 本次下注变化余额
        /// </summary>
        public long ChageBalance { get; set; }
        /// <summary>
        /// 本次下注变化bonus
        /// </summary>
        public long ChangeBonus { get; set; }
        /// <summary>
        /// 是否中奖
        /// </summary>
        public int IsWin { get; set; }
        public long RealWinAmount => WinAmount * IsWin;
        public Slot_configEO Config { get; }
        public Slot_config_chipsEO Chips { get; set; }
        public Slot_user_extEO UserExt { get; set; }
        public List<Slot_config_linePO> LineList { get; set; }
        public Slot_config_tagEO Tag { get; set; }
        /// <summary>
        /// 用户标签 RandomSymbol
        /// </summary>
        public List<RandomSymbol> TagRS
        {
            get
            {
                return SerializerUtil.DeserializeJson<List<RandomSymbol>>(Tag.RandomSymbol);
            }
        }
        /// <summary>
        /// 用户标签 RandomSymbolMultip
        /// </summary>
        public List<RandomSymbolMultip> TagRSM
        {
            get
            {
                return SerializerUtil.DeserializeJson<List<RandomSymbolMultip>>(Tag.RandomSymbolMultip);
            }
        }
        /// <summary>
        /// 用户标签 Weight
        /// </summary>
        public List<List<RandomSymbol>> TagWeightList
        {
            get
            {
                return SerializerUtil.DeserializeJson<List<List<RandomSymbol>>>(Tag.WeightList);
            }
        }
        public string HistoryMultip { get; set; }
        public string HistoryLine { get; set; }
        public int TotalMultip { get; set; }
        public int TriggerMaxMultip { get; set; }
        /// <summary>
        /// 虎虎生威中奖id
        /// </summary>
        public int BonusItemId { get; set; }
        /// <summary>
        /// 是否触发HHSW模式 0-否,1-是
        /// </summary>
        public int TriggerSM { get; set; }
        /// <summary>
        /// 触发HHSW后是否展示特效  0-否,1-是
        /// </summary>
        public int TriggerSE { get; set; }
        public int TriggerMiniGame { get; set; }
        /// <summary>
        /// wildNum
        /// </summary>
        public int WildNum { get; set; }
        public int UserFlag { get; }
        public List<RewardDetail> RewardDetails { get; set; } = new();
        public List<List<int>> SlotEleArray { get; set; } = new();
        public int PoolType { get; set; }
        public List<List<List<int>>> BonusInfo { get; set; } = new();
        public string CurrencyId => Ipo.CurrencyId;
        public string OperatorId => UserExt.OperatorID;
        public string AppId => UserExt.AppID;
        public BetContext(BetIpo ipo, Slot_user_extEO _ext)
        {
            Ipo = ipo;
            UserExt = _ext;
            if (UserExt != null)
            {
                Config = GetConfig(UserExt.AppID, UserExt.OperatorID, UserExt.CurrencyID);
                Chips = GetChips(UserExt.AppID, ipo.ChipsId);
                UserFlag = (int)UserExt.UserFlag % 2;
                LineList = GetLineList(UserExt.AppID);
            }
        }

        public class BetPartAmount
        {
            public long PartMoneyAmount { get; set; }
            public long PartBonusAmount { get; set; }
        }
    }
}
