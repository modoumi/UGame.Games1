using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_tiger.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Slot_config_tagPO
    {
        #region tinyfx
        public static implicit operator Slot_config_tagEO(Slot_config_tagPO value)
        {
            if (value==null) return null;
            return new Slot_config_tagEO
            {
		        BID = value.BID,
		        BetAmount = value.BetAmount,
		        BetAmountEnd = value.BetAmountEnd,
		        SpecialModeRatio = value.SpecialModeRatio,
		        WeightList = value.WeightList,
		        RandomSymbol = value.RandomSymbol,
		        RandomSymbolMultip = value.RandomSymbolMultip,
		        Memo = value.Memo,
            };
        }
        public static implicit operator Slot_config_tagPO(Slot_config_tagEO value)
        {
            if (value==null) return null;
            return new Slot_config_tagPO
            {
		        BID = value.BID,
		        BetAmount = value.BetAmount,
		        BetAmountEnd = value.BetAmountEnd,
		        SpecialModeRatio = value.SpecialModeRatio,
		        WeightList = value.WeightList,
		        RandomSymbol = value.RandomSymbol,
		        RandomSymbolMultip = value.RandomSymbolMultip,
		        Memo = value.Memo,
            };
        }
        #endregion
    }
}