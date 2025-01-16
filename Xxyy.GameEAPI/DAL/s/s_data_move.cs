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
    /// 数据迁移策略定义，就解决大表数据清理
    /// 【表 s_data_move 的实体类】
    /// </summary>
    [DataContract]
    public class S_data_moveEO : IRowMapper<S_data_moveEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public S_data_moveEO()
        {
            this.HandleMode = 0;
            this.KeepValue = 0;
            this.Status = 0;
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private int _originalDataMoveID;
        /// <summary>
        /// 【数据库中的原始主键 DataMoveID 值的副本，用于主键值更新】
        /// </summary>
        public int OriginalDataMoveID
        {
            get { return _originalDataMoveID; }
            set { HasOriginal = true; _originalDataMoveID = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "DataMoveID", DataMoveID }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// 数据迁移编码
        /// 【主键 int】
        /// </summary>
        [DataMember(Order = 1)]
        public int DataMoveID { get; set; }
        /// <summary>
        /// 数据库名（配置文件连接名或连接字符串）
        /// 【字段 varchar(1000)】
        /// </summary>
        [DataMember(Order = 2)]
        public string DatabaseName { get; set; }
        /// <summary>
        /// 表名
        /// 【字段 varchar(100)】
        /// </summary>
        [DataMember(Order = 3)]
        public string TableName { get; set; }
        /// <summary>
        /// 时间字段名
        /// 【字段 varchar(100)】
        /// </summary>
        [DataMember(Order = 4)]
        public string DateFieldName { get; set; }
        /// <summary>
        /// 索引名称
        /// 【字段 varchar(255)】
        /// </summary>
        [DataMember(Order = 5)]
        public string IndexName { get; set; }
        /// <summary>
        /// 处理方式
        ///              0-删除数据
        ///              1-按年生成备份表：tablename_yyyy
        ///              2-按季度生成备份表：tablename_yyyy1,2,3,4
        ///              3-按月生成备份表：tablename_yyyyMM
        ///              4-按日生成备份表：tablename_yyyyMMdd
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 6)]
        public int HandleMode { get; set; }
        /// <summary>
        /// 保留数据长度（根据HandleMode值不同）
        ///              0-删除数据 ==> 表示保留的天数
        ///              1-按年生成备份表：tablename_yyyy => 表示保留的年数
        ///              2-按季度生成备份表：tablename_yyyy1,2,3,4 ==> 表示保留的季节数
        ///              3-按月生成备份表：tablename_yyyyMM ==> 表示保留的月份数
        ///              4-按日生成备份表：tablename_yyyyMMdd ==> 表示保留的天数
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 7)]
        public int KeepValue { get; set; }
        /// <summary>
        /// 迁移数据的条件
        /// 【字段 varchar(1000)】
        /// </summary>
        [DataMember(Order = 8)]
        public string WhereStatement { get; set; }
        /// <summary>
        /// 状态(0-无效1-有效)
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 9)]
        public int Status { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public S_data_moveEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static S_data_moveEO MapDataReader(IDataReader reader)
        {
            S_data_moveEO ret = new S_data_moveEO();
            ret.DataMoveID = reader.ToInt32("DataMoveID");
            ret.OriginalDataMoveID = ret.DataMoveID;
            ret.DatabaseName = reader.ToString("DatabaseName");
            ret.TableName = reader.ToString("TableName");
            ret.DateFieldName = reader.ToString("DateFieldName");
            ret.IndexName = reader.ToString("IndexName");
            ret.HandleMode = reader.ToInt32("HandleMode");
            ret.KeepValue = reader.ToInt32("KeepValue");
            ret.WhereStatement = reader.ToString("WhereStatement");
            ret.Status = reader.ToInt32("Status");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// 数据迁移策略定义，就解决大表数据清理
    /// 【表 s_data_move 的操作类】
    /// </summary>
    public class S_data_moveMO : MySqlTableMO<S_data_moveEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`s_data_move`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public S_data_moveMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public S_data_moveMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public S_data_moveMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(S_data_moveEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            item.DataMoveID = Database.ExecSqlScalar<int>(sql_, paras_, tm_);
            return 1;
        }
        public override async Task<int> AddAsync(S_data_moveEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            item.DataMoveID = await Database.ExecSqlScalarAsync<int>(sql_, paras_, tm_);
            return 1;
        }
        private void RepairAddData(S_data_moveEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`DatabaseName`, `TableName`, `DateFieldName`, `IndexName`, `HandleMode`, `KeepValue`, `WhereStatement`, `Status`) VALUE (@DatabaseName, @TableName, @DateFieldName, @IndexName, @HandleMode, @KeepValue, @WhereStatement, @Status);SELECT LAST_INSERT_ID();";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DatabaseName", item.DatabaseName != null ? item.DatabaseName : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@TableName", item.TableName, MySqlDbType.VarChar),
                Database.CreateInParameter("@DateFieldName", item.DateFieldName != null ? item.DateFieldName : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@IndexName", item.IndexName != null ? item.IndexName : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@HandleMode", item.HandleMode, MySqlDbType.Int32),
                Database.CreateInParameter("@KeepValue", item.KeepValue, MySqlDbType.Int32),
                Database.CreateInParameter("@WhereStatement", item.WhereStatement != null ? item.WhereStatement : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
            };
        }
        public int AddByBatch(IEnumerable<S_data_moveEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<S_data_moveEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_data_moveEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`DataMoveID`, `DatabaseName`, `TableName`, `DateFieldName`, `IndexName`, `HandleMode`, `KeepValue`, `WhereStatement`, `Status`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"({item.DataMoveID},'{item.DatabaseName}','{item.TableName}','{item.DateFieldName}','{item.IndexName}',{item.HandleMode},{item.KeepValue},'{item.WhereStatement}',{item.Status}),");
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
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(int dataMoveID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(dataMoveID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(int dataMoveID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(dataMoveID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(int dataMoveID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `DataMoveID` = @DataMoveID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(S_data_moveEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.DataMoveID, tm_);
        }
        public async Task<int> RemoveAsync(S_data_moveEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.DataMoveID, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
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
        #region RemoveByDateFieldName
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "dateFieldName">时间字段名</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByDateFieldName(string dateFieldName, TransactionManager tm_ = null)
        {
            RepairRemoveByDateFieldNameData(dateFieldName, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByDateFieldNameAsync(string dateFieldName, TransactionManager tm_ = null)
        {
            RepairRemoveByDateFieldNameData(dateFieldName, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByDateFieldNameData(string dateFieldName, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (dateFieldName != null ? "`DateFieldName` = @DateFieldName" : "`DateFieldName` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (dateFieldName != null)
                paras_.Add(Database.CreateInParameter("@DateFieldName", dateFieldName, MySqlDbType.VarChar));
        }
        #endregion // RemoveByDateFieldName
        #region RemoveByIndexName
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "indexName">索引名称</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByIndexName(string indexName, TransactionManager tm_ = null)
        {
            RepairRemoveByIndexNameData(indexName, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByIndexNameAsync(string indexName, TransactionManager tm_ = null)
        {
            RepairRemoveByIndexNameData(indexName, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByIndexNameData(string indexName, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (indexName != null ? "`IndexName` = @IndexName" : "`IndexName` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (indexName != null)
                paras_.Add(Database.CreateInParameter("@IndexName", indexName, MySqlDbType.VarChar));
        }
        #endregion // RemoveByIndexName
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
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）</param>
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
        #region RemoveByWhereStatement
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "whereStatement">迁移数据的条件</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByWhereStatement(string whereStatement, TransactionManager tm_ = null)
        {
            RepairRemoveByWhereStatementData(whereStatement, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByWhereStatementAsync(string whereStatement, TransactionManager tm_ = null)
        {
            RepairRemoveByWhereStatementData(whereStatement, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByWhereStatementData(string whereStatement, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (whereStatement != null ? "`WhereStatement` = @WhereStatement" : "`WhereStatement` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (whereStatement != null)
                paras_.Add(Database.CreateInParameter("@WhereStatement", whereStatement, MySqlDbType.VarChar));
        }
        #endregion // RemoveByWhereStatement
        #region RemoveByStatus
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "status">状态(0-无效1-有效)</param>
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
        public int Put(S_data_moveEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(S_data_moveEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(S_data_moveEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `DatabaseName` = @DatabaseName, `TableName` = @TableName, `DateFieldName` = @DateFieldName, `IndexName` = @IndexName, `HandleMode` = @HandleMode, `KeepValue` = @KeepValue, `WhereStatement` = @WhereStatement, `Status` = @Status WHERE `DataMoveID` = @DataMoveID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DatabaseName", item.DatabaseName != null ? item.DatabaseName : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@TableName", item.TableName, MySqlDbType.VarChar),
                Database.CreateInParameter("@DateFieldName", item.DateFieldName != null ? item.DateFieldName : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@IndexName", item.IndexName != null ? item.IndexName : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@HandleMode", item.HandleMode, MySqlDbType.Int32),
                Database.CreateInParameter("@KeepValue", item.KeepValue, MySqlDbType.Int32),
                Database.CreateInParameter("@WhereStatement", item.WhereStatement != null ? item.WhereStatement : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
                Database.CreateInParameter("@DataMoveID_Original", item.HasOriginal ? item.OriginalDataMoveID : item.DataMoveID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<S_data_moveEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<S_data_moveEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int dataMoveID, string set_, params object[] values_)
        {
            return Put(set_, "`DataMoveID` = @DataMoveID", ConcatValues(values_, dataMoveID));
        }
        public async Task<int> PutByPKAsync(int dataMoveID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`DataMoveID` = @DataMoveID", ConcatValues(values_, dataMoveID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int dataMoveID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`DataMoveID` = @DataMoveID", tm_, ConcatValues(values_, dataMoveID));
        }
        public async Task<int> PutByPKAsync(int dataMoveID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`DataMoveID` = @DataMoveID", tm_, ConcatValues(values_, dataMoveID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int dataMoveID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return Put(set_, "`DataMoveID` = @DataMoveID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(int dataMoveID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return await PutAsync(set_, "`DataMoveID` = @DataMoveID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutDatabaseName
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// /// <param name = "databaseName">数据库名（配置文件连接名或连接字符串）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutDatabaseNameByPK(int dataMoveID, string databaseName, TransactionManager tm_ = null)
        {
            RepairPutDatabaseNameByPKData(dataMoveID, databaseName, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutDatabaseNameByPKAsync(int dataMoveID, string databaseName, TransactionManager tm_ = null)
        {
            RepairPutDatabaseNameByPKData(dataMoveID, databaseName, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutDatabaseNameByPKData(int dataMoveID, string databaseName, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `DatabaseName` = @DatabaseName  WHERE `DataMoveID` = @DataMoveID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DatabaseName", databaseName != null ? databaseName : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
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
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// /// <param name = "tableName">表名</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutTableNameByPK(int dataMoveID, string tableName, TransactionManager tm_ = null)
        {
            RepairPutTableNameByPKData(dataMoveID, tableName, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutTableNameByPKAsync(int dataMoveID, string tableName, TransactionManager tm_ = null)
        {
            RepairPutTableNameByPKData(dataMoveID, tableName, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutTableNameByPKData(int dataMoveID, string tableName, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `TableName` = @TableName  WHERE `DataMoveID` = @DataMoveID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@TableName", tableName, MySqlDbType.VarChar),
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
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
        #region PutDateFieldName
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// /// <param name = "dateFieldName">时间字段名</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutDateFieldNameByPK(int dataMoveID, string dateFieldName, TransactionManager tm_ = null)
        {
            RepairPutDateFieldNameByPKData(dataMoveID, dateFieldName, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutDateFieldNameByPKAsync(int dataMoveID, string dateFieldName, TransactionManager tm_ = null)
        {
            RepairPutDateFieldNameByPKData(dataMoveID, dateFieldName, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutDateFieldNameByPKData(int dataMoveID, string dateFieldName, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `DateFieldName` = @DateFieldName  WHERE `DataMoveID` = @DataMoveID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DateFieldName", dateFieldName != null ? dateFieldName : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "dateFieldName">时间字段名</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutDateFieldName(string dateFieldName, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `DateFieldName` = @DateFieldName";
            var parameter_ = Database.CreateInParameter("@DateFieldName", dateFieldName != null ? dateFieldName : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutDateFieldNameAsync(string dateFieldName, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `DateFieldName` = @DateFieldName";
            var parameter_ = Database.CreateInParameter("@DateFieldName", dateFieldName != null ? dateFieldName : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutDateFieldName
        #region PutIndexName
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// /// <param name = "indexName">索引名称</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutIndexNameByPK(int dataMoveID, string indexName, TransactionManager tm_ = null)
        {
            RepairPutIndexNameByPKData(dataMoveID, indexName, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutIndexNameByPKAsync(int dataMoveID, string indexName, TransactionManager tm_ = null)
        {
            RepairPutIndexNameByPKData(dataMoveID, indexName, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutIndexNameByPKData(int dataMoveID, string indexName, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `IndexName` = @IndexName  WHERE `DataMoveID` = @DataMoveID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@IndexName", indexName != null ? indexName : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "indexName">索引名称</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutIndexName(string indexName, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `IndexName` = @IndexName";
            var parameter_ = Database.CreateInParameter("@IndexName", indexName != null ? indexName : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutIndexNameAsync(string indexName, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `IndexName` = @IndexName";
            var parameter_ = Database.CreateInParameter("@IndexName", indexName != null ? indexName : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutIndexName
        #region PutHandleMode
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// /// <param name = "handleMode">处理方式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutHandleModeByPK(int dataMoveID, int handleMode, TransactionManager tm_ = null)
        {
            RepairPutHandleModeByPKData(dataMoveID, handleMode, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutHandleModeByPKAsync(int dataMoveID, int handleMode, TransactionManager tm_ = null)
        {
            RepairPutHandleModeByPKData(dataMoveID, handleMode, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutHandleModeByPKData(int dataMoveID, int handleMode, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `HandleMode` = @HandleMode  WHERE `DataMoveID` = @DataMoveID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@HandleMode", handleMode, MySqlDbType.Int32),
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
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
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutKeepValueByPK(int dataMoveID, int keepValue, TransactionManager tm_ = null)
        {
            RepairPutKeepValueByPKData(dataMoveID, keepValue, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutKeepValueByPKAsync(int dataMoveID, int keepValue, TransactionManager tm_ = null)
        {
            RepairPutKeepValueByPKData(dataMoveID, keepValue, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutKeepValueByPKData(int dataMoveID, int keepValue, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `KeepValue` = @KeepValue  WHERE `DataMoveID` = @DataMoveID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@KeepValue", keepValue, MySqlDbType.Int32),
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）</param>
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
        #region PutWhereStatement
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// /// <param name = "whereStatement">迁移数据的条件</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutWhereStatementByPK(int dataMoveID, string whereStatement, TransactionManager tm_ = null)
        {
            RepairPutWhereStatementByPKData(dataMoveID, whereStatement, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutWhereStatementByPKAsync(int dataMoveID, string whereStatement, TransactionManager tm_ = null)
        {
            RepairPutWhereStatementByPKData(dataMoveID, whereStatement, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutWhereStatementByPKData(int dataMoveID, string whereStatement, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `WhereStatement` = @WhereStatement  WHERE `DataMoveID` = @DataMoveID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@WhereStatement", whereStatement != null ? whereStatement : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "whereStatement">迁移数据的条件</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutWhereStatement(string whereStatement, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `WhereStatement` = @WhereStatement";
            var parameter_ = Database.CreateInParameter("@WhereStatement", whereStatement != null ? whereStatement : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutWhereStatementAsync(string whereStatement, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `WhereStatement` = @WhereStatement";
            var parameter_ = Database.CreateInParameter("@WhereStatement", whereStatement != null ? whereStatement : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutWhereStatement
        #region PutStatus
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// /// <param name = "status">状态(0-无效1-有效)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutStatusByPK(int dataMoveID, int status, TransactionManager tm_ = null)
        {
            RepairPutStatusByPKData(dataMoveID, status, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutStatusByPKAsync(int dataMoveID, int status, TransactionManager tm_ = null)
        {
            RepairPutStatusByPKData(dataMoveID, status, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutStatusByPKData(int dataMoveID, int status, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `DataMoveID` = @DataMoveID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "status">状态(0-无效1-有效)</param>
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
        #endregion // PutXXX
        #endregion // Put

        #region Set

        /// <summary>
        /// 插入或者更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>true:插入操作；false:更新操作</return>
        public bool Set(S_data_moveEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.DataMoveID) == null)
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
        public async Task<bool> SetAsync(S_data_moveEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.DataMoveID) == null)
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
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public S_data_moveEO GetByPK(int dataMoveID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(dataMoveID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        public async Task<S_data_moveEO> GetByPKAsync(int dataMoveID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(dataMoveID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        private void RepairGetByPKData(int dataMoveID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`DataMoveID` = @DataMoveID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 DatabaseName（字段）
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetDatabaseNameByPK(int dataMoveID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return (string)GetScalar("`DatabaseName`", "`DataMoveID` = @DataMoveID", paras_, tm_);
        }
        public async Task<string> GetDatabaseNameByPKAsync(int dataMoveID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return (string)await GetScalarAsync("`DatabaseName`", "`DataMoveID` = @DataMoveID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 TableName（字段）
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetTableNameByPK(int dataMoveID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return (string)GetScalar("`TableName`", "`DataMoveID` = @DataMoveID", paras_, tm_);
        }
        public async Task<string> GetTableNameByPKAsync(int dataMoveID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return (string)await GetScalarAsync("`TableName`", "`DataMoveID` = @DataMoveID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 DateFieldName（字段）
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetDateFieldNameByPK(int dataMoveID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return (string)GetScalar("`DateFieldName`", "`DataMoveID` = @DataMoveID", paras_, tm_);
        }
        public async Task<string> GetDateFieldNameByPKAsync(int dataMoveID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return (string)await GetScalarAsync("`DateFieldName`", "`DataMoveID` = @DataMoveID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 IndexName（字段）
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetIndexNameByPK(int dataMoveID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return (string)GetScalar("`IndexName`", "`DataMoveID` = @DataMoveID", paras_, tm_);
        }
        public async Task<string> GetIndexNameByPKAsync(int dataMoveID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return (string)await GetScalarAsync("`IndexName`", "`DataMoveID` = @DataMoveID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 HandleMode（字段）
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetHandleModeByPK(int dataMoveID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`HandleMode`", "`DataMoveID` = @DataMoveID", paras_, tm_);
        }
        public async Task<int> GetHandleModeByPKAsync(int dataMoveID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`HandleMode`", "`DataMoveID` = @DataMoveID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 KeepValue（字段）
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetKeepValueByPK(int dataMoveID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`KeepValue`", "`DataMoveID` = @DataMoveID", paras_, tm_);
        }
        public async Task<int> GetKeepValueByPKAsync(int dataMoveID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`KeepValue`", "`DataMoveID` = @DataMoveID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 WhereStatement（字段）
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetWhereStatementByPK(int dataMoveID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return (string)GetScalar("`WhereStatement`", "`DataMoveID` = @DataMoveID", paras_, tm_);
        }
        public async Task<string> GetWhereStatementByPKAsync(int dataMoveID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return (string)await GetScalarAsync("`WhereStatement`", "`DataMoveID` = @DataMoveID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Status（字段）
        /// </summary>
        /// /// <param name = "dataMoveID">数据迁移编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetStatusByPK(int dataMoveID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Status`", "`DataMoveID` = @DataMoveID", paras_, tm_);
        }
        public async Task<int> GetStatusByPKAsync(int dataMoveID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@DataMoveID", dataMoveID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Status`", "`DataMoveID` = @DataMoveID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByDatabaseName

        /// <summary>
        /// 按 DatabaseName（字段） 查询
        /// </summary>
        /// /// <param name = "databaseName">数据库名（配置文件连接名或连接字符串）</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByDatabaseName(string databaseName)
        {
            return GetByDatabaseName(databaseName, 0, string.Empty, null);
        }
        public async Task<List<S_data_moveEO>> GetByDatabaseNameAsync(string databaseName)
        {
            return await GetByDatabaseNameAsync(databaseName, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 DatabaseName（字段） 查询
        /// </summary>
        /// /// <param name = "databaseName">数据库名（配置文件连接名或连接字符串）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByDatabaseName(string databaseName, TransactionManager tm_)
        {
            return GetByDatabaseName(databaseName, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByDatabaseNameAsync(string databaseName, TransactionManager tm_)
        {
            return await GetByDatabaseNameAsync(databaseName, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 DatabaseName（字段） 查询
        /// </summary>
        /// /// <param name = "databaseName">数据库名（配置文件连接名或连接字符串）</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByDatabaseName(string databaseName, int top_)
        {
            return GetByDatabaseName(databaseName, top_, string.Empty, null);
        }
        public async Task<List<S_data_moveEO>> GetByDatabaseNameAsync(string databaseName, int top_)
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
        public List<S_data_moveEO> GetByDatabaseName(string databaseName, int top_, TransactionManager tm_)
        {
            return GetByDatabaseName(databaseName, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByDatabaseNameAsync(string databaseName, int top_, TransactionManager tm_)
        {
            return await GetByDatabaseNameAsync(databaseName, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 DatabaseName（字段） 查询
        /// </summary>
        /// /// <param name = "databaseName">数据库名（配置文件连接名或连接字符串）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByDatabaseName(string databaseName, string sort_)
        {
            return GetByDatabaseName(databaseName, 0, sort_, null);
        }
        public async Task<List<S_data_moveEO>> GetByDatabaseNameAsync(string databaseName, string sort_)
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
        public List<S_data_moveEO> GetByDatabaseName(string databaseName, string sort_, TransactionManager tm_)
        {
            return GetByDatabaseName(databaseName, 0, sort_, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByDatabaseNameAsync(string databaseName, string sort_, TransactionManager tm_)
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
        public List<S_data_moveEO> GetByDatabaseName(string databaseName, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(databaseName != null ? "`DatabaseName` = @DatabaseName" : "`DatabaseName` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (databaseName != null)
                paras_.Add(Database.CreateInParameter("@DatabaseName", databaseName, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        public async Task<List<S_data_moveEO>> GetByDatabaseNameAsync(string databaseName, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(databaseName != null ? "`DatabaseName` = @DatabaseName" : "`DatabaseName` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (databaseName != null)
                paras_.Add(Database.CreateInParameter("@DatabaseName", databaseName, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        #endregion // GetByDatabaseName
        #region GetByTableName

        /// <summary>
        /// 按 TableName（字段） 查询
        /// </summary>
        /// /// <param name = "tableName">表名</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByTableName(string tableName)
        {
            return GetByTableName(tableName, 0, string.Empty, null);
        }
        public async Task<List<S_data_moveEO>> GetByTableNameAsync(string tableName)
        {
            return await GetByTableNameAsync(tableName, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 TableName（字段） 查询
        /// </summary>
        /// /// <param name = "tableName">表名</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByTableName(string tableName, TransactionManager tm_)
        {
            return GetByTableName(tableName, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByTableNameAsync(string tableName, TransactionManager tm_)
        {
            return await GetByTableNameAsync(tableName, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 TableName（字段） 查询
        /// </summary>
        /// /// <param name = "tableName">表名</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByTableName(string tableName, int top_)
        {
            return GetByTableName(tableName, top_, string.Empty, null);
        }
        public async Task<List<S_data_moveEO>> GetByTableNameAsync(string tableName, int top_)
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
        public List<S_data_moveEO> GetByTableName(string tableName, int top_, TransactionManager tm_)
        {
            return GetByTableName(tableName, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByTableNameAsync(string tableName, int top_, TransactionManager tm_)
        {
            return await GetByTableNameAsync(tableName, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 TableName（字段） 查询
        /// </summary>
        /// /// <param name = "tableName">表名</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByTableName(string tableName, string sort_)
        {
            return GetByTableName(tableName, 0, sort_, null);
        }
        public async Task<List<S_data_moveEO>> GetByTableNameAsync(string tableName, string sort_)
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
        public List<S_data_moveEO> GetByTableName(string tableName, string sort_, TransactionManager tm_)
        {
            return GetByTableName(tableName, 0, sort_, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByTableNameAsync(string tableName, string sort_, TransactionManager tm_)
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
        public List<S_data_moveEO> GetByTableName(string tableName, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`TableName` = @TableName", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TableName", tableName, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        public async Task<List<S_data_moveEO>> GetByTableNameAsync(string tableName, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`TableName` = @TableName", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TableName", tableName, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        #endregion // GetByTableName
        #region GetByDateFieldName

        /// <summary>
        /// 按 DateFieldName（字段） 查询
        /// </summary>
        /// /// <param name = "dateFieldName">时间字段名</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByDateFieldName(string dateFieldName)
        {
            return GetByDateFieldName(dateFieldName, 0, string.Empty, null);
        }
        public async Task<List<S_data_moveEO>> GetByDateFieldNameAsync(string dateFieldName)
        {
            return await GetByDateFieldNameAsync(dateFieldName, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 DateFieldName（字段） 查询
        /// </summary>
        /// /// <param name = "dateFieldName">时间字段名</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByDateFieldName(string dateFieldName, TransactionManager tm_)
        {
            return GetByDateFieldName(dateFieldName, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByDateFieldNameAsync(string dateFieldName, TransactionManager tm_)
        {
            return await GetByDateFieldNameAsync(dateFieldName, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 DateFieldName（字段） 查询
        /// </summary>
        /// /// <param name = "dateFieldName">时间字段名</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByDateFieldName(string dateFieldName, int top_)
        {
            return GetByDateFieldName(dateFieldName, top_, string.Empty, null);
        }
        public async Task<List<S_data_moveEO>> GetByDateFieldNameAsync(string dateFieldName, int top_)
        {
            return await GetByDateFieldNameAsync(dateFieldName, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 DateFieldName（字段） 查询
        /// </summary>
        /// /// <param name = "dateFieldName">时间字段名</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByDateFieldName(string dateFieldName, int top_, TransactionManager tm_)
        {
            return GetByDateFieldName(dateFieldName, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByDateFieldNameAsync(string dateFieldName, int top_, TransactionManager tm_)
        {
            return await GetByDateFieldNameAsync(dateFieldName, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 DateFieldName（字段） 查询
        /// </summary>
        /// /// <param name = "dateFieldName">时间字段名</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByDateFieldName(string dateFieldName, string sort_)
        {
            return GetByDateFieldName(dateFieldName, 0, sort_, null);
        }
        public async Task<List<S_data_moveEO>> GetByDateFieldNameAsync(string dateFieldName, string sort_)
        {
            return await GetByDateFieldNameAsync(dateFieldName, 0, sort_, null);
        }

        /// <summary>
        /// 按 DateFieldName（字段） 查询
        /// </summary>
        /// /// <param name = "dateFieldName">时间字段名</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByDateFieldName(string dateFieldName, string sort_, TransactionManager tm_)
        {
            return GetByDateFieldName(dateFieldName, 0, sort_, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByDateFieldNameAsync(string dateFieldName, string sort_, TransactionManager tm_)
        {
            return await GetByDateFieldNameAsync(dateFieldName, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 DateFieldName（字段） 查询
        /// </summary>
        /// /// <param name = "dateFieldName">时间字段名</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByDateFieldName(string dateFieldName, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(dateFieldName != null ? "`DateFieldName` = @DateFieldName" : "`DateFieldName` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (dateFieldName != null)
                paras_.Add(Database.CreateInParameter("@DateFieldName", dateFieldName, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        public async Task<List<S_data_moveEO>> GetByDateFieldNameAsync(string dateFieldName, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(dateFieldName != null ? "`DateFieldName` = @DateFieldName" : "`DateFieldName` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (dateFieldName != null)
                paras_.Add(Database.CreateInParameter("@DateFieldName", dateFieldName, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        #endregion // GetByDateFieldName
        #region GetByIndexName

        /// <summary>
        /// 按 IndexName（字段） 查询
        /// </summary>
        /// /// <param name = "indexName">索引名称</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByIndexName(string indexName)
        {
            return GetByIndexName(indexName, 0, string.Empty, null);
        }
        public async Task<List<S_data_moveEO>> GetByIndexNameAsync(string indexName)
        {
            return await GetByIndexNameAsync(indexName, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 IndexName（字段） 查询
        /// </summary>
        /// /// <param name = "indexName">索引名称</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByIndexName(string indexName, TransactionManager tm_)
        {
            return GetByIndexName(indexName, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByIndexNameAsync(string indexName, TransactionManager tm_)
        {
            return await GetByIndexNameAsync(indexName, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 IndexName（字段） 查询
        /// </summary>
        /// /// <param name = "indexName">索引名称</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByIndexName(string indexName, int top_)
        {
            return GetByIndexName(indexName, top_, string.Empty, null);
        }
        public async Task<List<S_data_moveEO>> GetByIndexNameAsync(string indexName, int top_)
        {
            return await GetByIndexNameAsync(indexName, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 IndexName（字段） 查询
        /// </summary>
        /// /// <param name = "indexName">索引名称</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByIndexName(string indexName, int top_, TransactionManager tm_)
        {
            return GetByIndexName(indexName, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByIndexNameAsync(string indexName, int top_, TransactionManager tm_)
        {
            return await GetByIndexNameAsync(indexName, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 IndexName（字段） 查询
        /// </summary>
        /// /// <param name = "indexName">索引名称</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByIndexName(string indexName, string sort_)
        {
            return GetByIndexName(indexName, 0, sort_, null);
        }
        public async Task<List<S_data_moveEO>> GetByIndexNameAsync(string indexName, string sort_)
        {
            return await GetByIndexNameAsync(indexName, 0, sort_, null);
        }

        /// <summary>
        /// 按 IndexName（字段） 查询
        /// </summary>
        /// /// <param name = "indexName">索引名称</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByIndexName(string indexName, string sort_, TransactionManager tm_)
        {
            return GetByIndexName(indexName, 0, sort_, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByIndexNameAsync(string indexName, string sort_, TransactionManager tm_)
        {
            return await GetByIndexNameAsync(indexName, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 IndexName（字段） 查询
        /// </summary>
        /// /// <param name = "indexName">索引名称</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByIndexName(string indexName, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(indexName != null ? "`IndexName` = @IndexName" : "`IndexName` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (indexName != null)
                paras_.Add(Database.CreateInParameter("@IndexName", indexName, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        public async Task<List<S_data_moveEO>> GetByIndexNameAsync(string indexName, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(indexName != null ? "`IndexName` = @IndexName" : "`IndexName` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (indexName != null)
                paras_.Add(Database.CreateInParameter("@IndexName", indexName, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        #endregion // GetByIndexName
        #region GetByHandleMode

        /// <summary>
        /// 按 HandleMode（字段） 查询
        /// </summary>
        /// /// <param name = "handleMode">处理方式</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByHandleMode(int handleMode)
        {
            return GetByHandleMode(handleMode, 0, string.Empty, null);
        }
        public async Task<List<S_data_moveEO>> GetByHandleModeAsync(int handleMode)
        {
            return await GetByHandleModeAsync(handleMode, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 HandleMode（字段） 查询
        /// </summary>
        /// /// <param name = "handleMode">处理方式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByHandleMode(int handleMode, TransactionManager tm_)
        {
            return GetByHandleMode(handleMode, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByHandleModeAsync(int handleMode, TransactionManager tm_)
        {
            return await GetByHandleModeAsync(handleMode, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 HandleMode（字段） 查询
        /// </summary>
        /// /// <param name = "handleMode">处理方式</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByHandleMode(int handleMode, int top_)
        {
            return GetByHandleMode(handleMode, top_, string.Empty, null);
        }
        public async Task<List<S_data_moveEO>> GetByHandleModeAsync(int handleMode, int top_)
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
        public List<S_data_moveEO> GetByHandleMode(int handleMode, int top_, TransactionManager tm_)
        {
            return GetByHandleMode(handleMode, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByHandleModeAsync(int handleMode, int top_, TransactionManager tm_)
        {
            return await GetByHandleModeAsync(handleMode, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 HandleMode（字段） 查询
        /// </summary>
        /// /// <param name = "handleMode">处理方式</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByHandleMode(int handleMode, string sort_)
        {
            return GetByHandleMode(handleMode, 0, sort_, null);
        }
        public async Task<List<S_data_moveEO>> GetByHandleModeAsync(int handleMode, string sort_)
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
        public List<S_data_moveEO> GetByHandleMode(int handleMode, string sort_, TransactionManager tm_)
        {
            return GetByHandleMode(handleMode, 0, sort_, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByHandleModeAsync(int handleMode, string sort_, TransactionManager tm_)
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
        public List<S_data_moveEO> GetByHandleMode(int handleMode, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`HandleMode` = @HandleMode", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@HandleMode", handleMode, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        public async Task<List<S_data_moveEO>> GetByHandleModeAsync(int handleMode, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`HandleMode` = @HandleMode", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@HandleMode", handleMode, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        #endregion // GetByHandleMode
        #region GetByKeepValue

        /// <summary>
        /// 按 KeepValue（字段） 查询
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByKeepValue(int keepValue)
        {
            return GetByKeepValue(keepValue, 0, string.Empty, null);
        }
        public async Task<List<S_data_moveEO>> GetByKeepValueAsync(int keepValue)
        {
            return await GetByKeepValueAsync(keepValue, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 KeepValue（字段） 查询
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByKeepValue(int keepValue, TransactionManager tm_)
        {
            return GetByKeepValue(keepValue, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByKeepValueAsync(int keepValue, TransactionManager tm_)
        {
            return await GetByKeepValueAsync(keepValue, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 KeepValue（字段） 查询
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByKeepValue(int keepValue, int top_)
        {
            return GetByKeepValue(keepValue, top_, string.Empty, null);
        }
        public async Task<List<S_data_moveEO>> GetByKeepValueAsync(int keepValue, int top_)
        {
            return await GetByKeepValueAsync(keepValue, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 KeepValue（字段） 查询
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByKeepValue(int keepValue, int top_, TransactionManager tm_)
        {
            return GetByKeepValue(keepValue, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByKeepValueAsync(int keepValue, int top_, TransactionManager tm_)
        {
            return await GetByKeepValueAsync(keepValue, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 KeepValue（字段） 查询
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByKeepValue(int keepValue, string sort_)
        {
            return GetByKeepValue(keepValue, 0, sort_, null);
        }
        public async Task<List<S_data_moveEO>> GetByKeepValueAsync(int keepValue, string sort_)
        {
            return await GetByKeepValueAsync(keepValue, 0, sort_, null);
        }

        /// <summary>
        /// 按 KeepValue（字段） 查询
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByKeepValue(int keepValue, string sort_, TransactionManager tm_)
        {
            return GetByKeepValue(keepValue, 0, sort_, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByKeepValueAsync(int keepValue, string sort_, TransactionManager tm_)
        {
            return await GetByKeepValueAsync(keepValue, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 KeepValue（字段） 查询
        /// </summary>
        /// /// <param name = "keepValue">保留数据长度（根据HandleMode值不同）</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByKeepValue(int keepValue, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`KeepValue` = @KeepValue", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@KeepValue", keepValue, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        public async Task<List<S_data_moveEO>> GetByKeepValueAsync(int keepValue, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`KeepValue` = @KeepValue", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@KeepValue", keepValue, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        #endregion // GetByKeepValue
        #region GetByWhereStatement

        /// <summary>
        /// 按 WhereStatement（字段） 查询
        /// </summary>
        /// /// <param name = "whereStatement">迁移数据的条件</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByWhereStatement(string whereStatement)
        {
            return GetByWhereStatement(whereStatement, 0, string.Empty, null);
        }
        public async Task<List<S_data_moveEO>> GetByWhereStatementAsync(string whereStatement)
        {
            return await GetByWhereStatementAsync(whereStatement, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 WhereStatement（字段） 查询
        /// </summary>
        /// /// <param name = "whereStatement">迁移数据的条件</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByWhereStatement(string whereStatement, TransactionManager tm_)
        {
            return GetByWhereStatement(whereStatement, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByWhereStatementAsync(string whereStatement, TransactionManager tm_)
        {
            return await GetByWhereStatementAsync(whereStatement, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 WhereStatement（字段） 查询
        /// </summary>
        /// /// <param name = "whereStatement">迁移数据的条件</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByWhereStatement(string whereStatement, int top_)
        {
            return GetByWhereStatement(whereStatement, top_, string.Empty, null);
        }
        public async Task<List<S_data_moveEO>> GetByWhereStatementAsync(string whereStatement, int top_)
        {
            return await GetByWhereStatementAsync(whereStatement, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 WhereStatement（字段） 查询
        /// </summary>
        /// /// <param name = "whereStatement">迁移数据的条件</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByWhereStatement(string whereStatement, int top_, TransactionManager tm_)
        {
            return GetByWhereStatement(whereStatement, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByWhereStatementAsync(string whereStatement, int top_, TransactionManager tm_)
        {
            return await GetByWhereStatementAsync(whereStatement, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 WhereStatement（字段） 查询
        /// </summary>
        /// /// <param name = "whereStatement">迁移数据的条件</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByWhereStatement(string whereStatement, string sort_)
        {
            return GetByWhereStatement(whereStatement, 0, sort_, null);
        }
        public async Task<List<S_data_moveEO>> GetByWhereStatementAsync(string whereStatement, string sort_)
        {
            return await GetByWhereStatementAsync(whereStatement, 0, sort_, null);
        }

        /// <summary>
        /// 按 WhereStatement（字段） 查询
        /// </summary>
        /// /// <param name = "whereStatement">迁移数据的条件</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByWhereStatement(string whereStatement, string sort_, TransactionManager tm_)
        {
            return GetByWhereStatement(whereStatement, 0, sort_, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByWhereStatementAsync(string whereStatement, string sort_, TransactionManager tm_)
        {
            return await GetByWhereStatementAsync(whereStatement, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 WhereStatement（字段） 查询
        /// </summary>
        /// /// <param name = "whereStatement">迁移数据的条件</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByWhereStatement(string whereStatement, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(whereStatement != null ? "`WhereStatement` = @WhereStatement" : "`WhereStatement` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (whereStatement != null)
                paras_.Add(Database.CreateInParameter("@WhereStatement", whereStatement, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        public async Task<List<S_data_moveEO>> GetByWhereStatementAsync(string whereStatement, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(whereStatement != null ? "`WhereStatement` = @WhereStatement" : "`WhereStatement` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (whereStatement != null)
                paras_.Add(Database.CreateInParameter("@WhereStatement", whereStatement, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        #endregion // GetByWhereStatement
        #region GetByStatus

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态(0-无效1-有效)</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByStatus(int status)
        {
            return GetByStatus(status, 0, string.Empty, null);
        }
        public async Task<List<S_data_moveEO>> GetByStatusAsync(int status)
        {
            return await GetByStatusAsync(status, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态(0-无效1-有效)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByStatus(int status, TransactionManager tm_)
        {
            return GetByStatus(status, 0, string.Empty, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByStatusAsync(int status, TransactionManager tm_)
        {
            return await GetByStatusAsync(status, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态(0-无效1-有效)</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByStatus(int status, int top_)
        {
            return GetByStatus(status, top_, string.Empty, null);
        }
        public async Task<List<S_data_moveEO>> GetByStatusAsync(int status, int top_)
        {
            return await GetByStatusAsync(status, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态(0-无效1-有效)</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByStatus(int status, int top_, TransactionManager tm_)
        {
            return GetByStatus(status, top_, string.Empty, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
        {
            return await GetByStatusAsync(status, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态(0-无效1-有效)</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByStatus(int status, string sort_)
        {
            return GetByStatus(status, 0, sort_, null);
        }
        public async Task<List<S_data_moveEO>> GetByStatusAsync(int status, string sort_)
        {
            return await GetByStatusAsync(status, 0, sort_, null);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态(0-无效1-有效)</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByStatus(int status, string sort_, TransactionManager tm_)
        {
            return GetByStatus(status, 0, sort_, tm_);
        }
        public async Task<List<S_data_moveEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
        {
            return await GetByStatusAsync(status, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态(0-无效1-有效)</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_data_moveEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        public async Task<List<S_data_moveEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_data_moveEO.MapDataReader);
        }
        #endregion // GetByStatus
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
