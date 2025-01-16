using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("gmf_retrigger_weight")]
    public partial class Gmf_retrigger_weightPO
    {
           public Gmf_retrigger_weightPO(){


           }
           /// <summary>
           /// Desc:数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int RetriggerNum {get;set;}

           /// <summary>
           /// Desc:权重
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Weight {get;set;}

    }
}
