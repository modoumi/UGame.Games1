/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2024-04-10 21: 28:52
 ******************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Data;
using MySql.Data.MySqlClient;
using System.Text;
using TinyFx.Data.MySql;

namespace Xxyy.DAL
{
	#region EO
	/// <summary>
	/// mq执行异常日志
	/// 【表 s_mq_log 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_mq_logEO : IRowMapper<S_mq_logEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_mq_logEO()
		{
			this.MessageLevel = 0;
			this.Status = 0;
			this.RecDate = DateTime.Now;
			this.RepublishDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalMQLogID;
		/// <summary>
		/// 【数据库中的原始主键 MQLogID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalMQLogID
		{
			get { return _originalMQLogID; }
			set { HasOriginal = true; _originalMQLogID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "MQLogID", MQLogID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// MQ异常日志编码
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string MQLogID { get; set; }
		/// <summary>
		/// 消费类类型
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 2)]
		public string ConsumerType { get; set; }
		/// <summary>
		/// 消息类型
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 3)]
		public string MessageType { get; set; }
		/// <summary>
		/// 消息数据
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 4)]
		public string MessageData { get; set; }
		/// <summary>
		/// 消息ID
		/// 【字段 varchar(36)】
		/// </summary>
		[DataMember(Order = 5)]
		public string MessageId { get; set; }
		/// <summary>
		/// 异常Action
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 6)]
		public string ActionName { get; set; }
		/// <summary>
		/// 异常Action描述
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 7)]
		public string ActionDesc { get; set; }
		/// <summary>
		/// 异常消息
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 8)]
		public string Exception { get; set; }
		/// <summary>
		/// 项目名称
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 9)]
		public string ProjectId { get; set; }
		/// <summary>
		/// 消息级别（无效）
		/// 【字段 tinyint】
		/// </summary>
		[DataMember(Order = 10)]
		public int MessageLevel { get; set; }
		/// <summary>
		/// 消息状态（0-初始异常1-已重新发送）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int Status { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 12)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 重新发布时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 13)]
		public DateTime? RepublishDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_mq_logEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_mq_logEO MapDataReader(IDataReader reader)
		{
		    S_mq_logEO ret = new S_mq_logEO();
			ret.MQLogID = reader.ToString("MQLogID");
			ret.OriginalMQLogID = ret.MQLogID;
			ret.ConsumerType = reader.ToString("ConsumerType");
			ret.MessageType = reader.ToString("MessageType");
			ret.MessageData = reader.ToString("MessageData");
			ret.MessageId = reader.ToString("MessageId");
			ret.ActionName = reader.ToString("ActionName");
			ret.ActionDesc = reader.ToString("ActionDesc");
			ret.Exception = reader.ToString("Exception");
			ret.ProjectId = reader.ToString("ProjectId");
			ret.MessageLevel = reader.ToInt32("MessageLevel");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.RepublishDate = reader.ToDateTimeN("RepublishDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// mq执行异常日志
	/// 【表 s_mq_log 的操作类】
	/// </summary>
	[Obsolete]
	public class S_mq_logMO : MySqlTableMO<S_mq_logEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_mq_log`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_mq_logMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_mq_logMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_mq_logMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_mq_logEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_mq_logEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_mq_logEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`MQLogID`, `ConsumerType`, `MessageType`, `MessageData`, `MessageId`, `ActionName`, `ActionDesc`, `Exception`, `ProjectId`, `MessageLevel`, `Status`, `RecDate`, `RepublishDate`) VALUE (@MQLogID, @ConsumerType, @MessageType, @MessageData, @MessageId, @ActionName, @ActionDesc, @Exception, @ProjectId, @MessageLevel, @Status, @RecDate, @RepublishDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", item.MQLogID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ConsumerType", item.ConsumerType != null ? item.ConsumerType : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageType", item.MessageType != null ? item.MessageType : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageData", item.MessageData != null ? item.MessageData : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@MessageId", item.MessageId != null ? item.MessageId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActionName", item.ActionName != null ? item.ActionName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActionDesc", item.ActionDesc != null ? item.ActionDesc : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Exception", item.Exception != null ? item.Exception : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ProjectId", item.ProjectId != null ? item.ProjectId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageLevel", item.MessageLevel, MySqlDbType.Byte),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@RepublishDate", item.RepublishDate.HasValue ? item.RepublishDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<S_mq_logEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_mq_logEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_mq_logEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`MQLogID`, `ConsumerType`, `MessageType`, `MessageData`, `MessageId`, `ActionName`, `ActionDesc`, `Exception`, `ProjectId`, `MessageLevel`, `Status`, `RecDate`, `RepublishDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.MQLogID}','{item.ConsumerType}','{item.MessageType}','{item.MessageData}','{item.MessageId}','{item.ActionName}','{item.ActionDesc}','{item.Exception}','{item.ProjectId}',{item.MessageLevel},{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.RepublishDate?.ToString("yyyy-MM-dd HH:mm:ss")}'),");
				if (count == batchCount)
				{
					count = 0;
					sql.Insert(0, insertSql);
					var ret = sql.ToString().TrimEnd(',');
					sql.Clear();
	                yield return ret;
				}
			}
			if (sql.Length > 0)
			{
	            sql.Insert(0, insertSql);
	            yield return sql.ToString().TrimEnd(',');
	        }
	    }
	    #endregion // Add
	    
		#region Remove
		#region RemoveByPK
		/// <summary>
		/// 按主键删除
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string mQLogID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(mQLogID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string mQLogID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(mQLogID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string mQLogID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MQLogID` = @MQLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_mq_logEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.MQLogID, tm_);
		}
		public async Task<int> RemoveAsync(S_mq_logEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.MQLogID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByConsumerType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "consumerType">消费类类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByConsumerType(string consumerType, TransactionManager tm_ = null)
		{
			RepairRemoveByConsumerTypeData(consumerType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByConsumerTypeAsync(string consumerType, TransactionManager tm_ = null)
		{
			RepairRemoveByConsumerTypeData(consumerType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByConsumerTypeData(string consumerType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (consumerType != null ? "`ConsumerType` = @ConsumerType" : "`ConsumerType` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (consumerType != null)
				paras_.Add(Database.CreateInParameter("@ConsumerType", consumerType, MySqlDbType.VarChar));
		}
		#endregion // RemoveByConsumerType
		#region RemoveByMessageType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "messageType">消息类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMessageType(string messageType, TransactionManager tm_ = null)
		{
			RepairRemoveByMessageTypeData(messageType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMessageTypeAsync(string messageType, TransactionManager tm_ = null)
		{
			RepairRemoveByMessageTypeData(messageType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMessageTypeData(string messageType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (messageType != null ? "`MessageType` = @MessageType" : "`MessageType` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (messageType != null)
				paras_.Add(Database.CreateInParameter("@MessageType", messageType, MySqlDbType.VarChar));
		}
		#endregion // RemoveByMessageType
		#region RemoveByMessageData
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "messageData">消息数据</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMessageData(string messageData, TransactionManager tm_ = null)
		{
			RepairRemoveByMessageDataData(messageData, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMessageDataAsync(string messageData, TransactionManager tm_ = null)
		{
			RepairRemoveByMessageDataData(messageData, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMessageDataData(string messageData, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (messageData != null ? "`MessageData` = @MessageData" : "`MessageData` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (messageData != null)
				paras_.Add(Database.CreateInParameter("@MessageData", messageData, MySqlDbType.Text));
		}
		#endregion // RemoveByMessageData
		#region RemoveByMessageId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "messageId">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMessageId(string messageId, TransactionManager tm_ = null)
		{
			RepairRemoveByMessageIdData(messageId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMessageIdAsync(string messageId, TransactionManager tm_ = null)
		{
			RepairRemoveByMessageIdData(messageId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMessageIdData(string messageId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (messageId != null ? "`MessageId` = @MessageId" : "`MessageId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (messageId != null)
				paras_.Add(Database.CreateInParameter("@MessageId", messageId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByMessageId
		#region RemoveByActionName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "actionName">异常Action</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByActionName(string actionName, TransactionManager tm_ = null)
		{
			RepairRemoveByActionNameData(actionName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByActionNameAsync(string actionName, TransactionManager tm_ = null)
		{
			RepairRemoveByActionNameData(actionName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByActionNameData(string actionName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (actionName != null ? "`ActionName` = @ActionName" : "`ActionName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (actionName != null)
				paras_.Add(Database.CreateInParameter("@ActionName", actionName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByActionName
		#region RemoveByActionDesc
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "actionDesc">异常Action描述</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByActionDesc(string actionDesc, TransactionManager tm_ = null)
		{
			RepairRemoveByActionDescData(actionDesc, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByActionDescAsync(string actionDesc, TransactionManager tm_ = null)
		{
			RepairRemoveByActionDescData(actionDesc, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByActionDescData(string actionDesc, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (actionDesc != null ? "`ActionDesc` = @ActionDesc" : "`ActionDesc` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (actionDesc != null)
				paras_.Add(Database.CreateInParameter("@ActionDesc", actionDesc, MySqlDbType.VarChar));
		}
		#endregion // RemoveByActionDesc
		#region RemoveByException
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByException(string exception, TransactionManager tm_ = null)
		{
			RepairRemoveByExceptionData(exception, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByExceptionAsync(string exception, TransactionManager tm_ = null)
		{
			RepairRemoveByExceptionData(exception, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByExceptionData(string exception, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (exception != null ? "`Exception` = @Exception" : "`Exception` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (exception != null)
				paras_.Add(Database.CreateInParameter("@Exception", exception, MySqlDbType.Text));
		}
		#endregion // RemoveByException
		#region RemoveByProjectId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "projectId">项目名称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByProjectId(string projectId, TransactionManager tm_ = null)
		{
			RepairRemoveByProjectIdData(projectId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByProjectIdAsync(string projectId, TransactionManager tm_ = null)
		{
			RepairRemoveByProjectIdData(projectId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByProjectIdData(string projectId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (projectId != null ? "`ProjectId` = @ProjectId" : "`ProjectId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (projectId != null)
				paras_.Add(Database.CreateInParameter("@ProjectId", projectId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByProjectId
		#region RemoveByMessageLevel
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "messageLevel">消息级别（无效）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMessageLevel(int messageLevel, TransactionManager tm_ = null)
		{
			RepairRemoveByMessageLevelData(messageLevel, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMessageLevelAsync(int messageLevel, TransactionManager tm_ = null)
		{
			RepairRemoveByMessageLevelData(messageLevel, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMessageLevelData(int messageLevel, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MessageLevel` = @MessageLevel";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MessageLevel", messageLevel, MySqlDbType.Byte));
		}
		#endregion // RemoveByMessageLevel
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始异常1-已重新发送）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByStatus(int status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStatusAsync(int status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStatusData(int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Status` = @Status";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
		}
		#endregion // RemoveByStatus
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecDateData(DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RecDate` = @RecDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRecDate
		#region RemoveByRepublishDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "republishDate">重新发布时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRepublishDate(DateTime? republishDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRepublishDateData(republishDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRepublishDateAsync(DateTime? republishDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRepublishDateData(republishDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRepublishDateData(DateTime? republishDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (republishDate.HasValue ? "`RepublishDate` = @RepublishDate" : "`RepublishDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (republishDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RepublishDate", republishDate.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRepublishDate
		#endregion // RemoveByXXX
	    
		#region RemoveByFKOrUnique
		#endregion // RemoveByFKOrUnique
		#endregion //Remove
	    
		#region Put
		#region PutItem
		/// <summary>
		/// 更新实体到数据库
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(S_mq_logEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_mq_logEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_mq_logEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MQLogID` = @MQLogID, `ConsumerType` = @ConsumerType, `MessageType` = @MessageType, `MessageData` = @MessageData, `MessageId` = @MessageId, `ActionName` = @ActionName, `ActionDesc` = @ActionDesc, `Exception` = @Exception, `ProjectId` = @ProjectId, `MessageLevel` = @MessageLevel, `Status` = @Status WHERE `MQLogID` = @MQLogID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", item.MQLogID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ConsumerType", item.ConsumerType != null ? item.ConsumerType : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageType", item.MessageType != null ? item.MessageType : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageData", item.MessageData != null ? item.MessageData : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@MessageId", item.MessageId != null ? item.MessageId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActionName", item.ActionName != null ? item.ActionName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActionDesc", item.ActionDesc != null ? item.ActionDesc : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Exception", item.Exception != null ? item.Exception : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ProjectId", item.ProjectId != null ? item.ProjectId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageLevel", item.MessageLevel, MySqlDbType.Byte),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@MQLogID_Original", item.HasOriginal ? item.OriginalMQLogID : item.MQLogID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_mq_logEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_mq_logEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += await PutAsync(item, tm_);
			}
			return ret;
		}
		#endregion // PutItem
		
		#region PutByPK
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string mQLogID, string set_, params object[] values_)
		{
			return Put(set_, "`MQLogID` = @MQLogID", ConcatValues(values_, mQLogID));
		}
		public async Task<int> PutByPKAsync(string mQLogID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`MQLogID` = @MQLogID", ConcatValues(values_, mQLogID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string mQLogID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`MQLogID` = @MQLogID", tm_, ConcatValues(values_, mQLogID));
		}
		public async Task<int> PutByPKAsync(string mQLogID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`MQLogID` = @MQLogID", tm_, ConcatValues(values_, mQLogID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string mQLogID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`MQLogID` = @MQLogID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string mQLogID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`MQLogID` = @MQLogID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutConsumerType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// /// <param name = "consumerType">消费类类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutConsumerTypeByPK(string mQLogID, string consumerType, TransactionManager tm_ = null)
		{
			RepairPutConsumerTypeByPKData(mQLogID, consumerType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutConsumerTypeByPKAsync(string mQLogID, string consumerType, TransactionManager tm_ = null)
		{
			RepairPutConsumerTypeByPKData(mQLogID, consumerType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutConsumerTypeByPKData(string mQLogID, string consumerType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ConsumerType` = @ConsumerType  WHERE `MQLogID` = @MQLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ConsumerType", consumerType != null ? consumerType : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "consumerType">消费类类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutConsumerType(string consumerType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ConsumerType` = @ConsumerType";
			var parameter_ = Database.CreateInParameter("@ConsumerType", consumerType != null ? consumerType : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutConsumerTypeAsync(string consumerType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ConsumerType` = @ConsumerType";
			var parameter_ = Database.CreateInParameter("@ConsumerType", consumerType != null ? consumerType : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutConsumerType
		#region PutMessageType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// /// <param name = "messageType">消息类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMessageTypeByPK(string mQLogID, string messageType, TransactionManager tm_ = null)
		{
			RepairPutMessageTypeByPKData(mQLogID, messageType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMessageTypeByPKAsync(string mQLogID, string messageType, TransactionManager tm_ = null)
		{
			RepairPutMessageTypeByPKData(mQLogID, messageType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMessageTypeByPKData(string mQLogID, string messageType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MessageType` = @MessageType  WHERE `MQLogID` = @MQLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageType", messageType != null ? messageType : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "messageType">消息类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMessageType(string messageType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MessageType` = @MessageType";
			var parameter_ = Database.CreateInParameter("@MessageType", messageType != null ? messageType : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMessageTypeAsync(string messageType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MessageType` = @MessageType";
			var parameter_ = Database.CreateInParameter("@MessageType", messageType != null ? messageType : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMessageType
		#region PutMessageData
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// /// <param name = "messageData">消息数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMessageDataByPK(string mQLogID, string messageData, TransactionManager tm_ = null)
		{
			RepairPutMessageDataByPKData(mQLogID, messageData, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMessageDataByPKAsync(string mQLogID, string messageData, TransactionManager tm_ = null)
		{
			RepairPutMessageDataByPKData(mQLogID, messageData, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMessageDataByPKData(string mQLogID, string messageData, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MessageData` = @MessageData  WHERE `MQLogID` = @MQLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageData", messageData != null ? messageData : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "messageData">消息数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMessageData(string messageData, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MessageData` = @MessageData";
			var parameter_ = Database.CreateInParameter("@MessageData", messageData != null ? messageData : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMessageDataAsync(string messageData, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MessageData` = @MessageData";
			var parameter_ = Database.CreateInParameter("@MessageData", messageData != null ? messageData : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMessageData
		#region PutMessageId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// /// <param name = "messageId">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMessageIdByPK(string mQLogID, string messageId, TransactionManager tm_ = null)
		{
			RepairPutMessageIdByPKData(mQLogID, messageId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMessageIdByPKAsync(string mQLogID, string messageId, TransactionManager tm_ = null)
		{
			RepairPutMessageIdByPKData(mQLogID, messageId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMessageIdByPKData(string mQLogID, string messageId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MessageId` = @MessageId  WHERE `MQLogID` = @MQLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageId", messageId != null ? messageId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "messageId">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMessageId(string messageId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MessageId` = @MessageId";
			var parameter_ = Database.CreateInParameter("@MessageId", messageId != null ? messageId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMessageIdAsync(string messageId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MessageId` = @MessageId";
			var parameter_ = Database.CreateInParameter("@MessageId", messageId != null ? messageId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMessageId
		#region PutActionName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// /// <param name = "actionName">异常Action</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActionNameByPK(string mQLogID, string actionName, TransactionManager tm_ = null)
		{
			RepairPutActionNameByPKData(mQLogID, actionName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutActionNameByPKAsync(string mQLogID, string actionName, TransactionManager tm_ = null)
		{
			RepairPutActionNameByPKData(mQLogID, actionName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutActionNameByPKData(string mQLogID, string actionName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ActionName` = @ActionName  WHERE `MQLogID` = @MQLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActionName", actionName != null ? actionName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "actionName">异常Action</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActionName(string actionName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActionName` = @ActionName";
			var parameter_ = Database.CreateInParameter("@ActionName", actionName != null ? actionName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutActionNameAsync(string actionName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActionName` = @ActionName";
			var parameter_ = Database.CreateInParameter("@ActionName", actionName != null ? actionName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutActionName
		#region PutActionDesc
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// /// <param name = "actionDesc">异常Action描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActionDescByPK(string mQLogID, string actionDesc, TransactionManager tm_ = null)
		{
			RepairPutActionDescByPKData(mQLogID, actionDesc, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutActionDescByPKAsync(string mQLogID, string actionDesc, TransactionManager tm_ = null)
		{
			RepairPutActionDescByPKData(mQLogID, actionDesc, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutActionDescByPKData(string mQLogID, string actionDesc, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ActionDesc` = @ActionDesc  WHERE `MQLogID` = @MQLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActionDesc", actionDesc != null ? actionDesc : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "actionDesc">异常Action描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActionDesc(string actionDesc, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActionDesc` = @ActionDesc";
			var parameter_ = Database.CreateInParameter("@ActionDesc", actionDesc != null ? actionDesc : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutActionDescAsync(string actionDesc, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActionDesc` = @ActionDesc";
			var parameter_ = Database.CreateInParameter("@ActionDesc", actionDesc != null ? actionDesc : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutActionDesc
		#region PutException
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// /// <param name = "exception">异常消息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutExceptionByPK(string mQLogID, string exception, TransactionManager tm_ = null)
		{
			RepairPutExceptionByPKData(mQLogID, exception, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutExceptionByPKAsync(string mQLogID, string exception, TransactionManager tm_ = null)
		{
			RepairPutExceptionByPKData(mQLogID, exception, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutExceptionByPKData(string mQLogID, string exception, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Exception` = @Exception  WHERE `MQLogID` = @MQLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Exception", exception != null ? exception : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutException(string exception, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Exception` = @Exception";
			var parameter_ = Database.CreateInParameter("@Exception", exception != null ? exception : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutExceptionAsync(string exception, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Exception` = @Exception";
			var parameter_ = Database.CreateInParameter("@Exception", exception != null ? exception : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutException
		#region PutProjectId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// /// <param name = "projectId">项目名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProjectIdByPK(string mQLogID, string projectId, TransactionManager tm_ = null)
		{
			RepairPutProjectIdByPKData(mQLogID, projectId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProjectIdByPKAsync(string mQLogID, string projectId, TransactionManager tm_ = null)
		{
			RepairPutProjectIdByPKData(mQLogID, projectId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProjectIdByPKData(string mQLogID, string projectId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProjectId` = @ProjectId  WHERE `MQLogID` = @MQLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProjectId", projectId != null ? projectId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "projectId">项目名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProjectId(string projectId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProjectId` = @ProjectId";
			var parameter_ = Database.CreateInParameter("@ProjectId", projectId != null ? projectId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutProjectIdAsync(string projectId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProjectId` = @ProjectId";
			var parameter_ = Database.CreateInParameter("@ProjectId", projectId != null ? projectId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutProjectId
		#region PutMessageLevel
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// /// <param name = "messageLevel">消息级别（无效）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMessageLevelByPK(string mQLogID, int messageLevel, TransactionManager tm_ = null)
		{
			RepairPutMessageLevelByPKData(mQLogID, messageLevel, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMessageLevelByPKAsync(string mQLogID, int messageLevel, TransactionManager tm_ = null)
		{
			RepairPutMessageLevelByPKData(mQLogID, messageLevel, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMessageLevelByPKData(string mQLogID, int messageLevel, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MessageLevel` = @MessageLevel  WHERE `MQLogID` = @MQLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageLevel", messageLevel, MySqlDbType.Byte),
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "messageLevel">消息级别（无效）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMessageLevel(int messageLevel, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MessageLevel` = @MessageLevel";
			var parameter_ = Database.CreateInParameter("@MessageLevel", messageLevel, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMessageLevelAsync(int messageLevel, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MessageLevel` = @MessageLevel";
			var parameter_ = Database.CreateInParameter("@MessageLevel", messageLevel, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMessageLevel
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// /// <param name = "status">消息状态（0-初始异常1-已重新发送）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string mQLogID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(mQLogID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string mQLogID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(mQLogID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string mQLogID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `MQLogID` = @MQLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始异常1-已重新发送）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatus(int status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStatusAsync(int status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutStatus
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string mQLogID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(mQLogID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string mQLogID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(mQLogID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string mQLogID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `MQLogID` = @MQLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRecDate
		#region PutRepublishDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// /// <param name = "republishDate">重新发布时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRepublishDateByPK(string mQLogID, DateTime? republishDate, TransactionManager tm_ = null)
		{
			RepairPutRepublishDateByPKData(mQLogID, republishDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRepublishDateByPKAsync(string mQLogID, DateTime? republishDate, TransactionManager tm_ = null)
		{
			RepairPutRepublishDateByPKData(mQLogID, republishDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRepublishDateByPKData(string mQLogID, DateTime? republishDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RepublishDate` = @RepublishDate  WHERE `MQLogID` = @MQLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RepublishDate", republishDate.HasValue ? republishDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "republishDate">重新发布时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRepublishDate(DateTime? republishDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RepublishDate` = @RepublishDate";
			var parameter_ = Database.CreateInParameter("@RepublishDate", republishDate.HasValue ? republishDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRepublishDateAsync(DateTime? republishDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RepublishDate` = @RepublishDate";
			var parameter_ = Database.CreateInParameter("@RepublishDate", republishDate.HasValue ? republishDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRepublishDate
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_mq_logEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.MQLogID) == null)
			{
				Add(item, tm);
			}
			else
			{
				Put(item, tm);
				ret = false;
			}
			return ret;
		}
		public async Task<bool> SetAsync(S_mq_logEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.MQLogID) == null)
			{
				await AddAsync(item, tm);
			}
			else
			{
				await PutAsync(item, tm);
				ret = false;
			}
			return ret;
		}
		
		#endregion // Set
		
		#region Get
		#region GetByPK
		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_mq_logEO GetByPK(string mQLogID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(mQLogID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		public async Task<S_mq_logEO> GetByPKAsync(string mQLogID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(mQLogID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		private void RepairGetByPKData(string mQLogID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`MQLogID` = @MQLogID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 ConsumerType（字段）
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetConsumerTypeByPK(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ConsumerType`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		public async Task<string> GetConsumerTypeByPKAsync(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ConsumerType`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MessageType（字段）
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMessageTypeByPK(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`MessageType`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		public async Task<string> GetMessageTypeByPKAsync(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`MessageType`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MessageData（字段）
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMessageDataByPK(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`MessageData`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		public async Task<string> GetMessageDataByPKAsync(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`MessageData`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MessageId（字段）
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMessageIdByPK(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`MessageId`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		public async Task<string> GetMessageIdByPKAsync(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`MessageId`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ActionName（字段）
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetActionNameByPK(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ActionName`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		public async Task<string> GetActionNameByPKAsync(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ActionName`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ActionDesc（字段）
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetActionDescByPK(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ActionDesc`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		public async Task<string> GetActionDescByPKAsync(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ActionDesc`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Exception（字段）
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetExceptionByPK(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Exception`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		public async Task<string> GetExceptionByPKAsync(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Exception`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ProjectId（字段）
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetProjectIdByPK(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ProjectId`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		public async Task<string> GetProjectIdByPKAsync(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ProjectId`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MessageLevel（字段）
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMessageLevelByPK(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`MessageLevel`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		public async Task<int> GetMessageLevelByPKAsync(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`MessageLevel`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RepublishDate（字段）
		/// </summary>
		/// /// <param name = "mQLogID">MQ异常日志编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetRepublishDateByPK(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`RepublishDate`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		public async Task<DateTime?> GetRepublishDateByPKAsync(string mQLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MQLogID", mQLogID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`RepublishDate`", "`MQLogID` = @MQLogID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByConsumerType
		
		/// <summary>
		/// 按 ConsumerType（字段） 查询
		/// </summary>
		/// /// <param name = "consumerType">消费类类型</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByConsumerType(string consumerType)
		{
			return GetByConsumerType(consumerType, 0, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByConsumerTypeAsync(string consumerType)
		{
			return await GetByConsumerTypeAsync(consumerType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ConsumerType（字段） 查询
		/// </summary>
		/// /// <param name = "consumerType">消费类类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByConsumerType(string consumerType, TransactionManager tm_)
		{
			return GetByConsumerType(consumerType, 0, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByConsumerTypeAsync(string consumerType, TransactionManager tm_)
		{
			return await GetByConsumerTypeAsync(consumerType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ConsumerType（字段） 查询
		/// </summary>
		/// /// <param name = "consumerType">消费类类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByConsumerType(string consumerType, int top_)
		{
			return GetByConsumerType(consumerType, top_, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByConsumerTypeAsync(string consumerType, int top_)
		{
			return await GetByConsumerTypeAsync(consumerType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ConsumerType（字段） 查询
		/// </summary>
		/// /// <param name = "consumerType">消费类类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByConsumerType(string consumerType, int top_, TransactionManager tm_)
		{
			return GetByConsumerType(consumerType, top_, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByConsumerTypeAsync(string consumerType, int top_, TransactionManager tm_)
		{
			return await GetByConsumerTypeAsync(consumerType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ConsumerType（字段） 查询
		/// </summary>
		/// /// <param name = "consumerType">消费类类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByConsumerType(string consumerType, string sort_)
		{
			return GetByConsumerType(consumerType, 0, sort_, null);
		}
		public async Task<List<S_mq_logEO>> GetByConsumerTypeAsync(string consumerType, string sort_)
		{
			return await GetByConsumerTypeAsync(consumerType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ConsumerType（字段） 查询
		/// </summary>
		/// /// <param name = "consumerType">消费类类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByConsumerType(string consumerType, string sort_, TransactionManager tm_)
		{
			return GetByConsumerType(consumerType, 0, sort_, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByConsumerTypeAsync(string consumerType, string sort_, TransactionManager tm_)
		{
			return await GetByConsumerTypeAsync(consumerType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ConsumerType（字段） 查询
		/// </summary>
		/// /// <param name = "consumerType">消费类类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByConsumerType(string consumerType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(consumerType != null ? "`ConsumerType` = @ConsumerType" : "`ConsumerType` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (consumerType != null)
				paras_.Add(Database.CreateInParameter("@ConsumerType", consumerType, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		public async Task<List<S_mq_logEO>> GetByConsumerTypeAsync(string consumerType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(consumerType != null ? "`ConsumerType` = @ConsumerType" : "`ConsumerType` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (consumerType != null)
				paras_.Add(Database.CreateInParameter("@ConsumerType", consumerType, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		#endregion // GetByConsumerType
		#region GetByMessageType
		
		/// <summary>
		/// 按 MessageType（字段） 查询
		/// </summary>
		/// /// <param name = "messageType">消息类型</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageType(string messageType)
		{
			return GetByMessageType(messageType, 0, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByMessageTypeAsync(string messageType)
		{
			return await GetByMessageTypeAsync(messageType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MessageType（字段） 查询
		/// </summary>
		/// /// <param name = "messageType">消息类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageType(string messageType, TransactionManager tm_)
		{
			return GetByMessageType(messageType, 0, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByMessageTypeAsync(string messageType, TransactionManager tm_)
		{
			return await GetByMessageTypeAsync(messageType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MessageType（字段） 查询
		/// </summary>
		/// /// <param name = "messageType">消息类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageType(string messageType, int top_)
		{
			return GetByMessageType(messageType, top_, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByMessageTypeAsync(string messageType, int top_)
		{
			return await GetByMessageTypeAsync(messageType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MessageType（字段） 查询
		/// </summary>
		/// /// <param name = "messageType">消息类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageType(string messageType, int top_, TransactionManager tm_)
		{
			return GetByMessageType(messageType, top_, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByMessageTypeAsync(string messageType, int top_, TransactionManager tm_)
		{
			return await GetByMessageTypeAsync(messageType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MessageType（字段） 查询
		/// </summary>
		/// /// <param name = "messageType">消息类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageType(string messageType, string sort_)
		{
			return GetByMessageType(messageType, 0, sort_, null);
		}
		public async Task<List<S_mq_logEO>> GetByMessageTypeAsync(string messageType, string sort_)
		{
			return await GetByMessageTypeAsync(messageType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MessageType（字段） 查询
		/// </summary>
		/// /// <param name = "messageType">消息类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageType(string messageType, string sort_, TransactionManager tm_)
		{
			return GetByMessageType(messageType, 0, sort_, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByMessageTypeAsync(string messageType, string sort_, TransactionManager tm_)
		{
			return await GetByMessageTypeAsync(messageType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MessageType（字段） 查询
		/// </summary>
		/// /// <param name = "messageType">消息类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageType(string messageType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(messageType != null ? "`MessageType` = @MessageType" : "`MessageType` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (messageType != null)
				paras_.Add(Database.CreateInParameter("@MessageType", messageType, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		public async Task<List<S_mq_logEO>> GetByMessageTypeAsync(string messageType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(messageType != null ? "`MessageType` = @MessageType" : "`MessageType` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (messageType != null)
				paras_.Add(Database.CreateInParameter("@MessageType", messageType, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		#endregion // GetByMessageType
		#region GetByMessageData
		
		/// <summary>
		/// 按 MessageData（字段） 查询
		/// </summary>
		/// /// <param name = "messageData">消息数据</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageData(string messageData)
		{
			return GetByMessageData(messageData, 0, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByMessageDataAsync(string messageData)
		{
			return await GetByMessageDataAsync(messageData, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MessageData（字段） 查询
		/// </summary>
		/// /// <param name = "messageData">消息数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageData(string messageData, TransactionManager tm_)
		{
			return GetByMessageData(messageData, 0, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByMessageDataAsync(string messageData, TransactionManager tm_)
		{
			return await GetByMessageDataAsync(messageData, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MessageData（字段） 查询
		/// </summary>
		/// /// <param name = "messageData">消息数据</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageData(string messageData, int top_)
		{
			return GetByMessageData(messageData, top_, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByMessageDataAsync(string messageData, int top_)
		{
			return await GetByMessageDataAsync(messageData, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MessageData（字段） 查询
		/// </summary>
		/// /// <param name = "messageData">消息数据</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageData(string messageData, int top_, TransactionManager tm_)
		{
			return GetByMessageData(messageData, top_, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByMessageDataAsync(string messageData, int top_, TransactionManager tm_)
		{
			return await GetByMessageDataAsync(messageData, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MessageData（字段） 查询
		/// </summary>
		/// /// <param name = "messageData">消息数据</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageData(string messageData, string sort_)
		{
			return GetByMessageData(messageData, 0, sort_, null);
		}
		public async Task<List<S_mq_logEO>> GetByMessageDataAsync(string messageData, string sort_)
		{
			return await GetByMessageDataAsync(messageData, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MessageData（字段） 查询
		/// </summary>
		/// /// <param name = "messageData">消息数据</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageData(string messageData, string sort_, TransactionManager tm_)
		{
			return GetByMessageData(messageData, 0, sort_, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByMessageDataAsync(string messageData, string sort_, TransactionManager tm_)
		{
			return await GetByMessageDataAsync(messageData, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MessageData（字段） 查询
		/// </summary>
		/// /// <param name = "messageData">消息数据</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageData(string messageData, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(messageData != null ? "`MessageData` = @MessageData" : "`MessageData` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (messageData != null)
				paras_.Add(Database.CreateInParameter("@MessageData", messageData, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		public async Task<List<S_mq_logEO>> GetByMessageDataAsync(string messageData, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(messageData != null ? "`MessageData` = @MessageData" : "`MessageData` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (messageData != null)
				paras_.Add(Database.CreateInParameter("@MessageData", messageData, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		#endregion // GetByMessageData
		#region GetByMessageId
		
		/// <summary>
		/// 按 MessageId（字段） 查询
		/// </summary>
		/// /// <param name = "messageId">消息ID</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageId(string messageId)
		{
			return GetByMessageId(messageId, 0, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByMessageIdAsync(string messageId)
		{
			return await GetByMessageIdAsync(messageId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MessageId（字段） 查询
		/// </summary>
		/// /// <param name = "messageId">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageId(string messageId, TransactionManager tm_)
		{
			return GetByMessageId(messageId, 0, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByMessageIdAsync(string messageId, TransactionManager tm_)
		{
			return await GetByMessageIdAsync(messageId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MessageId（字段） 查询
		/// </summary>
		/// /// <param name = "messageId">消息ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageId(string messageId, int top_)
		{
			return GetByMessageId(messageId, top_, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByMessageIdAsync(string messageId, int top_)
		{
			return await GetByMessageIdAsync(messageId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MessageId（字段） 查询
		/// </summary>
		/// /// <param name = "messageId">消息ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageId(string messageId, int top_, TransactionManager tm_)
		{
			return GetByMessageId(messageId, top_, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByMessageIdAsync(string messageId, int top_, TransactionManager tm_)
		{
			return await GetByMessageIdAsync(messageId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MessageId（字段） 查询
		/// </summary>
		/// /// <param name = "messageId">消息ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageId(string messageId, string sort_)
		{
			return GetByMessageId(messageId, 0, sort_, null);
		}
		public async Task<List<S_mq_logEO>> GetByMessageIdAsync(string messageId, string sort_)
		{
			return await GetByMessageIdAsync(messageId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MessageId（字段） 查询
		/// </summary>
		/// /// <param name = "messageId">消息ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageId(string messageId, string sort_, TransactionManager tm_)
		{
			return GetByMessageId(messageId, 0, sort_, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByMessageIdAsync(string messageId, string sort_, TransactionManager tm_)
		{
			return await GetByMessageIdAsync(messageId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MessageId（字段） 查询
		/// </summary>
		/// /// <param name = "messageId">消息ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageId(string messageId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(messageId != null ? "`MessageId` = @MessageId" : "`MessageId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (messageId != null)
				paras_.Add(Database.CreateInParameter("@MessageId", messageId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		public async Task<List<S_mq_logEO>> GetByMessageIdAsync(string messageId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(messageId != null ? "`MessageId` = @MessageId" : "`MessageId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (messageId != null)
				paras_.Add(Database.CreateInParameter("@MessageId", messageId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		#endregion // GetByMessageId
		#region GetByActionName
		
		/// <summary>
		/// 按 ActionName（字段） 查询
		/// </summary>
		/// /// <param name = "actionName">异常Action</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByActionName(string actionName)
		{
			return GetByActionName(actionName, 0, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByActionNameAsync(string actionName)
		{
			return await GetByActionNameAsync(actionName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActionName（字段） 查询
		/// </summary>
		/// /// <param name = "actionName">异常Action</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByActionName(string actionName, TransactionManager tm_)
		{
			return GetByActionName(actionName, 0, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByActionNameAsync(string actionName, TransactionManager tm_)
		{
			return await GetByActionNameAsync(actionName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActionName（字段） 查询
		/// </summary>
		/// /// <param name = "actionName">异常Action</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByActionName(string actionName, int top_)
		{
			return GetByActionName(actionName, top_, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByActionNameAsync(string actionName, int top_)
		{
			return await GetByActionNameAsync(actionName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActionName（字段） 查询
		/// </summary>
		/// /// <param name = "actionName">异常Action</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByActionName(string actionName, int top_, TransactionManager tm_)
		{
			return GetByActionName(actionName, top_, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByActionNameAsync(string actionName, int top_, TransactionManager tm_)
		{
			return await GetByActionNameAsync(actionName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActionName（字段） 查询
		/// </summary>
		/// /// <param name = "actionName">异常Action</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByActionName(string actionName, string sort_)
		{
			return GetByActionName(actionName, 0, sort_, null);
		}
		public async Task<List<S_mq_logEO>> GetByActionNameAsync(string actionName, string sort_)
		{
			return await GetByActionNameAsync(actionName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ActionName（字段） 查询
		/// </summary>
		/// /// <param name = "actionName">异常Action</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByActionName(string actionName, string sort_, TransactionManager tm_)
		{
			return GetByActionName(actionName, 0, sort_, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByActionNameAsync(string actionName, string sort_, TransactionManager tm_)
		{
			return await GetByActionNameAsync(actionName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ActionName（字段） 查询
		/// </summary>
		/// /// <param name = "actionName">异常Action</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByActionName(string actionName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(actionName != null ? "`ActionName` = @ActionName" : "`ActionName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (actionName != null)
				paras_.Add(Database.CreateInParameter("@ActionName", actionName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		public async Task<List<S_mq_logEO>> GetByActionNameAsync(string actionName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(actionName != null ? "`ActionName` = @ActionName" : "`ActionName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (actionName != null)
				paras_.Add(Database.CreateInParameter("@ActionName", actionName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		#endregion // GetByActionName
		#region GetByActionDesc
		
		/// <summary>
		/// 按 ActionDesc（字段） 查询
		/// </summary>
		/// /// <param name = "actionDesc">异常Action描述</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByActionDesc(string actionDesc)
		{
			return GetByActionDesc(actionDesc, 0, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByActionDescAsync(string actionDesc)
		{
			return await GetByActionDescAsync(actionDesc, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActionDesc（字段） 查询
		/// </summary>
		/// /// <param name = "actionDesc">异常Action描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByActionDesc(string actionDesc, TransactionManager tm_)
		{
			return GetByActionDesc(actionDesc, 0, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByActionDescAsync(string actionDesc, TransactionManager tm_)
		{
			return await GetByActionDescAsync(actionDesc, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActionDesc（字段） 查询
		/// </summary>
		/// /// <param name = "actionDesc">异常Action描述</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByActionDesc(string actionDesc, int top_)
		{
			return GetByActionDesc(actionDesc, top_, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByActionDescAsync(string actionDesc, int top_)
		{
			return await GetByActionDescAsync(actionDesc, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActionDesc（字段） 查询
		/// </summary>
		/// /// <param name = "actionDesc">异常Action描述</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByActionDesc(string actionDesc, int top_, TransactionManager tm_)
		{
			return GetByActionDesc(actionDesc, top_, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByActionDescAsync(string actionDesc, int top_, TransactionManager tm_)
		{
			return await GetByActionDescAsync(actionDesc, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActionDesc（字段） 查询
		/// </summary>
		/// /// <param name = "actionDesc">异常Action描述</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByActionDesc(string actionDesc, string sort_)
		{
			return GetByActionDesc(actionDesc, 0, sort_, null);
		}
		public async Task<List<S_mq_logEO>> GetByActionDescAsync(string actionDesc, string sort_)
		{
			return await GetByActionDescAsync(actionDesc, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ActionDesc（字段） 查询
		/// </summary>
		/// /// <param name = "actionDesc">异常Action描述</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByActionDesc(string actionDesc, string sort_, TransactionManager tm_)
		{
			return GetByActionDesc(actionDesc, 0, sort_, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByActionDescAsync(string actionDesc, string sort_, TransactionManager tm_)
		{
			return await GetByActionDescAsync(actionDesc, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ActionDesc（字段） 查询
		/// </summary>
		/// /// <param name = "actionDesc">异常Action描述</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByActionDesc(string actionDesc, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(actionDesc != null ? "`ActionDesc` = @ActionDesc" : "`ActionDesc` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (actionDesc != null)
				paras_.Add(Database.CreateInParameter("@ActionDesc", actionDesc, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		public async Task<List<S_mq_logEO>> GetByActionDescAsync(string actionDesc, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(actionDesc != null ? "`ActionDesc` = @ActionDesc" : "`ActionDesc` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (actionDesc != null)
				paras_.Add(Database.CreateInParameter("@ActionDesc", actionDesc, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		#endregion // GetByActionDesc
		#region GetByException
		
		/// <summary>
		/// 按 Exception（字段） 查询
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByException(string exception)
		{
			return GetByException(exception, 0, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByExceptionAsync(string exception)
		{
			return await GetByExceptionAsync(exception, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Exception（字段） 查询
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByException(string exception, TransactionManager tm_)
		{
			return GetByException(exception, 0, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByExceptionAsync(string exception, TransactionManager tm_)
		{
			return await GetByExceptionAsync(exception, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Exception（字段） 查询
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByException(string exception, int top_)
		{
			return GetByException(exception, top_, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByExceptionAsync(string exception, int top_)
		{
			return await GetByExceptionAsync(exception, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Exception（字段） 查询
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByException(string exception, int top_, TransactionManager tm_)
		{
			return GetByException(exception, top_, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByExceptionAsync(string exception, int top_, TransactionManager tm_)
		{
			return await GetByExceptionAsync(exception, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Exception（字段） 查询
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByException(string exception, string sort_)
		{
			return GetByException(exception, 0, sort_, null);
		}
		public async Task<List<S_mq_logEO>> GetByExceptionAsync(string exception, string sort_)
		{
			return await GetByExceptionAsync(exception, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Exception（字段） 查询
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByException(string exception, string sort_, TransactionManager tm_)
		{
			return GetByException(exception, 0, sort_, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByExceptionAsync(string exception, string sort_, TransactionManager tm_)
		{
			return await GetByExceptionAsync(exception, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Exception（字段） 查询
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByException(string exception, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(exception != null ? "`Exception` = @Exception" : "`Exception` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (exception != null)
				paras_.Add(Database.CreateInParameter("@Exception", exception, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		public async Task<List<S_mq_logEO>> GetByExceptionAsync(string exception, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(exception != null ? "`Exception` = @Exception" : "`Exception` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (exception != null)
				paras_.Add(Database.CreateInParameter("@Exception", exception, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		#endregion // GetByException
		#region GetByProjectId
		
		/// <summary>
		/// 按 ProjectId（字段） 查询
		/// </summary>
		/// /// <param name = "projectId">项目名称</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByProjectId(string projectId)
		{
			return GetByProjectId(projectId, 0, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByProjectIdAsync(string projectId)
		{
			return await GetByProjectIdAsync(projectId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProjectId（字段） 查询
		/// </summary>
		/// /// <param name = "projectId">项目名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByProjectId(string projectId, TransactionManager tm_)
		{
			return GetByProjectId(projectId, 0, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByProjectIdAsync(string projectId, TransactionManager tm_)
		{
			return await GetByProjectIdAsync(projectId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProjectId（字段） 查询
		/// </summary>
		/// /// <param name = "projectId">项目名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByProjectId(string projectId, int top_)
		{
			return GetByProjectId(projectId, top_, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByProjectIdAsync(string projectId, int top_)
		{
			return await GetByProjectIdAsync(projectId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProjectId（字段） 查询
		/// </summary>
		/// /// <param name = "projectId">项目名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByProjectId(string projectId, int top_, TransactionManager tm_)
		{
			return GetByProjectId(projectId, top_, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByProjectIdAsync(string projectId, int top_, TransactionManager tm_)
		{
			return await GetByProjectIdAsync(projectId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProjectId（字段） 查询
		/// </summary>
		/// /// <param name = "projectId">项目名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByProjectId(string projectId, string sort_)
		{
			return GetByProjectId(projectId, 0, sort_, null);
		}
		public async Task<List<S_mq_logEO>> GetByProjectIdAsync(string projectId, string sort_)
		{
			return await GetByProjectIdAsync(projectId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ProjectId（字段） 查询
		/// </summary>
		/// /// <param name = "projectId">项目名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByProjectId(string projectId, string sort_, TransactionManager tm_)
		{
			return GetByProjectId(projectId, 0, sort_, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByProjectIdAsync(string projectId, string sort_, TransactionManager tm_)
		{
			return await GetByProjectIdAsync(projectId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ProjectId（字段） 查询
		/// </summary>
		/// /// <param name = "projectId">项目名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByProjectId(string projectId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(projectId != null ? "`ProjectId` = @ProjectId" : "`ProjectId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (projectId != null)
				paras_.Add(Database.CreateInParameter("@ProjectId", projectId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		public async Task<List<S_mq_logEO>> GetByProjectIdAsync(string projectId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(projectId != null ? "`ProjectId` = @ProjectId" : "`ProjectId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (projectId != null)
				paras_.Add(Database.CreateInParameter("@ProjectId", projectId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		#endregion // GetByProjectId
		#region GetByMessageLevel
		
		/// <summary>
		/// 按 MessageLevel（字段） 查询
		/// </summary>
		/// /// <param name = "messageLevel">消息级别（无效）</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageLevel(int messageLevel)
		{
			return GetByMessageLevel(messageLevel, 0, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByMessageLevelAsync(int messageLevel)
		{
			return await GetByMessageLevelAsync(messageLevel, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MessageLevel（字段） 查询
		/// </summary>
		/// /// <param name = "messageLevel">消息级别（无效）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageLevel(int messageLevel, TransactionManager tm_)
		{
			return GetByMessageLevel(messageLevel, 0, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByMessageLevelAsync(int messageLevel, TransactionManager tm_)
		{
			return await GetByMessageLevelAsync(messageLevel, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MessageLevel（字段） 查询
		/// </summary>
		/// /// <param name = "messageLevel">消息级别（无效）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageLevel(int messageLevel, int top_)
		{
			return GetByMessageLevel(messageLevel, top_, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByMessageLevelAsync(int messageLevel, int top_)
		{
			return await GetByMessageLevelAsync(messageLevel, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MessageLevel（字段） 查询
		/// </summary>
		/// /// <param name = "messageLevel">消息级别（无效）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageLevel(int messageLevel, int top_, TransactionManager tm_)
		{
			return GetByMessageLevel(messageLevel, top_, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByMessageLevelAsync(int messageLevel, int top_, TransactionManager tm_)
		{
			return await GetByMessageLevelAsync(messageLevel, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MessageLevel（字段） 查询
		/// </summary>
		/// /// <param name = "messageLevel">消息级别（无效）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageLevel(int messageLevel, string sort_)
		{
			return GetByMessageLevel(messageLevel, 0, sort_, null);
		}
		public async Task<List<S_mq_logEO>> GetByMessageLevelAsync(int messageLevel, string sort_)
		{
			return await GetByMessageLevelAsync(messageLevel, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MessageLevel（字段） 查询
		/// </summary>
		/// /// <param name = "messageLevel">消息级别（无效）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageLevel(int messageLevel, string sort_, TransactionManager tm_)
		{
			return GetByMessageLevel(messageLevel, 0, sort_, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByMessageLevelAsync(int messageLevel, string sort_, TransactionManager tm_)
		{
			return await GetByMessageLevelAsync(messageLevel, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MessageLevel（字段） 查询
		/// </summary>
		/// /// <param name = "messageLevel">消息级别（无效）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByMessageLevel(int messageLevel, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MessageLevel` = @MessageLevel", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MessageLevel", messageLevel, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		public async Task<List<S_mq_logEO>> GetByMessageLevelAsync(int messageLevel, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MessageLevel` = @MessageLevel", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MessageLevel", messageLevel, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		#endregion // GetByMessageLevel
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始异常1-已重新发送）</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始异常1-已重新发送）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始异常1-已重新发送）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByStatusAsync(int status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始异常1-已重新发送）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始异常1-已重新发送）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<S_mq_logEO>> GetByStatusAsync(int status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始异常1-已重新发送）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始异常1-已重新发送）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		public async Task<List<S_mq_logEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<S_mq_logEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		public async Task<List<S_mq_logEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByRepublishDate
		
		/// <summary>
		/// 按 RepublishDate（字段） 查询
		/// </summary>
		/// /// <param name = "republishDate">重新发布时间</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByRepublishDate(DateTime? republishDate)
		{
			return GetByRepublishDate(republishDate, 0, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByRepublishDateAsync(DateTime? republishDate)
		{
			return await GetByRepublishDateAsync(republishDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RepublishDate（字段） 查询
		/// </summary>
		/// /// <param name = "republishDate">重新发布时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByRepublishDate(DateTime? republishDate, TransactionManager tm_)
		{
			return GetByRepublishDate(republishDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByRepublishDateAsync(DateTime? republishDate, TransactionManager tm_)
		{
			return await GetByRepublishDateAsync(republishDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RepublishDate（字段） 查询
		/// </summary>
		/// /// <param name = "republishDate">重新发布时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByRepublishDate(DateTime? republishDate, int top_)
		{
			return GetByRepublishDate(republishDate, top_, string.Empty, null);
		}
		public async Task<List<S_mq_logEO>> GetByRepublishDateAsync(DateTime? republishDate, int top_)
		{
			return await GetByRepublishDateAsync(republishDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RepublishDate（字段） 查询
		/// </summary>
		/// /// <param name = "republishDate">重新发布时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByRepublishDate(DateTime? republishDate, int top_, TransactionManager tm_)
		{
			return GetByRepublishDate(republishDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByRepublishDateAsync(DateTime? republishDate, int top_, TransactionManager tm_)
		{
			return await GetByRepublishDateAsync(republishDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RepublishDate（字段） 查询
		/// </summary>
		/// /// <param name = "republishDate">重新发布时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByRepublishDate(DateTime? republishDate, string sort_)
		{
			return GetByRepublishDate(republishDate, 0, sort_, null);
		}
		public async Task<List<S_mq_logEO>> GetByRepublishDateAsync(DateTime? republishDate, string sort_)
		{
			return await GetByRepublishDateAsync(republishDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RepublishDate（字段） 查询
		/// </summary>
		/// /// <param name = "republishDate">重新发布时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByRepublishDate(DateTime? republishDate, string sort_, TransactionManager tm_)
		{
			return GetByRepublishDate(republishDate, 0, sort_, tm_);
		}
		public async Task<List<S_mq_logEO>> GetByRepublishDateAsync(DateTime? republishDate, string sort_, TransactionManager tm_)
		{
			return await GetByRepublishDateAsync(republishDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RepublishDate（字段） 查询
		/// </summary>
		/// /// <param name = "republishDate">重新发布时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_mq_logEO> GetByRepublishDate(DateTime? republishDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(republishDate.HasValue ? "`RepublishDate` = @RepublishDate" : "`RepublishDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (republishDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RepublishDate", republishDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		public async Task<List<S_mq_logEO>> GetByRepublishDateAsync(DateTime? republishDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(republishDate.HasValue ? "`RepublishDate` = @RepublishDate" : "`RepublishDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (republishDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RepublishDate", republishDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_mq_logEO.MapDataReader);
		}
		#endregion // GetByRepublishDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
