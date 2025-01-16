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
    /// 用户游戏数据，根据chipId保存
    /// 【表 gmf_user_chips_data 的实体类】
    /// </summary>
    [DataContract]
    public class Gmf_user_chips_dataEO : IRowMapper<Gmf_user_chips_dataEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Gmf_user_chips_dataEO()
        {
            this.BingoTotal = 0;
            this.BingoLock = 0;
            this.BingoHitLine = 0;
            this.BingoKeepNum = 0;
            this.BonusTotal = 0;
            this.BonusLock = 0;
            this.FreeSpinNum = 0;
            this.RetriggerNum = 0;
            this.FreeSpinAmount = 0;
            this.BaseLock = 0;
            this.Status = 0;
            this.RecDate = DateTime.Now;
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

        private int _originalChipsID;
        /// <summary>
        /// 【数据库中的原始主键 ChipsID 值的副本，用于主键值更新】
        /// </summary>
        public int OriginalChipsID
        {
            get { return _originalChipsID; }
            set { HasOriginal = true; _originalChipsID = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "UserID", UserID }, { "ChipsID", ChipsID }, };
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
        /// 筹码编码
        /// 【主键 int】
        /// </summary>
        [DataMember(Order = 2)]
        public int ChipsID { get; set; }
        /// <summary>
        /// Bingo累计
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 3)]
        public long BingoTotal { get; set; }
        /// <summary>
        /// Bingo部分锁定金额
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 4)]
        public long BingoLock { get; set; }
        /// <summary>
        /// Bingo面板的25个球,按顺序|分割
        /// 【字段 varchar(100)】
        /// </summary>
        [DataMember(Order = 5)]
        public string BingoPanelNums { get; set; }
        /// <summary>
        /// Bingo中奖线
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 6)]
        public int BingoHitLine { get; set; }
        /// <summary>
        /// Bingo保留的数字
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 7)]
        public int BingoKeepNum { get; set; }
        /// <summary>
        /// Bingo保留的数字
        /// 【字段 varchar(100)】
        /// </summary>
        [DataMember(Order = 8)]
        public string BingoKeepNums { get; set; }
        /// <summary>
        /// Bingo已出的75个数字,按顺序|分割
        /// 【字段 varchar(255)】
        /// </summary>
        [DataMember(Order = 9)]
        public string BingoHasNums { get; set; }
        /// <summary>
        /// Bonus累计
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 10)]
        public long BonusTotal { get; set; }
        /// <summary>
        /// Bonus部分锁定金额
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 11)]
        public long BonusLock { get; set; }
        /// <summary>
        /// freespin剩余数量
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 12)]
        public int FreeSpinNum { get; set; }
        /// <summary>
        /// retrigger剩余数量
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 13)]
        public int RetriggerNum { get; set; }
        /// <summary>
        /// retrigger出现顺序
        /// 【字段 varchar(255)】
        /// </summary>
        [DataMember(Order = 14)]
        public string RetriggerList { get; set; }
        /// <summary>
        /// freespin环节总盈利
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 15)]
        public long FreeSpinAmount { get; set; }
        /// <summary>
        /// base部分锁定金额
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 16)]
        public long BaseLock { get; set; }
        /// <summary>
        /// 最后一次slot明细编码
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 17)]
        public long? SlotID { get; set; }
        /// <summary>
        /// 状态1-正常2-锁定中3-异常用户账户错误
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 18)]
        public int Status { get; set; }
        /// <summary>
        /// 记录时间
        /// 【字段 datetime】
        /// </summary>
        [DataMember(Order = 19)]
        public DateTime RecDate { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public Gmf_user_chips_dataEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static Gmf_user_chips_dataEO MapDataReader(IDataReader reader)
        {
            Gmf_user_chips_dataEO ret = new Gmf_user_chips_dataEO();
            ret.UserID = reader.ToString("UserID");
            ret.OriginalUserID = ret.UserID;
            ret.ChipsID = reader.ToInt32("ChipsID");
            ret.OriginalChipsID = ret.ChipsID;
            ret.BingoTotal = reader.ToInt64("BingoTotal");
            ret.BingoLock = reader.ToInt64("BingoLock");
            ret.BingoPanelNums = reader.ToString("BingoPanelNums");
            ret.BingoHitLine = reader.ToInt32("BingoHitLine");
            ret.BingoKeepNum = reader.ToInt32("BingoKeepNum");
            ret.BingoKeepNums = reader.ToString("BingoKeepNums");
            ret.BingoHasNums = reader.ToString("BingoHasNums");
            ret.BonusTotal = reader.ToInt64("BonusTotal");
            ret.BonusLock = reader.ToInt64("BonusLock");
            ret.FreeSpinNum = reader.ToInt32("FreeSpinNum");
            ret.RetriggerNum = reader.ToInt32("RetriggerNum");
            ret.RetriggerList = reader.ToString("RetriggerList");
            ret.FreeSpinAmount = reader.ToInt64("FreeSpinAmount");
            ret.BaseLock = reader.ToInt64("BaseLock");
            ret.SlotID = reader.ToInt64N("SlotID");
            ret.Status = reader.ToInt32("Status");
            ret.RecDate = reader.ToDateTime("RecDate");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// 用户游戏数据，根据chipId保存
    /// 【表 gmf_user_chips_data 的操作类】
    /// </summary>
    public class Gmf_user_chips_dataMO : MySqlTableMO<Gmf_user_chips_dataEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`gmf_user_chips_data`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public Gmf_user_chips_dataMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public Gmf_user_chips_dataMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public Gmf_user_chips_dataMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(Gmf_user_chips_dataEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(Gmf_user_chips_dataEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(Gmf_user_chips_dataEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`UserID`, `ChipsID`, `BingoTotal`, `BingoLock`, `BingoPanelNums`, `BingoHitLine`, `BingoKeepNum`, `BingoKeepNums`, `BingoHasNums`, `BonusTotal`, `BonusLock`, `FreeSpinNum`, `RetriggerNum`, `RetriggerList`, `FreeSpinAmount`, `BaseLock`, `SlotID`, `Status`, `RecDate`) VALUE (@UserID, @ChipsID, @BingoTotal, @BingoLock, @BingoPanelNums, @BingoHitLine, @BingoKeepNum, @BingoKeepNums, @BingoHasNums, @BonusTotal, @BonusLock, @FreeSpinNum, @RetriggerNum, @RetriggerList, @FreeSpinAmount, @BaseLock, @SlotID, @Status, @RecDate);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@BingoTotal", item.BingoTotal, MySqlDbType.Int64),
                Database.CreateInParameter("@BingoLock", item.BingoLock, MySqlDbType.Int64),
                Database.CreateInParameter("@BingoPanelNums", item.BingoPanelNums != null ? item.BingoPanelNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@BingoHitLine", item.BingoHitLine, MySqlDbType.Byte),
                Database.CreateInParameter("@BingoKeepNum", item.BingoKeepNum, MySqlDbType.Byte),
                Database.CreateInParameter("@BingoKeepNums", item.BingoKeepNums != null ? item.BingoKeepNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@BingoHasNums", item.BingoHasNums != null ? item.BingoHasNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@BonusTotal", item.BonusTotal, MySqlDbType.Int64),
                Database.CreateInParameter("@BonusLock", item.BonusLock, MySqlDbType.Int64),
                Database.CreateInParameter("@FreeSpinNum", item.FreeSpinNum, MySqlDbType.Byte),
                Database.CreateInParameter("@RetriggerNum", item.RetriggerNum, MySqlDbType.Byte),
                Database.CreateInParameter("@RetriggerList", item.RetriggerList != null ? item.RetriggerList : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@FreeSpinAmount", item.FreeSpinAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@BaseLock", item.BaseLock, MySqlDbType.Int64),
                Database.CreateInParameter("@SlotID", item.SlotID.HasValue ? item.SlotID.Value : (object)DBNull.Value, MySqlDbType.Int64),
                Database.CreateInParameter("@Status", item.Status, MySqlDbType.Byte),
                Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
            };
        }
        public int AddByBatch(IEnumerable<Gmf_user_chips_dataEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<Gmf_user_chips_dataEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gmf_user_chips_dataEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`UserID`, `ChipsID`, `BingoTotal`, `BingoLock`, `BingoPanelNums`, `BingoHitLine`, `BingoKeepNum`, `BingoKeepNums`, `BingoHasNums`, `BonusTotal`, `BonusLock`, `FreeSpinNum`, `RetriggerNum`, `RetriggerList`, `FreeSpinAmount`, `BaseLock`, `SlotID`, `Status`, `RecDate`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"('{item.UserID}',{item.ChipsID},{item.BingoTotal},{item.BingoLock},'{item.BingoPanelNums}',{item.BingoHitLine},{item.BingoKeepNum},'{item.BingoKeepNums}','{item.BingoHasNums}',{item.BonusTotal},{item.BonusLock},{item.FreeSpinNum},{item.RetriggerNum},'{item.RetriggerList}',{item.FreeSpinAmount},{item.BaseLock},{item.SlotID?.ToString() ?? null},{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(userID, chipsID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(userID, chipsID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(string userID, int chipsID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(Gmf_user_chips_dataEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.UserID, item.ChipsID, tm_);
        }
        public async Task<int> RemoveAsync(Gmf_user_chips_dataEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.UserID, item.ChipsID, tm_);
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
        #region RemoveByBingoTotal
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoTotal">Bingo累计</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBingoTotal(long bingoTotal, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoTotalData(bingoTotal, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBingoTotalAsync(long bingoTotal, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoTotalData(bingoTotal, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBingoTotalData(long bingoTotal, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BingoTotal` = @BingoTotal";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoTotal", bingoTotal, MySqlDbType.Int64));
        }
        #endregion // RemoveByBingoTotal
        #region RemoveByBingoLock
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoLock">Bingo部分锁定金额</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBingoLock(long bingoLock, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoLockData(bingoLock, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBingoLockAsync(long bingoLock, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoLockData(bingoLock, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBingoLockData(long bingoLock, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BingoLock` = @BingoLock";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoLock", bingoLock, MySqlDbType.Int64));
        }
        #endregion // RemoveByBingoLock
        #region RemoveByBingoPanelNums
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoPanelNums">Bingo面板的25个球,按顺序|分割</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBingoPanelNums(string bingoPanelNums, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoPanelNumsData(bingoPanelNums, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBingoPanelNumsAsync(string bingoPanelNums, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoPanelNumsData(bingoPanelNums, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBingoPanelNumsData(string bingoPanelNums, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (bingoPanelNums != null ? "`BingoPanelNums` = @BingoPanelNums" : "`BingoPanelNums` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (bingoPanelNums != null)
                paras_.Add(Database.CreateInParameter("@BingoPanelNums", bingoPanelNums, MySqlDbType.VarChar));
        }
        #endregion // RemoveByBingoPanelNums
        #region RemoveByBingoHitLine
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoHitLine">Bingo中奖线</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBingoHitLine(int bingoHitLine, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoHitLineData(bingoHitLine, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBingoHitLineAsync(int bingoHitLine, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoHitLineData(bingoHitLine, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBingoHitLineData(int bingoHitLine, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BingoHitLine` = @BingoHitLine";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoHitLine", bingoHitLine, MySqlDbType.Byte));
        }
        #endregion // RemoveByBingoHitLine
        #region RemoveByBingoKeepNum
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoKeepNum">Bingo保留的数字</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBingoKeepNum(int bingoKeepNum, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoKeepNumData(bingoKeepNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBingoKeepNumAsync(int bingoKeepNum, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoKeepNumData(bingoKeepNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBingoKeepNumData(int bingoKeepNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BingoKeepNum` = @BingoKeepNum";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoKeepNum", bingoKeepNum, MySqlDbType.Byte));
        }
        #endregion // RemoveByBingoKeepNum
        #region RemoveByBingoKeepNums
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoKeepNums">Bingo保留的数字</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBingoKeepNums(string bingoKeepNums, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoKeepNumsData(bingoKeepNums, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBingoKeepNumsAsync(string bingoKeepNums, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoKeepNumsData(bingoKeepNums, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBingoKeepNumsData(string bingoKeepNums, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (bingoKeepNums != null ? "`BingoKeepNums` = @BingoKeepNums" : "`BingoKeepNums` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (bingoKeepNums != null)
                paras_.Add(Database.CreateInParameter("@BingoKeepNums", bingoKeepNums, MySqlDbType.VarChar));
        }
        #endregion // RemoveByBingoKeepNums
        #region RemoveByBingoHasNums
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoHasNums">Bingo已出的75个数字,按顺序|分割</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBingoHasNums(string bingoHasNums, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoHasNumsData(bingoHasNums, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBingoHasNumsAsync(string bingoHasNums, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoHasNumsData(bingoHasNums, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBingoHasNumsData(string bingoHasNums, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (bingoHasNums != null ? "`BingoHasNums` = @BingoHasNums" : "`BingoHasNums` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (bingoHasNums != null)
                paras_.Add(Database.CreateInParameter("@BingoHasNums", bingoHasNums, MySqlDbType.VarChar));
        }
        #endregion // RemoveByBingoHasNums
        #region RemoveByBonusTotal
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bonusTotal">Bonus累计</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBonusTotal(long bonusTotal, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusTotalData(bonusTotal, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBonusTotalAsync(long bonusTotal, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusTotalData(bonusTotal, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBonusTotalData(long bonusTotal, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BonusTotal` = @BonusTotal";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusTotal", bonusTotal, MySqlDbType.Int64));
        }
        #endregion // RemoveByBonusTotal
        #region RemoveByBonusLock
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bonusLock">Bonus部分锁定金额</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBonusLock(long bonusLock, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusLockData(bonusLock, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBonusLockAsync(long bonusLock, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusLockData(bonusLock, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBonusLockData(long bonusLock, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BonusLock` = @BonusLock";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusLock", bonusLock, MySqlDbType.Int64));
        }
        #endregion // RemoveByBonusLock
        #region RemoveByFreeSpinNum
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "freeSpinNum">freespin剩余数量</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByFreeSpinNum(int freeSpinNum, TransactionManager tm_ = null)
        {
            RepairRemoveByFreeSpinNumData(freeSpinNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByFreeSpinNumAsync(int freeSpinNum, TransactionManager tm_ = null)
        {
            RepairRemoveByFreeSpinNumData(freeSpinNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByFreeSpinNumData(int freeSpinNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `FreeSpinNum` = @FreeSpinNum";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@FreeSpinNum", freeSpinNum, MySqlDbType.Byte));
        }
        #endregion // RemoveByFreeSpinNum
        #region RemoveByRetriggerNum
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "retriggerNum">retrigger剩余数量</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByRetriggerNum(int retriggerNum, TransactionManager tm_ = null)
        {
            RepairRemoveByRetriggerNumData(retriggerNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByRetriggerNumAsync(int retriggerNum, TransactionManager tm_ = null)
        {
            RepairRemoveByRetriggerNumData(retriggerNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByRetriggerNumData(int retriggerNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `RetriggerNum` = @RetriggerNum";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RetriggerNum", retriggerNum, MySqlDbType.Byte));
        }
        #endregion // RemoveByRetriggerNum
        #region RemoveByRetriggerList
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "retriggerList">retrigger出现顺序</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByRetriggerList(string retriggerList, TransactionManager tm_ = null)
        {
            RepairRemoveByRetriggerListData(retriggerList, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByRetriggerListAsync(string retriggerList, TransactionManager tm_ = null)
        {
            RepairRemoveByRetriggerListData(retriggerList, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByRetriggerListData(string retriggerList, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (retriggerList != null ? "`RetriggerList` = @RetriggerList" : "`RetriggerList` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (retriggerList != null)
                paras_.Add(Database.CreateInParameter("@RetriggerList", retriggerList, MySqlDbType.VarChar));
        }
        #endregion // RemoveByRetriggerList
        #region RemoveByFreeSpinAmount
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "freeSpinAmount">freespin环节总盈利</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByFreeSpinAmount(long freeSpinAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByFreeSpinAmountData(freeSpinAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByFreeSpinAmountAsync(long freeSpinAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByFreeSpinAmountData(freeSpinAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByFreeSpinAmountData(long freeSpinAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `FreeSpinAmount` = @FreeSpinAmount";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@FreeSpinAmount", freeSpinAmount, MySqlDbType.Int64));
        }
        #endregion // RemoveByFreeSpinAmount
        #region RemoveByBaseLock
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "baseLock">base部分锁定金额</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBaseLock(long baseLock, TransactionManager tm_ = null)
        {
            RepairRemoveByBaseLockData(baseLock, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBaseLockAsync(long baseLock, TransactionManager tm_ = null)
        {
            RepairRemoveByBaseLockData(baseLock, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBaseLockData(long baseLock, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BaseLock` = @BaseLock";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BaseLock", baseLock, MySqlDbType.Int64));
        }
        #endregion // RemoveByBaseLock
        #region RemoveBySlotID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "slotID">最后一次slot明细编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveBySlotID(long? slotID, TransactionManager tm_ = null)
        {
            RepairRemoveBySlotIDData(slotID.Value, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveBySlotIDAsync(long? slotID, TransactionManager tm_ = null)
        {
            RepairRemoveBySlotIDData(slotID.Value, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveBySlotIDData(long? slotID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (slotID.HasValue ? "`SlotID` = @SlotID" : "`SlotID` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (slotID.HasValue)
                paras_.Add(Database.CreateInParameter("@SlotID", slotID.Value, MySqlDbType.Int64));
        }
        #endregion // RemoveBySlotID
        #region RemoveByStatus
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "status">状态1-正常2-锁定中3-异常用户账户错误</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByStatus(int status, TransactionManager tm_ = null)
        {
            RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByStatusAsync(int status, TransactionManager tm_ = null)
        {
            RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByStatusData(int status, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Status` = @Status";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Byte));
        }
        #endregion // RemoveByStatus
        #region RemoveByRecDate
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByRecDate(DateTime recDate, TransactionManager tm_ = null)
        {
            RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
        {
            RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByRecDateData(DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `RecDate` = @RecDate";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
        }
        #endregion // RemoveByRecDate
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
        public int Put(Gmf_user_chips_dataEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(Gmf_user_chips_dataEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(Gmf_user_chips_dataEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `UserID` = @UserID, `ChipsID` = @ChipsID, `BingoTotal` = @BingoTotal, `BingoLock` = @BingoLock, `BingoPanelNums` = @BingoPanelNums, `BingoHitLine` = @BingoHitLine, `BingoKeepNum` = @BingoKeepNum, `BingoKeepNums` = @BingoKeepNums, `BingoHasNums` = @BingoHasNums, `BonusTotal` = @BonusTotal, `BonusLock` = @BonusLock, `FreeSpinNum` = @FreeSpinNum, `RetriggerNum` = @RetriggerNum, `RetriggerList` = @RetriggerList, `FreeSpinAmount` = @FreeSpinAmount, `BaseLock` = @BaseLock, `SlotID` = @SlotID, `Status` = @Status WHERE `UserID` = @UserID_Original AND `ChipsID` = @ChipsID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@BingoTotal", item.BingoTotal, MySqlDbType.Int64),
                Database.CreateInParameter("@BingoLock", item.BingoLock, MySqlDbType.Int64),
                Database.CreateInParameter("@BingoPanelNums", item.BingoPanelNums != null ? item.BingoPanelNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@BingoHitLine", item.BingoHitLine, MySqlDbType.Byte),
                Database.CreateInParameter("@BingoKeepNum", item.BingoKeepNum, MySqlDbType.Byte),
                Database.CreateInParameter("@BingoKeepNums", item.BingoKeepNums != null ? item.BingoKeepNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@BingoHasNums", item.BingoHasNums != null ? item.BingoHasNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@BonusTotal", item.BonusTotal, MySqlDbType.Int64),
                Database.CreateInParameter("@BonusLock", item.BonusLock, MySqlDbType.Int64),
                Database.CreateInParameter("@FreeSpinNum", item.FreeSpinNum, MySqlDbType.Byte),
                Database.CreateInParameter("@RetriggerNum", item.RetriggerNum, MySqlDbType.Byte),
                Database.CreateInParameter("@RetriggerList", item.RetriggerList != null ? item.RetriggerList : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@FreeSpinAmount", item.FreeSpinAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@BaseLock", item.BaseLock, MySqlDbType.Int64),
                Database.CreateInParameter("@SlotID", item.SlotID.HasValue ? item.SlotID.Value : (object)DBNull.Value, MySqlDbType.Int64),
                Database.CreateInParameter("@Status", item.Status, MySqlDbType.Byte),
                Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID_Original", item.HasOriginal ? item.OriginalChipsID : item.ChipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<Gmf_user_chips_dataEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<Gmf_user_chips_dataEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string userID, int chipsID, string set_, params object[] values_)
        {
            return Put(set_, "`UserID` = @UserID AND `ChipsID` = @ChipsID", ConcatValues(values_, userID, chipsID));
        }
        public async Task<int> PutByPKAsync(string userID, int chipsID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`UserID` = @UserID AND `ChipsID` = @ChipsID", ConcatValues(values_, userID, chipsID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string userID, int chipsID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`UserID` = @UserID AND `ChipsID` = @ChipsID", tm_, ConcatValues(values_, userID, chipsID));
        }
        public async Task<int> PutByPKAsync(string userID, int chipsID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`UserID` = @UserID AND `ChipsID` = @ChipsID", tm_, ConcatValues(values_, userID, chipsID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string userID, int chipsID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return Put(set_, "`UserID` = @UserID AND `ChipsID` = @ChipsID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(string userID, int chipsID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return await PutAsync(set_, "`UserID` = @UserID AND `ChipsID` = @ChipsID", ConcatParameters(paras_, newParas_), tm_);
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
        #region PutBingoTotal
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "bingoTotal">Bingo累计</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoTotalByPK(string userID, int chipsID, long bingoTotal, TransactionManager tm_ = null)
        {
            RepairPutBingoTotalByPKData(userID, chipsID, bingoTotal, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoTotalByPKAsync(string userID, int chipsID, long bingoTotal, TransactionManager tm_ = null)
        {
            RepairPutBingoTotalByPKData(userID, chipsID, bingoTotal, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoTotalByPKData(string userID, int chipsID, long bingoTotal, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoTotal` = @BingoTotal  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoTotal", bingoTotal, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoTotal">Bingo累计</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoTotal(long bingoTotal, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoTotal` = @BingoTotal";
            var parameter_ = Database.CreateInParameter("@BingoTotal", bingoTotal, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBingoTotalAsync(long bingoTotal, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoTotal` = @BingoTotal";
            var parameter_ = Database.CreateInParameter("@BingoTotal", bingoTotal, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBingoTotal
        #region PutBingoLock
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "bingoLock">Bingo部分锁定金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoLockByPK(string userID, int chipsID, long bingoLock, TransactionManager tm_ = null)
        {
            RepairPutBingoLockByPKData(userID, chipsID, bingoLock, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoLockByPKAsync(string userID, int chipsID, long bingoLock, TransactionManager tm_ = null)
        {
            RepairPutBingoLockByPKData(userID, chipsID, bingoLock, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoLockByPKData(string userID, int chipsID, long bingoLock, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoLock` = @BingoLock  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoLock", bingoLock, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoLock">Bingo部分锁定金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoLock(long bingoLock, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoLock` = @BingoLock";
            var parameter_ = Database.CreateInParameter("@BingoLock", bingoLock, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBingoLockAsync(long bingoLock, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoLock` = @BingoLock";
            var parameter_ = Database.CreateInParameter("@BingoLock", bingoLock, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBingoLock
        #region PutBingoPanelNums
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "bingoPanelNums">Bingo面板的25个球,按顺序|分割</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoPanelNumsByPK(string userID, int chipsID, string bingoPanelNums, TransactionManager tm_ = null)
        {
            RepairPutBingoPanelNumsByPKData(userID, chipsID, bingoPanelNums, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoPanelNumsByPKAsync(string userID, int chipsID, string bingoPanelNums, TransactionManager tm_ = null)
        {
            RepairPutBingoPanelNumsByPKData(userID, chipsID, bingoPanelNums, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoPanelNumsByPKData(string userID, int chipsID, string bingoPanelNums, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoPanelNums` = @BingoPanelNums  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoPanelNums", bingoPanelNums != null ? bingoPanelNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoPanelNums">Bingo面板的25个球,按顺序|分割</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoPanelNums(string bingoPanelNums, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoPanelNums` = @BingoPanelNums";
            var parameter_ = Database.CreateInParameter("@BingoPanelNums", bingoPanelNums != null ? bingoPanelNums : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBingoPanelNumsAsync(string bingoPanelNums, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoPanelNums` = @BingoPanelNums";
            var parameter_ = Database.CreateInParameter("@BingoPanelNums", bingoPanelNums != null ? bingoPanelNums : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBingoPanelNums
        #region PutBingoHitLine
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "bingoHitLine">Bingo中奖线</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoHitLineByPK(string userID, int chipsID, int bingoHitLine, TransactionManager tm_ = null)
        {
            RepairPutBingoHitLineByPKData(userID, chipsID, bingoHitLine, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoHitLineByPKAsync(string userID, int chipsID, int bingoHitLine, TransactionManager tm_ = null)
        {
            RepairPutBingoHitLineByPKData(userID, chipsID, bingoHitLine, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoHitLineByPKData(string userID, int chipsID, int bingoHitLine, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoHitLine` = @BingoHitLine  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoHitLine", bingoHitLine, MySqlDbType.Byte),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoHitLine">Bingo中奖线</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoHitLine(int bingoHitLine, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoHitLine` = @BingoHitLine";
            var parameter_ = Database.CreateInParameter("@BingoHitLine", bingoHitLine, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBingoHitLineAsync(int bingoHitLine, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoHitLine` = @BingoHitLine";
            var parameter_ = Database.CreateInParameter("@BingoHitLine", bingoHitLine, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBingoHitLine
        #region PutBingoKeepNum
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "bingoKeepNum">Bingo保留的数字</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoKeepNumByPK(string userID, int chipsID, int bingoKeepNum, TransactionManager tm_ = null)
        {
            RepairPutBingoKeepNumByPKData(userID, chipsID, bingoKeepNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoKeepNumByPKAsync(string userID, int chipsID, int bingoKeepNum, TransactionManager tm_ = null)
        {
            RepairPutBingoKeepNumByPKData(userID, chipsID, bingoKeepNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoKeepNumByPKData(string userID, int chipsID, int bingoKeepNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoKeepNum` = @BingoKeepNum  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoKeepNum", bingoKeepNum, MySqlDbType.Byte),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoKeepNum">Bingo保留的数字</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoKeepNum(int bingoKeepNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoKeepNum` = @BingoKeepNum";
            var parameter_ = Database.CreateInParameter("@BingoKeepNum", bingoKeepNum, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBingoKeepNumAsync(int bingoKeepNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoKeepNum` = @BingoKeepNum";
            var parameter_ = Database.CreateInParameter("@BingoKeepNum", bingoKeepNum, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBingoKeepNum
        #region PutBingoKeepNums
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "bingoKeepNums">Bingo保留的数字</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoKeepNumsByPK(string userID, int chipsID, string bingoKeepNums, TransactionManager tm_ = null)
        {
            RepairPutBingoKeepNumsByPKData(userID, chipsID, bingoKeepNums, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoKeepNumsByPKAsync(string userID, int chipsID, string bingoKeepNums, TransactionManager tm_ = null)
        {
            RepairPutBingoKeepNumsByPKData(userID, chipsID, bingoKeepNums, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoKeepNumsByPKData(string userID, int chipsID, string bingoKeepNums, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoKeepNums` = @BingoKeepNums  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoKeepNums", bingoKeepNums != null ? bingoKeepNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoKeepNums">Bingo保留的数字</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoKeepNums(string bingoKeepNums, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoKeepNums` = @BingoKeepNums";
            var parameter_ = Database.CreateInParameter("@BingoKeepNums", bingoKeepNums != null ? bingoKeepNums : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBingoKeepNumsAsync(string bingoKeepNums, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoKeepNums` = @BingoKeepNums";
            var parameter_ = Database.CreateInParameter("@BingoKeepNums", bingoKeepNums != null ? bingoKeepNums : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBingoKeepNums
        #region PutBingoHasNums
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "bingoHasNums">Bingo已出的75个数字,按顺序|分割</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoHasNumsByPK(string userID, int chipsID, string bingoHasNums, TransactionManager tm_ = null)
        {
            RepairPutBingoHasNumsByPKData(userID, chipsID, bingoHasNums, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoHasNumsByPKAsync(string userID, int chipsID, string bingoHasNums, TransactionManager tm_ = null)
        {
            RepairPutBingoHasNumsByPKData(userID, chipsID, bingoHasNums, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoHasNumsByPKData(string userID, int chipsID, string bingoHasNums, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoHasNums` = @BingoHasNums  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoHasNums", bingoHasNums != null ? bingoHasNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoHasNums">Bingo已出的75个数字,按顺序|分割</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoHasNums(string bingoHasNums, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoHasNums` = @BingoHasNums";
            var parameter_ = Database.CreateInParameter("@BingoHasNums", bingoHasNums != null ? bingoHasNums : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBingoHasNumsAsync(string bingoHasNums, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoHasNums` = @BingoHasNums";
            var parameter_ = Database.CreateInParameter("@BingoHasNums", bingoHasNums != null ? bingoHasNums : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBingoHasNums
        #region PutBonusTotal
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "bonusTotal">Bonus累计</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusTotalByPK(string userID, int chipsID, long bonusTotal, TransactionManager tm_ = null)
        {
            RepairPutBonusTotalByPKData(userID, chipsID, bonusTotal, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBonusTotalByPKAsync(string userID, int chipsID, long bonusTotal, TransactionManager tm_ = null)
        {
            RepairPutBonusTotalByPKData(userID, chipsID, bonusTotal, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBonusTotalByPKData(string userID, int chipsID, long bonusTotal, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BonusTotal` = @BonusTotal  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BonusTotal", bonusTotal, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bonusTotal">Bonus累计</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusTotal(long bonusTotal, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusTotal` = @BonusTotal";
            var parameter_ = Database.CreateInParameter("@BonusTotal", bonusTotal, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBonusTotalAsync(long bonusTotal, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusTotal` = @BonusTotal";
            var parameter_ = Database.CreateInParameter("@BonusTotal", bonusTotal, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBonusTotal
        #region PutBonusLock
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "bonusLock">Bonus部分锁定金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusLockByPK(string userID, int chipsID, long bonusLock, TransactionManager tm_ = null)
        {
            RepairPutBonusLockByPKData(userID, chipsID, bonusLock, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBonusLockByPKAsync(string userID, int chipsID, long bonusLock, TransactionManager tm_ = null)
        {
            RepairPutBonusLockByPKData(userID, chipsID, bonusLock, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBonusLockByPKData(string userID, int chipsID, long bonusLock, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BonusLock` = @BonusLock  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BonusLock", bonusLock, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bonusLock">Bonus部分锁定金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusLock(long bonusLock, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusLock` = @BonusLock";
            var parameter_ = Database.CreateInParameter("@BonusLock", bonusLock, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBonusLockAsync(long bonusLock, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusLock` = @BonusLock";
            var parameter_ = Database.CreateInParameter("@BonusLock", bonusLock, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBonusLock
        #region PutFreeSpinNum
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "freeSpinNum">freespin剩余数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutFreeSpinNumByPK(string userID, int chipsID, int freeSpinNum, TransactionManager tm_ = null)
        {
            RepairPutFreeSpinNumByPKData(userID, chipsID, freeSpinNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutFreeSpinNumByPKAsync(string userID, int chipsID, int freeSpinNum, TransactionManager tm_ = null)
        {
            RepairPutFreeSpinNumByPKData(userID, chipsID, freeSpinNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutFreeSpinNumByPKData(string userID, int chipsID, int freeSpinNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `FreeSpinNum` = @FreeSpinNum  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@FreeSpinNum", freeSpinNum, MySqlDbType.Byte),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "freeSpinNum">freespin剩余数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutFreeSpinNum(int freeSpinNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `FreeSpinNum` = @FreeSpinNum";
            var parameter_ = Database.CreateInParameter("@FreeSpinNum", freeSpinNum, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutFreeSpinNumAsync(int freeSpinNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `FreeSpinNum` = @FreeSpinNum";
            var parameter_ = Database.CreateInParameter("@FreeSpinNum", freeSpinNum, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutFreeSpinNum
        #region PutRetriggerNum
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "retriggerNum">retrigger剩余数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRetriggerNumByPK(string userID, int chipsID, int retriggerNum, TransactionManager tm_ = null)
        {
            RepairPutRetriggerNumByPKData(userID, chipsID, retriggerNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRetriggerNumByPKAsync(string userID, int chipsID, int retriggerNum, TransactionManager tm_ = null)
        {
            RepairPutRetriggerNumByPKData(userID, chipsID, retriggerNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRetriggerNumByPKData(string userID, int chipsID, int retriggerNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `RetriggerNum` = @RetriggerNum  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RetriggerNum", retriggerNum, MySqlDbType.Byte),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "retriggerNum">retrigger剩余数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRetriggerNum(int retriggerNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `RetriggerNum` = @RetriggerNum";
            var parameter_ = Database.CreateInParameter("@RetriggerNum", retriggerNum, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutRetriggerNumAsync(int retriggerNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `RetriggerNum` = @RetriggerNum";
            var parameter_ = Database.CreateInParameter("@RetriggerNum", retriggerNum, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutRetriggerNum
        #region PutRetriggerList
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "retriggerList">retrigger出现顺序</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRetriggerListByPK(string userID, int chipsID, string retriggerList, TransactionManager tm_ = null)
        {
            RepairPutRetriggerListByPKData(userID, chipsID, retriggerList, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRetriggerListByPKAsync(string userID, int chipsID, string retriggerList, TransactionManager tm_ = null)
        {
            RepairPutRetriggerListByPKData(userID, chipsID, retriggerList, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRetriggerListByPKData(string userID, int chipsID, string retriggerList, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `RetriggerList` = @RetriggerList  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RetriggerList", retriggerList != null ? retriggerList : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "retriggerList">retrigger出现顺序</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRetriggerList(string retriggerList, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `RetriggerList` = @RetriggerList";
            var parameter_ = Database.CreateInParameter("@RetriggerList", retriggerList != null ? retriggerList : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutRetriggerListAsync(string retriggerList, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `RetriggerList` = @RetriggerList";
            var parameter_ = Database.CreateInParameter("@RetriggerList", retriggerList != null ? retriggerList : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutRetriggerList
        #region PutFreeSpinAmount
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "freeSpinAmount">freespin环节总盈利</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutFreeSpinAmountByPK(string userID, int chipsID, long freeSpinAmount, TransactionManager tm_ = null)
        {
            RepairPutFreeSpinAmountByPKData(userID, chipsID, freeSpinAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutFreeSpinAmountByPKAsync(string userID, int chipsID, long freeSpinAmount, TransactionManager tm_ = null)
        {
            RepairPutFreeSpinAmountByPKData(userID, chipsID, freeSpinAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutFreeSpinAmountByPKData(string userID, int chipsID, long freeSpinAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `FreeSpinAmount` = @FreeSpinAmount  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@FreeSpinAmount", freeSpinAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "freeSpinAmount">freespin环节总盈利</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutFreeSpinAmount(long freeSpinAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `FreeSpinAmount` = @FreeSpinAmount";
            var parameter_ = Database.CreateInParameter("@FreeSpinAmount", freeSpinAmount, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutFreeSpinAmountAsync(long freeSpinAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `FreeSpinAmount` = @FreeSpinAmount";
            var parameter_ = Database.CreateInParameter("@FreeSpinAmount", freeSpinAmount, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutFreeSpinAmount
        #region PutBaseLock
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "baseLock">base部分锁定金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBaseLockByPK(string userID, int chipsID, long baseLock, TransactionManager tm_ = null)
        {
            RepairPutBaseLockByPKData(userID, chipsID, baseLock, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBaseLockByPKAsync(string userID, int chipsID, long baseLock, TransactionManager tm_ = null)
        {
            RepairPutBaseLockByPKData(userID, chipsID, baseLock, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBaseLockByPKData(string userID, int chipsID, long baseLock, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BaseLock` = @BaseLock  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BaseLock", baseLock, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "baseLock">base部分锁定金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBaseLock(long baseLock, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BaseLock` = @BaseLock";
            var parameter_ = Database.CreateInParameter("@BaseLock", baseLock, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBaseLockAsync(long baseLock, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BaseLock` = @BaseLock";
            var parameter_ = Database.CreateInParameter("@BaseLock", baseLock, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBaseLock
        #region PutSlotID
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "slotID">最后一次slot明细编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSlotIDByPK(string userID, int chipsID, long? slotID, TransactionManager tm_ = null)
        {
            RepairPutSlotIDByPKData(userID, chipsID, slotID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutSlotIDByPKAsync(string userID, int chipsID, long? slotID, TransactionManager tm_ = null)
        {
            RepairPutSlotIDByPKData(userID, chipsID, slotID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutSlotIDByPKData(string userID, int chipsID, long? slotID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `SlotID` = @SlotID  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID.HasValue ? slotID.Value : (object)DBNull.Value, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "slotID">最后一次slot明细编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSlotID(long? slotID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SlotID` = @SlotID";
            var parameter_ = Database.CreateInParameter("@SlotID", slotID.HasValue ? slotID.Value : (object)DBNull.Value, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutSlotIDAsync(long? slotID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SlotID` = @SlotID";
            var parameter_ = Database.CreateInParameter("@SlotID", slotID.HasValue ? slotID.Value : (object)DBNull.Value, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutSlotID
        #region PutStatus
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "status">状态1-正常2-锁定中3-异常用户账户错误</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutStatusByPK(string userID, int chipsID, int status, TransactionManager tm_ = null)
        {
            RepairPutStatusByPKData(userID, chipsID, status, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutStatusByPKAsync(string userID, int chipsID, int status, TransactionManager tm_ = null)
        {
            RepairPutStatusByPKData(userID, chipsID, status, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutStatusByPKData(string userID, int chipsID, int status, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Status", status, MySqlDbType.Byte),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "status">状态1-正常2-锁定中3-异常用户账户错误</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutStatus(int status, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
            var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutStatusAsync(int status, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
            var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutStatus
        #region PutRecDate
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRecDateByPK(string userID, int chipsID, DateTime recDate, TransactionManager tm_ = null)
        {
            RepairPutRecDateByPKData(userID, chipsID, recDate, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRecDateByPKAsync(string userID, int chipsID, DateTime recDate, TransactionManager tm_ = null)
        {
            RepairPutRecDateByPKData(userID, chipsID, recDate, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRecDateByPKData(string userID, int chipsID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRecDate(DateTime recDate, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
            var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
            var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutRecDate
        #endregion // PutXXX
        #endregion // Put

        #region Set

        /// <summary>
        /// 插入或者更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>true:插入操作；false:更新操作</return>
        public bool Set(Gmf_user_chips_dataEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.UserID, item.ChipsID) == null)
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
        public async Task<bool> SetAsync(Gmf_user_chips_dataEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.UserID, item.ChipsID) == null)
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
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public Gmf_user_chips_dataEO GetByPK(string userID, int chipsID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(userID, chipsID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<Gmf_user_chips_dataEO> GetByPKAsync(string userID, int chipsID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(userID, chipsID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        private void RepairGetByPKData(string userID, int chipsID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`UserID` = @UserID AND `ChipsID` = @ChipsID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 UserID（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetUserIDByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (string)GetScalar("`UserID`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<string> GetUserIDByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (string)await GetScalarAsync("`UserID`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 ChipsID（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetChipsIDByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`ChipsID`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<int> GetChipsIDByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`ChipsID`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoTotal（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetBingoTotalByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (long)GetScalar("`BingoTotal`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<long> GetBingoTotalByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (long)await GetScalarAsync("`BingoTotal`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoLock（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetBingoLockByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (long)GetScalar("`BingoLock`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<long> GetBingoLockByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (long)await GetScalarAsync("`BingoLock`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoPanelNums（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetBingoPanelNumsByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (string)GetScalar("`BingoPanelNums`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<string> GetBingoPanelNumsByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (string)await GetScalarAsync("`BingoPanelNums`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoHitLine（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetBingoHitLineByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`BingoHitLine`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<int> GetBingoHitLineByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`BingoHitLine`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoKeepNum（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetBingoKeepNumByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`BingoKeepNum`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<int> GetBingoKeepNumByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`BingoKeepNum`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoKeepNums（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetBingoKeepNumsByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (string)GetScalar("`BingoKeepNums`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<string> GetBingoKeepNumsByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (string)await GetScalarAsync("`BingoKeepNums`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoHasNums（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetBingoHasNumsByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (string)GetScalar("`BingoHasNums`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<string> GetBingoHasNumsByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (string)await GetScalarAsync("`BingoHasNums`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BonusTotal（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetBonusTotalByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (long)GetScalar("`BonusTotal`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<long> GetBonusTotalByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (long)await GetScalarAsync("`BonusTotal`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BonusLock（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetBonusLockByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (long)GetScalar("`BonusLock`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<long> GetBonusLockByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (long)await GetScalarAsync("`BonusLock`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 FreeSpinNum（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetFreeSpinNumByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`FreeSpinNum`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<int> GetFreeSpinNumByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`FreeSpinNum`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 RetriggerNum（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetRetriggerNumByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`RetriggerNum`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<int> GetRetriggerNumByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`RetriggerNum`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 RetriggerList（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetRetriggerListByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (string)GetScalar("`RetriggerList`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<string> GetRetriggerListByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (string)await GetScalarAsync("`RetriggerList`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 FreeSpinAmount（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetFreeSpinAmountByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (long)GetScalar("`FreeSpinAmount`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<long> GetFreeSpinAmountByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (long)await GetScalarAsync("`FreeSpinAmount`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BaseLock（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetBaseLockByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (long)GetScalar("`BaseLock`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<long> GetBaseLockByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (long)await GetScalarAsync("`BaseLock`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 SlotID（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long? GetSlotIDByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (long?)GetScalar("`SlotID`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<long?> GetSlotIDByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (long?)await GetScalarAsync("`SlotID`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Status（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetStatusByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`Status`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<int> GetStatusByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`Status`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 RecDate（字段）
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public DateTime GetRecDateByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (DateTime)GetScalar("`RecDate`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<DateTime> GetRecDateByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (DateTime)await GetScalarAsync("`RecDate`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByUserID

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByUserID(string userID)
        {
            return GetByUserID(userID, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByUserIDAsync(string userID)
        {
            return await GetByUserIDAsync(userID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByUserID(string userID, TransactionManager tm_)
        {
            return GetByUserID(userID, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
        {
            return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByUserID(string userID, int top_)
        {
            return GetByUserID(userID, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByUserIDAsync(string userID, int top_)
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
        public List<Gmf_user_chips_dataEO> GetByUserID(string userID, int top_, TransactionManager tm_)
        {
            return GetByUserID(userID, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
        {
            return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByUserID(string userID, string sort_)
        {
            return GetByUserID(userID, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByUserIDAsync(string userID, string sort_)
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
        public List<Gmf_user_chips_dataEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
        {
            return GetByUserID(userID, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
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
        public List<Gmf_user_chips_dataEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByUserID
        #region GetByChipsID

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByChipsID(int chipsID)
        {
            return GetByChipsID(chipsID, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByChipsIDAsync(int chipsID)
        {
            return await GetByChipsIDAsync(chipsID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByChipsID(int chipsID, TransactionManager tm_)
        {
            return GetByChipsID(chipsID, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByChipsIDAsync(int chipsID, TransactionManager tm_)
        {
            return await GetByChipsIDAsync(chipsID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByChipsID(int chipsID, int top_)
        {
            return GetByChipsID(chipsID, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByChipsIDAsync(int chipsID, int top_)
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
        public List<Gmf_user_chips_dataEO> GetByChipsID(int chipsID, int top_, TransactionManager tm_)
        {
            return GetByChipsID(chipsID, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByChipsIDAsync(int chipsID, int top_, TransactionManager tm_)
        {
            return await GetByChipsIDAsync(chipsID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByChipsID(int chipsID, string sort_)
        {
            return GetByChipsID(chipsID, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByChipsIDAsync(int chipsID, string sort_)
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
        public List<Gmf_user_chips_dataEO> GetByChipsID(int chipsID, string sort_, TransactionManager tm_)
        {
            return GetByChipsID(chipsID, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByChipsIDAsync(int chipsID, string sort_, TransactionManager tm_)
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
        public List<Gmf_user_chips_dataEO> GetByChipsID(int chipsID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByChipsIDAsync(int chipsID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByChipsID
        #region GetByBingoTotal

        /// <summary>
        /// 按 BingoTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTotal">Bingo累计</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoTotal(long bingoTotal)
        {
            return GetByBingoTotal(bingoTotal, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoTotalAsync(long bingoTotal)
        {
            return await GetByBingoTotalAsync(bingoTotal, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTotal">Bingo累计</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoTotal(long bingoTotal, TransactionManager tm_)
        {
            return GetByBingoTotal(bingoTotal, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoTotalAsync(long bingoTotal, TransactionManager tm_)
        {
            return await GetByBingoTotalAsync(bingoTotal, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTotal">Bingo累计</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoTotal(long bingoTotal, int top_)
        {
            return GetByBingoTotal(bingoTotal, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoTotalAsync(long bingoTotal, int top_)
        {
            return await GetByBingoTotalAsync(bingoTotal, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTotal">Bingo累计</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoTotal(long bingoTotal, int top_, TransactionManager tm_)
        {
            return GetByBingoTotal(bingoTotal, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoTotalAsync(long bingoTotal, int top_, TransactionManager tm_)
        {
            return await GetByBingoTotalAsync(bingoTotal, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTotal">Bingo累计</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoTotal(long bingoTotal, string sort_)
        {
            return GetByBingoTotal(bingoTotal, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoTotalAsync(long bingoTotal, string sort_)
        {
            return await GetByBingoTotalAsync(bingoTotal, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTotal">Bingo累计</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoTotal(long bingoTotal, string sort_, TransactionManager tm_)
        {
            return GetByBingoTotal(bingoTotal, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoTotalAsync(long bingoTotal, string sort_, TransactionManager tm_)
        {
            return await GetByBingoTotalAsync(bingoTotal, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTotal">Bingo累计</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoTotal(long bingoTotal, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoTotal` = @BingoTotal", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoTotal", bingoTotal, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoTotalAsync(long bingoTotal, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoTotal` = @BingoTotal", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoTotal", bingoTotal, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByBingoTotal
        #region GetByBingoLock

        /// <summary>
        /// 按 BingoLock（字段） 查询
        /// </summary>
        /// /// <param name = "bingoLock">Bingo部分锁定金额</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoLock(long bingoLock)
        {
            return GetByBingoLock(bingoLock, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoLockAsync(long bingoLock)
        {
            return await GetByBingoLockAsync(bingoLock, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoLock（字段） 查询
        /// </summary>
        /// /// <param name = "bingoLock">Bingo部分锁定金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoLock(long bingoLock, TransactionManager tm_)
        {
            return GetByBingoLock(bingoLock, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoLockAsync(long bingoLock, TransactionManager tm_)
        {
            return await GetByBingoLockAsync(bingoLock, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoLock（字段） 查询
        /// </summary>
        /// /// <param name = "bingoLock">Bingo部分锁定金额</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoLock(long bingoLock, int top_)
        {
            return GetByBingoLock(bingoLock, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoLockAsync(long bingoLock, int top_)
        {
            return await GetByBingoLockAsync(bingoLock, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoLock（字段） 查询
        /// </summary>
        /// /// <param name = "bingoLock">Bingo部分锁定金额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoLock(long bingoLock, int top_, TransactionManager tm_)
        {
            return GetByBingoLock(bingoLock, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoLockAsync(long bingoLock, int top_, TransactionManager tm_)
        {
            return await GetByBingoLockAsync(bingoLock, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoLock（字段） 查询
        /// </summary>
        /// /// <param name = "bingoLock">Bingo部分锁定金额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoLock(long bingoLock, string sort_)
        {
            return GetByBingoLock(bingoLock, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoLockAsync(long bingoLock, string sort_)
        {
            return await GetByBingoLockAsync(bingoLock, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoLock（字段） 查询
        /// </summary>
        /// /// <param name = "bingoLock">Bingo部分锁定金额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoLock(long bingoLock, string sort_, TransactionManager tm_)
        {
            return GetByBingoLock(bingoLock, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoLockAsync(long bingoLock, string sort_, TransactionManager tm_)
        {
            return await GetByBingoLockAsync(bingoLock, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoLock（字段） 查询
        /// </summary>
        /// /// <param name = "bingoLock">Bingo部分锁定金额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoLock(long bingoLock, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoLock` = @BingoLock", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoLock", bingoLock, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoLockAsync(long bingoLock, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoLock` = @BingoLock", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoLock", bingoLock, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByBingoLock
        #region GetByBingoPanelNums

        /// <summary>
        /// 按 BingoPanelNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPanelNums">Bingo面板的25个球,按顺序|分割</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoPanelNums(string bingoPanelNums)
        {
            return GetByBingoPanelNums(bingoPanelNums, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoPanelNumsAsync(string bingoPanelNums)
        {
            return await GetByBingoPanelNumsAsync(bingoPanelNums, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoPanelNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPanelNums">Bingo面板的25个球,按顺序|分割</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoPanelNums(string bingoPanelNums, TransactionManager tm_)
        {
            return GetByBingoPanelNums(bingoPanelNums, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoPanelNumsAsync(string bingoPanelNums, TransactionManager tm_)
        {
            return await GetByBingoPanelNumsAsync(bingoPanelNums, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoPanelNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPanelNums">Bingo面板的25个球,按顺序|分割</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoPanelNums(string bingoPanelNums, int top_)
        {
            return GetByBingoPanelNums(bingoPanelNums, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoPanelNumsAsync(string bingoPanelNums, int top_)
        {
            return await GetByBingoPanelNumsAsync(bingoPanelNums, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoPanelNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPanelNums">Bingo面板的25个球,按顺序|分割</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoPanelNums(string bingoPanelNums, int top_, TransactionManager tm_)
        {
            return GetByBingoPanelNums(bingoPanelNums, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoPanelNumsAsync(string bingoPanelNums, int top_, TransactionManager tm_)
        {
            return await GetByBingoPanelNumsAsync(bingoPanelNums, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoPanelNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPanelNums">Bingo面板的25个球,按顺序|分割</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoPanelNums(string bingoPanelNums, string sort_)
        {
            return GetByBingoPanelNums(bingoPanelNums, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoPanelNumsAsync(string bingoPanelNums, string sort_)
        {
            return await GetByBingoPanelNumsAsync(bingoPanelNums, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoPanelNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPanelNums">Bingo面板的25个球,按顺序|分割</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoPanelNums(string bingoPanelNums, string sort_, TransactionManager tm_)
        {
            return GetByBingoPanelNums(bingoPanelNums, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoPanelNumsAsync(string bingoPanelNums, string sort_, TransactionManager tm_)
        {
            return await GetByBingoPanelNumsAsync(bingoPanelNums, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoPanelNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPanelNums">Bingo面板的25个球,按顺序|分割</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoPanelNums(string bingoPanelNums, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(bingoPanelNums != null ? "`BingoPanelNums` = @BingoPanelNums" : "`BingoPanelNums` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (bingoPanelNums != null)
                paras_.Add(Database.CreateInParameter("@BingoPanelNums", bingoPanelNums, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoPanelNumsAsync(string bingoPanelNums, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(bingoPanelNums != null ? "`BingoPanelNums` = @BingoPanelNums" : "`BingoPanelNums` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (bingoPanelNums != null)
                paras_.Add(Database.CreateInParameter("@BingoPanelNums", bingoPanelNums, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByBingoPanelNums
        #region GetByBingoHitLine

        /// <summary>
        /// 按 BingoHitLine（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHitLine">Bingo中奖线</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoHitLine(int bingoHitLine)
        {
            return GetByBingoHitLine(bingoHitLine, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoHitLineAsync(int bingoHitLine)
        {
            return await GetByBingoHitLineAsync(bingoHitLine, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoHitLine（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHitLine">Bingo中奖线</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoHitLine(int bingoHitLine, TransactionManager tm_)
        {
            return GetByBingoHitLine(bingoHitLine, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoHitLineAsync(int bingoHitLine, TransactionManager tm_)
        {
            return await GetByBingoHitLineAsync(bingoHitLine, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoHitLine（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHitLine">Bingo中奖线</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoHitLine(int bingoHitLine, int top_)
        {
            return GetByBingoHitLine(bingoHitLine, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoHitLineAsync(int bingoHitLine, int top_)
        {
            return await GetByBingoHitLineAsync(bingoHitLine, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoHitLine（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHitLine">Bingo中奖线</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoHitLine(int bingoHitLine, int top_, TransactionManager tm_)
        {
            return GetByBingoHitLine(bingoHitLine, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoHitLineAsync(int bingoHitLine, int top_, TransactionManager tm_)
        {
            return await GetByBingoHitLineAsync(bingoHitLine, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoHitLine（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHitLine">Bingo中奖线</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoHitLine(int bingoHitLine, string sort_)
        {
            return GetByBingoHitLine(bingoHitLine, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoHitLineAsync(int bingoHitLine, string sort_)
        {
            return await GetByBingoHitLineAsync(bingoHitLine, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoHitLine（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHitLine">Bingo中奖线</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoHitLine(int bingoHitLine, string sort_, TransactionManager tm_)
        {
            return GetByBingoHitLine(bingoHitLine, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoHitLineAsync(int bingoHitLine, string sort_, TransactionManager tm_)
        {
            return await GetByBingoHitLineAsync(bingoHitLine, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoHitLine（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHitLine">Bingo中奖线</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoHitLine(int bingoHitLine, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoHitLine` = @BingoHitLine", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoHitLine", bingoHitLine, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoHitLineAsync(int bingoHitLine, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoHitLine` = @BingoHitLine", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoHitLine", bingoHitLine, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByBingoHitLine
        #region GetByBingoKeepNum

        /// <summary>
        /// 按 BingoKeepNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNum">Bingo保留的数字</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoKeepNum(int bingoKeepNum)
        {
            return GetByBingoKeepNum(bingoKeepNum, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoKeepNumAsync(int bingoKeepNum)
        {
            return await GetByBingoKeepNumAsync(bingoKeepNum, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoKeepNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNum">Bingo保留的数字</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoKeepNum(int bingoKeepNum, TransactionManager tm_)
        {
            return GetByBingoKeepNum(bingoKeepNum, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoKeepNumAsync(int bingoKeepNum, TransactionManager tm_)
        {
            return await GetByBingoKeepNumAsync(bingoKeepNum, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoKeepNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNum">Bingo保留的数字</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoKeepNum(int bingoKeepNum, int top_)
        {
            return GetByBingoKeepNum(bingoKeepNum, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoKeepNumAsync(int bingoKeepNum, int top_)
        {
            return await GetByBingoKeepNumAsync(bingoKeepNum, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoKeepNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNum">Bingo保留的数字</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoKeepNum(int bingoKeepNum, int top_, TransactionManager tm_)
        {
            return GetByBingoKeepNum(bingoKeepNum, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoKeepNumAsync(int bingoKeepNum, int top_, TransactionManager tm_)
        {
            return await GetByBingoKeepNumAsync(bingoKeepNum, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoKeepNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNum">Bingo保留的数字</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoKeepNum(int bingoKeepNum, string sort_)
        {
            return GetByBingoKeepNum(bingoKeepNum, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoKeepNumAsync(int bingoKeepNum, string sort_)
        {
            return await GetByBingoKeepNumAsync(bingoKeepNum, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoKeepNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNum">Bingo保留的数字</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoKeepNum(int bingoKeepNum, string sort_, TransactionManager tm_)
        {
            return GetByBingoKeepNum(bingoKeepNum, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoKeepNumAsync(int bingoKeepNum, string sort_, TransactionManager tm_)
        {
            return await GetByBingoKeepNumAsync(bingoKeepNum, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoKeepNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNum">Bingo保留的数字</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoKeepNum(int bingoKeepNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoKeepNum` = @BingoKeepNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoKeepNum", bingoKeepNum, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoKeepNumAsync(int bingoKeepNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoKeepNum` = @BingoKeepNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoKeepNum", bingoKeepNum, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByBingoKeepNum
        #region GetByBingoKeepNums

        /// <summary>
        /// 按 BingoKeepNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNums">Bingo保留的数字</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoKeepNums(string bingoKeepNums)
        {
            return GetByBingoKeepNums(bingoKeepNums, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoKeepNumsAsync(string bingoKeepNums)
        {
            return await GetByBingoKeepNumsAsync(bingoKeepNums, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoKeepNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNums">Bingo保留的数字</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoKeepNums(string bingoKeepNums, TransactionManager tm_)
        {
            return GetByBingoKeepNums(bingoKeepNums, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoKeepNumsAsync(string bingoKeepNums, TransactionManager tm_)
        {
            return await GetByBingoKeepNumsAsync(bingoKeepNums, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoKeepNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNums">Bingo保留的数字</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoKeepNums(string bingoKeepNums, int top_)
        {
            return GetByBingoKeepNums(bingoKeepNums, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoKeepNumsAsync(string bingoKeepNums, int top_)
        {
            return await GetByBingoKeepNumsAsync(bingoKeepNums, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoKeepNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNums">Bingo保留的数字</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoKeepNums(string bingoKeepNums, int top_, TransactionManager tm_)
        {
            return GetByBingoKeepNums(bingoKeepNums, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoKeepNumsAsync(string bingoKeepNums, int top_, TransactionManager tm_)
        {
            return await GetByBingoKeepNumsAsync(bingoKeepNums, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoKeepNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNums">Bingo保留的数字</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoKeepNums(string bingoKeepNums, string sort_)
        {
            return GetByBingoKeepNums(bingoKeepNums, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoKeepNumsAsync(string bingoKeepNums, string sort_)
        {
            return await GetByBingoKeepNumsAsync(bingoKeepNums, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoKeepNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNums">Bingo保留的数字</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoKeepNums(string bingoKeepNums, string sort_, TransactionManager tm_)
        {
            return GetByBingoKeepNums(bingoKeepNums, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoKeepNumsAsync(string bingoKeepNums, string sort_, TransactionManager tm_)
        {
            return await GetByBingoKeepNumsAsync(bingoKeepNums, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoKeepNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNums">Bingo保留的数字</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoKeepNums(string bingoKeepNums, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(bingoKeepNums != null ? "`BingoKeepNums` = @BingoKeepNums" : "`BingoKeepNums` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (bingoKeepNums != null)
                paras_.Add(Database.CreateInParameter("@BingoKeepNums", bingoKeepNums, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoKeepNumsAsync(string bingoKeepNums, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(bingoKeepNums != null ? "`BingoKeepNums` = @BingoKeepNums" : "`BingoKeepNums` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (bingoKeepNums != null)
                paras_.Add(Database.CreateInParameter("@BingoKeepNums", bingoKeepNums, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByBingoKeepNums
        #region GetByBingoHasNums

        /// <summary>
        /// 按 BingoHasNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHasNums">Bingo已出的75个数字,按顺序|分割</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoHasNums(string bingoHasNums)
        {
            return GetByBingoHasNums(bingoHasNums, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoHasNumsAsync(string bingoHasNums)
        {
            return await GetByBingoHasNumsAsync(bingoHasNums, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoHasNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHasNums">Bingo已出的75个数字,按顺序|分割</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoHasNums(string bingoHasNums, TransactionManager tm_)
        {
            return GetByBingoHasNums(bingoHasNums, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoHasNumsAsync(string bingoHasNums, TransactionManager tm_)
        {
            return await GetByBingoHasNumsAsync(bingoHasNums, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoHasNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHasNums">Bingo已出的75个数字,按顺序|分割</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoHasNums(string bingoHasNums, int top_)
        {
            return GetByBingoHasNums(bingoHasNums, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoHasNumsAsync(string bingoHasNums, int top_)
        {
            return await GetByBingoHasNumsAsync(bingoHasNums, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoHasNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHasNums">Bingo已出的75个数字,按顺序|分割</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoHasNums(string bingoHasNums, int top_, TransactionManager tm_)
        {
            return GetByBingoHasNums(bingoHasNums, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoHasNumsAsync(string bingoHasNums, int top_, TransactionManager tm_)
        {
            return await GetByBingoHasNumsAsync(bingoHasNums, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoHasNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHasNums">Bingo已出的75个数字,按顺序|分割</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoHasNums(string bingoHasNums, string sort_)
        {
            return GetByBingoHasNums(bingoHasNums, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoHasNumsAsync(string bingoHasNums, string sort_)
        {
            return await GetByBingoHasNumsAsync(bingoHasNums, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoHasNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHasNums">Bingo已出的75个数字,按顺序|分割</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoHasNums(string bingoHasNums, string sort_, TransactionManager tm_)
        {
            return GetByBingoHasNums(bingoHasNums, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoHasNumsAsync(string bingoHasNums, string sort_, TransactionManager tm_)
        {
            return await GetByBingoHasNumsAsync(bingoHasNums, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoHasNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHasNums">Bingo已出的75个数字,按顺序|分割</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBingoHasNums(string bingoHasNums, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(bingoHasNums != null ? "`BingoHasNums` = @BingoHasNums" : "`BingoHasNums` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (bingoHasNums != null)
                paras_.Add(Database.CreateInParameter("@BingoHasNums", bingoHasNums, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBingoHasNumsAsync(string bingoHasNums, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(bingoHasNums != null ? "`BingoHasNums` = @BingoHasNums" : "`BingoHasNums` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (bingoHasNums != null)
                paras_.Add(Database.CreateInParameter("@BingoHasNums", bingoHasNums, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByBingoHasNums
        #region GetByBonusTotal

        /// <summary>
        /// 按 BonusTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTotal">Bonus累计</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBonusTotal(long bonusTotal)
        {
            return GetByBonusTotal(bonusTotal, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBonusTotalAsync(long bonusTotal)
        {
            return await GetByBonusTotalAsync(bonusTotal, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTotal">Bonus累计</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBonusTotal(long bonusTotal, TransactionManager tm_)
        {
            return GetByBonusTotal(bonusTotal, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBonusTotalAsync(long bonusTotal, TransactionManager tm_)
        {
            return await GetByBonusTotalAsync(bonusTotal, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTotal">Bonus累计</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBonusTotal(long bonusTotal, int top_)
        {
            return GetByBonusTotal(bonusTotal, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBonusTotalAsync(long bonusTotal, int top_)
        {
            return await GetByBonusTotalAsync(bonusTotal, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTotal">Bonus累计</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBonusTotal(long bonusTotal, int top_, TransactionManager tm_)
        {
            return GetByBonusTotal(bonusTotal, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBonusTotalAsync(long bonusTotal, int top_, TransactionManager tm_)
        {
            return await GetByBonusTotalAsync(bonusTotal, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTotal">Bonus累计</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBonusTotal(long bonusTotal, string sort_)
        {
            return GetByBonusTotal(bonusTotal, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBonusTotalAsync(long bonusTotal, string sort_)
        {
            return await GetByBonusTotalAsync(bonusTotal, 0, sort_, null);
        }

        /// <summary>
        /// 按 BonusTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTotal">Bonus累计</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBonusTotal(long bonusTotal, string sort_, TransactionManager tm_)
        {
            return GetByBonusTotal(bonusTotal, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBonusTotalAsync(long bonusTotal, string sort_, TransactionManager tm_)
        {
            return await GetByBonusTotalAsync(bonusTotal, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BonusTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTotal">Bonus累计</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBonusTotal(long bonusTotal, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusTotal` = @BonusTotal", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusTotal", bonusTotal, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBonusTotalAsync(long bonusTotal, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusTotal` = @BonusTotal", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusTotal", bonusTotal, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByBonusTotal
        #region GetByBonusLock

        /// <summary>
        /// 按 BonusLock（字段） 查询
        /// </summary>
        /// /// <param name = "bonusLock">Bonus部分锁定金额</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBonusLock(long bonusLock)
        {
            return GetByBonusLock(bonusLock, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBonusLockAsync(long bonusLock)
        {
            return await GetByBonusLockAsync(bonusLock, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusLock（字段） 查询
        /// </summary>
        /// /// <param name = "bonusLock">Bonus部分锁定金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBonusLock(long bonusLock, TransactionManager tm_)
        {
            return GetByBonusLock(bonusLock, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBonusLockAsync(long bonusLock, TransactionManager tm_)
        {
            return await GetByBonusLockAsync(bonusLock, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusLock（字段） 查询
        /// </summary>
        /// /// <param name = "bonusLock">Bonus部分锁定金额</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBonusLock(long bonusLock, int top_)
        {
            return GetByBonusLock(bonusLock, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBonusLockAsync(long bonusLock, int top_)
        {
            return await GetByBonusLockAsync(bonusLock, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusLock（字段） 查询
        /// </summary>
        /// /// <param name = "bonusLock">Bonus部分锁定金额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBonusLock(long bonusLock, int top_, TransactionManager tm_)
        {
            return GetByBonusLock(bonusLock, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBonusLockAsync(long bonusLock, int top_, TransactionManager tm_)
        {
            return await GetByBonusLockAsync(bonusLock, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusLock（字段） 查询
        /// </summary>
        /// /// <param name = "bonusLock">Bonus部分锁定金额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBonusLock(long bonusLock, string sort_)
        {
            return GetByBonusLock(bonusLock, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBonusLockAsync(long bonusLock, string sort_)
        {
            return await GetByBonusLockAsync(bonusLock, 0, sort_, null);
        }

        /// <summary>
        /// 按 BonusLock（字段） 查询
        /// </summary>
        /// /// <param name = "bonusLock">Bonus部分锁定金额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBonusLock(long bonusLock, string sort_, TransactionManager tm_)
        {
            return GetByBonusLock(bonusLock, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBonusLockAsync(long bonusLock, string sort_, TransactionManager tm_)
        {
            return await GetByBonusLockAsync(bonusLock, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BonusLock（字段） 查询
        /// </summary>
        /// /// <param name = "bonusLock">Bonus部分锁定金额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBonusLock(long bonusLock, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusLock` = @BonusLock", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusLock", bonusLock, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBonusLockAsync(long bonusLock, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusLock` = @BonusLock", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusLock", bonusLock, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByBonusLock
        #region GetByFreeSpinNum

        /// <summary>
        /// 按 FreeSpinNum（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinNum">freespin剩余数量</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByFreeSpinNum(int freeSpinNum)
        {
            return GetByFreeSpinNum(freeSpinNum, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByFreeSpinNumAsync(int freeSpinNum)
        {
            return await GetByFreeSpinNumAsync(freeSpinNum, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 FreeSpinNum（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinNum">freespin剩余数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByFreeSpinNum(int freeSpinNum, TransactionManager tm_)
        {
            return GetByFreeSpinNum(freeSpinNum, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByFreeSpinNumAsync(int freeSpinNum, TransactionManager tm_)
        {
            return await GetByFreeSpinNumAsync(freeSpinNum, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 FreeSpinNum（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinNum">freespin剩余数量</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByFreeSpinNum(int freeSpinNum, int top_)
        {
            return GetByFreeSpinNum(freeSpinNum, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByFreeSpinNumAsync(int freeSpinNum, int top_)
        {
            return await GetByFreeSpinNumAsync(freeSpinNum, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 FreeSpinNum（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinNum">freespin剩余数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByFreeSpinNum(int freeSpinNum, int top_, TransactionManager tm_)
        {
            return GetByFreeSpinNum(freeSpinNum, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByFreeSpinNumAsync(int freeSpinNum, int top_, TransactionManager tm_)
        {
            return await GetByFreeSpinNumAsync(freeSpinNum, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 FreeSpinNum（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinNum">freespin剩余数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByFreeSpinNum(int freeSpinNum, string sort_)
        {
            return GetByFreeSpinNum(freeSpinNum, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByFreeSpinNumAsync(int freeSpinNum, string sort_)
        {
            return await GetByFreeSpinNumAsync(freeSpinNum, 0, sort_, null);
        }

        /// <summary>
        /// 按 FreeSpinNum（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinNum">freespin剩余数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByFreeSpinNum(int freeSpinNum, string sort_, TransactionManager tm_)
        {
            return GetByFreeSpinNum(freeSpinNum, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByFreeSpinNumAsync(int freeSpinNum, string sort_, TransactionManager tm_)
        {
            return await GetByFreeSpinNumAsync(freeSpinNum, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 FreeSpinNum（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinNum">freespin剩余数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByFreeSpinNum(int freeSpinNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`FreeSpinNum` = @FreeSpinNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@FreeSpinNum", freeSpinNum, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByFreeSpinNumAsync(int freeSpinNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`FreeSpinNum` = @FreeSpinNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@FreeSpinNum", freeSpinNum, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByFreeSpinNum
        #region GetByRetriggerNum

        /// <summary>
        /// 按 RetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerNum">retrigger剩余数量</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRetriggerNum(int retriggerNum)
        {
            return GetByRetriggerNum(retriggerNum, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRetriggerNumAsync(int retriggerNum)
        {
            return await GetByRetriggerNumAsync(retriggerNum, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 RetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerNum">retrigger剩余数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRetriggerNum(int retriggerNum, TransactionManager tm_)
        {
            return GetByRetriggerNum(retriggerNum, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRetriggerNumAsync(int retriggerNum, TransactionManager tm_)
        {
            return await GetByRetriggerNumAsync(retriggerNum, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerNum">retrigger剩余数量</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRetriggerNum(int retriggerNum, int top_)
        {
            return GetByRetriggerNum(retriggerNum, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRetriggerNumAsync(int retriggerNum, int top_)
        {
            return await GetByRetriggerNumAsync(retriggerNum, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 RetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerNum">retrigger剩余数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRetriggerNum(int retriggerNum, int top_, TransactionManager tm_)
        {
            return GetByRetriggerNum(retriggerNum, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRetriggerNumAsync(int retriggerNum, int top_, TransactionManager tm_)
        {
            return await GetByRetriggerNumAsync(retriggerNum, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerNum">retrigger剩余数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRetriggerNum(int retriggerNum, string sort_)
        {
            return GetByRetriggerNum(retriggerNum, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRetriggerNumAsync(int retriggerNum, string sort_)
        {
            return await GetByRetriggerNumAsync(retriggerNum, 0, sort_, null);
        }

        /// <summary>
        /// 按 RetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerNum">retrigger剩余数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRetriggerNum(int retriggerNum, string sort_, TransactionManager tm_)
        {
            return GetByRetriggerNum(retriggerNum, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRetriggerNumAsync(int retriggerNum, string sort_, TransactionManager tm_)
        {
            return await GetByRetriggerNumAsync(retriggerNum, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 RetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerNum">retrigger剩余数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRetriggerNum(int retriggerNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RetriggerNum` = @RetriggerNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RetriggerNum", retriggerNum, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRetriggerNumAsync(int retriggerNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RetriggerNum` = @RetriggerNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RetriggerNum", retriggerNum, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByRetriggerNum
        #region GetByRetriggerList

        /// <summary>
        /// 按 RetriggerList（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerList">retrigger出现顺序</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRetriggerList(string retriggerList)
        {
            return GetByRetriggerList(retriggerList, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRetriggerListAsync(string retriggerList)
        {
            return await GetByRetriggerListAsync(retriggerList, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 RetriggerList（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerList">retrigger出现顺序</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRetriggerList(string retriggerList, TransactionManager tm_)
        {
            return GetByRetriggerList(retriggerList, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRetriggerListAsync(string retriggerList, TransactionManager tm_)
        {
            return await GetByRetriggerListAsync(retriggerList, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RetriggerList（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerList">retrigger出现顺序</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRetriggerList(string retriggerList, int top_)
        {
            return GetByRetriggerList(retriggerList, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRetriggerListAsync(string retriggerList, int top_)
        {
            return await GetByRetriggerListAsync(retriggerList, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 RetriggerList（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerList">retrigger出现顺序</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRetriggerList(string retriggerList, int top_, TransactionManager tm_)
        {
            return GetByRetriggerList(retriggerList, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRetriggerListAsync(string retriggerList, int top_, TransactionManager tm_)
        {
            return await GetByRetriggerListAsync(retriggerList, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RetriggerList（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerList">retrigger出现顺序</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRetriggerList(string retriggerList, string sort_)
        {
            return GetByRetriggerList(retriggerList, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRetriggerListAsync(string retriggerList, string sort_)
        {
            return await GetByRetriggerListAsync(retriggerList, 0, sort_, null);
        }

        /// <summary>
        /// 按 RetriggerList（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerList">retrigger出现顺序</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRetriggerList(string retriggerList, string sort_, TransactionManager tm_)
        {
            return GetByRetriggerList(retriggerList, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRetriggerListAsync(string retriggerList, string sort_, TransactionManager tm_)
        {
            return await GetByRetriggerListAsync(retriggerList, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 RetriggerList（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerList">retrigger出现顺序</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRetriggerList(string retriggerList, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(retriggerList != null ? "`RetriggerList` = @RetriggerList" : "`RetriggerList` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (retriggerList != null)
                paras_.Add(Database.CreateInParameter("@RetriggerList", retriggerList, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRetriggerListAsync(string retriggerList, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(retriggerList != null ? "`RetriggerList` = @RetriggerList" : "`RetriggerList` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (retriggerList != null)
                paras_.Add(Database.CreateInParameter("@RetriggerList", retriggerList, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByRetriggerList
        #region GetByFreeSpinAmount

        /// <summary>
        /// 按 FreeSpinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinAmount">freespin环节总盈利</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByFreeSpinAmount(long freeSpinAmount)
        {
            return GetByFreeSpinAmount(freeSpinAmount, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByFreeSpinAmountAsync(long freeSpinAmount)
        {
            return await GetByFreeSpinAmountAsync(freeSpinAmount, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 FreeSpinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinAmount">freespin环节总盈利</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByFreeSpinAmount(long freeSpinAmount, TransactionManager tm_)
        {
            return GetByFreeSpinAmount(freeSpinAmount, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByFreeSpinAmountAsync(long freeSpinAmount, TransactionManager tm_)
        {
            return await GetByFreeSpinAmountAsync(freeSpinAmount, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 FreeSpinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinAmount">freespin环节总盈利</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByFreeSpinAmount(long freeSpinAmount, int top_)
        {
            return GetByFreeSpinAmount(freeSpinAmount, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByFreeSpinAmountAsync(long freeSpinAmount, int top_)
        {
            return await GetByFreeSpinAmountAsync(freeSpinAmount, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 FreeSpinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinAmount">freespin环节总盈利</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByFreeSpinAmount(long freeSpinAmount, int top_, TransactionManager tm_)
        {
            return GetByFreeSpinAmount(freeSpinAmount, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByFreeSpinAmountAsync(long freeSpinAmount, int top_, TransactionManager tm_)
        {
            return await GetByFreeSpinAmountAsync(freeSpinAmount, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 FreeSpinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinAmount">freespin环节总盈利</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByFreeSpinAmount(long freeSpinAmount, string sort_)
        {
            return GetByFreeSpinAmount(freeSpinAmount, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByFreeSpinAmountAsync(long freeSpinAmount, string sort_)
        {
            return await GetByFreeSpinAmountAsync(freeSpinAmount, 0, sort_, null);
        }

        /// <summary>
        /// 按 FreeSpinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinAmount">freespin环节总盈利</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByFreeSpinAmount(long freeSpinAmount, string sort_, TransactionManager tm_)
        {
            return GetByFreeSpinAmount(freeSpinAmount, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByFreeSpinAmountAsync(long freeSpinAmount, string sort_, TransactionManager tm_)
        {
            return await GetByFreeSpinAmountAsync(freeSpinAmount, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 FreeSpinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinAmount">freespin环节总盈利</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByFreeSpinAmount(long freeSpinAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`FreeSpinAmount` = @FreeSpinAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@FreeSpinAmount", freeSpinAmount, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByFreeSpinAmountAsync(long freeSpinAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`FreeSpinAmount` = @FreeSpinAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@FreeSpinAmount", freeSpinAmount, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByFreeSpinAmount
        #region GetByBaseLock

        /// <summary>
        /// 按 BaseLock（字段） 查询
        /// </summary>
        /// /// <param name = "baseLock">base部分锁定金额</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBaseLock(long baseLock)
        {
            return GetByBaseLock(baseLock, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBaseLockAsync(long baseLock)
        {
            return await GetByBaseLockAsync(baseLock, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BaseLock（字段） 查询
        /// </summary>
        /// /// <param name = "baseLock">base部分锁定金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBaseLock(long baseLock, TransactionManager tm_)
        {
            return GetByBaseLock(baseLock, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBaseLockAsync(long baseLock, TransactionManager tm_)
        {
            return await GetByBaseLockAsync(baseLock, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BaseLock（字段） 查询
        /// </summary>
        /// /// <param name = "baseLock">base部分锁定金额</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBaseLock(long baseLock, int top_)
        {
            return GetByBaseLock(baseLock, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBaseLockAsync(long baseLock, int top_)
        {
            return await GetByBaseLockAsync(baseLock, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BaseLock（字段） 查询
        /// </summary>
        /// /// <param name = "baseLock">base部分锁定金额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBaseLock(long baseLock, int top_, TransactionManager tm_)
        {
            return GetByBaseLock(baseLock, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBaseLockAsync(long baseLock, int top_, TransactionManager tm_)
        {
            return await GetByBaseLockAsync(baseLock, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BaseLock（字段） 查询
        /// </summary>
        /// /// <param name = "baseLock">base部分锁定金额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBaseLock(long baseLock, string sort_)
        {
            return GetByBaseLock(baseLock, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBaseLockAsync(long baseLock, string sort_)
        {
            return await GetByBaseLockAsync(baseLock, 0, sort_, null);
        }

        /// <summary>
        /// 按 BaseLock（字段） 查询
        /// </summary>
        /// /// <param name = "baseLock">base部分锁定金额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBaseLock(long baseLock, string sort_, TransactionManager tm_)
        {
            return GetByBaseLock(baseLock, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBaseLockAsync(long baseLock, string sort_, TransactionManager tm_)
        {
            return await GetByBaseLockAsync(baseLock, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BaseLock（字段） 查询
        /// </summary>
        /// /// <param name = "baseLock">base部分锁定金额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByBaseLock(long baseLock, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BaseLock` = @BaseLock", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BaseLock", baseLock, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByBaseLockAsync(long baseLock, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BaseLock` = @BaseLock", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BaseLock", baseLock, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByBaseLock
        #region GetBySlotID

        /// <summary>
        /// 按 SlotID（字段） 查询
        /// </summary>
        /// /// <param name = "slotID">最后一次slot明细编码</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetBySlotID(long? slotID)
        {
            return GetBySlotID(slotID, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetBySlotIDAsync(long? slotID)
        {
            return await GetBySlotIDAsync(slotID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 SlotID（字段） 查询
        /// </summary>
        /// /// <param name = "slotID">最后一次slot明细编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetBySlotID(long? slotID, TransactionManager tm_)
        {
            return GetBySlotID(slotID, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetBySlotIDAsync(long? slotID, TransactionManager tm_)
        {
            return await GetBySlotIDAsync(slotID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SlotID（字段） 查询
        /// </summary>
        /// /// <param name = "slotID">最后一次slot明细编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetBySlotID(long? slotID, int top_)
        {
            return GetBySlotID(slotID, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetBySlotIDAsync(long? slotID, int top_)
        {
            return await GetBySlotIDAsync(slotID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 SlotID（字段） 查询
        /// </summary>
        /// /// <param name = "slotID">最后一次slot明细编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetBySlotID(long? slotID, int top_, TransactionManager tm_)
        {
            return GetBySlotID(slotID, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetBySlotIDAsync(long? slotID, int top_, TransactionManager tm_)
        {
            return await GetBySlotIDAsync(slotID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SlotID（字段） 查询
        /// </summary>
        /// /// <param name = "slotID">最后一次slot明细编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetBySlotID(long? slotID, string sort_)
        {
            return GetBySlotID(slotID, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetBySlotIDAsync(long? slotID, string sort_)
        {
            return await GetBySlotIDAsync(slotID, 0, sort_, null);
        }

        /// <summary>
        /// 按 SlotID（字段） 查询
        /// </summary>
        /// /// <param name = "slotID">最后一次slot明细编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetBySlotID(long? slotID, string sort_, TransactionManager tm_)
        {
            return GetBySlotID(slotID, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetBySlotIDAsync(long? slotID, string sort_, TransactionManager tm_)
        {
            return await GetBySlotIDAsync(slotID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 SlotID（字段） 查询
        /// </summary>
        /// /// <param name = "slotID">最后一次slot明细编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetBySlotID(long? slotID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(slotID.HasValue ? "`SlotID` = @SlotID" : "`SlotID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (slotID.HasValue)
                paras_.Add(Database.CreateInParameter("@SlotID", slotID.Value, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetBySlotIDAsync(long? slotID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(slotID.HasValue ? "`SlotID` = @SlotID" : "`SlotID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (slotID.HasValue)
                paras_.Add(Database.CreateInParameter("@SlotID", slotID.Value, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetBySlotID
        #region GetByStatus

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态1-正常2-锁定中3-异常用户账户错误</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByStatus(int status)
        {
            return GetByStatus(status, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByStatusAsync(int status)
        {
            return await GetByStatusAsync(status, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态1-正常2-锁定中3-异常用户账户错误</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByStatus(int status, TransactionManager tm_)
        {
            return GetByStatus(status, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByStatusAsync(int status, TransactionManager tm_)
        {
            return await GetByStatusAsync(status, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态1-正常2-锁定中3-异常用户账户错误</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByStatus(int status, int top_)
        {
            return GetByStatus(status, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByStatusAsync(int status, int top_)
        {
            return await GetByStatusAsync(status, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态1-正常2-锁定中3-异常用户账户错误</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByStatus(int status, int top_, TransactionManager tm_)
        {
            return GetByStatus(status, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
        {
            return await GetByStatusAsync(status, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态1-正常2-锁定中3-异常用户账户错误</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByStatus(int status, string sort_)
        {
            return GetByStatus(status, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByStatusAsync(int status, string sort_)
        {
            return await GetByStatusAsync(status, 0, sort_, null);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态1-正常2-锁定中3-异常用户账户错误</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByStatus(int status, string sort_, TransactionManager tm_)
        {
            return GetByStatus(status, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
        {
            return await GetByStatusAsync(status, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态1-正常2-锁定中3-异常用户账户错误</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByStatus
        #region GetByRecDate

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRecDate(DateTime recDate)
        {
            return GetByRecDate(recDate, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRecDateAsync(DateTime recDate)
        {
            return await GetByRecDateAsync(recDate, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
        {
            return GetByRecDate(recDate, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
        {
            return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRecDate(DateTime recDate, int top_)
        {
            return GetByRecDate(recDate, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRecDateAsync(DateTime recDate, int top_)
        {
            return await GetByRecDateAsync(recDate, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
        {
            return GetByRecDate(recDate, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
        {
            return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRecDate(DateTime recDate, string sort_)
        {
            return GetByRecDate(recDate, 0, sort_, null);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRecDateAsync(DateTime recDate, string sort_)
        {
            return await GetByRecDateAsync(recDate, 0, sort_, null);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
        {
            return GetByRecDate(recDate, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
        {
            return await GetByRecDateAsync(recDate, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_chips_dataEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        public async Task<List<Gmf_user_chips_dataEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_chips_dataEO.MapDataReader);
        }
        #endregion // GetByRecDate
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
