using Fortune_ox.DAL;
using TinyFx;
using Xxyy.GameEAPI.Services;

namespace Fortune_ox.BLL
{
    public class HistoryService : RootService
    {
        private readonly Fox_bet_detailMO _detailMo = new();
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
                    var _GameInfoList = FortuneUtil.BuildGameInfoList(detail, userExt.CurrencyID, out decimal totalWin);
                    ret.HistoryInfoList.Add(
                        new History
                        {
                            TotalWin = totalWin,
                            GameInfoList = _GameInfoList
                        });
                }
            }
            return ret;
        }


    }
}