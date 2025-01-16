using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_big.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Big_config_symbolPO
    {
        #region tinyfx
        public static implicit operator Big_config_symbolEO(Big_config_symbolPO value)
        {
            if (value==null) return null;
            return new Big_config_symbolEO
            {
		        SymbolID = value.SymbolID,
		        SymbolType = value.SymbolType,
		        SymbolName = value.SymbolName,
		        SymbolMultiple3 = value.SymbolMultiple3,
		        SymbolMultiple4 = value.SymbolMultiple4,
		        SymbolMultiple5 = value.SymbolMultiple5,
            };
        }
        public static implicit operator Big_config_symbolPO(Big_config_symbolEO value)
        {
            if (value==null) return null;
            return new Big_config_symbolPO
            {
		        SymbolID = value.SymbolID,
		        SymbolType = value.SymbolType,
		        SymbolName = value.SymbolName,
		        SymbolMultiple3 = value.SymbolMultiple3,
		        SymbolMultiple4 = value.SymbolMultiple4,
		        SymbolMultiple5 = value.SymbolMultiple5,
            };
        }
        #endregion
    }
}