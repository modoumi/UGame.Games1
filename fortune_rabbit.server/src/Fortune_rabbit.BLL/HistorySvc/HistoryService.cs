using Fortune_rabbit.DAL;
using Serilog;
using TinyFx;
using TinyFx.Data.SqlSugar;
using TinyFx.Logging;

namespace Fortune_rabbit.BLL
{
    public class HistoryService : RootService
    {
        private readonly Fra_bet_detailMO _detailMo = new();
        public async Task<HistoryDto> History(HistoryIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var userExt = await CheckUserExtAsync(ipo.UserId);
            var ret = new HistoryDto();
            var s = DateTimeUtil.ParseTimestamp(ipo.StartTime, true);
            var e = DateTimeUtil.ParseTimestamp(ipo.EndTime, true);
            LogUtil.Info($"历史记录开始时间结束时间 s:{s},e:{e}");
           // var list = DbUtil.GetRepository<Sfra_bet_detailEO>().GetList(d => d.UserID.Equals(userExt.UserID) && d.RecDate>= s && d.RecDate <= e ).OrderByDescending(d => d.RecDate).ToList();
            var list = await  _detailMo.GetAsync($"UserId=@UserId AND RecDate BETWEEN '{s:yyyy-MM-dd HH:mm:ss}' AND '{e:yyyy-MM-dd HH:mm:ss}' ORDER BY RecDate DESC", userExt.UserID);
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