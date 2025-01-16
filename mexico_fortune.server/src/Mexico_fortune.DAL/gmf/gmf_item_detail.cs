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
    /// 明细
    /// 【表 gmf_item_detail 的实体类】
    /// </summary>
    [DataContract]
    public class Gmf_item_detailEO : IRowMapper<Gmf_item_detailEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Gmf_item_detailEO()
        {
            this.S1 = 0;
            this.S2 = 0;
            this.S3 = 0;
            this.S4 = 0;
            this.S5 = 0;
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private long _originalItemID;
        /// <summary>
        /// 【数据库中的原始主键 ItemID 值的副本，用于主键值更新】
        /// </summary>
        public long OriginalItemID
        {
            get { return _originalItemID; }
            set { HasOriginal = true; _originalItemID = value; }
        }

        private int _originalRowIndex;
        /// <summary>
        /// 【数据库中的原始主键 RowIndex 值的副本，用于主键值更新】
        /// </summary>
        public int OriginalRowIndex
        {
            get { return _originalRowIndex; }
            set { HasOriginal = true; _originalRowIndex = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "ItemID", ItemID }, { "RowIndex", RowIndex }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// 项编码
        /// 【主键 bigint】
        /// </summary>
        [DataMember(Order = 1)]
        public long ItemID { get; set; }
        /// <summary>
        /// 行编码012
        /// 【主键 tinyint】
        /// </summary>
        [DataMember(Order = 2)]
        public int RowIndex { get; set; }
        /// <summary>
        /// 轴1
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 3)]
        public int S1 { get; set; }
        /// <summary>
        /// 轴2
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 4)]
        public int S2 { get; set; }
        /// <summary>
        /// 轴3
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 5)]
        public int S3 { get; set; }
        /// <summary>
        /// 轴4
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 6)]
        public int S4 { get; set; }
        /// <summary>
        /// 轴5
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 7)]
        public int S5 { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public Gmf_item_detailEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static Gmf_item_detailEO MapDataReader(IDataReader reader)
        {
            Gmf_item_detailEO ret = new Gmf_item_detailEO();
            ret.ItemID = reader.ToInt64("ItemID");
            ret.OriginalItemID = ret.ItemID;
            ret.RowIndex = reader.ToInt32("RowIndex");
            ret.OriginalRowIndex = ret.RowIndex;
            ret.S1 = reader.ToInt32("S1");
            ret.S2 = reader.ToInt32("S2");
            ret.S3 = reader.ToInt32("S3");
            ret.S4 = reader.ToInt32("S4");
            ret.S5 = reader.ToInt32("S5");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// 明细
    /// 【表 gmf_item_detail 的操作类】
    /// </summary>
    public class Gmf_item_detailMO : MySqlTableMO<Gmf_item_detailEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`gmf_item_detail`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public Gmf_item_detailMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public Gmf_item_detailMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public Gmf_item_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(Gmf_item_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(Gmf_item_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(Gmf_item_detailEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`ItemID`, `RowIndex`, `S1`, `S2`, `S3`, `S4`, `S5`) VALUE (@ItemID, @RowIndex, @S1, @S2, @S3, @S4, @S5);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", item.RowIndex, MySqlDbType.Byte),
                Database.CreateInParameter("@S1", item.S1, MySqlDbType.Byte),
                Database.CreateInParameter("@S2", item.S2, MySqlDbType.Byte),
                Database.CreateInParameter("@S3", item.S3, MySqlDbType.Byte),
                Database.CreateInParameter("@S4", item.S4, MySqlDbType.Byte),
                Database.CreateInParameter("@S5", item.S5, MySqlDbType.Byte),
            };
        }
        public int AddByBatch(IEnumerable<Gmf_item_detailEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<Gmf_item_detailEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gmf_item_detailEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`ItemID`, `RowIndex`, `S1`, `S2`, `S3`, `S4`, `S5`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"({item.ItemID},{item.RowIndex},{item.S1},{item.S2},{item.S3},{item.S4},{item.S5}),");
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
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(long itemID, int rowIndex, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(itemID, rowIndex, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(long itemID, int rowIndex, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(itemID, rowIndex, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(long itemID, int rowIndex, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `ItemID` = @ItemID AND `RowIndex` = @RowIndex";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(Gmf_item_detailEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.ItemID, item.RowIndex, tm_);
        }
        public async Task<int> RemoveAsync(Gmf_item_detailEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.ItemID, item.RowIndex, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
        #region RemoveByItemID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByItemID(long itemID, TransactionManager tm_ = null)
        {
            RepairRemoveByItemIDData(itemID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByItemIDAsync(long itemID, TransactionManager tm_ = null)
        {
            RepairRemoveByItemIDData(itemID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByItemIDData(long itemID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `ItemID` = @ItemID";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64));
        }
        #endregion // RemoveByItemID
        #region RemoveByRowIndex
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByRowIndex(int rowIndex, TransactionManager tm_ = null)
        {
            RepairRemoveByRowIndexData(rowIndex, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByRowIndexAsync(int rowIndex, TransactionManager tm_ = null)
        {
            RepairRemoveByRowIndexData(rowIndex, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByRowIndexData(int rowIndex, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `RowIndex` = @RowIndex";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte));
        }
        #endregion // RemoveByRowIndex
        #region RemoveByS1
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "s1">轴1</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByS1(int s1, TransactionManager tm_ = null)
        {
            RepairRemoveByS1Data(s1, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByS1Async(int s1, TransactionManager tm_ = null)
        {
            RepairRemoveByS1Data(s1, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByS1Data(int s1, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `S1` = @S1";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@S1", s1, MySqlDbType.Byte));
        }
        #endregion // RemoveByS1
        #region RemoveByS2
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "s2">轴2</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByS2(int s2, TransactionManager tm_ = null)
        {
            RepairRemoveByS2Data(s2, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByS2Async(int s2, TransactionManager tm_ = null)
        {
            RepairRemoveByS2Data(s2, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByS2Data(int s2, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `S2` = @S2";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@S2", s2, MySqlDbType.Byte));
        }
        #endregion // RemoveByS2
        #region RemoveByS3
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "s3">轴3</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByS3(int s3, TransactionManager tm_ = null)
        {
            RepairRemoveByS3Data(s3, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByS3Async(int s3, TransactionManager tm_ = null)
        {
            RepairRemoveByS3Data(s3, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByS3Data(int s3, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `S3` = @S3";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@S3", s3, MySqlDbType.Byte));
        }
        #endregion // RemoveByS3
        #region RemoveByS4
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "s4">轴4</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByS4(int s4, TransactionManager tm_ = null)
        {
            RepairRemoveByS4Data(s4, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByS4Async(int s4, TransactionManager tm_ = null)
        {
            RepairRemoveByS4Data(s4, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByS4Data(int s4, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `S4` = @S4";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@S4", s4, MySqlDbType.Byte));
        }
        #endregion // RemoveByS4
        #region RemoveByS5
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "s5">轴5</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByS5(int s5, TransactionManager tm_ = null)
        {
            RepairRemoveByS5Data(s5, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByS5Async(int s5, TransactionManager tm_ = null)
        {
            RepairRemoveByS5Data(s5, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByS5Data(int s5, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `S5` = @S5";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@S5", s5, MySqlDbType.Byte));
        }
        #endregion // RemoveByS5
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
        public int Put(Gmf_item_detailEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(Gmf_item_detailEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(Gmf_item_detailEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID, `RowIndex` = @RowIndex, `S1` = @S1, `S2` = @S2, `S3` = @S3, `S4` = @S4, `S5` = @S5 WHERE `ItemID` = @ItemID_Original AND `RowIndex` = @RowIndex_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", item.RowIndex, MySqlDbType.Byte),
                Database.CreateInParameter("@S1", item.S1, MySqlDbType.Byte),
                Database.CreateInParameter("@S2", item.S2, MySqlDbType.Byte),
                Database.CreateInParameter("@S3", item.S3, MySqlDbType.Byte),
                Database.CreateInParameter("@S4", item.S4, MySqlDbType.Byte),
                Database.CreateInParameter("@S5", item.S5, MySqlDbType.Byte),
                Database.CreateInParameter("@ItemID_Original", item.HasOriginal ? item.OriginalItemID : item.ItemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex_Original", item.HasOriginal ? item.OriginalRowIndex : item.RowIndex, MySqlDbType.Byte),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<Gmf_item_detailEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<Gmf_item_detailEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(long itemID, int rowIndex, string set_, params object[] values_)
        {
            return Put(set_, "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", ConcatValues(values_, itemID, rowIndex));
        }
        public async Task<int> PutByPKAsync(long itemID, int rowIndex, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", ConcatValues(values_, itemID, rowIndex));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(long itemID, int rowIndex, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", tm_, ConcatValues(values_, itemID, rowIndex));
        }
        public async Task<int> PutByPKAsync(long itemID, int rowIndex, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", tm_, ConcatValues(values_, itemID, rowIndex));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(long itemID, int rowIndex, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
            return Put(set_, "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(long itemID, int rowIndex, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
            return await PutAsync(set_, "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutItemID

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutItemID(long itemID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID";
            var parameter_ = Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutItemIDAsync(long itemID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID";
            var parameter_ = Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutItemID
        #region PutRowIndex

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRowIndex(int rowIndex, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `RowIndex` = @RowIndex";
            var parameter_ = Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutRowIndexAsync(int rowIndex, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `RowIndex` = @RowIndex";
            var parameter_ = Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutRowIndex
        #region PutS1
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// /// <param name = "s1">轴1</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutS1ByPK(long itemID, int rowIndex, int s1, TransactionManager tm_ = null)
        {
            RepairPutS1ByPKData(itemID, rowIndex, s1, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutS1ByPKAsync(long itemID, int rowIndex, int s1, TransactionManager tm_ = null)
        {
            RepairPutS1ByPKData(itemID, rowIndex, s1, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutS1ByPKData(long itemID, int rowIndex, int s1, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `S1` = @S1  WHERE `ItemID` = @ItemID AND `RowIndex` = @RowIndex";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@S1", s1, MySqlDbType.Byte),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "s1">轴1</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutS1(int s1, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `S1` = @S1";
            var parameter_ = Database.CreateInParameter("@S1", s1, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutS1Async(int s1, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `S1` = @S1";
            var parameter_ = Database.CreateInParameter("@S1", s1, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutS1
        #region PutS2
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// /// <param name = "s2">轴2</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutS2ByPK(long itemID, int rowIndex, int s2, TransactionManager tm_ = null)
        {
            RepairPutS2ByPKData(itemID, rowIndex, s2, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutS2ByPKAsync(long itemID, int rowIndex, int s2, TransactionManager tm_ = null)
        {
            RepairPutS2ByPKData(itemID, rowIndex, s2, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutS2ByPKData(long itemID, int rowIndex, int s2, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `S2` = @S2  WHERE `ItemID` = @ItemID AND `RowIndex` = @RowIndex";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@S2", s2, MySqlDbType.Byte),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "s2">轴2</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutS2(int s2, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `S2` = @S2";
            var parameter_ = Database.CreateInParameter("@S2", s2, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutS2Async(int s2, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `S2` = @S2";
            var parameter_ = Database.CreateInParameter("@S2", s2, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutS2
        #region PutS3
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// /// <param name = "s3">轴3</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutS3ByPK(long itemID, int rowIndex, int s3, TransactionManager tm_ = null)
        {
            RepairPutS3ByPKData(itemID, rowIndex, s3, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutS3ByPKAsync(long itemID, int rowIndex, int s3, TransactionManager tm_ = null)
        {
            RepairPutS3ByPKData(itemID, rowIndex, s3, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutS3ByPKData(long itemID, int rowIndex, int s3, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `S3` = @S3  WHERE `ItemID` = @ItemID AND `RowIndex` = @RowIndex";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@S3", s3, MySqlDbType.Byte),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "s3">轴3</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutS3(int s3, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `S3` = @S3";
            var parameter_ = Database.CreateInParameter("@S3", s3, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutS3Async(int s3, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `S3` = @S3";
            var parameter_ = Database.CreateInParameter("@S3", s3, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutS3
        #region PutS4
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// /// <param name = "s4">轴4</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutS4ByPK(long itemID, int rowIndex, int s4, TransactionManager tm_ = null)
        {
            RepairPutS4ByPKData(itemID, rowIndex, s4, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutS4ByPKAsync(long itemID, int rowIndex, int s4, TransactionManager tm_ = null)
        {
            RepairPutS4ByPKData(itemID, rowIndex, s4, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutS4ByPKData(long itemID, int rowIndex, int s4, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `S4` = @S4  WHERE `ItemID` = @ItemID AND `RowIndex` = @RowIndex";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@S4", s4, MySqlDbType.Byte),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "s4">轴4</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutS4(int s4, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `S4` = @S4";
            var parameter_ = Database.CreateInParameter("@S4", s4, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutS4Async(int s4, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `S4` = @S4";
            var parameter_ = Database.CreateInParameter("@S4", s4, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutS4
        #region PutS5
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// /// <param name = "s5">轴5</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutS5ByPK(long itemID, int rowIndex, int s5, TransactionManager tm_ = null)
        {
            RepairPutS5ByPKData(itemID, rowIndex, s5, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutS5ByPKAsync(long itemID, int rowIndex, int s5, TransactionManager tm_ = null)
        {
            RepairPutS5ByPKData(itemID, rowIndex, s5, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutS5ByPKData(long itemID, int rowIndex, int s5, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `S5` = @S5  WHERE `ItemID` = @ItemID AND `RowIndex` = @RowIndex";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@S5", s5, MySqlDbType.Byte),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "s5">轴5</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutS5(int s5, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `S5` = @S5";
            var parameter_ = Database.CreateInParameter("@S5", s5, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutS5Async(int s5, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `S5` = @S5";
            var parameter_ = Database.CreateInParameter("@S5", s5, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutS5
        #endregion // PutXXX
        #endregion // Put

        #region Set

        /// <summary>
        /// 插入或者更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>true:插入操作；false:更新操作</return>
        public bool Set(Gmf_item_detailEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.ItemID, item.RowIndex) == null)
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
        public async Task<bool> SetAsync(Gmf_item_detailEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.ItemID, item.RowIndex) == null)
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
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public Gmf_item_detailEO GetByPK(long itemID, int rowIndex, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(itemID, rowIndex, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, Gmf_item_detailEO.MapDataReader);
        }
        public async Task<Gmf_item_detailEO> GetByPKAsync(long itemID, int rowIndex, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(itemID, rowIndex, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gmf_item_detailEO.MapDataReader);
        }
        private void RepairGetByPKData(long itemID, int rowIndex, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`ItemID` = @ItemID AND `RowIndex` = @RowIndex", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 ItemID（字段）
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetItemIDByPK(long itemID, int rowIndex, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
            return (long)GetScalar("`ItemID`", "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", paras_, tm_);
        }
        public async Task<long> GetItemIDByPKAsync(long itemID, int rowIndex, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
            return (long)await GetScalarAsync("`ItemID`", "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 RowIndex（字段）
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetRowIndexByPK(long itemID, int rowIndex, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
            return (int)GetScalar("`RowIndex`", "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", paras_, tm_);
        }
        public async Task<int> GetRowIndexByPKAsync(long itemID, int rowIndex, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
            return (int)await GetScalarAsync("`RowIndex`", "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 S1（字段）
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetS1ByPK(long itemID, int rowIndex, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
            return (int)GetScalar("`S1`", "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", paras_, tm_);
        }
        public async Task<int> GetS1ByPKAsync(long itemID, int rowIndex, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
            return (int)await GetScalarAsync("`S1`", "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 S2（字段）
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetS2ByPK(long itemID, int rowIndex, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
            return (int)GetScalar("`S2`", "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", paras_, tm_);
        }
        public async Task<int> GetS2ByPKAsync(long itemID, int rowIndex, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
            return (int)await GetScalarAsync("`S2`", "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 S3（字段）
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetS3ByPK(long itemID, int rowIndex, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
            return (int)GetScalar("`S3`", "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", paras_, tm_);
        }
        public async Task<int> GetS3ByPKAsync(long itemID, int rowIndex, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
            return (int)await GetScalarAsync("`S3`", "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 S4（字段）
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetS4ByPK(long itemID, int rowIndex, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
            return (int)GetScalar("`S4`", "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", paras_, tm_);
        }
        public async Task<int> GetS4ByPKAsync(long itemID, int rowIndex, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
            return (int)await GetScalarAsync("`S4`", "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 S5（字段）
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetS5ByPK(long itemID, int rowIndex, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
            return (int)GetScalar("`S5`", "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", paras_, tm_);
        }
        public async Task<int> GetS5ByPKAsync(long itemID, int rowIndex, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte),
            };
            return (int)await GetScalarAsync("`S5`", "`ItemID` = @ItemID AND `RowIndex` = @RowIndex", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByItemID

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByItemID(long itemID)
        {
            return GetByItemID(itemID, 0, string.Empty, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByItemIDAsync(long itemID)
        {
            return await GetByItemIDAsync(itemID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByItemID(long itemID, TransactionManager tm_)
        {
            return GetByItemID(itemID, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByItemIDAsync(long itemID, TransactionManager tm_)
        {
            return await GetByItemIDAsync(itemID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByItemID(long itemID, int top_)
        {
            return GetByItemID(itemID, top_, string.Empty, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByItemIDAsync(long itemID, int top_)
        {
            return await GetByItemIDAsync(itemID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByItemID(long itemID, int top_, TransactionManager tm_)
        {
            return GetByItemID(itemID, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByItemIDAsync(long itemID, int top_, TransactionManager tm_)
        {
            return await GetByItemIDAsync(itemID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByItemID(long itemID, string sort_)
        {
            return GetByItemID(itemID, 0, sort_, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByItemIDAsync(long itemID, string sort_)
        {
            return await GetByItemIDAsync(itemID, 0, sort_, null);
        }

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByItemID(long itemID, string sort_, TransactionManager tm_)
        {
            return GetByItemID(itemID, 0, sort_, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByItemIDAsync(long itemID, string sort_, TransactionManager tm_)
        {
            return await GetByItemIDAsync(itemID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByItemID(long itemID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_item_detailEO.MapDataReader);
        }
        public async Task<List<Gmf_item_detailEO>> GetByItemIDAsync(long itemID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_item_detailEO.MapDataReader);
        }
        #endregion // GetByItemID
        #region GetByRowIndex

        /// <summary>
        /// 按 RowIndex（字段） 查询
        /// </summary>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByRowIndex(int rowIndex)
        {
            return GetByRowIndex(rowIndex, 0, string.Empty, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByRowIndexAsync(int rowIndex)
        {
            return await GetByRowIndexAsync(rowIndex, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 RowIndex（字段） 查询
        /// </summary>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByRowIndex(int rowIndex, TransactionManager tm_)
        {
            return GetByRowIndex(rowIndex, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByRowIndexAsync(int rowIndex, TransactionManager tm_)
        {
            return await GetByRowIndexAsync(rowIndex, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RowIndex（字段） 查询
        /// </summary>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByRowIndex(int rowIndex, int top_)
        {
            return GetByRowIndex(rowIndex, top_, string.Empty, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByRowIndexAsync(int rowIndex, int top_)
        {
            return await GetByRowIndexAsync(rowIndex, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 RowIndex（字段） 查询
        /// </summary>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByRowIndex(int rowIndex, int top_, TransactionManager tm_)
        {
            return GetByRowIndex(rowIndex, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByRowIndexAsync(int rowIndex, int top_, TransactionManager tm_)
        {
            return await GetByRowIndexAsync(rowIndex, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RowIndex（字段） 查询
        /// </summary>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByRowIndex(int rowIndex, string sort_)
        {
            return GetByRowIndex(rowIndex, 0, sort_, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByRowIndexAsync(int rowIndex, string sort_)
        {
            return await GetByRowIndexAsync(rowIndex, 0, sort_, null);
        }

        /// <summary>
        /// 按 RowIndex（字段） 查询
        /// </summary>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByRowIndex(int rowIndex, string sort_, TransactionManager tm_)
        {
            return GetByRowIndex(rowIndex, 0, sort_, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByRowIndexAsync(int rowIndex, string sort_, TransactionManager tm_)
        {
            return await GetByRowIndexAsync(rowIndex, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 RowIndex（字段） 查询
        /// </summary>
        /// /// <param name = "rowIndex">行编码012</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByRowIndex(int rowIndex, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RowIndex` = @RowIndex", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_item_detailEO.MapDataReader);
        }
        public async Task<List<Gmf_item_detailEO>> GetByRowIndexAsync(int rowIndex, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RowIndex` = @RowIndex", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RowIndex", rowIndex, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_item_detailEO.MapDataReader);
        }
        #endregion // GetByRowIndex
        #region GetByS1

        /// <summary>
        /// 按 S1（字段） 查询
        /// </summary>
        /// /// <param name = "s1">轴1</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS1(int s1)
        {
            return GetByS1(s1, 0, string.Empty, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS1Async(int s1)
        {
            return await GetByS1Async(s1, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 S1（字段） 查询
        /// </summary>
        /// /// <param name = "s1">轴1</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS1(int s1, TransactionManager tm_)
        {
            return GetByS1(s1, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS1Async(int s1, TransactionManager tm_)
        {
            return await GetByS1Async(s1, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 S1（字段） 查询
        /// </summary>
        /// /// <param name = "s1">轴1</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS1(int s1, int top_)
        {
            return GetByS1(s1, top_, string.Empty, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS1Async(int s1, int top_)
        {
            return await GetByS1Async(s1, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 S1（字段） 查询
        /// </summary>
        /// /// <param name = "s1">轴1</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS1(int s1, int top_, TransactionManager tm_)
        {
            return GetByS1(s1, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS1Async(int s1, int top_, TransactionManager tm_)
        {
            return await GetByS1Async(s1, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 S1（字段） 查询
        /// </summary>
        /// /// <param name = "s1">轴1</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS1(int s1, string sort_)
        {
            return GetByS1(s1, 0, sort_, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS1Async(int s1, string sort_)
        {
            return await GetByS1Async(s1, 0, sort_, null);
        }

        /// <summary>
        /// 按 S1（字段） 查询
        /// </summary>
        /// /// <param name = "s1">轴1</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS1(int s1, string sort_, TransactionManager tm_)
        {
            return GetByS1(s1, 0, sort_, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS1Async(int s1, string sort_, TransactionManager tm_)
        {
            return await GetByS1Async(s1, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 S1（字段） 查询
        /// </summary>
        /// /// <param name = "s1">轴1</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS1(int s1, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`S1` = @S1", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@S1", s1, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_item_detailEO.MapDataReader);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS1Async(int s1, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`S1` = @S1", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@S1", s1, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_item_detailEO.MapDataReader);
        }
        #endregion // GetByS1
        #region GetByS2

        /// <summary>
        /// 按 S2（字段） 查询
        /// </summary>
        /// /// <param name = "s2">轴2</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS2(int s2)
        {
            return GetByS2(s2, 0, string.Empty, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS2Async(int s2)
        {
            return await GetByS2Async(s2, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 S2（字段） 查询
        /// </summary>
        /// /// <param name = "s2">轴2</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS2(int s2, TransactionManager tm_)
        {
            return GetByS2(s2, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS2Async(int s2, TransactionManager tm_)
        {
            return await GetByS2Async(s2, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 S2（字段） 查询
        /// </summary>
        /// /// <param name = "s2">轴2</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS2(int s2, int top_)
        {
            return GetByS2(s2, top_, string.Empty, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS2Async(int s2, int top_)
        {
            return await GetByS2Async(s2, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 S2（字段） 查询
        /// </summary>
        /// /// <param name = "s2">轴2</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS2(int s2, int top_, TransactionManager tm_)
        {
            return GetByS2(s2, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS2Async(int s2, int top_, TransactionManager tm_)
        {
            return await GetByS2Async(s2, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 S2（字段） 查询
        /// </summary>
        /// /// <param name = "s2">轴2</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS2(int s2, string sort_)
        {
            return GetByS2(s2, 0, sort_, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS2Async(int s2, string sort_)
        {
            return await GetByS2Async(s2, 0, sort_, null);
        }

        /// <summary>
        /// 按 S2（字段） 查询
        /// </summary>
        /// /// <param name = "s2">轴2</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS2(int s2, string sort_, TransactionManager tm_)
        {
            return GetByS2(s2, 0, sort_, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS2Async(int s2, string sort_, TransactionManager tm_)
        {
            return await GetByS2Async(s2, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 S2（字段） 查询
        /// </summary>
        /// /// <param name = "s2">轴2</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS2(int s2, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`S2` = @S2", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@S2", s2, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_item_detailEO.MapDataReader);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS2Async(int s2, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`S2` = @S2", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@S2", s2, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_item_detailEO.MapDataReader);
        }
        #endregion // GetByS2
        #region GetByS3

        /// <summary>
        /// 按 S3（字段） 查询
        /// </summary>
        /// /// <param name = "s3">轴3</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS3(int s3)
        {
            return GetByS3(s3, 0, string.Empty, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS3Async(int s3)
        {
            return await GetByS3Async(s3, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 S3（字段） 查询
        /// </summary>
        /// /// <param name = "s3">轴3</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS3(int s3, TransactionManager tm_)
        {
            return GetByS3(s3, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS3Async(int s3, TransactionManager tm_)
        {
            return await GetByS3Async(s3, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 S3（字段） 查询
        /// </summary>
        /// /// <param name = "s3">轴3</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS3(int s3, int top_)
        {
            return GetByS3(s3, top_, string.Empty, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS3Async(int s3, int top_)
        {
            return await GetByS3Async(s3, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 S3（字段） 查询
        /// </summary>
        /// /// <param name = "s3">轴3</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS3(int s3, int top_, TransactionManager tm_)
        {
            return GetByS3(s3, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS3Async(int s3, int top_, TransactionManager tm_)
        {
            return await GetByS3Async(s3, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 S3（字段） 查询
        /// </summary>
        /// /// <param name = "s3">轴3</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS3(int s3, string sort_)
        {
            return GetByS3(s3, 0, sort_, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS3Async(int s3, string sort_)
        {
            return await GetByS3Async(s3, 0, sort_, null);
        }

        /// <summary>
        /// 按 S3（字段） 查询
        /// </summary>
        /// /// <param name = "s3">轴3</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS3(int s3, string sort_, TransactionManager tm_)
        {
            return GetByS3(s3, 0, sort_, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS3Async(int s3, string sort_, TransactionManager tm_)
        {
            return await GetByS3Async(s3, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 S3（字段） 查询
        /// </summary>
        /// /// <param name = "s3">轴3</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS3(int s3, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`S3` = @S3", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@S3", s3, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_item_detailEO.MapDataReader);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS3Async(int s3, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`S3` = @S3", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@S3", s3, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_item_detailEO.MapDataReader);
        }
        #endregion // GetByS3
        #region GetByS4

        /// <summary>
        /// 按 S4（字段） 查询
        /// </summary>
        /// /// <param name = "s4">轴4</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS4(int s4)
        {
            return GetByS4(s4, 0, string.Empty, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS4Async(int s4)
        {
            return await GetByS4Async(s4, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 S4（字段） 查询
        /// </summary>
        /// /// <param name = "s4">轴4</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS4(int s4, TransactionManager tm_)
        {
            return GetByS4(s4, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS4Async(int s4, TransactionManager tm_)
        {
            return await GetByS4Async(s4, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 S4（字段） 查询
        /// </summary>
        /// /// <param name = "s4">轴4</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS4(int s4, int top_)
        {
            return GetByS4(s4, top_, string.Empty, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS4Async(int s4, int top_)
        {
            return await GetByS4Async(s4, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 S4（字段） 查询
        /// </summary>
        /// /// <param name = "s4">轴4</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS4(int s4, int top_, TransactionManager tm_)
        {
            return GetByS4(s4, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS4Async(int s4, int top_, TransactionManager tm_)
        {
            return await GetByS4Async(s4, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 S4（字段） 查询
        /// </summary>
        /// /// <param name = "s4">轴4</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS4(int s4, string sort_)
        {
            return GetByS4(s4, 0, sort_, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS4Async(int s4, string sort_)
        {
            return await GetByS4Async(s4, 0, sort_, null);
        }

        /// <summary>
        /// 按 S4（字段） 查询
        /// </summary>
        /// /// <param name = "s4">轴4</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS4(int s4, string sort_, TransactionManager tm_)
        {
            return GetByS4(s4, 0, sort_, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS4Async(int s4, string sort_, TransactionManager tm_)
        {
            return await GetByS4Async(s4, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 S4（字段） 查询
        /// </summary>
        /// /// <param name = "s4">轴4</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS4(int s4, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`S4` = @S4", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@S4", s4, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_item_detailEO.MapDataReader);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS4Async(int s4, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`S4` = @S4", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@S4", s4, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_item_detailEO.MapDataReader);
        }
        #endregion // GetByS4
        #region GetByS5

        /// <summary>
        /// 按 S5（字段） 查询
        /// </summary>
        /// /// <param name = "s5">轴5</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS5(int s5)
        {
            return GetByS5(s5, 0, string.Empty, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS5Async(int s5)
        {
            return await GetByS5Async(s5, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 S5（字段） 查询
        /// </summary>
        /// /// <param name = "s5">轴5</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS5(int s5, TransactionManager tm_)
        {
            return GetByS5(s5, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS5Async(int s5, TransactionManager tm_)
        {
            return await GetByS5Async(s5, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 S5（字段） 查询
        /// </summary>
        /// /// <param name = "s5">轴5</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS5(int s5, int top_)
        {
            return GetByS5(s5, top_, string.Empty, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS5Async(int s5, int top_)
        {
            return await GetByS5Async(s5, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 S5（字段） 查询
        /// </summary>
        /// /// <param name = "s5">轴5</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS5(int s5, int top_, TransactionManager tm_)
        {
            return GetByS5(s5, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS5Async(int s5, int top_, TransactionManager tm_)
        {
            return await GetByS5Async(s5, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 S5（字段） 查询
        /// </summary>
        /// /// <param name = "s5">轴5</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS5(int s5, string sort_)
        {
            return GetByS5(s5, 0, sort_, null);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS5Async(int s5, string sort_)
        {
            return await GetByS5Async(s5, 0, sort_, null);
        }

        /// <summary>
        /// 按 S5（字段） 查询
        /// </summary>
        /// /// <param name = "s5">轴5</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS5(int s5, string sort_, TransactionManager tm_)
        {
            return GetByS5(s5, 0, sort_, tm_);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS5Async(int s5, string sort_, TransactionManager tm_)
        {
            return await GetByS5Async(s5, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 S5（字段） 查询
        /// </summary>
        /// /// <param name = "s5">轴5</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_detailEO> GetByS5(int s5, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`S5` = @S5", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@S5", s5, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_item_detailEO.MapDataReader);
        }
        public async Task<List<Gmf_item_detailEO>> GetByS5Async(int s5, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`S5` = @S5", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@S5", s5, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_item_detailEO.MapDataReader);
        }
        #endregion // GetByS5
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
