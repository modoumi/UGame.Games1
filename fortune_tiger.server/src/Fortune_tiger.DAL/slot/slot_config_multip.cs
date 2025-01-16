/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-08-29 18: 49:15
 ******************************************************/
using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.Serialization;
using System.Text;
using TinyFx;
using TinyFx.Data;
using TinyFx.Data.MySql;

namespace Fortune_tiger.DAL
{
    #region EO
    /// <summary>
    /// 倍率表
    /// 【表 slot_config_multip 的实体类】
    /// </summary>
    [DataContract]
    public class Slot_config_multipEO : IRowMapper<Slot_config_multipEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Slot_config_multipEO()
        {
            this.Multip3 = 0;
            this.Multip4 = 0;
            this.Multip5 = 0;
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private string _originalAppID;
        /// <summary>
        /// 【数据库中的原始主键 AppID 值的副本，用于主键值更新】
        /// </summary>
        public string OriginalAppID
        {
            get { return _originalAppID; }
            set { HasOriginal = true; _originalAppID = value; }
        }

        private int _originalItemID;
        /// <summary>
        /// 【数据库中的原始主键 ItemID 值的副本，用于主键值更新】
        /// </summary>
        public int OriginalItemID
        {
            get { return _originalItemID; }
            set { HasOriginal = true; _originalItemID = value; }
        }

        private string _originalOperatorID;
        /// <summary>
        /// 【数据库中的原始主键 OperatorID 值的副本，用于主键值更新】
        /// </summary>
        public string OriginalOperatorID
        {
            get { return _originalOperatorID; }
            set { HasOriginal = true; _originalOperatorID = value; }
        }

        private string _originalCurrencyID;
        /// <summary>
        /// 【数据库中的原始主键 CurrencyID 值的副本，用于主键值更新】
        /// </summary>
        public string OriginalCurrencyID
        {
            get { return _originalCurrencyID; }
            set { HasOriginal = true; _originalCurrencyID = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "AppID", AppID }, { "ItemID", ItemID }, { "OperatorID", OperatorID }, { "CurrencyID", CurrencyID }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// appid
        /// 【主键 varchar(50)】
        /// </summary>
        [DataMember(Order = 1)]
        public string AppID { get; set; }
        /// <summary>
        /// 主键
        /// 【主键 int】
        /// </summary>
        [DataMember(Order = 2)]
        public int ItemID { get; set; }
        /// <summary>
        /// 运营商编码
        /// 【主键 varchar(50)】
        /// </summary>
        [DataMember(Order = 3)]
        public string OperatorID { get; set; }
        /// <summary>
        /// 货币编码（ISO 4217大写）
        /// 【主键 varchar(5)】
        /// </summary>
        [DataMember(Order = 4)]
        public string CurrencyID { get; set; }
        /// <summary>
        /// icon类型1-普通,2-万能,3-scatter
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 5)]
        public int IconType { get; set; }
        /// <summary>
        /// x3倍数
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 6)]
        public int Multip3 { get; set; }
        /// <summary>
        /// x4倍数
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 7)]
        public int Multip4 { get; set; }
        /// <summary>
        /// x5倍数
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 8)]
        public int Multip5 { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public Slot_config_multipEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static Slot_config_multipEO MapDataReader(IDataReader reader)
        {
            Slot_config_multipEO ret = new Slot_config_multipEO();
            ret.AppID = reader.ToString("AppID");
            ret.OriginalAppID = ret.AppID;
            ret.ItemID = reader.ToInt32("ItemID");
            ret.OriginalItemID = ret.ItemID;
            ret.OperatorID = reader.ToString("OperatorID");
            ret.OriginalOperatorID = ret.OperatorID;
            ret.CurrencyID = reader.ToString("CurrencyID");
            ret.OriginalCurrencyID = ret.CurrencyID;
            ret.IconType = reader.ToInt32("IconType");
            ret.Multip3 = reader.ToInt32("Multip3");
            ret.Multip4 = reader.ToInt32("Multip4");
            ret.Multip5 = reader.ToInt32("Multip5");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// 倍率表
    /// 【表 slot_config_multip 的操作类】
    /// </summary>
    public class Slot_config_multipMO : MySqlTableMO<Slot_config_multipEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`slot_config_multip`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public Slot_config_multipMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public Slot_config_multipMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public Slot_config_multipMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(Slot_config_multipEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(Slot_config_multipEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(Slot_config_multipEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`AppID`, `ItemID`, `OperatorID`, `CurrencyID`, `IconType`, `Multip3`, `Multip4`, `Multip5`) VALUE (@AppID, @ItemID, @OperatorID, @CurrencyID, @IconType, @Multip3, @Multip4, @Multip5);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
                Database.CreateInParameter("@IconType", item.IconType, MySqlDbType.Int32),
                Database.CreateInParameter("@Multip3", item.Multip3, MySqlDbType.Int32),
                Database.CreateInParameter("@Multip4", item.Multip4, MySqlDbType.Int32),
                Database.CreateInParameter("@Multip5", item.Multip5, MySqlDbType.Int32),
            };
        }
        public int AddByBatch(IEnumerable<Slot_config_multipEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<Slot_config_multipEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<Slot_config_multipEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`AppID`, `ItemID`, `OperatorID`, `CurrencyID`, `IconType`, `Multip3`, `Multip4`, `Multip5`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"('{item.AppID}',{item.ItemID},'{item.OperatorID}','{item.CurrencyID}',{item.IconType},{item.Multip3},{item.Multip4},{item.Multip5}),");
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
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(appID, itemID, operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(appID, itemID, operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(string appID, int itemID, string operatorID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(Slot_config_multipEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.AppID, item.ItemID, item.OperatorID, item.CurrencyID, tm_);
        }
        public async Task<int> RemoveAsync(Slot_config_multipEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.AppID, item.ItemID, item.OperatorID, item.CurrencyID, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
        #region RemoveByAppID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByAppID(string appID, TransactionManager tm_ = null)
        {
            RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByAppIDAsync(string appID, TransactionManager tm_ = null)
        {
            RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByAppIDData(string appID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `AppID` = @AppID";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
        }
        #endregion // RemoveByAppID
        #region RemoveByItemID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "itemID">主键</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByItemID(int itemID, TransactionManager tm_ = null)
        {
            RepairRemoveByItemIDData(itemID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByItemIDAsync(int itemID, TransactionManager tm_ = null)
        {
            RepairRemoveByItemIDData(itemID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByItemIDData(int itemID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `ItemID` = @ItemID";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
        }
        #endregion // RemoveByItemID
        #region RemoveByOperatorID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByOperatorID(string operatorID, TransactionManager tm_ = null)
        {
            RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
        {
            RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByOperatorIDData(string operatorID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
        }
        #endregion // RemoveByOperatorID
        #region RemoveByCurrencyID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
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
            sql_ = $"DELETE FROM {TableName} WHERE `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
        }
        #endregion // RemoveByCurrencyID
        #region RemoveByIconType
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByIconType(int iconType, TransactionManager tm_ = null)
        {
            RepairRemoveByIconTypeData(iconType, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByIconTypeAsync(int iconType, TransactionManager tm_ = null)
        {
            RepairRemoveByIconTypeData(iconType, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByIconTypeData(int iconType, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `IconType` = @IconType";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32));
        }
        #endregion // RemoveByIconType
        #region RemoveByMultip3
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "multip3">x3倍数</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByMultip3(int multip3, TransactionManager tm_ = null)
        {
            RepairRemoveByMultip3Data(multip3, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByMultip3Async(int multip3, TransactionManager tm_ = null)
        {
            RepairRemoveByMultip3Data(multip3, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByMultip3Data(int multip3, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Multip3` = @Multip3";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip3", multip3, MySqlDbType.Int32));
        }
        #endregion // RemoveByMultip3
        #region RemoveByMultip4
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "multip4">x4倍数</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByMultip4(int multip4, TransactionManager tm_ = null)
        {
            RepairRemoveByMultip4Data(multip4, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByMultip4Async(int multip4, TransactionManager tm_ = null)
        {
            RepairRemoveByMultip4Data(multip4, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByMultip4Data(int multip4, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Multip4` = @Multip4";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip4", multip4, MySqlDbType.Int32));
        }
        #endregion // RemoveByMultip4
        #region RemoveByMultip5
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "multip5">x5倍数</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByMultip5(int multip5, TransactionManager tm_ = null)
        {
            RepairRemoveByMultip5Data(multip5, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByMultip5Async(int multip5, TransactionManager tm_ = null)
        {
            RepairRemoveByMultip5Data(multip5, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByMultip5Data(int multip5, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Multip5` = @Multip5";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip5", multip5, MySqlDbType.Int32));
        }
        #endregion // RemoveByMultip5
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
        public int Put(Slot_config_multipEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(Slot_config_multipEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(Slot_config_multipEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `AppID` = @AppID, `ItemID` = @ItemID, `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `IconType` = @IconType, `Multip3` = @Multip3, `Multip4` = @Multip4, `Multip5` = @Multip5 WHERE `AppID` = @AppID_Original AND `ItemID` = @ItemID_Original AND `OperatorID` = @OperatorID_Original AND `CurrencyID` = @CurrencyID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
                Database.CreateInParameter("@IconType", item.IconType, MySqlDbType.Int32),
                Database.CreateInParameter("@Multip3", item.Multip3, MySqlDbType.Int32),
                Database.CreateInParameter("@Multip4", item.Multip4, MySqlDbType.Int32),
                Database.CreateInParameter("@Multip5", item.Multip5, MySqlDbType.Int32),
                Database.CreateInParameter("@AppID_Original", item.HasOriginal ? item.OriginalAppID : item.AppID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID_Original", item.HasOriginal ? item.OriginalItemID : item.ItemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID_Original", item.HasOriginal ? item.OriginalCurrencyID : item.CurrencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<Slot_config_multipEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<Slot_config_multipEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string appID, int itemID, string operatorID, string currencyID, string set_, params object[] values_)
        {
            return Put(set_, "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatValues(values_, appID, itemID, operatorID, currencyID));
        }
        public async Task<int> PutByPKAsync(string appID, int itemID, string operatorID, string currencyID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatValues(values_, appID, itemID, operatorID, currencyID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string appID, int itemID, string operatorID, string currencyID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, appID, itemID, operatorID, currencyID));
        }
        public async Task<int> PutByPKAsync(string appID, int itemID, string operatorID, string currencyID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, appID, itemID, operatorID, currencyID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string appID, int itemID, string operatorID, string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return Put(set_, "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(string appID, int itemID, string operatorID, string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return await PutAsync(set_, "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutAppID

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutAppID(string appID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
            var parameter_ = Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutAppIDAsync(string appID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
            var parameter_ = Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutAppID
        #region PutItemID

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "itemID">主键</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutItemID(int itemID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID";
            var parameter_ = Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutItemIDAsync(int itemID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID";
            var parameter_ = Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutItemID
        #region PutOperatorID

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutOperatorID(string operatorID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
            var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
            var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutOperatorID
        #region PutCurrencyID

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutCurrencyID(string currencyID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
            var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
            var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutCurrencyID
        #region PutIconType
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutIconTypeByPK(string appID, int itemID, string operatorID, string currencyID, int iconType, TransactionManager tm_ = null)
        {
            RepairPutIconTypeByPKData(appID, itemID, operatorID, currencyID, iconType, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutIconTypeByPKAsync(string appID, int itemID, string operatorID, string currencyID, int iconType, TransactionManager tm_ = null)
        {
            RepairPutIconTypeByPKData(appID, itemID, operatorID, currencyID, iconType, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutIconTypeByPKData(string appID, int itemID, string operatorID, string currencyID, int iconType, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `IconType` = @IconType  WHERE `AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutIconType(int iconType, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `IconType` = @IconType";
            var parameter_ = Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutIconTypeAsync(int iconType, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `IconType` = @IconType";
            var parameter_ = Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutIconType
        #region PutMultip3
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// /// <param name = "multip3">x3倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutMultip3ByPK(string appID, int itemID, string operatorID, string currencyID, int multip3, TransactionManager tm_ = null)
        {
            RepairPutMultip3ByPKData(appID, itemID, operatorID, currencyID, multip3, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutMultip3ByPKAsync(string appID, int itemID, string operatorID, string currencyID, int multip3, TransactionManager tm_ = null)
        {
            RepairPutMultip3ByPKData(appID, itemID, operatorID, currencyID, multip3, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutMultip3ByPKData(string appID, int itemID, string operatorID, string currencyID, int multip3, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Multip3` = @Multip3  WHERE `AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Multip3", multip3, MySqlDbType.Int32),
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "multip3">x3倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutMultip3(int multip3, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Multip3` = @Multip3";
            var parameter_ = Database.CreateInParameter("@Multip3", multip3, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutMultip3Async(int multip3, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Multip3` = @Multip3";
            var parameter_ = Database.CreateInParameter("@Multip3", multip3, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutMultip3
        #region PutMultip4
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// /// <param name = "multip4">x4倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutMultip4ByPK(string appID, int itemID, string operatorID, string currencyID, int multip4, TransactionManager tm_ = null)
        {
            RepairPutMultip4ByPKData(appID, itemID, operatorID, currencyID, multip4, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutMultip4ByPKAsync(string appID, int itemID, string operatorID, string currencyID, int multip4, TransactionManager tm_ = null)
        {
            RepairPutMultip4ByPKData(appID, itemID, operatorID, currencyID, multip4, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutMultip4ByPKData(string appID, int itemID, string operatorID, string currencyID, int multip4, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Multip4` = @Multip4  WHERE `AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Multip4", multip4, MySqlDbType.Int32),
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "multip4">x4倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutMultip4(int multip4, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Multip4` = @Multip4";
            var parameter_ = Database.CreateInParameter("@Multip4", multip4, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutMultip4Async(int multip4, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Multip4` = @Multip4";
            var parameter_ = Database.CreateInParameter("@Multip4", multip4, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutMultip4
        #region PutMultip5
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// /// <param name = "multip5">x5倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutMultip5ByPK(string appID, int itemID, string operatorID, string currencyID, int multip5, TransactionManager tm_ = null)
        {
            RepairPutMultip5ByPKData(appID, itemID, operatorID, currencyID, multip5, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutMultip5ByPKAsync(string appID, int itemID, string operatorID, string currencyID, int multip5, TransactionManager tm_ = null)
        {
            RepairPutMultip5ByPKData(appID, itemID, operatorID, currencyID, multip5, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutMultip5ByPKData(string appID, int itemID, string operatorID, string currencyID, int multip5, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Multip5` = @Multip5  WHERE `AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Multip5", multip5, MySqlDbType.Int32),
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "multip5">x5倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutMultip5(int multip5, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Multip5` = @Multip5";
            var parameter_ = Database.CreateInParameter("@Multip5", multip5, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutMultip5Async(int multip5, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Multip5` = @Multip5";
            var parameter_ = Database.CreateInParameter("@Multip5", multip5, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutMultip5
        #endregion // PutXXX
        #endregion // Put

        #region Set

        /// <summary>
        /// 插入或者更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>true:插入操作；false:更新操作</return>
        public bool Set(Slot_config_multipEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.AppID, item.ItemID, item.OperatorID, item.CurrencyID) == null)
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
        public async Task<bool> SetAsync(Slot_config_multipEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.AppID, item.ItemID, item.OperatorID, item.CurrencyID) == null)
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
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public Slot_config_multipEO GetByPK(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(appID, itemID, operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        public async Task<Slot_config_multipEO> GetByPKAsync(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(appID, itemID, operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        private void RepairGetByPKData(string appID, int itemID, string operatorID, string currencyID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 AppID（字段）
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetAppIDByPK(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`AppID`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<string> GetAppIDByPKAsync(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`AppID`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 ItemID（字段）
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetItemIDByPK(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`ItemID`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<int> GetItemIDByPKAsync(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`ItemID`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 OperatorID（字段）
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetOperatorIDByPK(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`OperatorID`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<string> GetOperatorIDByPKAsync(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`OperatorID`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 CurrencyID（字段）
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetCurrencyIDByPK(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`CurrencyID`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<string> GetCurrencyIDByPKAsync(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`CurrencyID`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 IconType（字段）
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetIconTypeByPK(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`IconType`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<int> GetIconTypeByPKAsync(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`IconType`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Multip3（字段）
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetMultip3ByPK(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`Multip3`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<int> GetMultip3ByPKAsync(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`Multip3`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Multip4（字段）
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetMultip4ByPK(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`Multip4`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<int> GetMultip4ByPKAsync(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`Multip4`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Multip5（字段）
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// /// <param name = "itemID">主键</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetMultip5ByPK(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`Multip5`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<int> GetMultip5ByPKAsync(string appID, int itemID, string operatorID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`Multip5`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByAppID

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByAppID(string appID)
        {
            return GetByAppID(appID, 0, string.Empty, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByAppIDAsync(string appID)
        {
            return await GetByAppIDAsync(appID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByAppID(string appID, TransactionManager tm_)
        {
            return GetByAppID(appID, 0, string.Empty, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
        {
            return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByAppID(string appID, int top_)
        {
            return GetByAppID(appID, top_, string.Empty, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByAppIDAsync(string appID, int top_)
        {
            return await GetByAppIDAsync(appID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByAppID(string appID, int top_, TransactionManager tm_)
        {
            return GetByAppID(appID, top_, string.Empty, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
        {
            return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByAppID(string appID, string sort_)
        {
            return GetByAppID(appID, 0, sort_, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByAppIDAsync(string appID, string sort_)
        {
            return await GetByAppIDAsync(appID, 0, sort_, null);
        }

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
        {
            return GetByAppID(appID, 0, sort_, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
        {
            return await GetByAppIDAsync(appID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 AppID（字段） 查询
        /// </summary>
        /// /// <param name = "appID">appid</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        public async Task<List<Slot_config_multipEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        #endregion // GetByAppID
        #region GetByItemID

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">主键</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByItemID(int itemID)
        {
            return GetByItemID(itemID, 0, string.Empty, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByItemIDAsync(int itemID)
        {
            return await GetByItemIDAsync(itemID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">主键</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByItemID(int itemID, TransactionManager tm_)
        {
            return GetByItemID(itemID, 0, string.Empty, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByItemIDAsync(int itemID, TransactionManager tm_)
        {
            return await GetByItemIDAsync(itemID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">主键</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByItemID(int itemID, int top_)
        {
            return GetByItemID(itemID, top_, string.Empty, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByItemIDAsync(int itemID, int top_)
        {
            return await GetByItemIDAsync(itemID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">主键</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByItemID(int itemID, int top_, TransactionManager tm_)
        {
            return GetByItemID(itemID, top_, string.Empty, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByItemIDAsync(int itemID, int top_, TransactionManager tm_)
        {
            return await GetByItemIDAsync(itemID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">主键</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByItemID(int itemID, string sort_)
        {
            return GetByItemID(itemID, 0, sort_, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByItemIDAsync(int itemID, string sort_)
        {
            return await GetByItemIDAsync(itemID, 0, sort_, null);
        }

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">主键</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByItemID(int itemID, string sort_, TransactionManager tm_)
        {
            return GetByItemID(itemID, 0, sort_, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByItemIDAsync(int itemID, string sort_, TransactionManager tm_)
        {
            return await GetByItemIDAsync(itemID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 ItemID（字段） 查询
        /// </summary>
        /// /// <param name = "itemID">主键</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByItemID(int itemID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        public async Task<List<Slot_config_multipEO>> GetByItemIDAsync(int itemID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        #endregion // GetByItemID
        #region GetByOperatorID

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByOperatorID(string operatorID)
        {
            return GetByOperatorID(operatorID, 0, string.Empty, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByOperatorIDAsync(string operatorID)
        {
            return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByOperatorID(string operatorID, TransactionManager tm_)
        {
            return GetByOperatorID(operatorID, 0, string.Empty, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
        {
            return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByOperatorID(string operatorID, int top_)
        {
            return GetByOperatorID(operatorID, top_, string.Empty, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByOperatorIDAsync(string operatorID, int top_)
        {
            return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
        {
            return GetByOperatorID(operatorID, top_, string.Empty, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
        {
            return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByOperatorID(string operatorID, string sort_)
        {
            return GetByOperatorID(operatorID, 0, sort_, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByOperatorIDAsync(string operatorID, string sort_)
        {
            return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
        {
            return GetByOperatorID(operatorID, 0, sort_, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
        {
            return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        public async Task<List<Slot_config_multipEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        #endregion // GetByOperatorID
        #region GetByCurrencyID

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByCurrencyID(string currencyID)
        {
            return GetByCurrencyID(currencyID, 0, string.Empty, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByCurrencyIDAsync(string currencyID)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByCurrencyID(string currencyID, int top_)
        {
            return GetByCurrencyID(currencyID, top_, string.Empty, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByCurrencyIDAsync(string currencyID, int top_)
        {
            return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
        {
            return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByCurrencyID(string currencyID, string sort_)
        {
            return GetByCurrencyID(currencyID, 0, sort_, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, 0, sort_, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        public async Task<List<Slot_config_multipEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        #endregion // GetByCurrencyID
        #region GetByIconType

        /// <summary>
        /// 按 IconType（字段） 查询
        /// </summary>
        /// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByIconType(int iconType)
        {
            return GetByIconType(iconType, 0, string.Empty, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByIconTypeAsync(int iconType)
        {
            return await GetByIconTypeAsync(iconType, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 IconType（字段） 查询
        /// </summary>
        /// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByIconType(int iconType, TransactionManager tm_)
        {
            return GetByIconType(iconType, 0, string.Empty, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByIconTypeAsync(int iconType, TransactionManager tm_)
        {
            return await GetByIconTypeAsync(iconType, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 IconType（字段） 查询
        /// </summary>
        /// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByIconType(int iconType, int top_)
        {
            return GetByIconType(iconType, top_, string.Empty, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByIconTypeAsync(int iconType, int top_)
        {
            return await GetByIconTypeAsync(iconType, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 IconType（字段） 查询
        /// </summary>
        /// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByIconType(int iconType, int top_, TransactionManager tm_)
        {
            return GetByIconType(iconType, top_, string.Empty, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByIconTypeAsync(int iconType, int top_, TransactionManager tm_)
        {
            return await GetByIconTypeAsync(iconType, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 IconType（字段） 查询
        /// </summary>
        /// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByIconType(int iconType, string sort_)
        {
            return GetByIconType(iconType, 0, sort_, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByIconTypeAsync(int iconType, string sort_)
        {
            return await GetByIconTypeAsync(iconType, 0, sort_, null);
        }

        /// <summary>
        /// 按 IconType（字段） 查询
        /// </summary>
        /// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByIconType(int iconType, string sort_, TransactionManager tm_)
        {
            return GetByIconType(iconType, 0, sort_, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByIconTypeAsync(int iconType, string sort_, TransactionManager tm_)
        {
            return await GetByIconTypeAsync(iconType, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 IconType（字段） 查询
        /// </summary>
        /// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByIconType(int iconType, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`IconType` = @IconType", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        public async Task<List<Slot_config_multipEO>> GetByIconTypeAsync(int iconType, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`IconType` = @IconType", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        #endregion // GetByIconType
        #region GetByMultip3

        /// <summary>
        /// 按 Multip3（字段） 查询
        /// </summary>
        /// /// <param name = "multip3">x3倍数</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip3(int multip3)
        {
            return GetByMultip3(multip3, 0, string.Empty, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip3Async(int multip3)
        {
            return await GetByMultip3Async(multip3, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Multip3（字段） 查询
        /// </summary>
        /// /// <param name = "multip3">x3倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip3(int multip3, TransactionManager tm_)
        {
            return GetByMultip3(multip3, 0, string.Empty, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip3Async(int multip3, TransactionManager tm_)
        {
            return await GetByMultip3Async(multip3, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Multip3（字段） 查询
        /// </summary>
        /// /// <param name = "multip3">x3倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip3(int multip3, int top_)
        {
            return GetByMultip3(multip3, top_, string.Empty, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip3Async(int multip3, int top_)
        {
            return await GetByMultip3Async(multip3, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Multip3（字段） 查询
        /// </summary>
        /// /// <param name = "multip3">x3倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip3(int multip3, int top_, TransactionManager tm_)
        {
            return GetByMultip3(multip3, top_, string.Empty, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip3Async(int multip3, int top_, TransactionManager tm_)
        {
            return await GetByMultip3Async(multip3, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Multip3（字段） 查询
        /// </summary>
        /// /// <param name = "multip3">x3倍数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip3(int multip3, string sort_)
        {
            return GetByMultip3(multip3, 0, sort_, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip3Async(int multip3, string sort_)
        {
            return await GetByMultip3Async(multip3, 0, sort_, null);
        }

        /// <summary>
        /// 按 Multip3（字段） 查询
        /// </summary>
        /// /// <param name = "multip3">x3倍数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip3(int multip3, string sort_, TransactionManager tm_)
        {
            return GetByMultip3(multip3, 0, sort_, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip3Async(int multip3, string sort_, TransactionManager tm_)
        {
            return await GetByMultip3Async(multip3, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Multip3（字段） 查询
        /// </summary>
        /// /// <param name = "multip3">x3倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip3(int multip3, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Multip3` = @Multip3", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip3", multip3, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip3Async(int multip3, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Multip3` = @Multip3", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip3", multip3, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        #endregion // GetByMultip3
        #region GetByMultip4

        /// <summary>
        /// 按 Multip4（字段） 查询
        /// </summary>
        /// /// <param name = "multip4">x4倍数</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip4(int multip4)
        {
            return GetByMultip4(multip4, 0, string.Empty, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip4Async(int multip4)
        {
            return await GetByMultip4Async(multip4, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Multip4（字段） 查询
        /// </summary>
        /// /// <param name = "multip4">x4倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip4(int multip4, TransactionManager tm_)
        {
            return GetByMultip4(multip4, 0, string.Empty, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip4Async(int multip4, TransactionManager tm_)
        {
            return await GetByMultip4Async(multip4, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Multip4（字段） 查询
        /// </summary>
        /// /// <param name = "multip4">x4倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip4(int multip4, int top_)
        {
            return GetByMultip4(multip4, top_, string.Empty, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip4Async(int multip4, int top_)
        {
            return await GetByMultip4Async(multip4, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Multip4（字段） 查询
        /// </summary>
        /// /// <param name = "multip4">x4倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip4(int multip4, int top_, TransactionManager tm_)
        {
            return GetByMultip4(multip4, top_, string.Empty, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip4Async(int multip4, int top_, TransactionManager tm_)
        {
            return await GetByMultip4Async(multip4, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Multip4（字段） 查询
        /// </summary>
        /// /// <param name = "multip4">x4倍数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip4(int multip4, string sort_)
        {
            return GetByMultip4(multip4, 0, sort_, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip4Async(int multip4, string sort_)
        {
            return await GetByMultip4Async(multip4, 0, sort_, null);
        }

        /// <summary>
        /// 按 Multip4（字段） 查询
        /// </summary>
        /// /// <param name = "multip4">x4倍数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip4(int multip4, string sort_, TransactionManager tm_)
        {
            return GetByMultip4(multip4, 0, sort_, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip4Async(int multip4, string sort_, TransactionManager tm_)
        {
            return await GetByMultip4Async(multip4, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Multip4（字段） 查询
        /// </summary>
        /// /// <param name = "multip4">x4倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip4(int multip4, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Multip4` = @Multip4", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip4", multip4, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip4Async(int multip4, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Multip4` = @Multip4", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip4", multip4, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        #endregion // GetByMultip4
        #region GetByMultip5

        /// <summary>
        /// 按 Multip5（字段） 查询
        /// </summary>
        /// /// <param name = "multip5">x5倍数</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip5(int multip5)
        {
            return GetByMultip5(multip5, 0, string.Empty, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip5Async(int multip5)
        {
            return await GetByMultip5Async(multip5, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Multip5（字段） 查询
        /// </summary>
        /// /// <param name = "multip5">x5倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip5(int multip5, TransactionManager tm_)
        {
            return GetByMultip5(multip5, 0, string.Empty, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip5Async(int multip5, TransactionManager tm_)
        {
            return await GetByMultip5Async(multip5, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Multip5（字段） 查询
        /// </summary>
        /// /// <param name = "multip5">x5倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip5(int multip5, int top_)
        {
            return GetByMultip5(multip5, top_, string.Empty, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip5Async(int multip5, int top_)
        {
            return await GetByMultip5Async(multip5, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Multip5（字段） 查询
        /// </summary>
        /// /// <param name = "multip5">x5倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip5(int multip5, int top_, TransactionManager tm_)
        {
            return GetByMultip5(multip5, top_, string.Empty, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip5Async(int multip5, int top_, TransactionManager tm_)
        {
            return await GetByMultip5Async(multip5, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Multip5（字段） 查询
        /// </summary>
        /// /// <param name = "multip5">x5倍数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip5(int multip5, string sort_)
        {
            return GetByMultip5(multip5, 0, sort_, null);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip5Async(int multip5, string sort_)
        {
            return await GetByMultip5Async(multip5, 0, sort_, null);
        }

        /// <summary>
        /// 按 Multip5（字段） 查询
        /// </summary>
        /// /// <param name = "multip5">x5倍数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip5(int multip5, string sort_, TransactionManager tm_)
        {
            return GetByMultip5(multip5, 0, sort_, tm_);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip5Async(int multip5, string sort_, TransactionManager tm_)
        {
            return await GetByMultip5Async(multip5, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Multip5（字段） 查询
        /// </summary>
        /// /// <param name = "multip5">x5倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Slot_config_multipEO> GetByMultip5(int multip5, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Multip5` = @Multip5", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip5", multip5, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        public async Task<List<Slot_config_multipEO>> GetByMultip5Async(int multip5, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Multip5` = @Multip5", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Multip5", multip5, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_multipEO.MapDataReader);
        }
        #endregion // GetByMultip5
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
