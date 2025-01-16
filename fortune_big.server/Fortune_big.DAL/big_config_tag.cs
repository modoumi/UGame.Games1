using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_big.DAL
{
    ///<summary>
    ///Atest用户标签配置
    ///</summary>
    [SugarTable("big_config_tag")]
    public partial class Big_config_tagPO
    {
           public Big_config_tagPO(){

            this.SpecialModeRatio =0d;
            this.Weight_Free3 ="0";

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
           public double SpecialModeRatio {get;set;}

           /// <summary>
           /// Desc:主轴权重值
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Weight_Main {get;set;}

           /// <summary>
           /// Desc:主轴权重值
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Weight_Main2 {get;set;}

           /// <summary>
           /// Desc:小玩法轴1
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Weight_Free1 {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string Weight_Free3 {get;set;}

           /// <summary>
           /// Desc:小玩法轴1
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Weight_Free2 {get;set;}

    }
}
