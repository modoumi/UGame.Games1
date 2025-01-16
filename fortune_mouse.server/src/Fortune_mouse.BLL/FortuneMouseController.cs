using Fortune_mouse.BLL.Caching;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TinyFx.Configuration;
using Xxyy.GameEAPI.Controllers;

namespace Fortune_mouse.BLL
{
    public class FortuneMouseController : GameControllerBase
    {
        #region init
        private LoadService _loadSvc = new();
        private BetService _betSvc = new();
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
         /*   if ("dev".Equals(ConfigUtil.EnvironmentString))
            {
                return await new RootService().RunTest(ipo);
            }
            else
            {*/
                return await _betSvc.Bet(ipo);
            //}
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
