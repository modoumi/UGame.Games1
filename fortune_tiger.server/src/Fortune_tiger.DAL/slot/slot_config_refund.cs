/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2024-04-09 16: 24:32
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
	/// Atest用户标签配置
	/// 【表 slot_config_refund 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Slot_config_refundEO : IRowMapper<Slot_config_refundEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Slot_config_refundEO()
		{
			this.SpecialModeCD = 0d;
			this.NewExtraRefund = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalReundID;
		/// <summary>
		/// 【数据库中的原始主键 ReundID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalReundID
		{
			get { return _originalReundID; }
			set { HasOriginal = true; _originalReundID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ReundID", ReundID }, };
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
		public int ReundID { get; set; }
		/// <summary>
		/// 下注抽水不进入奖池的额度（用之前写死的也可以，做成可以配置的也可以）
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 2)]
		public double BetRate { get; set; }
		/// <summary>
		/// 下注之后进入输返奖池的额度
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 3)]
		public double RefundPotRate { get; set; }
		/// <summary>
		/// 小游戏冷却回合数，仅在当日连续随机到小游戏铺满的时候判断是否满足CD，如果跨日和小游戏随机到未铺满的话，则不判断
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 4)]
		public double SpecialModeCD { get; set; }
		/// <summary>
		/// 新用户不触发小游戏的累计轮数（非当日轮数），前面100轮不执行小游戏触发几率，或者触发了再判断是否满足手数，否则退回去重新执行一次非小游戏的随机
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int NewMinigameRound { get; set; }
		/// <summary>
		/// 新用户不触发输返工具的累计轮数（非当日轮数），前面50轮不会触发，超出轮数之后才开始开始走工具触发表的round累计循环行为，在那之前工具触发表的round数量不用开始计算
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int NewRefundRound { get; set; }
		/// <summary>
		/// 用户默认的输返工具触发次数，直到用完为止，当有默认次数和每日次数的时候，优先消耗每日次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int NewExtraRefund { get; set; }
		/// <summary>
		/// 小玩法轴1
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int Weight_Free2 { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Slot_config_refundEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Slot_config_refundEO MapDataReader(IDataReader reader)
		{
		    Slot_config_refundEO ret = new Slot_config_refundEO();
			ret.ReundID = reader.ToInt32("ReundID");
			ret.OriginalReundID = ret.ReundID;
			ret.BetRate = reader.ToDouble("BetRate");
			ret.RefundPotRate = reader.ToDouble("RefundPotRate");
			ret.SpecialModeCD = reader.ToDouble("SpecialModeCD");
			ret.NewMinigameRound = reader.ToInt32("NewMinigameRound");
			ret.NewRefundRound = reader.ToInt32("NewRefundRound");
			ret.NewExtraRefund = reader.ToInt32("NewExtraRefund");
			ret.Weight_Free2 = reader.ToInt32("Weight_Free2");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// Atest用户标签配置
	/// 【表 slot_config_refund 的操作类】
	/// </summary>
	[Obsolete]
	public class Slot_config_refundMO : MySqlTableMO<Slot_config_refundEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`slot_config_refund`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Slot_config_refundMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Slot_config_refundMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Slot_config_refundMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Slot_config_refundEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Slot_config_refundEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Slot_config_refundEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ReundID`, `BetRate`, `RefundPotRate`, `SpecialModeCD`, `NewMinigameRound`, `NewRefundRound`, `NewExtraRefund`, `Weight_Free2`) VALUE (@ReundID, @BetRate, @RefundPotRate, @SpecialModeCD, @NewMinigameRound, @NewRefundRound, @NewExtraRefund, @Weight_Free2);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", item.ReundID, MySqlDbType.Int32),
				Database.CreateInParameter("@BetRate", item.BetRate, MySqlDbType.Double),
				Database.CreateInParameter("@RefundPotRate", item.RefundPotRate, MySqlDbType.Double),
				Database.CreateInParameter("@SpecialModeCD", item.SpecialModeCD, MySqlDbType.Double),
				Database.CreateInParameter("@NewMinigameRound", item.NewMinigameRound, MySqlDbType.Int32),
				Database.CreateInParameter("@NewRefundRound", item.NewRefundRound, MySqlDbType.Int32),
				Database.CreateInParameter("@NewExtraRefund", item.NewExtraRefund, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight_Free2", item.Weight_Free2, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Slot_config_refundEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Slot_config_refundEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Slot_config_refundEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ReundID`, `BetRate`, `RefundPotRate`, `SpecialModeCD`, `NewMinigameRound`, `NewRefundRound`, `NewExtraRefund`, `Weight_Free2`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.ReundID},{item.BetRate},{item.RefundPotRate},{item.SpecialModeCD},{item.NewMinigameRound},{item.NewRefundRound},{item.NewExtraRefund},{item.Weight_Free2}),");
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
		/// /// <param name = "reundID"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int reundID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(reundID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int reundID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(reundID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int reundID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ReundID` = @ReundID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Slot_config_refundEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ReundID, tm_);
		}
		public async Task<int> RemoveAsync(Slot_config_refundEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ReundID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByBetRate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betRate">下注抽水不进入奖池的额度（用之前写死的也可以，做成可以配置的也可以）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetRate(double betRate, TransactionManager tm_ = null)
		{
			RepairRemoveByBetRateData(betRate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetRateAsync(double betRate, TransactionManager tm_ = null)
		{
			RepairRemoveByBetRateData(betRate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetRateData(double betRate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetRate` = @BetRate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetRate", betRate, MySqlDbType.Double));
		}
		#endregion // RemoveByBetRate
		#region RemoveByRefundPotRate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "refundPotRate">下注之后进入输返奖池的额度</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRefundPotRate(double refundPotRate, TransactionManager tm_ = null)
		{
			RepairRemoveByRefundPotRateData(refundPotRate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRefundPotRateAsync(double refundPotRate, TransactionManager tm_ = null)
		{
			RepairRemoveByRefundPotRateData(refundPotRate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRefundPotRateData(double refundPotRate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RefundPotRate` = @RefundPotRate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundPotRate", refundPotRate, MySqlDbType.Double));
		}
		#endregion // RemoveByRefundPotRate
		#region RemoveBySpecialModeCD
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "specialModeCD">小游戏冷却回合数，仅在当日连续随机到小游戏铺满的时候判断是否满足CD，如果跨日和小游戏随机到未铺满的话，则不判断</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySpecialModeCD(double specialModeCD, TransactionManager tm_ = null)
		{
			RepairRemoveBySpecialModeCDData(specialModeCD, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySpecialModeCDAsync(double specialModeCD, TransactionManager tm_ = null)
		{
			RepairRemoveBySpecialModeCDData(specialModeCD, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySpecialModeCDData(double specialModeCD, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SpecialModeCD` = @SpecialModeCD";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SpecialModeCD", specialModeCD, MySqlDbType.Double));
		}
		#endregion // RemoveBySpecialModeCD
		#region RemoveByNewMinigameRound
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "newMinigameRound">新用户不触发小游戏的累计轮数（非当日轮数），前面100轮不执行小游戏触发几率，或者触发了再判断是否满足手数，否则退回去重新执行一次非小游戏的随机</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNewMinigameRound(int newMinigameRound, TransactionManager tm_ = null)
		{
			RepairRemoveByNewMinigameRoundData(newMinigameRound, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNewMinigameRoundAsync(int newMinigameRound, TransactionManager tm_ = null)
		{
			RepairRemoveByNewMinigameRoundData(newMinigameRound, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNewMinigameRoundData(int newMinigameRound, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NewMinigameRound` = @NewMinigameRound";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewMinigameRound", newMinigameRound, MySqlDbType.Int32));
		}
		#endregion // RemoveByNewMinigameRound
		#region RemoveByNewRefundRound
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "newRefundRound">新用户不触发输返工具的累计轮数（非当日轮数），前面50轮不会触发，超出轮数之后才开始开始走工具触发表的round累计循环行为，在那之前工具触发表的round数量不用开始计算</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNewRefundRound(int newRefundRound, TransactionManager tm_ = null)
		{
			RepairRemoveByNewRefundRoundData(newRefundRound, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNewRefundRoundAsync(int newRefundRound, TransactionManager tm_ = null)
		{
			RepairRemoveByNewRefundRoundData(newRefundRound, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNewRefundRoundData(int newRefundRound, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NewRefundRound` = @NewRefundRound";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewRefundRound", newRefundRound, MySqlDbType.Int32));
		}
		#endregion // RemoveByNewRefundRound
		#region RemoveByNewExtraRefund
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "newExtraRefund">用户默认的输返工具触发次数，直到用完为止，当有默认次数和每日次数的时候，优先消耗每日次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNewExtraRefund(int newExtraRefund, TransactionManager tm_ = null)
		{
			RepairRemoveByNewExtraRefundData(newExtraRefund, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNewExtraRefundAsync(int newExtraRefund, TransactionManager tm_ = null)
		{
			RepairRemoveByNewExtraRefundData(newExtraRefund, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNewExtraRefundData(int newExtraRefund, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NewExtraRefund` = @NewExtraRefund";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewExtraRefund", newExtraRefund, MySqlDbType.Int32));
		}
		#endregion // RemoveByNewExtraRefund
		#region RemoveByWeight_Free2
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeight_Free2(int weight_Free2, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight_Free2Data(weight_Free2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeight_Free2Async(int weight_Free2, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight_Free2Data(weight_Free2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeight_Free2Data(int weight_Free2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Weight_Free2` = @Weight_Free2";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Free2", weight_Free2, MySqlDbType.Int32));
		}
		#endregion // RemoveByWeight_Free2
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
		public int Put(Slot_config_refundEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Slot_config_refundEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Slot_config_refundEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ReundID` = @ReundID, `BetRate` = @BetRate, `RefundPotRate` = @RefundPotRate, `SpecialModeCD` = @SpecialModeCD, `NewMinigameRound` = @NewMinigameRound, `NewRefundRound` = @NewRefundRound, `NewExtraRefund` = @NewExtraRefund, `Weight_Free2` = @Weight_Free2 WHERE `ReundID` = @ReundID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", item.ReundID, MySqlDbType.Int32),
				Database.CreateInParameter("@BetRate", item.BetRate, MySqlDbType.Double),
				Database.CreateInParameter("@RefundPotRate", item.RefundPotRate, MySqlDbType.Double),
				Database.CreateInParameter("@SpecialModeCD", item.SpecialModeCD, MySqlDbType.Double),
				Database.CreateInParameter("@NewMinigameRound", item.NewMinigameRound, MySqlDbType.Int32),
				Database.CreateInParameter("@NewRefundRound", item.NewRefundRound, MySqlDbType.Int32),
				Database.CreateInParameter("@NewExtraRefund", item.NewExtraRefund, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight_Free2", item.Weight_Free2, MySqlDbType.Int32),
				Database.CreateInParameter("@ReundID_Original", item.HasOriginal ? item.OriginalReundID : item.ReundID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Slot_config_refundEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Slot_config_refundEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "reundID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int reundID, string set_, params object[] values_)
		{
			return Put(set_, "`ReundID` = @ReundID", ConcatValues(values_, reundID));
		}
		public async Task<int> PutByPKAsync(int reundID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ReundID` = @ReundID", ConcatValues(values_, reundID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "reundID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int reundID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ReundID` = @ReundID", tm_, ConcatValues(values_, reundID));
		}
		public async Task<int> PutByPKAsync(int reundID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ReundID` = @ReundID", tm_, ConcatValues(values_, reundID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "reundID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int reundID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
	        };
			return Put(set_, "`ReundID` = @ReundID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int reundID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`ReundID` = @ReundID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutBetRate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "reundID"></param>
		/// /// <param name = "betRate">下注抽水不进入奖池的额度（用之前写死的也可以，做成可以配置的也可以）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetRateByPK(int reundID, double betRate, TransactionManager tm_ = null)
		{
			RepairPutBetRateByPKData(reundID, betRate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetRateByPKAsync(int reundID, double betRate, TransactionManager tm_ = null)
		{
			RepairPutBetRateByPKData(reundID, betRate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetRateByPKData(int reundID, double betRate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetRate` = @BetRate  WHERE `ReundID` = @ReundID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetRate", betRate, MySqlDbType.Double),
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betRate">下注抽水不进入奖池的额度（用之前写死的也可以，做成可以配置的也可以）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetRate(double betRate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetRate` = @BetRate";
			var parameter_ = Database.CreateInParameter("@BetRate", betRate, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetRateAsync(double betRate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetRate` = @BetRate";
			var parameter_ = Database.CreateInParameter("@BetRate", betRate, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetRate
		#region PutRefundPotRate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "reundID"></param>
		/// /// <param name = "refundPotRate">下注之后进入输返奖池的额度</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRefundPotRateByPK(int reundID, double refundPotRate, TransactionManager tm_ = null)
		{
			RepairPutRefundPotRateByPKData(reundID, refundPotRate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRefundPotRateByPKAsync(int reundID, double refundPotRate, TransactionManager tm_ = null)
		{
			RepairPutRefundPotRateByPKData(reundID, refundPotRate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRefundPotRateByPKData(int reundID, double refundPotRate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RefundPotRate` = @RefundPotRate  WHERE `ReundID` = @ReundID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RefundPotRate", refundPotRate, MySqlDbType.Double),
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "refundPotRate">下注之后进入输返奖池的额度</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRefundPotRate(double refundPotRate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RefundPotRate` = @RefundPotRate";
			var parameter_ = Database.CreateInParameter("@RefundPotRate", refundPotRate, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRefundPotRateAsync(double refundPotRate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RefundPotRate` = @RefundPotRate";
			var parameter_ = Database.CreateInParameter("@RefundPotRate", refundPotRate, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRefundPotRate
		#region PutSpecialModeCD
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "reundID"></param>
		/// /// <param name = "specialModeCD">小游戏冷却回合数，仅在当日连续随机到小游戏铺满的时候判断是否满足CD，如果跨日和小游戏随机到未铺满的话，则不判断</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSpecialModeCDByPK(int reundID, double specialModeCD, TransactionManager tm_ = null)
		{
			RepairPutSpecialModeCDByPKData(reundID, specialModeCD, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSpecialModeCDByPKAsync(int reundID, double specialModeCD, TransactionManager tm_ = null)
		{
			RepairPutSpecialModeCDByPKData(reundID, specialModeCD, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSpecialModeCDByPKData(int reundID, double specialModeCD, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SpecialModeCD` = @SpecialModeCD  WHERE `ReundID` = @ReundID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SpecialModeCD", specialModeCD, MySqlDbType.Double),
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "specialModeCD">小游戏冷却回合数，仅在当日连续随机到小游戏铺满的时候判断是否满足CD，如果跨日和小游戏随机到未铺满的话，则不判断</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSpecialModeCD(double specialModeCD, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SpecialModeCD` = @SpecialModeCD";
			var parameter_ = Database.CreateInParameter("@SpecialModeCD", specialModeCD, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSpecialModeCDAsync(double specialModeCD, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SpecialModeCD` = @SpecialModeCD";
			var parameter_ = Database.CreateInParameter("@SpecialModeCD", specialModeCD, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSpecialModeCD
		#region PutNewMinigameRound
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "reundID"></param>
		/// /// <param name = "newMinigameRound">新用户不触发小游戏的累计轮数（非当日轮数），前面100轮不执行小游戏触发几率，或者触发了再判断是否满足手数，否则退回去重新执行一次非小游戏的随机</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewMinigameRoundByPK(int reundID, int newMinigameRound, TransactionManager tm_ = null)
		{
			RepairPutNewMinigameRoundByPKData(reundID, newMinigameRound, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNewMinigameRoundByPKAsync(int reundID, int newMinigameRound, TransactionManager tm_ = null)
		{
			RepairPutNewMinigameRoundByPKData(reundID, newMinigameRound, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNewMinigameRoundByPKData(int reundID, int newMinigameRound, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NewMinigameRound` = @NewMinigameRound  WHERE `ReundID` = @ReundID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NewMinigameRound", newMinigameRound, MySqlDbType.Int32),
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "newMinigameRound">新用户不触发小游戏的累计轮数（非当日轮数），前面100轮不执行小游戏触发几率，或者触发了再判断是否满足手数，否则退回去重新执行一次非小游戏的随机</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewMinigameRound(int newMinigameRound, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewMinigameRound` = @NewMinigameRound";
			var parameter_ = Database.CreateInParameter("@NewMinigameRound", newMinigameRound, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNewMinigameRoundAsync(int newMinigameRound, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewMinigameRound` = @NewMinigameRound";
			var parameter_ = Database.CreateInParameter("@NewMinigameRound", newMinigameRound, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNewMinigameRound
		#region PutNewRefundRound
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "reundID"></param>
		/// /// <param name = "newRefundRound">新用户不触发输返工具的累计轮数（非当日轮数），前面50轮不会触发，超出轮数之后才开始开始走工具触发表的round累计循环行为，在那之前工具触发表的round数量不用开始计算</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewRefundRoundByPK(int reundID, int newRefundRound, TransactionManager tm_ = null)
		{
			RepairPutNewRefundRoundByPKData(reundID, newRefundRound, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNewRefundRoundByPKAsync(int reundID, int newRefundRound, TransactionManager tm_ = null)
		{
			RepairPutNewRefundRoundByPKData(reundID, newRefundRound, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNewRefundRoundByPKData(int reundID, int newRefundRound, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NewRefundRound` = @NewRefundRound  WHERE `ReundID` = @ReundID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NewRefundRound", newRefundRound, MySqlDbType.Int32),
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "newRefundRound">新用户不触发输返工具的累计轮数（非当日轮数），前面50轮不会触发，超出轮数之后才开始开始走工具触发表的round累计循环行为，在那之前工具触发表的round数量不用开始计算</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewRefundRound(int newRefundRound, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewRefundRound` = @NewRefundRound";
			var parameter_ = Database.CreateInParameter("@NewRefundRound", newRefundRound, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNewRefundRoundAsync(int newRefundRound, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewRefundRound` = @NewRefundRound";
			var parameter_ = Database.CreateInParameter("@NewRefundRound", newRefundRound, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNewRefundRound
		#region PutNewExtraRefund
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "reundID"></param>
		/// /// <param name = "newExtraRefund">用户默认的输返工具触发次数，直到用完为止，当有默认次数和每日次数的时候，优先消耗每日次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewExtraRefundByPK(int reundID, int newExtraRefund, TransactionManager tm_ = null)
		{
			RepairPutNewExtraRefundByPKData(reundID, newExtraRefund, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNewExtraRefundByPKAsync(int reundID, int newExtraRefund, TransactionManager tm_ = null)
		{
			RepairPutNewExtraRefundByPKData(reundID, newExtraRefund, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNewExtraRefundByPKData(int reundID, int newExtraRefund, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NewExtraRefund` = @NewExtraRefund  WHERE `ReundID` = @ReundID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NewExtraRefund", newExtraRefund, MySqlDbType.Int32),
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "newExtraRefund">用户默认的输返工具触发次数，直到用完为止，当有默认次数和每日次数的时候，优先消耗每日次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNewExtraRefund(int newExtraRefund, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewExtraRefund` = @NewExtraRefund";
			var parameter_ = Database.CreateInParameter("@NewExtraRefund", newExtraRefund, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNewExtraRefundAsync(int newExtraRefund, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NewExtraRefund` = @NewExtraRefund";
			var parameter_ = Database.CreateInParameter("@NewExtraRefund", newExtraRefund, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNewExtraRefund
		#region PutWeight_Free2
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "reundID"></param>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight_Free2ByPK(int reundID, int weight_Free2, TransactionManager tm_ = null)
		{
			RepairPutWeight_Free2ByPKData(reundID, weight_Free2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeight_Free2ByPKAsync(int reundID, int weight_Free2, TransactionManager tm_ = null)
		{
			RepairPutWeight_Free2ByPKData(reundID, weight_Free2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeight_Free2ByPKData(int reundID, int weight_Free2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight_Free2` = @Weight_Free2  WHERE `ReundID` = @ReundID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight_Free2", weight_Free2, MySqlDbType.Int32),
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight_Free2(int weight_Free2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight_Free2` = @Weight_Free2";
			var parameter_ = Database.CreateInParameter("@Weight_Free2", weight_Free2, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeight_Free2Async(int weight_Free2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight_Free2` = @Weight_Free2";
			var parameter_ = Database.CreateInParameter("@Weight_Free2", weight_Free2, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWeight_Free2
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Slot_config_refundEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ReundID) == null)
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
		public async Task<bool> SetAsync(Slot_config_refundEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ReundID) == null)
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
		/// /// <param name = "reundID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Slot_config_refundEO GetByPK(int reundID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(reundID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Slot_config_refundEO.MapDataReader);
		}
		public async Task<Slot_config_refundEO> GetByPKAsync(int reundID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(reundID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Slot_config_refundEO.MapDataReader);
		}
		private void RepairGetByPKData(int reundID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ReundID` = @ReundID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 BetRate（字段）
		/// </summary>
		/// /// <param name = "reundID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetBetRateByPK(int reundID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
			return (double)GetScalar("`BetRate`", "`ReundID` = @ReundID", paras_, tm_);
		}
		public async Task<double> GetBetRateByPKAsync(int reundID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
			return (double)await GetScalarAsync("`BetRate`", "`ReundID` = @ReundID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RefundPotRate（字段）
		/// </summary>
		/// /// <param name = "reundID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetRefundPotRateByPK(int reundID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
			return (double)GetScalar("`RefundPotRate`", "`ReundID` = @ReundID", paras_, tm_);
		}
		public async Task<double> GetRefundPotRateByPKAsync(int reundID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
			return (double)await GetScalarAsync("`RefundPotRate`", "`ReundID` = @ReundID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SpecialModeCD（字段）
		/// </summary>
		/// /// <param name = "reundID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetSpecialModeCDByPK(int reundID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
			return (double)GetScalar("`SpecialModeCD`", "`ReundID` = @ReundID", paras_, tm_);
		}
		public async Task<double> GetSpecialModeCDByPKAsync(int reundID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
			return (double)await GetScalarAsync("`SpecialModeCD`", "`ReundID` = @ReundID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NewMinigameRound（字段）
		/// </summary>
		/// /// <param name = "reundID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetNewMinigameRoundByPK(int reundID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`NewMinigameRound`", "`ReundID` = @ReundID", paras_, tm_);
		}
		public async Task<int> GetNewMinigameRoundByPKAsync(int reundID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`NewMinigameRound`", "`ReundID` = @ReundID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NewRefundRound（字段）
		/// </summary>
		/// /// <param name = "reundID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetNewRefundRoundByPK(int reundID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`NewRefundRound`", "`ReundID` = @ReundID", paras_, tm_);
		}
		public async Task<int> GetNewRefundRoundByPKAsync(int reundID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`NewRefundRound`", "`ReundID` = @ReundID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NewExtraRefund（字段）
		/// </summary>
		/// /// <param name = "reundID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetNewExtraRefundByPK(int reundID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`NewExtraRefund`", "`ReundID` = @ReundID", paras_, tm_);
		}
		public async Task<int> GetNewExtraRefundByPKAsync(int reundID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`NewExtraRefund`", "`ReundID` = @ReundID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight_Free2（字段）
		/// </summary>
		/// /// <param name = "reundID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeight_Free2ByPK(int reundID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Weight_Free2`", "`ReundID` = @ReundID", paras_, tm_);
		}
		public async Task<int> GetWeight_Free2ByPKAsync(int reundID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReundID", reundID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Weight_Free2`", "`ReundID` = @ReundID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByBetRate
		
		/// <summary>
		/// 按 BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "betRate">下注抽水不进入奖池的额度（用之前写死的也可以，做成可以配置的也可以）</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByBetRate(double betRate)
		{
			return GetByBetRate(betRate, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByBetRateAsync(double betRate)
		{
			return await GetByBetRateAsync(betRate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "betRate">下注抽水不进入奖池的额度（用之前写死的也可以，做成可以配置的也可以）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByBetRate(double betRate, TransactionManager tm_)
		{
			return GetByBetRate(betRate, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByBetRateAsync(double betRate, TransactionManager tm_)
		{
			return await GetByBetRateAsync(betRate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "betRate">下注抽水不进入奖池的额度（用之前写死的也可以，做成可以配置的也可以）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByBetRate(double betRate, int top_)
		{
			return GetByBetRate(betRate, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByBetRateAsync(double betRate, int top_)
		{
			return await GetByBetRateAsync(betRate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "betRate">下注抽水不进入奖池的额度（用之前写死的也可以，做成可以配置的也可以）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByBetRate(double betRate, int top_, TransactionManager tm_)
		{
			return GetByBetRate(betRate, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByBetRateAsync(double betRate, int top_, TransactionManager tm_)
		{
			return await GetByBetRateAsync(betRate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "betRate">下注抽水不进入奖池的额度（用之前写死的也可以，做成可以配置的也可以）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByBetRate(double betRate, string sort_)
		{
			return GetByBetRate(betRate, 0, sort_, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByBetRateAsync(double betRate, string sort_)
		{
			return await GetByBetRateAsync(betRate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "betRate">下注抽水不进入奖池的额度（用之前写死的也可以，做成可以配置的也可以）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByBetRate(double betRate, string sort_, TransactionManager tm_)
		{
			return GetByBetRate(betRate, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByBetRateAsync(double betRate, string sort_, TransactionManager tm_)
		{
			return await GetByBetRateAsync(betRate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetRate（字段） 查询
		/// </summary>
		/// /// <param name = "betRate">下注抽水不进入奖池的额度（用之前写死的也可以，做成可以配置的也可以）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByBetRate(double betRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetRate` = @BetRate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetRate", betRate, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_refundEO.MapDataReader);
		}
		public async Task<List<Slot_config_refundEO>> GetByBetRateAsync(double betRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetRate` = @BetRate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetRate", betRate, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_refundEO.MapDataReader);
		}
		#endregion // GetByBetRate
		#region GetByRefundPotRate
		
		/// <summary>
		/// 按 RefundPotRate（字段） 查询
		/// </summary>
		/// /// <param name = "refundPotRate">下注之后进入输返奖池的额度</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByRefundPotRate(double refundPotRate)
		{
			return GetByRefundPotRate(refundPotRate, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByRefundPotRateAsync(double refundPotRate)
		{
			return await GetByRefundPotRateAsync(refundPotRate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RefundPotRate（字段） 查询
		/// </summary>
		/// /// <param name = "refundPotRate">下注之后进入输返奖池的额度</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByRefundPotRate(double refundPotRate, TransactionManager tm_)
		{
			return GetByRefundPotRate(refundPotRate, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByRefundPotRateAsync(double refundPotRate, TransactionManager tm_)
		{
			return await GetByRefundPotRateAsync(refundPotRate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RefundPotRate（字段） 查询
		/// </summary>
		/// /// <param name = "refundPotRate">下注之后进入输返奖池的额度</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByRefundPotRate(double refundPotRate, int top_)
		{
			return GetByRefundPotRate(refundPotRate, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByRefundPotRateAsync(double refundPotRate, int top_)
		{
			return await GetByRefundPotRateAsync(refundPotRate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RefundPotRate（字段） 查询
		/// </summary>
		/// /// <param name = "refundPotRate">下注之后进入输返奖池的额度</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByRefundPotRate(double refundPotRate, int top_, TransactionManager tm_)
		{
			return GetByRefundPotRate(refundPotRate, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByRefundPotRateAsync(double refundPotRate, int top_, TransactionManager tm_)
		{
			return await GetByRefundPotRateAsync(refundPotRate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RefundPotRate（字段） 查询
		/// </summary>
		/// /// <param name = "refundPotRate">下注之后进入输返奖池的额度</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByRefundPotRate(double refundPotRate, string sort_)
		{
			return GetByRefundPotRate(refundPotRate, 0, sort_, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByRefundPotRateAsync(double refundPotRate, string sort_)
		{
			return await GetByRefundPotRateAsync(refundPotRate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RefundPotRate（字段） 查询
		/// </summary>
		/// /// <param name = "refundPotRate">下注之后进入输返奖池的额度</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByRefundPotRate(double refundPotRate, string sort_, TransactionManager tm_)
		{
			return GetByRefundPotRate(refundPotRate, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByRefundPotRateAsync(double refundPotRate, string sort_, TransactionManager tm_)
		{
			return await GetByRefundPotRateAsync(refundPotRate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RefundPotRate（字段） 查询
		/// </summary>
		/// /// <param name = "refundPotRate">下注之后进入输返奖池的额度</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByRefundPotRate(double refundPotRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RefundPotRate` = @RefundPotRate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundPotRate", refundPotRate, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_refundEO.MapDataReader);
		}
		public async Task<List<Slot_config_refundEO>> GetByRefundPotRateAsync(double refundPotRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RefundPotRate` = @RefundPotRate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundPotRate", refundPotRate, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_refundEO.MapDataReader);
		}
		#endregion // GetByRefundPotRate
		#region GetBySpecialModeCD
		
		/// <summary>
		/// 按 SpecialModeCD（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeCD">小游戏冷却回合数，仅在当日连续随机到小游戏铺满的时候判断是否满足CD，如果跨日和小游戏随机到未铺满的话，则不判断</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetBySpecialModeCD(double specialModeCD)
		{
			return GetBySpecialModeCD(specialModeCD, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_refundEO>> GetBySpecialModeCDAsync(double specialModeCD)
		{
			return await GetBySpecialModeCDAsync(specialModeCD, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SpecialModeCD（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeCD">小游戏冷却回合数，仅在当日连续随机到小游戏铺满的时候判断是否满足CD，如果跨日和小游戏随机到未铺满的话，则不判断</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetBySpecialModeCD(double specialModeCD, TransactionManager tm_)
		{
			return GetBySpecialModeCD(specialModeCD, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetBySpecialModeCDAsync(double specialModeCD, TransactionManager tm_)
		{
			return await GetBySpecialModeCDAsync(specialModeCD, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SpecialModeCD（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeCD">小游戏冷却回合数，仅在当日连续随机到小游戏铺满的时候判断是否满足CD，如果跨日和小游戏随机到未铺满的话，则不判断</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetBySpecialModeCD(double specialModeCD, int top_)
		{
			return GetBySpecialModeCD(specialModeCD, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_refundEO>> GetBySpecialModeCDAsync(double specialModeCD, int top_)
		{
			return await GetBySpecialModeCDAsync(specialModeCD, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SpecialModeCD（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeCD">小游戏冷却回合数，仅在当日连续随机到小游戏铺满的时候判断是否满足CD，如果跨日和小游戏随机到未铺满的话，则不判断</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetBySpecialModeCD(double specialModeCD, int top_, TransactionManager tm_)
		{
			return GetBySpecialModeCD(specialModeCD, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetBySpecialModeCDAsync(double specialModeCD, int top_, TransactionManager tm_)
		{
			return await GetBySpecialModeCDAsync(specialModeCD, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SpecialModeCD（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeCD">小游戏冷却回合数，仅在当日连续随机到小游戏铺满的时候判断是否满足CD，如果跨日和小游戏随机到未铺满的话，则不判断</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetBySpecialModeCD(double specialModeCD, string sort_)
		{
			return GetBySpecialModeCD(specialModeCD, 0, sort_, null);
		}
		public async Task<List<Slot_config_refundEO>> GetBySpecialModeCDAsync(double specialModeCD, string sort_)
		{
			return await GetBySpecialModeCDAsync(specialModeCD, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SpecialModeCD（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeCD">小游戏冷却回合数，仅在当日连续随机到小游戏铺满的时候判断是否满足CD，如果跨日和小游戏随机到未铺满的话，则不判断</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetBySpecialModeCD(double specialModeCD, string sort_, TransactionManager tm_)
		{
			return GetBySpecialModeCD(specialModeCD, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetBySpecialModeCDAsync(double specialModeCD, string sort_, TransactionManager tm_)
		{
			return await GetBySpecialModeCDAsync(specialModeCD, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SpecialModeCD（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeCD">小游戏冷却回合数，仅在当日连续随机到小游戏铺满的时候判断是否满足CD，如果跨日和小游戏随机到未铺满的话，则不判断</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetBySpecialModeCD(double specialModeCD, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SpecialModeCD` = @SpecialModeCD", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SpecialModeCD", specialModeCD, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_refundEO.MapDataReader);
		}
		public async Task<List<Slot_config_refundEO>> GetBySpecialModeCDAsync(double specialModeCD, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SpecialModeCD` = @SpecialModeCD", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SpecialModeCD", specialModeCD, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_refundEO.MapDataReader);
		}
		#endregion // GetBySpecialModeCD
		#region GetByNewMinigameRound
		
		/// <summary>
		/// 按 NewMinigameRound（字段） 查询
		/// </summary>
		/// /// <param name = "newMinigameRound">新用户不触发小游戏的累计轮数（非当日轮数），前面100轮不执行小游戏触发几率，或者触发了再判断是否满足手数，否则退回去重新执行一次非小游戏的随机</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewMinigameRound(int newMinigameRound)
		{
			return GetByNewMinigameRound(newMinigameRound, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewMinigameRoundAsync(int newMinigameRound)
		{
			return await GetByNewMinigameRoundAsync(newMinigameRound, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewMinigameRound（字段） 查询
		/// </summary>
		/// /// <param name = "newMinigameRound">新用户不触发小游戏的累计轮数（非当日轮数），前面100轮不执行小游戏触发几率，或者触发了再判断是否满足手数，否则退回去重新执行一次非小游戏的随机</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewMinigameRound(int newMinigameRound, TransactionManager tm_)
		{
			return GetByNewMinigameRound(newMinigameRound, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewMinigameRoundAsync(int newMinigameRound, TransactionManager tm_)
		{
			return await GetByNewMinigameRoundAsync(newMinigameRound, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewMinigameRound（字段） 查询
		/// </summary>
		/// /// <param name = "newMinigameRound">新用户不触发小游戏的累计轮数（非当日轮数），前面100轮不执行小游戏触发几率，或者触发了再判断是否满足手数，否则退回去重新执行一次非小游戏的随机</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewMinigameRound(int newMinigameRound, int top_)
		{
			return GetByNewMinigameRound(newMinigameRound, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewMinigameRoundAsync(int newMinigameRound, int top_)
		{
			return await GetByNewMinigameRoundAsync(newMinigameRound, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewMinigameRound（字段） 查询
		/// </summary>
		/// /// <param name = "newMinigameRound">新用户不触发小游戏的累计轮数（非当日轮数），前面100轮不执行小游戏触发几率，或者触发了再判断是否满足手数，否则退回去重新执行一次非小游戏的随机</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewMinigameRound(int newMinigameRound, int top_, TransactionManager tm_)
		{
			return GetByNewMinigameRound(newMinigameRound, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewMinigameRoundAsync(int newMinigameRound, int top_, TransactionManager tm_)
		{
			return await GetByNewMinigameRoundAsync(newMinigameRound, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewMinigameRound（字段） 查询
		/// </summary>
		/// /// <param name = "newMinigameRound">新用户不触发小游戏的累计轮数（非当日轮数），前面100轮不执行小游戏触发几率，或者触发了再判断是否满足手数，否则退回去重新执行一次非小游戏的随机</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewMinigameRound(int newMinigameRound, string sort_)
		{
			return GetByNewMinigameRound(newMinigameRound, 0, sort_, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewMinigameRoundAsync(int newMinigameRound, string sort_)
		{
			return await GetByNewMinigameRoundAsync(newMinigameRound, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewMinigameRound（字段） 查询
		/// </summary>
		/// /// <param name = "newMinigameRound">新用户不触发小游戏的累计轮数（非当日轮数），前面100轮不执行小游戏触发几率，或者触发了再判断是否满足手数，否则退回去重新执行一次非小游戏的随机</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewMinigameRound(int newMinigameRound, string sort_, TransactionManager tm_)
		{
			return GetByNewMinigameRound(newMinigameRound, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewMinigameRoundAsync(int newMinigameRound, string sort_, TransactionManager tm_)
		{
			return await GetByNewMinigameRoundAsync(newMinigameRound, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewMinigameRound（字段） 查询
		/// </summary>
		/// /// <param name = "newMinigameRound">新用户不触发小游戏的累计轮数（非当日轮数），前面100轮不执行小游戏触发几率，或者触发了再判断是否满足手数，否则退回去重新执行一次非小游戏的随机</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewMinigameRound(int newMinigameRound, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewMinigameRound` = @NewMinigameRound", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewMinigameRound", newMinigameRound, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_refundEO.MapDataReader);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewMinigameRoundAsync(int newMinigameRound, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewMinigameRound` = @NewMinigameRound", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewMinigameRound", newMinigameRound, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_refundEO.MapDataReader);
		}
		#endregion // GetByNewMinigameRound
		#region GetByNewRefundRound
		
		/// <summary>
		/// 按 NewRefundRound（字段） 查询
		/// </summary>
		/// /// <param name = "newRefundRound">新用户不触发输返工具的累计轮数（非当日轮数），前面50轮不会触发，超出轮数之后才开始开始走工具触发表的round累计循环行为，在那之前工具触发表的round数量不用开始计算</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewRefundRound(int newRefundRound)
		{
			return GetByNewRefundRound(newRefundRound, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewRefundRoundAsync(int newRefundRound)
		{
			return await GetByNewRefundRoundAsync(newRefundRound, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewRefundRound（字段） 查询
		/// </summary>
		/// /// <param name = "newRefundRound">新用户不触发输返工具的累计轮数（非当日轮数），前面50轮不会触发，超出轮数之后才开始开始走工具触发表的round累计循环行为，在那之前工具触发表的round数量不用开始计算</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewRefundRound(int newRefundRound, TransactionManager tm_)
		{
			return GetByNewRefundRound(newRefundRound, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewRefundRoundAsync(int newRefundRound, TransactionManager tm_)
		{
			return await GetByNewRefundRoundAsync(newRefundRound, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewRefundRound（字段） 查询
		/// </summary>
		/// /// <param name = "newRefundRound">新用户不触发输返工具的累计轮数（非当日轮数），前面50轮不会触发，超出轮数之后才开始开始走工具触发表的round累计循环行为，在那之前工具触发表的round数量不用开始计算</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewRefundRound(int newRefundRound, int top_)
		{
			return GetByNewRefundRound(newRefundRound, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewRefundRoundAsync(int newRefundRound, int top_)
		{
			return await GetByNewRefundRoundAsync(newRefundRound, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewRefundRound（字段） 查询
		/// </summary>
		/// /// <param name = "newRefundRound">新用户不触发输返工具的累计轮数（非当日轮数），前面50轮不会触发，超出轮数之后才开始开始走工具触发表的round累计循环行为，在那之前工具触发表的round数量不用开始计算</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewRefundRound(int newRefundRound, int top_, TransactionManager tm_)
		{
			return GetByNewRefundRound(newRefundRound, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewRefundRoundAsync(int newRefundRound, int top_, TransactionManager tm_)
		{
			return await GetByNewRefundRoundAsync(newRefundRound, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewRefundRound（字段） 查询
		/// </summary>
		/// /// <param name = "newRefundRound">新用户不触发输返工具的累计轮数（非当日轮数），前面50轮不会触发，超出轮数之后才开始开始走工具触发表的round累计循环行为，在那之前工具触发表的round数量不用开始计算</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewRefundRound(int newRefundRound, string sort_)
		{
			return GetByNewRefundRound(newRefundRound, 0, sort_, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewRefundRoundAsync(int newRefundRound, string sort_)
		{
			return await GetByNewRefundRoundAsync(newRefundRound, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewRefundRound（字段） 查询
		/// </summary>
		/// /// <param name = "newRefundRound">新用户不触发输返工具的累计轮数（非当日轮数），前面50轮不会触发，超出轮数之后才开始开始走工具触发表的round累计循环行为，在那之前工具触发表的round数量不用开始计算</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewRefundRound(int newRefundRound, string sort_, TransactionManager tm_)
		{
			return GetByNewRefundRound(newRefundRound, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewRefundRoundAsync(int newRefundRound, string sort_, TransactionManager tm_)
		{
			return await GetByNewRefundRoundAsync(newRefundRound, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewRefundRound（字段） 查询
		/// </summary>
		/// /// <param name = "newRefundRound">新用户不触发输返工具的累计轮数（非当日轮数），前面50轮不会触发，超出轮数之后才开始开始走工具触发表的round累计循环行为，在那之前工具触发表的round数量不用开始计算</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewRefundRound(int newRefundRound, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewRefundRound` = @NewRefundRound", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewRefundRound", newRefundRound, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_refundEO.MapDataReader);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewRefundRoundAsync(int newRefundRound, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewRefundRound` = @NewRefundRound", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewRefundRound", newRefundRound, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_refundEO.MapDataReader);
		}
		#endregion // GetByNewRefundRound
		#region GetByNewExtraRefund
		
		/// <summary>
		/// 按 NewExtraRefund（字段） 查询
		/// </summary>
		/// /// <param name = "newExtraRefund">用户默认的输返工具触发次数，直到用完为止，当有默认次数和每日次数的时候，优先消耗每日次数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewExtraRefund(int newExtraRefund)
		{
			return GetByNewExtraRefund(newExtraRefund, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewExtraRefundAsync(int newExtraRefund)
		{
			return await GetByNewExtraRefundAsync(newExtraRefund, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewExtraRefund（字段） 查询
		/// </summary>
		/// /// <param name = "newExtraRefund">用户默认的输返工具触发次数，直到用完为止，当有默认次数和每日次数的时候，优先消耗每日次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewExtraRefund(int newExtraRefund, TransactionManager tm_)
		{
			return GetByNewExtraRefund(newExtraRefund, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewExtraRefundAsync(int newExtraRefund, TransactionManager tm_)
		{
			return await GetByNewExtraRefundAsync(newExtraRefund, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewExtraRefund（字段） 查询
		/// </summary>
		/// /// <param name = "newExtraRefund">用户默认的输返工具触发次数，直到用完为止，当有默认次数和每日次数的时候，优先消耗每日次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewExtraRefund(int newExtraRefund, int top_)
		{
			return GetByNewExtraRefund(newExtraRefund, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewExtraRefundAsync(int newExtraRefund, int top_)
		{
			return await GetByNewExtraRefundAsync(newExtraRefund, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NewExtraRefund（字段） 查询
		/// </summary>
		/// /// <param name = "newExtraRefund">用户默认的输返工具触发次数，直到用完为止，当有默认次数和每日次数的时候，优先消耗每日次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewExtraRefund(int newExtraRefund, int top_, TransactionManager tm_)
		{
			return GetByNewExtraRefund(newExtraRefund, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewExtraRefundAsync(int newExtraRefund, int top_, TransactionManager tm_)
		{
			return await GetByNewExtraRefundAsync(newExtraRefund, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NewExtraRefund（字段） 查询
		/// </summary>
		/// /// <param name = "newExtraRefund">用户默认的输返工具触发次数，直到用完为止，当有默认次数和每日次数的时候，优先消耗每日次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewExtraRefund(int newExtraRefund, string sort_)
		{
			return GetByNewExtraRefund(newExtraRefund, 0, sort_, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewExtraRefundAsync(int newExtraRefund, string sort_)
		{
			return await GetByNewExtraRefundAsync(newExtraRefund, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NewExtraRefund（字段） 查询
		/// </summary>
		/// /// <param name = "newExtraRefund">用户默认的输返工具触发次数，直到用完为止，当有默认次数和每日次数的时候，优先消耗每日次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewExtraRefund(int newExtraRefund, string sort_, TransactionManager tm_)
		{
			return GetByNewExtraRefund(newExtraRefund, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewExtraRefundAsync(int newExtraRefund, string sort_, TransactionManager tm_)
		{
			return await GetByNewExtraRefundAsync(newExtraRefund, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NewExtraRefund（字段） 查询
		/// </summary>
		/// /// <param name = "newExtraRefund">用户默认的输返工具触发次数，直到用完为止，当有默认次数和每日次数的时候，优先消耗每日次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByNewExtraRefund(int newExtraRefund, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewExtraRefund` = @NewExtraRefund", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewExtraRefund", newExtraRefund, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_refundEO.MapDataReader);
		}
		public async Task<List<Slot_config_refundEO>> GetByNewExtraRefundAsync(int newExtraRefund, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NewExtraRefund` = @NewExtraRefund", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NewExtraRefund", newExtraRefund, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_refundEO.MapDataReader);
		}
		#endregion // GetByNewExtraRefund
		#region GetByWeight_Free2
		
		/// <summary>
		/// 按 Weight_Free2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByWeight_Free2(int weight_Free2)
		{
			return GetByWeight_Free2(weight_Free2, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByWeight_Free2Async(int weight_Free2)
		{
			return await GetByWeight_Free2Async(weight_Free2, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight_Free2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByWeight_Free2(int weight_Free2, TransactionManager tm_)
		{
			return GetByWeight_Free2(weight_Free2, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByWeight_Free2Async(int weight_Free2, TransactionManager tm_)
		{
			return await GetByWeight_Free2Async(weight_Free2, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Free2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByWeight_Free2(int weight_Free2, int top_)
		{
			return GetByWeight_Free2(weight_Free2, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByWeight_Free2Async(int weight_Free2, int top_)
		{
			return await GetByWeight_Free2Async(weight_Free2, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight_Free2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByWeight_Free2(int weight_Free2, int top_, TransactionManager tm_)
		{
			return GetByWeight_Free2(weight_Free2, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByWeight_Free2Async(int weight_Free2, int top_, TransactionManager tm_)
		{
			return await GetByWeight_Free2Async(weight_Free2, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Free2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByWeight_Free2(int weight_Free2, string sort_)
		{
			return GetByWeight_Free2(weight_Free2, 0, sort_, null);
		}
		public async Task<List<Slot_config_refundEO>> GetByWeight_Free2Async(int weight_Free2, string sort_)
		{
			return await GetByWeight_Free2Async(weight_Free2, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Weight_Free2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByWeight_Free2(int weight_Free2, string sort_, TransactionManager tm_)
		{
			return GetByWeight_Free2(weight_Free2, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_refundEO>> GetByWeight_Free2Async(int weight_Free2, string sort_, TransactionManager tm_)
		{
			return await GetByWeight_Free2Async(weight_Free2, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Free2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_refundEO> GetByWeight_Free2(int weight_Free2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight_Free2` = @Weight_Free2", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Free2", weight_Free2, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_refundEO.MapDataReader);
		}
		public async Task<List<Slot_config_refundEO>> GetByWeight_Free2Async(int weight_Free2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight_Free2` = @Weight_Free2", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Free2", weight_Free2, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_refundEO.MapDataReader);
		}
		#endregion // GetByWeight_Free2
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
