namespace Super_phoenix.BLL
{
    public class Super_phoenixRankIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
        public int ChipsId { get; set; }
    }
    public class Super_phoenixRankDto
    {
        public List<SimplePlayerInfo> SimplePlayerInfoList { get; set; } = new();
    }

    public class SimplePlayerInfo
    {
        /// <summary>
        /// username或mobile
        /// </summary>
        public string Player { get; set; }
        /// <summary>
        /// 中间额
        /// </summary>
        public decimal Reward { get; set; }
        /// <summary>
        /// 中奖总倍数
        /// </summary>
        public int Multi { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        public long RecDate { get; set; }
    }
}