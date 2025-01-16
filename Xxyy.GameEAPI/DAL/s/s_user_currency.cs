/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-11-08 15: 50:57
 ******************************************************/
using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.Serialization;
using System.Text;
using TinyFx.Data;
using TinyFx.Data.MySql;

namespace Xxyy.DAL
{
    #region EO
    /// <summary>
    /// 用户货币表
    /// 【表 s_user_currency 的实体类】
    /// </summary>
    [DataContract]
    public class S_user_currencyEO : IRowMapper<S_user_currencyEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public S_user_currencyEO()
        {
            this.CurrencyType = 0;
            this.Balance = 0;
            this.TotalBetAmount = 0;
            this.TotalWinAmount = 0;
            this.TotalChangeAmount = 0;
            this.TotalPayAmount = 0;
            this.TotalCashAmount = 0;
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private string _originalUserID;
        /// <summary>
        /// 【数据库中的原始主键 UserID 值的副本，用于主键值更新】
        /// </summary>
        public string OriginalUserID
        {
            get { return _originalUserID; }
            set { HasOriginal = true; _originalUserID = value; }
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
            return new Dictionary<string, object>() { { "UserID", UserID }, { "CurrencyID", CurrencyID }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// 用户编码(GUID)
        /// 【主键 varchar(38)】
        /// </summary>
        [DataMember(Order = 1)]
        public string UserID { get; set; }
        /// <summary>
        /// 货币类型（货币缩写USD）
        /// 【主键 varchar(5)】
        /// </summary>
        [DataMember(Order = 2)]
        public string CurrencyID { get; set; }
        /// <summary>
        /// 货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 3)]
        public int CurrencyType { get; set; }
        /// <summary>
        /// 账户货币数量
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 4)]
        public long Balance { get; set; }
        /// <summary>
        /// 下注总额
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 5)]
        public long TotalBetAmount { get; set; }
        /// <summary>
        /// 返奖总额
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 6)]
        public long TotalWinAmount { get; set; }
        /// <summary>
        /// 变化总额
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 7)]
        public long TotalChangeAmount { get; set; }
        /// <summary>
        /// 充值总额
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 8)]
        public long TotalPayAmount { get; set; }
        /// <summary>
        /// 提现总额
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 9)]
        public long TotalCashAmount { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public S_user_currencyEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static S_user_currencyEO MapDataReader(IDataReader reader)
        {
            S_user_currencyEO ret = new S_user_currencyEO();
            ret.UserID = reader.ToString("UserID");
            ret.OriginalUserID = ret.UserID;
            ret.CurrencyID = reader.ToString("CurrencyID");
            ret.OriginalCurrencyID = ret.CurrencyID;
            ret.CurrencyType = reader.ToInt32("CurrencyType");
            ret.Balance = reader.ToInt64("Balance");
            ret.TotalBetAmount = reader.ToInt64("TotalBetAmount");
            ret.TotalWinAmount = reader.ToInt64("TotalWinAmount");
            ret.TotalChangeAmount = reader.ToInt64("TotalChangeAmount");
            ret.TotalPayAmount = reader.ToInt64("TotalPayAmount");
            ret.TotalCashAmount = reader.ToInt64("TotalCashAmount");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// 用户货币表
    /// 【表 s_user_currency 的操作类】
    /// </summary>
    public class S_user_currencyMO : MySqlTableMO<S_user_currencyEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`s_user_currency`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public S_user_currencyMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public S_user_currencyMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public S_user_currencyMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(S_user_currencyEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(S_user_currencyEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(S_user_currencyEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`UserID`, `CurrencyID`, `CurrencyType`, `Balance`, `TotalBetAmount`, `TotalWinAmount`, `TotalChangeAmount`, `TotalPayAmount`, `TotalCashAmount`) VALUE (@UserID, @CurrencyID, @CurrencyType, @Balance, @TotalBetAmount, @TotalWinAmount, @TotalChangeAmount, @TotalPayAmount, @TotalCashAmount);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyType", item.CurrencyType, MySqlDbType.Int32),
                Database.CreateInParameter("@Balance", item.Balance, MySqlDbType.Int64),
                Database.CreateInParameter("@TotalBetAmount", item.TotalBetAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@TotalWinAmount", item.TotalWinAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@TotalChangeAmount", item.TotalChangeAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@TotalPayAmount", item.TotalPayAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@TotalCashAmount", item.TotalCashAmount, MySqlDbType.Int64),
            };
        }
        public int AddByBatch(IEnumerable<S_user_currencyEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<S_user_currencyEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_user_currencyEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`UserID`, `CurrencyID`, `CurrencyType`, `Balance`, `TotalBetAmount`, `TotalWinAmount`, `TotalChangeAmount`, `TotalPayAmount`, `TotalCashAmount`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"('{item.UserID}','{item.CurrencyID}',{item.CurrencyType},{item.Balance},{item.TotalBetAmount},{item.TotalWinAmount},{item.TotalChangeAmount},{item.TotalPayAmount},{item.TotalCashAmount}),");
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
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(string userID, string currencyID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(userID, currencyID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(string userID, string currencyID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(userID, currencyID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(string userID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(S_user_currencyEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.UserID, item.CurrencyID, tm_);
        }
        public async Task<int> RemoveAsync(S_user_currencyEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.UserID, item.CurrencyID, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
        #region RemoveByUserID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByUserID(string userID, TransactionManager tm_ = null)
        {
            RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByUserIDAsync(string userID, TransactionManager tm_ = null)
        {
            RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByUserIDData(string userID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
        }
        #endregion // RemoveByUserID
        #region RemoveByCurrencyID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
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
        #region RemoveByCurrencyType
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByCurrencyType(int currencyType, TransactionManager tm_ = null)
        {
            RepairRemoveByCurrencyTypeData(currencyType, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByCurrencyTypeAsync(int currencyType, TransactionManager tm_ = null)
        {
            RepairRemoveByCurrencyTypeData(currencyType, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByCurrencyTypeData(int currencyType, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `CurrencyType` = @CurrencyType";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32));
        }
        #endregion // RemoveByCurrencyType
        #region RemoveByBalance
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "balance">账户货币数量</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBalance(long balance, TransactionManager tm_ = null)
        {
            RepairRemoveByBalanceData(balance, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBalanceAsync(long balance, TransactionManager tm_ = null)
        {
            RepairRemoveByBalanceData(balance, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBalanceData(long balance, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Balance` = @Balance";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Balance", balance, MySqlDbType.Int64));
        }
        #endregion // RemoveByBalance
        #region RemoveByTotalBetAmount
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "totalBetAmount">下注总额</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByTotalBetAmount(long totalBetAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByTotalBetAmountData(totalBetAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByTotalBetAmountAsync(long totalBetAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByTotalBetAmountData(totalBetAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByTotalBetAmountData(long totalBetAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `TotalBetAmount` = @TotalBetAmount";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64));
        }
        #endregion // RemoveByTotalBetAmount
        #region RemoveByTotalWinAmount
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "totalWinAmount">返奖总额</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByTotalWinAmount(long totalWinAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByTotalWinAmountData(totalWinAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByTotalWinAmountAsync(long totalWinAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByTotalWinAmountData(totalWinAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByTotalWinAmountData(long totalWinAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `TotalWinAmount` = @TotalWinAmount";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64));
        }
        #endregion // RemoveByTotalWinAmount
        #region RemoveByTotalChangeAmount
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "totalChangeAmount">变化总额</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByTotalChangeAmount(long totalChangeAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByTotalChangeAmountData(totalChangeAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByTotalChangeAmountAsync(long totalChangeAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByTotalChangeAmountData(totalChangeAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByTotalChangeAmountData(long totalChangeAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `TotalChangeAmount` = @TotalChangeAmount";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64));
        }
        #endregion // RemoveByTotalChangeAmount
        #region RemoveByTotalPayAmount
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "totalPayAmount">充值总额</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByTotalPayAmount(long totalPayAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByTotalPayAmountData(totalPayAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByTotalPayAmountAsync(long totalPayAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByTotalPayAmountData(totalPayAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByTotalPayAmountData(long totalPayAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `TotalPayAmount` = @TotalPayAmount";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64));
        }
        #endregion // RemoveByTotalPayAmount
        #region RemoveByTotalCashAmount
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "totalCashAmount">提现总额</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByTotalCashAmount(long totalCashAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByTotalCashAmountData(totalCashAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByTotalCashAmountAsync(long totalCashAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByTotalCashAmountData(totalCashAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByTotalCashAmountData(long totalCashAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `TotalCashAmount` = @TotalCashAmount";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64));
        }
        #endregion // RemoveByTotalCashAmount
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
        public int Put(S_user_currencyEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(S_user_currencyEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(S_user_currencyEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `UserID` = @UserID, `CurrencyID` = @CurrencyID, `CurrencyType` = @CurrencyType, `Balance` = @Balance, `TotalBetAmount` = @TotalBetAmount, `TotalWinAmount` = @TotalWinAmount, `TotalChangeAmount` = @TotalChangeAmount, `TotalPayAmount` = @TotalPayAmount, `TotalCashAmount` = @TotalCashAmount WHERE `UserID` = @UserID_Original AND `CurrencyID` = @CurrencyID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyType", item.CurrencyType, MySqlDbType.Int32),
                Database.CreateInParameter("@Balance", item.Balance, MySqlDbType.Int64),
                Database.CreateInParameter("@TotalBetAmount", item.TotalBetAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@TotalWinAmount", item.TotalWinAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@TotalChangeAmount", item.TotalChangeAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@TotalPayAmount", item.TotalPayAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@TotalCashAmount", item.TotalCashAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID_Original", item.HasOriginal ? item.OriginalCurrencyID : item.CurrencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<S_user_currencyEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<S_user_currencyEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string userID, string currencyID, string set_, params object[] values_)
        {
            return Put(set_, "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", ConcatValues(values_, userID, currencyID));
        }
        public async Task<int> PutByPKAsync(string userID, string currencyID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", ConcatValues(values_, userID, currencyID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string userID, string currencyID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, userID, currencyID));
        }
        public async Task<int> PutByPKAsync(string userID, string currencyID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, userID, currencyID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string userID, string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return Put(set_, "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(string userID, string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return await PutAsync(set_, "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutUserID

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutUserID(string userID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
            var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutUserIDAsync(string userID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
            var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutUserID
        #region PutCurrencyID

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
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
        #region PutCurrencyType
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutCurrencyTypeByPK(string userID, string currencyID, int currencyType, TransactionManager tm_ = null)
        {
            RepairPutCurrencyTypeByPKData(userID, currencyID, currencyType, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutCurrencyTypeByPKAsync(string userID, string currencyID, int currencyType, TransactionManager tm_ = null)
        {
            RepairPutCurrencyTypeByPKData(userID, currencyID, currencyType, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutCurrencyTypeByPKData(string userID, string currencyID, int currencyType, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `CurrencyType` = @CurrencyType  WHERE `UserID` = @UserID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutCurrencyType(int currencyType, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `CurrencyType` = @CurrencyType";
            var parameter_ = Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutCurrencyTypeAsync(int currencyType, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `CurrencyType` = @CurrencyType";
            var parameter_ = Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutCurrencyType
        #region PutBalance
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// /// <param name = "balance">账户货币数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBalanceByPK(string userID, string currencyID, long balance, TransactionManager tm_ = null)
        {
            RepairPutBalanceByPKData(userID, currencyID, balance, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBalanceByPKAsync(string userID, string currencyID, long balance, TransactionManager tm_ = null)
        {
            RepairPutBalanceByPKData(userID, currencyID, balance, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBalanceByPKData(string userID, string currencyID, long balance, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Balance` = @Balance  WHERE `UserID` = @UserID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Balance", balance, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "balance">账户货币数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBalance(long balance, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Balance` = @Balance";
            var parameter_ = Database.CreateInParameter("@Balance", balance, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBalanceAsync(long balance, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Balance` = @Balance";
            var parameter_ = Database.CreateInParameter("@Balance", balance, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBalance
        #region PutTotalBetAmount
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// /// <param name = "totalBetAmount">下注总额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutTotalBetAmountByPK(string userID, string currencyID, long totalBetAmount, TransactionManager tm_ = null)
        {
            RepairPutTotalBetAmountByPKData(userID, currencyID, totalBetAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutTotalBetAmountByPKAsync(string userID, string currencyID, long totalBetAmount, TransactionManager tm_ = null)
        {
            RepairPutTotalBetAmountByPKData(userID, currencyID, totalBetAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutTotalBetAmountByPKData(string userID, string currencyID, long totalBetAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `TotalBetAmount` = @TotalBetAmount  WHERE `UserID` = @UserID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "totalBetAmount">下注总额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutTotalBetAmount(long totalBetAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `TotalBetAmount` = @TotalBetAmount";
            var parameter_ = Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutTotalBetAmountAsync(long totalBetAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `TotalBetAmount` = @TotalBetAmount";
            var parameter_ = Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutTotalBetAmount
        #region PutTotalWinAmount
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// /// <param name = "totalWinAmount">返奖总额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutTotalWinAmountByPK(string userID, string currencyID, long totalWinAmount, TransactionManager tm_ = null)
        {
            RepairPutTotalWinAmountByPKData(userID, currencyID, totalWinAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutTotalWinAmountByPKAsync(string userID, string currencyID, long totalWinAmount, TransactionManager tm_ = null)
        {
            RepairPutTotalWinAmountByPKData(userID, currencyID, totalWinAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutTotalWinAmountByPKData(string userID, string currencyID, long totalWinAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `TotalWinAmount` = @TotalWinAmount  WHERE `UserID` = @UserID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "totalWinAmount">返奖总额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutTotalWinAmount(long totalWinAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `TotalWinAmount` = @TotalWinAmount";
            var parameter_ = Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutTotalWinAmountAsync(long totalWinAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `TotalWinAmount` = @TotalWinAmount";
            var parameter_ = Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutTotalWinAmount
        #region PutTotalChangeAmount
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// /// <param name = "totalChangeAmount">变化总额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutTotalChangeAmountByPK(string userID, string currencyID, long totalChangeAmount, TransactionManager tm_ = null)
        {
            RepairPutTotalChangeAmountByPKData(userID, currencyID, totalChangeAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutTotalChangeAmountByPKAsync(string userID, string currencyID, long totalChangeAmount, TransactionManager tm_ = null)
        {
            RepairPutTotalChangeAmountByPKData(userID, currencyID, totalChangeAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutTotalChangeAmountByPKData(string userID, string currencyID, long totalChangeAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `TotalChangeAmount` = @TotalChangeAmount  WHERE `UserID` = @UserID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "totalChangeAmount">变化总额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutTotalChangeAmount(long totalChangeAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `TotalChangeAmount` = @TotalChangeAmount";
            var parameter_ = Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutTotalChangeAmountAsync(long totalChangeAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `TotalChangeAmount` = @TotalChangeAmount";
            var parameter_ = Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutTotalChangeAmount
        #region PutTotalPayAmount
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// /// <param name = "totalPayAmount">充值总额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutTotalPayAmountByPK(string userID, string currencyID, long totalPayAmount, TransactionManager tm_ = null)
        {
            RepairPutTotalPayAmountByPKData(userID, currencyID, totalPayAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutTotalPayAmountByPKAsync(string userID, string currencyID, long totalPayAmount, TransactionManager tm_ = null)
        {
            RepairPutTotalPayAmountByPKData(userID, currencyID, totalPayAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutTotalPayAmountByPKData(string userID, string currencyID, long totalPayAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `TotalPayAmount` = @TotalPayAmount  WHERE `UserID` = @UserID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "totalPayAmount">充值总额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutTotalPayAmount(long totalPayAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `TotalPayAmount` = @TotalPayAmount";
            var parameter_ = Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutTotalPayAmountAsync(long totalPayAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `TotalPayAmount` = @TotalPayAmount";
            var parameter_ = Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutTotalPayAmount
        #region PutTotalCashAmount
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// /// <param name = "totalCashAmount">提现总额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutTotalCashAmountByPK(string userID, string currencyID, long totalCashAmount, TransactionManager tm_ = null)
        {
            RepairPutTotalCashAmountByPKData(userID, currencyID, totalCashAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutTotalCashAmountByPKAsync(string userID, string currencyID, long totalCashAmount, TransactionManager tm_ = null)
        {
            RepairPutTotalCashAmountByPKData(userID, currencyID, totalCashAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutTotalCashAmountByPKData(string userID, string currencyID, long totalCashAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `TotalCashAmount` = @TotalCashAmount  WHERE `UserID` = @UserID AND `CurrencyID` = @CurrencyID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "totalCashAmount">提现总额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutTotalCashAmount(long totalCashAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `TotalCashAmount` = @TotalCashAmount";
            var parameter_ = Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutTotalCashAmountAsync(long totalCashAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `TotalCashAmount` = @TotalCashAmount";
            var parameter_ = Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutTotalCashAmount
        #endregion // PutXXX
        #endregion // Put

        #region Set

        /// <summary>
        /// 插入或者更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>true:插入操作；false:更新操作</return>
        public bool Set(S_user_currencyEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.UserID, item.CurrencyID) == null)
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
        public async Task<bool> SetAsync(S_user_currencyEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.UserID, item.CurrencyID) == null)
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
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public S_user_currencyEO GetByPK(string userID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(userID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        public async Task<S_user_currencyEO> GetByPKAsync(string userID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(userID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        private void RepairGetByPKData(string userID, string currencyID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`UserID` = @UserID AND `CurrencyID` = @CurrencyID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 UserID（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetUserIDByPK(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`UserID`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<string> GetUserIDByPKAsync(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`UserID`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 CurrencyID（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetCurrencyIDByPK(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`CurrencyID`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<string> GetCurrencyIDByPKAsync(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`CurrencyID`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 CurrencyType（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetCurrencyTypeByPK(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)GetScalar("`CurrencyType`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<int> GetCurrencyTypeByPKAsync(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (int)await GetScalarAsync("`CurrencyType`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Balance（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetBalanceByPK(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (long)GetScalar("`Balance`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<long> GetBalanceByPKAsync(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (long)await GetScalarAsync("`Balance`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 TotalBetAmount（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetTotalBetAmountByPK(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (long)GetScalar("`TotalBetAmount`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<long> GetTotalBetAmountByPKAsync(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (long)await GetScalarAsync("`TotalBetAmount`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 TotalWinAmount（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetTotalWinAmountByPK(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (long)GetScalar("`TotalWinAmount`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<long> GetTotalWinAmountByPKAsync(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (long)await GetScalarAsync("`TotalWinAmount`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 TotalChangeAmount（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetTotalChangeAmountByPK(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (long)GetScalar("`TotalChangeAmount`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<long> GetTotalChangeAmountByPKAsync(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (long)await GetScalarAsync("`TotalChangeAmount`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 TotalPayAmount（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetTotalPayAmountByPK(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (long)GetScalar("`TotalPayAmount`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<long> GetTotalPayAmountByPKAsync(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (long)await GetScalarAsync("`TotalPayAmount`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 TotalCashAmount（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetTotalCashAmountByPK(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (long)GetScalar("`TotalCashAmount`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        public async Task<long> GetTotalCashAmountByPKAsync(string userID, string currencyID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
            };
            return (long)await GetScalarAsync("`TotalCashAmount`", "`UserID` = @UserID AND `CurrencyID` = @CurrencyID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByUserID

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByUserID(string userID)
        {
            return GetByUserID(userID, 0, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByUserIDAsync(string userID)
        {
            return await GetByUserIDAsync(userID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByUserID(string userID, TransactionManager tm_)
        {
            return GetByUserID(userID, 0, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
        {
            return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByUserID(string userID, int top_)
        {
            return GetByUserID(userID, top_, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByUserIDAsync(string userID, int top_)
        {
            return await GetByUserIDAsync(userID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByUserID(string userID, int top_, TransactionManager tm_)
        {
            return GetByUserID(userID, top_, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
        {
            return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByUserID(string userID, string sort_)
        {
            return GetByUserID(userID, 0, sort_, null);
        }
        public async Task<List<S_user_currencyEO>> GetByUserIDAsync(string userID, string sort_)
        {
            return await GetByUserIDAsync(userID, 0, sort_, null);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
        {
            return GetByUserID(userID, 0, sort_, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
        {
            return await GetByUserIDAsync(userID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        public async Task<List<S_user_currencyEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        #endregion // GetByUserID
        #region GetByCurrencyID

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByCurrencyID(string currencyID)
        {
            return GetByCurrencyID(currencyID, 0, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByCurrencyIDAsync(string currencyID)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByCurrencyID(string currencyID, int top_)
        {
            return GetByCurrencyID(currencyID, top_, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByCurrencyIDAsync(string currencyID, int top_)
        {
            return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
        {
            return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByCurrencyID(string currencyID, string sort_)
        {
            return GetByCurrencyID(currencyID, 0, sort_, null);
        }
        public async Task<List<S_user_currencyEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, 0, sort_, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        public async Task<List<S_user_currencyEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        #endregion // GetByCurrencyID
        #region GetByCurrencyType

        /// <summary>
        /// 按 CurrencyType（字段） 查询
        /// </summary>
        /// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByCurrencyType(int currencyType)
        {
            return GetByCurrencyType(currencyType, 0, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByCurrencyTypeAsync(int currencyType)
        {
            return await GetByCurrencyTypeAsync(currencyType, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 CurrencyType（字段） 查询
        /// </summary>
        /// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByCurrencyType(int currencyType, TransactionManager tm_)
        {
            return GetByCurrencyType(currencyType, 0, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByCurrencyTypeAsync(int currencyType, TransactionManager tm_)
        {
            return await GetByCurrencyTypeAsync(currencyType, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CurrencyType（字段） 查询
        /// </summary>
        /// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByCurrencyType(int currencyType, int top_)
        {
            return GetByCurrencyType(currencyType, top_, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByCurrencyTypeAsync(int currencyType, int top_)
        {
            return await GetByCurrencyTypeAsync(currencyType, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 CurrencyType（字段） 查询
        /// </summary>
        /// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByCurrencyType(int currencyType, int top_, TransactionManager tm_)
        {
            return GetByCurrencyType(currencyType, top_, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByCurrencyTypeAsync(int currencyType, int top_, TransactionManager tm_)
        {
            return await GetByCurrencyTypeAsync(currencyType, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CurrencyType（字段） 查询
        /// </summary>
        /// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByCurrencyType(int currencyType, string sort_)
        {
            return GetByCurrencyType(currencyType, 0, sort_, null);
        }
        public async Task<List<S_user_currencyEO>> GetByCurrencyTypeAsync(int currencyType, string sort_)
        {
            return await GetByCurrencyTypeAsync(currencyType, 0, sort_, null);
        }

        /// <summary>
        /// 按 CurrencyType（字段） 查询
        /// </summary>
        /// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByCurrencyType(int currencyType, string sort_, TransactionManager tm_)
        {
            return GetByCurrencyType(currencyType, 0, sort_, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByCurrencyTypeAsync(int currencyType, string sort_, TransactionManager tm_)
        {
            return await GetByCurrencyTypeAsync(currencyType, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 CurrencyType（字段） 查询
        /// </summary>
        /// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByCurrencyType(int currencyType, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`CurrencyType` = @CurrencyType", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        public async Task<List<S_user_currencyEO>> GetByCurrencyTypeAsync(int currencyType, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`CurrencyType` = @CurrencyType", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        #endregion // GetByCurrencyType
        #region GetByBalance

        /// <summary>
        /// 按 Balance（字段） 查询
        /// </summary>
        /// /// <param name = "balance">账户货币数量</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByBalance(long balance)
        {
            return GetByBalance(balance, 0, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByBalanceAsync(long balance)
        {
            return await GetByBalanceAsync(balance, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Balance（字段） 查询
        /// </summary>
        /// /// <param name = "balance">账户货币数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByBalance(long balance, TransactionManager tm_)
        {
            return GetByBalance(balance, 0, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByBalanceAsync(long balance, TransactionManager tm_)
        {
            return await GetByBalanceAsync(balance, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Balance（字段） 查询
        /// </summary>
        /// /// <param name = "balance">账户货币数量</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByBalance(long balance, int top_)
        {
            return GetByBalance(balance, top_, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByBalanceAsync(long balance, int top_)
        {
            return await GetByBalanceAsync(balance, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Balance（字段） 查询
        /// </summary>
        /// /// <param name = "balance">账户货币数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByBalance(long balance, int top_, TransactionManager tm_)
        {
            return GetByBalance(balance, top_, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByBalanceAsync(long balance, int top_, TransactionManager tm_)
        {
            return await GetByBalanceAsync(balance, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Balance（字段） 查询
        /// </summary>
        /// /// <param name = "balance">账户货币数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByBalance(long balance, string sort_)
        {
            return GetByBalance(balance, 0, sort_, null);
        }
        public async Task<List<S_user_currencyEO>> GetByBalanceAsync(long balance, string sort_)
        {
            return await GetByBalanceAsync(balance, 0, sort_, null);
        }

        /// <summary>
        /// 按 Balance（字段） 查询
        /// </summary>
        /// /// <param name = "balance">账户货币数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByBalance(long balance, string sort_, TransactionManager tm_)
        {
            return GetByBalance(balance, 0, sort_, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByBalanceAsync(long balance, string sort_, TransactionManager tm_)
        {
            return await GetByBalanceAsync(balance, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Balance（字段） 查询
        /// </summary>
        /// /// <param name = "balance">账户货币数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByBalance(long balance, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Balance` = @Balance", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Balance", balance, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        public async Task<List<S_user_currencyEO>> GetByBalanceAsync(long balance, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Balance` = @Balance", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Balance", balance, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        #endregion // GetByBalance
        #region GetByTotalBetAmount

        /// <summary>
        /// 按 TotalBetAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalBetAmount">下注总额</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalBetAmount(long totalBetAmount)
        {
            return GetByTotalBetAmount(totalBetAmount, 0, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalBetAmountAsync(long totalBetAmount)
        {
            return await GetByTotalBetAmountAsync(totalBetAmount, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 TotalBetAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalBetAmount">下注总额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalBetAmount(long totalBetAmount, TransactionManager tm_)
        {
            return GetByTotalBetAmount(totalBetAmount, 0, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalBetAmountAsync(long totalBetAmount, TransactionManager tm_)
        {
            return await GetByTotalBetAmountAsync(totalBetAmount, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 TotalBetAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalBetAmount">下注总额</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalBetAmount(long totalBetAmount, int top_)
        {
            return GetByTotalBetAmount(totalBetAmount, top_, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalBetAmountAsync(long totalBetAmount, int top_)
        {
            return await GetByTotalBetAmountAsync(totalBetAmount, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 TotalBetAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalBetAmount">下注总额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalBetAmount(long totalBetAmount, int top_, TransactionManager tm_)
        {
            return GetByTotalBetAmount(totalBetAmount, top_, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalBetAmountAsync(long totalBetAmount, int top_, TransactionManager tm_)
        {
            return await GetByTotalBetAmountAsync(totalBetAmount, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 TotalBetAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalBetAmount">下注总额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalBetAmount(long totalBetAmount, string sort_)
        {
            return GetByTotalBetAmount(totalBetAmount, 0, sort_, null);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalBetAmountAsync(long totalBetAmount, string sort_)
        {
            return await GetByTotalBetAmountAsync(totalBetAmount, 0, sort_, null);
        }

        /// <summary>
        /// 按 TotalBetAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalBetAmount">下注总额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalBetAmount(long totalBetAmount, string sort_, TransactionManager tm_)
        {
            return GetByTotalBetAmount(totalBetAmount, 0, sort_, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalBetAmountAsync(long totalBetAmount, string sort_, TransactionManager tm_)
        {
            return await GetByTotalBetAmountAsync(totalBetAmount, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 TotalBetAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalBetAmount">下注总额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalBetAmount(long totalBetAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`TotalBetAmount` = @TotalBetAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalBetAmountAsync(long totalBetAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`TotalBetAmount` = @TotalBetAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        #endregion // GetByTotalBetAmount
        #region GetByTotalWinAmount

        /// <summary>
        /// 按 TotalWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalWinAmount">返奖总额</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalWinAmount(long totalWinAmount)
        {
            return GetByTotalWinAmount(totalWinAmount, 0, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalWinAmountAsync(long totalWinAmount)
        {
            return await GetByTotalWinAmountAsync(totalWinAmount, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 TotalWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalWinAmount">返奖总额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalWinAmount(long totalWinAmount, TransactionManager tm_)
        {
            return GetByTotalWinAmount(totalWinAmount, 0, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalWinAmountAsync(long totalWinAmount, TransactionManager tm_)
        {
            return await GetByTotalWinAmountAsync(totalWinAmount, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 TotalWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalWinAmount">返奖总额</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalWinAmount(long totalWinAmount, int top_)
        {
            return GetByTotalWinAmount(totalWinAmount, top_, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalWinAmountAsync(long totalWinAmount, int top_)
        {
            return await GetByTotalWinAmountAsync(totalWinAmount, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 TotalWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalWinAmount">返奖总额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalWinAmount(long totalWinAmount, int top_, TransactionManager tm_)
        {
            return GetByTotalWinAmount(totalWinAmount, top_, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalWinAmountAsync(long totalWinAmount, int top_, TransactionManager tm_)
        {
            return await GetByTotalWinAmountAsync(totalWinAmount, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 TotalWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalWinAmount">返奖总额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalWinAmount(long totalWinAmount, string sort_)
        {
            return GetByTotalWinAmount(totalWinAmount, 0, sort_, null);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalWinAmountAsync(long totalWinAmount, string sort_)
        {
            return await GetByTotalWinAmountAsync(totalWinAmount, 0, sort_, null);
        }

        /// <summary>
        /// 按 TotalWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalWinAmount">返奖总额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalWinAmount(long totalWinAmount, string sort_, TransactionManager tm_)
        {
            return GetByTotalWinAmount(totalWinAmount, 0, sort_, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalWinAmountAsync(long totalWinAmount, string sort_, TransactionManager tm_)
        {
            return await GetByTotalWinAmountAsync(totalWinAmount, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 TotalWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalWinAmount">返奖总额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalWinAmount(long totalWinAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`TotalWinAmount` = @TotalWinAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalWinAmountAsync(long totalWinAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`TotalWinAmount` = @TotalWinAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        #endregion // GetByTotalWinAmount
        #region GetByTotalChangeAmount

        /// <summary>
        /// 按 TotalChangeAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalChangeAmount">变化总额</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalChangeAmount(long totalChangeAmount)
        {
            return GetByTotalChangeAmount(totalChangeAmount, 0, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalChangeAmountAsync(long totalChangeAmount)
        {
            return await GetByTotalChangeAmountAsync(totalChangeAmount, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 TotalChangeAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalChangeAmount">变化总额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalChangeAmount(long totalChangeAmount, TransactionManager tm_)
        {
            return GetByTotalChangeAmount(totalChangeAmount, 0, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, TransactionManager tm_)
        {
            return await GetByTotalChangeAmountAsync(totalChangeAmount, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 TotalChangeAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalChangeAmount">变化总额</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalChangeAmount(long totalChangeAmount, int top_)
        {
            return GetByTotalChangeAmount(totalChangeAmount, top_, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, int top_)
        {
            return await GetByTotalChangeAmountAsync(totalChangeAmount, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 TotalChangeAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalChangeAmount">变化总额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalChangeAmount(long totalChangeAmount, int top_, TransactionManager tm_)
        {
            return GetByTotalChangeAmount(totalChangeAmount, top_, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, int top_, TransactionManager tm_)
        {
            return await GetByTotalChangeAmountAsync(totalChangeAmount, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 TotalChangeAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalChangeAmount">变化总额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalChangeAmount(long totalChangeAmount, string sort_)
        {
            return GetByTotalChangeAmount(totalChangeAmount, 0, sort_, null);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, string sort_)
        {
            return await GetByTotalChangeAmountAsync(totalChangeAmount, 0, sort_, null);
        }

        /// <summary>
        /// 按 TotalChangeAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalChangeAmount">变化总额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalChangeAmount(long totalChangeAmount, string sort_, TransactionManager tm_)
        {
            return GetByTotalChangeAmount(totalChangeAmount, 0, sort_, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, string sort_, TransactionManager tm_)
        {
            return await GetByTotalChangeAmountAsync(totalChangeAmount, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 TotalChangeAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalChangeAmount">变化总额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalChangeAmount(long totalChangeAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`TotalChangeAmount` = @TotalChangeAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`TotalChangeAmount` = @TotalChangeAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        #endregion // GetByTotalChangeAmount
        #region GetByTotalPayAmount

        /// <summary>
        /// 按 TotalPayAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalPayAmount">充值总额</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalPayAmount(long totalPayAmount)
        {
            return GetByTotalPayAmount(totalPayAmount, 0, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalPayAmountAsync(long totalPayAmount)
        {
            return await GetByTotalPayAmountAsync(totalPayAmount, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 TotalPayAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalPayAmount">充值总额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalPayAmount(long totalPayAmount, TransactionManager tm_)
        {
            return GetByTotalPayAmount(totalPayAmount, 0, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalPayAmountAsync(long totalPayAmount, TransactionManager tm_)
        {
            return await GetByTotalPayAmountAsync(totalPayAmount, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 TotalPayAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalPayAmount">充值总额</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalPayAmount(long totalPayAmount, int top_)
        {
            return GetByTotalPayAmount(totalPayAmount, top_, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalPayAmountAsync(long totalPayAmount, int top_)
        {
            return await GetByTotalPayAmountAsync(totalPayAmount, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 TotalPayAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalPayAmount">充值总额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalPayAmount(long totalPayAmount, int top_, TransactionManager tm_)
        {
            return GetByTotalPayAmount(totalPayAmount, top_, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalPayAmountAsync(long totalPayAmount, int top_, TransactionManager tm_)
        {
            return await GetByTotalPayAmountAsync(totalPayAmount, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 TotalPayAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalPayAmount">充值总额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalPayAmount(long totalPayAmount, string sort_)
        {
            return GetByTotalPayAmount(totalPayAmount, 0, sort_, null);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalPayAmountAsync(long totalPayAmount, string sort_)
        {
            return await GetByTotalPayAmountAsync(totalPayAmount, 0, sort_, null);
        }

        /// <summary>
        /// 按 TotalPayAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalPayAmount">充值总额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalPayAmount(long totalPayAmount, string sort_, TransactionManager tm_)
        {
            return GetByTotalPayAmount(totalPayAmount, 0, sort_, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalPayAmountAsync(long totalPayAmount, string sort_, TransactionManager tm_)
        {
            return await GetByTotalPayAmountAsync(totalPayAmount, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 TotalPayAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalPayAmount">充值总额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalPayAmount(long totalPayAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`TotalPayAmount` = @TotalPayAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalPayAmountAsync(long totalPayAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`TotalPayAmount` = @TotalPayAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        #endregion // GetByTotalPayAmount
        #region GetByTotalCashAmount

        /// <summary>
        /// 按 TotalCashAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalCashAmount">提现总额</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalCashAmount(long totalCashAmount)
        {
            return GetByTotalCashAmount(totalCashAmount, 0, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalCashAmountAsync(long totalCashAmount)
        {
            return await GetByTotalCashAmountAsync(totalCashAmount, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 TotalCashAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalCashAmount">提现总额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalCashAmount(long totalCashAmount, TransactionManager tm_)
        {
            return GetByTotalCashAmount(totalCashAmount, 0, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalCashAmountAsync(long totalCashAmount, TransactionManager tm_)
        {
            return await GetByTotalCashAmountAsync(totalCashAmount, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 TotalCashAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalCashAmount">提现总额</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalCashAmount(long totalCashAmount, int top_)
        {
            return GetByTotalCashAmount(totalCashAmount, top_, string.Empty, null);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalCashAmountAsync(long totalCashAmount, int top_)
        {
            return await GetByTotalCashAmountAsync(totalCashAmount, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 TotalCashAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalCashAmount">提现总额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalCashAmount(long totalCashAmount, int top_, TransactionManager tm_)
        {
            return GetByTotalCashAmount(totalCashAmount, top_, string.Empty, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalCashAmountAsync(long totalCashAmount, int top_, TransactionManager tm_)
        {
            return await GetByTotalCashAmountAsync(totalCashAmount, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 TotalCashAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalCashAmount">提现总额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalCashAmount(long totalCashAmount, string sort_)
        {
            return GetByTotalCashAmount(totalCashAmount, 0, sort_, null);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalCashAmountAsync(long totalCashAmount, string sort_)
        {
            return await GetByTotalCashAmountAsync(totalCashAmount, 0, sort_, null);
        }

        /// <summary>
        /// 按 TotalCashAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalCashAmount">提现总额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalCashAmount(long totalCashAmount, string sort_, TransactionManager tm_)
        {
            return GetByTotalCashAmount(totalCashAmount, 0, sort_, tm_);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalCashAmountAsync(long totalCashAmount, string sort_, TransactionManager tm_)
        {
            return await GetByTotalCashAmountAsync(totalCashAmount, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 TotalCashAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalCashAmount">提现总额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_user_currencyEO> GetByTotalCashAmount(long totalCashAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`TotalCashAmount` = @TotalCashAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        public async Task<List<S_user_currencyEO>> GetByTotalCashAmountAsync(long totalCashAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`TotalCashAmount` = @TotalCashAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_currencyEO.MapDataReader);
        }
        #endregion // GetByTotalCashAmount
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
