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
    /// symbol定义
    /// 【表 gmf_symbol 的实体类】
    /// </summary>
    [DataContract]
    public class Gmf_symbolEO : IRowMapper<Gmf_symbolEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Gmf_symbolEO()
        {
            this.Type = 0;
            this.IsNormal = false;
            this.IsWild = false;
            this.IsBonus = false;
            this.IsBingo = false;
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private int _originalSymbolID;
        /// <summary>
        /// 【数据库中的原始主键 SymbolID 值的副本，用于主键值更新】
        /// </summary>
        public int OriginalSymbolID
        {
            get { return _originalSymbolID; }
            set { HasOriginal = true; _originalSymbolID = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "SymbolID", SymbolID }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// Symbol编码
        /// 【主键 tinyint】
        /// </summary>
        [DataMember(Order = 1)]
        public int SymbolID { get; set; }
        /// <summary>
        /// 名称
        /// 【字段 varchar(20)】
        /// </summary>
        [DataMember(Order = 2)]
        public string Name { get; set; }
        /// <summary>
        /// 1-normal,2-wild,3-bonus 4-bingo 5-andFreeSpin
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 3)]
        public int Type { get; set; }
        /// <summary>
        /// 是否普通Symbol
        /// 【字段 tinyint(1)】
        /// </summary>
        [DataMember(Order = 4)]
        public bool IsNormal { get; set; }
        /// <summary>
        /// 
        /// 【字段 tinyint(1)】
        /// </summary>
        [DataMember(Order = 5)]
        public bool IsWild { get; set; }
        /// <summary>
        /// 
        /// 【字段 tinyint(1)】
        /// </summary>
        [DataMember(Order = 6)]
        public bool IsBonus { get; set; }
        /// <summary>
        /// 
        /// 【字段 tinyint(1)】
        /// </summary>
        [DataMember(Order = 7)]
        public bool IsBingo { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public Gmf_symbolEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static Gmf_symbolEO MapDataReader(IDataReader reader)
        {
            Gmf_symbolEO ret = new Gmf_symbolEO();
            ret.SymbolID = reader.ToInt32("SymbolID");
            ret.OriginalSymbolID = ret.SymbolID;
            ret.Name = reader.ToString("Name");
            ret.Type = reader.ToInt32("Type");
            ret.IsNormal = reader.ToBoolean("IsNormal");
            ret.IsWild = reader.ToBoolean("IsWild");
            ret.IsBonus = reader.ToBoolean("IsBonus");
            ret.IsBingo = reader.ToBoolean("IsBingo");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// symbol定义
    /// 【表 gmf_symbol 的操作类】
    /// </summary>
    public class Gmf_symbolMO : MySqlTableMO<Gmf_symbolEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`gmf_symbol`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public Gmf_symbolMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public Gmf_symbolMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public Gmf_symbolMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(Gmf_symbolEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(Gmf_symbolEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(Gmf_symbolEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`SymbolID`, `Name`, `Type`, `IsNormal`, `IsWild`, `IsBonus`, `IsBingo`) VALUE (@SymbolID, @Name, @Type, @IsNormal, @IsWild, @IsBonus, @IsBingo);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", item.SymbolID, MySqlDbType.Byte),
                Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@Type", item.Type, MySqlDbType.Int32),
                Database.CreateInParameter("@IsNormal", item.IsNormal, MySqlDbType.Byte),
                Database.CreateInParameter("@IsWild", item.IsWild, MySqlDbType.Byte),
                Database.CreateInParameter("@IsBonus", item.IsBonus, MySqlDbType.Byte),
                Database.CreateInParameter("@IsBingo", item.IsBingo, MySqlDbType.Byte),
            };
        }
        public int AddByBatch(IEnumerable<Gmf_symbolEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<Gmf_symbolEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gmf_symbolEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`SymbolID`, `Name`, `Type`, `IsNormal`, `IsWild`, `IsBonus`, `IsBingo`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"({item.SymbolID},'{item.Name}',{item.Type},{item.IsNormal},{item.IsWild},{item.IsBonus},{item.IsBingo}),");
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
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(int symbolID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(symbolID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(int symbolID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(symbolID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(int symbolID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `SymbolID` = @SymbolID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(Gmf_symbolEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.SymbolID, tm_);
        }
        public async Task<int> RemoveAsync(Gmf_symbolEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.SymbolID, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
        #region RemoveByName
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByName(string name, TransactionManager tm_ = null)
        {
            RepairRemoveByNameData(name, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByNameAsync(string name, TransactionManager tm_ = null)
        {
            RepairRemoveByNameData(name, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByNameData(string name, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (name != null ? "`Name` = @Name" : "`Name` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (name != null)
                paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
        }
        #endregion // RemoveByName
        #region RemoveByType
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "type">1-normal,2-wild,3-bonus 4-bingo 5-andFreeSpin</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByType(int type, TransactionManager tm_ = null)
        {
            RepairRemoveByTypeData(type, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByTypeAsync(int type, TransactionManager tm_ = null)
        {
            RepairRemoveByTypeData(type, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByTypeData(int type, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `Type` = @Type";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Type", type, MySqlDbType.Int32));
        }
        #endregion // RemoveByType
        #region RemoveByIsNormal
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "isNormal">是否普通Symbol</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByIsNormal(bool isNormal, TransactionManager tm_ = null)
        {
            RepairRemoveByIsNormalData(isNormal, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByIsNormalAsync(bool isNormal, TransactionManager tm_ = null)
        {
            RepairRemoveByIsNormalData(isNormal, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByIsNormalData(bool isNormal, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `IsNormal` = @IsNormal";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IsNormal", isNormal, MySqlDbType.Byte));
        }
        #endregion // RemoveByIsNormal
        #region RemoveByIsWild
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "isWild"></param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByIsWild(bool isWild, TransactionManager tm_ = null)
        {
            RepairRemoveByIsWildData(isWild, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByIsWildAsync(bool isWild, TransactionManager tm_ = null)
        {
            RepairRemoveByIsWildData(isWild, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByIsWildData(bool isWild, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `IsWild` = @IsWild";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IsWild", isWild, MySqlDbType.Byte));
        }
        #endregion // RemoveByIsWild
        #region RemoveByIsBonus
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "isBonus"></param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByIsBonus(bool isBonus, TransactionManager tm_ = null)
        {
            RepairRemoveByIsBonusData(isBonus, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByIsBonusAsync(bool isBonus, TransactionManager tm_ = null)
        {
            RepairRemoveByIsBonusData(isBonus, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByIsBonusData(bool isBonus, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `IsBonus` = @IsBonus";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IsBonus", isBonus, MySqlDbType.Byte));
        }
        #endregion // RemoveByIsBonus
        #region RemoveByIsBingo
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "isBingo"></param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByIsBingo(bool isBingo, TransactionManager tm_ = null)
        {
            RepairRemoveByIsBingoData(isBingo, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByIsBingoAsync(bool isBingo, TransactionManager tm_ = null)
        {
            RepairRemoveByIsBingoData(isBingo, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByIsBingoData(bool isBingo, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `IsBingo` = @IsBingo";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IsBingo", isBingo, MySqlDbType.Byte));
        }
        #endregion // RemoveByIsBingo
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
        public int Put(Gmf_symbolEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(Gmf_symbolEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(Gmf_symbolEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `SymbolID` = @SymbolID, `Name` = @Name, `Type` = @Type, `IsNormal` = @IsNormal, `IsWild` = @IsWild, `IsBonus` = @IsBonus, `IsBingo` = @IsBingo WHERE `SymbolID` = @SymbolID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", item.SymbolID, MySqlDbType.Byte),
                Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@Type", item.Type, MySqlDbType.Int32),
                Database.CreateInParameter("@IsNormal", item.IsNormal, MySqlDbType.Byte),
                Database.CreateInParameter("@IsWild", item.IsWild, MySqlDbType.Byte),
                Database.CreateInParameter("@IsBonus", item.IsBonus, MySqlDbType.Byte),
                Database.CreateInParameter("@IsBingo", item.IsBingo, MySqlDbType.Byte),
                Database.CreateInParameter("@SymbolID_Original", item.HasOriginal ? item.OriginalSymbolID : item.SymbolID, MySqlDbType.Byte),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<Gmf_symbolEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<Gmf_symbolEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int symbolID, string set_, params object[] values_)
        {
            return Put(set_, "`SymbolID` = @SymbolID", ConcatValues(values_, symbolID));
        }
        public async Task<int> PutByPKAsync(int symbolID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`SymbolID` = @SymbolID", ConcatValues(values_, symbolID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int symbolID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`SymbolID` = @SymbolID", tm_, ConcatValues(values_, symbolID));
        }
        public async Task<int> PutByPKAsync(int symbolID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`SymbolID` = @SymbolID", tm_, ConcatValues(values_, symbolID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(int symbolID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
            return Put(set_, "`SymbolID` = @SymbolID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(int symbolID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
            return await PutAsync(set_, "`SymbolID` = @SymbolID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutName
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// /// <param name = "name">名称</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutNameByPK(int symbolID, string name, TransactionManager tm_ = null)
        {
            RepairPutNameByPKData(symbolID, name, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutNameByPKAsync(int symbolID, string name, TransactionManager tm_ = null)
        {
            RepairPutNameByPKData(symbolID, name, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutNameByPKData(int symbolID, string name, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Name` = @Name  WHERE `SymbolID` = @SymbolID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutName(string name, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Name` = @Name";
            var parameter_ = Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutNameAsync(string name, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Name` = @Name";
            var parameter_ = Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutName
        #region PutType
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// /// <param name = "type">1-normal,2-wild,3-bonus 4-bingo 5-andFreeSpin</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutTypeByPK(int symbolID, int type, TransactionManager tm_ = null)
        {
            RepairPutTypeByPKData(symbolID, type, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutTypeByPKAsync(int symbolID, int type, TransactionManager tm_ = null)
        {
            RepairPutTypeByPKData(symbolID, type, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutTypeByPKData(int symbolID, int type, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `Type` = @Type  WHERE `SymbolID` = @SymbolID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@Type", type, MySqlDbType.Int32),
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "type">1-normal,2-wild,3-bonus 4-bingo 5-andFreeSpin</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutType(int type, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Type` = @Type";
            var parameter_ = Database.CreateInParameter("@Type", type, MySqlDbType.Int32);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutTypeAsync(int type, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `Type` = @Type";
            var parameter_ = Database.CreateInParameter("@Type", type, MySqlDbType.Int32);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutType
        #region PutIsNormal
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// /// <param name = "isNormal">是否普通Symbol</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutIsNormalByPK(int symbolID, bool isNormal, TransactionManager tm_ = null)
        {
            RepairPutIsNormalByPKData(symbolID, isNormal, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutIsNormalByPKAsync(int symbolID, bool isNormal, TransactionManager tm_ = null)
        {
            RepairPutIsNormalByPKData(symbolID, isNormal, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutIsNormalByPKData(int symbolID, bool isNormal, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `IsNormal` = @IsNormal  WHERE `SymbolID` = @SymbolID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@IsNormal", isNormal, MySqlDbType.Byte),
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "isNormal">是否普通Symbol</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutIsNormal(bool isNormal, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `IsNormal` = @IsNormal";
            var parameter_ = Database.CreateInParameter("@IsNormal", isNormal, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutIsNormalAsync(bool isNormal, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `IsNormal` = @IsNormal";
            var parameter_ = Database.CreateInParameter("@IsNormal", isNormal, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutIsNormal
        #region PutIsWild
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// /// <param name = "isWild"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutIsWildByPK(int symbolID, bool isWild, TransactionManager tm_ = null)
        {
            RepairPutIsWildByPKData(symbolID, isWild, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutIsWildByPKAsync(int symbolID, bool isWild, TransactionManager tm_ = null)
        {
            RepairPutIsWildByPKData(symbolID, isWild, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutIsWildByPKData(int symbolID, bool isWild, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `IsWild` = @IsWild  WHERE `SymbolID` = @SymbolID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@IsWild", isWild, MySqlDbType.Byte),
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "isWild"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutIsWild(bool isWild, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `IsWild` = @IsWild";
            var parameter_ = Database.CreateInParameter("@IsWild", isWild, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutIsWildAsync(bool isWild, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `IsWild` = @IsWild";
            var parameter_ = Database.CreateInParameter("@IsWild", isWild, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutIsWild
        #region PutIsBonus
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// /// <param name = "isBonus"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutIsBonusByPK(int symbolID, bool isBonus, TransactionManager tm_ = null)
        {
            RepairPutIsBonusByPKData(symbolID, isBonus, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutIsBonusByPKAsync(int symbolID, bool isBonus, TransactionManager tm_ = null)
        {
            RepairPutIsBonusByPKData(symbolID, isBonus, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutIsBonusByPKData(int symbolID, bool isBonus, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `IsBonus` = @IsBonus  WHERE `SymbolID` = @SymbolID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@IsBonus", isBonus, MySqlDbType.Byte),
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "isBonus"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutIsBonus(bool isBonus, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `IsBonus` = @IsBonus";
            var parameter_ = Database.CreateInParameter("@IsBonus", isBonus, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutIsBonusAsync(bool isBonus, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `IsBonus` = @IsBonus";
            var parameter_ = Database.CreateInParameter("@IsBonus", isBonus, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutIsBonus
        #region PutIsBingo
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// /// <param name = "isBingo"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutIsBingoByPK(int symbolID, bool isBingo, TransactionManager tm_ = null)
        {
            RepairPutIsBingoByPKData(symbolID, isBingo, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutIsBingoByPKAsync(int symbolID, bool isBingo, TransactionManager tm_ = null)
        {
            RepairPutIsBingoByPKData(symbolID, isBingo, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutIsBingoByPKData(int symbolID, bool isBingo, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `IsBingo` = @IsBingo  WHERE `SymbolID` = @SymbolID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@IsBingo", isBingo, MySqlDbType.Byte),
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "isBingo"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutIsBingo(bool isBingo, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `IsBingo` = @IsBingo";
            var parameter_ = Database.CreateInParameter("@IsBingo", isBingo, MySqlDbType.Byte);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutIsBingoAsync(bool isBingo, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `IsBingo` = @IsBingo";
            var parameter_ = Database.CreateInParameter("@IsBingo", isBingo, MySqlDbType.Byte);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutIsBingo
        #endregion // PutXXX
        #endregion // Put

        #region Set

        /// <summary>
        /// 插入或者更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>true:插入操作；false:更新操作</return>
        public bool Set(Gmf_symbolEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.SymbolID) == null)
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
        public async Task<bool> SetAsync(Gmf_symbolEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.SymbolID) == null)
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
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public Gmf_symbolEO GetByPK(int symbolID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(symbolID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, Gmf_symbolEO.MapDataReader);
        }
        public async Task<Gmf_symbolEO> GetByPKAsync(int symbolID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(symbolID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gmf_symbolEO.MapDataReader);
        }
        private void RepairGetByPKData(int symbolID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`SymbolID` = @SymbolID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 Name（字段）
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetNameByPK(int symbolID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
            return (string)GetScalar("`Name`", "`SymbolID` = @SymbolID", paras_, tm_);
        }
        public async Task<string> GetNameByPKAsync(int symbolID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
            return (string)await GetScalarAsync("`Name`", "`SymbolID` = @SymbolID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 Type（字段）
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetTypeByPK(int symbolID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
            return (int)GetScalar("`Type`", "`SymbolID` = @SymbolID", paras_, tm_);
        }
        public async Task<int> GetTypeByPKAsync(int symbolID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
            return (int)await GetScalarAsync("`Type`", "`SymbolID` = @SymbolID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 IsNormal（字段）
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public bool GetIsNormalByPK(int symbolID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
            return (bool)GetScalar("`IsNormal`", "`SymbolID` = @SymbolID", paras_, tm_);
        }
        public async Task<bool> GetIsNormalByPKAsync(int symbolID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
            return (bool)await GetScalarAsync("`IsNormal`", "`SymbolID` = @SymbolID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 IsWild（字段）
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public bool GetIsWildByPK(int symbolID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
            return (bool)GetScalar("`IsWild`", "`SymbolID` = @SymbolID", paras_, tm_);
        }
        public async Task<bool> GetIsWildByPKAsync(int symbolID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
            return (bool)await GetScalarAsync("`IsWild`", "`SymbolID` = @SymbolID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 IsBonus（字段）
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public bool GetIsBonusByPK(int symbolID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
            return (bool)GetScalar("`IsBonus`", "`SymbolID` = @SymbolID", paras_, tm_);
        }
        public async Task<bool> GetIsBonusByPKAsync(int symbolID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
            return (bool)await GetScalarAsync("`IsBonus`", "`SymbolID` = @SymbolID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 IsBingo（字段）
        /// </summary>
        /// /// <param name = "symbolID">Symbol编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public bool GetIsBingoByPK(int symbolID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
            return (bool)GetScalar("`IsBingo`", "`SymbolID` = @SymbolID", paras_, tm_);
        }
        public async Task<bool> GetIsBingoByPKAsync(int symbolID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Byte),
            };
            return (bool)await GetScalarAsync("`IsBingo`", "`SymbolID` = @SymbolID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByName

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByName(string name)
        {
            return GetByName(name, 0, string.Empty, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByNameAsync(string name)
        {
            return await GetByNameAsync(name, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByName(string name, TransactionManager tm_)
        {
            return GetByName(name, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByNameAsync(string name, TransactionManager tm_)
        {
            return await GetByNameAsync(name, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByName(string name, int top_)
        {
            return GetByName(name, top_, string.Empty, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByNameAsync(string name, int top_)
        {
            return await GetByNameAsync(name, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByName(string name, int top_, TransactionManager tm_)
        {
            return GetByName(name, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByNameAsync(string name, int top_, TransactionManager tm_)
        {
            return await GetByNameAsync(name, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByName(string name, string sort_)
        {
            return GetByName(name, 0, sort_, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByNameAsync(string name, string sort_)
        {
            return await GetByNameAsync(name, 0, sort_, null);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByName(string name, string sort_, TransactionManager tm_)
        {
            return GetByName(name, 0, sort_, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByNameAsync(string name, string sort_, TransactionManager tm_)
        {
            return await GetByNameAsync(name, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Name（字段） 查询
        /// </summary>
        /// /// <param name = "name">名称</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByName(string name, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (name != null)
                paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_symbolEO.MapDataReader);
        }
        public async Task<List<Gmf_symbolEO>> GetByNameAsync(string name, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (name != null)
                paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_symbolEO.MapDataReader);
        }
        #endregion // GetByName
        #region GetByType

        /// <summary>
        /// 按 Type（字段） 查询
        /// </summary>
        /// /// <param name = "type">1-normal,2-wild,3-bonus 4-bingo 5-andFreeSpin</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByType(int type)
        {
            return GetByType(type, 0, string.Empty, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByTypeAsync(int type)
        {
            return await GetByTypeAsync(type, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 Type（字段） 查询
        /// </summary>
        /// /// <param name = "type">1-normal,2-wild,3-bonus 4-bingo 5-andFreeSpin</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByType(int type, TransactionManager tm_)
        {
            return GetByType(type, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByTypeAsync(int type, TransactionManager tm_)
        {
            return await GetByTypeAsync(type, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Type（字段） 查询
        /// </summary>
        /// /// <param name = "type">1-normal,2-wild,3-bonus 4-bingo 5-andFreeSpin</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByType(int type, int top_)
        {
            return GetByType(type, top_, string.Empty, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByTypeAsync(int type, int top_)
        {
            return await GetByTypeAsync(type, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 Type（字段） 查询
        /// </summary>
        /// /// <param name = "type">1-normal,2-wild,3-bonus 4-bingo 5-andFreeSpin</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByType(int type, int top_, TransactionManager tm_)
        {
            return GetByType(type, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByTypeAsync(int type, int top_, TransactionManager tm_)
        {
            return await GetByTypeAsync(type, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 Type（字段） 查询
        /// </summary>
        /// /// <param name = "type">1-normal,2-wild,3-bonus 4-bingo 5-andFreeSpin</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByType(int type, string sort_)
        {
            return GetByType(type, 0, sort_, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByTypeAsync(int type, string sort_)
        {
            return await GetByTypeAsync(type, 0, sort_, null);
        }

        /// <summary>
        /// 按 Type（字段） 查询
        /// </summary>
        /// /// <param name = "type">1-normal,2-wild,3-bonus 4-bingo 5-andFreeSpin</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByType(int type, string sort_, TransactionManager tm_)
        {
            return GetByType(type, 0, sort_, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByTypeAsync(int type, string sort_, TransactionManager tm_)
        {
            return await GetByTypeAsync(type, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 Type（字段） 查询
        /// </summary>
        /// /// <param name = "type">1-normal,2-wild,3-bonus 4-bingo 5-andFreeSpin</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByType(int type, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Type` = @Type", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Type", type, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_symbolEO.MapDataReader);
        }
        public async Task<List<Gmf_symbolEO>> GetByTypeAsync(int type, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`Type` = @Type", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@Type", type, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_symbolEO.MapDataReader);
        }
        #endregion // GetByType
        #region GetByIsNormal

        /// <summary>
        /// 按 IsNormal（字段） 查询
        /// </summary>
        /// /// <param name = "isNormal">是否普通Symbol</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsNormal(bool isNormal)
        {
            return GetByIsNormal(isNormal, 0, string.Empty, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsNormalAsync(bool isNormal)
        {
            return await GetByIsNormalAsync(isNormal, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 IsNormal（字段） 查询
        /// </summary>
        /// /// <param name = "isNormal">是否普通Symbol</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsNormal(bool isNormal, TransactionManager tm_)
        {
            return GetByIsNormal(isNormal, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsNormalAsync(bool isNormal, TransactionManager tm_)
        {
            return await GetByIsNormalAsync(isNormal, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 IsNormal（字段） 查询
        /// </summary>
        /// /// <param name = "isNormal">是否普通Symbol</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsNormal(bool isNormal, int top_)
        {
            return GetByIsNormal(isNormal, top_, string.Empty, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsNormalAsync(bool isNormal, int top_)
        {
            return await GetByIsNormalAsync(isNormal, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 IsNormal（字段） 查询
        /// </summary>
        /// /// <param name = "isNormal">是否普通Symbol</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsNormal(bool isNormal, int top_, TransactionManager tm_)
        {
            return GetByIsNormal(isNormal, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsNormalAsync(bool isNormal, int top_, TransactionManager tm_)
        {
            return await GetByIsNormalAsync(isNormal, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 IsNormal（字段） 查询
        /// </summary>
        /// /// <param name = "isNormal">是否普通Symbol</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsNormal(bool isNormal, string sort_)
        {
            return GetByIsNormal(isNormal, 0, sort_, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsNormalAsync(bool isNormal, string sort_)
        {
            return await GetByIsNormalAsync(isNormal, 0, sort_, null);
        }

        /// <summary>
        /// 按 IsNormal（字段） 查询
        /// </summary>
        /// /// <param name = "isNormal">是否普通Symbol</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsNormal(bool isNormal, string sort_, TransactionManager tm_)
        {
            return GetByIsNormal(isNormal, 0, sort_, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsNormalAsync(bool isNormal, string sort_, TransactionManager tm_)
        {
            return await GetByIsNormalAsync(isNormal, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 IsNormal（字段） 查询
        /// </summary>
        /// /// <param name = "isNormal">是否普通Symbol</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsNormal(bool isNormal, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`IsNormal` = @IsNormal", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IsNormal", isNormal, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_symbolEO.MapDataReader);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsNormalAsync(bool isNormal, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`IsNormal` = @IsNormal", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IsNormal", isNormal, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_symbolEO.MapDataReader);
        }
        #endregion // GetByIsNormal
        #region GetByIsWild

        /// <summary>
        /// 按 IsWild（字段） 查询
        /// </summary>
        /// /// <param name = "isWild"></param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsWild(bool isWild)
        {
            return GetByIsWild(isWild, 0, string.Empty, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsWildAsync(bool isWild)
        {
            return await GetByIsWildAsync(isWild, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 IsWild（字段） 查询
        /// </summary>
        /// /// <param name = "isWild"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsWild(bool isWild, TransactionManager tm_)
        {
            return GetByIsWild(isWild, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsWildAsync(bool isWild, TransactionManager tm_)
        {
            return await GetByIsWildAsync(isWild, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 IsWild（字段） 查询
        /// </summary>
        /// /// <param name = "isWild"></param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsWild(bool isWild, int top_)
        {
            return GetByIsWild(isWild, top_, string.Empty, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsWildAsync(bool isWild, int top_)
        {
            return await GetByIsWildAsync(isWild, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 IsWild（字段） 查询
        /// </summary>
        /// /// <param name = "isWild"></param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsWild(bool isWild, int top_, TransactionManager tm_)
        {
            return GetByIsWild(isWild, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsWildAsync(bool isWild, int top_, TransactionManager tm_)
        {
            return await GetByIsWildAsync(isWild, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 IsWild（字段） 查询
        /// </summary>
        /// /// <param name = "isWild"></param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsWild(bool isWild, string sort_)
        {
            return GetByIsWild(isWild, 0, sort_, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsWildAsync(bool isWild, string sort_)
        {
            return await GetByIsWildAsync(isWild, 0, sort_, null);
        }

        /// <summary>
        /// 按 IsWild（字段） 查询
        /// </summary>
        /// /// <param name = "isWild"></param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsWild(bool isWild, string sort_, TransactionManager tm_)
        {
            return GetByIsWild(isWild, 0, sort_, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsWildAsync(bool isWild, string sort_, TransactionManager tm_)
        {
            return await GetByIsWildAsync(isWild, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 IsWild（字段） 查询
        /// </summary>
        /// /// <param name = "isWild"></param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsWild(bool isWild, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`IsWild` = @IsWild", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IsWild", isWild, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_symbolEO.MapDataReader);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsWildAsync(bool isWild, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`IsWild` = @IsWild", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IsWild", isWild, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_symbolEO.MapDataReader);
        }
        #endregion // GetByIsWild
        #region GetByIsBonus

        /// <summary>
        /// 按 IsBonus（字段） 查询
        /// </summary>
        /// /// <param name = "isBonus"></param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsBonus(bool isBonus)
        {
            return GetByIsBonus(isBonus, 0, string.Empty, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsBonusAsync(bool isBonus)
        {
            return await GetByIsBonusAsync(isBonus, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 IsBonus（字段） 查询
        /// </summary>
        /// /// <param name = "isBonus"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsBonus(bool isBonus, TransactionManager tm_)
        {
            return GetByIsBonus(isBonus, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsBonusAsync(bool isBonus, TransactionManager tm_)
        {
            return await GetByIsBonusAsync(isBonus, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 IsBonus（字段） 查询
        /// </summary>
        /// /// <param name = "isBonus"></param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsBonus(bool isBonus, int top_)
        {
            return GetByIsBonus(isBonus, top_, string.Empty, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsBonusAsync(bool isBonus, int top_)
        {
            return await GetByIsBonusAsync(isBonus, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 IsBonus（字段） 查询
        /// </summary>
        /// /// <param name = "isBonus"></param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsBonus(bool isBonus, int top_, TransactionManager tm_)
        {
            return GetByIsBonus(isBonus, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsBonusAsync(bool isBonus, int top_, TransactionManager tm_)
        {
            return await GetByIsBonusAsync(isBonus, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 IsBonus（字段） 查询
        /// </summary>
        /// /// <param name = "isBonus"></param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsBonus(bool isBonus, string sort_)
        {
            return GetByIsBonus(isBonus, 0, sort_, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsBonusAsync(bool isBonus, string sort_)
        {
            return await GetByIsBonusAsync(isBonus, 0, sort_, null);
        }

        /// <summary>
        /// 按 IsBonus（字段） 查询
        /// </summary>
        /// /// <param name = "isBonus"></param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsBonus(bool isBonus, string sort_, TransactionManager tm_)
        {
            return GetByIsBonus(isBonus, 0, sort_, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsBonusAsync(bool isBonus, string sort_, TransactionManager tm_)
        {
            return await GetByIsBonusAsync(isBonus, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 IsBonus（字段） 查询
        /// </summary>
        /// /// <param name = "isBonus"></param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsBonus(bool isBonus, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`IsBonus` = @IsBonus", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IsBonus", isBonus, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_symbolEO.MapDataReader);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsBonusAsync(bool isBonus, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`IsBonus` = @IsBonus", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IsBonus", isBonus, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_symbolEO.MapDataReader);
        }
        #endregion // GetByIsBonus
        #region GetByIsBingo

        /// <summary>
        /// 按 IsBingo（字段） 查询
        /// </summary>
        /// /// <param name = "isBingo"></param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsBingo(bool isBingo)
        {
            return GetByIsBingo(isBingo, 0, string.Empty, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsBingoAsync(bool isBingo)
        {
            return await GetByIsBingoAsync(isBingo, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 IsBingo（字段） 查询
        /// </summary>
        /// /// <param name = "isBingo"></param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsBingo(bool isBingo, TransactionManager tm_)
        {
            return GetByIsBingo(isBingo, 0, string.Empty, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsBingoAsync(bool isBingo, TransactionManager tm_)
        {
            return await GetByIsBingoAsync(isBingo, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 IsBingo（字段） 查询
        /// </summary>
        /// /// <param name = "isBingo"></param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsBingo(bool isBingo, int top_)
        {
            return GetByIsBingo(isBingo, top_, string.Empty, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsBingoAsync(bool isBingo, int top_)
        {
            return await GetByIsBingoAsync(isBingo, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 IsBingo（字段） 查询
        /// </summary>
        /// /// <param name = "isBingo"></param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsBingo(bool isBingo, int top_, TransactionManager tm_)
        {
            return GetByIsBingo(isBingo, top_, string.Empty, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsBingoAsync(bool isBingo, int top_, TransactionManager tm_)
        {
            return await GetByIsBingoAsync(isBingo, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 IsBingo（字段） 查询
        /// </summary>
        /// /// <param name = "isBingo"></param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsBingo(bool isBingo, string sort_)
        {
            return GetByIsBingo(isBingo, 0, sort_, null);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsBingoAsync(bool isBingo, string sort_)
        {
            return await GetByIsBingoAsync(isBingo, 0, sort_, null);
        }

        /// <summary>
        /// 按 IsBingo（字段） 查询
        /// </summary>
        /// /// <param name = "isBingo"></param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsBingo(bool isBingo, string sort_, TransactionManager tm_)
        {
            return GetByIsBingo(isBingo, 0, sort_, tm_);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsBingoAsync(bool isBingo, string sort_, TransactionManager tm_)
        {
            return await GetByIsBingoAsync(isBingo, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 IsBingo（字段） 查询
        /// </summary>
        /// /// <param name = "isBingo"></param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gmf_symbolEO> GetByIsBingo(bool isBingo, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`IsBingo` = @IsBingo", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IsBingo", isBingo, MySqlDbType.Byte));
            return Database.ExecSqlList(sql_, paras_, tm_, Gmf_symbolEO.MapDataReader);
        }
        public async Task<List<Gmf_symbolEO>> GetByIsBingoAsync(bool isBingo, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`IsBingo` = @IsBingo", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@IsBingo", isBingo, MySqlDbType.Byte));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gmf_symbolEO.MapDataReader);
        }
        #endregion // GetByIsBingo
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
