namespace Mexico_fortune.BLL
{
    public class SlotIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
        public int ChipsId { get; set; }
    }
    public class SlotDto
    {
        public string SlotId { get; set; }
        public string ItemId { get; set; }
        public SlotPlayerInfo PlayerInfo { get; set; } = new();
        public SlotResultInfo ResultInfo { get; set; } = new();
        /// <summary>
        /// 彩票结果信息
        /// </summary>
        public SlotLottoryResultInfo LottoryResultInfo { get; set; } = new();
    }
    public class SlotPlayerInfo
    {
        public decimal Balance { get; set; }
    }
    public class SlotResultInfo
    {
        /// <summary>
        /// //slot上的元素[[1,2,3], [2,3,4], [3,4,5], [4,5,6], [5,6,7]]
        /// </summary>
        public List<int[]> SlotEles { get; set; }
        /// <summary>
        /// 所有line的奖励总和
        /// </summary>
        public decimal TotalReward { get; set; }
        /// <summary>
        /// 中奖总倍数
        /// </summary>
        public float TotalMulti { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<SlotRewardDetail> RewardDetails { get; set; }
        /// <summary>
        /// 免费摇奖次数
        /// </summary>
        public int FreeSpinCount { get; set; }
        /// <summary>
        /// free spin次数的总奖励，如果耗光重置为0，用户退出也需要记录，下一次进入还得有
        /// </summary>
        public decimal FreeSpinTotalReward { get; set; }
        /// <summary>
        /// 添加的freeSpin对应slot ele上的奖励次数
        /// </summary>
        public List<int> AddFreeSpinCountList { get; set; }
    }
    public class SlotRewardDetail
    {
        /// <summary>
        /// 线束
        /// </summary>
        public int Line { get; set; }
        /// <summary>
        /// 奖励
        /// </summary>
        public double Reward { get; set; }
        public long RewardAmount { get; set; }
        /// <summary>
        /// 同样元素数量
        /// </summary>
        public int SameUnitCount { get; set; }
        /// <summary>
        /// 中奖倍数，可能不需要
        /// </summary>
        public double Multi { get; set; }
    }
    public class SlotLottoryResultInfo
    {
        /// <summary>
        /// 是否收集齐彩票，触发jp抽奖
        /// </summary>
        public bool IsTriggerJpReward { get; set; }
        public decimal JpReward { get; set; }
        /// <summary>
        /// jp开奖值，如果isTriggerJpReward是false就是0，如果是true，取meta中betJpBonus对应bet档位上的某一档奖励
        /// </summary>
        public int JpRewardIndex { get; set; }
        /// <summary>
        /// 彩票25球信息(新的)
        /// [[1,16,31,46,61], [2,17,32,47,62], [3,18,33,48,63], [4,19,34,49,64], [5,20,35,50,65]]
        /// </summary>
        public List<int[]> LottoryEle { get; set; }
        /// <summary>
        /// 新出现的元素，最多可能有5个，对应slot ele上的数字
        /// </summary>
        public List<int> NewEle { get; set; }
    }
}
