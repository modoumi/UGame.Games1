using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_tiger.DAL
{
    ///<summary>
    ///Atest用户标签配置
    ///</summary>
    [SugarTable("slot_config_refund_weight")]
    public partial class Slot_config_refund_weightPO
    {
           public Slot_config_refund_weightPO(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int WeightID {get;set;}

           /// <summary>
           /// Desc:倍数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public double Multiple {get;set;}

           /// <summary>
           /// Desc:权重
           /// Default:
           /// Nullable:False
           /// </summary>           
           public double Weight {get;set;}

    }
}
