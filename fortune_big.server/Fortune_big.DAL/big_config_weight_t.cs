using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_big.DAL
{
    ///<summary>
    ///所有奖池权重
    ///</summary>
    [SugarTable("big_config_weight_t")]
    public partial class Big_config_weight_tPO
    {
           public Big_config_weight_tPO(){

            this.Weight_Main =0;
            this.Weight_SM =0;
            this.Multip =0f;

           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int TID {get;set;}

           /// <summary>
           /// Desc:普通玩法权重
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Weight_Main {get;set;}

           /// <summary>
           /// Desc:特殊玩法权重
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Weight_SM {get;set;}

           /// <summary>
           /// Desc:倍率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float Multip {get;set;}

    }
}
