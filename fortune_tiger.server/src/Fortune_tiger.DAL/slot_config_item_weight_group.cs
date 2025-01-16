using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_tiger.DAL
{
    ///<summary>
    ///倍率表
    ///</summary>
    [SugarTable("slot_config_item_weight_group")]
    public partial class Slot_config_item_weight_groupPO
    {
           public Slot_config_item_weight_groupPO(){

            this.FristLineNum =0;
            this.IconNum =0;
            this.IconGroup ="0";

           }
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
           /// Desc:第一此出N条线
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FristLineNum {get;set;}

           /// <summary>
           /// Desc:图标个数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int IconNum {get;set;}

           /// <summary>
           /// Desc:图标组合
           /// Default:0
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string IconGroup {get;set;}

           /// <summary>
           /// Desc:权重
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Weight {get;set;}

    }
}
