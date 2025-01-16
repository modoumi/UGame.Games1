/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-14 21: 25:27
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

namespace Super_phoenix.DAL
{
	#region EO
	/// <summary>
	/// 下注表
	/// 【表 gsp_bet_detail 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Gsp_bet_detailEO : IRowMapper<Gsp_bet_detailEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Gsp_bet_detailEO()
		{
			this.ChipsID = 0;
			this.BetBaseAmount = 0;
			this.TriggerMiniGame = 0;
			this.MiniGameTotalVal = 0;
			this.FreeSpinCount = 0;
			this.WinAmount = 0;
			this.TotalMultip = 0;
			this.HistoryLine = "0";
			this.HistoryMultip = "0";
			this.OrderStatus = 0;
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
		/// 用户Id
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 2)]
		public string UserID { get; set; }
		/// <summary>
		/// 下注配置ID
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int ChipsID { get; set; }
		/// <summary>
		/// 实际下注金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 4)]
		public long BetBaseAmount { get; set; }
		/// <summary>
		/// 是否触发小游戏
		/// 【字段 tinyint】
		/// </summary>
		[DataMember(Order = 5)]
		public int TriggerMiniGame { get; set; }
		/// <summary>
		/// 小游戏累计值
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long MiniGameTotalVal { get; set; }
		/// <summary>
		/// 免费摇奖次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int FreeSpinCount { get; set; }
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
		/// 25条线记录
		/// 【字段 varchar(1000)】
		/// </summary>
		[DataMember(Order = 11)]
		public string HistoryLine { get; set; }
		/// <summary>
		/// 25条线对应的倍率
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 12)]
		public string HistoryMultip { get; set; }
		/// <summary>
		/// 状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 13)]
		public int OrderStatus { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 14)]
		public DateTime? RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Gsp_bet_detailEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Gsp_bet_detailEO MapDataReader(IDataReader reader)
		{
		    Gsp_bet_detailEO ret = new Gsp_bet_detailEO();
			ret.BetID = reader.ToInt64("BetID");
			ret.OriginalBetID = ret.BetID;
			ret.UserID = reader.ToString("UserID");
			ret.ChipsID = reader.ToInt32("ChipsID");
			ret.BetBaseAmount = reader.ToInt64("BetBaseAmount");
			ret.TriggerMiniGame = reader.ToInt32("TriggerMiniGame");
			ret.MiniGameTotalVal = reader.ToInt64("MiniGameTotalVal");
			ret.FreeSpinCount = reader.ToInt32("FreeSpinCount");
			ret.IsWin = reader.ToInt32("IsWin");
			ret.WinAmount = reader.ToInt64("WinAmount");
			ret.TotalMultip = reader.ToInt32("TotalMultip");
			ret.HistoryLine = reader.ToString("HistoryLine");
			ret.HistoryMultip = reader.ToString("HistoryMultip");
			ret.OrderStatus = reader.ToInt32("OrderStatus");
			ret.RecDate = reader.ToDateTimeN("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 下注表
	/// 【表 gsp_bet_detail 的操作类】
	/// </summary>
	[Obsolete]
	public class Gsp_bet_detailMO : MySqlTableMO<Gsp_bet_detailEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`gsp_bet_detail`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Gsp_bet_detailMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Gsp_bet_detailMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Gsp_bet_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Gsp_bet_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Gsp_bet_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Gsp_bet_detailEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`BetID`, `UserID`, `ChipsID`, `BetBaseAmount`, `TriggerMiniGame`, `MiniGameTotalVal`, `FreeSpinCount`, `IsWin`, `WinAmount`, `TotalMultip`, `HistoryLine`, `HistoryMultip`, `OrderStatus`, `RecDate`) VALUE (@BetID, @UserID, @ChipsID, @BetBaseAmount, @TriggerMiniGame, @MiniGameTotalVal, @FreeSpinCount, @IsWin, @WinAmount, @TotalMultip, @HistoryLine, @HistoryMultip, @OrderStatus, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", item.BetID, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@BetBaseAmount", item.BetBaseAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TriggerMiniGame", item.TriggerMiniGame, MySqlDbType.Byte),
				Database.CreateInParameter("@MiniGameTotalVal", item.MiniGameTotalVal, MySqlDbType.Int64),
				Database.CreateInParameter("@FreeSpinCount", item.FreeSpinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@IsWin", item.IsWin, MySqlDbType.Int32),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalMultip", item.TotalMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@HistoryLine", item.HistoryLine, MySqlDbType.VarChar),
				Database.CreateInParameter("@HistoryMultip", item.HistoryMultip, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderStatus", item.OrderStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate.HasValue ? item.RecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Gsp_bet_detailEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Gsp_bet_detailEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gsp_bet_detailEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`BetID`, `UserID`, `ChipsID`, `BetBaseAmount`, `TriggerMiniGame`, `MiniGameTotalVal`, `FreeSpinCount`, `IsWin`, `WinAmount`, `TotalMultip`, `HistoryLine`, `HistoryMultip`, `OrderStatus`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.BetID},'{item.UserID}',{item.ChipsID},{item.BetBaseAmount},{item.TriggerMiniGame},{item.MiniGameTotalVal},{item.FreeSpinCount},{item.IsWin},{item.WinAmount},{item.TotalMultip},'{item.HistoryLine}','{item.HistoryMultip}',{item.OrderStatus},'{item.RecDate?.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		public int Remove(Gsp_bet_detailEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.BetID, tm_);
		}
		public async Task<int> RemoveAsync(Gsp_bet_detailEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.BetID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
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
		#region RemoveByTriggerMiniGame
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "triggerMiniGame">是否触发小游戏</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTriggerMiniGame(int triggerMiniGame, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerMiniGameData(triggerMiniGame, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTriggerMiniGameAsync(int triggerMiniGame, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerMiniGameData(triggerMiniGame, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTriggerMiniGameData(int triggerMiniGame, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TriggerMiniGame` = @TriggerMiniGame";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerMiniGame", triggerMiniGame, MySqlDbType.Byte));
		}
		#endregion // RemoveByTriggerMiniGame
		#region RemoveByMiniGameTotalVal
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "miniGameTotalVal">小游戏累计值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMiniGameTotalVal(long miniGameTotalVal, TransactionManager tm_ = null)
		{
			RepairRemoveByMiniGameTotalValData(miniGameTotalVal, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMiniGameTotalValAsync(long miniGameTotalVal, TransactionManager tm_ = null)
		{
			RepairRemoveByMiniGameTotalValData(miniGameTotalVal, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMiniGameTotalValData(long miniGameTotalVal, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MiniGameTotalVal` = @MiniGameTotalVal";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MiniGameTotalVal", miniGameTotalVal, MySqlDbType.Int64));
		}
		#endregion // RemoveByMiniGameTotalVal
		#region RemoveByFreeSpinCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFreeSpinCount(int freeSpinCount, TransactionManager tm_ = null)
		{
			RepairRemoveByFreeSpinCountData(freeSpinCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFreeSpinCountAsync(int freeSpinCount, TransactionManager tm_ = null)
		{
			RepairRemoveByFreeSpinCountData(freeSpinCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFreeSpinCountData(int freeSpinCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FreeSpinCount` = @FreeSpinCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByFreeSpinCount
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
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecDate(DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecDateAsync(DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecDateData(DateTime? recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
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
		public int Put(Gsp_bet_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Gsp_bet_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Gsp_bet_detailEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetID` = @BetID, `UserID` = @UserID, `ChipsID` = @ChipsID, `BetBaseAmount` = @BetBaseAmount, `TriggerMiniGame` = @TriggerMiniGame, `MiniGameTotalVal` = @MiniGameTotalVal, `FreeSpinCount` = @FreeSpinCount, `IsWin` = @IsWin, `WinAmount` = @WinAmount, `TotalMultip` = @TotalMultip, `HistoryLine` = @HistoryLine, `HistoryMultip` = @HistoryMultip, `OrderStatus` = @OrderStatus WHERE `BetID` = @BetID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", item.BetID, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@BetBaseAmount", item.BetBaseAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TriggerMiniGame", item.TriggerMiniGame, MySqlDbType.Byte),
				Database.CreateInParameter("@MiniGameTotalVal", item.MiniGameTotalVal, MySqlDbType.Int64),
				Database.CreateInParameter("@FreeSpinCount", item.FreeSpinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@IsWin", item.IsWin, MySqlDbType.Int32),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalMultip", item.TotalMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@HistoryLine", item.HistoryLine, MySqlDbType.VarChar),
				Database.CreateInParameter("@HistoryMultip", item.HistoryMultip, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderStatus", item.OrderStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID_Original", item.HasOriginal ? item.OriginalBetID : item.BetID, MySqlDbType.Int64),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Gsp_bet_detailEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Gsp_bet_detailEO> items, TransactionManager tm_ = null)
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
		#region PutTriggerMiniGame
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "triggerMiniGame">是否触发小游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerMiniGameByPK(long betID, int triggerMiniGame, TransactionManager tm_ = null)
		{
			RepairPutTriggerMiniGameByPKData(betID, triggerMiniGame, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTriggerMiniGameByPKAsync(long betID, int triggerMiniGame, TransactionManager tm_ = null)
		{
			RepairPutTriggerMiniGameByPKData(betID, triggerMiniGame, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTriggerMiniGameByPKData(long betID, int triggerMiniGame, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TriggerMiniGame` = @TriggerMiniGame  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TriggerMiniGame", triggerMiniGame, MySqlDbType.Byte),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "triggerMiniGame">是否触发小游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerMiniGame(int triggerMiniGame, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerMiniGame` = @TriggerMiniGame";
			var parameter_ = Database.CreateInParameter("@TriggerMiniGame", triggerMiniGame, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTriggerMiniGameAsync(int triggerMiniGame, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerMiniGame` = @TriggerMiniGame";
			var parameter_ = Database.CreateInParameter("@TriggerMiniGame", triggerMiniGame, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTriggerMiniGame
		#region PutMiniGameTotalVal
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "miniGameTotalVal">小游戏累计值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMiniGameTotalValByPK(long betID, long miniGameTotalVal, TransactionManager tm_ = null)
		{
			RepairPutMiniGameTotalValByPKData(betID, miniGameTotalVal, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMiniGameTotalValByPKAsync(long betID, long miniGameTotalVal, TransactionManager tm_ = null)
		{
			RepairPutMiniGameTotalValByPKData(betID, miniGameTotalVal, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMiniGameTotalValByPKData(long betID, long miniGameTotalVal, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MiniGameTotalVal` = @MiniGameTotalVal  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MiniGameTotalVal", miniGameTotalVal, MySqlDbType.Int64),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "miniGameTotalVal">小游戏累计值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMiniGameTotalVal(long miniGameTotalVal, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MiniGameTotalVal` = @MiniGameTotalVal";
			var parameter_ = Database.CreateInParameter("@MiniGameTotalVal", miniGameTotalVal, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMiniGameTotalValAsync(long miniGameTotalVal, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MiniGameTotalVal` = @MiniGameTotalVal";
			var parameter_ = Database.CreateInParameter("@MiniGameTotalVal", miniGameTotalVal, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMiniGameTotalVal
		#region PutFreeSpinCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreeSpinCountByPK(long betID, int freeSpinCount, TransactionManager tm_ = null)
		{
			RepairPutFreeSpinCountByPKData(betID, freeSpinCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFreeSpinCountByPKAsync(long betID, int freeSpinCount, TransactionManager tm_ = null)
		{
			RepairPutFreeSpinCountByPKData(betID, freeSpinCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFreeSpinCountByPKData(long betID, int freeSpinCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FreeSpinCount` = @FreeSpinCount  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreeSpinCount(int freeSpinCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FreeSpinCount` = @FreeSpinCount";
			var parameter_ = Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFreeSpinCountAsync(int freeSpinCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FreeSpinCount` = @FreeSpinCount";
			var parameter_ = Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFreeSpinCount
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
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(long betID, DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(betID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(long betID, DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(betID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(long betID, DateTime? recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDate(DateTime? recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecDateAsync(DateTime? recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
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
		public bool Set(Gsp_bet_detailEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Gsp_bet_detailEO item, TransactionManager tm = null)
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
		public Gsp_bet_detailEO GetByPK(long betID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(betID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		public async Task<Gsp_bet_detailEO> GetByPKAsync(long betID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(betID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
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
		/// 按主键查询 TriggerMiniGame（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTriggerMiniGameByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`TriggerMiniGame`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetTriggerMiniGameByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`TriggerMiniGame`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MiniGameTotalVal（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetMiniGameTotalValByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)GetScalar("`MiniGameTotalVal`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<long> GetMiniGameTotalValByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`MiniGameTotalVal`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FreeSpinCount（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFreeSpinCountByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`FreeSpinCount`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetFreeSpinCountByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`FreeSpinCount`", "`BetID` = @BetID", paras_, tm_);
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
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetRecDateByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (DateTime?)GetScalar("`RecDate`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<DateTime?> GetRecDateByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (DateTime?)await GetScalarAsync("`RecDate`", "`BetID` = @BetID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByUserIDAsync(string userID, int top_)
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
		public List<Gsp_bet_detailEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByUserIDAsync(string userID, string sort_)
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
		public List<Gsp_bet_detailEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
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
		public List<Gsp_bet_detailEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByChipsID
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByChipsID(int chipsID)
		{
			return GetByChipsID(chipsID, 0, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByChipsIDAsync(int chipsID)
		{
			return await GetByChipsIDAsync(chipsID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByChipsID(int chipsID, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByChipsIDAsync(int chipsID, TransactionManager tm_)
		{
			return await GetByChipsIDAsync(chipsID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByChipsID(int chipsID, int top_)
		{
			return GetByChipsID(chipsID, top_, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByChipsIDAsync(int chipsID, int top_)
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
		public List<Gsp_bet_detailEO> GetByChipsID(int chipsID, int top_, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByChipsIDAsync(int chipsID, int top_, TransactionManager tm_)
		{
			return await GetByChipsIDAsync(chipsID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByChipsID(int chipsID, string sort_)
		{
			return GetByChipsID(chipsID, 0, sort_, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByChipsIDAsync(int chipsID, string sort_)
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
		public List<Gsp_bet_detailEO> GetByChipsID(int chipsID, string sort_, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, 0, sort_, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByChipsIDAsync(int chipsID, string sort_, TransactionManager tm_)
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
		public List<Gsp_bet_detailEO> GetByChipsID(int chipsID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByChipsIDAsync(int chipsID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByChipsID
		#region GetByBetBaseAmount
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByBetBaseAmount(long betBaseAmount)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, TransactionManager tm_)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, TransactionManager tm_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, int top_)
		{
			return GetByBetBaseAmount(betBaseAmount, top_, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, int top_)
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
		public List<Gsp_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, int top_, TransactionManager tm_)
		{
			return GetByBetBaseAmount(betBaseAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, string sort_)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, sort_, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, string sort_)
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
		public List<Gsp_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, sort_, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, string sort_, TransactionManager tm_)
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
		public List<Gsp_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBaseAmount` = @BetBaseAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBaseAmount` = @BetBaseAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByBetBaseAmount
		#region GetByTriggerMiniGame
		
		/// <summary>
		/// 按 TriggerMiniGame（字段） 查询
		/// </summary>
		/// /// <param name = "triggerMiniGame">是否触发小游戏</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByTriggerMiniGame(int triggerMiniGame)
		{
			return GetByTriggerMiniGame(triggerMiniGame, 0, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByTriggerMiniGameAsync(int triggerMiniGame)
		{
			return await GetByTriggerMiniGameAsync(triggerMiniGame, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerMiniGame（字段） 查询
		/// </summary>
		/// /// <param name = "triggerMiniGame">是否触发小游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByTriggerMiniGame(int triggerMiniGame, TransactionManager tm_)
		{
			return GetByTriggerMiniGame(triggerMiniGame, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByTriggerMiniGameAsync(int triggerMiniGame, TransactionManager tm_)
		{
			return await GetByTriggerMiniGameAsync(triggerMiniGame, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerMiniGame（字段） 查询
		/// </summary>
		/// /// <param name = "triggerMiniGame">是否触发小游戏</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByTriggerMiniGame(int triggerMiniGame, int top_)
		{
			return GetByTriggerMiniGame(triggerMiniGame, top_, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByTriggerMiniGameAsync(int triggerMiniGame, int top_)
		{
			return await GetByTriggerMiniGameAsync(triggerMiniGame, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerMiniGame（字段） 查询
		/// </summary>
		/// /// <param name = "triggerMiniGame">是否触发小游戏</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByTriggerMiniGame(int triggerMiniGame, int top_, TransactionManager tm_)
		{
			return GetByTriggerMiniGame(triggerMiniGame, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByTriggerMiniGameAsync(int triggerMiniGame, int top_, TransactionManager tm_)
		{
			return await GetByTriggerMiniGameAsync(triggerMiniGame, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerMiniGame（字段） 查询
		/// </summary>
		/// /// <param name = "triggerMiniGame">是否触发小游戏</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByTriggerMiniGame(int triggerMiniGame, string sort_)
		{
			return GetByTriggerMiniGame(triggerMiniGame, 0, sort_, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByTriggerMiniGameAsync(int triggerMiniGame, string sort_)
		{
			return await GetByTriggerMiniGameAsync(triggerMiniGame, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TriggerMiniGame（字段） 查询
		/// </summary>
		/// /// <param name = "triggerMiniGame">是否触发小游戏</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByTriggerMiniGame(int triggerMiniGame, string sort_, TransactionManager tm_)
		{
			return GetByTriggerMiniGame(triggerMiniGame, 0, sort_, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByTriggerMiniGameAsync(int triggerMiniGame, string sort_, TransactionManager tm_)
		{
			return await GetByTriggerMiniGameAsync(triggerMiniGame, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TriggerMiniGame（字段） 查询
		/// </summary>
		/// /// <param name = "triggerMiniGame">是否触发小游戏</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByTriggerMiniGame(int triggerMiniGame, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerMiniGame` = @TriggerMiniGame", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerMiniGame", triggerMiniGame, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByTriggerMiniGameAsync(int triggerMiniGame, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerMiniGame` = @TriggerMiniGame", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerMiniGame", triggerMiniGame, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByTriggerMiniGame
		#region GetByMiniGameTotalVal
		
		/// <summary>
		/// 按 MiniGameTotalVal（字段） 查询
		/// </summary>
		/// /// <param name = "miniGameTotalVal">小游戏累计值</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByMiniGameTotalVal(long miniGameTotalVal)
		{
			return GetByMiniGameTotalVal(miniGameTotalVal, 0, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByMiniGameTotalValAsync(long miniGameTotalVal)
		{
			return await GetByMiniGameTotalValAsync(miniGameTotalVal, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MiniGameTotalVal（字段） 查询
		/// </summary>
		/// /// <param name = "miniGameTotalVal">小游戏累计值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByMiniGameTotalVal(long miniGameTotalVal, TransactionManager tm_)
		{
			return GetByMiniGameTotalVal(miniGameTotalVal, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByMiniGameTotalValAsync(long miniGameTotalVal, TransactionManager tm_)
		{
			return await GetByMiniGameTotalValAsync(miniGameTotalVal, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MiniGameTotalVal（字段） 查询
		/// </summary>
		/// /// <param name = "miniGameTotalVal">小游戏累计值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByMiniGameTotalVal(long miniGameTotalVal, int top_)
		{
			return GetByMiniGameTotalVal(miniGameTotalVal, top_, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByMiniGameTotalValAsync(long miniGameTotalVal, int top_)
		{
			return await GetByMiniGameTotalValAsync(miniGameTotalVal, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MiniGameTotalVal（字段） 查询
		/// </summary>
		/// /// <param name = "miniGameTotalVal">小游戏累计值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByMiniGameTotalVal(long miniGameTotalVal, int top_, TransactionManager tm_)
		{
			return GetByMiniGameTotalVal(miniGameTotalVal, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByMiniGameTotalValAsync(long miniGameTotalVal, int top_, TransactionManager tm_)
		{
			return await GetByMiniGameTotalValAsync(miniGameTotalVal, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MiniGameTotalVal（字段） 查询
		/// </summary>
		/// /// <param name = "miniGameTotalVal">小游戏累计值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByMiniGameTotalVal(long miniGameTotalVal, string sort_)
		{
			return GetByMiniGameTotalVal(miniGameTotalVal, 0, sort_, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByMiniGameTotalValAsync(long miniGameTotalVal, string sort_)
		{
			return await GetByMiniGameTotalValAsync(miniGameTotalVal, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MiniGameTotalVal（字段） 查询
		/// </summary>
		/// /// <param name = "miniGameTotalVal">小游戏累计值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByMiniGameTotalVal(long miniGameTotalVal, string sort_, TransactionManager tm_)
		{
			return GetByMiniGameTotalVal(miniGameTotalVal, 0, sort_, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByMiniGameTotalValAsync(long miniGameTotalVal, string sort_, TransactionManager tm_)
		{
			return await GetByMiniGameTotalValAsync(miniGameTotalVal, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MiniGameTotalVal（字段） 查询
		/// </summary>
		/// /// <param name = "miniGameTotalVal">小游戏累计值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByMiniGameTotalVal(long miniGameTotalVal, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MiniGameTotalVal` = @MiniGameTotalVal", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MiniGameTotalVal", miniGameTotalVal, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByMiniGameTotalValAsync(long miniGameTotalVal, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MiniGameTotalVal` = @MiniGameTotalVal", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MiniGameTotalVal", miniGameTotalVal, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByMiniGameTotalVal
		#region GetByFreeSpinCount
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByFreeSpinCount(int freeSpinCount)
		{
			return GetByFreeSpinCount(freeSpinCount, 0, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByFreeSpinCountAsync(int freeSpinCount)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByFreeSpinCount(int freeSpinCount, TransactionManager tm_)
		{
			return GetByFreeSpinCount(freeSpinCount, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByFreeSpinCountAsync(int freeSpinCount, TransactionManager tm_)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByFreeSpinCount(int freeSpinCount, int top_)
		{
			return GetByFreeSpinCount(freeSpinCount, top_, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByFreeSpinCountAsync(int freeSpinCount, int top_)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByFreeSpinCount(int freeSpinCount, int top_, TransactionManager tm_)
		{
			return GetByFreeSpinCount(freeSpinCount, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByFreeSpinCountAsync(int freeSpinCount, int top_, TransactionManager tm_)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByFreeSpinCount(int freeSpinCount, string sort_)
		{
			return GetByFreeSpinCount(freeSpinCount, 0, sort_, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByFreeSpinCountAsync(int freeSpinCount, string sort_)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByFreeSpinCount(int freeSpinCount, string sort_, TransactionManager tm_)
		{
			return GetByFreeSpinCount(freeSpinCount, 0, sort_, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByFreeSpinCountAsync(int freeSpinCount, string sort_, TransactionManager tm_)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByFreeSpinCount(int freeSpinCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FreeSpinCount` = @FreeSpinCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByFreeSpinCountAsync(int freeSpinCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FreeSpinCount` = @FreeSpinCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByFreeSpinCount
		#region GetByIsWin
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByIsWin(int isWin)
		{
			return GetByIsWin(isWin, 0, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByIsWinAsync(int isWin)
		{
			return await GetByIsWinAsync(isWin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByIsWin(int isWin, TransactionManager tm_)
		{
			return GetByIsWin(isWin, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByIsWinAsync(int isWin, TransactionManager tm_)
		{
			return await GetByIsWinAsync(isWin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByIsWin(int isWin, int top_)
		{
			return GetByIsWin(isWin, top_, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByIsWinAsync(int isWin, int top_)
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
		public List<Gsp_bet_detailEO> GetByIsWin(int isWin, int top_, TransactionManager tm_)
		{
			return GetByIsWin(isWin, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByIsWinAsync(int isWin, int top_, TransactionManager tm_)
		{
			return await GetByIsWinAsync(isWin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByIsWin(int isWin, string sort_)
		{
			return GetByIsWin(isWin, 0, sort_, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByIsWinAsync(int isWin, string sort_)
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
		public List<Gsp_bet_detailEO> GetByIsWin(int isWin, string sort_, TransactionManager tm_)
		{
			return GetByIsWin(isWin, 0, sort_, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByIsWinAsync(int isWin, string sort_, TransactionManager tm_)
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
		public List<Gsp_bet_detailEO> GetByIsWin(int isWin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsWin` = @IsWin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByIsWinAsync(int isWin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsWin` = @IsWin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByIsWin
		#region GetByWinAmount
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByWinAmount(long winAmount)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByWinAmountAsync(long winAmount)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByWinAmount(long winAmount, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByWinAmountAsync(long winAmount, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByWinAmount(long winAmount, int top_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByWinAmountAsync(long winAmount, int top_)
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
		public List<Gsp_bet_detailEO> GetByWinAmount(long winAmount, int top_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByWinAmountAsync(long winAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByWinAmount(long winAmount, string sort_)
		{
			return GetByWinAmount(winAmount, 0, sort_, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByWinAmountAsync(long winAmount, string sort_)
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
		public List<Gsp_bet_detailEO> GetByWinAmount(long winAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, sort_, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByWinAmountAsync(long winAmount, string sort_, TransactionManager tm_)
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
		public List<Gsp_bet_detailEO> GetByWinAmount(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByWinAmountAsync(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByWinAmount
		#region GetByTotalMultip
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByTotalMultip(int totalMultip)
		{
			return GetByTotalMultip(totalMultip, 0, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByTotalMultipAsync(int totalMultip)
		{
			return await GetByTotalMultipAsync(totalMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByTotalMultip(int totalMultip, TransactionManager tm_)
		{
			return GetByTotalMultip(totalMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByTotalMultipAsync(int totalMultip, TransactionManager tm_)
		{
			return await GetByTotalMultipAsync(totalMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByTotalMultip(int totalMultip, int top_)
		{
			return GetByTotalMultip(totalMultip, top_, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByTotalMultipAsync(int totalMultip, int top_)
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
		public List<Gsp_bet_detailEO> GetByTotalMultip(int totalMultip, int top_, TransactionManager tm_)
		{
			return GetByTotalMultip(totalMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByTotalMultipAsync(int totalMultip, int top_, TransactionManager tm_)
		{
			return await GetByTotalMultipAsync(totalMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByTotalMultip(int totalMultip, string sort_)
		{
			return GetByTotalMultip(totalMultip, 0, sort_, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByTotalMultipAsync(int totalMultip, string sort_)
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
		public List<Gsp_bet_detailEO> GetByTotalMultip(int totalMultip, string sort_, TransactionManager tm_)
		{
			return GetByTotalMultip(totalMultip, 0, sort_, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByTotalMultipAsync(int totalMultip, string sort_, TransactionManager tm_)
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
		public List<Gsp_bet_detailEO> GetByTotalMultip(int totalMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalMultip` = @TotalMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalMultip", totalMultip, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByTotalMultipAsync(int totalMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalMultip` = @TotalMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalMultip", totalMultip, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByTotalMultip
		#region GetByHistoryLine
		
		/// <summary>
		/// 按 HistoryLine（字段） 查询
		/// </summary>
		/// /// <param name = "historyLine">25条线记录</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByHistoryLine(string historyLine)
		{
			return GetByHistoryLine(historyLine, 0, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByHistoryLineAsync(string historyLine)
		{
			return await GetByHistoryLineAsync(historyLine, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HistoryLine（字段） 查询
		/// </summary>
		/// /// <param name = "historyLine">25条线记录</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByHistoryLine(string historyLine, TransactionManager tm_)
		{
			return GetByHistoryLine(historyLine, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByHistoryLineAsync(string historyLine, TransactionManager tm_)
		{
			return await GetByHistoryLineAsync(historyLine, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryLine（字段） 查询
		/// </summary>
		/// /// <param name = "historyLine">25条线记录</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByHistoryLine(string historyLine, int top_)
		{
			return GetByHistoryLine(historyLine, top_, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByHistoryLineAsync(string historyLine, int top_)
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
		public List<Gsp_bet_detailEO> GetByHistoryLine(string historyLine, int top_, TransactionManager tm_)
		{
			return GetByHistoryLine(historyLine, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByHistoryLineAsync(string historyLine, int top_, TransactionManager tm_)
		{
			return await GetByHistoryLineAsync(historyLine, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryLine（字段） 查询
		/// </summary>
		/// /// <param name = "historyLine">25条线记录</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByHistoryLine(string historyLine, string sort_)
		{
			return GetByHistoryLine(historyLine, 0, sort_, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByHistoryLineAsync(string historyLine, string sort_)
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
		public List<Gsp_bet_detailEO> GetByHistoryLine(string historyLine, string sort_, TransactionManager tm_)
		{
			return GetByHistoryLine(historyLine, 0, sort_, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByHistoryLineAsync(string historyLine, string sort_, TransactionManager tm_)
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
		public List<Gsp_bet_detailEO> GetByHistoryLine(string historyLine, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryLine` = @HistoryLine", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryLine", historyLine, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByHistoryLineAsync(string historyLine, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryLine` = @HistoryLine", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryLine", historyLine, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByHistoryLine
		#region GetByHistoryMultip
		
		/// <summary>
		/// 按 HistoryMultip（字段） 查询
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByHistoryMultip(string historyMultip)
		{
			return GetByHistoryMultip(historyMultip, 0, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByHistoryMultipAsync(string historyMultip)
		{
			return await GetByHistoryMultipAsync(historyMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HistoryMultip（字段） 查询
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByHistoryMultip(string historyMultip, TransactionManager tm_)
		{
			return GetByHistoryMultip(historyMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByHistoryMultipAsync(string historyMultip, TransactionManager tm_)
		{
			return await GetByHistoryMultipAsync(historyMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryMultip（字段） 查询
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByHistoryMultip(string historyMultip, int top_)
		{
			return GetByHistoryMultip(historyMultip, top_, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByHistoryMultipAsync(string historyMultip, int top_)
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
		public List<Gsp_bet_detailEO> GetByHistoryMultip(string historyMultip, int top_, TransactionManager tm_)
		{
			return GetByHistoryMultip(historyMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByHistoryMultipAsync(string historyMultip, int top_, TransactionManager tm_)
		{
			return await GetByHistoryMultipAsync(historyMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryMultip（字段） 查询
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByHistoryMultip(string historyMultip, string sort_)
		{
			return GetByHistoryMultip(historyMultip, 0, sort_, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByHistoryMultipAsync(string historyMultip, string sort_)
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
		public List<Gsp_bet_detailEO> GetByHistoryMultip(string historyMultip, string sort_, TransactionManager tm_)
		{
			return GetByHistoryMultip(historyMultip, 0, sort_, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByHistoryMultipAsync(string historyMultip, string sort_, TransactionManager tm_)
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
		public List<Gsp_bet_detailEO> GetByHistoryMultip(string historyMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryMultip` = @HistoryMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryMultip", historyMultip, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByHistoryMultipAsync(string historyMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryMultip` = @HistoryMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryMultip", historyMultip, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByHistoryMultip
		#region GetByOrderStatus
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByOrderStatus(int orderStatus)
		{
			return GetByOrderStatus(orderStatus, 0, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByOrderStatusAsync(int orderStatus)
		{
			return await GetByOrderStatusAsync(orderStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByOrderStatus(int orderStatus, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, TransactionManager tm_)
		{
			return await GetByOrderStatusAsync(orderStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByOrderStatus(int orderStatus, int top_)
		{
			return GetByOrderStatus(orderStatus, top_, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_)
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
		public List<Gsp_bet_detailEO> GetByOrderStatus(int orderStatus, int top_, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_, TransactionManager tm_)
		{
			return await GetByOrderStatusAsync(orderStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByOrderStatus(int orderStatus, string sort_)
		{
			return GetByOrderStatus(orderStatus, 0, sort_, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, string sort_)
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
		public List<Gsp_bet_detailEO> GetByOrderStatus(int orderStatus, string sort_, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, 0, sort_, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, string sort_, TransactionManager tm_)
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
		public List<Gsp_bet_detailEO> GetByOrderStatus(int orderStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderStatus` = @OrderStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderStatus` = @OrderStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByOrderStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByRecDate(DateTime? recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByRecDateAsync(DateTime? recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByRecDate(DateTime? recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByRecDate(DateTime? recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, int top_)
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
		public List<Gsp_bet_detailEO> GetByRecDate(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_bet_detailEO> GetByRecDate(DateTime? recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, string sort_)
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
		public List<Gsp_bet_detailEO> GetByRecDate(DateTime? recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, string sort_, TransactionManager tm_)
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
		public List<Gsp_bet_detailEO> GetByRecDate(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Gsp_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
