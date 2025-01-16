using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///下注筹码表
    ///</summary>
    [SugarTable("gmf_chips")]
    public partial class Gmf_chipsPO
    {
           public Gmf_chipsPO(){

            this.BetMoney =0d;
            this.JPMini =0;
            this.JPMinor =0;
            this.JPMajor =0;
            this.JPGrand =0;

           }
           /// <summary>
           /// Desc:筹码编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ChipsID {get;set;}

           /// <summary>
           /// Desc:货币编码（ISO 4217大写）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:下注金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public double BetMoney {get;set;}

           /// <summary>
           /// Desc:jackpot奖池Mini
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int JPMini {get;set;}

           /// <summary>
           /// Desc:jackpot奖池Minor
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int JPMinor {get;set;}

           /// <summary>
           /// Desc:jackpot奖池Major
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int JPMajor {get;set;}

           /// <summary>
           /// Desc:jackpot奖池Grand
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int JPGrand {get;set;}

    }
}
