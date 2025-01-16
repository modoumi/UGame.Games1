using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///Bonus中奖权重
    ///</summary>
    [SugarTable("gmf_bonus_weight")]
    public partial class Gmf_bonus_weightPO
    {
           public Gmf_bonus_weightPO(){


           }
           /// <summary>
           /// Desc:编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int WeightID {get;set;}

           /// <summary>
           /// Desc:bonus图标出现数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int SymbolNum {get;set;}

           /// <summary>
           /// Desc:倍数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Multip {get;set;}

           /// <summary>
           /// Desc:权重
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Weight {get;set;}

    }
}
