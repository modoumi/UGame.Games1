using Fortune_ox.BLL.Caching;
using Fortune_ox.DAL;
using TinyFx;
using Xxyy.Common.Caching.Partner;
using static Fortune_ox.BLL.Caching.MemoryUtil;

namespace Fortune_ox.BLL
{
    public class BetContext
    {
        public BetIpo Ipo { get; set; }
        public string UserId => Ipo.UserId;
        public long BetId { get; set; }
        public string GroupId { get; set; }
        public BetPartAmount PartAmount { get; } = new();
        public ResultInfo ResultInfo { get; set; } = new();
        /// <summary>
        /// 当前用户身上是bonus
        /// </summary>
        public long BonusAmount { get; set; }
        /// <summary>
        /// 是否操作过用户账户
        /// </summary>
        public bool IsChangeBalance { get; set; }
        /// <summary>
        /// 赢得总奖金
        /// </summary>
        public long WinAmount { get; set; }
        /// <summary>
        /// 下注bonus,由接口返回
        /// </summary>
        public long BetBonus { get; set; }
        /// <summary>
        /// 返奖bonus,由接口返回
        /// </summary>
        public long WinBonus { get; set; }
        /// <summary>
        /// 每次下注前的余额
        /// </summary>
        public long BalanceAmountBefore { get; set; }
        /// <summary>
        /// 每次下注后的余额
        /// </summary>
        public long BalanceAmountAfter { get; set; }
        /// <summary>
        /// 是否中奖
        /// </summary>
        public int IsWin { get; set; }
        public long RealWinAmount => WinAmount * IsWin;
        public Fox_configEO Config { get; }
        public Fox_config_chipsEO Chips { get; set; }
        public Fox_user_extEO UserExt { get; set; }
        public List<Fox_config_linePO> LineList { get; set; }
        public Fox_config_tagEO Tag { get; set; }
        /// <summary>
        /// 用户标签 RandomSymbol
        /// </summary>
        public List<SpecialMode> TagSM_Y1
        {
            get
            {
                return SerializerUtil.DeserializeJson<List<SpecialMode>>(Tag.SpecialMode_Y1);
            }
        }
        /// <summary>
        /// 用户标签 RandomSymbolMultip
        /// </summary>
        public List<SpecialMode> TagSM_Y2
        {
            get
            {
                return SerializerUtil.DeserializeJson<List<SpecialMode>>(Tag.SpecialMode_Y2);
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
        public int TotalMultip { get; set; }
        public int TriggerMaxMultip { get; set; }
        /// <summary>
        /// 是否触发HHSW特效 0-否,1-是
        /// </summary>
        public int TriggerSM { get; set; }
        /// <summary>
        /// 触发HHSW后是否中奖 0-否,1-是
        /// </summary>
        public int TriggerSE { get; set; }
        public int TriggerMiniGame { get; set; }
        public List<RewardDetail> RewardDetails { get; set; } = new();
        public List<List<int>> SlotEleArray { get; set; } = new();
        public List<List<List<int>>> BonusInfo { get; set; } = new();
        public DateTime RecDate { get; set; }
        public string CurrencyId => UserExt.CurrencyID;
        public string OperatorId => UserExt.OperatorID;
        public string AppId => UserExt.AppID;
        public int UserFlag { get; }
        public BetContext(BetIpo ipo, Fox_user_extEO _ext)
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
