using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Super_phoenix.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gsp_configPO
    {
        #region tinyfx
        public static implicit operator Gsp_configEO(Gsp_configPO value)
        {
            if (value==null) return null;
            return new Gsp_configEO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
		        MiniGameRatio = value.MiniGameRatio,
		        FreeSpinCount = value.FreeSpinCount,
		        FreeSpinTrigger = value.FreeSpinTrigger,
		        BIG = value.BIG,
		        MEGA = value.MEGA,
		        SUPER = value.SUPER,
		        EPIC = value.EPIC,
            };
        }
        public static implicit operator Gsp_configPO(Gsp_configEO value)
        {
            if (value==null) return null;
            return new Gsp_configPO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
		        MiniGameRatio = value.MiniGameRatio,
		        FreeSpinCount = value.FreeSpinCount,
		        FreeSpinTrigger = value.FreeSpinTrigger,
		        BIG = value.BIG,
		        MEGA = value.MEGA,
		        SUPER = value.SUPER,
		        EPIC = value.EPIC,
            };
        }
        #endregion
    }
}