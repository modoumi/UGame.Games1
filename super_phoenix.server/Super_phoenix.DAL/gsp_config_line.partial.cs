using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Super_phoenix.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gsp_config_linePO
    {
        #region tinyfx
        public static implicit operator Gsp_config_lineEO(Gsp_config_linePO value)
        {
            if (value==null) return null;
            return new Gsp_config_lineEO
            {
		        LineNo = value.LineNo,
		        Line = value.Line,
            };
        }
        public static implicit operator Gsp_config_linePO(Gsp_config_lineEO value)
        {
            if (value==null) return null;
            return new Gsp_config_linePO
            {
		        LineNo = value.LineNo,
		        Line = value.Line,
            };
        }
        #endregion
    }
}