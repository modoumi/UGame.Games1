using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using TinyFx.Configuration;
using TinyFx.Security;
using TinyFx.Serialization;

namespace Xxyy.GameEAPI.Temp
{
    //
    // 摘要:
    //     当前上下文
    public static class HttpContextEx_Temp
    {
        private const string CONTEXT_KEY = "CONTEXT_KEY";

        private static ISerializer _serializer = new TinyJsonSerializer();

        //
        // 摘要:
        //     当前Current
        public static HttpContext Current
        {
            get
            {
                IHttpContextAccessor requiredService = DIUtil.GetRequiredService<IHttpContextAccessor>();
                return requiredService.HttpContext;
            }
        }

        public static HttpRequest Request => Current?.Request;

        public static HttpResponse Response => Current?.Response;

        public static ClaimsPrincipal User => Current?.User;

        //
        // 摘要:
        //     当前授权用户编码
        public static string IdentityUserId => User?.Identity?.Name;

        public static ConnectionInfo Connection => Current?.Connection;

        public static IDictionary<object, object> Items => Current?.Items;

        public static ISession Session => Current?.Session;

        public static bool TryGetItem<T>(string key, out T value)
        {
            object value2;
            bool flag = Items.TryGetValue(key, out value2);
            value = flag ? (T)value2 : default;
            return flag;
        }

        public static void SetItem(string key, object value)
        {
            Items.Add(key, value);
        }

        //
        // 摘要:
        //     获取header值
        //
        // 参数:
        //   name:
        public static string GetHeaderValue(string name)
        {
            HttpRequest request = Request;
            object result;
            if (request == null)
            {
                result = null;
            }
            else
            {
                IHeaderDictionary headers = request.Headers;
                result = headers != null ? headers[name].FirstOrDefault() : null;
            }

            return (string)result;
        }

        //
        // 摘要:
        //     设置自定义上下文
        //
        // 参数:
        //   context:
        //
        // 类型参数:
        //   T:
        public static void SetContext<T>(T context) where T : class
        {
            if (Items.ContainsKey("CONTEXT_KEY"))
            {
                Items["CONTEXT_KEY"] = context;
            }
            else
            {
                Items.Add("CONTEXT_KEY", context);
            }
        }

        //
        // 摘要:
        //     获取自定义上下文
        //
        // 类型参数:
        //   T:
        //
        // 异常:
        //   T:System.Exception:
        public static T GetContext<T>() where T : class
        {
            if (!Items.TryGetValue("CONTEXT_KEY", out var value))
            {
                throw new Exception("获取自定义上下文Contexnt失败，没有初始化! type:" + typeof(T).GetType().FullName);
            }

            return (T)value;
        }

        public static void SetSession(string key, object value)
        {
            byte[] value2 = _serializer.Serialize(value);
            Session.Set(key, value2);
        }

        public static T GetSessionOrDefault<T>(string key, T defaultValue)
        {
            byte[] array = Session.Get(key);
            if (array == null)
            {
                return defaultValue;
            }

            return _serializer.Deserialize<T>(array);
        }

        public static T GetSessionOrException<T>(string key)
        {
            byte[] utf8Bytes = Session.Get(key);
            return _serializer.Deserialize<T>(utf8Bytes);
        }

        //
        // 摘要:
        //     使用cookie登录验证（需要配置SessionOrCookie）
        //
        // 参数:
        //   userId:
        //
        //   enforceUse:
        //     是否强制使用,true:没有配置抛出异常
        public static async Task SignInUseCookie(string userId, bool enforceUse = false)
        {
            SessionAndCookieSection section = ConfigUtil.GetSection<SessionAndCookieSection>();
            if (section == null || !section.UseCookieIdentity)
            {
                if (enforceUse)
                {
                    throw new Exception("使用cookie登录时，必须设置SessionOrCookieSection");
                }

                return;
            }

            List<Claim> claims = new List<Claim>
            {
                new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", userId)
            };
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Cookies");
            await AuthenticationHttpContextExtensions.SignInAsync(properties: new AuthenticationProperties
            {
                AllowRefresh = true,
                ExpiresUtc = DateTimeOffset.MaxValue,
                IsPersistent = true
            }, context: Current, scheme: "Cookies", principal: new ClaimsPrincipal(claimsIdentity));
        }

        //
        // 摘要:
        //     cookie验证登出
        public static async Task SignOutUseCookie()
        {
            SessionAndCookieSection section = ConfigUtil.GetSection<SessionAndCookieSection>();
            if (section != null && section.UseCookieIdentity)
            {
                await Current.SignOutAsync("Cookies");
            }
        }

        public static JwtTokenInfo GetJwtToken(string userIp = null)
        {
            string headerValue = GetHeaderValue("Authorization");
            if (!string.IsNullOrEmpty(headerValue) && headerValue.StartsWith("Bearer "))
            {
                headerValue = headerValue.Substring(7).Trim();
                if (!string.IsNullOrEmpty(headerValue))
                {
                    return JwtUtil.ReadJwtToken(headerValue, userIp);
                }
            }

            throw new CustomException("G_JwtTokenInvalid", "HttpContextEx.JwtTokenInfo时错误");
        }
    }
}