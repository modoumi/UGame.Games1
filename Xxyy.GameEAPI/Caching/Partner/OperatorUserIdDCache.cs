using TinyFx.Caching;
using TinyFx.Data;
using TinyFx.Extensions.StackExchangeRedis;
using Xxyy.GameEAPI.Common;

namespace Xxyy.Common.Caching.Partner
{
    public class OperatorUserIdDCache : RedisStringClient<string>
    {
        private const int EXPIRE_DAYS = 3; // 缓存有效期
        public string OperatorId { get; set; }
        public string OperatorUserId { get; set; }
        public OperatorUserIdDCache(string operatorId, string operatorUserId)
        {
            if (string.IsNullOrEmpty(operatorId))
                OperatorId = operatorId;
            OperatorUserId = operatorUserId;
            RedisKey = GetProjectRedisKey($"{OperatorId}:{OperatorUserId}");
        }
        //private string GetKey() => $"{OperatorId}:{OperatorUserId}";
        protected override async Task<CacheValue<string>> LoadValueWhenRedisNotExistsAsync()
        {
            foreach (var mo in DbSink.GetUserMoList())
            {
                var where = $"OperatorID='{OperatorId}' and OperatorUserId='{OperatorUserId}'";
                var row = await mo.GetSingleRowAsync("UserID", where);
                if (row != null)
                {
                    return new CacheValue<string>(row.ToString(0));
                }
            }
            return new CacheValue<string>(false);
        }

        public async Task<string> GetUserId()
        {
            var ret = await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_DAYS));
            return ret.Value;
        }
        public async Task SetUserId(string userId)
        {
            await SetAndExpireDaysAsync(userId, EXPIRE_DAYS);
        }
    }
}
