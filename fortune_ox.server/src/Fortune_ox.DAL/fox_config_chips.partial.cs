using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_ox.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fox_config_chipsPO
    {
        #region tinyfx
        public static implicit operator Fox_config_chipsEO(Fox_config_chipsPO value)
        {
            if (value==null) return null;
            return new Fox_config_chipsEO
            {
		        ChipsID = value.ChipsID,
		        BetAmount = value.BetAmount,
		        SingleAmount = value.SingleAmount,
		        LineNum = value.LineNum,
		        IsShortcut = value.IsShortcut,
            };
        }
        public static implicit operator Fox_config_chipsPO(Fox_config_chipsEO value)
        {
            if (value==null) return null;
            return new Fox_config_chipsPO
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