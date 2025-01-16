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
    /// bingo中奖线
    /// 【表 gmf_line 的实体类】
    /// </summary>
    [DataContract]
    public class Gmf_lineEO : IRowMapper<Gmf_lineEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Gmf_lineEO()
        {
            this.Row1 = 0;
            this.Row2 = 0;
            this.Row3 = 0;
            this.Row4 = 0;
            this.Row5 = 0;
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private int _originalLineID;
        /// <summary>
        /// 【数据库中的原始主键 LineID 值的副本，用于主键值更新】
        /// </summary>
        public int OriginalLineID
        {
            get { return _originalLineID; }
            set { HasOriginal = true; _originalLineID = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "LineID", LineID }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// 线编码
        /// 【主键 int】
        /// </summary>
        [DataMember(Order = 1)]
        public int LineID { get; set; }
        /// <summary>
        /// 行1
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 2)]
        public int Row1 { get; set; }
        /// <summary>
        /// 行2
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 3)]
        public int Row2 { get; set; }
        /// <summary>
        /// 行3
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 4)]
        public int Row3 { get; set; }
        /// <summary>
        /// 行4
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 5)]
        public int Row4 { get; set; }
        /// <summary>
        /// 行5
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 6)]
        public int Row5 { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public Gmf_lineEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static Gmf_lineEO MapDataReader(IDataReader reader)
        {
            Gmf_lineEO ret = new Gmf_lineEO();
            ret.LineID = reader.ToInt32("LineID");
            ret.OriginalLineID = ret.LineID;
            ret.Row1 = reader.ToInt32("Row1");
            ret.Row2 = reader.ToInt32("Row2");
            ret.Row3 = reader.ToInt32("Row3");
            ret.Row4 = reader.ToInt32("Row4");
            ret.Row5 = reader.ToInt32("Row5");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// bingo中奖线
    /// 【表 gmf_line 的操作类】
    /// </summary>
    public class Gmf_lineMO : MySqlTableMO<Gmf_lineEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`gmf_line`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public Gmf_lineMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public Gmf_lineMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public Gmf_lineMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(Gmf_lineEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(Gmf_lineEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(Gmf_lineEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`LineID`, `Row1`, `Row2`, `Row3`, `Row4`, `Row5`) VALUE (@LineID, @Row1, @Row2, @Row3, @Row4, @Row5);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LineID", item.LineID, MySqlDbType.Int32),
                Database.CreateInParameter("@Row1", item.Row1, MySqlDbType.Byte),
                Database.CreateInParameter("@Row2", item.Row2, MySqlDbType.Byte),
                Database.CreateInParameter("@Row3", item.Row3, MySqlDbType.Byte),
                Database.CreateInParameter("@Row4", item.Row4, MySqlDbType.Byte),
                Database.CreateInParameter("@Row5", item.Row5, MySqlDbType.Byte),
            };
        }
        public int AddByBatch(IEnumerable<Gmf_lineEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<Gmf_lineEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gmf_lineEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`LineID`, `Row1`, `Row2`, `Row3`, `Row4`, `Row5`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"({item.LineID},{item.Row1},{item.Row2},{item.Row3},{item.Row4},{item.Row5}),");
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
        /// /// <param name = "lineID">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(int lineID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(lineID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(int lineID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(lineID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(int lineID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `LineID` = @LineID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(Gmf_lineEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.LineID, tm_);
        }
        public async Task<int> RemoveAsync(Gmf_lineEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.LineID, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
        #region RemoveByRow1
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "row1">行1</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByRow1(int row1, TransactionManager tm_ = null)
        {
            RepairRemoveByRow1Data(row1, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByRow1Async(int row1, TransactionManager tm_ = null)
        {
            RepairRemoveByRow1Data(row1, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByRow1Data(int row1, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Row1` = @Row1";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Row1", row1, MySqlDbType.Byte));
        }
        #endregion // RemoveByRow1
        #region RemoveByRow2
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "row2">行2</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByRow2(int row2, TransactionManager tm_ = null)
        {
            RepairRemoveByRow2Data(row2, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByRow2Async(int row2, TransactionManager tm_ = null)
        {
            RepairRemoveByRow2Data(row2, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByRow2Data(int row2, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Row2` = @Row2";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Row2", row2, MySqlDbType.Byte));
        }
        #endregion // RemoveByRow2
        #region RemoveByRow3
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "row3">行3</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByRow3(int row3, TransactionManager tm_ = null)
        {
            RepairRemoveByRow3Data(row3, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByRow3Async(int row3, TransactionManager tm_ = null)
        {
            RepairRemoveByRow3Data(row3, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByRow3Data(int row3, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Row3` = @Row3";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Row3", row3, MySqlDbType.Byte));
        }
        #endregion // RemoveByRow3
        #region RemoveByRow4
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "row4">行4</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByRow4(int row4, TransactionManager tm_ = null)
        {
            RepairRemoveByRow4Data(row4, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByRow4Async(int row4, TransactionManager tm_ = null)
        {
            RepairRemoveByRow4Data(row4, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByRow4Data(int row4, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Row4` = @Row4";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Row4", row4, MySqlDbType.Byte));
        }
        #endregion // RemoveByRow4
        #region RemoveByRow5
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "row5">行5</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByRow5(int row5, TransactionManager tm_ = null)
        {
            RepairRemoveByRow5Data(row5, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByRow5Async(int row5, TransactionManager tm_ = null)
        {
            RepairRemoveByRow5Data(row5, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByRow5Data(int row5, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Row5` = @Row5";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Row5", row5, MySqlDbType.Byte));
        }
        #endregion // RemoveByRow5
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
        public int Put(Gmf_lineEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(Gmf_lineEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(Gmf_lineEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `LineID` = @LineID, `Row1` = @Row1, `Row2` = @Row2, `Row3` = @Row3, `Row4` = @Row4, `Row5` = @Row5 WHERE `LineID` = @LineID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LineID", item.LineID, MySqlDbType.Int32),
                Database.CreateInParameter("@Row1", item.Row1, MySqlDbType.Byte),
                Database.CreateInParameter("@Row2", item.Row2, MySqlDbType.Byte),
                Database.CreateInParameter("@Row3", item.Row3, MySqlDbType.Byte),
                Database.CreateInParameter("@Row4", item.Row4, MySqlDbType.Byte),
                Database.CreateInParameter("@Row5", item.Row5, MySqlDbType.Byte),
                Database.CreateInParameter("@LineID_Original", item.HasOriginal ? item.OriginalLineID : item.LineID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<Gmf_lineEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<Gmf_lineEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "lineID">线编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int lineID, string set_, params object[] values_)
        {
            return Put(set_, "`LineID` = @LineID", ConcatValues(values_, lineID));
        }
        public async Task<int> PutByPKAsync(int lineID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`LineID` = @LineID", ConcatValues(values_, lineID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "lineID">线编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int lineID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`LineID` = @LineID", tm_, ConcatValues(values_, lineID));
        }
        public async Task<int> PutByPKAsync(int lineID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`LineID` = @LineID", tm_, ConcatValues(values_, lineID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "lineID">线编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int lineID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
            return Put(set_, "`LineID` = @LineID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(int lineID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
            return await PutAsync(set_, "`LineID` = @LineID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutRow1
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "lineID">线编码</param>
        /// /// <param name = "row1">行1</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRow1ByPK(int lineID, int row1, TransactionManager tm_ = null)
        {
            RepairPutRow1ByPKData(lineID, row1, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRow1ByPKAsync(int lineID, int row1, TransactionManager tm_ = null)
        {
            RepairPutRow1ByPKData(lineID, row1, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRow1ByPKData(int lineID, int row1, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Row1` = @Row1  WHERE `LineID` = @LineID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Row1", row1, MySqlDbType.Byte),
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "row1">行1</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRow1(int row1, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Row1` = @Row1";
            var parameter_ = Database.CreateInParameter("@Row1", row1, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutRow1Async(int row1, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Row1` = @Row1";
            var parameter_ = Database.CreateInParameter("@Row1", row1, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutRow1
        #region PutRow2
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "lineID">线编码</param>
        /// /// <param name = "row2">行2</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRow2ByPK(int lineID, int row2, TransactionManager tm_ = null)
        {
            RepairPutRow2ByPKData(lineID, row2, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRow2ByPKAsync(int lineID, int row2, TransactionManager tm_ = null)
        {
            RepairPutRow2ByPKData(lineID, row2, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRow2ByPKData(int lineID, int row2, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Row2` = @Row2  WHERE `LineID` = @LineID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Row2", row2, MySqlDbType.Byte),
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "row2">行2</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRow2(int row2, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Row2` = @Row2";
            var parameter_ = Database.CreateInParameter("@Row2", row2, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutRow2Async(int row2, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Row2` = @Row2";
            var parameter_ = Database.CreateInParameter("@Row2", row2, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutRow2
        #region PutRow3
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "lineID">线编码</param>
        /// /// <param name = "row3">行3</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRow3ByPK(int lineID, int row3, TransactionManager tm_ = null)
        {
            RepairPutRow3ByPKData(lineID, row3, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRow3ByPKAsync(int lineID, int row3, TransactionManager tm_ = null)
        {
            RepairPutRow3ByPKData(lineID, row3, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRow3ByPKData(int lineID, int row3, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Row3` = @Row3  WHERE `LineID` = @LineID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Row3", row3, MySqlDbType.Byte),
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "row3">行3</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRow3(int row3, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Row3` = @Row3";
            var parameter_ = Database.CreateInParameter("@Row3", row3, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutRow3Async(int row3, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Row3` = @Row3";
            var parameter_ = Database.CreateInParameter("@Row3", row3, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutRow3
        #region PutRow4
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "lineID">线编码</param>
        /// /// <param name = "row4">行4</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRow4ByPK(int lineID, int row4, TransactionManager tm_ = null)
        {
            RepairPutRow4ByPKData(lineID, row4, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRow4ByPKAsync(int lineID, int row4, TransactionManager tm_ = null)
        {
            RepairPutRow4ByPKData(lineID, row4, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRow4ByPKData(int lineID, int row4, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Row4` = @Row4  WHERE `LineID` = @LineID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Row4", row4, MySqlDbType.Byte),
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "row4">行4</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRow4(int row4, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Row4` = @Row4";
            var parameter_ = Database.CreateInParameter("@Row4", row4, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutRow4Async(int row4, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Row4` = @Row4";
            var parameter_ = Database.CreateInParameter("@Row4", row4, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutRow4
        #region PutRow5
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "lineID">线编码</param>
        /// /// <param name = "row5">行5</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRow5ByPK(int lineID, int row5, TransactionManager tm_ = null)
        {
            RepairPutRow5ByPKData(lineID, row5, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRow5ByPKAsync(int lineID, int row5, TransactionManager tm_ = null)
        {
            RepairPutRow5ByPKData(lineID, row5, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRow5ByPKData(int lineID, int row5, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Row5` = @Row5  WHERE `LineID` = @LineID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Row5", row5, MySqlDbType.Byte),
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "row5">行5</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRow5(int row5, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Row5` = @Row5";
            var parameter_ = Database.CreateInParameter("@Row5", row5, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutRow5Async(int row5, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Row5` = @Row5";
            var parameter_ = Database.CreateInParameter("@Row5", row5, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutRow5
        #endregion // PutXXX
        #endregion // Put

        #region Set

        /// <summary>
        /// 插入或者更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>true:插入操作；false:更新操作</return>
        public bool Set(Gmf_lineEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.LineID) == null)
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
        public async Task<bool> SetAsync(Gmf_lineEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.LineID) == null)
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
        /// /// <param name = "lineID">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public Gmf_lineEO GetByPK(int lineID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(lineID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, Gmf_lineEO.MapDataReader);
        }
        public async Task<Gmf_lineEO> GetByPKAsync(int lineID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(lineID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gmf_lineEO.MapDataReader);
        }
        private void RepairGetByPKData(int lineID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`LineID` = @LineID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 Row1（字段）
        /// </summary>
        /// /// <param name = "lineID">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetRow1ByPK(int lineID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Row1`", "`LineID` = @LineID", paras_, tm_);
        }
        public async Task<int> GetRow1ByPKAsync(int lineID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Row1`", "`LineID` = @LineID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Row2（字段）
        /// </summary>
        /// /// <param name = "lineID">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetRow2ByPK(int lineID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Row2`", "`LineID` = @LineID", paras_, tm_);
        }
        public async Task<int> GetRow2ByPKAsync(int lineID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Row2`", "`LineID` = @LineID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Row3（字段）
        /// </summary>
        /// /// <param name = "lineID">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetRow3ByPK(int lineID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Row3`", "`LineID` = @LineID", paras_, tm_);
        }
        public async Task<int> GetRow3ByPKAsync(int lineID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Row3`", "`LineID` = @LineID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Row4（字段）
        /// </summary>
        /// /// <param name = "lineID">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetRow4ByPK(int lineID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Row4`", "`LineID` = @LineID", paras_, tm_);
        }
        public async Task<int> GetRow4ByPKAsync(int lineID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Row4`", "`LineID` = @LineID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Row5（字段）
        /// </summary>
        /// /// <param name = "lineID">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetRow5ByPK(int lineID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Row5`", "`LineID` = @LineID", paras_, tm_);
        }
        public async Task<int> GetRow5ByPKAsync(int lineID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Row5`", "`LineID` = @LineID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByRow1

        /// <summary>
        /// 按 Row1（字段） 查询
        /// </summary>
        /// /// <param name = "row1">行1</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow1(int row1)
        {
            return GetByRow1(row1, 0, string.Empty, null);
        }
        public async Task<List<Gmf_lineEO>> GetByRow1Async(int row1)
        {
            return await GetByRow1Async(row1, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Row1（字段） 查询
        /// </summary>
        /// /// <param name = "row1">行1</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow1(int row1, TransactionManager tm_)
        {
            return GetByRow1(row1, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_lineEO>> GetByRow1Async(int row1, TransactionManager tm_)
        {
            return await GetByRow1Async(row1, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Row1（字段） 查询
        /// </summary>
        /// /// <param name = "row1">行1</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow1(int row1, int top_)
        {
            return GetByRow1(row1, top_, string.Empty, null);
        }
        public async Task<List<Gmf_lineEO>> GetByRow1Async(int row1, int top_)
        {
            return await GetByRow1Async(row1, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Row1（字段） 查询
        /// </summary>
        /// /// <param name = "row1">行1</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow1(int row1, int top_, TransactionManager tm_)
        {
            return GetByRow1(row1, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_lineEO>> GetByRow1Async(int row1, int top_, TransactionManager tm_)
        {
            return await GetByRow1Async(row1, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Row1（字段） 查询
        /// </summary>
        /// /// <param name = "row1">行1</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow1(int row1, string sort_)
        {
            return GetByRow1(row1, 0, sort_, null);
        }
        public async Task<List<Gmf_lineEO>> GetByRow1Async(int row1, string sort_)
        {
            return await GetByRow1Async(row1, 0, sort_, null);
        }

        /// <summary>
        /// 按 Row1（字段） 查询
        /// </summary>
        /// /// <param name = "row1">行1</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow1(int row1, string sort_, TransactionManager tm_)
        {
            return GetByRow1(row1, 0, sort_, tm_);
        }
        public async Task<List<Gmf_lineEO>> GetByRow1Async(int row1, string sort_, TransactionManager tm_)
        {
            return await GetByRow1Async(row1, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Row1（字段） 查询
        /// </summary>
        /// /// <param name = "row1">行1</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow1(int row1, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Row1` = @Row1", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Row1", row1, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_lineEO.MapDataReader);
        }
        public async Task<List<Gmf_lineEO>> GetByRow1Async(int row1, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Row1` = @Row1", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Row1", row1, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_lineEO.MapDataReader);
        }
        #endregion // GetByRow1
        #region GetByRow2

        /// <summary>
        /// 按 Row2（字段） 查询
        /// </summary>
        /// /// <param name = "row2">行2</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow2(int row2)
        {
            return GetByRow2(row2, 0, string.Empty, null);
        }
        public async Task<List<Gmf_lineEO>> GetByRow2Async(int row2)
        {
            return await GetByRow2Async(row2, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Row2（字段） 查询
        /// </summary>
        /// /// <param name = "row2">行2</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow2(int row2, TransactionManager tm_)
        {
            return GetByRow2(row2, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_lineEO>> GetByRow2Async(int row2, TransactionManager tm_)
        {
            return await GetByRow2Async(row2, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Row2（字段） 查询
        /// </summary>
        /// /// <param name = "row2">行2</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow2(int row2, int top_)
        {
            return GetByRow2(row2, top_, string.Empty, null);
        }
        public async Task<List<Gmf_lineEO>> GetByRow2Async(int row2, int top_)
        {
            return await GetByRow2Async(row2, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Row2（字段） 查询
        /// </summary>
        /// /// <param name = "row2">行2</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow2(int row2, int top_, TransactionManager tm_)
        {
            return GetByRow2(row2, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_lineEO>> GetByRow2Async(int row2, int top_, TransactionManager tm_)
        {
            return await GetByRow2Async(row2, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Row2（字段） 查询
        /// </summary>
        /// /// <param name = "row2">行2</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow2(int row2, string sort_)
        {
            return GetByRow2(row2, 0, sort_, null);
        }
        public async Task<List<Gmf_lineEO>> GetByRow2Async(int row2, string sort_)
        {
            return await GetByRow2Async(row2, 0, sort_, null);
        }

        /// <summary>
        /// 按 Row2（字段） 查询
        /// </summary>
        /// /// <param name = "row2">行2</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow2(int row2, string sort_, TransactionManager tm_)
        {
            return GetByRow2(row2, 0, sort_, tm_);
        }
        public async Task<List<Gmf_lineEO>> GetByRow2Async(int row2, string sort_, TransactionManager tm_)
        {
            return await GetByRow2Async(row2, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Row2（字段） 查询
        /// </summary>
        /// /// <param name = "row2">行2</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow2(int row2, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Row2` = @Row2", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Row2", row2, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_lineEO.MapDataReader);
        }
        public async Task<List<Gmf_lineEO>> GetByRow2Async(int row2, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Row2` = @Row2", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Row2", row2, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_lineEO.MapDataReader);
        }
        #endregion // GetByRow2
        #region GetByRow3

        /// <summary>
        /// 按 Row3（字段） 查询
        /// </summary>
        /// /// <param name = "row3">行3</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow3(int row3)
        {
            return GetByRow3(row3, 0, string.Empty, null);
        }
        public async Task<List<Gmf_lineEO>> GetByRow3Async(int row3)
        {
            return await GetByRow3Async(row3, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Row3（字段） 查询
        /// </summary>
        /// /// <param name = "row3">行3</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow3(int row3, TransactionManager tm_)
        {
            return GetByRow3(row3, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_lineEO>> GetByRow3Async(int row3, TransactionManager tm_)
        {
            return await GetByRow3Async(row3, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Row3（字段） 查询
        /// </summary>
        /// /// <param name = "row3">行3</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow3(int row3, int top_)
        {
            return GetByRow3(row3, top_, string.Empty, null);
        }
        public async Task<List<Gmf_lineEO>> GetByRow3Async(int row3, int top_)
        {
            return await GetByRow3Async(row3, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Row3（字段） 查询
        /// </summary>
        /// /// <param name = "row3">行3</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow3(int row3, int top_, TransactionManager tm_)
        {
            return GetByRow3(row3, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_lineEO>> GetByRow3Async(int row3, int top_, TransactionManager tm_)
        {
            return await GetByRow3Async(row3, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Row3（字段） 查询
        /// </summary>
        /// /// <param name = "row3">行3</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow3(int row3, string sort_)
        {
            return GetByRow3(row3, 0, sort_, null);
        }
        public async Task<List<Gmf_lineEO>> GetByRow3Async(int row3, string sort_)
        {
            return await GetByRow3Async(row3, 0, sort_, null);
        }

        /// <summary>
        /// 按 Row3（字段） 查询
        /// </summary>
        /// /// <param name = "row3">行3</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow3(int row3, string sort_, TransactionManager tm_)
        {
            return GetByRow3(row3, 0, sort_, tm_);
        }
        public async Task<List<Gmf_lineEO>> GetByRow3Async(int row3, string sort_, TransactionManager tm_)
        {
            return await GetByRow3Async(row3, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Row3（字段） 查询
        /// </summary>
        /// /// <param name = "row3">行3</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow3(int row3, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Row3` = @Row3", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Row3", row3, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_lineEO.MapDataReader);
        }
        public async Task<List<Gmf_lineEO>> GetByRow3Async(int row3, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Row3` = @Row3", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Row3", row3, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_lineEO.MapDataReader);
        }
        #endregion // GetByRow3
        #region GetByRow4

        /// <summary>
        /// 按 Row4（字段） 查询
        /// </summary>
        /// /// <param name = "row4">行4</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow4(int row4)
        {
            return GetByRow4(row4, 0, string.Empty, null);
        }
        public async Task<List<Gmf_lineEO>> GetByRow4Async(int row4)
        {
            return await GetByRow4Async(row4, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Row4（字段） 查询
        /// </summary>
        /// /// <param name = "row4">行4</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow4(int row4, TransactionManager tm_)
        {
            return GetByRow4(row4, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_lineEO>> GetByRow4Async(int row4, TransactionManager tm_)
        {
            return await GetByRow4Async(row4, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Row4（字段） 查询
        /// </summary>
        /// /// <param name = "row4">行4</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow4(int row4, int top_)
        {
            return GetByRow4(row4, top_, string.Empty, null);
        }
        public async Task<List<Gmf_lineEO>> GetByRow4Async(int row4, int top_)
        {
            return await GetByRow4Async(row4, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Row4（字段） 查询
        /// </summary>
        /// /// <param name = "row4">行4</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow4(int row4, int top_, TransactionManager tm_)
        {
            return GetByRow4(row4, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_lineEO>> GetByRow4Async(int row4, int top_, TransactionManager tm_)
        {
            return await GetByRow4Async(row4, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Row4（字段） 查询
        /// </summary>
        /// /// <param name = "row4">行4</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow4(int row4, string sort_)
        {
            return GetByRow4(row4, 0, sort_, null);
        }
        public async Task<List<Gmf_lineEO>> GetByRow4Async(int row4, string sort_)
        {
            return await GetByRow4Async(row4, 0, sort_, null);
        }

        /// <summary>
        /// 按 Row4（字段） 查询
        /// </summary>
        /// /// <param name = "row4">行4</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow4(int row4, string sort_, TransactionManager tm_)
        {
            return GetByRow4(row4, 0, sort_, tm_);
        }
        public async Task<List<Gmf_lineEO>> GetByRow4Async(int row4, string sort_, TransactionManager tm_)
        {
            return await GetByRow4Async(row4, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Row4（字段） 查询
        /// </summary>
        /// /// <param name = "row4">行4</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow4(int row4, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Row4` = @Row4", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Row4", row4, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_lineEO.MapDataReader);
        }
        public async Task<List<Gmf_lineEO>> GetByRow4Async(int row4, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Row4` = @Row4", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Row4", row4, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_lineEO.MapDataReader);
        }
        #endregion // GetByRow4
        #region GetByRow5

        /// <summary>
        /// 按 Row5（字段） 查询
        /// </summary>
        /// /// <param name = "row5">行5</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow5(int row5)
        {
            return GetByRow5(row5, 0, string.Empty, null);
        }
        public async Task<List<Gmf_lineEO>> GetByRow5Async(int row5)
        {
            return await GetByRow5Async(row5, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Row5（字段） 查询
        /// </summary>
        /// /// <param name = "row5">行5</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow5(int row5, TransactionManager tm_)
        {
            return GetByRow5(row5, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_lineEO>> GetByRow5Async(int row5, TransactionManager tm_)
        {
            return await GetByRow5Async(row5, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Row5（字段） 查询
        /// </summary>
        /// /// <param name = "row5">行5</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow5(int row5, int top_)
        {
            return GetByRow5(row5, top_, string.Empty, null);
        }
        public async Task<List<Gmf_lineEO>> GetByRow5Async(int row5, int top_)
        {
            return await GetByRow5Async(row5, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Row5（字段） 查询
        /// </summary>
        /// /// <param name = "row5">行5</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow5(int row5, int top_, TransactionManager tm_)
        {
            return GetByRow5(row5, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_lineEO>> GetByRow5Async(int row5, int top_, TransactionManager tm_)
        {
            return await GetByRow5Async(row5, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Row5（字段） 查询
        /// </summary>
        /// /// <param name = "row5">行5</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow5(int row5, string sort_)
        {
            return GetByRow5(row5, 0, sort_, null);
        }
        public async Task<List<Gmf_lineEO>> GetByRow5Async(int row5, string sort_)
        {
            return await GetByRow5Async(row5, 0, sort_, null);
        }

        /// <summary>
        /// 按 Row5（字段） 查询
        /// </summary>
        /// /// <param name = "row5">行5</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow5(int row5, string sort_, TransactionManager tm_)
        {
            return GetByRow5(row5, 0, sort_, tm_);
        }
        public async Task<List<Gmf_lineEO>> GetByRow5Async(int row5, string sort_, TransactionManager tm_)
        {
            return await GetByRow5Async(row5, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Row5（字段） 查询
        /// </summary>
        /// /// <param name = "row5">行5</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_lineEO> GetByRow5(int row5, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Row5` = @Row5", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Row5", row5, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_lineEO.MapDataReader);
        }
        public async Task<List<Gmf_lineEO>> GetByRow5Async(int row5, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Row5` = @Row5", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Row5", row5, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_lineEO.MapDataReader);
        }
        #endregion // GetByRow5
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
