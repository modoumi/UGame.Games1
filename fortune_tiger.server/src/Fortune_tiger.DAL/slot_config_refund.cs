using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_tiger.DAL
{
    ///<summary>
    ///Atest用户标签配置
    ///</summary>
    [SugarTable("slot_config_refund")]
    public partial class Slot_config_refundPO
    {
           public Slot_config_refundPO(){

            this.SpecialModeCD =0d;
            this.NewExtraRefund =0;

           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ReundID {get;set;}

           /// <summary>
           /// Desc:下注抽水不进入奖池的额度（用之前写死的也可以，做成可以配置的也可以）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public double BetRate {get;set;}

           /// <summary>
           /// Desc:下注之后进入输返奖池的额度
           /// Default:
           /// Nullable:False
           /// </summary>           
           public double RefundPotRate {get;set;}

           /// <summary>
           /// Desc:小游戏冷却回合数，仅在当日连续随机到小游戏铺满的时候判断是否满足CD，如果跨日和小游戏随机到未铺满的话，则不判断
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public double SpecialModeCD {get;set;}

           /// <summary>
           /// Desc:新用户不触发小游戏的累计轮数（非当日轮数），前面100轮不执行小游戏触发几率，或者触发了再判断是否满足手数，否则退回去重新执行一次非小游戏的随机
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int NewMinigameRound {get;set;}

           /// <summary>
           /// Desc:新用户不触发输返工具的累计轮数（非当日轮数），前面50轮不会触发，超出轮数之后才开始开始走工具触发表的round累计循环行为，在那之前工具触发表的round数量不用开始计算
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int NewRefundRound {get;set;}

           /// <summary>
           /// Desc:用户默认的输返工具触发次数，直到用完为止，当有默认次数和每日次数的时候，优先消耗每日次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int NewExtraRefund {get;set;}

           /// <summary>
           /// Desc:小玩法轴1
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Weight_Free2 {get;set;}

    }
}
