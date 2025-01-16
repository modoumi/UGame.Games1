using Xxyy.Common.Caching;
using Xxyy.Common.Caching.Partner;
using Xxyy.GameEAPI.Caching.Login.UserId;
using Xxyy.GameEAPI.Common;

namespace Xxyy.GameEAPI.Caching.Login
{
    public static class LoginCacheUtil
    {
        #region Email|Mobile|Username => UserId
        public static async Task<string> GetUserIdByEmail(string email, TimeSpan? expire = null)
        {
            if (string.IsNullOrEmpty(email))
                throw new ArgumentNullException("Email不能为空");
            var ret = await new EmailLoginDCache(email, expire).GetUserId();
            if (!ret.HasValue)
                throw new CustomException(CommonCodes.EmailNotExist, $"Email不存在。email:{email}");
            return ret.Value;
        }
        public static async Task<string> GetUserIdByMobile(string mobile, TimeSpan? expire = null)
        {
            if (string.IsNullOrEmpty(mobile))
                throw new ArgumentNullException("mobile不能为空");
            var item = await new MobileLoginDCache(mobile, expire).GetUserId();
            if (!item.HasValue)
                throw new CustomException(CommonCodes.MobileNotExist, $"mobile不存在。mobile:{mobile}");
            return item.Value;
        }

        public static async Task<string> GetUserIdByUsername(string username, TimeSpan? expire = null)
        {
            if (string.IsNullOrEmpty(username))
                throw new ArgumentNullException("username不能为空");
            var item = await new UsernameLoginDCache(username, expire).GetUserId();
            if (!item.HasValue)
                throw new CustomException(CommonCodes.UsernameNotExist, $"username不存在。username:{username}");
            return item.Value;
        }

        public static async Task<string> GetUserIdByOperatorUserId(string operatorId, string operatorUserId, TimeSpan? expire = null)
        {
            if (string.IsNullOrEmpty(operatorId))
                throw new ArgumentNullException("operatorId不能为空");
            if (string.IsNullOrEmpty(operatorUserId))
                throw new ArgumentNullException("operatorUserId不能为空");
            var item = await new OperatorUserDCache(operatorId, operatorUserId, expire).GetUserId();
            if (!item.HasValue)
                throw new CustomException(CommonCodes.OperatorUserIdNotExist, $"运营商用户不存在。operatorId:{operatorId} operatorUserId:{operatorUserId}");
            return item.Value;
        }
        #endregion

        #region AppLoginToken
        public static async Task SetAppLoginTokenDoAsync(AppLoginTokenDO appLoginTokenDO)
        {
            TinyFxUtil.ThrowIfNullOrEmpty("SetAppLoginTokenDoAsync时appid,token,userid不能为空"
                , appLoginTokenDO.AppId, appLoginTokenDO.Token, appLoginTokenDO.UserId);
            await new AppLoginTokenDCache(appLoginTokenDO.AppId, appLoginTokenDO.Token).SetTokenDo(appLoginTokenDO);
            await new UserAppDCache(appLoginTokenDO.UserId, appLoginTokenDO.AppId).SetLoginTokenAsync(appLoginTokenDO.Token);
        }

        public static async Task<AppLoginTokenDO> GetAppLoginTokenDoAsync(string userId, string appId)
        {
            TinyFxUtil.ThrowIfNullOrEmpty("GetAppLoginTokenDoAsync时appid,userid不能为空", userId, appId);
            var token = await new UserAppDCache(userId, appId).GetLoginTokenAsync();
            return !string.IsNullOrEmpty(token)
                ? await GetAppLoginTokenDoByTokenAsync(appId, token)
                : null;
        }

        public static async Task<AppLoginTokenDO> GetAppLoginTokenDoByTokenAsync(string appId, string token)
        {
            TinyFxUtil.ThrowIfNullOrEmpty("GetAppLoginTokenDoByTokenAsync时appid,token不能为空", token, appId);
            return await new AppLoginTokenDCache(appId, token).GetTokenDo();
        }
        #endregion

        #region AccessKey
        //public async Task 
        #endregion
    }
}
