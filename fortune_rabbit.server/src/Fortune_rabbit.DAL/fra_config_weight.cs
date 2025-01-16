using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_rabbit.DAL
{
    ///<summary>
    ///所有奖池权重
    ///</summary>
    [SugarTable("fra_config_weight")]
    public partial class Fra_config_weightPO
    {
           public Fra_config_weightPO(){

            this.Weight1 =0;
            this.Weight2 =0;
            this.Weight3 =0;

           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ItemID {get;set;}

           /// <summary>
           /// Desc:icon类型1-普通,2-万能
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int IconType {get;set;}

           /// <summary>
           /// Desc:轴1权重
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Weight1 {get;set;}

           /// <summary>
           /// Desc:轴2权重
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Weight2 {get;set;}

           /// <summary>
           /// Desc:轴3权重
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Weight3 {get;set;}

    }
}
