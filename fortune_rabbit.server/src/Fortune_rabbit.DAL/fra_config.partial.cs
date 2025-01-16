using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_rabbit.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fra_configPO
    {
        #region tinyfx
        public static implicit operator Fra_configEO(Fra_configPO value)
        {
            if (value==null) return null;
            return new Fra_configEO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
		        SpecialModeRatio = value.SpecialModeRatio,
		        SpecialModeArray = value.SpecialModeArray,
		        SpecialModeTurnNum = value.SpecialModeTurnNum,
		        DefaultSlotArray = value.DefaultSlotArray,
		        MultipArray = value.MultipArray,
            };
        }
        public static implicit operator Fra_configPO(Fra_configEO value)
        {
            if (value==null) return null;
            return new Fra_configPO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
		        SpecialModeRatio = value.SpecialModeRatio,
		        SpecialModeArray = value.SpecialModeArray,
		        SpecialModeTurnNum = value.SpecialModeTurnNum,
		        DefaultSlotArray = value.DefaultSlotArray,
		        MultipArray = value.MultipArray,
            };
        }
        #endregion
    }
}