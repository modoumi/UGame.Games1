using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_tiger.DAL
{
    ///<summary>
    ///倍率表
    ///</summary>
    [SugarTable("slot_config_hhsw")]
    public partial class Slot_config_hhswPO
    {
           public Slot_config_hhswPO(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int HhswID {get;set;}

           /// <summary>
           /// Desc:中了几条线
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int LineNum {get;set;}

           /// <summary>
           /// Desc:线ID集合
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string LineNoArr {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? IconGroup {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Memo {get;set;}

    }
}
