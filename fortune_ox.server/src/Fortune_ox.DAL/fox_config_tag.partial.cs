using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_ox.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fox_config_tagPO
    {
        #region tinyfx
        public static implicit operator Fox_config_tagEO(Fox_config_tagPO value)
        {
            if (value==null) return null;
            return new Fox_config_tagEO
            {
		        BID = value.BID,
		        BetAmount = value.BetAmount,
		        BetAmountEnd = value.BetAmountEnd,
		        SpecialModeRatio = value.SpecialModeRatio,
		        WeightList = value.WeightList,
		        SpecialMode_Y1 = value.SpecialMode_Y1,
		        SpecialMode_Y2 = value.SpecialMode_Y2,
		        Memo = value.Memo,
            };
        }
        public static implicit operator Fox_config_tagPO(Fox_config_tagEO value)
        {
            if (value==null) return null;
            return new Fox_config_tagPO
            {
		        BID = value.BID,
		        BetAmount = value.BetAmount,
		        BetAmountEnd = value.BetAmountEnd,
		        SpecialModeRatio = value.SpecialModeRatio,
		        WeightList = value.WeightList,
		        SpecialMode_Y1 = value.SpecialMode_Y1,
		        SpecialMode_Y2 = value.SpecialMode_Y2,
		        Memo = value.Memo,
            };
        }
        #endregion
    }
}