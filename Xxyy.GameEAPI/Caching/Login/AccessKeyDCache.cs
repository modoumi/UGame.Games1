using TinyFx.Extensions.StackExchangeRedis;

namespace Xxyy.GameEAPI.Caching.Login
{
    public class AccessKeyDCache : RedisStringClient<AccessKeyDO>
    {
        public TimeSpan EXPIRE_SPAN { get; } // 缓存有效期3天
        public string AccessKeyId { get; set; }
        public AccessKeyDCache(string accessKeyId, TimeSpan? expire = null)
        {
            if (string.IsNullOrEmpty(accessKeyId))
                throw new Exception("BothKeyDCache时uuid为空");

            AccessKeyId = accessKeyId;
            EXPIRE_SPAN = expire.HasValue ? expire.Value : TimeSpan.FromDays(3);
            RedisKey = GetGlobalGroupRedisKey("Login", accessKeyId);
        }

        public Task<AccessKeyDO> GetDo() => GetOrDefaultAsync(null, EXPIRE_SPAN);
        public Task SetDo(AccessKeyDO value) => SetAsync(value, EXPIRE_SPAN);
    }
    public class AccessKeyDO
    {
        public string AccessKeyId { get; set; }
        public string AppId { get; set; }
        public DateTime UtcTime { get; set; }
        public string BothKey { get; set; }
        public string AccessKey { get; set; }
        public string AccessKeyEncrypt { get; set; }

        public string OperatorId { get; set; }
        public string UserId { get; set; }
    }
}
