namespace Xxyy.GameEAPI.Services
{
    public class GameEngineLoginIpo
    {
        public string AppId { get; set; }
        public string Ticket { get; set; }
        public string UserId { get; set; }
    }
    public class GameEngineLoginDto
    {
        public string UserId { get; set; }
        public string ProviderId { get; set; }
        public string OperatorId { get; set; }
        public string CountryId { get; set; }
        public string CurrencyId { get; set; }
        public string LangId { get; set; }
        public List<string> OperatorLangs { get; set; }
        public string LobbyUrl { get; set; }
        public string BankUrl { get; set; }

        public string AppServerToken { get; set; }
    }
}
