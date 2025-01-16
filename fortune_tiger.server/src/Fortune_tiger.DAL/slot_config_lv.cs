using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_tiger.DAL
{
    ///<summary>
    ///Atest用户标签配置
    ///</summary>
    [SugarTable("slot_config_lv")]
    public partial class Slot_config_lvPO
    {
           public Slot_config_lvPO(){

            this.CashRate =0d;
            this.RTP =0d;

           }
           /// <summary>
           /// Desc:用户等级
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int Level {get;set;}

           /// <summary>
           /// Desc:用户在当前游戏的总下注额度
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long TotalBet {get;set;}

           /// <summary>
           /// Desc:每日的触发次数，跟默认次数在一起的时候优先消耗每日次数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long RefundLimit {get;set;}

           /// <summary>
           /// Desc:今日本金比例，用户今日首次进入游戏的时候的本金*cashRate，会用来计算第一次预期值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public double CashRate {get;set;}

           /// <summary>
           /// Desc:昨日亏损比例，用户上一次游戏的那一天亏损的比例，会用来计算预期值，如果用户上一次游戏的那一天在3天之前，就不考虑之前的亏损了
           /// Default:
           /// Nullable:False
           /// </summary>           
           public double LastLossRate {get;set;}

           /// <summary>
           /// Desc:预期值当日亏损率，round触发输返工具时筛选的2个条件之一，如果1-（余额/预期）亏损超过lossRate，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果
           /// Default:
           /// Nullable:False
           /// </summary>           
           public double LossRate {get;set;}

           /// <summary>
           /// Desc:返奖率，round触发输返工具时筛选的2个条件之一，如果当日在游戏中的TOTALREWARD/TOTALBET，小于这个配置的RTP，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public double RTP {get;set;}

    }
}
