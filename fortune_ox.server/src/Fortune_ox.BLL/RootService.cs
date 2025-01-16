using Fortune_ox.DAL;
using TinyFx.Configuration;
using TinyFx.SnowflakeId;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Services;
using Xxyy.Partners.Model;
using static Xxyy.GameEAPI.Core.GameEAPIUtil;

namespace Fortune_ox.BLL
{
    public class RootService : BaseApiGameService
    {
        private static readonly Fox_user_extMO _extMO = new();
        private static readonly Fox_pool_returnMO _poolMo = new();
        private static readonly Fox_configMO _configMo = new();

        public static async Task CheckConfigAsync(string operatorId, string currencyId)
        {
            //反奖池
            var poolItem = await _poolMo.GetByPKAsync(operatorId, currencyId);
            if (poolItem == null)
            {
                await _poolMo.AddAsync(new Fox_pool_returnEO
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
                    await _configMo.AddAsync(new Fox_configEO
                    {
                        CurrencyID = currencyId,
                        OperatorID = operatorId,
                        IncomeRatio = _temp.IncomeRatio,
                        HHSWRatio = _temp.HHSWRatio,
                        TriggerLampMultip = _temp.TriggerLampMultip,
                        DefaultSlotArray = _temp.DefaultSlotArray,
                        MultipArray = _temp.MultipArray,
                    });
                }
            }
        }
        public async Task<Fox_user_extEO> CheckUserExtAsync(string UserId)
        {
            var userExt = await _extMO.GetByPKAsync(UserId);
            if (userExt == null)
            {
                var appToken = GetLoginTokenDo(UserId);
                return await FortuneUtil.InitUserExtAsync(UserId, appToken.OperatorId, appToken.AppId, appToken.CurrencyId);
            }
            return userExt;
        }


        public async Task<BetDto> RunTest(BetIpo ipo)
        {
            int cou = 200;
            List<BetContext> list = new List<BetContext>();
            int cc = 1000000;
            while (cc > 0)
            {
                var context = new BetContext(ipo, await CheckUserExtAsync(ipo.UserId));
                var betId = context.BetId = SnowflakeIdUtil.NextId();
                context.GroupId = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff");
                //算法逻辑
                var Account = new BalanceDto()
                {
                    Balance = 10000000000,
                    Bonus = 0,
                    CurrencyId = context.CurrencyId,
                    UserId = context.UserId,
                    RequestUUID = Guid.NewGuid().ToString()
                };

                BetInitProcess.InitConfig(context, Account);
                await new BetProcess().Execute(context);

                list.Add(context);
                if (list.Count == cou)
                {
                    if (list != null)
                    {
                        TimeSpan elapsedTime = await MeasureExecutionTime<BetContext>(async () =>
                        {
                            await FortuneUtil.AddBetDetail_Batch(list, null);
                            list.Clear();
                        });
                        Console.WriteLine($"更新{cou}条数据:{ConfigUtil.Environment.Name},-> 耗时:{elapsedTime.Milliseconds}毫秒");
                    }
                }
                cc--;
            }
            return new BetDto();
        }
    }
}
