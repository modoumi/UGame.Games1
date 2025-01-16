using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_tiger.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Slot_config_itemPO
    {
        #region tinyfx
        public static implicit operator Slot_config_itemEO(Slot_config_itemPO value)
        {
            if (value==null) return null;
            return new Slot_config_itemEO
            {
		        AppID = value.AppID,
		        ItemID = value.ItemID,
		        PoolType = value.PoolType,
		        IconType = value.IconType,
		        ItemName = value.ItemName,
		        ItemWeight = value.ItemWeight,
		        ItemBaseMultip = value.ItemBaseMultip,
            };
        }
        public static implicit operator Slot_config_itemPO(Slot_config_itemEO value)
        {
            if (value==null) return null;
            return new Slot_config_itemPO
            {
		        AppID = value.AppID,
		        ItemID = value.ItemID,
		        PoolType = value.PoolType,
		        IconType = value.IconType,
		        ItemName = value.ItemName,
		        ItemWeight = value.ItemWeight,
		        ItemBaseMultip = value.ItemBaseMultip,
            };
        }
        #endregion
    }
}