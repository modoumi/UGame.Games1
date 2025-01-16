using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_mouse.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fmo_config_linePO
    {
        #region tinyfx
        public static implicit operator Fmo_config_lineEO(Fmo_config_linePO value)
        {
            if (value==null) return null;
            return new Fmo_config_lineEO
            {
		        LineNo = value.LineNo,
		        Line = value.Line,
            };
        }
        public static implicit operator Fmo_config_linePO(Fmo_config_lineEO value)
        {
            if (value==null) return null;
            return new Fmo_config_linePO
            {
		        LineNo = value.LineNo,
		        Line = value.Line,
            };
        }
        #endregion
    }
}