using Fortune_rabbit.DAL;
using System.Text;
using System.Text.Json.Nodes;
using static Fortune_rabbit.BLL.Caching.MemoryUtil;

namespace Fortune_rabbit.BLL
{
    public class BetContext
    {
        public BetIpo Ipo { get; set; }
        public string UserId => Ipo.UserId;
        public long BetId { get; set; }
        public string GroupId { get; set; }
        public BetPartAmount PartAmount { get; } = new();
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
        /// 8次 特殊玩法赢得的总奖金
        /// </summary>
        public long WinAmount_SpecialIcon { get; set; }
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
        public long RealWinAmount
        {
            get
            {
                return WinAmount * (IsWin >= 1 ? 1 : 0);
            }
        }
        public Fra_configEO Config { get; }
        public Fra_config_chipsEO Chips { get; set; }
        public Fra_user_extEO UserExt { get; set; }
        public List<Fra_config_linePO> LineList { get; set; }
        public float TotalMultip { get; set; }
        /// <summary>
        /// 特殊图标倍数
        /// </summary>
        public float SpecialModeMultip { get; set; }
        /// <summary>
        /// 进入特殊模式 0-否,1-是
        /// </summary>
        public int TriggerSM { get; set; }
        /// <summary>
        /// 触发HHSW后是否中奖 0-否,1-是
        /// </summary>
        public int TriggerSE { get; set; }
        public List<RewardDetail> RewardDetails { get; set; } = new();
        public List<List<int>> SlotEleArray { get; set; } = new();
        public List<GameInfo> BonusDetailList { get; set; } = new();
        public DateTime RecDate { get; set; }
        public string CurrencyId => UserExt.CurrencyID;
        public string OperatorId => UserExt.OperatorID;
        public string AppId => UserExt.AppID;
        public int UserFlag { get; set; }
        public StringBuilder Memo { get; set; } = new();

        public BetContext(BetIpo ipo, Fra_user_extEO _ext)
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
