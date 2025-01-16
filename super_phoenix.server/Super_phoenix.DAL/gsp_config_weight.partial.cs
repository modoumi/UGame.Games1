using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Super_phoenix.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gsp_config_weightPO
    {
        #region tinyfx
        public static implicit operator Gsp_config_weightEO(Gsp_config_weightPO value)
        {
            if (value==null) return null;
            return new Gsp_config_weightEO
            {
		        ItemID = value.ItemID,
		        ItemType = value.ItemType,
		        IconType = value.IconType,
		        Weight1 = value.Weight1,
		        Weight2 = value.Weight2,
		        Weight3 = value.Weight3,
		        Weight4 = value.Weight4,
		        Weight5 = value.Weight5,
            };
        }
        public static implicit operator Gsp_config_weightPO(Gsp_config_weightEO value)
        {
            if (value==null) return null;
            return new Gsp_config_weightPO
            {
		        ItemID = value.ItemID,
		        ItemType = value.ItemType,
		        IconType = value.IconType,
		        Weight1 = value.Weight1,
		        Weight2 = value.Weight2,
		        Weight3 = value.Weight3,
		        Weight4 = value.Weight4,
		        Weight5 = value.Weight5,
            };
        }
        #endregion
    }
}