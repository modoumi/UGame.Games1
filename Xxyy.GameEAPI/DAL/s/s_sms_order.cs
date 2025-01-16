/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-11-08 15: 50:57
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
    /// sms订单
    /// 【表 s_sms_order 的实体类】
    /// </summary>
    [DataContract]
    public class S_sms_orderEO : IRowMapper<S_sms_orderEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public S_sms_orderEO()
        {
            this.Status = 0;
            this.RecDate = DateTime.Now;
            this.SettlStatus = 0;
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private string _originalOrderID;
        /// <summary>
        /// 【数据库中的原始主键 OrderID 值的副本，用于主键值更新】
        /// </summary>
        public string OriginalOrderID
        {
            get { return _originalOrderID; }
            set { HasOriginal = true; _originalOrderID = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "OrderID", OrderID }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// 订单ID GUID
        /// 【主键 varchar(38)】
        /// </summary>
        [DataMember(Order = 1)]
        public string OrderID { get; set; }
        /// <summary>
        /// 短信商编码
        /// 【字段 varchar(50)】
        /// </summary>
        [DataMember(Order = 2)]
        public string SmsID { get; set; }
        /// <summary>
        /// 国家编码ISO 3166-1三位字母
        /// 【字段 varchar(5)】
        /// </summary>
        [DataMember(Order = 3)]
        public string CountryID { get; set; }
        /// <summary>
        /// 发送模板名（s_sms_country表的模板列名）
        /// 【字段 varchar(200)】
        /// </summary>
        [DataMember(Order = 4)]
        public string SendTemplate { get; set; }
        /// <summary>
        /// 应用编码
        /// 【字段 varchar(50)】
        /// </summary>
        [DataMember(Order = 5)]
        public string AppID { get; set; }
        /// <summary>
        /// 运营商编码
        /// 【字段 varchar(50)】
        /// </summary>
        [DataMember(Order = 6)]
        public string OperatorID { get; set; }
        /// <summary>
        /// 用户编码(GUID)
        /// 【字段 varchar(38)】
        /// </summary>
        [DataMember(Order = 7)]
        public string UserID { get; set; }
        /// <summary>
        /// 请求时间
        /// 【字段 datetime】
        /// </summary>
        [DataMember(Order = 8)]
        public DateTime RequestTime { get; set; }
        /// <summary>
        /// 请求消息（我方请求或对方请求）json
        /// 【字段 text】
        /// </summary>
        [DataMember(Order = 9)]
        public string RequestBody { get; set; }
        /// <summary>
        /// 状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 10)]
        public int Status { get; set; }
        /// <summary>
        /// 记录时间
        /// 【字段 datetime】
        /// </summary>
        [DataMember(Order = 11)]
        public DateTime RecDate { get; set; }
        /// <summary>
        /// 短信商订单编码
        /// 【字段 varchar(50)】
        /// </summary>
        [DataMember(Order = 12)]
        public string SmsOrderId { get; set; }
        /// <summary>
        /// 返回时间
        /// 【字段 datetime】
        /// </summary>
        [DataMember(Order = 13)]
        public DateTime? ResponseTime { get; set; }
        /// <summary>
        /// 响应消息（对方响应或我方响应）json
        /// 【字段 text】
        /// </summary>
        [DataMember(Order = 14)]
        public string ResponseBody { get; set; }
        /// <summary>
        /// 异常消息
        /// 【字段 text】
        /// </summary>
        [DataMember(Order = 15)]
        public string Exception { get; set; }
        /// <summary>
        /// 结算表名
        /// 【字段 varchar(100)】
        /// </summary>
        [DataMember(Order = 16)]
        public string SettlTable { get; set; }
        /// <summary>
        /// 结算编码
        /// 【字段 varchar(50)】
        /// </summary>
        [DataMember(Order = 17)]
        public string SettlId { get; set; }
        /// <summary>
        /// 结算状态（0-未结算1-已结算）
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 18)]
        public int SettlStatus { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public S_sms_orderEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static S_sms_orderEO MapDataReader(IDataReader reader)
        {
            S_sms_orderEO ret = new S_sms_orderEO();
            ret.OrderID = reader.ToString("OrderID");
            ret.OriginalOrderID = ret.OrderID;
            ret.SmsID = reader.ToString("SmsID");
            ret.CountryID = reader.ToString("CountryID");
            ret.SendTemplate = reader.ToString("SendTemplate");
            ret.AppID = reader.ToString("AppID");
            ret.OperatorID = reader.ToString("OperatorID");
            ret.UserID = reader.ToString("UserID");
            ret.RequestTime = reader.ToDateTime("RequestTime");
            ret.RequestBody = reader.ToString("RequestBody");
            ret.Status = reader.ToInt32("Status");
            ret.RecDate = reader.ToDateTime("RecDate");
            ret.SmsOrderId = reader.ToString("SmsOrderId");
            ret.ResponseTime = reader.ToDateTimeN("ResponseTime");
            ret.ResponseBody = reader.ToString("ResponseBody");
            ret.Exception = reader.ToString("Exception");
            ret.SettlTable = reader.ToString("SettlTable");
            ret.SettlId = reader.ToString("SettlId");
            ret.SettlStatus = reader.ToInt32("SettlStatus");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// sms订单
    /// 【表 s_sms_order 的操作类】
    /// </summary>
    public class S_sms_orderMO : MySqlTableMO<S_sms_orderEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`s_sms_order`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public S_sms_orderMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public S_sms_orderMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public S_sms_orderMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(S_sms_orderEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(S_sms_orderEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(S_sms_orderEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`OrderID`, `SmsID`, `CountryID`, `SendTemplate`, `AppID`, `OperatorID`, `UserID`, `RequestTime`, `RequestBody`, `Status`, `RecDate`, `SmsOrderId`, `ResponseTime`, `ResponseBody`, `Exception`, `SettlTable`, `SettlId`, `SettlStatus`) VALUE (@OrderID, @SmsID, @CountryID, @SendTemplate, @AppID, @OperatorID, @UserID, @RequestTime, @RequestBody, @Status, @RecDate, @SmsOrderId, @ResponseTime, @ResponseBody, @Exception, @SettlTable, @SettlId, @SettlStatus);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", item.OrderID, MySqlDbType.VarChar),
                Database.CreateInParameter("@SmsID", item.SmsID != null ? item.SmsID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SendTemplate", item.SendTemplate != null ? item.SendTemplate : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@UserID", item.UserID != null ? item.UserID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@RequestTime", item.RequestTime, MySqlDbType.DateTime),
                Database.CreateInParameter("@RequestBody", item.RequestBody != null ? item.RequestBody : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
                Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
                Database.CreateInParameter("@SmsOrderId", item.SmsOrderId != null ? item.SmsOrderId : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@ResponseTime", item.ResponseTime.HasValue ? item.ResponseTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
                Database.CreateInParameter("@ResponseBody", item.ResponseBody != null ? item.ResponseBody : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@Exception", item.Exception != null ? item.Exception : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@SettlTable", item.SettlTable != null ? item.SettlTable : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SettlId", item.SettlId != null ? item.SettlId : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SettlStatus", item.SettlStatus, MySqlDbType.Int32),
            };
        }
        public int AddByBatch(IEnumerable<S_sms_orderEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<S_sms_orderEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_sms_orderEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`OrderID`, `SmsID`, `CountryID`, `SendTemplate`, `AppID`, `OperatorID`, `UserID`, `RequestTime`, `RequestBody`, `Status`, `RecDate`, `SmsOrderId`, `ResponseTime`, `ResponseBody`, `Exception`, `SettlTable`, `SettlId`, `SettlStatus`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"('{item.OrderID}','{item.SmsID}','{item.CountryID}','{item.SendTemplate}','{item.AppID}','{item.OperatorID}','{item.UserID}','{item.RequestTime.ToString("yyyy-MM-dd HH:mm:ss")}','{item.RequestBody}',{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.SmsOrderId}','{item.ResponseTime?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.ResponseBody}','{item.Exception}','{item.SettlTable}','{item.SettlId}',{item.SettlStatus}),");
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
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(string orderID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(orderID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(orderID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(string orderID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(S_sms_orderEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.OrderID, tm_);
        }
        public async Task<int> RemoveAsync(S_sms_orderEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.OrderID, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
        #region RemoveBySmsID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveBySmsID(string smsID, TransactionManager tm_ = null)
        {
            RepairRemoveBySmsIDData(smsID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveBySmsIDAsync(string smsID, TransactionManager tm_ = null)
        {
            RepairRemoveBySmsIDData(smsID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveBySmsIDData(string smsID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (smsID != null ? "`SmsID` = @SmsID" : "`SmsID` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (smsID != null)
                paras_.Add(Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar));
        }
        #endregion // RemoveBySmsID
        #region RemoveByCountryID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByCountryID(string countryID, TransactionManager tm_ = null)
        {
            RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByCountryIDAsync(string countryID, TransactionManager tm_ = null)
        {
            RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByCountryIDData(string countryID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (countryID != null)
                paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
        }
        #endregion // RemoveByCountryID
        #region RemoveBySendTemplate
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "sendTemplate">发送模板名（s_sms_country表的模板列名）</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveBySendTemplate(string sendTemplate, TransactionManager tm_ = null)
        {
            RepairRemoveBySendTemplateData(sendTemplate, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveBySendTemplateAsync(string sendTemplate, TransactionManager tm_ = null)
        {
            RepairRemoveBySendTemplateData(sendTemplate, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveBySendTemplateData(string sendTemplate, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (sendTemplate != null ? "`SendTemplate` = @SendTemplate" : "`SendTemplate` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (sendTemplate != null)
                paras_.Add(Database.CreateInParameter("@SendTemplate", sendTemplate, MySqlDbType.VarChar));
        }
        #endregion // RemoveBySendTemplate
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
        /// /// <param name = "userID">用户编码(GUID)</param>
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
        #region RemoveByRequestTime
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "requestTime">请求时间</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByRequestTime(DateTime requestTime, TransactionManager tm_ = null)
        {
            RepairRemoveByRequestTimeData(requestTime, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByRequestTimeAsync(DateTime requestTime, TransactionManager tm_ = null)
        {
            RepairRemoveByRequestTimeData(requestTime, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByRequestTimeData(DateTime requestTime, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `RequestTime` = @RequestTime";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RequestTime", requestTime, MySqlDbType.DateTime));
        }
        #endregion // RemoveByRequestTime
        #region RemoveByRequestBody
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByRequestBody(string requestBody, TransactionManager tm_ = null)
        {
            RepairRemoveByRequestBodyData(requestBody, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByRequestBodyAsync(string requestBody, TransactionManager tm_ = null)
        {
            RepairRemoveByRequestBodyData(requestBody, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByRequestBodyData(string requestBody, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (requestBody != null ? "`RequestBody` = @RequestBody" : "`RequestBody` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (requestBody != null)
                paras_.Add(Database.CreateInParameter("@RequestBody", requestBody, MySqlDbType.Text));
        }
        #endregion // RemoveByRequestBody
        #region RemoveByStatus
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
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
        #region RemoveBySmsOrderId
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "smsOrderId">短信商订单编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveBySmsOrderId(string smsOrderId, TransactionManager tm_ = null)
        {
            RepairRemoveBySmsOrderIdData(smsOrderId, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveBySmsOrderIdAsync(string smsOrderId, TransactionManager tm_ = null)
        {
            RepairRemoveBySmsOrderIdData(smsOrderId, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveBySmsOrderIdData(string smsOrderId, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (smsOrderId != null ? "`SmsOrderId` = @SmsOrderId" : "`SmsOrderId` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (smsOrderId != null)
                paras_.Add(Database.CreateInParameter("@SmsOrderId", smsOrderId, MySqlDbType.VarChar));
        }
        #endregion // RemoveBySmsOrderId
        #region RemoveByResponseTime
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "responseTime">返回时间</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByResponseTime(DateTime? responseTime, TransactionManager tm_ = null)
        {
            RepairRemoveByResponseTimeData(responseTime.Value, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByResponseTimeAsync(DateTime? responseTime, TransactionManager tm_ = null)
        {
            RepairRemoveByResponseTimeData(responseTime.Value, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByResponseTimeData(DateTime? responseTime, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (responseTime.HasValue ? "`ResponseTime` = @ResponseTime" : "`ResponseTime` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (responseTime.HasValue)
                paras_.Add(Database.CreateInParameter("@ResponseTime", responseTime.Value, MySqlDbType.DateTime));
        }
        #endregion // RemoveByResponseTime
        #region RemoveByResponseBody
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByResponseBody(string responseBody, TransactionManager tm_ = null)
        {
            RepairRemoveByResponseBodyData(responseBody, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByResponseBodyAsync(string responseBody, TransactionManager tm_ = null)
        {
            RepairRemoveByResponseBodyData(responseBody, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByResponseBodyData(string responseBody, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (responseBody != null ? "`ResponseBody` = @ResponseBody" : "`ResponseBody` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (responseBody != null)
                paras_.Add(Database.CreateInParameter("@ResponseBody", responseBody, MySqlDbType.Text));
        }
        #endregion // RemoveByResponseBody
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
        #region RemoveBySettlTable
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "settlTable">结算表名</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveBySettlTable(string settlTable, TransactionManager tm_ = null)
        {
            RepairRemoveBySettlTableData(settlTable, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveBySettlTableAsync(string settlTable, TransactionManager tm_ = null)
        {
            RepairRemoveBySettlTableData(settlTable, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveBySettlTableData(string settlTable, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (settlTable != null ? "`SettlTable` = @SettlTable" : "`SettlTable` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (settlTable != null)
                paras_.Add(Database.CreateInParameter("@SettlTable", settlTable, MySqlDbType.VarChar));
        }
        #endregion // RemoveBySettlTable
        #region RemoveBySettlId
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "settlId">结算编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveBySettlId(string settlId, TransactionManager tm_ = null)
        {
            RepairRemoveBySettlIdData(settlId, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveBySettlIdAsync(string settlId, TransactionManager tm_ = null)
        {
            RepairRemoveBySettlIdData(settlId, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveBySettlIdData(string settlId, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (settlId != null ? "`SettlId` = @SettlId" : "`SettlId` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (settlId != null)
                paras_.Add(Database.CreateInParameter("@SettlId", settlId, MySqlDbType.VarChar));
        }
        #endregion // RemoveBySettlId
        #region RemoveBySettlStatus
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveBySettlStatus(int settlStatus, TransactionManager tm_ = null)
        {
            RepairRemoveBySettlStatusData(settlStatus, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveBySettlStatusAsync(int settlStatus, TransactionManager tm_ = null)
        {
            RepairRemoveBySettlStatusData(settlStatus, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveBySettlStatusData(int settlStatus, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `SettlStatus` = @SettlStatus";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SettlStatus", settlStatus, MySqlDbType.Int32));
        }
        #endregion // RemoveBySettlStatus
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
        public int Put(S_sms_orderEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(S_sms_orderEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(S_sms_orderEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `OrderID` = @OrderID, `SmsID` = @SmsID, `CountryID` = @CountryID, `SendTemplate` = @SendTemplate, `AppID` = @AppID, `OperatorID` = @OperatorID, `UserID` = @UserID, `RequestTime` = @RequestTime, `RequestBody` = @RequestBody, `Status` = @Status, `SmsOrderId` = @SmsOrderId, `ResponseTime` = @ResponseTime, `ResponseBody` = @ResponseBody, `Exception` = @Exception, `SettlTable` = @SettlTable, `SettlId` = @SettlId, `SettlStatus` = @SettlStatus WHERE `OrderID` = @OrderID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", item.OrderID, MySqlDbType.VarChar),
                Database.CreateInParameter("@SmsID", item.SmsID != null ? item.SmsID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SendTemplate", item.SendTemplate != null ? item.SendTemplate : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@UserID", item.UserID != null ? item.UserID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@RequestTime", item.RequestTime, MySqlDbType.DateTime),
                Database.CreateInParameter("@RequestBody", item.RequestBody != null ? item.RequestBody : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
                Database.CreateInParameter("@SmsOrderId", item.SmsOrderId != null ? item.SmsOrderId : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@ResponseTime", item.ResponseTime.HasValue ? item.ResponseTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
                Database.CreateInParameter("@ResponseBody", item.ResponseBody != null ? item.ResponseBody : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@Exception", item.Exception != null ? item.Exception : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@SettlTable", item.SettlTable != null ? item.SettlTable : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SettlId", item.SettlId != null ? item.SettlId : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SettlStatus", item.SettlStatus, MySqlDbType.Int32),
                Database.CreateInParameter("@OrderID_Original", item.HasOriginal ? item.OriginalOrderID : item.OrderID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<S_sms_orderEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<S_sms_orderEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string orderID, string set_, params object[] values_)
        {
            return Put(set_, "`OrderID` = @OrderID", ConcatValues(values_, orderID));
        }
        public async Task<int> PutByPKAsync(string orderID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`OrderID` = @OrderID", ConcatValues(values_, orderID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string orderID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`OrderID` = @OrderID", tm_, ConcatValues(values_, orderID));
        }
        public async Task<int> PutByPKAsync(string orderID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`OrderID` = @OrderID", tm_, ConcatValues(values_, orderID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string orderID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return Put(set_, "`OrderID` = @OrderID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(string orderID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return await PutAsync(set_, "`OrderID` = @OrderID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutSmsID
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSmsIDByPK(string orderID, string smsID, TransactionManager tm_ = null)
        {
            RepairPutSmsIDByPKData(orderID, smsID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutSmsIDByPKAsync(string orderID, string smsID, TransactionManager tm_ = null)
        {
            RepairPutSmsIDByPKData(orderID, smsID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutSmsIDByPKData(string orderID, string smsID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `SmsID` = @SmsID  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID != null ? smsID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSmsID(string smsID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SmsID` = @SmsID";
            var parameter_ = Database.CreateInParameter("@SmsID", smsID != null ? smsID : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutSmsIDAsync(string smsID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SmsID` = @SmsID";
            var parameter_ = Database.CreateInParameter("@SmsID", smsID != null ? smsID : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutSmsID
        #region PutCountryID
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutCountryIDByPK(string orderID, string countryID, TransactionManager tm_ = null)
        {
            RepairPutCountryIDByPKData(orderID, countryID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutCountryIDByPKAsync(string orderID, string countryID, TransactionManager tm_ = null)
        {
            RepairPutCountryIDByPKData(orderID, countryID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutCountryIDByPKData(string orderID, string countryID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutCountryID(string countryID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
            var parameter_ = Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutCountryIDAsync(string countryID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
            var parameter_ = Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutCountryID
        #region PutSendTemplate
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "sendTemplate">发送模板名（s_sms_country表的模板列名）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSendTemplateByPK(string orderID, string sendTemplate, TransactionManager tm_ = null)
        {
            RepairPutSendTemplateByPKData(orderID, sendTemplate, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutSendTemplateByPKAsync(string orderID, string sendTemplate, TransactionManager tm_ = null)
        {
            RepairPutSendTemplateByPKData(orderID, sendTemplate, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutSendTemplateByPKData(string orderID, string sendTemplate, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `SendTemplate` = @SendTemplate  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SendTemplate", sendTemplate != null ? sendTemplate : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "sendTemplate">发送模板名（s_sms_country表的模板列名）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSendTemplate(string sendTemplate, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SendTemplate` = @SendTemplate";
            var parameter_ = Database.CreateInParameter("@SendTemplate", sendTemplate != null ? sendTemplate : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutSendTemplateAsync(string sendTemplate, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SendTemplate` = @SendTemplate";
            var parameter_ = Database.CreateInParameter("@SendTemplate", sendTemplate != null ? sendTemplate : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutSendTemplate
        #region PutAppID
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "appID">应用编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutAppIDByPK(string orderID, string appID, TransactionManager tm_ = null)
        {
            RepairPutAppIDByPKData(orderID, appID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAppIDByPKAsync(string orderID, string appID, TransactionManager tm_ = null)
        {
            RepairPutAppIDByPKData(orderID, appID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutAppIDByPKData(string orderID, string appID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `AppID` = @AppID  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutOperatorIDByPK(string orderID, string operatorID, TransactionManager tm_ = null)
        {
            RepairPutOperatorIDByPKData(orderID, operatorID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutOperatorIDByPKAsync(string orderID, string operatorID, TransactionManager tm_ = null)
        {
            RepairPutOperatorIDByPKData(orderID, operatorID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutOperatorIDByPKData(string orderID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutUserIDByPK(string orderID, string userID, TransactionManager tm_ = null)
        {
            RepairPutUserIDByPKData(orderID, userID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutUserIDByPKAsync(string orderID, string userID, TransactionManager tm_ = null)
        {
            RepairPutUserIDByPKData(orderID, userID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutUserIDByPKData(string orderID, string userID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `UserID` = @UserID  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
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
        #region PutRequestTime
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "requestTime">请求时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRequestTimeByPK(string orderID, DateTime requestTime, TransactionManager tm_ = null)
        {
            RepairPutRequestTimeByPKData(orderID, requestTime, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRequestTimeByPKAsync(string orderID, DateTime requestTime, TransactionManager tm_ = null)
        {
            RepairPutRequestTimeByPKData(orderID, requestTime, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRequestTimeByPKData(string orderID, DateTime requestTime, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `RequestTime` = @RequestTime  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RequestTime", requestTime, MySqlDbType.DateTime),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "requestTime">请求时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRequestTime(DateTime requestTime, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `RequestTime` = @RequestTime";
            var parameter_ = Database.CreateInParameter("@RequestTime", requestTime, MySqlDbType.DateTime);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutRequestTimeAsync(DateTime requestTime, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `RequestTime` = @RequestTime";
            var parameter_ = Database.CreateInParameter("@RequestTime", requestTime, MySqlDbType.DateTime);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutRequestTime
        #region PutRequestBody
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRequestBodyByPK(string orderID, string requestBody, TransactionManager tm_ = null)
        {
            RepairPutRequestBodyByPKData(orderID, requestBody, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRequestBodyByPKAsync(string orderID, string requestBody, TransactionManager tm_ = null)
        {
            RepairPutRequestBodyByPKData(orderID, requestBody, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRequestBodyByPKData(string orderID, string requestBody, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `RequestBody` = @RequestBody  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RequestBody", requestBody != null ? requestBody : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRequestBody(string requestBody, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `RequestBody` = @RequestBody";
            var parameter_ = Database.CreateInParameter("@RequestBody", requestBody != null ? requestBody : (object)DBNull.Value, MySqlDbType.Text);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutRequestBodyAsync(string requestBody, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `RequestBody` = @RequestBody";
            var parameter_ = Database.CreateInParameter("@RequestBody", requestBody != null ? requestBody : (object)DBNull.Value, MySqlDbType.Text);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutRequestBody
        #region PutStatus
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutStatusByPK(string orderID, int status, TransactionManager tm_ = null)
        {
            RepairPutStatusByPKData(orderID, status, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutStatusByPKAsync(string orderID, int status, TransactionManager tm_ = null)
        {
            RepairPutStatusByPKData(orderID, status, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutStatusByPKData(string orderID, int status, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
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
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRecDateByPK(string orderID, DateTime recDate, TransactionManager tm_ = null)
        {
            RepairPutRecDateByPKData(orderID, recDate, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRecDateByPKAsync(string orderID, DateTime recDate, TransactionManager tm_ = null)
        {
            RepairPutRecDateByPKData(orderID, recDate, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRecDateByPKData(string orderID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
        #region PutSmsOrderId
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "smsOrderId">短信商订单编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSmsOrderIdByPK(string orderID, string smsOrderId, TransactionManager tm_ = null)
        {
            RepairPutSmsOrderIdByPKData(orderID, smsOrderId, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutSmsOrderIdByPKAsync(string orderID, string smsOrderId, TransactionManager tm_ = null)
        {
            RepairPutSmsOrderIdByPKData(orderID, smsOrderId, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutSmsOrderIdByPKData(string orderID, string smsOrderId, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `SmsOrderId` = @SmsOrderId  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsOrderId", smsOrderId != null ? smsOrderId : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "smsOrderId">短信商订单编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSmsOrderId(string smsOrderId, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SmsOrderId` = @SmsOrderId";
            var parameter_ = Database.CreateInParameter("@SmsOrderId", smsOrderId != null ? smsOrderId : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutSmsOrderIdAsync(string smsOrderId, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SmsOrderId` = @SmsOrderId";
            var parameter_ = Database.CreateInParameter("@SmsOrderId", smsOrderId != null ? smsOrderId : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutSmsOrderId
        #region PutResponseTime
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "responseTime">返回时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutResponseTimeByPK(string orderID, DateTime? responseTime, TransactionManager tm_ = null)
        {
            RepairPutResponseTimeByPKData(orderID, responseTime, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutResponseTimeByPKAsync(string orderID, DateTime? responseTime, TransactionManager tm_ = null)
        {
            RepairPutResponseTimeByPKData(orderID, responseTime, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutResponseTimeByPKData(string orderID, DateTime? responseTime, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `ResponseTime` = @ResponseTime  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ResponseTime", responseTime.HasValue ? responseTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "responseTime">返回时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutResponseTime(DateTime? responseTime, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `ResponseTime` = @ResponseTime";
            var parameter_ = Database.CreateInParameter("@ResponseTime", responseTime.HasValue ? responseTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutResponseTimeAsync(DateTime? responseTime, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `ResponseTime` = @ResponseTime";
            var parameter_ = Database.CreateInParameter("@ResponseTime", responseTime.HasValue ? responseTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutResponseTime
        #region PutResponseBody
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutResponseBodyByPK(string orderID, string responseBody, TransactionManager tm_ = null)
        {
            RepairPutResponseBodyByPKData(orderID, responseBody, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutResponseBodyByPKAsync(string orderID, string responseBody, TransactionManager tm_ = null)
        {
            RepairPutResponseBodyByPKData(orderID, responseBody, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutResponseBodyByPKData(string orderID, string responseBody, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `ResponseBody` = @ResponseBody  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ResponseBody", responseBody != null ? responseBody : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutResponseBody(string responseBody, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `ResponseBody` = @ResponseBody";
            var parameter_ = Database.CreateInParameter("@ResponseBody", responseBody != null ? responseBody : (object)DBNull.Value, MySqlDbType.Text);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutResponseBodyAsync(string responseBody, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `ResponseBody` = @ResponseBody";
            var parameter_ = Database.CreateInParameter("@ResponseBody", responseBody != null ? responseBody : (object)DBNull.Value, MySqlDbType.Text);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutResponseBody
        #region PutException
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "exception">异常消息</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutExceptionByPK(string orderID, string exception, TransactionManager tm_ = null)
        {
            RepairPutExceptionByPKData(orderID, exception, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutExceptionByPKAsync(string orderID, string exception, TransactionManager tm_ = null)
        {
            RepairPutExceptionByPKData(orderID, exception, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutExceptionByPKData(string orderID, string exception, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Exception` = @Exception  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Exception", exception != null ? exception : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
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
        #region PutSettlTable
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "settlTable">结算表名</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSettlTableByPK(string orderID, string settlTable, TransactionManager tm_ = null)
        {
            RepairPutSettlTableByPKData(orderID, settlTable, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutSettlTableByPKAsync(string orderID, string settlTable, TransactionManager tm_ = null)
        {
            RepairPutSettlTableByPKData(orderID, settlTable, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutSettlTableByPKData(string orderID, string settlTable, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `SettlTable` = @SettlTable  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SettlTable", settlTable != null ? settlTable : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "settlTable">结算表名</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSettlTable(string settlTable, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SettlTable` = @SettlTable";
            var parameter_ = Database.CreateInParameter("@SettlTable", settlTable != null ? settlTable : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutSettlTableAsync(string settlTable, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SettlTable` = @SettlTable";
            var parameter_ = Database.CreateInParameter("@SettlTable", settlTable != null ? settlTable : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutSettlTable
        #region PutSettlId
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "settlId">结算编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSettlIdByPK(string orderID, string settlId, TransactionManager tm_ = null)
        {
            RepairPutSettlIdByPKData(orderID, settlId, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutSettlIdByPKAsync(string orderID, string settlId, TransactionManager tm_ = null)
        {
            RepairPutSettlIdByPKData(orderID, settlId, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutSettlIdByPKData(string orderID, string settlId, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `SettlId` = @SettlId  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SettlId", settlId != null ? settlId : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "settlId">结算编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSettlId(string settlId, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SettlId` = @SettlId";
            var parameter_ = Database.CreateInParameter("@SettlId", settlId != null ? settlId : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutSettlIdAsync(string settlId, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SettlId` = @SettlId";
            var parameter_ = Database.CreateInParameter("@SettlId", settlId != null ? settlId : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutSettlId
        #region PutSettlStatus
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSettlStatusByPK(string orderID, int settlStatus, TransactionManager tm_ = null)
        {
            RepairPutSettlStatusByPKData(orderID, settlStatus, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutSettlStatusByPKAsync(string orderID, int settlStatus, TransactionManager tm_ = null)
        {
            RepairPutSettlStatusByPKData(orderID, settlStatus, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutSettlStatusByPKData(string orderID, int settlStatus, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `SettlStatus` = @SettlStatus  WHERE `OrderID` = @OrderID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SettlStatus", settlStatus, MySqlDbType.Int32),
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSettlStatus(int settlStatus, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SettlStatus` = @SettlStatus";
            var parameter_ = Database.CreateInParameter("@SettlStatus", settlStatus, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutSettlStatusAsync(int settlStatus, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SettlStatus` = @SettlStatus";
            var parameter_ = Database.CreateInParameter("@SettlStatus", settlStatus, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutSettlStatus
        #endregion // PutXXX
        #endregion // Put

        #region Set

        /// <summary>
        /// 插入或者更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>true:插入操作；false:更新操作</return>
        public bool Set(S_sms_orderEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.OrderID) == null)
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
        public async Task<bool> SetAsync(S_sms_orderEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.OrderID) == null)
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
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public S_sms_orderEO GetByPK(string orderID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(orderID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<S_sms_orderEO> GetByPKAsync(string orderID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(orderID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        private void RepairGetByPKData(string orderID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`OrderID` = @OrderID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 SmsID（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetSmsIDByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`SmsID`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<string> GetSmsIDByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`SmsID`", "`OrderID` = @OrderID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 CountryID（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetCountryIDByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`CountryID`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<string> GetCountryIDByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`CountryID`", "`OrderID` = @OrderID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 SendTemplate（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetSendTemplateByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`SendTemplate`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<string> GetSendTemplateByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`SendTemplate`", "`OrderID` = @OrderID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 AppID（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetAppIDByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`AppID`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<string> GetAppIDByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`AppID`", "`OrderID` = @OrderID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 OperatorID（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetOperatorIDByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`OperatorID`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<string> GetOperatorIDByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`OperatorID`", "`OrderID` = @OrderID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 UserID（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetUserIDByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`UserID`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<string> GetUserIDByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`UserID`", "`OrderID` = @OrderID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 RequestTime（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public DateTime GetRequestTimeByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (DateTime)GetScalar("`RequestTime`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<DateTime> GetRequestTimeByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (DateTime)await GetScalarAsync("`RequestTime`", "`OrderID` = @OrderID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 RequestBody（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetRequestBodyByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`RequestBody`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<string> GetRequestBodyByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`RequestBody`", "`OrderID` = @OrderID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Status（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetStatusByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`Status`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<int> GetStatusByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`Status`", "`OrderID` = @OrderID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 RecDate（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public DateTime GetRecDateByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (DateTime)GetScalar("`RecDate`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<DateTime> GetRecDateByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (DateTime)await GetScalarAsync("`RecDate`", "`OrderID` = @OrderID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 SmsOrderId（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetSmsOrderIdByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`SmsOrderId`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<string> GetSmsOrderIdByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`SmsOrderId`", "`OrderID` = @OrderID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 ResponseTime（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public DateTime? GetResponseTimeByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (DateTime?)GetScalar("`ResponseTime`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<DateTime?> GetResponseTimeByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (DateTime?)await GetScalarAsync("`ResponseTime`", "`OrderID` = @OrderID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 ResponseBody（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetResponseBodyByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`ResponseBody`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<string> GetResponseBodyByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`ResponseBody`", "`OrderID` = @OrderID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Exception（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetExceptionByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`Exception`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<string> GetExceptionByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`Exception`", "`OrderID` = @OrderID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 SettlTable（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetSettlTableByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`SettlTable`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<string> GetSettlTableByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`SettlTable`", "`OrderID` = @OrderID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 SettlId（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetSettlIdByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`SettlId`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<string> GetSettlIdByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`SettlId`", "`OrderID` = @OrderID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 SettlStatus（字段）
        /// </summary>
        /// /// <param name = "orderID">订单ID GUID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetSettlStatusByPK(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`SettlStatus`", "`OrderID` = @OrderID", paras_, tm_);
        }
        public async Task<int> GetSettlStatusByPKAsync(string orderID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`SettlStatus`", "`OrderID` = @OrderID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetBySmsID

        /// <summary>
        /// 按 SmsID（字段） 查询
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySmsID(string smsID)
        {
            return GetBySmsID(smsID, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySmsIDAsync(string smsID)
        {
            return await GetBySmsIDAsync(smsID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 SmsID（字段） 查询
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySmsID(string smsID, TransactionManager tm_)
        {
            return GetBySmsID(smsID, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySmsIDAsync(string smsID, TransactionManager tm_)
        {
            return await GetBySmsIDAsync(smsID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SmsID（字段） 查询
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySmsID(string smsID, int top_)
        {
            return GetBySmsID(smsID, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySmsIDAsync(string smsID, int top_)
        {
            return await GetBySmsIDAsync(smsID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 SmsID（字段） 查询
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySmsID(string smsID, int top_, TransactionManager tm_)
        {
            return GetBySmsID(smsID, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySmsIDAsync(string smsID, int top_, TransactionManager tm_)
        {
            return await GetBySmsIDAsync(smsID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SmsID（字段） 查询
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySmsID(string smsID, string sort_)
        {
            return GetBySmsID(smsID, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySmsIDAsync(string smsID, string sort_)
        {
            return await GetBySmsIDAsync(smsID, 0, sort_, null);
        }

        /// <summary>
        /// 按 SmsID（字段） 查询
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySmsID(string smsID, string sort_, TransactionManager tm_)
        {
            return GetBySmsID(smsID, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySmsIDAsync(string smsID, string sort_, TransactionManager tm_)
        {
            return await GetBySmsIDAsync(smsID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 SmsID（字段） 查询
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySmsID(string smsID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(smsID != null ? "`SmsID` = @SmsID" : "`SmsID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (smsID != null)
                paras_.Add(Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetBySmsIDAsync(string smsID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(smsID != null ? "`SmsID` = @SmsID" : "`SmsID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (smsID != null)
                paras_.Add(Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetBySmsID
        #region GetByCountryID

        /// <summary>
        /// 按 CountryID（字段） 查询
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByCountryID(string countryID)
        {
            return GetByCountryID(countryID, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByCountryIDAsync(string countryID)
        {
            return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 CountryID（字段） 查询
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByCountryID(string countryID, TransactionManager tm_)
        {
            return GetByCountryID(countryID, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
        {
            return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CountryID（字段） 查询
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByCountryID(string countryID, int top_)
        {
            return GetByCountryID(countryID, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByCountryIDAsync(string countryID, int top_)
        {
            return await GetByCountryIDAsync(countryID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 CountryID（字段） 查询
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
        {
            return GetByCountryID(countryID, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
        {
            return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CountryID（字段） 查询
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByCountryID(string countryID, string sort_)
        {
            return GetByCountryID(countryID, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetByCountryIDAsync(string countryID, string sort_)
        {
            return await GetByCountryIDAsync(countryID, 0, sort_, null);
        }

        /// <summary>
        /// 按 CountryID（字段） 查询
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
        {
            return GetByCountryID(countryID, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
        {
            return await GetByCountryIDAsync(countryID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 CountryID（字段） 查询
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (countryID != null)
                paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (countryID != null)
                paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetByCountryID
        #region GetBySendTemplate

        /// <summary>
        /// 按 SendTemplate（字段） 查询
        /// </summary>
        /// /// <param name = "sendTemplate">发送模板名（s_sms_country表的模板列名）</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySendTemplate(string sendTemplate)
        {
            return GetBySendTemplate(sendTemplate, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySendTemplateAsync(string sendTemplate)
        {
            return await GetBySendTemplateAsync(sendTemplate, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 SendTemplate（字段） 查询
        /// </summary>
        /// /// <param name = "sendTemplate">发送模板名（s_sms_country表的模板列名）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySendTemplate(string sendTemplate, TransactionManager tm_)
        {
            return GetBySendTemplate(sendTemplate, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySendTemplateAsync(string sendTemplate, TransactionManager tm_)
        {
            return await GetBySendTemplateAsync(sendTemplate, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SendTemplate（字段） 查询
        /// </summary>
        /// /// <param name = "sendTemplate">发送模板名（s_sms_country表的模板列名）</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySendTemplate(string sendTemplate, int top_)
        {
            return GetBySendTemplate(sendTemplate, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySendTemplateAsync(string sendTemplate, int top_)
        {
            return await GetBySendTemplateAsync(sendTemplate, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 SendTemplate（字段） 查询
        /// </summary>
        /// /// <param name = "sendTemplate">发送模板名（s_sms_country表的模板列名）</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySendTemplate(string sendTemplate, int top_, TransactionManager tm_)
        {
            return GetBySendTemplate(sendTemplate, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySendTemplateAsync(string sendTemplate, int top_, TransactionManager tm_)
        {
            return await GetBySendTemplateAsync(sendTemplate, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SendTemplate（字段） 查询
        /// </summary>
        /// /// <param name = "sendTemplate">发送模板名（s_sms_country表的模板列名）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySendTemplate(string sendTemplate, string sort_)
        {
            return GetBySendTemplate(sendTemplate, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySendTemplateAsync(string sendTemplate, string sort_)
        {
            return await GetBySendTemplateAsync(sendTemplate, 0, sort_, null);
        }

        /// <summary>
        /// 按 SendTemplate（字段） 查询
        /// </summary>
        /// /// <param name = "sendTemplate">发送模板名（s_sms_country表的模板列名）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySendTemplate(string sendTemplate, string sort_, TransactionManager tm_)
        {
            return GetBySendTemplate(sendTemplate, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySendTemplateAsync(string sendTemplate, string sort_, TransactionManager tm_)
        {
            return await GetBySendTemplateAsync(sendTemplate, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 SendTemplate（字段） 查询
        /// </summary>
        /// /// <param name = "sendTemplate">发送模板名（s_sms_country表的模板列名）</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySendTemplate(string sendTemplate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(sendTemplate != null ? "`SendTemplate` = @SendTemplate" : "`SendTemplate` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (sendTemplate != null)
                paras_.Add(Database.CreateInParameter("@SendTemplate", sendTemplate, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetBySendTemplateAsync(string sendTemplate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(sendTemplate != null ? "`SendTemplate` = @SendTemplate" : "`SendTemplate` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (sendTemplate != null)
                paras_.Add(Database.CreateInParameter("@SendTemplate", sendTemplate, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetBySendTemplate
        #region GetByAppID

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">应用编码</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByAppID(string appID)
        {
            return GetByAppID(appID, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByAppIDAsync(string appID)
        {
            return await GetByAppIDAsync(appID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">应用编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByAppID(string appID, TransactionManager tm_)
        {
            return GetByAppID(appID, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
        {
            return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">应用编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByAppID(string appID, int top_)
        {
            return GetByAppID(appID, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByAppIDAsync(string appID, int top_)
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
        public List<S_sms_orderEO> GetByAppID(string appID, int top_, TransactionManager tm_)
        {
            return GetByAppID(appID, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
        {
            return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">应用编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByAppID(string appID, string sort_)
        {
            return GetByAppID(appID, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetByAppIDAsync(string appID, string sort_)
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
        public List<S_sms_orderEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
        {
            return GetByAppID(appID, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
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
        public List<S_sms_orderEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (appID != null)
                paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (appID != null)
                paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetByAppID
        #region GetByOperatorID

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByOperatorID(string operatorID)
        {
            return GetByOperatorID(operatorID, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByOperatorIDAsync(string operatorID)
        {
            return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByOperatorID(string operatorID, TransactionManager tm_)
        {
            return GetByOperatorID(operatorID, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
        {
            return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByOperatorID(string operatorID, int top_)
        {
            return GetByOperatorID(operatorID, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
        public List<S_sms_orderEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
        {
            return GetByOperatorID(operatorID, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
        {
            return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByOperatorID(string operatorID, string sort_)
        {
            return GetByOperatorID(operatorID, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
        public List<S_sms_orderEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
        {
            return GetByOperatorID(operatorID, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
        public List<S_sms_orderEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (operatorID != null)
                paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (operatorID != null)
                paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetByOperatorID
        #region GetByUserID

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByUserID(string userID)
        {
            return GetByUserID(userID, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByUserIDAsync(string userID)
        {
            return await GetByUserIDAsync(userID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByUserID(string userID, TransactionManager tm_)
        {
            return GetByUserID(userID, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
        {
            return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByUserID(string userID, int top_)
        {
            return GetByUserID(userID, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByUserIDAsync(string userID, int top_)
        {
            return await GetByUserIDAsync(userID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByUserID(string userID, int top_, TransactionManager tm_)
        {
            return GetByUserID(userID, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
        {
            return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByUserID(string userID, string sort_)
        {
            return GetByUserID(userID, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetByUserIDAsync(string userID, string sort_)
        {
            return await GetByUserIDAsync(userID, 0, sort_, null);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
        {
            return GetByUserID(userID, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
        {
            return await GetByUserIDAsync(userID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (userID != null)
                paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (userID != null)
                paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetByUserID
        #region GetByRequestTime

        /// <summary>
        /// 按 RequestTime（字段） 查询
        /// </summary>
        /// /// <param name = "requestTime">请求时间</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRequestTime(DateTime requestTime)
        {
            return GetByRequestTime(requestTime, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByRequestTimeAsync(DateTime requestTime)
        {
            return await GetByRequestTimeAsync(requestTime, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 RequestTime（字段） 查询
        /// </summary>
        /// /// <param name = "requestTime">请求时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRequestTime(DateTime requestTime, TransactionManager tm_)
        {
            return GetByRequestTime(requestTime, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByRequestTimeAsync(DateTime requestTime, TransactionManager tm_)
        {
            return await GetByRequestTimeAsync(requestTime, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RequestTime（字段） 查询
        /// </summary>
        /// /// <param name = "requestTime">请求时间</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRequestTime(DateTime requestTime, int top_)
        {
            return GetByRequestTime(requestTime, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByRequestTimeAsync(DateTime requestTime, int top_)
        {
            return await GetByRequestTimeAsync(requestTime, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 RequestTime（字段） 查询
        /// </summary>
        /// /// <param name = "requestTime">请求时间</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRequestTime(DateTime requestTime, int top_, TransactionManager tm_)
        {
            return GetByRequestTime(requestTime, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByRequestTimeAsync(DateTime requestTime, int top_, TransactionManager tm_)
        {
            return await GetByRequestTimeAsync(requestTime, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RequestTime（字段） 查询
        /// </summary>
        /// /// <param name = "requestTime">请求时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRequestTime(DateTime requestTime, string sort_)
        {
            return GetByRequestTime(requestTime, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetByRequestTimeAsync(DateTime requestTime, string sort_)
        {
            return await GetByRequestTimeAsync(requestTime, 0, sort_, null);
        }

        /// <summary>
        /// 按 RequestTime（字段） 查询
        /// </summary>
        /// /// <param name = "requestTime">请求时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRequestTime(DateTime requestTime, string sort_, TransactionManager tm_)
        {
            return GetByRequestTime(requestTime, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByRequestTimeAsync(DateTime requestTime, string sort_, TransactionManager tm_)
        {
            return await GetByRequestTimeAsync(requestTime, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 RequestTime（字段） 查询
        /// </summary>
        /// /// <param name = "requestTime">请求时间</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRequestTime(DateTime requestTime, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RequestTime` = @RequestTime", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RequestTime", requestTime, MySqlDbType.DateTime));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetByRequestTimeAsync(DateTime requestTime, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RequestTime` = @RequestTime", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RequestTime", requestTime, MySqlDbType.DateTime));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetByRequestTime
        #region GetByRequestBody

        /// <summary>
        /// 按 RequestBody（字段） 查询
        /// </summary>
        /// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRequestBody(string requestBody)
        {
            return GetByRequestBody(requestBody, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByRequestBodyAsync(string requestBody)
        {
            return await GetByRequestBodyAsync(requestBody, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 RequestBody（字段） 查询
        /// </summary>
        /// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRequestBody(string requestBody, TransactionManager tm_)
        {
            return GetByRequestBody(requestBody, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByRequestBodyAsync(string requestBody, TransactionManager tm_)
        {
            return await GetByRequestBodyAsync(requestBody, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RequestBody（字段） 查询
        /// </summary>
        /// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRequestBody(string requestBody, int top_)
        {
            return GetByRequestBody(requestBody, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByRequestBodyAsync(string requestBody, int top_)
        {
            return await GetByRequestBodyAsync(requestBody, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 RequestBody（字段） 查询
        /// </summary>
        /// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRequestBody(string requestBody, int top_, TransactionManager tm_)
        {
            return GetByRequestBody(requestBody, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByRequestBodyAsync(string requestBody, int top_, TransactionManager tm_)
        {
            return await GetByRequestBodyAsync(requestBody, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RequestBody（字段） 查询
        /// </summary>
        /// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRequestBody(string requestBody, string sort_)
        {
            return GetByRequestBody(requestBody, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetByRequestBodyAsync(string requestBody, string sort_)
        {
            return await GetByRequestBodyAsync(requestBody, 0, sort_, null);
        }

        /// <summary>
        /// 按 RequestBody（字段） 查询
        /// </summary>
        /// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRequestBody(string requestBody, string sort_, TransactionManager tm_)
        {
            return GetByRequestBody(requestBody, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByRequestBodyAsync(string requestBody, string sort_, TransactionManager tm_)
        {
            return await GetByRequestBodyAsync(requestBody, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 RequestBody（字段） 查询
        /// </summary>
        /// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRequestBody(string requestBody, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(requestBody != null ? "`RequestBody` = @RequestBody" : "`RequestBody` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (requestBody != null)
                paras_.Add(Database.CreateInParameter("@RequestBody", requestBody, MySqlDbType.Text));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetByRequestBodyAsync(string requestBody, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(requestBody != null ? "`RequestBody` = @RequestBody" : "`RequestBody` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (requestBody != null)
                paras_.Add(Database.CreateInParameter("@RequestBody", requestBody, MySqlDbType.Text));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetByRequestBody
        #region GetByStatus

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByStatus(int status)
        {
            return GetByStatus(status, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByStatusAsync(int status)
        {
            return await GetByStatusAsync(status, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByStatus(int status, TransactionManager tm_)
        {
            return GetByStatus(status, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByStatusAsync(int status, TransactionManager tm_)
        {
            return await GetByStatusAsync(status, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByStatus(int status, int top_)
        {
            return GetByStatus(status, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByStatusAsync(int status, int top_)
        {
            return await GetByStatusAsync(status, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByStatus(int status, int top_, TransactionManager tm_)
        {
            return GetByStatus(status, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
        {
            return await GetByStatusAsync(status, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByStatus(int status, string sort_)
        {
            return GetByStatus(status, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetByStatusAsync(int status, string sort_)
        {
            return await GetByStatusAsync(status, 0, sort_, null);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByStatus(int status, string sort_, TransactionManager tm_)
        {
            return GetByStatus(status, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
        {
            return await GetByStatusAsync(status, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetByStatus
        #region GetByRecDate

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRecDate(DateTime recDate)
        {
            return GetByRecDate(recDate, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByRecDateAsync(DateTime recDate)
        {
            return await GetByRecDateAsync(recDate, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
        {
            return GetByRecDate(recDate, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
        {
            return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRecDate(DateTime recDate, int top_)
        {
            return GetByRecDate(recDate, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
        public List<S_sms_orderEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
        {
            return GetByRecDate(recDate, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
        {
            return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByRecDate(DateTime recDate, string sort_)
        {
            return GetByRecDate(recDate, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
        public List<S_sms_orderEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
        {
            return GetByRecDate(recDate, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
        public List<S_sms_orderEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetByRecDate
        #region GetBySmsOrderId

        /// <summary>
        /// 按 SmsOrderId（字段） 查询
        /// </summary>
        /// /// <param name = "smsOrderId">短信商订单编码</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySmsOrderId(string smsOrderId)
        {
            return GetBySmsOrderId(smsOrderId, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySmsOrderIdAsync(string smsOrderId)
        {
            return await GetBySmsOrderIdAsync(smsOrderId, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 SmsOrderId（字段） 查询
        /// </summary>
        /// /// <param name = "smsOrderId">短信商订单编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySmsOrderId(string smsOrderId, TransactionManager tm_)
        {
            return GetBySmsOrderId(smsOrderId, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySmsOrderIdAsync(string smsOrderId, TransactionManager tm_)
        {
            return await GetBySmsOrderIdAsync(smsOrderId, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SmsOrderId（字段） 查询
        /// </summary>
        /// /// <param name = "smsOrderId">短信商订单编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySmsOrderId(string smsOrderId, int top_)
        {
            return GetBySmsOrderId(smsOrderId, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySmsOrderIdAsync(string smsOrderId, int top_)
        {
            return await GetBySmsOrderIdAsync(smsOrderId, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 SmsOrderId（字段） 查询
        /// </summary>
        /// /// <param name = "smsOrderId">短信商订单编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySmsOrderId(string smsOrderId, int top_, TransactionManager tm_)
        {
            return GetBySmsOrderId(smsOrderId, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySmsOrderIdAsync(string smsOrderId, int top_, TransactionManager tm_)
        {
            return await GetBySmsOrderIdAsync(smsOrderId, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SmsOrderId（字段） 查询
        /// </summary>
        /// /// <param name = "smsOrderId">短信商订单编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySmsOrderId(string smsOrderId, string sort_)
        {
            return GetBySmsOrderId(smsOrderId, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySmsOrderIdAsync(string smsOrderId, string sort_)
        {
            return await GetBySmsOrderIdAsync(smsOrderId, 0, sort_, null);
        }

        /// <summary>
        /// 按 SmsOrderId（字段） 查询
        /// </summary>
        /// /// <param name = "smsOrderId">短信商订单编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySmsOrderId(string smsOrderId, string sort_, TransactionManager tm_)
        {
            return GetBySmsOrderId(smsOrderId, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySmsOrderIdAsync(string smsOrderId, string sort_, TransactionManager tm_)
        {
            return await GetBySmsOrderIdAsync(smsOrderId, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 SmsOrderId（字段） 查询
        /// </summary>
        /// /// <param name = "smsOrderId">短信商订单编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySmsOrderId(string smsOrderId, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(smsOrderId != null ? "`SmsOrderId` = @SmsOrderId" : "`SmsOrderId` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (smsOrderId != null)
                paras_.Add(Database.CreateInParameter("@SmsOrderId", smsOrderId, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetBySmsOrderIdAsync(string smsOrderId, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(smsOrderId != null ? "`SmsOrderId` = @SmsOrderId" : "`SmsOrderId` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (smsOrderId != null)
                paras_.Add(Database.CreateInParameter("@SmsOrderId", smsOrderId, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetBySmsOrderId
        #region GetByResponseTime

        /// <summary>
        /// 按 ResponseTime（字段） 查询
        /// </summary>
        /// /// <param name = "responseTime">返回时间</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByResponseTime(DateTime? responseTime)
        {
            return GetByResponseTime(responseTime, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByResponseTimeAsync(DateTime? responseTime)
        {
            return await GetByResponseTimeAsync(responseTime, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 ResponseTime（字段） 查询
        /// </summary>
        /// /// <param name = "responseTime">返回时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByResponseTime(DateTime? responseTime, TransactionManager tm_)
        {
            return GetByResponseTime(responseTime, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByResponseTimeAsync(DateTime? responseTime, TransactionManager tm_)
        {
            return await GetByResponseTimeAsync(responseTime, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ResponseTime（字段） 查询
        /// </summary>
        /// /// <param name = "responseTime">返回时间</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByResponseTime(DateTime? responseTime, int top_)
        {
            return GetByResponseTime(responseTime, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByResponseTimeAsync(DateTime? responseTime, int top_)
        {
            return await GetByResponseTimeAsync(responseTime, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 ResponseTime（字段） 查询
        /// </summary>
        /// /// <param name = "responseTime">返回时间</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByResponseTime(DateTime? responseTime, int top_, TransactionManager tm_)
        {
            return GetByResponseTime(responseTime, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByResponseTimeAsync(DateTime? responseTime, int top_, TransactionManager tm_)
        {
            return await GetByResponseTimeAsync(responseTime, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ResponseTime（字段） 查询
        /// </summary>
        /// /// <param name = "responseTime">返回时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByResponseTime(DateTime? responseTime, string sort_)
        {
            return GetByResponseTime(responseTime, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetByResponseTimeAsync(DateTime? responseTime, string sort_)
        {
            return await GetByResponseTimeAsync(responseTime, 0, sort_, null);
        }

        /// <summary>
        /// 按 ResponseTime（字段） 查询
        /// </summary>
        /// /// <param name = "responseTime">返回时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByResponseTime(DateTime? responseTime, string sort_, TransactionManager tm_)
        {
            return GetByResponseTime(responseTime, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByResponseTimeAsync(DateTime? responseTime, string sort_, TransactionManager tm_)
        {
            return await GetByResponseTimeAsync(responseTime, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 ResponseTime（字段） 查询
        /// </summary>
        /// /// <param name = "responseTime">返回时间</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByResponseTime(DateTime? responseTime, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(responseTime.HasValue ? "`ResponseTime` = @ResponseTime" : "`ResponseTime` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (responseTime.HasValue)
                paras_.Add(Database.CreateInParameter("@ResponseTime", responseTime.Value, MySqlDbType.DateTime));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetByResponseTimeAsync(DateTime? responseTime, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(responseTime.HasValue ? "`ResponseTime` = @ResponseTime" : "`ResponseTime` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (responseTime.HasValue)
                paras_.Add(Database.CreateInParameter("@ResponseTime", responseTime.Value, MySqlDbType.DateTime));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetByResponseTime
        #region GetByResponseBody

        /// <summary>
        /// 按 ResponseBody（字段） 查询
        /// </summary>
        /// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByResponseBody(string responseBody)
        {
            return GetByResponseBody(responseBody, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByResponseBodyAsync(string responseBody)
        {
            return await GetByResponseBodyAsync(responseBody, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 ResponseBody（字段） 查询
        /// </summary>
        /// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByResponseBody(string responseBody, TransactionManager tm_)
        {
            return GetByResponseBody(responseBody, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByResponseBodyAsync(string responseBody, TransactionManager tm_)
        {
            return await GetByResponseBodyAsync(responseBody, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ResponseBody（字段） 查询
        /// </summary>
        /// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByResponseBody(string responseBody, int top_)
        {
            return GetByResponseBody(responseBody, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByResponseBodyAsync(string responseBody, int top_)
        {
            return await GetByResponseBodyAsync(responseBody, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 ResponseBody（字段） 查询
        /// </summary>
        /// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByResponseBody(string responseBody, int top_, TransactionManager tm_)
        {
            return GetByResponseBody(responseBody, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByResponseBodyAsync(string responseBody, int top_, TransactionManager tm_)
        {
            return await GetByResponseBodyAsync(responseBody, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ResponseBody（字段） 查询
        /// </summary>
        /// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByResponseBody(string responseBody, string sort_)
        {
            return GetByResponseBody(responseBody, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetByResponseBodyAsync(string responseBody, string sort_)
        {
            return await GetByResponseBodyAsync(responseBody, 0, sort_, null);
        }

        /// <summary>
        /// 按 ResponseBody（字段） 查询
        /// </summary>
        /// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByResponseBody(string responseBody, string sort_, TransactionManager tm_)
        {
            return GetByResponseBody(responseBody, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByResponseBodyAsync(string responseBody, string sort_, TransactionManager tm_)
        {
            return await GetByResponseBodyAsync(responseBody, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 ResponseBody（字段） 查询
        /// </summary>
        /// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByResponseBody(string responseBody, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(responseBody != null ? "`ResponseBody` = @ResponseBody" : "`ResponseBody` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (responseBody != null)
                paras_.Add(Database.CreateInParameter("@ResponseBody", responseBody, MySqlDbType.Text));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetByResponseBodyAsync(string responseBody, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(responseBody != null ? "`ResponseBody` = @ResponseBody" : "`ResponseBody` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (responseBody != null)
                paras_.Add(Database.CreateInParameter("@ResponseBody", responseBody, MySqlDbType.Text));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetByResponseBody
        #region GetByException

        /// <summary>
        /// 按 Exception（字段） 查询
        /// </summary>
        /// /// <param name = "exception">异常消息</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByException(string exception)
        {
            return GetByException(exception, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByExceptionAsync(string exception)
        {
            return await GetByExceptionAsync(exception, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Exception（字段） 查询
        /// </summary>
        /// /// <param name = "exception">异常消息</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByException(string exception, TransactionManager tm_)
        {
            return GetByException(exception, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByExceptionAsync(string exception, TransactionManager tm_)
        {
            return await GetByExceptionAsync(exception, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Exception（字段） 查询
        /// </summary>
        /// /// <param name = "exception">异常消息</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByException(string exception, int top_)
        {
            return GetByException(exception, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetByExceptionAsync(string exception, int top_)
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
        public List<S_sms_orderEO> GetByException(string exception, int top_, TransactionManager tm_)
        {
            return GetByException(exception, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByExceptionAsync(string exception, int top_, TransactionManager tm_)
        {
            return await GetByExceptionAsync(exception, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Exception（字段） 查询
        /// </summary>
        /// /// <param name = "exception">异常消息</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetByException(string exception, string sort_)
        {
            return GetByException(exception, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetByExceptionAsync(string exception, string sort_)
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
        public List<S_sms_orderEO> GetByException(string exception, string sort_, TransactionManager tm_)
        {
            return GetByException(exception, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetByExceptionAsync(string exception, string sort_, TransactionManager tm_)
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
        public List<S_sms_orderEO> GetByException(string exception, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(exception != null ? "`Exception` = @Exception" : "`Exception` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (exception != null)
                paras_.Add(Database.CreateInParameter("@Exception", exception, MySqlDbType.Text));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetByExceptionAsync(string exception, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(exception != null ? "`Exception` = @Exception" : "`Exception` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (exception != null)
                paras_.Add(Database.CreateInParameter("@Exception", exception, MySqlDbType.Text));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetByException
        #region GetBySettlTable

        /// <summary>
        /// 按 SettlTable（字段） 查询
        /// </summary>
        /// /// <param name = "settlTable">结算表名</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlTable(string settlTable)
        {
            return GetBySettlTable(settlTable, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlTableAsync(string settlTable)
        {
            return await GetBySettlTableAsync(settlTable, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 SettlTable（字段） 查询
        /// </summary>
        /// /// <param name = "settlTable">结算表名</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlTable(string settlTable, TransactionManager tm_)
        {
            return GetBySettlTable(settlTable, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlTableAsync(string settlTable, TransactionManager tm_)
        {
            return await GetBySettlTableAsync(settlTable, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SettlTable（字段） 查询
        /// </summary>
        /// /// <param name = "settlTable">结算表名</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlTable(string settlTable, int top_)
        {
            return GetBySettlTable(settlTable, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlTableAsync(string settlTable, int top_)
        {
            return await GetBySettlTableAsync(settlTable, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 SettlTable（字段） 查询
        /// </summary>
        /// /// <param name = "settlTable">结算表名</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlTable(string settlTable, int top_, TransactionManager tm_)
        {
            return GetBySettlTable(settlTable, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlTableAsync(string settlTable, int top_, TransactionManager tm_)
        {
            return await GetBySettlTableAsync(settlTable, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SettlTable（字段） 查询
        /// </summary>
        /// /// <param name = "settlTable">结算表名</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlTable(string settlTable, string sort_)
        {
            return GetBySettlTable(settlTable, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlTableAsync(string settlTable, string sort_)
        {
            return await GetBySettlTableAsync(settlTable, 0, sort_, null);
        }

        /// <summary>
        /// 按 SettlTable（字段） 查询
        /// </summary>
        /// /// <param name = "settlTable">结算表名</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlTable(string settlTable, string sort_, TransactionManager tm_)
        {
            return GetBySettlTable(settlTable, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlTableAsync(string settlTable, string sort_, TransactionManager tm_)
        {
            return await GetBySettlTableAsync(settlTable, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 SettlTable（字段） 查询
        /// </summary>
        /// /// <param name = "settlTable">结算表名</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlTable(string settlTable, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(settlTable != null ? "`SettlTable` = @SettlTable" : "`SettlTable` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (settlTable != null)
                paras_.Add(Database.CreateInParameter("@SettlTable", settlTable, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlTableAsync(string settlTable, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(settlTable != null ? "`SettlTable` = @SettlTable" : "`SettlTable` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (settlTable != null)
                paras_.Add(Database.CreateInParameter("@SettlTable", settlTable, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetBySettlTable
        #region GetBySettlId

        /// <summary>
        /// 按 SettlId（字段） 查询
        /// </summary>
        /// /// <param name = "settlId">结算编码</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlId(string settlId)
        {
            return GetBySettlId(settlId, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlIdAsync(string settlId)
        {
            return await GetBySettlIdAsync(settlId, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 SettlId（字段） 查询
        /// </summary>
        /// /// <param name = "settlId">结算编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlId(string settlId, TransactionManager tm_)
        {
            return GetBySettlId(settlId, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlIdAsync(string settlId, TransactionManager tm_)
        {
            return await GetBySettlIdAsync(settlId, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SettlId（字段） 查询
        /// </summary>
        /// /// <param name = "settlId">结算编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlId(string settlId, int top_)
        {
            return GetBySettlId(settlId, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlIdAsync(string settlId, int top_)
        {
            return await GetBySettlIdAsync(settlId, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 SettlId（字段） 查询
        /// </summary>
        /// /// <param name = "settlId">结算编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlId(string settlId, int top_, TransactionManager tm_)
        {
            return GetBySettlId(settlId, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlIdAsync(string settlId, int top_, TransactionManager tm_)
        {
            return await GetBySettlIdAsync(settlId, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SettlId（字段） 查询
        /// </summary>
        /// /// <param name = "settlId">结算编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlId(string settlId, string sort_)
        {
            return GetBySettlId(settlId, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlIdAsync(string settlId, string sort_)
        {
            return await GetBySettlIdAsync(settlId, 0, sort_, null);
        }

        /// <summary>
        /// 按 SettlId（字段） 查询
        /// </summary>
        /// /// <param name = "settlId">结算编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlId(string settlId, string sort_, TransactionManager tm_)
        {
            return GetBySettlId(settlId, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlIdAsync(string settlId, string sort_, TransactionManager tm_)
        {
            return await GetBySettlIdAsync(settlId, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 SettlId（字段） 查询
        /// </summary>
        /// /// <param name = "settlId">结算编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlId(string settlId, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(settlId != null ? "`SettlId` = @SettlId" : "`SettlId` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (settlId != null)
                paras_.Add(Database.CreateInParameter("@SettlId", settlId, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlIdAsync(string settlId, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(settlId != null ? "`SettlId` = @SettlId" : "`SettlId` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (settlId != null)
                paras_.Add(Database.CreateInParameter("@SettlId", settlId, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetBySettlId
        #region GetBySettlStatus

        /// <summary>
        /// 按 SettlStatus（字段） 查询
        /// </summary>
        /// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlStatus(int settlStatus)
        {
            return GetBySettlStatus(settlStatus, 0, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlStatusAsync(int settlStatus)
        {
            return await GetBySettlStatusAsync(settlStatus, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 SettlStatus（字段） 查询
        /// </summary>
        /// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlStatus(int settlStatus, TransactionManager tm_)
        {
            return GetBySettlStatus(settlStatus, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlStatusAsync(int settlStatus, TransactionManager tm_)
        {
            return await GetBySettlStatusAsync(settlStatus, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SettlStatus（字段） 查询
        /// </summary>
        /// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlStatus(int settlStatus, int top_)
        {
            return GetBySettlStatus(settlStatus, top_, string.Empty, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlStatusAsync(int settlStatus, int top_)
        {
            return await GetBySettlStatusAsync(settlStatus, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 SettlStatus（字段） 查询
        /// </summary>
        /// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlStatus(int settlStatus, int top_, TransactionManager tm_)
        {
            return GetBySettlStatus(settlStatus, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlStatusAsync(int settlStatus, int top_, TransactionManager tm_)
        {
            return await GetBySettlStatusAsync(settlStatus, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SettlStatus（字段） 查询
        /// </summary>
        /// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlStatus(int settlStatus, string sort_)
        {
            return GetBySettlStatus(settlStatus, 0, sort_, null);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlStatusAsync(int settlStatus, string sort_)
        {
            return await GetBySettlStatusAsync(settlStatus, 0, sort_, null);
        }

        /// <summary>
        /// 按 SettlStatus（字段） 查询
        /// </summary>
        /// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlStatus(int settlStatus, string sort_, TransactionManager tm_)
        {
            return GetBySettlStatus(settlStatus, 0, sort_, tm_);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlStatusAsync(int settlStatus, string sort_, TransactionManager tm_)
        {
            return await GetBySettlStatusAsync(settlStatus, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 SettlStatus（字段） 查询
        /// </summary>
        /// /// <param name = "settlStatus">结算状态（0-未结算1-已结算）</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_orderEO> GetBySettlStatus(int settlStatus, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`SettlStatus` = @SettlStatus", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SettlStatus", settlStatus, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        public async Task<List<S_sms_orderEO>> GetBySettlStatusAsync(int settlStatus, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`SettlStatus` = @SettlStatus", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SettlStatus", settlStatus, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_orderEO.MapDataReader);
        }
        #endregion // GetBySettlStatus
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
