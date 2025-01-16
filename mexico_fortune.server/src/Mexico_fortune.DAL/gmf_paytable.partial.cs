using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_paytablePO
    {
        #region tinyfx
        public static implicit operator Gmf_paytableEO(Gmf_paytablePO value)
        {
            if (value==null) return null;
            return new Gmf_paytableEO
            {
		        SymbolID = value.SymbolID,
		        Count = value.Count,
		        Multip = value.Multip,
            };
        }
        public static implicit operator Gmf_paytablePO(Gmf_paytableEO value)
        {
            if (value==null) return null;
            return new Gmf_paytablePO
            {
		        SymbolID = value.SymbolID,
		        Count = value.Count,
		        Multip = value.Multip,
            };
        }
        #endregion
    }
}