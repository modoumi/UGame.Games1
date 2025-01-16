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
    /// Bingo刷球数量
    /// 【表 gmf_bingo_num_weight 的实体类】
    /// </summary>
    [DataContract]
    public class Gmf_bingo_num_weightEO : IRowMapper<Gmf_bingo_num_weightEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Gmf_bingo_num_weightEO()
        {
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private int _originalBingoNum;
        /// <summary>
        /// 【数据库中的原始主键 BingoNum 值的副本，用于主键值更新】
        /// </summary>
        public int OriginalBingoNum
        {
            get { return _originalBingoNum; }
            set { HasOriginal = true; _originalBingoNum = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "BingoNum", BingoNum }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// 出球数量
        /// 【主键 int】
        /// </summary>
        [DataMember(Order = 1)]
        public int BingoNum { get; set; }
        /// <summary>
        /// 权重
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 2)]
        public int Weight { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public Gmf_bingo_num_weightEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static Gmf_bingo_num_weightEO MapDataReader(IDataReader reader)
        {
            Gmf_bingo_num_weightEO ret = new Gmf_bingo_num_weightEO();
            ret.BingoNum = reader.ToInt32("BingoNum");
            ret.OriginalBingoNum = ret.BingoNum;
            ret.Weight = reader.ToInt32("Weight");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// Bingo刷球数量
    /// 【表 gmf_bingo_num_weight 的操作类】
    /// </summary>
    public class Gmf_bingo_num_weightMO : MySqlTableMO<Gmf_bingo_num_weightEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`gmf_bingo_num_weight`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public Gmf_bingo_num_weightMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public Gmf_bingo_num_weightMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public Gmf_bingo_num_weightMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(Gmf_bingo_num_weightEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(Gmf_bingo_num_weightEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(Gmf_bingo_num_weightEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`BingoNum`, `Weight`) VALUE (@BingoNum, @Weight);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoNum", item.BingoNum, MySqlDbType.Int32),
                Database.CreateInParameter("@Weight", item.Weight, MySqlDbType.Int32),
            };
        }
        public int AddByBatch(IEnumerable<Gmf_bingo_num_weightEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<Gmf_bingo_num_weightEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gmf_bingo_num_weightEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`BingoNum`, `Weight`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"({item.BingoNum},{item.Weight}),");
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
        /// /// <param name = "bingoNum">出球数量</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(int bingoNum, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(bingoNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(int bingoNum, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(bingoNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(int bingoNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BingoNum` = @BingoNum";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoNum", bingoNum, MySqlDbType.Int32),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(Gmf_bingo_num_weightEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.BingoNum, tm_);
        }
        public async Task<int> RemoveAsync(Gmf_bingo_num_weightEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.BingoNum, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
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
        public int Put(Gmf_bingo_num_weightEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(Gmf_bingo_num_weightEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(Gmf_bingo_num_weightEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoNum` = @BingoNum, `Weight` = @Weight WHERE `BingoNum` = @BingoNum_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoNum", item.BingoNum, MySqlDbType.Int32),
                Database.CreateInParameter("@Weight", item.Weight, MySqlDbType.Int32),
                Database.CreateInParameter("@BingoNum_Original", item.HasOriginal ? item.OriginalBingoNum : item.BingoNum, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<Gmf_bingo_num_weightEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<Gmf_bingo_num_weightEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "bingoNum">出球数量</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int bingoNum, string set_, params object[] values_)
        {
            return Put(set_, "`BingoNum` = @BingoNum", ConcatValues(values_, bingoNum));
        }
        public async Task<int> PutByPKAsync(int bingoNum, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`BingoNum` = @BingoNum", ConcatValues(values_, bingoNum));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "bingoNum">出球数量</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int bingoNum, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`BingoNum` = @BingoNum", tm_, ConcatValues(values_, bingoNum));
        }
        public async Task<int> PutByPKAsync(int bingoNum, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`BingoNum` = @BingoNum", tm_, ConcatValues(values_, bingoNum));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "bingoNum">出球数量</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int bingoNum, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@BingoNum", bingoNum, MySqlDbType.Int32),
            };
            return Put(set_, "`BingoNum` = @BingoNum", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(int bingoNum, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@BingoNum", bingoNum, MySqlDbType.Int32),
            };
            return await PutAsync(set_, "`BingoNum` = @BingoNum", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutWeight
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "bingoNum">出球数量</param>
        /// /// <param name = "weight">权重</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutWeightByPK(int bingoNum, int weight, TransactionManager tm_ = null)
        {
            RepairPutWeightByPKData(bingoNum, weight, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutWeightByPKAsync(int bingoNum, int weight, TransactionManager tm_ = null)
        {
            RepairPutWeightByPKData(bingoNum, weight, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutWeightByPKData(int bingoNum, int weight, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Weight` = @Weight  WHERE `BingoNum` = @BingoNum";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32),
                Database.CreateInParameter("@BingoNum", bingoNum, MySqlDbType.Int32),
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
        public bool Set(Gmf_bingo_num_weightEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.BingoNum) == null)
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
        public async Task<bool> SetAsync(Gmf_bingo_num_weightEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.BingoNum) == null)
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
        /// /// <param name = "bingoNum">出球数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public Gmf_bingo_num_weightEO GetByPK(int bingoNum, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(bingoNum, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, Gmf_bingo_num_weightEO.MapDataReader);
        }
        public async Task<Gmf_bingo_num_weightEO> GetByPKAsync(int bingoNum, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(bingoNum, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gmf_bingo_num_weightEO.MapDataReader);
        }
        private void RepairGetByPKData(int bingoNum, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`BingoNum` = @BingoNum", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoNum", bingoNum, MySqlDbType.Int32),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 Weight（字段）
        /// </summary>
        /// /// <param name = "bingoNum">出球数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetWeightByPK(int bingoNum, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoNum", bingoNum, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Weight`", "`BingoNum` = @BingoNum", paras_, tm_);
        }
        public async Task<int> GetWeightByPKAsync(int bingoNum, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoNum", bingoNum, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Weight`", "`BingoNum` = @BingoNum", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByWeight

        /// <summary>
        /// 按 Weight（字段） 查询
        /// </summary>
        /// /// <param name = "weight">权重</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bingo_num_weightEO> GetByWeight(int weight)
        {
            return GetByWeight(weight, 0, string.Empty, null);
        }
        public async Task<List<Gmf_bingo_num_weightEO>> GetByWeightAsync(int weight)
        {
            return await GetByWeightAsync(weight, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Weight（字段） 查询
        /// </summary>
        /// /// <param name = "weight">权重</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bingo_num_weightEO> GetByWeight(int weight, TransactionManager tm_)
        {
            return GetByWeight(weight, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_bingo_num_weightEO>> GetByWeightAsync(int weight, TransactionManager tm_)
        {
            return await GetByWeightAsync(weight, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Weight（字段） 查询
        /// </summary>
        /// /// <param name = "weight">权重</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bingo_num_weightEO> GetByWeight(int weight, int top_)
        {
            return GetByWeight(weight, top_, string.Empty, null);
        }
        public async Task<List<Gmf_bingo_num_weightEO>> GetByWeightAsync(int weight, int top_)
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
        public List<Gmf_bingo_num_weightEO> GetByWeight(int weight, int top_, TransactionManager tm_)
        {
            return GetByWeight(weight, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_bingo_num_weightEO>> GetByWeightAsync(int weight, int top_, TransactionManager tm_)
        {
            return await GetByWeightAsync(weight, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Weight（字段） 查询
        /// </summary>
        /// /// <param name = "weight">权重</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_bingo_num_weightEO> GetByWeight(int weight, string sort_)
        {
            return GetByWeight(weight, 0, sort_, null);
        }
        public async Task<List<Gmf_bingo_num_weightEO>> GetByWeightAsync(int weight, string sort_)
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
        public List<Gmf_bingo_num_weightEO> GetByWeight(int weight, string sort_, TransactionManager tm_)
        {
            return GetByWeight(weight, 0, sort_, tm_);
        }
        public async Task<List<Gmf_bingo_num_weightEO>> GetByWeightAsync(int weight, string sort_, TransactionManager tm_)
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
        public List<Gmf_bingo_num_weightEO> GetByWeight(int weight, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Weight` = @Weight", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_bingo_num_weightEO.MapDataReader);
        }
        public async Task<List<Gmf_bingo_num_weightEO>> GetByWeightAsync(int weight, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Weight` = @Weight", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_bingo_num_weightEO.MapDataReader);
        }
        #endregion // GetByWeight
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
