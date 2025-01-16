using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_ox.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fox_config_itemPO
    {
        #region tinyfx
        public static implicit operator Fox_config_itemEO(Fox_config_itemPO value)
        {
            if (value==null) return null;
            return new Fox_config_itemEO
            {
		        ItemID = value.ItemID,
		        IconType = value.IconType,
		        ItemName = value.ItemName,
		        ItemBaseMultip = value.ItemBaseMultip,
            };
        }
        public static implicit operator Fox_config_itemPO(Fox_config_itemEO value)
        {
            if (value==null) return null;
            return new Fox_config_itemPO
            {
		        ItemID = value.ItemID,
		        IconType = value.IconType,
		        ItemName = value.ItemName,
		        ItemBaseMultip = value.ItemBaseMultip,
            };
        }
        #endregion
    }
}