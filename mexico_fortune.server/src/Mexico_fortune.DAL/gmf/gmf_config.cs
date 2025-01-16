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
    /// 【表 gmf_config 的实体类】
    /// </summary>
    [DataContract]
    public class Gmf_configEO : IRowMapper<Gmf_configEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Gmf_configEO()
        {
            this.BonusTH = 0f;
            this.BingoTH = 0f;
            this.BingoPerValue = 0f;
            this.BonusRetriggerRatio = 0f;
            this.BonusBigoRatio = 0f;
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private int _originalID;
        /// <summary>
        /// 【数据库中的原始主键 ID 值的副本，用于主键值更新】
        /// </summary>
        public int OriginalID
        {
            get { return _originalID; }
            set { HasOriginal = true; _originalID = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "ID", ID }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// 
        /// 【主键 int】
        /// </summary>
        [DataMember(Order = 1)]
        public int ID { get; set; }
        /// <summary>
        /// BIG WIN中奖倍数
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 2)]
        public int BigWin { get; set; }
        /// <summary>
        /// MEGA WIN中奖倍数
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 3)]
        public int MegaWin { get; set; }
        /// <summary>
        /// SUPER WIN中奖倍数
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 4)]
        public int SuperWin { get; set; }
        /// <summary>
        /// EPIC WIN中奖倍数
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 5)]
        public int EpicWin { get; set; }
        /// <summary>
        /// bonus阈值
        /// 【字段 float】
        /// </summary>
        [DataMember(Order = 6)]
        public float BonusTH { get; set; }
        /// <summary>
        /// bingo阈值
        /// 【字段 float】
        /// </summary>
        [DataMember(Order = 7)]
        public float BingoTH { get; set; }
        /// <summary>
        /// Bingo固定价值
        /// 【字段 float】
        /// </summary>
        [DataMember(Order = 8)]
        public float BingoPerValue { get; set; }
        /// <summary>
        /// BaseName模块分配比例
        /// 【字段 float】
        /// </summary>
        [DataMember(Order = 9)]
        public float PartBaseRatio { get; set; }
        /// <summary>
        /// Bonus模块分配比例
        /// 【字段 float】
        /// </summary>
        [DataMember(Order = 10)]
        public float PartBonusRatio { get; set; }
        /// <summary>
        /// bingo模块分配比例
        /// 【字段 float】
        /// </summary>
        [DataMember(Order = 11)]
        public float PartBingoRatio { get; set; }
        /// <summary>
        /// bonus时分配超10倍部分分配给retrigger比率
        /// 【字段 float】
        /// </summary>
        [DataMember(Order = 12)]
        public float BonusRetriggerRatio { get; set; }
        /// <summary>
        /// bonus时分配超10倍部分分配给bingo比率
        /// 【字段 float】
        /// </summary>
        [DataMember(Order = 13)]
        public float BonusBigoRatio { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public Gmf_configEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static Gmf_configEO MapDataReader(IDataReader reader)
        {
            Gmf_configEO ret = new Gmf_configEO();
            ret.ID = reader.ToInt32("ID");
            ret.OriginalID = ret.ID;
            ret.BigWin = reader.ToInt32("BigWin");
            ret.MegaWin = reader.ToInt32("MegaWin");
            ret.SuperWin = reader.ToInt32("SuperWin");
            ret.EpicWin = reader.ToInt32("EpicWin");
            ret.BonusTH = reader.ToSingle("BonusTH");
            ret.BingoTH = reader.ToSingle("BingoTH");
            ret.BingoPerValue = reader.ToSingle("BingoPerValue");
            ret.PartBaseRatio = reader.ToSingle("PartBaseRatio");
            ret.PartBonusRatio = reader.ToSingle("PartBonusRatio");
            ret.PartBingoRatio = reader.ToSingle("PartBingoRatio");
            ret.BonusRetriggerRatio = reader.ToSingle("BonusRetriggerRatio");
            ret.BonusBigoRatio = reader.ToSingle("BonusBigoRatio");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// 
    /// 【表 gmf_config 的操作类】
    /// </summary>
    public class Gmf_configMO : MySqlTableMO<Gmf_configEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`gmf_config`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public Gmf_configMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public Gmf_configMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public Gmf_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(Gmf_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(Gmf_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(Gmf_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`ID`, `BigWin`, `MegaWin`, `SuperWin`, `EpicWin`, `BonusTH`, `BingoTH`, `BingoPerValue`, `PartBaseRatio`, `PartBonusRatio`, `PartBingoRatio`, `BonusRetriggerRatio`, `BonusBigoRatio`) VALUE (@ID, @BigWin, @MegaWin, @SuperWin, @EpicWin, @BonusTH, @BingoTH, @BingoPerValue, @PartBaseRatio, @PartBonusRatio, @PartBingoRatio, @BonusRetriggerRatio, @BonusBigoRatio);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", item.ID, MySqlDbType.Int32),
                Database.CreateInParameter("@BigWin", item.BigWin, MySqlDbType.Int32),
                Database.CreateInParameter("@MegaWin", item.MegaWin, MySqlDbType.Int32),
                Database.CreateInParameter("@SuperWin", item.SuperWin, MySqlDbType.Int32),
                Database.CreateInParameter("@EpicWin", item.EpicWin, MySqlDbType.Int32),
                Database.CreateInParameter("@BonusTH", item.BonusTH, MySqlDbType.Float),
                Database.CreateInParameter("@BingoTH", item.BingoTH, MySqlDbType.Float),
                Database.CreateInParameter("@BingoPerValue", item.BingoPerValue, MySqlDbType.Float),
                Database.CreateInParameter("@PartBaseRatio", item.PartBaseRatio, MySqlDbType.Float),
                Database.CreateInParameter("@PartBonusRatio", item.PartBonusRatio, MySqlDbType.Float),
                Database.CreateInParameter("@PartBingoRatio", item.PartBingoRatio, MySqlDbType.Float),
                Database.CreateInParameter("@BonusRetriggerRatio", item.BonusRetriggerRatio, MySqlDbType.Float),
                Database.CreateInParameter("@BonusBigoRatio", item.BonusBigoRatio, MySqlDbType.Float),
            };
        }
        public int AddByBatch(IEnumerable<Gmf_configEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<Gmf_configEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gmf_configEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`ID`, `BigWin`, `MegaWin`, `SuperWin`, `EpicWin`, `BonusTH`, `BingoTH`, `BingoPerValue`, `PartBaseRatio`, `PartBonusRatio`, `PartBingoRatio`, `BonusRetriggerRatio`, `BonusBigoRatio`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"({item.ID},{item.BigWin},{item.MegaWin},{item.SuperWin},{item.EpicWin},{item.BonusTH},{item.BingoTH},{item.BingoPerValue},{item.PartBaseRatio},{item.PartBonusRatio},{item.PartBingoRatio},{item.BonusRetriggerRatio},{item.BonusBigoRatio}),");
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
        /// /// <param name = "iD"></param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(int iD, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(iD, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(int iD, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(iD, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(int iD, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `ID` = @ID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(Gmf_configEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.ID, tm_);
        }
        public async Task<int> RemoveAsync(Gmf_configEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.ID, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
        #region RemoveByBigWin
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bigWin">BIG WIN中奖倍数</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBigWin(int bigWin, TransactionManager tm_ = null)
        {
            RepairRemoveByBigWinData(bigWin, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBigWinAsync(int bigWin, TransactionManager tm_ = null)
        {
            RepairRemoveByBigWinData(bigWin, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBigWinData(int bigWin, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BigWin` = @BigWin";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BigWin", bigWin, MySqlDbType.Int32));
        }
        #endregion // RemoveByBigWin
        #region RemoveByMegaWin
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "megaWin">MEGA WIN中奖倍数</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByMegaWin(int megaWin, TransactionManager tm_ = null)
        {
            RepairRemoveByMegaWinData(megaWin, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByMegaWinAsync(int megaWin, TransactionManager tm_ = null)
        {
            RepairRemoveByMegaWinData(megaWin, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByMegaWinData(int megaWin, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `MegaWin` = @MegaWin";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@MegaWin", megaWin, MySqlDbType.Int32));
        }
        #endregion // RemoveByMegaWin
        #region RemoveBySuperWin
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "superWin">SUPER WIN中奖倍数</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveBySuperWin(int superWin, TransactionManager tm_ = null)
        {
            RepairRemoveBySuperWinData(superWin, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveBySuperWinAsync(int superWin, TransactionManager tm_ = null)
        {
            RepairRemoveBySuperWinData(superWin, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveBySuperWinData(int superWin, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `SuperWin` = @SuperWin";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SuperWin", superWin, MySqlDbType.Int32));
        }
        #endregion // RemoveBySuperWin
        #region RemoveByEpicWin
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "epicWin">EPIC WIN中奖倍数</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByEpicWin(int epicWin, TransactionManager tm_ = null)
        {
            RepairRemoveByEpicWinData(epicWin, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByEpicWinAsync(int epicWin, TransactionManager tm_ = null)
        {
            RepairRemoveByEpicWinData(epicWin, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByEpicWinData(int epicWin, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `EpicWin` = @EpicWin";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@EpicWin", epicWin, MySqlDbType.Int32));
        }
        #endregion // RemoveByEpicWin
        #region RemoveByBonusTH
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bonusTH">bonus阈值</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBonusTH(float bonusTH, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusTHData(bonusTH, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBonusTHAsync(float bonusTH, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusTHData(bonusTH, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBonusTHData(float bonusTH, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BonusTH` = @BonusTH";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusTH", bonusTH, MySqlDbType.Float));
        }
        #endregion // RemoveByBonusTH
        #region RemoveByBingoTH
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoTH">bingo阈值</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBingoTH(float bingoTH, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoTHData(bingoTH, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBingoTHAsync(float bingoTH, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoTHData(bingoTH, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBingoTHData(float bingoTH, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BingoTH` = @BingoTH";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoTH", bingoTH, MySqlDbType.Float));
        }
        #endregion // RemoveByBingoTH
        #region RemoveByBingoPerValue
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bingoPerValue">Bingo固定价值</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBingoPerValue(float bingoPerValue, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoPerValueData(bingoPerValue, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBingoPerValueAsync(float bingoPerValue, TransactionManager tm_ = null)
        {
            RepairRemoveByBingoPerValueData(bingoPerValue, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBingoPerValueData(float bingoPerValue, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BingoPerValue` = @BingoPerValue";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoPerValue", bingoPerValue, MySqlDbType.Float));
        }
        #endregion // RemoveByBingoPerValue
        #region RemoveByPartBaseRatio
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "partBaseRatio">BaseName模块分配比例</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPartBaseRatio(float partBaseRatio, TransactionManager tm_ = null)
        {
            RepairRemoveByPartBaseRatioData(partBaseRatio, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPartBaseRatioAsync(float partBaseRatio, TransactionManager tm_ = null)
        {
            RepairRemoveByPartBaseRatioData(partBaseRatio, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByPartBaseRatioData(float partBaseRatio, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `PartBaseRatio` = @PartBaseRatio";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBaseRatio", partBaseRatio, MySqlDbType.Float));
        }
        #endregion // RemoveByPartBaseRatio
        #region RemoveByPartBonusRatio
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "partBonusRatio">Bonus模块分配比例</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPartBonusRatio(float partBonusRatio, TransactionManager tm_ = null)
        {
            RepairRemoveByPartBonusRatioData(partBonusRatio, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPartBonusRatioAsync(float partBonusRatio, TransactionManager tm_ = null)
        {
            RepairRemoveByPartBonusRatioData(partBonusRatio, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByPartBonusRatioData(float partBonusRatio, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `PartBonusRatio` = @PartBonusRatio";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBonusRatio", partBonusRatio, MySqlDbType.Float));
        }
        #endregion // RemoveByPartBonusRatio
        #region RemoveByPartBingoRatio
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "partBingoRatio">bingo模块分配比例</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPartBingoRatio(float partBingoRatio, TransactionManager tm_ = null)
        {
            RepairRemoveByPartBingoRatioData(partBingoRatio, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPartBingoRatioAsync(float partBingoRatio, TransactionManager tm_ = null)
        {
            RepairRemoveByPartBingoRatioData(partBingoRatio, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByPartBingoRatioData(float partBingoRatio, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `PartBingoRatio` = @PartBingoRatio";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBingoRatio", partBingoRatio, MySqlDbType.Float));
        }
        #endregion // RemoveByPartBingoRatio
        #region RemoveByBonusRetriggerRatio
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bonusRetriggerRatio">bonus时分配超10倍部分分配给retrigger比率</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBonusRetriggerRatio(float bonusRetriggerRatio, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusRetriggerRatioData(bonusRetriggerRatio, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBonusRetriggerRatioAsync(float bonusRetriggerRatio, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusRetriggerRatioData(bonusRetriggerRatio, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBonusRetriggerRatioData(float bonusRetriggerRatio, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BonusRetriggerRatio` = @BonusRetriggerRatio";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusRetriggerRatio", bonusRetriggerRatio, MySqlDbType.Float));
        }
        #endregion // RemoveByBonusRetriggerRatio
        #region RemoveByBonusBigoRatio
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "bonusBigoRatio">bonus时分配超10倍部分分配给bingo比率</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByBonusBigoRatio(float bonusBigoRatio, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusBigoRatioData(bonusBigoRatio, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByBonusBigoRatioAsync(float bonusBigoRatio, TransactionManager tm_ = null)
        {
            RepairRemoveByBonusBigoRatioData(bonusBigoRatio, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByBonusBigoRatioData(float bonusBigoRatio, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `BonusBigoRatio` = @BonusBigoRatio";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusBigoRatio", bonusBigoRatio, MySqlDbType.Float));
        }
        #endregion // RemoveByBonusBigoRatio
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
        public int Put(Gmf_configEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(Gmf_configEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(Gmf_configEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `ID` = @ID, `BigWin` = @BigWin, `MegaWin` = @MegaWin, `SuperWin` = @SuperWin, `EpicWin` = @EpicWin, `BonusTH` = @BonusTH, `BingoTH` = @BingoTH, `BingoPerValue` = @BingoPerValue, `PartBaseRatio` = @PartBaseRatio, `PartBonusRatio` = @PartBonusRatio, `PartBingoRatio` = @PartBingoRatio, `BonusRetriggerRatio` = @BonusRetriggerRatio, `BonusBigoRatio` = @BonusBigoRatio WHERE `ID` = @ID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", item.ID, MySqlDbType.Int32),
                Database.CreateInParameter("@BigWin", item.BigWin, MySqlDbType.Int32),
                Database.CreateInParameter("@MegaWin", item.MegaWin, MySqlDbType.Int32),
                Database.CreateInParameter("@SuperWin", item.SuperWin, MySqlDbType.Int32),
                Database.CreateInParameter("@EpicWin", item.EpicWin, MySqlDbType.Int32),
                Database.CreateInParameter("@BonusTH", item.BonusTH, MySqlDbType.Float),
                Database.CreateInParameter("@BingoTH", item.BingoTH, MySqlDbType.Float),
                Database.CreateInParameter("@BingoPerValue", item.BingoPerValue, MySqlDbType.Float),
                Database.CreateInParameter("@PartBaseRatio", item.PartBaseRatio, MySqlDbType.Float),
                Database.CreateInParameter("@PartBonusRatio", item.PartBonusRatio, MySqlDbType.Float),
                Database.CreateInParameter("@PartBingoRatio", item.PartBingoRatio, MySqlDbType.Float),
                Database.CreateInParameter("@BonusRetriggerRatio", item.BonusRetriggerRatio, MySqlDbType.Float),
                Database.CreateInParameter("@BonusBigoRatio", item.BonusBigoRatio, MySqlDbType.Float),
                Database.CreateInParameter("@ID_Original", item.HasOriginal ? item.OriginalID : item.ID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<Gmf_configEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<Gmf_configEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "iD"></param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int iD, string set_, params object[] values_)
        {
            return Put(set_, "`ID` = @ID", ConcatValues(values_, iD));
        }
        public async Task<int> PutByPKAsync(int iD, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`ID` = @ID", ConcatValues(values_, iD));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "iD"></param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int iD, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`ID` = @ID", tm_, ConcatValues(values_, iD));
        }
        public async Task<int> PutByPKAsync(int iD, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`ID` = @ID", tm_, ConcatValues(values_, iD));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "iD"></param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int iD, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return Put(set_, "`ID` = @ID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(int iD, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return await PutAsync(set_, "`ID` = @ID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutBigWin
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "iD"></param>
        /// /// <param name = "bigWin">BIG WIN中奖倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBigWinByPK(int iD, int bigWin, TransactionManager tm_ = null)
        {
            RepairPutBigWinByPKData(iD, bigWin, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBigWinByPKAsync(int iD, int bigWin, TransactionManager tm_ = null)
        {
            RepairPutBigWinByPKData(iD, bigWin, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBigWinByPKData(int iD, int bigWin, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BigWin` = @BigWin  WHERE `ID` = @ID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BigWin", bigWin, MySqlDbType.Int32),
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bigWin">BIG WIN中奖倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBigWin(int bigWin, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BigWin` = @BigWin";
            var parameter_ = Database.CreateInParameter("@BigWin", bigWin, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBigWinAsync(int bigWin, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BigWin` = @BigWin";
            var parameter_ = Database.CreateInParameter("@BigWin", bigWin, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBigWin
        #region PutMegaWin
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "iD"></param>
        /// /// <param name = "megaWin">MEGA WIN中奖倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutMegaWinByPK(int iD, int megaWin, TransactionManager tm_ = null)
        {
            RepairPutMegaWinByPKData(iD, megaWin, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutMegaWinByPKAsync(int iD, int megaWin, TransactionManager tm_ = null)
        {
            RepairPutMegaWinByPKData(iD, megaWin, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutMegaWinByPKData(int iD, int megaWin, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `MegaWin` = @MegaWin  WHERE `ID` = @ID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@MegaWin", megaWin, MySqlDbType.Int32),
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "megaWin">MEGA WIN中奖倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutMegaWin(int megaWin, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `MegaWin` = @MegaWin";
            var parameter_ = Database.CreateInParameter("@MegaWin", megaWin, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutMegaWinAsync(int megaWin, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `MegaWin` = @MegaWin";
            var parameter_ = Database.CreateInParameter("@MegaWin", megaWin, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutMegaWin
        #region PutSuperWin
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "iD"></param>
        /// /// <param name = "superWin">SUPER WIN中奖倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSuperWinByPK(int iD, int superWin, TransactionManager tm_ = null)
        {
            RepairPutSuperWinByPKData(iD, superWin, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutSuperWinByPKAsync(int iD, int superWin, TransactionManager tm_ = null)
        {
            RepairPutSuperWinByPKData(iD, superWin, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutSuperWinByPKData(int iD, int superWin, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `SuperWin` = @SuperWin  WHERE `ID` = @ID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SuperWin", superWin, MySqlDbType.Int32),
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "superWin">SUPER WIN中奖倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSuperWin(int superWin, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SuperWin` = @SuperWin";
            var parameter_ = Database.CreateInParameter("@SuperWin", superWin, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutSuperWinAsync(int superWin, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SuperWin` = @SuperWin";
            var parameter_ = Database.CreateInParameter("@SuperWin", superWin, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutSuperWin
        #region PutEpicWin
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "iD"></param>
        /// /// <param name = "epicWin">EPIC WIN中奖倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutEpicWinByPK(int iD, int epicWin, TransactionManager tm_ = null)
        {
            RepairPutEpicWinByPKData(iD, epicWin, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutEpicWinByPKAsync(int iD, int epicWin, TransactionManager tm_ = null)
        {
            RepairPutEpicWinByPKData(iD, epicWin, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutEpicWinByPKData(int iD, int epicWin, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `EpicWin` = @EpicWin  WHERE `ID` = @ID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@EpicWin", epicWin, MySqlDbType.Int32),
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "epicWin">EPIC WIN中奖倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutEpicWin(int epicWin, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `EpicWin` = @EpicWin";
            var parameter_ = Database.CreateInParameter("@EpicWin", epicWin, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutEpicWinAsync(int epicWin, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `EpicWin` = @EpicWin";
            var parameter_ = Database.CreateInParameter("@EpicWin", epicWin, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutEpicWin
        #region PutBonusTH
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "iD"></param>
        /// /// <param name = "bonusTH">bonus阈值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusTHByPK(int iD, float bonusTH, TransactionManager tm_ = null)
        {
            RepairPutBonusTHByPKData(iD, bonusTH, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBonusTHByPKAsync(int iD, float bonusTH, TransactionManager tm_ = null)
        {
            RepairPutBonusTHByPKData(iD, bonusTH, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBonusTHByPKData(int iD, float bonusTH, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BonusTH` = @BonusTH  WHERE `ID` = @ID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BonusTH", bonusTH, MySqlDbType.Float),
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bonusTH">bonus阈值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusTH(float bonusTH, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusTH` = @BonusTH";
            var parameter_ = Database.CreateInParameter("@BonusTH", bonusTH, MySqlDbType.Float);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBonusTHAsync(float bonusTH, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusTH` = @BonusTH";
            var parameter_ = Database.CreateInParameter("@BonusTH", bonusTH, MySqlDbType.Float);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBonusTH
        #region PutBingoTH
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "iD"></param>
        /// /// <param name = "bingoTH">bingo阈值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoTHByPK(int iD, float bingoTH, TransactionManager tm_ = null)
        {
            RepairPutBingoTHByPKData(iD, bingoTH, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoTHByPKAsync(int iD, float bingoTH, TransactionManager tm_ = null)
        {
            RepairPutBingoTHByPKData(iD, bingoTH, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoTHByPKData(int iD, float bingoTH, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoTH` = @BingoTH  WHERE `ID` = @ID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoTH", bingoTH, MySqlDbType.Float),
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoTH">bingo阈值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoTH(float bingoTH, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoTH` = @BingoTH";
            var parameter_ = Database.CreateInParameter("@BingoTH", bingoTH, MySqlDbType.Float);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBingoTHAsync(float bingoTH, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoTH` = @BingoTH";
            var parameter_ = Database.CreateInParameter("@BingoTH", bingoTH, MySqlDbType.Float);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBingoTH
        #region PutBingoPerValue
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "iD"></param>
        /// /// <param name = "bingoPerValue">Bingo固定价值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoPerValueByPK(int iD, float bingoPerValue, TransactionManager tm_ = null)
        {
            RepairPutBingoPerValueByPKData(iD, bingoPerValue, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBingoPerValueByPKAsync(int iD, float bingoPerValue, TransactionManager tm_ = null)
        {
            RepairPutBingoPerValueByPKData(iD, bingoPerValue, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBingoPerValueByPKData(int iD, float bingoPerValue, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BingoPerValue` = @BingoPerValue  WHERE `ID` = @ID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BingoPerValue", bingoPerValue, MySqlDbType.Float),
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bingoPerValue">Bingo固定价值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBingoPerValue(float bingoPerValue, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoPerValue` = @BingoPerValue";
            var parameter_ = Database.CreateInParameter("@BingoPerValue", bingoPerValue, MySqlDbType.Float);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBingoPerValueAsync(float bingoPerValue, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BingoPerValue` = @BingoPerValue";
            var parameter_ = Database.CreateInParameter("@BingoPerValue", bingoPerValue, MySqlDbType.Float);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBingoPerValue
        #region PutPartBaseRatio
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "iD"></param>
        /// /// <param name = "partBaseRatio">BaseName模块分配比例</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutPartBaseRatioByPK(int iD, float partBaseRatio, TransactionManager tm_ = null)
        {
            RepairPutPartBaseRatioByPKData(iD, partBaseRatio, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutPartBaseRatioByPKAsync(int iD, float partBaseRatio, TransactionManager tm_ = null)
        {
            RepairPutPartBaseRatioByPKData(iD, partBaseRatio, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutPartBaseRatioByPKData(int iD, float partBaseRatio, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `PartBaseRatio` = @PartBaseRatio  WHERE `ID` = @ID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@PartBaseRatio", partBaseRatio, MySqlDbType.Float),
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "partBaseRatio">BaseName模块分配比例</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutPartBaseRatio(float partBaseRatio, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `PartBaseRatio` = @PartBaseRatio";
            var parameter_ = Database.CreateInParameter("@PartBaseRatio", partBaseRatio, MySqlDbType.Float);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutPartBaseRatioAsync(float partBaseRatio, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `PartBaseRatio` = @PartBaseRatio";
            var parameter_ = Database.CreateInParameter("@PartBaseRatio", partBaseRatio, MySqlDbType.Float);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutPartBaseRatio
        #region PutPartBonusRatio
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "iD"></param>
        /// /// <param name = "partBonusRatio">Bonus模块分配比例</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutPartBonusRatioByPK(int iD, float partBonusRatio, TransactionManager tm_ = null)
        {
            RepairPutPartBonusRatioByPKData(iD, partBonusRatio, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutPartBonusRatioByPKAsync(int iD, float partBonusRatio, TransactionManager tm_ = null)
        {
            RepairPutPartBonusRatioByPKData(iD, partBonusRatio, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutPartBonusRatioByPKData(int iD, float partBonusRatio, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `PartBonusRatio` = @PartBonusRatio  WHERE `ID` = @ID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@PartBonusRatio", partBonusRatio, MySqlDbType.Float),
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "partBonusRatio">Bonus模块分配比例</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutPartBonusRatio(float partBonusRatio, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `PartBonusRatio` = @PartBonusRatio";
            var parameter_ = Database.CreateInParameter("@PartBonusRatio", partBonusRatio, MySqlDbType.Float);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutPartBonusRatioAsync(float partBonusRatio, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `PartBonusRatio` = @PartBonusRatio";
            var parameter_ = Database.CreateInParameter("@PartBonusRatio", partBonusRatio, MySqlDbType.Float);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutPartBonusRatio
        #region PutPartBingoRatio
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "iD"></param>
        /// /// <param name = "partBingoRatio">bingo模块分配比例</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutPartBingoRatioByPK(int iD, float partBingoRatio, TransactionManager tm_ = null)
        {
            RepairPutPartBingoRatioByPKData(iD, partBingoRatio, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutPartBingoRatioByPKAsync(int iD, float partBingoRatio, TransactionManager tm_ = null)
        {
            RepairPutPartBingoRatioByPKData(iD, partBingoRatio, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutPartBingoRatioByPKData(int iD, float partBingoRatio, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `PartBingoRatio` = @PartBingoRatio  WHERE `ID` = @ID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@PartBingoRatio", partBingoRatio, MySqlDbType.Float),
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "partBingoRatio">bingo模块分配比例</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutPartBingoRatio(float partBingoRatio, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `PartBingoRatio` = @PartBingoRatio";
            var parameter_ = Database.CreateInParameter("@PartBingoRatio", partBingoRatio, MySqlDbType.Float);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutPartBingoRatioAsync(float partBingoRatio, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `PartBingoRatio` = @PartBingoRatio";
            var parameter_ = Database.CreateInParameter("@PartBingoRatio", partBingoRatio, MySqlDbType.Float);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutPartBingoRatio
        #region PutBonusRetriggerRatio
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "iD"></param>
        /// /// <param name = "bonusRetriggerRatio">bonus时分配超10倍部分分配给retrigger比率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusRetriggerRatioByPK(int iD, float bonusRetriggerRatio, TransactionManager tm_ = null)
        {
            RepairPutBonusRetriggerRatioByPKData(iD, bonusRetriggerRatio, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBonusRetriggerRatioByPKAsync(int iD, float bonusRetriggerRatio, TransactionManager tm_ = null)
        {
            RepairPutBonusRetriggerRatioByPKData(iD, bonusRetriggerRatio, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBonusRetriggerRatioByPKData(int iD, float bonusRetriggerRatio, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BonusRetriggerRatio` = @BonusRetriggerRatio  WHERE `ID` = @ID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BonusRetriggerRatio", bonusRetriggerRatio, MySqlDbType.Float),
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bonusRetriggerRatio">bonus时分配超10倍部分分配给retrigger比率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusRetriggerRatio(float bonusRetriggerRatio, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusRetriggerRatio` = @BonusRetriggerRatio";
            var parameter_ = Database.CreateInParameter("@BonusRetriggerRatio", bonusRetriggerRatio, MySqlDbType.Float);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBonusRetriggerRatioAsync(float bonusRetriggerRatio, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusRetriggerRatio` = @BonusRetriggerRatio";
            var parameter_ = Database.CreateInParameter("@BonusRetriggerRatio", bonusRetriggerRatio, MySqlDbType.Float);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBonusRetriggerRatio
        #region PutBonusBigoRatio
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "iD"></param>
        /// /// <param name = "bonusBigoRatio">bonus时分配超10倍部分分配给bingo比率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusBigoRatioByPK(int iD, float bonusBigoRatio, TransactionManager tm_ = null)
        {
            RepairPutBonusBigoRatioByPKData(iD, bonusBigoRatio, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutBonusBigoRatioByPKAsync(int iD, float bonusBigoRatio, TransactionManager tm_ = null)
        {
            RepairPutBonusBigoRatioByPKData(iD, bonusBigoRatio, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutBonusBigoRatioByPKData(int iD, float bonusBigoRatio, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `BonusBigoRatio` = @BonusBigoRatio  WHERE `ID` = @ID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@BonusBigoRatio", bonusBigoRatio, MySqlDbType.Float),
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "bonusBigoRatio">bonus时分配超10倍部分分配给bingo比率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutBonusBigoRatio(float bonusBigoRatio, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusBigoRatio` = @BonusBigoRatio";
            var parameter_ = Database.CreateInParameter("@BonusBigoRatio", bonusBigoRatio, MySqlDbType.Float);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutBonusBigoRatioAsync(float bonusBigoRatio, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `BonusBigoRatio` = @BonusBigoRatio";
            var parameter_ = Database.CreateInParameter("@BonusBigoRatio", bonusBigoRatio, MySqlDbType.Float);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutBonusBigoRatio
        #endregion // PutXXX
        #endregion // Put

        #region Set

        /// <summary>
        /// 插入或者更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>true:插入操作；false:更新操作</return>
        public bool Set(Gmf_configEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.ID) == null)
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
        public async Task<bool> SetAsync(Gmf_configEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.ID) == null)
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
        /// /// <param name = "iD"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public Gmf_configEO GetByPK(int iD, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(iD, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        public async Task<Gmf_configEO> GetByPKAsync(int iD, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(iD, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        private void RepairGetByPKData(int iD, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`ID` = @ID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 BigWin（字段）
        /// </summary>
        /// /// <param name = "iD"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetBigWinByPK(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (int)GetScalar("`BigWin`", "`ID` = @ID", paras_, tm_);
        }
        public async Task<int> GetBigWinByPKAsync(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`BigWin`", "`ID` = @ID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 MegaWin（字段）
        /// </summary>
        /// /// <param name = "iD"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetMegaWinByPK(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (int)GetScalar("`MegaWin`", "`ID` = @ID", paras_, tm_);
        }
        public async Task<int> GetMegaWinByPKAsync(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`MegaWin`", "`ID` = @ID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 SuperWin（字段）
        /// </summary>
        /// /// <param name = "iD"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetSuperWinByPK(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (int)GetScalar("`SuperWin`", "`ID` = @ID", paras_, tm_);
        }
        public async Task<int> GetSuperWinByPKAsync(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`SuperWin`", "`ID` = @ID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 EpicWin（字段）
        /// </summary>
        /// /// <param name = "iD"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetEpicWinByPK(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (int)GetScalar("`EpicWin`", "`ID` = @ID", paras_, tm_);
        }
        public async Task<int> GetEpicWinByPKAsync(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`EpicWin`", "`ID` = @ID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BonusTH（字段）
        /// </summary>
        /// /// <param name = "iD"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public float GetBonusTHByPK(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (float)GetScalar("`BonusTH`", "`ID` = @ID", paras_, tm_);
        }
        public async Task<float> GetBonusTHByPKAsync(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (float)await GetScalarAsync("`BonusTH`", "`ID` = @ID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoTH（字段）
        /// </summary>
        /// /// <param name = "iD"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public float GetBingoTHByPK(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (float)GetScalar("`BingoTH`", "`ID` = @ID", paras_, tm_);
        }
        public async Task<float> GetBingoTHByPKAsync(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (float)await GetScalarAsync("`BingoTH`", "`ID` = @ID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BingoPerValue（字段）
        /// </summary>
        /// /// <param name = "iD"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public float GetBingoPerValueByPK(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (float)GetScalar("`BingoPerValue`", "`ID` = @ID", paras_, tm_);
        }
        public async Task<float> GetBingoPerValueByPKAsync(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (float)await GetScalarAsync("`BingoPerValue`", "`ID` = @ID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 PartBaseRatio（字段）
        /// </summary>
        /// /// <param name = "iD"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public float GetPartBaseRatioByPK(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (float)GetScalar("`PartBaseRatio`", "`ID` = @ID", paras_, tm_);
        }
        public async Task<float> GetPartBaseRatioByPKAsync(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (float)await GetScalarAsync("`PartBaseRatio`", "`ID` = @ID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 PartBonusRatio（字段）
        /// </summary>
        /// /// <param name = "iD"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public float GetPartBonusRatioByPK(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (float)GetScalar("`PartBonusRatio`", "`ID` = @ID", paras_, tm_);
        }
        public async Task<float> GetPartBonusRatioByPKAsync(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (float)await GetScalarAsync("`PartBonusRatio`", "`ID` = @ID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 PartBingoRatio（字段）
        /// </summary>
        /// /// <param name = "iD"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public float GetPartBingoRatioByPK(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (float)GetScalar("`PartBingoRatio`", "`ID` = @ID", paras_, tm_);
        }
        public async Task<float> GetPartBingoRatioByPKAsync(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (float)await GetScalarAsync("`PartBingoRatio`", "`ID` = @ID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BonusRetriggerRatio（字段）
        /// </summary>
        /// /// <param name = "iD"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public float GetBonusRetriggerRatioByPK(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (float)GetScalar("`BonusRetriggerRatio`", "`ID` = @ID", paras_, tm_);
        }
        public async Task<float> GetBonusRetriggerRatioByPKAsync(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (float)await GetScalarAsync("`BonusRetriggerRatio`", "`ID` = @ID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 BonusBigoRatio（字段）
        /// </summary>
        /// /// <param name = "iD"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public float GetBonusBigoRatioByPK(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (float)GetScalar("`BonusBigoRatio`", "`ID` = @ID", paras_, tm_);
        }
        public async Task<float> GetBonusBigoRatioByPKAsync(int iD, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@ID", iD, MySqlDbType.Int32),
            };
            return (float)await GetScalarAsync("`BonusBigoRatio`", "`ID` = @ID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByBigWin

        /// <summary>
        /// 按 BigWin（字段） 查询
        /// </summary>
        /// /// <param name = "bigWin">BIG WIN中奖倍数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBigWin(int bigWin)
        {
            return GetByBigWin(bigWin, 0, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByBigWinAsync(int bigWin)
        {
            return await GetByBigWinAsync(bigWin, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BigWin（字段） 查询
        /// </summary>
        /// /// <param name = "bigWin">BIG WIN中奖倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBigWin(int bigWin, TransactionManager tm_)
        {
            return GetByBigWin(bigWin, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBigWinAsync(int bigWin, TransactionManager tm_)
        {
            return await GetByBigWinAsync(bigWin, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BigWin（字段） 查询
        /// </summary>
        /// /// <param name = "bigWin">BIG WIN中奖倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBigWin(int bigWin, int top_)
        {
            return GetByBigWin(bigWin, top_, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByBigWinAsync(int bigWin, int top_)
        {
            return await GetByBigWinAsync(bigWin, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BigWin（字段） 查询
        /// </summary>
        /// /// <param name = "bigWin">BIG WIN中奖倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBigWin(int bigWin, int top_, TransactionManager tm_)
        {
            return GetByBigWin(bigWin, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBigWinAsync(int bigWin, int top_, TransactionManager tm_)
        {
            return await GetByBigWinAsync(bigWin, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BigWin（字段） 查询
        /// </summary>
        /// /// <param name = "bigWin">BIG WIN中奖倍数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBigWin(int bigWin, string sort_)
        {
            return GetByBigWin(bigWin, 0, sort_, null);
        }
        public async Task<List<Gmf_configEO>> GetByBigWinAsync(int bigWin, string sort_)
        {
            return await GetByBigWinAsync(bigWin, 0, sort_, null);
        }

        /// <summary>
        /// 按 BigWin（字段） 查询
        /// </summary>
        /// /// <param name = "bigWin">BIG WIN中奖倍数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBigWin(int bigWin, string sort_, TransactionManager tm_)
        {
            return GetByBigWin(bigWin, 0, sort_, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBigWinAsync(int bigWin, string sort_, TransactionManager tm_)
        {
            return await GetByBigWinAsync(bigWin, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BigWin（字段） 查询
        /// </summary>
        /// /// <param name = "bigWin">BIG WIN中奖倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBigWin(int bigWin, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BigWin` = @BigWin", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BigWin", bigWin, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        public async Task<List<Gmf_configEO>> GetByBigWinAsync(int bigWin, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BigWin` = @BigWin", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BigWin", bigWin, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        #endregion // GetByBigWin
        #region GetByMegaWin

        /// <summary>
        /// 按 MegaWin（字段） 查询
        /// </summary>
        /// /// <param name = "megaWin">MEGA WIN中奖倍数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByMegaWin(int megaWin)
        {
            return GetByMegaWin(megaWin, 0, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByMegaWinAsync(int megaWin)
        {
            return await GetByMegaWinAsync(megaWin, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 MegaWin（字段） 查询
        /// </summary>
        /// /// <param name = "megaWin">MEGA WIN中奖倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByMegaWin(int megaWin, TransactionManager tm_)
        {
            return GetByMegaWin(megaWin, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByMegaWinAsync(int megaWin, TransactionManager tm_)
        {
            return await GetByMegaWinAsync(megaWin, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 MegaWin（字段） 查询
        /// </summary>
        /// /// <param name = "megaWin">MEGA WIN中奖倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByMegaWin(int megaWin, int top_)
        {
            return GetByMegaWin(megaWin, top_, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByMegaWinAsync(int megaWin, int top_)
        {
            return await GetByMegaWinAsync(megaWin, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 MegaWin（字段） 查询
        /// </summary>
        /// /// <param name = "megaWin">MEGA WIN中奖倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByMegaWin(int megaWin, int top_, TransactionManager tm_)
        {
            return GetByMegaWin(megaWin, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByMegaWinAsync(int megaWin, int top_, TransactionManager tm_)
        {
            return await GetByMegaWinAsync(megaWin, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 MegaWin（字段） 查询
        /// </summary>
        /// /// <param name = "megaWin">MEGA WIN中奖倍数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByMegaWin(int megaWin, string sort_)
        {
            return GetByMegaWin(megaWin, 0, sort_, null);
        }
        public async Task<List<Gmf_configEO>> GetByMegaWinAsync(int megaWin, string sort_)
        {
            return await GetByMegaWinAsync(megaWin, 0, sort_, null);
        }

        /// <summary>
        /// 按 MegaWin（字段） 查询
        /// </summary>
        /// /// <param name = "megaWin">MEGA WIN中奖倍数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByMegaWin(int megaWin, string sort_, TransactionManager tm_)
        {
            return GetByMegaWin(megaWin, 0, sort_, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByMegaWinAsync(int megaWin, string sort_, TransactionManager tm_)
        {
            return await GetByMegaWinAsync(megaWin, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 MegaWin（字段） 查询
        /// </summary>
        /// /// <param name = "megaWin">MEGA WIN中奖倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByMegaWin(int megaWin, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`MegaWin` = @MegaWin", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@MegaWin", megaWin, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        public async Task<List<Gmf_configEO>> GetByMegaWinAsync(int megaWin, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`MegaWin` = @MegaWin", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@MegaWin", megaWin, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        #endregion // GetByMegaWin
        #region GetBySuperWin

        /// <summary>
        /// 按 SuperWin（字段） 查询
        /// </summary>
        /// /// <param name = "superWin">SUPER WIN中奖倍数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetBySuperWin(int superWin)
        {
            return GetBySuperWin(superWin, 0, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetBySuperWinAsync(int superWin)
        {
            return await GetBySuperWinAsync(superWin, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 SuperWin（字段） 查询
        /// </summary>
        /// /// <param name = "superWin">SUPER WIN中奖倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetBySuperWin(int superWin, TransactionManager tm_)
        {
            return GetBySuperWin(superWin, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetBySuperWinAsync(int superWin, TransactionManager tm_)
        {
            return await GetBySuperWinAsync(superWin, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SuperWin（字段） 查询
        /// </summary>
        /// /// <param name = "superWin">SUPER WIN中奖倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetBySuperWin(int superWin, int top_)
        {
            return GetBySuperWin(superWin, top_, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetBySuperWinAsync(int superWin, int top_)
        {
            return await GetBySuperWinAsync(superWin, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 SuperWin（字段） 查询
        /// </summary>
        /// /// <param name = "superWin">SUPER WIN中奖倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetBySuperWin(int superWin, int top_, TransactionManager tm_)
        {
            return GetBySuperWin(superWin, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetBySuperWinAsync(int superWin, int top_, TransactionManager tm_)
        {
            return await GetBySuperWinAsync(superWin, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SuperWin（字段） 查询
        /// </summary>
        /// /// <param name = "superWin">SUPER WIN中奖倍数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetBySuperWin(int superWin, string sort_)
        {
            return GetBySuperWin(superWin, 0, sort_, null);
        }
        public async Task<List<Gmf_configEO>> GetBySuperWinAsync(int superWin, string sort_)
        {
            return await GetBySuperWinAsync(superWin, 0, sort_, null);
        }

        /// <summary>
        /// 按 SuperWin（字段） 查询
        /// </summary>
        /// /// <param name = "superWin">SUPER WIN中奖倍数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetBySuperWin(int superWin, string sort_, TransactionManager tm_)
        {
            return GetBySuperWin(superWin, 0, sort_, tm_);
        }
        public async Task<List<Gmf_configEO>> GetBySuperWinAsync(int superWin, string sort_, TransactionManager tm_)
        {
            return await GetBySuperWinAsync(superWin, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 SuperWin（字段） 查询
        /// </summary>
        /// /// <param name = "superWin">SUPER WIN中奖倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetBySuperWin(int superWin, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`SuperWin` = @SuperWin", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SuperWin", superWin, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        public async Task<List<Gmf_configEO>> GetBySuperWinAsync(int superWin, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`SuperWin` = @SuperWin", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SuperWin", superWin, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        #endregion // GetBySuperWin
        #region GetByEpicWin

        /// <summary>
        /// 按 EpicWin（字段） 查询
        /// </summary>
        /// /// <param name = "epicWin">EPIC WIN中奖倍数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByEpicWin(int epicWin)
        {
            return GetByEpicWin(epicWin, 0, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByEpicWinAsync(int epicWin)
        {
            return await GetByEpicWinAsync(epicWin, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 EpicWin（字段） 查询
        /// </summary>
        /// /// <param name = "epicWin">EPIC WIN中奖倍数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByEpicWin(int epicWin, TransactionManager tm_)
        {
            return GetByEpicWin(epicWin, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByEpicWinAsync(int epicWin, TransactionManager tm_)
        {
            return await GetByEpicWinAsync(epicWin, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 EpicWin（字段） 查询
        /// </summary>
        /// /// <param name = "epicWin">EPIC WIN中奖倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByEpicWin(int epicWin, int top_)
        {
            return GetByEpicWin(epicWin, top_, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByEpicWinAsync(int epicWin, int top_)
        {
            return await GetByEpicWinAsync(epicWin, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 EpicWin（字段） 查询
        /// </summary>
        /// /// <param name = "epicWin">EPIC WIN中奖倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByEpicWin(int epicWin, int top_, TransactionManager tm_)
        {
            return GetByEpicWin(epicWin, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByEpicWinAsync(int epicWin, int top_, TransactionManager tm_)
        {
            return await GetByEpicWinAsync(epicWin, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 EpicWin（字段） 查询
        /// </summary>
        /// /// <param name = "epicWin">EPIC WIN中奖倍数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByEpicWin(int epicWin, string sort_)
        {
            return GetByEpicWin(epicWin, 0, sort_, null);
        }
        public async Task<List<Gmf_configEO>> GetByEpicWinAsync(int epicWin, string sort_)
        {
            return await GetByEpicWinAsync(epicWin, 0, sort_, null);
        }

        /// <summary>
        /// 按 EpicWin（字段） 查询
        /// </summary>
        /// /// <param name = "epicWin">EPIC WIN中奖倍数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByEpicWin(int epicWin, string sort_, TransactionManager tm_)
        {
            return GetByEpicWin(epicWin, 0, sort_, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByEpicWinAsync(int epicWin, string sort_, TransactionManager tm_)
        {
            return await GetByEpicWinAsync(epicWin, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 EpicWin（字段） 查询
        /// </summary>
        /// /// <param name = "epicWin">EPIC WIN中奖倍数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByEpicWin(int epicWin, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`EpicWin` = @EpicWin", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@EpicWin", epicWin, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        public async Task<List<Gmf_configEO>> GetByEpicWinAsync(int epicWin, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`EpicWin` = @EpicWin", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@EpicWin", epicWin, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        #endregion // GetByEpicWin
        #region GetByBonusTH

        /// <summary>
        /// 按 BonusTH（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTH">bonus阈值</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusTH(float bonusTH)
        {
            return GetByBonusTH(bonusTH, 0, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByBonusTHAsync(float bonusTH)
        {
            return await GetByBonusTHAsync(bonusTH, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusTH（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTH">bonus阈值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusTH(float bonusTH, TransactionManager tm_)
        {
            return GetByBonusTH(bonusTH, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBonusTHAsync(float bonusTH, TransactionManager tm_)
        {
            return await GetByBonusTHAsync(bonusTH, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusTH（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTH">bonus阈值</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusTH(float bonusTH, int top_)
        {
            return GetByBonusTH(bonusTH, top_, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByBonusTHAsync(float bonusTH, int top_)
        {
            return await GetByBonusTHAsync(bonusTH, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusTH（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTH">bonus阈值</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusTH(float bonusTH, int top_, TransactionManager tm_)
        {
            return GetByBonusTH(bonusTH, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBonusTHAsync(float bonusTH, int top_, TransactionManager tm_)
        {
            return await GetByBonusTHAsync(bonusTH, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusTH（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTH">bonus阈值</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusTH(float bonusTH, string sort_)
        {
            return GetByBonusTH(bonusTH, 0, sort_, null);
        }
        public async Task<List<Gmf_configEO>> GetByBonusTHAsync(float bonusTH, string sort_)
        {
            return await GetByBonusTHAsync(bonusTH, 0, sort_, null);
        }

        /// <summary>
        /// 按 BonusTH（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTH">bonus阈值</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusTH(float bonusTH, string sort_, TransactionManager tm_)
        {
            return GetByBonusTH(bonusTH, 0, sort_, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBonusTHAsync(float bonusTH, string sort_, TransactionManager tm_)
        {
            return await GetByBonusTHAsync(bonusTH, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BonusTH（字段） 查询
        /// </summary>
        /// /// <param name = "bonusTH">bonus阈值</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusTH(float bonusTH, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusTH` = @BonusTH", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusTH", bonusTH, MySqlDbType.Float));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        public async Task<List<Gmf_configEO>> GetByBonusTHAsync(float bonusTH, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusTH` = @BonusTH", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusTH", bonusTH, MySqlDbType.Float));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        #endregion // GetByBonusTH
        #region GetByBingoTH

        /// <summary>
        /// 按 BingoTH（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTH">bingo阈值</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBingoTH(float bingoTH)
        {
            return GetByBingoTH(bingoTH, 0, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByBingoTHAsync(float bingoTH)
        {
            return await GetByBingoTHAsync(bingoTH, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoTH（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTH">bingo阈值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBingoTH(float bingoTH, TransactionManager tm_)
        {
            return GetByBingoTH(bingoTH, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBingoTHAsync(float bingoTH, TransactionManager tm_)
        {
            return await GetByBingoTHAsync(bingoTH, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoTH（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTH">bingo阈值</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBingoTH(float bingoTH, int top_)
        {
            return GetByBingoTH(bingoTH, top_, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByBingoTHAsync(float bingoTH, int top_)
        {
            return await GetByBingoTHAsync(bingoTH, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoTH（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTH">bingo阈值</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBingoTH(float bingoTH, int top_, TransactionManager tm_)
        {
            return GetByBingoTH(bingoTH, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBingoTHAsync(float bingoTH, int top_, TransactionManager tm_)
        {
            return await GetByBingoTHAsync(bingoTH, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoTH（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTH">bingo阈值</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBingoTH(float bingoTH, string sort_)
        {
            return GetByBingoTH(bingoTH, 0, sort_, null);
        }
        public async Task<List<Gmf_configEO>> GetByBingoTHAsync(float bingoTH, string sort_)
        {
            return await GetByBingoTHAsync(bingoTH, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoTH（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTH">bingo阈值</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBingoTH(float bingoTH, string sort_, TransactionManager tm_)
        {
            return GetByBingoTH(bingoTH, 0, sort_, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBingoTHAsync(float bingoTH, string sort_, TransactionManager tm_)
        {
            return await GetByBingoTHAsync(bingoTH, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoTH（字段） 查询
        /// </summary>
        /// /// <param name = "bingoTH">bingo阈值</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBingoTH(float bingoTH, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoTH` = @BingoTH", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoTH", bingoTH, MySqlDbType.Float));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        public async Task<List<Gmf_configEO>> GetByBingoTHAsync(float bingoTH, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoTH` = @BingoTH", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoTH", bingoTH, MySqlDbType.Float));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        #endregion // GetByBingoTH
        #region GetByBingoPerValue

        /// <summary>
        /// 按 BingoPerValue（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPerValue">Bingo固定价值</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBingoPerValue(float bingoPerValue)
        {
            return GetByBingoPerValue(bingoPerValue, 0, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByBingoPerValueAsync(float bingoPerValue)
        {
            return await GetByBingoPerValueAsync(bingoPerValue, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoPerValue（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPerValue">Bingo固定价值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBingoPerValue(float bingoPerValue, TransactionManager tm_)
        {
            return GetByBingoPerValue(bingoPerValue, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBingoPerValueAsync(float bingoPerValue, TransactionManager tm_)
        {
            return await GetByBingoPerValueAsync(bingoPerValue, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoPerValue（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPerValue">Bingo固定价值</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBingoPerValue(float bingoPerValue, int top_)
        {
            return GetByBingoPerValue(bingoPerValue, top_, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByBingoPerValueAsync(float bingoPerValue, int top_)
        {
            return await GetByBingoPerValueAsync(bingoPerValue, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BingoPerValue（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPerValue">Bingo固定价值</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBingoPerValue(float bingoPerValue, int top_, TransactionManager tm_)
        {
            return GetByBingoPerValue(bingoPerValue, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBingoPerValueAsync(float bingoPerValue, int top_, TransactionManager tm_)
        {
            return await GetByBingoPerValueAsync(bingoPerValue, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BingoPerValue（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPerValue">Bingo固定价值</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBingoPerValue(float bingoPerValue, string sort_)
        {
            return GetByBingoPerValue(bingoPerValue, 0, sort_, null);
        }
        public async Task<List<Gmf_configEO>> GetByBingoPerValueAsync(float bingoPerValue, string sort_)
        {
            return await GetByBingoPerValueAsync(bingoPerValue, 0, sort_, null);
        }

        /// <summary>
        /// 按 BingoPerValue（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPerValue">Bingo固定价值</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBingoPerValue(float bingoPerValue, string sort_, TransactionManager tm_)
        {
            return GetByBingoPerValue(bingoPerValue, 0, sort_, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBingoPerValueAsync(float bingoPerValue, string sort_, TransactionManager tm_)
        {
            return await GetByBingoPerValueAsync(bingoPerValue, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BingoPerValue（字段） 查询
        /// </summary>
        /// /// <param name = "bingoPerValue">Bingo固定价值</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBingoPerValue(float bingoPerValue, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoPerValue` = @BingoPerValue", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoPerValue", bingoPerValue, MySqlDbType.Float));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        public async Task<List<Gmf_configEO>> GetByBingoPerValueAsync(float bingoPerValue, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BingoPerValue` = @BingoPerValue", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BingoPerValue", bingoPerValue, MySqlDbType.Float));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        #endregion // GetByBingoPerValue
        #region GetByPartBaseRatio

        /// <summary>
        /// 按 PartBaseRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBaseRatio">BaseName模块分配比例</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBaseRatio(float partBaseRatio)
        {
            return GetByPartBaseRatio(partBaseRatio, 0, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByPartBaseRatioAsync(float partBaseRatio)
        {
            return await GetByPartBaseRatioAsync(partBaseRatio, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PartBaseRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBaseRatio">BaseName模块分配比例</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBaseRatio(float partBaseRatio, TransactionManager tm_)
        {
            return GetByPartBaseRatio(partBaseRatio, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByPartBaseRatioAsync(float partBaseRatio, TransactionManager tm_)
        {
            return await GetByPartBaseRatioAsync(partBaseRatio, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 PartBaseRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBaseRatio">BaseName模块分配比例</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBaseRatio(float partBaseRatio, int top_)
        {
            return GetByPartBaseRatio(partBaseRatio, top_, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByPartBaseRatioAsync(float partBaseRatio, int top_)
        {
            return await GetByPartBaseRatioAsync(partBaseRatio, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 PartBaseRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBaseRatio">BaseName模块分配比例</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBaseRatio(float partBaseRatio, int top_, TransactionManager tm_)
        {
            return GetByPartBaseRatio(partBaseRatio, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByPartBaseRatioAsync(float partBaseRatio, int top_, TransactionManager tm_)
        {
            return await GetByPartBaseRatioAsync(partBaseRatio, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 PartBaseRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBaseRatio">BaseName模块分配比例</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBaseRatio(float partBaseRatio, string sort_)
        {
            return GetByPartBaseRatio(partBaseRatio, 0, sort_, null);
        }
        public async Task<List<Gmf_configEO>> GetByPartBaseRatioAsync(float partBaseRatio, string sort_)
        {
            return await GetByPartBaseRatioAsync(partBaseRatio, 0, sort_, null);
        }

        /// <summary>
        /// 按 PartBaseRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBaseRatio">BaseName模块分配比例</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBaseRatio(float partBaseRatio, string sort_, TransactionManager tm_)
        {
            return GetByPartBaseRatio(partBaseRatio, 0, sort_, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByPartBaseRatioAsync(float partBaseRatio, string sort_, TransactionManager tm_)
        {
            return await GetByPartBaseRatioAsync(partBaseRatio, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 PartBaseRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBaseRatio">BaseName模块分配比例</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBaseRatio(float partBaseRatio, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`PartBaseRatio` = @PartBaseRatio", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBaseRatio", partBaseRatio, MySqlDbType.Float));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        public async Task<List<Gmf_configEO>> GetByPartBaseRatioAsync(float partBaseRatio, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`PartBaseRatio` = @PartBaseRatio", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBaseRatio", partBaseRatio, MySqlDbType.Float));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        #endregion // GetByPartBaseRatio
        #region GetByPartBonusRatio

        /// <summary>
        /// 按 PartBonusRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBonusRatio">Bonus模块分配比例</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBonusRatio(float partBonusRatio)
        {
            return GetByPartBonusRatio(partBonusRatio, 0, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByPartBonusRatioAsync(float partBonusRatio)
        {
            return await GetByPartBonusRatioAsync(partBonusRatio, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PartBonusRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBonusRatio">Bonus模块分配比例</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBonusRatio(float partBonusRatio, TransactionManager tm_)
        {
            return GetByPartBonusRatio(partBonusRatio, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByPartBonusRatioAsync(float partBonusRatio, TransactionManager tm_)
        {
            return await GetByPartBonusRatioAsync(partBonusRatio, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 PartBonusRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBonusRatio">Bonus模块分配比例</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBonusRatio(float partBonusRatio, int top_)
        {
            return GetByPartBonusRatio(partBonusRatio, top_, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByPartBonusRatioAsync(float partBonusRatio, int top_)
        {
            return await GetByPartBonusRatioAsync(partBonusRatio, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 PartBonusRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBonusRatio">Bonus模块分配比例</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBonusRatio(float partBonusRatio, int top_, TransactionManager tm_)
        {
            return GetByPartBonusRatio(partBonusRatio, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByPartBonusRatioAsync(float partBonusRatio, int top_, TransactionManager tm_)
        {
            return await GetByPartBonusRatioAsync(partBonusRatio, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 PartBonusRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBonusRatio">Bonus模块分配比例</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBonusRatio(float partBonusRatio, string sort_)
        {
            return GetByPartBonusRatio(partBonusRatio, 0, sort_, null);
        }
        public async Task<List<Gmf_configEO>> GetByPartBonusRatioAsync(float partBonusRatio, string sort_)
        {
            return await GetByPartBonusRatioAsync(partBonusRatio, 0, sort_, null);
        }

        /// <summary>
        /// 按 PartBonusRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBonusRatio">Bonus模块分配比例</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBonusRatio(float partBonusRatio, string sort_, TransactionManager tm_)
        {
            return GetByPartBonusRatio(partBonusRatio, 0, sort_, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByPartBonusRatioAsync(float partBonusRatio, string sort_, TransactionManager tm_)
        {
            return await GetByPartBonusRatioAsync(partBonusRatio, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 PartBonusRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBonusRatio">Bonus模块分配比例</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBonusRatio(float partBonusRatio, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`PartBonusRatio` = @PartBonusRatio", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBonusRatio", partBonusRatio, MySqlDbType.Float));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        public async Task<List<Gmf_configEO>> GetByPartBonusRatioAsync(float partBonusRatio, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`PartBonusRatio` = @PartBonusRatio", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBonusRatio", partBonusRatio, MySqlDbType.Float));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        #endregion // GetByPartBonusRatio
        #region GetByPartBingoRatio

        /// <summary>
        /// 按 PartBingoRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBingoRatio">bingo模块分配比例</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBingoRatio(float partBingoRatio)
        {
            return GetByPartBingoRatio(partBingoRatio, 0, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByPartBingoRatioAsync(float partBingoRatio)
        {
            return await GetByPartBingoRatioAsync(partBingoRatio, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PartBingoRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBingoRatio">bingo模块分配比例</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBingoRatio(float partBingoRatio, TransactionManager tm_)
        {
            return GetByPartBingoRatio(partBingoRatio, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByPartBingoRatioAsync(float partBingoRatio, TransactionManager tm_)
        {
            return await GetByPartBingoRatioAsync(partBingoRatio, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 PartBingoRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBingoRatio">bingo模块分配比例</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBingoRatio(float partBingoRatio, int top_)
        {
            return GetByPartBingoRatio(partBingoRatio, top_, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByPartBingoRatioAsync(float partBingoRatio, int top_)
        {
            return await GetByPartBingoRatioAsync(partBingoRatio, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 PartBingoRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBingoRatio">bingo模块分配比例</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBingoRatio(float partBingoRatio, int top_, TransactionManager tm_)
        {
            return GetByPartBingoRatio(partBingoRatio, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByPartBingoRatioAsync(float partBingoRatio, int top_, TransactionManager tm_)
        {
            return await GetByPartBingoRatioAsync(partBingoRatio, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 PartBingoRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBingoRatio">bingo模块分配比例</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBingoRatio(float partBingoRatio, string sort_)
        {
            return GetByPartBingoRatio(partBingoRatio, 0, sort_, null);
        }
        public async Task<List<Gmf_configEO>> GetByPartBingoRatioAsync(float partBingoRatio, string sort_)
        {
            return await GetByPartBingoRatioAsync(partBingoRatio, 0, sort_, null);
        }

        /// <summary>
        /// 按 PartBingoRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBingoRatio">bingo模块分配比例</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBingoRatio(float partBingoRatio, string sort_, TransactionManager tm_)
        {
            return GetByPartBingoRatio(partBingoRatio, 0, sort_, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByPartBingoRatioAsync(float partBingoRatio, string sort_, TransactionManager tm_)
        {
            return await GetByPartBingoRatioAsync(partBingoRatio, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 PartBingoRatio（字段） 查询
        /// </summary>
        /// /// <param name = "partBingoRatio">bingo模块分配比例</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByPartBingoRatio(float partBingoRatio, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`PartBingoRatio` = @PartBingoRatio", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBingoRatio", partBingoRatio, MySqlDbType.Float));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        public async Task<List<Gmf_configEO>> GetByPartBingoRatioAsync(float partBingoRatio, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`PartBingoRatio` = @PartBingoRatio", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@PartBingoRatio", partBingoRatio, MySqlDbType.Float));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        #endregion // GetByPartBingoRatio
        #region GetByBonusRetriggerRatio

        /// <summary>
        /// 按 BonusRetriggerRatio（字段） 查询
        /// </summary>
        /// /// <param name = "bonusRetriggerRatio">bonus时分配超10倍部分分配给retrigger比率</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusRetriggerRatio(float bonusRetriggerRatio)
        {
            return GetByBonusRetriggerRatio(bonusRetriggerRatio, 0, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByBonusRetriggerRatioAsync(float bonusRetriggerRatio)
        {
            return await GetByBonusRetriggerRatioAsync(bonusRetriggerRatio, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusRetriggerRatio（字段） 查询
        /// </summary>
        /// /// <param name = "bonusRetriggerRatio">bonus时分配超10倍部分分配给retrigger比率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusRetriggerRatio(float bonusRetriggerRatio, TransactionManager tm_)
        {
            return GetByBonusRetriggerRatio(bonusRetriggerRatio, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBonusRetriggerRatioAsync(float bonusRetriggerRatio, TransactionManager tm_)
        {
            return await GetByBonusRetriggerRatioAsync(bonusRetriggerRatio, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusRetriggerRatio（字段） 查询
        /// </summary>
        /// /// <param name = "bonusRetriggerRatio">bonus时分配超10倍部分分配给retrigger比率</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusRetriggerRatio(float bonusRetriggerRatio, int top_)
        {
            return GetByBonusRetriggerRatio(bonusRetriggerRatio, top_, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByBonusRetriggerRatioAsync(float bonusRetriggerRatio, int top_)
        {
            return await GetByBonusRetriggerRatioAsync(bonusRetriggerRatio, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusRetriggerRatio（字段） 查询
        /// </summary>
        /// /// <param name = "bonusRetriggerRatio">bonus时分配超10倍部分分配给retrigger比率</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusRetriggerRatio(float bonusRetriggerRatio, int top_, TransactionManager tm_)
        {
            return GetByBonusRetriggerRatio(bonusRetriggerRatio, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBonusRetriggerRatioAsync(float bonusRetriggerRatio, int top_, TransactionManager tm_)
        {
            return await GetByBonusRetriggerRatioAsync(bonusRetriggerRatio, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusRetriggerRatio（字段） 查询
        /// </summary>
        /// /// <param name = "bonusRetriggerRatio">bonus时分配超10倍部分分配给retrigger比率</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusRetriggerRatio(float bonusRetriggerRatio, string sort_)
        {
            return GetByBonusRetriggerRatio(bonusRetriggerRatio, 0, sort_, null);
        }
        public async Task<List<Gmf_configEO>> GetByBonusRetriggerRatioAsync(float bonusRetriggerRatio, string sort_)
        {
            return await GetByBonusRetriggerRatioAsync(bonusRetriggerRatio, 0, sort_, null);
        }

        /// <summary>
        /// 按 BonusRetriggerRatio（字段） 查询
        /// </summary>
        /// /// <param name = "bonusRetriggerRatio">bonus时分配超10倍部分分配给retrigger比率</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusRetriggerRatio(float bonusRetriggerRatio, string sort_, TransactionManager tm_)
        {
            return GetByBonusRetriggerRatio(bonusRetriggerRatio, 0, sort_, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBonusRetriggerRatioAsync(float bonusRetriggerRatio, string sort_, TransactionManager tm_)
        {
            return await GetByBonusRetriggerRatioAsync(bonusRetriggerRatio, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BonusRetriggerRatio（字段） 查询
        /// </summary>
        /// /// <param name = "bonusRetriggerRatio">bonus时分配超10倍部分分配给retrigger比率</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusRetriggerRatio(float bonusRetriggerRatio, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusRetriggerRatio` = @BonusRetriggerRatio", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusRetriggerRatio", bonusRetriggerRatio, MySqlDbType.Float));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        public async Task<List<Gmf_configEO>> GetByBonusRetriggerRatioAsync(float bonusRetriggerRatio, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusRetriggerRatio` = @BonusRetriggerRatio", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusRetriggerRatio", bonusRetriggerRatio, MySqlDbType.Float));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        #endregion // GetByBonusRetriggerRatio
        #region GetByBonusBigoRatio

        /// <summary>
        /// 按 BonusBigoRatio（字段） 查询
        /// </summary>
        /// /// <param name = "bonusBigoRatio">bonus时分配超10倍部分分配给bingo比率</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusBigoRatio(float bonusBigoRatio)
        {
            return GetByBonusBigoRatio(bonusBigoRatio, 0, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByBonusBigoRatioAsync(float bonusBigoRatio)
        {
            return await GetByBonusBigoRatioAsync(bonusBigoRatio, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusBigoRatio（字段） 查询
        /// </summary>
        /// /// <param name = "bonusBigoRatio">bonus时分配超10倍部分分配给bingo比率</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusBigoRatio(float bonusBigoRatio, TransactionManager tm_)
        {
            return GetByBonusBigoRatio(bonusBigoRatio, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBonusBigoRatioAsync(float bonusBigoRatio, TransactionManager tm_)
        {
            return await GetByBonusBigoRatioAsync(bonusBigoRatio, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusBigoRatio（字段） 查询
        /// </summary>
        /// /// <param name = "bonusBigoRatio">bonus时分配超10倍部分分配给bingo比率</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusBigoRatio(float bonusBigoRatio, int top_)
        {
            return GetByBonusBigoRatio(bonusBigoRatio, top_, string.Empty, null);
        }
        public async Task<List<Gmf_configEO>> GetByBonusBigoRatioAsync(float bonusBigoRatio, int top_)
        {
            return await GetByBonusBigoRatioAsync(bonusBigoRatio, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 BonusBigoRatio（字段） 查询
        /// </summary>
        /// /// <param name = "bonusBigoRatio">bonus时分配超10倍部分分配给bingo比率</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusBigoRatio(float bonusBigoRatio, int top_, TransactionManager tm_)
        {
            return GetByBonusBigoRatio(bonusBigoRatio, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBonusBigoRatioAsync(float bonusBigoRatio, int top_, TransactionManager tm_)
        {
            return await GetByBonusBigoRatioAsync(bonusBigoRatio, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 BonusBigoRatio（字段） 查询
        /// </summary>
        /// /// <param name = "bonusBigoRatio">bonus时分配超10倍部分分配给bingo比率</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusBigoRatio(float bonusBigoRatio, string sort_)
        {
            return GetByBonusBigoRatio(bonusBigoRatio, 0, sort_, null);
        }
        public async Task<List<Gmf_configEO>> GetByBonusBigoRatioAsync(float bonusBigoRatio, string sort_)
        {
            return await GetByBonusBigoRatioAsync(bonusBigoRatio, 0, sort_, null);
        }

        /// <summary>
        /// 按 BonusBigoRatio（字段） 查询
        /// </summary>
        /// /// <param name = "bonusBigoRatio">bonus时分配超10倍部分分配给bingo比率</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusBigoRatio(float bonusBigoRatio, string sort_, TransactionManager tm_)
        {
            return GetByBonusBigoRatio(bonusBigoRatio, 0, sort_, tm_);
        }
        public async Task<List<Gmf_configEO>> GetByBonusBigoRatioAsync(float bonusBigoRatio, string sort_, TransactionManager tm_)
        {
            return await GetByBonusBigoRatioAsync(bonusBigoRatio, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 BonusBigoRatio（字段） 查询
        /// </summary>
        /// /// <param name = "bonusBigoRatio">bonus时分配超10倍部分分配给bingo比率</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_configEO> GetByBonusBigoRatio(float bonusBigoRatio, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusBigoRatio` = @BonusBigoRatio", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusBigoRatio", bonusBigoRatio, MySqlDbType.Float));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        public async Task<List<Gmf_configEO>> GetByBonusBigoRatioAsync(float bonusBigoRatio, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`BonusBigoRatio` = @BonusBigoRatio", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@BonusBigoRatio", bonusBigoRatio, MySqlDbType.Float));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_configEO.MapDataReader);
        }
        #endregion // GetByBonusBigoRatio
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
