using Super_phoenix.BLL.Caching;
using TinyFx;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Services;

namespace Super_phoenix.BLL
{
    public class RankService : BaseApiGameService
    {
        public async Task<Super_phoenixRankDto> Rank(Super_phoenixRankIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var context = GetLoginTokenDo(ipo.UserId);
            var ret = new Super_phoenixRankDto();
            var list = MemoryUtil.LampList(context.OperatorId, context.CurrencyId);
            if (list != null)
            {
                foreach (var item in list)
                {
                    ret.SimplePlayerInfoList.Add(new SimplePlayerInfo
                    {
                        Player = item.PlayerName,
                        Multi = item.Multip,
                        Reward = item.Reward.AToM(ipo.CurrencyId),
                        RecDate = item.RecDate.ToTimestamp(true,true),
                    });
                }
            }
            return ret;
        }
    }
}