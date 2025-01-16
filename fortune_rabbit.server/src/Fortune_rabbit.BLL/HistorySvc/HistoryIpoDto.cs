namespace Fortune_rabbit.BLL
{
    public class HistoryIpo
    {
        public string UserId { get; set; }
        public long StartTime { get; set; }
        public long EndTime { get; set; }
        public int PageIndex { get; set; }
    }
    public class HistoryDto
    {
        public List<History> HistoryInfoList { get; set; } = new();
    }

    public class History
    {

        public decimal TotalWin { get; set; }
        public List<GameInfo> GameInfoList { get; set; } = new();
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