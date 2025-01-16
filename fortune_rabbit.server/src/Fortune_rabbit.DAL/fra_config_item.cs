using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_rabbit.DAL
{
    ///<summary>
    ///图标ICON权重表
    ///</summary>
    [SugarTable("fra_config_item")]
    public partial class Fra_config_itemPO
    {
           public Fra_config_itemPO(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ItemID {get;set;}

           /// <summary>
           /// Desc:1-普通,2-万能
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int IconType {get;set;}

           /// <summary>
           /// Desc:图标名字
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ItemName {get;set;}

           /// <summary>
           /// Desc:图标ICON基础倍率
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ItemBaseMultip {get;set;}

    }
}
