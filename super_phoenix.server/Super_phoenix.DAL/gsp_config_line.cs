using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Super_phoenix.DAL
{
    ///<summary>
    ///线配置表
    ///</summary>
    [SugarTable("gsp_config_line")]
    public partial class Gsp_config_linePO
    {
           public Gsp_config_linePO(){

            this.LineNo =0;

           }
           /// <summary>
           /// Desc:线序号
           /// Default:0
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int LineNo {get;set;}

           /// <summary>
           /// Desc:线坐标
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Line {get;set;}

    }
}
