using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_user_slotPO
    {
        #region tinyfx
        public static implicit operator Gmf_user_slotEO(Gmf_user_slotPO value)
        {
            if (value==null) return null;
            return new Gmf_user_slotEO
            {
		        SlotID = value.SlotID,
		        UserID = value.UserID,
		        ChipsID = value.ChipsID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IsFreeSpin = value.IsFreeSpin,
		        PartBase = value.PartBase,
		        PartBonus = value.PartBonus,
		        PartBingo = value.PartBingo,
		        PartIncome = value.PartIncome,
		        BingoIsOutTH = value.BingoIsOutTH,
		        BingoIsWin = value.BingoIsWin,
		        BingoJPPoolType = value.BingoJPPoolType,
		        BingoMultip = value.BingoMultip,
		        BingoTotal = value.BingoTotal,
		        BingoPanelNums = value.BingoPanelNums,
		        BingoHitLine = value.BingoHitLine,
		        BingoKeepNum = value.BingoKeepNum,
		        BingoKeepNums = value.BingoKeepNums,
		        BingoNewNums = value.BingoNewNums,
		        BingoHasNums = value.BingoHasNums,
		        BingoWinAmount = value.BingoWinAmount,
		        BonusIsOutTH = value.BonusIsOutTH,
		        BonusIsWin = value.BonusIsWin,
		        BonusMultip = value.BonusMultip,
		        BonusTotal = value.BonusTotal,
		        BonusSymbolNum = value.BonusSymbolNum,
		        BonusNewRetriggerNum = value.BonusNewRetriggerNum,
		        FreeSpinNum = value.FreeSpinNum,
		        RetriggerNum = value.RetriggerNum,
		        RetriggerList = value.RetriggerList,
		        BonusWinAmount = value.BonusWinAmount,
		        BaseIsWin = value.BaseIsWin,
		        BaseMultip = value.BaseMultip,
		        BaseWinAmount = value.BaseWinAmount,
		        TotalAmount = value.TotalAmount,
		        SlotItemID = value.SlotItemID,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Gmf_user_slotPO(Gmf_user_slotEO value)
        {
            if (value==null) return null;
            return new Gmf_user_slotPO
            {
		        SlotID = value.SlotID,
		        UserID = value.UserID,
		        ChipsID = value.ChipsID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IsFreeSpin = value.IsFreeSpin,
		        PartBase = value.PartBase,
		        PartBonus = value.PartBonus,
		        PartBingo = value.PartBingo,
		        PartIncome = value.PartIncome,
		        BingoIsOutTH = value.BingoIsOutTH,
		        BingoIsWin = value.BingoIsWin,
		        BingoJPPoolType = value.BingoJPPoolType,
		        BingoMultip = value.BingoMultip,
		        BingoTotal = value.BingoTotal,
		        BingoPanelNums = value.BingoPanelNums,
		        BingoHitLine = value.BingoHitLine,
		        BingoKeepNum = value.BingoKeepNum,
		        BingoKeepNums = value.BingoKeepNums,
		        BingoNewNums = value.BingoNewNums,
		        BingoHasNums = value.BingoHasNums,
		        BingoWinAmount = value.BingoWinAmount,
		        BonusIsOutTH = value.BonusIsOutTH,
		        BonusIsWin = value.BonusIsWin,
		        BonusMultip = value.BonusMultip,
		        BonusTotal = value.BonusTotal,
		        BonusSymbolNum = value.BonusSymbolNum,
		        BonusNewRetriggerNum = value.BonusNewRetriggerNum,
		        FreeSpinNum = value.FreeSpinNum,
		        RetriggerNum = value.RetriggerNum,
		        RetriggerList = value.RetriggerList,
		        BonusWinAmount = value.BonusWinAmount,
		        BaseIsWin = value.BaseIsWin,
		        BaseMultip = value.BaseMultip,
		        BaseWinAmount = value.BaseWinAmount,
		        TotalAmount = value.TotalAmount,
		        SlotItemID = value.SlotItemID,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}