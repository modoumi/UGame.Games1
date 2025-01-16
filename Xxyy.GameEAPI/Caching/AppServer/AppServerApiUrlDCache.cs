using TinyFx.Extensions.StackExchangeRedis;
using Xxyy.GameEAPI.Common.Const;

namespace Xxyy.Common.Caching.AppServer
{
    public class AppServerApiUrlDCache : RedisHashClient<string>
    {
        private static AppServerApiUrlDCache _instance = new();
        public static AppServerApiUrlDCache Create() => _instance;
        private AppServerApiUrlDCache()
        {
            RedisKey = GetGlobalGroupRedisKey("AppServer");
        }
        public string GetField(string appId, ServerType serverType, string sign)
            => string.IsNullOrEmpty(sign) ? $"{appId}|{serverType}" : $"{appId}|{serverType}|{sign}";
        public async Task SetServerUrl(string appId, ServerType serverType, string sign, string serverUrl)
        {
            await SetAsync(GetField(appId, serverType, sign), serverUrl);
        }
        public async Task<string> GetServerUrl(string appId, ServerType serverType, string sign)
        {
            return await GetOrDefaultAsync(GetField(appId, serverType, sign), null);
        }
    }
}
