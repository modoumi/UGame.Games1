using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_itemPO
    {
        #region tinyfx
        public static implicit operator Gmf_itemEO(Gmf_itemPO value)
        {
            if (value==null) return null;
            return new Gmf_itemEO
            {
		        ItemID = value.ItemID,
		        Multip = value.Multip,
		        BonusNum = value.BonusNum,
		        BingoNum = value.BingoNum,
		        LineNum = value.LineNum,
            };
        }
        public static implicit operator Gmf_itemPO(Gmf_itemEO value)
        {
            if (value==null) return null;
            return new Gmf_itemPO
            {
		        ItemID = value.ItemID,
		        Multip = value.Multip,
		        BonusNum = value.BonusNum,
		        BingoNum = value.BingoNum,
		        LineNum = value.LineNum,
            };
        }
        #endregion
    }
}