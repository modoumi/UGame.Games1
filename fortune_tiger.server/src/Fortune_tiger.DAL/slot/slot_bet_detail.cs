/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2024-01-30 16: 08:07
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
	/// 下注表
	/// 【表 slot_bet_detail 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Slot_bet_detailEO : IRowMapper<Slot_bet_detailEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Slot_bet_detailEO()
		{
			this.ChipsID = 0;
			this.BetBaseAmount = 0;
			this.BalanceAmount = 0;
			this.WinAmount = 0;
			this.TotalMultip = 0;
			this.TriggerHHSW = 0;
			this.TriggerHHSWIsWin = 0;
			this.TriggerMaxMultip = 0;
			this.HistoryLine = "0";
			this.HistoryMultip = "0";
			this.OrderStatus = 0;
			this.UserFlag = -1;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private long _originalBetID;
		/// <summary>
		/// 【数据库中的原始主键 BetID 值的副本，用于主键值更新】
		/// </summary>
		public long OriginalBetID
		{
			get { return _originalBetID; }
			set { HasOriginal = true; _originalBetID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "BetID", BetID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 主键
		/// 【主键 bigint】
		/// </summary>
		[DataMember(Order = 1)]
		public long BetID { get; set; }
		/// <summary>
		/// 下注配置ID
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int ChipsID { get; set; }
		/// <summary>
		/// appid
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string AppID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 用户Id
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 5)]
		public string UserID { get; set; }
		/// <summary>
		/// 实际下注金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long BetBaseAmount { get; set; }
		/// <summary>
		/// 下注后金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long BalanceAmount { get; set; }
		/// <summary>
		/// 是否中奖
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int IsWin { get; set; }
		/// <summary>
		/// 所有彩票的奖励总和
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 9)]
		public long WinAmount { get; set; }
		/// <summary>
		/// 中奖总倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 10)]
		public int TotalMultip { get; set; }
		/// <summary>
		/// 是否触发虎虎生威
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int TriggerHHSW { get; set; }
		/// <summary>
		/// 触发虎虎生威后是否中奖
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int TriggerHHSWIsWin { get; set; }
		/// <summary>
		/// 中五条线触发10倍率
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 13)]
		public int TriggerMaxMultip { get; set; }
		/// <summary>
		/// 25条线记录
		/// 【字段 varchar(1000)】
		/// </summary>
		[DataMember(Order = 14)]
		public string HistoryLine { get; set; }
		/// <summary>
		/// 25条线对应的倍率
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 15)]
		public string HistoryMultip { get; set; }
		/// <summary>
		/// 状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 16)]
		public int OrderStatus { get; set; }
		/// <summary>
		/// 中奖详情
		/// 【字段 varchar(1000)】
		/// </summary>
		[DataMember(Order = 17)]
		public string RewardDetails { get; set; }
		/// <summary>
		/// 返回给客户端数据结构
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 18)]
		public string SlotEleArray { get; set; }
		/// <summary>
		/// 虎虎生威数据结构
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 19)]
		public string BonusInfo { get; set; }
		/// <summary>
		/// wild数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 20)]
		public int WildNum { get; set; }
		/// <summary>
		/// 虎虎生威中奖id
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 21)]
		public int BonusItemId { get; set; }
		/// <summary>
		/// 走的哪个奖池
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 22)]
		public int PoolType { get; set; }
		/// <summary>
		/// 用户AB面
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 23)]
		public int UserFlag { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 24)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Slot_bet_detailEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Slot_bet_detailEO MapDataReader(IDataReader reader)
		{
		    Slot_bet_detailEO ret = new Slot_bet_detailEO();
			ret.BetID = reader.ToInt64("BetID");
			ret.OriginalBetID = ret.BetID;
			ret.ChipsID = reader.ToInt32("ChipsID");
			ret.AppID = reader.ToString("AppID");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.UserID = reader.ToString("UserID");
			ret.BetBaseAmount = reader.ToInt64("BetBaseAmount");
			ret.BalanceAmount = reader.ToInt64("BalanceAmount");
			ret.IsWin = reader.ToInt32("IsWin");
			ret.WinAmount = reader.ToInt64("WinAmount");
			ret.TotalMultip = reader.ToInt32("TotalMultip");
			ret.TriggerHHSW = reader.ToInt32("TriggerHHSW");
			ret.TriggerHHSWIsWin = reader.ToInt32("TriggerHHSWIsWin");
			ret.TriggerMaxMultip = reader.ToInt32("TriggerMaxMultip");
			ret.HistoryLine = reader.ToString("HistoryLine");
			ret.HistoryMultip = reader.ToString("HistoryMultip");
			ret.OrderStatus = reader.ToInt32("OrderStatus");
			ret.RewardDetails = reader.ToString("RewardDetails");
			ret.SlotEleArray = reader.ToString("SlotEleArray");
			ret.BonusInfo = reader.ToString("BonusInfo");
			ret.WildNum = reader.ToInt32("WildNum");
			ret.BonusItemId = reader.ToInt32("BonusItemId");
			ret.PoolType = reader.ToInt32("PoolType");
			ret.UserFlag = reader.ToInt32("UserFlag");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 下注表
	/// 【表 slot_bet_detail 的操作类】
	/// </summary>
	[Obsolete]
	public class Slot_bet_detailMO : MySqlTableMO<Slot_bet_detailEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`slot_bet_detail`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Slot_bet_detailMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Slot_bet_detailMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Slot_bet_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Slot_bet_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Slot_bet_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Slot_bet_detailEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`BetID`, `ChipsID`, `AppID`, `OperatorID`, `UserID`, `BetBaseAmount`, `BalanceAmount`, `IsWin`, `WinAmount`, `TotalMultip`, `TriggerHHSW`, `TriggerHHSWIsWin`, `TriggerMaxMultip`, `HistoryLine`, `HistoryMultip`, `OrderStatus`, `RewardDetails`, `SlotEleArray`, `BonusInfo`, `WildNum`, `BonusItemId`, `PoolType`, `UserFlag`, `RecDate`) VALUE (@BetID, @ChipsID, @AppID, @OperatorID, @UserID, @BetBaseAmount, @BalanceAmount, @IsWin, @WinAmount, @TotalMultip, @TriggerHHSW, @TriggerHHSWIsWin, @TriggerMaxMultip, @HistoryLine, @HistoryMultip, @OrderStatus, @RewardDetails, @SlotEleArray, @BonusInfo, @WildNum, @BonusItemId, @PoolType, @UserFlag, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", item.BetID, MySqlDbType.Int64),
				Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetBaseAmount", item.BetBaseAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BalanceAmount", item.BalanceAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@IsWin", item.IsWin, MySqlDbType.Int32),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalMultip", item.TotalMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@TriggerHHSW", item.TriggerHHSW, MySqlDbType.Int32),
				Database.CreateInParameter("@TriggerHHSWIsWin", item.TriggerHHSWIsWin, MySqlDbType.Int32),
				Database.CreateInParameter("@TriggerMaxMultip", item.TriggerMaxMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@HistoryLine", item.HistoryLine, MySqlDbType.VarChar),
				Database.CreateInParameter("@HistoryMultip", item.HistoryMultip, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderStatus", item.OrderStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardDetails", item.RewardDetails, MySqlDbType.VarChar),
				Database.CreateInParameter("@SlotEleArray", item.SlotEleArray, MySqlDbType.VarChar),
				Database.CreateInParameter("@BonusInfo", item.BonusInfo, MySqlDbType.VarChar),
				Database.CreateInParameter("@WildNum", item.WildNum, MySqlDbType.Int32),
				Database.CreateInParameter("@BonusItemId", item.BonusItemId, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", item.PoolType, MySqlDbType.Int32),
				Database.CreateInParameter("@UserFlag", item.UserFlag, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Slot_bet_detailEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Slot_bet_detailEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Slot_bet_detailEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`BetID`, `ChipsID`, `AppID`, `OperatorID`, `UserID`, `BetBaseAmount`, `BalanceAmount`, `IsWin`, `WinAmount`, `TotalMultip`, `TriggerHHSW`, `TriggerHHSWIsWin`, `TriggerMaxMultip`, `HistoryLine`, `HistoryMultip`, `OrderStatus`, `RewardDetails`, `SlotEleArray`, `BonusInfo`, `WildNum`, `BonusItemId`, `PoolType`, `UserFlag`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.BetID},{item.ChipsID},'{item.AppID}','{item.OperatorID}','{item.UserID}',{item.BetBaseAmount},{item.BalanceAmount},{item.IsWin},{item.WinAmount},{item.TotalMultip},{item.TriggerHHSW},{item.TriggerHHSWIsWin},{item.TriggerMaxMultip},'{item.HistoryLine}','{item.HistoryMultip}',{item.OrderStatus},'{item.RewardDetails}','{item.SlotEleArray}','{item.BonusInfo}',{item.WildNum},{item.BonusItemId},{item.PoolType},{item.UserFlag},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(long betID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(betID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(long betID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(betID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(long betID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Slot_bet_detailEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.BetID, tm_);
		}
		public async Task<int> RemoveAsync(Slot_bet_detailEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.BetID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByChipsID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
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
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
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
		#region RemoveByBetBaseAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetBaseAmount(long betBaseAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetBaseAmountData(betBaseAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetBaseAmountAsync(long betBaseAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetBaseAmountData(betBaseAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetBaseAmountData(long betBaseAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetBaseAmount` = @BetBaseAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetBaseAmount
		#region RemoveByBalanceAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "balanceAmount">下注后金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBalanceAmount(long balanceAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBalanceAmountData(balanceAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBalanceAmountAsync(long balanceAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBalanceAmountData(balanceAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBalanceAmountData(long balanceAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BalanceAmount` = @BalanceAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BalanceAmount", balanceAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByBalanceAmount
		#region RemoveByIsWin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsWin(int isWin, TransactionManager tm_ = null)
		{
			RepairRemoveByIsWinData(isWin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsWinAsync(int isWin, TransactionManager tm_ = null)
		{
			RepairRemoveByIsWinData(isWin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsWinData(int isWin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsWin` = @IsWin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Int32));
		}
		#endregion // RemoveByIsWin
		#region RemoveByWinAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWinAmount(long winAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinAmountData(winAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWinAmountAsync(long winAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinAmountData(winAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWinAmountData(long winAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WinAmount` = @WinAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByWinAmount
		#region RemoveByTotalMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalMultip(int totalMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalMultipData(totalMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalMultipAsync(int totalMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalMultipData(totalMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalMultipData(int totalMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalMultip` = @TotalMultip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalMultip", totalMultip, MySqlDbType.Int32));
		}
		#endregion // RemoveByTotalMultip
		#region RemoveByTriggerHHSW
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "triggerHHSW">是否触发虎虎生威</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTriggerHHSW(int triggerHHSW, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerHHSWData(triggerHHSW, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTriggerHHSWAsync(int triggerHHSW, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerHHSWData(triggerHHSW, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTriggerHHSWData(int triggerHHSW, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TriggerHHSW` = @TriggerHHSW";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerHHSW", triggerHHSW, MySqlDbType.Int32));
		}
		#endregion // RemoveByTriggerHHSW
		#region RemoveByTriggerHHSWIsWin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "triggerHHSWIsWin">触发虎虎生威后是否中奖</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTriggerHHSWIsWin(int triggerHHSWIsWin, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerHHSWIsWinData(triggerHHSWIsWin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTriggerHHSWIsWinAsync(int triggerHHSWIsWin, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerHHSWIsWinData(triggerHHSWIsWin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTriggerHHSWIsWinData(int triggerHHSWIsWin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TriggerHHSWIsWin` = @TriggerHHSWIsWin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerHHSWIsWin", triggerHHSWIsWin, MySqlDbType.Int32));
		}
		#endregion // RemoveByTriggerHHSWIsWin
		#region RemoveByTriggerMaxMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "triggerMaxMultip">中五条线触发10倍率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTriggerMaxMultip(int triggerMaxMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerMaxMultipData(triggerMaxMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTriggerMaxMultipAsync(int triggerMaxMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerMaxMultipData(triggerMaxMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTriggerMaxMultipData(int triggerMaxMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TriggerMaxMultip` = @TriggerMaxMultip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerMaxMultip", triggerMaxMultip, MySqlDbType.Int32));
		}
		#endregion // RemoveByTriggerMaxMultip
		#region RemoveByHistoryLine
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "historyLine">25条线记录</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHistoryLine(string historyLine, TransactionManager tm_ = null)
		{
			RepairRemoveByHistoryLineData(historyLine, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHistoryLineAsync(string historyLine, TransactionManager tm_ = null)
		{
			RepairRemoveByHistoryLineData(historyLine, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHistoryLineData(string historyLine, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HistoryLine` = @HistoryLine";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryLine", historyLine, MySqlDbType.VarChar));
		}
		#endregion // RemoveByHistoryLine
		#region RemoveByHistoryMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHistoryMultip(string historyMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByHistoryMultipData(historyMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHistoryMultipAsync(string historyMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByHistoryMultipData(historyMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHistoryMultipData(string historyMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HistoryMultip` = @HistoryMultip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryMultip", historyMultip, MySqlDbType.VarChar));
		}
		#endregion // RemoveByHistoryMultip
		#region RemoveByOrderStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOrderStatus(int orderStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderStatusData(orderStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOrderStatusAsync(int orderStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderStatusData(orderStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOrderStatusData(int orderStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OrderStatus` = @OrderStatus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32));
		}
		#endregion // RemoveByOrderStatus
		#region RemoveByRewardDetails
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardDetails">中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRewardDetails(string rewardDetails, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardDetailsData(rewardDetails, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRewardDetailsAsync(string rewardDetails, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardDetailsData(rewardDetails, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRewardDetailsData(string rewardDetails, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RewardDetails` = @RewardDetails";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardDetails", rewardDetails, MySqlDbType.VarChar));
		}
		#endregion // RemoveByRewardDetails
		#region RemoveBySlotEleArray
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "slotEleArray">返回给客户端数据结构</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySlotEleArray(string slotEleArray, TransactionManager tm_ = null)
		{
			RepairRemoveBySlotEleArrayData(slotEleArray, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySlotEleArrayAsync(string slotEleArray, TransactionManager tm_ = null)
		{
			RepairRemoveBySlotEleArrayData(slotEleArray, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySlotEleArrayData(string slotEleArray, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SlotEleArray` = @SlotEleArray";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SlotEleArray", slotEleArray, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySlotEleArray
		#region RemoveByBonusInfo
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bonusInfo">虎虎生威数据结构</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBonusInfo(string bonusInfo, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusInfoData(bonusInfo, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBonusInfoAsync(string bonusInfo, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusInfoData(bonusInfo, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBonusInfoData(string bonusInfo, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BonusInfo` = @BonusInfo";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BonusInfo", bonusInfo, MySqlDbType.VarChar));
		}
		#endregion // RemoveByBonusInfo
		#region RemoveByWildNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "wildNum">wild数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWildNum(int wildNum, TransactionManager tm_ = null)
		{
			RepairRemoveByWildNumData(wildNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWildNumAsync(int wildNum, TransactionManager tm_ = null)
		{
			RepairRemoveByWildNumData(wildNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWildNumData(int wildNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WildNum` = @WildNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WildNum", wildNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByWildNum
		#region RemoveByBonusItemId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bonusItemId">虎虎生威中奖id</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBonusItemId(int bonusItemId, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusItemIdData(bonusItemId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBonusItemIdAsync(int bonusItemId, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusItemIdData(bonusItemId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBonusItemIdData(int bonusItemId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BonusItemId` = @BonusItemId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BonusItemId", bonusItemId, MySqlDbType.Int32));
		}
		#endregion // RemoveByBonusItemId
		#region RemoveByPoolType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "poolType">走的哪个奖池</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPoolType(int poolType, TransactionManager tm_ = null)
		{
			RepairRemoveByPoolTypeData(poolType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPoolTypeAsync(int poolType, TransactionManager tm_ = null)
		{
			RepairRemoveByPoolTypeData(poolType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPoolTypeData(int poolType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PoolType` = @PoolType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32));
		}
		#endregion // RemoveByPoolType
		#region RemoveByUserFlag
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserFlag(int userFlag, TransactionManager tm_ = null)
		{
			RepairRemoveByUserFlagData(userFlag, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserFlagAsync(int userFlag, TransactionManager tm_ = null)
		{
			RepairRemoveByUserFlagData(userFlag, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserFlagData(int userFlag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserFlag` = @UserFlag";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserFlag", userFlag, MySqlDbType.Int32));
		}
		#endregion // RemoveByUserFlag
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
		public int Put(Slot_bet_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Slot_bet_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Slot_bet_detailEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetID` = @BetID, `ChipsID` = @ChipsID, `AppID` = @AppID, `OperatorID` = @OperatorID, `UserID` = @UserID, `BetBaseAmount` = @BetBaseAmount, `BalanceAmount` = @BalanceAmount, `IsWin` = @IsWin, `WinAmount` = @WinAmount, `TotalMultip` = @TotalMultip, `TriggerHHSW` = @TriggerHHSW, `TriggerHHSWIsWin` = @TriggerHHSWIsWin, `TriggerMaxMultip` = @TriggerMaxMultip, `HistoryLine` = @HistoryLine, `HistoryMultip` = @HistoryMultip, `OrderStatus` = @OrderStatus, `RewardDetails` = @RewardDetails, `SlotEleArray` = @SlotEleArray, `BonusInfo` = @BonusInfo, `WildNum` = @WildNum, `BonusItemId` = @BonusItemId, `PoolType` = @PoolType, `UserFlag` = @UserFlag WHERE `BetID` = @BetID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", item.BetID, MySqlDbType.Int64),
				Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetBaseAmount", item.BetBaseAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BalanceAmount", item.BalanceAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@IsWin", item.IsWin, MySqlDbType.Int32),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalMultip", item.TotalMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@TriggerHHSW", item.TriggerHHSW, MySqlDbType.Int32),
				Database.CreateInParameter("@TriggerHHSWIsWin", item.TriggerHHSWIsWin, MySqlDbType.Int32),
				Database.CreateInParameter("@TriggerMaxMultip", item.TriggerMaxMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@HistoryLine", item.HistoryLine, MySqlDbType.VarChar),
				Database.CreateInParameter("@HistoryMultip", item.HistoryMultip, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderStatus", item.OrderStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardDetails", item.RewardDetails, MySqlDbType.VarChar),
				Database.CreateInParameter("@SlotEleArray", item.SlotEleArray, MySqlDbType.VarChar),
				Database.CreateInParameter("@BonusInfo", item.BonusInfo, MySqlDbType.VarChar),
				Database.CreateInParameter("@WildNum", item.WildNum, MySqlDbType.Int32),
				Database.CreateInParameter("@BonusItemId", item.BonusItemId, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", item.PoolType, MySqlDbType.Int32),
				Database.CreateInParameter("@UserFlag", item.UserFlag, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID_Original", item.HasOriginal ? item.OriginalBetID : item.BetID, MySqlDbType.Int64),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Slot_bet_detailEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Slot_bet_detailEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "betID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(long betID, string set_, params object[] values_)
		{
			return Put(set_, "`BetID` = @BetID", ConcatValues(values_, betID));
		}
		public async Task<int> PutByPKAsync(long betID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`BetID` = @BetID", ConcatValues(values_, betID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(long betID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`BetID` = @BetID", tm_, ConcatValues(values_, betID));
		}
		public async Task<int> PutByPKAsync(long betID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`BetID` = @BetID", tm_, ConcatValues(values_, betID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(long betID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
	        };
			return Put(set_, "`BetID` = @BetID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(long betID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
	        };
			return await PutAsync(set_, "`BetID` = @BetID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutChipsID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChipsIDByPK(long betID, int chipsID, TransactionManager tm_ = null)
		{
			RepairPutChipsIDByPKData(betID, chipsID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutChipsIDByPKAsync(long betID, int chipsID, TransactionManager tm_ = null)
		{
			RepairPutChipsIDByPKData(betID, chipsID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutChipsIDByPKData(long betID, int chipsID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ChipsID` = @ChipsID  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
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
		#region PutAppID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppIDByPK(long betID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(betID, appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppIDByPKAsync(long betID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(betID, appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppIDByPKData(long betID, string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
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
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(long betID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(betID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(long betID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(betID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(long betID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
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
		#region PutUserID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIDByPK(long betID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(betID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIDByPKAsync(long betID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(betID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIDByPKData(long betID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
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
		#region PutBetBaseAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBaseAmountByPK(long betID, long betBaseAmount, TransactionManager tm_ = null)
		{
			RepairPutBetBaseAmountByPKData(betID, betBaseAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetBaseAmountByPKAsync(long betID, long betBaseAmount, TransactionManager tm_ = null)
		{
			RepairPutBetBaseAmountByPKData(betID, betBaseAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetBaseAmountByPKData(long betID, long betBaseAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetBaseAmount` = @BetBaseAmount  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBaseAmount(long betBaseAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetBaseAmount` = @BetBaseAmount";
			var parameter_ = Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetBaseAmountAsync(long betBaseAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetBaseAmount` = @BetBaseAmount";
			var parameter_ = Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetBaseAmount
		#region PutBalanceAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "balanceAmount">下注后金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBalanceAmountByPK(long betID, long balanceAmount, TransactionManager tm_ = null)
		{
			RepairPutBalanceAmountByPKData(betID, balanceAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBalanceAmountByPKAsync(long betID, long balanceAmount, TransactionManager tm_ = null)
		{
			RepairPutBalanceAmountByPKData(betID, balanceAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBalanceAmountByPKData(long betID, long balanceAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BalanceAmount` = @BalanceAmount  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BalanceAmount", balanceAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "balanceAmount">下注后金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBalanceAmount(long balanceAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BalanceAmount` = @BalanceAmount";
			var parameter_ = Database.CreateInParameter("@BalanceAmount", balanceAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBalanceAmountAsync(long balanceAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BalanceAmount` = @BalanceAmount";
			var parameter_ = Database.CreateInParameter("@BalanceAmount", balanceAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBalanceAmount
		#region PutIsWin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsWinByPK(long betID, int isWin, TransactionManager tm_ = null)
		{
			RepairPutIsWinByPKData(betID, isWin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsWinByPKAsync(long betID, int isWin, TransactionManager tm_ = null)
		{
			RepairPutIsWinByPKData(betID, isWin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsWinByPKData(long betID, int isWin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsWin` = @IsWin  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsWin(int isWin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsWin` = @IsWin";
			var parameter_ = Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsWinAsync(int isWin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsWin` = @IsWin";
			var parameter_ = Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsWin
		#region PutWinAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinAmountByPK(long betID, long winAmount, TransactionManager tm_ = null)
		{
			RepairPutWinAmountByPKData(betID, winAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinAmountByPKAsync(long betID, long winAmount, TransactionManager tm_ = null)
		{
			RepairPutWinAmountByPKData(betID, winAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinAmountByPKData(long betID, long winAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinAmount` = @WinAmount  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinAmount(long winAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinAmount` = @WinAmount";
			var parameter_ = Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWinAmountAsync(long winAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinAmount` = @WinAmount";
			var parameter_ = Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWinAmount
		#region PutTotalMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalMultipByPK(long betID, int totalMultip, TransactionManager tm_ = null)
		{
			RepairPutTotalMultipByPKData(betID, totalMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalMultipByPKAsync(long betID, int totalMultip, TransactionManager tm_ = null)
		{
			RepairPutTotalMultipByPKData(betID, totalMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalMultipByPKData(long betID, int totalMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalMultip` = @TotalMultip  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalMultip", totalMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalMultip(int totalMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalMultip` = @TotalMultip";
			var parameter_ = Database.CreateInParameter("@TotalMultip", totalMultip, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalMultipAsync(int totalMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalMultip` = @TotalMultip";
			var parameter_ = Database.CreateInParameter("@TotalMultip", totalMultip, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalMultip
		#region PutTriggerHHSW
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "triggerHHSW">是否触发虎虎生威</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerHHSWByPK(long betID, int triggerHHSW, TransactionManager tm_ = null)
		{
			RepairPutTriggerHHSWByPKData(betID, triggerHHSW, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTriggerHHSWByPKAsync(long betID, int triggerHHSW, TransactionManager tm_ = null)
		{
			RepairPutTriggerHHSWByPKData(betID, triggerHHSW, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTriggerHHSWByPKData(long betID, int triggerHHSW, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TriggerHHSW` = @TriggerHHSW  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TriggerHHSW", triggerHHSW, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "triggerHHSW">是否触发虎虎生威</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerHHSW(int triggerHHSW, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerHHSW` = @TriggerHHSW";
			var parameter_ = Database.CreateInParameter("@TriggerHHSW", triggerHHSW, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTriggerHHSWAsync(int triggerHHSW, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerHHSW` = @TriggerHHSW";
			var parameter_ = Database.CreateInParameter("@TriggerHHSW", triggerHHSW, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTriggerHHSW
		#region PutTriggerHHSWIsWin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "triggerHHSWIsWin">触发虎虎生威后是否中奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerHHSWIsWinByPK(long betID, int triggerHHSWIsWin, TransactionManager tm_ = null)
		{
			RepairPutTriggerHHSWIsWinByPKData(betID, triggerHHSWIsWin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTriggerHHSWIsWinByPKAsync(long betID, int triggerHHSWIsWin, TransactionManager tm_ = null)
		{
			RepairPutTriggerHHSWIsWinByPKData(betID, triggerHHSWIsWin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTriggerHHSWIsWinByPKData(long betID, int triggerHHSWIsWin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TriggerHHSWIsWin` = @TriggerHHSWIsWin  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TriggerHHSWIsWin", triggerHHSWIsWin, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "triggerHHSWIsWin">触发虎虎生威后是否中奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerHHSWIsWin(int triggerHHSWIsWin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerHHSWIsWin` = @TriggerHHSWIsWin";
			var parameter_ = Database.CreateInParameter("@TriggerHHSWIsWin", triggerHHSWIsWin, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTriggerHHSWIsWinAsync(int triggerHHSWIsWin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerHHSWIsWin` = @TriggerHHSWIsWin";
			var parameter_ = Database.CreateInParameter("@TriggerHHSWIsWin", triggerHHSWIsWin, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTriggerHHSWIsWin
		#region PutTriggerMaxMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "triggerMaxMultip">中五条线触发10倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerMaxMultipByPK(long betID, int triggerMaxMultip, TransactionManager tm_ = null)
		{
			RepairPutTriggerMaxMultipByPKData(betID, triggerMaxMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTriggerMaxMultipByPKAsync(long betID, int triggerMaxMultip, TransactionManager tm_ = null)
		{
			RepairPutTriggerMaxMultipByPKData(betID, triggerMaxMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTriggerMaxMultipByPKData(long betID, int triggerMaxMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TriggerMaxMultip` = @TriggerMaxMultip  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TriggerMaxMultip", triggerMaxMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "triggerMaxMultip">中五条线触发10倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerMaxMultip(int triggerMaxMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerMaxMultip` = @TriggerMaxMultip";
			var parameter_ = Database.CreateInParameter("@TriggerMaxMultip", triggerMaxMultip, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTriggerMaxMultipAsync(int triggerMaxMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerMaxMultip` = @TriggerMaxMultip";
			var parameter_ = Database.CreateInParameter("@TriggerMaxMultip", triggerMaxMultip, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTriggerMaxMultip
		#region PutHistoryLine
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "historyLine">25条线记录</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHistoryLineByPK(long betID, string historyLine, TransactionManager tm_ = null)
		{
			RepairPutHistoryLineByPKData(betID, historyLine, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHistoryLineByPKAsync(long betID, string historyLine, TransactionManager tm_ = null)
		{
			RepairPutHistoryLineByPKData(betID, historyLine, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHistoryLineByPKData(long betID, string historyLine, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HistoryLine` = @HistoryLine  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HistoryLine", historyLine, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "historyLine">25条线记录</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHistoryLine(string historyLine, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HistoryLine` = @HistoryLine";
			var parameter_ = Database.CreateInParameter("@HistoryLine", historyLine, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHistoryLineAsync(string historyLine, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HistoryLine` = @HistoryLine";
			var parameter_ = Database.CreateInParameter("@HistoryLine", historyLine, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHistoryLine
		#region PutHistoryMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHistoryMultipByPK(long betID, string historyMultip, TransactionManager tm_ = null)
		{
			RepairPutHistoryMultipByPKData(betID, historyMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHistoryMultipByPKAsync(long betID, string historyMultip, TransactionManager tm_ = null)
		{
			RepairPutHistoryMultipByPKData(betID, historyMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHistoryMultipByPKData(long betID, string historyMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HistoryMultip` = @HistoryMultip  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HistoryMultip", historyMultip, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHistoryMultip(string historyMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HistoryMultip` = @HistoryMultip";
			var parameter_ = Database.CreateInParameter("@HistoryMultip", historyMultip, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHistoryMultipAsync(string historyMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HistoryMultip` = @HistoryMultip";
			var parameter_ = Database.CreateInParameter("@HistoryMultip", historyMultip, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHistoryMultip
		#region PutOrderStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderStatusByPK(long betID, int orderStatus, TransactionManager tm_ = null)
		{
			RepairPutOrderStatusByPKData(betID, orderStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderStatusByPKAsync(long betID, int orderStatus, TransactionManager tm_ = null)
		{
			RepairPutOrderStatusByPKData(betID, orderStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderStatusByPKData(long betID, int orderStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderStatus` = @OrderStatus  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderStatus(int orderStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderStatus` = @OrderStatus";
			var parameter_ = Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOrderStatusAsync(int orderStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderStatus` = @OrderStatus";
			var parameter_ = Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOrderStatus
		#region PutRewardDetails
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "rewardDetails">中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardDetailsByPK(long betID, string rewardDetails, TransactionManager tm_ = null)
		{
			RepairPutRewardDetailsByPKData(betID, rewardDetails, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardDetailsByPKAsync(long betID, string rewardDetails, TransactionManager tm_ = null)
		{
			RepairPutRewardDetailsByPKData(betID, rewardDetails, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardDetailsByPKData(long betID, string rewardDetails, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardDetails` = @RewardDetails  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardDetails", rewardDetails, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rewardDetails">中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardDetails(string rewardDetails, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardDetails` = @RewardDetails";
			var parameter_ = Database.CreateInParameter("@RewardDetails", rewardDetails, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRewardDetailsAsync(string rewardDetails, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardDetails` = @RewardDetails";
			var parameter_ = Database.CreateInParameter("@RewardDetails", rewardDetails, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRewardDetails
		#region PutSlotEleArray
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "slotEleArray">返回给客户端数据结构</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSlotEleArrayByPK(long betID, string slotEleArray, TransactionManager tm_ = null)
		{
			RepairPutSlotEleArrayByPKData(betID, slotEleArray, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSlotEleArrayByPKAsync(long betID, string slotEleArray, TransactionManager tm_ = null)
		{
			RepairPutSlotEleArrayByPKData(betID, slotEleArray, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSlotEleArrayByPKData(long betID, string slotEleArray, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SlotEleArray` = @SlotEleArray  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SlotEleArray", slotEleArray, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "slotEleArray">返回给客户端数据结构</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSlotEleArray(string slotEleArray, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SlotEleArray` = @SlotEleArray";
			var parameter_ = Database.CreateInParameter("@SlotEleArray", slotEleArray, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSlotEleArrayAsync(string slotEleArray, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SlotEleArray` = @SlotEleArray";
			var parameter_ = Database.CreateInParameter("@SlotEleArray", slotEleArray, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSlotEleArray
		#region PutBonusInfo
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "bonusInfo">虎虎生威数据结构</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonusInfoByPK(long betID, string bonusInfo, TransactionManager tm_ = null)
		{
			RepairPutBonusInfoByPKData(betID, bonusInfo, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBonusInfoByPKAsync(long betID, string bonusInfo, TransactionManager tm_ = null)
		{
			RepairPutBonusInfoByPKData(betID, bonusInfo, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBonusInfoByPKData(long betID, string bonusInfo, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BonusInfo` = @BonusInfo  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BonusInfo", bonusInfo, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bonusInfo">虎虎生威数据结构</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonusInfo(string bonusInfo, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BonusInfo` = @BonusInfo";
			var parameter_ = Database.CreateInParameter("@BonusInfo", bonusInfo, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBonusInfoAsync(string bonusInfo, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BonusInfo` = @BonusInfo";
			var parameter_ = Database.CreateInParameter("@BonusInfo", bonusInfo, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBonusInfo
		#region PutWildNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "wildNum">wild数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWildNumByPK(long betID, int wildNum, TransactionManager tm_ = null)
		{
			RepairPutWildNumByPKData(betID, wildNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWildNumByPKAsync(long betID, int wildNum, TransactionManager tm_ = null)
		{
			RepairPutWildNumByPKData(betID, wildNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWildNumByPKData(long betID, int wildNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WildNum` = @WildNum  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WildNum", wildNum, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "wildNum">wild数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWildNum(int wildNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WildNum` = @WildNum";
			var parameter_ = Database.CreateInParameter("@WildNum", wildNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWildNumAsync(int wildNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WildNum` = @WildNum";
			var parameter_ = Database.CreateInParameter("@WildNum", wildNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWildNum
		#region PutBonusItemId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "bonusItemId">虎虎生威中奖id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonusItemIdByPK(long betID, int bonusItemId, TransactionManager tm_ = null)
		{
			RepairPutBonusItemIdByPKData(betID, bonusItemId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBonusItemIdByPKAsync(long betID, int bonusItemId, TransactionManager tm_ = null)
		{
			RepairPutBonusItemIdByPKData(betID, bonusItemId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBonusItemIdByPKData(long betID, int bonusItemId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BonusItemId` = @BonusItemId  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BonusItemId", bonusItemId, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bonusItemId">虎虎生威中奖id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonusItemId(int bonusItemId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BonusItemId` = @BonusItemId";
			var parameter_ = Database.CreateInParameter("@BonusItemId", bonusItemId, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBonusItemIdAsync(int bonusItemId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BonusItemId` = @BonusItemId";
			var parameter_ = Database.CreateInParameter("@BonusItemId", bonusItemId, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBonusItemId
		#region PutPoolType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "poolType">走的哪个奖池</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPoolTypeByPK(long betID, int poolType, TransactionManager tm_ = null)
		{
			RepairPutPoolTypeByPKData(betID, poolType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPoolTypeByPKAsync(long betID, int poolType, TransactionManager tm_ = null)
		{
			RepairPutPoolTypeByPKData(betID, poolType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPoolTypeByPKData(long betID, int poolType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PoolType` = @PoolType  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "poolType">走的哪个奖池</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPoolType(int poolType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PoolType` = @PoolType";
			var parameter_ = Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPoolTypeAsync(int poolType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PoolType` = @PoolType";
			var parameter_ = Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPoolType
		#region PutUserFlag
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserFlagByPK(long betID, int userFlag, TransactionManager tm_ = null)
		{
			RepairPutUserFlagByPKData(betID, userFlag, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserFlagByPKAsync(long betID, int userFlag, TransactionManager tm_ = null)
		{
			RepairPutUserFlagByPKData(betID, userFlag, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserFlagByPKData(long betID, int userFlag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserFlag` = @UserFlag  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserFlag", userFlag, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserFlag(int userFlag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserFlag` = @UserFlag";
			var parameter_ = Database.CreateInParameter("@UserFlag", userFlag, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserFlagAsync(int userFlag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserFlag` = @UserFlag";
			var parameter_ = Database.CreateInParameter("@UserFlag", userFlag, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserFlag
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(long betID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(betID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(long betID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(betID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(long betID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
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
		public bool Set(Slot_bet_detailEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.BetID) == null)
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
		public async Task<bool> SetAsync(Slot_bet_detailEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.BetID) == null)
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
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Slot_bet_detailEO GetByPK(long betID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(betID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<Slot_bet_detailEO> GetByPKAsync(long betID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(betID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		private void RepairGetByPKData(long betID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`BetID` = @BetID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 ChipsID（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetChipsIDByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`ChipsID`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetChipsIDByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`ChipsID`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`AppID`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`AppID`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`OperatorID`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`UserID`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`UserID`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetBaseAmount（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetBaseAmountByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)GetScalar("`BetBaseAmount`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<long> GetBetBaseAmountByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`BetBaseAmount`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BalanceAmount（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBalanceAmountByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)GetScalar("`BalanceAmount`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<long> GetBalanceAmountByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`BalanceAmount`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsWin（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetIsWinByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`IsWin`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetIsWinByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`IsWin`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinAmount（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinAmountByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)GetScalar("`WinAmount`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<long> GetWinAmountByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`WinAmount`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalMultip（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTotalMultipByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`TotalMultip`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetTotalMultipByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`TotalMultip`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TriggerHHSW（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTriggerHHSWByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`TriggerHHSW`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetTriggerHHSWByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`TriggerHHSW`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TriggerHHSWIsWin（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTriggerHHSWIsWinByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`TriggerHHSWIsWin`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetTriggerHHSWIsWinByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`TriggerHHSWIsWin`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TriggerMaxMultip（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTriggerMaxMultipByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`TriggerMaxMultip`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetTriggerMaxMultipByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`TriggerMaxMultip`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HistoryLine（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetHistoryLineByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`HistoryLine`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetHistoryLineByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`HistoryLine`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HistoryMultip（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetHistoryMultipByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`HistoryMultip`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetHistoryMultipByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`HistoryMultip`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OrderStatus（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOrderStatusByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`OrderStatus`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetOrderStatusByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`OrderStatus`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RewardDetails（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetRewardDetailsByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`RewardDetails`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetRewardDetailsByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`RewardDetails`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SlotEleArray（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSlotEleArrayByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`SlotEleArray`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetSlotEleArrayByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`SlotEleArray`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BonusInfo（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBonusInfoByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`BonusInfo`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetBonusInfoByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`BonusInfo`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WildNum（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWildNumByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`WildNum`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetWildNumByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`WildNum`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BonusItemId（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetBonusItemIdByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`BonusItemId`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetBonusItemIdByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`BonusItemId`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PoolType（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPoolTypeByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`PoolType`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetPoolTypeByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`PoolType`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserFlag（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserFlagByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`UserFlag`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetUserFlagByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`UserFlag`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (DateTime)GetScalar("`RecDate`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`BetID` = @BetID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByChipsID
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByChipsID(int chipsID)
		{
			return GetByChipsID(chipsID, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByChipsIDAsync(int chipsID)
		{
			return await GetByChipsIDAsync(chipsID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByChipsID(int chipsID, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByChipsIDAsync(int chipsID, TransactionManager tm_)
		{
			return await GetByChipsIDAsync(chipsID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByChipsID(int chipsID, int top_)
		{
			return GetByChipsID(chipsID, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByChipsIDAsync(int chipsID, int top_)
		{
			return await GetByChipsIDAsync(chipsID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByChipsID(int chipsID, int top_, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByChipsIDAsync(int chipsID, int top_, TransactionManager tm_)
		{
			return await GetByChipsIDAsync(chipsID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByChipsID(int chipsID, string sort_)
		{
			return GetByChipsID(chipsID, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByChipsIDAsync(int chipsID, string sort_)
		{
			return await GetByChipsIDAsync(chipsID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByChipsID(int chipsID, string sort_, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByChipsIDAsync(int chipsID, string sort_, TransactionManager tm_)
		{
			return await GetByChipsIDAsync(chipsID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByChipsID(int chipsID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByChipsIDAsync(int chipsID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByChipsID
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByAppIDAsync(string appID, int top_)
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
		public List<Slot_bet_detailEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByAppIDAsync(string appID, string sort_)
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
		public List<Slot_bet_detailEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
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
		public List<Slot_bet_detailEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Slot_bet_detailEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Slot_bet_detailEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Slot_bet_detailEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByBetBaseAmount
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBetBaseAmount(long betBaseAmount)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, TransactionManager tm_)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, TransactionManager tm_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, int top_)
		{
			return GetByBetBaseAmount(betBaseAmount, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, int top_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, int top_, TransactionManager tm_)
		{
			return GetByBetBaseAmount(betBaseAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, string sort_)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, string sort_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBaseAmount` = @BetBaseAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBaseAmount` = @BetBaseAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByBetBaseAmount
		#region GetByBalanceAmount
		
		/// <summary>
		/// 按 BalanceAmount（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmount">下注后金额</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBalanceAmount(long balanceAmount)
		{
			return GetByBalanceAmount(balanceAmount, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBalanceAmountAsync(long balanceAmount)
		{
			return await GetByBalanceAmountAsync(balanceAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BalanceAmount（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmount">下注后金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBalanceAmount(long balanceAmount, TransactionManager tm_)
		{
			return GetByBalanceAmount(balanceAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBalanceAmountAsync(long balanceAmount, TransactionManager tm_)
		{
			return await GetByBalanceAmountAsync(balanceAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BalanceAmount（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmount">下注后金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBalanceAmount(long balanceAmount, int top_)
		{
			return GetByBalanceAmount(balanceAmount, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBalanceAmountAsync(long balanceAmount, int top_)
		{
			return await GetByBalanceAmountAsync(balanceAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BalanceAmount（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmount">下注后金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBalanceAmount(long balanceAmount, int top_, TransactionManager tm_)
		{
			return GetByBalanceAmount(balanceAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBalanceAmountAsync(long balanceAmount, int top_, TransactionManager tm_)
		{
			return await GetByBalanceAmountAsync(balanceAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BalanceAmount（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmount">下注后金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBalanceAmount(long balanceAmount, string sort_)
		{
			return GetByBalanceAmount(balanceAmount, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBalanceAmountAsync(long balanceAmount, string sort_)
		{
			return await GetByBalanceAmountAsync(balanceAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BalanceAmount（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmount">下注后金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBalanceAmount(long balanceAmount, string sort_, TransactionManager tm_)
		{
			return GetByBalanceAmount(balanceAmount, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBalanceAmountAsync(long balanceAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBalanceAmountAsync(balanceAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BalanceAmount（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmount">下注后金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBalanceAmount(long balanceAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BalanceAmount` = @BalanceAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BalanceAmount", balanceAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBalanceAmountAsync(long balanceAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BalanceAmount` = @BalanceAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BalanceAmount", balanceAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByBalanceAmount
		#region GetByIsWin
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByIsWin(int isWin)
		{
			return GetByIsWin(isWin, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByIsWinAsync(int isWin)
		{
			return await GetByIsWinAsync(isWin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByIsWin(int isWin, TransactionManager tm_)
		{
			return GetByIsWin(isWin, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByIsWinAsync(int isWin, TransactionManager tm_)
		{
			return await GetByIsWinAsync(isWin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByIsWin(int isWin, int top_)
		{
			return GetByIsWin(isWin, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByIsWinAsync(int isWin, int top_)
		{
			return await GetByIsWinAsync(isWin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByIsWin(int isWin, int top_, TransactionManager tm_)
		{
			return GetByIsWin(isWin, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByIsWinAsync(int isWin, int top_, TransactionManager tm_)
		{
			return await GetByIsWinAsync(isWin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByIsWin(int isWin, string sort_)
		{
			return GetByIsWin(isWin, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByIsWinAsync(int isWin, string sort_)
		{
			return await GetByIsWinAsync(isWin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByIsWin(int isWin, string sort_, TransactionManager tm_)
		{
			return GetByIsWin(isWin, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByIsWinAsync(int isWin, string sort_, TransactionManager tm_)
		{
			return await GetByIsWinAsync(isWin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByIsWin(int isWin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsWin` = @IsWin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByIsWinAsync(int isWin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsWin` = @IsWin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByIsWin
		#region GetByWinAmount
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByWinAmount(long winAmount)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByWinAmountAsync(long winAmount)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByWinAmount(long winAmount, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByWinAmountAsync(long winAmount, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByWinAmount(long winAmount, int top_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByWinAmountAsync(long winAmount, int top_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByWinAmount(long winAmount, int top_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByWinAmountAsync(long winAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByWinAmount(long winAmount, string sort_)
		{
			return GetByWinAmount(winAmount, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByWinAmountAsync(long winAmount, string sort_)
		{
			return await GetByWinAmountAsync(winAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByWinAmount(long winAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByWinAmountAsync(long winAmount, string sort_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByWinAmount(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByWinAmountAsync(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByWinAmount
		#region GetByTotalMultip
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTotalMultip(int totalMultip)
		{
			return GetByTotalMultip(totalMultip, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTotalMultipAsync(int totalMultip)
		{
			return await GetByTotalMultipAsync(totalMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTotalMultip(int totalMultip, TransactionManager tm_)
		{
			return GetByTotalMultip(totalMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTotalMultipAsync(int totalMultip, TransactionManager tm_)
		{
			return await GetByTotalMultipAsync(totalMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTotalMultip(int totalMultip, int top_)
		{
			return GetByTotalMultip(totalMultip, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTotalMultipAsync(int totalMultip, int top_)
		{
			return await GetByTotalMultipAsync(totalMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTotalMultip(int totalMultip, int top_, TransactionManager tm_)
		{
			return GetByTotalMultip(totalMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTotalMultipAsync(int totalMultip, int top_, TransactionManager tm_)
		{
			return await GetByTotalMultipAsync(totalMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTotalMultip(int totalMultip, string sort_)
		{
			return GetByTotalMultip(totalMultip, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTotalMultipAsync(int totalMultip, string sort_)
		{
			return await GetByTotalMultipAsync(totalMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTotalMultip(int totalMultip, string sort_, TransactionManager tm_)
		{
			return GetByTotalMultip(totalMultip, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTotalMultipAsync(int totalMultip, string sort_, TransactionManager tm_)
		{
			return await GetByTotalMultipAsync(totalMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTotalMultip(int totalMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalMultip` = @TotalMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalMultip", totalMultip, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTotalMultipAsync(int totalMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalMultip` = @TotalMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalMultip", totalMultip, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByTotalMultip
		#region GetByTriggerHHSW
		
		/// <summary>
		/// 按 TriggerHHSW（字段） 查询
		/// </summary>
		/// /// <param name = "triggerHHSW">是否触发虎虎生威</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerHHSW(int triggerHHSW)
		{
			return GetByTriggerHHSW(triggerHHSW, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerHHSWAsync(int triggerHHSW)
		{
			return await GetByTriggerHHSWAsync(triggerHHSW, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerHHSW（字段） 查询
		/// </summary>
		/// /// <param name = "triggerHHSW">是否触发虎虎生威</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerHHSW(int triggerHHSW, TransactionManager tm_)
		{
			return GetByTriggerHHSW(triggerHHSW, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerHHSWAsync(int triggerHHSW, TransactionManager tm_)
		{
			return await GetByTriggerHHSWAsync(triggerHHSW, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerHHSW（字段） 查询
		/// </summary>
		/// /// <param name = "triggerHHSW">是否触发虎虎生威</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerHHSW(int triggerHHSW, int top_)
		{
			return GetByTriggerHHSW(triggerHHSW, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerHHSWAsync(int triggerHHSW, int top_)
		{
			return await GetByTriggerHHSWAsync(triggerHHSW, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerHHSW（字段） 查询
		/// </summary>
		/// /// <param name = "triggerHHSW">是否触发虎虎生威</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerHHSW(int triggerHHSW, int top_, TransactionManager tm_)
		{
			return GetByTriggerHHSW(triggerHHSW, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerHHSWAsync(int triggerHHSW, int top_, TransactionManager tm_)
		{
			return await GetByTriggerHHSWAsync(triggerHHSW, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerHHSW（字段） 查询
		/// </summary>
		/// /// <param name = "triggerHHSW">是否触发虎虎生威</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerHHSW(int triggerHHSW, string sort_)
		{
			return GetByTriggerHHSW(triggerHHSW, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerHHSWAsync(int triggerHHSW, string sort_)
		{
			return await GetByTriggerHHSWAsync(triggerHHSW, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TriggerHHSW（字段） 查询
		/// </summary>
		/// /// <param name = "triggerHHSW">是否触发虎虎生威</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerHHSW(int triggerHHSW, string sort_, TransactionManager tm_)
		{
			return GetByTriggerHHSW(triggerHHSW, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerHHSWAsync(int triggerHHSW, string sort_, TransactionManager tm_)
		{
			return await GetByTriggerHHSWAsync(triggerHHSW, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TriggerHHSW（字段） 查询
		/// </summary>
		/// /// <param name = "triggerHHSW">是否触发虎虎生威</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerHHSW(int triggerHHSW, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerHHSW` = @TriggerHHSW", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerHHSW", triggerHHSW, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerHHSWAsync(int triggerHHSW, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerHHSW` = @TriggerHHSW", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerHHSW", triggerHHSW, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByTriggerHHSW
		#region GetByTriggerHHSWIsWin
		
		/// <summary>
		/// 按 TriggerHHSWIsWin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerHHSWIsWin">触发虎虎生威后是否中奖</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerHHSWIsWin(int triggerHHSWIsWin)
		{
			return GetByTriggerHHSWIsWin(triggerHHSWIsWin, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerHHSWIsWinAsync(int triggerHHSWIsWin)
		{
			return await GetByTriggerHHSWIsWinAsync(triggerHHSWIsWin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerHHSWIsWin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerHHSWIsWin">触发虎虎生威后是否中奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerHHSWIsWin(int triggerHHSWIsWin, TransactionManager tm_)
		{
			return GetByTriggerHHSWIsWin(triggerHHSWIsWin, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerHHSWIsWinAsync(int triggerHHSWIsWin, TransactionManager tm_)
		{
			return await GetByTriggerHHSWIsWinAsync(triggerHHSWIsWin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerHHSWIsWin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerHHSWIsWin">触发虎虎生威后是否中奖</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerHHSWIsWin(int triggerHHSWIsWin, int top_)
		{
			return GetByTriggerHHSWIsWin(triggerHHSWIsWin, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerHHSWIsWinAsync(int triggerHHSWIsWin, int top_)
		{
			return await GetByTriggerHHSWIsWinAsync(triggerHHSWIsWin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerHHSWIsWin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerHHSWIsWin">触发虎虎生威后是否中奖</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerHHSWIsWin(int triggerHHSWIsWin, int top_, TransactionManager tm_)
		{
			return GetByTriggerHHSWIsWin(triggerHHSWIsWin, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerHHSWIsWinAsync(int triggerHHSWIsWin, int top_, TransactionManager tm_)
		{
			return await GetByTriggerHHSWIsWinAsync(triggerHHSWIsWin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerHHSWIsWin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerHHSWIsWin">触发虎虎生威后是否中奖</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerHHSWIsWin(int triggerHHSWIsWin, string sort_)
		{
			return GetByTriggerHHSWIsWin(triggerHHSWIsWin, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerHHSWIsWinAsync(int triggerHHSWIsWin, string sort_)
		{
			return await GetByTriggerHHSWIsWinAsync(triggerHHSWIsWin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TriggerHHSWIsWin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerHHSWIsWin">触发虎虎生威后是否中奖</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerHHSWIsWin(int triggerHHSWIsWin, string sort_, TransactionManager tm_)
		{
			return GetByTriggerHHSWIsWin(triggerHHSWIsWin, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerHHSWIsWinAsync(int triggerHHSWIsWin, string sort_, TransactionManager tm_)
		{
			return await GetByTriggerHHSWIsWinAsync(triggerHHSWIsWin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TriggerHHSWIsWin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerHHSWIsWin">触发虎虎生威后是否中奖</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerHHSWIsWin(int triggerHHSWIsWin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerHHSWIsWin` = @TriggerHHSWIsWin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerHHSWIsWin", triggerHHSWIsWin, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerHHSWIsWinAsync(int triggerHHSWIsWin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerHHSWIsWin` = @TriggerHHSWIsWin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerHHSWIsWin", triggerHHSWIsWin, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByTriggerHHSWIsWin
		#region GetByTriggerMaxMultip
		
		/// <summary>
		/// 按 TriggerMaxMultip（字段） 查询
		/// </summary>
		/// /// <param name = "triggerMaxMultip">中五条线触发10倍率</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerMaxMultip(int triggerMaxMultip)
		{
			return GetByTriggerMaxMultip(triggerMaxMultip, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerMaxMultipAsync(int triggerMaxMultip)
		{
			return await GetByTriggerMaxMultipAsync(triggerMaxMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerMaxMultip（字段） 查询
		/// </summary>
		/// /// <param name = "triggerMaxMultip">中五条线触发10倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerMaxMultip(int triggerMaxMultip, TransactionManager tm_)
		{
			return GetByTriggerMaxMultip(triggerMaxMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerMaxMultipAsync(int triggerMaxMultip, TransactionManager tm_)
		{
			return await GetByTriggerMaxMultipAsync(triggerMaxMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerMaxMultip（字段） 查询
		/// </summary>
		/// /// <param name = "triggerMaxMultip">中五条线触发10倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerMaxMultip(int triggerMaxMultip, int top_)
		{
			return GetByTriggerMaxMultip(triggerMaxMultip, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerMaxMultipAsync(int triggerMaxMultip, int top_)
		{
			return await GetByTriggerMaxMultipAsync(triggerMaxMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerMaxMultip（字段） 查询
		/// </summary>
		/// /// <param name = "triggerMaxMultip">中五条线触发10倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerMaxMultip(int triggerMaxMultip, int top_, TransactionManager tm_)
		{
			return GetByTriggerMaxMultip(triggerMaxMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerMaxMultipAsync(int triggerMaxMultip, int top_, TransactionManager tm_)
		{
			return await GetByTriggerMaxMultipAsync(triggerMaxMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerMaxMultip（字段） 查询
		/// </summary>
		/// /// <param name = "triggerMaxMultip">中五条线触发10倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerMaxMultip(int triggerMaxMultip, string sort_)
		{
			return GetByTriggerMaxMultip(triggerMaxMultip, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerMaxMultipAsync(int triggerMaxMultip, string sort_)
		{
			return await GetByTriggerMaxMultipAsync(triggerMaxMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TriggerMaxMultip（字段） 查询
		/// </summary>
		/// /// <param name = "triggerMaxMultip">中五条线触发10倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerMaxMultip(int triggerMaxMultip, string sort_, TransactionManager tm_)
		{
			return GetByTriggerMaxMultip(triggerMaxMultip, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerMaxMultipAsync(int triggerMaxMultip, string sort_, TransactionManager tm_)
		{
			return await GetByTriggerMaxMultipAsync(triggerMaxMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TriggerMaxMultip（字段） 查询
		/// </summary>
		/// /// <param name = "triggerMaxMultip">中五条线触发10倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByTriggerMaxMultip(int triggerMaxMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerMaxMultip` = @TriggerMaxMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerMaxMultip", triggerMaxMultip, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByTriggerMaxMultipAsync(int triggerMaxMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerMaxMultip` = @TriggerMaxMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerMaxMultip", triggerMaxMultip, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByTriggerMaxMultip
		#region GetByHistoryLine
		
		/// <summary>
		/// 按 HistoryLine（字段） 查询
		/// </summary>
		/// /// <param name = "historyLine">25条线记录</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByHistoryLine(string historyLine)
		{
			return GetByHistoryLine(historyLine, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByHistoryLineAsync(string historyLine)
		{
			return await GetByHistoryLineAsync(historyLine, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HistoryLine（字段） 查询
		/// </summary>
		/// /// <param name = "historyLine">25条线记录</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByHistoryLine(string historyLine, TransactionManager tm_)
		{
			return GetByHistoryLine(historyLine, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByHistoryLineAsync(string historyLine, TransactionManager tm_)
		{
			return await GetByHistoryLineAsync(historyLine, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryLine（字段） 查询
		/// </summary>
		/// /// <param name = "historyLine">25条线记录</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByHistoryLine(string historyLine, int top_)
		{
			return GetByHistoryLine(historyLine, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByHistoryLineAsync(string historyLine, int top_)
		{
			return await GetByHistoryLineAsync(historyLine, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HistoryLine（字段） 查询
		/// </summary>
		/// /// <param name = "historyLine">25条线记录</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByHistoryLine(string historyLine, int top_, TransactionManager tm_)
		{
			return GetByHistoryLine(historyLine, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByHistoryLineAsync(string historyLine, int top_, TransactionManager tm_)
		{
			return await GetByHistoryLineAsync(historyLine, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryLine（字段） 查询
		/// </summary>
		/// /// <param name = "historyLine">25条线记录</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByHistoryLine(string historyLine, string sort_)
		{
			return GetByHistoryLine(historyLine, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByHistoryLineAsync(string historyLine, string sort_)
		{
			return await GetByHistoryLineAsync(historyLine, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HistoryLine（字段） 查询
		/// </summary>
		/// /// <param name = "historyLine">25条线记录</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByHistoryLine(string historyLine, string sort_, TransactionManager tm_)
		{
			return GetByHistoryLine(historyLine, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByHistoryLineAsync(string historyLine, string sort_, TransactionManager tm_)
		{
			return await GetByHistoryLineAsync(historyLine, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HistoryLine（字段） 查询
		/// </summary>
		/// /// <param name = "historyLine">25条线记录</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByHistoryLine(string historyLine, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryLine` = @HistoryLine", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryLine", historyLine, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByHistoryLineAsync(string historyLine, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryLine` = @HistoryLine", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryLine", historyLine, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByHistoryLine
		#region GetByHistoryMultip
		
		/// <summary>
		/// 按 HistoryMultip（字段） 查询
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByHistoryMultip(string historyMultip)
		{
			return GetByHistoryMultip(historyMultip, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByHistoryMultipAsync(string historyMultip)
		{
			return await GetByHistoryMultipAsync(historyMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HistoryMultip（字段） 查询
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByHistoryMultip(string historyMultip, TransactionManager tm_)
		{
			return GetByHistoryMultip(historyMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByHistoryMultipAsync(string historyMultip, TransactionManager tm_)
		{
			return await GetByHistoryMultipAsync(historyMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryMultip（字段） 查询
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByHistoryMultip(string historyMultip, int top_)
		{
			return GetByHistoryMultip(historyMultip, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByHistoryMultipAsync(string historyMultip, int top_)
		{
			return await GetByHistoryMultipAsync(historyMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HistoryMultip（字段） 查询
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByHistoryMultip(string historyMultip, int top_, TransactionManager tm_)
		{
			return GetByHistoryMultip(historyMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByHistoryMultipAsync(string historyMultip, int top_, TransactionManager tm_)
		{
			return await GetByHistoryMultipAsync(historyMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryMultip（字段） 查询
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByHistoryMultip(string historyMultip, string sort_)
		{
			return GetByHistoryMultip(historyMultip, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByHistoryMultipAsync(string historyMultip, string sort_)
		{
			return await GetByHistoryMultipAsync(historyMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HistoryMultip（字段） 查询
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByHistoryMultip(string historyMultip, string sort_, TransactionManager tm_)
		{
			return GetByHistoryMultip(historyMultip, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByHistoryMultipAsync(string historyMultip, string sort_, TransactionManager tm_)
		{
			return await GetByHistoryMultipAsync(historyMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HistoryMultip（字段） 查询
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByHistoryMultip(string historyMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryMultip` = @HistoryMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryMultip", historyMultip, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByHistoryMultipAsync(string historyMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryMultip` = @HistoryMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryMultip", historyMultip, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByHistoryMultip
		#region GetByOrderStatus
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByOrderStatus(int orderStatus)
		{
			return GetByOrderStatus(orderStatus, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByOrderStatusAsync(int orderStatus)
		{
			return await GetByOrderStatusAsync(orderStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByOrderStatus(int orderStatus, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, TransactionManager tm_)
		{
			return await GetByOrderStatusAsync(orderStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByOrderStatus(int orderStatus, int top_)
		{
			return GetByOrderStatus(orderStatus, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_)
		{
			return await GetByOrderStatusAsync(orderStatus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByOrderStatus(int orderStatus, int top_, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_, TransactionManager tm_)
		{
			return await GetByOrderStatusAsync(orderStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByOrderStatus(int orderStatus, string sort_)
		{
			return GetByOrderStatus(orderStatus, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, string sort_)
		{
			return await GetByOrderStatusAsync(orderStatus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByOrderStatus(int orderStatus, string sort_, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, string sort_, TransactionManager tm_)
		{
			return await GetByOrderStatusAsync(orderStatus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByOrderStatus(int orderStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderStatus` = @OrderStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderStatus` = @OrderStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByOrderStatus
		#region GetByRewardDetails
		
		/// <summary>
		/// 按 RewardDetails（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetails">中奖详情</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByRewardDetails(string rewardDetails)
		{
			return GetByRewardDetails(rewardDetails, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByRewardDetailsAsync(string rewardDetails)
		{
			return await GetByRewardDetailsAsync(rewardDetails, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardDetails（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetails">中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByRewardDetails(string rewardDetails, TransactionManager tm_)
		{
			return GetByRewardDetails(rewardDetails, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByRewardDetailsAsync(string rewardDetails, TransactionManager tm_)
		{
			return await GetByRewardDetailsAsync(rewardDetails, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardDetails（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetails">中奖详情</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByRewardDetails(string rewardDetails, int top_)
		{
			return GetByRewardDetails(rewardDetails, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByRewardDetailsAsync(string rewardDetails, int top_)
		{
			return await GetByRewardDetailsAsync(rewardDetails, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardDetails（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetails">中奖详情</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByRewardDetails(string rewardDetails, int top_, TransactionManager tm_)
		{
			return GetByRewardDetails(rewardDetails, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByRewardDetailsAsync(string rewardDetails, int top_, TransactionManager tm_)
		{
			return await GetByRewardDetailsAsync(rewardDetails, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardDetails（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetails">中奖详情</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByRewardDetails(string rewardDetails, string sort_)
		{
			return GetByRewardDetails(rewardDetails, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByRewardDetailsAsync(string rewardDetails, string sort_)
		{
			return await GetByRewardDetailsAsync(rewardDetails, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RewardDetails（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetails">中奖详情</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByRewardDetails(string rewardDetails, string sort_, TransactionManager tm_)
		{
			return GetByRewardDetails(rewardDetails, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByRewardDetailsAsync(string rewardDetails, string sort_, TransactionManager tm_)
		{
			return await GetByRewardDetailsAsync(rewardDetails, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RewardDetails（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetails">中奖详情</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByRewardDetails(string rewardDetails, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardDetails` = @RewardDetails", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardDetails", rewardDetails, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByRewardDetailsAsync(string rewardDetails, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardDetails` = @RewardDetails", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardDetails", rewardDetails, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByRewardDetails
		#region GetBySlotEleArray
		
		/// <summary>
		/// 按 SlotEleArray（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleArray">返回给客户端数据结构</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetBySlotEleArray(string slotEleArray)
		{
			return GetBySlotEleArray(slotEleArray, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetBySlotEleArrayAsync(string slotEleArray)
		{
			return await GetBySlotEleArrayAsync(slotEleArray, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SlotEleArray（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleArray">返回给客户端数据结构</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetBySlotEleArray(string slotEleArray, TransactionManager tm_)
		{
			return GetBySlotEleArray(slotEleArray, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetBySlotEleArrayAsync(string slotEleArray, TransactionManager tm_)
		{
			return await GetBySlotEleArrayAsync(slotEleArray, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SlotEleArray（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleArray">返回给客户端数据结构</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetBySlotEleArray(string slotEleArray, int top_)
		{
			return GetBySlotEleArray(slotEleArray, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetBySlotEleArrayAsync(string slotEleArray, int top_)
		{
			return await GetBySlotEleArrayAsync(slotEleArray, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SlotEleArray（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleArray">返回给客户端数据结构</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetBySlotEleArray(string slotEleArray, int top_, TransactionManager tm_)
		{
			return GetBySlotEleArray(slotEleArray, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetBySlotEleArrayAsync(string slotEleArray, int top_, TransactionManager tm_)
		{
			return await GetBySlotEleArrayAsync(slotEleArray, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SlotEleArray（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleArray">返回给客户端数据结构</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetBySlotEleArray(string slotEleArray, string sort_)
		{
			return GetBySlotEleArray(slotEleArray, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetBySlotEleArrayAsync(string slotEleArray, string sort_)
		{
			return await GetBySlotEleArrayAsync(slotEleArray, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SlotEleArray（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleArray">返回给客户端数据结构</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetBySlotEleArray(string slotEleArray, string sort_, TransactionManager tm_)
		{
			return GetBySlotEleArray(slotEleArray, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetBySlotEleArrayAsync(string slotEleArray, string sort_, TransactionManager tm_)
		{
			return await GetBySlotEleArrayAsync(slotEleArray, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SlotEleArray（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleArray">返回给客户端数据结构</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetBySlotEleArray(string slotEleArray, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SlotEleArray` = @SlotEleArray", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SlotEleArray", slotEleArray, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetBySlotEleArrayAsync(string slotEleArray, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SlotEleArray` = @SlotEleArray", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SlotEleArray", slotEleArray, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetBySlotEleArray
		#region GetByBonusInfo
		
		/// <summary>
		/// 按 BonusInfo（字段） 查询
		/// </summary>
		/// /// <param name = "bonusInfo">虎虎生威数据结构</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBonusInfo(string bonusInfo)
		{
			return GetByBonusInfo(bonusInfo, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBonusInfoAsync(string bonusInfo)
		{
			return await GetByBonusInfoAsync(bonusInfo, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusInfo（字段） 查询
		/// </summary>
		/// /// <param name = "bonusInfo">虎虎生威数据结构</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBonusInfo(string bonusInfo, TransactionManager tm_)
		{
			return GetByBonusInfo(bonusInfo, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBonusInfoAsync(string bonusInfo, TransactionManager tm_)
		{
			return await GetByBonusInfoAsync(bonusInfo, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusInfo（字段） 查询
		/// </summary>
		/// /// <param name = "bonusInfo">虎虎生威数据结构</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBonusInfo(string bonusInfo, int top_)
		{
			return GetByBonusInfo(bonusInfo, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBonusInfoAsync(string bonusInfo, int top_)
		{
			return await GetByBonusInfoAsync(bonusInfo, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusInfo（字段） 查询
		/// </summary>
		/// /// <param name = "bonusInfo">虎虎生威数据结构</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBonusInfo(string bonusInfo, int top_, TransactionManager tm_)
		{
			return GetByBonusInfo(bonusInfo, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBonusInfoAsync(string bonusInfo, int top_, TransactionManager tm_)
		{
			return await GetByBonusInfoAsync(bonusInfo, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusInfo（字段） 查询
		/// </summary>
		/// /// <param name = "bonusInfo">虎虎生威数据结构</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBonusInfo(string bonusInfo, string sort_)
		{
			return GetByBonusInfo(bonusInfo, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBonusInfoAsync(string bonusInfo, string sort_)
		{
			return await GetByBonusInfoAsync(bonusInfo, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BonusInfo（字段） 查询
		/// </summary>
		/// /// <param name = "bonusInfo">虎虎生威数据结构</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBonusInfo(string bonusInfo, string sort_, TransactionManager tm_)
		{
			return GetByBonusInfo(bonusInfo, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBonusInfoAsync(string bonusInfo, string sort_, TransactionManager tm_)
		{
			return await GetByBonusInfoAsync(bonusInfo, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BonusInfo（字段） 查询
		/// </summary>
		/// /// <param name = "bonusInfo">虎虎生威数据结构</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBonusInfo(string bonusInfo, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BonusInfo` = @BonusInfo", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BonusInfo", bonusInfo, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBonusInfoAsync(string bonusInfo, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BonusInfo` = @BonusInfo", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BonusInfo", bonusInfo, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByBonusInfo
		#region GetByWildNum
		
		/// <summary>
		/// 按 WildNum（字段） 查询
		/// </summary>
		/// /// <param name = "wildNum">wild数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByWildNum(int wildNum)
		{
			return GetByWildNum(wildNum, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByWildNumAsync(int wildNum)
		{
			return await GetByWildNumAsync(wildNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WildNum（字段） 查询
		/// </summary>
		/// /// <param name = "wildNum">wild数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByWildNum(int wildNum, TransactionManager tm_)
		{
			return GetByWildNum(wildNum, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByWildNumAsync(int wildNum, TransactionManager tm_)
		{
			return await GetByWildNumAsync(wildNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WildNum（字段） 查询
		/// </summary>
		/// /// <param name = "wildNum">wild数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByWildNum(int wildNum, int top_)
		{
			return GetByWildNum(wildNum, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByWildNumAsync(int wildNum, int top_)
		{
			return await GetByWildNumAsync(wildNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WildNum（字段） 查询
		/// </summary>
		/// /// <param name = "wildNum">wild数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByWildNum(int wildNum, int top_, TransactionManager tm_)
		{
			return GetByWildNum(wildNum, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByWildNumAsync(int wildNum, int top_, TransactionManager tm_)
		{
			return await GetByWildNumAsync(wildNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WildNum（字段） 查询
		/// </summary>
		/// /// <param name = "wildNum">wild数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByWildNum(int wildNum, string sort_)
		{
			return GetByWildNum(wildNum, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByWildNumAsync(int wildNum, string sort_)
		{
			return await GetByWildNumAsync(wildNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WildNum（字段） 查询
		/// </summary>
		/// /// <param name = "wildNum">wild数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByWildNum(int wildNum, string sort_, TransactionManager tm_)
		{
			return GetByWildNum(wildNum, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByWildNumAsync(int wildNum, string sort_, TransactionManager tm_)
		{
			return await GetByWildNumAsync(wildNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WildNum（字段） 查询
		/// </summary>
		/// /// <param name = "wildNum">wild数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByWildNum(int wildNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WildNum` = @WildNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WildNum", wildNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByWildNumAsync(int wildNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WildNum` = @WildNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WildNum", wildNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByWildNum
		#region GetByBonusItemId
		
		/// <summary>
		/// 按 BonusItemId（字段） 查询
		/// </summary>
		/// /// <param name = "bonusItemId">虎虎生威中奖id</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBonusItemId(int bonusItemId)
		{
			return GetByBonusItemId(bonusItemId, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBonusItemIdAsync(int bonusItemId)
		{
			return await GetByBonusItemIdAsync(bonusItemId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusItemId（字段） 查询
		/// </summary>
		/// /// <param name = "bonusItemId">虎虎生威中奖id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBonusItemId(int bonusItemId, TransactionManager tm_)
		{
			return GetByBonusItemId(bonusItemId, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBonusItemIdAsync(int bonusItemId, TransactionManager tm_)
		{
			return await GetByBonusItemIdAsync(bonusItemId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusItemId（字段） 查询
		/// </summary>
		/// /// <param name = "bonusItemId">虎虎生威中奖id</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBonusItemId(int bonusItemId, int top_)
		{
			return GetByBonusItemId(bonusItemId, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBonusItemIdAsync(int bonusItemId, int top_)
		{
			return await GetByBonusItemIdAsync(bonusItemId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusItemId（字段） 查询
		/// </summary>
		/// /// <param name = "bonusItemId">虎虎生威中奖id</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBonusItemId(int bonusItemId, int top_, TransactionManager tm_)
		{
			return GetByBonusItemId(bonusItemId, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBonusItemIdAsync(int bonusItemId, int top_, TransactionManager tm_)
		{
			return await GetByBonusItemIdAsync(bonusItemId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusItemId（字段） 查询
		/// </summary>
		/// /// <param name = "bonusItemId">虎虎生威中奖id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBonusItemId(int bonusItemId, string sort_)
		{
			return GetByBonusItemId(bonusItemId, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBonusItemIdAsync(int bonusItemId, string sort_)
		{
			return await GetByBonusItemIdAsync(bonusItemId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BonusItemId（字段） 查询
		/// </summary>
		/// /// <param name = "bonusItemId">虎虎生威中奖id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBonusItemId(int bonusItemId, string sort_, TransactionManager tm_)
		{
			return GetByBonusItemId(bonusItemId, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBonusItemIdAsync(int bonusItemId, string sort_, TransactionManager tm_)
		{
			return await GetByBonusItemIdAsync(bonusItemId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BonusItemId（字段） 查询
		/// </summary>
		/// /// <param name = "bonusItemId">虎虎生威中奖id</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByBonusItemId(int bonusItemId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BonusItemId` = @BonusItemId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BonusItemId", bonusItemId, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByBonusItemIdAsync(int bonusItemId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BonusItemId` = @BonusItemId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BonusItemId", bonusItemId, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByBonusItemId
		#region GetByPoolType
		
		/// <summary>
		/// 按 PoolType（字段） 查询
		/// </summary>
		/// /// <param name = "poolType">走的哪个奖池</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByPoolType(int poolType)
		{
			return GetByPoolType(poolType, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByPoolTypeAsync(int poolType)
		{
			return await GetByPoolTypeAsync(poolType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PoolType（字段） 查询
		/// </summary>
		/// /// <param name = "poolType">走的哪个奖池</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByPoolType(int poolType, TransactionManager tm_)
		{
			return GetByPoolType(poolType, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByPoolTypeAsync(int poolType, TransactionManager tm_)
		{
			return await GetByPoolTypeAsync(poolType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PoolType（字段） 查询
		/// </summary>
		/// /// <param name = "poolType">走的哪个奖池</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByPoolType(int poolType, int top_)
		{
			return GetByPoolType(poolType, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByPoolTypeAsync(int poolType, int top_)
		{
			return await GetByPoolTypeAsync(poolType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PoolType（字段） 查询
		/// </summary>
		/// /// <param name = "poolType">走的哪个奖池</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByPoolType(int poolType, int top_, TransactionManager tm_)
		{
			return GetByPoolType(poolType, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByPoolTypeAsync(int poolType, int top_, TransactionManager tm_)
		{
			return await GetByPoolTypeAsync(poolType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PoolType（字段） 查询
		/// </summary>
		/// /// <param name = "poolType">走的哪个奖池</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByPoolType(int poolType, string sort_)
		{
			return GetByPoolType(poolType, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByPoolTypeAsync(int poolType, string sort_)
		{
			return await GetByPoolTypeAsync(poolType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PoolType（字段） 查询
		/// </summary>
		/// /// <param name = "poolType">走的哪个奖池</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByPoolType(int poolType, string sort_, TransactionManager tm_)
		{
			return GetByPoolType(poolType, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByPoolTypeAsync(int poolType, string sort_, TransactionManager tm_)
		{
			return await GetByPoolTypeAsync(poolType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PoolType（字段） 查询
		/// </summary>
		/// /// <param name = "poolType">走的哪个奖池</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByPoolType(int poolType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PoolType` = @PoolType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByPoolTypeAsync(int poolType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PoolType` = @PoolType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByPoolType
		#region GetByUserFlag
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByUserFlag(int userFlag)
		{
			return GetByUserFlag(userFlag, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByUserFlagAsync(int userFlag)
		{
			return await GetByUserFlagAsync(userFlag, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByUserFlag(int userFlag, TransactionManager tm_)
		{
			return GetByUserFlag(userFlag, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByUserFlagAsync(int userFlag, TransactionManager tm_)
		{
			return await GetByUserFlagAsync(userFlag, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByUserFlag(int userFlag, int top_)
		{
			return GetByUserFlag(userFlag, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByUserFlagAsync(int userFlag, int top_)
		{
			return await GetByUserFlagAsync(userFlag, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByUserFlag(int userFlag, int top_, TransactionManager tm_)
		{
			return GetByUserFlag(userFlag, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByUserFlagAsync(int userFlag, int top_, TransactionManager tm_)
		{
			return await GetByUserFlagAsync(userFlag, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByUserFlag(int userFlag, string sort_)
		{
			return GetByUserFlag(userFlag, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByUserFlagAsync(int userFlag, string sort_)
		{
			return await GetByUserFlagAsync(userFlag, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByUserFlag(int userFlag, string sort_, TransactionManager tm_)
		{
			return GetByUserFlag(userFlag, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByUserFlagAsync(int userFlag, string sort_, TransactionManager tm_)
		{
			return await GetByUserFlagAsync(userFlag, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByUserFlag(int userFlag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserFlag` = @UserFlag", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserFlag", userFlag, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByUserFlagAsync(int userFlag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserFlag` = @UserFlag", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserFlag", userFlag, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByUserFlag
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Slot_bet_detailEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_bet_detailEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Slot_bet_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Slot_bet_detailEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Slot_bet_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Slot_bet_detailEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		public async Task<List<Slot_bet_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_bet_detailEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
