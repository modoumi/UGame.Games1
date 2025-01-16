using Fortune_big.BLL.Caching;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TinyFx.Configuration;
using Xxyy.GameEAPI.Controllers;

namespace Fortune_big.BLL
{
    public class FortuneBigController : GameControllerBase
    {
        #region init
        private LoadService _loadSvc = new();
        private SpinService _spinSvc = new();
        private HistoryService _historySvc = new();
        #endregion

        [HttpPost]
        public async Task<LoadDto> Load(LoadIpo ipo)
        {
            return await _loadSvc.Load(ipo);
        }
        [HttpPost]
        public async Task<SpinDto> Spin(SpinIpo ipo)
        {
            if ("dev".Equals(ConfigUtil.Environment.Name))
            {
                return await new RootService().RunTest(ipo);
            }
            else
            {
                return await _spinSvc.Spin(ipo);
            }
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
