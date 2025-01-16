using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_configPO
    {
        #region tinyfx
        public static implicit operator Gmf_configEO(Gmf_configPO value)
        {
            if (value==null) return null;
            return new Gmf_configEO
            {
		        ID = value.ID,
		        BigWin = value.BigWin,
		        MegaWin = value.MegaWin,
		        SuperWin = value.SuperWin,
		        EpicWin = value.EpicWin,
		        BonusTH = value.BonusTH,
		        BingoTH = value.BingoTH,
		        BingoPerValue = value.BingoPerValue,
		        PartBaseRatio = value.PartBaseRatio,
		        PartBonusRatio = value.PartBonusRatio,
		        PartBingoRatio = value.PartBingoRatio,
		        BonusRetriggerRatio = value.BonusRetriggerRatio,
		        BonusBigoRatio = value.BonusBigoRatio,
            };
        }
        public static implicit operator Gmf_configPO(Gmf_configEO value)
        {
            if (value==null) return null;
            return new Gmf_configPO
            {
		        ID = value.ID,
		        BigWin = value.BigWin,
		        MegaWin = value.MegaWin,
		        SuperWin = value.SuperWin,
		        EpicWin = value.EpicWin,
		        BonusTH = value.BonusTH,
		        BingoTH = value.BingoTH,
		        BingoPerValue = value.BingoPerValue,
		        PartBaseRatio = value.PartBaseRatio,
		        PartBonusRatio = value.PartBonusRatio,
		        PartBingoRatio = value.PartBingoRatio,
		        BonusRetriggerRatio = value.BonusRetriggerRatio,
		        BonusBigoRatio = value.BonusBigoRatio,
            };
        }
        #endregion
    }
}