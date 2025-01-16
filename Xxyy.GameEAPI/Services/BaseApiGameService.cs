using Google.Protobuf.WellKnownTypes;
using TinyFx.AspNet;
using TinyFx.Configuration;
using Xxyy.Common.Caching.Partner;
using Xxyy.GameEAPI.Caching.Login;
using Xxyy.GameEAPI.Common;

namespace Xxyy.GameEAPI.Services
{
    /// <summary>
    /// API游戏服务基类
    /// </summary>
    public class BaseApiGameService
    {
        public string AppId => HttpContextEx.GetJwtToken()?.Meta;
        /// <summary>
        /// 验证是否有效登录，测试时mock数据
        /// </summary>
        /// <returns></returns>
        public async Task<bool> CheckIdentityAndMock(string userId = null)
        {
            var ret = CheckUserIdentity(userId);
            if (!ret)
            {
                // 模拟登录
                await new GameEngineService().Login(new GameEngineLoginIpo
                {
                    AppId = AppId,
                    UserId = userId,
                });
            }
            return ret;
        }

        private AppLoginTokenDO _loginTokenDo;
        public AppLoginTokenDO GetLoginTokenDo(string userId = null,string appid = "")
        {
            if (_loginTokenDo == null)
            {
                var isLogin = CheckUserIdentity(userId);
                userId = isLogin ? HttpContextEx.IdentityUserId : userId;
                _loginTokenDo = LoginCacheUtil.GetAppLoginTokenDoAsync(userId, string.IsNullOrEmpty(appid) ? AppId : appid).GetAwaiter().GetResult();
            }
            if (_loginTokenDo == null)
            {
                throw new CustomException(CommonCodes.LOGIN_TIMEOUT, "从redis获取appToken为空!");
            }
            return _loginTokenDo;
        }
        private bool CheckUserIdentity(string userId = null)
        {
            var iuserid = HttpContextEx.IdentityUserId;
            var isLogin = !string.IsNullOrEmpty(iuserid);
            if (isLogin)
            {
                if (!string.IsNullOrEmpty(userId) && iuserid != userId)
                    throw new Exception("UserId不一致，禁止访问");
            }
            else
            {
                if (string.IsNullOrEmpty(userId))//|| !ConfigUtil.Environment.IsDebug //"Environment:" + ConfigUtil.Environment.IsDebug
                {
                    string error = "v1正式环境必须登录访问或者测试环境需指定userId:" + userId  + "iuserid:" + iuserid;
                    throw new Exception(error);
                }
               
            }
            return isLogin;
        }
    }
}
