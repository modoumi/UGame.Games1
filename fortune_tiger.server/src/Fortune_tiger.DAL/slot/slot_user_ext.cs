/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2024-01-30 16: 08:10
 ******************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Data;
using MySql.Data.MySqlClient;
using System.Text;
using TinyFx.Data.MySql;

namespace Fortune_tiger.DAL
{
	#region EO
	/// <summary>
	/// 用户扩展数据
	/// 【表 slot_user_ext 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Slot_user_extEO : IRowMapper<Slot_user_extEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Slot_user_extEO()
		{
			this.UserFlag = 0;
			this.Balance = 0;
			this.Bonus = 0;
			this.HistoryBetCount = 0;
			this.HistoryWinAmount = 0;
			this.HistoryBetAmount = 0;
			this.RefundLv = 1;
			this.RefundNum = 1;
			this.RTP = 1d;
			this.UserStatus = true;
			this.LastRecDate = DateTime.Now;
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
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "UserID", UserID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 用户Id
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string UserID { get; set; }
		/// <summary>
		/// appid
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string AppID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 货币编码（ISO 4217大写）
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 用户标识
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 5)]
		public long UserFlag { get; set; }
		/// <summary>
		/// 余额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long Balance { get; set; }
		/// <summary>
		/// bonus
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long Bonus { get; set; }
		/// <summary>
		/// 历史总下注手数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int HistoryBetCount { get; set; }
		/// <summary>
		/// 历史总盈亏
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 9)]
		public long HistoryWinAmount { get; set; }
		/// <summary>
		/// 历史总下注金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 10)]
		public long HistoryBetAmount { get; set; }
		/// <summary>
		/// 用户等级
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int RefundLv { get; set; }
		/// <summary>
		/// 每日输反次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int RefundNum { get; set; }
		/// <summary>
		/// 用户返奖率
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 13)]
		public double RTP { get; set; }
		/// <summary>
		/// 1-正常 0-异常
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 14)]
		public bool UserStatus { get; set; }
		/// <summary>
		/// 记录最后记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 15)]
		public DateTime? LastRecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Slot_user_extEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Slot_user_extEO MapDataReader(IDataReader reader)
		{
		    Slot_user_extEO ret = new Slot_user_extEO();
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.AppID = reader.ToString("AppID");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.UserFlag = reader.ToInt64("UserFlag");
			ret.Balance = reader.ToInt64("Balance");
			ret.Bonus = reader.ToInt64("Bonus");
			ret.HistoryBetCount = reader.ToInt32("HistoryBetCount");
			ret.HistoryWinAmount = reader.ToInt64("HistoryWinAmount");
			ret.HistoryBetAmount = reader.ToInt64("HistoryBetAmount");
			ret.RefundLv = reader.ToInt32("RefundLv");
			ret.RefundNum = reader.ToInt32("RefundNum");
			ret.RTP = reader.ToDouble("RTP");
			ret.UserStatus = reader.ToBoolean("UserStatus");
			ret.LastRecDate = reader.ToDateTimeN("LastRecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户扩展数据
	/// 【表 slot_user_ext 的操作类】
	/// </summary>
	[Obsolete]
	public class Slot_user_extMO : MySqlTableMO<Slot_user_extEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`slot_user_ext`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Slot_user_extMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Slot_user_extMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Slot_user_extMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Slot_user_extEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Slot_user_extEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Slot_user_extEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`UserID`, `AppID`, `OperatorID`, `CurrencyID`, `UserFlag`, `Balance`, `Bonus`, `HistoryBetCount`, `HistoryWinAmount`, `HistoryBetAmount`, `RefundLv`, `RefundNum`, `RTP`, `UserStatus`, `LastRecDate`) VALUE (@UserID, @AppID, @OperatorID, @CurrencyID, @UserFlag, @Balance, @Bonus, @HistoryBetCount, @HistoryWinAmount, @HistoryBetAmount, @RefundLv, @RefundNum, @RTP, @UserStatus, @LastRecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserFlag", item.UserFlag, MySqlDbType.Int64),
				Database.CreateInParameter("@Balance", item.Balance, MySqlDbType.Int64),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@HistoryBetCount", item.HistoryBetCount, MySqlDbType.Int32),
				Database.CreateInParameter("@HistoryWinAmount", item.HistoryWinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@HistoryBetAmount", item.HistoryBetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@RefundLv", item.RefundLv, MySqlDbType.Int32),
				Database.CreateInParameter("@RefundNum", item.RefundNum, MySqlDbType.Int32),
				Database.CreateInParameter("@RTP", item.RTP, MySqlDbType.Double),
				Database.CreateInParameter("@UserStatus", item.UserStatus, MySqlDbType.Byte),
				Database.CreateInParameter("@LastRecDate", item.LastRecDate.HasValue ? item.LastRecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Slot_user_extEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Slot_user_extEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Slot_user_extEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`UserID`, `AppID`, `OperatorID`, `CurrencyID`, `UserFlag`, `Balance`, `Bonus`, `HistoryBetCount`, `HistoryWinAmount`, `HistoryBetAmount`, `RefundLv`, `RefundNum`, `RTP`, `UserStatus`, `LastRecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.UserID}','{item.AppID}','{item.OperatorID}','{item.CurrencyID}',{item.UserFlag},{item.Balance},{item.Bonus},{item.HistoryBetCount},{item.HistoryWinAmount},{item.HistoryBetAmount},{item.RefundLv},{item.RefundNum},{item.RTP},{item.UserStatus},'{item.LastRecDate?.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Slot_user_extEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.UserID, tm_);
		}
		public async Task<int> RemoveAsync(Slot_user_extEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.UserID, tm_);
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
		#region RemoveByUserFlag
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userFlag">用户标识</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserFlag(long userFlag, TransactionManager tm_ = null)
		{
			RepairRemoveByUserFlagData(userFlag, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserFlagAsync(long userFlag, TransactionManager tm_ = null)
		{
			RepairRemoveByUserFlagData(userFlag, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserFlagData(long userFlag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserFlag` = @UserFlag";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserFlag", userFlag, MySqlDbType.Int64));
		}
		#endregion // RemoveByUserFlag
		#region RemoveByBalance
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "balance">余额</param>
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
		#region RemoveByBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bonus">bonus</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBonus(long bonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusData(bonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBonusAsync(long bonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusData(bonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBonusData(long bonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Bonus` = @Bonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByBonus
		#region RemoveByHistoryBetCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "historyBetCount">历史总下注手数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHistoryBetCount(int historyBetCount, TransactionManager tm_ = null)
		{
			RepairRemoveByHistoryBetCountData(historyBetCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHistoryBetCountAsync(int historyBetCount, TransactionManager tm_ = null)
		{
			RepairRemoveByHistoryBetCountData(historyBetCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHistoryBetCountData(int historyBetCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HistoryBetCount` = @HistoryBetCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryBetCount", historyBetCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByHistoryBetCount
		#region RemoveByHistoryWinAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "historyWinAmount">历史总盈亏</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHistoryWinAmount(long historyWinAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByHistoryWinAmountData(historyWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHistoryWinAmountAsync(long historyWinAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByHistoryWinAmountData(historyWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHistoryWinAmountData(long historyWinAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HistoryWinAmount` = @HistoryWinAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryWinAmount", historyWinAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByHistoryWinAmount
		#region RemoveByHistoryBetAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "historyBetAmount">历史总下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHistoryBetAmount(long historyBetAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByHistoryBetAmountData(historyBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHistoryBetAmountAsync(long historyBetAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByHistoryBetAmountData(historyBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHistoryBetAmountData(long historyBetAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HistoryBetAmount` = @HistoryBetAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryBetAmount", historyBetAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByHistoryBetAmount
		#region RemoveByRefundLv
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "refundLv">用户等级</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRefundLv(int refundLv, TransactionManager tm_ = null)
		{
			RepairRemoveByRefundLvData(refundLv, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRefundLvAsync(int refundLv, TransactionManager tm_ = null)
		{
			RepairRemoveByRefundLvData(refundLv, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRefundLvData(int refundLv, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RefundLv` = @RefundLv";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundLv", refundLv, MySqlDbType.Int32));
		}
		#endregion // RemoveByRefundLv
		#region RemoveByRefundNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "refundNum">每日输反次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRefundNum(int refundNum, TransactionManager tm_ = null)
		{
			RepairRemoveByRefundNumData(refundNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRefundNumAsync(int refundNum, TransactionManager tm_ = null)
		{
			RepairRemoveByRefundNumData(refundNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRefundNumData(int refundNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RefundNum` = @RefundNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundNum", refundNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByRefundNum
		#region RemoveByRTP
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rTP">用户返奖率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRTP(double rTP, TransactionManager tm_ = null)
		{
			RepairRemoveByRTPData(rTP, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRTPAsync(double rTP, TransactionManager tm_ = null)
		{
			RepairRemoveByRTPData(rTP, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRTPData(double rTP, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RTP` = @RTP";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RTP", rTP, MySqlDbType.Double));
		}
		#endregion // RemoveByRTP
		#region RemoveByUserStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userStatus">1-正常 0-异常</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserStatus(bool userStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByUserStatusData(userStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserStatusAsync(bool userStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByUserStatusData(userStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserStatusData(bool userStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserStatus` = @UserStatus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserStatus", userStatus, MySqlDbType.Byte));
		}
		#endregion // RemoveByUserStatus
		#region RemoveByLastRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLastRecDate(DateTime? lastRecDate, TransactionManager tm_ = null)
		{
			RepairRemoveByLastRecDateData(lastRecDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLastRecDateAsync(DateTime? lastRecDate, TransactionManager tm_ = null)
		{
			RepairRemoveByLastRecDateData(lastRecDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLastRecDateData(DateTime? lastRecDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (lastRecDate.HasValue ? "`LastRecDate` = @LastRecDate" : "`LastRecDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (lastRecDate.HasValue)
				paras_.Add(Database.CreateInParameter("@LastRecDate", lastRecDate.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByLastRecDate
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
		public int Put(Slot_user_extEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Slot_user_extEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Slot_user_extEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID, `AppID` = @AppID, `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `UserFlag` = @UserFlag, `Balance` = @Balance, `Bonus` = @Bonus, `HistoryBetCount` = @HistoryBetCount, `HistoryWinAmount` = @HistoryWinAmount, `HistoryBetAmount` = @HistoryBetAmount, `RefundLv` = @RefundLv, `RefundNum` = @RefundNum, `RTP` = @RTP, `UserStatus` = @UserStatus WHERE `UserID` = @UserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserFlag", item.UserFlag, MySqlDbType.Int64),
				Database.CreateInParameter("@Balance", item.Balance, MySqlDbType.Int64),
				Database.CreateInParameter("@Bonus", item.Bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@HistoryBetCount", item.HistoryBetCount, MySqlDbType.Int32),
				Database.CreateInParameter("@HistoryWinAmount", item.HistoryWinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@HistoryBetAmount", item.HistoryBetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@RefundLv", item.RefundLv, MySqlDbType.Int32),
				Database.CreateInParameter("@RefundNum", item.RefundNum, MySqlDbType.Int32),
				Database.CreateInParameter("@RTP", item.RTP, MySqlDbType.Double),
				Database.CreateInParameter("@UserStatus", item.UserStatus, MySqlDbType.Byte),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Slot_user_extEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Slot_user_extEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID", ConcatValues(values_, userID));
		}
		public async Task<int> PutByPKAsync(string userID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID", ConcatValues(values_, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID", tm_, ConcatValues(values_, userID));
		}
		public async Task<int> PutByPKAsync(string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID", tm_, ConcatValues(values_, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutAppID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppIDByPK(string userID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(userID, appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppIDByPKAsync(string userID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(userID, appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppIDByPKData(string userID, string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
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
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string userID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(userID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string userID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(userID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string userID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string userID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(userID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string userID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(userID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string userID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutUserFlag
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "userFlag">用户标识</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserFlagByPK(string userID, long userFlag, TransactionManager tm_ = null)
		{
			RepairPutUserFlagByPKData(userID, userFlag, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserFlagByPKAsync(string userID, long userFlag, TransactionManager tm_ = null)
		{
			RepairPutUserFlagByPKData(userID, userFlag, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserFlagByPKData(string userID, long userFlag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserFlag` = @UserFlag  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserFlag", userFlag, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userFlag">用户标识</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserFlag(long userFlag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserFlag` = @UserFlag";
			var parameter_ = Database.CreateInParameter("@UserFlag", userFlag, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserFlagAsync(long userFlag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserFlag` = @UserFlag";
			var parameter_ = Database.CreateInParameter("@UserFlag", userFlag, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserFlag
		#region PutBalance
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "balance">余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBalanceByPK(string userID, long balance, TransactionManager tm_ = null)
		{
			RepairPutBalanceByPKData(userID, balance, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBalanceByPKAsync(string userID, long balance, TransactionManager tm_ = null)
		{
			RepairPutBalanceByPKData(userID, balance, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBalanceByPKData(string userID, long balance, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Balance` = @Balance  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Balance", balance, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "balance">余额</param>
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
		#region PutBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "bonus">bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonusByPK(string userID, long bonus, TransactionManager tm_ = null)
		{
			RepairPutBonusByPKData(userID, bonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBonusByPKAsync(string userID, long bonus, TransactionManager tm_ = null)
		{
			RepairPutBonusByPKData(userID, bonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBonusByPKData(string userID, long bonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bonus">bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonus(long bonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus";
			var parameter_ = Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBonusAsync(long bonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Bonus` = @Bonus";
			var parameter_ = Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBonus
		#region PutHistoryBetCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "historyBetCount">历史总下注手数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHistoryBetCountByPK(string userID, int historyBetCount, TransactionManager tm_ = null)
		{
			RepairPutHistoryBetCountByPKData(userID, historyBetCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHistoryBetCountByPKAsync(string userID, int historyBetCount, TransactionManager tm_ = null)
		{
			RepairPutHistoryBetCountByPKData(userID, historyBetCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHistoryBetCountByPKData(string userID, int historyBetCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HistoryBetCount` = @HistoryBetCount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HistoryBetCount", historyBetCount, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "historyBetCount">历史总下注手数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHistoryBetCount(int historyBetCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HistoryBetCount` = @HistoryBetCount";
			var parameter_ = Database.CreateInParameter("@HistoryBetCount", historyBetCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHistoryBetCountAsync(int historyBetCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HistoryBetCount` = @HistoryBetCount";
			var parameter_ = Database.CreateInParameter("@HistoryBetCount", historyBetCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHistoryBetCount
		#region PutHistoryWinAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "historyWinAmount">历史总盈亏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHistoryWinAmountByPK(string userID, long historyWinAmount, TransactionManager tm_ = null)
		{
			RepairPutHistoryWinAmountByPKData(userID, historyWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHistoryWinAmountByPKAsync(string userID, long historyWinAmount, TransactionManager tm_ = null)
		{
			RepairPutHistoryWinAmountByPKData(userID, historyWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHistoryWinAmountByPKData(string userID, long historyWinAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HistoryWinAmount` = @HistoryWinAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HistoryWinAmount", historyWinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "historyWinAmount">历史总盈亏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHistoryWinAmount(long historyWinAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HistoryWinAmount` = @HistoryWinAmount";
			var parameter_ = Database.CreateInParameter("@HistoryWinAmount", historyWinAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHistoryWinAmountAsync(long historyWinAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HistoryWinAmount` = @HistoryWinAmount";
			var parameter_ = Database.CreateInParameter("@HistoryWinAmount", historyWinAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHistoryWinAmount
		#region PutHistoryBetAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "historyBetAmount">历史总下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHistoryBetAmountByPK(string userID, long historyBetAmount, TransactionManager tm_ = null)
		{
			RepairPutHistoryBetAmountByPKData(userID, historyBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHistoryBetAmountByPKAsync(string userID, long historyBetAmount, TransactionManager tm_ = null)
		{
			RepairPutHistoryBetAmountByPKData(userID, historyBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHistoryBetAmountByPKData(string userID, long historyBetAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HistoryBetAmount` = @HistoryBetAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HistoryBetAmount", historyBetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "historyBetAmount">历史总下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHistoryBetAmount(long historyBetAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HistoryBetAmount` = @HistoryBetAmount";
			var parameter_ = Database.CreateInParameter("@HistoryBetAmount", historyBetAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHistoryBetAmountAsync(long historyBetAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HistoryBetAmount` = @HistoryBetAmount";
			var parameter_ = Database.CreateInParameter("@HistoryBetAmount", historyBetAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHistoryBetAmount
		#region PutRefundLv
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "refundLv">用户等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRefundLvByPK(string userID, int refundLv, TransactionManager tm_ = null)
		{
			RepairPutRefundLvByPKData(userID, refundLv, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRefundLvByPKAsync(string userID, int refundLv, TransactionManager tm_ = null)
		{
			RepairPutRefundLvByPKData(userID, refundLv, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRefundLvByPKData(string userID, int refundLv, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RefundLv` = @RefundLv  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RefundLv", refundLv, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "refundLv">用户等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRefundLv(int refundLv, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RefundLv` = @RefundLv";
			var parameter_ = Database.CreateInParameter("@RefundLv", refundLv, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRefundLvAsync(int refundLv, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RefundLv` = @RefundLv";
			var parameter_ = Database.CreateInParameter("@RefundLv", refundLv, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRefundLv
		#region PutRefundNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "refundNum">每日输反次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRefundNumByPK(string userID, int refundNum, TransactionManager tm_ = null)
		{
			RepairPutRefundNumByPKData(userID, refundNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRefundNumByPKAsync(string userID, int refundNum, TransactionManager tm_ = null)
		{
			RepairPutRefundNumByPKData(userID, refundNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRefundNumByPKData(string userID, int refundNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RefundNum` = @RefundNum  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RefundNum", refundNum, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "refundNum">每日输反次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRefundNum(int refundNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RefundNum` = @RefundNum";
			var parameter_ = Database.CreateInParameter("@RefundNum", refundNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRefundNumAsync(int refundNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RefundNum` = @RefundNum";
			var parameter_ = Database.CreateInParameter("@RefundNum", refundNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRefundNum
		#region PutRTP
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "rTP">用户返奖率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRTPByPK(string userID, double rTP, TransactionManager tm_ = null)
		{
			RepairPutRTPByPKData(userID, rTP, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRTPByPKAsync(string userID, double rTP, TransactionManager tm_ = null)
		{
			RepairPutRTPByPKData(userID, rTP, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRTPByPKData(string userID, double rTP, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RTP` = @RTP  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RTP", rTP, MySqlDbType.Double),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rTP">用户返奖率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRTP(double rTP, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RTP` = @RTP";
			var parameter_ = Database.CreateInParameter("@RTP", rTP, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRTPAsync(double rTP, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RTP` = @RTP";
			var parameter_ = Database.CreateInParameter("@RTP", rTP, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRTP
		#region PutUserStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "userStatus">1-正常 0-异常</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserStatusByPK(string userID, bool userStatus, TransactionManager tm_ = null)
		{
			RepairPutUserStatusByPKData(userID, userStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserStatusByPKAsync(string userID, bool userStatus, TransactionManager tm_ = null)
		{
			RepairPutUserStatusByPKData(userID, userStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserStatusByPKData(string userID, bool userStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserStatus` = @UserStatus  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserStatus", userStatus, MySqlDbType.Byte),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userStatus">1-正常 0-异常</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserStatus(bool userStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserStatus` = @UserStatus";
			var parameter_ = Database.CreateInParameter("@UserStatus", userStatus, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserStatusAsync(bool userStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserStatus` = @UserStatus";
			var parameter_ = Database.CreateInParameter("@UserStatus", userStatus, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserStatus
		#region PutLastRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastRecDateByPK(string userID, DateTime? lastRecDate, TransactionManager tm_ = null)
		{
			RepairPutLastRecDateByPKData(userID, lastRecDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLastRecDateByPKAsync(string userID, DateTime? lastRecDate, TransactionManager tm_ = null)
		{
			RepairPutLastRecDateByPKData(userID, lastRecDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLastRecDateByPKData(string userID, DateTime? lastRecDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LastRecDate` = @LastRecDate  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LastRecDate", lastRecDate.HasValue ? lastRecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastRecDate(DateTime? lastRecDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastRecDate` = @LastRecDate";
			var parameter_ = Database.CreateInParameter("@LastRecDate", lastRecDate.HasValue ? lastRecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLastRecDateAsync(DateTime? lastRecDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastRecDate` = @LastRecDate";
			var parameter_ = Database.CreateInParameter("@LastRecDate", lastRecDate.HasValue ? lastRecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLastRecDate
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Slot_user_extEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID) == null)
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
		public async Task<bool> SetAsync(Slot_user_extEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID) == null)
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
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Slot_user_extEO GetByPK(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		public async Task<Slot_user_extEO> GetByPKAsync(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		private void RepairGetByPKData(string userID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`UserID` = @UserID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserFlag（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetUserFlagByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`UserFlag`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetUserFlagByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`UserFlag`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Balance（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBalanceByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Balance`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetBalanceByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Balance`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Bonus（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBonusByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Bonus`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetBonusByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Bonus`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HistoryBetCount（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetHistoryBetCountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`HistoryBetCount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetHistoryBetCountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`HistoryBetCount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HistoryWinAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetHistoryWinAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`HistoryWinAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetHistoryWinAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`HistoryWinAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HistoryBetAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetHistoryBetAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`HistoryBetAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetHistoryBetAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`HistoryBetAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RefundLv（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetRefundLvByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`RefundLv`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetRefundLvByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`RefundLv`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RefundNum（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetRefundNumByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`RefundNum`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetRefundNumByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`RefundNum`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RTP（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetRTPByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (double)GetScalar("`RTP`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<double> GetRTPByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (double)await GetScalarAsync("`RTP`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserStatus（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetUserStatusByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`UserStatus`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<bool> GetUserStatusByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`UserStatus`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LastRecDate（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetLastRecDateByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`LastRecDate`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime?> GetLastRecDateByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`LastRecDate`", "`UserID` = @UserID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByAppIDAsync(string appID, int top_)
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
		public List<Slot_user_extEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<Slot_user_extEO>> GetByAppIDAsync(string appID, string sort_)
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
		public List<Slot_user_extEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
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
		public List<Slot_user_extEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		public async Task<List<Slot_user_extEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Slot_user_extEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Slot_user_extEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Slot_user_extEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Slot_user_extEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		public async Task<List<Slot_user_extEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Slot_user_extEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Slot_user_extEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Slot_user_extEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Slot_user_extEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		public async Task<List<Slot_user_extEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByUserFlag
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户标识</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByUserFlag(long userFlag)
		{
			return GetByUserFlag(userFlag, 0, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByUserFlagAsync(long userFlag)
		{
			return await GetByUserFlagAsync(userFlag, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户标识</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByUserFlag(long userFlag, TransactionManager tm_)
		{
			return GetByUserFlag(userFlag, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByUserFlagAsync(long userFlag, TransactionManager tm_)
		{
			return await GetByUserFlagAsync(userFlag, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户标识</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByUserFlag(long userFlag, int top_)
		{
			return GetByUserFlag(userFlag, top_, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByUserFlagAsync(long userFlag, int top_)
		{
			return await GetByUserFlagAsync(userFlag, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户标识</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByUserFlag(long userFlag, int top_, TransactionManager tm_)
		{
			return GetByUserFlag(userFlag, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByUserFlagAsync(long userFlag, int top_, TransactionManager tm_)
		{
			return await GetByUserFlagAsync(userFlag, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户标识</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByUserFlag(long userFlag, string sort_)
		{
			return GetByUserFlag(userFlag, 0, sort_, null);
		}
		public async Task<List<Slot_user_extEO>> GetByUserFlagAsync(long userFlag, string sort_)
		{
			return await GetByUserFlagAsync(userFlag, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户标识</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByUserFlag(long userFlag, string sort_, TransactionManager tm_)
		{
			return GetByUserFlag(userFlag, 0, sort_, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByUserFlagAsync(long userFlag, string sort_, TransactionManager tm_)
		{
			return await GetByUserFlagAsync(userFlag, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户标识</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByUserFlag(long userFlag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserFlag` = @UserFlag", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserFlag", userFlag, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		public async Task<List<Slot_user_extEO>> GetByUserFlagAsync(long userFlag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserFlag` = @UserFlag", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserFlag", userFlag, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		#endregion // GetByUserFlag
		#region GetByBalance
		
		/// <summary>
		/// 按 Balance（字段） 查询
		/// </summary>
		/// /// <param name = "balance">余额</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByBalance(long balance)
		{
			return GetByBalance(balance, 0, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByBalanceAsync(long balance)
		{
			return await GetByBalanceAsync(balance, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Balance（字段） 查询
		/// </summary>
		/// /// <param name = "balance">余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByBalance(long balance, TransactionManager tm_)
		{
			return GetByBalance(balance, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByBalanceAsync(long balance, TransactionManager tm_)
		{
			return await GetByBalanceAsync(balance, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Balance（字段） 查询
		/// </summary>
		/// /// <param name = "balance">余额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByBalance(long balance, int top_)
		{
			return GetByBalance(balance, top_, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByBalanceAsync(long balance, int top_)
		{
			return await GetByBalanceAsync(balance, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Balance（字段） 查询
		/// </summary>
		/// /// <param name = "balance">余额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByBalance(long balance, int top_, TransactionManager tm_)
		{
			return GetByBalance(balance, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByBalanceAsync(long balance, int top_, TransactionManager tm_)
		{
			return await GetByBalanceAsync(balance, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Balance（字段） 查询
		/// </summary>
		/// /// <param name = "balance">余额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByBalance(long balance, string sort_)
		{
			return GetByBalance(balance, 0, sort_, null);
		}
		public async Task<List<Slot_user_extEO>> GetByBalanceAsync(long balance, string sort_)
		{
			return await GetByBalanceAsync(balance, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Balance（字段） 查询
		/// </summary>
		/// /// <param name = "balance">余额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByBalance(long balance, string sort_, TransactionManager tm_)
		{
			return GetByBalance(balance, 0, sort_, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByBalanceAsync(long balance, string sort_, TransactionManager tm_)
		{
			return await GetByBalanceAsync(balance, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Balance（字段） 查询
		/// </summary>
		/// /// <param name = "balance">余额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByBalance(long balance, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Balance` = @Balance", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Balance", balance, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		public async Task<List<Slot_user_extEO>> GetByBalanceAsync(long balance, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Balance` = @Balance", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Balance", balance, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		#endregion // GetByBalance
		#region GetByBonus
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">bonus</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByBonus(long bonus)
		{
			return GetByBonus(bonus, 0, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByBonusAsync(long bonus)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByBonus(long bonus, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByBonusAsync(long bonus, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByBonus(long bonus, int top_)
		{
			return GetByBonus(bonus, top_, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByBonusAsync(long bonus, int top_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByBonus(long bonus, int top_, TransactionManager tm_)
		{
			return GetByBonus(bonus, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByBonusAsync(long bonus, int top_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByBonus(long bonus, string sort_)
		{
			return GetByBonus(bonus, 0, sort_, null);
		}
		public async Task<List<Slot_user_extEO>> GetByBonusAsync(long bonus, string sort_)
		{
			return await GetByBonusAsync(bonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByBonus(long bonus, string sort_, TransactionManager tm_)
		{
			return GetByBonus(bonus, 0, sort_, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByBonusAsync(long bonus, string sort_, TransactionManager tm_)
		{
			return await GetByBonusAsync(bonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Bonus（字段） 查询
		/// </summary>
		/// /// <param name = "bonus">bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByBonus(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		public async Task<List<Slot_user_extEO>> GetByBonusAsync(long bonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bonus` = @Bonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bonus", bonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		#endregion // GetByBonus
		#region GetByHistoryBetCount
		
		/// <summary>
		/// 按 HistoryBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "historyBetCount">历史总下注手数</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryBetCount(int historyBetCount)
		{
			return GetByHistoryBetCount(historyBetCount, 0, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryBetCountAsync(int historyBetCount)
		{
			return await GetByHistoryBetCountAsync(historyBetCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HistoryBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "historyBetCount">历史总下注手数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryBetCount(int historyBetCount, TransactionManager tm_)
		{
			return GetByHistoryBetCount(historyBetCount, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryBetCountAsync(int historyBetCount, TransactionManager tm_)
		{
			return await GetByHistoryBetCountAsync(historyBetCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "historyBetCount">历史总下注手数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryBetCount(int historyBetCount, int top_)
		{
			return GetByHistoryBetCount(historyBetCount, top_, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryBetCountAsync(int historyBetCount, int top_)
		{
			return await GetByHistoryBetCountAsync(historyBetCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HistoryBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "historyBetCount">历史总下注手数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryBetCount(int historyBetCount, int top_, TransactionManager tm_)
		{
			return GetByHistoryBetCount(historyBetCount, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryBetCountAsync(int historyBetCount, int top_, TransactionManager tm_)
		{
			return await GetByHistoryBetCountAsync(historyBetCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "historyBetCount">历史总下注手数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryBetCount(int historyBetCount, string sort_)
		{
			return GetByHistoryBetCount(historyBetCount, 0, sort_, null);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryBetCountAsync(int historyBetCount, string sort_)
		{
			return await GetByHistoryBetCountAsync(historyBetCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HistoryBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "historyBetCount">历史总下注手数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryBetCount(int historyBetCount, string sort_, TransactionManager tm_)
		{
			return GetByHistoryBetCount(historyBetCount, 0, sort_, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryBetCountAsync(int historyBetCount, string sort_, TransactionManager tm_)
		{
			return await GetByHistoryBetCountAsync(historyBetCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HistoryBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "historyBetCount">历史总下注手数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryBetCount(int historyBetCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryBetCount` = @HistoryBetCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryBetCount", historyBetCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryBetCountAsync(int historyBetCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryBetCount` = @HistoryBetCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryBetCount", historyBetCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		#endregion // GetByHistoryBetCount
		#region GetByHistoryWinAmount
		
		/// <summary>
		/// 按 HistoryWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "historyWinAmount">历史总盈亏</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryWinAmount(long historyWinAmount)
		{
			return GetByHistoryWinAmount(historyWinAmount, 0, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryWinAmountAsync(long historyWinAmount)
		{
			return await GetByHistoryWinAmountAsync(historyWinAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HistoryWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "historyWinAmount">历史总盈亏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryWinAmount(long historyWinAmount, TransactionManager tm_)
		{
			return GetByHistoryWinAmount(historyWinAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryWinAmountAsync(long historyWinAmount, TransactionManager tm_)
		{
			return await GetByHistoryWinAmountAsync(historyWinAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "historyWinAmount">历史总盈亏</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryWinAmount(long historyWinAmount, int top_)
		{
			return GetByHistoryWinAmount(historyWinAmount, top_, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryWinAmountAsync(long historyWinAmount, int top_)
		{
			return await GetByHistoryWinAmountAsync(historyWinAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HistoryWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "historyWinAmount">历史总盈亏</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryWinAmount(long historyWinAmount, int top_, TransactionManager tm_)
		{
			return GetByHistoryWinAmount(historyWinAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryWinAmountAsync(long historyWinAmount, int top_, TransactionManager tm_)
		{
			return await GetByHistoryWinAmountAsync(historyWinAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "historyWinAmount">历史总盈亏</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryWinAmount(long historyWinAmount, string sort_)
		{
			return GetByHistoryWinAmount(historyWinAmount, 0, sort_, null);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryWinAmountAsync(long historyWinAmount, string sort_)
		{
			return await GetByHistoryWinAmountAsync(historyWinAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HistoryWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "historyWinAmount">历史总盈亏</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryWinAmount(long historyWinAmount, string sort_, TransactionManager tm_)
		{
			return GetByHistoryWinAmount(historyWinAmount, 0, sort_, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryWinAmountAsync(long historyWinAmount, string sort_, TransactionManager tm_)
		{
			return await GetByHistoryWinAmountAsync(historyWinAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HistoryWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "historyWinAmount">历史总盈亏</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryWinAmount(long historyWinAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryWinAmount` = @HistoryWinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryWinAmount", historyWinAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryWinAmountAsync(long historyWinAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryWinAmount` = @HistoryWinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryWinAmount", historyWinAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		#endregion // GetByHistoryWinAmount
		#region GetByHistoryBetAmount
		
		/// <summary>
		/// 按 HistoryBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "historyBetAmount">历史总下注金额</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryBetAmount(long historyBetAmount)
		{
			return GetByHistoryBetAmount(historyBetAmount, 0, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryBetAmountAsync(long historyBetAmount)
		{
			return await GetByHistoryBetAmountAsync(historyBetAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HistoryBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "historyBetAmount">历史总下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryBetAmount(long historyBetAmount, TransactionManager tm_)
		{
			return GetByHistoryBetAmount(historyBetAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryBetAmountAsync(long historyBetAmount, TransactionManager tm_)
		{
			return await GetByHistoryBetAmountAsync(historyBetAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "historyBetAmount">历史总下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryBetAmount(long historyBetAmount, int top_)
		{
			return GetByHistoryBetAmount(historyBetAmount, top_, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryBetAmountAsync(long historyBetAmount, int top_)
		{
			return await GetByHistoryBetAmountAsync(historyBetAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HistoryBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "historyBetAmount">历史总下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryBetAmount(long historyBetAmount, int top_, TransactionManager tm_)
		{
			return GetByHistoryBetAmount(historyBetAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryBetAmountAsync(long historyBetAmount, int top_, TransactionManager tm_)
		{
			return await GetByHistoryBetAmountAsync(historyBetAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "historyBetAmount">历史总下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryBetAmount(long historyBetAmount, string sort_)
		{
			return GetByHistoryBetAmount(historyBetAmount, 0, sort_, null);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryBetAmountAsync(long historyBetAmount, string sort_)
		{
			return await GetByHistoryBetAmountAsync(historyBetAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HistoryBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "historyBetAmount">历史总下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryBetAmount(long historyBetAmount, string sort_, TransactionManager tm_)
		{
			return GetByHistoryBetAmount(historyBetAmount, 0, sort_, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryBetAmountAsync(long historyBetAmount, string sort_, TransactionManager tm_)
		{
			return await GetByHistoryBetAmountAsync(historyBetAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HistoryBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "historyBetAmount">历史总下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByHistoryBetAmount(long historyBetAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryBetAmount` = @HistoryBetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryBetAmount", historyBetAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		public async Task<List<Slot_user_extEO>> GetByHistoryBetAmountAsync(long historyBetAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryBetAmount` = @HistoryBetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryBetAmount", historyBetAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		#endregion // GetByHistoryBetAmount
		#region GetByRefundLv
		
		/// <summary>
		/// 按 RefundLv（字段） 查询
		/// </summary>
		/// /// <param name = "refundLv">用户等级</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRefundLv(int refundLv)
		{
			return GetByRefundLv(refundLv, 0, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByRefundLvAsync(int refundLv)
		{
			return await GetByRefundLvAsync(refundLv, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RefundLv（字段） 查询
		/// </summary>
		/// /// <param name = "refundLv">用户等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRefundLv(int refundLv, TransactionManager tm_)
		{
			return GetByRefundLv(refundLv, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByRefundLvAsync(int refundLv, TransactionManager tm_)
		{
			return await GetByRefundLvAsync(refundLv, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RefundLv（字段） 查询
		/// </summary>
		/// /// <param name = "refundLv">用户等级</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRefundLv(int refundLv, int top_)
		{
			return GetByRefundLv(refundLv, top_, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByRefundLvAsync(int refundLv, int top_)
		{
			return await GetByRefundLvAsync(refundLv, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RefundLv（字段） 查询
		/// </summary>
		/// /// <param name = "refundLv">用户等级</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRefundLv(int refundLv, int top_, TransactionManager tm_)
		{
			return GetByRefundLv(refundLv, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByRefundLvAsync(int refundLv, int top_, TransactionManager tm_)
		{
			return await GetByRefundLvAsync(refundLv, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RefundLv（字段） 查询
		/// </summary>
		/// /// <param name = "refundLv">用户等级</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRefundLv(int refundLv, string sort_)
		{
			return GetByRefundLv(refundLv, 0, sort_, null);
		}
		public async Task<List<Slot_user_extEO>> GetByRefundLvAsync(int refundLv, string sort_)
		{
			return await GetByRefundLvAsync(refundLv, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RefundLv（字段） 查询
		/// </summary>
		/// /// <param name = "refundLv">用户等级</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRefundLv(int refundLv, string sort_, TransactionManager tm_)
		{
			return GetByRefundLv(refundLv, 0, sort_, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByRefundLvAsync(int refundLv, string sort_, TransactionManager tm_)
		{
			return await GetByRefundLvAsync(refundLv, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RefundLv（字段） 查询
		/// </summary>
		/// /// <param name = "refundLv">用户等级</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRefundLv(int refundLv, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RefundLv` = @RefundLv", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundLv", refundLv, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		public async Task<List<Slot_user_extEO>> GetByRefundLvAsync(int refundLv, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RefundLv` = @RefundLv", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundLv", refundLv, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		#endregion // GetByRefundLv
		#region GetByRefundNum
		
		/// <summary>
		/// 按 RefundNum（字段） 查询
		/// </summary>
		/// /// <param name = "refundNum">每日输反次数</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRefundNum(int refundNum)
		{
			return GetByRefundNum(refundNum, 0, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByRefundNumAsync(int refundNum)
		{
			return await GetByRefundNumAsync(refundNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RefundNum（字段） 查询
		/// </summary>
		/// /// <param name = "refundNum">每日输反次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRefundNum(int refundNum, TransactionManager tm_)
		{
			return GetByRefundNum(refundNum, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByRefundNumAsync(int refundNum, TransactionManager tm_)
		{
			return await GetByRefundNumAsync(refundNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RefundNum（字段） 查询
		/// </summary>
		/// /// <param name = "refundNum">每日输反次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRefundNum(int refundNum, int top_)
		{
			return GetByRefundNum(refundNum, top_, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByRefundNumAsync(int refundNum, int top_)
		{
			return await GetByRefundNumAsync(refundNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RefundNum（字段） 查询
		/// </summary>
		/// /// <param name = "refundNum">每日输反次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRefundNum(int refundNum, int top_, TransactionManager tm_)
		{
			return GetByRefundNum(refundNum, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByRefundNumAsync(int refundNum, int top_, TransactionManager tm_)
		{
			return await GetByRefundNumAsync(refundNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RefundNum（字段） 查询
		/// </summary>
		/// /// <param name = "refundNum">每日输反次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRefundNum(int refundNum, string sort_)
		{
			return GetByRefundNum(refundNum, 0, sort_, null);
		}
		public async Task<List<Slot_user_extEO>> GetByRefundNumAsync(int refundNum, string sort_)
		{
			return await GetByRefundNumAsync(refundNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RefundNum（字段） 查询
		/// </summary>
		/// /// <param name = "refundNum">每日输反次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRefundNum(int refundNum, string sort_, TransactionManager tm_)
		{
			return GetByRefundNum(refundNum, 0, sort_, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByRefundNumAsync(int refundNum, string sort_, TransactionManager tm_)
		{
			return await GetByRefundNumAsync(refundNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RefundNum（字段） 查询
		/// </summary>
		/// /// <param name = "refundNum">每日输反次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRefundNum(int refundNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RefundNum` = @RefundNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundNum", refundNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		public async Task<List<Slot_user_extEO>> GetByRefundNumAsync(int refundNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RefundNum` = @RefundNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundNum", refundNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		#endregion // GetByRefundNum
		#region GetByRTP
		
		/// <summary>
		/// 按 RTP（字段） 查询
		/// </summary>
		/// /// <param name = "rTP">用户返奖率</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRTP(double rTP)
		{
			return GetByRTP(rTP, 0, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByRTPAsync(double rTP)
		{
			return await GetByRTPAsync(rTP, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RTP（字段） 查询
		/// </summary>
		/// /// <param name = "rTP">用户返奖率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRTP(double rTP, TransactionManager tm_)
		{
			return GetByRTP(rTP, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByRTPAsync(double rTP, TransactionManager tm_)
		{
			return await GetByRTPAsync(rTP, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RTP（字段） 查询
		/// </summary>
		/// /// <param name = "rTP">用户返奖率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRTP(double rTP, int top_)
		{
			return GetByRTP(rTP, top_, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByRTPAsync(double rTP, int top_)
		{
			return await GetByRTPAsync(rTP, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RTP（字段） 查询
		/// </summary>
		/// /// <param name = "rTP">用户返奖率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRTP(double rTP, int top_, TransactionManager tm_)
		{
			return GetByRTP(rTP, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByRTPAsync(double rTP, int top_, TransactionManager tm_)
		{
			return await GetByRTPAsync(rTP, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RTP（字段） 查询
		/// </summary>
		/// /// <param name = "rTP">用户返奖率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRTP(double rTP, string sort_)
		{
			return GetByRTP(rTP, 0, sort_, null);
		}
		public async Task<List<Slot_user_extEO>> GetByRTPAsync(double rTP, string sort_)
		{
			return await GetByRTPAsync(rTP, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RTP（字段） 查询
		/// </summary>
		/// /// <param name = "rTP">用户返奖率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRTP(double rTP, string sort_, TransactionManager tm_)
		{
			return GetByRTP(rTP, 0, sort_, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByRTPAsync(double rTP, string sort_, TransactionManager tm_)
		{
			return await GetByRTPAsync(rTP, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RTP（字段） 查询
		/// </summary>
		/// /// <param name = "rTP">用户返奖率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByRTP(double rTP, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RTP` = @RTP", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RTP", rTP, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		public async Task<List<Slot_user_extEO>> GetByRTPAsync(double rTP, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RTP` = @RTP", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RTP", rTP, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		#endregion // GetByRTP
		#region GetByUserStatus
		
		/// <summary>
		/// 按 UserStatus（字段） 查询
		/// </summary>
		/// /// <param name = "userStatus">1-正常 0-异常</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByUserStatus(bool userStatus)
		{
			return GetByUserStatus(userStatus, 0, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByUserStatusAsync(bool userStatus)
		{
			return await GetByUserStatusAsync(userStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserStatus（字段） 查询
		/// </summary>
		/// /// <param name = "userStatus">1-正常 0-异常</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByUserStatus(bool userStatus, TransactionManager tm_)
		{
			return GetByUserStatus(userStatus, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByUserStatusAsync(bool userStatus, TransactionManager tm_)
		{
			return await GetByUserStatusAsync(userStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserStatus（字段） 查询
		/// </summary>
		/// /// <param name = "userStatus">1-正常 0-异常</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByUserStatus(bool userStatus, int top_)
		{
			return GetByUserStatus(userStatus, top_, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByUserStatusAsync(bool userStatus, int top_)
		{
			return await GetByUserStatusAsync(userStatus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserStatus（字段） 查询
		/// </summary>
		/// /// <param name = "userStatus">1-正常 0-异常</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByUserStatus(bool userStatus, int top_, TransactionManager tm_)
		{
			return GetByUserStatus(userStatus, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByUserStatusAsync(bool userStatus, int top_, TransactionManager tm_)
		{
			return await GetByUserStatusAsync(userStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserStatus（字段） 查询
		/// </summary>
		/// /// <param name = "userStatus">1-正常 0-异常</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByUserStatus(bool userStatus, string sort_)
		{
			return GetByUserStatus(userStatus, 0, sort_, null);
		}
		public async Task<List<Slot_user_extEO>> GetByUserStatusAsync(bool userStatus, string sort_)
		{
			return await GetByUserStatusAsync(userStatus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserStatus（字段） 查询
		/// </summary>
		/// /// <param name = "userStatus">1-正常 0-异常</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByUserStatus(bool userStatus, string sort_, TransactionManager tm_)
		{
			return GetByUserStatus(userStatus, 0, sort_, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByUserStatusAsync(bool userStatus, string sort_, TransactionManager tm_)
		{
			return await GetByUserStatusAsync(userStatus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserStatus（字段） 查询
		/// </summary>
		/// /// <param name = "userStatus">1-正常 0-异常</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByUserStatus(bool userStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserStatus` = @UserStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserStatus", userStatus, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		public async Task<List<Slot_user_extEO>> GetByUserStatusAsync(bool userStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserStatus` = @UserStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserStatus", userStatus, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		#endregion // GetByUserStatus
		#region GetByLastRecDate
		
		/// <summary>
		/// 按 LastRecDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByLastRecDate(DateTime? lastRecDate)
		{
			return GetByLastRecDate(lastRecDate, 0, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByLastRecDateAsync(DateTime? lastRecDate)
		{
			return await GetByLastRecDateAsync(lastRecDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastRecDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByLastRecDate(DateTime? lastRecDate, TransactionManager tm_)
		{
			return GetByLastRecDate(lastRecDate, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByLastRecDateAsync(DateTime? lastRecDate, TransactionManager tm_)
		{
			return await GetByLastRecDateAsync(lastRecDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastRecDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByLastRecDate(DateTime? lastRecDate, int top_)
		{
			return GetByLastRecDate(lastRecDate, top_, string.Empty, null);
		}
		public async Task<List<Slot_user_extEO>> GetByLastRecDateAsync(DateTime? lastRecDate, int top_)
		{
			return await GetByLastRecDateAsync(lastRecDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastRecDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByLastRecDate(DateTime? lastRecDate, int top_, TransactionManager tm_)
		{
			return GetByLastRecDate(lastRecDate, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByLastRecDateAsync(DateTime? lastRecDate, int top_, TransactionManager tm_)
		{
			return await GetByLastRecDateAsync(lastRecDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastRecDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByLastRecDate(DateTime? lastRecDate, string sort_)
		{
			return GetByLastRecDate(lastRecDate, 0, sort_, null);
		}
		public async Task<List<Slot_user_extEO>> GetByLastRecDateAsync(DateTime? lastRecDate, string sort_)
		{
			return await GetByLastRecDateAsync(lastRecDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LastRecDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByLastRecDate(DateTime? lastRecDate, string sort_, TransactionManager tm_)
		{
			return GetByLastRecDate(lastRecDate, 0, sort_, tm_);
		}
		public async Task<List<Slot_user_extEO>> GetByLastRecDateAsync(DateTime? lastRecDate, string sort_, TransactionManager tm_)
		{
			return await GetByLastRecDateAsync(lastRecDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LastRecDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_user_extEO> GetByLastRecDate(DateTime? lastRecDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lastRecDate.HasValue ? "`LastRecDate` = @LastRecDate" : "`LastRecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lastRecDate.HasValue)
				paras_.Add(Database.CreateInParameter("@LastRecDate", lastRecDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		public async Task<List<Slot_user_extEO>> GetByLastRecDateAsync(DateTime? lastRecDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lastRecDate.HasValue ? "`LastRecDate` = @LastRecDate" : "`LastRecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lastRecDate.HasValue)
				paras_.Add(Database.CreateInParameter("@LastRecDate", lastRecDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_user_extEO.MapDataReader);
		}
		#endregion // GetByLastRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
