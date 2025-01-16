namespace Fortune_tiger.BLL
{
    public class BetIpo
    {
        public string AppId { get; set; }
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
        public int ChipsId { get; set; }
    }
    public class BetDto
    {
        public PlayerInfo PlayerInfo { get; set; } = new();
        public ResultInfo ResultInfo { get; set; } = new();
    }

    public class ResultInfo
    {
        public GameInfo GameInfo { get; set; } = new();
        public ExtraInfo ExtraInfo { get; set; } = new();
    }

    public class GameInfo
    {
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
        public int TotalMulti { get; set; }
        /// <summary>
        /// Wild累计数,到下次虎虎生威清零
        /// </summary>
        public int WildNum { get; set; }
        public List<RewardDetail> RewardDetails { get; set; } = new();
        /// <summary>
        /// 本次下注的钱
        /// </summary>
        public decimal Cost { get; set; }
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

    }


    public class RewardDetail
    {
        public int Line { get; set; }//线束编号
        public decimal Reward { get; set; }//奖励
        public int SameUnitCount { get; set; }//同样元素数量
        public double Multi { get; set; }//0.5//中奖倍数，可能不需要
    }

    public class ExtraInfo
    {
        public bool IsTrigerBonus { get; set; }//是否触发10倍全中效果
        public bool IsBonus { get; set; }//是否命中10倍全中效果
        public List<List<List<int>>> BonusInfo { get; set; } = new();
        /// <summary>
        /// 虎虎生威中奖id
        /// </summary>
        public int BonousItemId { get; set; }
    }

}