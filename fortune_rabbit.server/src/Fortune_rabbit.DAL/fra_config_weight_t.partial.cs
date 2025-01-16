using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_rabbit.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fra_config_weight_tPO
    {
        #region tinyfx
        public static implicit operator Fra_config_weight_tEO(Fra_config_weight_tPO value)
        {
            if (value==null) return null;
            return new Fra_config_weight_tEO
            {
		        TID = value.TID,
		        Weight_Main = value.Weight_Main,
		        Weight_SM = value.Weight_SM,
		        Multip = value.Multip,
            };
        }
        public static implicit operator Fra_config_weight_tPO(Fra_config_weight_tEO value)
        {
            if (value==null) return null;
            return new Fra_config_weight_tPO
            {
		        TID = value.TID,
		        Weight_Main = value.Weight_Main,
		        Weight_SM = value.Weight_SM,
		        Multip = value.Multip,
            };
        }
        #endregion
    }
}