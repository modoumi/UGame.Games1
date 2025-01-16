/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-11 17: 14:07
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

namespace Fortune_rabbit.DAL
{
	#region EO
	/// <summary>
	/// 下注表
	/// 【表 fra_bet_detail 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Fra_bet_detailEO : IRowMapper<Fra_bet_detailEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Fra_bet_detailEO()
		{
			this.ChipsID = 0;
			this.BalanceAmountBefore = 0;
			this.BalanceAmountAfter = 0;
			this.BetAmount = 0;
			this.WinAmount = 0;
			this.TotalMultip = 0f;
			this.TriggerSM = 0;
			this.TriggerSE = 0;
			this.UserFlag = -1;
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
		/// 订单分组ID
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 2)]
		public string GroupId { get; set; }
		/// <summary>
		/// 下注配置ID
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int ChipsID { get; set; }
		/// <summary>
		/// appid
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string AppID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 5)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 用户Id
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 6)]
		public string UserID { get; set; }
		/// <summary>
		/// 下注后余额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long BalanceAmountBefore { get; set; }
		/// <summary>
		/// 下注后余额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long BalanceAmountAfter { get; set; }
		/// <summary>
		/// 实际下注金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 9)]
		public long BetAmount { get; set; }
		/// <summary>
		/// 返奖金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 10)]
		public long WinAmount { get; set; }
		/// <summary>
		/// 是否中奖(奖池是否够)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int IsWin { get; set; }
		/// <summary>
		/// 中奖总倍数
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 12)]
		public float TotalMultip { get; set; }
		/// <summary>
		/// 触发Special mode
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 13)]
		public int TriggerSM { get; set; }
		/// <summary>
		/// 触发Special effects
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 14)]
		public int TriggerSE { get; set; }
		/// <summary>
		/// 中奖详情
		/// 【字段 varchar(1000)】
		/// </summary>
		[DataMember(Order = 15)]
		public string RewardDetails { get; set; }
		/// <summary>
		/// 小游戏数据结构
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 16)]
		public string BonusDetailList { get; set; }
		/// <summary>
		/// 中奖牌面
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 17)]
		public string SlotEleArray { get; set; }
		/// <summary>
		/// 用户AB面
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 18)]
		public int UserFlag { get; set; }
		/// <summary>
		/// 状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 19)]
		public int OrderStatus { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 20)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 备注
		/// 【字段 varchar(1000)】
		/// </summary>
		[DataMember(Order = 21)]
		public string Memo { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Fra_bet_detailEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Fra_bet_detailEO MapDataReader(IDataReader reader)
		{
		    Fra_bet_detailEO ret = new Fra_bet_detailEO();
			ret.BetID = reader.ToInt64("BetID");
			ret.OriginalBetID = ret.BetID;
			ret.GroupId = reader.ToString("GroupId");
			ret.ChipsID = reader.ToInt32("ChipsID");
			ret.AppID = reader.ToString("AppID");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.UserID = reader.ToString("UserID");
			ret.BalanceAmountBefore = reader.ToInt64("BalanceAmountBefore");
			ret.BalanceAmountAfter = reader.ToInt64("BalanceAmountAfter");
			ret.BetAmount = reader.ToInt64("BetAmount");
			ret.WinAmount = reader.ToInt64("WinAmount");
			ret.IsWin = reader.ToInt32("IsWin");
			ret.TotalMultip = reader.ToSingle("TotalMultip");
			ret.TriggerSM = reader.ToInt32("TriggerSM");
			ret.TriggerSE = reader.ToInt32("TriggerSE");
			ret.RewardDetails = reader.ToString("RewardDetails");
			ret.BonusDetailList = reader.ToString("BonusDetailList");
			ret.SlotEleArray = reader.ToString("SlotEleArray");
			ret.UserFlag = reader.ToInt32("UserFlag");
			ret.OrderStatus = reader.ToInt32("OrderStatus");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.Memo = reader.ToString("Memo");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 下注表
	/// 【表 fra_bet_detail 的操作类】
	/// </summary>
	[Obsolete]
	public class Fra_bet_detailMO : MySqlTableMO<Fra_bet_detailEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`fra_bet_detail`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Fra_bet_detailMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Fra_bet_detailMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Fra_bet_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Fra_bet_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Fra_bet_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Fra_bet_detailEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`BetID`, `GroupId`, `ChipsID`, `AppID`, `OperatorID`, `UserID`, `BalanceAmountBefore`, `BalanceAmountAfter`, `BetAmount`, `WinAmount`, `IsWin`, `TotalMultip`, `TriggerSM`, `TriggerSE`, `RewardDetails`, `BonusDetailList`, `SlotEleArray`, `UserFlag`, `OrderStatus`, `RecDate`, `Memo`) VALUE (@BetID, @GroupId, @ChipsID, @AppID, @OperatorID, @UserID, @BalanceAmountBefore, @BalanceAmountAfter, @BetAmount, @WinAmount, @IsWin, @TotalMultip, @TriggerSM, @TriggerSE, @RewardDetails, @BonusDetailList, @SlotEleArray, @UserFlag, @OrderStatus, @RecDate, @Memo);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", item.BetID, MySqlDbType.Int64),
				Database.CreateInParameter("@GroupId", item.GroupId, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BalanceAmountBefore", item.BalanceAmountBefore, MySqlDbType.Int64),
				Database.CreateInParameter("@BalanceAmountAfter", item.BalanceAmountAfter, MySqlDbType.Int64),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@IsWin", item.IsWin, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalMultip", item.TotalMultip, MySqlDbType.Float),
				Database.CreateInParameter("@TriggerSM", item.TriggerSM, MySqlDbType.Int32),
				Database.CreateInParameter("@TriggerSE", item.TriggerSE, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardDetails", item.RewardDetails, MySqlDbType.VarChar),
				Database.CreateInParameter("@BonusDetailList", item.BonusDetailList, MySqlDbType.Text),
				Database.CreateInParameter("@SlotEleArray", item.SlotEleArray, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserFlag", item.UserFlag, MySqlDbType.Int32),
				Database.CreateInParameter("@OrderStatus", item.OrderStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@Memo", item.Memo, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Fra_bet_detailEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Fra_bet_detailEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Fra_bet_detailEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`BetID`, `GroupId`, `ChipsID`, `AppID`, `OperatorID`, `UserID`, `BalanceAmountBefore`, `BalanceAmountAfter`, `BetAmount`, `WinAmount`, `IsWin`, `TotalMultip`, `TriggerSM`, `TriggerSE`, `RewardDetails`, `BonusDetailList`, `SlotEleArray`, `UserFlag`, `OrderStatus`, `RecDate`, `Memo`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.BetID},'{item.GroupId}',{item.ChipsID},'{item.AppID}','{item.OperatorID}','{item.UserID}',{item.BalanceAmountBefore},{item.BalanceAmountAfter},{item.BetAmount},{item.WinAmount},{item.IsWin},{item.TotalMultip},{item.TriggerSM},{item.TriggerSE},'{item.RewardDetails}','{item.BonusDetailList}','{item.SlotEleArray}',{item.UserFlag},{item.OrderStatus},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.Memo}'),");
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
		public int Remove(Fra_bet_detailEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.BetID, tm_);
		}
		public async Task<int> RemoveAsync(Fra_bet_detailEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.BetID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByGroupId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "groupId">订单分组ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByGroupId(string groupId, TransactionManager tm_ = null)
		{
			RepairRemoveByGroupIdData(groupId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByGroupIdAsync(string groupId, TransactionManager tm_ = null)
		{
			RepairRemoveByGroupIdData(groupId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByGroupIdData(string groupId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `GroupId` = @GroupId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@GroupId", groupId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByGroupId
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
		#region RemoveByBalanceAmountBefore
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后余额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBalanceAmountBefore(long balanceAmountBefore, TransactionManager tm_ = null)
		{
			RepairRemoveByBalanceAmountBeforeData(balanceAmountBefore, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBalanceAmountBeforeAsync(long balanceAmountBefore, TransactionManager tm_ = null)
		{
			RepairRemoveByBalanceAmountBeforeData(balanceAmountBefore, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBalanceAmountBeforeData(long balanceAmountBefore, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BalanceAmountBefore` = @BalanceAmountBefore";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BalanceAmountBefore", balanceAmountBefore, MySqlDbType.Int64));
		}
		#endregion // RemoveByBalanceAmountBefore
		#region RemoveByBalanceAmountAfter
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "balanceAmountAfter">下注后余额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBalanceAmountAfter(long balanceAmountAfter, TransactionManager tm_ = null)
		{
			RepairRemoveByBalanceAmountAfterData(balanceAmountAfter, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBalanceAmountAfterAsync(long balanceAmountAfter, TransactionManager tm_ = null)
		{
			RepairRemoveByBalanceAmountAfterData(balanceAmountAfter, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBalanceAmountAfterData(long balanceAmountAfter, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BalanceAmountAfter` = @BalanceAmountAfter";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BalanceAmountAfter", balanceAmountAfter, MySqlDbType.Int64));
		}
		#endregion // RemoveByBalanceAmountAfter
		#region RemoveByBetAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betAmount">实际下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetAmount(long betAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetAmountData(betAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetAmountAsync(long betAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetAmountData(betAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetAmountData(long betAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetAmount` = @BetAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetAmount
		#region RemoveByWinAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winAmount">返奖金额</param>
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
		#region RemoveByIsWin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isWin">是否中奖(奖池是否够)</param>
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
		#region RemoveByTotalMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalMultip(float totalMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalMultipData(totalMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalMultipAsync(float totalMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalMultipData(totalMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalMultipData(float totalMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalMultip` = @TotalMultip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalMultip", totalMultip, MySqlDbType.Float));
		}
		#endregion // RemoveByTotalMultip
		#region RemoveByTriggerSM
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "triggerSM">触发Special mode</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTriggerSM(int triggerSM, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerSMData(triggerSM, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTriggerSMAsync(int triggerSM, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerSMData(triggerSM, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTriggerSMData(int triggerSM, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TriggerSM` = @TriggerSM";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerSM", triggerSM, MySqlDbType.Int32));
		}
		#endregion // RemoveByTriggerSM
		#region RemoveByTriggerSE
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "triggerSE">触发Special effects</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTriggerSE(int triggerSE, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerSEData(triggerSE, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTriggerSEAsync(int triggerSE, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerSEData(triggerSE, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTriggerSEData(int triggerSE, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TriggerSE` = @TriggerSE";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerSE", triggerSE, MySqlDbType.Int32));
		}
		#endregion // RemoveByTriggerSE
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
		#region RemoveByBonusDetailList
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bonusDetailList">小游戏数据结构</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBonusDetailList(string bonusDetailList, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusDetailListData(bonusDetailList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBonusDetailListAsync(string bonusDetailList, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusDetailListData(bonusDetailList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBonusDetailListData(string bonusDetailList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BonusDetailList` = @BonusDetailList";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BonusDetailList", bonusDetailList, MySqlDbType.Text));
		}
		#endregion // RemoveByBonusDetailList
		#region RemoveBySlotEleArray
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "slotEleArray">中奖牌面</param>
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
		#region RemoveByMemo
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "memo">备注</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMemo(string memo, TransactionManager tm_ = null)
		{
			RepairRemoveByMemoData(memo, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMemoAsync(string memo, TransactionManager tm_ = null)
		{
			RepairRemoveByMemoData(memo, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMemoData(string memo, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Memo` = @Memo";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Memo", memo, MySqlDbType.VarChar));
		}
		#endregion // RemoveByMemo
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
		public int Put(Fra_bet_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Fra_bet_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Fra_bet_detailEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetID` = @BetID, `GroupId` = @GroupId, `ChipsID` = @ChipsID, `AppID` = @AppID, `OperatorID` = @OperatorID, `UserID` = @UserID, `BalanceAmountBefore` = @BalanceAmountBefore, `BalanceAmountAfter` = @BalanceAmountAfter, `BetAmount` = @BetAmount, `WinAmount` = @WinAmount, `IsWin` = @IsWin, `TotalMultip` = @TotalMultip, `TriggerSM` = @TriggerSM, `TriggerSE` = @TriggerSE, `RewardDetails` = @RewardDetails, `BonusDetailList` = @BonusDetailList, `SlotEleArray` = @SlotEleArray, `UserFlag` = @UserFlag, `OrderStatus` = @OrderStatus, `Memo` = @Memo WHERE `BetID` = @BetID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", item.BetID, MySqlDbType.Int64),
				Database.CreateInParameter("@GroupId", item.GroupId, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BalanceAmountBefore", item.BalanceAmountBefore, MySqlDbType.Int64),
				Database.CreateInParameter("@BalanceAmountAfter", item.BalanceAmountAfter, MySqlDbType.Int64),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@IsWin", item.IsWin, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalMultip", item.TotalMultip, MySqlDbType.Float),
				Database.CreateInParameter("@TriggerSM", item.TriggerSM, MySqlDbType.Int32),
				Database.CreateInParameter("@TriggerSE", item.TriggerSE, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardDetails", item.RewardDetails, MySqlDbType.VarChar),
				Database.CreateInParameter("@BonusDetailList", item.BonusDetailList, MySqlDbType.Text),
				Database.CreateInParameter("@SlotEleArray", item.SlotEleArray, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserFlag", item.UserFlag, MySqlDbType.Int32),
				Database.CreateInParameter("@OrderStatus", item.OrderStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@Memo", item.Memo, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetID_Original", item.HasOriginal ? item.OriginalBetID : item.BetID, MySqlDbType.Int64),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Fra_bet_detailEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Fra_bet_detailEO> items, TransactionManager tm_ = null)
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
		#region PutGroupId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "groupId">订单分组ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGroupIdByPK(long betID, string groupId, TransactionManager tm_ = null)
		{
			RepairPutGroupIdByPKData(betID, groupId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutGroupIdByPKAsync(long betID, string groupId, TransactionManager tm_ = null)
		{
			RepairPutGroupIdByPKData(betID, groupId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutGroupIdByPKData(long betID, string groupId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `GroupId` = @GroupId  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@GroupId", groupId, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "groupId">订单分组ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGroupId(string groupId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GroupId` = @GroupId";
			var parameter_ = Database.CreateInParameter("@GroupId", groupId, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutGroupIdAsync(string groupId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GroupId` = @GroupId";
			var parameter_ = Database.CreateInParameter("@GroupId", groupId, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutGroupId
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
		#region PutBalanceAmountBefore
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "balanceAmountBefore">下注后余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBalanceAmountBeforeByPK(long betID, long balanceAmountBefore, TransactionManager tm_ = null)
		{
			RepairPutBalanceAmountBeforeByPKData(betID, balanceAmountBefore, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBalanceAmountBeforeByPKAsync(long betID, long balanceAmountBefore, TransactionManager tm_ = null)
		{
			RepairPutBalanceAmountBeforeByPKData(betID, balanceAmountBefore, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBalanceAmountBeforeByPKData(long betID, long balanceAmountBefore, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BalanceAmountBefore` = @BalanceAmountBefore  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BalanceAmountBefore", balanceAmountBefore, MySqlDbType.Int64),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBalanceAmountBefore(long balanceAmountBefore, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BalanceAmountBefore` = @BalanceAmountBefore";
			var parameter_ = Database.CreateInParameter("@BalanceAmountBefore", balanceAmountBefore, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBalanceAmountBeforeAsync(long balanceAmountBefore, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BalanceAmountBefore` = @BalanceAmountBefore";
			var parameter_ = Database.CreateInParameter("@BalanceAmountBefore", balanceAmountBefore, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBalanceAmountBefore
		#region PutBalanceAmountAfter
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "balanceAmountAfter">下注后余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBalanceAmountAfterByPK(long betID, long balanceAmountAfter, TransactionManager tm_ = null)
		{
			RepairPutBalanceAmountAfterByPKData(betID, balanceAmountAfter, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBalanceAmountAfterByPKAsync(long betID, long balanceAmountAfter, TransactionManager tm_ = null)
		{
			RepairPutBalanceAmountAfterByPKData(betID, balanceAmountAfter, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBalanceAmountAfterByPKData(long betID, long balanceAmountAfter, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BalanceAmountAfter` = @BalanceAmountAfter  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BalanceAmountAfter", balanceAmountAfter, MySqlDbType.Int64),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "balanceAmountAfter">下注后余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBalanceAmountAfter(long balanceAmountAfter, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BalanceAmountAfter` = @BalanceAmountAfter";
			var parameter_ = Database.CreateInParameter("@BalanceAmountAfter", balanceAmountAfter, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBalanceAmountAfterAsync(long balanceAmountAfter, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BalanceAmountAfter` = @BalanceAmountAfter";
			var parameter_ = Database.CreateInParameter("@BalanceAmountAfter", balanceAmountAfter, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBalanceAmountAfter
		#region PutBetAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "betAmount">实际下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetAmountByPK(long betID, long betAmount, TransactionManager tm_ = null)
		{
			RepairPutBetAmountByPKData(betID, betAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetAmountByPKAsync(long betID, long betAmount, TransactionManager tm_ = null)
		{
			RepairPutBetAmountByPKData(betID, betAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetAmountByPKData(long betID, long betAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betAmount">实际下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetAmount(long betAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount";
			var parameter_ = Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetAmountAsync(long betAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount";
			var parameter_ = Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetAmount
		#region PutWinAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "winAmount">返奖金额</param>
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
		/// /// <param name = "winAmount">返奖金额</param>
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
		#region PutIsWin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "isWin">是否中奖(奖池是否够)</param>
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
		/// /// <param name = "isWin">是否中奖(奖池是否够)</param>
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
		#region PutTotalMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalMultipByPK(long betID, float totalMultip, TransactionManager tm_ = null)
		{
			RepairPutTotalMultipByPKData(betID, totalMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalMultipByPKAsync(long betID, float totalMultip, TransactionManager tm_ = null)
		{
			RepairPutTotalMultipByPKData(betID, totalMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalMultipByPKData(long betID, float totalMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalMultip` = @TotalMultip  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalMultip", totalMultip, MySqlDbType.Float),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalMultip(float totalMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalMultip` = @TotalMultip";
			var parameter_ = Database.CreateInParameter("@TotalMultip", totalMultip, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalMultipAsync(float totalMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalMultip` = @TotalMultip";
			var parameter_ = Database.CreateInParameter("@TotalMultip", totalMultip, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalMultip
		#region PutTriggerSM
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "triggerSM">触发Special mode</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerSMByPK(long betID, int triggerSM, TransactionManager tm_ = null)
		{
			RepairPutTriggerSMByPKData(betID, triggerSM, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTriggerSMByPKAsync(long betID, int triggerSM, TransactionManager tm_ = null)
		{
			RepairPutTriggerSMByPKData(betID, triggerSM, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTriggerSMByPKData(long betID, int triggerSM, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TriggerSM` = @TriggerSM  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TriggerSM", triggerSM, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "triggerSM">触发Special mode</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerSM(int triggerSM, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerSM` = @TriggerSM";
			var parameter_ = Database.CreateInParameter("@TriggerSM", triggerSM, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTriggerSMAsync(int triggerSM, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerSM` = @TriggerSM";
			var parameter_ = Database.CreateInParameter("@TriggerSM", triggerSM, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTriggerSM
		#region PutTriggerSE
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "triggerSE">触发Special effects</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerSEByPK(long betID, int triggerSE, TransactionManager tm_ = null)
		{
			RepairPutTriggerSEByPKData(betID, triggerSE, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTriggerSEByPKAsync(long betID, int triggerSE, TransactionManager tm_ = null)
		{
			RepairPutTriggerSEByPKData(betID, triggerSE, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTriggerSEByPKData(long betID, int triggerSE, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TriggerSE` = @TriggerSE  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TriggerSE", triggerSE, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "triggerSE">触发Special effects</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerSE(int triggerSE, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerSE` = @TriggerSE";
			var parameter_ = Database.CreateInParameter("@TriggerSE", triggerSE, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTriggerSEAsync(int triggerSE, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerSE` = @TriggerSE";
			var parameter_ = Database.CreateInParameter("@TriggerSE", triggerSE, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTriggerSE
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
		#region PutBonusDetailList
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "bonusDetailList">小游戏数据结构</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonusDetailListByPK(long betID, string bonusDetailList, TransactionManager tm_ = null)
		{
			RepairPutBonusDetailListByPKData(betID, bonusDetailList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBonusDetailListByPKAsync(long betID, string bonusDetailList, TransactionManager tm_ = null)
		{
			RepairPutBonusDetailListByPKData(betID, bonusDetailList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBonusDetailListByPKData(long betID, string bonusDetailList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BonusDetailList` = @BonusDetailList  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BonusDetailList", bonusDetailList, MySqlDbType.Text),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bonusDetailList">小游戏数据结构</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonusDetailList(string bonusDetailList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BonusDetailList` = @BonusDetailList";
			var parameter_ = Database.CreateInParameter("@BonusDetailList", bonusDetailList, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBonusDetailListAsync(string bonusDetailList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BonusDetailList` = @BonusDetailList";
			var parameter_ = Database.CreateInParameter("@BonusDetailList", bonusDetailList, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBonusDetailList
		#region PutSlotEleArray
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "slotEleArray">中奖牌面</param>
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
		/// /// <param name = "slotEleArray">中奖牌面</param>
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
		#region PutMemo
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "memo">备注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMemoByPK(long betID, string memo, TransactionManager tm_ = null)
		{
			RepairPutMemoByPKData(betID, memo, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMemoByPKAsync(long betID, string memo, TransactionManager tm_ = null)
		{
			RepairPutMemoByPKData(betID, memo, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMemoByPKData(long betID, string memo, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Memo` = @Memo  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Memo", memo, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "memo">备注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMemo(string memo, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Memo` = @Memo";
			var parameter_ = Database.CreateInParameter("@Memo", memo, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMemoAsync(string memo, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Memo` = @Memo";
			var parameter_ = Database.CreateInParameter("@Memo", memo, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMemo
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Fra_bet_detailEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Fra_bet_detailEO item, TransactionManager tm = null)
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
		public Fra_bet_detailEO GetByPK(long betID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(betID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<Fra_bet_detailEO> GetByPKAsync(long betID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(betID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
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
		/// 按主键查询 GroupId（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetGroupIdByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`GroupId`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetGroupIdByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`GroupId`", "`BetID` = @BetID", paras_, tm_);
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
		/// 按主键查询 BalanceAmountBefore（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBalanceAmountBeforeByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)GetScalar("`BalanceAmountBefore`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<long> GetBalanceAmountBeforeByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`BalanceAmountBefore`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BalanceAmountAfter（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBalanceAmountAfterByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)GetScalar("`BalanceAmountAfter`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<long> GetBalanceAmountAfterByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`BalanceAmountAfter`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetAmount（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetAmountByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)GetScalar("`BetAmount`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<long> GetBetAmountByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`BetAmount`", "`BetID` = @BetID", paras_, tm_);
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
		/// 按主键查询 TotalMultip（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetTotalMultipByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (float)GetScalar("`TotalMultip`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<float> GetTotalMultipByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (float)await GetScalarAsync("`TotalMultip`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TriggerSM（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTriggerSMByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`TriggerSM`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetTriggerSMByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`TriggerSM`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TriggerSE（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTriggerSEByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`TriggerSE`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetTriggerSEByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`TriggerSE`", "`BetID` = @BetID", paras_, tm_);
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
		/// 按主键查询 BonusDetailList（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBonusDetailListByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`BonusDetailList`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetBonusDetailListByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`BonusDetailList`", "`BetID` = @BetID", paras_, tm_);
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
		
		/// <summary>
		/// 按主键查询 Memo（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMemoByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`Memo`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetMemoByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`Memo`", "`BetID` = @BetID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByGroupId
		
		/// <summary>
		/// 按 GroupId（字段） 查询
		/// </summary>
		/// /// <param name = "groupId">订单分组ID</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByGroupId(string groupId)
		{
			return GetByGroupId(groupId, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByGroupIdAsync(string groupId)
		{
			return await GetByGroupIdAsync(groupId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GroupId（字段） 查询
		/// </summary>
		/// /// <param name = "groupId">订单分组ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByGroupId(string groupId, TransactionManager tm_)
		{
			return GetByGroupId(groupId, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByGroupIdAsync(string groupId, TransactionManager tm_)
		{
			return await GetByGroupIdAsync(groupId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GroupId（字段） 查询
		/// </summary>
		/// /// <param name = "groupId">订单分组ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByGroupId(string groupId, int top_)
		{
			return GetByGroupId(groupId, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByGroupIdAsync(string groupId, int top_)
		{
			return await GetByGroupIdAsync(groupId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GroupId（字段） 查询
		/// </summary>
		/// /// <param name = "groupId">订单分组ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByGroupId(string groupId, int top_, TransactionManager tm_)
		{
			return GetByGroupId(groupId, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByGroupIdAsync(string groupId, int top_, TransactionManager tm_)
		{
			return await GetByGroupIdAsync(groupId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GroupId（字段） 查询
		/// </summary>
		/// /// <param name = "groupId">订单分组ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByGroupId(string groupId, string sort_)
		{
			return GetByGroupId(groupId, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByGroupIdAsync(string groupId, string sort_)
		{
			return await GetByGroupIdAsync(groupId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 GroupId（字段） 查询
		/// </summary>
		/// /// <param name = "groupId">订单分组ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByGroupId(string groupId, string sort_, TransactionManager tm_)
		{
			return GetByGroupId(groupId, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByGroupIdAsync(string groupId, string sort_, TransactionManager tm_)
		{
			return await GetByGroupIdAsync(groupId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 GroupId（字段） 查询
		/// </summary>
		/// /// <param name = "groupId">订单分组ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByGroupId(string groupId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`GroupId` = @GroupId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@GroupId", groupId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByGroupIdAsync(string groupId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`GroupId` = @GroupId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@GroupId", groupId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByGroupId
		#region GetByChipsID
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByChipsID(int chipsID)
		{
			return GetByChipsID(chipsID, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByChipsIDAsync(int chipsID)
		{
			return await GetByChipsIDAsync(chipsID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByChipsID(int chipsID, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByChipsIDAsync(int chipsID, TransactionManager tm_)
		{
			return await GetByChipsIDAsync(chipsID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByChipsID(int chipsID, int top_)
		{
			return GetByChipsID(chipsID, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByChipsIDAsync(int chipsID, int top_)
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
		public List<Fra_bet_detailEO> GetByChipsID(int chipsID, int top_, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByChipsIDAsync(int chipsID, int top_, TransactionManager tm_)
		{
			return await GetByChipsIDAsync(chipsID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByChipsID(int chipsID, string sort_)
		{
			return GetByChipsID(chipsID, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByChipsIDAsync(int chipsID, string sort_)
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
		public List<Fra_bet_detailEO> GetByChipsID(int chipsID, string sort_, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByChipsIDAsync(int chipsID, string sort_, TransactionManager tm_)
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
		public List<Fra_bet_detailEO> GetByChipsID(int chipsID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByChipsIDAsync(int chipsID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByChipsID
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByAppIDAsync(string appID, int top_)
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
		public List<Fra_bet_detailEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByAppIDAsync(string appID, string sort_)
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
		public List<Fra_bet_detailEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
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
		public List<Fra_bet_detailEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Fra_bet_detailEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Fra_bet_detailEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Fra_bet_detailEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByUserIDAsync(string userID, int top_)
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
		public List<Fra_bet_detailEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByUserIDAsync(string userID, string sort_)
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
		public List<Fra_bet_detailEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
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
		public List<Fra_bet_detailEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByBalanceAmountBefore
		
		/// <summary>
		/// 按 BalanceAmountBefore（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后余额</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBalanceAmountBefore(long balanceAmountBefore)
		{
			return GetByBalanceAmountBefore(balanceAmountBefore, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBalanceAmountBeforeAsync(long balanceAmountBefore)
		{
			return await GetByBalanceAmountBeforeAsync(balanceAmountBefore, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BalanceAmountBefore（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBalanceAmountBefore(long balanceAmountBefore, TransactionManager tm_)
		{
			return GetByBalanceAmountBefore(balanceAmountBefore, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBalanceAmountBeforeAsync(long balanceAmountBefore, TransactionManager tm_)
		{
			return await GetByBalanceAmountBeforeAsync(balanceAmountBefore, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BalanceAmountBefore（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后余额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBalanceAmountBefore(long balanceAmountBefore, int top_)
		{
			return GetByBalanceAmountBefore(balanceAmountBefore, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBalanceAmountBeforeAsync(long balanceAmountBefore, int top_)
		{
			return await GetByBalanceAmountBeforeAsync(balanceAmountBefore, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BalanceAmountBefore（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后余额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBalanceAmountBefore(long balanceAmountBefore, int top_, TransactionManager tm_)
		{
			return GetByBalanceAmountBefore(balanceAmountBefore, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBalanceAmountBeforeAsync(long balanceAmountBefore, int top_, TransactionManager tm_)
		{
			return await GetByBalanceAmountBeforeAsync(balanceAmountBefore, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BalanceAmountBefore（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后余额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBalanceAmountBefore(long balanceAmountBefore, string sort_)
		{
			return GetByBalanceAmountBefore(balanceAmountBefore, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBalanceAmountBeforeAsync(long balanceAmountBefore, string sort_)
		{
			return await GetByBalanceAmountBeforeAsync(balanceAmountBefore, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BalanceAmountBefore（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后余额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBalanceAmountBefore(long balanceAmountBefore, string sort_, TransactionManager tm_)
		{
			return GetByBalanceAmountBefore(balanceAmountBefore, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBalanceAmountBeforeAsync(long balanceAmountBefore, string sort_, TransactionManager tm_)
		{
			return await GetByBalanceAmountBeforeAsync(balanceAmountBefore, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BalanceAmountBefore（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后余额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBalanceAmountBefore(long balanceAmountBefore, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BalanceAmountBefore` = @BalanceAmountBefore", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BalanceAmountBefore", balanceAmountBefore, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBalanceAmountBeforeAsync(long balanceAmountBefore, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BalanceAmountBefore` = @BalanceAmountBefore", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BalanceAmountBefore", balanceAmountBefore, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByBalanceAmountBefore
		#region GetByBalanceAmountAfter
		
		/// <summary>
		/// 按 BalanceAmountAfter（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountAfter">下注后余额</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBalanceAmountAfter(long balanceAmountAfter)
		{
			return GetByBalanceAmountAfter(balanceAmountAfter, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBalanceAmountAfterAsync(long balanceAmountAfter)
		{
			return await GetByBalanceAmountAfterAsync(balanceAmountAfter, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BalanceAmountAfter（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountAfter">下注后余额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBalanceAmountAfter(long balanceAmountAfter, TransactionManager tm_)
		{
			return GetByBalanceAmountAfter(balanceAmountAfter, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBalanceAmountAfterAsync(long balanceAmountAfter, TransactionManager tm_)
		{
			return await GetByBalanceAmountAfterAsync(balanceAmountAfter, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BalanceAmountAfter（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountAfter">下注后余额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBalanceAmountAfter(long balanceAmountAfter, int top_)
		{
			return GetByBalanceAmountAfter(balanceAmountAfter, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBalanceAmountAfterAsync(long balanceAmountAfter, int top_)
		{
			return await GetByBalanceAmountAfterAsync(balanceAmountAfter, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BalanceAmountAfter（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountAfter">下注后余额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBalanceAmountAfter(long balanceAmountAfter, int top_, TransactionManager tm_)
		{
			return GetByBalanceAmountAfter(balanceAmountAfter, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBalanceAmountAfterAsync(long balanceAmountAfter, int top_, TransactionManager tm_)
		{
			return await GetByBalanceAmountAfterAsync(balanceAmountAfter, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BalanceAmountAfter（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountAfter">下注后余额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBalanceAmountAfter(long balanceAmountAfter, string sort_)
		{
			return GetByBalanceAmountAfter(balanceAmountAfter, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBalanceAmountAfterAsync(long balanceAmountAfter, string sort_)
		{
			return await GetByBalanceAmountAfterAsync(balanceAmountAfter, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BalanceAmountAfter（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountAfter">下注后余额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBalanceAmountAfter(long balanceAmountAfter, string sort_, TransactionManager tm_)
		{
			return GetByBalanceAmountAfter(balanceAmountAfter, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBalanceAmountAfterAsync(long balanceAmountAfter, string sort_, TransactionManager tm_)
		{
			return await GetByBalanceAmountAfterAsync(balanceAmountAfter, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BalanceAmountAfter（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountAfter">下注后余额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBalanceAmountAfter(long balanceAmountAfter, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BalanceAmountAfter` = @BalanceAmountAfter", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BalanceAmountAfter", balanceAmountAfter, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBalanceAmountAfterAsync(long balanceAmountAfter, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BalanceAmountAfter` = @BalanceAmountAfter", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BalanceAmountAfter", balanceAmountAfter, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByBalanceAmountAfter
		#region GetByBetAmount
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">实际下注金额</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBetAmount(long betAmount)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBetAmountAsync(long betAmount)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">实际下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBetAmount(long betAmount, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBetAmountAsync(long betAmount, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">实际下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBetAmount(long betAmount, int top_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBetAmountAsync(long betAmount, int top_)
		{
			return await GetByBetAmountAsync(betAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">实际下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBetAmount(long betAmount, int top_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBetAmountAsync(long betAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">实际下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBetAmount(long betAmount, string sort_)
		{
			return GetByBetAmount(betAmount, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBetAmountAsync(long betAmount, string sort_)
		{
			return await GetByBetAmountAsync(betAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">实际下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBetAmount(long betAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBetAmountAsync(long betAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">实际下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBetAmount(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBetAmountAsync(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByBetAmount
		#region GetByWinAmount
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖金额</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByWinAmount(long winAmount)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByWinAmountAsync(long winAmount)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByWinAmount(long winAmount, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByWinAmountAsync(long winAmount, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByWinAmount(long winAmount, int top_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByWinAmountAsync(long winAmount, int top_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByWinAmount(long winAmount, int top_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByWinAmountAsync(long winAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByWinAmount(long winAmount, string sort_)
		{
			return GetByWinAmount(winAmount, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByWinAmountAsync(long winAmount, string sort_)
		{
			return await GetByWinAmountAsync(winAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByWinAmount(long winAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByWinAmountAsync(long winAmount, string sort_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByWinAmount(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByWinAmountAsync(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByWinAmount
		#region GetByIsWin
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖(奖池是否够)</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByIsWin(int isWin)
		{
			return GetByIsWin(isWin, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByIsWinAsync(int isWin)
		{
			return await GetByIsWinAsync(isWin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖(奖池是否够)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByIsWin(int isWin, TransactionManager tm_)
		{
			return GetByIsWin(isWin, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByIsWinAsync(int isWin, TransactionManager tm_)
		{
			return await GetByIsWinAsync(isWin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖(奖池是否够)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByIsWin(int isWin, int top_)
		{
			return GetByIsWin(isWin, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByIsWinAsync(int isWin, int top_)
		{
			return await GetByIsWinAsync(isWin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖(奖池是否够)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByIsWin(int isWin, int top_, TransactionManager tm_)
		{
			return GetByIsWin(isWin, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByIsWinAsync(int isWin, int top_, TransactionManager tm_)
		{
			return await GetByIsWinAsync(isWin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖(奖池是否够)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByIsWin(int isWin, string sort_)
		{
			return GetByIsWin(isWin, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByIsWinAsync(int isWin, string sort_)
		{
			return await GetByIsWinAsync(isWin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖(奖池是否够)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByIsWin(int isWin, string sort_, TransactionManager tm_)
		{
			return GetByIsWin(isWin, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByIsWinAsync(int isWin, string sort_, TransactionManager tm_)
		{
			return await GetByIsWinAsync(isWin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖(奖池是否够)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByIsWin(int isWin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsWin` = @IsWin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByIsWinAsync(int isWin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsWin` = @IsWin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByIsWin
		#region GetByTotalMultip
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTotalMultip(float totalMultip)
		{
			return GetByTotalMultip(totalMultip, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTotalMultipAsync(float totalMultip)
		{
			return await GetByTotalMultipAsync(totalMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTotalMultip(float totalMultip, TransactionManager tm_)
		{
			return GetByTotalMultip(totalMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTotalMultipAsync(float totalMultip, TransactionManager tm_)
		{
			return await GetByTotalMultipAsync(totalMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTotalMultip(float totalMultip, int top_)
		{
			return GetByTotalMultip(totalMultip, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTotalMultipAsync(float totalMultip, int top_)
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
		public List<Fra_bet_detailEO> GetByTotalMultip(float totalMultip, int top_, TransactionManager tm_)
		{
			return GetByTotalMultip(totalMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTotalMultipAsync(float totalMultip, int top_, TransactionManager tm_)
		{
			return await GetByTotalMultipAsync(totalMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTotalMultip(float totalMultip, string sort_)
		{
			return GetByTotalMultip(totalMultip, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTotalMultipAsync(float totalMultip, string sort_)
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
		public List<Fra_bet_detailEO> GetByTotalMultip(float totalMultip, string sort_, TransactionManager tm_)
		{
			return GetByTotalMultip(totalMultip, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTotalMultipAsync(float totalMultip, string sort_, TransactionManager tm_)
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
		public List<Fra_bet_detailEO> GetByTotalMultip(float totalMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalMultip` = @TotalMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalMultip", totalMultip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTotalMultipAsync(float totalMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalMultip` = @TotalMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalMultip", totalMultip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByTotalMultip
		#region GetByTriggerSM
		
		/// <summary>
		/// 按 TriggerSM（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSM">触发Special mode</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTriggerSM(int triggerSM)
		{
			return GetByTriggerSM(triggerSM, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTriggerSMAsync(int triggerSM)
		{
			return await GetByTriggerSMAsync(triggerSM, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerSM（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSM">触发Special mode</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTriggerSM(int triggerSM, TransactionManager tm_)
		{
			return GetByTriggerSM(triggerSM, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTriggerSMAsync(int triggerSM, TransactionManager tm_)
		{
			return await GetByTriggerSMAsync(triggerSM, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerSM（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSM">触发Special mode</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTriggerSM(int triggerSM, int top_)
		{
			return GetByTriggerSM(triggerSM, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTriggerSMAsync(int triggerSM, int top_)
		{
			return await GetByTriggerSMAsync(triggerSM, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerSM（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSM">触发Special mode</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTriggerSM(int triggerSM, int top_, TransactionManager tm_)
		{
			return GetByTriggerSM(triggerSM, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTriggerSMAsync(int triggerSM, int top_, TransactionManager tm_)
		{
			return await GetByTriggerSMAsync(triggerSM, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerSM（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSM">触发Special mode</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTriggerSM(int triggerSM, string sort_)
		{
			return GetByTriggerSM(triggerSM, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTriggerSMAsync(int triggerSM, string sort_)
		{
			return await GetByTriggerSMAsync(triggerSM, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TriggerSM（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSM">触发Special mode</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTriggerSM(int triggerSM, string sort_, TransactionManager tm_)
		{
			return GetByTriggerSM(triggerSM, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTriggerSMAsync(int triggerSM, string sort_, TransactionManager tm_)
		{
			return await GetByTriggerSMAsync(triggerSM, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TriggerSM（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSM">触发Special mode</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTriggerSM(int triggerSM, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerSM` = @TriggerSM", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerSM", triggerSM, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTriggerSMAsync(int triggerSM, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerSM` = @TriggerSM", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerSM", triggerSM, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByTriggerSM
		#region GetByTriggerSE
		
		/// <summary>
		/// 按 TriggerSE（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSE">触发Special effects</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTriggerSE(int triggerSE)
		{
			return GetByTriggerSE(triggerSE, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTriggerSEAsync(int triggerSE)
		{
			return await GetByTriggerSEAsync(triggerSE, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerSE（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSE">触发Special effects</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTriggerSE(int triggerSE, TransactionManager tm_)
		{
			return GetByTriggerSE(triggerSE, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTriggerSEAsync(int triggerSE, TransactionManager tm_)
		{
			return await GetByTriggerSEAsync(triggerSE, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerSE（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSE">触发Special effects</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTriggerSE(int triggerSE, int top_)
		{
			return GetByTriggerSE(triggerSE, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTriggerSEAsync(int triggerSE, int top_)
		{
			return await GetByTriggerSEAsync(triggerSE, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerSE（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSE">触发Special effects</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTriggerSE(int triggerSE, int top_, TransactionManager tm_)
		{
			return GetByTriggerSE(triggerSE, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTriggerSEAsync(int triggerSE, int top_, TransactionManager tm_)
		{
			return await GetByTriggerSEAsync(triggerSE, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerSE（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSE">触发Special effects</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTriggerSE(int triggerSE, string sort_)
		{
			return GetByTriggerSE(triggerSE, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTriggerSEAsync(int triggerSE, string sort_)
		{
			return await GetByTriggerSEAsync(triggerSE, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TriggerSE（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSE">触发Special effects</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTriggerSE(int triggerSE, string sort_, TransactionManager tm_)
		{
			return GetByTriggerSE(triggerSE, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTriggerSEAsync(int triggerSE, string sort_, TransactionManager tm_)
		{
			return await GetByTriggerSEAsync(triggerSE, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TriggerSE（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSE">触发Special effects</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByTriggerSE(int triggerSE, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerSE` = @TriggerSE", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerSE", triggerSE, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByTriggerSEAsync(int triggerSE, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerSE` = @TriggerSE", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerSE", triggerSE, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByTriggerSE
		#region GetByRewardDetails
		
		/// <summary>
		/// 按 RewardDetails（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetails">中奖详情</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByRewardDetails(string rewardDetails)
		{
			return GetByRewardDetails(rewardDetails, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByRewardDetailsAsync(string rewardDetails)
		{
			return await GetByRewardDetailsAsync(rewardDetails, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardDetails（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetails">中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByRewardDetails(string rewardDetails, TransactionManager tm_)
		{
			return GetByRewardDetails(rewardDetails, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByRewardDetailsAsync(string rewardDetails, TransactionManager tm_)
		{
			return await GetByRewardDetailsAsync(rewardDetails, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardDetails（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetails">中奖详情</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByRewardDetails(string rewardDetails, int top_)
		{
			return GetByRewardDetails(rewardDetails, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByRewardDetailsAsync(string rewardDetails, int top_)
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
		public List<Fra_bet_detailEO> GetByRewardDetails(string rewardDetails, int top_, TransactionManager tm_)
		{
			return GetByRewardDetails(rewardDetails, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByRewardDetailsAsync(string rewardDetails, int top_, TransactionManager tm_)
		{
			return await GetByRewardDetailsAsync(rewardDetails, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardDetails（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetails">中奖详情</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByRewardDetails(string rewardDetails, string sort_)
		{
			return GetByRewardDetails(rewardDetails, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByRewardDetailsAsync(string rewardDetails, string sort_)
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
		public List<Fra_bet_detailEO> GetByRewardDetails(string rewardDetails, string sort_, TransactionManager tm_)
		{
			return GetByRewardDetails(rewardDetails, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByRewardDetailsAsync(string rewardDetails, string sort_, TransactionManager tm_)
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
		public List<Fra_bet_detailEO> GetByRewardDetails(string rewardDetails, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardDetails` = @RewardDetails", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardDetails", rewardDetails, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByRewardDetailsAsync(string rewardDetails, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardDetails` = @RewardDetails", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardDetails", rewardDetails, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByRewardDetails
		#region GetByBonusDetailList
		
		/// <summary>
		/// 按 BonusDetailList（字段） 查询
		/// </summary>
		/// /// <param name = "bonusDetailList">小游戏数据结构</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBonusDetailList(string bonusDetailList)
		{
			return GetByBonusDetailList(bonusDetailList, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBonusDetailListAsync(string bonusDetailList)
		{
			return await GetByBonusDetailListAsync(bonusDetailList, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusDetailList（字段） 查询
		/// </summary>
		/// /// <param name = "bonusDetailList">小游戏数据结构</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBonusDetailList(string bonusDetailList, TransactionManager tm_)
		{
			return GetByBonusDetailList(bonusDetailList, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBonusDetailListAsync(string bonusDetailList, TransactionManager tm_)
		{
			return await GetByBonusDetailListAsync(bonusDetailList, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusDetailList（字段） 查询
		/// </summary>
		/// /// <param name = "bonusDetailList">小游戏数据结构</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBonusDetailList(string bonusDetailList, int top_)
		{
			return GetByBonusDetailList(bonusDetailList, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBonusDetailListAsync(string bonusDetailList, int top_)
		{
			return await GetByBonusDetailListAsync(bonusDetailList, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusDetailList（字段） 查询
		/// </summary>
		/// /// <param name = "bonusDetailList">小游戏数据结构</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBonusDetailList(string bonusDetailList, int top_, TransactionManager tm_)
		{
			return GetByBonusDetailList(bonusDetailList, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBonusDetailListAsync(string bonusDetailList, int top_, TransactionManager tm_)
		{
			return await GetByBonusDetailListAsync(bonusDetailList, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusDetailList（字段） 查询
		/// </summary>
		/// /// <param name = "bonusDetailList">小游戏数据结构</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBonusDetailList(string bonusDetailList, string sort_)
		{
			return GetByBonusDetailList(bonusDetailList, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBonusDetailListAsync(string bonusDetailList, string sort_)
		{
			return await GetByBonusDetailListAsync(bonusDetailList, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BonusDetailList（字段） 查询
		/// </summary>
		/// /// <param name = "bonusDetailList">小游戏数据结构</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBonusDetailList(string bonusDetailList, string sort_, TransactionManager tm_)
		{
			return GetByBonusDetailList(bonusDetailList, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBonusDetailListAsync(string bonusDetailList, string sort_, TransactionManager tm_)
		{
			return await GetByBonusDetailListAsync(bonusDetailList, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BonusDetailList（字段） 查询
		/// </summary>
		/// /// <param name = "bonusDetailList">小游戏数据结构</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByBonusDetailList(string bonusDetailList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BonusDetailList` = @BonusDetailList", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BonusDetailList", bonusDetailList, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByBonusDetailListAsync(string bonusDetailList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BonusDetailList` = @BonusDetailList", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BonusDetailList", bonusDetailList, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByBonusDetailList
		#region GetBySlotEleArray
		
		/// <summary>
		/// 按 SlotEleArray（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleArray">中奖牌面</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetBySlotEleArray(string slotEleArray)
		{
			return GetBySlotEleArray(slotEleArray, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetBySlotEleArrayAsync(string slotEleArray)
		{
			return await GetBySlotEleArrayAsync(slotEleArray, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SlotEleArray（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleArray">中奖牌面</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetBySlotEleArray(string slotEleArray, TransactionManager tm_)
		{
			return GetBySlotEleArray(slotEleArray, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetBySlotEleArrayAsync(string slotEleArray, TransactionManager tm_)
		{
			return await GetBySlotEleArrayAsync(slotEleArray, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SlotEleArray（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleArray">中奖牌面</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetBySlotEleArray(string slotEleArray, int top_)
		{
			return GetBySlotEleArray(slotEleArray, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetBySlotEleArrayAsync(string slotEleArray, int top_)
		{
			return await GetBySlotEleArrayAsync(slotEleArray, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SlotEleArray（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleArray">中奖牌面</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetBySlotEleArray(string slotEleArray, int top_, TransactionManager tm_)
		{
			return GetBySlotEleArray(slotEleArray, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetBySlotEleArrayAsync(string slotEleArray, int top_, TransactionManager tm_)
		{
			return await GetBySlotEleArrayAsync(slotEleArray, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SlotEleArray（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleArray">中奖牌面</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetBySlotEleArray(string slotEleArray, string sort_)
		{
			return GetBySlotEleArray(slotEleArray, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetBySlotEleArrayAsync(string slotEleArray, string sort_)
		{
			return await GetBySlotEleArrayAsync(slotEleArray, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SlotEleArray（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleArray">中奖牌面</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetBySlotEleArray(string slotEleArray, string sort_, TransactionManager tm_)
		{
			return GetBySlotEleArray(slotEleArray, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetBySlotEleArrayAsync(string slotEleArray, string sort_, TransactionManager tm_)
		{
			return await GetBySlotEleArrayAsync(slotEleArray, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SlotEleArray（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleArray">中奖牌面</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetBySlotEleArray(string slotEleArray, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SlotEleArray` = @SlotEleArray", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SlotEleArray", slotEleArray, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetBySlotEleArrayAsync(string slotEleArray, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SlotEleArray` = @SlotEleArray", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SlotEleArray", slotEleArray, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetBySlotEleArray
		#region GetByUserFlag
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByUserFlag(int userFlag)
		{
			return GetByUserFlag(userFlag, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByUserFlagAsync(int userFlag)
		{
			return await GetByUserFlagAsync(userFlag, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByUserFlag(int userFlag, TransactionManager tm_)
		{
			return GetByUserFlag(userFlag, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByUserFlagAsync(int userFlag, TransactionManager tm_)
		{
			return await GetByUserFlagAsync(userFlag, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByUserFlag(int userFlag, int top_)
		{
			return GetByUserFlag(userFlag, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByUserFlagAsync(int userFlag, int top_)
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
		public List<Fra_bet_detailEO> GetByUserFlag(int userFlag, int top_, TransactionManager tm_)
		{
			return GetByUserFlag(userFlag, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByUserFlagAsync(int userFlag, int top_, TransactionManager tm_)
		{
			return await GetByUserFlagAsync(userFlag, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByUserFlag(int userFlag, string sort_)
		{
			return GetByUserFlag(userFlag, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByUserFlagAsync(int userFlag, string sort_)
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
		public List<Fra_bet_detailEO> GetByUserFlag(int userFlag, string sort_, TransactionManager tm_)
		{
			return GetByUserFlag(userFlag, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByUserFlagAsync(int userFlag, string sort_, TransactionManager tm_)
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
		public List<Fra_bet_detailEO> GetByUserFlag(int userFlag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserFlag` = @UserFlag", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserFlag", userFlag, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByUserFlagAsync(int userFlag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserFlag` = @UserFlag", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserFlag", userFlag, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByUserFlag
		#region GetByOrderStatus
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByOrderStatus(int orderStatus)
		{
			return GetByOrderStatus(orderStatus, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByOrderStatusAsync(int orderStatus)
		{
			return await GetByOrderStatusAsync(orderStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByOrderStatus(int orderStatus, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, TransactionManager tm_)
		{
			return await GetByOrderStatusAsync(orderStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByOrderStatus(int orderStatus, int top_)
		{
			return GetByOrderStatus(orderStatus, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_)
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
		public List<Fra_bet_detailEO> GetByOrderStatus(int orderStatus, int top_, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_, TransactionManager tm_)
		{
			return await GetByOrderStatusAsync(orderStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByOrderStatus(int orderStatus, string sort_)
		{
			return GetByOrderStatus(orderStatus, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, string sort_)
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
		public List<Fra_bet_detailEO> GetByOrderStatus(int orderStatus, string sort_, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, string sort_, TransactionManager tm_)
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
		public List<Fra_bet_detailEO> GetByOrderStatus(int orderStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderStatus` = @OrderStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderStatus` = @OrderStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByOrderStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Fra_bet_detailEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Fra_bet_detailEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Fra_bet_detailEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByMemo
		
		/// <summary>
		/// 按 Memo（字段） 查询
		/// </summary>
		/// /// <param name = "memo">备注</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByMemo(string memo)
		{
			return GetByMemo(memo, 0, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByMemoAsync(string memo)
		{
			return await GetByMemoAsync(memo, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Memo（字段） 查询
		/// </summary>
		/// /// <param name = "memo">备注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByMemo(string memo, TransactionManager tm_)
		{
			return GetByMemo(memo, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByMemoAsync(string memo, TransactionManager tm_)
		{
			return await GetByMemoAsync(memo, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Memo（字段） 查询
		/// </summary>
		/// /// <param name = "memo">备注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByMemo(string memo, int top_)
		{
			return GetByMemo(memo, top_, string.Empty, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByMemoAsync(string memo, int top_)
		{
			return await GetByMemoAsync(memo, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Memo（字段） 查询
		/// </summary>
		/// /// <param name = "memo">备注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByMemo(string memo, int top_, TransactionManager tm_)
		{
			return GetByMemo(memo, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByMemoAsync(string memo, int top_, TransactionManager tm_)
		{
			return await GetByMemoAsync(memo, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Memo（字段） 查询
		/// </summary>
		/// /// <param name = "memo">备注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByMemo(string memo, string sort_)
		{
			return GetByMemo(memo, 0, sort_, null);
		}
		public async Task<List<Fra_bet_detailEO>> GetByMemoAsync(string memo, string sort_)
		{
			return await GetByMemoAsync(memo, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Memo（字段） 查询
		/// </summary>
		/// /// <param name = "memo">备注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByMemo(string memo, string sort_, TransactionManager tm_)
		{
			return GetByMemo(memo, 0, sort_, tm_);
		}
		public async Task<List<Fra_bet_detailEO>> GetByMemoAsync(string memo, string sort_, TransactionManager tm_)
		{
			return await GetByMemoAsync(memo, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Memo（字段） 查询
		/// </summary>
		/// /// <param name = "memo">备注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_bet_detailEO> GetByMemo(string memo, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Memo` = @Memo", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Memo", memo, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		public async Task<List<Fra_bet_detailEO>> GetByMemoAsync(string memo, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Memo` = @Memo", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Memo", memo, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_bet_detailEO.MapDataReader);
		}
		#endregion // GetByMemo
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
