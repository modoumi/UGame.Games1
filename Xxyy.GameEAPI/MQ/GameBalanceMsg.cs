using TinyFx.Extensions.RabbitMQ;

namespace Xxyy.GameEAPI.MQ;


public class GameBalanceMsg //: IMQMessage
{
    public string UserId { get; set; }
    public long Bet { get; set; }
    public long BetBonus { get; set; }
    public long Win { get; set; }
    public long WinBonus { get; set; }
    public long Balance { get; set; }
    public long Bonus { get; set; }
    public string AppId { get; set; }
    public long BetId { get; set; }
    public object MQMeta { get; set; }
}