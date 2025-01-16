namespace Fortune_tiger.BLL
{
    public class LampIpo
    {
        public string AppId { get; set; }
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
        public long LastTime { get; set; }//上次请求时间戳，第一次为0
    }
    public class LampDto
    {
        public List<SimplePlayerInfo> SimplePlayerInfoList { get; set; } = new();
    }

}