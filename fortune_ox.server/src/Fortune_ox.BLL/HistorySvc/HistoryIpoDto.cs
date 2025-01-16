namespace Fortune_ox.BLL
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
}