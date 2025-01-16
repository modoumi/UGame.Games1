using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_item_detailPO
    {
        #region tinyfx
        public static implicit operator Gmf_item_detailEO(Gmf_item_detailPO value)
        {
            if (value==null) return null;
            return new Gmf_item_detailEO
            {
		        ItemID = value.ItemID,
		        RowIndex = value.RowIndex,
		        S1 = value.S1,
		        S2 = value.S2,
		        S3 = value.S3,
		        S4 = value.S4,
		        S5 = value.S5,
            };
        }
        public static implicit operator Gmf_item_detailPO(Gmf_item_detailEO value)
        {
            if (value==null) return null;
            return new Gmf_item_detailPO
            {
		        ItemID = value.ItemID,
		        RowIndex = value.RowIndex,
		        S1 = value.S1,
		        S2 = value.S2,
		        S3 = value.S3,
		        S4 = value.S4,
		        S5 = value.S5,
            };
        }
        #endregion
    }
}