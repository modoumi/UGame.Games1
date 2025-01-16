using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_tiger.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Slot_config_triggerPO
    {
        #region tinyfx
        public static implicit operator Slot_config_triggerEO(Slot_config_triggerPO value)
        {
            if (value==null) return null;
            return new Slot_config_triggerEO
            {
		        Round = value.Round,
		        TriggerRate = value.TriggerRate,
            };
        }
        public static implicit operator Slot_config_triggerPO(Slot_config_triggerEO value)
        {
            if (value==null) return null;
            return new Slot_config_triggerPO
            {
		        Round = value.Round,
		        TriggerRate = value.TriggerRate,
            };
        }
        #endregion
    }
}