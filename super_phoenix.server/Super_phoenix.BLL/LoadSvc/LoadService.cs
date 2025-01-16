using Super_phoenix.BLL.Caching;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace Super_phoenix.BLL
{
    public class LoadService : BaseApiGameService
    {
        public async Task<Super_phoenixLoadDto> Load(Super_phoenixLoadIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var appToken = GetLoginTokenDo(ipo.UserId);

            await SuperUtil.CheckAndInitUserData(ipo.UserId, appToken.OperatorId, ipo.CurrencyId);
            var ret = new Super_phoenixLoadDto();
            ret.PlayerInfo.Balance = await GameEAPIUtil.GetBalanceMoney(ipo.UserId, appToken.AppId, ipo.CurrencyId);
            foreach (var item in MemoryUtil.GetChipsList())
            {
                ret.Meta.Chips.Add(new Chips
                {
                    ChipsId = item.ChipsID,
                    Bet = item.BetAmount.AToM(ipo.CurrencyId),
                });
            }
            var lines = MemoryUtil.GetLineList();
            foreach (var item in lines)
            {
                int[] line = Array.ConvertAll(item.Line.Split(","), x => int.Parse(x));
                ret.Meta.Lines.Add(line);
            }
            var multips = MemoryUtil.GetMultipList();
            foreach (var item in multips)
            {
                ret.Meta.SlotEles.Add(new SlotEle
                {
                    Id = item.ItemID,
                    Type = item.IconType,
                    MultiList = new List<int> { item.Multip3, item.Multip4, item.Multip5 },
                });
            }
            var config = MemoryUtil.GetConfig(appToken.OperatorId, ipo.CurrencyId);
            ret.Meta.WinTypeMultis = new List<int> { config.BIG, config.MEGA, config.SUPER, config.EPIC };

            var userExt = MemoryUtil.GetUserDataList(ipo.UserId);
            foreach (var item in userExt)
            {
                ret.GameInfo.Add(new GameInfo
                {
                    ChipsId = item.ChipsID,
                    FreeSpinCount = item.FreeSpinCount,
                    FreeSpinTotalReward = item.FreeSpinTotalReward.AToM(ipo.CurrencyId),
                });
            }
            return ret;
        }
    }
}
