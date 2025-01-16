namespace Fortune_rabbit.BLL
{
    public class BetIpo
    {
        public string UserId { get; set; }
        public int ChipsId { get; set; }
    }
    public class BetDto
    {
        public PlayerInfo PlayerInfo { get; set; } = new();
        public ResultInfo ResultInfo { get; set; } = new();
    }

    public class ResultInfo
    {
        public List<GameInfo> GameInfoList { get; set; } = new();
    }

    public class GameInfo
    {
        /// <summary>
        /// 本次下注的钱
        /// </summary>
        public decimal Cost { get; set; }
        /// <summary>
        /// 净盈利
        /// </summary>
        public decimal Win => TotalReward - Cost;
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
        /// 是否触发呼吸特效
        /// </summary>
        public bool TriggerSpecialEffects { get; set; }
        /// <summary>
        /// slot上的元素
        /// </summary>
        public List<List<int>> SlotEles { get; set; } = new();
        /// <summary>
        /// 所有line的奖励总和
        /// </summary>
        public decimal TotalReward { get; set; }
        /// <summary>
        /// 中奖总倍数
        /// </summary>
        public float TotalMulti { get; set; }
        public List<RewardDetail> RewardDetails { get; set; } = new();
    }


    public class RewardDetail
    {
        public List<int> ItemIdList { get; set; } = new();//道具id
        public int Line { get; set; }//线束编号
        public decimal Reward { get; set; }//奖励
        public int SameUnitCount { get; set; }//同样元素数量
        public float Multi { get; set; }//0.5中奖倍数
    }
}