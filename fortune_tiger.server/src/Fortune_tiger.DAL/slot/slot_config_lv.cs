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
	/// 【表 slot_config_lv 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Slot_config_lvEO : IRowMapper<Slot_config_lvEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Slot_config_lvEO()
		{
			this.CashRate = 0d;
			this.RTP = 0d;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalLevel;
		/// <summary>
		/// 【数据库中的原始主键 Level 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalLevel
		{
			get { return _originalLevel; }
			set { HasOriginal = true; _originalLevel = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "Level", Level }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 用户等级
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int Level { get; set; }
		/// <summary>
		/// 用户在当前游戏的总下注额度
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 2)]
		public long TotalBet { get; set; }
		/// <summary>
		/// 每日的触发次数，跟默认次数在一起的时候优先消耗每日次数
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 3)]
		public long RefundLimit { get; set; }
		/// <summary>
		/// 今日本金比例，用户今日首次进入游戏的时候的本金*cashRate，会用来计算第一次预期值
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 4)]
		public double CashRate { get; set; }
		/// <summary>
		/// 昨日亏损比例，用户上一次游戏的那一天亏损的比例，会用来计算预期值，如果用户上一次游戏的那一天在3天之前，就不考虑之前的亏损了
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 5)]
		public double LastLossRate { get; set; }
		/// <summary>
		/// 预期值当日亏损率，round触发输返工具时筛选的2个条件之一，如果1-（余额/预期）亏损超过lossRate，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 6)]
		public double LossRate { get; set; }
		/// <summary>
		/// 返奖率，round触发输返工具时筛选的2个条件之一，如果当日在游戏中的TOTALREWARD/TOTALBET，小于这个配置的RTP，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 7)]
		public double RTP { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Slot_config_lvEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Slot_config_lvEO MapDataReader(IDataReader reader)
		{
		    Slot_config_lvEO ret = new Slot_config_lvEO();
			ret.Level = reader.ToInt32("Level");
			ret.OriginalLevel = ret.Level;
			ret.TotalBet = reader.ToInt64("TotalBet");
			ret.RefundLimit = reader.ToInt64("RefundLimit");
			ret.CashRate = reader.ToDouble("CashRate");
			ret.LastLossRate = reader.ToDouble("LastLossRate");
			ret.LossRate = reader.ToDouble("LossRate");
			ret.RTP = reader.ToDouble("RTP");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// Atest用户标签配置
	/// 【表 slot_config_lv 的操作类】
	/// </summary>
	[Obsolete]
	public class Slot_config_lvMO : MySqlTableMO<Slot_config_lvEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`slot_config_lv`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Slot_config_lvMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Slot_config_lvMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Slot_config_lvMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Slot_config_lvEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Slot_config_lvEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Slot_config_lvEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`Level`, `TotalBet`, `RefundLimit`, `CashRate`, `LastLossRate`, `LossRate`, `RTP`) VALUE (@Level, @TotalBet, @RefundLimit, @CashRate, @LastLossRate, @LossRate, @RTP);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", item.Level, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalBet", item.TotalBet, MySqlDbType.Int64),
				Database.CreateInParameter("@RefundLimit", item.RefundLimit, MySqlDbType.Int64),
				Database.CreateInParameter("@CashRate", item.CashRate, MySqlDbType.Double),
				Database.CreateInParameter("@LastLossRate", item.LastLossRate, MySqlDbType.Double),
				Database.CreateInParameter("@LossRate", item.LossRate, MySqlDbType.Double),
				Database.CreateInParameter("@RTP", item.RTP, MySqlDbType.Double),
			};
		}
		public int AddByBatch(IEnumerable<Slot_config_lvEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Slot_config_lvEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Slot_config_lvEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`Level`, `TotalBet`, `RefundLimit`, `CashRate`, `LastLossRate`, `LossRate`, `RTP`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.Level},{item.TotalBet},{item.RefundLimit},{item.CashRate},{item.LastLossRate},{item.LossRate},{item.RTP}),");
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
		/// /// <param name = "level">用户等级</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int level, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(level, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int level, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(level, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int level, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Level` = @Level";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Slot_config_lvEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.Level, tm_);
		}
		public async Task<int> RemoveAsync(Slot_config_lvEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.Level, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByTotalBet
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalBet">用户在当前游戏的总下注额度</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalBet(long totalBet, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBetData(totalBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalBetAsync(long totalBet, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBetData(totalBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalBetData(long totalBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalBet` = @TotalBet";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBet", totalBet, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalBet
		#region RemoveByRefundLimit
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "refundLimit">每日的触发次数，跟默认次数在一起的时候优先消耗每日次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRefundLimit(long refundLimit, TransactionManager tm_ = null)
		{
			RepairRemoveByRefundLimitData(refundLimit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRefundLimitAsync(long refundLimit, TransactionManager tm_ = null)
		{
			RepairRemoveByRefundLimitData(refundLimit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRefundLimitData(long refundLimit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RefundLimit` = @RefundLimit";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundLimit", refundLimit, MySqlDbType.Int64));
		}
		#endregion // RemoveByRefundLimit
		#region RemoveByCashRate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashRate">今日本金比例，用户今日首次进入游戏的时候的本金*cashRate，会用来计算第一次预期值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashRate(double cashRate, TransactionManager tm_ = null)
		{
			RepairRemoveByCashRateData(cashRate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashRateAsync(double cashRate, TransactionManager tm_ = null)
		{
			RepairRemoveByCashRateData(cashRate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashRateData(double cashRate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CashRate` = @CashRate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashRate", cashRate, MySqlDbType.Double));
		}
		#endregion // RemoveByCashRate
		#region RemoveByLastLossRate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lastLossRate">昨日亏损比例，用户上一次游戏的那一天亏损的比例，会用来计算预期值，如果用户上一次游戏的那一天在3天之前，就不考虑之前的亏损了</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLastLossRate(double lastLossRate, TransactionManager tm_ = null)
		{
			RepairRemoveByLastLossRateData(lastLossRate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLastLossRateAsync(double lastLossRate, TransactionManager tm_ = null)
		{
			RepairRemoveByLastLossRateData(lastLossRate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLastLossRateData(double lastLossRate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LastLossRate` = @LastLossRate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastLossRate", lastLossRate, MySqlDbType.Double));
		}
		#endregion // RemoveByLastLossRate
		#region RemoveByLossRate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lossRate">预期值当日亏损率，round触发输返工具时筛选的2个条件之一，如果1-（余额/预期）亏损超过lossRate，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLossRate(double lossRate, TransactionManager tm_ = null)
		{
			RepairRemoveByLossRateData(lossRate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLossRateAsync(double lossRate, TransactionManager tm_ = null)
		{
			RepairRemoveByLossRateData(lossRate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLossRateData(double lossRate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LossRate` = @LossRate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LossRate", lossRate, MySqlDbType.Double));
		}
		#endregion // RemoveByLossRate
		#region RemoveByRTP
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rTP">返奖率，round触发输返工具时筛选的2个条件之一，如果当日在游戏中的TOTALREWARD/TOTALBET，小于这个配置的RTP，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
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
		public int Put(Slot_config_lvEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Slot_config_lvEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Slot_config_lvEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Level` = @Level, `TotalBet` = @TotalBet, `RefundLimit` = @RefundLimit, `CashRate` = @CashRate, `LastLossRate` = @LastLossRate, `LossRate` = @LossRate, `RTP` = @RTP WHERE `Level` = @Level_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", item.Level, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalBet", item.TotalBet, MySqlDbType.Int64),
				Database.CreateInParameter("@RefundLimit", item.RefundLimit, MySqlDbType.Int64),
				Database.CreateInParameter("@CashRate", item.CashRate, MySqlDbType.Double),
				Database.CreateInParameter("@LastLossRate", item.LastLossRate, MySqlDbType.Double),
				Database.CreateInParameter("@LossRate", item.LossRate, MySqlDbType.Double),
				Database.CreateInParameter("@RTP", item.RTP, MySqlDbType.Double),
				Database.CreateInParameter("@Level_Original", item.HasOriginal ? item.OriginalLevel : item.Level, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Slot_config_lvEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Slot_config_lvEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "level">用户等级</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int level, string set_, params object[] values_)
		{
			return Put(set_, "`Level` = @Level", ConcatValues(values_, level));
		}
		public async Task<int> PutByPKAsync(int level, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`Level` = @Level", ConcatValues(values_, level));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "level">用户等级</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int level, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`Level` = @Level", tm_, ConcatValues(values_, level));
		}
		public async Task<int> PutByPKAsync(int level, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`Level` = @Level", tm_, ConcatValues(values_, level));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "level">用户等级</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int level, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
	        };
			return Put(set_, "`Level` = @Level", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int level, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`Level` = @Level", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutTotalBet
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "level">用户等级</param>
		/// /// <param name = "totalBet">用户在当前游戏的总下注额度</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBetByPK(int level, long totalBet, TransactionManager tm_ = null)
		{
			RepairPutTotalBetByPKData(level, totalBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalBetByPKAsync(int level, long totalBet, TransactionManager tm_ = null)
		{
			RepairPutTotalBetByPKData(level, totalBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalBetByPKData(int level, long totalBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalBet` = @TotalBet  WHERE `Level` = @Level";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalBet", totalBet, MySqlDbType.Int64),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalBet">用户在当前游戏的总下注额度</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBet(long totalBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBet` = @TotalBet";
			var parameter_ = Database.CreateInParameter("@TotalBet", totalBet, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalBetAsync(long totalBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBet` = @TotalBet";
			var parameter_ = Database.CreateInParameter("@TotalBet", totalBet, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalBet
		#region PutRefundLimit
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "level">用户等级</param>
		/// /// <param name = "refundLimit">每日的触发次数，跟默认次数在一起的时候优先消耗每日次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRefundLimitByPK(int level, long refundLimit, TransactionManager tm_ = null)
		{
			RepairPutRefundLimitByPKData(level, refundLimit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRefundLimitByPKAsync(int level, long refundLimit, TransactionManager tm_ = null)
		{
			RepairPutRefundLimitByPKData(level, refundLimit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRefundLimitByPKData(int level, long refundLimit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RefundLimit` = @RefundLimit  WHERE `Level` = @Level";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RefundLimit", refundLimit, MySqlDbType.Int64),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "refundLimit">每日的触发次数，跟默认次数在一起的时候优先消耗每日次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRefundLimit(long refundLimit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RefundLimit` = @RefundLimit";
			var parameter_ = Database.CreateInParameter("@RefundLimit", refundLimit, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRefundLimitAsync(long refundLimit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RefundLimit` = @RefundLimit";
			var parameter_ = Database.CreateInParameter("@RefundLimit", refundLimit, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRefundLimit
		#region PutCashRate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "level">用户等级</param>
		/// /// <param name = "cashRate">今日本金比例，用户今日首次进入游戏的时候的本金*cashRate，会用来计算第一次预期值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashRateByPK(int level, double cashRate, TransactionManager tm_ = null)
		{
			RepairPutCashRateByPKData(level, cashRate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashRateByPKAsync(int level, double cashRate, TransactionManager tm_ = null)
		{
			RepairPutCashRateByPKData(level, cashRate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashRateByPKData(int level, double cashRate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashRate` = @CashRate  WHERE `Level` = @Level";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashRate", cashRate, MySqlDbType.Double),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashRate">今日本金比例，用户今日首次进入游戏的时候的本金*cashRate，会用来计算第一次预期值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashRate(double cashRate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashRate` = @CashRate";
			var parameter_ = Database.CreateInParameter("@CashRate", cashRate, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashRateAsync(double cashRate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashRate` = @CashRate";
			var parameter_ = Database.CreateInParameter("@CashRate", cashRate, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashRate
		#region PutLastLossRate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "level">用户等级</param>
		/// /// <param name = "lastLossRate">昨日亏损比例，用户上一次游戏的那一天亏损的比例，会用来计算预期值，如果用户上一次游戏的那一天在3天之前，就不考虑之前的亏损了</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastLossRateByPK(int level, double lastLossRate, TransactionManager tm_ = null)
		{
			RepairPutLastLossRateByPKData(level, lastLossRate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLastLossRateByPKAsync(int level, double lastLossRate, TransactionManager tm_ = null)
		{
			RepairPutLastLossRateByPKData(level, lastLossRate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLastLossRateByPKData(int level, double lastLossRate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LastLossRate` = @LastLossRate  WHERE `Level` = @Level";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LastLossRate", lastLossRate, MySqlDbType.Double),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lastLossRate">昨日亏损比例，用户上一次游戏的那一天亏损的比例，会用来计算预期值，如果用户上一次游戏的那一天在3天之前，就不考虑之前的亏损了</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastLossRate(double lastLossRate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastLossRate` = @LastLossRate";
			var parameter_ = Database.CreateInParameter("@LastLossRate", lastLossRate, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLastLossRateAsync(double lastLossRate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastLossRate` = @LastLossRate";
			var parameter_ = Database.CreateInParameter("@LastLossRate", lastLossRate, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLastLossRate
		#region PutLossRate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "level">用户等级</param>
		/// /// <param name = "lossRate">预期值当日亏损率，round触发输返工具时筛选的2个条件之一，如果1-（余额/预期）亏损超过lossRate，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLossRateByPK(int level, double lossRate, TransactionManager tm_ = null)
		{
			RepairPutLossRateByPKData(level, lossRate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLossRateByPKAsync(int level, double lossRate, TransactionManager tm_ = null)
		{
			RepairPutLossRateByPKData(level, lossRate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLossRateByPKData(int level, double lossRate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LossRate` = @LossRate  WHERE `Level` = @Level";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LossRate", lossRate, MySqlDbType.Double),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lossRate">预期值当日亏损率，round触发输返工具时筛选的2个条件之一，如果1-（余额/预期）亏损超过lossRate，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLossRate(double lossRate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LossRate` = @LossRate";
			var parameter_ = Database.CreateInParameter("@LossRate", lossRate, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLossRateAsync(double lossRate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LossRate` = @LossRate";
			var parameter_ = Database.CreateInParameter("@LossRate", lossRate, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLossRate
		#region PutRTP
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "level">用户等级</param>
		/// /// <param name = "rTP">返奖率，round触发输返工具时筛选的2个条件之一，如果当日在游戏中的TOTALREWARD/TOTALBET，小于这个配置的RTP，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRTPByPK(int level, double rTP, TransactionManager tm_ = null)
		{
			RepairPutRTPByPKData(level, rTP, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRTPByPKAsync(int level, double rTP, TransactionManager tm_ = null)
		{
			RepairPutRTPByPKData(level, rTP, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRTPByPKData(int level, double rTP, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RTP` = @RTP  WHERE `Level` = @Level";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RTP", rTP, MySqlDbType.Double),
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rTP">返奖率，round触发输返工具时筛选的2个条件之一，如果当日在游戏中的TOTALREWARD/TOTALBET，小于这个配置的RTP，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Slot_config_lvEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.Level) == null)
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
		public async Task<bool> SetAsync(Slot_config_lvEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.Level) == null)
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
		/// /// <param name = "level">用户等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Slot_config_lvEO GetByPK(int level, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(level, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Slot_config_lvEO.MapDataReader);
		}
		public async Task<Slot_config_lvEO> GetByPKAsync(int level, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(level, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Slot_config_lvEO.MapDataReader);
		}
		private void RepairGetByPKData(int level, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`Level` = @Level", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 TotalBet（字段）
		/// </summary>
		/// /// <param name = "level">用户等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalBetByPK(int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (long)GetScalar("`TotalBet`", "`Level` = @Level", paras_, tm_);
		}
		public async Task<long> GetTotalBetByPKAsync(int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`TotalBet`", "`Level` = @Level", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RefundLimit（字段）
		/// </summary>
		/// /// <param name = "level">用户等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetRefundLimitByPK(int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (long)GetScalar("`RefundLimit`", "`Level` = @Level", paras_, tm_);
		}
		public async Task<long> GetRefundLimitByPKAsync(int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`RefundLimit`", "`Level` = @Level", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashRate（字段）
		/// </summary>
		/// /// <param name = "level">用户等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetCashRateByPK(int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (double)GetScalar("`CashRate`", "`Level` = @Level", paras_, tm_);
		}
		public async Task<double> GetCashRateByPKAsync(int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (double)await GetScalarAsync("`CashRate`", "`Level` = @Level", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LastLossRate（字段）
		/// </summary>
		/// /// <param name = "level">用户等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetLastLossRateByPK(int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (double)GetScalar("`LastLossRate`", "`Level` = @Level", paras_, tm_);
		}
		public async Task<double> GetLastLossRateByPKAsync(int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (double)await GetScalarAsync("`LastLossRate`", "`Level` = @Level", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LossRate（字段）
		/// </summary>
		/// /// <param name = "level">用户等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetLossRateByPK(int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (double)GetScalar("`LossRate`", "`Level` = @Level", paras_, tm_);
		}
		public async Task<double> GetLossRateByPKAsync(int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (double)await GetScalarAsync("`LossRate`", "`Level` = @Level", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RTP（字段）
		/// </summary>
		/// /// <param name = "level">用户等级</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetRTPByPK(int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (double)GetScalar("`RTP`", "`Level` = @Level", paras_, tm_);
		}
		public async Task<double> GetRTPByPKAsync(int level, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Level", level, MySqlDbType.Int32),
			};
			return (double)await GetScalarAsync("`RTP`", "`Level` = @Level", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByTotalBet
		
		/// <summary>
		/// 按 TotalBet（字段） 查询
		/// </summary>
		/// /// <param name = "totalBet">用户在当前游戏的总下注额度</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByTotalBet(long totalBet)
		{
			return GetByTotalBet(totalBet, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByTotalBetAsync(long totalBet)
		{
			return await GetByTotalBetAsync(totalBet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBet（字段） 查询
		/// </summary>
		/// /// <param name = "totalBet">用户在当前游戏的总下注额度</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByTotalBet(long totalBet, TransactionManager tm_)
		{
			return GetByTotalBet(totalBet, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByTotalBetAsync(long totalBet, TransactionManager tm_)
		{
			return await GetByTotalBetAsync(totalBet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBet（字段） 查询
		/// </summary>
		/// /// <param name = "totalBet">用户在当前游戏的总下注额度</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByTotalBet(long totalBet, int top_)
		{
			return GetByTotalBet(totalBet, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByTotalBetAsync(long totalBet, int top_)
		{
			return await GetByTotalBetAsync(totalBet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBet（字段） 查询
		/// </summary>
		/// /// <param name = "totalBet">用户在当前游戏的总下注额度</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByTotalBet(long totalBet, int top_, TransactionManager tm_)
		{
			return GetByTotalBet(totalBet, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByTotalBetAsync(long totalBet, int top_, TransactionManager tm_)
		{
			return await GetByTotalBetAsync(totalBet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBet（字段） 查询
		/// </summary>
		/// /// <param name = "totalBet">用户在当前游戏的总下注额度</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByTotalBet(long totalBet, string sort_)
		{
			return GetByTotalBet(totalBet, 0, sort_, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByTotalBetAsync(long totalBet, string sort_)
		{
			return await GetByTotalBetAsync(totalBet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalBet（字段） 查询
		/// </summary>
		/// /// <param name = "totalBet">用户在当前游戏的总下注额度</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByTotalBet(long totalBet, string sort_, TransactionManager tm_)
		{
			return GetByTotalBet(totalBet, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByTotalBetAsync(long totalBet, string sort_, TransactionManager tm_)
		{
			return await GetByTotalBetAsync(totalBet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalBet（字段） 查询
		/// </summary>
		/// /// <param name = "totalBet">用户在当前游戏的总下注额度</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByTotalBet(long totalBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBet` = @TotalBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBet", totalBet, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_lvEO.MapDataReader);
		}
		public async Task<List<Slot_config_lvEO>> GetByTotalBetAsync(long totalBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBet` = @TotalBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBet", totalBet, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_lvEO.MapDataReader);
		}
		#endregion // GetByTotalBet
		#region GetByRefundLimit
		
		/// <summary>
		/// 按 RefundLimit（字段） 查询
		/// </summary>
		/// /// <param name = "refundLimit">每日的触发次数，跟默认次数在一起的时候优先消耗每日次数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByRefundLimit(long refundLimit)
		{
			return GetByRefundLimit(refundLimit, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByRefundLimitAsync(long refundLimit)
		{
			return await GetByRefundLimitAsync(refundLimit, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RefundLimit（字段） 查询
		/// </summary>
		/// /// <param name = "refundLimit">每日的触发次数，跟默认次数在一起的时候优先消耗每日次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByRefundLimit(long refundLimit, TransactionManager tm_)
		{
			return GetByRefundLimit(refundLimit, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByRefundLimitAsync(long refundLimit, TransactionManager tm_)
		{
			return await GetByRefundLimitAsync(refundLimit, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RefundLimit（字段） 查询
		/// </summary>
		/// /// <param name = "refundLimit">每日的触发次数，跟默认次数在一起的时候优先消耗每日次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByRefundLimit(long refundLimit, int top_)
		{
			return GetByRefundLimit(refundLimit, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByRefundLimitAsync(long refundLimit, int top_)
		{
			return await GetByRefundLimitAsync(refundLimit, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RefundLimit（字段） 查询
		/// </summary>
		/// /// <param name = "refundLimit">每日的触发次数，跟默认次数在一起的时候优先消耗每日次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByRefundLimit(long refundLimit, int top_, TransactionManager tm_)
		{
			return GetByRefundLimit(refundLimit, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByRefundLimitAsync(long refundLimit, int top_, TransactionManager tm_)
		{
			return await GetByRefundLimitAsync(refundLimit, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RefundLimit（字段） 查询
		/// </summary>
		/// /// <param name = "refundLimit">每日的触发次数，跟默认次数在一起的时候优先消耗每日次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByRefundLimit(long refundLimit, string sort_)
		{
			return GetByRefundLimit(refundLimit, 0, sort_, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByRefundLimitAsync(long refundLimit, string sort_)
		{
			return await GetByRefundLimitAsync(refundLimit, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RefundLimit（字段） 查询
		/// </summary>
		/// /// <param name = "refundLimit">每日的触发次数，跟默认次数在一起的时候优先消耗每日次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByRefundLimit(long refundLimit, string sort_, TransactionManager tm_)
		{
			return GetByRefundLimit(refundLimit, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByRefundLimitAsync(long refundLimit, string sort_, TransactionManager tm_)
		{
			return await GetByRefundLimitAsync(refundLimit, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RefundLimit（字段） 查询
		/// </summary>
		/// /// <param name = "refundLimit">每日的触发次数，跟默认次数在一起的时候优先消耗每日次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByRefundLimit(long refundLimit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RefundLimit` = @RefundLimit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundLimit", refundLimit, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_lvEO.MapDataReader);
		}
		public async Task<List<Slot_config_lvEO>> GetByRefundLimitAsync(long refundLimit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RefundLimit` = @RefundLimit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RefundLimit", refundLimit, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_lvEO.MapDataReader);
		}
		#endregion // GetByRefundLimit
		#region GetByCashRate
		
		/// <summary>
		/// 按 CashRate（字段） 查询
		/// </summary>
		/// /// <param name = "cashRate">今日本金比例，用户今日首次进入游戏的时候的本金*cashRate，会用来计算第一次预期值</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByCashRate(double cashRate)
		{
			return GetByCashRate(cashRate, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByCashRateAsync(double cashRate)
		{
			return await GetByCashRateAsync(cashRate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashRate（字段） 查询
		/// </summary>
		/// /// <param name = "cashRate">今日本金比例，用户今日首次进入游戏的时候的本金*cashRate，会用来计算第一次预期值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByCashRate(double cashRate, TransactionManager tm_)
		{
			return GetByCashRate(cashRate, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByCashRateAsync(double cashRate, TransactionManager tm_)
		{
			return await GetByCashRateAsync(cashRate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashRate（字段） 查询
		/// </summary>
		/// /// <param name = "cashRate">今日本金比例，用户今日首次进入游戏的时候的本金*cashRate，会用来计算第一次预期值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByCashRate(double cashRate, int top_)
		{
			return GetByCashRate(cashRate, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByCashRateAsync(double cashRate, int top_)
		{
			return await GetByCashRateAsync(cashRate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashRate（字段） 查询
		/// </summary>
		/// /// <param name = "cashRate">今日本金比例，用户今日首次进入游戏的时候的本金*cashRate，会用来计算第一次预期值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByCashRate(double cashRate, int top_, TransactionManager tm_)
		{
			return GetByCashRate(cashRate, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByCashRateAsync(double cashRate, int top_, TransactionManager tm_)
		{
			return await GetByCashRateAsync(cashRate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashRate（字段） 查询
		/// </summary>
		/// /// <param name = "cashRate">今日本金比例，用户今日首次进入游戏的时候的本金*cashRate，会用来计算第一次预期值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByCashRate(double cashRate, string sort_)
		{
			return GetByCashRate(cashRate, 0, sort_, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByCashRateAsync(double cashRate, string sort_)
		{
			return await GetByCashRateAsync(cashRate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashRate（字段） 查询
		/// </summary>
		/// /// <param name = "cashRate">今日本金比例，用户今日首次进入游戏的时候的本金*cashRate，会用来计算第一次预期值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByCashRate(double cashRate, string sort_, TransactionManager tm_)
		{
			return GetByCashRate(cashRate, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByCashRateAsync(double cashRate, string sort_, TransactionManager tm_)
		{
			return await GetByCashRateAsync(cashRate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashRate（字段） 查询
		/// </summary>
		/// /// <param name = "cashRate">今日本金比例，用户今日首次进入游戏的时候的本金*cashRate，会用来计算第一次预期值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByCashRate(double cashRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashRate` = @CashRate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashRate", cashRate, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_lvEO.MapDataReader);
		}
		public async Task<List<Slot_config_lvEO>> GetByCashRateAsync(double cashRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashRate` = @CashRate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashRate", cashRate, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_lvEO.MapDataReader);
		}
		#endregion // GetByCashRate
		#region GetByLastLossRate
		
		/// <summary>
		/// 按 LastLossRate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLossRate">昨日亏损比例，用户上一次游戏的那一天亏损的比例，会用来计算预期值，如果用户上一次游戏的那一天在3天之前，就不考虑之前的亏损了</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByLastLossRate(double lastLossRate)
		{
			return GetByLastLossRate(lastLossRate, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByLastLossRateAsync(double lastLossRate)
		{
			return await GetByLastLossRateAsync(lastLossRate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastLossRate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLossRate">昨日亏损比例，用户上一次游戏的那一天亏损的比例，会用来计算预期值，如果用户上一次游戏的那一天在3天之前，就不考虑之前的亏损了</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByLastLossRate(double lastLossRate, TransactionManager tm_)
		{
			return GetByLastLossRate(lastLossRate, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByLastLossRateAsync(double lastLossRate, TransactionManager tm_)
		{
			return await GetByLastLossRateAsync(lastLossRate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastLossRate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLossRate">昨日亏损比例，用户上一次游戏的那一天亏损的比例，会用来计算预期值，如果用户上一次游戏的那一天在3天之前，就不考虑之前的亏损了</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByLastLossRate(double lastLossRate, int top_)
		{
			return GetByLastLossRate(lastLossRate, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByLastLossRateAsync(double lastLossRate, int top_)
		{
			return await GetByLastLossRateAsync(lastLossRate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastLossRate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLossRate">昨日亏损比例，用户上一次游戏的那一天亏损的比例，会用来计算预期值，如果用户上一次游戏的那一天在3天之前，就不考虑之前的亏损了</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByLastLossRate(double lastLossRate, int top_, TransactionManager tm_)
		{
			return GetByLastLossRate(lastLossRate, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByLastLossRateAsync(double lastLossRate, int top_, TransactionManager tm_)
		{
			return await GetByLastLossRateAsync(lastLossRate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastLossRate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLossRate">昨日亏损比例，用户上一次游戏的那一天亏损的比例，会用来计算预期值，如果用户上一次游戏的那一天在3天之前，就不考虑之前的亏损了</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByLastLossRate(double lastLossRate, string sort_)
		{
			return GetByLastLossRate(lastLossRate, 0, sort_, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByLastLossRateAsync(double lastLossRate, string sort_)
		{
			return await GetByLastLossRateAsync(lastLossRate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LastLossRate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLossRate">昨日亏损比例，用户上一次游戏的那一天亏损的比例，会用来计算预期值，如果用户上一次游戏的那一天在3天之前，就不考虑之前的亏损了</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByLastLossRate(double lastLossRate, string sort_, TransactionManager tm_)
		{
			return GetByLastLossRate(lastLossRate, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByLastLossRateAsync(double lastLossRate, string sort_, TransactionManager tm_)
		{
			return await GetByLastLossRateAsync(lastLossRate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LastLossRate（字段） 查询
		/// </summary>
		/// /// <param name = "lastLossRate">昨日亏损比例，用户上一次游戏的那一天亏损的比例，会用来计算预期值，如果用户上一次游戏的那一天在3天之前，就不考虑之前的亏损了</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByLastLossRate(double lastLossRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LastLossRate` = @LastLossRate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastLossRate", lastLossRate, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_lvEO.MapDataReader);
		}
		public async Task<List<Slot_config_lvEO>> GetByLastLossRateAsync(double lastLossRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LastLossRate` = @LastLossRate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastLossRate", lastLossRate, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_lvEO.MapDataReader);
		}
		#endregion // GetByLastLossRate
		#region GetByLossRate
		
		/// <summary>
		/// 按 LossRate（字段） 查询
		/// </summary>
		/// /// <param name = "lossRate">预期值当日亏损率，round触发输返工具时筛选的2个条件之一，如果1-（余额/预期）亏损超过lossRate，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByLossRate(double lossRate)
		{
			return GetByLossRate(lossRate, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByLossRateAsync(double lossRate)
		{
			return await GetByLossRateAsync(lossRate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LossRate（字段） 查询
		/// </summary>
		/// /// <param name = "lossRate">预期值当日亏损率，round触发输返工具时筛选的2个条件之一，如果1-（余额/预期）亏损超过lossRate，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByLossRate(double lossRate, TransactionManager tm_)
		{
			return GetByLossRate(lossRate, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByLossRateAsync(double lossRate, TransactionManager tm_)
		{
			return await GetByLossRateAsync(lossRate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LossRate（字段） 查询
		/// </summary>
		/// /// <param name = "lossRate">预期值当日亏损率，round触发输返工具时筛选的2个条件之一，如果1-（余额/预期）亏损超过lossRate，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByLossRate(double lossRate, int top_)
		{
			return GetByLossRate(lossRate, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByLossRateAsync(double lossRate, int top_)
		{
			return await GetByLossRateAsync(lossRate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LossRate（字段） 查询
		/// </summary>
		/// /// <param name = "lossRate">预期值当日亏损率，round触发输返工具时筛选的2个条件之一，如果1-（余额/预期）亏损超过lossRate，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByLossRate(double lossRate, int top_, TransactionManager tm_)
		{
			return GetByLossRate(lossRate, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByLossRateAsync(double lossRate, int top_, TransactionManager tm_)
		{
			return await GetByLossRateAsync(lossRate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LossRate（字段） 查询
		/// </summary>
		/// /// <param name = "lossRate">预期值当日亏损率，round触发输返工具时筛选的2个条件之一，如果1-（余额/预期）亏损超过lossRate，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByLossRate(double lossRate, string sort_)
		{
			return GetByLossRate(lossRate, 0, sort_, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByLossRateAsync(double lossRate, string sort_)
		{
			return await GetByLossRateAsync(lossRate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LossRate（字段） 查询
		/// </summary>
		/// /// <param name = "lossRate">预期值当日亏损率，round触发输返工具时筛选的2个条件之一，如果1-（余额/预期）亏损超过lossRate，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByLossRate(double lossRate, string sort_, TransactionManager tm_)
		{
			return GetByLossRate(lossRate, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByLossRateAsync(double lossRate, string sort_, TransactionManager tm_)
		{
			return await GetByLossRateAsync(lossRate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LossRate（字段） 查询
		/// </summary>
		/// /// <param name = "lossRate">预期值当日亏损率，round触发输返工具时筛选的2个条件之一，如果1-（余额/预期）亏损超过lossRate，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByLossRate(double lossRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LossRate` = @LossRate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LossRate", lossRate, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_lvEO.MapDataReader);
		}
		public async Task<List<Slot_config_lvEO>> GetByLossRateAsync(double lossRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LossRate` = @LossRate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LossRate", lossRate, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_lvEO.MapDataReader);
		}
		#endregion // GetByLossRate
		#region GetByRTP
		
		/// <summary>
		/// 按 RTP（字段） 查询
		/// </summary>
		/// /// <param name = "rTP">返奖率，round触发输返工具时筛选的2个条件之一，如果当日在游戏中的TOTALREWARD/TOTALBET，小于这个配置的RTP，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByRTP(double rTP)
		{
			return GetByRTP(rTP, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByRTPAsync(double rTP)
		{
			return await GetByRTPAsync(rTP, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RTP（字段） 查询
		/// </summary>
		/// /// <param name = "rTP">返奖率，round触发输返工具时筛选的2个条件之一，如果当日在游戏中的TOTALREWARD/TOTALBET，小于这个配置的RTP，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByRTP(double rTP, TransactionManager tm_)
		{
			return GetByRTP(rTP, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByRTPAsync(double rTP, TransactionManager tm_)
		{
			return await GetByRTPAsync(rTP, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RTP（字段） 查询
		/// </summary>
		/// /// <param name = "rTP">返奖率，round触发输返工具时筛选的2个条件之一，如果当日在游戏中的TOTALREWARD/TOTALBET，小于这个配置的RTP，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByRTP(double rTP, int top_)
		{
			return GetByRTP(rTP, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByRTPAsync(double rTP, int top_)
		{
			return await GetByRTPAsync(rTP, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RTP（字段） 查询
		/// </summary>
		/// /// <param name = "rTP">返奖率，round触发输返工具时筛选的2个条件之一，如果当日在游戏中的TOTALREWARD/TOTALBET，小于这个配置的RTP，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByRTP(double rTP, int top_, TransactionManager tm_)
		{
			return GetByRTP(rTP, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByRTPAsync(double rTP, int top_, TransactionManager tm_)
		{
			return await GetByRTPAsync(rTP, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RTP（字段） 查询
		/// </summary>
		/// /// <param name = "rTP">返奖率，round触发输返工具时筛选的2个条件之一，如果当日在游戏中的TOTALREWARD/TOTALBET，小于这个配置的RTP，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByRTP(double rTP, string sort_)
		{
			return GetByRTP(rTP, 0, sort_, null);
		}
		public async Task<List<Slot_config_lvEO>> GetByRTPAsync(double rTP, string sort_)
		{
			return await GetByRTPAsync(rTP, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RTP（字段） 查询
		/// </summary>
		/// /// <param name = "rTP">返奖率，round触发输返工具时筛选的2个条件之一，如果当日在游戏中的TOTALREWARD/TOTALBET，小于这个配置的RTP，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByRTP(double rTP, string sort_, TransactionManager tm_)
		{
			return GetByRTP(rTP, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_lvEO>> GetByRTPAsync(double rTP, string sort_, TransactionManager tm_)
		{
			return await GetByRTPAsync(rTP, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RTP（字段） 查询
		/// </summary>
		/// /// <param name = "rTP">返奖率，round触发输返工具时筛选的2个条件之一，如果当日在游戏中的TOTALREWARD/TOTALBET，小于这个配置的RTP，则会触发输返工具，2个条件满足1个和2个都是一样的触发效果</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lvEO> GetByRTP(double rTP, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RTP` = @RTP", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RTP", rTP, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_lvEO.MapDataReader);
		}
		public async Task<List<Slot_config_lvEO>> GetByRTPAsync(double rTP, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RTP` = @RTP", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RTP", rTP, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_lvEO.MapDataReader);
		}
		#endregion // GetByRTP
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
