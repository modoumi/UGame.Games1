using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_chipsPO
    {
        #region tinyfx
        public static implicit operator Gmf_chipsEO(Gmf_chipsPO value)
        {
            if (value==null) return null;
            return new Gmf_chipsEO
            {
		        ChipsID = value.ChipsID,
		        CurrencyID = value.CurrencyID,
		        BetMoney = value.BetMoney,
		        JPMini = value.JPMini,
		        JPMinor = value.JPMinor,
		        JPMajor = value.JPMajor,
		        JPGrand = value.JPGrand,
            };
        }
        public static implicit operator Gmf_chipsPO(Gmf_chipsEO value)
        {
            if (value==null) return null;
            return new Gmf_chipsPO
            {
		        ChipsID = value.ChipsID,
		        CurrencyID = value.CurrencyID,
		        BetMoney = value.BetMoney,
		        JPMini = value.JPMini,
		        JPMinor = value.JPMinor,
		        JPMajor = value.JPMajor,
		        JPGrand = value.JPGrand,
            };
        }
        #endregion
    }
}