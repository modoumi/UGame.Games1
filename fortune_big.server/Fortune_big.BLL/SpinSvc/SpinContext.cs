using Fortune_big.DAL;
using TinyFx;
using TinyFx.Randoms;
using static Fortune_big.BLL.Caching.MemoryUtil;

namespace Fortune_big.BLL
{
    public class SpinContext
    {
        public SpinIpo Ipo { get; set; }
        public string UserId => Ipo.UserId;

        public long BetId { get; set; }

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
        /// 每次下注后余额
        /// </summary>
        public long BalanceAmountAfter { get; set; }

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
        public long RealWinAmount => (WinAmount + SMAmount) * IsWin;
        public Big_configEO Config { get; set; }
        public Big_config_chipsEO Chips { get; set; }
        public Big_user_extEO UserExt { get; set; }
        public List<Big_config_linePO> LineList { get; set; }
        public List<GameInfo> FreeSpinList { get; set; } = new();
        public List<GameInfo> RespinList { get; set; } = new();
        public Big_config_tagEO Tag { get; set; }

        public List<List<RandomSymbol>> TagWeight_Main
        {
            get
            {
                string main = RandomUtil.IsOdds(0.5m) ? Tag.Weight_Main : Tag.Weight_Main2;
                return SerializerUtil.DeserializeJson<List<List<RandomSymbol>>>(main);
            }
        }
        public List<List<RandomSymbol>> TagWeight_Free1
        {
            get
            {
                return SerializerUtil.DeserializeJson<List<List<RandomSymbol>>>(Tag.Weight_Free1);
            }
        }
        public List<List<RandomSymbol>> TagWeight_Free2
        {
            get
            {
                return SerializerUtil.DeserializeJson<List<List<RandomSymbol>>>(Tag.Weight_Free2);
            }
        }
        public List<List<RandomSymbol>> TagWeight_Free3
        {
            get
            {
                return SerializerUtil.DeserializeJson<List<List<RandomSymbol>>>(Tag.Weight_Free3);
            }
        }

        public string HistoryMultip { get; set; }
        public float TotalMultip { get; set; }
        public float SMMultip { get; set; }
        public long SMAmount { get; set; }
        /// <summary>
        /// 是否触发特殊模式 0-否,1-是
        /// </summary>
        public int TriggerFreeSpin { get; set; }
        public int TriggerRespin { get; set; }
        /// <summary>
        /// 是否展示呼吸特效  0-否,1-是
        /// </summary>
        public int TriggerSE { get; set; }
        public int UserFlag { get; set; }
        public List<RewardDetail> RewardDetailList { get; set; } = new();
        public List<List<int>> SlotEleList { get; set; } = new();
        public string CurrencyId => Ipo.CurrencyId;
        public string OperatorId => UserExt.OperatorID;
        public string AppId => UserExt.AppID;

        public DateTime RecDate { get; set; }

        public SpinContext(SpinIpo ipo)
        {
            Ipo = ipo;
            Chips = GetChips(Ipo.ChipsId);
            LineList = GetLineList();
        }
        public class BetPartAmount
        {
            public long PartMoneyAmount { get; set; }
            public long PartBonusAmount { get; set; }
        }
    }
}
