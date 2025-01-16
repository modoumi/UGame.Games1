using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_rabbit.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fra_config_chipsPO
    {
        #region tinyfx
        public static implicit operator Fra_config_chipsEO(Fra_config_chipsPO value)
        {
            if (value==null) return null;
            return new Fra_config_chipsEO
            {
		        ChipsID = value.ChipsID,
		        BetAmount = value.BetAmount,
		        SingleAmount = value.SingleAmount,
		        LineNum = value.LineNum,
		        IsShortcut = value.IsShortcut,
            };
        }
        public static implicit operator Fra_config_chipsPO(Fra_config_chipsEO value)
        {
            if (value==null) return null;
            return new Fra_config_chipsPO
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