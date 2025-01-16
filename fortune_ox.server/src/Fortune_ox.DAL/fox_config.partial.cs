using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_ox.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fox_configPO
    {
        #region tinyfx
        public static implicit operator Fox_configEO(Fox_configPO value)
        {
            if (value==null) return null;
            return new Fox_configEO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
		        HHSWRatio = value.HHSWRatio,
		        TriggerLampMultip = value.TriggerLampMultip,
		        DefaultSlotArray = value.DefaultSlotArray,
		        MultipArray = value.MultipArray,
            };
        }
        public static implicit operator Fox_configPO(Fox_configEO value)
        {
            if (value==null) return null;
            return new Fox_configPO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
		        HHSWRatio = value.HHSWRatio,
		        TriggerLampMultip = value.TriggerLampMultip,
		        DefaultSlotArray = value.DefaultSlotArray,
		        MultipArray = value.MultipArray,
            };
        }
        #endregion
    }
}