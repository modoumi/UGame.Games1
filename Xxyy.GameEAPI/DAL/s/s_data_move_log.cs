/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-11-08 15: 51:04
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
    /// 数据迁移日志
    /// 【表 s_data_move_log 的实体类】
    /// </summary>
    [DataContract]
    public class S_data_move_logEO : IRowMapper<S_data_move_logEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public S_data_move_logEO()
        {
            this.HandleMode = 0;
            this.KeepValue = 0;
            this.RowNum = 0;
            this.Status = 0;
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
        /// 日志编码(GUID)
        /// 【主键 varchar(38)】
        /// </summary>
        [DataMember(Order = 1)]
        public string LogID { get; set; }
        /// <summary>
        /// 数据迁移编码
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 2)]
        public int DataMoveID { get; set; }
        /// <summary>
        /// 数据库名（配置文件连接名或连接字符串）
        /// 【字段 varchar(1000)】
        /// </summary>
        [DataMember(Order = 3)]
        public string DatabaseName { get; set; }
        /// <summary>
        /// 表名
        /// 【字段 varchar(100)】
        /// </summary>
        [DataMember(Order = 4)]
        public string TableName { get; set; }
        /// <summary>
        /// 处理方式
        ///              0-删除数据
        ///              1-按年生成备份表：tablename_yyyy
        ///              2-按季度生成备份表：tablename_yyyy1,2,3,4
        ///              3-按月生成备份表：tablename_yyyyMM
        ///              4-按日生成备份表：tablename_yyyyMMdd
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 5)]
        public int HandleMode { get; set; }
        /// <summary>
        /// 保留数据长度（根据HandleMode值不同）HandleMode=
        ///              0-删除数据 ==> 表示保留的天数
        ///              1-按年生成备份表：tablename_yyyy =》 表示保留的年数
        ///              2-按季度生成备份表：tablename_yyyy1,2,3,4 ==》 表示保留的季节数
        ///              3-按月生成备份表：tablename_yyyyMM ==> 表示保留的月份数
        ///              4-按日生成备份表：tablename_yyyyMMdd ==> 表示保留的天数
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 6)]
        public int KeepValue { get; set; }
        /// <summary>
        /// 起始时间
        /// 【字段 date】
        /// </summary>
        [DataMember(Order = 7)]
        public DateTime BeginDate { get; set; }
        /// <summary>
        /// 结束时间
        /// 【字段 date】
        /// </summary>
        [DataMember(Order = 8)]
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 备份表名，|分割
        /// 【字段 text】
        /// </summary>
        [DataMember(Order = 9)]
        public string BackupTableName { get; set; }
        /// <summary>
        /// 执行SQL
        /// 【字段 longtext】
        /// </summary>
        [DataMember(Order = 10)]
        public string ExecSQL { get; set; }
        /// <summary>
        /// 处理记录数
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 11)]
        public int RowNum { get; set; }
        /// <summary>
        /// 异常消息
        /// 【字段 text】
        /// </summary>
        [DataMember(Order = 12)]
        public string Exception { get; set; }
        /// <summary>
        /// 状态(0-未知1-成功2-无数据3-失败)
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 13)]
        public int Status { get; set; }
        /// <summary>
        /// 记录时间
        /// 【字段 datetime】
        /// </summary>
        [DataMember(Order = 14)]
        public DateTime RecDate { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public S_data_move_logEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static S_data_move_logEO MapDataReader(IDataReader reader)
        {
            S_data_move_logEO ret = new S_data_move_logEO();
            ret.LogID = reader.ToString("LogID");
            ret.OriginalLogID = ret.LogID;
            ret.DataMoveID = reader.ToInt32("DataMoveID");
            ret.DatabaseName = reader.ToString("DatabaseName");
            ret.TableName = reader.ToString("TableName");
            ret.HandleMode = reader.ToInt32("HandleMode");
            ret.KeepValue = reader.ToInt32("KeepValue");
            ret.BeginDate = reader.ToDateTime("BeginDate");
            ret.EndDate = reader.ToDateTime("EndDate");
            ret.BackupTableName = reader.ToString("BackupTableName");
            ret.ExecSQL = reader.ToString("ExecSQL");
            ret.RowNum = reader.ToInt32("RowNum");
            ret.Exception = reader.ToString("Exception");
            ret.Status = reader.ToInt32("Status");
            ret.RecDate = reader.ToDateTime("RecDate");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// 数据迁移日志
    /// 【表 s_data_move_log 的操作类】
    /// </summary>
    public class S_data_move_logMO : MySqlTableMO<S_data_move_logEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`s_data_move_log`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public S_data_move_logMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public S_data_move_logMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public S_data_move_logMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(S_data_move_logEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(S_data_move_logEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(S_data_move_logEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`LogID`, `DataMoveID`, `DatabaseName`, `TableName`, `HandleMode`, `KeepValue`, `BeginDate`, `EndDate`, `BackupTableName`, `ExecSQL`, `RowNum`, `Exception`, `Status`, `RecDate`) VALUE (@LogID, @DataMoveID, @DatabaseName, @TableName, @HandleMode, @KeepValue, @BeginDate, @EndDate, @BackupTableName, @ExecSQL, @RowNum, @Exception, @Status, @RecDate);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", item.LogID, MySqlDbType.VarChar),
                Database.CreateInParameter("@DataMoveID", item.DataMoveID, MySqlDbType.Int32),
                Database.CreateInParameter("@DatabaseName", item.DatabaseName != null ? item.DatabaseName : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@TableName", item.TableName, MySqlDbType.VarChar),
                Database.CreateInParameter("@HandleMode", item.HandleMode, MySqlDbType.Int32),
                Database.CreateInParameter("@KeepValue", item.KeepValue, MySqlDbType.Int32),
                Database.CreateInParameter("@BeginDate", item.BeginDate, MySqlDbType.Date),
                Database.CreateInParameter("@EndDate", item.EndDate, MySqlDbType.Date),
                Database.CreateInParameter("@BackupTableName", item.BackupTableName != null ? item.BackupTableName : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@ExecSQL", item.ExecSQL != null ? item.ExecSQL : (object)DBNull.Value, MySqlDbType.LongText),
                Database.CreateInParameter("@RowNum", item.RowNum, MySqlDbType.Int32),
                Database.CreateInParameter("@Exception", item.Exception != null ? item.Exception : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
                Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
            };
        }
        public int AddByBatch(IEnumerable<S_data_move_logEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<S_data_move_logEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_data_move_logEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`LogID`, `DataMoveID`, `DatabaseName`, `TableName`, `HandleMode`, `KeepValue`, `BeginDate`, `EndDate`, `BackupTableName`, `ExecSQL`, `RowNum`, `Exception`, `Status`, `RecDate`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"('{item.LogID}',{item.DataMoveID},'{item.DatabaseName}','{item.TableName}',{item.HandleMode},{item.KeepValue},'{item.BeginDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.EndDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.BackupTableName}','{item.ExecSQL}',{item.RowNum},'{item.Exception}',{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
        /// /// <param name = "logID">日志编码(GUID)</param>
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
        public int Remove(S_data_move_logEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.LogID, tm_);
        }
        public async Task<int> RemoveAsync(S_data_move_logEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.LogID, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
        #region RemoveByDataMoveID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByDataMoveID(int dataMoveID, TransactionManager tm_ = null)
        {
            RepairRemoveByDataMoveIDData(dataMoveID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByDataMoveIDAsync(int dataMoveID, TransactionManager tm_ = null)
        {
            RepairRemoveByDataMoveIDData(dataMoveID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByDataMoveIDData(int dataMoveID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `DataMoveID` = @DataMoveID";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32));
        }
        #endregion // RemoveByDataMoveID
        #region RemoveByDatabaseName
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "databaseName">数据库名（配置文件连接名或连接字符串）</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByDatabaseName(string databaseName, TransactionManager tm_ = null)
        {
            RepairRemoveByDatabaseNameData(databaseName, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByDatabaseNameAsync(string databaseName, TransactionManager tm_ = null)
        {
            RepairRemoveByDatabaseNameData(databaseName, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByDatabaseNameData(string databaseName, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (databaseName != null ? "`DatabaseName` = @DatabaseName" : "`DatabaseName` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (databaseName != null)
                paras_.Add(Database.CreateInParameter("@DatabaseName", databaseName, MySqlDbType.VarChar));
        }
        #endregion // RemoveByDatabaseName
        #region RemoveByTableName
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "tableName">表名</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByTableName(string tableName, TransactionManager tm_ = null)
        {
            RepairRemoveByTableNameData(tableName, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByTableNameAsync(string tableName, TransactionManager tm_ = null)
        {
            RepairRemoveByTableNameData(tableName, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByTableNameData(string tableName, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `TableName` = @TableName";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TableName", tableName, MySqlDbType.VarChar));
        }
        #endregion // RemoveByTableName
        #region RemoveByHandleMode
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "handleMode">处理方式</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByHandleMode(int handleMode, TransactionManager tm_ = null)
        {
            RepairRemoveByHandleModeData(handleMode, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByHandleModeAsync(int handleMode, TransactionManager tm_ = null)
        {
            RepairRemoveByHandleModeData(handleMode, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByHandleModeData(int handleMode, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `HandleMode` = @HandleMode";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@HandleMode", handleMode, MySqlDbType.Int32));
        }
        #endregion // RemoveByHandleMode
        #region RemoveByKeepValue
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）HandleMode=</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByKeepValue(int keepValue, TransactionManager tm_ = null)
        {
            RepairRemoveByKeepValueData(keepValue, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByKeepValueAsync(int keepValue, TransactionManager tm_ = null)
        {
            RepairRemoveByKeepValueData(keepValue, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByKeepValueData(int keepValue, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `KeepValue` = @KeepValue";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@KeepValue", keepValue, MySqlDbType.Int32));
        }
        #endregion // RemoveByKeepValue
        #region RemoveByBeginDate
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "beginDate">起始时间</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBeginDate(DateTime beginDate, TransactionManager tm_ = null)
        {
            RepairRemoveByBeginDateData(beginDate, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBeginDateAsync(DateTime beginDate, TransactionManager tm_ = null)
        {
            RepairRemoveByBeginDateData(beginDate, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBeginDateData(DateTime beginDate, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BeginDate` = @BeginDate";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.Date));
        }
        #endregion // RemoveByBeginDate
        #region RemoveByEndDate
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "endDate">结束时间</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByEndDate(DateTime endDate, TransactionManager tm_ = null)
        {
            RepairRemoveByEndDateData(endDate, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByEndDateAsync(DateTime endDate, TransactionManager tm_ = null)
        {
            RepairRemoveByEndDateData(endDate, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByEndDateData(DateTime endDate, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `EndDate` = @EndDate";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@EndDate", endDate, MySqlDbType.Date));
        }
        #endregion // RemoveByEndDate
        #region RemoveByBackupTableName
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "backupTableName">备份表名，|分割</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBackupTableName(string backupTableName, TransactionManager tm_ = null)
        {
            RepairRemoveByBackupTableNameData(backupTableName, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBackupTableNameAsync(string backupTableName, TransactionManager tm_ = null)
        {
            RepairRemoveByBackupTableNameData(backupTableName, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBackupTableNameData(string backupTableName, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (backupTableName != null ? "`BackupTableName` = @BackupTableName" : "`BackupTableName` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (backupTableName != null)
                paras_.Add(Database.CreateInParameter("@BackupTableName", backupTableName, MySqlDbType.Text));
        }
        #endregion // RemoveByBackupTableName
        #region RemoveByExecSQL
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "execSQL">执行SQL</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByExecSQL(string execSQL, TransactionManager tm_ = null)
        {
            RepairRemoveByExecSQLData(execSQL, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByExecSQLAsync(string execSQL, TransactionManager tm_ = null)
        {
            RepairRemoveByExecSQLData(execSQL, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByExecSQLData(string execSQL, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (execSQL != null ? "`ExecSQL` = @ExecSQL" : "`ExecSQL` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (execSQL != null)
                paras_.Add(Database.CreateInParameter("@ExecSQL", execSQL, MySqlDbType.LongText));
        }
        #endregion // RemoveByExecSQL
        #region RemoveByRowNum
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "rowNum">处理记录数</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByRowNum(int rowNum, TransactionManager tm_ = null)
        {
            RepairRemoveByRowNumData(rowNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByRowNumAsync(int rowNum, TransactionManager tm_ = null)
        {
            RepairRemoveByRowNumData(rowNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByRowNumData(int rowNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `RowNum` = @RowNum";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RowNum", rowNum, MySqlDbType.Int32));
        }
        #endregion // RemoveByRowNum
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
        #region RemoveByStatus
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "status">状态(0-未知1-成功2-无数据3-失败)</param>
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
        public int Put(S_data_move_logEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(S_data_move_logEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(S_data_move_logEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `LogID` = @LogID, `DataMoveID` = @DataMoveID, `DatabaseName` = @DatabaseName, `TableName` = @TableName, `HandleMode` = @HandleMode, `KeepValue` = @KeepValue, `BeginDate` = @BeginDate, `EndDate` = @EndDate, `BackupTableName` = @BackupTableName, `ExecSQL` = @ExecSQL, `RowNum` = @RowNum, `Exception` = @Exception, `Status` = @Status WHERE `LogID` = @LogID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", item.LogID, MySqlDbType.VarChar),
                Database.CreateInParameter("@DataMoveID", item.DataMoveID, MySqlDbType.Int32),
                Database.CreateInParameter("@DatabaseName", item.DatabaseName != null ? item.DatabaseName : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@TableName", item.TableName, MySqlDbType.VarChar),
                Database.CreateInParameter("@HandleMode", item.HandleMode, MySqlDbType.Int32),
                Database.CreateInParameter("@KeepValue", item.KeepValue, MySqlDbType.Int32),
                Database.CreateInParameter("@BeginDate", item.BeginDate, MySqlDbType.Date),
                Database.CreateInParameter("@EndDate", item.EndDate, MySqlDbType.Date),
                Database.CreateInParameter("@BackupTableName", item.BackupTableName != null ? item.BackupTableName : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@ExecSQL", item.ExecSQL != null ? item.ExecSQL : (object)DBNull.Value, MySqlDbType.LongText),
                Database.CreateInParameter("@RowNum", item.RowNum, MySqlDbType.Int32),
                Database.CreateInParameter("@Exception", item.Exception != null ? item.Exception : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
                Database.CreateInParameter("@LogID_Original", item.HasOriginal ? item.OriginalLogID : item.LogID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<S_data_move_logEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<S_data_move_logEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "logID">日志编码(GUID)</param>
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
        /// /// <param name = "logID">日志编码(GUID)</param>
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
        /// /// <param name = "logID">日志编码(GUID)</param>
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
        #region PutDataMoveID
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutDataMoveIDByPK(string logID, int dataMoveID, TransactionManager tm_ = null)
        {
            RepairPutDataMoveIDByPKData(logID, dataMoveID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutDataMoveIDByPKAsync(string logID, int dataMoveID, TransactionManager tm_ = null)
        {
            RepairPutDataMoveIDByPKData(logID, dataMoveID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutDataMoveIDByPKData(string logID, int dataMoveID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `DataMoveID` = @DataMoveID  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutDataMoveID(int dataMoveID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `DataMoveID` = @DataMoveID";
            var parameter_ = Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutDataMoveIDAsync(int dataMoveID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `DataMoveID` = @DataMoveID";
            var parameter_ = Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutDataMoveID
        #region PutDatabaseName
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// /// <param name = "databaseName">数据库名（配置文件连接名或连接字符串）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutDatabaseNameByPK(string logID, string databaseName, TransactionManager tm_ = null)
        {
            RepairPutDatabaseNameByPKData(logID, databaseName, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutDatabaseNameByPKAsync(string logID, string databaseName, TransactionManager tm_ = null)
        {
            RepairPutDatabaseNameByPKData(logID, databaseName, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutDatabaseNameByPKData(string logID, string databaseName, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `DatabaseName` = @DatabaseName  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DatabaseName", databaseName != null ? databaseName : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "databaseName">数据库名（配置文件连接名或连接字符串）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutDatabaseName(string databaseName, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `DatabaseName` = @DatabaseName";
            var parameter_ = Database.CreateInParameter("@DatabaseName", databaseName != null ? databaseName : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutDatabaseNameAsync(string databaseName, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `DatabaseName` = @DatabaseName";
            var parameter_ = Database.CreateInParameter("@DatabaseName", databaseName != null ? databaseName : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutDatabaseName
        #region PutTableName
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// /// <param name = "tableName">表名</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutTableNameByPK(string logID, string tableName, TransactionManager tm_ = null)
        {
            RepairPutTableNameByPKData(logID, tableName, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutTableNameByPKAsync(string logID, string tableName, TransactionManager tm_ = null)
        {
            RepairPutTableNameByPKData(logID, tableName, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutTableNameByPKData(string logID, string tableName, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `TableName` = @TableName  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@TableName", tableName, MySqlDbType.VarChar),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "tableName">表名</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutTableName(string tableName, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `TableName` = @TableName";
            var parameter_ = Database.CreateInParameter("@TableName", tableName, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutTableNameAsync(string tableName, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `TableName` = @TableName";
            var parameter_ = Database.CreateInParameter("@TableName", tableName, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutTableName
        #region PutHandleMode
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// /// <param name = "handleMode">处理方式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutHandleModeByPK(string logID, int handleMode, TransactionManager tm_ = null)
        {
            RepairPutHandleModeByPKData(logID, handleMode, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutHandleModeByPKAsync(string logID, int handleMode, TransactionManager tm_ = null)
        {
            RepairPutHandleModeByPKData(logID, handleMode, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutHandleModeByPKData(string logID, int handleMode, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `HandleMode` = @HandleMode  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@HandleMode", handleMode, MySqlDbType.Int32),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "handleMode">处理方式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutHandleMode(int handleMode, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `HandleMode` = @HandleMode";
            var parameter_ = Database.CreateInParameter("@HandleMode", handleMode, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutHandleModeAsync(int handleMode, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `HandleMode` = @HandleMode";
            var parameter_ = Database.CreateInParameter("@HandleMode", handleMode, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutHandleMode
        #region PutKeepValue
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）HandleMode=</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutKeepValueByPK(string logID, int keepValue, TransactionManager tm_ = null)
        {
            RepairPutKeepValueByPKData(logID, keepValue, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutKeepValueByPKAsync(string logID, int keepValue, TransactionManager tm_ = null)
        {
            RepairPutKeepValueByPKData(logID, keepValue, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutKeepValueByPKData(string logID, int keepValue, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `KeepValue` = @KeepValue  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@KeepValue", keepValue, MySqlDbType.Int32),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）HandleMode=</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutKeepValue(int keepValue, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `KeepValue` = @KeepValue";
            var parameter_ = Database.CreateInParameter("@KeepValue", keepValue, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutKeepValueAsync(int keepValue, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `KeepValue` = @KeepValue";
            var parameter_ = Database.CreateInParameter("@KeepValue", keepValue, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutKeepValue
        #region PutBeginDate
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// /// <param name = "beginDate">起始时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBeginDateByPK(string logID, DateTime beginDate, TransactionManager tm_ = null)
        {
            RepairPutBeginDateByPKData(logID, beginDate, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBeginDateByPKAsync(string logID, DateTime beginDate, TransactionManager tm_ = null)
        {
            RepairPutBeginDateByPKData(logID, beginDate, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBeginDateByPKData(string logID, DateTime beginDate, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BeginDate` = @BeginDate  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.Date),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "beginDate">起始时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBeginDate(DateTime beginDate, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BeginDate` = @BeginDate";
            var parameter_ = Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.Date);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBeginDateAsync(DateTime beginDate, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BeginDate` = @BeginDate";
            var parameter_ = Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.Date);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBeginDate
        #region PutEndDate
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// /// <param name = "endDate">结束时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutEndDateByPK(string logID, DateTime endDate, TransactionManager tm_ = null)
        {
            RepairPutEndDateByPKData(logID, endDate, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutEndDateByPKAsync(string logID, DateTime endDate, TransactionManager tm_ = null)
        {
            RepairPutEndDateByPKData(logID, endDate, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutEndDateByPKData(string logID, DateTime endDate, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `EndDate` = @EndDate  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@EndDate", endDate, MySqlDbType.Date),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "endDate">结束时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutEndDate(DateTime endDate, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `EndDate` = @EndDate";
            var parameter_ = Database.CreateInParameter("@EndDate", endDate, MySqlDbType.Date);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutEndDateAsync(DateTime endDate, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `EndDate` = @EndDate";
            var parameter_ = Database.CreateInParameter("@EndDate", endDate, MySqlDbType.Date);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutEndDate
        #region PutBackupTableName
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// /// <param name = "backupTableName">备份表名，|分割</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBackupTableNameByPK(string logID, string backupTableName, TransactionManager tm_ = null)
        {
            RepairPutBackupTableNameByPKData(logID, backupTableName, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBackupTableNameByPKAsync(string logID, string backupTableName, TransactionManager tm_ = null)
        {
            RepairPutBackupTableNameByPKData(logID, backupTableName, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBackupTableNameByPKData(string logID, string backupTableName, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BackupTableName` = @BackupTableName  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BackupTableName", backupTableName != null ? backupTableName : (object)DBNull.Value, MySqlDbType.Text),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "backupTableName">备份表名，|分割</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBackupTableName(string backupTableName, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BackupTableName` = @BackupTableName";
            var parameter_ = Database.CreateInParameter("@BackupTableName", backupTableName != null ? backupTableName : (object)DBNull.Value, MySqlDbType.Text);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBackupTableNameAsync(string backupTableName, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BackupTableName` = @BackupTableName";
            var parameter_ = Database.CreateInParameter("@BackupTableName", backupTableName != null ? backupTableName : (object)DBNull.Value, MySqlDbType.Text);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBackupTableName
        #region PutExecSQL
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// /// <param name = "execSQL">执行SQL</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutExecSQLByPK(string logID, string execSQL, TransactionManager tm_ = null)
        {
            RepairPutExecSQLByPKData(logID, execSQL, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutExecSQLByPKAsync(string logID, string execSQL, TransactionManager tm_ = null)
        {
            RepairPutExecSQLByPKData(logID, execSQL, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutExecSQLByPKData(string logID, string execSQL, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `ExecSQL` = @ExecSQL  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ExecSQL", execSQL != null ? execSQL : (object)DBNull.Value, MySqlDbType.LongText),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "execSQL">执行SQL</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutExecSQL(string execSQL, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `ExecSQL` = @ExecSQL";
            var parameter_ = Database.CreateInParameter("@ExecSQL", execSQL != null ? execSQL : (object)DBNull.Value, MySqlDbType.LongText);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutExecSQLAsync(string execSQL, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `ExecSQL` = @ExecSQL";
            var parameter_ = Database.CreateInParameter("@ExecSQL", execSQL != null ? execSQL : (object)DBNull.Value, MySqlDbType.LongText);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutExecSQL
        #region PutRowNum
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// /// <param name = "rowNum">处理记录数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRowNumByPK(string logID, int rowNum, TransactionManager tm_ = null)
        {
            RepairPutRowNumByPKData(logID, rowNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRowNumByPKAsync(string logID, int rowNum, TransactionManager tm_ = null)
        {
            RepairPutRowNumByPKData(logID, rowNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRowNumByPKData(string logID, int rowNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `RowNum` = @RowNum  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RowNum", rowNum, MySqlDbType.Int32),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "rowNum">处理记录数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRowNum(int rowNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `RowNum` = @RowNum";
            var parameter_ = Database.CreateInParameter("@RowNum", rowNum, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutRowNumAsync(int rowNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `RowNum` = @RowNum";
            var parameter_ = Database.CreateInParameter("@RowNum", rowNum, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutRowNum
        #region PutException
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// /// <param name = "exception">异常消息</param>
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
        #region PutStatus
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// /// <param name = "status">状态(0-未知1-成功2-无数据3-失败)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutStatusByPK(string logID, int status, TransactionManager tm_ = null)
        {
            RepairPutStatusByPKData(logID, status, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutStatusByPKAsync(string logID, int status, TransactionManager tm_ = null)
        {
            RepairPutStatusByPKData(logID, status, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutStatusByPKData(string logID, int status, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `LogID` = @LogID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "status">状态(0-未知1-成功2-无数据3-失败)</param>
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
        /// /// <param name = "logID">日志编码(GUID)</param>
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
        public bool Set(S_data_move_logEO item, TransactionManager tm = null)
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
        public async Task<bool> SetAsync(S_data_move_logEO item, TransactionManager tm = null)
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
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public S_data_move_logEO GetByPK(string logID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(logID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        public async Task<S_data_move_logEO> GetByPKAsync(string logID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(logID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
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
        /// 按主键查询 DataMoveID（字段）
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetDataMoveIDByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`DataMoveID`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<int> GetDataMoveIDByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`DataMoveID`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 DatabaseName（字段）
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetDatabaseNameByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`DatabaseName`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<string> GetDatabaseNameByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`DatabaseName`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 TableName（字段）
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetTableNameByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`TableName`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<string> GetTableNameByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`TableName`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 HandleMode（字段）
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetHandleModeByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`HandleMode`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<int> GetHandleModeByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`HandleMode`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 KeepValue（字段）
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetKeepValueByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`KeepValue`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<int> GetKeepValueByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`KeepValue`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BeginDate（字段）
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public DateTime GetBeginDateByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (DateTime)GetScalar("`BeginDate`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<DateTime> GetBeginDateByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (DateTime)await GetScalarAsync("`BeginDate`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 EndDate（字段）
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public DateTime GetEndDateByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (DateTime)GetScalar("`EndDate`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<DateTime> GetEndDateByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (DateTime)await GetScalarAsync("`EndDate`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BackupTableName（字段）
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetBackupTableNameByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`BackupTableName`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<string> GetBackupTableNameByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`BackupTableName`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 ExecSQL（字段）
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetExecSQLByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`ExecSQL`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<string> GetExecSQLByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`ExecSQL`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 RowNum（字段）
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetRowNumByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`RowNum`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<int> GetRowNumByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`RowNum`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Exception（字段）
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
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
        /// 按主键查询 Status（字段）
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetStatusByPK(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`Status`", "`LogID` = @LogID", paras_, tm_);
        }
        public async Task<int> GetStatusByPKAsync(string logID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`Status`", "`LogID` = @LogID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 RecDate（字段）
        /// </summary>
        /// /// <param name = "logID">日志编码(GUID)</param>
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
        #region GetByDataMoveID

        /// <summary>
        /// 按 DataMoveID（字段） 查询
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByDataMoveID(int dataMoveID)
        {
            return GetByDataMoveID(dataMoveID, 0, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByDataMoveIDAsync(int dataMoveID)
        {
            return await GetByDataMoveIDAsync(dataMoveID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 DataMoveID（字段） 查询
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByDataMoveID(int dataMoveID, TransactionManager tm_)
        {
            return GetByDataMoveID(dataMoveID, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByDataMoveIDAsync(int dataMoveID, TransactionManager tm_)
        {
            return await GetByDataMoveIDAsync(dataMoveID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 DataMoveID（字段） 查询
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByDataMoveID(int dataMoveID, int top_)
        {
            return GetByDataMoveID(dataMoveID, top_, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByDataMoveIDAsync(int dataMoveID, int top_)
        {
            return await GetByDataMoveIDAsync(dataMoveID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 DataMoveID（字段） 查询
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByDataMoveID(int dataMoveID, int top_, TransactionManager tm_)
        {
            return GetByDataMoveID(dataMoveID, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByDataMoveIDAsync(int dataMoveID, int top_, TransactionManager tm_)
        {
            return await GetByDataMoveIDAsync(dataMoveID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 DataMoveID（字段） 查询
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByDataMoveID(int dataMoveID, string sort_)
        {
            return GetByDataMoveID(dataMoveID, 0, sort_, null);
        }
        public async Task<List<S_data_move_logEO>> GetByDataMoveIDAsync(int dataMoveID, string sort_)
        {
            return await GetByDataMoveIDAsync(dataMoveID, 0, sort_, null);
        }

        /// <summary>
        /// 按 DataMoveID（字段） 查询
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByDataMoveID(int dataMoveID, string sort_, TransactionManager tm_)
        {
            return GetByDataMoveID(dataMoveID, 0, sort_, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByDataMoveIDAsync(int dataMoveID, string sort_, TransactionManager tm_)
        {
            return await GetByDataMoveIDAsync(dataMoveID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 DataMoveID（字段） 查询
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByDataMoveID(int dataMoveID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`DataMoveID` = @DataMoveID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        public async Task<List<S_data_move_logEO>> GetByDataMoveIDAsync(int dataMoveID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`DataMoveID` = @DataMoveID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        #endregion // GetByDataMoveID
        #region GetByDatabaseName

        /// <summary>
        /// 按 DatabaseName（字段） 查询
        /// </summary>
        /// /// <param name = "databaseName">数据库名（配置文件连接名或连接字符串）</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByDatabaseName(string databaseName)
        {
            return GetByDatabaseName(databaseName, 0, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByDatabaseNameAsync(string databaseName)
        {
            return await GetByDatabaseNameAsync(databaseName, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 DatabaseName（字段） 查询
        /// </summary>
        /// /// <param name = "databaseName">数据库名（配置文件连接名或连接字符串）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByDatabaseName(string databaseName, TransactionManager tm_)
        {
            return GetByDatabaseName(databaseName, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByDatabaseNameAsync(string databaseName, TransactionManager tm_)
        {
            return await GetByDatabaseNameAsync(databaseName, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 DatabaseName（字段） 查询
        /// </summary>
        /// /// <param name = "databaseName">数据库名（配置文件连接名或连接字符串）</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByDatabaseName(string databaseName, int top_)
        {
            return GetByDatabaseName(databaseName, top_, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByDatabaseNameAsync(string databaseName, int top_)
        {
            return await GetByDatabaseNameAsync(databaseName, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 DatabaseName（字段） 查询
        /// </summary>
        /// /// <param name = "databaseName">数据库名（配置文件连接名或连接字符串）</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByDatabaseName(string databaseName, int top_, TransactionManager tm_)
        {
            return GetByDatabaseName(databaseName, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByDatabaseNameAsync(string databaseName, int top_, TransactionManager tm_)
        {
            return await GetByDatabaseNameAsync(databaseName, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 DatabaseName（字段） 查询
        /// </summary>
        /// /// <param name = "databaseName">数据库名（配置文件连接名或连接字符串）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByDatabaseName(string databaseName, string sort_)
        {
            return GetByDatabaseName(databaseName, 0, sort_, null);
        }
        public async Task<List<S_data_move_logEO>> GetByDatabaseNameAsync(string databaseName, string sort_)
        {
            return await GetByDatabaseNameAsync(databaseName, 0, sort_, null);
        }

        /// <summary>
        /// 按 DatabaseName（字段） 查询
        /// </summary>
        /// /// <param name = "databaseName">数据库名（配置文件连接名或连接字符串）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByDatabaseName(string databaseName, string sort_, TransactionManager tm_)
        {
            return GetByDatabaseName(databaseName, 0, sort_, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByDatabaseNameAsync(string databaseName, string sort_, TransactionManager tm_)
        {
            return await GetByDatabaseNameAsync(databaseName, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 DatabaseName（字段） 查询
        /// </summary>
        /// /// <param name = "databaseName">数据库名（配置文件连接名或连接字符串）</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByDatabaseName(string databaseName, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(databaseName != null ? "`DatabaseName` = @DatabaseName" : "`DatabaseName` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (databaseName != null)
                paras_.Add(Database.CreateInParameter("@DatabaseName", databaseName, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        public async Task<List<S_data_move_logEO>> GetByDatabaseNameAsync(string databaseName, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(databaseName != null ? "`DatabaseName` = @DatabaseName" : "`DatabaseName` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (databaseName != null)
                paras_.Add(Database.CreateInParameter("@DatabaseName", databaseName, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        #endregion // GetByDatabaseName
        #region GetByTableName

        /// <summary>
        /// 按 TableName（字段） 查询
        /// </summary>
        /// /// <param name = "tableName">表名</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByTableName(string tableName)
        {
            return GetByTableName(tableName, 0, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByTableNameAsync(string tableName)
        {
            return await GetByTableNameAsync(tableName, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 TableName（字段） 查询
        /// </summary>
        /// /// <param name = "tableName">表名</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByTableName(string tableName, TransactionManager tm_)
        {
            return GetByTableName(tableName, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByTableNameAsync(string tableName, TransactionManager tm_)
        {
            return await GetByTableNameAsync(tableName, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 TableName（字段） 查询
        /// </summary>
        /// /// <param name = "tableName">表名</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByTableName(string tableName, int top_)
        {
            return GetByTableName(tableName, top_, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByTableNameAsync(string tableName, int top_)
        {
            return await GetByTableNameAsync(tableName, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 TableName（字段） 查询
        /// </summary>
        /// /// <param name = "tableName">表名</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByTableName(string tableName, int top_, TransactionManager tm_)
        {
            return GetByTableName(tableName, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByTableNameAsync(string tableName, int top_, TransactionManager tm_)
        {
            return await GetByTableNameAsync(tableName, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 TableName（字段） 查询
        /// </summary>
        /// /// <param name = "tableName">表名</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByTableName(string tableName, string sort_)
        {
            return GetByTableName(tableName, 0, sort_, null);
        }
        public async Task<List<S_data_move_logEO>> GetByTableNameAsync(string tableName, string sort_)
        {
            return await GetByTableNameAsync(tableName, 0, sort_, null);
        }

        /// <summary>
        /// 按 TableName（字段） 查询
        /// </summary>
        /// /// <param name = "tableName">表名</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByTableName(string tableName, string sort_, TransactionManager tm_)
        {
            return GetByTableName(tableName, 0, sort_, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByTableNameAsync(string tableName, string sort_, TransactionManager tm_)
        {
            return await GetByTableNameAsync(tableName, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 TableName（字段） 查询
        /// </summary>
        /// /// <param name = "tableName">表名</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByTableName(string tableName, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`TableName` = @TableName", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TableName", tableName, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        public async Task<List<S_data_move_logEO>> GetByTableNameAsync(string tableName, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`TableName` = @TableName", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TableName", tableName, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        #endregion // GetByTableName
        #region GetByHandleMode

        /// <summary>
        /// 按 HandleMode（字段） 查询
        /// </summary>
        /// /// <param name = "handleMode">处理方式</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByHandleMode(int handleMode)
        {
            return GetByHandleMode(handleMode, 0, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByHandleModeAsync(int handleMode)
        {
            return await GetByHandleModeAsync(handleMode, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 HandleMode（字段） 查询
        /// </summary>
        /// /// <param name = "handleMode">处理方式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByHandleMode(int handleMode, TransactionManager tm_)
        {
            return GetByHandleMode(handleMode, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByHandleModeAsync(int handleMode, TransactionManager tm_)
        {
            return await GetByHandleModeAsync(handleMode, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 HandleMode（字段） 查询
        /// </summary>
        /// /// <param name = "handleMode">处理方式</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByHandleMode(int handleMode, int top_)
        {
            return GetByHandleMode(handleMode, top_, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByHandleModeAsync(int handleMode, int top_)
        {
            return await GetByHandleModeAsync(handleMode, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 HandleMode（字段） 查询
        /// </summary>
        /// /// <param name = "handleMode">处理方式</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByHandleMode(int handleMode, int top_, TransactionManager tm_)
        {
            return GetByHandleMode(handleMode, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByHandleModeAsync(int handleMode, int top_, TransactionManager tm_)
        {
            return await GetByHandleModeAsync(handleMode, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 HandleMode（字段） 查询
        /// </summary>
        /// /// <param name = "handleMode">处理方式</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByHandleMode(int handleMode, string sort_)
        {
            return GetByHandleMode(handleMode, 0, sort_, null);
        }
        public async Task<List<S_data_move_logEO>> GetByHandleModeAsync(int handleMode, string sort_)
        {
            return await GetByHandleModeAsync(handleMode, 0, sort_, null);
        }

        /// <summary>
        /// 按 HandleMode（字段） 查询
        /// </summary>
        /// /// <param name = "handleMode">处理方式</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByHandleMode(int handleMode, string sort_, TransactionManager tm_)
        {
            return GetByHandleMode(handleMode, 0, sort_, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByHandleModeAsync(int handleMode, string sort_, TransactionManager tm_)
        {
            return await GetByHandleModeAsync(handleMode, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 HandleMode（字段） 查询
        /// </summary>
        /// /// <param name = "handleMode">处理方式</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByHandleMode(int handleMode, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`HandleMode` = @HandleMode", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@HandleMode", handleMode, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        public async Task<List<S_data_move_logEO>> GetByHandleModeAsync(int handleMode, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`HandleMode` = @HandleMode", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@HandleMode", handleMode, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        #endregion // GetByHandleMode
        #region GetByKeepValue

        /// <summary>
        /// 按 KeepValue（字段） 查询
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）HandleMode=</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByKeepValue(int keepValue)
        {
            return GetByKeepValue(keepValue, 0, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByKeepValueAsync(int keepValue)
        {
            return await GetByKeepValueAsync(keepValue, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 KeepValue（字段） 查询
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）HandleMode=</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByKeepValue(int keepValue, TransactionManager tm_)
        {
            return GetByKeepValue(keepValue, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByKeepValueAsync(int keepValue, TransactionManager tm_)
        {
            return await GetByKeepValueAsync(keepValue, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 KeepValue（字段） 查询
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）HandleMode=</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByKeepValue(int keepValue, int top_)
        {
            return GetByKeepValue(keepValue, top_, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByKeepValueAsync(int keepValue, int top_)
        {
            return await GetByKeepValueAsync(keepValue, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 KeepValue（字段） 查询
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）HandleMode=</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByKeepValue(int keepValue, int top_, TransactionManager tm_)
        {
            return GetByKeepValue(keepValue, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByKeepValueAsync(int keepValue, int top_, TransactionManager tm_)
        {
            return await GetByKeepValueAsync(keepValue, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 KeepValue（字段） 查询
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）HandleMode=</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByKeepValue(int keepValue, string sort_)
        {
            return GetByKeepValue(keepValue, 0, sort_, null);
        }
        public async Task<List<S_data_move_logEO>> GetByKeepValueAsync(int keepValue, string sort_)
        {
            return await GetByKeepValueAsync(keepValue, 0, sort_, null);
        }

        /// <summary>
        /// 按 KeepValue（字段） 查询
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）HandleMode=</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByKeepValue(int keepValue, string sort_, TransactionManager tm_)
        {
            return GetByKeepValue(keepValue, 0, sort_, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByKeepValueAsync(int keepValue, string sort_, TransactionManager tm_)
        {
            return await GetByKeepValueAsync(keepValue, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 KeepValue（字段） 查询
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）HandleMode=</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByKeepValue(int keepValue, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`KeepValue` = @KeepValue", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@KeepValue", keepValue, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        public async Task<List<S_data_move_logEO>> GetByKeepValueAsync(int keepValue, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`KeepValue` = @KeepValue", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@KeepValue", keepValue, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        #endregion // GetByKeepValue
        #region GetByBeginDate

        /// <summary>
        /// 按 BeginDate（字段） 查询
        /// </summary>
        /// /// <param name = "beginDate">起始时间</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByBeginDate(DateTime beginDate)
        {
            return GetByBeginDate(beginDate, 0, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByBeginDateAsync(DateTime beginDate)
        {
            return await GetByBeginDateAsync(beginDate, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BeginDate（字段） 查询
        /// </summary>
        /// /// <param name = "beginDate">起始时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByBeginDate(DateTime beginDate, TransactionManager tm_)
        {
            return GetByBeginDate(beginDate, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByBeginDateAsync(DateTime beginDate, TransactionManager tm_)
        {
            return await GetByBeginDateAsync(beginDate, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BeginDate（字段） 查询
        /// </summary>
        /// /// <param name = "beginDate">起始时间</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByBeginDate(DateTime beginDate, int top_)
        {
            return GetByBeginDate(beginDate, top_, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByBeginDateAsync(DateTime beginDate, int top_)
        {
            return await GetByBeginDateAsync(beginDate, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BeginDate（字段） 查询
        /// </summary>
        /// /// <param name = "beginDate">起始时间</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByBeginDate(DateTime beginDate, int top_, TransactionManager tm_)
        {
            return GetByBeginDate(beginDate, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByBeginDateAsync(DateTime beginDate, int top_, TransactionManager tm_)
        {
            return await GetByBeginDateAsync(beginDate, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BeginDate（字段） 查询
        /// </summary>
        /// /// <param name = "beginDate">起始时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByBeginDate(DateTime beginDate, string sort_)
        {
            return GetByBeginDate(beginDate, 0, sort_, null);
        }
        public async Task<List<S_data_move_logEO>> GetByBeginDateAsync(DateTime beginDate, string sort_)
        {
            return await GetByBeginDateAsync(beginDate, 0, sort_, null);
        }

        /// <summary>
        /// 按 BeginDate（字段） 查询
        /// </summary>
        /// /// <param name = "beginDate">起始时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByBeginDate(DateTime beginDate, string sort_, TransactionManager tm_)
        {
            return GetByBeginDate(beginDate, 0, sort_, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByBeginDateAsync(DateTime beginDate, string sort_, TransactionManager tm_)
        {
            return await GetByBeginDateAsync(beginDate, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BeginDate（字段） 查询
        /// </summary>
        /// /// <param name = "beginDate">起始时间</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByBeginDate(DateTime beginDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BeginDate` = @BeginDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.Date));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        public async Task<List<S_data_move_logEO>> GetByBeginDateAsync(DateTime beginDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BeginDate` = @BeginDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.Date));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        #endregion // GetByBeginDate
        #region GetByEndDate

        /// <summary>
        /// 按 EndDate（字段） 查询
        /// </summary>
        /// /// <param name = "endDate">结束时间</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByEndDate(DateTime endDate)
        {
            return GetByEndDate(endDate, 0, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByEndDateAsync(DateTime endDate)
        {
            return await GetByEndDateAsync(endDate, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 EndDate（字段） 查询
        /// </summary>
        /// /// <param name = "endDate">结束时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByEndDate(DateTime endDate, TransactionManager tm_)
        {
            return GetByEndDate(endDate, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByEndDateAsync(DateTime endDate, TransactionManager tm_)
        {
            return await GetByEndDateAsync(endDate, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 EndDate（字段） 查询
        /// </summary>
        /// /// <param name = "endDate">结束时间</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByEndDate(DateTime endDate, int top_)
        {
            return GetByEndDate(endDate, top_, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByEndDateAsync(DateTime endDate, int top_)
        {
            return await GetByEndDateAsync(endDate, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 EndDate（字段） 查询
        /// </summary>
        /// /// <param name = "endDate">结束时间</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByEndDate(DateTime endDate, int top_, TransactionManager tm_)
        {
            return GetByEndDate(endDate, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByEndDateAsync(DateTime endDate, int top_, TransactionManager tm_)
        {
            return await GetByEndDateAsync(endDate, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 EndDate（字段） 查询
        /// </summary>
        /// /// <param name = "endDate">结束时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByEndDate(DateTime endDate, string sort_)
        {
            return GetByEndDate(endDate, 0, sort_, null);
        }
        public async Task<List<S_data_move_logEO>> GetByEndDateAsync(DateTime endDate, string sort_)
        {
            return await GetByEndDateAsync(endDate, 0, sort_, null);
        }

        /// <summary>
        /// 按 EndDate（字段） 查询
        /// </summary>
        /// /// <param name = "endDate">结束时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByEndDate(DateTime endDate, string sort_, TransactionManager tm_)
        {
            return GetByEndDate(endDate, 0, sort_, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByEndDateAsync(DateTime endDate, string sort_, TransactionManager tm_)
        {
            return await GetByEndDateAsync(endDate, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 EndDate（字段） 查询
        /// </summary>
        /// /// <param name = "endDate">结束时间</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByEndDate(DateTime endDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`EndDate` = @EndDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@EndDate", endDate, MySqlDbType.Date));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        public async Task<List<S_data_move_logEO>> GetByEndDateAsync(DateTime endDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`EndDate` = @EndDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@EndDate", endDate, MySqlDbType.Date));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        #endregion // GetByEndDate
        #region GetByBackupTableName

        /// <summary>
        /// 按 BackupTableName（字段） 查询
        /// </summary>
        /// /// <param name = "backupTableName">备份表名，|分割</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByBackupTableName(string backupTableName)
        {
            return GetByBackupTableName(backupTableName, 0, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByBackupTableNameAsync(string backupTableName)
        {
            return await GetByBackupTableNameAsync(backupTableName, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BackupTableName（字段） 查询
        /// </summary>
        /// /// <param name = "backupTableName">备份表名，|分割</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByBackupTableName(string backupTableName, TransactionManager tm_)
        {
            return GetByBackupTableName(backupTableName, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByBackupTableNameAsync(string backupTableName, TransactionManager tm_)
        {
            return await GetByBackupTableNameAsync(backupTableName, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BackupTableName（字段） 查询
        /// </summary>
        /// /// <param name = "backupTableName">备份表名，|分割</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByBackupTableName(string backupTableName, int top_)
        {
            return GetByBackupTableName(backupTableName, top_, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByBackupTableNameAsync(string backupTableName, int top_)
        {
            return await GetByBackupTableNameAsync(backupTableName, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BackupTableName（字段） 查询
        /// </summary>
        /// /// <param name = "backupTableName">备份表名，|分割</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByBackupTableName(string backupTableName, int top_, TransactionManager tm_)
        {
            return GetByBackupTableName(backupTableName, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByBackupTableNameAsync(string backupTableName, int top_, TransactionManager tm_)
        {
            return await GetByBackupTableNameAsync(backupTableName, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BackupTableName（字段） 查询
        /// </summary>
        /// /// <param name = "backupTableName">备份表名，|分割</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByBackupTableName(string backupTableName, string sort_)
        {
            return GetByBackupTableName(backupTableName, 0, sort_, null);
        }
        public async Task<List<S_data_move_logEO>> GetByBackupTableNameAsync(string backupTableName, string sort_)
        {
            return await GetByBackupTableNameAsync(backupTableName, 0, sort_, null);
        }

        /// <summary>
        /// 按 BackupTableName（字段） 查询
        /// </summary>
        /// /// <param name = "backupTableName">备份表名，|分割</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByBackupTableName(string backupTableName, string sort_, TransactionManager tm_)
        {
            return GetByBackupTableName(backupTableName, 0, sort_, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByBackupTableNameAsync(string backupTableName, string sort_, TransactionManager tm_)
        {
            return await GetByBackupTableNameAsync(backupTableName, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BackupTableName（字段） 查询
        /// </summary>
        /// /// <param name = "backupTableName">备份表名，|分割</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByBackupTableName(string backupTableName, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(backupTableName != null ? "`BackupTableName` = @BackupTableName" : "`BackupTableName` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (backupTableName != null)
                paras_.Add(Database.CreateInParameter("@BackupTableName", backupTableName, MySqlDbType.Text));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        public async Task<List<S_data_move_logEO>> GetByBackupTableNameAsync(string backupTableName, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(backupTableName != null ? "`BackupTableName` = @BackupTableName" : "`BackupTableName` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (backupTableName != null)
                paras_.Add(Database.CreateInParameter("@BackupTableName", backupTableName, MySqlDbType.Text));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        #endregion // GetByBackupTableName
        #region GetByExecSQL

        /// <summary>
        /// 按 ExecSQL（字段） 查询
        /// </summary>
        /// /// <param name = "execSQL">执行SQL</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByExecSQL(string execSQL)
        {
            return GetByExecSQL(execSQL, 0, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByExecSQLAsync(string execSQL)
        {
            return await GetByExecSQLAsync(execSQL, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 ExecSQL（字段） 查询
        /// </summary>
        /// /// <param name = "execSQL">执行SQL</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByExecSQL(string execSQL, TransactionManager tm_)
        {
            return GetByExecSQL(execSQL, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByExecSQLAsync(string execSQL, TransactionManager tm_)
        {
            return await GetByExecSQLAsync(execSQL, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ExecSQL（字段） 查询
        /// </summary>
        /// /// <param name = "execSQL">执行SQL</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByExecSQL(string execSQL, int top_)
        {
            return GetByExecSQL(execSQL, top_, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByExecSQLAsync(string execSQL, int top_)
        {
            return await GetByExecSQLAsync(execSQL, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 ExecSQL（字段） 查询
        /// </summary>
        /// /// <param name = "execSQL">执行SQL</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByExecSQL(string execSQL, int top_, TransactionManager tm_)
        {
            return GetByExecSQL(execSQL, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByExecSQLAsync(string execSQL, int top_, TransactionManager tm_)
        {
            return await GetByExecSQLAsync(execSQL, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ExecSQL（字段） 查询
        /// </summary>
        /// /// <param name = "execSQL">执行SQL</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByExecSQL(string execSQL, string sort_)
        {
            return GetByExecSQL(execSQL, 0, sort_, null);
        }
        public async Task<List<S_data_move_logEO>> GetByExecSQLAsync(string execSQL, string sort_)
        {
            return await GetByExecSQLAsync(execSQL, 0, sort_, null);
        }

        /// <summary>
        /// 按 ExecSQL（字段） 查询
        /// </summary>
        /// /// <param name = "execSQL">执行SQL</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByExecSQL(string execSQL, string sort_, TransactionManager tm_)
        {
            return GetByExecSQL(execSQL, 0, sort_, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByExecSQLAsync(string execSQL, string sort_, TransactionManager tm_)
        {
            return await GetByExecSQLAsync(execSQL, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 ExecSQL（字段） 查询
        /// </summary>
        /// /// <param name = "execSQL">执行SQL</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByExecSQL(string execSQL, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(execSQL != null ? "`ExecSQL` = @ExecSQL" : "`ExecSQL` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (execSQL != null)
                paras_.Add(Database.CreateInParameter("@ExecSQL", execSQL, MySqlDbType.LongText));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        public async Task<List<S_data_move_logEO>> GetByExecSQLAsync(string execSQL, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(execSQL != null ? "`ExecSQL` = @ExecSQL" : "`ExecSQL` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (execSQL != null)
                paras_.Add(Database.CreateInParameter("@ExecSQL", execSQL, MySqlDbType.LongText));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        #endregion // GetByExecSQL
        #region GetByRowNum

        /// <summary>
        /// 按 RowNum（字段） 查询
        /// </summary>
        /// /// <param name = "rowNum">处理记录数</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByRowNum(int rowNum)
        {
            return GetByRowNum(rowNum, 0, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByRowNumAsync(int rowNum)
        {
            return await GetByRowNumAsync(rowNum, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 RowNum（字段） 查询
        /// </summary>
        /// /// <param name = "rowNum">处理记录数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByRowNum(int rowNum, TransactionManager tm_)
        {
            return GetByRowNum(rowNum, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByRowNumAsync(int rowNum, TransactionManager tm_)
        {
            return await GetByRowNumAsync(rowNum, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RowNum（字段） 查询
        /// </summary>
        /// /// <param name = "rowNum">处理记录数</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByRowNum(int rowNum, int top_)
        {
            return GetByRowNum(rowNum, top_, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByRowNumAsync(int rowNum, int top_)
        {
            return await GetByRowNumAsync(rowNum, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 RowNum（字段） 查询
        /// </summary>
        /// /// <param name = "rowNum">处理记录数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByRowNum(int rowNum, int top_, TransactionManager tm_)
        {
            return GetByRowNum(rowNum, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByRowNumAsync(int rowNum, int top_, TransactionManager tm_)
        {
            return await GetByRowNumAsync(rowNum, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RowNum（字段） 查询
        /// </summary>
        /// /// <param name = "rowNum">处理记录数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByRowNum(int rowNum, string sort_)
        {
            return GetByRowNum(rowNum, 0, sort_, null);
        }
        public async Task<List<S_data_move_logEO>> GetByRowNumAsync(int rowNum, string sort_)
        {
            return await GetByRowNumAsync(rowNum, 0, sort_, null);
        }

        /// <summary>
        /// 按 RowNum（字段） 查询
        /// </summary>
        /// /// <param name = "rowNum">处理记录数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByRowNum(int rowNum, string sort_, TransactionManager tm_)
        {
            return GetByRowNum(rowNum, 0, sort_, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByRowNumAsync(int rowNum, string sort_, TransactionManager tm_)
        {
            return await GetByRowNumAsync(rowNum, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 RowNum（字段） 查询
        /// </summary>
        /// /// <param name = "rowNum">处理记录数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByRowNum(int rowNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RowNum` = @RowNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RowNum", rowNum, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        public async Task<List<S_data_move_logEO>> GetByRowNumAsync(int rowNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RowNum` = @RowNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RowNum", rowNum, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        #endregion // GetByRowNum
        #region GetByException

        /// <summary>
        /// 按 Exception（字段） 查询
        /// </summary>
        /// /// <param name = "exception">异常消息</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByException(string exception)
        {
            return GetByException(exception, 0, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByExceptionAsync(string exception)
        {
            return await GetByExceptionAsync(exception, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Exception（字段） 查询
        /// </summary>
        /// /// <param name = "exception">异常消息</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByException(string exception, TransactionManager tm_)
        {
            return GetByException(exception, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByExceptionAsync(string exception, TransactionManager tm_)
        {
            return await GetByExceptionAsync(exception, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Exception（字段） 查询
        /// </summary>
        /// /// <param name = "exception">异常消息</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByException(string exception, int top_)
        {
            return GetByException(exception, top_, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByExceptionAsync(string exception, int top_)
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
        public List<S_data_move_logEO> GetByException(string exception, int top_, TransactionManager tm_)
        {
            return GetByException(exception, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByExceptionAsync(string exception, int top_, TransactionManager tm_)
        {
            return await GetByExceptionAsync(exception, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Exception（字段） 查询
        /// </summary>
        /// /// <param name = "exception">异常消息</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByException(string exception, string sort_)
        {
            return GetByException(exception, 0, sort_, null);
        }
        public async Task<List<S_data_move_logEO>> GetByExceptionAsync(string exception, string sort_)
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
        public List<S_data_move_logEO> GetByException(string exception, string sort_, TransactionManager tm_)
        {
            return GetByException(exception, 0, sort_, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByExceptionAsync(string exception, string sort_, TransactionManager tm_)
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
        public List<S_data_move_logEO> GetByException(string exception, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(exception != null ? "`Exception` = @Exception" : "`Exception` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (exception != null)
                paras_.Add(Database.CreateInParameter("@Exception", exception, MySqlDbType.Text));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        public async Task<List<S_data_move_logEO>> GetByExceptionAsync(string exception, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(exception != null ? "`Exception` = @Exception" : "`Exception` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (exception != null)
                paras_.Add(Database.CreateInParameter("@Exception", exception, MySqlDbType.Text));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        #endregion // GetByException
        #region GetByStatus

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态(0-未知1-成功2-无数据3-失败)</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByStatus(int status)
        {
            return GetByStatus(status, 0, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByStatusAsync(int status)
        {
            return await GetByStatusAsync(status, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态(0-未知1-成功2-无数据3-失败)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByStatus(int status, TransactionManager tm_)
        {
            return GetByStatus(status, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByStatusAsync(int status, TransactionManager tm_)
        {
            return await GetByStatusAsync(status, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态(0-未知1-成功2-无数据3-失败)</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByStatus(int status, int top_)
        {
            return GetByStatus(status, top_, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByStatusAsync(int status, int top_)
        {
            return await GetByStatusAsync(status, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态(0-未知1-成功2-无数据3-失败)</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByStatus(int status, int top_, TransactionManager tm_)
        {
            return GetByStatus(status, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
        {
            return await GetByStatusAsync(status, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态(0-未知1-成功2-无数据3-失败)</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByStatus(int status, string sort_)
        {
            return GetByStatus(status, 0, sort_, null);
        }
        public async Task<List<S_data_move_logEO>> GetByStatusAsync(int status, string sort_)
        {
            return await GetByStatusAsync(status, 0, sort_, null);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态(0-未知1-成功2-无数据3-失败)</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByStatus(int status, string sort_, TransactionManager tm_)
        {
            return GetByStatus(status, 0, sort_, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
        {
            return await GetByStatusAsync(status, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态(0-未知1-成功2-无数据3-失败)</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        public async Task<List<S_data_move_logEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        #endregion // GetByStatus
        #region GetByRecDate

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByRecDate(DateTime recDate)
        {
            return GetByRecDate(recDate, 0, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByRecDateAsync(DateTime recDate)
        {
            return await GetByRecDateAsync(recDate, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
        {
            return GetByRecDate(recDate, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
        {
            return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByRecDate(DateTime recDate, int top_)
        {
            return GetByRecDate(recDate, top_, string.Empty, null);
        }
        public async Task<List<S_data_move_logEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
        public List<S_data_move_logEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
        {
            return GetByRecDate(recDate, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
        {
            return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_move_logEO> GetByRecDate(DateTime recDate, string sort_)
        {
            return GetByRecDate(recDate, 0, sort_, null);
        }
        public async Task<List<S_data_move_logEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
        public List<S_data_move_logEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
        {
            return GetByRecDate(recDate, 0, sort_, tm_);
        }
        public async Task<List<S_data_move_logEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
        public List<S_data_move_logEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        public async Task<List<S_data_move_logEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_move_logEO.MapDataReader);
        }
        #endregion // GetByRecDate
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
