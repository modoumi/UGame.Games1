using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Super_phoenix.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gsp_config_multipPO
    {
        #region tinyfx
        public static implicit operator Gsp_config_multipEO(Gsp_config_multipPO value)
        {
            if (value==null) return null;
            return new Gsp_config_multipEO
            {
		        ItemID = value.ItemID,
		        IconType = value.IconType,
		        Multip3 = value.Multip3,
		        Multip4 = value.Multip4,
		        Multip5 = value.Multip5,
            };
        }
        public static implicit operator Gsp_config_multipPO(Gsp_config_multipEO value)
        {
            if (value==null) return null;
            return new Gsp_config_multipPO
            {
		        ItemID = value.ItemID,
		        IconType = value.IconType,
		        Multip3 = value.Multip3,
		        Multip4 = value.Multip4,
		        Multip5 = value.Multip5,
            };
        }
        #endregion
    }
}