using Mexico_fortune.BLL.Caching;
using TinyFx.Collections;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace Mexico_fortune.BLL
{
    public class LoadService : BaseApiGameService
    {
        public async Task<LoadDto> Load(LoadIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var loginTokenDo = GetLoginTokenDo(ipo.UserId);
            await SlotUtil.CheckAndInitUserData(ipo.UserId, loginTokenDo.OperatorId, ipo.CurrencyId);

            var ret = new LoadDto();
            //
            ret.PlayerInfo.Balance = await GameEAPIUtil.GetBalanceMoney(ipo.UserId, loginTokenDo.AppId, ipo.CurrencyId);
            //
            ret.Meta.Chips = GmfDBCacheUtil.GetLoadChips(ipo.CurrencyId);
            ret.Meta.Lines = GmfDBCacheUtil.GetLines();
            ret.Meta.SlotEles = GmfDBCacheUtil.GetSlotEles();
            ret.Meta.WinTypeMultis = GmfDBCacheUtil.GetWinTypeMulti();
            //

            foreach (var chips in GmfDBCacheUtil.GetLoadChips(ipo.CurrencyId))
            {
                var userDo = await new UserDataDCache(ipo.UserId).GetUserChipsDataDo(chips.ChipsId);
                var info = new LoadGameInfo
                {
                    ChipsId = chips.ChipsId,
                    FreeSpinCount = userDo.FreeSpinNum,
                    FreeSpinTotalReward = userDo.RetriggerNum,
                    LottoryInfo = new LoadLottoryInfo
                    {
                        LottoryEle = ArrayUtil.TwoDToListRows(userDo.BingoPanelNumTwoD),
                        AppearEle = userDo.BingoHasNums ?? new List<int>()
                    }
                };
                ret.GameInfo.Add(info);
            }
            return ret;
        }
    }
}
