using Fortune_big.DAL;
using TinyFx;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;

namespace Fortune_big.BLL;

public class HistoryService : RootService
{
    private readonly Big_spin_detailMO _detailMo = new();

    public async Task<HistoryDto> History(HistoryIpo ipo)
    {
        await CheckIdentityAndMock(ipo.UserId);
        var userExt = await CheckUserExtAsync(ipo.UserId);
        var ret = new HistoryDto();
        var s =DateTimeUtil.ParseTimestamp(ipo.StartTime,true);
        var e = DateTimeUtil.ParseTimestamp(ipo.EndTime, true);
        var list = await _detailMo.GetAsync($"UserId=@UserId AND RecDate BETWEEN '{s:yyyy-MM-dd HH:mm:ss}' AND '{e:yyyy-MM-dd HH:mm:ss}' ORDER BY RecDate DESC", userExt.UserID);
        if (list != null && list.Count > 0)
        {
            foreach (var detail in list)
            {
                ret.HistoryList.Add(
                    new ResultInfo
                    {
                        FreeSpinList = SerializerUtil.DeserializeJson<List<GameInfo>>(detail.FreeSpinList),
                        TriggerRespin = detail.TriggerRespin > 1 ? true : false,
                        TriggerFreeSpin = detail.TriggerFreeSpin > 1 ? true : false,
                        GameInfo = new GameInfo
                        {
                            Balance = detail.BalanceAmountAfter.AToM(userExt.CurrencyID),
                            Bet = detail.BetAmount.AToM(userExt.CurrencyID),
                            Date = GameEAPIUtil.DataTimeUTCToTimestamp(detail.RecDate, false),
                            N = 1,
                            RewardDetailList = SerializerUtil.DeserializeJson<List<RewardDetail>>(detail.RewardDetailList),
                            SlotEleList = SerializerUtil.DeserializeJson<List<List<int>>>(detail.SlotEleList),
                            TotalMultiple = detail.TotalMultip,
                            TotalReward = detail.IsWin * detail.WinAmount.AToM(userExt.CurrencyID),
                            Transactionld = detail.BetID.ToString(),
                        },
                        RespinList = SerializerUtil.DeserializeJson<List<GameInfo>>(detail.RespinList),
                        TriggerEffect = detail.TriggerSE > 1,
                    });
            }
        }
        return ret;
    }
}