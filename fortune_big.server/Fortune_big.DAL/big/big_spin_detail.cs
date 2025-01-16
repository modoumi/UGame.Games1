/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2024-01-30 14: 40:29
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

namespace Fortune_big.DAL
{
	#region EO
	/// <summary>
	/// 下注表
	/// 【表 big_spin_detail 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Big_spin_detailEO : IRowMapper<Big_spin_detailEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Big_spin_detailEO()
		{
			this.ChipsID = 0;
			this.BalanceAmountBefore = 0;
			this.BalanceAmountAfter = 0;
			this.BetAmount = 0;
			this.WinAmount = 0;
			this.BetBonus = 0;
			this.WinBonus = 0;
			this.TotalMultip = 0f;
			this.TriggerFreeSpin = 0;
			this.TriggerRespin = 0;
			this.TriggerSE = 0;
			this.HistoryMultip = "0";
			this.UserFlag = -1;
			this.SMMultip = 0f;
			this.SMAmount = 0;
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
		/// 下注后金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long BalanceAmountBefore { get; set; }
		/// <summary>
		/// 下注后金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long BalanceAmountAfter { get; set; }
		/// <summary>
		/// 实际下注金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long BetAmount { get; set; }
		/// <summary>
		/// 返奖金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 9)]
		public long WinAmount { get; set; }
		/// <summary>
		/// 下注bonus
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 10)]
		public long BetBonus { get; set; }
		/// <summary>
		/// 返奖bonus
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 11)]
		public long WinBonus { get; set; }
		/// <summary>
		/// 是否中奖(奖池是否够)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int IsWin { get; set; }
		/// <summary>
		/// 中奖总倍数
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 13)]
		public float TotalMultip { get; set; }
		/// <summary>
		/// 触发freespin次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 14)]
		public int TriggerFreeSpin { get; set; }
		/// <summary>
		/// 触发respin次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 15)]
		public int TriggerRespin { get; set; }
		/// <summary>
		/// 触发Special effects
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 16)]
		public int TriggerSE { get; set; }
		/// <summary>
		/// 25条线对应的倍率
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 17)]
		public string HistoryMultip { get; set; }
		/// <summary>
		/// 中奖详情
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 18)]
		public string RewardDetailList { get; set; }
		/// <summary>
		/// 返回给客户端数据结构
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 19)]
		public string SlotEleList { get; set; }
		/// <summary>
		/// respin中奖详情
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 20)]
		public string RespinList { get; set; }
		/// <summary>
		/// freespin中奖详情
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 21)]
		public string FreeSpinList { get; set; }
		/// <summary>
		/// 用户AB面
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 22)]
		public int UserFlag { get; set; }
		/// <summary>
		/// 特殊玩法中奖总倍数
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 23)]
		public float SMMultip { get; set; }
		/// <summary>
		/// 特殊返奖金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 24)]
		public long SMAmount { get; set; }
		/// <summary>
		/// 状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 25)]
		public int OrderStatus { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 26)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Big_spin_detailEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Big_spin_detailEO MapDataReader(IDataReader reader)
		{
		    Big_spin_detailEO ret = new Big_spin_detailEO();
			ret.BetID = reader.ToInt64("BetID");
			ret.OriginalBetID = ret.BetID;
			ret.ChipsID = reader.ToInt32("ChipsID");
			ret.AppID = reader.ToString("AppID");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.UserID = reader.ToString("UserID");
			ret.BalanceAmountBefore = reader.ToInt64("BalanceAmountBefore");
			ret.BalanceAmountAfter = reader.ToInt64("BalanceAmountAfter");
			ret.BetAmount = reader.ToInt64("BetAmount");
			ret.WinAmount = reader.ToInt64("WinAmount");
			ret.BetBonus = reader.ToInt64("BetBonus");
			ret.WinBonus = reader.ToInt64("WinBonus");
			ret.IsWin = reader.ToInt32("IsWin");
			ret.TotalMultip = reader.ToSingle("TotalMultip");
			ret.TriggerFreeSpin = reader.ToInt32("TriggerFreeSpin");
			ret.TriggerRespin = reader.ToInt32("TriggerRespin");
			ret.TriggerSE = reader.ToInt32("TriggerSE");
			ret.HistoryMultip = reader.ToString("HistoryMultip");
			ret.RewardDetailList = reader.ToString("RewardDetailList");
			ret.SlotEleList = reader.ToString("SlotEleList");
			ret.RespinList = reader.ToString("RespinList");
			ret.FreeSpinList = reader.ToString("FreeSpinList");
			ret.UserFlag = reader.ToInt32("UserFlag");
			ret.SMMultip = reader.ToSingle("SMMultip");
			ret.SMAmount = reader.ToInt64("SMAmount");
			ret.OrderStatus = reader.ToInt32("OrderStatus");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 下注表
	/// 【表 big_spin_detail 的操作类】
	/// </summary>
	[Obsolete]
	public class Big_spin_detailMO : MySqlTableMO<Big_spin_detailEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`big_spin_detail`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Big_spin_detailMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Big_spin_detailMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Big_spin_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Big_spin_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Big_spin_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Big_spin_detailEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`BetID`, `ChipsID`, `AppID`, `OperatorID`, `UserID`, `BalanceAmountBefore`, `BalanceAmountAfter`, `BetAmount`, `WinAmount`, `BetBonus`, `WinBonus`, `IsWin`, `TotalMultip`, `TriggerFreeSpin`, `TriggerRespin`, `TriggerSE`, `HistoryMultip`, `RewardDetailList`, `SlotEleList`, `RespinList`, `FreeSpinList`, `UserFlag`, `SMMultip`, `SMAmount`, `OrderStatus`, `RecDate`) VALUE (@BetID, @ChipsID, @AppID, @OperatorID, @UserID, @BalanceAmountBefore, @BalanceAmountAfter, @BetAmount, @WinAmount, @BetBonus, @WinBonus, @IsWin, @TotalMultip, @TriggerFreeSpin, @TriggerRespin, @TriggerSE, @HistoryMultip, @RewardDetailList, @SlotEleList, @RespinList, @FreeSpinList, @UserFlag, @SMMultip, @SMAmount, @OrderStatus, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", item.BetID, MySqlDbType.Int64),
				Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BalanceAmountBefore", item.BalanceAmountBefore, MySqlDbType.Int64),
				Database.CreateInParameter("@BalanceAmountAfter", item.BalanceAmountAfter, MySqlDbType.Int64),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetBonus", item.BetBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@WinBonus", item.WinBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@IsWin", item.IsWin, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalMultip", item.TotalMultip, MySqlDbType.Float),
				Database.CreateInParameter("@TriggerFreeSpin", item.TriggerFreeSpin, MySqlDbType.Int32),
				Database.CreateInParameter("@TriggerRespin", item.TriggerRespin, MySqlDbType.Int32),
				Database.CreateInParameter("@TriggerSE", item.TriggerSE, MySqlDbType.Int32),
				Database.CreateInParameter("@HistoryMultip", item.HistoryMultip, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardDetailList", item.RewardDetailList, MySqlDbType.Text),
				Database.CreateInParameter("@SlotEleList", item.SlotEleList, MySqlDbType.VarChar),
				Database.CreateInParameter("@RespinList", item.RespinList, MySqlDbType.Text),
				Database.CreateInParameter("@FreeSpinList", item.FreeSpinList, MySqlDbType.Text),
				Database.CreateInParameter("@UserFlag", item.UserFlag, MySqlDbType.Int32),
				Database.CreateInParameter("@SMMultip", item.SMMultip, MySqlDbType.Float),
				Database.CreateInParameter("@SMAmount", item.SMAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderStatus", item.OrderStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Big_spin_detailEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Big_spin_detailEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Big_spin_detailEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`BetID`, `ChipsID`, `AppID`, `OperatorID`, `UserID`, `BalanceAmountBefore`, `BalanceAmountAfter`, `BetAmount`, `WinAmount`, `BetBonus`, `WinBonus`, `IsWin`, `TotalMultip`, `TriggerFreeSpin`, `TriggerRespin`, `TriggerSE`, `HistoryMultip`, `RewardDetailList`, `SlotEleList`, `RespinList`, `FreeSpinList`, `UserFlag`, `SMMultip`, `SMAmount`, `OrderStatus`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.BetID},{item.ChipsID},'{item.AppID}','{item.OperatorID}','{item.UserID}',{item.BalanceAmountBefore},{item.BalanceAmountAfter},{item.BetAmount},{item.WinAmount},{item.BetBonus},{item.WinBonus},{item.IsWin},{item.TotalMultip},{item.TriggerFreeSpin},{item.TriggerRespin},{item.TriggerSE},'{item.HistoryMultip}','{item.RewardDetailList}','{item.SlotEleList}','{item.RespinList}','{item.FreeSpinList}',{item.UserFlag},{item.SMMultip},{item.SMAmount},{item.OrderStatus},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		public int Remove(Big_spin_detailEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.BetID, tm_);
		}
		public async Task<int> RemoveAsync(Big_spin_detailEO item, TransactionManager tm_ = null)
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
		#region RemoveByBalanceAmountBefore
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后金额</param>
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
		/// /// <param name = "balanceAmountAfter">下注后金额</param>
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
		#region RemoveByBetBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betBonus">下注bonus</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetBonus(long betBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBetBonusData(betBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetBonusAsync(long betBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByBetBonusData(betBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetBonusData(long betBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetBonus` = @BetBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetBonus
		#region RemoveByWinBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winBonus">返奖bonus</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWinBonus(long winBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByWinBonusData(winBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWinBonusAsync(long winBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByWinBonusData(winBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWinBonusData(long winBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WinBonus` = @WinBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByWinBonus
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
		#region RemoveByTriggerFreeSpin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "triggerFreeSpin">触发freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTriggerFreeSpin(int triggerFreeSpin, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerFreeSpinData(triggerFreeSpin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTriggerFreeSpinAsync(int triggerFreeSpin, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerFreeSpinData(triggerFreeSpin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTriggerFreeSpinData(int triggerFreeSpin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TriggerFreeSpin` = @TriggerFreeSpin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerFreeSpin", triggerFreeSpin, MySqlDbType.Int32));
		}
		#endregion // RemoveByTriggerFreeSpin
		#region RemoveByTriggerRespin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "triggerRespin">触发respin次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTriggerRespin(int triggerRespin, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerRespinData(triggerRespin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTriggerRespinAsync(int triggerRespin, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerRespinData(triggerRespin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTriggerRespinData(int triggerRespin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TriggerRespin` = @TriggerRespin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerRespin", triggerRespin, MySqlDbType.Int32));
		}
		#endregion // RemoveByTriggerRespin
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
		#region RemoveByRewardDetailList
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardDetailList">中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRewardDetailList(string rewardDetailList, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardDetailListData(rewardDetailList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRewardDetailListAsync(string rewardDetailList, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardDetailListData(rewardDetailList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRewardDetailListData(string rewardDetailList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RewardDetailList` = @RewardDetailList";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardDetailList", rewardDetailList, MySqlDbType.Text));
		}
		#endregion // RemoveByRewardDetailList
		#region RemoveBySlotEleList
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "slotEleList">返回给客户端数据结构</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySlotEleList(string slotEleList, TransactionManager tm_ = null)
		{
			RepairRemoveBySlotEleListData(slotEleList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySlotEleListAsync(string slotEleList, TransactionManager tm_ = null)
		{
			RepairRemoveBySlotEleListData(slotEleList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySlotEleListData(string slotEleList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SlotEleList` = @SlotEleList";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SlotEleList", slotEleList, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySlotEleList
		#region RemoveByRespinList
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "respinList">respin中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRespinList(string respinList, TransactionManager tm_ = null)
		{
			RepairRemoveByRespinListData(respinList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRespinListAsync(string respinList, TransactionManager tm_ = null)
		{
			RepairRemoveByRespinListData(respinList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRespinListData(string respinList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RespinList` = @RespinList";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RespinList", respinList, MySqlDbType.Text));
		}
		#endregion // RemoveByRespinList
		#region RemoveByFreeSpinList
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "freeSpinList">freespin中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFreeSpinList(string freeSpinList, TransactionManager tm_ = null)
		{
			RepairRemoveByFreeSpinListData(freeSpinList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFreeSpinListAsync(string freeSpinList, TransactionManager tm_ = null)
		{
			RepairRemoveByFreeSpinListData(freeSpinList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFreeSpinListData(string freeSpinList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FreeSpinList` = @FreeSpinList";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreeSpinList", freeSpinList, MySqlDbType.Text));
		}
		#endregion // RemoveByFreeSpinList
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
		#region RemoveBySMMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sMMultip">特殊玩法中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySMMultip(float sMMultip, TransactionManager tm_ = null)
		{
			RepairRemoveBySMMultipData(sMMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySMMultipAsync(float sMMultip, TransactionManager tm_ = null)
		{
			RepairRemoveBySMMultipData(sMMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySMMultipData(float sMMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SMMultip` = @SMMultip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SMMultip", sMMultip, MySqlDbType.Float));
		}
		#endregion // RemoveBySMMultip
		#region RemoveBySMAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sMAmount">特殊返奖金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySMAmount(long sMAmount, TransactionManager tm_ = null)
		{
			RepairRemoveBySMAmountData(sMAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySMAmountAsync(long sMAmount, TransactionManager tm_ = null)
		{
			RepairRemoveBySMAmountData(sMAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySMAmountData(long sMAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SMAmount` = @SMAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SMAmount", sMAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveBySMAmount
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
		public int Put(Big_spin_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Big_spin_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Big_spin_detailEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetID` = @BetID, `ChipsID` = @ChipsID, `AppID` = @AppID, `OperatorID` = @OperatorID, `UserID` = @UserID, `BalanceAmountBefore` = @BalanceAmountBefore, `BalanceAmountAfter` = @BalanceAmountAfter, `BetAmount` = @BetAmount, `WinAmount` = @WinAmount, `BetBonus` = @BetBonus, `WinBonus` = @WinBonus, `IsWin` = @IsWin, `TotalMultip` = @TotalMultip, `TriggerFreeSpin` = @TriggerFreeSpin, `TriggerRespin` = @TriggerRespin, `TriggerSE` = @TriggerSE, `HistoryMultip` = @HistoryMultip, `RewardDetailList` = @RewardDetailList, `SlotEleList` = @SlotEleList, `RespinList` = @RespinList, `FreeSpinList` = @FreeSpinList, `UserFlag` = @UserFlag, `SMMultip` = @SMMultip, `SMAmount` = @SMAmount, `OrderStatus` = @OrderStatus WHERE `BetID` = @BetID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", item.BetID, MySqlDbType.Int64),
				Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BalanceAmountBefore", item.BalanceAmountBefore, MySqlDbType.Int64),
				Database.CreateInParameter("@BalanceAmountAfter", item.BalanceAmountAfter, MySqlDbType.Int64),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetBonus", item.BetBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@WinBonus", item.WinBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@IsWin", item.IsWin, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalMultip", item.TotalMultip, MySqlDbType.Float),
				Database.CreateInParameter("@TriggerFreeSpin", item.TriggerFreeSpin, MySqlDbType.Int32),
				Database.CreateInParameter("@TriggerRespin", item.TriggerRespin, MySqlDbType.Int32),
				Database.CreateInParameter("@TriggerSE", item.TriggerSE, MySqlDbType.Int32),
				Database.CreateInParameter("@HistoryMultip", item.HistoryMultip, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardDetailList", item.RewardDetailList, MySqlDbType.Text),
				Database.CreateInParameter("@SlotEleList", item.SlotEleList, MySqlDbType.VarChar),
				Database.CreateInParameter("@RespinList", item.RespinList, MySqlDbType.Text),
				Database.CreateInParameter("@FreeSpinList", item.FreeSpinList, MySqlDbType.Text),
				Database.CreateInParameter("@UserFlag", item.UserFlag, MySqlDbType.Int32),
				Database.CreateInParameter("@SMMultip", item.SMMultip, MySqlDbType.Float),
				Database.CreateInParameter("@SMAmount", item.SMAmount, MySqlDbType.Int64),
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
		public int Put(IEnumerable<Big_spin_detailEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Big_spin_detailEO> items, TransactionManager tm_ = null)
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
		#region PutBalanceAmountBefore
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "balanceAmountBefore">下注后金额</param>
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
		/// /// <param name = "balanceAmountBefore">下注后金额</param>
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
		/// /// <param name = "balanceAmountAfter">下注后金额</param>
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
		/// /// <param name = "balanceAmountAfter">下注后金额</param>
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
		#region PutBetBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "betBonus">下注bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBonusByPK(long betID, long betBonus, TransactionManager tm_ = null)
		{
			RepairPutBetBonusByPKData(betID, betBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetBonusByPKAsync(long betID, long betBonus, TransactionManager tm_ = null)
		{
			RepairPutBetBonusByPKData(betID, betBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetBonusByPKData(long betID, long betBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetBonus` = @BetBonus  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betBonus">下注bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBonus(long betBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetBonus` = @BetBonus";
			var parameter_ = Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetBonusAsync(long betBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetBonus` = @BetBonus";
			var parameter_ = Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetBonus
		#region PutWinBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "winBonus">返奖bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinBonusByPK(long betID, long winBonus, TransactionManager tm_ = null)
		{
			RepairPutWinBonusByPKData(betID, winBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinBonusByPKAsync(long betID, long winBonus, TransactionManager tm_ = null)
		{
			RepairPutWinBonusByPKData(betID, winBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinBonusByPKData(long betID, long winBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinBonus` = @WinBonus  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winBonus">返奖bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinBonus(long winBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinBonus` = @WinBonus";
			var parameter_ = Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWinBonusAsync(long winBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinBonus` = @WinBonus";
			var parameter_ = Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWinBonus
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
		#region PutTriggerFreeSpin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "triggerFreeSpin">触发freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerFreeSpinByPK(long betID, int triggerFreeSpin, TransactionManager tm_ = null)
		{
			RepairPutTriggerFreeSpinByPKData(betID, triggerFreeSpin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTriggerFreeSpinByPKAsync(long betID, int triggerFreeSpin, TransactionManager tm_ = null)
		{
			RepairPutTriggerFreeSpinByPKData(betID, triggerFreeSpin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTriggerFreeSpinByPKData(long betID, int triggerFreeSpin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TriggerFreeSpin` = @TriggerFreeSpin  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TriggerFreeSpin", triggerFreeSpin, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "triggerFreeSpin">触发freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerFreeSpin(int triggerFreeSpin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerFreeSpin` = @TriggerFreeSpin";
			var parameter_ = Database.CreateInParameter("@TriggerFreeSpin", triggerFreeSpin, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTriggerFreeSpinAsync(int triggerFreeSpin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerFreeSpin` = @TriggerFreeSpin";
			var parameter_ = Database.CreateInParameter("@TriggerFreeSpin", triggerFreeSpin, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTriggerFreeSpin
		#region PutTriggerRespin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "triggerRespin">触发respin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerRespinByPK(long betID, int triggerRespin, TransactionManager tm_ = null)
		{
			RepairPutTriggerRespinByPKData(betID, triggerRespin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTriggerRespinByPKAsync(long betID, int triggerRespin, TransactionManager tm_ = null)
		{
			RepairPutTriggerRespinByPKData(betID, triggerRespin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTriggerRespinByPKData(long betID, int triggerRespin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TriggerRespin` = @TriggerRespin  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TriggerRespin", triggerRespin, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "triggerRespin">触发respin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerRespin(int triggerRespin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerRespin` = @TriggerRespin";
			var parameter_ = Database.CreateInParameter("@TriggerRespin", triggerRespin, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTriggerRespinAsync(int triggerRespin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerRespin` = @TriggerRespin";
			var parameter_ = Database.CreateInParameter("@TriggerRespin", triggerRespin, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTriggerRespin
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
		#region PutRewardDetailList
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "rewardDetailList">中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardDetailListByPK(long betID, string rewardDetailList, TransactionManager tm_ = null)
		{
			RepairPutRewardDetailListByPKData(betID, rewardDetailList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardDetailListByPKAsync(long betID, string rewardDetailList, TransactionManager tm_ = null)
		{
			RepairPutRewardDetailListByPKData(betID, rewardDetailList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardDetailListByPKData(long betID, string rewardDetailList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardDetailList` = @RewardDetailList  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardDetailList", rewardDetailList, MySqlDbType.Text),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rewardDetailList">中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardDetailList(string rewardDetailList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardDetailList` = @RewardDetailList";
			var parameter_ = Database.CreateInParameter("@RewardDetailList", rewardDetailList, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRewardDetailListAsync(string rewardDetailList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardDetailList` = @RewardDetailList";
			var parameter_ = Database.CreateInParameter("@RewardDetailList", rewardDetailList, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRewardDetailList
		#region PutSlotEleList
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "slotEleList">返回给客户端数据结构</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSlotEleListByPK(long betID, string slotEleList, TransactionManager tm_ = null)
		{
			RepairPutSlotEleListByPKData(betID, slotEleList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSlotEleListByPKAsync(long betID, string slotEleList, TransactionManager tm_ = null)
		{
			RepairPutSlotEleListByPKData(betID, slotEleList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSlotEleListByPKData(long betID, string slotEleList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SlotEleList` = @SlotEleList  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SlotEleList", slotEleList, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "slotEleList">返回给客户端数据结构</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSlotEleList(string slotEleList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SlotEleList` = @SlotEleList";
			var parameter_ = Database.CreateInParameter("@SlotEleList", slotEleList, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSlotEleListAsync(string slotEleList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SlotEleList` = @SlotEleList";
			var parameter_ = Database.CreateInParameter("@SlotEleList", slotEleList, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSlotEleList
		#region PutRespinList
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "respinList">respin中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRespinListByPK(long betID, string respinList, TransactionManager tm_ = null)
		{
			RepairPutRespinListByPKData(betID, respinList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRespinListByPKAsync(long betID, string respinList, TransactionManager tm_ = null)
		{
			RepairPutRespinListByPKData(betID, respinList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRespinListByPKData(long betID, string respinList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RespinList` = @RespinList  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RespinList", respinList, MySqlDbType.Text),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "respinList">respin中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRespinList(string respinList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RespinList` = @RespinList";
			var parameter_ = Database.CreateInParameter("@RespinList", respinList, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRespinListAsync(string respinList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RespinList` = @RespinList";
			var parameter_ = Database.CreateInParameter("@RespinList", respinList, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRespinList
		#region PutFreeSpinList
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "freeSpinList">freespin中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreeSpinListByPK(long betID, string freeSpinList, TransactionManager tm_ = null)
		{
			RepairPutFreeSpinListByPKData(betID, freeSpinList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFreeSpinListByPKAsync(long betID, string freeSpinList, TransactionManager tm_ = null)
		{
			RepairPutFreeSpinListByPKData(betID, freeSpinList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFreeSpinListByPKData(long betID, string freeSpinList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FreeSpinList` = @FreeSpinList  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FreeSpinList", freeSpinList, MySqlDbType.Text),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "freeSpinList">freespin中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreeSpinList(string freeSpinList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FreeSpinList` = @FreeSpinList";
			var parameter_ = Database.CreateInParameter("@FreeSpinList", freeSpinList, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFreeSpinListAsync(string freeSpinList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FreeSpinList` = @FreeSpinList";
			var parameter_ = Database.CreateInParameter("@FreeSpinList", freeSpinList, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFreeSpinList
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
		#region PutSMMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "sMMultip">特殊玩法中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSMMultipByPK(long betID, float sMMultip, TransactionManager tm_ = null)
		{
			RepairPutSMMultipByPKData(betID, sMMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSMMultipByPKAsync(long betID, float sMMultip, TransactionManager tm_ = null)
		{
			RepairPutSMMultipByPKData(betID, sMMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSMMultipByPKData(long betID, float sMMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SMMultip` = @SMMultip  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SMMultip", sMMultip, MySqlDbType.Float),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sMMultip">特殊玩法中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSMMultip(float sMMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SMMultip` = @SMMultip";
			var parameter_ = Database.CreateInParameter("@SMMultip", sMMultip, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSMMultipAsync(float sMMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SMMultip` = @SMMultip";
			var parameter_ = Database.CreateInParameter("@SMMultip", sMMultip, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSMMultip
		#region PutSMAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "sMAmount">特殊返奖金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSMAmountByPK(long betID, long sMAmount, TransactionManager tm_ = null)
		{
			RepairPutSMAmountByPKData(betID, sMAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSMAmountByPKAsync(long betID, long sMAmount, TransactionManager tm_ = null)
		{
			RepairPutSMAmountByPKData(betID, sMAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSMAmountByPKData(long betID, long sMAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SMAmount` = @SMAmount  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SMAmount", sMAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sMAmount">特殊返奖金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSMAmount(long sMAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SMAmount` = @SMAmount";
			var parameter_ = Database.CreateInParameter("@SMAmount", sMAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSMAmountAsync(long sMAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SMAmount` = @SMAmount";
			var parameter_ = Database.CreateInParameter("@SMAmount", sMAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSMAmount
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Big_spin_detailEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Big_spin_detailEO item, TransactionManager tm = null)
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
		public Big_spin_detailEO GetByPK(long betID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(betID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<Big_spin_detailEO> GetByPKAsync(long betID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(betID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
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
		/// 按主键查询 BetBonus（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetBonusByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)GetScalar("`BetBonus`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<long> GetBetBonusByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`BetBonus`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinBonus（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinBonusByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)GetScalar("`WinBonus`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<long> GetWinBonusByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`WinBonus`", "`BetID` = @BetID", paras_, tm_);
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
		/// 按主键查询 TriggerFreeSpin（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTriggerFreeSpinByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`TriggerFreeSpin`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetTriggerFreeSpinByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`TriggerFreeSpin`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TriggerRespin（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTriggerRespinByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`TriggerRespin`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetTriggerRespinByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`TriggerRespin`", "`BetID` = @BetID", paras_, tm_);
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
		/// 按主键查询 RewardDetailList（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetRewardDetailListByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`RewardDetailList`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetRewardDetailListByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`RewardDetailList`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SlotEleList（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSlotEleListByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`SlotEleList`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetSlotEleListByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`SlotEleList`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RespinList（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetRespinListByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`RespinList`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetRespinListByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`RespinList`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FreeSpinList（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFreeSpinListByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`FreeSpinList`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetFreeSpinListByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`FreeSpinList`", "`BetID` = @BetID", paras_, tm_);
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
		/// 按主键查询 SMMultip（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetSMMultipByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (float)GetScalar("`SMMultip`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<float> GetSMMultipByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (float)await GetScalarAsync("`SMMultip`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SMAmount（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetSMAmountByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)GetScalar("`SMAmount`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<long> GetSMAmountByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`SMAmount`", "`BetID` = @BetID", paras_, tm_);
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
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByChipsID
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByChipsID(int chipsID)
		{
			return GetByChipsID(chipsID, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByChipsIDAsync(int chipsID)
		{
			return await GetByChipsIDAsync(chipsID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByChipsID(int chipsID, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByChipsIDAsync(int chipsID, TransactionManager tm_)
		{
			return await GetByChipsIDAsync(chipsID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByChipsID(int chipsID, int top_)
		{
			return GetByChipsID(chipsID, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByChipsIDAsync(int chipsID, int top_)
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
		public List<Big_spin_detailEO> GetByChipsID(int chipsID, int top_, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByChipsIDAsync(int chipsID, int top_, TransactionManager tm_)
		{
			return await GetByChipsIDAsync(chipsID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByChipsID(int chipsID, string sort_)
		{
			return GetByChipsID(chipsID, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByChipsIDAsync(int chipsID, string sort_)
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
		public List<Big_spin_detailEO> GetByChipsID(int chipsID, string sort_, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByChipsIDAsync(int chipsID, string sort_, TransactionManager tm_)
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
		public List<Big_spin_detailEO> GetByChipsID(int chipsID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByChipsIDAsync(int chipsID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByChipsID
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByAppIDAsync(string appID, int top_)
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
		public List<Big_spin_detailEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByAppIDAsync(string appID, string sort_)
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
		public List<Big_spin_detailEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
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
		public List<Big_spin_detailEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Big_spin_detailEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Big_spin_detailEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Big_spin_detailEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByUserIDAsync(string userID, int top_)
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
		public List<Big_spin_detailEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByUserIDAsync(string userID, string sort_)
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
		public List<Big_spin_detailEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
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
		public List<Big_spin_detailEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByBalanceAmountBefore
		
		/// <summary>
		/// 按 BalanceAmountBefore（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后金额</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBalanceAmountBefore(long balanceAmountBefore)
		{
			return GetByBalanceAmountBefore(balanceAmountBefore, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByBalanceAmountBeforeAsync(long balanceAmountBefore)
		{
			return await GetByBalanceAmountBeforeAsync(balanceAmountBefore, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BalanceAmountBefore（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBalanceAmountBefore(long balanceAmountBefore, TransactionManager tm_)
		{
			return GetByBalanceAmountBefore(balanceAmountBefore, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByBalanceAmountBeforeAsync(long balanceAmountBefore, TransactionManager tm_)
		{
			return await GetByBalanceAmountBeforeAsync(balanceAmountBefore, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BalanceAmountBefore（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBalanceAmountBefore(long balanceAmountBefore, int top_)
		{
			return GetByBalanceAmountBefore(balanceAmountBefore, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByBalanceAmountBeforeAsync(long balanceAmountBefore, int top_)
		{
			return await GetByBalanceAmountBeforeAsync(balanceAmountBefore, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BalanceAmountBefore（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBalanceAmountBefore(long balanceAmountBefore, int top_, TransactionManager tm_)
		{
			return GetByBalanceAmountBefore(balanceAmountBefore, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByBalanceAmountBeforeAsync(long balanceAmountBefore, int top_, TransactionManager tm_)
		{
			return await GetByBalanceAmountBeforeAsync(balanceAmountBefore, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BalanceAmountBefore（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBalanceAmountBefore(long balanceAmountBefore, string sort_)
		{
			return GetByBalanceAmountBefore(balanceAmountBefore, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByBalanceAmountBeforeAsync(long balanceAmountBefore, string sort_)
		{
			return await GetByBalanceAmountBeforeAsync(balanceAmountBefore, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BalanceAmountBefore（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBalanceAmountBefore(long balanceAmountBefore, string sort_, TransactionManager tm_)
		{
			return GetByBalanceAmountBefore(balanceAmountBefore, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByBalanceAmountBeforeAsync(long balanceAmountBefore, string sort_, TransactionManager tm_)
		{
			return await GetByBalanceAmountBeforeAsync(balanceAmountBefore, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BalanceAmountBefore（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountBefore">下注后金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBalanceAmountBefore(long balanceAmountBefore, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BalanceAmountBefore` = @BalanceAmountBefore", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BalanceAmountBefore", balanceAmountBefore, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByBalanceAmountBeforeAsync(long balanceAmountBefore, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BalanceAmountBefore` = @BalanceAmountBefore", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BalanceAmountBefore", balanceAmountBefore, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByBalanceAmountBefore
		#region GetByBalanceAmountAfter
		
		/// <summary>
		/// 按 BalanceAmountAfter（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountAfter">下注后金额</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBalanceAmountAfter(long balanceAmountAfter)
		{
			return GetByBalanceAmountAfter(balanceAmountAfter, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByBalanceAmountAfterAsync(long balanceAmountAfter)
		{
			return await GetByBalanceAmountAfterAsync(balanceAmountAfter, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BalanceAmountAfter（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountAfter">下注后金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBalanceAmountAfter(long balanceAmountAfter, TransactionManager tm_)
		{
			return GetByBalanceAmountAfter(balanceAmountAfter, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByBalanceAmountAfterAsync(long balanceAmountAfter, TransactionManager tm_)
		{
			return await GetByBalanceAmountAfterAsync(balanceAmountAfter, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BalanceAmountAfter（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountAfter">下注后金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBalanceAmountAfter(long balanceAmountAfter, int top_)
		{
			return GetByBalanceAmountAfter(balanceAmountAfter, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByBalanceAmountAfterAsync(long balanceAmountAfter, int top_)
		{
			return await GetByBalanceAmountAfterAsync(balanceAmountAfter, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BalanceAmountAfter（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountAfter">下注后金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBalanceAmountAfter(long balanceAmountAfter, int top_, TransactionManager tm_)
		{
			return GetByBalanceAmountAfter(balanceAmountAfter, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByBalanceAmountAfterAsync(long balanceAmountAfter, int top_, TransactionManager tm_)
		{
			return await GetByBalanceAmountAfterAsync(balanceAmountAfter, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BalanceAmountAfter（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountAfter">下注后金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBalanceAmountAfter(long balanceAmountAfter, string sort_)
		{
			return GetByBalanceAmountAfter(balanceAmountAfter, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByBalanceAmountAfterAsync(long balanceAmountAfter, string sort_)
		{
			return await GetByBalanceAmountAfterAsync(balanceAmountAfter, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BalanceAmountAfter（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountAfter">下注后金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBalanceAmountAfter(long balanceAmountAfter, string sort_, TransactionManager tm_)
		{
			return GetByBalanceAmountAfter(balanceAmountAfter, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByBalanceAmountAfterAsync(long balanceAmountAfter, string sort_, TransactionManager tm_)
		{
			return await GetByBalanceAmountAfterAsync(balanceAmountAfter, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BalanceAmountAfter（字段） 查询
		/// </summary>
		/// /// <param name = "balanceAmountAfter">下注后金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBalanceAmountAfter(long balanceAmountAfter, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BalanceAmountAfter` = @BalanceAmountAfter", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BalanceAmountAfter", balanceAmountAfter, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByBalanceAmountAfterAsync(long balanceAmountAfter, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BalanceAmountAfter` = @BalanceAmountAfter", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BalanceAmountAfter", balanceAmountAfter, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByBalanceAmountAfter
		#region GetByBetAmount
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">实际下注金额</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBetAmount(long betAmount)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByBetAmountAsync(long betAmount)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">实际下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBetAmount(long betAmount, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByBetAmountAsync(long betAmount, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">实际下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBetAmount(long betAmount, int top_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByBetAmountAsync(long betAmount, int top_)
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
		public List<Big_spin_detailEO> GetByBetAmount(long betAmount, int top_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByBetAmountAsync(long betAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">实际下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBetAmount(long betAmount, string sort_)
		{
			return GetByBetAmount(betAmount, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByBetAmountAsync(long betAmount, string sort_)
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
		public List<Big_spin_detailEO> GetByBetAmount(long betAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByBetAmountAsync(long betAmount, string sort_, TransactionManager tm_)
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
		public List<Big_spin_detailEO> GetByBetAmount(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByBetAmountAsync(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByBetAmount
		#region GetByWinAmount
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖金额</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByWinAmount(long winAmount)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByWinAmountAsync(long winAmount)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByWinAmount(long winAmount, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByWinAmountAsync(long winAmount, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByWinAmount(long winAmount, int top_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByWinAmountAsync(long winAmount, int top_)
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
		public List<Big_spin_detailEO> GetByWinAmount(long winAmount, int top_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByWinAmountAsync(long winAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">返奖金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByWinAmount(long winAmount, string sort_)
		{
			return GetByWinAmount(winAmount, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByWinAmountAsync(long winAmount, string sort_)
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
		public List<Big_spin_detailEO> GetByWinAmount(long winAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByWinAmountAsync(long winAmount, string sort_, TransactionManager tm_)
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
		public List<Big_spin_detailEO> GetByWinAmount(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByWinAmountAsync(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByWinAmount
		#region GetByBetBonus
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注bonus</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBetBonus(long betBonus)
		{
			return GetByBetBonus(betBonus, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByBetBonusAsync(long betBonus)
		{
			return await GetByBetBonusAsync(betBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBetBonus(long betBonus, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByBetBonusAsync(long betBonus, TransactionManager tm_)
		{
			return await GetByBetBonusAsync(betBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBetBonus(long betBonus, int top_)
		{
			return GetByBetBonus(betBonus, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByBetBonusAsync(long betBonus, int top_)
		{
			return await GetByBetBonusAsync(betBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBetBonus(long betBonus, int top_, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByBetBonusAsync(long betBonus, int top_, TransactionManager tm_)
		{
			return await GetByBetBonusAsync(betBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBetBonus(long betBonus, string sort_)
		{
			return GetByBetBonus(betBonus, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByBetBonusAsync(long betBonus, string sort_)
		{
			return await GetByBetBonusAsync(betBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBetBonus(long betBonus, string sort_, TransactionManager tm_)
		{
			return GetByBetBonus(betBonus, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByBetBonusAsync(long betBonus, string sort_, TransactionManager tm_)
		{
			return await GetByBetBonusAsync(betBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetBonus（字段） 查询
		/// </summary>
		/// /// <param name = "betBonus">下注bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByBetBonus(long betBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBonus` = @BetBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByBetBonusAsync(long betBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBonus` = @BetBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonus", betBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByBetBonus
		#region GetByWinBonus
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖bonus</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByWinBonus(long winBonus)
		{
			return GetByWinBonus(winBonus, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByWinBonusAsync(long winBonus)
		{
			return await GetByWinBonusAsync(winBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByWinBonus(long winBonus, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByWinBonusAsync(long winBonus, TransactionManager tm_)
		{
			return await GetByWinBonusAsync(winBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByWinBonus(long winBonus, int top_)
		{
			return GetByWinBonus(winBonus, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByWinBonusAsync(long winBonus, int top_)
		{
			return await GetByWinBonusAsync(winBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByWinBonus(long winBonus, int top_, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByWinBonusAsync(long winBonus, int top_, TransactionManager tm_)
		{
			return await GetByWinBonusAsync(winBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByWinBonus(long winBonus, string sort_)
		{
			return GetByWinBonus(winBonus, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByWinBonusAsync(long winBonus, string sort_)
		{
			return await GetByWinBonusAsync(winBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByWinBonus(long winBonus, string sort_, TransactionManager tm_)
		{
			return GetByWinBonus(winBonus, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByWinBonusAsync(long winBonus, string sort_, TransactionManager tm_)
		{
			return await GetByWinBonusAsync(winBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinBonus（字段） 查询
		/// </summary>
		/// /// <param name = "winBonus">返奖bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByWinBonus(long winBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinBonus` = @WinBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByWinBonusAsync(long winBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinBonus` = @WinBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonus", winBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByWinBonus
		#region GetByIsWin
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖(奖池是否够)</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByIsWin(int isWin)
		{
			return GetByIsWin(isWin, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByIsWinAsync(int isWin)
		{
			return await GetByIsWinAsync(isWin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖(奖池是否够)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByIsWin(int isWin, TransactionManager tm_)
		{
			return GetByIsWin(isWin, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByIsWinAsync(int isWin, TransactionManager tm_)
		{
			return await GetByIsWinAsync(isWin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖(奖池是否够)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByIsWin(int isWin, int top_)
		{
			return GetByIsWin(isWin, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByIsWinAsync(int isWin, int top_)
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
		public List<Big_spin_detailEO> GetByIsWin(int isWin, int top_, TransactionManager tm_)
		{
			return GetByIsWin(isWin, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByIsWinAsync(int isWin, int top_, TransactionManager tm_)
		{
			return await GetByIsWinAsync(isWin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖(奖池是否够)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByIsWin(int isWin, string sort_)
		{
			return GetByIsWin(isWin, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByIsWinAsync(int isWin, string sort_)
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
		public List<Big_spin_detailEO> GetByIsWin(int isWin, string sort_, TransactionManager tm_)
		{
			return GetByIsWin(isWin, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByIsWinAsync(int isWin, string sort_, TransactionManager tm_)
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
		public List<Big_spin_detailEO> GetByIsWin(int isWin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsWin` = @IsWin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByIsWinAsync(int isWin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsWin` = @IsWin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByIsWin
		#region GetByTotalMultip
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTotalMultip(float totalMultip)
		{
			return GetByTotalMultip(totalMultip, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByTotalMultipAsync(float totalMultip)
		{
			return await GetByTotalMultipAsync(totalMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTotalMultip(float totalMultip, TransactionManager tm_)
		{
			return GetByTotalMultip(totalMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByTotalMultipAsync(float totalMultip, TransactionManager tm_)
		{
			return await GetByTotalMultipAsync(totalMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTotalMultip(float totalMultip, int top_)
		{
			return GetByTotalMultip(totalMultip, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByTotalMultipAsync(float totalMultip, int top_)
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
		public List<Big_spin_detailEO> GetByTotalMultip(float totalMultip, int top_, TransactionManager tm_)
		{
			return GetByTotalMultip(totalMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByTotalMultipAsync(float totalMultip, int top_, TransactionManager tm_)
		{
			return await GetByTotalMultipAsync(totalMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalMultip（字段） 查询
		/// </summary>
		/// /// <param name = "totalMultip">中奖总倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTotalMultip(float totalMultip, string sort_)
		{
			return GetByTotalMultip(totalMultip, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByTotalMultipAsync(float totalMultip, string sort_)
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
		public List<Big_spin_detailEO> GetByTotalMultip(float totalMultip, string sort_, TransactionManager tm_)
		{
			return GetByTotalMultip(totalMultip, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByTotalMultipAsync(float totalMultip, string sort_, TransactionManager tm_)
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
		public List<Big_spin_detailEO> GetByTotalMultip(float totalMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalMultip` = @TotalMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalMultip", totalMultip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByTotalMultipAsync(float totalMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalMultip` = @TotalMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalMultip", totalMultip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByTotalMultip
		#region GetByTriggerFreeSpin
		
		/// <summary>
		/// 按 TriggerFreeSpin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerFreeSpin">触发freespin次数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerFreeSpin(int triggerFreeSpin)
		{
			return GetByTriggerFreeSpin(triggerFreeSpin, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerFreeSpinAsync(int triggerFreeSpin)
		{
			return await GetByTriggerFreeSpinAsync(triggerFreeSpin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerFreeSpin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerFreeSpin">触发freespin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerFreeSpin(int triggerFreeSpin, TransactionManager tm_)
		{
			return GetByTriggerFreeSpin(triggerFreeSpin, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerFreeSpinAsync(int triggerFreeSpin, TransactionManager tm_)
		{
			return await GetByTriggerFreeSpinAsync(triggerFreeSpin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerFreeSpin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerFreeSpin">触发freespin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerFreeSpin(int triggerFreeSpin, int top_)
		{
			return GetByTriggerFreeSpin(triggerFreeSpin, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerFreeSpinAsync(int triggerFreeSpin, int top_)
		{
			return await GetByTriggerFreeSpinAsync(triggerFreeSpin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerFreeSpin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerFreeSpin">触发freespin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerFreeSpin(int triggerFreeSpin, int top_, TransactionManager tm_)
		{
			return GetByTriggerFreeSpin(triggerFreeSpin, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerFreeSpinAsync(int triggerFreeSpin, int top_, TransactionManager tm_)
		{
			return await GetByTriggerFreeSpinAsync(triggerFreeSpin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerFreeSpin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerFreeSpin">触发freespin次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerFreeSpin(int triggerFreeSpin, string sort_)
		{
			return GetByTriggerFreeSpin(triggerFreeSpin, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerFreeSpinAsync(int triggerFreeSpin, string sort_)
		{
			return await GetByTriggerFreeSpinAsync(triggerFreeSpin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TriggerFreeSpin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerFreeSpin">触发freespin次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerFreeSpin(int triggerFreeSpin, string sort_, TransactionManager tm_)
		{
			return GetByTriggerFreeSpin(triggerFreeSpin, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerFreeSpinAsync(int triggerFreeSpin, string sort_, TransactionManager tm_)
		{
			return await GetByTriggerFreeSpinAsync(triggerFreeSpin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TriggerFreeSpin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerFreeSpin">触发freespin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerFreeSpin(int triggerFreeSpin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerFreeSpin` = @TriggerFreeSpin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerFreeSpin", triggerFreeSpin, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerFreeSpinAsync(int triggerFreeSpin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerFreeSpin` = @TriggerFreeSpin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerFreeSpin", triggerFreeSpin, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByTriggerFreeSpin
		#region GetByTriggerRespin
		
		/// <summary>
		/// 按 TriggerRespin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerRespin">触发respin次数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerRespin(int triggerRespin)
		{
			return GetByTriggerRespin(triggerRespin, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerRespinAsync(int triggerRespin)
		{
			return await GetByTriggerRespinAsync(triggerRespin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerRespin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerRespin">触发respin次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerRespin(int triggerRespin, TransactionManager tm_)
		{
			return GetByTriggerRespin(triggerRespin, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerRespinAsync(int triggerRespin, TransactionManager tm_)
		{
			return await GetByTriggerRespinAsync(triggerRespin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerRespin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerRespin">触发respin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerRespin(int triggerRespin, int top_)
		{
			return GetByTriggerRespin(triggerRespin, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerRespinAsync(int triggerRespin, int top_)
		{
			return await GetByTriggerRespinAsync(triggerRespin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerRespin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerRespin">触发respin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerRespin(int triggerRespin, int top_, TransactionManager tm_)
		{
			return GetByTriggerRespin(triggerRespin, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerRespinAsync(int triggerRespin, int top_, TransactionManager tm_)
		{
			return await GetByTriggerRespinAsync(triggerRespin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerRespin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerRespin">触发respin次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerRespin(int triggerRespin, string sort_)
		{
			return GetByTriggerRespin(triggerRespin, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerRespinAsync(int triggerRespin, string sort_)
		{
			return await GetByTriggerRespinAsync(triggerRespin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TriggerRespin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerRespin">触发respin次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerRespin(int triggerRespin, string sort_, TransactionManager tm_)
		{
			return GetByTriggerRespin(triggerRespin, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerRespinAsync(int triggerRespin, string sort_, TransactionManager tm_)
		{
			return await GetByTriggerRespinAsync(triggerRespin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TriggerRespin（字段） 查询
		/// </summary>
		/// /// <param name = "triggerRespin">触发respin次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerRespin(int triggerRespin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerRespin` = @TriggerRespin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerRespin", triggerRespin, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerRespinAsync(int triggerRespin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerRespin` = @TriggerRespin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerRespin", triggerRespin, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByTriggerRespin
		#region GetByTriggerSE
		
		/// <summary>
		/// 按 TriggerSE（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSE">触发Special effects</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerSE(int triggerSE)
		{
			return GetByTriggerSE(triggerSE, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerSEAsync(int triggerSE)
		{
			return await GetByTriggerSEAsync(triggerSE, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerSE（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSE">触发Special effects</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerSE(int triggerSE, TransactionManager tm_)
		{
			return GetByTriggerSE(triggerSE, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerSEAsync(int triggerSE, TransactionManager tm_)
		{
			return await GetByTriggerSEAsync(triggerSE, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerSE（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSE">触发Special effects</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerSE(int triggerSE, int top_)
		{
			return GetByTriggerSE(triggerSE, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerSEAsync(int triggerSE, int top_)
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
		public List<Big_spin_detailEO> GetByTriggerSE(int triggerSE, int top_, TransactionManager tm_)
		{
			return GetByTriggerSE(triggerSE, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerSEAsync(int triggerSE, int top_, TransactionManager tm_)
		{
			return await GetByTriggerSEAsync(triggerSE, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerSE（字段） 查询
		/// </summary>
		/// /// <param name = "triggerSE">触发Special effects</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByTriggerSE(int triggerSE, string sort_)
		{
			return GetByTriggerSE(triggerSE, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerSEAsync(int triggerSE, string sort_)
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
		public List<Big_spin_detailEO> GetByTriggerSE(int triggerSE, string sort_, TransactionManager tm_)
		{
			return GetByTriggerSE(triggerSE, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerSEAsync(int triggerSE, string sort_, TransactionManager tm_)
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
		public List<Big_spin_detailEO> GetByTriggerSE(int triggerSE, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerSE` = @TriggerSE", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerSE", triggerSE, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByTriggerSEAsync(int triggerSE, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerSE` = @TriggerSE", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerSE", triggerSE, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByTriggerSE
		#region GetByHistoryMultip
		
		/// <summary>
		/// 按 HistoryMultip（字段） 查询
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByHistoryMultip(string historyMultip)
		{
			return GetByHistoryMultip(historyMultip, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByHistoryMultipAsync(string historyMultip)
		{
			return await GetByHistoryMultipAsync(historyMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HistoryMultip（字段） 查询
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByHistoryMultip(string historyMultip, TransactionManager tm_)
		{
			return GetByHistoryMultip(historyMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByHistoryMultipAsync(string historyMultip, TransactionManager tm_)
		{
			return await GetByHistoryMultipAsync(historyMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryMultip（字段） 查询
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByHistoryMultip(string historyMultip, int top_)
		{
			return GetByHistoryMultip(historyMultip, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByHistoryMultipAsync(string historyMultip, int top_)
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
		public List<Big_spin_detailEO> GetByHistoryMultip(string historyMultip, int top_, TransactionManager tm_)
		{
			return GetByHistoryMultip(historyMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByHistoryMultipAsync(string historyMultip, int top_, TransactionManager tm_)
		{
			return await GetByHistoryMultipAsync(historyMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryMultip（字段） 查询
		/// </summary>
		/// /// <param name = "historyMultip">25条线对应的倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByHistoryMultip(string historyMultip, string sort_)
		{
			return GetByHistoryMultip(historyMultip, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByHistoryMultipAsync(string historyMultip, string sort_)
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
		public List<Big_spin_detailEO> GetByHistoryMultip(string historyMultip, string sort_, TransactionManager tm_)
		{
			return GetByHistoryMultip(historyMultip, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByHistoryMultipAsync(string historyMultip, string sort_, TransactionManager tm_)
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
		public List<Big_spin_detailEO> GetByHistoryMultip(string historyMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryMultip` = @HistoryMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryMultip", historyMultip, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByHistoryMultipAsync(string historyMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryMultip` = @HistoryMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryMultip", historyMultip, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByHistoryMultip
		#region GetByRewardDetailList
		
		/// <summary>
		/// 按 RewardDetailList（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetailList">中奖详情</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRewardDetailList(string rewardDetailList)
		{
			return GetByRewardDetailList(rewardDetailList, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByRewardDetailListAsync(string rewardDetailList)
		{
			return await GetByRewardDetailListAsync(rewardDetailList, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardDetailList（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetailList">中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRewardDetailList(string rewardDetailList, TransactionManager tm_)
		{
			return GetByRewardDetailList(rewardDetailList, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByRewardDetailListAsync(string rewardDetailList, TransactionManager tm_)
		{
			return await GetByRewardDetailListAsync(rewardDetailList, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardDetailList（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetailList">中奖详情</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRewardDetailList(string rewardDetailList, int top_)
		{
			return GetByRewardDetailList(rewardDetailList, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByRewardDetailListAsync(string rewardDetailList, int top_)
		{
			return await GetByRewardDetailListAsync(rewardDetailList, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardDetailList（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetailList">中奖详情</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRewardDetailList(string rewardDetailList, int top_, TransactionManager tm_)
		{
			return GetByRewardDetailList(rewardDetailList, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByRewardDetailListAsync(string rewardDetailList, int top_, TransactionManager tm_)
		{
			return await GetByRewardDetailListAsync(rewardDetailList, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardDetailList（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetailList">中奖详情</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRewardDetailList(string rewardDetailList, string sort_)
		{
			return GetByRewardDetailList(rewardDetailList, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByRewardDetailListAsync(string rewardDetailList, string sort_)
		{
			return await GetByRewardDetailListAsync(rewardDetailList, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RewardDetailList（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetailList">中奖详情</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRewardDetailList(string rewardDetailList, string sort_, TransactionManager tm_)
		{
			return GetByRewardDetailList(rewardDetailList, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByRewardDetailListAsync(string rewardDetailList, string sort_, TransactionManager tm_)
		{
			return await GetByRewardDetailListAsync(rewardDetailList, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RewardDetailList（字段） 查询
		/// </summary>
		/// /// <param name = "rewardDetailList">中奖详情</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRewardDetailList(string rewardDetailList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardDetailList` = @RewardDetailList", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardDetailList", rewardDetailList, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByRewardDetailListAsync(string rewardDetailList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardDetailList` = @RewardDetailList", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardDetailList", rewardDetailList, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByRewardDetailList
		#region GetBySlotEleList
		
		/// <summary>
		/// 按 SlotEleList（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleList">返回给客户端数据结构</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySlotEleList(string slotEleList)
		{
			return GetBySlotEleList(slotEleList, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetBySlotEleListAsync(string slotEleList)
		{
			return await GetBySlotEleListAsync(slotEleList, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SlotEleList（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleList">返回给客户端数据结构</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySlotEleList(string slotEleList, TransactionManager tm_)
		{
			return GetBySlotEleList(slotEleList, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetBySlotEleListAsync(string slotEleList, TransactionManager tm_)
		{
			return await GetBySlotEleListAsync(slotEleList, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SlotEleList（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleList">返回给客户端数据结构</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySlotEleList(string slotEleList, int top_)
		{
			return GetBySlotEleList(slotEleList, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetBySlotEleListAsync(string slotEleList, int top_)
		{
			return await GetBySlotEleListAsync(slotEleList, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SlotEleList（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleList">返回给客户端数据结构</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySlotEleList(string slotEleList, int top_, TransactionManager tm_)
		{
			return GetBySlotEleList(slotEleList, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetBySlotEleListAsync(string slotEleList, int top_, TransactionManager tm_)
		{
			return await GetBySlotEleListAsync(slotEleList, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SlotEleList（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleList">返回给客户端数据结构</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySlotEleList(string slotEleList, string sort_)
		{
			return GetBySlotEleList(slotEleList, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetBySlotEleListAsync(string slotEleList, string sort_)
		{
			return await GetBySlotEleListAsync(slotEleList, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SlotEleList（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleList">返回给客户端数据结构</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySlotEleList(string slotEleList, string sort_, TransactionManager tm_)
		{
			return GetBySlotEleList(slotEleList, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetBySlotEleListAsync(string slotEleList, string sort_, TransactionManager tm_)
		{
			return await GetBySlotEleListAsync(slotEleList, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SlotEleList（字段） 查询
		/// </summary>
		/// /// <param name = "slotEleList">返回给客户端数据结构</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySlotEleList(string slotEleList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SlotEleList` = @SlotEleList", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SlotEleList", slotEleList, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetBySlotEleListAsync(string slotEleList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SlotEleList` = @SlotEleList", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SlotEleList", slotEleList, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetBySlotEleList
		#region GetByRespinList
		
		/// <summary>
		/// 按 RespinList（字段） 查询
		/// </summary>
		/// /// <param name = "respinList">respin中奖详情</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRespinList(string respinList)
		{
			return GetByRespinList(respinList, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByRespinListAsync(string respinList)
		{
			return await GetByRespinListAsync(respinList, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RespinList（字段） 查询
		/// </summary>
		/// /// <param name = "respinList">respin中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRespinList(string respinList, TransactionManager tm_)
		{
			return GetByRespinList(respinList, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByRespinListAsync(string respinList, TransactionManager tm_)
		{
			return await GetByRespinListAsync(respinList, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RespinList（字段） 查询
		/// </summary>
		/// /// <param name = "respinList">respin中奖详情</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRespinList(string respinList, int top_)
		{
			return GetByRespinList(respinList, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByRespinListAsync(string respinList, int top_)
		{
			return await GetByRespinListAsync(respinList, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RespinList（字段） 查询
		/// </summary>
		/// /// <param name = "respinList">respin中奖详情</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRespinList(string respinList, int top_, TransactionManager tm_)
		{
			return GetByRespinList(respinList, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByRespinListAsync(string respinList, int top_, TransactionManager tm_)
		{
			return await GetByRespinListAsync(respinList, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RespinList（字段） 查询
		/// </summary>
		/// /// <param name = "respinList">respin中奖详情</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRespinList(string respinList, string sort_)
		{
			return GetByRespinList(respinList, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByRespinListAsync(string respinList, string sort_)
		{
			return await GetByRespinListAsync(respinList, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RespinList（字段） 查询
		/// </summary>
		/// /// <param name = "respinList">respin中奖详情</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRespinList(string respinList, string sort_, TransactionManager tm_)
		{
			return GetByRespinList(respinList, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByRespinListAsync(string respinList, string sort_, TransactionManager tm_)
		{
			return await GetByRespinListAsync(respinList, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RespinList（字段） 查询
		/// </summary>
		/// /// <param name = "respinList">respin中奖详情</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRespinList(string respinList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RespinList` = @RespinList", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RespinList", respinList, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByRespinListAsync(string respinList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RespinList` = @RespinList", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RespinList", respinList, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByRespinList
		#region GetByFreeSpinList
		
		/// <summary>
		/// 按 FreeSpinList（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinList">freespin中奖详情</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByFreeSpinList(string freeSpinList)
		{
			return GetByFreeSpinList(freeSpinList, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByFreeSpinListAsync(string freeSpinList)
		{
			return await GetByFreeSpinListAsync(freeSpinList, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FreeSpinList（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinList">freespin中奖详情</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByFreeSpinList(string freeSpinList, TransactionManager tm_)
		{
			return GetByFreeSpinList(freeSpinList, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByFreeSpinListAsync(string freeSpinList, TransactionManager tm_)
		{
			return await GetByFreeSpinListAsync(freeSpinList, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FreeSpinList（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinList">freespin中奖详情</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByFreeSpinList(string freeSpinList, int top_)
		{
			return GetByFreeSpinList(freeSpinList, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByFreeSpinListAsync(string freeSpinList, int top_)
		{
			return await GetByFreeSpinListAsync(freeSpinList, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FreeSpinList（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinList">freespin中奖详情</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByFreeSpinList(string freeSpinList, int top_, TransactionManager tm_)
		{
			return GetByFreeSpinList(freeSpinList, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByFreeSpinListAsync(string freeSpinList, int top_, TransactionManager tm_)
		{
			return await GetByFreeSpinListAsync(freeSpinList, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FreeSpinList（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinList">freespin中奖详情</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByFreeSpinList(string freeSpinList, string sort_)
		{
			return GetByFreeSpinList(freeSpinList, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByFreeSpinListAsync(string freeSpinList, string sort_)
		{
			return await GetByFreeSpinListAsync(freeSpinList, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FreeSpinList（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinList">freespin中奖详情</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByFreeSpinList(string freeSpinList, string sort_, TransactionManager tm_)
		{
			return GetByFreeSpinList(freeSpinList, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByFreeSpinListAsync(string freeSpinList, string sort_, TransactionManager tm_)
		{
			return await GetByFreeSpinListAsync(freeSpinList, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FreeSpinList（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinList">freespin中奖详情</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByFreeSpinList(string freeSpinList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FreeSpinList` = @FreeSpinList", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreeSpinList", freeSpinList, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByFreeSpinListAsync(string freeSpinList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FreeSpinList` = @FreeSpinList", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreeSpinList", freeSpinList, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByFreeSpinList
		#region GetByUserFlag
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByUserFlag(int userFlag)
		{
			return GetByUserFlag(userFlag, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByUserFlagAsync(int userFlag)
		{
			return await GetByUserFlagAsync(userFlag, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByUserFlag(int userFlag, TransactionManager tm_)
		{
			return GetByUserFlag(userFlag, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByUserFlagAsync(int userFlag, TransactionManager tm_)
		{
			return await GetByUserFlagAsync(userFlag, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByUserFlag(int userFlag, int top_)
		{
			return GetByUserFlag(userFlag, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByUserFlagAsync(int userFlag, int top_)
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
		public List<Big_spin_detailEO> GetByUserFlag(int userFlag, int top_, TransactionManager tm_)
		{
			return GetByUserFlag(userFlag, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByUserFlagAsync(int userFlag, int top_, TransactionManager tm_)
		{
			return await GetByUserFlagAsync(userFlag, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserFlag（字段） 查询
		/// </summary>
		/// /// <param name = "userFlag">用户AB面</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByUserFlag(int userFlag, string sort_)
		{
			return GetByUserFlag(userFlag, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByUserFlagAsync(int userFlag, string sort_)
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
		public List<Big_spin_detailEO> GetByUserFlag(int userFlag, string sort_, TransactionManager tm_)
		{
			return GetByUserFlag(userFlag, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByUserFlagAsync(int userFlag, string sort_, TransactionManager tm_)
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
		public List<Big_spin_detailEO> GetByUserFlag(int userFlag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserFlag` = @UserFlag", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserFlag", userFlag, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByUserFlagAsync(int userFlag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserFlag` = @UserFlag", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserFlag", userFlag, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByUserFlag
		#region GetBySMMultip
		
		/// <summary>
		/// 按 SMMultip（字段） 查询
		/// </summary>
		/// /// <param name = "sMMultip">特殊玩法中奖总倍数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySMMultip(float sMMultip)
		{
			return GetBySMMultip(sMMultip, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetBySMMultipAsync(float sMMultip)
		{
			return await GetBySMMultipAsync(sMMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SMMultip（字段） 查询
		/// </summary>
		/// /// <param name = "sMMultip">特殊玩法中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySMMultip(float sMMultip, TransactionManager tm_)
		{
			return GetBySMMultip(sMMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetBySMMultipAsync(float sMMultip, TransactionManager tm_)
		{
			return await GetBySMMultipAsync(sMMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SMMultip（字段） 查询
		/// </summary>
		/// /// <param name = "sMMultip">特殊玩法中奖总倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySMMultip(float sMMultip, int top_)
		{
			return GetBySMMultip(sMMultip, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetBySMMultipAsync(float sMMultip, int top_)
		{
			return await GetBySMMultipAsync(sMMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SMMultip（字段） 查询
		/// </summary>
		/// /// <param name = "sMMultip">特殊玩法中奖总倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySMMultip(float sMMultip, int top_, TransactionManager tm_)
		{
			return GetBySMMultip(sMMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetBySMMultipAsync(float sMMultip, int top_, TransactionManager tm_)
		{
			return await GetBySMMultipAsync(sMMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SMMultip（字段） 查询
		/// </summary>
		/// /// <param name = "sMMultip">特殊玩法中奖总倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySMMultip(float sMMultip, string sort_)
		{
			return GetBySMMultip(sMMultip, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetBySMMultipAsync(float sMMultip, string sort_)
		{
			return await GetBySMMultipAsync(sMMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SMMultip（字段） 查询
		/// </summary>
		/// /// <param name = "sMMultip">特殊玩法中奖总倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySMMultip(float sMMultip, string sort_, TransactionManager tm_)
		{
			return GetBySMMultip(sMMultip, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetBySMMultipAsync(float sMMultip, string sort_, TransactionManager tm_)
		{
			return await GetBySMMultipAsync(sMMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SMMultip（字段） 查询
		/// </summary>
		/// /// <param name = "sMMultip">特殊玩法中奖总倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySMMultip(float sMMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SMMultip` = @SMMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SMMultip", sMMultip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetBySMMultipAsync(float sMMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SMMultip` = @SMMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SMMultip", sMMultip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetBySMMultip
		#region GetBySMAmount
		
		/// <summary>
		/// 按 SMAmount（字段） 查询
		/// </summary>
		/// /// <param name = "sMAmount">特殊返奖金额</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySMAmount(long sMAmount)
		{
			return GetBySMAmount(sMAmount, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetBySMAmountAsync(long sMAmount)
		{
			return await GetBySMAmountAsync(sMAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SMAmount（字段） 查询
		/// </summary>
		/// /// <param name = "sMAmount">特殊返奖金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySMAmount(long sMAmount, TransactionManager tm_)
		{
			return GetBySMAmount(sMAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetBySMAmountAsync(long sMAmount, TransactionManager tm_)
		{
			return await GetBySMAmountAsync(sMAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SMAmount（字段） 查询
		/// </summary>
		/// /// <param name = "sMAmount">特殊返奖金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySMAmount(long sMAmount, int top_)
		{
			return GetBySMAmount(sMAmount, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetBySMAmountAsync(long sMAmount, int top_)
		{
			return await GetBySMAmountAsync(sMAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SMAmount（字段） 查询
		/// </summary>
		/// /// <param name = "sMAmount">特殊返奖金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySMAmount(long sMAmount, int top_, TransactionManager tm_)
		{
			return GetBySMAmount(sMAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetBySMAmountAsync(long sMAmount, int top_, TransactionManager tm_)
		{
			return await GetBySMAmountAsync(sMAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SMAmount（字段） 查询
		/// </summary>
		/// /// <param name = "sMAmount">特殊返奖金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySMAmount(long sMAmount, string sort_)
		{
			return GetBySMAmount(sMAmount, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetBySMAmountAsync(long sMAmount, string sort_)
		{
			return await GetBySMAmountAsync(sMAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SMAmount（字段） 查询
		/// </summary>
		/// /// <param name = "sMAmount">特殊返奖金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySMAmount(long sMAmount, string sort_, TransactionManager tm_)
		{
			return GetBySMAmount(sMAmount, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetBySMAmountAsync(long sMAmount, string sort_, TransactionManager tm_)
		{
			return await GetBySMAmountAsync(sMAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SMAmount（字段） 查询
		/// </summary>
		/// /// <param name = "sMAmount">特殊返奖金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetBySMAmount(long sMAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SMAmount` = @SMAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SMAmount", sMAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetBySMAmountAsync(long sMAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SMAmount` = @SMAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SMAmount", sMAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetBySMAmount
		#region GetByOrderStatus
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByOrderStatus(int orderStatus)
		{
			return GetByOrderStatus(orderStatus, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByOrderStatusAsync(int orderStatus)
		{
			return await GetByOrderStatusAsync(orderStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByOrderStatus(int orderStatus, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByOrderStatusAsync(int orderStatus, TransactionManager tm_)
		{
			return await GetByOrderStatusAsync(orderStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByOrderStatus(int orderStatus, int top_)
		{
			return GetByOrderStatus(orderStatus, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_)
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
		public List<Big_spin_detailEO> GetByOrderStatus(int orderStatus, int top_, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_, TransactionManager tm_)
		{
			return await GetByOrderStatusAsync(orderStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByOrderStatus(int orderStatus, string sort_)
		{
			return GetByOrderStatus(orderStatus, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByOrderStatusAsync(int orderStatus, string sort_)
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
		public List<Big_spin_detailEO> GetByOrderStatus(int orderStatus, string sort_, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByOrderStatusAsync(int orderStatus, string sort_, TransactionManager tm_)
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
		public List<Big_spin_detailEO> GetByOrderStatus(int orderStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderStatus` = @OrderStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderStatus` = @OrderStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByOrderStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Big_spin_detailEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_spin_detailEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Big_spin_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Big_spin_detailEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Big_spin_detailEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Big_spin_detailEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		public async Task<List<Big_spin_detailEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_spin_detailEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
