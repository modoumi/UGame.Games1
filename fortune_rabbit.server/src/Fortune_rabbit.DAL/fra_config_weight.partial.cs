using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_rabbit.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fra_config_weightPO
    {
        #region tinyfx
        public static implicit operator Fra_config_weightEO(Fra_config_weightPO value)
        {
            if (value==null) return null;
            return new Fra_config_weightEO
            {
		        ItemID = value.ItemID,
		        IconType = value.IconType,
		        Weight1 = value.Weight1,
		        Weight2 = value.Weight2,
		        Weight3 = value.Weight3,
            };
        }
        public static implicit operator Fra_config_weightPO(Fra_config_weightEO value)
        {
            if (value==null) return null;
            return new Fra_config_weightPO
            {
		        ItemID = value.ItemID,
		        IconType = value.IconType,
		        Weight1 = value.Weight1,
		        Weight2 = value.Weight2,
		        Weight3 = value.Weight3,
            };
        }
        #endregion
    }
}