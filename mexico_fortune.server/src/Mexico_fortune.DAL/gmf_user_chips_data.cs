using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///用户游戏数据，根据chipId保存
    ///</summary>
    [SugarTable("gmf_user_chips_data")]
    public partial class Gmf_user_chips_dataPO
    {
           public Gmf_user_chips_dataPO(){

            this.BingoTotal =0;
            this.BingoLock =0;
            this.BingoHitLine =0;
            this.BingoKeepNum =0;
            this.BonusTotal =0;
            this.BonusLock =0;
            this.FreeSpinNum =0;
            this.RetriggerNum =0;
            this.FreeSpinAmount =0;
            this.BaseLock =0;
            this.Status =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:用户编码(GUID)
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

           /// <summary>
           /// Desc:筹码编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ChipsID {get;set;}

           /// <summary>
           /// Desc:Bingo累计
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BingoTotal {get;set;}

           /// <summary>
           /// Desc:Bingo部分锁定金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BingoLock {get;set;}

           /// <summary>
           /// Desc:Bingo面板的25个球,按顺序|分割
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
           /// Desc:Bingo已出的75个数字,按顺序|分割
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? BingoHasNums {get;set;}

           /// <summary>
           /// Desc:Bonus累计
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BonusTotal {get;set;}

           /// <summary>
           /// Desc:Bonus部分锁定金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BonusLock {get;set;}

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
           /// Desc:freespin环节总盈利
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long FreeSpinAmount {get;set;}

           /// <summary>
           /// Desc:base部分锁定金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BaseLock {get;set;}

           /// <summary>
           /// Desc:最后一次slot明细编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? SlotID {get;set;}

           /// <summary>
           /// Desc:状态1-正常2-锁定中3-异常用户账户错误
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
