using TinyFx;
using TinyFx.SnowflakeId;
using TinyFx.Extensions.StackExchangeRedis;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Services;

namespace Fortune_tiger.BLL
{
    public class Program : BaseApiGameService
    {
        static async void Main()
        {
           /* BetIpo ipo = new BetIpo() { AppId = "fortune_tiger", ChipsId = 1, CurrencyId = "BRL", UserId = "003f038c-758d-4413-9886-603bac417c44" };
            var api = new BaseApiGameService();
            var appToken = api.GetLoginTokenDo(ipo.UserId);
            await api.CheckIdentityAndMock(ipo.UserId);
            var context = new BetContext(ipo, appToken);
            var lockKey = $"{appToken.AppId}:{ipo.UserId}";
            using (var redlock = await RedisUtil.LockAsync(lockKey, CommonCodes.LockTime))
            {
                if (!redlock.IsLocked)
                {
                    redlock.Release();
                    throw new CustomException(CommonCodes.UserConcurrent, $"{lockKey}:请求分布式锁失败!");
                }
                var betId = context.BetId = SnowflakeIdUtil.NextId();
                long balance = 0;
                //算法逻辑
                await new BetInitProcess().Execute(context);
                await new BetProcess().Execute(context);
            }
            Console.WriteLine($"context:{SerializerUtil.SerializeJsonNet(context)}");*/
        }
    }
}
