using Xxyy.GameEAPI.Common.Const;

namespace Xxyy.GameEAPI.Caching.AppServer
{
    public class MemoryUtils
    {
        private static MemoryUtils _instance = null;
        private static Dictionary<string, string> AppServerUrlDic;
        private static readonly object _lock = new();
        private MemoryUtils()
        {
        }

        public static MemoryUtils Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance ??= new MemoryUtils();
                    }
                }
                return _instance;
            }
        }
        public void SetAppServerUrl(string appId, ServerType serverType, string sign, string appServerUrl)
        {
            AppServerUrlDic ??= new Dictionary<string, string>();
            var key = GetKey(appId, serverType, sign);
            if (!AppServerUrlDic.ContainsKey(key))
            {
                AppServerUrlDic.Add(key, appServerUrl);
            }
        }
        public string GetAppServerUrl(string appId, ServerType serverType, string sign)
        {
            return AppServerUrlDic[GetKey(appId, serverType, sign)];
        }
        public string GetKey(string appId, ServerType serverType, string sign)
        {
            return string.IsNullOrEmpty(sign) ? $"{appId}|{serverType}" : $"{appId}|{serverType}|{sign}";
        }
    }
}
