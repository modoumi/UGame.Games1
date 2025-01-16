using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_mouse.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fmo_configPO
    {
        #region tinyfx
        public static implicit operator Fmo_configEO(Fmo_configPO value)
        {
            if (value==null) return null;
            return new Fmo_configEO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
		        MultipArray = value.MultipArray,
		        DefaultSlotArray = value.DefaultSlotArray,
            };
        }
        public static implicit operator Fmo_configPO(Fmo_configEO value)
        {
            if (value==null) return null;
            return new Fmo_configPO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
		        MultipArray = value.MultipArray,
		        DefaultSlotArray = value.DefaultSlotArray,
            };
        }
        #endregion
    }
}