using Super_phoenix.BLL.Caching;
using Super_phoenix.BLL.Core;
using Super_phoenix.DAL;
using Xxyy.Common.Caching.Partner;
using static Super_phoenix.BLL.Caching.MemoryUtil;

namespace Super_phoenix.BLL
{
    public class SlotContext
    {
        public Super_phoenixSlotIpo Ipo { get; set; }
        public string UserId => Ipo.UserId;
        public string CurrencyId => Ipo.CurrencyId;
        public AppLoginTokenDO LoginTokenDo { get; }
        public string OperatorId => LoginTokenDo.OperatorId;
        public string AppId => LoginTokenDo.AppId;
        public long BetId { get; set; }
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
        /// 是否中奖
        /// </summary>
        public int IsWin { get; set; }
        public long RealWinAmount => WinAmount * IsWin;
        public Gsp_configEO Config { get; }
        public Gsp_config_chipsEO Config_Chips { get; set; }
        public Gsp_user_extEO UserExt { get; set; }
        public Gsp_user_dataEO UserData { get; set; }
        public List<Gsp_config_linePO> LineList { get; set; }
        public List<Gsp_config_weightEO> WeightList { get; set; }
        public string HistoryMultip { get; set; }
        public bool IsFreeSpin { get; }
        public string HistoryLine { get; set; }
        public int TotalMultip { get; set; }
        public int TriggerMiniGame { get; set; }
        public List<WeightColumn>[] WeightColumnList { get; set; }
        public List<RewardDetail> RewardDetails { get; set; } = new();
        public List<int[]> SlotEleArray { get; set; } = new();
        public GameItemType ItemType { get; set; }

        /// <summary>
        /// 触发freespin的阈值点
        /// </summary>
        public long TriggerFreeSpinVal { get; }
        /// <summary>
        /// 触发freespin的阈值概率分母
        /// </summary>
        public long TriggerFreeSpinVal_Denominator { get; }
        /// <summary>
        /// 是否真正触发freespin 0-普通,1-中奖,2-未触发
        /// </summary>
        public int TriggerFreeSpinOdds { get; set; }
        public SlotContext(Super_phoenixSlotIpo ipo, AppLoginTokenDO token)
        {
            Ipo = ipo;
            LoginTokenDo = token;
            Config = GetConfig(OperatorId, CurrencyId);
            Config_Chips = GetChips(ipo.ChipsId);
            TriggerFreeSpinVal = Config_Chips.BetAmount * Config.FreeSpinTrigger;
            TriggerFreeSpinVal_Denominator = Config_Chips.BetAmount * Config.FreeSpinCount;
            UserData = GetUserData(ipo.UserId, ipo.ChipsId);
            Gsp_user_extMO _ext = new();
            UserExt = _ext.GetByPK(UserId);
            LineList = GetLineList();
            IsFreeSpin = UserData.FreeSpinCount > 0;
        }

        public class BetPartAmount
        {
            public long PartMiniGameTotalVal { get; set; }
            public long PartBaseAmount { get; set; }
            public long PartIncomeAmount { get; set; }
        }
    }
}
