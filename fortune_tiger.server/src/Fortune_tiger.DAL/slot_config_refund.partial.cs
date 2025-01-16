using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_tiger.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Slot_config_refundPO
    {
        #region tinyfx
        public static implicit operator Slot_config_refundEO(Slot_config_refundPO value)
        {
            if (value==null) return null;
            return new Slot_config_refundEO
            {
		        ReundID = value.ReundID,
		        BetRate = value.BetRate,
		        RefundPotRate = value.RefundPotRate,
		        SpecialModeCD = value.SpecialModeCD,
		        NewMinigameRound = value.NewMinigameRound,
		        NewRefundRound = value.NewRefundRound,
		        NewExtraRefund = value.NewExtraRefund,
		        Weight_Free2 = value.Weight_Free2,
            };
        }
        public static implicit operator Slot_config_refundPO(Slot_config_refundEO value)
        {
            if (value==null) return null;
            return new Slot_config_refundPO
            {
		        ReundID = value.ReundID,
		        BetRate = value.BetRate,
		        RefundPotRate = value.RefundPotRate,
		        SpecialModeCD = value.SpecialModeCD,
		        NewMinigameRound = value.NewMinigameRound,
		        NewRefundRound = value.NewRefundRound,
		        NewExtraRefund = value.NewExtraRefund,
		        Weight_Free2 = value.Weight_Free2,
            };
        }
        #endregion
    }
}