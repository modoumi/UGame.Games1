using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_tiger.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Slot_configPO
    {
        #region tinyfx
        public static implicit operator Slot_configEO(Slot_configPO value)
        {
            if (value==null) return null;
            return new Slot_configEO
            {
		        AppID = value.AppID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
		        BIG = value.BIG,
		        MEGA = value.MEGA,
		        SUPER = value.SUPER,
		        EPIC = value.EPIC,
		        WightA = value.WightA,
		        WightB = value.WightB,
            };
        }
        public static implicit operator Slot_configPO(Slot_configEO value)
        {
            if (value==null) return null;
            return new Slot_configPO
            {
		        AppID = value.AppID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
		        BIG = value.BIG,
		        MEGA = value.MEGA,
		        SUPER = value.SUPER,
		        EPIC = value.EPIC,
		        WightA = value.WightA,
		        WightB = value.WightB,
            };
        }
        #endregion
    }
}