using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///Bingo刷球数量
    ///</summary>
    [SugarTable("gmf_bingo_num_weight")]
    public partial class Gmf_bingo_num_weightPO
    {
           public Gmf_bingo_num_weightPO(){


           }
           /// <summary>
           /// Desc:出球数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int BingoNum {get;set;}

           /// <summary>
           /// Desc:权重
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Weight {get;set;}

    }
}
