using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_tiger.DAL
{
    ///<summary>
    ///Atest用户标签配置
    ///</summary>
    [SugarTable("slot_config_tag")]
    public partial class Slot_config_tagPO
    {
           public Slot_config_tagPO(){

            this.SpecialModeRatio ="0";
            this.Memo ="0";

           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int BID {get;set;}

           /// <summary>
           /// Desc:用户标签下注额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long BetAmount {get;set;}

           /// <summary>
           /// Desc:用户标签下注额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long BetAmountEnd {get;set;}

           /// <summary>
           /// Desc:特殊玩法进入概率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string SpecialModeRatio {get;set;}

           /// <summary>
           /// Desc:主轴权重值
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string WeightList {get;set;}

           /// <summary>
           /// Desc:小玩法随机图标
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string RandomSymbol {get;set;}

           /// <summary>
           /// Desc:小玩法随机图标对应的倍数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string RandomSymbolMultip {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string Memo {get;set;}

    }
}
