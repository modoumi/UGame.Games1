namespace Fortune_big.BLL
{
    public class HistoryIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
        public long StartTime { get; set; }
        public long EndTime { get; set; }
        public int PageIndex { get; set; }
    }
    public class HistoryDto
    {
        public List<ResultInfo> HistoryList { get; set; } = new();
    }
}