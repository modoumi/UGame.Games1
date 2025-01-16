using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_tiger.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Slot_config_hhswPO
    {
        #region tinyfx
        public static implicit operator Slot_config_hhswEO(Slot_config_hhswPO value)
        {
            if (value==null) return null;
            return new Slot_config_hhswEO
            {
		        HhswID = value.HhswID,
		        LineNum = value.LineNum,
		        LineNoArr = value.LineNoArr,
		        IconGroup = value.IconGroup,
		        Memo = value.Memo,
            };
        }
        public static implicit operator Slot_config_hhswPO(Slot_config_hhswEO value)
        {
            if (value==null) return null;
            return new Slot_config_hhswPO
            {
		        HhswID = value.HhswID,
		        LineNum = value.LineNum,
		        LineNoArr = value.LineNoArr,
		        IconGroup = value.IconGroup,
		        Memo = value.Memo,
            };
        }
        #endregion
    }
}