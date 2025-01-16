namespace Super_phoenix.BLL
{
    public class Super_phoenixSlotIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
        public int ChipsId { get; set; }
    }
    public class Super_phoenixSlotDto
    {
        public PlayerInfo PlayerInfo { get; set; } = new();
        public ResultInfo ResultInfo { get; set; } = new();
    }

    public class ResultInfo
    {
        /// <summary>
        /// slot上的元素
        /// </summary>
        public List<int[]> SlotEles { get; set; } = new();
        /// <summary>
        /// 所有line的奖励总和
        /// </summary>
        public decimal TotalReward { get; set; }
        /// <summary>
        /// 中奖总倍数
        /// </summary>
        public int TotalMulti { get; set; }
        public List<RewardDetail> RewardDetails { get; set; } = new();
        /// <summary>
        /// FreeSpin次数
        /// </summary>
        public int FreeSpinCount { get; set; } = new();
        /// <summary>
        /// free spin次数的总奖励，如果耗光重置为0，用户退出也需要记录，下一次进入还得有
        /// </summary>
        public decimal FreeSpinTotalReward { get; set; } = new();
    }

    public class RewardDetail
    {
        public int Line { get; set; }//线束编号
        public decimal Reward { get; set; }//奖励
        public int SameUnitCount { get; set; }//同样元素数量
        public double Multi { get; set; }//0.5//中奖倍数，可能不需要
    }

}