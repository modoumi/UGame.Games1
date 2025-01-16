using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_ox.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fox_config_weight_changePO
    {
        #region tinyfx
        public static implicit operator Fox_config_weight_changeEO(Fox_config_weight_changePO value)
        {
            if (value==null) return null;
            return new Fox_config_weight_changeEO
            {
		        Y1 = value.Y1,
		        Y2 = value.Y2,
		        Y3 = value.Y3,
            };
        }
        public static implicit operator Fox_config_weight_changePO(Fox_config_weight_changeEO value)
        {
            if (value==null) return null;
            return new Fox_config_weight_changePO
            {
		        Y1 = value.Y1,
		        Y2 = value.Y2,
		        Y3 = value.Y3,
            };
        }
        #endregion
    }
}