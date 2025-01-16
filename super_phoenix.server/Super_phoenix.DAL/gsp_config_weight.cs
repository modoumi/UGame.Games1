using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Super_phoenix.DAL
{
    ///<summary>
    ///所有奖池权重
    ///</summary>
    [SugarTable("gsp_config_weight")]
    public partial class Gsp_config_weightPO
    {
           public Gsp_config_weightPO(){

            this.Weight1 =0;
            this.Weight2 =0;
            this.Weight3 =0;
            this.Weight4 =0;
            this.Weight5 =0;

           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ItemID {get;set;}

           /// <summary>
           /// Desc:权重类型列0-2列,1-3列,2-4列,3-主游戏
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ItemType {get;set;}

           /// <summary>
           /// Desc:icon类型1-普通,2-万能,3-scatter
           /// Default:
           /// Nullable:False
           /// </summary>           
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

           /// <summary>
           /// Desc:轴4权重
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Weight4 {get;set;}

           /// <summary>
           /// Desc:轴5权重
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Weight5 {get;set;}

    }
}
