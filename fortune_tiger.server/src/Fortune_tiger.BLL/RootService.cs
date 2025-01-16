using Fortune_tiger.DAL;
using TinyFx;
using Xxyy.GameEAPI.Caching.Login;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using Xxyy.GameEAPI.Services;

namespace Fortune_tiger.BLL
{
    public class RootService : BaseApiGameService
    {
        private static readonly Slot_user_extMO _extMO = new();
        private static readonly Slot_pool_returnMO _poolMo = new();
        private static readonly Slot_configMO _configMo = new();

        public static async Task CheckConfigAsync(string operatorId, string currencyId, string appId)
        {
            //反奖池
            var poolItem = await _poolMo.GetByPKAsync(operatorId, currencyId);
            if (poolItem == null)
            {
                await _poolMo.AddAsync(new Slot_pool_returnEO
                {
                    OperatorID = operatorId,
                    CurrencyID = currencyId,
                    PoolVal = CommonCodes.POOL_DEFAULT
                });
            }
            var config = await _configMo.GetByPKAsync(appId, operatorId, currencyId);
            if (config == null)
            {
                var _temp = (await _configMo.GetTopAsync("1=1", 1)).FirstOrDefault();
                if (_temp != null)
                {
                    await _configMo.AddAsync(new Slot_configEO
                    {
                        AppID = appId,
                        CurrencyID = currencyId,
                        OperatorID = operatorId,
                        IncomeRatio = _temp.IncomeRatio,
                        BIG = _temp.BIG,
                        MEGA = _temp.MEGA,
                        SUPER = _temp.SUPER,
                        EPIC = _temp.EPIC,
                        WightA = _temp.WightA,
                        WightB = _temp.WightB,
                    });
                }
            }
        }
        public async Task<Slot_user_extEO> CheckUserExtAsync(string UserId, bool isValid = true,string appid="")
        {
            var userExt = await _extMO.GetByPKAsync(UserId);
            //if (userExt != null && !userExt.UserStatus && isValid) { throw new CustomException(CommonCodes.RS_TOKEN_EXPIRED, ("用户数据异常,请重新登录!" + (userExt != null) + "/" + (!userExt.UserStatus) + "/" + isValid)); }
            if (userExt == null)
            {
                var appToken = GetLoginTokenDo(UserId, appid);
                return await FortuneUtil.InitUserExtAsync(UserId, appToken.OperatorId, appToken.AppId, appToken.CurrencyId);
            }
            return userExt;
        }

      
    }
}
