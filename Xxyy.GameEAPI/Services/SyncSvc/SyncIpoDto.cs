namespace Xxyy.GameEAPI.Services
{
    public class SyncIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
    }
    public class SyncDto
    {
        public PlayerInfo PlayerInfo { get; set; } = new();
    }

    public class PlayerInfo
    {
        public decimal Balance { get; set; }
    }
}