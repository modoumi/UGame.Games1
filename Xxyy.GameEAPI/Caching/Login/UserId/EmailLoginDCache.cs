using TinyFx.Caching;
using TinyFx.Extensions.StackExchangeRedis;
using Xxyy.GameEAPI.Common;

namespace Xxyy.GameEAPI.Caching.Login.UserId
{
    /// <summary>
    /// Email获取UserId缓存 
    /// key: email value: userId
    /// </summary>
    internal class EmailLoginDCache : RedisStringClient<string>
    {
        public TimeSpan EXPIRE_SPAN { get; } // 缓存有效期3天
        public string Email { get; set; }
        public EmailLoginDCache(string email, TimeSpan? expire = null)
        {
            if (string.IsNullOrEmpty(email))
                throw new Exception("EmailLoginDCache时email为空");

            Email = email;
            EXPIRE_SPAN = expire.HasValue ? expire.Value : TimeSpan.FromDays(3);
            RedisKey = GetGlobalGroupRedisKey("Login", email);
        }
        protected override async Task<CacheValue<string>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<string>();
            foreach (var userMo in DbSink.GetUserMoList())
            {
                var userId = (await userMo.GetSingleAsync($"Email=@Email", Email))?.UserID;
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
