using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_bonus_weightPO
    {
        #region tinyfx
        public static implicit operator Gmf_bonus_weightEO(Gmf_bonus_weightPO value)
        {
            if (value==null) return null;
            return new Gmf_bonus_weightEO
            {
		        WeightID = value.WeightID,
		        SymbolNum = value.SymbolNum,
		        Multip = value.Multip,
		        Weight = value.Weight,
            };
        }
        public static implicit operator Gmf_bonus_weightPO(Gmf_bonus_weightEO value)
        {
            if (value==null) return null;
            return new Gmf_bonus_weightPO
            {
		        WeightID = value.WeightID,
		        SymbolNum = value.SymbolNum,
		        Multip = value.Multip,
		        Weight = value.Weight,
            };
        }
        #endregion
    }
}