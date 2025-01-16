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
        /// �账����쳣�룺
        ///     UserStatusError | RS_USER_DISABLED: �û�״̬�쳣
        ///     RS_NOT_ENOUGH_MONEY: �û���Ǯ����
        ///     UserConcurrent: �û�����
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
