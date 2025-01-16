using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///倍数权重
    ///</summary>
    [SugarTable("gmf_multip_weight")]
    public partial class Gmf_multip_weightPO
    {
           public Gmf_multip_weightPO(){

            this.HitRatio =0d;

           }
           /// <summary>
           /// Desc:最大占位数（含）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int SNum {get;set;}

           /// <summary>
           /// Desc:倍数
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int Multip {get;set;}

           /// <summary>
           /// Desc:权重
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Weight {get;set;}

           /// <summary>
           /// Desc:中奖率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public double HitRatio {get;set;}

    }
}
