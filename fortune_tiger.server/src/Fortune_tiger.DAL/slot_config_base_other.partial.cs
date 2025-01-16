using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_tiger.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Slot_config_base_otherPO
    {
        #region tinyfx
        public static implicit operator Slot_config_base_otherEO(Slot_config_base_otherPO value)
        {
            if (value==null) return null;
            return new Slot_config_base_otherEO
            {
		        ItemId = value.ItemId,
		        LineNum = value.LineNum,
		        Weight = value.Weight,
            };
        }
        public static implicit operator Slot_config_base_otherPO(Slot_config_base_otherEO value)
        {
            if (value==null) return null;
            return new Slot_config_base_otherPO
            {
		        ItemId = value.ItemId,
		        LineNum = value.LineNum,
		        Weight = value.Weight,
            };
        }
        #endregion
    }
}