/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-07-28 11: 33:57
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
    /// 轴数据定义(1开始0为空)
    /// 【表 gmf_reel_value 的实体类】
    /// </summary>
    [DataContract]
    public class Gmf_reel_valueEO : IRowMapper<Gmf_reel_valueEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Gmf_reel_valueEO()
        {
            this.Reel1 = 0;
            this.Reel2 = 0;
            this.Reel3 = 0;
            this.Reel4 = 0;
            this.Reel5 = 0;
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private int _originalRValueID;
        /// <summary>
        /// 【数据库中的原始主键 RValueID 值的副本，用于主键值更新】
        /// </summary>
        public int OriginalRValueID
        {
            get { return _originalRValueID; }
            set { HasOriginal = true; _originalRValueID = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "RValueID", RValueID }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// 行编码
        /// 【主键 int】
        /// </summary>
        [DataMember(Order = 1)]
        public int RValueID { get; set; }
        /// <summary>
        /// 轴1
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 2)]
        public int Reel1 { get; set; }
        /// <summary>
        /// 轴2
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 3)]
        public int Reel2 { get; set; }
        /// <summary>
        /// 轴3
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 4)]
        public int Reel3 { get; set; }
        /// <summary>
        /// 轴4
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 5)]
        public int Reel4 { get; set; }
        /// <summary>
        /// 轴5
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 6)]
        public int Reel5 { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public Gmf_reel_valueEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static Gmf_reel_valueEO MapDataReader(IDataReader reader)
        {
            Gmf_reel_valueEO ret = new Gmf_reel_valueEO();
            ret.RValueID = reader.ToInt32("RValueID");
            ret.OriginalRValueID = ret.RValueID;
            ret.Reel1 = reader.ToInt32("Reel1");
            ret.Reel2 = reader.ToInt32("Reel2");
            ret.Reel3 = reader.ToInt32("Reel3");
            ret.Reel4 = reader.ToInt32("Reel4");
            ret.Reel5 = reader.ToInt32("Reel5");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// 轴数据定义(1开始0为空)
    /// 【表 gmf_reel_value 的操作类】
    /// </summary>
    public class Gmf_reel_valueMO : MySqlTableMO<Gmf_reel_valueEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`gmf_reel_value`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public Gmf_reel_valueMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public Gmf_reel_valueMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public Gmf_reel_valueMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(Gmf_reel_valueEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(Gmf_reel_valueEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(Gmf_reel_valueEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`RValueID`, `Reel1`, `Reel2`, `Reel3`, `Reel4`, `Reel5`) VALUE (@RValueID, @Reel1, @Reel2, @Reel3, @Reel4, @Reel5);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RValueID", item.RValueID, MySqlDbType.Int32),
                Database.CreateInParameter("@Reel1", item.Reel1, MySqlDbType.Byte),
                Database.CreateInParameter("@Reel2", item.Reel2, MySqlDbType.Byte),
                Database.CreateInParameter("@Reel3", item.Reel3, MySqlDbType.Byte),
                Database.CreateInParameter("@Reel4", item.Reel4, MySqlDbType.Byte),
                Database.CreateInParameter("@Reel5", item.Reel5, MySqlDbType.Byte),
            };
        }
        public int AddByBatch(IEnumerable<Gmf_reel_valueEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<Gmf_reel_valueEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gmf_reel_valueEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`RValueID`, `Reel1`, `Reel2`, `Reel3`, `Reel4`, `Reel5`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"({item.RValueID},{item.Reel1},{item.Reel2},{item.Reel3},{item.Reel4},{item.Reel5}),");
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
        /// /// <param name = "rValueID">行编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(int rValueID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(rValueID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(int rValueID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(rValueID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(int rValueID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `RValueID` = @RValueID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(Gmf_reel_valueEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.RValueID, tm_);
        }
        public async Task<int> RemoveAsync(Gmf_reel_valueEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.RValueID, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
        #region RemoveByReel1
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "reel1">轴1</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByReel1(int reel1, TransactionManager tm_ = null)
        {
            RepairRemoveByReel1Data(reel1, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByReel1Async(int reel1, TransactionManager tm_ = null)
        {
            RepairRemoveByReel1Data(reel1, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByReel1Data(int reel1, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Reel1` = @Reel1";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Reel1", reel1, MySqlDbType.Byte));
        }
        #endregion // RemoveByReel1
        #region RemoveByReel2
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "reel2">轴2</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByReel2(int reel2, TransactionManager tm_ = null)
        {
            RepairRemoveByReel2Data(reel2, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByReel2Async(int reel2, TransactionManager tm_ = null)
        {
            RepairRemoveByReel2Data(reel2, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByReel2Data(int reel2, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Reel2` = @Reel2";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Reel2", reel2, MySqlDbType.Byte));
        }
        #endregion // RemoveByReel2
        #region RemoveByReel3
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "reel3">轴3</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByReel3(int reel3, TransactionManager tm_ = null)
        {
            RepairRemoveByReel3Data(reel3, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByReel3Async(int reel3, TransactionManager tm_ = null)
        {
            RepairRemoveByReel3Data(reel3, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByReel3Data(int reel3, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Reel3` = @Reel3";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Reel3", reel3, MySqlDbType.Byte));
        }
        #endregion // RemoveByReel3
        #region RemoveByReel4
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "reel4">轴4</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByReel4(int reel4, TransactionManager tm_ = null)
        {
            RepairRemoveByReel4Data(reel4, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByReel4Async(int reel4, TransactionManager tm_ = null)
        {
            RepairRemoveByReel4Data(reel4, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByReel4Data(int reel4, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Reel4` = @Reel4";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Reel4", reel4, MySqlDbType.Byte));
        }
        #endregion // RemoveByReel4
        #region RemoveByReel5
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "reel5">轴5</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByReel5(int reel5, TransactionManager tm_ = null)
        {
            RepairRemoveByReel5Data(reel5, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByReel5Async(int reel5, TransactionManager tm_ = null)
        {
            RepairRemoveByReel5Data(reel5, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByReel5Data(int reel5, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Reel5` = @Reel5";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Reel5", reel5, MySqlDbType.Byte));
        }
        #endregion // RemoveByReel5
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
        public int Put(Gmf_reel_valueEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(Gmf_reel_valueEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(Gmf_reel_valueEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `RValueID` = @RValueID, `Reel1` = @Reel1, `Reel2` = @Reel2, `Reel3` = @Reel3, `Reel4` = @Reel4, `Reel5` = @Reel5 WHERE `RValueID` = @RValueID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RValueID", item.RValueID, MySqlDbType.Int32),
                Database.CreateInParameter("@Reel1", item.Reel1, MySqlDbType.Byte),
                Database.CreateInParameter("@Reel2", item.Reel2, MySqlDbType.Byte),
                Database.CreateInParameter("@Reel3", item.Reel3, MySqlDbType.Byte),
                Database.CreateInParameter("@Reel4", item.Reel4, MySqlDbType.Byte),
                Database.CreateInParameter("@Reel5", item.Reel5, MySqlDbType.Byte),
                Database.CreateInParameter("@RValueID_Original", item.HasOriginal ? item.OriginalRValueID : item.RValueID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<Gmf_reel_valueEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<Gmf_reel_valueEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "rValueID">行编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int rValueID, string set_, params object[] values_)
        {
            return Put(set_, "`RValueID` = @RValueID", ConcatValues(values_, rValueID));
        }
        public async Task<int> PutByPKAsync(int rValueID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`RValueID` = @RValueID", ConcatValues(values_, rValueID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "rValueID">行编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int rValueID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`RValueID` = @RValueID", tm_, ConcatValues(values_, rValueID));
        }
        public async Task<int> PutByPKAsync(int rValueID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`RValueID` = @RValueID", tm_, ConcatValues(values_, rValueID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "rValueID">行编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int rValueID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
            return Put(set_, "`RValueID` = @RValueID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(int rValueID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
            return await PutAsync(set_, "`RValueID` = @RValueID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutReel1
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "rValueID">行编码</param>
        /// /// <param name = "reel1">轴1</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutReel1ByPK(int rValueID, int reel1, TransactionManager tm_ = null)
        {
            RepairPutReel1ByPKData(rValueID, reel1, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutReel1ByPKAsync(int rValueID, int reel1, TransactionManager tm_ = null)
        {
            RepairPutReel1ByPKData(rValueID, reel1, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutReel1ByPKData(int rValueID, int reel1, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Reel1` = @Reel1  WHERE `RValueID` = @RValueID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Reel1", reel1, MySqlDbType.Byte),
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "reel1">轴1</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutReel1(int reel1, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Reel1` = @Reel1";
            var parameter_ = Database.CreateInParameter("@Reel1", reel1, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutReel1Async(int reel1, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Reel1` = @Reel1";
            var parameter_ = Database.CreateInParameter("@Reel1", reel1, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutReel1
        #region PutReel2
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "rValueID">行编码</param>
        /// /// <param name = "reel2">轴2</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutReel2ByPK(int rValueID, int reel2, TransactionManager tm_ = null)
        {
            RepairPutReel2ByPKData(rValueID, reel2, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutReel2ByPKAsync(int rValueID, int reel2, TransactionManager tm_ = null)
        {
            RepairPutReel2ByPKData(rValueID, reel2, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutReel2ByPKData(int rValueID, int reel2, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Reel2` = @Reel2  WHERE `RValueID` = @RValueID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Reel2", reel2, MySqlDbType.Byte),
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "reel2">轴2</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutReel2(int reel2, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Reel2` = @Reel2";
            var parameter_ = Database.CreateInParameter("@Reel2", reel2, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutReel2Async(int reel2, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Reel2` = @Reel2";
            var parameter_ = Database.CreateInParameter("@Reel2", reel2, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutReel2
        #region PutReel3
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "rValueID">行编码</param>
        /// /// <param name = "reel3">轴3</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutReel3ByPK(int rValueID, int reel3, TransactionManager tm_ = null)
        {
            RepairPutReel3ByPKData(rValueID, reel3, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutReel3ByPKAsync(int rValueID, int reel3, TransactionManager tm_ = null)
        {
            RepairPutReel3ByPKData(rValueID, reel3, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutReel3ByPKData(int rValueID, int reel3, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Reel3` = @Reel3  WHERE `RValueID` = @RValueID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Reel3", reel3, MySqlDbType.Byte),
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "reel3">轴3</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutReel3(int reel3, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Reel3` = @Reel3";
            var parameter_ = Database.CreateInParameter("@Reel3", reel3, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutReel3Async(int reel3, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Reel3` = @Reel3";
            var parameter_ = Database.CreateInParameter("@Reel3", reel3, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutReel3
        #region PutReel4
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "rValueID">行编码</param>
        /// /// <param name = "reel4">轴4</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutReel4ByPK(int rValueID, int reel4, TransactionManager tm_ = null)
        {
            RepairPutReel4ByPKData(rValueID, reel4, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutReel4ByPKAsync(int rValueID, int reel4, TransactionManager tm_ = null)
        {
            RepairPutReel4ByPKData(rValueID, reel4, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutReel4ByPKData(int rValueID, int reel4, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Reel4` = @Reel4  WHERE `RValueID` = @RValueID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Reel4", reel4, MySqlDbType.Byte),
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "reel4">轴4</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutReel4(int reel4, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Reel4` = @Reel4";
            var parameter_ = Database.CreateInParameter("@Reel4", reel4, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutReel4Async(int reel4, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Reel4` = @Reel4";
            var parameter_ = Database.CreateInParameter("@Reel4", reel4, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutReel4
        #region PutReel5
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "rValueID">行编码</param>
        /// /// <param name = "reel5">轴5</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutReel5ByPK(int rValueID, int reel5, TransactionManager tm_ = null)
        {
            RepairPutReel5ByPKData(rValueID, reel5, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutReel5ByPKAsync(int rValueID, int reel5, TransactionManager tm_ = null)
        {
            RepairPutReel5ByPKData(rValueID, reel5, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutReel5ByPKData(int rValueID, int reel5, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Reel5` = @Reel5  WHERE `RValueID` = @RValueID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Reel5", reel5, MySqlDbType.Byte),
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "reel5">轴5</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutReel5(int reel5, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Reel5` = @Reel5";
            var parameter_ = Database.CreateInParameter("@Reel5", reel5, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutReel5Async(int reel5, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Reel5` = @Reel5";
            var parameter_ = Database.CreateInParameter("@Reel5", reel5, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutReel5
        #endregion // PutXXX
        #endregion // Put

        #region Set

        /// <summary>
        /// 插入或者更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>true:插入操作；false:更新操作</return>
        public bool Set(Gmf_reel_valueEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.RValueID) == null)
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
        public async Task<bool> SetAsync(Gmf_reel_valueEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.RValueID) == null)
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
        /// /// <param name = "rValueID">行编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public Gmf_reel_valueEO GetByPK(int rValueID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(rValueID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, Gmf_reel_valueEO.MapDataReader);
        }
        public async Task<Gmf_reel_valueEO> GetByPKAsync(int rValueID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(rValueID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gmf_reel_valueEO.MapDataReader);
        }
        private void RepairGetByPKData(int rValueID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`RValueID` = @RValueID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 Reel1（字段）
        /// </summary>
        /// /// <param name = "rValueID">行编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetReel1ByPK(int rValueID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Reel1`", "`RValueID` = @RValueID", paras_, tm_);
        }
        public async Task<int> GetReel1ByPKAsync(int rValueID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Reel1`", "`RValueID` = @RValueID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Reel2（字段）
        /// </summary>
        /// /// <param name = "rValueID">行编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetReel2ByPK(int rValueID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Reel2`", "`RValueID` = @RValueID", paras_, tm_);
        }
        public async Task<int> GetReel2ByPKAsync(int rValueID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Reel2`", "`RValueID` = @RValueID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Reel3（字段）
        /// </summary>
        /// /// <param name = "rValueID">行编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetReel3ByPK(int rValueID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Reel3`", "`RValueID` = @RValueID", paras_, tm_);
        }
        public async Task<int> GetReel3ByPKAsync(int rValueID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Reel3`", "`RValueID` = @RValueID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Reel4（字段）
        /// </summary>
        /// /// <param name = "rValueID">行编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetReel4ByPK(int rValueID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Reel4`", "`RValueID` = @RValueID", paras_, tm_);
        }
        public async Task<int> GetReel4ByPKAsync(int rValueID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Reel4`", "`RValueID` = @RValueID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Reel5（字段）
        /// </summary>
        /// /// <param name = "rValueID">行编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetReel5ByPK(int rValueID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Reel5`", "`RValueID` = @RValueID", paras_, tm_);
        }
        public async Task<int> GetReel5ByPKAsync(int rValueID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RValueID", rValueID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Reel5`", "`RValueID` = @RValueID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByReel1

        /// <summary>
        /// 按 Reel1（字段） 查询
        /// </summary>
        /// /// <param name = "reel1">轴1</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel1(int reel1)
        {
            return GetByReel1(reel1, 0, string.Empty, null);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel1Async(int reel1)
        {
            return await GetByReel1Async(reel1, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Reel1（字段） 查询
        /// </summary>
        /// /// <param name = "reel1">轴1</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel1(int reel1, TransactionManager tm_)
        {
            return GetByReel1(reel1, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel1Async(int reel1, TransactionManager tm_)
        {
            return await GetByReel1Async(reel1, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Reel1（字段） 查询
        /// </summary>
        /// /// <param name = "reel1">轴1</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel1(int reel1, int top_)
        {
            return GetByReel1(reel1, top_, string.Empty, null);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel1Async(int reel1, int top_)
        {
            return await GetByReel1Async(reel1, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Reel1（字段） 查询
        /// </summary>
        /// /// <param name = "reel1">轴1</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel1(int reel1, int top_, TransactionManager tm_)
        {
            return GetByReel1(reel1, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel1Async(int reel1, int top_, TransactionManager tm_)
        {
            return await GetByReel1Async(reel1, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Reel1（字段） 查询
        /// </summary>
        /// /// <param name = "reel1">轴1</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel1(int reel1, string sort_)
        {
            return GetByReel1(reel1, 0, sort_, null);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel1Async(int reel1, string sort_)
        {
            return await GetByReel1Async(reel1, 0, sort_, null);
        }

        /// <summary>
        /// 按 Reel1（字段） 查询
        /// </summary>
        /// /// <param name = "reel1">轴1</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel1(int reel1, string sort_, TransactionManager tm_)
        {
            return GetByReel1(reel1, 0, sort_, tm_);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel1Async(int reel1, string sort_, TransactionManager tm_)
        {
            return await GetByReel1Async(reel1, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Reel1（字段） 查询
        /// </summary>
        /// /// <param name = "reel1">轴1</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel1(int reel1, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Reel1` = @Reel1", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Reel1", reel1, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_reel_valueEO.MapDataReader);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel1Async(int reel1, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Reel1` = @Reel1", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Reel1", reel1, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_reel_valueEO.MapDataReader);
        }
        #endregion // GetByReel1
        #region GetByReel2

        /// <summary>
        /// 按 Reel2（字段） 查询
        /// </summary>
        /// /// <param name = "reel2">轴2</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel2(int reel2)
        {
            return GetByReel2(reel2, 0, string.Empty, null);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel2Async(int reel2)
        {
            return await GetByReel2Async(reel2, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Reel2（字段） 查询
        /// </summary>
        /// /// <param name = "reel2">轴2</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel2(int reel2, TransactionManager tm_)
        {
            return GetByReel2(reel2, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel2Async(int reel2, TransactionManager tm_)
        {
            return await GetByReel2Async(reel2, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Reel2（字段） 查询
        /// </summary>
        /// /// <param name = "reel2">轴2</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel2(int reel2, int top_)
        {
            return GetByReel2(reel2, top_, string.Empty, null);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel2Async(int reel2, int top_)
        {
            return await GetByReel2Async(reel2, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Reel2（字段） 查询
        /// </summary>
        /// /// <param name = "reel2">轴2</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel2(int reel2, int top_, TransactionManager tm_)
        {
            return GetByReel2(reel2, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel2Async(int reel2, int top_, TransactionManager tm_)
        {
            return await GetByReel2Async(reel2, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Reel2（字段） 查询
        /// </summary>
        /// /// <param name = "reel2">轴2</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel2(int reel2, string sort_)
        {
            return GetByReel2(reel2, 0, sort_, null);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel2Async(int reel2, string sort_)
        {
            return await GetByReel2Async(reel2, 0, sort_, null);
        }

        /// <summary>
        /// 按 Reel2（字段） 查询
        /// </summary>
        /// /// <param name = "reel2">轴2</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel2(int reel2, string sort_, TransactionManager tm_)
        {
            return GetByReel2(reel2, 0, sort_, tm_);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel2Async(int reel2, string sort_, TransactionManager tm_)
        {
            return await GetByReel2Async(reel2, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Reel2（字段） 查询
        /// </summary>
        /// /// <param name = "reel2">轴2</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel2(int reel2, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Reel2` = @Reel2", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Reel2", reel2, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_reel_valueEO.MapDataReader);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel2Async(int reel2, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Reel2` = @Reel2", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Reel2", reel2, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_reel_valueEO.MapDataReader);
        }
        #endregion // GetByReel2
        #region GetByReel3

        /// <summary>
        /// 按 Reel3（字段） 查询
        /// </summary>
        /// /// <param name = "reel3">轴3</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel3(int reel3)
        {
            return GetByReel3(reel3, 0, string.Empty, null);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel3Async(int reel3)
        {
            return await GetByReel3Async(reel3, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Reel3（字段） 查询
        /// </summary>
        /// /// <param name = "reel3">轴3</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel3(int reel3, TransactionManager tm_)
        {
            return GetByReel3(reel3, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel3Async(int reel3, TransactionManager tm_)
        {
            return await GetByReel3Async(reel3, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Reel3（字段） 查询
        /// </summary>
        /// /// <param name = "reel3">轴3</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel3(int reel3, int top_)
        {
            return GetByReel3(reel3, top_, string.Empty, null);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel3Async(int reel3, int top_)
        {
            return await GetByReel3Async(reel3, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Reel3（字段） 查询
        /// </summary>
        /// /// <param name = "reel3">轴3</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel3(int reel3, int top_, TransactionManager tm_)
        {
            return GetByReel3(reel3, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel3Async(int reel3, int top_, TransactionManager tm_)
        {
            return await GetByReel3Async(reel3, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Reel3（字段） 查询
        /// </summary>
        /// /// <param name = "reel3">轴3</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel3(int reel3, string sort_)
        {
            return GetByReel3(reel3, 0, sort_, null);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel3Async(int reel3, string sort_)
        {
            return await GetByReel3Async(reel3, 0, sort_, null);
        }

        /// <summary>
        /// 按 Reel3（字段） 查询
        /// </summary>
        /// /// <param name = "reel3">轴3</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel3(int reel3, string sort_, TransactionManager tm_)
        {
            return GetByReel3(reel3, 0, sort_, tm_);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel3Async(int reel3, string sort_, TransactionManager tm_)
        {
            return await GetByReel3Async(reel3, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Reel3（字段） 查询
        /// </summary>
        /// /// <param name = "reel3">轴3</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel3(int reel3, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Reel3` = @Reel3", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Reel3", reel3, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_reel_valueEO.MapDataReader);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel3Async(int reel3, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Reel3` = @Reel3", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Reel3", reel3, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_reel_valueEO.MapDataReader);
        }
        #endregion // GetByReel3
        #region GetByReel4

        /// <summary>
        /// 按 Reel4（字段） 查询
        /// </summary>
        /// /// <param name = "reel4">轴4</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel4(int reel4)
        {
            return GetByReel4(reel4, 0, string.Empty, null);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel4Async(int reel4)
        {
            return await GetByReel4Async(reel4, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Reel4（字段） 查询
        /// </summary>
        /// /// <param name = "reel4">轴4</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel4(int reel4, TransactionManager tm_)
        {
            return GetByReel4(reel4, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel4Async(int reel4, TransactionManager tm_)
        {
            return await GetByReel4Async(reel4, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Reel4（字段） 查询
        /// </summary>
        /// /// <param name = "reel4">轴4</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel4(int reel4, int top_)
        {
            return GetByReel4(reel4, top_, string.Empty, null);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel4Async(int reel4, int top_)
        {
            return await GetByReel4Async(reel4, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Reel4（字段） 查询
        /// </summary>
        /// /// <param name = "reel4">轴4</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel4(int reel4, int top_, TransactionManager tm_)
        {
            return GetByReel4(reel4, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel4Async(int reel4, int top_, TransactionManager tm_)
        {
            return await GetByReel4Async(reel4, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Reel4（字段） 查询
        /// </summary>
        /// /// <param name = "reel4">轴4</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel4(int reel4, string sort_)
        {
            return GetByReel4(reel4, 0, sort_, null);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel4Async(int reel4, string sort_)
        {
            return await GetByReel4Async(reel4, 0, sort_, null);
        }

        /// <summary>
        /// 按 Reel4（字段） 查询
        /// </summary>
        /// /// <param name = "reel4">轴4</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel4(int reel4, string sort_, TransactionManager tm_)
        {
            return GetByReel4(reel4, 0, sort_, tm_);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel4Async(int reel4, string sort_, TransactionManager tm_)
        {
            return await GetByReel4Async(reel4, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Reel4（字段） 查询
        /// </summary>
        /// /// <param name = "reel4">轴4</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel4(int reel4, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Reel4` = @Reel4", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Reel4", reel4, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_reel_valueEO.MapDataReader);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel4Async(int reel4, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Reel4` = @Reel4", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Reel4", reel4, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_reel_valueEO.MapDataReader);
        }
        #endregion // GetByReel4
        #region GetByReel5

        /// <summary>
        /// 按 Reel5（字段） 查询
        /// </summary>
        /// /// <param name = "reel5">轴5</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel5(int reel5)
        {
            return GetByReel5(reel5, 0, string.Empty, null);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel5Async(int reel5)
        {
            return await GetByReel5Async(reel5, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Reel5（字段） 查询
        /// </summary>
        /// /// <param name = "reel5">轴5</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel5(int reel5, TransactionManager tm_)
        {
            return GetByReel5(reel5, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel5Async(int reel5, TransactionManager tm_)
        {
            return await GetByReel5Async(reel5, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Reel5（字段） 查询
        /// </summary>
        /// /// <param name = "reel5">轴5</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel5(int reel5, int top_)
        {
            return GetByReel5(reel5, top_, string.Empty, null);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel5Async(int reel5, int top_)
        {
            return await GetByReel5Async(reel5, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Reel5（字段） 查询
        /// </summary>
        /// /// <param name = "reel5">轴5</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel5(int reel5, int top_, TransactionManager tm_)
        {
            return GetByReel5(reel5, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel5Async(int reel5, int top_, TransactionManager tm_)
        {
            return await GetByReel5Async(reel5, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Reel5（字段） 查询
        /// </summary>
        /// /// <param name = "reel5">轴5</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel5(int reel5, string sort_)
        {
            return GetByReel5(reel5, 0, sort_, null);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel5Async(int reel5, string sort_)
        {
            return await GetByReel5Async(reel5, 0, sort_, null);
        }

        /// <summary>
        /// 按 Reel5（字段） 查询
        /// </summary>
        /// /// <param name = "reel5">轴5</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel5(int reel5, string sort_, TransactionManager tm_)
        {
            return GetByReel5(reel5, 0, sort_, tm_);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel5Async(int reel5, string sort_, TransactionManager tm_)
        {
            return await GetByReel5Async(reel5, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Reel5（字段） 查询
        /// </summary>
        /// /// <param name = "reel5">轴5</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_reel_valueEO> GetByReel5(int reel5, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Reel5` = @Reel5", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Reel5", reel5, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_reel_valueEO.MapDataReader);
        }
        public async Task<List<Gmf_reel_valueEO>> GetByReel5Async(int reel5, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Reel5` = @Reel5", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Reel5", reel5, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_reel_valueEO.MapDataReader);
        }
        #endregion // GetByReel5
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
