using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_big.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Big_config_chipsPO
    {
        #region tinyfx
        public static implicit operator Big_config_chipsEO(Big_config_chipsPO value)
        {
            if (value==null) return null;
            return new Big_config_chipsEO
            {
		        ChipsID = value.ChipsID,
		        BetAmount = value.BetAmount,
		        SingleAmount = value.SingleAmount,
		        LineNum = value.LineNum,
		        IsShortcut = value.IsShortcut,
            };
        }
        public static implicit operator Big_config_chipsPO(Big_config_chipsEO value)
        {
            if (value==null) return null;
            return new Big_config_chipsPO
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