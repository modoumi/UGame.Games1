using Amazon.Runtime;
using Fortune_tiger.BLL.Caching;
using Fortune_tiger.BLL.Core;
using Fortune_tiger.DAL;
using Google.Protobuf.WellKnownTypes;
using TinyFx;
using TinyFx.DbCaching;
using TinyFx.Logging;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using Xxyy.GameEAPI.Core;

namespace Fortune_tiger.BLL
{
    public class LoadService : RootService
    {
        private readonly Slot_bet_detailMO mo = new();
        private readonly Slot_user_extMO _extMO = new();
        public async Task<LoadDto> Load(LoadIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var userExt = await CheckUserExtAsync(ipo.UserId, false);
            await CheckConfigAsync(userExt.OperatorID, userExt.CurrencyID, userExt.AppID);
            await SyncBalance(userExt);

            var ret = new LoadDto();
            ret.PlayerInfo.Balance = await GameEAPIUtil.GetBalanceMoney(ipo.UserId, userExt.AppID, userExt.CurrencyID);
            var chipsList = MemoryUtil.GetChipsList(userExt.AppID);
            foreach (var item in chipsList)
            {
                ret.Meta.Chips.Add(new Chips
                {
                    ChipsId = item.ChipsID,
                    Bet = item.BetAmount.AToM(userExt.CurrencyID),
                    IsShortcut = item.IsShortcut,
                });
            }
            var lines = MemoryUtil.GetLineList(userExt.AppID);
            foreach (var item in lines)
            {
                int[] line = Array.ConvertAll(item.Line.Split(","), x => int.Parse(x));
                ret.Meta.Lines.Add(line);
            }
            int poolType = 1;
            foreach (var item in MemoryUtil.GetItemListByPoolType(poolType))
            {
                ret.Meta.SlotEles.Add(new SlotEle
                {
                    Id = item.ItemID,
                    Type = item.IconType,
                    MultiList = new List<int> { item.ItemBaseMultip },
                });
            }
            var config = MemoryUtil.GetConfig(userExt.AppID, userExt.OperatorID, userExt.CurrencyID);
            if(config == null)
            {
                LogUtil.Error(" Fortune_tiger.BLL null" + userExt.AppID + "/" + userExt.OperatorID + "/" + userExt.CurrencyID+ DbCachingUtil.GetAllList<Slot_configPO>().ToJson());
            }
            ret.Meta.WinTypeMultis = new List<int> { config.BIG, config.MEGA, config.SUPER, config.EPIC };

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
                ret.LastBetInfo.GameInfo.SlotEles.Add(new List<int> { 6, 6, 6 });
                ret.LastBetInfo.GameInfo.SlotEles.Add(new List<int> { 7, 7, 7 });
                ret.LastBetInfo.GameInfo.SlotEles.Add(new List<int> { 5, 5, 5 });
            }
            else
            {
                var detail = list.First();
                ret.LastBetInfo.GameInfo.TotalReward = detail.WinAmount.AToM(userExt.CurrencyID) * detail.IsWin;
                ret.LastBetInfo.GameInfo.TotalMulti = detail.TotalMultip * detail.IsWin;
                ret.LastBetInfo.GameInfo.RewardDetails = SerializerUtil.DeserializeJsonNet<List<RewardDetail>>(detail.RewardDetails);
                ret.LastBetInfo.GameInfo.SlotEles = SerializerUtil.DeserializeJsonNet<List<List<int>>>(detail.SlotEleArray);
                ret.LastBetInfo.GameInfo.WildNum = detail.WildNum;
                ret.LastBetInfo.GameInfo.Cost = detail.BetBaseAmount.AToM(userExt.CurrencyID);
                ret.LastBetInfo.GameInfo.Date = GameEAPIUtil.DataTimeUTCToTimestamp(detail.RecDate, false);
                ret.LastBetInfo.GameInfo.Balance = detail.BalanceAmount.AToM(userExt.CurrencyID);
                ret.LastBetInfo.GameInfo.Transactionld = detail.BetID.ToString();

                ret.LastBetInfo.ExtraInfo.IsTrigerBonus = (detail.TriggerHHSW == 1 && detail.TriggerHHSWIsWin == 1);
                ret.LastBetInfo.ExtraInfo.IsBonus = (detail.TriggerMaxMultip == 10 && detail.IsWin == 1 && detail.TriggerHHSW == 1);
                ret.LastBetInfo.ExtraInfo.BonusInfo = SerializerUtil.DeserializeJsonNet<List<List<List<int>>>>(detail.BonusInfo);
                ret.LastBetInfo.ExtraInfo.BonousItemId = detail.BonusItemId;
            }

            LogUtil.Debug($"===============:{SerializerUtil.SerializeJsonNet(ret)}");
            return ret;
        }

        public async Task SyncBalance(Slot_user_extEO userExt)
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
