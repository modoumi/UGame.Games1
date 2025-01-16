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
    /// 【表 gmf_item 的实体类】
    /// </summary>
    [DataContract]
    public class Gmf_itemEO : IRowMapper<Gmf_itemEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Gmf_itemEO()
        {
            this.Multip = 0;
            this.BonusNum = 0;
            this.BingoNum = 0;
            this.LineNum = 0;
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
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "ItemID", ItemID }, };
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
        /// 倍率
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 2)]
        public int Multip { get; set; }
        /// <summary>
        /// Bonus（数量）
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 3)]
        public int BonusNum { get; set; }
        /// <summary>
        /// Bingo图标数量
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 4)]
        public int BingoNum { get; set; }
        /// <summary>
        /// 中奖线数量
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 5)]
        public int LineNum { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public Gmf_itemEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static Gmf_itemEO MapDataReader(IDataReader reader)
        {
            Gmf_itemEO ret = new Gmf_itemEO();
            ret.ItemID = reader.ToInt64("ItemID");
            ret.OriginalItemID = ret.ItemID;
            ret.Multip = reader.ToInt32("Multip");
            ret.BonusNum = reader.ToInt32("BonusNum");
            ret.BingoNum = reader.ToInt32("BingoNum");
            ret.LineNum = reader.ToInt32("LineNum");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// 
    /// 【表 gmf_item 的操作类】
    /// </summary>
    public class Gmf_itemMO : MySqlTableMO<Gmf_itemEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`gmf_item`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public Gmf_itemMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public Gmf_itemMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public Gmf_itemMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(Gmf_itemEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(Gmf_itemEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(Gmf_itemEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`ItemID`, `Multip`, `BonusNum`, `BingoNum`, `LineNum`) VALUE (@ItemID, @Multip, @BonusNum, @BingoNum, @LineNum);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int64),
                Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Int32),
                Database.CreateInParameter("@BonusNum", item.BonusNum, MySqlDbType.Byte),
                Database.CreateInParameter("@BingoNum", item.BingoNum, MySqlDbType.Byte),
                Database.CreateInParameter("@LineNum", item.LineNum, MySqlDbType.Byte),
            };
        }
        public int AddByBatch(IEnumerable<Gmf_itemEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<Gmf_itemEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gmf_itemEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`ItemID`, `Multip`, `BonusNum`, `BingoNum`, `LineNum`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"({item.ItemID},{item.Multip},{item.BonusNum},{item.BingoNum},{item.LineNum}),");
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
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(long itemID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(itemID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(long itemID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(itemID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(long itemID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `ItemID` = @ItemID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(Gmf_itemEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.ItemID, tm_);
        }
        public async Task<int> RemoveAsync(Gmf_itemEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.ItemID, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
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
        #region RemoveByBonusNum
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bonusNum">Bonus（数量）</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBonusNum(int bonusNum, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusNumData(bonusNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBonusNumAsync(int bonusNum, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusNumData(bonusNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBonusNumData(int bonusNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BonusNum` = @BonusNum";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusNum", bonusNum, MySqlDbType.Byte));
        }
        #endregion // RemoveByBonusNum
        #region RemoveByBingoNum
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoNum">Bingo图标数量</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBingoNum(int bingoNum, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoNumData(bingoNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBingoNumAsync(int bingoNum, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoNumData(bingoNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBingoNumData(int bingoNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BingoNum` = @BingoNum";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoNum", bingoNum, MySqlDbType.Byte));
        }
        #endregion // RemoveByBingoNum
        #region RemoveByLineNum
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "lineNum">中奖线数量</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByLineNum(int lineNum, TransactionManager tm_ = null)
        {
            RepairRemoveByLineNumData(lineNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByLineNumAsync(int lineNum, TransactionManager tm_ = null)
        {
            RepairRemoveByLineNumData(lineNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByLineNumData(int lineNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `LineNum` = @LineNum";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Byte));
        }
        #endregion // RemoveByLineNum
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
        public int Put(Gmf_itemEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(Gmf_itemEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(Gmf_itemEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID, `Multip` = @Multip, `BonusNum` = @BonusNum, `BingoNum` = @BingoNum, `LineNum` = @LineNum WHERE `ItemID` = @ItemID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int64),
                Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Int32),
                Database.CreateInParameter("@BonusNum", item.BonusNum, MySqlDbType.Byte),
                Database.CreateInParameter("@BingoNum", item.BingoNum, MySqlDbType.Byte),
                Database.CreateInParameter("@LineNum", item.LineNum, MySqlDbType.Byte),
                Database.CreateInParameter("@ItemID_Original", item.HasOriginal ? item.OriginalItemID : item.ItemID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<Gmf_itemEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<Gmf_itemEO> items, TransactionManager tm_ = null)
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
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(long itemID, string set_, params object[] values_)
        {
            return Put(set_, "`ItemID` = @ItemID", ConcatValues(values_, itemID));
        }
        public async Task<int> PutByPKAsync(long itemID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`ItemID` = @ItemID", ConcatValues(values_, itemID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(long itemID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`ItemID` = @ItemID", tm_, ConcatValues(values_, itemID));
        }
        public async Task<int> PutByPKAsync(long itemID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`ItemID` = @ItemID", tm_, ConcatValues(values_, itemID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(long itemID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
            };
            return Put(set_, "`ItemID` = @ItemID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(long itemID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
            };
            return await PutAsync(set_, "`ItemID` = @ItemID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutMultip
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "multip">倍率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutMultipByPK(long itemID, int multip, TransactionManager tm_ = null)
        {
            RepairPutMultipByPKData(itemID, multip, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutMultipByPKAsync(long itemID, int multip, TransactionManager tm_ = null)
        {
            RepairPutMultipByPKData(itemID, multip, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutMultipByPKData(long itemID, int multip, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Multip` = @Multip  WHERE `ItemID` = @ItemID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
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
        #region PutBonusNum
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "bonusNum">Bonus（数量）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusNumByPK(long itemID, int bonusNum, TransactionManager tm_ = null)
        {
            RepairPutBonusNumByPKData(itemID, bonusNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBonusNumByPKAsync(long itemID, int bonusNum, TransactionManager tm_ = null)
        {
            RepairPutBonusNumByPKData(itemID, bonusNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBonusNumByPKData(long itemID, int bonusNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BonusNum` = @BonusNum  WHERE `ItemID` = @ItemID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BonusNum", bonusNum, MySqlDbType.Byte),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bonusNum">Bonus（数量）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusNum(int bonusNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusNum` = @BonusNum";
            var parameter_ = Database.CreateInParameter("@BonusNum", bonusNum, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBonusNumAsync(int bonusNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusNum` = @BonusNum";
            var parameter_ = Database.CreateInParameter("@BonusNum", bonusNum, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBonusNum
        #region PutBingoNum
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "bingoNum">Bingo图标数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoNumByPK(long itemID, int bingoNum, TransactionManager tm_ = null)
        {
            RepairPutBingoNumByPKData(itemID, bingoNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoNumByPKAsync(long itemID, int bingoNum, TransactionManager tm_ = null)
        {
            RepairPutBingoNumByPKData(itemID, bingoNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoNumByPKData(long itemID, int bingoNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoNum` = @BingoNum  WHERE `ItemID` = @ItemID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoNum", bingoNum, MySqlDbType.Byte),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoNum">Bingo图标数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoNum(int bingoNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoNum` = @BingoNum";
            var parameter_ = Database.CreateInParameter("@BingoNum", bingoNum, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBingoNumAsync(int bingoNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoNum` = @BingoNum";
            var parameter_ = Database.CreateInParameter("@BingoNum", bingoNum, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBingoNum
        #region PutLineNum
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// /// <param name = "lineNum">中奖线数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutLineNumByPK(long itemID, int lineNum, TransactionManager tm_ = null)
        {
            RepairPutLineNumByPKData(itemID, lineNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutLineNumByPKAsync(long itemID, int lineNum, TransactionManager tm_ = null)
        {
            RepairPutLineNumByPKData(itemID, lineNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutLineNumByPKData(long itemID, int lineNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `LineNum` = @LineNum  WHERE `ItemID` = @ItemID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Byte),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "lineNum">中奖线数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutLineNum(int lineNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `LineNum` = @LineNum";
            var parameter_ = Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutLineNumAsync(int lineNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `LineNum` = @LineNum";
            var parameter_ = Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutLineNum
        #endregion // PutXXX
        #endregion // Put

        #region Set

        /// <summary>
        /// 插入或者更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>true:插入操作；false:更新操作</return>
        public bool Set(Gmf_itemEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.ItemID) == null)
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
        public async Task<bool> SetAsync(Gmf_itemEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.ItemID) == null)
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
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public Gmf_itemEO GetByPK(long itemID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(itemID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, Gmf_itemEO.MapDataReader);
        }
        public async Task<Gmf_itemEO> GetByPKAsync(long itemID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(itemID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gmf_itemEO.MapDataReader);
        }
        private void RepairGetByPKData(long itemID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`ItemID` = @ItemID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 Multip（字段）
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetMultipByPK(long itemID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
            };
            return (int)GetScalar("`Multip`", "`ItemID` = @ItemID", paras_, tm_);
        }
        public async Task<int> GetMultipByPKAsync(long itemID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
            };
            return (int)await GetScalarAsync("`Multip`", "`ItemID` = @ItemID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BonusNum（字段）
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetBonusNumByPK(long itemID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
            };
            return (int)GetScalar("`BonusNum`", "`ItemID` = @ItemID", paras_, tm_);
        }
        public async Task<int> GetBonusNumByPKAsync(long itemID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
            };
            return (int)await GetScalarAsync("`BonusNum`", "`ItemID` = @ItemID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoNum（字段）
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetBingoNumByPK(long itemID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
            };
            return (int)GetScalar("`BingoNum`", "`ItemID` = @ItemID", paras_, tm_);
        }
        public async Task<int> GetBingoNumByPKAsync(long itemID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
            };
            return (int)await GetScalarAsync("`BingoNum`", "`ItemID` = @ItemID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 LineNum（字段）
        /// </summary>
        /// /// <param name = "itemID">项编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetLineNumByPK(long itemID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
            };
            return (int)GetScalar("`LineNum`", "`ItemID` = @ItemID", paras_, tm_);
        }
        public async Task<int> GetLineNumByPKAsync(long itemID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int64),
            };
            return (int)await GetScalarAsync("`LineNum`", "`ItemID` = @ItemID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByMultip

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByMultip(int multip)
        {
            return GetByMultip(multip, 0, string.Empty, null);
        }
        public async Task<List<Gmf_itemEO>> GetByMultipAsync(int multip)
        {
            return await GetByMultipAsync(multip, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByMultip(int multip, TransactionManager tm_)
        {
            return GetByMultip(multip, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_itemEO>> GetByMultipAsync(int multip, TransactionManager tm_)
        {
            return await GetByMultipAsync(multip, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByMultip(int multip, int top_)
        {
            return GetByMultip(multip, top_, string.Empty, null);
        }
        public async Task<List<Gmf_itemEO>> GetByMultipAsync(int multip, int top_)
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
        public List<Gmf_itemEO> GetByMultip(int multip, int top_, TransactionManager tm_)
        {
            return GetByMultip(multip, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_itemEO>> GetByMultipAsync(int multip, int top_, TransactionManager tm_)
        {
            return await GetByMultipAsync(multip, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Multip（字段） 查询
        /// </summary>
        /// /// <param name = "multip">倍率</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByMultip(int multip, string sort_)
        {
            return GetByMultip(multip, 0, sort_, null);
        }
        public async Task<List<Gmf_itemEO>> GetByMultipAsync(int multip, string sort_)
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
        public List<Gmf_itemEO> GetByMultip(int multip, string sort_, TransactionManager tm_)
        {
            return GetByMultip(multip, 0, sort_, tm_);
        }
        public async Task<List<Gmf_itemEO>> GetByMultipAsync(int multip, string sort_, TransactionManager tm_)
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
        public List<Gmf_itemEO> GetByMultip(int multip, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_itemEO.MapDataReader);
        }
        public async Task<List<Gmf_itemEO>> GetByMultipAsync(int multip, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_itemEO.MapDataReader);
        }
        #endregion // GetByMultip
        #region GetByBonusNum

        /// <summary>
        /// 按 BonusNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusNum">Bonus（数量）</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByBonusNum(int bonusNum)
        {
            return GetByBonusNum(bonusNum, 0, string.Empty, null);
        }
        public async Task<List<Gmf_itemEO>> GetByBonusNumAsync(int bonusNum)
        {
            return await GetByBonusNumAsync(bonusNum, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusNum">Bonus（数量）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByBonusNum(int bonusNum, TransactionManager tm_)
        {
            return GetByBonusNum(bonusNum, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_itemEO>> GetByBonusNumAsync(int bonusNum, TransactionManager tm_)
        {
            return await GetByBonusNumAsync(bonusNum, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusNum">Bonus（数量）</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByBonusNum(int bonusNum, int top_)
        {
            return GetByBonusNum(bonusNum, top_, string.Empty, null);
        }
        public async Task<List<Gmf_itemEO>> GetByBonusNumAsync(int bonusNum, int top_)
        {
            return await GetByBonusNumAsync(bonusNum, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusNum">Bonus（数量）</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByBonusNum(int bonusNum, int top_, TransactionManager tm_)
        {
            return GetByBonusNum(bonusNum, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_itemEO>> GetByBonusNumAsync(int bonusNum, int top_, TransactionManager tm_)
        {
            return await GetByBonusNumAsync(bonusNum, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusNum">Bonus（数量）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByBonusNum(int bonusNum, string sort_)
        {
            return GetByBonusNum(bonusNum, 0, sort_, null);
        }
        public async Task<List<Gmf_itemEO>> GetByBonusNumAsync(int bonusNum, string sort_)
        {
            return await GetByBonusNumAsync(bonusNum, 0, sort_, null);
        }

        /// <summary>
        /// 按 BonusNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusNum">Bonus（数量）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByBonusNum(int bonusNum, string sort_, TransactionManager tm_)
        {
            return GetByBonusNum(bonusNum, 0, sort_, tm_);
        }
        public async Task<List<Gmf_itemEO>> GetByBonusNumAsync(int bonusNum, string sort_, TransactionManager tm_)
        {
            return await GetByBonusNumAsync(bonusNum, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BonusNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusNum">Bonus（数量）</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByBonusNum(int bonusNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusNum` = @BonusNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusNum", bonusNum, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_itemEO.MapDataReader);
        }
        public async Task<List<Gmf_itemEO>> GetByBonusNumAsync(int bonusNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusNum` = @BonusNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusNum", bonusNum, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_itemEO.MapDataReader);
        }
        #endregion // GetByBonusNum
        #region GetByBingoNum

        /// <summary>
        /// 按 BingoNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoNum">Bingo图标数量</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByBingoNum(int bingoNum)
        {
            return GetByBingoNum(bingoNum, 0, string.Empty, null);
        }
        public async Task<List<Gmf_itemEO>> GetByBingoNumAsync(int bingoNum)
        {
            return await GetByBingoNumAsync(bingoNum, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoNum">Bingo图标数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByBingoNum(int bingoNum, TransactionManager tm_)
        {
            return GetByBingoNum(bingoNum, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_itemEO>> GetByBingoNumAsync(int bingoNum, TransactionManager tm_)
        {
            return await GetByBingoNumAsync(bingoNum, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoNum">Bingo图标数量</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByBingoNum(int bingoNum, int top_)
        {
            return GetByBingoNum(bingoNum, top_, string.Empty, null);
        }
        public async Task<List<Gmf_itemEO>> GetByBingoNumAsync(int bingoNum, int top_)
        {
            return await GetByBingoNumAsync(bingoNum, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoNum">Bingo图标数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByBingoNum(int bingoNum, int top_, TransactionManager tm_)
        {
            return GetByBingoNum(bingoNum, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_itemEO>> GetByBingoNumAsync(int bingoNum, int top_, TransactionManager tm_)
        {
            return await GetByBingoNumAsync(bingoNum, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoNum">Bingo图标数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByBingoNum(int bingoNum, string sort_)
        {
            return GetByBingoNum(bingoNum, 0, sort_, null);
        }
        public async Task<List<Gmf_itemEO>> GetByBingoNumAsync(int bingoNum, string sort_)
        {
            return await GetByBingoNumAsync(bingoNum, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoNum">Bingo图标数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByBingoNum(int bingoNum, string sort_, TransactionManager tm_)
        {
            return GetByBingoNum(bingoNum, 0, sort_, tm_);
        }
        public async Task<List<Gmf_itemEO>> GetByBingoNumAsync(int bingoNum, string sort_, TransactionManager tm_)
        {
            return await GetByBingoNumAsync(bingoNum, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoNum">Bingo图标数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByBingoNum(int bingoNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoNum` = @BingoNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoNum", bingoNum, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_itemEO.MapDataReader);
        }
        public async Task<List<Gmf_itemEO>> GetByBingoNumAsync(int bingoNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoNum` = @BingoNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoNum", bingoNum, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_itemEO.MapDataReader);
        }
        #endregion // GetByBingoNum
        #region GetByLineNum

        /// <summary>
        /// 按 LineNum（字段） 查询
        /// </summary>
        /// /// <param name = "lineNum">中奖线数量</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByLineNum(int lineNum)
        {
            return GetByLineNum(lineNum, 0, string.Empty, null);
        }
        public async Task<List<Gmf_itemEO>> GetByLineNumAsync(int lineNum)
        {
            return await GetByLineNumAsync(lineNum, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 LineNum（字段） 查询
        /// </summary>
        /// /// <param name = "lineNum">中奖线数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByLineNum(int lineNum, TransactionManager tm_)
        {
            return GetByLineNum(lineNum, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_itemEO>> GetByLineNumAsync(int lineNum, TransactionManager tm_)
        {
            return await GetByLineNumAsync(lineNum, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 LineNum（字段） 查询
        /// </summary>
        /// /// <param name = "lineNum">中奖线数量</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByLineNum(int lineNum, int top_)
        {
            return GetByLineNum(lineNum, top_, string.Empty, null);
        }
        public async Task<List<Gmf_itemEO>> GetByLineNumAsync(int lineNum, int top_)
        {
            return await GetByLineNumAsync(lineNum, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 LineNum（字段） 查询
        /// </summary>
        /// /// <param name = "lineNum">中奖线数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByLineNum(int lineNum, int top_, TransactionManager tm_)
        {
            return GetByLineNum(lineNum, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_itemEO>> GetByLineNumAsync(int lineNum, int top_, TransactionManager tm_)
        {
            return await GetByLineNumAsync(lineNum, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 LineNum（字段） 查询
        /// </summary>
        /// /// <param name = "lineNum">中奖线数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByLineNum(int lineNum, string sort_)
        {
            return GetByLineNum(lineNum, 0, sort_, null);
        }
        public async Task<List<Gmf_itemEO>> GetByLineNumAsync(int lineNum, string sort_)
        {
            return await GetByLineNumAsync(lineNum, 0, sort_, null);
        }

        /// <summary>
        /// 按 LineNum（字段） 查询
        /// </summary>
        /// /// <param name = "lineNum">中奖线数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByLineNum(int lineNum, string sort_, TransactionManager tm_)
        {
            return GetByLineNum(lineNum, 0, sort_, tm_);
        }
        public async Task<List<Gmf_itemEO>> GetByLineNumAsync(int lineNum, string sort_, TransactionManager tm_)
        {
            return await GetByLineNumAsync(lineNum, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 LineNum（字段） 查询
        /// </summary>
        /// /// <param name = "lineNum">中奖线数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_itemEO> GetByLineNum(int lineNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`LineNum` = @LineNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_itemEO.MapDataReader);
        }
        public async Task<List<Gmf_itemEO>> GetByLineNumAsync(int lineNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`LineNum` = @LineNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_itemEO.MapDataReader);
        }
        #endregion // GetByLineNum
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
