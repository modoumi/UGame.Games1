using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_tiger.DAL
{
    ///<summary>
    ///图标ICON权重表
    ///</summary>
    [SugarTable("slot_config_item")]
    public partial class Slot_config_itemPO
    {
           public Slot_config_itemPO(){


           }
           /// <summary>
           /// Desc:appid
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string AppID {get;set;}

           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ItemID {get;set;}

           /// <summary>
           /// Desc:奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int PoolType {get;set;}

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
           /// Desc:图标ICON权重
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ItemWeight {get;set;}

           /// <summary>
           /// Desc:图标ICON基础倍率
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ItemBaseMultip {get;set;}

    }
}
