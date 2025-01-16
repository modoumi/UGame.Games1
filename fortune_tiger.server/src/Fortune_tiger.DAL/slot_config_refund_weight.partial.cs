using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_tiger.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Slot_config_refund_weightPO
    {
        #region tinyfx
        public static implicit operator Slot_config_refund_weightEO(Slot_config_refund_weightPO value)
        {
            if (value==null) return null;
            return new Slot_config_refund_weightEO
            {
		        WeightID = value.WeightID,
		        Multiple = value.Multiple,
		        Weight = value.Weight,
            };
        }
        public static implicit operator Slot_config_refund_weightPO(Slot_config_refund_weightEO value)
        {
            if (value==null) return null;
            return new Slot_config_refund_weightPO
            {
		        WeightID = value.WeightID,
		        Multiple = value.Multiple,
		        Weight = value.Weight,
            };
        }
        #endregion
    }
}