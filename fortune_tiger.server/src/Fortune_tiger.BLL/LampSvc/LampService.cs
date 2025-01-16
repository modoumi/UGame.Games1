using Fortune_tiger.BLL.Caching;
using TinyFx;
using Xxyy.GameEAPI.Common;

namespace Fortune_tiger.BLL
{
    public class LampService : RootService
    {
        public async Task<LampDto> Lamp(LampIpo ipo)
        {
            var appToken = await CheckUserExtAsync(ipo.UserId);
            await CheckIdentityAndMock(ipo.UserId);
            var ret = new LampDto();
            var list = MemoryUtil.LampList(appToken.OperatorID, appToken.CurrencyID);
            if (list != null)
            {
                foreach (var item in list)
                {
                    ret.SimplePlayerInfoList.Add(new SimplePlayerInfo
                    {
                        Player = item.PlayerName,
                        Multi = item.Multip,
                        Reward = item.Reward.AToM(ipo.CurrencyId),
                        RecDate = item.RecDate.ToTimestamp(true,true)
                    });
                }
            }
            return ret;
        }
    }
}