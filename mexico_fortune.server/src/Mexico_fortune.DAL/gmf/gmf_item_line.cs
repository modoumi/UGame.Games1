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
    /// 【表 gmf_item_line 的实体类】
    /// </summary>
    [DataContract]
    public class Gmf_item_lineEO : IRowMapper<Gmf_item_lineEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Gmf_item_lineEO()
        {
            this.HitNum = 0;
            this.Multip = 0;
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

        private int _originalLineId;
        /// <summary>
        /// 【数据库中的原始主键 LineId 值的副本，用于主键值更新】
        /// </summary>
        public int OriginalLineId
        {
            get { return _originalLineId; }
            set { HasOriginal = true; _originalLineId = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "ItemID", ItemID }, { "LineId", LineId }, };
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
        /// 线编码
        /// 【主键 tinyint】
        /// </summary>
        [DataMember(Order = 2)]
        public int LineId { get; set; }
        /// <summary>
        /// Symbol编码
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 3)]
        public int HitId { get; set; }
        /// <summary>
        /// 重复数量
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 4)]
        public int HitNum { get; set; }
        /// <summary>
        /// 倍率
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 5)]
        public int Multip { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public Gmf_item_lineEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static Gmf_item_lineEO MapDataReader(IDataReader reader)
        {
            Gmf_item_lineEO ret = new Gmf_item_lineEO();
            ret.ItemID = reader.ToInt64("ItemID");
            ret.OriginalItemID = ret.ItemID;
            ret.LineId = reader.ToInt32("LineId");
            ret.OriginalLineId = ret.LineId;
            ret.HitId = reader.ToInt32("HitId");
            ret.HitNum = reader.ToInt32("HitNum");
            ret.Multip = reader.ToInt32("Multip");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// 
    /// 【表 gmf_item_line 的操作类】
    /// </summary>
    public class Gmf_item_lineMO : MySqlTableMO<Gmf_item_lineEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`gmf_item_line`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public Gmf_item_lineMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public Gmf_item_lineMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public Gmf_item_lineMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(Gmf_item_lineEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(Gmf_item_lineEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(Gmf_item_lineEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`ItemID`, `LineId`, `HitId`, `HitNum`, `Multip`) VALUE (@ItemID, @LineId, @HitId, @HitNum, @Multip);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", item.LineId, MySqlDbType.Byte),
                Database.CreateInParameter("@HitId", item.HitId, MySqlDbType.Byte),
                Database.CreateInParameter("@HitNum", item.HitNum, MySqlDbType.Byte),
                Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Int32),
            };
        }
        public int AddByBatch(IEnumerable<Gmf_item_lineEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<Gmf_item_lineEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gmf_item_lineEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`ItemID`, `LineId`, `HitId`, `HitNum`, `Multip`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"({item.ItemID},{item.LineId},{item.HitId},{item.HitNum},{item.Multip}),");
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
        /// /// <param name = "lineId">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(long itemID, int lineId, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(itemID, lineId, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(long itemID, int lineId, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(itemID, lineId, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(long itemID, int lineId, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `ItemID` = @ItemID AND `LineId` = @LineId";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(Gmf_item_lineEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.ItemID, item.LineId, tm_);
        }
        public async Task<int> RemoveAsync(Gmf_item_lineEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.ItemID, item.LineId, tm_);
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
        #region RemoveByLineId
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "lineId">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByLineId(int lineId, TransactionManager tm_ = null)
        {
            RepairRemoveByLineIdData(lineId, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByLineIdAsync(int lineId, TransactionManager tm_ = null)
        {
            RepairRemoveByLineIdData(lineId, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByLineIdData(int lineId, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `LineId` = @LineId";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte));
        }
        #endregion // RemoveByLineId
        #region RemoveByHitId
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "hitId">Symbol编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByHitId(int hitId, TransactionManager tm_ = null)
        {
            RepairRemoveByHitIdData(hitId, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByHitIdAsync(int hitId, TransactionManager tm_ = null)
        {
            RepairRemoveByHitIdData(hitId, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByHitIdData(int hitId, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `HitId` = @HitId";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@HitId", hitId, MySqlDbType.Byte));
        }
        #endregion // RemoveByHitId
        #region RemoveByHitNum
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "hitNum">重复数量</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByHitNum(int hitNum, TransactionManager tm_ = null)
        {
            RepairRemoveByHitNumData(hitNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByHitNumAsync(int hitNum, TransactionManager tm_ = null)
        {
            RepairRemoveByHitNumData(hitNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByHitNumData(int hitNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `HitNum` = @HitNum";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@HitNum", hitNum, MySqlDbType.Byte));
        }
        #endregion // RemoveByHitNum
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
        public int Put(Gmf_item_lineEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(Gmf_item_lineEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(Gmf_item_lineEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID, `LineId` = @LineId, `HitId` = @HitId, `HitNum` = @HitNum, `Multip` = @Multip WHERE `ItemID` = @ItemID_Original AND `LineId` = @LineId_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", item.LineId, MySqlDbType.Byte),
                Database.CreateInParameter("@HitId", item.HitId, MySqlDbType.Byte),
                Database.CreateInParameter("@HitNum", item.HitNum, MySqlDbType.Byte),
                Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Int32),
                Database.CreateInParameter("@ItemID_Original", item.HasOriginal ? item.OriginalItemID : item.ItemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId_Original", item.HasOriginal ? item.OriginalLineId : item.LineId, MySqlDbType.Byte),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<Gmf_item_lineEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<Gmf_item_lineEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "lineId">线编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(long itemID, int lineId, string set_, params object[] values_)
        {
            return Put(set_, "`ItemID` = @ItemID AND `LineId` = @LineId", ConcatValues(values_, itemID, lineId));
        }
        public async Task<int> PutByPKAsync(long itemID, int lineId, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`ItemID` = @ItemID AND `LineId` = @LineId", ConcatValues(values_, itemID, lineId));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "lineId">线编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(long itemID, int lineId, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`ItemID` = @ItemID AND `LineId` = @LineId", tm_, ConcatValues(values_, itemID, lineId));
        }
        public async Task<int> PutByPKAsync(long itemID, int lineId, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`ItemID` = @ItemID AND `LineId` = @LineId", tm_, ConcatValues(values_, itemID, lineId));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "lineId">线编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(long itemID, int lineId, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
            };
            return Put(set_, "`ItemID` = @ItemID AND `LineId` = @LineId", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(long itemID, int lineId, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
            };
            return await PutAsync(set_, "`ItemID` = @ItemID AND `LineId` = @LineId", ConcatParameters(paras_, newParas_), tm_);
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
        #region PutLineId

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "lineId">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutLineId(int lineId, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `LineId` = @LineId";
            var parameter_ = Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutLineIdAsync(int lineId, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `LineId` = @LineId";
            var parameter_ = Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutLineId
        #region PutHitId
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "lineId">线编码</param>
        /// /// <param name = "hitId">Symbol编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutHitIdByPK(long itemID, int lineId, int hitId, TransactionManager tm_ = null)
        {
            RepairPutHitIdByPKData(itemID, lineId, hitId, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutHitIdByPKAsync(long itemID, int lineId, int hitId, TransactionManager tm_ = null)
        {
            RepairPutHitIdByPKData(itemID, lineId, hitId, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutHitIdByPKData(long itemID, int lineId, int hitId, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `HitId` = @HitId  WHERE `ItemID` = @ItemID AND `LineId` = @LineId";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@HitId", hitId, MySqlDbType.Byte),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "hitId">Symbol编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutHitId(int hitId, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `HitId` = @HitId";
            var parameter_ = Database.CreateInParameter("@HitId", hitId, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutHitIdAsync(int hitId, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `HitId` = @HitId";
            var parameter_ = Database.CreateInParameter("@HitId", hitId, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutHitId
        #region PutHitNum
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "lineId">线编码</param>
        /// /// <param name = "hitNum">重复数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutHitNumByPK(long itemID, int lineId, int hitNum, TransactionManager tm_ = null)
        {
            RepairPutHitNumByPKData(itemID, lineId, hitNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutHitNumByPKAsync(long itemID, int lineId, int hitNum, TransactionManager tm_ = null)
        {
            RepairPutHitNumByPKData(itemID, lineId, hitNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutHitNumByPKData(long itemID, int lineId, int hitNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `HitNum` = @HitNum  WHERE `ItemID` = @ItemID AND `LineId` = @LineId";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@HitNum", hitNum, MySqlDbType.Byte),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "hitNum">重复数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutHitNum(int hitNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `HitNum` = @HitNum";
            var parameter_ = Database.CreateInParameter("@HitNum", hitNum, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutHitNumAsync(int hitNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `HitNum` = @HitNum";
            var parameter_ = Database.CreateInParameter("@HitNum", hitNum, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutHitNum
        #region PutMultip
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "lineId">线编码</param>
        /// /// <param name = "multip">倍率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutMultipByPK(long itemID, int lineId, int multip, TransactionManager tm_ = null)
        {
            RepairPutMultipByPKData(itemID, lineId, multip, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutMultipByPKAsync(long itemID, int lineId, int multip, TransactionManager tm_ = null)
        {
            RepairPutMultipByPKData(itemID, lineId, multip, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutMultipByPKData(long itemID, int lineId, int multip, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Multip` = @Multip  WHERE `ItemID` = @ItemID AND `LineId` = @LineId";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
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
        public bool Set(Gmf_item_lineEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.ItemID, item.LineId) == null)
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
        public async Task<bool> SetAsync(Gmf_item_lineEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.ItemID, item.LineId) == null)
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
        /// /// <param name = "lineId">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public Gmf_item_lineEO GetByPK(long itemID, int lineId, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(itemID, lineId, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, Gmf_item_lineEO.MapDataReader);
        }
        public async Task<Gmf_item_lineEO> GetByPKAsync(long itemID, int lineId, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(itemID, lineId, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gmf_item_lineEO.MapDataReader);
        }
        private void RepairGetByPKData(long itemID, int lineId, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`ItemID` = @ItemID AND `LineId` = @LineId", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 ItemID（字段）
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "lineId">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetItemIDByPK(long itemID, int lineId, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
            };
            return (long)GetScalar("`ItemID`", "`ItemID` = @ItemID AND `LineId` = @LineId", paras_, tm_);
        }
        public async Task<long> GetItemIDByPKAsync(long itemID, int lineId, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
            };
            return (long)await GetScalarAsync("`ItemID`", "`ItemID` = @ItemID AND `LineId` = @LineId", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 LineId（字段）
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "lineId">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetLineIdByPK(long itemID, int lineId, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
            };
            return (int)GetScalar("`LineId`", "`ItemID` = @ItemID AND `LineId` = @LineId", paras_, tm_);
        }
        public async Task<int> GetLineIdByPKAsync(long itemID, int lineId, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
            };
            return (int)await GetScalarAsync("`LineId`", "`ItemID` = @ItemID AND `LineId` = @LineId", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 HitId（字段）
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "lineId">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetHitIdByPK(long itemID, int lineId, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
            };
            return (int)GetScalar("`HitId`", "`ItemID` = @ItemID AND `LineId` = @LineId", paras_, tm_);
        }
        public async Task<int> GetHitIdByPKAsync(long itemID, int lineId, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
            };
            return (int)await GetScalarAsync("`HitId`", "`ItemID` = @ItemID AND `LineId` = @LineId", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 HitNum（字段）
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "lineId">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetHitNumByPK(long itemID, int lineId, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
            };
            return (int)GetScalar("`HitNum`", "`ItemID` = @ItemID AND `LineId` = @LineId", paras_, tm_);
        }
        public async Task<int> GetHitNumByPKAsync(long itemID, int lineId, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
            };
            return (int)await GetScalarAsync("`HitNum`", "`ItemID` = @ItemID AND `LineId` = @LineId", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Multip（字段）
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "lineId">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetMultipByPK(long itemID, int lineId, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
            };
            return (int)GetScalar("`Multip`", "`ItemID` = @ItemID AND `LineId` = @LineId", paras_, tm_);
        }
        public async Task<int> GetMultipByPKAsync(long itemID, int lineId, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
                Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte),
            };
            return (int)await GetScalarAsync("`Multip`", "`ItemID` = @ItemID AND `LineId` = @LineId", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByItemID

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByItemID(long itemID)
        {
            return GetByItemID(itemID, 0, string.Empty, null);
        }
        public async Task<List<Gmf_item_lineEO>> GetByItemIDAsync(long itemID)
        {
            return await GetByItemIDAsync(itemID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByItemID(long itemID, TransactionManager tm_)
        {
            return GetByItemID(itemID, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_lineEO>> GetByItemIDAsync(long itemID, TransactionManager tm_)
        {
            return await GetByItemIDAsync(itemID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByItemID(long itemID, int top_)
        {
            return GetByItemID(itemID, top_, string.Empty, null);
        }
        public async Task<List<Gmf_item_lineEO>> GetByItemIDAsync(long itemID, int top_)
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
        public List<Gmf_item_lineEO> GetByItemID(long itemID, int top_, TransactionManager tm_)
        {
            return GetByItemID(itemID, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_lineEO>> GetByItemIDAsync(long itemID, int top_, TransactionManager tm_)
        {
            return await GetByItemIDAsync(itemID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByItemID(long itemID, string sort_)
        {
            return GetByItemID(itemID, 0, sort_, null);
        }
        public async Task<List<Gmf_item_lineEO>> GetByItemIDAsync(long itemID, string sort_)
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
        public List<Gmf_item_lineEO> GetByItemID(long itemID, string sort_, TransactionManager tm_)
        {
            return GetByItemID(itemID, 0, sort_, tm_);
        }
        public async Task<List<Gmf_item_lineEO>> GetByItemIDAsync(long itemID, string sort_, TransactionManager tm_)
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
        public List<Gmf_item_lineEO> GetByItemID(long itemID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_item_lineEO.MapDataReader);
        }
        public async Task<List<Gmf_item_lineEO>> GetByItemIDAsync(long itemID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_item_lineEO.MapDataReader);
        }
        #endregion // GetByItemID
        #region GetByLineId

        /// <summary>
        /// 按 LineId（字段） 查询
        /// </summary>
        /// /// <param name = "lineId">线编码</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByLineId(int lineId)
        {
            return GetByLineId(lineId, 0, string.Empty, null);
        }
        public async Task<List<Gmf_item_lineEO>> GetByLineIdAsync(int lineId)
        {
            return await GetByLineIdAsync(lineId, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 LineId（字段） 查询
        /// </summary>
        /// /// <param name = "lineId">线编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByLineId(int lineId, TransactionManager tm_)
        {
            return GetByLineId(lineId, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_lineEO>> GetByLineIdAsync(int lineId, TransactionManager tm_)
        {
            return await GetByLineIdAsync(lineId, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 LineId（字段） 查询
        /// </summary>
        /// /// <param name = "lineId">线编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByLineId(int lineId, int top_)
        {
            return GetByLineId(lineId, top_, string.Empty, null);
        }
        public async Task<List<Gmf_item_lineEO>> GetByLineIdAsync(int lineId, int top_)
        {
            return await GetByLineIdAsync(lineId, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 LineId（字段） 查询
        /// </summary>
        /// /// <param name = "lineId">线编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByLineId(int lineId, int top_, TransactionManager tm_)
        {
            return GetByLineId(lineId, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_lineEO>> GetByLineIdAsync(int lineId, int top_, TransactionManager tm_)
        {
            return await GetByLineIdAsync(lineId, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 LineId（字段） 查询
        /// </summary>
        /// /// <param name = "lineId">线编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByLineId(int lineId, string sort_)
        {
            return GetByLineId(lineId, 0, sort_, null);
        }
        public async Task<List<Gmf_item_lineEO>> GetByLineIdAsync(int lineId, string sort_)
        {
            return await GetByLineIdAsync(lineId, 0, sort_, null);
        }

        /// <summary>
        /// 按 LineId（字段） 查询
        /// </summary>
        /// /// <param name = "lineId">线编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByLineId(int lineId, string sort_, TransactionManager tm_)
        {
            return GetByLineId(lineId, 0, sort_, tm_);
        }
        public async Task<List<Gmf_item_lineEO>> GetByLineIdAsync(int lineId, string sort_, TransactionManager tm_)
        {
            return await GetByLineIdAsync(lineId, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 LineId（字段） 查询
        /// </summary>
        /// /// <param name = "lineId">线编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByLineId(int lineId, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`LineId` = @LineId", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_item_lineEO.MapDataReader);
        }
        public async Task<List<Gmf_item_lineEO>> GetByLineIdAsync(int lineId, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`LineId` = @LineId", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@LineId", lineId, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_item_lineEO.MapDataReader);
        }
        #endregion // GetByLineId
        #region GetByHitId

        /// <summary>
        /// 按 HitId（字段） 查询
        /// </summary>
        /// /// <param name = "hitId">Symbol编码</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByHitId(int hitId)
        {
            return GetByHitId(hitId, 0, string.Empty, null);
        }
        public async Task<List<Gmf_item_lineEO>> GetByHitIdAsync(int hitId)
        {
            return await GetByHitIdAsync(hitId, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 HitId（字段） 查询
        /// </summary>
        /// /// <param name = "hitId">Symbol编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByHitId(int hitId, TransactionManager tm_)
        {
            return GetByHitId(hitId, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_lineEO>> GetByHitIdAsync(int hitId, TransactionManager tm_)
        {
            return await GetByHitIdAsync(hitId, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 HitId（字段） 查询
        /// </summary>
        /// /// <param name = "hitId">Symbol编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByHitId(int hitId, int top_)
        {
            return GetByHitId(hitId, top_, string.Empty, null);
        }
        public async Task<List<Gmf_item_lineEO>> GetByHitIdAsync(int hitId, int top_)
        {
            return await GetByHitIdAsync(hitId, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 HitId（字段） 查询
        /// </summary>
        /// /// <param name = "hitId">Symbol编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByHitId(int hitId, int top_, TransactionManager tm_)
        {
            return GetByHitId(hitId, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_lineEO>> GetByHitIdAsync(int hitId, int top_, TransactionManager tm_)
        {
            return await GetByHitIdAsync(hitId, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 HitId（字段） 查询
        /// </summary>
        /// /// <param name = "hitId">Symbol编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByHitId(int hitId, string sort_)
        {
            return GetByHitId(hitId, 0, sort_, null);
        }
        public async Task<List<Gmf_item_lineEO>> GetByHitIdAsync(int hitId, string sort_)
        {
            return await GetByHitIdAsync(hitId, 0, sort_, null);
        }

        /// <summary>
        /// 按 HitId（字段） 查询
        /// </summary>
        /// /// <param name = "hitId">Symbol编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByHitId(int hitId, string sort_, TransactionManager tm_)
        {
            return GetByHitId(hitId, 0, sort_, tm_);
        }
        public async Task<List<Gmf_item_lineEO>> GetByHitIdAsync(int hitId, string sort_, TransactionManager tm_)
        {
            return await GetByHitIdAsync(hitId, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 HitId（字段） 查询
        /// </summary>
        /// /// <param name = "hitId">Symbol编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByHitId(int hitId, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`HitId` = @HitId", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@HitId", hitId, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_item_lineEO.MapDataReader);
        }
        public async Task<List<Gmf_item_lineEO>> GetByHitIdAsync(int hitId, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`HitId` = @HitId", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@HitId", hitId, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_item_lineEO.MapDataReader);
        }
        #endregion // GetByHitId
        #region GetByHitNum

        /// <summary>
        /// 按 HitNum（字段） 查询
        /// </summary>
        /// /// <param name = "hitNum">重复数量</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByHitNum(int hitNum)
        {
            return GetByHitNum(hitNum, 0, string.Empty, null);
        }
        public async Task<List<Gmf_item_lineEO>> GetByHitNumAsync(int hitNum)
        {
            return await GetByHitNumAsync(hitNum, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 HitNum（字段） 查询
        /// </summary>
        /// /// <param name = "hitNum">重复数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByHitNum(int hitNum, TransactionManager tm_)
        {
            return GetByHitNum(hitNum, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_lineEO>> GetByHitNumAsync(int hitNum, TransactionManager tm_)
        {
            return await GetByHitNumAsync(hitNum, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 HitNum（字段） 查询
        /// </summary>
        /// /// <param name = "hitNum">重复数量</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByHitNum(int hitNum, int top_)
        {
            return GetByHitNum(hitNum, top_, string.Empty, null);
        }
        public async Task<List<Gmf_item_lineEO>> GetByHitNumAsync(int hitNum, int top_)
        {
            return await GetByHitNumAsync(hitNum, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 HitNum（字段） 查询
        /// </summary>
        /// /// <param name = "hitNum">重复数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByHitNum(int hitNum, int top_, TransactionManager tm_)
        {
            return GetByHitNum(hitNum, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_lineEO>> GetByHitNumAsync(int hitNum, int top_, TransactionManager tm_)
        {
            return await GetByHitNumAsync(hitNum, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 HitNum（字段） 查询
        /// </summary>
        /// /// <param name = "hitNum">重复数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByHitNum(int hitNum, string sort_)
        {
            return GetByHitNum(hitNum, 0, sort_, null);
        }
        public async Task<List<Gmf_item_lineEO>> GetByHitNumAsync(int hitNum, string sort_)
        {
            return await GetByHitNumAsync(hitNum, 0, sort_, null);
        }

        /// <summary>
        /// 按 HitNum（字段） 查询
        /// </summary>
        /// /// <param name = "hitNum">重复数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByHitNum(int hitNum, string sort_, TransactionManager tm_)
        {
            return GetByHitNum(hitNum, 0, sort_, tm_);
        }
        public async Task<List<Gmf_item_lineEO>> GetByHitNumAsync(int hitNum, string sort_, TransactionManager tm_)
        {
            return await GetByHitNumAsync(hitNum, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 HitNum（字段） 查询
        /// </summary>
        /// /// <param name = "hitNum">重复数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByHitNum(int hitNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`HitNum` = @HitNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@HitNum", hitNum, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_item_lineEO.MapDataReader);
        }
        public async Task<List<Gmf_item_lineEO>> GetByHitNumAsync(int hitNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`HitNum` = @HitNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@HitNum", hitNum, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_item_lineEO.MapDataReader);
        }
        #endregion // GetByHitNum
        #region GetByMultip

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByMultip(int multip)
        {
            return GetByMultip(multip, 0, string.Empty, null);
        }
        public async Task<List<Gmf_item_lineEO>> GetByMultipAsync(int multip)
        {
            return await GetByMultipAsync(multip, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByMultip(int multip, TransactionManager tm_)
        {
            return GetByMultip(multip, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_lineEO>> GetByMultipAsync(int multip, TransactionManager tm_)
        {
            return await GetByMultipAsync(multip, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByMultip(int multip, int top_)
        {
            return GetByMultip(multip, top_, string.Empty, null);
        }
        public async Task<List<Gmf_item_lineEO>> GetByMultipAsync(int multip, int top_)
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
        public List<Gmf_item_lineEO> GetByMultip(int multip, int top_, TransactionManager tm_)
        {
            return GetByMultip(multip, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_item_lineEO>> GetByMultipAsync(int multip, int top_, TransactionManager tm_)
        {
            return await GetByMultipAsync(multip, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_item_lineEO> GetByMultip(int multip, string sort_)
        {
            return GetByMultip(multip, 0, sort_, null);
        }
        public async Task<List<Gmf_item_lineEO>> GetByMultipAsync(int multip, string sort_)
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
        public List<Gmf_item_lineEO> GetByMultip(int multip, string sort_, TransactionManager tm_)
        {
            return GetByMultip(multip, 0, sort_, tm_);
        }
        public async Task<List<Gmf_item_lineEO>> GetByMultipAsync(int multip, string sort_, TransactionManager tm_)
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
        public List<Gmf_item_lineEO> GetByMultip(int multip, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_item_lineEO.MapDataReader);
        }
        public async Task<List<Gmf_item_lineEO>> GetByMultipAsync(int multip, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_item_lineEO.MapDataReader);
        }
        #endregion // GetByMultip
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
