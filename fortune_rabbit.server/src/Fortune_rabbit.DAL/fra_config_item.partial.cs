using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_rabbit.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fra_config_itemPO
    {
        #region tinyfx
        public static implicit operator Fra_config_itemEO(Fra_config_itemPO value)
        {
            if (value==null) return null;
            return new Fra_config_itemEO
            {
		        ItemID = value.ItemID,
		        IconType = value.IconType,
		        ItemName = value.ItemName,
		        ItemBaseMultip = value.ItemBaseMultip,
            };
        }
        public static implicit operator Fra_config_itemPO(Fra_config_itemEO value)
        {
            if (value==null) return null;
            return new Fra_config_itemPO
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