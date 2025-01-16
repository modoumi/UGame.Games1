namespace Fortune_big.BLL
{
    public class SpinIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
        public int ChipsId { get; set; }
    }
    public class SpinDto
    {
        public PlayerInfo PlayerInfo { get; set; } = new();
        public ResultInfo ResultInfo { get; set; } = new();
    }
    public class ResultInfo
    {
        public bool TriggerFreeSpin { get; set; }
        public bool TriggerRespin { get; set; }
        public bool TriggerEffect { get; set; }
        public GameInfo GameInfo { get; set; } = new();
        public List<GameInfo> RespinList { get; set; } = new();
        public List<GameInfo> FreeSpinList { get; set; } = new();
    }

    public class GameInfo
    {
        /// <summary>
        /// 本次下注的钱
        /// </summary>
        public decimal Bet { get; set; }
        /// <summary>
        /// win
        /// </summary>
        public decimal Win => TotalReward - Bet;
        /// <summary>
        /// 下注时间戳
        /// </summary>
        public long Date { get; set; }
        /// <summary>
        /// 订单ID
        /// </summary>
        public string Transactionld { get; set; }
        /// <summary>
        /// 本次下注后的余额
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// slot上的元素
        /// </summary>
        public List<List<int>> SlotEleList { get; set; } = new();
        /// <summary>
        /// 普通所有line的奖励总和
        /// </summary>
        public decimal TotalReward { get; set; }
        /// </summary>
        /// 普通玩法中奖总倍数
        /// </summary>
        public float TotalMultiple { get; set; }
        /// <summary>
        /// 特殊玩法第几次
        /// </summary>
        public int N { get; set; }
        public List<RewardDetail> RewardDetailList { get; set; } = new();
    }

    public class RewardDetail
    {
        public int LineId { get; set; }//线束编号
        public decimal Reward { get; set; }//奖励
        public List<int> IndexHaveList { get; set; } = new();//奖励
        public int SameCount { get; set; }//同样元素数量
        public double SingleMultiple { get; set; }//单线倍数
    }
}