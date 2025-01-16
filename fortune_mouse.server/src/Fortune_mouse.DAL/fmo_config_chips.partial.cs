using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_mouse.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fmo_config_chipsPO
    {
        #region tinyfx
        public static implicit operator Fmo_config_chipsEO(Fmo_config_chipsPO value)
        {
            if (value==null) return null;
            return new Fmo_config_chipsEO
            {
		        ChipsID = value.ChipsID,
		        BetAmount = value.BetAmount,
		        SingleAmount = value.SingleAmount,
		        LineNum = value.LineNum,
		        IsShortcut = value.IsShortcut,
            };
        }
        public static implicit operator Fmo_config_chipsPO(Fmo_config_chipsEO value)
        {
            if (value==null) return null;
            return new Fmo_config_chipsPO
            {
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