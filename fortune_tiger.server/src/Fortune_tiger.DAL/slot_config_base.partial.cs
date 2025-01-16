using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_tiger.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Slot_config_basePO
    {
        #region tinyfx
        public static implicit operator Slot_config_baseEO(Slot_config_basePO value)
        {
            if (value==null) return null;
            return new Slot_config_baseEO
            {
		        BaseName = value.BaseName,
		        BaseColumn = value.BaseColumn,
		        BaseText = value.BaseText,
            };
        }
        public static implicit operator Slot_config_basePO(Slot_config_baseEO value)
        {
            if (value==null) return null;
            return new Slot_config_basePO
            {
		        BaseName = value.BaseName,
		        BaseColumn = value.BaseColumn,
		        BaseText = value.BaseText,
            };
        }
        #endregion
    }
}