using Fortune_big.BLL.Caching;
using Fortune_big.DAL;
using Polly;
using TinyFx;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;

namespace Fortune_big.BLL
{
    public class LoadService : RootService
    {
        private readonly Big_spin_detailMO mo = new();
        private readonly Big_user_extMO _extMO = new();
        public async Task<LoadDto> Load(LoadIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var userExt = await CheckUserExtAsync(ipo.UserId, false);
            await CheckConfigAsync(userExt.OperatorID, userExt.CurrencyID);
            await SyncBalance(userExt);

            var ret = new LoadDto();
            ret.PlayerInfo.Balance = await GameEAPIUtil.GetBalanceMoney(ipo.UserId, userExt.AppID, userExt.CurrencyID);
            var chipsList = MemoryUtil.GetChipsList();
            foreach (var item in chipsList)
            {
                ret.Meta.ChipList.Add(new Chips
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
                ret.Meta.LineList.Add(line);
            }
            foreach (var item in MemoryUtil.GetSymbolList())
            {
                ret.Meta.SlotEleList.Add(new SlotEle
                {
                    Id = item.SymbolID,
                    Type = item.SymbolType,
                    MultipleList = new List<int> { item.SymbolMultiple3 },
                });
            }
            var config = MemoryUtil.GetConfig(userExt.OperatorID, userExt.CurrencyID);
            ret.Meta.WinMultipleList = SerializerUtil.DeserializeJson<List<int>>(config.MultipleArray);
            ret.Meta.SingleBetList = SerializerUtil.DeserializeJson<List<double>>(config.SingleBetArray);
            foreach (var item in MemoryUtil.GetWeight_tList())
            {
                ret.Meta.TMultipleList.Add(new TMultip { TID = item.TID, Multiple = item.Multip });
            }

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
                ret.LastBetInfo.GameInfo = new GameInfo
                {
                    SlotEleList = SerializerUtil.DeserializeJsonNet<List<List<int>>>(config.DefaultSlotArray)
                };
            }
            else
            {
                var detail = list.First();
                ret.LastBetInfo.GameInfo = new GameInfo
                {
                    Balance = detail.BalanceAmountBefore.AToM(userExt.CurrencyID),
                    Bet = detail.BetAmount.AToM(userExt.CurrencyID),
                    Date = GameEAPIUtil.DataTimeUTCToTimestamp(detail.RecDate, false),
                    N = 1,
                    RewardDetailList = SerializerUtil.DeserializeJson<List<RewardDetail>>(detail.RewardDetailList),
                    SlotEleList = SerializerUtil.DeserializeJson<List<List<int>>>(detail.SlotEleList),
                    TotalMultiple = detail.TotalMultip,
                    TotalReward = detail.IsWin * detail.WinAmount.AToM(userExt.CurrencyID),
                    Transactionld = detail.BetID.ToString(),
                };
                ret.LastBetInfo.FreeSpinList = SerializerUtil.DeserializeJson<List<GameInfo>>(detail.FreeSpinList);
                ret.LastBetInfo.RespinList = SerializerUtil.DeserializeJson<List<GameInfo>>(detail.RespinList);
            }
            return ret;
        }
        public async Task SyncBalance(Big_user_extEO userExt)
        {
            //同步余额
            var Account = await GameEAPIUtil.GetAccount(userExt.UserID, userExt.AppID);
            if (Account == null)
            {
                throw new CustomException(CommonCodes.ACCOUNT_NULL, "调用用户余额接口返回异常, _operatorClient.Balance返回  IS NULL");
            }
            //更新用户数据
            await _extMO.PutByPKAsync(userExt.UserID, $"Balance={Account.Balance},Bonus={Account.Bonus},UserStatus=1");
        }
    }
}
