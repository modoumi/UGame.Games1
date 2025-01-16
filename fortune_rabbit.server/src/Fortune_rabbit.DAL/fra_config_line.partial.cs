using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_rabbit.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fra_config_linePO
    {
        #region tinyfx
        public static implicit operator Fra_config_lineEO(Fra_config_linePO value)
        {
            if (value==null) return null;
            return new Fra_config_lineEO
            {
		        LineNo = value.LineNo,
		        Line = value.Line,
            };
        }
        public static implicit operator Fra_config_linePO(Fra_config_lineEO value)
        {
            if (value==null) return null;
            return new Fra_config_linePO
            {
		        LineNo = value.LineNo,
		        Line = value.Line,
            };
        }
        #endregion
    }
}