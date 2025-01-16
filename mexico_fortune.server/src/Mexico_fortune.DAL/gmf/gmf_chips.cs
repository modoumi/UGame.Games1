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
    /// 下注筹码表
    /// 【表 gmf_chips 的实体类】
    /// </summary>
    [DataContract]
    public class Gmf_chipsEO : IRowMapper<Gmf_chipsEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Gmf_chipsEO()
        {
            this.BetMoney = 0d;
            this.JPMini = 0;
            this.JPMinor = 0;
            this.JPMajor = 0;
            this.JPGrand = 0;
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private int _originalChipsID;
        /// <summary>
        /// 【数据库中的原始主键 ChipsID 值的副本，用于主键值更新】
        /// </summary>
        public int OriginalChipsID
        {
            get { return _originalChipsID; }
            set { HasOriginal = true; _originalChipsID = value; }
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
            return new Dictionary<string, object>() { { "ChipsID", ChipsID }, { "CurrencyID", CurrencyID }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// 筹码编码
        /// 【主键 int】
        /// </summary>
        [DataMember(Order = 1)]
        public int ChipsID { get; set; }
        /// <summary>
        /// 货币编码（ISO 4217大写）
        /// 【主键 varchar(5)】
        /// </summary>
        [DataMember(Order = 2)]
        public string CurrencyID { get; set; }
        /// <summary>
        /// 下注金额
        /// 【字段 double】
        /// </summary>
        [DataMember(Order = 3)]
        public double BetMoney { get; set; }
        /// <summary>
        /// jackpot奖池Mini
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 4)]
        public int JPMini { get; set; }
        /// <summary>
        /// jackpot奖池Minor
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 5)]
        public int JPMinor { get; set; }
        /// <summary>
        /// jackpot奖池Major
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 6)]
        public int JPMajor { get; set; }
        /// <summary>
        /// jackpot奖池Grand
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 7)]
        public int JPGrand { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public Gmf_chipsEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static Gmf_chipsEO MapDataReader(IDataReader reader)
        {
            Gmf_chipsEO ret = new Gmf_chipsEO();
            ret.ChipsID = reader.ToInt32("ChipsID");
            ret.OriginalChipsID = ret.ChipsID;
            ret.CurrencyID = reader.ToString("CurrencyID");
            ret.OriginalCurrencyID = ret.CurrencyID;
            ret.BetMoney = reader.ToDouble("BetMoney");
            ret.JPMini = reader.ToInt32("JPMini");
            ret.JPMinor = reader.ToInt32("JPMinor");
            ret.JPMajor = reader.ToInt32("JPMajor");
            ret.JPGrand = reader.ToInt32("JPGrand");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// 下注筹码表
    /// 【表 gmf_chips 的操作类】
    /// </summary>
    public class Gmf_chipsMO : MySqlTableMO<Gmf_chipsEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`gmf_chips`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public Gmf_chipsMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public Gmf_chipsMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public Gmf_chipsMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(Gmf_chipsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(Gmf_chipsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(Gmf_chipsEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`ChipsID`, `CurrencyID`, `BetMoney`, `JPMini`, `JPMinor`, `JPMajor`, `JPGrand`) VALUE (@ChipsID, @CurrencyID, @BetMoney, @JPMini, @JPMinor, @JPMajor, @JPGrand);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
                Database.CreateInParameter("@BetMoney", item.BetMoney, MySqlDbType.Double),
                Database.CreateInParameter("@JPMini", item.JPMini, MySqlDbType.Int32),
                Database.CreateInParameter("@JPMinor", item.JPMinor, MySqlDbType.Int32),
                Database.CreateInParameter("@JPMajor", item.JPMajor, MySqlDbType.Int32),
                Database.CreateInParameter("@JPGrand", item.JPGrand, MySqlDbType.Int32),
            };
        }
        public int AddByBatch(IEnumerable<Gmf_chipsEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<Gmf_chipsEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gmf_chipsEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`ChipsID`, `CurrencyID`, `BetMoney`, `JPMini`, `JPMinor`, `JPMajor`, `JPGrand`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"({item.ChipsID},'{item.CurrencyID}',{item.BetMoney},{item.JPMini},{item.JPMinor},{item.JPMajor},{item.JPGrand}),");
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
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(int chipsID, string currencyID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(chipsID, currencyID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(int chipsID, string currencyID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(chipsID, currencyID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(int chipsID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(Gmf_chipsEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.ChipsID, item.CurrencyID, tm_);
        }
        public async Task<int> RemoveAsync(Gmf_chipsEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.ChipsID, item.CurrencyID, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
        #region RemoveByChipsID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByChipsID(int chipsID, TransactionManager tm_ = null)
        {
            RepairRemoveByChipsIDData(chipsID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByChipsIDAsync(int chipsID, TransactionManager tm_ = null)
        {
            RepairRemoveByChipsIDData(chipsID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByChipsIDData(int chipsID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
        }
        #endregion // RemoveByChipsID
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
        #region RemoveByBetMoney
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "betMoney">下注金额</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBetMoney(double betMoney, TransactionManager tm_ = null)
        {
            RepairRemoveByBetMoneyData(betMoney, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBetMoneyAsync(double betMoney, TransactionManager tm_ = null)
        {
            RepairRemoveByBetMoneyData(betMoney, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBetMoneyData(double betMoney, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BetMoney` = @BetMoney";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BetMoney", betMoney, MySqlDbType.Double));
        }
        #endregion // RemoveByBetMoney
        #region RemoveByJPMini
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "jPMini">jackpot奖池Mini</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByJPMini(int jPMini, TransactionManager tm_ = null)
        {
            RepairRemoveByJPMiniData(jPMini, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByJPMiniAsync(int jPMini, TransactionManager tm_ = null)
        {
            RepairRemoveByJPMiniData(jPMini, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByJPMiniData(int jPMini, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `JPMini` = @JPMini";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@JPMini", jPMini, MySqlDbType.Int32));
        }
        #endregion // RemoveByJPMini
        #region RemoveByJPMinor
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "jPMinor">jackpot奖池Minor</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByJPMinor(int jPMinor, TransactionManager tm_ = null)
        {
            RepairRemoveByJPMinorData(jPMinor, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByJPMinorAsync(int jPMinor, TransactionManager tm_ = null)
        {
            RepairRemoveByJPMinorData(jPMinor, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByJPMinorData(int jPMinor, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `JPMinor` = @JPMinor";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@JPMinor", jPMinor, MySqlDbType.Int32));
        }
        #endregion // RemoveByJPMinor
        #region RemoveByJPMajor
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "jPMajor">jackpot奖池Major</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByJPMajor(int jPMajor, TransactionManager tm_ = null)
        {
            RepairRemoveByJPMajorData(jPMajor, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByJPMajorAsync(int jPMajor, TransactionManager tm_ = null)
        {
            RepairRemoveByJPMajorData(jPMajor, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByJPMajorData(int jPMajor, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `JPMajor` = @JPMajor";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@JPMajor", jPMajor, MySqlDbType.Int32));
        }
        #endregion // RemoveByJPMajor
        #region RemoveByJPGrand
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "jPGrand">jackpot奖池Grand</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByJPGrand(int jPGrand, TransactionManager tm_ = null)
        {
            RepairRemoveByJPGrandData(jPGrand, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByJPGrandAsync(int jPGrand, TransactionManager tm_ = null)
        {
            RepairRemoveByJPGrandData(jPGrand, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByJPGrandData(int jPGrand, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `JPGrand` = @JPGrand";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@JPGrand", jPGrand, MySqlDbType.Int32));
        }
        #endregion // RemoveByJPGrand
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
        public int Put(Gmf_chipsEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(Gmf_chipsEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(Gmf_chipsEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `ChipsID` = @ChipsID, `CurrencyID` = @CurrencyID, `BetMoney` = @BetMoney, `JPMini` = @JPMini, `JPMinor` = @JPMinor, `JPMajor` = @JPMajor, `JPGrand` = @JPGrand WHERE `ChipsID` = @ChipsID_Original AND `CurrencyID` = @CurrencyID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
                Database.CreateInParameter("@BetMoney", item.BetMoney, MySqlDbType.Double),
                Database.CreateInParameter("@JPMini", item.JPMini, MySqlDbType.Int32),
                Database.CreateInParameter("@JPMinor", item.JPMinor, MySqlDbType.Int32),
                Database.CreateInParameter("@JPMajor", item.JPMajor, MySqlDbType.Int32),
                Database.CreateInParameter("@JPGrand", item.JPGrand, MySqlDbType.Int32),
                Database.CreateInParameter("@ChipsID_Original", item.HasOriginal ? item.OriginalChipsID : item.ChipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID_Original", item.HasOriginal ? item.OriginalCurrencyID : item.CurrencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<Gmf_chipsEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<Gmf_chipsEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int chipsID, string currencyID, string set_, params object[] values_)
        {
            return Put(set_, "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", ConcatValues(values_, chipsID, currencyID));
        }
        public async Task<int> PutByPKAsync(int chipsID, string currencyID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", ConcatValues(values_, chipsID, currencyID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int chipsID, string currencyID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, chipsID, currencyID));
        }
        public async Task<int> PutByPKAsync(int chipsID, string currencyID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, chipsID, currencyID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int chipsID, string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return Put(set_, "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(int chipsID, string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return await PutAsync(set_, "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutChipsID

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutChipsID(int chipsID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `ChipsID` = @ChipsID";
            var parameter_ = Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutChipsIDAsync(int chipsID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `ChipsID` = @ChipsID";
            var parameter_ = Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutChipsID
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
        #region PutBetMoney
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// /// <param name = "betMoney">下注金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBetMoneyByPK(int chipsID, string currencyID, double betMoney, TransactionManager tm_ = null)
        {
            RepairPutBetMoneyByPKData(chipsID, currencyID, betMoney, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBetMoneyByPKAsync(int chipsID, string currencyID, double betMoney, TransactionManager tm_ = null)
        {
            RepairPutBetMoneyByPKData(chipsID, currencyID, betMoney, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBetMoneyByPKData(int chipsID, string currencyID, double betMoney, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BetMoney` = @BetMoney  WHERE `ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BetMoney", betMoney, MySqlDbType.Double),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "betMoney">下注金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBetMoney(double betMoney, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BetMoney` = @BetMoney";
            var parameter_ = Database.CreateInParameter("@BetMoney", betMoney, MySqlDbType.Double);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBetMoneyAsync(double betMoney, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BetMoney` = @BetMoney";
            var parameter_ = Database.CreateInParameter("@BetMoney", betMoney, MySqlDbType.Double);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBetMoney
        #region PutJPMini
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// /// <param name = "jPMini">jackpot奖池Mini</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutJPMiniByPK(int chipsID, string currencyID, int jPMini, TransactionManager tm_ = null)
        {
            RepairPutJPMiniByPKData(chipsID, currencyID, jPMini, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutJPMiniByPKAsync(int chipsID, string currencyID, int jPMini, TransactionManager tm_ = null)
        {
            RepairPutJPMiniByPKData(chipsID, currencyID, jPMini, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutJPMiniByPKData(int chipsID, string currencyID, int jPMini, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `JPMini` = @JPMini  WHERE `ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@JPMini", jPMini, MySqlDbType.Int32),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "jPMini">jackpot奖池Mini</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutJPMini(int jPMini, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `JPMini` = @JPMini";
            var parameter_ = Database.CreateInParameter("@JPMini", jPMini, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutJPMiniAsync(int jPMini, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `JPMini` = @JPMini";
            var parameter_ = Database.CreateInParameter("@JPMini", jPMini, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutJPMini
        #region PutJPMinor
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// /// <param name = "jPMinor">jackpot奖池Minor</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutJPMinorByPK(int chipsID, string currencyID, int jPMinor, TransactionManager tm_ = null)
        {
            RepairPutJPMinorByPKData(chipsID, currencyID, jPMinor, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutJPMinorByPKAsync(int chipsID, string currencyID, int jPMinor, TransactionManager tm_ = null)
        {
            RepairPutJPMinorByPKData(chipsID, currencyID, jPMinor, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutJPMinorByPKData(int chipsID, string currencyID, int jPMinor, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `JPMinor` = @JPMinor  WHERE `ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@JPMinor", jPMinor, MySqlDbType.Int32),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "jPMinor">jackpot奖池Minor</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutJPMinor(int jPMinor, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `JPMinor` = @JPMinor";
            var parameter_ = Database.CreateInParameter("@JPMinor", jPMinor, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutJPMinorAsync(int jPMinor, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `JPMinor` = @JPMinor";
            var parameter_ = Database.CreateInParameter("@JPMinor", jPMinor, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutJPMinor
        #region PutJPMajor
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// /// <param name = "jPMajor">jackpot奖池Major</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutJPMajorByPK(int chipsID, string currencyID, int jPMajor, TransactionManager tm_ = null)
        {
            RepairPutJPMajorByPKData(chipsID, currencyID, jPMajor, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutJPMajorByPKAsync(int chipsID, string currencyID, int jPMajor, TransactionManager tm_ = null)
        {
            RepairPutJPMajorByPKData(chipsID, currencyID, jPMajor, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutJPMajorByPKData(int chipsID, string currencyID, int jPMajor, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `JPMajor` = @JPMajor  WHERE `ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@JPMajor", jPMajor, MySqlDbType.Int32),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "jPMajor">jackpot奖池Major</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutJPMajor(int jPMajor, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `JPMajor` = @JPMajor";
            var parameter_ = Database.CreateInParameter("@JPMajor", jPMajor, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutJPMajorAsync(int jPMajor, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `JPMajor` = @JPMajor";
            var parameter_ = Database.CreateInParameter("@JPMajor", jPMajor, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutJPMajor
        #region PutJPGrand
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// /// <param name = "jPGrand">jackpot奖池Grand</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutJPGrandByPK(int chipsID, string currencyID, int jPGrand, TransactionManager tm_ = null)
        {
            RepairPutJPGrandByPKData(chipsID, currencyID, jPGrand, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutJPGrandByPKAsync(int chipsID, string currencyID, int jPGrand, TransactionManager tm_ = null)
        {
            RepairPutJPGrandByPKData(chipsID, currencyID, jPGrand, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutJPGrandByPKData(int chipsID, string currencyID, int jPGrand, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `JPGrand` = @JPGrand  WHERE `ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@JPGrand", jPGrand, MySqlDbType.Int32),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "jPGrand">jackpot奖池Grand</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutJPGrand(int jPGrand, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `JPGrand` = @JPGrand";
            var parameter_ = Database.CreateInParameter("@JPGrand", jPGrand, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutJPGrandAsync(int jPGrand, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `JPGrand` = @JPGrand";
            var parameter_ = Database.CreateInParameter("@JPGrand", jPGrand, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutJPGrand
        #endregion // PutXXX
        #endregion // Put

        #region Set

        /// <summary>
        /// 插入或者更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>true:插入操作；false:更新操作</return>
        public bool Set(Gmf_chipsEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.ChipsID, item.CurrencyID) == null)
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
        public async Task<bool> SetAsync(Gmf_chipsEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.ChipsID, item.CurrencyID) == null)
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
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public Gmf_chipsEO GetByPK(int chipsID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(chipsID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, Gmf_chipsEO.MapDataReader);
        }
        public async Task<Gmf_chipsEO> GetByPKAsync(int chipsID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(chipsID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gmf_chipsEO.MapDataReader);
        }
        private void RepairGetByPKData(int chipsID, string currencyID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 ChipsID（字段）
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetChipsIDByPK(int chipsID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`ChipsID`", "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<int> GetChipsIDByPKAsync(int chipsID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`ChipsID`", "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 CurrencyID（字段）
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetCurrencyIDByPK(int chipsID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`CurrencyID`", "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<string> GetCurrencyIDByPKAsync(int chipsID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`CurrencyID`", "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BetMoney（字段）
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public double GetBetMoneyByPK(int chipsID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (double)GetScalar("`BetMoney`", "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<double> GetBetMoneyByPKAsync(int chipsID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (double)await GetScalarAsync("`BetMoney`", "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 JPMini（字段）
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetJPMiniByPK(int chipsID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`JPMini`", "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<int> GetJPMiniByPKAsync(int chipsID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`JPMini`", "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 JPMinor（字段）
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetJPMinorByPK(int chipsID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`JPMinor`", "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<int> GetJPMinorByPKAsync(int chipsID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`JPMinor`", "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 JPMajor（字段）
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetJPMajorByPK(int chipsID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`JPMajor`", "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<int> GetJPMajorByPKAsync(int chipsID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`JPMajor`", "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 JPGrand（字段）
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetJPGrandByPK(int chipsID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`JPGrand`", "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<int> GetJPGrandByPKAsync(int chipsID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`JPGrand`", "`ChipsID` = @ChipsID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByChipsID

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByChipsID(int chipsID)
        {
            return GetByChipsID(chipsID, 0, string.Empty, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByChipsIDAsync(int chipsID)
        {
            return await GetByChipsIDAsync(chipsID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByChipsID(int chipsID, TransactionManager tm_)
        {
            return GetByChipsID(chipsID, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByChipsIDAsync(int chipsID, TransactionManager tm_)
        {
            return await GetByChipsIDAsync(chipsID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByChipsID(int chipsID, int top_)
        {
            return GetByChipsID(chipsID, top_, string.Empty, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByChipsIDAsync(int chipsID, int top_)
        {
            return await GetByChipsIDAsync(chipsID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByChipsID(int chipsID, int top_, TransactionManager tm_)
        {
            return GetByChipsID(chipsID, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByChipsIDAsync(int chipsID, int top_, TransactionManager tm_)
        {
            return await GetByChipsIDAsync(chipsID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByChipsID(int chipsID, string sort_)
        {
            return GetByChipsID(chipsID, 0, sort_, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByChipsIDAsync(int chipsID, string sort_)
        {
            return await GetByChipsIDAsync(chipsID, 0, sort_, null);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByChipsID(int chipsID, string sort_, TransactionManager tm_)
        {
            return GetByChipsID(chipsID, 0, sort_, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByChipsIDAsync(int chipsID, string sort_, TransactionManager tm_)
        {
            return await GetByChipsIDAsync(chipsID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByChipsID(int chipsID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_chipsEO.MapDataReader);
        }
        public async Task<List<Gmf_chipsEO>> GetByChipsIDAsync(int chipsID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_chipsEO.MapDataReader);
        }
        #endregion // GetByChipsID
        #region GetByCurrencyID

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByCurrencyID(string currencyID)
        {
            return GetByCurrencyID(currencyID, 0, string.Empty, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByCurrencyIDAsync(string currencyID)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByCurrencyID(string currencyID, int top_)
        {
            return GetByCurrencyID(currencyID, top_, string.Empty, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
        public List<Gmf_chipsEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
        {
            return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByCurrencyID(string currencyID, string sort_)
        {
            return GetByCurrencyID(currencyID, 0, sort_, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
        public List<Gmf_chipsEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, 0, sort_, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
        public List<Gmf_chipsEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_chipsEO.MapDataReader);
        }
        public async Task<List<Gmf_chipsEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_chipsEO.MapDataReader);
        }
        #endregion // GetByCurrencyID
        #region GetByBetMoney

        /// <summary>
        /// 按 BetMoney（字段） 查询
        /// </summary>
        /// /// <param name = "betMoney">下注金额</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByBetMoney(double betMoney)
        {
            return GetByBetMoney(betMoney, 0, string.Empty, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByBetMoneyAsync(double betMoney)
        {
            return await GetByBetMoneyAsync(betMoney, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BetMoney（字段） 查询
        /// </summary>
        /// /// <param name = "betMoney">下注金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByBetMoney(double betMoney, TransactionManager tm_)
        {
            return GetByBetMoney(betMoney, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByBetMoneyAsync(double betMoney, TransactionManager tm_)
        {
            return await GetByBetMoneyAsync(betMoney, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BetMoney（字段） 查询
        /// </summary>
        /// /// <param name = "betMoney">下注金额</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByBetMoney(double betMoney, int top_)
        {
            return GetByBetMoney(betMoney, top_, string.Empty, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByBetMoneyAsync(double betMoney, int top_)
        {
            return await GetByBetMoneyAsync(betMoney, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BetMoney（字段） 查询
        /// </summary>
        /// /// <param name = "betMoney">下注金额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByBetMoney(double betMoney, int top_, TransactionManager tm_)
        {
            return GetByBetMoney(betMoney, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByBetMoneyAsync(double betMoney, int top_, TransactionManager tm_)
        {
            return await GetByBetMoneyAsync(betMoney, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BetMoney（字段） 查询
        /// </summary>
        /// /// <param name = "betMoney">下注金额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByBetMoney(double betMoney, string sort_)
        {
            return GetByBetMoney(betMoney, 0, sort_, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByBetMoneyAsync(double betMoney, string sort_)
        {
            return await GetByBetMoneyAsync(betMoney, 0, sort_, null);
        }

        /// <summary>
        /// 按 BetMoney（字段） 查询
        /// </summary>
        /// /// <param name = "betMoney">下注金额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByBetMoney(double betMoney, string sort_, TransactionManager tm_)
        {
            return GetByBetMoney(betMoney, 0, sort_, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByBetMoneyAsync(double betMoney, string sort_, TransactionManager tm_)
        {
            return await GetByBetMoneyAsync(betMoney, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BetMoney（字段） 查询
        /// </summary>
        /// /// <param name = "betMoney">下注金额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByBetMoney(double betMoney, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BetMoney` = @BetMoney", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BetMoney", betMoney, MySqlDbType.Double));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_chipsEO.MapDataReader);
        }
        public async Task<List<Gmf_chipsEO>> GetByBetMoneyAsync(double betMoney, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BetMoney` = @BetMoney", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BetMoney", betMoney, MySqlDbType.Double));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_chipsEO.MapDataReader);
        }
        #endregion // GetByBetMoney
        #region GetByJPMini

        /// <summary>
        /// 按 JPMini（字段） 查询
        /// </summary>
        /// /// <param name = "jPMini">jackpot奖池Mini</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMini(int jPMini)
        {
            return GetByJPMini(jPMini, 0, string.Empty, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMiniAsync(int jPMini)
        {
            return await GetByJPMiniAsync(jPMini, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 JPMini（字段） 查询
        /// </summary>
        /// /// <param name = "jPMini">jackpot奖池Mini</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMini(int jPMini, TransactionManager tm_)
        {
            return GetByJPMini(jPMini, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMiniAsync(int jPMini, TransactionManager tm_)
        {
            return await GetByJPMiniAsync(jPMini, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 JPMini（字段） 查询
        /// </summary>
        /// /// <param name = "jPMini">jackpot奖池Mini</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMini(int jPMini, int top_)
        {
            return GetByJPMini(jPMini, top_, string.Empty, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMiniAsync(int jPMini, int top_)
        {
            return await GetByJPMiniAsync(jPMini, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 JPMini（字段） 查询
        /// </summary>
        /// /// <param name = "jPMini">jackpot奖池Mini</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMini(int jPMini, int top_, TransactionManager tm_)
        {
            return GetByJPMini(jPMini, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMiniAsync(int jPMini, int top_, TransactionManager tm_)
        {
            return await GetByJPMiniAsync(jPMini, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 JPMini（字段） 查询
        /// </summary>
        /// /// <param name = "jPMini">jackpot奖池Mini</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMini(int jPMini, string sort_)
        {
            return GetByJPMini(jPMini, 0, sort_, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMiniAsync(int jPMini, string sort_)
        {
            return await GetByJPMiniAsync(jPMini, 0, sort_, null);
        }

        /// <summary>
        /// 按 JPMini（字段） 查询
        /// </summary>
        /// /// <param name = "jPMini">jackpot奖池Mini</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMini(int jPMini, string sort_, TransactionManager tm_)
        {
            return GetByJPMini(jPMini, 0, sort_, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMiniAsync(int jPMini, string sort_, TransactionManager tm_)
        {
            return await GetByJPMiniAsync(jPMini, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 JPMini（字段） 查询
        /// </summary>
        /// /// <param name = "jPMini">jackpot奖池Mini</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMini(int jPMini, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`JPMini` = @JPMini", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@JPMini", jPMini, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_chipsEO.MapDataReader);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMiniAsync(int jPMini, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`JPMini` = @JPMini", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@JPMini", jPMini, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_chipsEO.MapDataReader);
        }
        #endregion // GetByJPMini
        #region GetByJPMinor

        /// <summary>
        /// 按 JPMinor（字段） 查询
        /// </summary>
        /// /// <param name = "jPMinor">jackpot奖池Minor</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMinor(int jPMinor)
        {
            return GetByJPMinor(jPMinor, 0, string.Empty, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMinorAsync(int jPMinor)
        {
            return await GetByJPMinorAsync(jPMinor, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 JPMinor（字段） 查询
        /// </summary>
        /// /// <param name = "jPMinor">jackpot奖池Minor</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMinor(int jPMinor, TransactionManager tm_)
        {
            return GetByJPMinor(jPMinor, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMinorAsync(int jPMinor, TransactionManager tm_)
        {
            return await GetByJPMinorAsync(jPMinor, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 JPMinor（字段） 查询
        /// </summary>
        /// /// <param name = "jPMinor">jackpot奖池Minor</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMinor(int jPMinor, int top_)
        {
            return GetByJPMinor(jPMinor, top_, string.Empty, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMinorAsync(int jPMinor, int top_)
        {
            return await GetByJPMinorAsync(jPMinor, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 JPMinor（字段） 查询
        /// </summary>
        /// /// <param name = "jPMinor">jackpot奖池Minor</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMinor(int jPMinor, int top_, TransactionManager tm_)
        {
            return GetByJPMinor(jPMinor, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMinorAsync(int jPMinor, int top_, TransactionManager tm_)
        {
            return await GetByJPMinorAsync(jPMinor, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 JPMinor（字段） 查询
        /// </summary>
        /// /// <param name = "jPMinor">jackpot奖池Minor</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMinor(int jPMinor, string sort_)
        {
            return GetByJPMinor(jPMinor, 0, sort_, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMinorAsync(int jPMinor, string sort_)
        {
            return await GetByJPMinorAsync(jPMinor, 0, sort_, null);
        }

        /// <summary>
        /// 按 JPMinor（字段） 查询
        /// </summary>
        /// /// <param name = "jPMinor">jackpot奖池Minor</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMinor(int jPMinor, string sort_, TransactionManager tm_)
        {
            return GetByJPMinor(jPMinor, 0, sort_, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMinorAsync(int jPMinor, string sort_, TransactionManager tm_)
        {
            return await GetByJPMinorAsync(jPMinor, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 JPMinor（字段） 查询
        /// </summary>
        /// /// <param name = "jPMinor">jackpot奖池Minor</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMinor(int jPMinor, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`JPMinor` = @JPMinor", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@JPMinor", jPMinor, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_chipsEO.MapDataReader);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMinorAsync(int jPMinor, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`JPMinor` = @JPMinor", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@JPMinor", jPMinor, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_chipsEO.MapDataReader);
        }
        #endregion // GetByJPMinor
        #region GetByJPMajor

        /// <summary>
        /// 按 JPMajor（字段） 查询
        /// </summary>
        /// /// <param name = "jPMajor">jackpot奖池Major</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMajor(int jPMajor)
        {
            return GetByJPMajor(jPMajor, 0, string.Empty, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMajorAsync(int jPMajor)
        {
            return await GetByJPMajorAsync(jPMajor, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 JPMajor（字段） 查询
        /// </summary>
        /// /// <param name = "jPMajor">jackpot奖池Major</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMajor(int jPMajor, TransactionManager tm_)
        {
            return GetByJPMajor(jPMajor, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMajorAsync(int jPMajor, TransactionManager tm_)
        {
            return await GetByJPMajorAsync(jPMajor, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 JPMajor（字段） 查询
        /// </summary>
        /// /// <param name = "jPMajor">jackpot奖池Major</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMajor(int jPMajor, int top_)
        {
            return GetByJPMajor(jPMajor, top_, string.Empty, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMajorAsync(int jPMajor, int top_)
        {
            return await GetByJPMajorAsync(jPMajor, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 JPMajor（字段） 查询
        /// </summary>
        /// /// <param name = "jPMajor">jackpot奖池Major</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMajor(int jPMajor, int top_, TransactionManager tm_)
        {
            return GetByJPMajor(jPMajor, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMajorAsync(int jPMajor, int top_, TransactionManager tm_)
        {
            return await GetByJPMajorAsync(jPMajor, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 JPMajor（字段） 查询
        /// </summary>
        /// /// <param name = "jPMajor">jackpot奖池Major</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMajor(int jPMajor, string sort_)
        {
            return GetByJPMajor(jPMajor, 0, sort_, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMajorAsync(int jPMajor, string sort_)
        {
            return await GetByJPMajorAsync(jPMajor, 0, sort_, null);
        }

        /// <summary>
        /// 按 JPMajor（字段） 查询
        /// </summary>
        /// /// <param name = "jPMajor">jackpot奖池Major</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMajor(int jPMajor, string sort_, TransactionManager tm_)
        {
            return GetByJPMajor(jPMajor, 0, sort_, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMajorAsync(int jPMajor, string sort_, TransactionManager tm_)
        {
            return await GetByJPMajorAsync(jPMajor, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 JPMajor（字段） 查询
        /// </summary>
        /// /// <param name = "jPMajor">jackpot奖池Major</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPMajor(int jPMajor, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`JPMajor` = @JPMajor", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@JPMajor", jPMajor, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_chipsEO.MapDataReader);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPMajorAsync(int jPMajor, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`JPMajor` = @JPMajor", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@JPMajor", jPMajor, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_chipsEO.MapDataReader);
        }
        #endregion // GetByJPMajor
        #region GetByJPGrand

        /// <summary>
        /// 按 JPGrand（字段） 查询
        /// </summary>
        /// /// <param name = "jPGrand">jackpot奖池Grand</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPGrand(int jPGrand)
        {
            return GetByJPGrand(jPGrand, 0, string.Empty, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPGrandAsync(int jPGrand)
        {
            return await GetByJPGrandAsync(jPGrand, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 JPGrand（字段） 查询
        /// </summary>
        /// /// <param name = "jPGrand">jackpot奖池Grand</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPGrand(int jPGrand, TransactionManager tm_)
        {
            return GetByJPGrand(jPGrand, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPGrandAsync(int jPGrand, TransactionManager tm_)
        {
            return await GetByJPGrandAsync(jPGrand, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 JPGrand（字段） 查询
        /// </summary>
        /// /// <param name = "jPGrand">jackpot奖池Grand</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPGrand(int jPGrand, int top_)
        {
            return GetByJPGrand(jPGrand, top_, string.Empty, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPGrandAsync(int jPGrand, int top_)
        {
            return await GetByJPGrandAsync(jPGrand, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 JPGrand（字段） 查询
        /// </summary>
        /// /// <param name = "jPGrand">jackpot奖池Grand</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPGrand(int jPGrand, int top_, TransactionManager tm_)
        {
            return GetByJPGrand(jPGrand, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPGrandAsync(int jPGrand, int top_, TransactionManager tm_)
        {
            return await GetByJPGrandAsync(jPGrand, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 JPGrand（字段） 查询
        /// </summary>
        /// /// <param name = "jPGrand">jackpot奖池Grand</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPGrand(int jPGrand, string sort_)
        {
            return GetByJPGrand(jPGrand, 0, sort_, null);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPGrandAsync(int jPGrand, string sort_)
        {
            return await GetByJPGrandAsync(jPGrand, 0, sort_, null);
        }

        /// <summary>
        /// 按 JPGrand（字段） 查询
        /// </summary>
        /// /// <param name = "jPGrand">jackpot奖池Grand</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPGrand(int jPGrand, string sort_, TransactionManager tm_)
        {
            return GetByJPGrand(jPGrand, 0, sort_, tm_);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPGrandAsync(int jPGrand, string sort_, TransactionManager tm_)
        {
            return await GetByJPGrandAsync(jPGrand, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 JPGrand（字段） 查询
        /// </summary>
        /// /// <param name = "jPGrand">jackpot奖池Grand</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_chipsEO> GetByJPGrand(int jPGrand, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`JPGrand` = @JPGrand", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@JPGrand", jPGrand, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_chipsEO.MapDataReader);
        }
        public async Task<List<Gmf_chipsEO>> GetByJPGrandAsync(int jPGrand, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`JPGrand` = @JPGrand", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@JPGrand", jPGrand, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_chipsEO.MapDataReader);
        }
        #endregion // GetByJPGrand
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
