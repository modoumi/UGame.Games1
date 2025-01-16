using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_tiger.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Slot_config_lvPO
    {
        #region tinyfx
        public static implicit operator Slot_config_lvEO(Slot_config_lvPO value)
        {
            if (value==null) return null;
            return new Slot_config_lvEO
            {
		        Level = value.Level,
		        TotalBet = value.TotalBet,
		        RefundLimit = value.RefundLimit,
		        CashRate = value.CashRate,
		        LastLossRate = value.LastLossRate,
		        LossRate = value.LossRate,
		        RTP = value.RTP,
            };
        }
        public static implicit operator Slot_config_lvPO(Slot_config_lvEO value)
        {
            if (value==null) return null;
            return new Slot_config_lvPO
            {
		        Level = value.Level,
		        TotalBet = value.TotalBet,
		        RefundLimit = value.RefundLimit,
		        CashRate = value.CashRate,
		        LastLossRate = value.LastLossRate,
		        LossRate = value.LossRate,
		        RTP = value.RTP,
            };
        }
        #endregion
    }
}