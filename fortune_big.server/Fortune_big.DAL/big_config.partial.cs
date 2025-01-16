using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_big.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Big_configPO
    {
        #region tinyfx
        public static implicit operator Big_configEO(Big_configPO value)
        {
            if (value==null) return null;
            return new Big_configEO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
		        DefaultSlotArray = value.DefaultSlotArray,
		        MultipleArray = value.MultipleArray,
		        SingleBetArray = value.SingleBetArray,
		        FreeSpinNum = value.FreeSpinNum,
		        RespinNum = value.RespinNum,
            };
        }
        public static implicit operator Big_configPO(Big_configEO value)
        {
            if (value==null) return null;
            return new Big_configPO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
		        DefaultSlotArray = value.DefaultSlotArray,
		        MultipleArray = value.MultipleArray,
		        SingleBetArray = value.SingleBetArray,
		        FreeSpinNum = value.FreeSpinNum,
		        RespinNum = value.RespinNum,
            };
        }
        #endregion
    }
}