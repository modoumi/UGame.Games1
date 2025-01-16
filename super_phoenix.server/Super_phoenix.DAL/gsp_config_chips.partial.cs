using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Super_phoenix.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gsp_config_chipsPO
    {
        #region tinyfx
        public static implicit operator Gsp_config_chipsEO(Gsp_config_chipsPO value)
        {
            if (value==null) return null;
            return new Gsp_config_chipsEO
            {
		        ChipsID = value.ChipsID,
		        BetAmount = value.BetAmount,
		        SingleAmount = value.SingleAmount,
		        LineNum = value.LineNum,
            };
        }
        public static implicit operator Gsp_config_chipsPO(Gsp_config_chipsEO value)
        {
            if (value==null) return null;
            return new Gsp_config_chipsPO
            {
		        ChipsID = value.ChipsID,
		        BetAmount = value.BetAmount,
		        SingleAmount = value.SingleAmount,
		        LineNum = value.LineNum,
            };
        }
        #endregion
    }
}