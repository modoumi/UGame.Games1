using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///Bingo奖励倍数权重
    ///</summary>
    [SugarTable("gmf_bingo_weight")]
    public partial class Gmf_bingo_weightPO
    {
           public Gmf_bingo_weightPO(){


           }
           /// <summary>
           /// Desc:奖池类型编码1-mini2-minor3-major4-grand
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int JPPoolID {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Name {get;set;}

           /// <summary>
           /// Desc:倍率（无效）
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
