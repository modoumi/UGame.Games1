using EasyNetQ;
using Fortune_big.DAL;
using TinyFx.BIZ.RabbitMQ;
using TinyFx.Extensions.RabbitMQ;
using static Xxyy.GameEAPI.Core.GameEAPIUtil;

namespace Xxyy.GameEAPI.MQ.MQSub
{

    public class GameMQSub : MQBizSubConsumer<GameBalanceMsg>
    {
        public readonly Fortune_big.BLL.LoadService loadService = new();
        private readonly Big_user_extMO _extMO = new();
        public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

        protected override void Configuration(ISubscriptionConfiguration x)
        {
        }
        protected override async Task OnMessage(GameBalanceMsg msg, CancellationToken cancellationToken)
        {
            TimeSpan elapsedTime = await MeasureExecutionTime<GameMQSub>(async () => await Exec(msg));
            Console.WriteLine($"{msg.AppId} 调用Partner BetWin -> 耗时:{elapsedTime.Milliseconds} ms");
        }

        private async Task Exec(GameBalanceMsg msg)
        {
            var Account = await GetAccount(msg.UserId, msg.AppId);
            if (Account!=null)
            {
                if (Account.Balance <= 0 || Account.Balance < msg.Bet) {
                    //更新用户数据
                    Console.WriteLine($"=====余额不足==FAIL=={msg.AppId}====={msg.UserId}=================={msg.Balance}");
                    await _extMO.PutByPKAsync(msg.UserId, $"UserStatus=0");
                    return;
                }
            }

            var _account = await BetWin(msg.UserId, msg.AppId, msg.BetId.ToString()
                   , msg.Bet, msg.Win);
            if (_account == null) { Console.WriteLine($"=======FAIL==调用接口返回异常=={msg.AppId}====={msg.UserId}=================={msg.Balance}"); }
            else
            {
                if (_account.Balance != msg.Balance || _account.Bonus != msg.Bonus)
                {
                    //Console.WriteLine($"=======FAIL=={msg.AppId}====={msg.UserId}=================={msg.Balance}");
                    ////更新用户数据
                    //await _extMO.PutByPKAsync(msg.UserId, $"UserStatus=0");
                    var userExt = await loadService.CheckUserExtAsync(msg.UserId, false,msg.AppId);

                    await loadService.SyncBalance(userExt);
                }
                else
                {
                    Console.WriteLine($"=======SUCCESS=={msg.AppId}====={msg.UserId}=================={msg.Balance}");
                }
            }
        }
    }
}
