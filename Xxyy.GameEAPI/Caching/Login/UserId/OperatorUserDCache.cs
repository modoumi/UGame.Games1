using TinyFx.Caching;
using TinyFx.Extensions.StackExchangeRedis;
using Xxyy.GameEAPI.Common;

namespace Xxyy.GameEAPI.Caching.Login.UserId
{
    /// <summary>
    /// 运营商用户对应的UserId映射缓存
    ///     key: operatorId|operatorUserId => UserId
    /// </summary>
    internal class OperatorUserDCache : RedisStringClient<string>
    {
        public TimeSpan EXPIRE_SPAN { get; } // 缓存有效期3天
        public string OperatorId { get; }
        public string OperatorUserId { get; set; }
        public OperatorUserDCache(string operatorId, string operatorUserId, TimeSpan? expire = null)
        {
            if (string.IsNullOrEmpty(operatorId) || string.IsNullOrEmpty(operatorUserId))
                throw new Exception("OperatorUserDCache时operatorId或者operatorUserId为空");

            OperatorId = operatorId;
            OperatorUserId = operatorUserId;
            EXPIRE_SPAN = expire.HasValue ? expire.Value : TimeSpan.FromDays(3);
            RedisKey = GetGlobalGroupRedisKey("Login", GetKey(operatorId, operatorUserId));
        }
        private static string GetKey(string operatorId, string operatorUserId)
            => $"{operatorId}|{operatorUserId}";
        protected override async Task<CacheValue<string>> LoadValueWhenRedisNotExistsAsync()
        {
            var ret = new CacheValue<string>();
            foreach (var userMo in DbSink.GetUserMoList())
            {
                var userId = (await userMo.GetSingleAsync($"OperatorID=@OperatorID and OperatorUserId=@OperatorUserId"
                        , OperatorId, OperatorUserId))?.UserID;
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
