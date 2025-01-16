/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-07-28 11: 33:56
 ******************************************************/
using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.Serialization;
using System.Text;
using TinyFx;
using TinyFx.Data;
using TinyFx.Data.MySql;

namespace Mexico_fortune.DAL
{
    #region EO
    /// <summary>
    /// 
    /// 【表 gmf_paytable 的实体类】
    /// </summary>
    [DataContract]
    public class Gmf_paytableEO : IRowMapper<Gmf_paytableEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Gmf_paytableEO()
        {
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private int _originalSymbolID;
        /// <summary>
        /// 【数据库中的原始主键 SymbolID 值的副本，用于主键值更新】
        /// </summary>
        public int OriginalSymbolID
        {
            get { return _originalSymbolID; }
            set { HasOriginal = true; _originalSymbolID = value; }
        }

        private int _originalCount;
        /// <summary>
        /// 【数据库中的原始主键 Count 值的副本，用于主键值更新】
        /// </summary>
        public int OriginalCount
        {
            get { return _originalCount; }
            set { HasOriginal = true; _originalCount = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "SymbolID", SymbolID }, { "Count", Count }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// Symbol编码
        /// 【主键 tinyint】
        /// </summary>
        [DataMember(Order = 1)]
        public int SymbolID { get; set; }
        /// <summary>
        /// 数量
        /// 【主键 int】
        /// </summary>
        [DataMember(Order = 2)]
        public int Count { get; set; }
        /// <summary>
        /// 倍率
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 3)]
        public int Multip { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public Gmf_paytableEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static Gmf_paytableEO MapDataReader(IDataReader reader)
        {
            Gmf_paytableEO ret = new Gmf_paytableEO();
            ret.SymbolID = reader.ToInt32("SymbolID");
            ret.OriginalSymbolID = ret.SymbolID;
            ret.Count = reader.ToInt32("Count");
            ret.OriginalCount = ret.Count;
            ret.Multip = reader.ToInt32("Multip");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// 
    /// 【表 gmf_paytable 的操作类】
    /// </summary>
    public class Gmf_paytableMO : MySqlTableMO<Gmf_paytableEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`gmf_paytable`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public Gmf_paytableMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public Gmf_paytableMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public Gmf_paytableMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(Gmf_paytableEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(Gmf_paytableEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(Gmf_paytableEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`SymbolID`, `Count`, `Multip`) VALUE (@SymbolID, @Count, @Multip);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", item.SymbolID, MySqlDbType.Byte),
                Database.CreateInParameter("@Count", item.Count, MySqlDbType.Int32),
                Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Int32),
            };
        }
        public int AddByBatch(IEnumerable<Gmf_paytableEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<Gmf_paytableEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gmf_paytableEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`SymbolID`, `Count`, `Multip`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"({item.SymbolID},{item.Count},{item.Multip}),");
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
        /// /// <param name = "symbolID">Symbol编码</param>
        /// /// <param name = "count">数量</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(int symbolID, int count, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(symbolID, count, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(int symbolID, int count, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(symbolID, count, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(int symbolID, int count, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `SymbolID` = @SymbolID AND `Count` = @Count";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
                Database.CreateInParameter("@Count", count, MySqlDbType.Int32),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(Gmf_paytableEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.SymbolID, item.Count, tm_);
        }
        public async Task<int> RemoveAsync(Gmf_paytableEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.SymbolID, item.Count, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
        #region RemoveBySymbolID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveBySymbolID(int symbolID, TransactionManager tm_ = null)
        {
            RepairRemoveBySymbolIDData(symbolID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveBySymbolIDAsync(int symbolID, TransactionManager tm_ = null)
        {
            RepairRemoveBySymbolIDData(symbolID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveBySymbolIDData(int symbolID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `SymbolID` = @SymbolID";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte));
        }
        #endregion // RemoveBySymbolID
        #region RemoveByCount
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "count">数量</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByCount(int count, TransactionManager tm_ = null)
        {
            RepairRemoveByCountData(count, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByCountAsync(int count, TransactionManager tm_ = null)
        {
            RepairRemoveByCountData(count, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByCountData(int count, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Count` = @Count";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Count", count, MySqlDbType.Int32));
        }
        #endregion // RemoveByCount
        #region RemoveByMultip
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByMultip(int multip, TransactionManager tm_ = null)
        {
            RepairRemoveByMultipData(multip, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByMultipAsync(int multip, TransactionManager tm_ = null)
        {
            RepairRemoveByMultipData(multip, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByMultipData(int multip, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Multip` = @Multip";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
        }
        #endregion // RemoveByMultip
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
        public int Put(Gmf_paytableEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(Gmf_paytableEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(Gmf_paytableEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `SymbolID` = @SymbolID, `Count` = @Count, `Multip` = @Multip WHERE `SymbolID` = @SymbolID_Original AND `Count` = @Count_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", item.SymbolID, MySqlDbType.Byte),
                Database.CreateInParameter("@Count", item.Count, MySqlDbType.Int32),
                Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Int32),
                Database.CreateInParameter("@SymbolID_Original", item.HasOriginal ? item.OriginalSymbolID : item.SymbolID, MySqlDbType.Byte),
                Database.CreateInParameter("@Count_Original", item.HasOriginal ? item.OriginalCount : item.Count, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<Gmf_paytableEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<Gmf_paytableEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "symbolID">Symbol编码</param>
        /// /// <param name = "count">数量</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int symbolID, int count, string set_, params object[] values_)
        {
            return Put(set_, "`SymbolID` = @SymbolID AND `Count` = @Count", ConcatValues(values_, symbolID, count));
        }
        public async Task<int> PutByPKAsync(int symbolID, int count, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`SymbolID` = @SymbolID AND `Count` = @Count", ConcatValues(values_, symbolID, count));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// /// <param name = "count">数量</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int symbolID, int count, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`SymbolID` = @SymbolID AND `Count` = @Count", tm_, ConcatValues(values_, symbolID, count));
        }
        public async Task<int> PutByPKAsync(int symbolID, int count, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`SymbolID` = @SymbolID AND `Count` = @Count", tm_, ConcatValues(values_, symbolID, count));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// /// <param name = "count">数量</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int symbolID, int count, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
                Database.CreateInParameter("@Count", count, MySqlDbType.Int32),
            };
            return Put(set_, "`SymbolID` = @SymbolID AND `Count` = @Count", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(int symbolID, int count, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
                Database.CreateInParameter("@Count", count, MySqlDbType.Int32),
            };
            return await PutAsync(set_, "`SymbolID` = @SymbolID AND `Count` = @Count", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutSymbolID

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSymbolID(int symbolID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SymbolID` = @SymbolID";
            var parameter_ = Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutSymbolIDAsync(int symbolID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SymbolID` = @SymbolID";
            var parameter_ = Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutSymbolID
        #region PutCount

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "count">数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutCount(int count, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Count` = @Count";
            var parameter_ = Database.CreateInParameter("@Count", count, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutCountAsync(int count, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Count` = @Count";
            var parameter_ = Database.CreateInParameter("@Count", count, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutCount
        #region PutMultip
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// /// <param name = "count">数量</param>
        /// /// <param name = "multip">倍率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutMultipByPK(int symbolID, int count, int multip, TransactionManager tm_ = null)
        {
            RepairPutMultipByPKData(symbolID, count, multip, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutMultipByPKAsync(int symbolID, int count, int multip, TransactionManager tm_ = null)
        {
            RepairPutMultipByPKData(symbolID, count, multip, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutMultipByPKData(int symbolID, int count, int multip, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Multip` = @Multip  WHERE `SymbolID` = @SymbolID AND `Count` = @Count";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32),
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
                Database.CreateInParameter("@Count", count, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutMultip(int multip, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Multip` = @Multip";
            var parameter_ = Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutMultipAsync(int multip, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Multip` = @Multip";
            var parameter_ = Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutMultip
        #endregion // PutXXX
        #endregion // Put

        #region Set

        /// <summary>
        /// 插入或者更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>true:插入操作；false:更新操作</return>
        public bool Set(Gmf_paytableEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.SymbolID, item.Count) == null)
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
        public async Task<bool> SetAsync(Gmf_paytableEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.SymbolID, item.Count) == null)
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
        /// /// <param name = "symbolID">Symbol编码</param>
        /// /// <param name = "count">数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public Gmf_paytableEO GetByPK(int symbolID, int count, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(symbolID, count, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, Gmf_paytableEO.MapDataReader);
        }
        public async Task<Gmf_paytableEO> GetByPKAsync(int symbolID, int count, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(symbolID, count, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gmf_paytableEO.MapDataReader);
        }
        private void RepairGetByPKData(int symbolID, int count, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`SymbolID` = @SymbolID AND `Count` = @Count", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
                Database.CreateInParameter("@Count", count, MySqlDbType.Int32),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 SymbolID（字段）
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// /// <param name = "count">数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetSymbolIDByPK(int symbolID, int count, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
                Database.CreateInParameter("@Count", count, MySqlDbType.Int32),
            };
            return (int)GetScalar("`SymbolID`", "`SymbolID` = @SymbolID AND `Count` = @Count", paras_, tm_);
        }
        public async Task<int> GetSymbolIDByPKAsync(int symbolID, int count, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
                Database.CreateInParameter("@Count", count, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`SymbolID`", "`SymbolID` = @SymbolID AND `Count` = @Count", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Count（字段）
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// /// <param name = "count">数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetCountByPK(int symbolID, int count, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
                Database.CreateInParameter("@Count", count, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Count`", "`SymbolID` = @SymbolID AND `Count` = @Count", paras_, tm_);
        }
        public async Task<int> GetCountByPKAsync(int symbolID, int count, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
                Database.CreateInParameter("@Count", count, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Count`", "`SymbolID` = @SymbolID AND `Count` = @Count", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Multip（字段）
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// /// <param name = "count">数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetMultipByPK(int symbolID, int count, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
                Database.CreateInParameter("@Count", count, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Multip`", "`SymbolID` = @SymbolID AND `Count` = @Count", paras_, tm_);
        }
        public async Task<int> GetMultipByPKAsync(int symbolID, int count, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
                Database.CreateInParameter("@Count", count, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Multip`", "`SymbolID` = @SymbolID AND `Count` = @Count", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetBySymbolID

        /// <summary>
        /// 按 SymbolID（字段） 查询
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetBySymbolID(int symbolID)
        {
            return GetBySymbolID(symbolID, 0, string.Empty, null);
        }
        public async Task<List<Gmf_paytableEO>> GetBySymbolIDAsync(int symbolID)
        {
            return await GetBySymbolIDAsync(symbolID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 SymbolID（字段） 查询
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetBySymbolID(int symbolID, TransactionManager tm_)
        {
            return GetBySymbolID(symbolID, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_paytableEO>> GetBySymbolIDAsync(int symbolID, TransactionManager tm_)
        {
            return await GetBySymbolIDAsync(symbolID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SymbolID（字段） 查询
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetBySymbolID(int symbolID, int top_)
        {
            return GetBySymbolID(symbolID, top_, string.Empty, null);
        }
        public async Task<List<Gmf_paytableEO>> GetBySymbolIDAsync(int symbolID, int top_)
        {
            return await GetBySymbolIDAsync(symbolID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 SymbolID（字段） 查询
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetBySymbolID(int symbolID, int top_, TransactionManager tm_)
        {
            return GetBySymbolID(symbolID, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_paytableEO>> GetBySymbolIDAsync(int symbolID, int top_, TransactionManager tm_)
        {
            return await GetBySymbolIDAsync(symbolID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SymbolID（字段） 查询
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetBySymbolID(int symbolID, string sort_)
        {
            return GetBySymbolID(symbolID, 0, sort_, null);
        }
        public async Task<List<Gmf_paytableEO>> GetBySymbolIDAsync(int symbolID, string sort_)
        {
            return await GetBySymbolIDAsync(symbolID, 0, sort_, null);
        }

        /// <summary>
        /// 按 SymbolID（字段） 查询
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetBySymbolID(int symbolID, string sort_, TransactionManager tm_)
        {
            return GetBySymbolID(symbolID, 0, sort_, tm_);
        }
        public async Task<List<Gmf_paytableEO>> GetBySymbolIDAsync(int symbolID, string sort_, TransactionManager tm_)
        {
            return await GetBySymbolIDAsync(symbolID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 SymbolID（字段） 查询
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetBySymbolID(int symbolID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`SymbolID` = @SymbolID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_paytableEO.MapDataReader);
        }
        public async Task<List<Gmf_paytableEO>> GetBySymbolIDAsync(int symbolID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`SymbolID` = @SymbolID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_paytableEO.MapDataReader);
        }
        #endregion // GetBySymbolID
        #region GetByCount

        /// <summary>
        /// 按 Count（字段） 查询
        /// </summary>
        /// /// <param name = "count">数量</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetByCount(int count)
        {
            return GetByCount(count, 0, string.Empty, null);
        }
        public async Task<List<Gmf_paytableEO>> GetByCountAsync(int count)
        {
            return await GetByCountAsync(count, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Count（字段） 查询
        /// </summary>
        /// /// <param name = "count">数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetByCount(int count, TransactionManager tm_)
        {
            return GetByCount(count, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_paytableEO>> GetByCountAsync(int count, TransactionManager tm_)
        {
            return await GetByCountAsync(count, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Count（字段） 查询
        /// </summary>
        /// /// <param name = "count">数量</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetByCount(int count, int top_)
        {
            return GetByCount(count, top_, string.Empty, null);
        }
        public async Task<List<Gmf_paytableEO>> GetByCountAsync(int count, int top_)
        {
            return await GetByCountAsync(count, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Count（字段） 查询
        /// </summary>
        /// /// <param name = "count">数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetByCount(int count, int top_, TransactionManager tm_)
        {
            return GetByCount(count, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_paytableEO>> GetByCountAsync(int count, int top_, TransactionManager tm_)
        {
            return await GetByCountAsync(count, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Count（字段） 查询
        /// </summary>
        /// /// <param name = "count">数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetByCount(int count, string sort_)
        {
            return GetByCount(count, 0, sort_, null);
        }
        public async Task<List<Gmf_paytableEO>> GetByCountAsync(int count, string sort_)
        {
            return await GetByCountAsync(count, 0, sort_, null);
        }

        /// <summary>
        /// 按 Count（字段） 查询
        /// </summary>
        /// /// <param name = "count">数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetByCount(int count, string sort_, TransactionManager tm_)
        {
            return GetByCount(count, 0, sort_, tm_);
        }
        public async Task<List<Gmf_paytableEO>> GetByCountAsync(int count, string sort_, TransactionManager tm_)
        {
            return await GetByCountAsync(count, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Count（字段） 查询
        /// </summary>
        /// /// <param name = "count">数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetByCount(int count, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Count` = @Count", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Count", count, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_paytableEO.MapDataReader);
        }
        public async Task<List<Gmf_paytableEO>> GetByCountAsync(int count, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Count` = @Count", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Count", count, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_paytableEO.MapDataReader);
        }
        #endregion // GetByCount
        #region GetByMultip

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetByMultip(int multip)
        {
            return GetByMultip(multip, 0, string.Empty, null);
        }
        public async Task<List<Gmf_paytableEO>> GetByMultipAsync(int multip)
        {
            return await GetByMultipAsync(multip, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetByMultip(int multip, TransactionManager tm_)
        {
            return GetByMultip(multip, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_paytableEO>> GetByMultipAsync(int multip, TransactionManager tm_)
        {
            return await GetByMultipAsync(multip, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetByMultip(int multip, int top_)
        {
            return GetByMultip(multip, top_, string.Empty, null);
        }
        public async Task<List<Gmf_paytableEO>> GetByMultipAsync(int multip, int top_)
        {
            return await GetByMultipAsync(multip, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetByMultip(int multip, int top_, TransactionManager tm_)
        {
            return GetByMultip(multip, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_paytableEO>> GetByMultipAsync(int multip, int top_, TransactionManager tm_)
        {
            return await GetByMultipAsync(multip, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetByMultip(int multip, string sort_)
        {
            return GetByMultip(multip, 0, sort_, null);
        }
        public async Task<List<Gmf_paytableEO>> GetByMultipAsync(int multip, string sort_)
        {
            return await GetByMultipAsync(multip, 0, sort_, null);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetByMultip(int multip, string sort_, TransactionManager tm_)
        {
            return GetByMultip(multip, 0, sort_, tm_);
        }
        public async Task<List<Gmf_paytableEO>> GetByMultipAsync(int multip, string sort_, TransactionManager tm_)
        {
            return await GetByMultipAsync(multip, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_paytableEO> GetByMultip(int multip, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_paytableEO.MapDataReader);
        }
        public async Task<List<Gmf_paytableEO>> GetByMultipAsync(int multip, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_paytableEO.MapDataReader);
        }
        #endregion // GetByMultip
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
