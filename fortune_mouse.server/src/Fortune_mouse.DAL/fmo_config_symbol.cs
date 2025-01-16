using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_mouse.DAL
{
    ///<summary>
    ///图标ICON权重表
    ///</summary>
    [SugarTable("fmo_config_symbol")]
    public partial class Fmo_config_symbolPO
    {
           public Fmo_config_symbolPO(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int SymbolID {get;set;}

           /// <summary>
           /// Desc:1-普通,2-万能
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int SymbolType {get;set;}

           /// <summary>
           /// Desc:图标名字
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SymbolName {get;set;}

           /// <summary>
           /// Desc:图标ICON权重
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Weight {get;set;}

           /// <summary>
           /// Desc:图标ICON基础倍率
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Multip {get;set;}

    }
}
