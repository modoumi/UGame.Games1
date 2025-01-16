using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("gmf_return_pool")]
    public partial class Gmf_return_poolPO
    {
           public Gmf_return_poolPO(){

            this.Value =0;

           }
           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:货币编码（ISO 4217大写）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Value {get;set;}

    }
}
