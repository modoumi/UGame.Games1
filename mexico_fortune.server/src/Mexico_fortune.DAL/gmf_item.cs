using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("gmf_item")]
    public partial class Gmf_itemPO
    {
           public Gmf_itemPO(){

            this.Multip =0;
            this.BonusNum =0;
            this.BingoNum =0;
            this.LineNum =0;

           }
           /// <summary>
           /// Desc:项编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long ItemID {get;set;}

           /// <summary>
           /// Desc:倍率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Multip {get;set;}

           /// <summary>
           /// Desc:Bonus（数量）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BonusNum {get;set;}

           /// <summary>
           /// Desc:Bingo图标数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BingoNum {get;set;}

           /// <summary>
           /// Desc:中奖线数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int LineNum {get;set;}

    }
}
