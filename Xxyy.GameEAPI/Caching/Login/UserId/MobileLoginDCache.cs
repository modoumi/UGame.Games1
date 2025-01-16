using TinyFx.Caching;
using TinyFx.Extensions.StackExchangeRedis;
using Xxyy.GameEAPI.Common;

namespace Xxyy.GameEAPI.Caching.Login.UserId
{
    /// <summary>
    /// 根据mobile获取userId 
    /// key: mobile value: userId
    /// </summary>
    internal class MobileLoginDCache : RedisStringClient<string>
    {
        public TimeSpan EXPIRE_SPAN { get; } // 缓存有效期3天
        public string Mobile { get; set; }
        public MobileLoginDCache(string mobile, TimeSpan? expire = null)
        {
            if (string.IsNullOrEmpty(mobile))
                throw new Exception("MobileLoginDCache时mobile为空");

            Mobile = mobile;
            EXPIRE_SPAN = expire.HasValue ? expire.Value : TimeSpan.FromDays(3);
            RedisKey = GetGlobalGroupRedisKey("Login", mobile);
        }
        protected override async Task<CacheValue<string>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<string>();
            foreach (var userMo in DbSink.GetUserMoList())
            {
                var userId = (await userMo.GetSingleAsync($"Mobile=@Mobile", Mobile))?.UserID;
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
