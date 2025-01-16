using TinyFx.Caching;
using TinyFx.Extensions.StackExchangeRedis;
using Xxyy.GameEAPI.Common;

namespace Xxyy.GameEAPI.Caching.Login.UserId
{
    /// <summary>
    /// 根据username获取userId
    /// </summary>
    internal class UsernameLoginDCache : RedisStringClient<string>
    {
        public TimeSpan EXPIRE_SPAN { get; } // 缓存有效期3天
        public string Username { get; set; }
        public UsernameLoginDCache(string username, TimeSpan? expire = null)
        {
            if (string.IsNullOrEmpty(username))
                throw new Exception("UsernameLoginDCache时username为空");

            Username = username;
            EXPIRE_SPAN = expire.HasValue ? expire.Value : TimeSpan.FromDays(3);
            RedisKey = GetGlobalGroupRedisKey("Login", username);
        }
        protected override async Task<CacheValue<string>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<string>();
            foreach (var userMo in DbSink.GetUserMoList())
            {
                var userId = (await userMo.GetSingleAsync($"Username=@Username", Username))?.UserID;
                if (userId != null)
                {
                    ret.HasValue = true;
                    ret.Value = userId;
                    break;
                }
            }
            return ret;
        }
        public async Task<CacheValue<string>> GetUserId()
        {
            return await GetOrLoadAsync(false, EXPIRE_SPAN);
        }

        public async Task RemoveUserId()
        {
            await KeyDeleteAsync();
        }
    }
}
