using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_tiger.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Slot_config_linePO
    {
        #region tinyfx
        public static implicit operator Slot_config_lineEO(Slot_config_linePO value)
        {
            if (value==null) return null;
            return new Slot_config_lineEO
            {
		        AppID = value.AppID,
		        LineNo = value.LineNo,
		        Line = value.Line,
            };
        }
        public static implicit operator Slot_config_linePO(Slot_config_lineEO value)
        {
            if (value==null) return null;
            return new Slot_config_linePO
            {
		        AppID = value.AppID,
		        LineNo = value.LineNo,
		        Line = value.Line,
            };
        }
        #endregion
    }
}