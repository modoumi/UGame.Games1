using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Xxyy.DAL
{
    public partial class S_mq_logPO
    {
        #region tinyfx
        public static implicit operator S_mq_logEO(S_mq_logPO value)
        {
            if (value==null) return null;
            return new S_mq_logEO
            {
		        MQLogID = value.MQLogID,
		        ConsumerType = value.ConsumerType,
		        MessageType = value.MessageType,
		        MessageData = value.MessageData,
		        MessageId = value.MessageId,
		        ActionName = value.ActionName,
		        ActionDesc = value.ActionDesc,
		        Exception = value.Exception,
		        ProjectId = value.ProjectId,
		        MessageLevel = value.MessageLevel,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        RepublishDate = value.RepublishDate,
            };
        }
        public static implicit operator S_mq_logPO(S_mq_logEO value)
        {
            if (value==null) return null;
            return new S_mq_logPO
            {
		        MQLogID = value.MQLogID,
		        ConsumerType = value.ConsumerType,
		        MessageType = value.MessageType,
		        MessageData = value.MessageData,
		        MessageId = value.MessageId,
		        ActionName = value.ActionName,
		        ActionDesc = value.ActionDesc,
		        Exception = value.Exception,
		        ProjectId = value.ProjectId,
		        MessageLevel = value.MessageLevel,
		        Status = value.Status,
		        RecDate = value.RecDate,
		        RepublishDate = value.RepublishDate,
            };
        }
        #endregion
    }
}