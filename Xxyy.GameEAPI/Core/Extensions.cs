using Microsoft.Extensions.DependencyInjection;
using System.Collections.Concurrent;
using System.Text.Json;

namespace Xxyy.GameEAPI.Core;

public static class Extensions
{
    private static ConcurrentDictionary<int, Type> namedInstances = new();
    public static IServiceCollection AddSingleton<TService, TImplementation>(this IServiceCollection services, string name)
        where TService : class
        where TImplementation : class, TService
    {
        services.AddSingleton<TImplementation>();
        var serverType = typeof(TService);
        var implType = typeof(TImplementation);

        var hashKey = HashCode.Combine(serverType, name);
        namedInstances.TryAdd(hashKey, implType);
        return services;
    }
    public static TService GetService<TService>(this IServiceProvider serviceProvider, string name)
    {
        var serverType = typeof(TService);
        var hashKey = HashCode.Combine(serverType, name);

        if (!namedInstances.TryGetValue(hashKey, out var implType))
            throw new Exception($"没有注册命名为{name}的服务类型:{serverType.FullName}");
        return (TService)serviceProvider.GetService(implType);
    }

    public static T JsonTo<T>(this object obj)
    {
        if (obj == null) return default;
        if (obj is JsonElement element)
            return JsonSerializer.Deserialize<T>(element.GetRawText());
        if (obj is string json)
            return JsonSerializer.Deserialize<T>(json);
        return obj.ConvertTo<T>();
    }
    public static T ConvertTo<T>(this object obj)
    {
        if (obj == null) return default;
        var targetType = typeof(T);
        var type = obj.GetType();
        if (targetType.IsAssignableFrom(type))
            return (T)obj;
        var underlyingType = Nullable.GetUnderlyingType(targetType);
        if (underlyingType == null) underlyingType = targetType;
        object result = obj;
        if (underlyingType.IsEnum)
        {
            var enumObj = Convert.ChangeType(result, underlyingType.GetEnumUnderlyingType());
            return (T)Enum.ToObject(underlyingType, enumObj);
        }
        return (T)Convert.ChangeType(result, underlyingType);
    }
    public static string ToJson(this object obj)
    {
        if (obj == null) return null;
        return JsonSerializer.Serialize(obj);
    }
    public static T JsonProperty<T>(this object jsonObj, string propertyName)
    {
        if (jsonObj.TryGetProperty<T>(propertyName, out var value))
            return value;
        return default;
    }
    public static bool TryGetProperty<T>(this object jsonObj, string propertyName, out T value)
    {
        if (jsonObj == null)
        {
            value = default;
            return false;
        }
        if (jsonObj is JsonElement element && element.TryGetProperty(propertyName, out var jsonValue))
        {
            value = jsonValue.JsonTo<T>();
            return true;
        }
        value = default;
        return false;
    }
    public static bool TryGetTo<T>(this Dictionary<string, object> dict, string key, out T value)
    {
        if (dict == null)
        {
            value = default;
            return false;
        }
        if (dict.TryGetValue(key, out var objValue))
        {
            value = (T)objValue;
            return true;
        }
        value = default;
        return false;
    }
    public static DateTimeOffset ToHalfMinute(this DateTimeOffset dateTime)
    {
        if (dateTime.Second > 30)
        {
            return dateTime.AddSeconds(30 - dateTime.Second).AddMilliseconds(-dateTime.Millisecond);
        }
        return dateTime.AddSeconds(-dateTime.Second).AddMilliseconds(-dateTime.Millisecond);
    }
    internal static SortedSet<int> TailSet(this SortedSet<int> set, int value)
    {
        return set.GetViewBetween(value, 9999999);
    }
}
