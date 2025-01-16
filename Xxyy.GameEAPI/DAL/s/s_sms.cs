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
    /// 短信商
    /// 【表 s_sms 的实体类】
    /// </summary>
    [DataContract]
    public class S_smsEO : IRowMapper<S_smsEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public S_smsEO()
        {
            this.RecDate = DateTime.Now;
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private string _originalSmsID;
        /// <summary>
        /// 【数据库中的原始主键 SmsID 值的副本，用于主键值更新】
        /// </summary>
        public string OriginalSmsID
        {
            get { return _originalSmsID; }
            set { HasOriginal = true; _originalSmsID = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "SmsID", SmsID }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// 短信商编码
        /// 【主键 varchar(50)】
        /// </summary>
        [DataMember(Order = 1)]
        public string SmsID { get; set; }
        /// <summary>
        /// 名称
        /// 【字段 varchar(50)】
        /// </summary>
        [DataMember(Order = 2)]
        public string Name { get; set; }
        /// <summary>
        /// 记录时间
        /// 【字段 datetime】
        /// </summary>
        [DataMember(Order = 3)]
        public DateTime RecDate { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public S_smsEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static S_smsEO MapDataReader(IDataReader reader)
        {
            S_smsEO ret = new S_smsEO();
            ret.SmsID = reader.ToString("SmsID");
            ret.OriginalSmsID = ret.SmsID;
            ret.Name = reader.ToString("Name");
            ret.RecDate = reader.ToDateTime("RecDate");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// 短信商
    /// 【表 s_sms 的操作类】
    /// </summary>
    public class S_smsMO : MySqlTableMO<S_smsEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`s_sms`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public S_smsMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public S_smsMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public S_smsMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(S_smsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(S_smsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(S_smsEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`SmsID`, `Name`, `RecDate`) VALUE (@SmsID, @Name, @RecDate);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", item.SmsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
            };
        }
        public int AddByBatch(IEnumerable<S_smsEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<S_smsEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_smsEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`SmsID`, `Name`, `RecDate`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"('{item.SmsID}','{item.Name}','{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(string smsID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(smsID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(string smsID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(smsID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(string smsID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `SmsID` = @SmsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(S_smsEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.SmsID, tm_);
        }
        public async Task<int> RemoveAsync(S_smsEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.SmsID, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
        #region RemoveByName
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByName(string name, TransactionManager tm_ = null)
        {
            RepairRemoveByNameData(name, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByNameAsync(string name, TransactionManager tm_ = null)
        {
            RepairRemoveByNameData(name, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByNameData(string name, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (name != null ? "`Name` = @Name" : "`Name` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (name != null)
                paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
        }
        #endregion // RemoveByName
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
        public int Put(S_smsEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(S_smsEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(S_smsEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `SmsID` = @SmsID, `Name` = @Name WHERE `SmsID` = @SmsID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", item.SmsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SmsID_Original", item.HasOriginal ? item.OriginalSmsID : item.SmsID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<S_smsEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<S_smsEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string smsID, string set_, params object[] values_)
        {
            return Put(set_, "`SmsID` = @SmsID", ConcatValues(values_, smsID));
        }
        public async Task<int> PutByPKAsync(string smsID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`SmsID` = @SmsID", ConcatValues(values_, smsID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string smsID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`SmsID` = @SmsID", tm_, ConcatValues(values_, smsID));
        }
        public async Task<int> PutByPKAsync(string smsID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`SmsID` = @SmsID", tm_, ConcatValues(values_, smsID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string smsID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
            };
            return Put(set_, "`SmsID` = @SmsID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(string smsID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
            };
            return await PutAsync(set_, "`SmsID` = @SmsID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutName
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// /// <param name = "name">名称</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutNameByPK(string smsID, string name, TransactionManager tm_ = null)
        {
            RepairPutNameByPKData(smsID, name, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutNameByPKAsync(string smsID, string name, TransactionManager tm_ = null)
        {
            RepairPutNameByPKData(smsID, name, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutNameByPKData(string smsID, string name, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Name` = @Name  WHERE `SmsID` = @SmsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutName(string name, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Name` = @Name";
            var parameter_ = Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutNameAsync(string name, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Name` = @Name";
            var parameter_ = Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutName
        #region PutRecDate
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRecDateByPK(string smsID, DateTime recDate, TransactionManager tm_ = null)
        {
            RepairPutRecDateByPKData(smsID, recDate, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRecDateByPKAsync(string smsID, DateTime recDate, TransactionManager tm_ = null)
        {
            RepairPutRecDateByPKData(smsID, recDate, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRecDateByPKData(string smsID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `SmsID` = @SmsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
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
        public bool Set(S_smsEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.SmsID) == null)
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
        public async Task<bool> SetAsync(S_smsEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.SmsID) == null)
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
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public S_smsEO GetByPK(string smsID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(smsID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, S_smsEO.MapDataReader);
        }
        public async Task<S_smsEO> GetByPKAsync(string smsID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(smsID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_smsEO.MapDataReader);
        }
        private void RepairGetByPKData(string smsID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`SmsID` = @SmsID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 Name（字段）
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetNameByPK(string smsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`Name`", "`SmsID` = @SmsID", paras_, tm_);
        }
        public async Task<string> GetNameByPKAsync(string smsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`Name`", "`SmsID` = @SmsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 RecDate（字段）
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public DateTime GetRecDateByPK(string smsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
            };
            return (DateTime)GetScalar("`RecDate`", "`SmsID` = @SmsID", paras_, tm_);
        }
        public async Task<DateTime> GetRecDateByPKAsync(string smsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
            };
            return (DateTime)await GetScalarAsync("`RecDate`", "`SmsID` = @SmsID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByName

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <return>实体对象集合</return>
        public List<S_smsEO> GetByName(string name)
        {
            return GetByName(name, 0, string.Empty, null);
        }
        public async Task<List<S_smsEO>> GetByNameAsync(string name)
        {
            return await GetByNameAsync(name, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_smsEO> GetByName(string name, TransactionManager tm_)
        {
            return GetByName(name, 0, string.Empty, tm_);
        }
        public async Task<List<S_smsEO>> GetByNameAsync(string name, TransactionManager tm_)
        {
            return await GetByNameAsync(name, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_smsEO> GetByName(string name, int top_)
        {
            return GetByName(name, top_, string.Empty, null);
        }
        public async Task<List<S_smsEO>> GetByNameAsync(string name, int top_)
        {
            return await GetByNameAsync(name, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_smsEO> GetByName(string name, int top_, TransactionManager tm_)
        {
            return GetByName(name, top_, string.Empty, tm_);
        }
        public async Task<List<S_smsEO>> GetByNameAsync(string name, int top_, TransactionManager tm_)
        {
            return await GetByNameAsync(name, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_smsEO> GetByName(string name, string sort_)
        {
            return GetByName(name, 0, sort_, null);
        }
        public async Task<List<S_smsEO>> GetByNameAsync(string name, string sort_)
        {
            return await GetByNameAsync(name, 0, sort_, null);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_smsEO> GetByName(string name, string sort_, TransactionManager tm_)
        {
            return GetByName(name, 0, sort_, tm_);
        }
        public async Task<List<S_smsEO>> GetByNameAsync(string name, string sort_, TransactionManager tm_)
        {
            return await GetByNameAsync(name, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_smsEO> GetByName(string name, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (name != null)
                paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_smsEO.MapDataReader);
        }
        public async Task<List<S_smsEO>> GetByNameAsync(string name, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (name != null)
                paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_smsEO.MapDataReader);
        }
        #endregion // GetByName
        #region GetByRecDate

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <return>实体对象集合</return>
        public List<S_smsEO> GetByRecDate(DateTime recDate)
        {
            return GetByRecDate(recDate, 0, string.Empty, null);
        }
        public async Task<List<S_smsEO>> GetByRecDateAsync(DateTime recDate)
        {
            return await GetByRecDateAsync(recDate, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_smsEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
        {
            return GetByRecDate(recDate, 0, string.Empty, tm_);
        }
        public async Task<List<S_smsEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
        {
            return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_smsEO> GetByRecDate(DateTime recDate, int top_)
        {
            return GetByRecDate(recDate, top_, string.Empty, null);
        }
        public async Task<List<S_smsEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
        public List<S_smsEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
        {
            return GetByRecDate(recDate, top_, string.Empty, tm_);
        }
        public async Task<List<S_smsEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
        {
            return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_smsEO> GetByRecDate(DateTime recDate, string sort_)
        {
            return GetByRecDate(recDate, 0, sort_, null);
        }
        public async Task<List<S_smsEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
        public List<S_smsEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
        {
            return GetByRecDate(recDate, 0, sort_, tm_);
        }
        public async Task<List<S_smsEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
        public List<S_smsEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
            return Database.ExecSqlList(sql_, paras_, tm_, S_smsEO.MapDataReader);
        }
        public async Task<List<S_smsEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_smsEO.MapDataReader);
        }
        #endregion // GetByRecDate
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
