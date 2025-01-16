using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_mouse.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fmo_config_symbolPO
    {
        #region tinyfx
        public static implicit operator Fmo_config_symbolEO(Fmo_config_symbolPO value)
        {
            if (value==null) return null;
            return new Fmo_config_symbolEO
            {
		        SymbolID = value.SymbolID,
		        SymbolType = value.SymbolType,
		        SymbolName = value.SymbolName,
		        Weight = value.Weight,
		        Multip = value.Multip,
            };
        }
        public static implicit operator Fmo_config_symbolPO(Fmo_config_symbolEO value)
        {
            if (value==null) return null;
            return new Fmo_config_symbolPO
            {
		        SymbolID = value.SymbolID,
		        SymbolType = value.SymbolType,
		        SymbolName = value.SymbolName,
		        Weight = value.Weight,
		        Multip = value.Multip,
            };
        }
        #endregion
    }
}