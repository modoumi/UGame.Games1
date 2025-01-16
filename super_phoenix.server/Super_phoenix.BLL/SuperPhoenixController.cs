using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Super_phoenix.BLL.Caching;
using TinyFx.AspNet;

namespace Super_phoenix.BLL
{
    public class SuperPhoenixController : TinyFxControllerBase
    {
        #region init
        private readonly LoadService _loadSvc = new();
        private readonly SlotService _slotSvc = new();
        private readonly LampService _lampSvc = new();
        private readonly RankService _rankSvc = new();
        #endregion

        [HttpPost]
        public async Task<Super_phoenixLoadDto> Load(Super_phoenixLoadIpo ipo)
        {
            return await _loadSvc.Load(ipo);
        }

        [HttpPost]
        public async Task<Super_phoenixSlotDto> Slot(Super_phoenixSlotIpo ipo)
        {
            return await _slotSvc.Slot(ipo);
        }
        [HttpPost]
        public async Task<Super_phoenixLampDto> Horse_Lamp(Super_phoenixLampIpo ipo)
        {
            return await _lampSvc.Lamp(ipo);
        }
        [HttpPost]
        public async Task<Super_phoenixRankDto> Rank_Reward(Super_phoenixRankIpo ipo)
        {
            return await _rankSvc.Rank(ipo);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task ClearMemory()
        {
            MemoryUtil.Clear();
        }
    }
}