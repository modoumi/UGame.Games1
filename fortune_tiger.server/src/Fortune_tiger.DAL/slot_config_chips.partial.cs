using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_tiger.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Slot_config_chipsPO
    {
        #region tinyfx
        public static implicit operator Slot_config_chipsEO(Slot_config_chipsPO value)
        {
            if (value==null) return null;
            return new Slot_config_chipsEO
            {
		        AppID = value.AppID,
		        ChipsID = value.ChipsID,
		        BetAmount = value.BetAmount,
		        SingleAmount = value.SingleAmount,
		        LineNum = value.LineNum,
		        IsShortcut = value.IsShortcut,
            };
        }
        public static implicit operator Slot_config_chipsPO(Slot_config_chipsEO value)
        {
            if (value==null) return null;
            return new Slot_config_chipsPO
            {
		        AppID = value.AppID,
		        ChipsID = value.ChipsID,
		        BetAmount = value.BetAmount,
		        SingleAmount = value.SingleAmount,
		        LineNum = value.LineNum,
		        IsShortcut = value.IsShortcut,
            };
        }
        #endregion
    }
}