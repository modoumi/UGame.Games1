/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-11-08 15: 50:58
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
    /// hub88与我方所支持的货币编码对应关系列表
    /// 【表 sp_hub88_currency 的实体类】
    /// </summary>
    [DataContract]
    public class Sp_hub88_currencyEO : IRowMapper<Sp_hub88_currencyEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Sp_hub88_currencyEO()
        {
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private string _originalTrdCurrencyID;
        /// <summary>
        /// 【数据库中的原始主键 TrdCurrencyID 值的副本，用于主键值更新】
        /// </summary>
        public string OriginalTrdCurrencyID
        {
            get { return _originalTrdCurrencyID; }
            set { HasOriginal = true; _originalTrdCurrencyID = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "TrdCurrencyID", TrdCurrencyID }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// 对方currencyId
        /// 【主键 varchar(20)】
        /// </summary>
        [DataMember(Order = 1)]
        public string TrdCurrencyID { get; set; }
        /// <summary>
        /// 货币类型
        /// 【字段 varchar(20)】
        /// </summary>
        [DataMember(Order = 2)]
        public string CurrencyID { get; set; }
        /// <summary>
        /// 货币名称
        /// 【字段 varchar(50)】
        /// </summary>
        [DataMember(Order = 3)]
        public string Name { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public Sp_hub88_currencyEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static Sp_hub88_currencyEO MapDataReader(IDataReader reader)
        {
            Sp_hub88_currencyEO ret = new Sp_hub88_currencyEO();
            ret.TrdCurrencyID = reader.ToString("TrdCurrencyID");
            ret.OriginalTrdCurrencyID = ret.TrdCurrencyID;
            ret.CurrencyID = reader.ToString("CurrencyID");
            ret.Name = reader.ToString("Name");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// hub88与我方所支持的货币编码对应关系列表
    /// 【表 sp_hub88_currency 的操作类】
    /// </summary>
    public class Sp_hub88_currencyMO : MySqlTableMO<Sp_hub88_currencyEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`sp_hub88_currency`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public Sp_hub88_currencyMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public Sp_hub88_currencyMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public Sp_hub88_currencyMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(Sp_hub88_currencyEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(Sp_hub88_currencyEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(Sp_hub88_currencyEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`TrdCurrencyID`, `CurrencyID`, `Name`) VALUE (@TrdCurrencyID, @CurrencyID, @Name);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@TrdCurrencyID", item.TrdCurrencyID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
            };
        }
        public int AddByBatch(IEnumerable<Sp_hub88_currencyEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<Sp_hub88_currencyEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sp_hub88_currencyEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`TrdCurrencyID`, `CurrencyID`, `Name`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"('{item.TrdCurrencyID}','{item.CurrencyID}','{item.Name}'),");
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
        /// /// <param name = "trdCurrencyID">对方currencyId</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(string trdCurrencyID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(trdCurrencyID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(string trdCurrencyID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(trdCurrencyID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(string trdCurrencyID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `TrdCurrencyID` = @TrdCurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@TrdCurrencyID", trdCurrencyID, MySqlDbType.VarChar),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(Sp_hub88_currencyEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.TrdCurrencyID, tm_);
        }
        public async Task<int> RemoveAsync(Sp_hub88_currencyEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.TrdCurrencyID, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
        #region RemoveByCurrencyID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByCurrencyID(string currencyID, TransactionManager tm_ = null)
        {
            RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
        {
            RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByCurrencyIDData(string currencyID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (currencyID != null)
                paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
        }
        #endregion // RemoveByCurrencyID
        #region RemoveByName
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "name">货币名称</param>
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
        public int Put(Sp_hub88_currencyEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(Sp_hub88_currencyEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(Sp_hub88_currencyEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `TrdCurrencyID` = @TrdCurrencyID, `CurrencyID` = @CurrencyID, `Name` = @Name WHERE `TrdCurrencyID` = @TrdCurrencyID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@TrdCurrencyID", item.TrdCurrencyID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@TrdCurrencyID_Original", item.HasOriginal ? item.OriginalTrdCurrencyID : item.TrdCurrencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<Sp_hub88_currencyEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<Sp_hub88_currencyEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "trdCurrencyID">对方currencyId</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string trdCurrencyID, string set_, params object[] values_)
        {
            return Put(set_, "`TrdCurrencyID` = @TrdCurrencyID", ConcatValues(values_, trdCurrencyID));
        }
        public async Task<int> PutByPKAsync(string trdCurrencyID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`TrdCurrencyID` = @TrdCurrencyID", ConcatValues(values_, trdCurrencyID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "trdCurrencyID">对方currencyId</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string trdCurrencyID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`TrdCurrencyID` = @TrdCurrencyID", tm_, ConcatValues(values_, trdCurrencyID));
        }
        public async Task<int> PutByPKAsync(string trdCurrencyID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`TrdCurrencyID` = @TrdCurrencyID", tm_, ConcatValues(values_, trdCurrencyID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "trdCurrencyID">对方currencyId</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string trdCurrencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@TrdCurrencyID", trdCurrencyID, MySqlDbType.VarChar),
            };
            return Put(set_, "`TrdCurrencyID` = @TrdCurrencyID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(string trdCurrencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@TrdCurrencyID", trdCurrencyID, MySqlDbType.VarChar),
            };
            return await PutAsync(set_, "`TrdCurrencyID` = @TrdCurrencyID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutCurrencyID
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "trdCurrencyID">对方currencyId</param>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutCurrencyIDByPK(string trdCurrencyID, string currencyID, TransactionManager tm_ = null)
        {
            RepairPutCurrencyIDByPKData(trdCurrencyID, currencyID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutCurrencyIDByPKAsync(string trdCurrencyID, string currencyID, TransactionManager tm_ = null)
        {
            RepairPutCurrencyIDByPKData(trdCurrencyID, currencyID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutCurrencyIDByPKData(string trdCurrencyID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `TrdCurrencyID` = @TrdCurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@TrdCurrencyID", trdCurrencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutCurrencyID(string currencyID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
            var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
            var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutCurrencyID
        #region PutName
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "trdCurrencyID">对方currencyId</param>
        /// /// <param name = "name">货币名称</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutNameByPK(string trdCurrencyID, string name, TransactionManager tm_ = null)
        {
            RepairPutNameByPKData(trdCurrencyID, name, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutNameByPKAsync(string trdCurrencyID, string name, TransactionManager tm_ = null)
        {
            RepairPutNameByPKData(trdCurrencyID, name, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutNameByPKData(string trdCurrencyID, string name, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Name` = @Name  WHERE `TrdCurrencyID` = @TrdCurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@TrdCurrencyID", trdCurrencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "name">货币名称</param>
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
        #endregion // PutXXX
        #endregion // Put

        #region Set

        /// <summary>
        /// 插入或者更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>true:插入操作；false:更新操作</return>
        public bool Set(Sp_hub88_currencyEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.TrdCurrencyID) == null)
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
        public async Task<bool> SetAsync(Sp_hub88_currencyEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.TrdCurrencyID) == null)
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
        /// /// <param name = "trdCurrencyID">对方currencyId</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public Sp_hub88_currencyEO GetByPK(string trdCurrencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(trdCurrencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, Sp_hub88_currencyEO.MapDataReader);
        }
        public async Task<Sp_hub88_currencyEO> GetByPKAsync(string trdCurrencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(trdCurrencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sp_hub88_currencyEO.MapDataReader);
        }
        private void RepairGetByPKData(string trdCurrencyID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`TrdCurrencyID` = @TrdCurrencyID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@TrdCurrencyID", trdCurrencyID, MySqlDbType.VarChar),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 CurrencyID（字段）
        /// </summary>
        /// /// <param name = "trdCurrencyID">对方currencyId</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetCurrencyIDByPK(string trdCurrencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@TrdCurrencyID", trdCurrencyID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`CurrencyID`", "`TrdCurrencyID` = @TrdCurrencyID", paras_, tm_);
        }
        public async Task<string> GetCurrencyIDByPKAsync(string trdCurrencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@TrdCurrencyID", trdCurrencyID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`CurrencyID`", "`TrdCurrencyID` = @TrdCurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Name（字段）
        /// </summary>
        /// /// <param name = "trdCurrencyID">对方currencyId</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetNameByPK(string trdCurrencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@TrdCurrencyID", trdCurrencyID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`Name`", "`TrdCurrencyID` = @TrdCurrencyID", paras_, tm_);
        }
        public async Task<string> GetNameByPKAsync(string trdCurrencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@TrdCurrencyID", trdCurrencyID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`Name`", "`TrdCurrencyID` = @TrdCurrencyID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByCurrencyID

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <return>实体对象集合</return>
        public List<Sp_hub88_currencyEO> GetByCurrencyID(string currencyID)
        {
            return GetByCurrencyID(currencyID, 0, string.Empty, null);
        }
        public async Task<List<Sp_hub88_currencyEO>> GetByCurrencyIDAsync(string currencyID)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Sp_hub88_currencyEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
        }
        public async Task<List<Sp_hub88_currencyEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Sp_hub88_currencyEO> GetByCurrencyID(string currencyID, int top_)
        {
            return GetByCurrencyID(currencyID, top_, string.Empty, null);
        }
        public async Task<List<Sp_hub88_currencyEO>> GetByCurrencyIDAsync(string currencyID, int top_)
        {
            return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Sp_hub88_currencyEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
        }
        public async Task<List<Sp_hub88_currencyEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
        {
            return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Sp_hub88_currencyEO> GetByCurrencyID(string currencyID, string sort_)
        {
            return GetByCurrencyID(currencyID, 0, sort_, null);
        }
        public async Task<List<Sp_hub88_currencyEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Sp_hub88_currencyEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, 0, sort_, tm_);
        }
        public async Task<List<Sp_hub88_currencyEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Sp_hub88_currencyEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (currencyID != null)
                paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Sp_hub88_currencyEO.MapDataReader);
        }
        public async Task<List<Sp_hub88_currencyEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (currencyID != null)
                paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sp_hub88_currencyEO.MapDataReader);
        }
        #endregion // GetByCurrencyID
        #region GetByName

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">货币名称</param>
        /// <return>实体对象集合</return>
        public List<Sp_hub88_currencyEO> GetByName(string name)
        {
            return GetByName(name, 0, string.Empty, null);
        }
        public async Task<List<Sp_hub88_currencyEO>> GetByNameAsync(string name)
        {
            return await GetByNameAsync(name, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">货币名称</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Sp_hub88_currencyEO> GetByName(string name, TransactionManager tm_)
        {
            return GetByName(name, 0, string.Empty, tm_);
        }
        public async Task<List<Sp_hub88_currencyEO>> GetByNameAsync(string name, TransactionManager tm_)
        {
            return await GetByNameAsync(name, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">货币名称</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Sp_hub88_currencyEO> GetByName(string name, int top_)
        {
            return GetByName(name, top_, string.Empty, null);
        }
        public async Task<List<Sp_hub88_currencyEO>> GetByNameAsync(string name, int top_)
        {
            return await GetByNameAsync(name, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">货币名称</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Sp_hub88_currencyEO> GetByName(string name, int top_, TransactionManager tm_)
        {
            return GetByName(name, top_, string.Empty, tm_);
        }
        public async Task<List<Sp_hub88_currencyEO>> GetByNameAsync(string name, int top_, TransactionManager tm_)
        {
            return await GetByNameAsync(name, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">货币名称</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Sp_hub88_currencyEO> GetByName(string name, string sort_)
        {
            return GetByName(name, 0, sort_, null);
        }
        public async Task<List<Sp_hub88_currencyEO>> GetByNameAsync(string name, string sort_)
        {
            return await GetByNameAsync(name, 0, sort_, null);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">货币名称</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Sp_hub88_currencyEO> GetByName(string name, string sort_, TransactionManager tm_)
        {
            return GetByName(name, 0, sort_, tm_);
        }
        public async Task<List<Sp_hub88_currencyEO>> GetByNameAsync(string name, string sort_, TransactionManager tm_)
        {
            return await GetByNameAsync(name, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">货币名称</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Sp_hub88_currencyEO> GetByName(string name, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (name != null)
                paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Sp_hub88_currencyEO.MapDataReader);
        }
        public async Task<List<Sp_hub88_currencyEO>> GetByNameAsync(string name, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (name != null)
                paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sp_hub88_currencyEO.MapDataReader);
        }
        #endregion // GetByName
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
