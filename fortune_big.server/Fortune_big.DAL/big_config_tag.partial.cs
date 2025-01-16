using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_big.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Big_config_tagPO
    {
        #region tinyfx
        public static implicit operator Big_config_tagEO(Big_config_tagPO value)
        {
            if (value==null) return null;
            return new Big_config_tagEO
            {
		        BID = value.BID,
		        BetAmount = value.BetAmount,
		        BetAmountEnd = value.BetAmountEnd,
		        SpecialModeRatio = value.SpecialModeRatio,
		        Weight_Main = value.Weight_Main,
		        Weight_Main2 = value.Weight_Main2,
		        Weight_Free1 = value.Weight_Free1,
		        Weight_Free3 = value.Weight_Free3,
		        Weight_Free2 = value.Weight_Free2,
            };
        }
        public static implicit operator Big_config_tagPO(Big_config_tagEO value)
        {
            if (value==null) return null;
            return new Big_config_tagPO
            {
		        BID = value.BID,
		        BetAmount = value.BetAmount,
		        BetAmountEnd = value.BetAmountEnd,
		        SpecialModeRatio = value.SpecialModeRatio,
		        Weight_Main = value.Weight_Main,
		        Weight_Main2 = value.Weight_Main2,
		        Weight_Free1 = value.Weight_Free1,
		        Weight_Free3 = value.Weight_Free3,
		        Weight_Free2 = value.Weight_Free2,
            };
        }
        #endregion
    }
}