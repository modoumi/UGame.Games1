using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_ox.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fox_config_linePO
    {
        #region tinyfx
        public static implicit operator Fox_config_lineEO(Fox_config_linePO value)
        {
            if (value==null) return null;
            return new Fox_config_lineEO
            {
		        LineNo = value.LineNo,
		        Line = value.Line,
            };
        }
        public static implicit operator Fox_config_linePO(Fox_config_lineEO value)
        {
            if (value==null) return null;
            return new Fox_config_linePO
            {
		        LineNo = value.LineNo,
		        Line = value.Line,
            };
        }
        #endregion
    }
}