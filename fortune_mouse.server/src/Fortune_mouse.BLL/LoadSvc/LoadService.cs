using Fortune_mouse.BLL.Caching;
using Fortune_mouse.DAL;
using TinyFx;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;

namespace Fortune_mouse.BLL
{
    public class LoadService : RootService
    {
        private readonly Fmo_bet_detailMO mo = new();
        public async Task<LoadDto> Load(LoadIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var userExt = await CheckUserExtAsync(ipo.UserId);
            await CheckConfigAsync(userExt.OperatorID, userExt.CurrencyID);

            var ret = new LoadDto();
            ret.PlayerInfo.Balance = await GameEAPIUtil.GetBalanceMoney(ipo.UserId, userExt.AppID, userExt.CurrencyID);
            var chipsList = MemoryUtil.GetChipsList();
            foreach (var item in chipsList)
            {
                ret.Meta.Chips.Add(new Chips
                {
                    ChipsId = item.ChipsID,
                    Bet = item.BetAmount.AToM(userExt.CurrencyID),
                    IsShortcut = item.IsShortcut,
                });
            }
            var lines = MemoryUtil.GetLineList();
            foreach (var item in lines)
            {
                int[] line = Array.ConvertAll(item.Line.Split(","), x => int.Parse(x));
                ret.Meta.Lines.Add(line);
            }
            foreach (var item in MemoryUtil.GetSymbolList())
            {
                ret.Meta.SlotEles.Add(new SlotEle
                {
                    Id = item.SymbolID,
                    Type = item.SymbolType,
                    MultiList = new List<int> { item.Multip },
                });
            }
            var config = MemoryUtil.GetConfig(userExt.OperatorID, userExt.CurrencyID);
            ret.Meta.WinTypeMultis = SerializerUtil.DeserializeJson<List<int>>(config.MultipArray);

            foreach (var item in chipsList)
            {
                ret.GameDataList.Add(new GameData
                {
                    ChipsId = item.ChipsID,
                });
            }

            var list = await mo.GetAsync($"UserId=@UserId ORDER BY RecDate DESC LIMIT 1", userExt.UserID);
            if (list == null || list.Count == 0)
            {
                ret.LastBetInfo.GameInfoList.Add(new GameInfo
                {
                    SlotEles = SerializerUtil.DeserializeJsonNet<List<List<int>>>(config.DefaultSlotArray)
                });
            }
            else
            {
                var detail = list.First();
                ret.LastBetInfo.GameInfoList = FortuneUtil.BuildGameInfoList(detail, userExt.CurrencyID, out decimal totalwin);
            }
            return ret;
        }
    }
}
