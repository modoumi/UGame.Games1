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
    /// slot游戏明细
    /// 【表 gmf_user_slot 的实体类】
    /// </summary>
    [DataContract]
    public class Gmf_user_slotEO : IRowMapper<Gmf_user_slotEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Gmf_user_slotEO()
        {
            this.IsFreeSpin = false;
            this.PartBase = 0;
            this.PartBonus = 0;
            this.PartBingo = 0;
            this.PartIncome = 0;
            this.BingoIsOutTH = false;
            this.BingoIsWin = false;
            this.BingoJPPoolType = 0;
            this.BingoMultip = 0;
            this.BingoTotal = 0;
            this.BingoHitLine = 0;
            this.BingoKeepNum = 0;
            this.BingoWinAmount = 0;
            this.BonusIsOutTH = false;
            this.BonusIsWin = false;
            this.BonusMultip = 0;
            this.BonusTotal = 0;
            this.BonusSymbolNum = 0;
            this.BonusNewRetriggerNum = 0;
            this.FreeSpinNum = 0;
            this.RetriggerNum = 0;
            this.BonusWinAmount = 0;
            this.BaseIsWin = false;
            this.BaseMultip = 0;
            this.BaseWinAmount = 0;
            this.TotalAmount = 0;
            this.Status = 0;
            this.RecDate = DateTime.Now;
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private long _originalSlotID;
        /// <summary>
        /// 【数据库中的原始主键 SlotID 值的副本，用于主键值更新】
        /// </summary>
        public long OriginalSlotID
        {
            get { return _originalSlotID; }
            set { HasOriginal = true; _originalSlotID = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "SlotID", SlotID }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// 编码
        /// 【主键 bigint】
        /// </summary>
        [DataMember(Order = 1)]
        public long SlotID { get; set; }
        /// <summary>
        /// 用户编码(GUID)
        /// 【字段 varchar(38)】
        /// </summary>
        [DataMember(Order = 2)]
        public string UserID { get; set; }
        /// <summary>
        /// 筹码编码
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 3)]
        public int ChipsID { get; set; }
        /// <summary>
        /// 运营商编码
        /// 【字段 varchar(50)】
        /// </summary>
        [DataMember(Order = 4)]
        public string OperatorID { get; set; }
        /// <summary>
        /// 货币编码（ISO 4217大写）
        /// 【字段 varchar(5)】
        /// </summary>
        [DataMember(Order = 5)]
        public string CurrencyID { get; set; }
        /// <summary>
        /// 是否FreeSpin
        /// 【字段 tinyint(1)】
        /// </summary>
        [DataMember(Order = 6)]
        public bool IsFreeSpin { get; set; }
        /// <summary>
        /// BaseGame分配金额
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 7)]
        public long PartBase { get; set; }
        /// <summary>
        /// Bonus分配金额
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 8)]
        public long PartBonus { get; set; }
        /// <summary>
        /// Bingo分配金额
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 9)]
        public long PartBingo { get; set; }
        /// <summary>
        /// 收入分配金额
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 10)]
        public long PartIncome { get; set; }
        /// <summary>
        /// bingo是否超过阈值
        /// 【字段 tinyint(1)】
        /// </summary>
        [DataMember(Order = 11)]
        public bool BingoIsOutTH { get; set; }
        /// <summary>
        /// bingo是否奖励
        /// 【字段 tinyint(1)】
        /// </summary>
        [DataMember(Order = 12)]
        public bool BingoIsWin { get; set; }
        /// <summary>
        /// bingoJP奖池类型
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 13)]
        public int BingoJPPoolType { get; set; }
        /// <summary>
        /// bingo倍率
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 14)]
        public int BingoMultip { get; set; }
        /// <summary>
        /// Bingo累计
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 15)]
        public long BingoTotal { get; set; }
        /// <summary>
        /// 面板的25个球,按顺序|分割
        /// 【字段 varchar(100)】
        /// </summary>
        [DataMember(Order = 16)]
        public string BingoPanelNums { get; set; }
        /// <summary>
        /// Bingo中奖线
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 17)]
        public int BingoHitLine { get; set; }
        /// <summary>
        /// Bingo保留的数字
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 18)]
        public int BingoKeepNum { get; set; }
        /// <summary>
        /// Bingo保留的数字
        /// 【字段 varchar(100)】
        /// </summary>
        [DataMember(Order = 19)]
        public string BingoKeepNums { get; set; }
        /// <summary>
        /// bingo新数字
        /// 【字段 varchar(15)】
        /// </summary>
        [DataMember(Order = 20)]
        public string BingoNewNums { get; set; }
        /// <summary>
        /// 已出的75个数字,按顺序|分割
        /// 【字段 varchar(255)】
        /// </summary>
        [DataMember(Order = 21)]
        public string BingoHasNums { get; set; }
        /// <summary>
        /// bingo奖金
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 22)]
        public long BingoWinAmount { get; set; }
        /// <summary>
        /// bonus是否超过阈值
        /// 【字段 tinyint(1)】
        /// </summary>
        [DataMember(Order = 23)]
        public bool BonusIsOutTH { get; set; }
        /// <summary>
        /// Bunus是否奖励
        /// 【字段 tinyint(1)】
        /// </summary>
        [DataMember(Order = 24)]
        public bool BonusIsWin { get; set; }
        /// <summary>
        /// Bonus倍率
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 25)]
        public int BonusMultip { get; set; }
        /// <summary>
        /// Bonus累计
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 26)]
        public long BonusTotal { get; set; }
        /// <summary>
        /// Bunus球数量
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 27)]
        public int BonusSymbolNum { get; set; }
        /// <summary>
        /// Bonus新retrigger数
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 28)]
        public int BonusNewRetriggerNum { get; set; }
        /// <summary>
        /// freespin剩余数量
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 29)]
        public int FreeSpinNum { get; set; }
        /// <summary>
        /// retrigger剩余数量
        /// 【字段 tinyint】
        /// </summary>
        [DataMember(Order = 30)]
        public int RetriggerNum { get; set; }
        /// <summary>
        /// retrigger出现顺序
        /// 【字段 varchar(255)】
        /// </summary>
        [DataMember(Order = 31)]
        public string RetriggerList { get; set; }
        /// <summary>
        /// Bonus奖金
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 32)]
        public long BonusWinAmount { get; set; }
        /// <summary>
        /// base是否奖励
        /// 【字段 tinyint(1)】
        /// </summary>
        [DataMember(Order = 33)]
        public bool BaseIsWin { get; set; }
        /// <summary>
        /// base倍率
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 34)]
        public int BaseMultip { get; set; }
        /// <summary>
        /// base奖金
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 35)]
        public long BaseWinAmount { get; set; }
        /// <summary>
        /// 总盈利
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 36)]
        public long TotalAmount { get; set; }
        /// <summary>
        /// 抽取的组合ID
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 37)]
        public long SlotItemID { get; set; }
        /// <summary>
        /// 状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 38)]
        public int Status { get; set; }
        /// <summary>
        /// 记录时间
        /// 【字段 datetime】
        /// </summary>
        [DataMember(Order = 39)]
        public DateTime RecDate { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public Gmf_user_slotEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static Gmf_user_slotEO MapDataReader(IDataReader reader)
        {
            Gmf_user_slotEO ret = new Gmf_user_slotEO();
            ret.SlotID = reader.ToInt64("SlotID");
            ret.OriginalSlotID = ret.SlotID;
            ret.UserID = reader.ToString("UserID");
            ret.ChipsID = reader.ToInt32("ChipsID");
            ret.OperatorID = reader.ToString("OperatorID");
            ret.CurrencyID = reader.ToString("CurrencyID");
            ret.IsFreeSpin = reader.ToBoolean("IsFreeSpin");
            ret.PartBase = reader.ToInt64("PartBase");
            ret.PartBonus = reader.ToInt64("PartBonus");
            ret.PartBingo = reader.ToInt64("PartBingo");
            ret.PartIncome = reader.ToInt64("PartIncome");
            ret.BingoIsOutTH = reader.ToBoolean("BingoIsOutTH");
            ret.BingoIsWin = reader.ToBoolean("BingoIsWin");
            ret.BingoJPPoolType = reader.ToInt32("BingoJPPoolType");
            ret.BingoMultip = reader.ToInt32("BingoMultip");
            ret.BingoTotal = reader.ToInt64("BingoTotal");
            ret.BingoPanelNums = reader.ToString("BingoPanelNums");
            ret.BingoHitLine = reader.ToInt32("BingoHitLine");
            ret.BingoKeepNum = reader.ToInt32("BingoKeepNum");
            ret.BingoKeepNums = reader.ToString("BingoKeepNums");
            ret.BingoNewNums = reader.ToString("BingoNewNums");
            ret.BingoHasNums = reader.ToString("BingoHasNums");
            ret.BingoWinAmount = reader.ToInt64("BingoWinAmount");
            ret.BonusIsOutTH = reader.ToBoolean("BonusIsOutTH");
            ret.BonusIsWin = reader.ToBoolean("BonusIsWin");
            ret.BonusMultip = reader.ToInt32("BonusMultip");
            ret.BonusTotal = reader.ToInt64("BonusTotal");
            ret.BonusSymbolNum = reader.ToInt32("BonusSymbolNum");
            ret.BonusNewRetriggerNum = reader.ToInt32("BonusNewRetriggerNum");
            ret.FreeSpinNum = reader.ToInt32("FreeSpinNum");
            ret.RetriggerNum = reader.ToInt32("RetriggerNum");
            ret.RetriggerList = reader.ToString("RetriggerList");
            ret.BonusWinAmount = reader.ToInt64("BonusWinAmount");
            ret.BaseIsWin = reader.ToBoolean("BaseIsWin");
            ret.BaseMultip = reader.ToInt32("BaseMultip");
            ret.BaseWinAmount = reader.ToInt64("BaseWinAmount");
            ret.TotalAmount = reader.ToInt64("TotalAmount");
            ret.SlotItemID = reader.ToInt64("SlotItemID");
            ret.Status = reader.ToInt32("Status");
            ret.RecDate = reader.ToDateTime("RecDate");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// slot游戏明细
    /// 【表 gmf_user_slot 的操作类】
    /// </summary>
    public class Gmf_user_slotMO : MySqlTableMO<Gmf_user_slotEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`gmf_user_slot`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public Gmf_user_slotMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public Gmf_user_slotMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public Gmf_user_slotMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(Gmf_user_slotEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(Gmf_user_slotEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(Gmf_user_slotEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`SlotID`, `UserID`, `ChipsID`, `OperatorID`, `CurrencyID`, `IsFreeSpin`, `PartBase`, `PartBonus`, `PartBingo`, `PartIncome`, `BingoIsOutTH`, `BingoIsWin`, `BingoJPPoolType`, `BingoMultip`, `BingoTotal`, `BingoPanelNums`, `BingoHitLine`, `BingoKeepNum`, `BingoKeepNums`, `BingoNewNums`, `BingoHasNums`, `BingoWinAmount`, `BonusIsOutTH`, `BonusIsWin`, `BonusMultip`, `BonusTotal`, `BonusSymbolNum`, `BonusNewRetriggerNum`, `FreeSpinNum`, `RetriggerNum`, `RetriggerList`, `BonusWinAmount`, `BaseIsWin`, `BaseMultip`, `BaseWinAmount`, `TotalAmount`, `SlotItemID`, `Status`, `RecDate`) VALUE (@SlotID, @UserID, @ChipsID, @OperatorID, @CurrencyID, @IsFreeSpin, @PartBase, @PartBonus, @PartBingo, @PartIncome, @BingoIsOutTH, @BingoIsWin, @BingoJPPoolType, @BingoMultip, @BingoTotal, @BingoPanelNums, @BingoHitLine, @BingoKeepNum, @BingoKeepNums, @BingoNewNums, @BingoHasNums, @BingoWinAmount, @BonusIsOutTH, @BonusIsWin, @BonusMultip, @BonusTotal, @BonusSymbolNum, @BonusNewRetriggerNum, @FreeSpinNum, @RetriggerNum, @RetriggerList, @BonusWinAmount, @BaseIsWin, @BaseMultip, @BaseWinAmount, @TotalAmount, @SlotItemID, @Status, @RecDate);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", item.SlotID, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID", item.UserID != null ? item.UserID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
                Database.CreateInParameter("@IsFreeSpin", item.IsFreeSpin, MySqlDbType.Byte),
                Database.CreateInParameter("@PartBase", item.PartBase, MySqlDbType.Int64),
                Database.CreateInParameter("@PartBonus", item.PartBonus, MySqlDbType.Int64),
                Database.CreateInParameter("@PartBingo", item.PartBingo, MySqlDbType.Int64),
                Database.CreateInParameter("@PartIncome", item.PartIncome, MySqlDbType.Int64),
                Database.CreateInParameter("@BingoIsOutTH", item.BingoIsOutTH, MySqlDbType.Byte),
                Database.CreateInParameter("@BingoIsWin", item.BingoIsWin, MySqlDbType.Byte),
                Database.CreateInParameter("@BingoJPPoolType", item.BingoJPPoolType, MySqlDbType.Byte),
                Database.CreateInParameter("@BingoMultip", item.BingoMultip, MySqlDbType.Int32),
                Database.CreateInParameter("@BingoTotal", item.BingoTotal, MySqlDbType.Int64),
                Database.CreateInParameter("@BingoPanelNums", item.BingoPanelNums != null ? item.BingoPanelNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@BingoHitLine", item.BingoHitLine, MySqlDbType.Byte),
                Database.CreateInParameter("@BingoKeepNum", item.BingoKeepNum, MySqlDbType.Byte),
                Database.CreateInParameter("@BingoKeepNums", item.BingoKeepNums != null ? item.BingoKeepNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@BingoNewNums", item.BingoNewNums != null ? item.BingoNewNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@BingoHasNums", item.BingoHasNums != null ? item.BingoHasNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@BingoWinAmount", item.BingoWinAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@BonusIsOutTH", item.BonusIsOutTH, MySqlDbType.Byte),
                Database.CreateInParameter("@BonusIsWin", item.BonusIsWin, MySqlDbType.Byte),
                Database.CreateInParameter("@BonusMultip", item.BonusMultip, MySqlDbType.Int32),
                Database.CreateInParameter("@BonusTotal", item.BonusTotal, MySqlDbType.Int64),
                Database.CreateInParameter("@BonusSymbolNum", item.BonusSymbolNum, MySqlDbType.Byte),
                Database.CreateInParameter("@BonusNewRetriggerNum", item.BonusNewRetriggerNum, MySqlDbType.Byte),
                Database.CreateInParameter("@FreeSpinNum", item.FreeSpinNum, MySqlDbType.Byte),
                Database.CreateInParameter("@RetriggerNum", item.RetriggerNum, MySqlDbType.Byte),
                Database.CreateInParameter("@RetriggerList", item.RetriggerList != null ? item.RetriggerList : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@BonusWinAmount", item.BonusWinAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@BaseIsWin", item.BaseIsWin, MySqlDbType.Byte),
                Database.CreateInParameter("@BaseMultip", item.BaseMultip, MySqlDbType.Int32),
                Database.CreateInParameter("@BaseWinAmount", item.BaseWinAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@TotalAmount", item.TotalAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@SlotItemID", item.SlotItemID, MySqlDbType.Int64),
                Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
                Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
            };
        }
        public int AddByBatch(IEnumerable<Gmf_user_slotEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<Gmf_user_slotEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gmf_user_slotEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`SlotID`, `UserID`, `ChipsID`, `OperatorID`, `CurrencyID`, `IsFreeSpin`, `PartBase`, `PartBonus`, `PartBingo`, `PartIncome`, `BingoIsOutTH`, `BingoIsWin`, `BingoJPPoolType`, `BingoMultip`, `BingoTotal`, `BingoPanelNums`, `BingoHitLine`, `BingoKeepNum`, `BingoKeepNums`, `BingoNewNums`, `BingoHasNums`, `BingoWinAmount`, `BonusIsOutTH`, `BonusIsWin`, `BonusMultip`, `BonusTotal`, `BonusSymbolNum`, `BonusNewRetriggerNum`, `FreeSpinNum`, `RetriggerNum`, `RetriggerList`, `BonusWinAmount`, `BaseIsWin`, `BaseMultip`, `BaseWinAmount`, `TotalAmount`, `SlotItemID`, `Status`, `RecDate`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"({item.SlotID},'{item.UserID}',{item.ChipsID},'{item.OperatorID}','{item.CurrencyID}',{item.IsFreeSpin},{item.PartBase},{item.PartBonus},{item.PartBingo},{item.PartIncome},{item.BingoIsOutTH},{item.BingoIsWin},{item.BingoJPPoolType},{item.BingoMultip},{item.BingoTotal},'{item.BingoPanelNums}',{item.BingoHitLine},{item.BingoKeepNum},'{item.BingoKeepNums}','{item.BingoNewNums}','{item.BingoHasNums}',{item.BingoWinAmount},{item.BonusIsOutTH},{item.BonusIsWin},{item.BonusMultip},{item.BonusTotal},{item.BonusSymbolNum},{item.BonusNewRetriggerNum},{item.FreeSpinNum},{item.RetriggerNum},'{item.RetriggerList}',{item.BonusWinAmount},{item.BaseIsWin},{item.BaseMultip},{item.BaseWinAmount},{item.TotalAmount},{item.SlotItemID},{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(long slotID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(slotID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(slotID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(long slotID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(Gmf_user_slotEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.SlotID, tm_);
        }
        public async Task<int> RemoveAsync(Gmf_user_slotEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.SlotID, tm_);
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
            sql_ = $"DELETE FROM {TableName} WHERE " + (userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (userID != null)
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
        #region RemoveByIsFreeSpin
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "isFreeSpin">是否FreeSpin</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByIsFreeSpin(bool isFreeSpin, TransactionManager tm_ = null)
        {
            RepairRemoveByIsFreeSpinData(isFreeSpin, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByIsFreeSpinAsync(bool isFreeSpin, TransactionManager tm_ = null)
        {
            RepairRemoveByIsFreeSpinData(isFreeSpin, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByIsFreeSpinData(bool isFreeSpin, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `IsFreeSpin` = @IsFreeSpin";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IsFreeSpin", isFreeSpin, MySqlDbType.Byte));
        }
        #endregion // RemoveByIsFreeSpin
        #region RemoveByPartBase
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "partBase">BaseGame分配金额</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPartBase(long partBase, TransactionManager tm_ = null)
        {
            RepairRemoveByPartBaseData(partBase, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPartBaseAsync(long partBase, TransactionManager tm_ = null)
        {
            RepairRemoveByPartBaseData(partBase, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByPartBaseData(long partBase, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `PartBase` = @PartBase";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBase", partBase, MySqlDbType.Int64));
        }
        #endregion // RemoveByPartBase
        #region RemoveByPartBonus
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "partBonus">Bonus分配金额</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPartBonus(long partBonus, TransactionManager tm_ = null)
        {
            RepairRemoveByPartBonusData(partBonus, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPartBonusAsync(long partBonus, TransactionManager tm_ = null)
        {
            RepairRemoveByPartBonusData(partBonus, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByPartBonusData(long partBonus, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `PartBonus` = @PartBonus";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBonus", partBonus, MySqlDbType.Int64));
        }
        #endregion // RemoveByPartBonus
        #region RemoveByPartBingo
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "partBingo">Bingo分配金额</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPartBingo(long partBingo, TransactionManager tm_ = null)
        {
            RepairRemoveByPartBingoData(partBingo, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPartBingoAsync(long partBingo, TransactionManager tm_ = null)
        {
            RepairRemoveByPartBingoData(partBingo, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByPartBingoData(long partBingo, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `PartBingo` = @PartBingo";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBingo", partBingo, MySqlDbType.Int64));
        }
        #endregion // RemoveByPartBingo
        #region RemoveByPartIncome
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "partIncome">收入分配金额</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPartIncome(long partIncome, TransactionManager tm_ = null)
        {
            RepairRemoveByPartIncomeData(partIncome, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPartIncomeAsync(long partIncome, TransactionManager tm_ = null)
        {
            RepairRemoveByPartIncomeData(partIncome, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByPartIncomeData(long partIncome, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `PartIncome` = @PartIncome";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartIncome", partIncome, MySqlDbType.Int64));
        }
        #endregion // RemoveByPartIncome
        #region RemoveByBingoIsOutTH
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoIsOutTH">bingo是否超过阈值</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBingoIsOutTH(bool bingoIsOutTH, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoIsOutTHData(bingoIsOutTH, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBingoIsOutTHAsync(bool bingoIsOutTH, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoIsOutTHData(bingoIsOutTH, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBingoIsOutTHData(bool bingoIsOutTH, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BingoIsOutTH` = @BingoIsOutTH";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoIsOutTH", bingoIsOutTH, MySqlDbType.Byte));
        }
        #endregion // RemoveByBingoIsOutTH
        #region RemoveByBingoIsWin
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoIsWin">bingo是否奖励</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBingoIsWin(bool bingoIsWin, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoIsWinData(bingoIsWin, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBingoIsWinAsync(bool bingoIsWin, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoIsWinData(bingoIsWin, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBingoIsWinData(bool bingoIsWin, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BingoIsWin` = @BingoIsWin";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoIsWin", bingoIsWin, MySqlDbType.Byte));
        }
        #endregion // RemoveByBingoIsWin
        #region RemoveByBingoJPPoolType
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoJPPoolType">bingoJP奖池类型</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBingoJPPoolType(int bingoJPPoolType, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoJPPoolTypeData(bingoJPPoolType, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBingoJPPoolTypeAsync(int bingoJPPoolType, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoJPPoolTypeData(bingoJPPoolType, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBingoJPPoolTypeData(int bingoJPPoolType, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BingoJPPoolType` = @BingoJPPoolType";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoJPPoolType", bingoJPPoolType, MySqlDbType.Byte));
        }
        #endregion // RemoveByBingoJPPoolType
        #region RemoveByBingoMultip
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoMultip">bingo倍率</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBingoMultip(int bingoMultip, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoMultipData(bingoMultip, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBingoMultipAsync(int bingoMultip, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoMultipData(bingoMultip, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBingoMultipData(int bingoMultip, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BingoMultip` = @BingoMultip";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoMultip", bingoMultip, MySqlDbType.Int32));
        }
        #endregion // RemoveByBingoMultip
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
        #region RemoveByBingoPanelNums
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoPanelNums">面板的25个球,按顺序|分割</param>
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
        #region RemoveByBingoNewNums
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoNewNums">bingo新数字</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBingoNewNums(string bingoNewNums, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoNewNumsData(bingoNewNums, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBingoNewNumsAsync(string bingoNewNums, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoNewNumsData(bingoNewNums, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBingoNewNumsData(string bingoNewNums, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (bingoNewNums != null ? "`BingoNewNums` = @BingoNewNums" : "`BingoNewNums` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (bingoNewNums != null)
                paras_.Add(Database.CreateInParameter("@BingoNewNums", bingoNewNums, MySqlDbType.VarChar));
        }
        #endregion // RemoveByBingoNewNums
        #region RemoveByBingoHasNums
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoHasNums">已出的75个数字,按顺序|分割</param>
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
        #region RemoveByBingoWinAmount
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoWinAmount">bingo奖金</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBingoWinAmount(long bingoWinAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoWinAmountData(bingoWinAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBingoWinAmountAsync(long bingoWinAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoWinAmountData(bingoWinAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBingoWinAmountData(long bingoWinAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BingoWinAmount` = @BingoWinAmount";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoWinAmount", bingoWinAmount, MySqlDbType.Int64));
        }
        #endregion // RemoveByBingoWinAmount
        #region RemoveByBonusIsOutTH
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bonusIsOutTH">bonus是否超过阈值</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBonusIsOutTH(bool bonusIsOutTH, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusIsOutTHData(bonusIsOutTH, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBonusIsOutTHAsync(bool bonusIsOutTH, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusIsOutTHData(bonusIsOutTH, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBonusIsOutTHData(bool bonusIsOutTH, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BonusIsOutTH` = @BonusIsOutTH";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusIsOutTH", bonusIsOutTH, MySqlDbType.Byte));
        }
        #endregion // RemoveByBonusIsOutTH
        #region RemoveByBonusIsWin
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bonusIsWin">Bunus是否奖励</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBonusIsWin(bool bonusIsWin, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusIsWinData(bonusIsWin, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBonusIsWinAsync(bool bonusIsWin, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusIsWinData(bonusIsWin, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBonusIsWinData(bool bonusIsWin, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BonusIsWin` = @BonusIsWin";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusIsWin", bonusIsWin, MySqlDbType.Byte));
        }
        #endregion // RemoveByBonusIsWin
        #region RemoveByBonusMultip
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bonusMultip">Bonus倍率</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBonusMultip(int bonusMultip, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusMultipData(bonusMultip, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBonusMultipAsync(int bonusMultip, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusMultipData(bonusMultip, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBonusMultipData(int bonusMultip, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BonusMultip` = @BonusMultip";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusMultip", bonusMultip, MySqlDbType.Int32));
        }
        #endregion // RemoveByBonusMultip
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
        #region RemoveByBonusSymbolNum
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bonusSymbolNum">Bunus球数量</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBonusSymbolNum(int bonusSymbolNum, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusSymbolNumData(bonusSymbolNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBonusSymbolNumAsync(int bonusSymbolNum, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusSymbolNumData(bonusSymbolNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBonusSymbolNumData(int bonusSymbolNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BonusSymbolNum` = @BonusSymbolNum";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusSymbolNum", bonusSymbolNum, MySqlDbType.Byte));
        }
        #endregion // RemoveByBonusSymbolNum
        #region RemoveByBonusNewRetriggerNum
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bonusNewRetriggerNum">Bonus新retrigger数</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBonusNewRetriggerNum(int bonusNewRetriggerNum, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusNewRetriggerNumData(bonusNewRetriggerNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBonusNewRetriggerNumAsync(int bonusNewRetriggerNum, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusNewRetriggerNumData(bonusNewRetriggerNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBonusNewRetriggerNumData(int bonusNewRetriggerNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BonusNewRetriggerNum` = @BonusNewRetriggerNum";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusNewRetriggerNum", bonusNewRetriggerNum, MySqlDbType.Byte));
        }
        #endregion // RemoveByBonusNewRetriggerNum
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
        #region RemoveByBonusWinAmount
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bonusWinAmount">Bonus奖金</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBonusWinAmount(long bonusWinAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusWinAmountData(bonusWinAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBonusWinAmountAsync(long bonusWinAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusWinAmountData(bonusWinAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBonusWinAmountData(long bonusWinAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BonusWinAmount` = @BonusWinAmount";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusWinAmount", bonusWinAmount, MySqlDbType.Int64));
        }
        #endregion // RemoveByBonusWinAmount
        #region RemoveByBaseIsWin
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "baseIsWin">base是否奖励</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBaseIsWin(bool baseIsWin, TransactionManager tm_ = null)
        {
            RepairRemoveByBaseIsWinData(baseIsWin, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBaseIsWinAsync(bool baseIsWin, TransactionManager tm_ = null)
        {
            RepairRemoveByBaseIsWinData(baseIsWin, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBaseIsWinData(bool baseIsWin, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BaseIsWin` = @BaseIsWin";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BaseIsWin", baseIsWin, MySqlDbType.Byte));
        }
        #endregion // RemoveByBaseIsWin
        #region RemoveByBaseMultip
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "baseMultip">base倍率</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBaseMultip(int baseMultip, TransactionManager tm_ = null)
        {
            RepairRemoveByBaseMultipData(baseMultip, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBaseMultipAsync(int baseMultip, TransactionManager tm_ = null)
        {
            RepairRemoveByBaseMultipData(baseMultip, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBaseMultipData(int baseMultip, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BaseMultip` = @BaseMultip";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BaseMultip", baseMultip, MySqlDbType.Int32));
        }
        #endregion // RemoveByBaseMultip
        #region RemoveByBaseWinAmount
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "baseWinAmount">base奖金</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBaseWinAmount(long baseWinAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByBaseWinAmountData(baseWinAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBaseWinAmountAsync(long baseWinAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByBaseWinAmountData(baseWinAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBaseWinAmountData(long baseWinAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BaseWinAmount` = @BaseWinAmount";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BaseWinAmount", baseWinAmount, MySqlDbType.Int64));
        }
        #endregion // RemoveByBaseWinAmount
        #region RemoveByTotalAmount
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "totalAmount">总盈利</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByTotalAmount(long totalAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByTotalAmountData(totalAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByTotalAmountAsync(long totalAmount, TransactionManager tm_ = null)
        {
            RepairRemoveByTotalAmountData(totalAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByTotalAmountData(long totalAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `TotalAmount` = @TotalAmount";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalAmount", totalAmount, MySqlDbType.Int64));
        }
        #endregion // RemoveByTotalAmount
        #region RemoveBySlotItemID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "slotItemID">抽取的组合ID</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveBySlotItemID(long slotItemID, TransactionManager tm_ = null)
        {
            RepairRemoveBySlotItemIDData(slotItemID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveBySlotItemIDAsync(long slotItemID, TransactionManager tm_ = null)
        {
            RepairRemoveBySlotItemIDData(slotItemID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveBySlotItemIDData(long slotItemID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `SlotItemID` = @SlotItemID";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SlotItemID", slotItemID, MySqlDbType.Int64));
        }
        #endregion // RemoveBySlotItemID
        #region RemoveByStatus
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
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
            paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
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
        public int Put(Gmf_user_slotEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(Gmf_user_slotEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(Gmf_user_slotEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `SlotID` = @SlotID, `UserID` = @UserID, `ChipsID` = @ChipsID, `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `IsFreeSpin` = @IsFreeSpin, `PartBase` = @PartBase, `PartBonus` = @PartBonus, `PartBingo` = @PartBingo, `PartIncome` = @PartIncome, `BingoIsOutTH` = @BingoIsOutTH, `BingoIsWin` = @BingoIsWin, `BingoJPPoolType` = @BingoJPPoolType, `BingoMultip` = @BingoMultip, `BingoTotal` = @BingoTotal, `BingoPanelNums` = @BingoPanelNums, `BingoHitLine` = @BingoHitLine, `BingoKeepNum` = @BingoKeepNum, `BingoKeepNums` = @BingoKeepNums, `BingoNewNums` = @BingoNewNums, `BingoHasNums` = @BingoHasNums, `BingoWinAmount` = @BingoWinAmount, `BonusIsOutTH` = @BonusIsOutTH, `BonusIsWin` = @BonusIsWin, `BonusMultip` = @BonusMultip, `BonusTotal` = @BonusTotal, `BonusSymbolNum` = @BonusSymbolNum, `BonusNewRetriggerNum` = @BonusNewRetriggerNum, `FreeSpinNum` = @FreeSpinNum, `RetriggerNum` = @RetriggerNum, `RetriggerList` = @RetriggerList, `BonusWinAmount` = @BonusWinAmount, `BaseIsWin` = @BaseIsWin, `BaseMultip` = @BaseMultip, `BaseWinAmount` = @BaseWinAmount, `TotalAmount` = @TotalAmount, `SlotItemID` = @SlotItemID, `Status` = @Status WHERE `SlotID` = @SlotID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", item.SlotID, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID", item.UserID != null ? item.UserID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
                Database.CreateInParameter("@IsFreeSpin", item.IsFreeSpin, MySqlDbType.Byte),
                Database.CreateInParameter("@PartBase", item.PartBase, MySqlDbType.Int64),
                Database.CreateInParameter("@PartBonus", item.PartBonus, MySqlDbType.Int64),
                Database.CreateInParameter("@PartBingo", item.PartBingo, MySqlDbType.Int64),
                Database.CreateInParameter("@PartIncome", item.PartIncome, MySqlDbType.Int64),
                Database.CreateInParameter("@BingoIsOutTH", item.BingoIsOutTH, MySqlDbType.Byte),
                Database.CreateInParameter("@BingoIsWin", item.BingoIsWin, MySqlDbType.Byte),
                Database.CreateInParameter("@BingoJPPoolType", item.BingoJPPoolType, MySqlDbType.Byte),
                Database.CreateInParameter("@BingoMultip", item.BingoMultip, MySqlDbType.Int32),
                Database.CreateInParameter("@BingoTotal", item.BingoTotal, MySqlDbType.Int64),
                Database.CreateInParameter("@BingoPanelNums", item.BingoPanelNums != null ? item.BingoPanelNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@BingoHitLine", item.BingoHitLine, MySqlDbType.Byte),
                Database.CreateInParameter("@BingoKeepNum", item.BingoKeepNum, MySqlDbType.Byte),
                Database.CreateInParameter("@BingoKeepNums", item.BingoKeepNums != null ? item.BingoKeepNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@BingoNewNums", item.BingoNewNums != null ? item.BingoNewNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@BingoHasNums", item.BingoHasNums != null ? item.BingoHasNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@BingoWinAmount", item.BingoWinAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@BonusIsOutTH", item.BonusIsOutTH, MySqlDbType.Byte),
                Database.CreateInParameter("@BonusIsWin", item.BonusIsWin, MySqlDbType.Byte),
                Database.CreateInParameter("@BonusMultip", item.BonusMultip, MySqlDbType.Int32),
                Database.CreateInParameter("@BonusTotal", item.BonusTotal, MySqlDbType.Int64),
                Database.CreateInParameter("@BonusSymbolNum", item.BonusSymbolNum, MySqlDbType.Byte),
                Database.CreateInParameter("@BonusNewRetriggerNum", item.BonusNewRetriggerNum, MySqlDbType.Byte),
                Database.CreateInParameter("@FreeSpinNum", item.FreeSpinNum, MySqlDbType.Byte),
                Database.CreateInParameter("@RetriggerNum", item.RetriggerNum, MySqlDbType.Byte),
                Database.CreateInParameter("@RetriggerList", item.RetriggerList != null ? item.RetriggerList : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@BonusWinAmount", item.BonusWinAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@BaseIsWin", item.BaseIsWin, MySqlDbType.Byte),
                Database.CreateInParameter("@BaseMultip", item.BaseMultip, MySqlDbType.Int32),
                Database.CreateInParameter("@BaseWinAmount", item.BaseWinAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@TotalAmount", item.TotalAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@SlotItemID", item.SlotItemID, MySqlDbType.Int64),
                Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
                Database.CreateInParameter("@SlotID_Original", item.HasOriginal ? item.OriginalSlotID : item.SlotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<Gmf_user_slotEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<Gmf_user_slotEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "slotID">编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(long slotID, string set_, params object[] values_)
        {
            return Put(set_, "`SlotID` = @SlotID", ConcatValues(values_, slotID));
        }
        public async Task<int> PutByPKAsync(long slotID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`SlotID` = @SlotID", ConcatValues(values_, slotID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(long slotID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`SlotID` = @SlotID", tm_, ConcatValues(values_, slotID));
        }
        public async Task<int> PutByPKAsync(long slotID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`SlotID` = @SlotID", tm_, ConcatValues(values_, slotID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(long slotID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return Put(set_, "`SlotID` = @SlotID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(long slotID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return await PutAsync(set_, "`SlotID` = @SlotID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutUserID
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutUserIDByPK(long slotID, string userID, TransactionManager tm_ = null)
        {
            RepairPutUserIDByPKData(slotID, userID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutUserIDByPKAsync(long slotID, string userID, TransactionManager tm_ = null)
        {
            RepairPutUserIDByPKData(slotID, userID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutUserIDByPKData(long slotID, string userID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `UserID` = @UserID  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutUserID(string userID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
            var parameter_ = Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutUserIDAsync(string userID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
            var parameter_ = Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutUserID
        #region PutChipsID
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutChipsIDByPK(long slotID, int chipsID, TransactionManager tm_ = null)
        {
            RepairPutChipsIDByPKData(slotID, chipsID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutChipsIDByPKAsync(long slotID, int chipsID, TransactionManager tm_ = null)
        {
            RepairPutChipsIDByPKData(slotID, chipsID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutChipsIDByPKData(long slotID, int chipsID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `ChipsID` = @ChipsID  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

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
        #region PutOperatorID
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutOperatorIDByPK(long slotID, string operatorID, TransactionManager tm_ = null)
        {
            RepairPutOperatorIDByPKData(slotID, operatorID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutOperatorIDByPKAsync(long slotID, string operatorID, TransactionManager tm_ = null)
        {
            RepairPutOperatorIDByPKData(slotID, operatorID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutOperatorIDByPKData(long slotID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

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
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutCurrencyIDByPK(long slotID, string currencyID, TransactionManager tm_ = null)
        {
            RepairPutCurrencyIDByPKData(slotID, currencyID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutCurrencyIDByPKAsync(long slotID, string currencyID, TransactionManager tm_ = null)
        {
            RepairPutCurrencyIDByPKData(slotID, currencyID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutCurrencyIDByPKData(long slotID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

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
        #region PutIsFreeSpin
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "isFreeSpin">是否FreeSpin</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutIsFreeSpinByPK(long slotID, bool isFreeSpin, TransactionManager tm_ = null)
        {
            RepairPutIsFreeSpinByPKData(slotID, isFreeSpin, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutIsFreeSpinByPKAsync(long slotID, bool isFreeSpin, TransactionManager tm_ = null)
        {
            RepairPutIsFreeSpinByPKData(slotID, isFreeSpin, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutIsFreeSpinByPKData(long slotID, bool isFreeSpin, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `IsFreeSpin` = @IsFreeSpin  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@IsFreeSpin", isFreeSpin, MySqlDbType.Byte),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "isFreeSpin">是否FreeSpin</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutIsFreeSpin(bool isFreeSpin, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `IsFreeSpin` = @IsFreeSpin";
            var parameter_ = Database.CreateInParameter("@IsFreeSpin", isFreeSpin, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutIsFreeSpinAsync(bool isFreeSpin, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `IsFreeSpin` = @IsFreeSpin";
            var parameter_ = Database.CreateInParameter("@IsFreeSpin", isFreeSpin, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutIsFreeSpin
        #region PutPartBase
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "partBase">BaseGame分配金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutPartBaseByPK(long slotID, long partBase, TransactionManager tm_ = null)
        {
            RepairPutPartBaseByPKData(slotID, partBase, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutPartBaseByPKAsync(long slotID, long partBase, TransactionManager tm_ = null)
        {
            RepairPutPartBaseByPKData(slotID, partBase, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutPartBaseByPKData(long slotID, long partBase, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `PartBase` = @PartBase  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@PartBase", partBase, MySqlDbType.Int64),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "partBase">BaseGame分配金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutPartBase(long partBase, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `PartBase` = @PartBase";
            var parameter_ = Database.CreateInParameter("@PartBase", partBase, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutPartBaseAsync(long partBase, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `PartBase` = @PartBase";
            var parameter_ = Database.CreateInParameter("@PartBase", partBase, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutPartBase
        #region PutPartBonus
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "partBonus">Bonus分配金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutPartBonusByPK(long slotID, long partBonus, TransactionManager tm_ = null)
        {
            RepairPutPartBonusByPKData(slotID, partBonus, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutPartBonusByPKAsync(long slotID, long partBonus, TransactionManager tm_ = null)
        {
            RepairPutPartBonusByPKData(slotID, partBonus, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutPartBonusByPKData(long slotID, long partBonus, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `PartBonus` = @PartBonus  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@PartBonus", partBonus, MySqlDbType.Int64),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "partBonus">Bonus分配金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutPartBonus(long partBonus, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `PartBonus` = @PartBonus";
            var parameter_ = Database.CreateInParameter("@PartBonus", partBonus, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutPartBonusAsync(long partBonus, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `PartBonus` = @PartBonus";
            var parameter_ = Database.CreateInParameter("@PartBonus", partBonus, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutPartBonus
        #region PutPartBingo
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "partBingo">Bingo分配金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutPartBingoByPK(long slotID, long partBingo, TransactionManager tm_ = null)
        {
            RepairPutPartBingoByPKData(slotID, partBingo, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutPartBingoByPKAsync(long slotID, long partBingo, TransactionManager tm_ = null)
        {
            RepairPutPartBingoByPKData(slotID, partBingo, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutPartBingoByPKData(long slotID, long partBingo, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `PartBingo` = @PartBingo  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@PartBingo", partBingo, MySqlDbType.Int64),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "partBingo">Bingo分配金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutPartBingo(long partBingo, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `PartBingo` = @PartBingo";
            var parameter_ = Database.CreateInParameter("@PartBingo", partBingo, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutPartBingoAsync(long partBingo, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `PartBingo` = @PartBingo";
            var parameter_ = Database.CreateInParameter("@PartBingo", partBingo, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutPartBingo
        #region PutPartIncome
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "partIncome">收入分配金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutPartIncomeByPK(long slotID, long partIncome, TransactionManager tm_ = null)
        {
            RepairPutPartIncomeByPKData(slotID, partIncome, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutPartIncomeByPKAsync(long slotID, long partIncome, TransactionManager tm_ = null)
        {
            RepairPutPartIncomeByPKData(slotID, partIncome, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutPartIncomeByPKData(long slotID, long partIncome, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `PartIncome` = @PartIncome  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@PartIncome", partIncome, MySqlDbType.Int64),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "partIncome">收入分配金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutPartIncome(long partIncome, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `PartIncome` = @PartIncome";
            var parameter_ = Database.CreateInParameter("@PartIncome", partIncome, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutPartIncomeAsync(long partIncome, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `PartIncome` = @PartIncome";
            var parameter_ = Database.CreateInParameter("@PartIncome", partIncome, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutPartIncome
        #region PutBingoIsOutTH
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bingoIsOutTH">bingo是否超过阈值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoIsOutTHByPK(long slotID, bool bingoIsOutTH, TransactionManager tm_ = null)
        {
            RepairPutBingoIsOutTHByPKData(slotID, bingoIsOutTH, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoIsOutTHByPKAsync(long slotID, bool bingoIsOutTH, TransactionManager tm_ = null)
        {
            RepairPutBingoIsOutTHByPKData(slotID, bingoIsOutTH, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoIsOutTHByPKData(long slotID, bool bingoIsOutTH, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoIsOutTH` = @BingoIsOutTH  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoIsOutTH", bingoIsOutTH, MySqlDbType.Byte),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoIsOutTH">bingo是否超过阈值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoIsOutTH(bool bingoIsOutTH, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoIsOutTH` = @BingoIsOutTH";
            var parameter_ = Database.CreateInParameter("@BingoIsOutTH", bingoIsOutTH, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBingoIsOutTHAsync(bool bingoIsOutTH, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoIsOutTH` = @BingoIsOutTH";
            var parameter_ = Database.CreateInParameter("@BingoIsOutTH", bingoIsOutTH, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBingoIsOutTH
        #region PutBingoIsWin
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bingoIsWin">bingo是否奖励</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoIsWinByPK(long slotID, bool bingoIsWin, TransactionManager tm_ = null)
        {
            RepairPutBingoIsWinByPKData(slotID, bingoIsWin, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoIsWinByPKAsync(long slotID, bool bingoIsWin, TransactionManager tm_ = null)
        {
            RepairPutBingoIsWinByPKData(slotID, bingoIsWin, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoIsWinByPKData(long slotID, bool bingoIsWin, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoIsWin` = @BingoIsWin  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoIsWin", bingoIsWin, MySqlDbType.Byte),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoIsWin">bingo是否奖励</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoIsWin(bool bingoIsWin, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoIsWin` = @BingoIsWin";
            var parameter_ = Database.CreateInParameter("@BingoIsWin", bingoIsWin, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBingoIsWinAsync(bool bingoIsWin, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoIsWin` = @BingoIsWin";
            var parameter_ = Database.CreateInParameter("@BingoIsWin", bingoIsWin, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBingoIsWin
        #region PutBingoJPPoolType
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bingoJPPoolType">bingoJP奖池类型</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoJPPoolTypeByPK(long slotID, int bingoJPPoolType, TransactionManager tm_ = null)
        {
            RepairPutBingoJPPoolTypeByPKData(slotID, bingoJPPoolType, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoJPPoolTypeByPKAsync(long slotID, int bingoJPPoolType, TransactionManager tm_ = null)
        {
            RepairPutBingoJPPoolTypeByPKData(slotID, bingoJPPoolType, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoJPPoolTypeByPKData(long slotID, int bingoJPPoolType, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoJPPoolType` = @BingoJPPoolType  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoJPPoolType", bingoJPPoolType, MySqlDbType.Byte),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoJPPoolType">bingoJP奖池类型</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoJPPoolType(int bingoJPPoolType, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoJPPoolType` = @BingoJPPoolType";
            var parameter_ = Database.CreateInParameter("@BingoJPPoolType", bingoJPPoolType, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBingoJPPoolTypeAsync(int bingoJPPoolType, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoJPPoolType` = @BingoJPPoolType";
            var parameter_ = Database.CreateInParameter("@BingoJPPoolType", bingoJPPoolType, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBingoJPPoolType
        #region PutBingoMultip
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bingoMultip">bingo倍率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoMultipByPK(long slotID, int bingoMultip, TransactionManager tm_ = null)
        {
            RepairPutBingoMultipByPKData(slotID, bingoMultip, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoMultipByPKAsync(long slotID, int bingoMultip, TransactionManager tm_ = null)
        {
            RepairPutBingoMultipByPKData(slotID, bingoMultip, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoMultipByPKData(long slotID, int bingoMultip, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoMultip` = @BingoMultip  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoMultip", bingoMultip, MySqlDbType.Int32),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoMultip">bingo倍率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoMultip(int bingoMultip, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoMultip` = @BingoMultip";
            var parameter_ = Database.CreateInParameter("@BingoMultip", bingoMultip, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBingoMultipAsync(int bingoMultip, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoMultip` = @BingoMultip";
            var parameter_ = Database.CreateInParameter("@BingoMultip", bingoMultip, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBingoMultip
        #region PutBingoTotal
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bingoTotal">Bingo累计</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoTotalByPK(long slotID, long bingoTotal, TransactionManager tm_ = null)
        {
            RepairPutBingoTotalByPKData(slotID, bingoTotal, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoTotalByPKAsync(long slotID, long bingoTotal, TransactionManager tm_ = null)
        {
            RepairPutBingoTotalByPKData(slotID, bingoTotal, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoTotalByPKData(long slotID, long bingoTotal, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoTotal` = @BingoTotal  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoTotal", bingoTotal, MySqlDbType.Int64),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
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
        #region PutBingoPanelNums
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bingoPanelNums">面板的25个球,按顺序|分割</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoPanelNumsByPK(long slotID, string bingoPanelNums, TransactionManager tm_ = null)
        {
            RepairPutBingoPanelNumsByPKData(slotID, bingoPanelNums, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoPanelNumsByPKAsync(long slotID, string bingoPanelNums, TransactionManager tm_ = null)
        {
            RepairPutBingoPanelNumsByPKData(slotID, bingoPanelNums, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoPanelNumsByPKData(long slotID, string bingoPanelNums, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoPanelNums` = @BingoPanelNums  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoPanelNums", bingoPanelNums != null ? bingoPanelNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoPanelNums">面板的25个球,按顺序|分割</param>
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
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bingoHitLine">Bingo中奖线</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoHitLineByPK(long slotID, int bingoHitLine, TransactionManager tm_ = null)
        {
            RepairPutBingoHitLineByPKData(slotID, bingoHitLine, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoHitLineByPKAsync(long slotID, int bingoHitLine, TransactionManager tm_ = null)
        {
            RepairPutBingoHitLineByPKData(slotID, bingoHitLine, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoHitLineByPKData(long slotID, int bingoHitLine, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoHitLine` = @BingoHitLine  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoHitLine", bingoHitLine, MySqlDbType.Byte),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
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
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bingoKeepNum">Bingo保留的数字</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoKeepNumByPK(long slotID, int bingoKeepNum, TransactionManager tm_ = null)
        {
            RepairPutBingoKeepNumByPKData(slotID, bingoKeepNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoKeepNumByPKAsync(long slotID, int bingoKeepNum, TransactionManager tm_ = null)
        {
            RepairPutBingoKeepNumByPKData(slotID, bingoKeepNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoKeepNumByPKData(long slotID, int bingoKeepNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoKeepNum` = @BingoKeepNum  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoKeepNum", bingoKeepNum, MySqlDbType.Byte),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
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
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bingoKeepNums">Bingo保留的数字</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoKeepNumsByPK(long slotID, string bingoKeepNums, TransactionManager tm_ = null)
        {
            RepairPutBingoKeepNumsByPKData(slotID, bingoKeepNums, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoKeepNumsByPKAsync(long slotID, string bingoKeepNums, TransactionManager tm_ = null)
        {
            RepairPutBingoKeepNumsByPKData(slotID, bingoKeepNums, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoKeepNumsByPKData(long slotID, string bingoKeepNums, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoKeepNums` = @BingoKeepNums  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoKeepNums", bingoKeepNums != null ? bingoKeepNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
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
        #region PutBingoNewNums
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bingoNewNums">bingo新数字</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoNewNumsByPK(long slotID, string bingoNewNums, TransactionManager tm_ = null)
        {
            RepairPutBingoNewNumsByPKData(slotID, bingoNewNums, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoNewNumsByPKAsync(long slotID, string bingoNewNums, TransactionManager tm_ = null)
        {
            RepairPutBingoNewNumsByPKData(slotID, bingoNewNums, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoNewNumsByPKData(long slotID, string bingoNewNums, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoNewNums` = @BingoNewNums  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoNewNums", bingoNewNums != null ? bingoNewNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoNewNums">bingo新数字</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoNewNums(string bingoNewNums, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoNewNums` = @BingoNewNums";
            var parameter_ = Database.CreateInParameter("@BingoNewNums", bingoNewNums != null ? bingoNewNums : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBingoNewNumsAsync(string bingoNewNums, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoNewNums` = @BingoNewNums";
            var parameter_ = Database.CreateInParameter("@BingoNewNums", bingoNewNums != null ? bingoNewNums : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBingoNewNums
        #region PutBingoHasNums
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bingoHasNums">已出的75个数字,按顺序|分割</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoHasNumsByPK(long slotID, string bingoHasNums, TransactionManager tm_ = null)
        {
            RepairPutBingoHasNumsByPKData(slotID, bingoHasNums, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoHasNumsByPKAsync(long slotID, string bingoHasNums, TransactionManager tm_ = null)
        {
            RepairPutBingoHasNumsByPKData(slotID, bingoHasNums, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoHasNumsByPKData(long slotID, string bingoHasNums, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoHasNums` = @BingoHasNums  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoHasNums", bingoHasNums != null ? bingoHasNums : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoHasNums">已出的75个数字,按顺序|分割</param>
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
        #region PutBingoWinAmount
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bingoWinAmount">bingo奖金</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoWinAmountByPK(long slotID, long bingoWinAmount, TransactionManager tm_ = null)
        {
            RepairPutBingoWinAmountByPKData(slotID, bingoWinAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoWinAmountByPKAsync(long slotID, long bingoWinAmount, TransactionManager tm_ = null)
        {
            RepairPutBingoWinAmountByPKData(slotID, bingoWinAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoWinAmountByPKData(long slotID, long bingoWinAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoWinAmount` = @BingoWinAmount  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoWinAmount", bingoWinAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoWinAmount">bingo奖金</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoWinAmount(long bingoWinAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoWinAmount` = @BingoWinAmount";
            var parameter_ = Database.CreateInParameter("@BingoWinAmount", bingoWinAmount, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBingoWinAmountAsync(long bingoWinAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoWinAmount` = @BingoWinAmount";
            var parameter_ = Database.CreateInParameter("@BingoWinAmount", bingoWinAmount, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBingoWinAmount
        #region PutBonusIsOutTH
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bonusIsOutTH">bonus是否超过阈值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusIsOutTHByPK(long slotID, bool bonusIsOutTH, TransactionManager tm_ = null)
        {
            RepairPutBonusIsOutTHByPKData(slotID, bonusIsOutTH, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBonusIsOutTHByPKAsync(long slotID, bool bonusIsOutTH, TransactionManager tm_ = null)
        {
            RepairPutBonusIsOutTHByPKData(slotID, bonusIsOutTH, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBonusIsOutTHByPKData(long slotID, bool bonusIsOutTH, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BonusIsOutTH` = @BonusIsOutTH  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BonusIsOutTH", bonusIsOutTH, MySqlDbType.Byte),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bonusIsOutTH">bonus是否超过阈值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusIsOutTH(bool bonusIsOutTH, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusIsOutTH` = @BonusIsOutTH";
            var parameter_ = Database.CreateInParameter("@BonusIsOutTH", bonusIsOutTH, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBonusIsOutTHAsync(bool bonusIsOutTH, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusIsOutTH` = @BonusIsOutTH";
            var parameter_ = Database.CreateInParameter("@BonusIsOutTH", bonusIsOutTH, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBonusIsOutTH
        #region PutBonusIsWin
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bonusIsWin">Bunus是否奖励</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusIsWinByPK(long slotID, bool bonusIsWin, TransactionManager tm_ = null)
        {
            RepairPutBonusIsWinByPKData(slotID, bonusIsWin, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBonusIsWinByPKAsync(long slotID, bool bonusIsWin, TransactionManager tm_ = null)
        {
            RepairPutBonusIsWinByPKData(slotID, bonusIsWin, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBonusIsWinByPKData(long slotID, bool bonusIsWin, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BonusIsWin` = @BonusIsWin  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BonusIsWin", bonusIsWin, MySqlDbType.Byte),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bonusIsWin">Bunus是否奖励</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusIsWin(bool bonusIsWin, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusIsWin` = @BonusIsWin";
            var parameter_ = Database.CreateInParameter("@BonusIsWin", bonusIsWin, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBonusIsWinAsync(bool bonusIsWin, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusIsWin` = @BonusIsWin";
            var parameter_ = Database.CreateInParameter("@BonusIsWin", bonusIsWin, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBonusIsWin
        #region PutBonusMultip
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bonusMultip">Bonus倍率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusMultipByPK(long slotID, int bonusMultip, TransactionManager tm_ = null)
        {
            RepairPutBonusMultipByPKData(slotID, bonusMultip, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBonusMultipByPKAsync(long slotID, int bonusMultip, TransactionManager tm_ = null)
        {
            RepairPutBonusMultipByPKData(slotID, bonusMultip, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBonusMultipByPKData(long slotID, int bonusMultip, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BonusMultip` = @BonusMultip  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BonusMultip", bonusMultip, MySqlDbType.Int32),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bonusMultip">Bonus倍率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusMultip(int bonusMultip, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusMultip` = @BonusMultip";
            var parameter_ = Database.CreateInParameter("@BonusMultip", bonusMultip, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBonusMultipAsync(int bonusMultip, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusMultip` = @BonusMultip";
            var parameter_ = Database.CreateInParameter("@BonusMultip", bonusMultip, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBonusMultip
        #region PutBonusTotal
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bonusTotal">Bonus累计</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusTotalByPK(long slotID, long bonusTotal, TransactionManager tm_ = null)
        {
            RepairPutBonusTotalByPKData(slotID, bonusTotal, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBonusTotalByPKAsync(long slotID, long bonusTotal, TransactionManager tm_ = null)
        {
            RepairPutBonusTotalByPKData(slotID, bonusTotal, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBonusTotalByPKData(long slotID, long bonusTotal, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BonusTotal` = @BonusTotal  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BonusTotal", bonusTotal, MySqlDbType.Int64),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
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
        #region PutBonusSymbolNum
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bonusSymbolNum">Bunus球数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusSymbolNumByPK(long slotID, int bonusSymbolNum, TransactionManager tm_ = null)
        {
            RepairPutBonusSymbolNumByPKData(slotID, bonusSymbolNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBonusSymbolNumByPKAsync(long slotID, int bonusSymbolNum, TransactionManager tm_ = null)
        {
            RepairPutBonusSymbolNumByPKData(slotID, bonusSymbolNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBonusSymbolNumByPKData(long slotID, int bonusSymbolNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BonusSymbolNum` = @BonusSymbolNum  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BonusSymbolNum", bonusSymbolNum, MySqlDbType.Byte),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bonusSymbolNum">Bunus球数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusSymbolNum(int bonusSymbolNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusSymbolNum` = @BonusSymbolNum";
            var parameter_ = Database.CreateInParameter("@BonusSymbolNum", bonusSymbolNum, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBonusSymbolNumAsync(int bonusSymbolNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusSymbolNum` = @BonusSymbolNum";
            var parameter_ = Database.CreateInParameter("@BonusSymbolNum", bonusSymbolNum, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBonusSymbolNum
        #region PutBonusNewRetriggerNum
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bonusNewRetriggerNum">Bonus新retrigger数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusNewRetriggerNumByPK(long slotID, int bonusNewRetriggerNum, TransactionManager tm_ = null)
        {
            RepairPutBonusNewRetriggerNumByPKData(slotID, bonusNewRetriggerNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBonusNewRetriggerNumByPKAsync(long slotID, int bonusNewRetriggerNum, TransactionManager tm_ = null)
        {
            RepairPutBonusNewRetriggerNumByPKData(slotID, bonusNewRetriggerNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBonusNewRetriggerNumByPKData(long slotID, int bonusNewRetriggerNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BonusNewRetriggerNum` = @BonusNewRetriggerNum  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BonusNewRetriggerNum", bonusNewRetriggerNum, MySqlDbType.Byte),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bonusNewRetriggerNum">Bonus新retrigger数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusNewRetriggerNum(int bonusNewRetriggerNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusNewRetriggerNum` = @BonusNewRetriggerNum";
            var parameter_ = Database.CreateInParameter("@BonusNewRetriggerNum", bonusNewRetriggerNum, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBonusNewRetriggerNumAsync(int bonusNewRetriggerNum, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusNewRetriggerNum` = @BonusNewRetriggerNum";
            var parameter_ = Database.CreateInParameter("@BonusNewRetriggerNum", bonusNewRetriggerNum, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBonusNewRetriggerNum
        #region PutFreeSpinNum
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "freeSpinNum">freespin剩余数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutFreeSpinNumByPK(long slotID, int freeSpinNum, TransactionManager tm_ = null)
        {
            RepairPutFreeSpinNumByPKData(slotID, freeSpinNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutFreeSpinNumByPKAsync(long slotID, int freeSpinNum, TransactionManager tm_ = null)
        {
            RepairPutFreeSpinNumByPKData(slotID, freeSpinNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutFreeSpinNumByPKData(long slotID, int freeSpinNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `FreeSpinNum` = @FreeSpinNum  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@FreeSpinNum", freeSpinNum, MySqlDbType.Byte),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
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
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "retriggerNum">retrigger剩余数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRetriggerNumByPK(long slotID, int retriggerNum, TransactionManager tm_ = null)
        {
            RepairPutRetriggerNumByPKData(slotID, retriggerNum, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRetriggerNumByPKAsync(long slotID, int retriggerNum, TransactionManager tm_ = null)
        {
            RepairPutRetriggerNumByPKData(slotID, retriggerNum, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRetriggerNumByPKData(long slotID, int retriggerNum, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `RetriggerNum` = @RetriggerNum  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RetriggerNum", retriggerNum, MySqlDbType.Byte),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
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
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "retriggerList">retrigger出现顺序</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRetriggerListByPK(long slotID, string retriggerList, TransactionManager tm_ = null)
        {
            RepairPutRetriggerListByPKData(slotID, retriggerList, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRetriggerListByPKAsync(long slotID, string retriggerList, TransactionManager tm_ = null)
        {
            RepairPutRetriggerListByPKData(slotID, retriggerList, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRetriggerListByPKData(long slotID, string retriggerList, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `RetriggerList` = @RetriggerList  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RetriggerList", retriggerList != null ? retriggerList : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
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
        #region PutBonusWinAmount
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "bonusWinAmount">Bonus奖金</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusWinAmountByPK(long slotID, long bonusWinAmount, TransactionManager tm_ = null)
        {
            RepairPutBonusWinAmountByPKData(slotID, bonusWinAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBonusWinAmountByPKAsync(long slotID, long bonusWinAmount, TransactionManager tm_ = null)
        {
            RepairPutBonusWinAmountByPKData(slotID, bonusWinAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBonusWinAmountByPKData(long slotID, long bonusWinAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BonusWinAmount` = @BonusWinAmount  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BonusWinAmount", bonusWinAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bonusWinAmount">Bonus奖金</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusWinAmount(long bonusWinAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusWinAmount` = @BonusWinAmount";
            var parameter_ = Database.CreateInParameter("@BonusWinAmount", bonusWinAmount, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBonusWinAmountAsync(long bonusWinAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusWinAmount` = @BonusWinAmount";
            var parameter_ = Database.CreateInParameter("@BonusWinAmount", bonusWinAmount, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBonusWinAmount
        #region PutBaseIsWin
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "baseIsWin">base是否奖励</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBaseIsWinByPK(long slotID, bool baseIsWin, TransactionManager tm_ = null)
        {
            RepairPutBaseIsWinByPKData(slotID, baseIsWin, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBaseIsWinByPKAsync(long slotID, bool baseIsWin, TransactionManager tm_ = null)
        {
            RepairPutBaseIsWinByPKData(slotID, baseIsWin, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBaseIsWinByPKData(long slotID, bool baseIsWin, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BaseIsWin` = @BaseIsWin  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BaseIsWin", baseIsWin, MySqlDbType.Byte),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "baseIsWin">base是否奖励</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBaseIsWin(bool baseIsWin, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BaseIsWin` = @BaseIsWin";
            var parameter_ = Database.CreateInParameter("@BaseIsWin", baseIsWin, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBaseIsWinAsync(bool baseIsWin, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BaseIsWin` = @BaseIsWin";
            var parameter_ = Database.CreateInParameter("@BaseIsWin", baseIsWin, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBaseIsWin
        #region PutBaseMultip
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "baseMultip">base倍率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBaseMultipByPK(long slotID, int baseMultip, TransactionManager tm_ = null)
        {
            RepairPutBaseMultipByPKData(slotID, baseMultip, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBaseMultipByPKAsync(long slotID, int baseMultip, TransactionManager tm_ = null)
        {
            RepairPutBaseMultipByPKData(slotID, baseMultip, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBaseMultipByPKData(long slotID, int baseMultip, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BaseMultip` = @BaseMultip  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BaseMultip", baseMultip, MySqlDbType.Int32),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "baseMultip">base倍率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBaseMultip(int baseMultip, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BaseMultip` = @BaseMultip";
            var parameter_ = Database.CreateInParameter("@BaseMultip", baseMultip, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBaseMultipAsync(int baseMultip, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BaseMultip` = @BaseMultip";
            var parameter_ = Database.CreateInParameter("@BaseMultip", baseMultip, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBaseMultip
        #region PutBaseWinAmount
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "baseWinAmount">base奖金</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBaseWinAmountByPK(long slotID, long baseWinAmount, TransactionManager tm_ = null)
        {
            RepairPutBaseWinAmountByPKData(slotID, baseWinAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBaseWinAmountByPKAsync(long slotID, long baseWinAmount, TransactionManager tm_ = null)
        {
            RepairPutBaseWinAmountByPKData(slotID, baseWinAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBaseWinAmountByPKData(long slotID, long baseWinAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BaseWinAmount` = @BaseWinAmount  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BaseWinAmount", baseWinAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "baseWinAmount">base奖金</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBaseWinAmount(long baseWinAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BaseWinAmount` = @BaseWinAmount";
            var parameter_ = Database.CreateInParameter("@BaseWinAmount", baseWinAmount, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBaseWinAmountAsync(long baseWinAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BaseWinAmount` = @BaseWinAmount";
            var parameter_ = Database.CreateInParameter("@BaseWinAmount", baseWinAmount, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBaseWinAmount
        #region PutTotalAmount
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "totalAmount">总盈利</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutTotalAmountByPK(long slotID, long totalAmount, TransactionManager tm_ = null)
        {
            RepairPutTotalAmountByPKData(slotID, totalAmount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutTotalAmountByPKAsync(long slotID, long totalAmount, TransactionManager tm_ = null)
        {
            RepairPutTotalAmountByPKData(slotID, totalAmount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutTotalAmountByPKData(long slotID, long totalAmount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `TotalAmount` = @TotalAmount  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@TotalAmount", totalAmount, MySqlDbType.Int64),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "totalAmount">总盈利</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutTotalAmount(long totalAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `TotalAmount` = @TotalAmount";
            var parameter_ = Database.CreateInParameter("@TotalAmount", totalAmount, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutTotalAmountAsync(long totalAmount, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `TotalAmount` = @TotalAmount";
            var parameter_ = Database.CreateInParameter("@TotalAmount", totalAmount, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutTotalAmount
        #region PutSlotItemID
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "slotItemID">抽取的组合ID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSlotItemIDByPK(long slotID, long slotItemID, TransactionManager tm_ = null)
        {
            RepairPutSlotItemIDByPKData(slotID, slotItemID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutSlotItemIDByPKAsync(long slotID, long slotItemID, TransactionManager tm_ = null)
        {
            RepairPutSlotItemIDByPKData(slotID, slotItemID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutSlotItemIDByPKData(long slotID, long slotItemID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `SlotItemID` = @SlotItemID  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotItemID", slotItemID, MySqlDbType.Int64),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "slotItemID">抽取的组合ID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSlotItemID(long slotItemID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SlotItemID` = @SlotItemID";
            var parameter_ = Database.CreateInParameter("@SlotItemID", slotItemID, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutSlotItemIDAsync(long slotItemID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SlotItemID` = @SlotItemID";
            var parameter_ = Database.CreateInParameter("@SlotItemID", slotItemID, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutSlotItemID
        #region PutStatus
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutStatusByPK(long slotID, int status, TransactionManager tm_ = null)
        {
            RepairPutStatusByPKData(slotID, status, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutStatusByPKAsync(long slotID, int status, TransactionManager tm_ = null)
        {
            RepairPutStatusByPKData(slotID, status, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutStatusByPKData(long slotID, int status, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutStatus(int status, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
            var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutStatusAsync(int status, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
            var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutStatus
        #region PutRecDate
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRecDateByPK(long slotID, DateTime recDate, TransactionManager tm_ = null)
        {
            RepairPutRecDateByPKData(slotID, recDate, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRecDateByPKAsync(long slotID, DateTime recDate, TransactionManager tm_ = null)
        {
            RepairPutRecDateByPKData(slotID, recDate, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRecDateByPKData(long slotID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `SlotID` = @SlotID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
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
        public bool Set(Gmf_user_slotEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.SlotID) == null)
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
        public async Task<bool> SetAsync(Gmf_user_slotEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.SlotID) == null)
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
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public Gmf_user_slotEO GetByPK(long slotID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(slotID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<Gmf_user_slotEO> GetByPKAsync(long slotID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(slotID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        private void RepairGetByPKData(long slotID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`SlotID` = @SlotID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 UserID（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetUserIDByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (string)GetScalar("`UserID`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<string> GetUserIDByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (string)await GetScalarAsync("`UserID`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 ChipsID（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetChipsIDByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)GetScalar("`ChipsID`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<int> GetChipsIDByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)await GetScalarAsync("`ChipsID`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 OperatorID（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetOperatorIDByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (string)GetScalar("`OperatorID`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<string> GetOperatorIDByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (string)await GetScalarAsync("`OperatorID`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 CurrencyID（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetCurrencyIDByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (string)GetScalar("`CurrencyID`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<string> GetCurrencyIDByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (string)await GetScalarAsync("`CurrencyID`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 IsFreeSpin（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public bool GetIsFreeSpinByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (bool)GetScalar("`IsFreeSpin`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<bool> GetIsFreeSpinByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (bool)await GetScalarAsync("`IsFreeSpin`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 PartBase（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetPartBaseByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)GetScalar("`PartBase`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<long> GetPartBaseByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)await GetScalarAsync("`PartBase`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 PartBonus（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetPartBonusByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)GetScalar("`PartBonus`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<long> GetPartBonusByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)await GetScalarAsync("`PartBonus`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 PartBingo（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetPartBingoByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)GetScalar("`PartBingo`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<long> GetPartBingoByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)await GetScalarAsync("`PartBingo`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 PartIncome（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetPartIncomeByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)GetScalar("`PartIncome`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<long> GetPartIncomeByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)await GetScalarAsync("`PartIncome`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoIsOutTH（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public bool GetBingoIsOutTHByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (bool)GetScalar("`BingoIsOutTH`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<bool> GetBingoIsOutTHByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (bool)await GetScalarAsync("`BingoIsOutTH`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoIsWin（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public bool GetBingoIsWinByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (bool)GetScalar("`BingoIsWin`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<bool> GetBingoIsWinByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (bool)await GetScalarAsync("`BingoIsWin`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoJPPoolType（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetBingoJPPoolTypeByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)GetScalar("`BingoJPPoolType`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<int> GetBingoJPPoolTypeByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)await GetScalarAsync("`BingoJPPoolType`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoMultip（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetBingoMultipByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)GetScalar("`BingoMultip`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<int> GetBingoMultipByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)await GetScalarAsync("`BingoMultip`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoTotal（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetBingoTotalByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)GetScalar("`BingoTotal`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<long> GetBingoTotalByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)await GetScalarAsync("`BingoTotal`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoPanelNums（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetBingoPanelNumsByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (string)GetScalar("`BingoPanelNums`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<string> GetBingoPanelNumsByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (string)await GetScalarAsync("`BingoPanelNums`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoHitLine（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetBingoHitLineByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)GetScalar("`BingoHitLine`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<int> GetBingoHitLineByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)await GetScalarAsync("`BingoHitLine`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoKeepNum（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetBingoKeepNumByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)GetScalar("`BingoKeepNum`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<int> GetBingoKeepNumByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)await GetScalarAsync("`BingoKeepNum`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoKeepNums（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetBingoKeepNumsByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (string)GetScalar("`BingoKeepNums`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<string> GetBingoKeepNumsByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (string)await GetScalarAsync("`BingoKeepNums`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoNewNums（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetBingoNewNumsByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (string)GetScalar("`BingoNewNums`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<string> GetBingoNewNumsByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (string)await GetScalarAsync("`BingoNewNums`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoHasNums（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetBingoHasNumsByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (string)GetScalar("`BingoHasNums`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<string> GetBingoHasNumsByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (string)await GetScalarAsync("`BingoHasNums`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoWinAmount（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetBingoWinAmountByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)GetScalar("`BingoWinAmount`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<long> GetBingoWinAmountByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)await GetScalarAsync("`BingoWinAmount`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BonusIsOutTH（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public bool GetBonusIsOutTHByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (bool)GetScalar("`BonusIsOutTH`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<bool> GetBonusIsOutTHByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (bool)await GetScalarAsync("`BonusIsOutTH`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BonusIsWin（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public bool GetBonusIsWinByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (bool)GetScalar("`BonusIsWin`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<bool> GetBonusIsWinByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (bool)await GetScalarAsync("`BonusIsWin`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BonusMultip（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetBonusMultipByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)GetScalar("`BonusMultip`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<int> GetBonusMultipByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)await GetScalarAsync("`BonusMultip`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BonusTotal（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetBonusTotalByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)GetScalar("`BonusTotal`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<long> GetBonusTotalByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)await GetScalarAsync("`BonusTotal`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BonusSymbolNum（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetBonusSymbolNumByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)GetScalar("`BonusSymbolNum`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<int> GetBonusSymbolNumByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)await GetScalarAsync("`BonusSymbolNum`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BonusNewRetriggerNum（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetBonusNewRetriggerNumByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)GetScalar("`BonusNewRetriggerNum`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<int> GetBonusNewRetriggerNumByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)await GetScalarAsync("`BonusNewRetriggerNum`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 FreeSpinNum（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetFreeSpinNumByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)GetScalar("`FreeSpinNum`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<int> GetFreeSpinNumByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)await GetScalarAsync("`FreeSpinNum`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 RetriggerNum（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetRetriggerNumByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)GetScalar("`RetriggerNum`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<int> GetRetriggerNumByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)await GetScalarAsync("`RetriggerNum`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 RetriggerList（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetRetriggerListByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (string)GetScalar("`RetriggerList`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<string> GetRetriggerListByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (string)await GetScalarAsync("`RetriggerList`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BonusWinAmount（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetBonusWinAmountByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)GetScalar("`BonusWinAmount`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<long> GetBonusWinAmountByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)await GetScalarAsync("`BonusWinAmount`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BaseIsWin（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public bool GetBaseIsWinByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (bool)GetScalar("`BaseIsWin`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<bool> GetBaseIsWinByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (bool)await GetScalarAsync("`BaseIsWin`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BaseMultip（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetBaseMultipByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)GetScalar("`BaseMultip`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<int> GetBaseMultipByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)await GetScalarAsync("`BaseMultip`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BaseWinAmount（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetBaseWinAmountByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)GetScalar("`BaseWinAmount`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<long> GetBaseWinAmountByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)await GetScalarAsync("`BaseWinAmount`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 TotalAmount（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetTotalAmountByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)GetScalar("`TotalAmount`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<long> GetTotalAmountByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)await GetScalarAsync("`TotalAmount`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 SlotItemID（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetSlotItemIDByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)GetScalar("`SlotItemID`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<long> GetSlotItemIDByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (long)await GetScalarAsync("`SlotItemID`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Status（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetStatusByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)GetScalar("`Status`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<int> GetStatusByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (int)await GetScalarAsync("`Status`", "`SlotID` = @SlotID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 RecDate（字段）
        /// </summary>
        /// /// <param name = "slotID">编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public DateTime GetRecDateByPK(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (DateTime)GetScalar("`RecDate`", "`SlotID` = @SlotID", paras_, tm_);
        }
        public async Task<DateTime> GetRecDateByPKAsync(long slotID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SlotID", slotID, MySqlDbType.Int64),
            };
            return (DateTime)await GetScalarAsync("`RecDate`", "`SlotID` = @SlotID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByUserID

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByUserID(string userID)
        {
            return GetByUserID(userID, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByUserIDAsync(string userID)
        {
            return await GetByUserIDAsync(userID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByUserID(string userID, TransactionManager tm_)
        {
            return GetByUserID(userID, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
        {
            return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByUserID(string userID, int top_)
        {
            return GetByUserID(userID, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByUserIDAsync(string userID, int top_)
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
        public List<Gmf_user_slotEO> GetByUserID(string userID, int top_, TransactionManager tm_)
        {
            return GetByUserID(userID, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
        {
            return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户编码(GUID)</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByUserID(string userID, string sort_)
        {
            return GetByUserID(userID, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByUserIDAsync(string userID, string sort_)
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
        public List<Gmf_user_slotEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
        {
            return GetByUserID(userID, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
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
        public List<Gmf_user_slotEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (userID != null)
                paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (userID != null)
                paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByUserID
        #region GetByChipsID

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByChipsID(int chipsID)
        {
            return GetByChipsID(chipsID, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByChipsIDAsync(int chipsID)
        {
            return await GetByChipsIDAsync(chipsID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByChipsID(int chipsID, TransactionManager tm_)
        {
            return GetByChipsID(chipsID, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByChipsIDAsync(int chipsID, TransactionManager tm_)
        {
            return await GetByChipsIDAsync(chipsID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByChipsID(int chipsID, int top_)
        {
            return GetByChipsID(chipsID, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByChipsIDAsync(int chipsID, int top_)
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
        public List<Gmf_user_slotEO> GetByChipsID(int chipsID, int top_, TransactionManager tm_)
        {
            return GetByChipsID(chipsID, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByChipsIDAsync(int chipsID, int top_, TransactionManager tm_)
        {
            return await GetByChipsIDAsync(chipsID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">筹码编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByChipsID(int chipsID, string sort_)
        {
            return GetByChipsID(chipsID, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByChipsIDAsync(int chipsID, string sort_)
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
        public List<Gmf_user_slotEO> GetByChipsID(int chipsID, string sort_, TransactionManager tm_)
        {
            return GetByChipsID(chipsID, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByChipsIDAsync(int chipsID, string sort_, TransactionManager tm_)
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
        public List<Gmf_user_slotEO> GetByChipsID(int chipsID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByChipsIDAsync(int chipsID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByChipsID
        #region GetByOperatorID

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByOperatorID(string operatorID)
        {
            return GetByOperatorID(operatorID, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByOperatorIDAsync(string operatorID)
        {
            return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByOperatorID(string operatorID, TransactionManager tm_)
        {
            return GetByOperatorID(operatorID, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
        {
            return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByOperatorID(string operatorID, int top_)
        {
            return GetByOperatorID(operatorID, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
        public List<Gmf_user_slotEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
        {
            return GetByOperatorID(operatorID, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
        {
            return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 OperatorID（字段） 查询
        /// </summary>
        /// /// <param name = "operatorID">运营商编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByOperatorID(string operatorID, string sort_)
        {
            return GetByOperatorID(operatorID, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
        public List<Gmf_user_slotEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
        {
            return GetByOperatorID(operatorID, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
        public List<Gmf_user_slotEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByOperatorID
        #region GetByCurrencyID

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByCurrencyID(string currencyID)
        {
            return GetByCurrencyID(currencyID, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByCurrencyIDAsync(string currencyID)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByCurrencyID(string currencyID, int top_)
        {
            return GetByCurrencyID(currencyID, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
        public List<Gmf_user_slotEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
        {
            return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByCurrencyID(string currencyID, string sort_)
        {
            return GetByCurrencyID(currencyID, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
        public List<Gmf_user_slotEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
        public List<Gmf_user_slotEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByCurrencyID
        #region GetByIsFreeSpin

        /// <summary>
        /// 按 IsFreeSpin（字段） 查询
        /// </summary>
        /// /// <param name = "isFreeSpin">是否FreeSpin</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByIsFreeSpin(bool isFreeSpin)
        {
            return GetByIsFreeSpin(isFreeSpin, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByIsFreeSpinAsync(bool isFreeSpin)
        {
            return await GetByIsFreeSpinAsync(isFreeSpin, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 IsFreeSpin（字段） 查询
        /// </summary>
        /// /// <param name = "isFreeSpin">是否FreeSpin</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByIsFreeSpin(bool isFreeSpin, TransactionManager tm_)
        {
            return GetByIsFreeSpin(isFreeSpin, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByIsFreeSpinAsync(bool isFreeSpin, TransactionManager tm_)
        {
            return await GetByIsFreeSpinAsync(isFreeSpin, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 IsFreeSpin（字段） 查询
        /// </summary>
        /// /// <param name = "isFreeSpin">是否FreeSpin</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByIsFreeSpin(bool isFreeSpin, int top_)
        {
            return GetByIsFreeSpin(isFreeSpin, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByIsFreeSpinAsync(bool isFreeSpin, int top_)
        {
            return await GetByIsFreeSpinAsync(isFreeSpin, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 IsFreeSpin（字段） 查询
        /// </summary>
        /// /// <param name = "isFreeSpin">是否FreeSpin</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByIsFreeSpin(bool isFreeSpin, int top_, TransactionManager tm_)
        {
            return GetByIsFreeSpin(isFreeSpin, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByIsFreeSpinAsync(bool isFreeSpin, int top_, TransactionManager tm_)
        {
            return await GetByIsFreeSpinAsync(isFreeSpin, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 IsFreeSpin（字段） 查询
        /// </summary>
        /// /// <param name = "isFreeSpin">是否FreeSpin</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByIsFreeSpin(bool isFreeSpin, string sort_)
        {
            return GetByIsFreeSpin(isFreeSpin, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByIsFreeSpinAsync(bool isFreeSpin, string sort_)
        {
            return await GetByIsFreeSpinAsync(isFreeSpin, 0, sort_, null);
        }

        /// <summary>
        /// 按 IsFreeSpin（字段） 查询
        /// </summary>
        /// /// <param name = "isFreeSpin">是否FreeSpin</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByIsFreeSpin(bool isFreeSpin, string sort_, TransactionManager tm_)
        {
            return GetByIsFreeSpin(isFreeSpin, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByIsFreeSpinAsync(bool isFreeSpin, string sort_, TransactionManager tm_)
        {
            return await GetByIsFreeSpinAsync(isFreeSpin, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 IsFreeSpin（字段） 查询
        /// </summary>
        /// /// <param name = "isFreeSpin">是否FreeSpin</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByIsFreeSpin(bool isFreeSpin, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`IsFreeSpin` = @IsFreeSpin", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IsFreeSpin", isFreeSpin, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByIsFreeSpinAsync(bool isFreeSpin, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`IsFreeSpin` = @IsFreeSpin", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IsFreeSpin", isFreeSpin, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByIsFreeSpin
        #region GetByPartBase

        /// <summary>
        /// 按 PartBase（字段） 查询
        /// </summary>
        /// /// <param name = "partBase">BaseGame分配金额</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBase(long partBase)
        {
            return GetByPartBase(partBase, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBaseAsync(long partBase)
        {
            return await GetByPartBaseAsync(partBase, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PartBase（字段） 查询
        /// </summary>
        /// /// <param name = "partBase">BaseGame分配金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBase(long partBase, TransactionManager tm_)
        {
            return GetByPartBase(partBase, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBaseAsync(long partBase, TransactionManager tm_)
        {
            return await GetByPartBaseAsync(partBase, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 PartBase（字段） 查询
        /// </summary>
        /// /// <param name = "partBase">BaseGame分配金额</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBase(long partBase, int top_)
        {
            return GetByPartBase(partBase, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBaseAsync(long partBase, int top_)
        {
            return await GetByPartBaseAsync(partBase, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 PartBase（字段） 查询
        /// </summary>
        /// /// <param name = "partBase">BaseGame分配金额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBase(long partBase, int top_, TransactionManager tm_)
        {
            return GetByPartBase(partBase, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBaseAsync(long partBase, int top_, TransactionManager tm_)
        {
            return await GetByPartBaseAsync(partBase, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 PartBase（字段） 查询
        /// </summary>
        /// /// <param name = "partBase">BaseGame分配金额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBase(long partBase, string sort_)
        {
            return GetByPartBase(partBase, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBaseAsync(long partBase, string sort_)
        {
            return await GetByPartBaseAsync(partBase, 0, sort_, null);
        }

        /// <summary>
        /// 按 PartBase（字段） 查询
        /// </summary>
        /// /// <param name = "partBase">BaseGame分配金额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBase(long partBase, string sort_, TransactionManager tm_)
        {
            return GetByPartBase(partBase, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBaseAsync(long partBase, string sort_, TransactionManager tm_)
        {
            return await GetByPartBaseAsync(partBase, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 PartBase（字段） 查询
        /// </summary>
        /// /// <param name = "partBase">BaseGame分配金额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBase(long partBase, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`PartBase` = @PartBase", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBase", partBase, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBaseAsync(long partBase, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`PartBase` = @PartBase", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBase", partBase, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByPartBase
        #region GetByPartBonus

        /// <summary>
        /// 按 PartBonus（字段） 查询
        /// </summary>
        /// /// <param name = "partBonus">Bonus分配金额</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBonus(long partBonus)
        {
            return GetByPartBonus(partBonus, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBonusAsync(long partBonus)
        {
            return await GetByPartBonusAsync(partBonus, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PartBonus（字段） 查询
        /// </summary>
        /// /// <param name = "partBonus">Bonus分配金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBonus(long partBonus, TransactionManager tm_)
        {
            return GetByPartBonus(partBonus, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBonusAsync(long partBonus, TransactionManager tm_)
        {
            return await GetByPartBonusAsync(partBonus, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 PartBonus（字段） 查询
        /// </summary>
        /// /// <param name = "partBonus">Bonus分配金额</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBonus(long partBonus, int top_)
        {
            return GetByPartBonus(partBonus, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBonusAsync(long partBonus, int top_)
        {
            return await GetByPartBonusAsync(partBonus, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 PartBonus（字段） 查询
        /// </summary>
        /// /// <param name = "partBonus">Bonus分配金额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBonus(long partBonus, int top_, TransactionManager tm_)
        {
            return GetByPartBonus(partBonus, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBonusAsync(long partBonus, int top_, TransactionManager tm_)
        {
            return await GetByPartBonusAsync(partBonus, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 PartBonus（字段） 查询
        /// </summary>
        /// /// <param name = "partBonus">Bonus分配金额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBonus(long partBonus, string sort_)
        {
            return GetByPartBonus(partBonus, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBonusAsync(long partBonus, string sort_)
        {
            return await GetByPartBonusAsync(partBonus, 0, sort_, null);
        }

        /// <summary>
        /// 按 PartBonus（字段） 查询
        /// </summary>
        /// /// <param name = "partBonus">Bonus分配金额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBonus(long partBonus, string sort_, TransactionManager tm_)
        {
            return GetByPartBonus(partBonus, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBonusAsync(long partBonus, string sort_, TransactionManager tm_)
        {
            return await GetByPartBonusAsync(partBonus, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 PartBonus（字段） 查询
        /// </summary>
        /// /// <param name = "partBonus">Bonus分配金额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBonus(long partBonus, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`PartBonus` = @PartBonus", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBonus", partBonus, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBonusAsync(long partBonus, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`PartBonus` = @PartBonus", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBonus", partBonus, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByPartBonus
        #region GetByPartBingo

        /// <summary>
        /// 按 PartBingo（字段） 查询
        /// </summary>
        /// /// <param name = "partBingo">Bingo分配金额</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBingo(long partBingo)
        {
            return GetByPartBingo(partBingo, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBingoAsync(long partBingo)
        {
            return await GetByPartBingoAsync(partBingo, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PartBingo（字段） 查询
        /// </summary>
        /// /// <param name = "partBingo">Bingo分配金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBingo(long partBingo, TransactionManager tm_)
        {
            return GetByPartBingo(partBingo, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBingoAsync(long partBingo, TransactionManager tm_)
        {
            return await GetByPartBingoAsync(partBingo, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 PartBingo（字段） 查询
        /// </summary>
        /// /// <param name = "partBingo">Bingo分配金额</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBingo(long partBingo, int top_)
        {
            return GetByPartBingo(partBingo, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBingoAsync(long partBingo, int top_)
        {
            return await GetByPartBingoAsync(partBingo, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 PartBingo（字段） 查询
        /// </summary>
        /// /// <param name = "partBingo">Bingo分配金额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBingo(long partBingo, int top_, TransactionManager tm_)
        {
            return GetByPartBingo(partBingo, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBingoAsync(long partBingo, int top_, TransactionManager tm_)
        {
            return await GetByPartBingoAsync(partBingo, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 PartBingo（字段） 查询
        /// </summary>
        /// /// <param name = "partBingo">Bingo分配金额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBingo(long partBingo, string sort_)
        {
            return GetByPartBingo(partBingo, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBingoAsync(long partBingo, string sort_)
        {
            return await GetByPartBingoAsync(partBingo, 0, sort_, null);
        }

        /// <summary>
        /// 按 PartBingo（字段） 查询
        /// </summary>
        /// /// <param name = "partBingo">Bingo分配金额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBingo(long partBingo, string sort_, TransactionManager tm_)
        {
            return GetByPartBingo(partBingo, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBingoAsync(long partBingo, string sort_, TransactionManager tm_)
        {
            return await GetByPartBingoAsync(partBingo, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 PartBingo（字段） 查询
        /// </summary>
        /// /// <param name = "partBingo">Bingo分配金额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartBingo(long partBingo, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`PartBingo` = @PartBingo", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBingo", partBingo, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartBingoAsync(long partBingo, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`PartBingo` = @PartBingo", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBingo", partBingo, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByPartBingo
        #region GetByPartIncome

        /// <summary>
        /// 按 PartIncome（字段） 查询
        /// </summary>
        /// /// <param name = "partIncome">收入分配金额</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartIncome(long partIncome)
        {
            return GetByPartIncome(partIncome, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartIncomeAsync(long partIncome)
        {
            return await GetByPartIncomeAsync(partIncome, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PartIncome（字段） 查询
        /// </summary>
        /// /// <param name = "partIncome">收入分配金额</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartIncome(long partIncome, TransactionManager tm_)
        {
            return GetByPartIncome(partIncome, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartIncomeAsync(long partIncome, TransactionManager tm_)
        {
            return await GetByPartIncomeAsync(partIncome, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 PartIncome（字段） 查询
        /// </summary>
        /// /// <param name = "partIncome">收入分配金额</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartIncome(long partIncome, int top_)
        {
            return GetByPartIncome(partIncome, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartIncomeAsync(long partIncome, int top_)
        {
            return await GetByPartIncomeAsync(partIncome, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 PartIncome（字段） 查询
        /// </summary>
        /// /// <param name = "partIncome">收入分配金额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartIncome(long partIncome, int top_, TransactionManager tm_)
        {
            return GetByPartIncome(partIncome, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartIncomeAsync(long partIncome, int top_, TransactionManager tm_)
        {
            return await GetByPartIncomeAsync(partIncome, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 PartIncome（字段） 查询
        /// </summary>
        /// /// <param name = "partIncome">收入分配金额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartIncome(long partIncome, string sort_)
        {
            return GetByPartIncome(partIncome, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartIncomeAsync(long partIncome, string sort_)
        {
            return await GetByPartIncomeAsync(partIncome, 0, sort_, null);
        }

        /// <summary>
        /// 按 PartIncome（字段） 查询
        /// </summary>
        /// /// <param name = "partIncome">收入分配金额</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartIncome(long partIncome, string sort_, TransactionManager tm_)
        {
            return GetByPartIncome(partIncome, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartIncomeAsync(long partIncome, string sort_, TransactionManager tm_)
        {
            return await GetByPartIncomeAsync(partIncome, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 PartIncome（字段） 查询
        /// </summary>
        /// /// <param name = "partIncome">收入分配金额</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByPartIncome(long partIncome, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`PartIncome` = @PartIncome", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartIncome", partIncome, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByPartIncomeAsync(long partIncome, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`PartIncome` = @PartIncome", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartIncome", partIncome, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByPartIncome
        #region GetByBingoIsOutTH

        /// <summary>
        /// 按 BingoIsOutTH（字段） 查询
        /// </summary>
        /// /// <param name = "bingoIsOutTH">bingo是否超过阈值</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoIsOutTH(bool bingoIsOutTH)
        {
            return GetByBingoIsOutTH(bingoIsOutTH, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoIsOutTHAsync(bool bingoIsOutTH)
        {
            return await GetByBingoIsOutTHAsync(bingoIsOutTH, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoIsOutTH（字段） 查询
        /// </summary>
        /// /// <param name = "bingoIsOutTH">bingo是否超过阈值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoIsOutTH(bool bingoIsOutTH, TransactionManager tm_)
        {
            return GetByBingoIsOutTH(bingoIsOutTH, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoIsOutTHAsync(bool bingoIsOutTH, TransactionManager tm_)
        {
            return await GetByBingoIsOutTHAsync(bingoIsOutTH, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoIsOutTH（字段） 查询
        /// </summary>
        /// /// <param name = "bingoIsOutTH">bingo是否超过阈值</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoIsOutTH(bool bingoIsOutTH, int top_)
        {
            return GetByBingoIsOutTH(bingoIsOutTH, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoIsOutTHAsync(bool bingoIsOutTH, int top_)
        {
            return await GetByBingoIsOutTHAsync(bingoIsOutTH, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoIsOutTH（字段） 查询
        /// </summary>
        /// /// <param name = "bingoIsOutTH">bingo是否超过阈值</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoIsOutTH(bool bingoIsOutTH, int top_, TransactionManager tm_)
        {
            return GetByBingoIsOutTH(bingoIsOutTH, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoIsOutTHAsync(bool bingoIsOutTH, int top_, TransactionManager tm_)
        {
            return await GetByBingoIsOutTHAsync(bingoIsOutTH, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoIsOutTH（字段） 查询
        /// </summary>
        /// /// <param name = "bingoIsOutTH">bingo是否超过阈值</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoIsOutTH(bool bingoIsOutTH, string sort_)
        {
            return GetByBingoIsOutTH(bingoIsOutTH, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoIsOutTHAsync(bool bingoIsOutTH, string sort_)
        {
            return await GetByBingoIsOutTHAsync(bingoIsOutTH, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoIsOutTH（字段） 查询
        /// </summary>
        /// /// <param name = "bingoIsOutTH">bingo是否超过阈值</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoIsOutTH(bool bingoIsOutTH, string sort_, TransactionManager tm_)
        {
            return GetByBingoIsOutTH(bingoIsOutTH, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoIsOutTHAsync(bool bingoIsOutTH, string sort_, TransactionManager tm_)
        {
            return await GetByBingoIsOutTHAsync(bingoIsOutTH, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoIsOutTH（字段） 查询
        /// </summary>
        /// /// <param name = "bingoIsOutTH">bingo是否超过阈值</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoIsOutTH(bool bingoIsOutTH, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoIsOutTH` = @BingoIsOutTH", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoIsOutTH", bingoIsOutTH, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoIsOutTHAsync(bool bingoIsOutTH, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoIsOutTH` = @BingoIsOutTH", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoIsOutTH", bingoIsOutTH, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBingoIsOutTH
        #region GetByBingoIsWin

        /// <summary>
        /// 按 BingoIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "bingoIsWin">bingo是否奖励</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoIsWin(bool bingoIsWin)
        {
            return GetByBingoIsWin(bingoIsWin, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoIsWinAsync(bool bingoIsWin)
        {
            return await GetByBingoIsWinAsync(bingoIsWin, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "bingoIsWin">bingo是否奖励</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoIsWin(bool bingoIsWin, TransactionManager tm_)
        {
            return GetByBingoIsWin(bingoIsWin, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoIsWinAsync(bool bingoIsWin, TransactionManager tm_)
        {
            return await GetByBingoIsWinAsync(bingoIsWin, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "bingoIsWin">bingo是否奖励</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoIsWin(bool bingoIsWin, int top_)
        {
            return GetByBingoIsWin(bingoIsWin, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoIsWinAsync(bool bingoIsWin, int top_)
        {
            return await GetByBingoIsWinAsync(bingoIsWin, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "bingoIsWin">bingo是否奖励</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoIsWin(bool bingoIsWin, int top_, TransactionManager tm_)
        {
            return GetByBingoIsWin(bingoIsWin, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoIsWinAsync(bool bingoIsWin, int top_, TransactionManager tm_)
        {
            return await GetByBingoIsWinAsync(bingoIsWin, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "bingoIsWin">bingo是否奖励</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoIsWin(bool bingoIsWin, string sort_)
        {
            return GetByBingoIsWin(bingoIsWin, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoIsWinAsync(bool bingoIsWin, string sort_)
        {
            return await GetByBingoIsWinAsync(bingoIsWin, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "bingoIsWin">bingo是否奖励</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoIsWin(bool bingoIsWin, string sort_, TransactionManager tm_)
        {
            return GetByBingoIsWin(bingoIsWin, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoIsWinAsync(bool bingoIsWin, string sort_, TransactionManager tm_)
        {
            return await GetByBingoIsWinAsync(bingoIsWin, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "bingoIsWin">bingo是否奖励</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoIsWin(bool bingoIsWin, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoIsWin` = @BingoIsWin", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoIsWin", bingoIsWin, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoIsWinAsync(bool bingoIsWin, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoIsWin` = @BingoIsWin", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoIsWin", bingoIsWin, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBingoIsWin
        #region GetByBingoJPPoolType

        /// <summary>
        /// 按 BingoJPPoolType（字段） 查询
        /// </summary>
        /// /// <param name = "bingoJPPoolType">bingoJP奖池类型</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoJPPoolType(int bingoJPPoolType)
        {
            return GetByBingoJPPoolType(bingoJPPoolType, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoJPPoolTypeAsync(int bingoJPPoolType)
        {
            return await GetByBingoJPPoolTypeAsync(bingoJPPoolType, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoJPPoolType（字段） 查询
        /// </summary>
        /// /// <param name = "bingoJPPoolType">bingoJP奖池类型</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoJPPoolType(int bingoJPPoolType, TransactionManager tm_)
        {
            return GetByBingoJPPoolType(bingoJPPoolType, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoJPPoolTypeAsync(int bingoJPPoolType, TransactionManager tm_)
        {
            return await GetByBingoJPPoolTypeAsync(bingoJPPoolType, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoJPPoolType（字段） 查询
        /// </summary>
        /// /// <param name = "bingoJPPoolType">bingoJP奖池类型</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoJPPoolType(int bingoJPPoolType, int top_)
        {
            return GetByBingoJPPoolType(bingoJPPoolType, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoJPPoolTypeAsync(int bingoJPPoolType, int top_)
        {
            return await GetByBingoJPPoolTypeAsync(bingoJPPoolType, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoJPPoolType（字段） 查询
        /// </summary>
        /// /// <param name = "bingoJPPoolType">bingoJP奖池类型</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoJPPoolType(int bingoJPPoolType, int top_, TransactionManager tm_)
        {
            return GetByBingoJPPoolType(bingoJPPoolType, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoJPPoolTypeAsync(int bingoJPPoolType, int top_, TransactionManager tm_)
        {
            return await GetByBingoJPPoolTypeAsync(bingoJPPoolType, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoJPPoolType（字段） 查询
        /// </summary>
        /// /// <param name = "bingoJPPoolType">bingoJP奖池类型</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoJPPoolType(int bingoJPPoolType, string sort_)
        {
            return GetByBingoJPPoolType(bingoJPPoolType, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoJPPoolTypeAsync(int bingoJPPoolType, string sort_)
        {
            return await GetByBingoJPPoolTypeAsync(bingoJPPoolType, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoJPPoolType（字段） 查询
        /// </summary>
        /// /// <param name = "bingoJPPoolType">bingoJP奖池类型</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoJPPoolType(int bingoJPPoolType, string sort_, TransactionManager tm_)
        {
            return GetByBingoJPPoolType(bingoJPPoolType, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoJPPoolTypeAsync(int bingoJPPoolType, string sort_, TransactionManager tm_)
        {
            return await GetByBingoJPPoolTypeAsync(bingoJPPoolType, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoJPPoolType（字段） 查询
        /// </summary>
        /// /// <param name = "bingoJPPoolType">bingoJP奖池类型</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoJPPoolType(int bingoJPPoolType, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoJPPoolType` = @BingoJPPoolType", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoJPPoolType", bingoJPPoolType, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoJPPoolTypeAsync(int bingoJPPoolType, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoJPPoolType` = @BingoJPPoolType", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoJPPoolType", bingoJPPoolType, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBingoJPPoolType
        #region GetByBingoMultip

        /// <summary>
        /// 按 BingoMultip（字段） 查询
        /// </summary>
        /// /// <param name = "bingoMultip">bingo倍率</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoMultip(int bingoMultip)
        {
            return GetByBingoMultip(bingoMultip, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoMultipAsync(int bingoMultip)
        {
            return await GetByBingoMultipAsync(bingoMultip, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoMultip（字段） 查询
        /// </summary>
        /// /// <param name = "bingoMultip">bingo倍率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoMultip(int bingoMultip, TransactionManager tm_)
        {
            return GetByBingoMultip(bingoMultip, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoMultipAsync(int bingoMultip, TransactionManager tm_)
        {
            return await GetByBingoMultipAsync(bingoMultip, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoMultip（字段） 查询
        /// </summary>
        /// /// <param name = "bingoMultip">bingo倍率</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoMultip(int bingoMultip, int top_)
        {
            return GetByBingoMultip(bingoMultip, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoMultipAsync(int bingoMultip, int top_)
        {
            return await GetByBingoMultipAsync(bingoMultip, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoMultip（字段） 查询
        /// </summary>
        /// /// <param name = "bingoMultip">bingo倍率</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoMultip(int bingoMultip, int top_, TransactionManager tm_)
        {
            return GetByBingoMultip(bingoMultip, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoMultipAsync(int bingoMultip, int top_, TransactionManager tm_)
        {
            return await GetByBingoMultipAsync(bingoMultip, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoMultip（字段） 查询
        /// </summary>
        /// /// <param name = "bingoMultip">bingo倍率</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoMultip(int bingoMultip, string sort_)
        {
            return GetByBingoMultip(bingoMultip, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoMultipAsync(int bingoMultip, string sort_)
        {
            return await GetByBingoMultipAsync(bingoMultip, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoMultip（字段） 查询
        /// </summary>
        /// /// <param name = "bingoMultip">bingo倍率</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoMultip(int bingoMultip, string sort_, TransactionManager tm_)
        {
            return GetByBingoMultip(bingoMultip, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoMultipAsync(int bingoMultip, string sort_, TransactionManager tm_)
        {
            return await GetByBingoMultipAsync(bingoMultip, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoMultip（字段） 查询
        /// </summary>
        /// /// <param name = "bingoMultip">bingo倍率</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoMultip(int bingoMultip, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoMultip` = @BingoMultip", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoMultip", bingoMultip, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoMultipAsync(int bingoMultip, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoMultip` = @BingoMultip", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoMultip", bingoMultip, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBingoMultip
        #region GetByBingoTotal

        /// <summary>
        /// 按 BingoTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTotal">Bingo累计</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoTotal(long bingoTotal)
        {
            return GetByBingoTotal(bingoTotal, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoTotalAsync(long bingoTotal)
        {
            return await GetByBingoTotalAsync(bingoTotal, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTotal">Bingo累计</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoTotal(long bingoTotal, TransactionManager tm_)
        {
            return GetByBingoTotal(bingoTotal, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoTotalAsync(long bingoTotal, TransactionManager tm_)
        {
            return await GetByBingoTotalAsync(bingoTotal, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTotal">Bingo累计</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoTotal(long bingoTotal, int top_)
        {
            return GetByBingoTotal(bingoTotal, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoTotalAsync(long bingoTotal, int top_)
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
        public List<Gmf_user_slotEO> GetByBingoTotal(long bingoTotal, int top_, TransactionManager tm_)
        {
            return GetByBingoTotal(bingoTotal, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoTotalAsync(long bingoTotal, int top_, TransactionManager tm_)
        {
            return await GetByBingoTotalAsync(bingoTotal, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTotal">Bingo累计</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoTotal(long bingoTotal, string sort_)
        {
            return GetByBingoTotal(bingoTotal, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoTotalAsync(long bingoTotal, string sort_)
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
        public List<Gmf_user_slotEO> GetByBingoTotal(long bingoTotal, string sort_, TransactionManager tm_)
        {
            return GetByBingoTotal(bingoTotal, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoTotalAsync(long bingoTotal, string sort_, TransactionManager tm_)
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
        public List<Gmf_user_slotEO> GetByBingoTotal(long bingoTotal, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoTotal` = @BingoTotal", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoTotal", bingoTotal, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoTotalAsync(long bingoTotal, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoTotal` = @BingoTotal", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoTotal", bingoTotal, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBingoTotal
        #region GetByBingoPanelNums

        /// <summary>
        /// 按 BingoPanelNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPanelNums">面板的25个球,按顺序|分割</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoPanelNums(string bingoPanelNums)
        {
            return GetByBingoPanelNums(bingoPanelNums, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoPanelNumsAsync(string bingoPanelNums)
        {
            return await GetByBingoPanelNumsAsync(bingoPanelNums, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoPanelNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPanelNums">面板的25个球,按顺序|分割</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoPanelNums(string bingoPanelNums, TransactionManager tm_)
        {
            return GetByBingoPanelNums(bingoPanelNums, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoPanelNumsAsync(string bingoPanelNums, TransactionManager tm_)
        {
            return await GetByBingoPanelNumsAsync(bingoPanelNums, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoPanelNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPanelNums">面板的25个球,按顺序|分割</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoPanelNums(string bingoPanelNums, int top_)
        {
            return GetByBingoPanelNums(bingoPanelNums, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoPanelNumsAsync(string bingoPanelNums, int top_)
        {
            return await GetByBingoPanelNumsAsync(bingoPanelNums, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoPanelNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPanelNums">面板的25个球,按顺序|分割</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoPanelNums(string bingoPanelNums, int top_, TransactionManager tm_)
        {
            return GetByBingoPanelNums(bingoPanelNums, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoPanelNumsAsync(string bingoPanelNums, int top_, TransactionManager tm_)
        {
            return await GetByBingoPanelNumsAsync(bingoPanelNums, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoPanelNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPanelNums">面板的25个球,按顺序|分割</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoPanelNums(string bingoPanelNums, string sort_)
        {
            return GetByBingoPanelNums(bingoPanelNums, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoPanelNumsAsync(string bingoPanelNums, string sort_)
        {
            return await GetByBingoPanelNumsAsync(bingoPanelNums, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoPanelNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPanelNums">面板的25个球,按顺序|分割</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoPanelNums(string bingoPanelNums, string sort_, TransactionManager tm_)
        {
            return GetByBingoPanelNums(bingoPanelNums, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoPanelNumsAsync(string bingoPanelNums, string sort_, TransactionManager tm_)
        {
            return await GetByBingoPanelNumsAsync(bingoPanelNums, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoPanelNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPanelNums">面板的25个球,按顺序|分割</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoPanelNums(string bingoPanelNums, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(bingoPanelNums != null ? "`BingoPanelNums` = @BingoPanelNums" : "`BingoPanelNums` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (bingoPanelNums != null)
                paras_.Add(Database.CreateInParameter("@BingoPanelNums", bingoPanelNums, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoPanelNumsAsync(string bingoPanelNums, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(bingoPanelNums != null ? "`BingoPanelNums` = @BingoPanelNums" : "`BingoPanelNums` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (bingoPanelNums != null)
                paras_.Add(Database.CreateInParameter("@BingoPanelNums", bingoPanelNums, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBingoPanelNums
        #region GetByBingoHitLine

        /// <summary>
        /// 按 BingoHitLine（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHitLine">Bingo中奖线</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoHitLine(int bingoHitLine)
        {
            return GetByBingoHitLine(bingoHitLine, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoHitLineAsync(int bingoHitLine)
        {
            return await GetByBingoHitLineAsync(bingoHitLine, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoHitLine（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHitLine">Bingo中奖线</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoHitLine(int bingoHitLine, TransactionManager tm_)
        {
            return GetByBingoHitLine(bingoHitLine, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoHitLineAsync(int bingoHitLine, TransactionManager tm_)
        {
            return await GetByBingoHitLineAsync(bingoHitLine, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoHitLine（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHitLine">Bingo中奖线</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoHitLine(int bingoHitLine, int top_)
        {
            return GetByBingoHitLine(bingoHitLine, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoHitLineAsync(int bingoHitLine, int top_)
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
        public List<Gmf_user_slotEO> GetByBingoHitLine(int bingoHitLine, int top_, TransactionManager tm_)
        {
            return GetByBingoHitLine(bingoHitLine, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoHitLineAsync(int bingoHitLine, int top_, TransactionManager tm_)
        {
            return await GetByBingoHitLineAsync(bingoHitLine, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoHitLine（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHitLine">Bingo中奖线</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoHitLine(int bingoHitLine, string sort_)
        {
            return GetByBingoHitLine(bingoHitLine, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoHitLineAsync(int bingoHitLine, string sort_)
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
        public List<Gmf_user_slotEO> GetByBingoHitLine(int bingoHitLine, string sort_, TransactionManager tm_)
        {
            return GetByBingoHitLine(bingoHitLine, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoHitLineAsync(int bingoHitLine, string sort_, TransactionManager tm_)
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
        public List<Gmf_user_slotEO> GetByBingoHitLine(int bingoHitLine, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoHitLine` = @BingoHitLine", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoHitLine", bingoHitLine, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoHitLineAsync(int bingoHitLine, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoHitLine` = @BingoHitLine", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoHitLine", bingoHitLine, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBingoHitLine
        #region GetByBingoKeepNum

        /// <summary>
        /// 按 BingoKeepNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNum">Bingo保留的数字</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoKeepNum(int bingoKeepNum)
        {
            return GetByBingoKeepNum(bingoKeepNum, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoKeepNumAsync(int bingoKeepNum)
        {
            return await GetByBingoKeepNumAsync(bingoKeepNum, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoKeepNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNum">Bingo保留的数字</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoKeepNum(int bingoKeepNum, TransactionManager tm_)
        {
            return GetByBingoKeepNum(bingoKeepNum, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoKeepNumAsync(int bingoKeepNum, TransactionManager tm_)
        {
            return await GetByBingoKeepNumAsync(bingoKeepNum, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoKeepNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNum">Bingo保留的数字</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoKeepNum(int bingoKeepNum, int top_)
        {
            return GetByBingoKeepNum(bingoKeepNum, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoKeepNumAsync(int bingoKeepNum, int top_)
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
        public List<Gmf_user_slotEO> GetByBingoKeepNum(int bingoKeepNum, int top_, TransactionManager tm_)
        {
            return GetByBingoKeepNum(bingoKeepNum, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoKeepNumAsync(int bingoKeepNum, int top_, TransactionManager tm_)
        {
            return await GetByBingoKeepNumAsync(bingoKeepNum, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoKeepNum（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNum">Bingo保留的数字</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoKeepNum(int bingoKeepNum, string sort_)
        {
            return GetByBingoKeepNum(bingoKeepNum, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoKeepNumAsync(int bingoKeepNum, string sort_)
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
        public List<Gmf_user_slotEO> GetByBingoKeepNum(int bingoKeepNum, string sort_, TransactionManager tm_)
        {
            return GetByBingoKeepNum(bingoKeepNum, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoKeepNumAsync(int bingoKeepNum, string sort_, TransactionManager tm_)
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
        public List<Gmf_user_slotEO> GetByBingoKeepNum(int bingoKeepNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoKeepNum` = @BingoKeepNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoKeepNum", bingoKeepNum, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoKeepNumAsync(int bingoKeepNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoKeepNum` = @BingoKeepNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoKeepNum", bingoKeepNum, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBingoKeepNum
        #region GetByBingoKeepNums

        /// <summary>
        /// 按 BingoKeepNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNums">Bingo保留的数字</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoKeepNums(string bingoKeepNums)
        {
            return GetByBingoKeepNums(bingoKeepNums, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoKeepNumsAsync(string bingoKeepNums)
        {
            return await GetByBingoKeepNumsAsync(bingoKeepNums, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoKeepNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNums">Bingo保留的数字</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoKeepNums(string bingoKeepNums, TransactionManager tm_)
        {
            return GetByBingoKeepNums(bingoKeepNums, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoKeepNumsAsync(string bingoKeepNums, TransactionManager tm_)
        {
            return await GetByBingoKeepNumsAsync(bingoKeepNums, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoKeepNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNums">Bingo保留的数字</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoKeepNums(string bingoKeepNums, int top_)
        {
            return GetByBingoKeepNums(bingoKeepNums, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoKeepNumsAsync(string bingoKeepNums, int top_)
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
        public List<Gmf_user_slotEO> GetByBingoKeepNums(string bingoKeepNums, int top_, TransactionManager tm_)
        {
            return GetByBingoKeepNums(bingoKeepNums, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoKeepNumsAsync(string bingoKeepNums, int top_, TransactionManager tm_)
        {
            return await GetByBingoKeepNumsAsync(bingoKeepNums, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoKeepNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoKeepNums">Bingo保留的数字</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoKeepNums(string bingoKeepNums, string sort_)
        {
            return GetByBingoKeepNums(bingoKeepNums, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoKeepNumsAsync(string bingoKeepNums, string sort_)
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
        public List<Gmf_user_slotEO> GetByBingoKeepNums(string bingoKeepNums, string sort_, TransactionManager tm_)
        {
            return GetByBingoKeepNums(bingoKeepNums, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoKeepNumsAsync(string bingoKeepNums, string sort_, TransactionManager tm_)
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
        public List<Gmf_user_slotEO> GetByBingoKeepNums(string bingoKeepNums, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(bingoKeepNums != null ? "`BingoKeepNums` = @BingoKeepNums" : "`BingoKeepNums` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (bingoKeepNums != null)
                paras_.Add(Database.CreateInParameter("@BingoKeepNums", bingoKeepNums, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoKeepNumsAsync(string bingoKeepNums, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(bingoKeepNums != null ? "`BingoKeepNums` = @BingoKeepNums" : "`BingoKeepNums` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (bingoKeepNums != null)
                paras_.Add(Database.CreateInParameter("@BingoKeepNums", bingoKeepNums, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBingoKeepNums
        #region GetByBingoNewNums

        /// <summary>
        /// 按 BingoNewNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoNewNums">bingo新数字</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoNewNums(string bingoNewNums)
        {
            return GetByBingoNewNums(bingoNewNums, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoNewNumsAsync(string bingoNewNums)
        {
            return await GetByBingoNewNumsAsync(bingoNewNums, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoNewNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoNewNums">bingo新数字</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoNewNums(string bingoNewNums, TransactionManager tm_)
        {
            return GetByBingoNewNums(bingoNewNums, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoNewNumsAsync(string bingoNewNums, TransactionManager tm_)
        {
            return await GetByBingoNewNumsAsync(bingoNewNums, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoNewNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoNewNums">bingo新数字</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoNewNums(string bingoNewNums, int top_)
        {
            return GetByBingoNewNums(bingoNewNums, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoNewNumsAsync(string bingoNewNums, int top_)
        {
            return await GetByBingoNewNumsAsync(bingoNewNums, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoNewNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoNewNums">bingo新数字</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoNewNums(string bingoNewNums, int top_, TransactionManager tm_)
        {
            return GetByBingoNewNums(bingoNewNums, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoNewNumsAsync(string bingoNewNums, int top_, TransactionManager tm_)
        {
            return await GetByBingoNewNumsAsync(bingoNewNums, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoNewNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoNewNums">bingo新数字</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoNewNums(string bingoNewNums, string sort_)
        {
            return GetByBingoNewNums(bingoNewNums, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoNewNumsAsync(string bingoNewNums, string sort_)
        {
            return await GetByBingoNewNumsAsync(bingoNewNums, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoNewNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoNewNums">bingo新数字</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoNewNums(string bingoNewNums, string sort_, TransactionManager tm_)
        {
            return GetByBingoNewNums(bingoNewNums, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoNewNumsAsync(string bingoNewNums, string sort_, TransactionManager tm_)
        {
            return await GetByBingoNewNumsAsync(bingoNewNums, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoNewNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoNewNums">bingo新数字</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoNewNums(string bingoNewNums, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(bingoNewNums != null ? "`BingoNewNums` = @BingoNewNums" : "`BingoNewNums` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (bingoNewNums != null)
                paras_.Add(Database.CreateInParameter("@BingoNewNums", bingoNewNums, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoNewNumsAsync(string bingoNewNums, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(bingoNewNums != null ? "`BingoNewNums` = @BingoNewNums" : "`BingoNewNums` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (bingoNewNums != null)
                paras_.Add(Database.CreateInParameter("@BingoNewNums", bingoNewNums, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBingoNewNums
        #region GetByBingoHasNums

        /// <summary>
        /// 按 BingoHasNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHasNums">已出的75个数字,按顺序|分割</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoHasNums(string bingoHasNums)
        {
            return GetByBingoHasNums(bingoHasNums, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoHasNumsAsync(string bingoHasNums)
        {
            return await GetByBingoHasNumsAsync(bingoHasNums, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoHasNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHasNums">已出的75个数字,按顺序|分割</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoHasNums(string bingoHasNums, TransactionManager tm_)
        {
            return GetByBingoHasNums(bingoHasNums, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoHasNumsAsync(string bingoHasNums, TransactionManager tm_)
        {
            return await GetByBingoHasNumsAsync(bingoHasNums, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoHasNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHasNums">已出的75个数字,按顺序|分割</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoHasNums(string bingoHasNums, int top_)
        {
            return GetByBingoHasNums(bingoHasNums, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoHasNumsAsync(string bingoHasNums, int top_)
        {
            return await GetByBingoHasNumsAsync(bingoHasNums, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoHasNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHasNums">已出的75个数字,按顺序|分割</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoHasNums(string bingoHasNums, int top_, TransactionManager tm_)
        {
            return GetByBingoHasNums(bingoHasNums, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoHasNumsAsync(string bingoHasNums, int top_, TransactionManager tm_)
        {
            return await GetByBingoHasNumsAsync(bingoHasNums, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoHasNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHasNums">已出的75个数字,按顺序|分割</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoHasNums(string bingoHasNums, string sort_)
        {
            return GetByBingoHasNums(bingoHasNums, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoHasNumsAsync(string bingoHasNums, string sort_)
        {
            return await GetByBingoHasNumsAsync(bingoHasNums, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoHasNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHasNums">已出的75个数字,按顺序|分割</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoHasNums(string bingoHasNums, string sort_, TransactionManager tm_)
        {
            return GetByBingoHasNums(bingoHasNums, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoHasNumsAsync(string bingoHasNums, string sort_, TransactionManager tm_)
        {
            return await GetByBingoHasNumsAsync(bingoHasNums, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoHasNums（字段） 查询
        /// </summary>
        /// /// <param name = "bingoHasNums">已出的75个数字,按顺序|分割</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoHasNums(string bingoHasNums, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(bingoHasNums != null ? "`BingoHasNums` = @BingoHasNums" : "`BingoHasNums` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (bingoHasNums != null)
                paras_.Add(Database.CreateInParameter("@BingoHasNums", bingoHasNums, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoHasNumsAsync(string bingoHasNums, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(bingoHasNums != null ? "`BingoHasNums` = @BingoHasNums" : "`BingoHasNums` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (bingoHasNums != null)
                paras_.Add(Database.CreateInParameter("@BingoHasNums", bingoHasNums, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBingoHasNums
        #region GetByBingoWinAmount

        /// <summary>
        /// 按 BingoWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "bingoWinAmount">bingo奖金</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoWinAmount(long bingoWinAmount)
        {
            return GetByBingoWinAmount(bingoWinAmount, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoWinAmountAsync(long bingoWinAmount)
        {
            return await GetByBingoWinAmountAsync(bingoWinAmount, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "bingoWinAmount">bingo奖金</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoWinAmount(long bingoWinAmount, TransactionManager tm_)
        {
            return GetByBingoWinAmount(bingoWinAmount, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoWinAmountAsync(long bingoWinAmount, TransactionManager tm_)
        {
            return await GetByBingoWinAmountAsync(bingoWinAmount, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "bingoWinAmount">bingo奖金</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoWinAmount(long bingoWinAmount, int top_)
        {
            return GetByBingoWinAmount(bingoWinAmount, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoWinAmountAsync(long bingoWinAmount, int top_)
        {
            return await GetByBingoWinAmountAsync(bingoWinAmount, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "bingoWinAmount">bingo奖金</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoWinAmount(long bingoWinAmount, int top_, TransactionManager tm_)
        {
            return GetByBingoWinAmount(bingoWinAmount, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoWinAmountAsync(long bingoWinAmount, int top_, TransactionManager tm_)
        {
            return await GetByBingoWinAmountAsync(bingoWinAmount, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "bingoWinAmount">bingo奖金</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoWinAmount(long bingoWinAmount, string sort_)
        {
            return GetByBingoWinAmount(bingoWinAmount, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoWinAmountAsync(long bingoWinAmount, string sort_)
        {
            return await GetByBingoWinAmountAsync(bingoWinAmount, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "bingoWinAmount">bingo奖金</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoWinAmount(long bingoWinAmount, string sort_, TransactionManager tm_)
        {
            return GetByBingoWinAmount(bingoWinAmount, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoWinAmountAsync(long bingoWinAmount, string sort_, TransactionManager tm_)
        {
            return await GetByBingoWinAmountAsync(bingoWinAmount, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "bingoWinAmount">bingo奖金</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBingoWinAmount(long bingoWinAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoWinAmount` = @BingoWinAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoWinAmount", bingoWinAmount, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBingoWinAmountAsync(long bingoWinAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoWinAmount` = @BingoWinAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoWinAmount", bingoWinAmount, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBingoWinAmount
        #region GetByBonusIsOutTH

        /// <summary>
        /// 按 BonusIsOutTH（字段） 查询
        /// </summary>
        /// /// <param name = "bonusIsOutTH">bonus是否超过阈值</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusIsOutTH(bool bonusIsOutTH)
        {
            return GetByBonusIsOutTH(bonusIsOutTH, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusIsOutTHAsync(bool bonusIsOutTH)
        {
            return await GetByBonusIsOutTHAsync(bonusIsOutTH, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusIsOutTH（字段） 查询
        /// </summary>
        /// /// <param name = "bonusIsOutTH">bonus是否超过阈值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusIsOutTH(bool bonusIsOutTH, TransactionManager tm_)
        {
            return GetByBonusIsOutTH(bonusIsOutTH, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusIsOutTHAsync(bool bonusIsOutTH, TransactionManager tm_)
        {
            return await GetByBonusIsOutTHAsync(bonusIsOutTH, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusIsOutTH（字段） 查询
        /// </summary>
        /// /// <param name = "bonusIsOutTH">bonus是否超过阈值</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusIsOutTH(bool bonusIsOutTH, int top_)
        {
            return GetByBonusIsOutTH(bonusIsOutTH, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusIsOutTHAsync(bool bonusIsOutTH, int top_)
        {
            return await GetByBonusIsOutTHAsync(bonusIsOutTH, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusIsOutTH（字段） 查询
        /// </summary>
        /// /// <param name = "bonusIsOutTH">bonus是否超过阈值</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusIsOutTH(bool bonusIsOutTH, int top_, TransactionManager tm_)
        {
            return GetByBonusIsOutTH(bonusIsOutTH, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusIsOutTHAsync(bool bonusIsOutTH, int top_, TransactionManager tm_)
        {
            return await GetByBonusIsOutTHAsync(bonusIsOutTH, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusIsOutTH（字段） 查询
        /// </summary>
        /// /// <param name = "bonusIsOutTH">bonus是否超过阈值</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusIsOutTH(bool bonusIsOutTH, string sort_)
        {
            return GetByBonusIsOutTH(bonusIsOutTH, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusIsOutTHAsync(bool bonusIsOutTH, string sort_)
        {
            return await GetByBonusIsOutTHAsync(bonusIsOutTH, 0, sort_, null);
        }

        /// <summary>
        /// 按 BonusIsOutTH（字段） 查询
        /// </summary>
        /// /// <param name = "bonusIsOutTH">bonus是否超过阈值</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusIsOutTH(bool bonusIsOutTH, string sort_, TransactionManager tm_)
        {
            return GetByBonusIsOutTH(bonusIsOutTH, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusIsOutTHAsync(bool bonusIsOutTH, string sort_, TransactionManager tm_)
        {
            return await GetByBonusIsOutTHAsync(bonusIsOutTH, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BonusIsOutTH（字段） 查询
        /// </summary>
        /// /// <param name = "bonusIsOutTH">bonus是否超过阈值</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusIsOutTH(bool bonusIsOutTH, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusIsOutTH` = @BonusIsOutTH", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusIsOutTH", bonusIsOutTH, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusIsOutTHAsync(bool bonusIsOutTH, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusIsOutTH` = @BonusIsOutTH", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusIsOutTH", bonusIsOutTH, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBonusIsOutTH
        #region GetByBonusIsWin

        /// <summary>
        /// 按 BonusIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "bonusIsWin">Bunus是否奖励</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusIsWin(bool bonusIsWin)
        {
            return GetByBonusIsWin(bonusIsWin, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusIsWinAsync(bool bonusIsWin)
        {
            return await GetByBonusIsWinAsync(bonusIsWin, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "bonusIsWin">Bunus是否奖励</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusIsWin(bool bonusIsWin, TransactionManager tm_)
        {
            return GetByBonusIsWin(bonusIsWin, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusIsWinAsync(bool bonusIsWin, TransactionManager tm_)
        {
            return await GetByBonusIsWinAsync(bonusIsWin, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "bonusIsWin">Bunus是否奖励</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusIsWin(bool bonusIsWin, int top_)
        {
            return GetByBonusIsWin(bonusIsWin, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusIsWinAsync(bool bonusIsWin, int top_)
        {
            return await GetByBonusIsWinAsync(bonusIsWin, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "bonusIsWin">Bunus是否奖励</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusIsWin(bool bonusIsWin, int top_, TransactionManager tm_)
        {
            return GetByBonusIsWin(bonusIsWin, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusIsWinAsync(bool bonusIsWin, int top_, TransactionManager tm_)
        {
            return await GetByBonusIsWinAsync(bonusIsWin, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "bonusIsWin">Bunus是否奖励</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusIsWin(bool bonusIsWin, string sort_)
        {
            return GetByBonusIsWin(bonusIsWin, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusIsWinAsync(bool bonusIsWin, string sort_)
        {
            return await GetByBonusIsWinAsync(bonusIsWin, 0, sort_, null);
        }

        /// <summary>
        /// 按 BonusIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "bonusIsWin">Bunus是否奖励</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusIsWin(bool bonusIsWin, string sort_, TransactionManager tm_)
        {
            return GetByBonusIsWin(bonusIsWin, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusIsWinAsync(bool bonusIsWin, string sort_, TransactionManager tm_)
        {
            return await GetByBonusIsWinAsync(bonusIsWin, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BonusIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "bonusIsWin">Bunus是否奖励</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusIsWin(bool bonusIsWin, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusIsWin` = @BonusIsWin", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusIsWin", bonusIsWin, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusIsWinAsync(bool bonusIsWin, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusIsWin` = @BonusIsWin", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusIsWin", bonusIsWin, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBonusIsWin
        #region GetByBonusMultip

        /// <summary>
        /// 按 BonusMultip（字段） 查询
        /// </summary>
        /// /// <param name = "bonusMultip">Bonus倍率</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusMultip(int bonusMultip)
        {
            return GetByBonusMultip(bonusMultip, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusMultipAsync(int bonusMultip)
        {
            return await GetByBonusMultipAsync(bonusMultip, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusMultip（字段） 查询
        /// </summary>
        /// /// <param name = "bonusMultip">Bonus倍率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusMultip(int bonusMultip, TransactionManager tm_)
        {
            return GetByBonusMultip(bonusMultip, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusMultipAsync(int bonusMultip, TransactionManager tm_)
        {
            return await GetByBonusMultipAsync(bonusMultip, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusMultip（字段） 查询
        /// </summary>
        /// /// <param name = "bonusMultip">Bonus倍率</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusMultip(int bonusMultip, int top_)
        {
            return GetByBonusMultip(bonusMultip, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusMultipAsync(int bonusMultip, int top_)
        {
            return await GetByBonusMultipAsync(bonusMultip, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusMultip（字段） 查询
        /// </summary>
        /// /// <param name = "bonusMultip">Bonus倍率</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusMultip(int bonusMultip, int top_, TransactionManager tm_)
        {
            return GetByBonusMultip(bonusMultip, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusMultipAsync(int bonusMultip, int top_, TransactionManager tm_)
        {
            return await GetByBonusMultipAsync(bonusMultip, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusMultip（字段） 查询
        /// </summary>
        /// /// <param name = "bonusMultip">Bonus倍率</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusMultip(int bonusMultip, string sort_)
        {
            return GetByBonusMultip(bonusMultip, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusMultipAsync(int bonusMultip, string sort_)
        {
            return await GetByBonusMultipAsync(bonusMultip, 0, sort_, null);
        }

        /// <summary>
        /// 按 BonusMultip（字段） 查询
        /// </summary>
        /// /// <param name = "bonusMultip">Bonus倍率</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusMultip(int bonusMultip, string sort_, TransactionManager tm_)
        {
            return GetByBonusMultip(bonusMultip, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusMultipAsync(int bonusMultip, string sort_, TransactionManager tm_)
        {
            return await GetByBonusMultipAsync(bonusMultip, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BonusMultip（字段） 查询
        /// </summary>
        /// /// <param name = "bonusMultip">Bonus倍率</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusMultip(int bonusMultip, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusMultip` = @BonusMultip", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusMultip", bonusMultip, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusMultipAsync(int bonusMultip, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusMultip` = @BonusMultip", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusMultip", bonusMultip, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBonusMultip
        #region GetByBonusTotal

        /// <summary>
        /// 按 BonusTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTotal">Bonus累计</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusTotal(long bonusTotal)
        {
            return GetByBonusTotal(bonusTotal, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusTotalAsync(long bonusTotal)
        {
            return await GetByBonusTotalAsync(bonusTotal, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTotal">Bonus累计</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusTotal(long bonusTotal, TransactionManager tm_)
        {
            return GetByBonusTotal(bonusTotal, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusTotalAsync(long bonusTotal, TransactionManager tm_)
        {
            return await GetByBonusTotalAsync(bonusTotal, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTotal">Bonus累计</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusTotal(long bonusTotal, int top_)
        {
            return GetByBonusTotal(bonusTotal, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusTotalAsync(long bonusTotal, int top_)
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
        public List<Gmf_user_slotEO> GetByBonusTotal(long bonusTotal, int top_, TransactionManager tm_)
        {
            return GetByBonusTotal(bonusTotal, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusTotalAsync(long bonusTotal, int top_, TransactionManager tm_)
        {
            return await GetByBonusTotalAsync(bonusTotal, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusTotal（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTotal">Bonus累计</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusTotal(long bonusTotal, string sort_)
        {
            return GetByBonusTotal(bonusTotal, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusTotalAsync(long bonusTotal, string sort_)
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
        public List<Gmf_user_slotEO> GetByBonusTotal(long bonusTotal, string sort_, TransactionManager tm_)
        {
            return GetByBonusTotal(bonusTotal, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusTotalAsync(long bonusTotal, string sort_, TransactionManager tm_)
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
        public List<Gmf_user_slotEO> GetByBonusTotal(long bonusTotal, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusTotal` = @BonusTotal", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusTotal", bonusTotal, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusTotalAsync(long bonusTotal, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusTotal` = @BonusTotal", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusTotal", bonusTotal, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBonusTotal
        #region GetByBonusSymbolNum

        /// <summary>
        /// 按 BonusSymbolNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusSymbolNum">Bunus球数量</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusSymbolNum(int bonusSymbolNum)
        {
            return GetByBonusSymbolNum(bonusSymbolNum, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusSymbolNumAsync(int bonusSymbolNum)
        {
            return await GetByBonusSymbolNumAsync(bonusSymbolNum, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusSymbolNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusSymbolNum">Bunus球数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusSymbolNum(int bonusSymbolNum, TransactionManager tm_)
        {
            return GetByBonusSymbolNum(bonusSymbolNum, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusSymbolNumAsync(int bonusSymbolNum, TransactionManager tm_)
        {
            return await GetByBonusSymbolNumAsync(bonusSymbolNum, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusSymbolNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusSymbolNum">Bunus球数量</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusSymbolNum(int bonusSymbolNum, int top_)
        {
            return GetByBonusSymbolNum(bonusSymbolNum, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusSymbolNumAsync(int bonusSymbolNum, int top_)
        {
            return await GetByBonusSymbolNumAsync(bonusSymbolNum, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusSymbolNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusSymbolNum">Bunus球数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusSymbolNum(int bonusSymbolNum, int top_, TransactionManager tm_)
        {
            return GetByBonusSymbolNum(bonusSymbolNum, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusSymbolNumAsync(int bonusSymbolNum, int top_, TransactionManager tm_)
        {
            return await GetByBonusSymbolNumAsync(bonusSymbolNum, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusSymbolNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusSymbolNum">Bunus球数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusSymbolNum(int bonusSymbolNum, string sort_)
        {
            return GetByBonusSymbolNum(bonusSymbolNum, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusSymbolNumAsync(int bonusSymbolNum, string sort_)
        {
            return await GetByBonusSymbolNumAsync(bonusSymbolNum, 0, sort_, null);
        }

        /// <summary>
        /// 按 BonusSymbolNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusSymbolNum">Bunus球数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusSymbolNum(int bonusSymbolNum, string sort_, TransactionManager tm_)
        {
            return GetByBonusSymbolNum(bonusSymbolNum, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusSymbolNumAsync(int bonusSymbolNum, string sort_, TransactionManager tm_)
        {
            return await GetByBonusSymbolNumAsync(bonusSymbolNum, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BonusSymbolNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusSymbolNum">Bunus球数量</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusSymbolNum(int bonusSymbolNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusSymbolNum` = @BonusSymbolNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusSymbolNum", bonusSymbolNum, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusSymbolNumAsync(int bonusSymbolNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusSymbolNum` = @BonusSymbolNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusSymbolNum", bonusSymbolNum, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBonusSymbolNum
        #region GetByBonusNewRetriggerNum

        /// <summary>
        /// 按 BonusNewRetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusNewRetriggerNum">Bonus新retrigger数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusNewRetriggerNum(int bonusNewRetriggerNum)
        {
            return GetByBonusNewRetriggerNum(bonusNewRetriggerNum, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusNewRetriggerNumAsync(int bonusNewRetriggerNum)
        {
            return await GetByBonusNewRetriggerNumAsync(bonusNewRetriggerNum, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusNewRetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusNewRetriggerNum">Bonus新retrigger数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusNewRetriggerNum(int bonusNewRetriggerNum, TransactionManager tm_)
        {
            return GetByBonusNewRetriggerNum(bonusNewRetriggerNum, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusNewRetriggerNumAsync(int bonusNewRetriggerNum, TransactionManager tm_)
        {
            return await GetByBonusNewRetriggerNumAsync(bonusNewRetriggerNum, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusNewRetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusNewRetriggerNum">Bonus新retrigger数</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusNewRetriggerNum(int bonusNewRetriggerNum, int top_)
        {
            return GetByBonusNewRetriggerNum(bonusNewRetriggerNum, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusNewRetriggerNumAsync(int bonusNewRetriggerNum, int top_)
        {
            return await GetByBonusNewRetriggerNumAsync(bonusNewRetriggerNum, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusNewRetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusNewRetriggerNum">Bonus新retrigger数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusNewRetriggerNum(int bonusNewRetriggerNum, int top_, TransactionManager tm_)
        {
            return GetByBonusNewRetriggerNum(bonusNewRetriggerNum, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusNewRetriggerNumAsync(int bonusNewRetriggerNum, int top_, TransactionManager tm_)
        {
            return await GetByBonusNewRetriggerNumAsync(bonusNewRetriggerNum, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusNewRetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusNewRetriggerNum">Bonus新retrigger数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusNewRetriggerNum(int bonusNewRetriggerNum, string sort_)
        {
            return GetByBonusNewRetriggerNum(bonusNewRetriggerNum, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusNewRetriggerNumAsync(int bonusNewRetriggerNum, string sort_)
        {
            return await GetByBonusNewRetriggerNumAsync(bonusNewRetriggerNum, 0, sort_, null);
        }

        /// <summary>
        /// 按 BonusNewRetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusNewRetriggerNum">Bonus新retrigger数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusNewRetriggerNum(int bonusNewRetriggerNum, string sort_, TransactionManager tm_)
        {
            return GetByBonusNewRetriggerNum(bonusNewRetriggerNum, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusNewRetriggerNumAsync(int bonusNewRetriggerNum, string sort_, TransactionManager tm_)
        {
            return await GetByBonusNewRetriggerNumAsync(bonusNewRetriggerNum, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BonusNewRetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "bonusNewRetriggerNum">Bonus新retrigger数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusNewRetriggerNum(int bonusNewRetriggerNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusNewRetriggerNum` = @BonusNewRetriggerNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusNewRetriggerNum", bonusNewRetriggerNum, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusNewRetriggerNumAsync(int bonusNewRetriggerNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusNewRetriggerNum` = @BonusNewRetriggerNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusNewRetriggerNum", bonusNewRetriggerNum, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBonusNewRetriggerNum
        #region GetByFreeSpinNum

        /// <summary>
        /// 按 FreeSpinNum（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinNum">freespin剩余数量</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByFreeSpinNum(int freeSpinNum)
        {
            return GetByFreeSpinNum(freeSpinNum, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByFreeSpinNumAsync(int freeSpinNum)
        {
            return await GetByFreeSpinNumAsync(freeSpinNum, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 FreeSpinNum（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinNum">freespin剩余数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByFreeSpinNum(int freeSpinNum, TransactionManager tm_)
        {
            return GetByFreeSpinNum(freeSpinNum, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByFreeSpinNumAsync(int freeSpinNum, TransactionManager tm_)
        {
            return await GetByFreeSpinNumAsync(freeSpinNum, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 FreeSpinNum（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinNum">freespin剩余数量</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByFreeSpinNum(int freeSpinNum, int top_)
        {
            return GetByFreeSpinNum(freeSpinNum, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByFreeSpinNumAsync(int freeSpinNum, int top_)
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
        public List<Gmf_user_slotEO> GetByFreeSpinNum(int freeSpinNum, int top_, TransactionManager tm_)
        {
            return GetByFreeSpinNum(freeSpinNum, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByFreeSpinNumAsync(int freeSpinNum, int top_, TransactionManager tm_)
        {
            return await GetByFreeSpinNumAsync(freeSpinNum, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 FreeSpinNum（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinNum">freespin剩余数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByFreeSpinNum(int freeSpinNum, string sort_)
        {
            return GetByFreeSpinNum(freeSpinNum, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByFreeSpinNumAsync(int freeSpinNum, string sort_)
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
        public List<Gmf_user_slotEO> GetByFreeSpinNum(int freeSpinNum, string sort_, TransactionManager tm_)
        {
            return GetByFreeSpinNum(freeSpinNum, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByFreeSpinNumAsync(int freeSpinNum, string sort_, TransactionManager tm_)
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
        public List<Gmf_user_slotEO> GetByFreeSpinNum(int freeSpinNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`FreeSpinNum` = @FreeSpinNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@FreeSpinNum", freeSpinNum, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByFreeSpinNumAsync(int freeSpinNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`FreeSpinNum` = @FreeSpinNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@FreeSpinNum", freeSpinNum, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByFreeSpinNum
        #region GetByRetriggerNum

        /// <summary>
        /// 按 RetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerNum">retrigger剩余数量</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByRetriggerNum(int retriggerNum)
        {
            return GetByRetriggerNum(retriggerNum, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRetriggerNumAsync(int retriggerNum)
        {
            return await GetByRetriggerNumAsync(retriggerNum, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 RetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerNum">retrigger剩余数量</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByRetriggerNum(int retriggerNum, TransactionManager tm_)
        {
            return GetByRetriggerNum(retriggerNum, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRetriggerNumAsync(int retriggerNum, TransactionManager tm_)
        {
            return await GetByRetriggerNumAsync(retriggerNum, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerNum">retrigger剩余数量</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByRetriggerNum(int retriggerNum, int top_)
        {
            return GetByRetriggerNum(retriggerNum, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRetriggerNumAsync(int retriggerNum, int top_)
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
        public List<Gmf_user_slotEO> GetByRetriggerNum(int retriggerNum, int top_, TransactionManager tm_)
        {
            return GetByRetriggerNum(retriggerNum, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRetriggerNumAsync(int retriggerNum, int top_, TransactionManager tm_)
        {
            return await GetByRetriggerNumAsync(retriggerNum, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RetriggerNum（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerNum">retrigger剩余数量</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByRetriggerNum(int retriggerNum, string sort_)
        {
            return GetByRetriggerNum(retriggerNum, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRetriggerNumAsync(int retriggerNum, string sort_)
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
        public List<Gmf_user_slotEO> GetByRetriggerNum(int retriggerNum, string sort_, TransactionManager tm_)
        {
            return GetByRetriggerNum(retriggerNum, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRetriggerNumAsync(int retriggerNum, string sort_, TransactionManager tm_)
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
        public List<Gmf_user_slotEO> GetByRetriggerNum(int retriggerNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RetriggerNum` = @RetriggerNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RetriggerNum", retriggerNum, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRetriggerNumAsync(int retriggerNum, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RetriggerNum` = @RetriggerNum", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RetriggerNum", retriggerNum, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByRetriggerNum
        #region GetByRetriggerList

        /// <summary>
        /// 按 RetriggerList（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerList">retrigger出现顺序</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByRetriggerList(string retriggerList)
        {
            return GetByRetriggerList(retriggerList, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRetriggerListAsync(string retriggerList)
        {
            return await GetByRetriggerListAsync(retriggerList, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 RetriggerList（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerList">retrigger出现顺序</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByRetriggerList(string retriggerList, TransactionManager tm_)
        {
            return GetByRetriggerList(retriggerList, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRetriggerListAsync(string retriggerList, TransactionManager tm_)
        {
            return await GetByRetriggerListAsync(retriggerList, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RetriggerList（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerList">retrigger出现顺序</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByRetriggerList(string retriggerList, int top_)
        {
            return GetByRetriggerList(retriggerList, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRetriggerListAsync(string retriggerList, int top_)
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
        public List<Gmf_user_slotEO> GetByRetriggerList(string retriggerList, int top_, TransactionManager tm_)
        {
            return GetByRetriggerList(retriggerList, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRetriggerListAsync(string retriggerList, int top_, TransactionManager tm_)
        {
            return await GetByRetriggerListAsync(retriggerList, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RetriggerList（字段） 查询
        /// </summary>
        /// /// <param name = "retriggerList">retrigger出现顺序</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByRetriggerList(string retriggerList, string sort_)
        {
            return GetByRetriggerList(retriggerList, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRetriggerListAsync(string retriggerList, string sort_)
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
        public List<Gmf_user_slotEO> GetByRetriggerList(string retriggerList, string sort_, TransactionManager tm_)
        {
            return GetByRetriggerList(retriggerList, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRetriggerListAsync(string retriggerList, string sort_, TransactionManager tm_)
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
        public List<Gmf_user_slotEO> GetByRetriggerList(string retriggerList, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(retriggerList != null ? "`RetriggerList` = @RetriggerList" : "`RetriggerList` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (retriggerList != null)
                paras_.Add(Database.CreateInParameter("@RetriggerList", retriggerList, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRetriggerListAsync(string retriggerList, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(retriggerList != null ? "`RetriggerList` = @RetriggerList" : "`RetriggerList` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (retriggerList != null)
                paras_.Add(Database.CreateInParameter("@RetriggerList", retriggerList, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByRetriggerList
        #region GetByBonusWinAmount

        /// <summary>
        /// 按 BonusWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "bonusWinAmount">Bonus奖金</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusWinAmount(long bonusWinAmount)
        {
            return GetByBonusWinAmount(bonusWinAmount, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusWinAmountAsync(long bonusWinAmount)
        {
            return await GetByBonusWinAmountAsync(bonusWinAmount, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "bonusWinAmount">Bonus奖金</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusWinAmount(long bonusWinAmount, TransactionManager tm_)
        {
            return GetByBonusWinAmount(bonusWinAmount, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusWinAmountAsync(long bonusWinAmount, TransactionManager tm_)
        {
            return await GetByBonusWinAmountAsync(bonusWinAmount, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "bonusWinAmount">Bonus奖金</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusWinAmount(long bonusWinAmount, int top_)
        {
            return GetByBonusWinAmount(bonusWinAmount, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusWinAmountAsync(long bonusWinAmount, int top_)
        {
            return await GetByBonusWinAmountAsync(bonusWinAmount, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "bonusWinAmount">Bonus奖金</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusWinAmount(long bonusWinAmount, int top_, TransactionManager tm_)
        {
            return GetByBonusWinAmount(bonusWinAmount, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusWinAmountAsync(long bonusWinAmount, int top_, TransactionManager tm_)
        {
            return await GetByBonusWinAmountAsync(bonusWinAmount, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "bonusWinAmount">Bonus奖金</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusWinAmount(long bonusWinAmount, string sort_)
        {
            return GetByBonusWinAmount(bonusWinAmount, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusWinAmountAsync(long bonusWinAmount, string sort_)
        {
            return await GetByBonusWinAmountAsync(bonusWinAmount, 0, sort_, null);
        }

        /// <summary>
        /// 按 BonusWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "bonusWinAmount">Bonus奖金</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusWinAmount(long bonusWinAmount, string sort_, TransactionManager tm_)
        {
            return GetByBonusWinAmount(bonusWinAmount, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusWinAmountAsync(long bonusWinAmount, string sort_, TransactionManager tm_)
        {
            return await GetByBonusWinAmountAsync(bonusWinAmount, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BonusWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "bonusWinAmount">Bonus奖金</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBonusWinAmount(long bonusWinAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusWinAmount` = @BonusWinAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusWinAmount", bonusWinAmount, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBonusWinAmountAsync(long bonusWinAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusWinAmount` = @BonusWinAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusWinAmount", bonusWinAmount, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBonusWinAmount
        #region GetByBaseIsWin

        /// <summary>
        /// 按 BaseIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "baseIsWin">base是否奖励</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseIsWin(bool baseIsWin)
        {
            return GetByBaseIsWin(baseIsWin, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseIsWinAsync(bool baseIsWin)
        {
            return await GetByBaseIsWinAsync(baseIsWin, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BaseIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "baseIsWin">base是否奖励</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseIsWin(bool baseIsWin, TransactionManager tm_)
        {
            return GetByBaseIsWin(baseIsWin, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseIsWinAsync(bool baseIsWin, TransactionManager tm_)
        {
            return await GetByBaseIsWinAsync(baseIsWin, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BaseIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "baseIsWin">base是否奖励</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseIsWin(bool baseIsWin, int top_)
        {
            return GetByBaseIsWin(baseIsWin, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseIsWinAsync(bool baseIsWin, int top_)
        {
            return await GetByBaseIsWinAsync(baseIsWin, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BaseIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "baseIsWin">base是否奖励</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseIsWin(bool baseIsWin, int top_, TransactionManager tm_)
        {
            return GetByBaseIsWin(baseIsWin, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseIsWinAsync(bool baseIsWin, int top_, TransactionManager tm_)
        {
            return await GetByBaseIsWinAsync(baseIsWin, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BaseIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "baseIsWin">base是否奖励</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseIsWin(bool baseIsWin, string sort_)
        {
            return GetByBaseIsWin(baseIsWin, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseIsWinAsync(bool baseIsWin, string sort_)
        {
            return await GetByBaseIsWinAsync(baseIsWin, 0, sort_, null);
        }

        /// <summary>
        /// 按 BaseIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "baseIsWin">base是否奖励</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseIsWin(bool baseIsWin, string sort_, TransactionManager tm_)
        {
            return GetByBaseIsWin(baseIsWin, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseIsWinAsync(bool baseIsWin, string sort_, TransactionManager tm_)
        {
            return await GetByBaseIsWinAsync(baseIsWin, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BaseIsWin（字段） 查询
        /// </summary>
        /// /// <param name = "baseIsWin">base是否奖励</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseIsWin(bool baseIsWin, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BaseIsWin` = @BaseIsWin", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BaseIsWin", baseIsWin, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseIsWinAsync(bool baseIsWin, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BaseIsWin` = @BaseIsWin", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BaseIsWin", baseIsWin, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBaseIsWin
        #region GetByBaseMultip

        /// <summary>
        /// 按 BaseMultip（字段） 查询
        /// </summary>
        /// /// <param name = "baseMultip">base倍率</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseMultip(int baseMultip)
        {
            return GetByBaseMultip(baseMultip, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseMultipAsync(int baseMultip)
        {
            return await GetByBaseMultipAsync(baseMultip, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BaseMultip（字段） 查询
        /// </summary>
        /// /// <param name = "baseMultip">base倍率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseMultip(int baseMultip, TransactionManager tm_)
        {
            return GetByBaseMultip(baseMultip, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseMultipAsync(int baseMultip, TransactionManager tm_)
        {
            return await GetByBaseMultipAsync(baseMultip, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BaseMultip（字段） 查询
        /// </summary>
        /// /// <param name = "baseMultip">base倍率</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseMultip(int baseMultip, int top_)
        {
            return GetByBaseMultip(baseMultip, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseMultipAsync(int baseMultip, int top_)
        {
            return await GetByBaseMultipAsync(baseMultip, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BaseMultip（字段） 查询
        /// </summary>
        /// /// <param name = "baseMultip">base倍率</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseMultip(int baseMultip, int top_, TransactionManager tm_)
        {
            return GetByBaseMultip(baseMultip, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseMultipAsync(int baseMultip, int top_, TransactionManager tm_)
        {
            return await GetByBaseMultipAsync(baseMultip, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BaseMultip（字段） 查询
        /// </summary>
        /// /// <param name = "baseMultip">base倍率</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseMultip(int baseMultip, string sort_)
        {
            return GetByBaseMultip(baseMultip, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseMultipAsync(int baseMultip, string sort_)
        {
            return await GetByBaseMultipAsync(baseMultip, 0, sort_, null);
        }

        /// <summary>
        /// 按 BaseMultip（字段） 查询
        /// </summary>
        /// /// <param name = "baseMultip">base倍率</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseMultip(int baseMultip, string sort_, TransactionManager tm_)
        {
            return GetByBaseMultip(baseMultip, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseMultipAsync(int baseMultip, string sort_, TransactionManager tm_)
        {
            return await GetByBaseMultipAsync(baseMultip, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BaseMultip（字段） 查询
        /// </summary>
        /// /// <param name = "baseMultip">base倍率</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseMultip(int baseMultip, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BaseMultip` = @BaseMultip", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BaseMultip", baseMultip, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseMultipAsync(int baseMultip, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BaseMultip` = @BaseMultip", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BaseMultip", baseMultip, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBaseMultip
        #region GetByBaseWinAmount

        /// <summary>
        /// 按 BaseWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "baseWinAmount">base奖金</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseWinAmount(long baseWinAmount)
        {
            return GetByBaseWinAmount(baseWinAmount, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseWinAmountAsync(long baseWinAmount)
        {
            return await GetByBaseWinAmountAsync(baseWinAmount, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BaseWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "baseWinAmount">base奖金</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseWinAmount(long baseWinAmount, TransactionManager tm_)
        {
            return GetByBaseWinAmount(baseWinAmount, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseWinAmountAsync(long baseWinAmount, TransactionManager tm_)
        {
            return await GetByBaseWinAmountAsync(baseWinAmount, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BaseWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "baseWinAmount">base奖金</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseWinAmount(long baseWinAmount, int top_)
        {
            return GetByBaseWinAmount(baseWinAmount, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseWinAmountAsync(long baseWinAmount, int top_)
        {
            return await GetByBaseWinAmountAsync(baseWinAmount, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BaseWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "baseWinAmount">base奖金</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseWinAmount(long baseWinAmount, int top_, TransactionManager tm_)
        {
            return GetByBaseWinAmount(baseWinAmount, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseWinAmountAsync(long baseWinAmount, int top_, TransactionManager tm_)
        {
            return await GetByBaseWinAmountAsync(baseWinAmount, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BaseWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "baseWinAmount">base奖金</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseWinAmount(long baseWinAmount, string sort_)
        {
            return GetByBaseWinAmount(baseWinAmount, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseWinAmountAsync(long baseWinAmount, string sort_)
        {
            return await GetByBaseWinAmountAsync(baseWinAmount, 0, sort_, null);
        }

        /// <summary>
        /// 按 BaseWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "baseWinAmount">base奖金</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseWinAmount(long baseWinAmount, string sort_, TransactionManager tm_)
        {
            return GetByBaseWinAmount(baseWinAmount, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseWinAmountAsync(long baseWinAmount, string sort_, TransactionManager tm_)
        {
            return await GetByBaseWinAmountAsync(baseWinAmount, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BaseWinAmount（字段） 查询
        /// </summary>
        /// /// <param name = "baseWinAmount">base奖金</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByBaseWinAmount(long baseWinAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BaseWinAmount` = @BaseWinAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BaseWinAmount", baseWinAmount, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByBaseWinAmountAsync(long baseWinAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BaseWinAmount` = @BaseWinAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BaseWinAmount", baseWinAmount, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByBaseWinAmount
        #region GetByTotalAmount

        /// <summary>
        /// 按 TotalAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalAmount">总盈利</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByTotalAmount(long totalAmount)
        {
            return GetByTotalAmount(totalAmount, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByTotalAmountAsync(long totalAmount)
        {
            return await GetByTotalAmountAsync(totalAmount, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 TotalAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalAmount">总盈利</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByTotalAmount(long totalAmount, TransactionManager tm_)
        {
            return GetByTotalAmount(totalAmount, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByTotalAmountAsync(long totalAmount, TransactionManager tm_)
        {
            return await GetByTotalAmountAsync(totalAmount, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 TotalAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalAmount">总盈利</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByTotalAmount(long totalAmount, int top_)
        {
            return GetByTotalAmount(totalAmount, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByTotalAmountAsync(long totalAmount, int top_)
        {
            return await GetByTotalAmountAsync(totalAmount, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 TotalAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalAmount">总盈利</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByTotalAmount(long totalAmount, int top_, TransactionManager tm_)
        {
            return GetByTotalAmount(totalAmount, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByTotalAmountAsync(long totalAmount, int top_, TransactionManager tm_)
        {
            return await GetByTotalAmountAsync(totalAmount, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 TotalAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalAmount">总盈利</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByTotalAmount(long totalAmount, string sort_)
        {
            return GetByTotalAmount(totalAmount, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByTotalAmountAsync(long totalAmount, string sort_)
        {
            return await GetByTotalAmountAsync(totalAmount, 0, sort_, null);
        }

        /// <summary>
        /// 按 TotalAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalAmount">总盈利</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByTotalAmount(long totalAmount, string sort_, TransactionManager tm_)
        {
            return GetByTotalAmount(totalAmount, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByTotalAmountAsync(long totalAmount, string sort_, TransactionManager tm_)
        {
            return await GetByTotalAmountAsync(totalAmount, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 TotalAmount（字段） 查询
        /// </summary>
        /// /// <param name = "totalAmount">总盈利</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByTotalAmount(long totalAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`TotalAmount` = @TotalAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalAmount", totalAmount, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByTotalAmountAsync(long totalAmount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`TotalAmount` = @TotalAmount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@TotalAmount", totalAmount, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByTotalAmount
        #region GetBySlotItemID

        /// <summary>
        /// 按 SlotItemID（字段） 查询
        /// </summary>
        /// /// <param name = "slotItemID">抽取的组合ID</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetBySlotItemID(long slotItemID)
        {
            return GetBySlotItemID(slotItemID, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetBySlotItemIDAsync(long slotItemID)
        {
            return await GetBySlotItemIDAsync(slotItemID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 SlotItemID（字段） 查询
        /// </summary>
        /// /// <param name = "slotItemID">抽取的组合ID</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetBySlotItemID(long slotItemID, TransactionManager tm_)
        {
            return GetBySlotItemID(slotItemID, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetBySlotItemIDAsync(long slotItemID, TransactionManager tm_)
        {
            return await GetBySlotItemIDAsync(slotItemID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SlotItemID（字段） 查询
        /// </summary>
        /// /// <param name = "slotItemID">抽取的组合ID</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetBySlotItemID(long slotItemID, int top_)
        {
            return GetBySlotItemID(slotItemID, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetBySlotItemIDAsync(long slotItemID, int top_)
        {
            return await GetBySlotItemIDAsync(slotItemID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 SlotItemID（字段） 查询
        /// </summary>
        /// /// <param name = "slotItemID">抽取的组合ID</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetBySlotItemID(long slotItemID, int top_, TransactionManager tm_)
        {
            return GetBySlotItemID(slotItemID, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetBySlotItemIDAsync(long slotItemID, int top_, TransactionManager tm_)
        {
            return await GetBySlotItemIDAsync(slotItemID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SlotItemID（字段） 查询
        /// </summary>
        /// /// <param name = "slotItemID">抽取的组合ID</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetBySlotItemID(long slotItemID, string sort_)
        {
            return GetBySlotItemID(slotItemID, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetBySlotItemIDAsync(long slotItemID, string sort_)
        {
            return await GetBySlotItemIDAsync(slotItemID, 0, sort_, null);
        }

        /// <summary>
        /// 按 SlotItemID（字段） 查询
        /// </summary>
        /// /// <param name = "slotItemID">抽取的组合ID</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetBySlotItemID(long slotItemID, string sort_, TransactionManager tm_)
        {
            return GetBySlotItemID(slotItemID, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetBySlotItemIDAsync(long slotItemID, string sort_, TransactionManager tm_)
        {
            return await GetBySlotItemIDAsync(slotItemID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 SlotItemID（字段） 查询
        /// </summary>
        /// /// <param name = "slotItemID">抽取的组合ID</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetBySlotItemID(long slotItemID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`SlotItemID` = @SlotItemID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SlotItemID", slotItemID, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetBySlotItemIDAsync(long slotItemID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`SlotItemID` = @SlotItemID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SlotItemID", slotItemID, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetBySlotItemID
        #region GetByStatus

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByStatus(int status)
        {
            return GetByStatus(status, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByStatusAsync(int status)
        {
            return await GetByStatusAsync(status, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByStatus(int status, TransactionManager tm_)
        {
            return GetByStatus(status, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByStatusAsync(int status, TransactionManager tm_)
        {
            return await GetByStatusAsync(status, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByStatus(int status, int top_)
        {
            return GetByStatus(status, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByStatusAsync(int status, int top_)
        {
            return await GetByStatusAsync(status, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByStatus(int status, int top_, TransactionManager tm_)
        {
            return GetByStatus(status, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
        {
            return await GetByStatusAsync(status, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByStatus(int status, string sort_)
        {
            return GetByStatus(status, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByStatusAsync(int status, string sort_)
        {
            return await GetByStatusAsync(status, 0, sort_, null);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByStatus(int status, string sort_, TransactionManager tm_)
        {
            return GetByStatus(status, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
        {
            return await GetByStatusAsync(status, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Status（字段） 查询
        /// </summary>
        /// /// <param name = "status">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByStatus
        #region GetByRecDate

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByRecDate(DateTime recDate)
        {
            return GetByRecDate(recDate, 0, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRecDateAsync(DateTime recDate)
        {
            return await GetByRecDateAsync(recDate, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
        {
            return GetByRecDate(recDate, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
        {
            return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByRecDate(DateTime recDate, int top_)
        {
            return GetByRecDate(recDate, top_, string.Empty, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
        public List<Gmf_user_slotEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
        {
            return GetByRecDate(recDate, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
        {
            return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_user_slotEO> GetByRecDate(DateTime recDate, string sort_)
        {
            return GetByRecDate(recDate, 0, sort_, null);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
        public List<Gmf_user_slotEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
        {
            return GetByRecDate(recDate, 0, sort_, tm_);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
        public List<Gmf_user_slotEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        public async Task<List<Gmf_user_slotEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_user_slotEO.MapDataReader);
        }
        #endregion // GetByRecDate
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
