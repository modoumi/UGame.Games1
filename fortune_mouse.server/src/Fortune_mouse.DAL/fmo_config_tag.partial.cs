using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Fortune_mouse.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Fmo_config_tagPO
    {
        #region tinyfx
        public static implicit operator Fmo_config_tagEO(Fmo_config_tagPO value)
        {
            if (value==null) return null;
            return new Fmo_config_tagEO
            {
		        BID = value.BID,
		        BetAmount = value.BetAmount,
		        BetAmountEnd = value.BetAmountEnd,
		        SpecialModeRatio = value.SpecialModeRatio,
		        Weight_Main = value.Weight_Main,
		        Weight_SM = value.Weight_SM,
		        Memo = value.Memo,
            };
        }
        public static implicit operator Fmo_config_tagPO(Fmo_config_tagEO value)
        {
            if (value==null) return null;
            return new Fmo_config_tagPO
            {
		        BID = value.BID,
		        BetAmount = value.BetAmount,
		        BetAmountEnd = value.BetAmountEnd,
		        SpecialModeRatio = value.SpecialModeRatio,
		        Weight_Main = value.Weight_Main,
		        Weight_SM = value.Weight_SM,
		        Memo = value.Memo,
            };
        }
        #endregion
    }
}