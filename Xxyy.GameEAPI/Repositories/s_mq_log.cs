using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Xxyy.DAL
{
    ///<summary>
    ///mq执行异常日志
    ///</summary>
    [SugarTable("s_mq_log")]
    public partial class S_mq_logPO
    {
           public S_mq_logPO(){

            this.MessageLevel =0;
            this.Status =0;
            this.RecDate =DateTime.Now;
            this.RepublishDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:MQ异常日志编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string MQLogID {get;set;}

           /// <summary>
           /// Desc:消费类类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ConsumerType {get;set;}

           /// <summary>
           /// Desc:消息类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? MessageType {get;set;}

           /// <summary>
           /// Desc:消息数据
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? MessageData {get;set;}

           /// <summary>
           /// Desc:消息ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? MessageId {get;set;}

           /// <summary>
           /// Desc:异常Action
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ActionName {get;set;}

           /// <summary>
           /// Desc:异常Action描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ActionDesc {get;set;}

           /// <summary>
           /// Desc:异常消息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Exception {get;set;}

           /// <summary>
           /// Desc:项目名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ProjectId {get;set;}

           /// <summary>
           /// Desc:消息级别（无效）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int MessageLevel {get;set;}

           /// <summary>
           /// Desc:消息状态（0-初始异常1-已重新发送）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

           /// <summary>
           /// Desc:重新发布时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? RepublishDate {get;set;}

    }
}
