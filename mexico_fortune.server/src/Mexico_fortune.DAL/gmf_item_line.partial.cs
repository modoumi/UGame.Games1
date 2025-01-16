using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_item_linePO
    {
        #region tinyfx
        public static implicit operator Gmf_item_lineEO(Gmf_item_linePO value)
        {
            if (value==null) return null;
            return new Gmf_item_lineEO
            {
		        ItemID = value.ItemID,
		        LineId = value.LineId,
		        HitId = value.HitId,
		        HitNum = value.HitNum,
		        Multip = value.Multip,
            };
        }
        public static implicit operator Gmf_item_linePO(Gmf_item_lineEO value)
        {
            if (value==null) return null;
            return new Gmf_item_linePO
            {
		        ItemID = value.ItemID,
		        LineId = value.LineId,
		        HitId = value.HitId,
		        HitNum = value.HitNum,
		        Multip = value.Multip,
            };
        }
        #endregion
    }
}