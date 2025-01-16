using Xxyy.GameEAPI.Core;

namespace Xxyy.GameEAPI.Services.SyncSvc
{
    public class SyncService : BaseApiGameService
    {
        public async Task<SyncDto> Sync(SyncIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var appToken = GetLoginTokenDo(ipo.UserId);
            var ret = new SyncDto();
            ret.PlayerInfo.Balance = await GameEAPIUtil.GetBalanceMoney(ipo.UserId, appToken.AppId, ipo.CurrencyId);
            return ret;
        }
    }
}