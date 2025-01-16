using Fortune_big.BLL.Caching;
using Fortune_big.DAL;
using Google.Protobuf.WellKnownTypes;
using TinyFx;
using TinyFx.SnowflakeId;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Services;
using Xxyy.Partners.Model;

namespace Fortune_big.BLL
{
    public class RootService : BaseApiGameService
    {
        private static readonly Big_user_extMO _extMO = new();
        private static readonly Big_pool_returnMO _poolMo = new();
        private static readonly Big_configMO _configMo = new();

        public static async Task CheckConfigAsync(string operatorId, string currencyId)
        {
            //反奖池
            var poolItem = await _poolMo.GetByPKAsync(operatorId, currencyId);
            if (poolItem == null)
            {
                await _poolMo.AddAsync(new Big_pool_returnEO
                {
                    OperatorID = operatorId,
                    CurrencyID = currencyId,
                    PoolVal = CommonCodes.POOL_DEFAULT
                });
            }
            var config = await _configMo.GetByPKAsync(operatorId, currencyId);
            if (config == null)
            {
                var _temp = (await _configMo.GetTopAsync("1=1", 1)).FirstOrDefault();
                if (_temp != null)
                {
                    await _configMo.AddAsync(new Big_configEO
                    {
                        CurrencyID = currencyId,
                        OperatorID = operatorId,
                        IncomeRatio = _temp.IncomeRatio,
                        DefaultSlotArray = _temp.DefaultSlotArray,
                        MultipleArray = _temp.MultipleArray,
                        SingleBetArray = _temp.SingleBetArray,
                        RespinNum = _temp.RespinNum,
                        FreeSpinNum = _temp.FreeSpinNum,
                    });
                }
            }
        }
        public async Task<Big_user_extEO> CheckUserExtAsync(string UserId, bool isValid = true, string appid = "")
        {
            var userExt = await _extMO.GetByPKAsync(UserId);
            if (userExt != null && !userExt.UserStatus && isValid) { throw new CustomException(CommonCodes.RS_TOKEN_EXPIRED, "用户数据异常,请重新登录!"); }
            if (userExt == null)
            {
                var appToken = GetLoginTokenDo(UserId, appid);
                return await Fortune_BigUtil.InitUserExtAsync(UserId, appToken.OperatorId, appToken.AppId, appToken.CurrencyId);
            }
            return userExt;
        }

        internal async Task<SpinDto> RunTest(SpinIpo ipo)
        {
            int cou = 200;
            List<SpinContext> list = new List<SpinContext>();
            int cc = 500000;
            while (cc > 0)
            {
                var context = new SpinContext(ipo)
                {
                    BetId = SnowflakeIdUtil.NextId(),
                    UserExt = await CheckUserExtAsync(ipo.UserId)
                };
                if (context.UserExt != null)
                {
                    context.Config = MemoryUtil.GetConfig(context.UserExt.OperatorID, context.UserExt.CurrencyID);
                    context.UserFlag = (int)context.UserExt.UserFlag % 2;
                }
                var betId = context.BetId = SnowflakeIdUtil.NextId();
                // context.GroupId = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff");
                //算法逻辑
                var Account = new BalanceDto()
                {
                    Balance = 10000000000,
                    Bonus = 0,
                    CurrencyId = context.CurrencyId,
                    UserId = context.UserId,
                    RequestUUID = Guid.NewGuid().ToString()
                };

                SpinInitProcess.InitConfig(context, Account);
                await new SpinProcess().Execute(context);

                list.Add(context);
                if (list.Count == cou)
                {
                    if (list != null)
                    {
                       
                            await Fortune_BigUtil.AddBetDetail_Batch(list, null);
                            list.Clear();
                    }
                }
                cc--;
            }
            return new SpinDto();
        }
    }
}
