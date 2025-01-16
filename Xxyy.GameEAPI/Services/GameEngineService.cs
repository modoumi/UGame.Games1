using TinyFx.AspNet;
using TinyFx.Configuration;
using TinyFx.Logging;
using TinyFx.Security;
using TinyFx.Text;
using Xxyy.Common.Caching;
using Xxyy.Common.Caching.Partner;
using Xxyy.DAL;
using Xxyy.GameEAPI.Caching;
using Xxyy.GameEAPI.Caching.Login;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Const;
using Xxyy.GameEAPI.Common.Enum;

namespace Xxyy.GameEAPI.Services
{
    public class GameEngineService
    {
        // private GameSectionBase _options { get; }
        public GameEngineService()
        {
            //_options = DIUtil.GetRequiredService<GameSectionBase>();
        }

        public async Task<GameEngineLoginDto> Login(GameEngineLoginIpo ipo)
        {
            if (string.IsNullOrEmpty(ipo.AppId))
                throw new ArgumentNullException(nameof(ipo.AppId));

            var ret = new GameEngineLoginDto();
            var userIp = AspNetUtil.GetRemoteIpString();

            AppLoginTokenDO tokenDo = null;
            if (string.IsNullOrEmpty(ipo.Ticket)) // 测试模式
            {
                if (string.IsNullOrEmpty(ipo.UserId))
                    throw new ArgumentNullException(nameof(ipo.UserId));
                // 测试环境模拟
                tokenDo = await MockAppLoginTokenDoWhenDebug(ipo);
                LogUtil.Debug($"当前环境:{ConfigUtil.Environment}");
                if (!ConfigUtil.Environment.IsDebug)
                    throw new CustomException($"游戏登录时直接传入userId进行登录测试，仅当Environment=Development或Testing有效");
            }
            else
            {
                tokenDo = await GetAppLoginTokenDo(ipo);
            }
            if (tokenDo == null || string.IsNullOrEmpty(tokenDo.AppId))
                throw new CustomException(CommonCodes.LOGIN_TIMEOUT, $"Login时无法获取LoginTokenDO"+ tokenDo.AppId);

            var user = await DbSink.BuildUserMo(tokenDo.UserId).GetByPKAsync(tokenDo.UserId);
            if (user == null)
                throw new CustomException($"用户不存在。userId: {tokenDo.UserId},ticket:{SerializerUtil.SerializeJson(tokenDo)}");
            var userKind = user.UserKind.ToEnum(UserKind.Unknow);

            //if (ConfigUtil.Environment.IsStaging && userKind != UserKind.Staging)
            //    throw new CustomException("仿真环境Staging时，用户UserKind必须Staging");
            //if (_options.ServerType == ServerType.JointDebug && userKind != UserKind.Debug)
            //    throw new CustomException("仿真环境Debug时，用户UserKind必须Debug");

            // 保存GlobalUserDCache
            var cache = new GlobalUserDCache(user.UserID);
            await cache.SetBaseValues(user);

            var app = DbCacheUtil.GetApp(ipo.AppId);
            ret.UserId = tokenDo.UserId;
            ret.ProviderId = app.ProviderID;
            ret.OperatorId = tokenDo.OperatorId;
            ret.CountryId = tokenDo.CountryId;
            ret.CurrencyId = tokenDo.CurrencyId;
            ret.LangId = tokenDo.LangId;
            var oper = DbCacheUtil.GetOperator(tokenDo.OperatorId);
            ret.OperatorLangs = oper.Langs?.Split('|').ToList();
            ret.LobbyUrl = GetLobbyUrl(oper, tokenDo);
            ret.BankUrl = GetBankUrl(oper, tokenDo);
            // 设置jwt
            ret.AppServerToken = JwtUtil.CreateJwtToken(tokenDo.UserId, user.UserKind.ToString(), userIp, null, tokenDo.AppId);
            // Cookie登录
            await HttpContextEx.SignInUseCookie(user.UserID, true);
            return ret;
        }
        private async Task<AppLoginTokenDO> MockAppLoginTokenDoWhenDebug(GameEngineLoginIpo ipo)
        {
            var user = await DbSink.BuildUserMo(ipo.UserId).GetByPKAsync(ipo.UserId);
            if (user == null)
                throw new Exception($"用户不存在。userId: {ipo.UserId}");
            var oper = DbCacheUtil.GetOperator(user.OperatorID);
            // new
            var ret = new AppLoginTokenDO
            {
                Token = ObjectId.NewId(),
                TokenFrom = 1,
                UserId = ipo.UserId,
                AppId = ipo.AppId,
                OperatorId = user.OperatorID,
                OperatorUserId = user.OperatorUserId,
                CountryId = user.CountryID,
                CurrencyId = user.CurrencyID,
                UserIp = AspNetUtil.GetRemoteIpString(),
                LangId = null,
                LobbyUrl = GetLobbyUrl(oper, null),
                DepositUrl = GetBankUrl(oper, null),
                UserKind = user.UserKind
            };
            await new UserAppDCache(ipo.UserId, ipo.AppId).SetLoginTokenAsync(ret.Token);
            await new AppLoginTokenDCache(ipo.AppId, ret.Token).SetTokenDo(ret);
            return ret;
        }
        private async Task<AppLoginTokenDO> GetAppLoginTokenDo(GameEngineLoginIpo ipo)
        {
            AppLoginTokenDO ret = null;
            // new
            var ticketDo = await new AppLoginTicketDCache(ipo.AppId, ipo.Ticket).GetTicketDoAndDelete();
            if (ticketDo != null)
            {
                ipo.UserId = ticketDo.UserId;
                ret = await LoginCacheUtil.GetAppLoginTokenDoByTokenAsync(ipo.AppId, ticketDo.Token);
                LogUtil.Info($"ticketDo -> {SerializerUtil.SerializeJsonNet(ticketDo)},appid:{ipo.AppId}");
                if (ret != null)
                {
                    await new UserAppDCache(ipo.UserId, ipo.AppId).SetLoginTokenAsync(ret.Token);
                    return ret;
                }
            }
            if (ret == null)
                throw new CustomException(CommonCodes.LOGIN_TIMEOUT, $"Login登录会话超时,无法获取LoginTokenDO,请重新登录");
            return ret;
        }

        private string GetLobbyUrl(V_s_operatorEO oper, AppLoginTokenDO tokenDo)
        {
            if (!string.IsNullOrEmpty(tokenDo?.LobbyUrl))
                return tokenDo.LobbyUrl;
            var ret = oper.LobbyUrl;
            //switch (_options.ServerType)
            //{
            //    case ServerType.Staging: ret = oper.LobbyUrlStaging; break;
            //    case ServerType.JointDebug: ret = oper.LobbyUrlDebug; break;
            //}
            return ret;
        }
        private string GetBankUrl(V_s_operatorEO oper, AppLoginTokenDO tokenDo)
        {
            if (!string.IsNullOrEmpty(tokenDo?.DepositUrl))
                return tokenDo.DepositUrl;
            var ret = oper.BankUrl;
            //switch (_options.ServerType)
            //{
            //    case ServerType.Staging: ret = oper.BankUrlStaging; break;
            //    case ServerType.JointDebug: ret = oper.BankUrlDebug; break;
            //}
            return ret;
        }
    }
}
