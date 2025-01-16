using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_user_chips_dataPO
    {
        #region tinyfx
        public static implicit operator Gmf_user_chips_dataEO(Gmf_user_chips_dataPO value)
        {
            if (value==null) return null;
            return new Gmf_user_chips_dataEO
            {
		        UserID = value.UserID,
		        ChipsID = value.ChipsID,
		        BingoTotal = value.BingoTotal,
		        BingoLock = value.BingoLock,
		        BingoPanelNums = value.BingoPanelNums,
		        BingoHitLine = value.BingoHitLine,
		        BingoKeepNum = value.BingoKeepNum,
		        BingoKeepNums = value.BingoKeepNums,
		        BingoHasNums = value.BingoHasNums,
		        BonusTotal = value.BonusTotal,
		        BonusLock = value.BonusLock,
		        FreeSpinNum = value.FreeSpinNum,
		        RetriggerNum = value.RetriggerNum,
		        RetriggerList = value.RetriggerList,
		        FreeSpinAmount = value.FreeSpinAmount,
		        BaseLock = value.BaseLock,
		        SlotID = value.SlotID,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Gmf_user_chips_dataPO(Gmf_user_chips_dataEO value)
        {
            if (value==null) return null;
            return new Gmf_user_chips_dataPO
            {
		        UserID = value.UserID,
		        ChipsID = value.ChipsID,
		        BingoTotal = value.BingoTotal,
		        BingoLock = value.BingoLock,
		        BingoPanelNums = value.BingoPanelNums,
		        BingoHitLine = value.BingoHitLine,
		        BingoKeepNum = value.BingoKeepNum,
		        BingoKeepNums = value.BingoKeepNums,
		        BingoHasNums = value.BingoHasNums,
		        BonusTotal = value.BonusTotal,
		        BonusLock = value.BonusLock,
		        FreeSpinNum = value.FreeSpinNum,
		        RetriggerNum = value.RetriggerNum,
		        RetriggerList = value.RetriggerList,
		        FreeSpinAmount = value.FreeSpinAmount,
		        BaseLock = value.BaseLock,
		        SlotID = value.SlotID,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}