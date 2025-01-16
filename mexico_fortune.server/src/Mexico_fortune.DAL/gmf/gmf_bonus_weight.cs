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
    /// Bonus中奖权重
    /// 【表 gmf_bonus_weight 的实体类】
    /// </summary>
    [DataContract]
    public class Gmf_bonus_weightEO : IRowMapper<Gmf_bonus_weightEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Gmf_bonus_weightEO()
        {
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private int _originalWeightID;
        /// <summary>
        /// 【数据库中的原始主键 WeightID 值的副本，用于主键值更新】
        /// </summary>
        public int OriginalWeightID
        {
            get { return _originalWeightID; }
            set { HasOriginal = true; _originalWeightID = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "WeightID", WeightID }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// 编码
        /// 【主键 int】
        /// </summary>
        [DataMember(Order = 1)]
        public int WeightID { get; set; }
        /// <summary>
        /// bonus图标出现数量
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 2)]
        public int SymbolNum { get; set; }
        /// <summary>
        /// 倍数
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 3)]
        public int Multip { get; set; }
        /// <summary>
        /// 权重
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 4)]
        public int Weight { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public Gmf_bonus_weightEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static Gmf_bonus_weightEO MapDataReader(IDataReader reader)
        {
            Gmf_bonus_weightEO ret = new Gmf_bonus_weightEO();
            ret.WeightID = reader.ToInt32("WeightID");
            ret.OriginalWeightID = ret.WeightID;
            ret.SymbolNum = reader.ToInt32("SymbolNum");
            ret.Multip = reader.ToInt32("Multip");
            ret.Weight = reader.ToInt32("Weight");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// Bonus中奖权重
    /// 【表 gmf_bonus_weight 的操作类】
    /// </summary>
    public class Gmf_bonus_weightMO : MySqlTableMO<Gmf_bonus_weightEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`gmf_bonus_weight`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public Gmf_bonus_weightMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public Gmf_bonus_weightMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public Gmf_bonus_weightMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(Gmf_bonus_weightEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(Gmf_bonus_weightEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(Gmf_bonus_weightEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`WeightID`, `SymbolNum`, `Multip`, `Weight`) VALUE (@WeightID, @SymbolNum, @Multip, @Weight);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@WeightID", item.WeightID, MySqlDbType.Int32),
                Database.CreateInParameter("@SymbolNum", item.SymbolNum, MySqlDbType.Int32),
                Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Int32),
                Database.CreateInParameter("@Weight", item.Weight, MySqlDbType.Int32),
            };
        }
        public int AddByBatch(IEnumerable<Gmf_bonus_weightEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<Gmf_bonus_weightEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gmf_bonus_weightEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`WeightID`, `SymbolNum`, `Multip`, `Weight`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"({item.WeightID},{item.SymbolNum},{item.Multip},{item.Weight}),");
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
        /// /// <param name = "weightID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(int weightID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(weightID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(int weightID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(weightID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(int weightID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `WeightID` = @WeightID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(Gmf_bonus_weightEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.WeightID, tm_);
        }
        public async Task<int> RemoveAsync(Gmf_bonus_weightEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.WeightID, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
        #region RemoveBySymbolNum
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "symbolNum">bonus图标出现数量</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveBySymbolNum(int symbolNum, TransactionManager tm_ = null)
        {
            RepairRemoveBySymbolNumData(symbolNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveBySymbolNumAsync(int symbolNum, TransactionManager tm_ = null)
        {
            RepairRemoveBySymbolNumData(symbolNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveBySymbolNumData(int symbolNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `SymbolNum` = @SymbolNum";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SymbolNum", symbolNum, MySqlDbType.Int32));
        }
        #endregion // RemoveBySymbolNum
        #region RemoveByMultip
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "multip">倍数</param>
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
        #region RemoveByWeight
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "weight">权重</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByWeight(int weight, TransactionManager tm_ = null)
        {
            RepairRemoveByWeightData(weight, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByWeightAsync(int weight, TransactionManager tm_ = null)
        {
            RepairRemoveByWeightData(weight, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByWeightData(int weight, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Weight` = @Weight";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
        }
        #endregion // RemoveByWeight
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
        public int Put(Gmf_bonus_weightEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(Gmf_bonus_weightEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(Gmf_bonus_weightEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `WeightID` = @WeightID, `SymbolNum` = @SymbolNum, `Multip` = @Multip, `Weight` = @Weight WHERE `WeightID` = @WeightID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@WeightID", item.WeightID, MySqlDbType.Int32),
                Database.CreateInParameter("@SymbolNum", item.SymbolNum, MySqlDbType.Int32),
                Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Int32),
                Database.CreateInParameter("@Weight", item.Weight, MySqlDbType.Int32),
                Database.CreateInParameter("@WeightID_Original", item.HasOriginal ? item.OriginalWeightID : item.WeightID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<Gmf_bonus_weightEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<Gmf_bonus_weightEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "weightID">编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int weightID, string set_, params object[] values_)
        {
            return Put(set_, "`WeightID` = @WeightID", ConcatValues(values_, weightID));
        }
        public async Task<int> PutByPKAsync(int weightID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`WeightID` = @WeightID", ConcatValues(values_, weightID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "weightID">编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int weightID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`WeightID` = @WeightID", tm_, ConcatValues(values_, weightID));
        }
        public async Task<int> PutByPKAsync(int weightID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`WeightID` = @WeightID", tm_, ConcatValues(values_, weightID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "weightID">编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int weightID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
            };
            return Put(set_, "`WeightID` = @WeightID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(int weightID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
            };
            return await PutAsync(set_, "`WeightID` = @WeightID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutSymbolNum
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "weightID">编码</param>
        /// /// <param name = "symbolNum">bonus图标出现数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSymbolNumByPK(int weightID, int symbolNum, TransactionManager tm_ = null)
        {
            RepairPutSymbolNumByPKData(weightID, symbolNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutSymbolNumByPKAsync(int weightID, int symbolNum, TransactionManager tm_ = null)
        {
            RepairPutSymbolNumByPKData(weightID, symbolNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutSymbolNumByPKData(int weightID, int symbolNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `SymbolNum` = @SymbolNum  WHERE `WeightID` = @WeightID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolNum", symbolNum, MySqlDbType.Int32),
                Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "symbolNum">bonus图标出现数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSymbolNum(int symbolNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SymbolNum` = @SymbolNum";
            var parameter_ = Database.CreateInParameter("@SymbolNum", symbolNum, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutSymbolNumAsync(int symbolNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SymbolNum` = @SymbolNum";
            var parameter_ = Database.CreateInParameter("@SymbolNum", symbolNum, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutSymbolNum
        #region PutMultip
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "weightID">编码</param>
        /// /// <param name = "multip">倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutMultipByPK(int weightID, int multip, TransactionManager tm_ = null)
        {
            RepairPutMultipByPKData(weightID, multip, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutMultipByPKAsync(int weightID, int multip, TransactionManager tm_ = null)
        {
            RepairPutMultipByPKData(weightID, multip, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutMultipByPKData(int weightID, int multip, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Multip` = @Multip  WHERE `WeightID` = @WeightID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32),
                Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "multip">倍数</param>
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
        #region PutWeight
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "weightID">编码</param>
        /// /// <param name = "weight">权重</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutWeightByPK(int weightID, int weight, TransactionManager tm_ = null)
        {
            RepairPutWeightByPKData(weightID, weight, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutWeightByPKAsync(int weightID, int weight, TransactionManager tm_ = null)
        {
            RepairPutWeightByPKData(weightID, weight, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutWeightByPKData(int weightID, int weight, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Weight` = @Weight  WHERE `WeightID` = @WeightID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32),
                Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "weight">权重</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutWeight(int weight, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Weight` = @Weight";
            var parameter_ = Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutWeightAsync(int weight, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Weight` = @Weight";
            var parameter_ = Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutWeight
        #endregion // PutXXX
        #endregion // Put

        #region Set

        /// <summary>
        /// 插入或者更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>true:插入操作；false:更新操作</return>
        public bool Set(Gmf_bonus_weightEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.WeightID) == null)
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
        public async Task<bool> SetAsync(Gmf_bonus_weightEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.WeightID) == null)
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
        /// /// <param name = "weightID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public Gmf_bonus_weightEO GetByPK(int weightID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(weightID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, Gmf_bonus_weightEO.MapDataReader);
        }
        public async Task<Gmf_bonus_weightEO> GetByPKAsync(int weightID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(weightID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gmf_bonus_weightEO.MapDataReader);
        }
        private void RepairGetByPKData(int weightID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`WeightID` = @WeightID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 SymbolNum（字段）
        /// </summary>
        /// /// <param name = "weightID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetSymbolNumByPK(int weightID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`SymbolNum`", "`WeightID` = @WeightID", paras_, tm_);
        }
        public async Task<int> GetSymbolNumByPKAsync(int weightID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`SymbolNum`", "`WeightID` = @WeightID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Multip（字段）
        /// </summary>
        /// /// <param name = "weightID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetMultipByPK(int weightID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Multip`", "`WeightID` = @WeightID", paras_, tm_);
        }
        public async Task<int> GetMultipByPKAsync(int weightID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Multip`", "`WeightID` = @WeightID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Weight（字段）
        /// </summary>
        /// /// <param name = "weightID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetWeightByPK(int weightID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Weight`", "`WeightID` = @WeightID", paras_, tm_);
        }
        public async Task<int> GetWeightByPKAsync(int weightID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Weight`", "`WeightID` = @WeightID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetBySymbolNum

        /// <summary>
        /// 按 SymbolNum（字段） 查询
        /// </summary>
        /// /// <param name = "symbolNum">bonus图标出现数量</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetBySymbolNum(int symbolNum)
        {
            return GetBySymbolNum(symbolNum, 0, string.Empty, null);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetBySymbolNumAsync(int symbolNum)
        {
            return await GetBySymbolNumAsync(symbolNum, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 SymbolNum（字段） 查询
        /// </summary>
        /// /// <param name = "symbolNum">bonus图标出现数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetBySymbolNum(int symbolNum, TransactionManager tm_)
        {
            return GetBySymbolNum(symbolNum, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetBySymbolNumAsync(int symbolNum, TransactionManager tm_)
        {
            return await GetBySymbolNumAsync(symbolNum, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SymbolNum（字段） 查询
        /// </summary>
        /// /// <param name = "symbolNum">bonus图标出现数量</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetBySymbolNum(int symbolNum, int top_)
        {
            return GetBySymbolNum(symbolNum, top_, string.Empty, null);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetBySymbolNumAsync(int symbolNum, int top_)
        {
            return await GetBySymbolNumAsync(symbolNum, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 SymbolNum（字段） 查询
        /// </summary>
        /// /// <param name = "symbolNum">bonus图标出现数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetBySymbolNum(int symbolNum, int top_, TransactionManager tm_)
        {
            return GetBySymbolNum(symbolNum, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetBySymbolNumAsync(int symbolNum, int top_, TransactionManager tm_)
        {
            return await GetBySymbolNumAsync(symbolNum, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SymbolNum（字段） 查询
        /// </summary>
        /// /// <param name = "symbolNum">bonus图标出现数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetBySymbolNum(int symbolNum, string sort_)
        {
            return GetBySymbolNum(symbolNum, 0, sort_, null);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetBySymbolNumAsync(int symbolNum, string sort_)
        {
            return await GetBySymbolNumAsync(symbolNum, 0, sort_, null);
        }

        /// <summary>
        /// 按 SymbolNum（字段） 查询
        /// </summary>
        /// /// <param name = "symbolNum">bonus图标出现数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetBySymbolNum(int symbolNum, string sort_, TransactionManager tm_)
        {
            return GetBySymbolNum(symbolNum, 0, sort_, tm_);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetBySymbolNumAsync(int symbolNum, string sort_, TransactionManager tm_)
        {
            return await GetBySymbolNumAsync(symbolNum, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 SymbolNum（字段） 查询
        /// </summary>
        /// /// <param name = "symbolNum">bonus图标出现数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetBySymbolNum(int symbolNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`SymbolNum` = @SymbolNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SymbolNum", symbolNum, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_bonus_weightEO.MapDataReader);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetBySymbolNumAsync(int symbolNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`SymbolNum` = @SymbolNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SymbolNum", symbolNum, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_bonus_weightEO.MapDataReader);
        }
        #endregion // GetBySymbolNum
        #region GetByMultip

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetByMultip(int multip)
        {
            return GetByMultip(multip, 0, string.Empty, null);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetByMultipAsync(int multip)
        {
            return await GetByMultipAsync(multip, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetByMultip(int multip, TransactionManager tm_)
        {
            return GetByMultip(multip, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetByMultipAsync(int multip, TransactionManager tm_)
        {
            return await GetByMultipAsync(multip, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetByMultip(int multip, int top_)
        {
            return GetByMultip(multip, top_, string.Empty, null);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetByMultipAsync(int multip, int top_)
        {
            return await GetByMultipAsync(multip, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetByMultip(int multip, int top_, TransactionManager tm_)
        {
            return GetByMultip(multip, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetByMultipAsync(int multip, int top_, TransactionManager tm_)
        {
            return await GetByMultipAsync(multip, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetByMultip(int multip, string sort_)
        {
            return GetByMultip(multip, 0, sort_, null);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetByMultipAsync(int multip, string sort_)
        {
            return await GetByMultipAsync(multip, 0, sort_, null);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetByMultip(int multip, string sort_, TransactionManager tm_)
        {
            return GetByMultip(multip, 0, sort_, tm_);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetByMultipAsync(int multip, string sort_, TransactionManager tm_)
        {
            return await GetByMultipAsync(multip, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetByMultip(int multip, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_bonus_weightEO.MapDataReader);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetByMultipAsync(int multip, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_bonus_weightEO.MapDataReader);
        }
        #endregion // GetByMultip
        #region GetByWeight

        /// <summary>
        /// 按 Weight（字段） 查询
        /// </summary>
        /// /// <param name = "weight">权重</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetByWeight(int weight)
        {
            return GetByWeight(weight, 0, string.Empty, null);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetByWeightAsync(int weight)
        {
            return await GetByWeightAsync(weight, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Weight（字段） 查询
        /// </summary>
        /// /// <param name = "weight">权重</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetByWeight(int weight, TransactionManager tm_)
        {
            return GetByWeight(weight, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetByWeightAsync(int weight, TransactionManager tm_)
        {
            return await GetByWeightAsync(weight, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Weight（字段） 查询
        /// </summary>
        /// /// <param name = "weight">权重</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetByWeight(int weight, int top_)
        {
            return GetByWeight(weight, top_, string.Empty, null);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetByWeightAsync(int weight, int top_)
        {
            return await GetByWeightAsync(weight, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Weight（字段） 查询
        /// </summary>
        /// /// <param name = "weight">权重</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetByWeight(int weight, int top_, TransactionManager tm_)
        {
            return GetByWeight(weight, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetByWeightAsync(int weight, int top_, TransactionManager tm_)
        {
            return await GetByWeightAsync(weight, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Weight（字段） 查询
        /// </summary>
        /// /// <param name = "weight">权重</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetByWeight(int weight, string sort_)
        {
            return GetByWeight(weight, 0, sort_, null);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetByWeightAsync(int weight, string sort_)
        {
            return await GetByWeightAsync(weight, 0, sort_, null);
        }

        /// <summary>
        /// 按 Weight（字段） 查询
        /// </summary>
        /// /// <param name = "weight">权重</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetByWeight(int weight, string sort_, TransactionManager tm_)
        {
            return GetByWeight(weight, 0, sort_, tm_);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetByWeightAsync(int weight, string sort_, TransactionManager tm_)
        {
            return await GetByWeightAsync(weight, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Weight（字段） 查询
        /// </summary>
        /// /// <param name = "weight">权重</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bonus_weightEO> GetByWeight(int weight, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Weight` = @Weight", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_bonus_weightEO.MapDataReader);
        }
        public async Task<List<Gmf_bonus_weightEO>> GetByWeightAsync(int weight, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Weight` = @Weight", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_bonus_weightEO.MapDataReader);
        }
        #endregion // GetByWeight
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
