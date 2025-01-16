using System.Collections.Concurrent;
using System.Reflection;
using TinyFx.AspNet;
using TinyFx.Configuration;
using Xxyy.Common.Partners;
using Xxyy.GameEAPI.Caching;
using Xxyy.GameEAPI.Common.Const;

namespace Xxyy.GameEAPI.Common
{
    public static class XxyyUtil
    {
        public static string GetNickname(string nickName = null)
        {
            return string.IsNullOrEmpty(nickName)
                ? $"G-{StringUtil.GetGuidString()}"
                : nickName;
        }

        private static ConcurrentDictionary<string, object> _asmObjCache = new();
        public static T CreateFromAssembly<T>(string asmName, string typeName, params object[] args)
            where T : class
        {
            var fullName = $"{asmName}.{typeName}";
            if (!_asmObjCache.TryGetValue(fullName, out object obj))
            {
                var asmFile = $"{asmName}.dll";
                var asm = Assembly.LoadFrom(Path.Combine(AppContext.BaseDirectory, asmFile));
                var type = asm.GetType(fullName, true, true);
                obj = Activator.CreateInstance(type, args);

                _asmObjCache.TryAdd(fullName, obj);
            }
            T ret = obj as T;
            if (ret == null)
                throw new Exception($"{typeName}不存在。dll: {asmName}");
            return ret;
        }

        #region Money和Amount相互转换

        public static long MToA(this decimal money, string currencyId)
            => (long)(GetCurrencyUnit(currencyId) * money);
        public static long MToA(this double money, string currencyId)
            => ((decimal)money).MToA(currencyId);
        public static long MToAByCountryId(this decimal money, string countryId)
            => (long)(GetCurrencyUnitByCountryId(countryId) * money);
        public static long MToAByCountryId(this double money, string countryId)
            => ((decimal)money).MToAByCountryId(countryId);
        public static decimal AToM(this long amount, string currencyId)
            => amount / GetCurrencyUnit(currencyId);
        public static decimal AToM(this int amount, string currencyId)
            => ((long)amount).AToM(currencyId);
        public static decimal AToMByCountryId(this long amount, string countryId)
            => amount / GetCurrencyUnitByCountryId(countryId);
        public static decimal AToMByCountryId(this int amount, string countryId)
            => ((long)amount).AToMByCountryId(countryId);

        /// <summary>
        /// 获取货币对应的基础货币单位（1单位货币等于多少最小币值）
        /// 如当BaseUnit = 100时
        ///     充值时存入的值Balance = (long)Amount*100
        ///     返回客户端的值 = Balance/100;
        /// </summary>
        /// <param name="currencyId"></param>
        /// <returns></returns>
        private static decimal GetCurrencyUnit(string currencyId)
        {
            if (string.IsNullOrEmpty(currencyId))
                throw new ArgumentNullException(nameof(currencyId));
            return DbCacheUtil.GetCurrency(currencyId).BaseUnit;
        }
        private static decimal GetCurrencyUnitByCountryId(string countryId)
        {
            if (string.IsNullOrEmpty(countryId))
                throw new ArgumentNullException(nameof(countryId));
            var country = DbCacheUtil.GetCountry(countryId);
            if (string.IsNullOrEmpty(country.CurrencyID))
                throw new Exception($"国家没有配置主货币。countryId: {countryId}");
            return GetCurrencyUnit(country.CurrencyID);
        }
        #endregion

        public static PartnerCodeType GetPartnerCodeType(string partnerCode)
        {
            switch (partnerCode)
            {
                case PartnerCode.RS_OK:
                    return PartnerCodeType.Ok;
                case PartnerCode.RS_NOT_ENOUGH_MONEY:
                    return PartnerCodeType.NotEnoughMoney;
                case PartnerCode.RS_USER_DISABLED:
                    return PartnerCodeType.UserDisabled;
                default:
                    return PartnerCodeType.UnknownError;
            }
        }

        #region 客户端获取的URL
        public static string GetAppUrl(string url = null)
        {
            if (url.StartsWith('/'))
            {
                if (ConfigUtil.Environment.IsDebug)
                    return $"{AspNetUtil.GetRequestBaseUrl()}{url}";
                // TODO https异常
                return $"https://www.{AspNetUtil.GetRequestTopDomain()}{url}";
            }
            return url;
        }
        public static string GetUploadUrl(string url = null)
        {
            if (url.StartsWith('/'))
            {
                if (ConfigUtil.Environment.IsDebug)
                    return $"{AspNetUtil.GetRequestBaseUrl()}{url}";
                //
                return $"https://upload.777gana.com{url}";
            }
            return url;
        }
        #endregion

        #region DateTime
        /// <summary>
        /// UTC时间转换OperatorId所在当地时间
        /// </summary>
        /// <param name="utcTime"></param>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        public static DateTime ToLocalTime(this DateTime utcTime, string operatorId)
        {
            var timeZone = DbCacheUtil.GetOperatorTimeZone(operatorId);
            return TimeZoneInfo.ConvertTimeFromUtc(utcTime, timeZone);
        }
        /// <summary>
        /// OperatorId所在当地时间转换UTC时间
        /// </summary>
        /// <param name="localTime"></param>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        public static DateTime ToUtcTime(this DateTime localTime, string operatorId)
        {
            var timeZone = DbCacheUtil.GetOperatorTimeZone(operatorId);
            return TimeZoneInfo.ConvertTimeToUtc(localTime, timeZone);
        }
        /// <summary>
        /// 获取指定年月日时分秒的OperatorId所在当地时间
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        /// <param name="second"></param>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        public static DateTimeOffset GetLocalTime(string operatorId, int year, int month, int day, int hour = 0, int minute = 0, int second = 0)
        {
            var timeZone = DbCacheUtil.GetOperatorTimeZone(operatorId);
            var ret = new DateTimeOffset(year, month, day, hour, minute, second, timeZone.BaseUtcOffset);
            return ret;
        }
        #endregion
    }
}
