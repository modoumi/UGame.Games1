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
    /// 短信商国家表
    /// 【表 s_sms_country 的实体类】
    /// </summary>
    [DataContract]
    public class S_sms_countryEO : IRowMapper<S_sms_countryEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public S_sms_countryEO()
        {
            this.RecDate = DateTime.Now;
        }
        #region 主键原始值 & 主键集合

        /// <summary>
        /// 当前对象是否保存原始主键值，当修改了主键值时为 true
        /// </summary>
        public bool HasOriginal { get; protected set; }

        private string _originalSmsID;
        /// <summary>
        /// 【数据库中的原始主键 SmsID 值的副本，用于主键值更新】
        /// </summary>
        public string OriginalSmsID
        {
            get { return _originalSmsID; }
            set { HasOriginal = true; _originalSmsID = value; }
        }

        private string _originalCountryID;
        /// <summary>
        /// 【数据库中的原始主键 CountryID 值的副本，用于主键值更新】
        /// </summary>
        public string OriginalCountryID
        {
            get { return _originalCountryID; }
            set { HasOriginal = true; _originalCountryID = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "SmsID", SmsID }, { "CountryID", CountryID }, };
        }
        /// <summary>
        /// 获取主键集合JSON格式
        /// </summary>
        /// <returns></returns>
        public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
        #endregion // 主键原始值
        #region 所有字段
        /// <summary>
        /// 短信商编码
        /// 【主键 varchar(50)】
        /// </summary>
        [DataMember(Order = 1)]
        public string SmsID { get; set; }
        /// <summary>
        /// 国家编码ISO 3166-1三位字母
        /// 【主键 varchar(5)】
        /// </summary>
        [DataMember(Order = 2)]
        public string CountryID { get; set; }
        /// <summary>
        /// 货币类型
        /// 【字段 varchar(5)】
        /// </summary>
        [DataMember(Order = 3)]
        public string CurrencyID { get; set; }
        /// <summary>
        /// 验证码模板
        /// 【字段 varchar(255)】
        /// </summary>
        [DataMember(Order = 4)]
        public string VerifyCodeTemplate { get; set; }
        /// <summary>
        /// 记录时间
        /// 【字段 datetime】
        /// </summary>
        [DataMember(Order = 5)]
        public DateTime RecDate { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public S_sms_countryEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static S_sms_countryEO MapDataReader(IDataReader reader)
        {
            S_sms_countryEO ret = new S_sms_countryEO();
            ret.SmsID = reader.ToString("SmsID");
            ret.OriginalSmsID = ret.SmsID;
            ret.CountryID = reader.ToString("CountryID");
            ret.OriginalCountryID = ret.CountryID;
            ret.CurrencyID = reader.ToString("CurrencyID");
            ret.VerifyCodeTemplate = reader.ToString("VerifyCodeTemplate");
            ret.RecDate = reader.ToDateTime("RecDate");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// 短信商国家表
    /// 【表 s_sms_country 的操作类】
    /// </summary>
    public class S_sms_countryMO : MySqlTableMO<S_sms_countryEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`s_sms_country`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public S_sms_countryMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public S_sms_countryMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public S_sms_countryMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(S_sms_countryEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(S_sms_countryEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(S_sms_countryEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`SmsID`, `CountryID`, `CurrencyID`, `VerifyCodeTemplate`, `RecDate`) VALUE (@SmsID, @CountryID, @CurrencyID, @VerifyCodeTemplate, @RecDate);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", item.SmsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", item.CountryID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@VerifyCodeTemplate", item.VerifyCodeTemplate != null ? item.VerifyCodeTemplate : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
            };
        }
        public int AddByBatch(IEnumerable<S_sms_countryEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<S_sms_countryEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_sms_countryEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`SmsID`, `CountryID`, `CurrencyID`, `VerifyCodeTemplate`, `RecDate`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"('{item.SmsID}','{item.CountryID}','{item.CurrencyID}','{item.VerifyCodeTemplate}','{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
        /// /// <param name = "smsID">短信商编码</param>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(string smsID, string countryID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(smsID, countryID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(string smsID, string countryID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(smsID, countryID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(string smsID, string countryID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `SmsID` = @SmsID AND `CountryID` = @CountryID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(S_sms_countryEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.SmsID, item.CountryID, tm_);
        }
        public async Task<int> RemoveAsync(S_sms_countryEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.SmsID, item.CountryID, tm_);
        }
        #endregion // RemoveByPK

        #region RemoveByXXX
        #region RemoveBySmsID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveBySmsID(string smsID, TransactionManager tm_ = null)
        {
            RepairRemoveBySmsIDData(smsID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveBySmsIDAsync(string smsID, TransactionManager tm_ = null)
        {
            RepairRemoveBySmsIDData(smsID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveBySmsIDData(string smsID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `SmsID` = @SmsID";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar));
        }
        #endregion // RemoveBySmsID
        #region RemoveByCountryID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByCountryID(string countryID, TransactionManager tm_ = null)
        {
            RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByCountryIDAsync(string countryID, TransactionManager tm_ = null)
        {
            RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByCountryIDData(string countryID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `CountryID` = @CountryID";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
        }
        #endregion // RemoveByCountryID
        #region RemoveByCurrencyID
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
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
            sql_ = $"DELETE FROM {TableName} WHERE " + (currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (currencyID != null)
                paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
        }
        #endregion // RemoveByCurrencyID
        #region RemoveByVerifyCodeTemplate
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "verifyCodeTemplate">验证码模板</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByVerifyCodeTemplate(string verifyCodeTemplate, TransactionManager tm_ = null)
        {
            RepairRemoveByVerifyCodeTemplateData(verifyCodeTemplate, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByVerifyCodeTemplateAsync(string verifyCodeTemplate, TransactionManager tm_ = null)
        {
            RepairRemoveByVerifyCodeTemplateData(verifyCodeTemplate, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByVerifyCodeTemplateData(string verifyCodeTemplate, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE " + (verifyCodeTemplate != null ? "`VerifyCodeTemplate` = @VerifyCodeTemplate" : "`VerifyCodeTemplate` IS NULL");
            paras_ = new List<MySqlParameter>();
            if (verifyCodeTemplate != null)
                paras_.Add(Database.CreateInParameter("@VerifyCodeTemplate", verifyCodeTemplate, MySqlDbType.VarChar));
        }
        #endregion // RemoveByVerifyCodeTemplate
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
        public int Put(S_sms_countryEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(S_sms_countryEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(S_sms_countryEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `SmsID` = @SmsID, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID, `VerifyCodeTemplate` = @VerifyCodeTemplate WHERE `SmsID` = @SmsID_Original AND `CountryID` = @CountryID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", item.SmsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", item.CountryID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@VerifyCodeTemplate", item.VerifyCodeTemplate != null ? item.VerifyCodeTemplate : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SmsID_Original", item.HasOriginal ? item.OriginalSmsID : item.SmsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID_Original", item.HasOriginal ? item.OriginalCountryID : item.CountryID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<S_sms_countryEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<S_sms_countryEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "smsID">短信商编码</param>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string smsID, string countryID, string set_, params object[] values_)
        {
            return Put(set_, "`SmsID` = @SmsID AND `CountryID` = @CountryID", ConcatValues(values_, smsID, countryID));
        }
        public async Task<int> PutByPKAsync(string smsID, string countryID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`SmsID` = @SmsID AND `CountryID` = @CountryID", ConcatValues(values_, smsID, countryID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string smsID, string countryID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`SmsID` = @SmsID AND `CountryID` = @CountryID", tm_, ConcatValues(values_, smsID, countryID));
        }
        public async Task<int> PutByPKAsync(string smsID, string countryID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`SmsID` = @SmsID AND `CountryID` = @CountryID", tm_, ConcatValues(values_, smsID, countryID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string smsID, string countryID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
            };
            return Put(set_, "`SmsID` = @SmsID AND `CountryID` = @CountryID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(string smsID, string countryID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
            };
            return await PutAsync(set_, "`SmsID` = @SmsID AND `CountryID` = @CountryID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutSmsID

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutSmsID(string smsID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SmsID` = @SmsID";
            var parameter_ = Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutSmsIDAsync(string smsID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `SmsID` = @SmsID";
            var parameter_ = Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutSmsID
        #region PutCountryID

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutCountryID(string countryID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
            var parameter_ = Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutCountryIDAsync(string countryID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
            var parameter_ = Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutCountryID
        #region PutCurrencyID
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutCurrencyIDByPK(string smsID, string countryID, string currencyID, TransactionManager tm_ = null)
        {
            RepairPutCurrencyIDByPKData(smsID, countryID, currencyID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutCurrencyIDByPKAsync(string smsID, string countryID, string currencyID, TransactionManager tm_ = null)
        {
            RepairPutCurrencyIDByPKData(smsID, countryID, currencyID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutCurrencyIDByPKData(string smsID, string countryID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `SmsID` = @SmsID AND `CountryID` = @CountryID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutCurrencyID(string currencyID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
            var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
            var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutCurrencyID
        #region PutVerifyCodeTemplate
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// /// <param name = "verifyCodeTemplate">验证码模板</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutVerifyCodeTemplateByPK(string smsID, string countryID, string verifyCodeTemplate, TransactionManager tm_ = null)
        {
            RepairPutVerifyCodeTemplateByPKData(smsID, countryID, verifyCodeTemplate, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutVerifyCodeTemplateByPKAsync(string smsID, string countryID, string verifyCodeTemplate, TransactionManager tm_ = null)
        {
            RepairPutVerifyCodeTemplateByPKData(smsID, countryID, verifyCodeTemplate, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutVerifyCodeTemplateByPKData(string smsID, string countryID, string verifyCodeTemplate, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `VerifyCodeTemplate` = @VerifyCodeTemplate  WHERE `SmsID` = @SmsID AND `CountryID` = @CountryID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@VerifyCodeTemplate", verifyCodeTemplate != null ? verifyCodeTemplate : (object)DBNull.Value, MySqlDbType.VarChar),
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "verifyCodeTemplate">验证码模板</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutVerifyCodeTemplate(string verifyCodeTemplate, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `VerifyCodeTemplate` = @VerifyCodeTemplate";
            var parameter_ = Database.CreateInParameter("@VerifyCodeTemplate", verifyCodeTemplate != null ? verifyCodeTemplate : (object)DBNull.Value, MySqlDbType.VarChar);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutVerifyCodeTemplateAsync(string verifyCodeTemplate, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `VerifyCodeTemplate` = @VerifyCodeTemplate";
            var parameter_ = Database.CreateInParameter("@VerifyCodeTemplate", verifyCodeTemplate != null ? verifyCodeTemplate : (object)DBNull.Value, MySqlDbType.VarChar);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutVerifyCodeTemplate
        #region PutRecDate
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutRecDateByPK(string smsID, string countryID, DateTime recDate, TransactionManager tm_ = null)
        {
            RepairPutRecDateByPKData(smsID, countryID, recDate, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutRecDateByPKAsync(string smsID, string countryID, DateTime recDate, TransactionManager tm_ = null)
        {
            RepairPutRecDateByPKData(smsID, countryID, recDate, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutRecDateByPKData(string smsID, string countryID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `SmsID` = @SmsID AND `CountryID` = @CountryID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
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
        public bool Set(S_sms_countryEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.SmsID, item.CountryID) == null)
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
        public async Task<bool> SetAsync(S_sms_countryEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.SmsID, item.CountryID) == null)
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
        /// /// <param name = "smsID">短信商编码</param>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public S_sms_countryEO GetByPK(string smsID, string countryID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(smsID, countryID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, S_sms_countryEO.MapDataReader);
        }
        public async Task<S_sms_countryEO> GetByPKAsync(string smsID, string countryID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(smsID, countryID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_sms_countryEO.MapDataReader);
        }
        private void RepairGetByPKData(string smsID, string countryID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`SmsID` = @SmsID AND `CountryID` = @CountryID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 SmsID（字段）
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetSmsIDByPK(string smsID, string countryID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`SmsID`", "`SmsID` = @SmsID AND `CountryID` = @CountryID", paras_, tm_);
        }
        public async Task<string> GetSmsIDByPKAsync(string smsID, string countryID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`SmsID`", "`SmsID` = @SmsID AND `CountryID` = @CountryID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 CountryID（字段）
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetCountryIDByPK(string smsID, string countryID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`CountryID`", "`SmsID` = @SmsID AND `CountryID` = @CountryID", paras_, tm_);
        }
        public async Task<string> GetCountryIDByPKAsync(string smsID, string countryID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`CountryID`", "`SmsID` = @SmsID AND `CountryID` = @CountryID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 CurrencyID（字段）
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetCurrencyIDByPK(string smsID, string countryID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`CurrencyID`", "`SmsID` = @SmsID AND `CountryID` = @CountryID", paras_, tm_);
        }
        public async Task<string> GetCurrencyIDByPKAsync(string smsID, string countryID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`CurrencyID`", "`SmsID` = @SmsID AND `CountryID` = @CountryID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 VerifyCodeTemplate（字段）
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetVerifyCodeTemplateByPK(string smsID, string countryID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
            };
            return (string)GetScalar("`VerifyCodeTemplate`", "`SmsID` = @SmsID AND `CountryID` = @CountryID", paras_, tm_);
        }
        public async Task<string> GetVerifyCodeTemplateByPKAsync(string smsID, string countryID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
            };
            return (string)await GetScalarAsync("`VerifyCodeTemplate`", "`SmsID` = @SmsID AND `CountryID` = @CountryID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 RecDate（字段）
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public DateTime GetRecDateByPK(string smsID, string countryID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
            };
            return (DateTime)GetScalar("`RecDate`", "`SmsID` = @SmsID AND `CountryID` = @CountryID", paras_, tm_);
        }
        public async Task<DateTime> GetRecDateByPKAsync(string smsID, string countryID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar),
                Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
            };
            return (DateTime)await GetScalarAsync("`RecDate`", "`SmsID` = @SmsID AND `CountryID` = @CountryID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetBySmsID

        /// <summary>
        /// 按 SmsID（字段） 查询
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetBySmsID(string smsID)
        {
            return GetBySmsID(smsID, 0, string.Empty, null);
        }
        public async Task<List<S_sms_countryEO>> GetBySmsIDAsync(string smsID)
        {
            return await GetBySmsIDAsync(smsID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 SmsID（字段） 查询
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetBySmsID(string smsID, TransactionManager tm_)
        {
            return GetBySmsID(smsID, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_countryEO>> GetBySmsIDAsync(string smsID, TransactionManager tm_)
        {
            return await GetBySmsIDAsync(smsID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SmsID（字段） 查询
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetBySmsID(string smsID, int top_)
        {
            return GetBySmsID(smsID, top_, string.Empty, null);
        }
        public async Task<List<S_sms_countryEO>> GetBySmsIDAsync(string smsID, int top_)
        {
            return await GetBySmsIDAsync(smsID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 SmsID（字段） 查询
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetBySmsID(string smsID, int top_, TransactionManager tm_)
        {
            return GetBySmsID(smsID, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_countryEO>> GetBySmsIDAsync(string smsID, int top_, TransactionManager tm_)
        {
            return await GetBySmsIDAsync(smsID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 SmsID（字段） 查询
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetBySmsID(string smsID, string sort_)
        {
            return GetBySmsID(smsID, 0, sort_, null);
        }
        public async Task<List<S_sms_countryEO>> GetBySmsIDAsync(string smsID, string sort_)
        {
            return await GetBySmsIDAsync(smsID, 0, sort_, null);
        }

        /// <summary>
        /// 按 SmsID（字段） 查询
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetBySmsID(string smsID, string sort_, TransactionManager tm_)
        {
            return GetBySmsID(smsID, 0, sort_, tm_);
        }
        public async Task<List<S_sms_countryEO>> GetBySmsIDAsync(string smsID, string sort_, TransactionManager tm_)
        {
            return await GetBySmsIDAsync(smsID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 SmsID（字段） 查询
        /// </summary>
        /// /// <param name = "smsID">短信商编码</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetBySmsID(string smsID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`SmsID` = @SmsID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_countryEO.MapDataReader);
        }
        public async Task<List<S_sms_countryEO>> GetBySmsIDAsync(string smsID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`SmsID` = @SmsID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@SmsID", smsID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_countryEO.MapDataReader);
        }
        #endregion // GetBySmsID
        #region GetByCountryID

        /// <summary>
        /// 按 CountryID（字段） 查询
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByCountryID(string countryID)
        {
            return GetByCountryID(countryID, 0, string.Empty, null);
        }
        public async Task<List<S_sms_countryEO>> GetByCountryIDAsync(string countryID)
        {
            return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 CountryID（字段） 查询
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByCountryID(string countryID, TransactionManager tm_)
        {
            return GetByCountryID(countryID, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_countryEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
        {
            return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CountryID（字段） 查询
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByCountryID(string countryID, int top_)
        {
            return GetByCountryID(countryID, top_, string.Empty, null);
        }
        public async Task<List<S_sms_countryEO>> GetByCountryIDAsync(string countryID, int top_)
        {
            return await GetByCountryIDAsync(countryID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 CountryID（字段） 查询
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
        {
            return GetByCountryID(countryID, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_countryEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
        {
            return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CountryID（字段） 查询
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByCountryID(string countryID, string sort_)
        {
            return GetByCountryID(countryID, 0, sort_, null);
        }
        public async Task<List<S_sms_countryEO>> GetByCountryIDAsync(string countryID, string sort_)
        {
            return await GetByCountryIDAsync(countryID, 0, sort_, null);
        }

        /// <summary>
        /// 按 CountryID（字段） 查询
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
        {
            return GetByCountryID(countryID, 0, sort_, tm_);
        }
        public async Task<List<S_sms_countryEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
        {
            return await GetByCountryIDAsync(countryID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 CountryID（字段） 查询
        /// </summary>
        /// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`CountryID` = @CountryID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_countryEO.MapDataReader);
        }
        public async Task<List<S_sms_countryEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`CountryID` = @CountryID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_countryEO.MapDataReader);
        }
        #endregion // GetByCountryID
        #region GetByCurrencyID

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByCurrencyID(string currencyID)
        {
            return GetByCurrencyID(currencyID, 0, string.Empty, null);
        }
        public async Task<List<S_sms_countryEO>> GetByCurrencyIDAsync(string currencyID)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_countryEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByCurrencyID(string currencyID, int top_)
        {
            return GetByCurrencyID(currencyID, top_, string.Empty, null);
        }
        public async Task<List<S_sms_countryEO>> GetByCurrencyIDAsync(string currencyID, int top_)
        {
            return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_countryEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
        {
            return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByCurrencyID(string currencyID, string sort_)
        {
            return GetByCurrencyID(currencyID, 0, sort_, null);
        }
        public async Task<List<S_sms_countryEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
        {
            return GetByCurrencyID(currencyID, 0, sort_, tm_);
        }
        public async Task<List<S_sms_countryEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
        {
            return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 CurrencyID（字段） 查询
        /// </summary>
        /// /// <param name = "currencyID">货币类型</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (currencyID != null)
                paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_countryEO.MapDataReader);
        }
        public async Task<List<S_sms_countryEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (currencyID != null)
                paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_countryEO.MapDataReader);
        }
        #endregion // GetByCurrencyID
        #region GetByVerifyCodeTemplate

        /// <summary>
        /// 按 VerifyCodeTemplate（字段） 查询
        /// </summary>
        /// /// <param name = "verifyCodeTemplate">验证码模板</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByVerifyCodeTemplate(string verifyCodeTemplate)
        {
            return GetByVerifyCodeTemplate(verifyCodeTemplate, 0, string.Empty, null);
        }
        public async Task<List<S_sms_countryEO>> GetByVerifyCodeTemplateAsync(string verifyCodeTemplate)
        {
            return await GetByVerifyCodeTemplateAsync(verifyCodeTemplate, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 VerifyCodeTemplate（字段） 查询
        /// </summary>
        /// /// <param name = "verifyCodeTemplate">验证码模板</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByVerifyCodeTemplate(string verifyCodeTemplate, TransactionManager tm_)
        {
            return GetByVerifyCodeTemplate(verifyCodeTemplate, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_countryEO>> GetByVerifyCodeTemplateAsync(string verifyCodeTemplate, TransactionManager tm_)
        {
            return await GetByVerifyCodeTemplateAsync(verifyCodeTemplate, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 VerifyCodeTemplate（字段） 查询
        /// </summary>
        /// /// <param name = "verifyCodeTemplate">验证码模板</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByVerifyCodeTemplate(string verifyCodeTemplate, int top_)
        {
            return GetByVerifyCodeTemplate(verifyCodeTemplate, top_, string.Empty, null);
        }
        public async Task<List<S_sms_countryEO>> GetByVerifyCodeTemplateAsync(string verifyCodeTemplate, int top_)
        {
            return await GetByVerifyCodeTemplateAsync(verifyCodeTemplate, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 VerifyCodeTemplate（字段） 查询
        /// </summary>
        /// /// <param name = "verifyCodeTemplate">验证码模板</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByVerifyCodeTemplate(string verifyCodeTemplate, int top_, TransactionManager tm_)
        {
            return GetByVerifyCodeTemplate(verifyCodeTemplate, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_countryEO>> GetByVerifyCodeTemplateAsync(string verifyCodeTemplate, int top_, TransactionManager tm_)
        {
            return await GetByVerifyCodeTemplateAsync(verifyCodeTemplate, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 VerifyCodeTemplate（字段） 查询
        /// </summary>
        /// /// <param name = "verifyCodeTemplate">验证码模板</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByVerifyCodeTemplate(string verifyCodeTemplate, string sort_)
        {
            return GetByVerifyCodeTemplate(verifyCodeTemplate, 0, sort_, null);
        }
        public async Task<List<S_sms_countryEO>> GetByVerifyCodeTemplateAsync(string verifyCodeTemplate, string sort_)
        {
            return await GetByVerifyCodeTemplateAsync(verifyCodeTemplate, 0, sort_, null);
        }

        /// <summary>
        /// 按 VerifyCodeTemplate（字段） 查询
        /// </summary>
        /// /// <param name = "verifyCodeTemplate">验证码模板</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByVerifyCodeTemplate(string verifyCodeTemplate, string sort_, TransactionManager tm_)
        {
            return GetByVerifyCodeTemplate(verifyCodeTemplate, 0, sort_, tm_);
        }
        public async Task<List<S_sms_countryEO>> GetByVerifyCodeTemplateAsync(string verifyCodeTemplate, string sort_, TransactionManager tm_)
        {
            return await GetByVerifyCodeTemplateAsync(verifyCodeTemplate, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 VerifyCodeTemplate（字段） 查询
        /// </summary>
        /// /// <param name = "verifyCodeTemplate">验证码模板</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByVerifyCodeTemplate(string verifyCodeTemplate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(verifyCodeTemplate != null ? "`VerifyCodeTemplate` = @VerifyCodeTemplate" : "`VerifyCodeTemplate` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (verifyCodeTemplate != null)
                paras_.Add(Database.CreateInParameter("@VerifyCodeTemplate", verifyCodeTemplate, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_countryEO.MapDataReader);
        }
        public async Task<List<S_sms_countryEO>> GetByVerifyCodeTemplateAsync(string verifyCodeTemplate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(verifyCodeTemplate != null ? "`VerifyCodeTemplate` = @VerifyCodeTemplate" : "`VerifyCodeTemplate` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (verifyCodeTemplate != null)
                paras_.Add(Database.CreateInParameter("@VerifyCodeTemplate", verifyCodeTemplate, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_countryEO.MapDataReader);
        }
        #endregion // GetByVerifyCodeTemplate
        #region GetByRecDate

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByRecDate(DateTime recDate)
        {
            return GetByRecDate(recDate, 0, string.Empty, null);
        }
        public async Task<List<S_sms_countryEO>> GetByRecDateAsync(DateTime recDate)
        {
            return await GetByRecDateAsync(recDate, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
        {
            return GetByRecDate(recDate, 0, string.Empty, tm_);
        }
        public async Task<List<S_sms_countryEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
        {
            return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByRecDate(DateTime recDate, int top_)
        {
            return GetByRecDate(recDate, top_, string.Empty, null);
        }
        public async Task<List<S_sms_countryEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
        public List<S_sms_countryEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
        {
            return GetByRecDate(recDate, top_, string.Empty, tm_);
        }
        public async Task<List<S_sms_countryEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
        {
            return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 RecDate（字段） 查询
        /// </summary>
        /// /// <param name = "recDate">记录时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<S_sms_countryEO> GetByRecDate(DateTime recDate, string sort_)
        {
            return GetByRecDate(recDate, 0, sort_, null);
        }
        public async Task<List<S_sms_countryEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
        public List<S_sms_countryEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
        {
            return GetByRecDate(recDate, 0, sort_, tm_);
        }
        public async Task<List<S_sms_countryEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
        public List<S_sms_countryEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
            return Database.ExecSqlList(sql_, paras_, tm_, S_sms_countryEO.MapDataReader);
        }
        public async Task<List<S_sms_countryEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_sms_countryEO.MapDataReader);
        }
        #endregion // GetByRecDate
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
