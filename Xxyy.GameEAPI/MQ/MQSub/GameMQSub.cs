/*using EasyNetQ;
using Polly;
using TinyFx.Extensions.RabbitMQ;
using Xxyy.GameEAPI.Common;
using static Xxyy.GameEAPI.Core.GameEAPIUtil;

namespace Xxyy.GameEAPI.MQ.MQSub
{

    public class GameMQSub : MQSubscribeConsumer<GameBalanceMsg>
    {
        public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

        protected override void Configuration(ISubscriptionConfiguration x)
        {
        }

        protected override async Task OnMessage(GameBalanceMsg msg, CancellationToken cancellationToken)
        {
            TimeSpan elapsedTime = await MeasureExecutionTime<GameMQSub>(async () => await Exec(msg));
            Console.WriteLine($"{msg.AppId} 调用Partner BetWin -> 耗时:{elapsedTime.Milliseconds} ms");
        }

        private static async Task Exec(GameBalanceMsg message)
        {
            var _account = await BetWin(message.UserId, message.AppId, message.BetId.ToString()
                   , message.Bet, message.Win);
            if (_account == null) { throw new CustomException(CommonCodes.RS_TOKEN_EXPIRED, "调用下注BetWin余额异常,请重新登录!"); }
            else
            {
                if (_account.Balance != message.Balance || _account.Bonus != message.Bonus)
                {
                    Console.WriteLine($"=======FAIL=={message.AppId}====={message.UserId}=================={message.Balance}");
                    throw new CustomException(CommonCodes.RS_TOKEN_EXPIRED, "调用下注BetWin余额异常,请重新登录!");
                }
                else
                {
                    Console.WriteLine($"=======SUCCESS=={message.AppId}====={message.UserId}=================={message.Balance}");
                }
            }
        }
    }
}
*/