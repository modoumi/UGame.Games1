using Microsoft.AspNetCore.Mvc;
using TinyFx.AspNet;

namespace Mexico_fortune.BLL
{
    public class MexicoFortuneController : TinyFxControllerBase
    {
        private LoadService _loadSvc = new();
        private SlotService _slotSvc = new();

        [HttpPost]
        public async Task<LoadDto> Load(LoadIpo ipo)
        {
            return await _loadSvc.Load(ipo);
        }

        /// <summary>
        /// 需处理的异常码：
        ///     UserStatusError | RS_USER_DISABLED: 用户状态异常
        ///     RS_NOT_ENOUGH_MONEY: 用户金钱不足
        ///     UserConcurrent: 用户并发
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<SlotDto> Slot(SlotIpo ipo)
        {
            return await _slotSvc.Slot(ipo);
        }
    }
}
