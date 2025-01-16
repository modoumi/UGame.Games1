using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("gmf_config")]
    public partial class Gmf_configPO
    {
           public Gmf_configPO(){

            this.BonusTH =0f;
            this.BingoTH =0f;
            this.BingoPerValue =0f;
            this.BonusRetriggerRatio =0f;
            this.BonusBigoRatio =0f;

           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:BIG WIN中奖倍数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int BigWin {get;set;}

           /// <summary>
           /// Desc:MEGA WIN中奖倍数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int MegaWin {get;set;}

           /// <summary>
           /// Desc:SUPER WIN中奖倍数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int SuperWin {get;set;}

           /// <summary>
           /// Desc:EPIC WIN中奖倍数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int EpicWin {get;set;}

           /// <summary>
           /// Desc:bonus阈值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float BonusTH {get;set;}

           /// <summary>
           /// Desc:bingo阈值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float BingoTH {get;set;}

           /// <summary>
           /// Desc:Bingo固定价值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float BingoPerValue {get;set;}

           /// <summary>
           /// Desc:BaseName模块分配比例
           /// Default:
           /// Nullable:False
           /// </summary>           
           public float PartBaseRatio {get;set;}

           /// <summary>
           /// Desc:Bonus模块分配比例
           /// Default:
           /// Nullable:False
           /// </summary>           
           public float PartBonusRatio {get;set;}

           /// <summary>
           /// Desc:bingo模块分配比例
           /// Default:
           /// Nullable:False
           /// </summary>           
           public float PartBingoRatio {get;set;}

           /// <summary>
           /// Desc:bonus时分配超10倍部分分配给retrigger比率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float BonusRetriggerRatio {get;set;}

           /// <summary>
           /// Desc:bonus时分配超10倍部分分配给bingo比率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float BonusBigoRatio {get;set;}

    }
}
