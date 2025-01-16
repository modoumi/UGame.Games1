using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("gmf_paytable")]
    public partial class Gmf_paytablePO
    {
           public Gmf_paytablePO(){


           }
           /// <summary>
           /// Desc:Symbol编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int SymbolID {get;set;}

           /// <summary>
           /// Desc:数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int Count {get;set;}

           /// <summary>
           /// Desc:倍率
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Multip {get;set;}

    }
}
