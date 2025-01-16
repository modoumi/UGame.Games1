using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Super_phoenix.DAL
{
    ///<summary>
    ///下注筹码表
    ///</summary>
    [SugarTable("gsp_config_chips")]
    public partial class Gsp_config_chipsPO
    {
           public Gsp_config_chipsPO(){

            this.BetAmount =0;
            this.SingleAmount =0;
            this.LineNum =0;

           }
           /// <summary>
           /// Desc:筹码编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ChipsID {get;set;}

           /// <summary>
           /// Desc:下注金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetAmount {get;set;}

           /// <summary>
           /// Desc:单线下注金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long SingleAmount {get;set;}

           /// <summary>
           /// Desc:线数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int LineNum {get;set;}

    }
}
