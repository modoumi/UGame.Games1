using Fortune_mouse.DAL;
using TinyFx.Configuration;
using TinyFx.SnowflakeId;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Services;
using Xxyy.Partners.Model;
using static Xxyy.GameEAPI.Core.GameEAPIUtil;

namespace Fortune_mouse.BLL
{
    public class RootService : BaseApiGameService
    {
        private static readonly Fmo_user_extMO _extMO = new();
        private static readonly Fmo_pool_returnMO _poolMo = new();
        private static readonly Fmo_configMO _configMo = new();

        public static async Task CheckConfigAsync(string operatorId, string currencyId)
        {
            //反奖池
            var poolItem = await _poolMo.GetByPKAsync(operatorId, currencyId);
            if (poolItem == null)
            {
                await _poolMo.AddAsync(new Fmo_pool_returnEO
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
                    await _configMo.AddAsync(new Fmo_configEO
                    {
                        CurrencyID = currencyId,
                        OperatorID = operatorId,
                        IncomeRatio = _temp.IncomeRatio,
                        MultipArray = _temp.MultipArray,
                        DefaultSlotArray = _temp.DefaultSlotArray,
                    });
                }
            }
        }
        public async Task<Fmo_user_extEO> CheckUserExtAsync(string UserId)
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
            int cc = 500000;
            while (cc > 0)
            {
                var context = new BetContext(ipo, await CheckUserExtAsync(ipo.UserId));
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
