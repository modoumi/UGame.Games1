using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_big.DAL
{
    ///<summary>
    ///线配置表
    ///</summary>
    [SugarTable("big_config_line")]
    public partial class Big_config_linePO
    {
           public Big_config_linePO(){

            this.LineID =0;

           }
           /// <summary>
           /// Desc:线序号
           /// Default:0
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int LineID {get;set;}

           /// <summary>
           /// Desc:线坐标
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Line {get;set;}

    }
}
