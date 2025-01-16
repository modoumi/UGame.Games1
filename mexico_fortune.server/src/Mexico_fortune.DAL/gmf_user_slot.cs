using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///slot游戏明细
    ///</summary>
    [SugarTable("gmf_user_slot")]
    public partial class Gmf_user_slotPO
    {
           public Gmf_user_slotPO(){

            this.IsFreeSpin =false;
            this.PartBase =0;
            this.PartBonus =0;
            this.PartBingo =0;
            this.PartIncome =0;
            this.BingoIsOutTH =false;
            this.BingoIsWin =false;
            this.BingoJPPoolType =0;
            this.BingoMultip =0;
            this.BingoTotal =0;
            this.BingoHitLine =0;
            this.BingoKeepNum =0;
            this.BingoWinAmount =0;
            this.BonusIsOutTH =false;
            this.BonusIsWin =false;
            this.BonusMultip =0;
            this.BonusTotal =0;
            this.BonusSymbolNum =0;
            this.BonusNewRetriggerNum =0;
            this.FreeSpinNum =0;
            this.RetriggerNum =0;
            this.BonusWinAmount =0;
            this.BaseIsWin =false;
            this.BaseMultip =0;
            this.BaseWinAmount =0;
            this.TotalAmount =0;
            this.Status =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long SlotID {get;set;}

           /// <summary>
           /// Desc:用户编码(GUID)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? UserID {get;set;}

           /// <summary>
           /// Desc:筹码编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ChipsID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:货币编码（ISO 4217大写）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:是否FreeSpin
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsFreeSpin {get;set;}

           /// <summary>
           /// Desc:BaseGame分配金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PartBase {get;set;}

           /// <summary>
           /// Desc:Bonus分配金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PartBonus {get;set;}

           /// <summary>
           /// Desc:Bingo分配金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PartBingo {get;set;}

           /// <summary>
           /// Desc:收入分配金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PartIncome {get;set;}

           /// <summary>
           /// Desc:bingo是否超过阈值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool BingoIsOutTH {get;set;}

           /// <summary>
           /// Desc:bingo是否奖励
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool BingoIsWin {get;set;}

           /// <summary>
           /// Desc:bingoJP奖池类型
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BingoJPPoolType {get;set;}

           /// <summary>
           /// Desc:bingo倍率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BingoMultip {get;set;}

           /// <summary>
           /// Desc:Bingo累计
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BingoTotal {get;set;}

           /// <summary>
           /// Desc:面板的25个球,按顺序|分割
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? BingoPanelNums {get;set;}

           /// <summary>
           /// Desc:Bingo中奖线
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BingoHitLine {get;set;}

           /// <summary>
           /// Desc:Bingo保留的数字
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BingoKeepNum {get;set;}

           /// <summary>
           /// Desc:Bingo保留的数字
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? BingoKeepNums {get;set;}

           /// <summary>
           /// Desc:bingo新数字
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? BingoNewNums {get;set;}

           /// <summary>
           /// Desc:已出的75个数字,按顺序|分割
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? BingoHasNums {get;set;}

           /// <summary>
           /// Desc:bingo奖金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BingoWinAmount {get;set;}

           /// <summary>
           /// Desc:bonus是否超过阈值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool BonusIsOutTH {get;set;}

           /// <summary>
           /// Desc:Bunus是否奖励
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool BonusIsWin {get;set;}

           /// <summary>
           /// Desc:Bonus倍率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BonusMultip {get;set;}

           /// <summary>
           /// Desc:Bonus累计
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BonusTotal {get;set;}

           /// <summary>
           /// Desc:Bunus球数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BonusSymbolNum {get;set;}

           /// <summary>
           /// Desc:Bonus新retrigger数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BonusNewRetriggerNum {get;set;}

           /// <summary>
           /// Desc:freespin剩余数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FreeSpinNum {get;set;}

           /// <summary>
           /// Desc:retrigger剩余数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RetriggerNum {get;set;}

           /// <summary>
           /// Desc:retrigger出现顺序
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? RetriggerList {get;set;}

           /// <summary>
           /// Desc:Bonus奖金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BonusWinAmount {get;set;}

           /// <summary>
           /// Desc:base是否奖励
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool BaseIsWin {get;set;}

           /// <summary>
           /// Desc:base倍率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BaseMultip {get;set;}

           /// <summary>
           /// Desc:base奖金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BaseWinAmount {get;set;}

           /// <summary>
           /// Desc:总盈利
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long TotalAmount {get;set;}

           /// <summary>
           /// Desc:抽取的组合ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long SlotItemID {get;set;}

           /// <summary>
           /// Desc:状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
