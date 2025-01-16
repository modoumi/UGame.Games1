using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Cryptography;
using System.Text;
using TinyFx.AspNet;
using TinyFx.Configuration;
using Xxyy.GameEAPI.Caching.Login;

namespace Xxyy.GameEAPI.Common
{
    public class VerifyClientRequestAttribute : Attribute, IAsyncActionFilter
    {
        public const string SESSION_KEY = "ACCESS_KEY_DATA";
        public const string HEADER_NAME = "Tinyfx-Sign";
        private AppSectionBase _section;
        public VerifyClientRequestAttribute()
        {
            _section = ConfigUtil.GetSection<AppSectionBase>();
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (_section != null && _section.UseVerifyClientRequest)
            {
                if (!context.HttpContext.Request.Headers.TryGetValue(HEADER_NAME, out var value))
                    throw new CustomException(CommonCodes.RS_INVALID_SIGNATURE, "无效的Tinyfx-Sign, header不存在");
                var data = Convert.ToString(value)?.Split('|');
                if (data == null || data.Length != 2)
                    throw new CustomException(CommonCodes.RS_INVALID_SIGNATURE, "无效的Tinyfx-Sign, header值格式不对");

                // 取值
                var uuid = data[0];
                var sign = data[1];
                var accessKeyDo = await new AccessKeyDCache(uuid).GetDo();
                if (accessKeyDo == null)
                    throw new CustomException(CommonCodes.RS_INVALID_SIGNATURE, "无效的Tinyfx-Sign，accessKeyDo不存在。");
                //var userId = HttpContextEx.IdentityUserId;
                //if (!string.IsNullOrEmpty(userId) && userId != accessKeyDo.UserId)
                //    throw new CustomException(CommonCodes.RS_INVALID_SIGNATURE, "无效的Tinyfx-Sign，userId异常。");
                var content = await AspNetUtil.GetRequestBodyAsync(context.HttpContext);
                content = string.IsNullOrEmpty(content) ? "null" : content;

                //验证
                var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(accessKeyDo.AccessKey));
                var hash = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(content)));
                if (hash != sign)
                    throw new CustomException(CommonCodes.RS_INVALID_SIGNATURE, "无效的Tinyfx-Sign，sign错误。");
            }

            await next.Invoke();
        }
    }
}
