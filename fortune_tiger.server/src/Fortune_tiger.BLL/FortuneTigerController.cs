using Fortune_tiger.BLL.Caching;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TinyFx.AspNet;

namespace Fortune_tiger.BLL
{
    public class FortuneTigerController : TinyFxControllerBase
    {
        #region init
        private LoadService _loadSvc = new();
        private BetService _slotSvc = new();
        private LampService _lampSvc = new();
        private HistoryService _historySvc = new();
        #endregion

        [HttpPost]
        public async Task<LoadDto> Load(LoadIpo ipo)
        {
            return await _loadSvc.Load(ipo);
        }
        [HttpPost]
        public async Task<BetDto> Bet(BetIpo ipo)
        {
            return await _slotSvc.Bet(ipo);
        }
        [HttpPost]
        public async Task<LampDto> Lamp(LampIpo ipo)
        {
            return await _lampSvc.Lamp(ipo);
        }
        [HttpPost]
        public async Task<HistoryDto> History(HistoryIpo ipo)
        {
            return await _historySvc.History(ipo);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task ClearMemory()
        {
            MemoryUtil.Clear();
        }
    }
}
