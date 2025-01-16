/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-11-08 15: 50:56
 ******************************************************/
using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.Serialization;
using System.Text;
using TinyFx.Data;
using TinyFx.Data.MySql;

namespace Xxyy.DAL
{
    #region EO
    /// <summary>
    /// 客户端上传数据日志
    /// 【表 s_client_log 的实体类】
    /// </summary>
    [DataContract]
    public class S_client_logEO : IRowMapper<S_client_logEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public S_client_logEO()
        {
            this.LogType = 0;
            this.Success = false;
            this.RecDate = DateTime.Now;
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private string _originalLogID;
        /// <summary>
        /// 【数据库中的原始主键 LogID 值的副本，用于主键值更新】
        /// </summary>
        public string OriginalLogID
        {
            get { return _originalLogID; }
            set { HasOriginal = true; _originalLogID = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "LogID", LogID }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// 主键GUID
        /// 【主键 varchar(38)】
        /// </summary>
        [DataMember(Order = 1)]
        public string LogID { get; set; }
        /// <summary>
        /// 应用编码
        /// 【字段 varchar(50)】
        /// </summary>
        [DataMember(Order = 2)]
        public string AppID { get; set; }
        /// <summary>
        /// 运营商编码
        /// 【字段 varchar(50)】
        /// </summary>
        [DataMember(Order = 3)]
        public string OperatorID { get; set; }
        /// <summary>
        /// 用户编码
        /// 【字段 varchar(38)】
        /// </summary>
        [DataMember(Order = 4)]
        public string UserID { get; set; }
        /// <summary>
        /// 日志类型:0-未知1-客户端日志2-api返回3-socket返回
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 5)]
        public int LogType { get; set; }
        /// <summary>
        /// 上传对象json数据
        /// 【字段 text】
        /// </summary>
        [DataMember(Order = 6)]
        public string LogData { get; set; }
        /// <summary>
        /// URL
        /// 【字段 varchar(250)】
        /// </summary>
        [DataMember(Order = 7)]
        public string Url { get; set; }
        /// <summary>
        /// 是否成功
        /// 【字段 tinyint(1)】
        /// </summary>
        [DataMember(Order = 8)]
        public bool Success { get; set; }
        /// <summary>
        /// 编码
        /// 【字段 varchar(50)】
        /// </summary>
        [DataMember(Order = 9)]
        public string Code { get; set; }
        /// <summary>
        /// 消息
        /// 【字段 text】
        /// </summary>
        [DataMember(Order = 10)]
        public string Message { get; set; }
        /// <summary>
        /// 结果
        /// 【字段 text】
        /// </summary>
        [DataMember(Order = 11)]
        public string Result { get; set; }
        /// <summary>
        /// 异常
        /// 【字段 text】
        /// </summary>
        [DataMember(Order = 12)]
        public string Exception { get; set; }
        /// <summary>
        /// 记录时间
        /// 【字段 datetime】
        /// </summary>
        [DataMember(Order = 13)]
        public DateTime RecDate { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public S_client_logEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static S_client_logEO MapDataReader(IDataReader reader)
        {
            S_client_logEO ret = new S_client_logEO();
            ret.LogID = reader.ToString("LogID");
            ret.OriginalLogID = ret.LogID;
            ret.AppID = reader.ToString("AppID");
            ret.OperatorID = reader.ToString("OperatorID");
            ret.UserID = reader.ToString("UserID");
            ret.LogType = reader.ToInt32("LogType");
            ret.LogData = reader.ToString("LogData");
            ret.Url = reader.ToString("Url");
            ret.Success = reader.ToBoolean("Success");
            ret.Code = reader.ToString("Code");
            ret.Message = reader.ToString("Message");
            ret.Result = reader.ToString("Result");
            ret.Exception = reader.ToString("Exception");
            ret.RecDate = reader.ToDateTime("RecDate");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// 客户端上传数据日志
    /// 【表 s_client_log 的操作类】
    /// </summary>
    public class S_client_logMO : MySqlTableMO<S_client_logEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`s_client_log`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public S_client_logMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public S_client_logMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public S_client_logMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(S_client_logEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(S_client_logEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(S_client_logEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`LogID`, `AppID`, `OperatorID`, `UserID`, `LogType`, `LogData`, `Url`, `Success`, `Code`, `Message`, `Result`, `Exception`, `RecDate`) VALUE (@LogID, @AppID, @OperatorID, @UserID, @LogType, @LogData, @Url, @Success, @Code, @Message, @Result, @Exception, @RecDate);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", item.LogID, MySqlDbType.VarChar),
                Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@UserID", item.UserID != null ? item.UserID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@LogType", item.LogType, MySqlDbType.Byte),
                Database.CreateInParameter("@LogData", item.LogData != null ? item.LogData : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@Url", item.Url != null ? item.Url : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@Success", item.Success, MySqlDbType.Byte),
                Database.CreateInParameter("@Code", item.Code != null ? item.Code : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@Message", item.Message != null ? item.Message : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@Result", item.Result != null ? item.Result : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@Exception", item.Exception != null ? item.Exception : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
            };
        }
        public int AddByBatch(IEnumerable<S_client_logEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<S_client_logEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_client_logEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`LogID`, `AppID`, `OperatorID`, `UserID`, `LogType`, `LogData`, `Url`, `Success`, `Code`, `Message`, `Result`, `Exception`, `RecDate`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"('{item.LogID}','{item.AppID}','{item.OperatorID}','{item.UserID}',{item.LogType},'{item.LogData}','{item.Url}',{item.Success},'{item.Code}','{item.Message}','{item.Result}','{item.Exception}','{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
        /// /// <param name = "logID">主键GUID</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(string logID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(logID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(string logID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(logID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(string logID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(S_client_logEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.LogID, tm_);
        }
        public async Task<int> RemoveAsync(S_client_logEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.LogID, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
        #region RemoveByAppID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "appID">应用编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByAppID(string appID, TransactionManager tm_ = null)
        {
            RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByAppIDAsync(string appID, TransactionManager tm_ = null)
        {
            RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByAppIDData(string appID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (appID != null)
                paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
        }
        #endregion // RemoveByAppID
        #region RemoveByOperatorID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByOperatorID(string operatorID, TransactionManager tm_ = null)
        {
            RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
        {
            RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByOperatorIDData(string operatorID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (operatorID != null)
                paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
        }
        #endregion // RemoveByOperatorID
        #region RemoveByUserID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "userID">用户编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByUserID(string userID, TransactionManager tm_ = null)
        {
            RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByUserIDAsync(string userID, TransactionManager tm_ = null)
        {
            RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByUserIDData(string userID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (userID != null)
                paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
        }
        #endregion // RemoveByUserID
        #region RemoveByLogType
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "logType">日志类型:0-未知1-客户端日志2-api返回3-socket返回</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByLogType(int logType, TransactionManager tm_ = null)
        {
            RepairRemoveByLogTypeData(logType, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByLogTypeAsync(int logType, TransactionManager tm_ = null)
        {
            RepairRemoveByLogTypeData(logType, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByLogTypeData(int logType, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `LogType` = @LogType";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@LogType", logType, MySqlDbType.Byte));
        }
        #endregion // RemoveByLogType
        #region RemoveByLogData
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "logData">上传对象json数据</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByLogData(string logData, TransactionManager tm_ = null)
        {
            RepairRemoveByLogDataData(logData, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByLogDataAsync(string logData, TransactionManager tm_ = null)
        {
            RepairRemoveByLogDataData(logData, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByLogDataData(string logData, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (logData != null ? "`LogData` = @LogData" : "`LogData` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (logData != null)
                paras_.Add(Database.CreateInParameter("@LogData", logData, MySqlDbType.Text));
        }
        #endregion // RemoveByLogData
        #region RemoveByUrl
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "url">URL</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByUrl(string url, TransactionManager tm_ = null)
        {
            RepairRemoveByUrlData(url, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByUrlAsync(string url, TransactionManager tm_ = null)
        {
            RepairRemoveByUrlData(url, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByUrlData(string url, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (url != null ? "`Url` = @Url" : "`Url` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (url != null)
                paras_.Add(Database.CreateInParameter("@Url", url, MySqlDbType.VarChar));
        }
        #endregion // RemoveByUrl
        #region RemoveBySuccess
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "success">是否成功</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveBySuccess(bool success, TransactionManager tm_ = null)
        {
            RepairRemoveBySuccessData(success, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveBySuccessAsync(bool success, TransactionManager tm_ = null)
        {
            RepairRemoveBySuccessData(success, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveBySuccessData(bool success, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Success` = @Success";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Success", success, MySqlDbType.Byte));
        }
        #endregion // RemoveBySuccess
        #region RemoveByCode
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "code">编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByCode(string code, TransactionManager tm_ = null)
        {
            RepairRemoveByCodeData(code, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByCodeAsync(string code, TransactionManager tm_ = null)
        {
            RepairRemoveByCodeData(code, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByCodeData(string code, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (code != null ? "`Code` = @Code" : "`Code` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (code != null)
                paras_.Add(Database.CreateInParameter("@Code", code, MySqlDbType.VarChar));
        }
        #endregion // RemoveByCode
        #region RemoveByMessage
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "message">消息</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByMessage(string message, TransactionManager tm_ = null)
        {
            RepairRemoveByMessageData(message, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByMessageAsync(string message, TransactionManager tm_ = null)
        {
            RepairRemoveByMessageData(message, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByMessageData(string message, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (message != null ? "`Message` = @Message" : "`Message` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (message != null)
                paras_.Add(Database.CreateInParameter("@Message", message, MySqlDbType.Text));
        }
        #endregion // RemoveByMessage
        #region RemoveByResult
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "result">结果</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByResult(string result, TransactionManager tm_ = null)
        {
            RepairRemoveByResultData(result, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByResultAsync(string result, TransactionManager tm_ = null)
        {
            RepairRemoveByResultData(result, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByResultData(string result, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (result != null ? "`Result` = @Result" : "`Result` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (result != null)
                paras_.Add(Database.CreateInParameter("@Result", result, MySqlDbType.Text));
        }
        #endregion // RemoveByResult
        #region RemoveByException
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "exception">异常</param>
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
        public int Put(S_client_logEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(S_client_logEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(S_client_logEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `LogID` = @LogID, `AppID` = @AppID, `OperatorID` = @OperatorID, `UserID` = @UserID, `LogType` = @LogType, `LogData` = @LogData, `Url` = @Url, `Success` = @Success, `Code` = @Code, `Message` = @Message, `Result` = @Result, `Exception` = @Exception WHERE `LogID` = @LogID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", item.LogID, MySqlDbType.VarChar),
                Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@UserID", item.UserID != null ? item.UserID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@LogType", item.LogType, MySqlDbType.Byte),
                Database.CreateInParameter("@LogData", item.LogData != null ? item.LogData : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@Url", item.Url != null ? item.Url : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@Success", item.Success, MySqlDbType.Byte),
                Database.CreateInParameter("@Code", item.Code != null ? item.Code : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@Message", item.Message != null ? item.Message : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@Result", item.Result != null ? item.Result : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@Exception", item.Exception != null ? item.Exception : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@LogID_Original", item.HasOriginal ? item.OriginalLogID : item.LogID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<S_client_logEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<S_client_logEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "logID">主键GUID</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string logID, string set_, params object[] values_)
        {
            return Put(set_, "`LogID` = @LogID", ConcatValues(values_, logID));
        }
        public async Task<int> PutByPKAsync(string logID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`LogID` = @LogID", ConcatValues(values_, logID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string logID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`LogID` = @LogID", tm_, ConcatValues(values_, logID));
        }
        public async Task<int> PutByPKAsync(string logID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`LogID` = @LogID", tm_, ConcatValues(values_, logID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string logID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return Put(set_, "`LogID` = @LogID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(string logID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return await PutAsync(set_, "`LogID` = @LogID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutAppID
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// /// <param name = "appID">应用编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutAppIDByPK(string logID, string appID, TransactionManager tm_ = null)
        {
            RepairPutAppIDByPKData(logID, appID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAppIDByPKAsync(string logID, string appID, TransactionManager tm_ = null)
        {
            RepairPutAppIDByPKData(logID, appID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutAppIDByPKData(string logID, string appID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `AppID` = @AppID  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "appID">应用编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutAppID(string appID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
            var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutAppIDAsync(string appID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
            var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutAppID
        #region PutOperatorID
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutOperatorIDByPK(string logID, string operatorID, TransactionManager tm_ = null)
        {
            RepairPutOperatorIDByPKData(logID, operatorID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutOperatorIDByPKAsync(string logID, string operatorID, TransactionManager tm_ = null)
        {
            RepairPutOperatorIDByPKData(logID, operatorID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutOperatorIDByPKData(string logID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutOperatorID(string operatorID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
            var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
            var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutOperatorID
        #region PutUserID
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// /// <param name = "userID">用户编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutUserIDByPK(string logID, string userID, TransactionManager tm_ = null)
        {
            RepairPutUserIDByPKData(logID, userID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutUserIDByPKAsync(string logID, string userID, TransactionManager tm_ = null)
        {
            RepairPutUserIDByPKData(logID, userID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutUserIDByPKData(string logID, string userID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `UserID` = @UserID  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "userID">用户编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutUserID(string userID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
            var parameter_ = Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutUserIDAsync(string userID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
            var parameter_ = Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutUserID
        #region PutLogType
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// /// <param name = "logType">日志类型:0-未知1-客户端日志2-api返回3-socket返回</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutLogTypeByPK(string logID, int logType, TransactionManager tm_ = null)
        {
            RepairPutLogTypeByPKData(logID, logType, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutLogTypeByPKAsync(string logID, int logType, TransactionManager tm_ = null)
        {
            RepairPutLogTypeByPKData(logID, logType, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutLogTypeByPKData(string logID, int logType, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `LogType` = @LogType  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogType", logType, MySqlDbType.Byte),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "logType">日志类型:0-未知1-客户端日志2-api返回3-socket返回</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutLogType(int logType, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `LogType` = @LogType";
            var parameter_ = Database.CreateInParameter("@LogType", logType, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutLogTypeAsync(int logType, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `LogType` = @LogType";
            var parameter_ = Database.CreateInParameter("@LogType", logType, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutLogType
        #region PutLogData
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// /// <param name = "logData">上传对象json数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutLogDataByPK(string logID, string logData, TransactionManager tm_ = null)
        {
            RepairPutLogDataByPKData(logID, logData, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutLogDataByPKAsync(string logID, string logData, TransactionManager tm_ = null)
        {
            RepairPutLogDataByPKData(logID, logData, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutLogDataByPKData(string logID, string logData, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `LogData` = @LogData  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogData", logData != null ? logData : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "logData">上传对象json数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutLogData(string logData, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `LogData` = @LogData";
            var parameter_ = Database.CreateInParameter("@LogData", logData != null ? logData : (object)DBNull.Value, MySqlDbType.Text);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutLogDataAsync(string logData, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `LogData` = @LogData";
            var parameter_ = Database.CreateInParameter("@LogData", logData != null ? logData : (object)DBNull.Value, MySqlDbType.Text);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutLogData
        #region PutUrl
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// /// <param name = "url">URL</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutUrlByPK(string logID, string url, TransactionManager tm_ = null)
        {
            RepairPutUrlByPKData(logID, url, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutUrlByPKAsync(string logID, string url, TransactionManager tm_ = null)
        {
            RepairPutUrlByPKData(logID, url, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutUrlByPKData(string logID, string url, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Url` = @Url  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Url", url != null ? url : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "url">URL</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutUrl(string url, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Url` = @Url";
            var parameter_ = Database.CreateInParameter("@Url", url != null ? url : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutUrlAsync(string url, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Url` = @Url";
            var parameter_ = Database.CreateInParameter("@Url", url != null ? url : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutUrl
        #region PutSuccess
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// /// <param name = "success">是否成功</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSuccessByPK(string logID, bool success, TransactionManager tm_ = null)
        {
            RepairPutSuccessByPKData(logID, success, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutSuccessByPKAsync(string logID, bool success, TransactionManager tm_ = null)
        {
            RepairPutSuccessByPKData(logID, success, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutSuccessByPKData(string logID, bool success, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Success` = @Success  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Success", success, MySqlDbType.Byte),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "success">是否成功</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSuccess(bool success, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Success` = @Success";
            var parameter_ = Database.CreateInParameter("@Success", success, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutSuccessAsync(bool success, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Success` = @Success";
            var parameter_ = Database.CreateInParameter("@Success", success, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutSuccess
        #region PutCode
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// /// <param name = "code">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutCodeByPK(string logID, string code, TransactionManager tm_ = null)
        {
            RepairPutCodeByPKData(logID, code, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutCodeByPKAsync(string logID, string code, TransactionManager tm_ = null)
        {
            RepairPutCodeByPKData(logID, code, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutCodeByPKData(string logID, string code, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Code` = @Code  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Code", code != null ? code : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "code">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutCode(string code, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Code` = @Code";
            var parameter_ = Database.CreateInParameter("@Code", code != null ? code : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutCodeAsync(string code, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Code` = @Code";
            var parameter_ = Database.CreateInParameter("@Code", code != null ? code : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutCode
        #region PutMessage
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// /// <param name = "message">消息</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutMessageByPK(string logID, string message, TransactionManager tm_ = null)
        {
            RepairPutMessageByPKData(logID, message, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutMessageByPKAsync(string logID, string message, TransactionManager tm_ = null)
        {
            RepairPutMessageByPKData(logID, message, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutMessageByPKData(string logID, string message, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Message` = @Message  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Message", message != null ? message : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "message">消息</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutMessage(string message, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Message` = @Message";
            var parameter_ = Database.CreateInParameter("@Message", message != null ? message : (object)DBNull.Value, MySqlDbType.Text);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutMessageAsync(string message, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Message` = @Message";
            var parameter_ = Database.CreateInParameter("@Message", message != null ? message : (object)DBNull.Value, MySqlDbType.Text);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutMessage
        #region PutResult
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// /// <param name = "result">结果</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutResultByPK(string logID, string result, TransactionManager tm_ = null)
        {
            RepairPutResultByPKData(logID, result, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutResultByPKAsync(string logID, string result, TransactionManager tm_ = null)
        {
            RepairPutResultByPKData(logID, result, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutResultByPKData(string logID, string result, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Result` = @Result  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Result", result != null ? result : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "result">结果</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutResult(string result, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Result` = @Result";
            var parameter_ = Database.CreateInParameter("@Result", result != null ? result : (object)DBNull.Value, MySqlDbType.Text);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutResultAsync(string result, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Result` = @Result";
            var parameter_ = Database.CreateInParameter("@Result", result != null ? result : (object)DBNull.Value, MySqlDbType.Text);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutResult
        #region PutException
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// /// <param name = "exception">异常</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutExceptionByPK(string logID, string exception, TransactionManager tm_ = null)
        {
            RepairPutExceptionByPKData(logID, exception, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutExceptionByPKAsync(string logID, string exception, TransactionManager tm_ = null)
        {
            RepairPutExceptionByPKData(logID, exception, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutExceptionByPKData(string logID, string exception, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Exception` = @Exception  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Exception", exception != null ? exception : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "exception">异常</param>
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
        #region PutRecDate
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRecDateByPK(string logID, DateTime recDate, TransactionManager tm_ = null)
        {
            RepairPutRecDateByPKData(logID, recDate, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRecDateByPKAsync(string logID, DateTime recDate, TransactionManager tm_ = null)
        {
            RepairPutRecDateByPKData(logID, recDate, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRecDateByPKData(string logID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
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
        #endregion // PutXXX
        #endregion // Put

        #region Set

        /// <summary>
        /// 插入或者更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>true:插入操作；false:更新操作</return>
        public bool Set(S_client_logEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.LogID) == null)
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
        public async Task<bool> SetAsync(S_client_logEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.LogID) == null)
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
        /// /// <param name = "logID">主键GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public S_client_logEO GetByPK(string logID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(logID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        public async Task<S_client_logEO> GetByPKAsync(string logID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(logID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        private void RepairGetByPKData(string logID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`LogID` = @LogID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 AppID（字段）
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetAppIDByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`AppID`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<string> GetAppIDByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`AppID`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 OperatorID（字段）
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetOperatorIDByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`OperatorID`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<string> GetOperatorIDByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`OperatorID`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 UserID（字段）
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetUserIDByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`UserID`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<string> GetUserIDByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`UserID`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 LogType（字段）
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetLogTypeByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`LogType`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<int> GetLogTypeByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`LogType`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 LogData（字段）
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetLogDataByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`LogData`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<string> GetLogDataByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`LogData`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Url（字段）
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetUrlByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`Url`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<string> GetUrlByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`Url`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Success（字段）
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public bool GetSuccessByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (bool)GetScalar("`Success`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<bool> GetSuccessByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (bool)await GetScalarAsync("`Success`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Code（字段）
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetCodeByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`Code`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<string> GetCodeByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`Code`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Message（字段）
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetMessageByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`Message`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<string> GetMessageByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`Message`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Result（字段）
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetResultByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`Result`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<string> GetResultByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`Result`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Exception（字段）
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetExceptionByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`Exception`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<string> GetExceptionByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`Exception`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 RecDate（字段）
        /// </summary>
        /// /// <param name = "logID">主键GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public DateTime GetRecDateByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (DateTime)GetScalar("`RecDate`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<DateTime> GetRecDateByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (DateTime)await GetScalarAsync("`RecDate`", "`LogID` = @LogID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByAppID

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">应用编码</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByAppID(string appID)
        {
            return GetByAppID(appID, 0, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByAppIDAsync(string appID)
        {
            return await GetByAppIDAsync(appID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">应用编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByAppID(string appID, TransactionManager tm_)
        {
            return GetByAppID(appID, 0, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
        {
            return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">应用编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByAppID(string appID, int top_)
        {
            return GetByAppID(appID, top_, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByAppIDAsync(string appID, int top_)
        {
            return await GetByAppIDAsync(appID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">应用编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByAppID(string appID, int top_, TransactionManager tm_)
        {
            return GetByAppID(appID, top_, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
        {
            return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">应用编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByAppID(string appID, string sort_)
        {
            return GetByAppID(appID, 0, sort_, null);
        }
        public async Task<List<S_client_logEO>> GetByAppIDAsync(string appID, string sort_)
        {
            return await GetByAppIDAsync(appID, 0, sort_, null);
        }

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">应用编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
        {
            return GetByAppID(appID, 0, sort_, tm_);
        }
        public async Task<List<S_client_logEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
        {
            return await GetByAppIDAsync(appID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">应用编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (appID != null)
                paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        public async Task<List<S_client_logEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (appID != null)
                paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        #endregion // GetByAppID
        #region GetByOperatorID

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByOperatorID(string operatorID)
        {
            return GetByOperatorID(operatorID, 0, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByOperatorIDAsync(string operatorID)
        {
            return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByOperatorID(string operatorID, TransactionManager tm_)
        {
            return GetByOperatorID(operatorID, 0, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
        {
            return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByOperatorID(string operatorID, int top_)
        {
            return GetByOperatorID(operatorID, top_, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByOperatorIDAsync(string operatorID, int top_)
        {
            return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
        {
            return GetByOperatorID(operatorID, top_, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
        {
            return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByOperatorID(string operatorID, string sort_)
        {
            return GetByOperatorID(operatorID, 0, sort_, null);
        }
        public async Task<List<S_client_logEO>> GetByOperatorIDAsync(string operatorID, string sort_)
        {
            return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
        {
            return GetByOperatorID(operatorID, 0, sort_, tm_);
        }
        public async Task<List<S_client_logEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
        {
            return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (operatorID != null)
                paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        public async Task<List<S_client_logEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (operatorID != null)
                paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        #endregion // GetByOperatorID
        #region GetByUserID

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByUserID(string userID)
        {
            return GetByUserID(userID, 0, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByUserIDAsync(string userID)
        {
            return await GetByUserIDAsync(userID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByUserID(string userID, TransactionManager tm_)
        {
            return GetByUserID(userID, 0, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
        {
            return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByUserID(string userID, int top_)
        {
            return GetByUserID(userID, top_, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByUserIDAsync(string userID, int top_)
        {
            return await GetByUserIDAsync(userID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByUserID(string userID, int top_, TransactionManager tm_)
        {
            return GetByUserID(userID, top_, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
        {
            return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByUserID(string userID, string sort_)
        {
            return GetByUserID(userID, 0, sort_, null);
        }
        public async Task<List<S_client_logEO>> GetByUserIDAsync(string userID, string sort_)
        {
            return await GetByUserIDAsync(userID, 0, sort_, null);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
        {
            return GetByUserID(userID, 0, sort_, tm_);
        }
        public async Task<List<S_client_logEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
        {
            return await GetByUserIDAsync(userID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (userID != null)
                paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        public async Task<List<S_client_logEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (userID != null)
                paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        #endregion // GetByUserID
        #region GetByLogType

        /// <summary>
        /// 按 LogType（字段） 查询
        /// </summary>
        /// /// <param name = "logType">日志类型:0-未知1-客户端日志2-api返回3-socket返回</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByLogType(int logType)
        {
            return GetByLogType(logType, 0, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByLogTypeAsync(int logType)
        {
            return await GetByLogTypeAsync(logType, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 LogType（字段） 查询
        /// </summary>
        /// /// <param name = "logType">日志类型:0-未知1-客户端日志2-api返回3-socket返回</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByLogType(int logType, TransactionManager tm_)
        {
            return GetByLogType(logType, 0, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByLogTypeAsync(int logType, TransactionManager tm_)
        {
            return await GetByLogTypeAsync(logType, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 LogType（字段） 查询
        /// </summary>
        /// /// <param name = "logType">日志类型:0-未知1-客户端日志2-api返回3-socket返回</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByLogType(int logType, int top_)
        {
            return GetByLogType(logType, top_, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByLogTypeAsync(int logType, int top_)
        {
            return await GetByLogTypeAsync(logType, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 LogType（字段） 查询
        /// </summary>
        /// /// <param name = "logType">日志类型:0-未知1-客户端日志2-api返回3-socket返回</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByLogType(int logType, int top_, TransactionManager tm_)
        {
            return GetByLogType(logType, top_, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByLogTypeAsync(int logType, int top_, TransactionManager tm_)
        {
            return await GetByLogTypeAsync(logType, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 LogType（字段） 查询
        /// </summary>
        /// /// <param name = "logType">日志类型:0-未知1-客户端日志2-api返回3-socket返回</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByLogType(int logType, string sort_)
        {
            return GetByLogType(logType, 0, sort_, null);
        }
        public async Task<List<S_client_logEO>> GetByLogTypeAsync(int logType, string sort_)
        {
            return await GetByLogTypeAsync(logType, 0, sort_, null);
        }

        /// <summary>
        /// 按 LogType（字段） 查询
        /// </summary>
        /// /// <param name = "logType">日志类型:0-未知1-客户端日志2-api返回3-socket返回</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByLogType(int logType, string sort_, TransactionManager tm_)
        {
            return GetByLogType(logType, 0, sort_, tm_);
        }
        public async Task<List<S_client_logEO>> GetByLogTypeAsync(int logType, string sort_, TransactionManager tm_)
        {
            return await GetByLogTypeAsync(logType, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 LogType（字段） 查询
        /// </summary>
        /// /// <param name = "logType">日志类型:0-未知1-客户端日志2-api返回3-socket返回</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByLogType(int logType, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`LogType` = @LogType", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@LogType", logType, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        public async Task<List<S_client_logEO>> GetByLogTypeAsync(int logType, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`LogType` = @LogType", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@LogType", logType, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        #endregion // GetByLogType
        #region GetByLogData

        /// <summary>
        /// 按 LogData（字段） 查询
        /// </summary>
        /// /// <param name = "logData">上传对象json数据</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByLogData(string logData)
        {
            return GetByLogData(logData, 0, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByLogDataAsync(string logData)
        {
            return await GetByLogDataAsync(logData, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 LogData（字段） 查询
        /// </summary>
        /// /// <param name = "logData">上传对象json数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByLogData(string logData, TransactionManager tm_)
        {
            return GetByLogData(logData, 0, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByLogDataAsync(string logData, TransactionManager tm_)
        {
            return await GetByLogDataAsync(logData, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 LogData（字段） 查询
        /// </summary>
        /// /// <param name = "logData">上传对象json数据</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByLogData(string logData, int top_)
        {
            return GetByLogData(logData, top_, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByLogDataAsync(string logData, int top_)
        {
            return await GetByLogDataAsync(logData, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 LogData（字段） 查询
        /// </summary>
        /// /// <param name = "logData">上传对象json数据</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByLogData(string logData, int top_, TransactionManager tm_)
        {
            return GetByLogData(logData, top_, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByLogDataAsync(string logData, int top_, TransactionManager tm_)
        {
            return await GetByLogDataAsync(logData, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 LogData（字段） 查询
        /// </summary>
        /// /// <param name = "logData">上传对象json数据</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByLogData(string logData, string sort_)
        {
            return GetByLogData(logData, 0, sort_, null);
        }
        public async Task<List<S_client_logEO>> GetByLogDataAsync(string logData, string sort_)
        {
            return await GetByLogDataAsync(logData, 0, sort_, null);
        }

        /// <summary>
        /// 按 LogData（字段） 查询
        /// </summary>
        /// /// <param name = "logData">上传对象json数据</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByLogData(string logData, string sort_, TransactionManager tm_)
        {
            return GetByLogData(logData, 0, sort_, tm_);
        }
        public async Task<List<S_client_logEO>> GetByLogDataAsync(string logData, string sort_, TransactionManager tm_)
        {
            return await GetByLogDataAsync(logData, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 LogData（字段） 查询
        /// </summary>
        /// /// <param name = "logData">上传对象json数据</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByLogData(string logData, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(logData != null ? "`LogData` = @LogData" : "`LogData` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (logData != null)
                paras_.Add(Database.CreateInParameter("@LogData", logData, MySqlDbType.Text));
            return Database.ExecSqlList(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        public async Task<List<S_client_logEO>> GetByLogDataAsync(string logData, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(logData != null ? "`LogData` = @LogData" : "`LogData` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (logData != null)
                paras_.Add(Database.CreateInParameter("@LogData", logData, MySqlDbType.Text));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        #endregion // GetByLogData
        #region GetByUrl

        /// <summary>
        /// 按 Url（字段） 查询
        /// </summary>
        /// /// <param name = "url">URL</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByUrl(string url)
        {
            return GetByUrl(url, 0, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByUrlAsync(string url)
        {
            return await GetByUrlAsync(url, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Url（字段） 查询
        /// </summary>
        /// /// <param name = "url">URL</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByUrl(string url, TransactionManager tm_)
        {
            return GetByUrl(url, 0, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByUrlAsync(string url, TransactionManager tm_)
        {
            return await GetByUrlAsync(url, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Url（字段） 查询
        /// </summary>
        /// /// <param name = "url">URL</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByUrl(string url, int top_)
        {
            return GetByUrl(url, top_, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByUrlAsync(string url, int top_)
        {
            return await GetByUrlAsync(url, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Url（字段） 查询
        /// </summary>
        /// /// <param name = "url">URL</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByUrl(string url, int top_, TransactionManager tm_)
        {
            return GetByUrl(url, top_, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByUrlAsync(string url, int top_, TransactionManager tm_)
        {
            return await GetByUrlAsync(url, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Url（字段） 查询
        /// </summary>
        /// /// <param name = "url">URL</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByUrl(string url, string sort_)
        {
            return GetByUrl(url, 0, sort_, null);
        }
        public async Task<List<S_client_logEO>> GetByUrlAsync(string url, string sort_)
        {
            return await GetByUrlAsync(url, 0, sort_, null);
        }

        /// <summary>
        /// 按 Url（字段） 查询
        /// </summary>
        /// /// <param name = "url">URL</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByUrl(string url, string sort_, TransactionManager tm_)
        {
            return GetByUrl(url, 0, sort_, tm_);
        }
        public async Task<List<S_client_logEO>> GetByUrlAsync(string url, string sort_, TransactionManager tm_)
        {
            return await GetByUrlAsync(url, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Url（字段） 查询
        /// </summary>
        /// /// <param name = "url">URL</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByUrl(string url, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(url != null ? "`Url` = @Url" : "`Url` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (url != null)
                paras_.Add(Database.CreateInParameter("@Url", url, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        public async Task<List<S_client_logEO>> GetByUrlAsync(string url, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(url != null ? "`Url` = @Url" : "`Url` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (url != null)
                paras_.Add(Database.CreateInParameter("@Url", url, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        #endregion // GetByUrl
        #region GetBySuccess

        /// <summary>
        /// 按 Success（字段） 查询
        /// </summary>
        /// /// <param name = "success">是否成功</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetBySuccess(bool success)
        {
            return GetBySuccess(success, 0, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetBySuccessAsync(bool success)
        {
            return await GetBySuccessAsync(success, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Success（字段） 查询
        /// </summary>
        /// /// <param name = "success">是否成功</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetBySuccess(bool success, TransactionManager tm_)
        {
            return GetBySuccess(success, 0, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetBySuccessAsync(bool success, TransactionManager tm_)
        {
            return await GetBySuccessAsync(success, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Success（字段） 查询
        /// </summary>
        /// /// <param name = "success">是否成功</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetBySuccess(bool success, int top_)
        {
            return GetBySuccess(success, top_, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetBySuccessAsync(bool success, int top_)
        {
            return await GetBySuccessAsync(success, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Success（字段） 查询
        /// </summary>
        /// /// <param name = "success">是否成功</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetBySuccess(bool success, int top_, TransactionManager tm_)
        {
            return GetBySuccess(success, top_, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetBySuccessAsync(bool success, int top_, TransactionManager tm_)
        {
            return await GetBySuccessAsync(success, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Success（字段） 查询
        /// </summary>
        /// /// <param name = "success">是否成功</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetBySuccess(bool success, string sort_)
        {
            return GetBySuccess(success, 0, sort_, null);
        }
        public async Task<List<S_client_logEO>> GetBySuccessAsync(bool success, string sort_)
        {
            return await GetBySuccessAsync(success, 0, sort_, null);
        }

        /// <summary>
        /// 按 Success（字段） 查询
        /// </summary>
        /// /// <param name = "success">是否成功</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetBySuccess(bool success, string sort_, TransactionManager tm_)
        {
            return GetBySuccess(success, 0, sort_, tm_);
        }
        public async Task<List<S_client_logEO>> GetBySuccessAsync(bool success, string sort_, TransactionManager tm_)
        {
            return await GetBySuccessAsync(success, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Success（字段） 查询
        /// </summary>
        /// /// <param name = "success">是否成功</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetBySuccess(bool success, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Success` = @Success", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Success", success, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        public async Task<List<S_client_logEO>> GetBySuccessAsync(bool success, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Success` = @Success", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Success", success, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        #endregion // GetBySuccess
        #region GetByCode

        /// <summary>
        /// 按 Code（字段） 查询
        /// </summary>
        /// /// <param name = "code">编码</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByCode(string code)
        {
            return GetByCode(code, 0, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByCodeAsync(string code)
        {
            return await GetByCodeAsync(code, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Code（字段） 查询
        /// </summary>
        /// /// <param name = "code">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByCode(string code, TransactionManager tm_)
        {
            return GetByCode(code, 0, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByCodeAsync(string code, TransactionManager tm_)
        {
            return await GetByCodeAsync(code, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Code（字段） 查询
        /// </summary>
        /// /// <param name = "code">编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByCode(string code, int top_)
        {
            return GetByCode(code, top_, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByCodeAsync(string code, int top_)
        {
            return await GetByCodeAsync(code, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Code（字段） 查询
        /// </summary>
        /// /// <param name = "code">编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByCode(string code, int top_, TransactionManager tm_)
        {
            return GetByCode(code, top_, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByCodeAsync(string code, int top_, TransactionManager tm_)
        {
            return await GetByCodeAsync(code, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Code（字段） 查询
        /// </summary>
        /// /// <param name = "code">编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByCode(string code, string sort_)
        {
            return GetByCode(code, 0, sort_, null);
        }
        public async Task<List<S_client_logEO>> GetByCodeAsync(string code, string sort_)
        {
            return await GetByCodeAsync(code, 0, sort_, null);
        }

        /// <summary>
        /// 按 Code（字段） 查询
        /// </summary>
        /// /// <param name = "code">编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByCode(string code, string sort_, TransactionManager tm_)
        {
            return GetByCode(code, 0, sort_, tm_);
        }
        public async Task<List<S_client_logEO>> GetByCodeAsync(string code, string sort_, TransactionManager tm_)
        {
            return await GetByCodeAsync(code, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Code（字段） 查询
        /// </summary>
        /// /// <param name = "code">编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByCode(string code, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(code != null ? "`Code` = @Code" : "`Code` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (code != null)
                paras_.Add(Database.CreateInParameter("@Code", code, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        public async Task<List<S_client_logEO>> GetByCodeAsync(string code, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(code != null ? "`Code` = @Code" : "`Code` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (code != null)
                paras_.Add(Database.CreateInParameter("@Code", code, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        #endregion // GetByCode
        #region GetByMessage

        /// <summary>
        /// 按 Message（字段） 查询
        /// </summary>
        /// /// <param name = "message">消息</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByMessage(string message)
        {
            return GetByMessage(message, 0, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByMessageAsync(string message)
        {
            return await GetByMessageAsync(message, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Message（字段） 查询
        /// </summary>
        /// /// <param name = "message">消息</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByMessage(string message, TransactionManager tm_)
        {
            return GetByMessage(message, 0, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByMessageAsync(string message, TransactionManager tm_)
        {
            return await GetByMessageAsync(message, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Message（字段） 查询
        /// </summary>
        /// /// <param name = "message">消息</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByMessage(string message, int top_)
        {
            return GetByMessage(message, top_, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByMessageAsync(string message, int top_)
        {
            return await GetByMessageAsync(message, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Message（字段） 查询
        /// </summary>
        /// /// <param name = "message">消息</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByMessage(string message, int top_, TransactionManager tm_)
        {
            return GetByMessage(message, top_, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByMessageAsync(string message, int top_, TransactionManager tm_)
        {
            return await GetByMessageAsync(message, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Message（字段） 查询
        /// </summary>
        /// /// <param name = "message">消息</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByMessage(string message, string sort_)
        {
            return GetByMessage(message, 0, sort_, null);
        }
        public async Task<List<S_client_logEO>> GetByMessageAsync(string message, string sort_)
        {
            return await GetByMessageAsync(message, 0, sort_, null);
        }

        /// <summary>
        /// 按 Message（字段） 查询
        /// </summary>
        /// /// <param name = "message">消息</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByMessage(string message, string sort_, TransactionManager tm_)
        {
            return GetByMessage(message, 0, sort_, tm_);
        }
        public async Task<List<S_client_logEO>> GetByMessageAsync(string message, string sort_, TransactionManager tm_)
        {
            return await GetByMessageAsync(message, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Message（字段） 查询
        /// </summary>
        /// /// <param name = "message">消息</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByMessage(string message, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(message != null ? "`Message` = @Message" : "`Message` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (message != null)
                paras_.Add(Database.CreateInParameter("@Message", message, MySqlDbType.Text));
            return Database.ExecSqlList(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        public async Task<List<S_client_logEO>> GetByMessageAsync(string message, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(message != null ? "`Message` = @Message" : "`Message` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (message != null)
                paras_.Add(Database.CreateInParameter("@Message", message, MySqlDbType.Text));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        #endregion // GetByMessage
        #region GetByResult

        /// <summary>
        /// 按 Result（字段） 查询
        /// </summary>
        /// /// <param name = "result">结果</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByResult(string result)
        {
            return GetByResult(result, 0, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByResultAsync(string result)
        {
            return await GetByResultAsync(result, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Result（字段） 查询
        /// </summary>
        /// /// <param name = "result">结果</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByResult(string result, TransactionManager tm_)
        {
            return GetByResult(result, 0, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByResultAsync(string result, TransactionManager tm_)
        {
            return await GetByResultAsync(result, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Result（字段） 查询
        /// </summary>
        /// /// <param name = "result">结果</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByResult(string result, int top_)
        {
            return GetByResult(result, top_, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByResultAsync(string result, int top_)
        {
            return await GetByResultAsync(result, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Result（字段） 查询
        /// </summary>
        /// /// <param name = "result">结果</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByResult(string result, int top_, TransactionManager tm_)
        {
            return GetByResult(result, top_, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByResultAsync(string result, int top_, TransactionManager tm_)
        {
            return await GetByResultAsync(result, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Result（字段） 查询
        /// </summary>
        /// /// <param name = "result">结果</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByResult(string result, string sort_)
        {
            return GetByResult(result, 0, sort_, null);
        }
        public async Task<List<S_client_logEO>> GetByResultAsync(string result, string sort_)
        {
            return await GetByResultAsync(result, 0, sort_, null);
        }

        /// <summary>
        /// 按 Result（字段） 查询
        /// </summary>
        /// /// <param name = "result">结果</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByResult(string result, string sort_, TransactionManager tm_)
        {
            return GetByResult(result, 0, sort_, tm_);
        }
        public async Task<List<S_client_logEO>> GetByResultAsync(string result, string sort_, TransactionManager tm_)
        {
            return await GetByResultAsync(result, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Result（字段） 查询
        /// </summary>
        /// /// <param name = "result">结果</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByResult(string result, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(result != null ? "`Result` = @Result" : "`Result` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (result != null)
                paras_.Add(Database.CreateInParameter("@Result", result, MySqlDbType.Text));
            return Database.ExecSqlList(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        public async Task<List<S_client_logEO>> GetByResultAsync(string result, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(result != null ? "`Result` = @Result" : "`Result` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (result != null)
                paras_.Add(Database.CreateInParameter("@Result", result, MySqlDbType.Text));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        #endregion // GetByResult
        #region GetByException

        /// <summary>
        /// 按 Exception（字段） 查询
        /// </summary>
        /// /// <param name = "exception">异常</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByException(string exception)
        {
            return GetByException(exception, 0, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByExceptionAsync(string exception)
        {
            return await GetByExceptionAsync(exception, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Exception（字段） 查询
        /// </summary>
        /// /// <param name = "exception">异常</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByException(string exception, TransactionManager tm_)
        {
            return GetByException(exception, 0, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByExceptionAsync(string exception, TransactionManager tm_)
        {
            return await GetByExceptionAsync(exception, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Exception（字段） 查询
        /// </summary>
        /// /// <param name = "exception">异常</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByException(string exception, int top_)
        {
            return GetByException(exception, top_, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByExceptionAsync(string exception, int top_)
        {
            return await GetByExceptionAsync(exception, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Exception（字段） 查询
        /// </summary>
        /// /// <param name = "exception">异常</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByException(string exception, int top_, TransactionManager tm_)
        {
            return GetByException(exception, top_, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByExceptionAsync(string exception, int top_, TransactionManager tm_)
        {
            return await GetByExceptionAsync(exception, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Exception（字段） 查询
        /// </summary>
        /// /// <param name = "exception">异常</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByException(string exception, string sort_)
        {
            return GetByException(exception, 0, sort_, null);
        }
        public async Task<List<S_client_logEO>> GetByExceptionAsync(string exception, string sort_)
        {
            return await GetByExceptionAsync(exception, 0, sort_, null);
        }

        /// <summary>
        /// 按 Exception（字段） 查询
        /// </summary>
        /// /// <param name = "exception">异常</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByException(string exception, string sort_, TransactionManager tm_)
        {
            return GetByException(exception, 0, sort_, tm_);
        }
        public async Task<List<S_client_logEO>> GetByExceptionAsync(string exception, string sort_, TransactionManager tm_)
        {
            return await GetByExceptionAsync(exception, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Exception（字段） 查询
        /// </summary>
        /// /// <param name = "exception">异常</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByException(string exception, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(exception != null ? "`Exception` = @Exception" : "`Exception` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (exception != null)
                paras_.Add(Database.CreateInParameter("@Exception", exception, MySqlDbType.Text));
            return Database.ExecSqlList(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        public async Task<List<S_client_logEO>> GetByExceptionAsync(string exception, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(exception != null ? "`Exception` = @Exception" : "`Exception` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (exception != null)
                paras_.Add(Database.CreateInParameter("@Exception", exception, MySqlDbType.Text));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        #endregion // GetByException
        #region GetByRecDate

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByRecDate(DateTime recDate)
        {
            return GetByRecDate(recDate, 0, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByRecDateAsync(DateTime recDate)
        {
            return await GetByRecDateAsync(recDate, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
        {
            return GetByRecDate(recDate, 0, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
        {
            return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByRecDate(DateTime recDate, int top_)
        {
            return GetByRecDate(recDate, top_, string.Empty, null);
        }
        public async Task<List<S_client_logEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
        public List<S_client_logEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
        {
            return GetByRecDate(recDate, top_, string.Empty, tm_);
        }
        public async Task<List<S_client_logEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
        {
            return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_client_logEO> GetByRecDate(DateTime recDate, string sort_)
        {
            return GetByRecDate(recDate, 0, sort_, null);
        }
        public async Task<List<S_client_logEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
        public List<S_client_logEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
        {
            return GetByRecDate(recDate, 0, sort_, tm_);
        }
        public async Task<List<S_client_logEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
        public List<S_client_logEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
            return Database.ExecSqlList(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        public async Task<List<S_client_logEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_client_logEO.MapDataReader);
        }
        #endregion // GetByRecDate
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
