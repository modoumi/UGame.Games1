using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_symbolPO
    {
        #region tinyfx
        public static implicit operator Gmf_symbolEO(Gmf_symbolPO value)
        {
            if (value==null) return null;
            return new Gmf_symbolEO
            {
		        SymbolID = value.SymbolID,
		        Name = value.Name,
		        Type = value.Type,
		        IsNormal = value.IsNormal,
		        IsWild = value.IsWild,
		        IsBonus = value.IsBonus,
		        IsBingo = value.IsBingo,
            };
        }
        public static implicit operator Gmf_symbolPO(Gmf_symbolEO value)
        {
            if (value==null) return null;
            return new Gmf_symbolPO
            {
		        SymbolID = value.SymbolID,
		        Name = value.Name,
		        Type = value.Type,
		        IsNormal = value.IsNormal,
		        IsWild = value.IsWild,
		        IsBonus = value.IsBonus,
		        IsBingo = value.IsBingo,
            };
        }
        #endregion
    }
}