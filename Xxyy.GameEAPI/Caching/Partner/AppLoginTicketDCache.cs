using TinyFx.Configuration;
using TinyFx.Extensions.StackExchangeRedis;
using TinyFx.Logging;

namespace Xxyy.Common.Caching.Partner
{
    public class AppLoginTicketDCache : RedisStringClient<AppLoginTicketDO>
    {
        private int EXPIRE_SECONDS = 120; // 缓存有效期
        public string AppId { get; set; }
        public string Ticket { get; set; }
        public AppLoginTicketDCache(string appId, string ticket)
        {
            EXPIRE_SECONDS = ConfigUtil.Environment.IsDebug
                ? (int)TimeSpan.FromDays(1).TotalSeconds : 120;
            AppId = appId;
            Ticket = ticket;
            RedisKey = GetGlobalGroupRedisKey("Partner", $"{appId}:{ticket}");
            LogUtil.Info($"登录入参: appId:{appId},ticket:{ticket},RedisKey:{RedisKey}");
        }
        public Task SetTicketDoAndExpire(AppLoginTicketDO loginDo)
        {
            return SetAndExpireSecondsAsync(loginDo, EXPIRE_SECONDS);
        }

        /// <summary>
        /// 用于游戏服务器调用，验证用户登录并获取数据
        /// </summary>
        /// <returns></returns>
        public async Task<AppLoginTicketDO> GetTicketDoAndDelete()
        {
            var ret = await GetOrDefaultAsync(null);
            LogUtil.Info($"GetOrDefaultAsync 返回值: ret:{SerializerUtil.SerializeJsonNet(ret)}");
            if (ret != null)
                await KeyDeleteAsync();
            return ret;
        }
    }

    public class AppLoginTicketDO
    {
        public string Token { get; set; }
        public string AppId { get; set; }
        public string UserId { get; set; }
        public string UserIp { get; set; }
    }
}
