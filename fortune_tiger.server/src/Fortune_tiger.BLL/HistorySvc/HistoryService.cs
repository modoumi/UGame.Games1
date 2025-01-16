using Fortune_tiger.DAL;
using TinyFx;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;

namespace Fortune_tiger.BLL
{
    public class HistoryService : RootService
    {
        private readonly Slot_bet_detailMO _detailMo = new();

        public async Task<HistoryDto> History(HistoryIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var userExt = await CheckUserExtAsync(ipo.UserId);
            var ret = new HistoryDto();

            var s = DateTimeUtil.ParseTimestamp(ipo.StartTime, true);
            var e = DateTimeUtil.ParseTimestamp(ipo.EndTime, true);
            var list = await _detailMo.GetAsync($"UserId=@UserId AND RecDate BETWEEN '{s:yyyy-MM-dd HH:mm:ss}' AND '{e:yyyy-MM-dd HH:mm:ss}' ORDER BY RecDate DESC", userExt.UserID);
            if (list != null && list.Count > 0)
            {
                foreach (var detail in list)
                {
                    ResultInfo resultInfo = new()
                    {
                        GameInfo = new GameInfo()
                        {
                            TotalReward = detail.WinAmount.AToM(userExt.CurrencyID) * detail.IsWin,
                            TotalMulti = detail.TotalMultip * detail.IsWin,
                            RewardDetails = SerializerUtil.DeserializeJsonNet<List<RewardDetail>>(detail.RewardDetails),
                            SlotEles = SerializerUtil.DeserializeJsonNet<List<List<int>>>(detail.SlotEleArray),
                            WildNum = detail.WildNum,
                            Cost = detail.BetBaseAmount.AToM(userExt.CurrencyID),
                            Date = GameEAPIUtil.DataTimeUTCToTimestamp(detail.RecDate, false),
                            Balance = detail.BalanceAmount.AToM(userExt.CurrencyID),
                            Transactionld = detail.BetID.ToString(),
                        },
                        ExtraInfo = new ExtraInfo()
                        {
                            IsTrigerBonus = (detail.TriggerHHSW == 1 && detail.TriggerHHSWIsWin == 1),
                            IsBonus = (detail.TriggerMaxMultip == 10 && detail.IsWin == 1 && detail.TriggerHHSW == 1),
                            BonusInfo = SerializerUtil.DeserializeJsonNet<List<List<List<int>>>>(detail.BonusInfo),
                            BonousItemId = detail.BonusItemId
                        }
                    };
                    ret.HistoryInfoList.Add(resultInfo);
                }
            }
            return ret;
        }
    }
}