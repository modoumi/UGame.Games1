namespace Super_phoenix.BLL
{
    public class Super_phoenixLampIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
        public long Timestamp { get; set; }
    }
    public class Super_phoenixLampDto
    {
        public List<SimplePlayerInfo> SimplePlayerInfoList { get; set; } = new();
    }

}