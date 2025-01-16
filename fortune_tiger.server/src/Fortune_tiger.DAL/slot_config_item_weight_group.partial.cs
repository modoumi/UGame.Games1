using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_tiger.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Slot_config_item_weight_groupPO
    {
        #region tinyfx
        public static implicit operator Slot_config_item_weight_groupEO(Slot_config_item_weight_groupPO value)
        {
            if (value==null) return null;
            return new Slot_config_item_weight_groupEO
            {
		        LineNum = value.LineNum,
		        LineNoArr = value.LineNoArr,
		        FristLineNum = value.FristLineNum,
		        IconNum = value.IconNum,
		        IconGroup = value.IconGroup,
		        Weight = value.Weight,
            };
        }
        public static implicit operator Slot_config_item_weight_groupPO(Slot_config_item_weight_groupEO value)
        {
            if (value==null) return null;
            return new Slot_config_item_weight_groupPO
            {
		        LineNum = value.LineNum,
		        LineNoArr = value.LineNoArr,
		        FristLineNum = value.FristLineNum,
		        IconNum = value.IconNum,
		        IconGroup = value.IconGroup,
		        Weight = value.Weight,
            };
        }
        #endregion
    }
}