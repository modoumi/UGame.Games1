using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_big.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Big_config_linePO
    {
        #region tinyfx
        public static implicit operator Big_config_lineEO(Big_config_linePO value)
        {
            if (value==null) return null;
            return new Big_config_lineEO
            {
		        LineID = value.LineID,
		        Line = value.Line,
            };
        }
        public static implicit operator Big_config_linePO(Big_config_lineEO value)
        {
            if (value==null) return null;
            return new Big_config_linePO
            {
		        LineID = value.LineID,
		        Line = value.Line,
            };
        }
        #endregion
    }
}