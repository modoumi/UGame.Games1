using Microsoft.Extensions.Configuration;
using StackExchange.Redis;
using TinyFx.Configuration;

namespace Xxyy.GameEAPI.Core;

public class GameRedisUtil
{
    private readonly int databaseIndex = -1;
    private readonly string url;
    private readonly ConnectionMultiplexer connectionPool;

    public GameRedisUtil(IConfiguration configuration)
    {
        url = ConfigUtil.Configuration["Redis:ConnectionStrings:default:ConnectionString"];
        //this.databaseIndex = configuration.GetValue("Redis:Database", -1); 
        if (string.IsNullOrEmpty(url))
            throw new ArgumentNullException("appsettings.json中缺少Redis:ConnectionStrings:default配置项");
        connectionPool = ConnectionMultiplexer.Connect(url);
    }
    public void Set(string key, object value, int lifetimeMinutes = 60)
    {
        if (string.IsNullOrEmpty(key))
            throw new ArgumentNullException(key);
        var database = connectionPool.GetDatabase(databaseIndex);
        database.StringSet(key, SerializerUtil.SerializeJsonNet(value), TimeSpan.FromMinutes(lifetimeMinutes));
    }
    public async Task SetAsync(string key, object value, int lifetimeMinutes = 60)
    {
        if (string.IsNullOrEmpty(key))
            throw new ArgumentNullException(key);
        var database = connectionPool.GetDatabase(databaseIndex);
        if (lifetimeMinutes == -1)
            await database.StringSetAsync(key, SerializerUtil.SerializeJsonNet(value));
        else
            await database.StringSetAsync(key, SerializerUtil.SerializeJsonNet(value), TimeSpan.FromMinutes(lifetimeMinutes));
    }
    public bool TryGet<T>(string key, out T result)
    {
        if (string.IsNullOrEmpty(key))
            throw new ArgumentNullException(key);
        var database = connectionPool.GetDatabase(databaseIndex);
        var redisValue = database.StringGet(key);
        if (redisValue.IsNull)
        {
            result = default;
            return false;
        }
        result = SerializerUtil.DeserializeJsonNet<T>(redisValue);
        return true;
    }
    public async Task<(bool, T)> GetAsync<T>(string key)
    {
        if (string.IsNullOrEmpty(key))
            throw new ArgumentNullException(key);
        var database = connectionPool.GetDatabase(databaseIndex);
        var redisValue = await database.StringGetAsync(key);
        if (redisValue.IsNull) return (false, default);
        return (true, SerializerUtil.DeserializeJsonNet<T>(redisValue));
    }
    public async Task<long> IncrementAsync(string key, int lifetimeMinutes = 60)
    {
        if (string.IsNullOrEmpty(key))
            throw new ArgumentNullException(key);
        var database = connectionPool.GetDatabase(databaseIndex);
        if (!database.KeyExists(key))
            database.StringSet(key, 0, TimeSpan.FromMinutes(lifetimeMinutes));
        var result = await database.StringIncrementAsync(key);
        return result;
    }
    public async Task RemoveCache(string key)
    {
        if (string.IsNullOrEmpty(key))
            throw new ArgumentNullException(key);
        var database = connectionPool.GetDatabase(databaseIndex);
        await database.KeyDeleteAsync(key);
    }
}