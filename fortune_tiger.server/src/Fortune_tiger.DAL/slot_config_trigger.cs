using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_tiger.DAL
{
    ///<summary>
    ///Atest用户标签配置
    ///</summary>
    [SugarTable("slot_config_trigger")]
    public partial class Slot_config_triggerPO
    {
           public Slot_config_triggerPO(){

            this.TriggerRate =0d;

           }
           /// <summary>
           /// Desc:1-N，手数，在离开newRefundRound的限制之后，不断积累，每一次触发不管最后是否扣除次数真实发奖，都会将round重置下一次继续从1开始
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int Round {get;set;}

           /// <summary>
           /// Desc:0-1，触发几率，1=100%触发，用户每一次游戏
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public double TriggerRate {get;set;}

    }
}
