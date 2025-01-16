/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2024-01-30 14: 40:30
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
	/// Atest用户标签配置
	/// 【表 big_config_tag 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Big_config_tagEO : IRowMapper<Big_config_tagEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Big_config_tagEO()
		{
			this.SpecialModeRatio = 0d;
			this.Weight_Free3 = "0";
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalBID;
		/// <summary>
		/// 【数据库中的原始主键 BID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalBID
		{
			get { return _originalBID; }
			set { HasOriginal = true; _originalBID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "BID", BID }, };
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
		public int BID { get; set; }
		/// <summary>
		/// 用户标签下注额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 2)]
		public long BetAmount { get; set; }
		/// <summary>
		/// 用户标签下注额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 3)]
		public long BetAmountEnd { get; set; }
		/// <summary>
		/// 特殊玩法进入概率
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 4)]
		public double SpecialModeRatio { get; set; }
		/// <summary>
		/// 主轴权重值
		/// 【字段 varchar(2000)】
		/// </summary>
		[DataMember(Order = 5)]
		public string Weight_Main { get; set; }
		/// <summary>
		/// 主轴权重值
		/// 【字段 varchar(2000)】
		/// </summary>
		[DataMember(Order = 6)]
		public string Weight_Main2 { get; set; }
		/// <summary>
		/// 小玩法轴1
		/// 【字段 varchar(2000)】
		/// </summary>
		[DataMember(Order = 7)]
		public string Weight_Free1 { get; set; }
		/// <summary>
		/// 备注
		/// 【字段 varchar(2000)】
		/// </summary>
		[DataMember(Order = 8)]
		public string Weight_Free3 { get; set; }
		/// <summary>
		/// 小玩法轴1
		/// 【字段 varchar(2000)】
		/// </summary>
		[DataMember(Order = 9)]
		public string Weight_Free2 { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Big_config_tagEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Big_config_tagEO MapDataReader(IDataReader reader)
		{
		    Big_config_tagEO ret = new Big_config_tagEO();
			ret.BID = reader.ToInt32("BID");
			ret.OriginalBID = ret.BID;
			ret.BetAmount = reader.ToInt64("BetAmount");
			ret.BetAmountEnd = reader.ToInt64("BetAmountEnd");
			ret.SpecialModeRatio = reader.ToDouble("SpecialModeRatio");
			ret.Weight_Main = reader.ToString("Weight_Main");
			ret.Weight_Main2 = reader.ToString("Weight_Main2");
			ret.Weight_Free1 = reader.ToString("Weight_Free1");
			ret.Weight_Free3 = reader.ToString("Weight_Free3");
			ret.Weight_Free2 = reader.ToString("Weight_Free2");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// Atest用户标签配置
	/// 【表 big_config_tag 的操作类】
	/// </summary>
	[Obsolete]
	public class Big_config_tagMO : MySqlTableMO<Big_config_tagEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`big_config_tag`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Big_config_tagMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Big_config_tagMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Big_config_tagMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Big_config_tagEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Big_config_tagEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Big_config_tagEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`BID`, `BetAmount`, `BetAmountEnd`, `SpecialModeRatio`, `Weight_Main`, `Weight_Main2`, `Weight_Free1`, `Weight_Free3`, `Weight_Free2`) VALUE (@BID, @BetAmount, @BetAmountEnd, @SpecialModeRatio, @Weight_Main, @Weight_Main2, @Weight_Free1, @Weight_Free3, @Weight_Free2);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", item.BID, MySqlDbType.Int32),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetAmountEnd", item.BetAmountEnd, MySqlDbType.Int64),
				Database.CreateInParameter("@SpecialModeRatio", item.SpecialModeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@Weight_Main", item.Weight_Main, MySqlDbType.VarChar),
				Database.CreateInParameter("@Weight_Main2", item.Weight_Main2, MySqlDbType.VarChar),
				Database.CreateInParameter("@Weight_Free1", item.Weight_Free1, MySqlDbType.VarChar),
				Database.CreateInParameter("@Weight_Free3", item.Weight_Free3, MySqlDbType.VarChar),
				Database.CreateInParameter("@Weight_Free2", item.Weight_Free2, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Big_config_tagEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Big_config_tagEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Big_config_tagEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`BID`, `BetAmount`, `BetAmountEnd`, `SpecialModeRatio`, `Weight_Main`, `Weight_Main2`, `Weight_Free1`, `Weight_Free3`, `Weight_Free2`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.BID},{item.BetAmount},{item.BetAmountEnd},{item.SpecialModeRatio},'{item.Weight_Main}','{item.Weight_Main2}','{item.Weight_Free1}','{item.Weight_Free3}','{item.Weight_Free2}'),");
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
		/// /// <param name = "bID"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int bID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(bID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int bID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(bID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int bID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BID` = @BID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Big_config_tagEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.BID, tm_);
		}
		public async Task<int> RemoveAsync(Big_config_tagEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.BID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByBetAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betAmount">用户标签下注额</param>
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
		#region RemoveByBetAmountEnd
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betAmountEnd">用户标签下注额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetAmountEnd(long betAmountEnd, TransactionManager tm_ = null)
		{
			RepairRemoveByBetAmountEndData(betAmountEnd, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetAmountEndAsync(long betAmountEnd, TransactionManager tm_ = null)
		{
			RepairRemoveByBetAmountEndData(betAmountEnd, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetAmountEndData(long betAmountEnd, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetAmountEnd` = @BetAmountEnd";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmountEnd", betAmountEnd, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetAmountEnd
		#region RemoveBySpecialModeRatio
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySpecialModeRatio(double specialModeRatio, TransactionManager tm_ = null)
		{
			RepairRemoveBySpecialModeRatioData(specialModeRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySpecialModeRatioAsync(double specialModeRatio, TransactionManager tm_ = null)
		{
			RepairRemoveBySpecialModeRatioData(specialModeRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySpecialModeRatioData(double specialModeRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SpecialModeRatio` = @SpecialModeRatio";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SpecialModeRatio", specialModeRatio, MySqlDbType.Double));
		}
		#endregion // RemoveBySpecialModeRatio
		#region RemoveByWeight_Main
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight_Main">主轴权重值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeight_Main(string weight_Main, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight_MainData(weight_Main, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeight_MainAsync(string weight_Main, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight_MainData(weight_Main, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeight_MainData(string weight_Main, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Weight_Main` = @Weight_Main";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Main", weight_Main, MySqlDbType.VarChar));
		}
		#endregion // RemoveByWeight_Main
		#region RemoveByWeight_Main2
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight_Main2">主轴权重值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeight_Main2(string weight_Main2, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight_Main2Data(weight_Main2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeight_Main2Async(string weight_Main2, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight_Main2Data(weight_Main2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeight_Main2Data(string weight_Main2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Weight_Main2` = @Weight_Main2";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Main2", weight_Main2, MySqlDbType.VarChar));
		}
		#endregion // RemoveByWeight_Main2
		#region RemoveByWeight_Free1
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight_Free1">小玩法轴1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeight_Free1(string weight_Free1, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight_Free1Data(weight_Free1, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeight_Free1Async(string weight_Free1, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight_Free1Data(weight_Free1, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeight_Free1Data(string weight_Free1, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Weight_Free1` = @Weight_Free1";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Free1", weight_Free1, MySqlDbType.VarChar));
		}
		#endregion // RemoveByWeight_Free1
		#region RemoveByWeight_Free3
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight_Free3">备注</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeight_Free3(string weight_Free3, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight_Free3Data(weight_Free3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeight_Free3Async(string weight_Free3, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight_Free3Data(weight_Free3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeight_Free3Data(string weight_Free3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Weight_Free3` = @Weight_Free3";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Free3", weight_Free3, MySqlDbType.VarChar));
		}
		#endregion // RemoveByWeight_Free3
		#region RemoveByWeight_Free2
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeight_Free2(string weight_Free2, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight_Free2Data(weight_Free2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeight_Free2Async(string weight_Free2, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight_Free2Data(weight_Free2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeight_Free2Data(string weight_Free2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Weight_Free2` = @Weight_Free2";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Free2", weight_Free2, MySqlDbType.VarChar));
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
		public int Put(Big_config_tagEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Big_config_tagEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Big_config_tagEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BID` = @BID, `BetAmount` = @BetAmount, `BetAmountEnd` = @BetAmountEnd, `SpecialModeRatio` = @SpecialModeRatio, `Weight_Main` = @Weight_Main, `Weight_Main2` = @Weight_Main2, `Weight_Free1` = @Weight_Free1, `Weight_Free3` = @Weight_Free3, `Weight_Free2` = @Weight_Free2 WHERE `BID` = @BID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", item.BID, MySqlDbType.Int32),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetAmountEnd", item.BetAmountEnd, MySqlDbType.Int64),
				Database.CreateInParameter("@SpecialModeRatio", item.SpecialModeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@Weight_Main", item.Weight_Main, MySqlDbType.VarChar),
				Database.CreateInParameter("@Weight_Main2", item.Weight_Main2, MySqlDbType.VarChar),
				Database.CreateInParameter("@Weight_Free1", item.Weight_Free1, MySqlDbType.VarChar),
				Database.CreateInParameter("@Weight_Free3", item.Weight_Free3, MySqlDbType.VarChar),
				Database.CreateInParameter("@Weight_Free2", item.Weight_Free2, MySqlDbType.VarChar),
				Database.CreateInParameter("@BID_Original", item.HasOriginal ? item.OriginalBID : item.BID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Big_config_tagEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Big_config_tagEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "bID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int bID, string set_, params object[] values_)
		{
			return Put(set_, "`BID` = @BID", ConcatValues(values_, bID));
		}
		public async Task<int> PutByPKAsync(int bID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`BID` = @BID", ConcatValues(values_, bID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "bID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int bID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`BID` = @BID", tm_, ConcatValues(values_, bID));
		}
		public async Task<int> PutByPKAsync(int bID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`BID` = @BID", tm_, ConcatValues(values_, bID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "bID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int bID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
	        };
			return Put(set_, "`BID` = @BID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int bID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`BID` = @BID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutBetAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bID"></param>
		/// /// <param name = "betAmount">用户标签下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetAmountByPK(int bID, long betAmount, TransactionManager tm_ = null)
		{
			RepairPutBetAmountByPKData(bID, betAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetAmountByPKAsync(int bID, long betAmount, TransactionManager tm_ = null)
		{
			RepairPutBetAmountByPKData(bID, betAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetAmountByPKData(int bID, long betAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount  WHERE `BID` = @BID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betAmount">用户标签下注额</param>
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
		#region PutBetAmountEnd
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bID"></param>
		/// /// <param name = "betAmountEnd">用户标签下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetAmountEndByPK(int bID, long betAmountEnd, TransactionManager tm_ = null)
		{
			RepairPutBetAmountEndByPKData(bID, betAmountEnd, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetAmountEndByPKAsync(int bID, long betAmountEnd, TransactionManager tm_ = null)
		{
			RepairPutBetAmountEndByPKData(bID, betAmountEnd, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetAmountEndByPKData(int bID, long betAmountEnd, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetAmountEnd` = @BetAmountEnd  WHERE `BID` = @BID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetAmountEnd", betAmountEnd, MySqlDbType.Int64),
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betAmountEnd">用户标签下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetAmountEnd(long betAmountEnd, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetAmountEnd` = @BetAmountEnd";
			var parameter_ = Database.CreateInParameter("@BetAmountEnd", betAmountEnd, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetAmountEndAsync(long betAmountEnd, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetAmountEnd` = @BetAmountEnd";
			var parameter_ = Database.CreateInParameter("@BetAmountEnd", betAmountEnd, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetAmountEnd
		#region PutSpecialModeRatio
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bID"></param>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSpecialModeRatioByPK(int bID, double specialModeRatio, TransactionManager tm_ = null)
		{
			RepairPutSpecialModeRatioByPKData(bID, specialModeRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSpecialModeRatioByPKAsync(int bID, double specialModeRatio, TransactionManager tm_ = null)
		{
			RepairPutSpecialModeRatioByPKData(bID, specialModeRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSpecialModeRatioByPKData(int bID, double specialModeRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SpecialModeRatio` = @SpecialModeRatio  WHERE `BID` = @BID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SpecialModeRatio", specialModeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSpecialModeRatio(double specialModeRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SpecialModeRatio` = @SpecialModeRatio";
			var parameter_ = Database.CreateInParameter("@SpecialModeRatio", specialModeRatio, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSpecialModeRatioAsync(double specialModeRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SpecialModeRatio` = @SpecialModeRatio";
			var parameter_ = Database.CreateInParameter("@SpecialModeRatio", specialModeRatio, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSpecialModeRatio
		#region PutWeight_Main
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bID"></param>
		/// /// <param name = "weight_Main">主轴权重值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight_MainByPK(int bID, string weight_Main, TransactionManager tm_ = null)
		{
			RepairPutWeight_MainByPKData(bID, weight_Main, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeight_MainByPKAsync(int bID, string weight_Main, TransactionManager tm_ = null)
		{
			RepairPutWeight_MainByPKData(bID, weight_Main, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeight_MainByPKData(int bID, string weight_Main, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight_Main` = @Weight_Main  WHERE `BID` = @BID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight_Main", weight_Main, MySqlDbType.VarChar),
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight_Main">主轴权重值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight_Main(string weight_Main, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight_Main` = @Weight_Main";
			var parameter_ = Database.CreateInParameter("@Weight_Main", weight_Main, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeight_MainAsync(string weight_Main, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight_Main` = @Weight_Main";
			var parameter_ = Database.CreateInParameter("@Weight_Main", weight_Main, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWeight_Main
		#region PutWeight_Main2
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bID"></param>
		/// /// <param name = "weight_Main2">主轴权重值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight_Main2ByPK(int bID, string weight_Main2, TransactionManager tm_ = null)
		{
			RepairPutWeight_Main2ByPKData(bID, weight_Main2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeight_Main2ByPKAsync(int bID, string weight_Main2, TransactionManager tm_ = null)
		{
			RepairPutWeight_Main2ByPKData(bID, weight_Main2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeight_Main2ByPKData(int bID, string weight_Main2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight_Main2` = @Weight_Main2  WHERE `BID` = @BID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight_Main2", weight_Main2, MySqlDbType.VarChar),
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight_Main2">主轴权重值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight_Main2(string weight_Main2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight_Main2` = @Weight_Main2";
			var parameter_ = Database.CreateInParameter("@Weight_Main2", weight_Main2, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeight_Main2Async(string weight_Main2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight_Main2` = @Weight_Main2";
			var parameter_ = Database.CreateInParameter("@Weight_Main2", weight_Main2, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWeight_Main2
		#region PutWeight_Free1
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bID"></param>
		/// /// <param name = "weight_Free1">小玩法轴1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight_Free1ByPK(int bID, string weight_Free1, TransactionManager tm_ = null)
		{
			RepairPutWeight_Free1ByPKData(bID, weight_Free1, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeight_Free1ByPKAsync(int bID, string weight_Free1, TransactionManager tm_ = null)
		{
			RepairPutWeight_Free1ByPKData(bID, weight_Free1, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeight_Free1ByPKData(int bID, string weight_Free1, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight_Free1` = @Weight_Free1  WHERE `BID` = @BID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight_Free1", weight_Free1, MySqlDbType.VarChar),
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight_Free1">小玩法轴1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight_Free1(string weight_Free1, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight_Free1` = @Weight_Free1";
			var parameter_ = Database.CreateInParameter("@Weight_Free1", weight_Free1, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeight_Free1Async(string weight_Free1, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight_Free1` = @Weight_Free1";
			var parameter_ = Database.CreateInParameter("@Weight_Free1", weight_Free1, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWeight_Free1
		#region PutWeight_Free3
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bID"></param>
		/// /// <param name = "weight_Free3">备注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight_Free3ByPK(int bID, string weight_Free3, TransactionManager tm_ = null)
		{
			RepairPutWeight_Free3ByPKData(bID, weight_Free3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeight_Free3ByPKAsync(int bID, string weight_Free3, TransactionManager tm_ = null)
		{
			RepairPutWeight_Free3ByPKData(bID, weight_Free3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeight_Free3ByPKData(int bID, string weight_Free3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight_Free3` = @Weight_Free3  WHERE `BID` = @BID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight_Free3", weight_Free3, MySqlDbType.VarChar),
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight_Free3">备注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight_Free3(string weight_Free3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight_Free3` = @Weight_Free3";
			var parameter_ = Database.CreateInParameter("@Weight_Free3", weight_Free3, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeight_Free3Async(string weight_Free3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight_Free3` = @Weight_Free3";
			var parameter_ = Database.CreateInParameter("@Weight_Free3", weight_Free3, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWeight_Free3
		#region PutWeight_Free2
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bID"></param>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight_Free2ByPK(int bID, string weight_Free2, TransactionManager tm_ = null)
		{
			RepairPutWeight_Free2ByPKData(bID, weight_Free2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeight_Free2ByPKAsync(int bID, string weight_Free2, TransactionManager tm_ = null)
		{
			RepairPutWeight_Free2ByPKData(bID, weight_Free2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeight_Free2ByPKData(int bID, string weight_Free2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight_Free2` = @Weight_Free2  WHERE `BID` = @BID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight_Free2", weight_Free2, MySqlDbType.VarChar),
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight_Free2(string weight_Free2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight_Free2` = @Weight_Free2";
			var parameter_ = Database.CreateInParameter("@Weight_Free2", weight_Free2, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeight_Free2Async(string weight_Free2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight_Free2` = @Weight_Free2";
			var parameter_ = Database.CreateInParameter("@Weight_Free2", weight_Free2, MySqlDbType.VarChar);
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
		public bool Set(Big_config_tagEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.BID) == null)
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
		public async Task<bool> SetAsync(Big_config_tagEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.BID) == null)
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
		/// /// <param name = "bID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Big_config_tagEO GetByPK(int bID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(bID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		public async Task<Big_config_tagEO> GetByPKAsync(int bID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(bID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		private void RepairGetByPKData(int bID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`BID` = @BID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 BetAmount（字段）
		/// </summary>
		/// /// <param name = "bID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetAmountByPK(int bID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
			return (long)GetScalar("`BetAmount`", "`BID` = @BID", paras_, tm_);
		}
		public async Task<long> GetBetAmountByPKAsync(int bID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`BetAmount`", "`BID` = @BID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetAmountEnd（字段）
		/// </summary>
		/// /// <param name = "bID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetAmountEndByPK(int bID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
			return (long)GetScalar("`BetAmountEnd`", "`BID` = @BID", paras_, tm_);
		}
		public async Task<long> GetBetAmountEndByPKAsync(int bID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`BetAmountEnd`", "`BID` = @BID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SpecialModeRatio（字段）
		/// </summary>
		/// /// <param name = "bID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetSpecialModeRatioByPK(int bID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
			return (double)GetScalar("`SpecialModeRatio`", "`BID` = @BID", paras_, tm_);
		}
		public async Task<double> GetSpecialModeRatioByPKAsync(int bID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
			return (double)await GetScalarAsync("`SpecialModeRatio`", "`BID` = @BID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight_Main（字段）
		/// </summary>
		/// /// <param name = "bID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetWeight_MainByPK(int bID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`Weight_Main`", "`BID` = @BID", paras_, tm_);
		}
		public async Task<string> GetWeight_MainByPKAsync(int bID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`Weight_Main`", "`BID` = @BID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight_Main2（字段）
		/// </summary>
		/// /// <param name = "bID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetWeight_Main2ByPK(int bID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`Weight_Main2`", "`BID` = @BID", paras_, tm_);
		}
		public async Task<string> GetWeight_Main2ByPKAsync(int bID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`Weight_Main2`", "`BID` = @BID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight_Free1（字段）
		/// </summary>
		/// /// <param name = "bID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetWeight_Free1ByPK(int bID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`Weight_Free1`", "`BID` = @BID", paras_, tm_);
		}
		public async Task<string> GetWeight_Free1ByPKAsync(int bID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`Weight_Free1`", "`BID` = @BID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight_Free3（字段）
		/// </summary>
		/// /// <param name = "bID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetWeight_Free3ByPK(int bID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`Weight_Free3`", "`BID` = @BID", paras_, tm_);
		}
		public async Task<string> GetWeight_Free3ByPKAsync(int bID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`Weight_Free3`", "`BID` = @BID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight_Free2（字段）
		/// </summary>
		/// /// <param name = "bID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetWeight_Free2ByPK(int bID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`Weight_Free2`", "`BID` = @BID", paras_, tm_);
		}
		public async Task<string> GetWeight_Free2ByPKAsync(int bID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BID", bID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`Weight_Free2`", "`BID` = @BID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByBetAmount
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">用户标签下注额</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByBetAmount(long betAmount)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, null);
		}
		public async Task<List<Big_config_tagEO>> GetByBetAmountAsync(long betAmount)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">用户标签下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByBetAmount(long betAmount, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByBetAmountAsync(long betAmount, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">用户标签下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByBetAmount(long betAmount, int top_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, null);
		}
		public async Task<List<Big_config_tagEO>> GetByBetAmountAsync(long betAmount, int top_)
		{
			return await GetByBetAmountAsync(betAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">用户标签下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByBetAmount(long betAmount, int top_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByBetAmountAsync(long betAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">用户标签下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByBetAmount(long betAmount, string sort_)
		{
			return GetByBetAmount(betAmount, 0, sort_, null);
		}
		public async Task<List<Big_config_tagEO>> GetByBetAmountAsync(long betAmount, string sort_)
		{
			return await GetByBetAmountAsync(betAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">用户标签下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByBetAmount(long betAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, sort_, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByBetAmountAsync(long betAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">用户标签下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByBetAmount(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		public async Task<List<Big_config_tagEO>> GetByBetAmountAsync(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		#endregion // GetByBetAmount
		#region GetByBetAmountEnd
		
		/// <summary>
		/// 按 BetAmountEnd（字段） 查询
		/// </summary>
		/// /// <param name = "betAmountEnd">用户标签下注额</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByBetAmountEnd(long betAmountEnd)
		{
			return GetByBetAmountEnd(betAmountEnd, 0, string.Empty, null);
		}
		public async Task<List<Big_config_tagEO>> GetByBetAmountEndAsync(long betAmountEnd)
		{
			return await GetByBetAmountEndAsync(betAmountEnd, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmountEnd（字段） 查询
		/// </summary>
		/// /// <param name = "betAmountEnd">用户标签下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByBetAmountEnd(long betAmountEnd, TransactionManager tm_)
		{
			return GetByBetAmountEnd(betAmountEnd, 0, string.Empty, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByBetAmountEndAsync(long betAmountEnd, TransactionManager tm_)
		{
			return await GetByBetAmountEndAsync(betAmountEnd, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmountEnd（字段） 查询
		/// </summary>
		/// /// <param name = "betAmountEnd">用户标签下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByBetAmountEnd(long betAmountEnd, int top_)
		{
			return GetByBetAmountEnd(betAmountEnd, top_, string.Empty, null);
		}
		public async Task<List<Big_config_tagEO>> GetByBetAmountEndAsync(long betAmountEnd, int top_)
		{
			return await GetByBetAmountEndAsync(betAmountEnd, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmountEnd（字段） 查询
		/// </summary>
		/// /// <param name = "betAmountEnd">用户标签下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByBetAmountEnd(long betAmountEnd, int top_, TransactionManager tm_)
		{
			return GetByBetAmountEnd(betAmountEnd, top_, string.Empty, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByBetAmountEndAsync(long betAmountEnd, int top_, TransactionManager tm_)
		{
			return await GetByBetAmountEndAsync(betAmountEnd, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmountEnd（字段） 查询
		/// </summary>
		/// /// <param name = "betAmountEnd">用户标签下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByBetAmountEnd(long betAmountEnd, string sort_)
		{
			return GetByBetAmountEnd(betAmountEnd, 0, sort_, null);
		}
		public async Task<List<Big_config_tagEO>> GetByBetAmountEndAsync(long betAmountEnd, string sort_)
		{
			return await GetByBetAmountEndAsync(betAmountEnd, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetAmountEnd（字段） 查询
		/// </summary>
		/// /// <param name = "betAmountEnd">用户标签下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByBetAmountEnd(long betAmountEnd, string sort_, TransactionManager tm_)
		{
			return GetByBetAmountEnd(betAmountEnd, 0, sort_, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByBetAmountEndAsync(long betAmountEnd, string sort_, TransactionManager tm_)
		{
			return await GetByBetAmountEndAsync(betAmountEnd, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetAmountEnd（字段） 查询
		/// </summary>
		/// /// <param name = "betAmountEnd">用户标签下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByBetAmountEnd(long betAmountEnd, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmountEnd` = @BetAmountEnd", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmountEnd", betAmountEnd, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		public async Task<List<Big_config_tagEO>> GetByBetAmountEndAsync(long betAmountEnd, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmountEnd` = @BetAmountEnd", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmountEnd", betAmountEnd, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		#endregion // GetByBetAmountEnd
		#region GetBySpecialModeRatio
		
		/// <summary>
		/// 按 SpecialModeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetBySpecialModeRatio(double specialModeRatio)
		{
			return GetBySpecialModeRatio(specialModeRatio, 0, string.Empty, null);
		}
		public async Task<List<Big_config_tagEO>> GetBySpecialModeRatioAsync(double specialModeRatio)
		{
			return await GetBySpecialModeRatioAsync(specialModeRatio, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SpecialModeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetBySpecialModeRatio(double specialModeRatio, TransactionManager tm_)
		{
			return GetBySpecialModeRatio(specialModeRatio, 0, string.Empty, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetBySpecialModeRatioAsync(double specialModeRatio, TransactionManager tm_)
		{
			return await GetBySpecialModeRatioAsync(specialModeRatio, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SpecialModeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetBySpecialModeRatio(double specialModeRatio, int top_)
		{
			return GetBySpecialModeRatio(specialModeRatio, top_, string.Empty, null);
		}
		public async Task<List<Big_config_tagEO>> GetBySpecialModeRatioAsync(double specialModeRatio, int top_)
		{
			return await GetBySpecialModeRatioAsync(specialModeRatio, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SpecialModeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetBySpecialModeRatio(double specialModeRatio, int top_, TransactionManager tm_)
		{
			return GetBySpecialModeRatio(specialModeRatio, top_, string.Empty, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetBySpecialModeRatioAsync(double specialModeRatio, int top_, TransactionManager tm_)
		{
			return await GetBySpecialModeRatioAsync(specialModeRatio, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SpecialModeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetBySpecialModeRatio(double specialModeRatio, string sort_)
		{
			return GetBySpecialModeRatio(specialModeRatio, 0, sort_, null);
		}
		public async Task<List<Big_config_tagEO>> GetBySpecialModeRatioAsync(double specialModeRatio, string sort_)
		{
			return await GetBySpecialModeRatioAsync(specialModeRatio, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SpecialModeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetBySpecialModeRatio(double specialModeRatio, string sort_, TransactionManager tm_)
		{
			return GetBySpecialModeRatio(specialModeRatio, 0, sort_, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetBySpecialModeRatioAsync(double specialModeRatio, string sort_, TransactionManager tm_)
		{
			return await GetBySpecialModeRatioAsync(specialModeRatio, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SpecialModeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetBySpecialModeRatio(double specialModeRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SpecialModeRatio` = @SpecialModeRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SpecialModeRatio", specialModeRatio, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		public async Task<List<Big_config_tagEO>> GetBySpecialModeRatioAsync(double specialModeRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SpecialModeRatio` = @SpecialModeRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SpecialModeRatio", specialModeRatio, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		#endregion // GetBySpecialModeRatio
		#region GetByWeight_Main
		
		/// <summary>
		/// 按 Weight_Main（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main">主轴权重值</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Main(string weight_Main)
		{
			return GetByWeight_Main(weight_Main, 0, string.Empty, null);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_MainAsync(string weight_Main)
		{
			return await GetByWeight_MainAsync(weight_Main, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight_Main（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main">主轴权重值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Main(string weight_Main, TransactionManager tm_)
		{
			return GetByWeight_Main(weight_Main, 0, string.Empty, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_MainAsync(string weight_Main, TransactionManager tm_)
		{
			return await GetByWeight_MainAsync(weight_Main, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Main（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main">主轴权重值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Main(string weight_Main, int top_)
		{
			return GetByWeight_Main(weight_Main, top_, string.Empty, null);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_MainAsync(string weight_Main, int top_)
		{
			return await GetByWeight_MainAsync(weight_Main, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight_Main（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main">主轴权重值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Main(string weight_Main, int top_, TransactionManager tm_)
		{
			return GetByWeight_Main(weight_Main, top_, string.Empty, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_MainAsync(string weight_Main, int top_, TransactionManager tm_)
		{
			return await GetByWeight_MainAsync(weight_Main, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Main（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main">主轴权重值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Main(string weight_Main, string sort_)
		{
			return GetByWeight_Main(weight_Main, 0, sort_, null);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_MainAsync(string weight_Main, string sort_)
		{
			return await GetByWeight_MainAsync(weight_Main, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Weight_Main（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main">主轴权重值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Main(string weight_Main, string sort_, TransactionManager tm_)
		{
			return GetByWeight_Main(weight_Main, 0, sort_, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_MainAsync(string weight_Main, string sort_, TransactionManager tm_)
		{
			return await GetByWeight_MainAsync(weight_Main, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Main（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main">主轴权重值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Main(string weight_Main, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight_Main` = @Weight_Main", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Main", weight_Main, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_MainAsync(string weight_Main, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight_Main` = @Weight_Main", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Main", weight_Main, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		#endregion // GetByWeight_Main
		#region GetByWeight_Main2
		
		/// <summary>
		/// 按 Weight_Main2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main2">主轴权重值</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Main2(string weight_Main2)
		{
			return GetByWeight_Main2(weight_Main2, 0, string.Empty, null);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Main2Async(string weight_Main2)
		{
			return await GetByWeight_Main2Async(weight_Main2, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight_Main2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main2">主轴权重值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Main2(string weight_Main2, TransactionManager tm_)
		{
			return GetByWeight_Main2(weight_Main2, 0, string.Empty, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Main2Async(string weight_Main2, TransactionManager tm_)
		{
			return await GetByWeight_Main2Async(weight_Main2, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Main2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main2">主轴权重值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Main2(string weight_Main2, int top_)
		{
			return GetByWeight_Main2(weight_Main2, top_, string.Empty, null);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Main2Async(string weight_Main2, int top_)
		{
			return await GetByWeight_Main2Async(weight_Main2, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight_Main2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main2">主轴权重值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Main2(string weight_Main2, int top_, TransactionManager tm_)
		{
			return GetByWeight_Main2(weight_Main2, top_, string.Empty, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Main2Async(string weight_Main2, int top_, TransactionManager tm_)
		{
			return await GetByWeight_Main2Async(weight_Main2, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Main2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main2">主轴权重值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Main2(string weight_Main2, string sort_)
		{
			return GetByWeight_Main2(weight_Main2, 0, sort_, null);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Main2Async(string weight_Main2, string sort_)
		{
			return await GetByWeight_Main2Async(weight_Main2, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Weight_Main2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main2">主轴权重值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Main2(string weight_Main2, string sort_, TransactionManager tm_)
		{
			return GetByWeight_Main2(weight_Main2, 0, sort_, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Main2Async(string weight_Main2, string sort_, TransactionManager tm_)
		{
			return await GetByWeight_Main2Async(weight_Main2, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Main2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main2">主轴权重值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Main2(string weight_Main2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight_Main2` = @Weight_Main2", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Main2", weight_Main2, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Main2Async(string weight_Main2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight_Main2` = @Weight_Main2", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Main2", weight_Main2, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		#endregion // GetByWeight_Main2
		#region GetByWeight_Free1
		
		/// <summary>
		/// 按 Weight_Free1（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free1">小玩法轴1</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free1(string weight_Free1)
		{
			return GetByWeight_Free1(weight_Free1, 0, string.Empty, null);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free1Async(string weight_Free1)
		{
			return await GetByWeight_Free1Async(weight_Free1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight_Free1（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free1">小玩法轴1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free1(string weight_Free1, TransactionManager tm_)
		{
			return GetByWeight_Free1(weight_Free1, 0, string.Empty, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free1Async(string weight_Free1, TransactionManager tm_)
		{
			return await GetByWeight_Free1Async(weight_Free1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Free1（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free1">小玩法轴1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free1(string weight_Free1, int top_)
		{
			return GetByWeight_Free1(weight_Free1, top_, string.Empty, null);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free1Async(string weight_Free1, int top_)
		{
			return await GetByWeight_Free1Async(weight_Free1, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight_Free1（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free1">小玩法轴1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free1(string weight_Free1, int top_, TransactionManager tm_)
		{
			return GetByWeight_Free1(weight_Free1, top_, string.Empty, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free1Async(string weight_Free1, int top_, TransactionManager tm_)
		{
			return await GetByWeight_Free1Async(weight_Free1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Free1（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free1">小玩法轴1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free1(string weight_Free1, string sort_)
		{
			return GetByWeight_Free1(weight_Free1, 0, sort_, null);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free1Async(string weight_Free1, string sort_)
		{
			return await GetByWeight_Free1Async(weight_Free1, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Weight_Free1（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free1">小玩法轴1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free1(string weight_Free1, string sort_, TransactionManager tm_)
		{
			return GetByWeight_Free1(weight_Free1, 0, sort_, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free1Async(string weight_Free1, string sort_, TransactionManager tm_)
		{
			return await GetByWeight_Free1Async(weight_Free1, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Free1（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free1">小玩法轴1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free1(string weight_Free1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight_Free1` = @Weight_Free1", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Free1", weight_Free1, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free1Async(string weight_Free1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight_Free1` = @Weight_Free1", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Free1", weight_Free1, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		#endregion // GetByWeight_Free1
		#region GetByWeight_Free3
		
		/// <summary>
		/// 按 Weight_Free3（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free3">备注</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free3(string weight_Free3)
		{
			return GetByWeight_Free3(weight_Free3, 0, string.Empty, null);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free3Async(string weight_Free3)
		{
			return await GetByWeight_Free3Async(weight_Free3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight_Free3（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free3">备注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free3(string weight_Free3, TransactionManager tm_)
		{
			return GetByWeight_Free3(weight_Free3, 0, string.Empty, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free3Async(string weight_Free3, TransactionManager tm_)
		{
			return await GetByWeight_Free3Async(weight_Free3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Free3（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free3">备注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free3(string weight_Free3, int top_)
		{
			return GetByWeight_Free3(weight_Free3, top_, string.Empty, null);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free3Async(string weight_Free3, int top_)
		{
			return await GetByWeight_Free3Async(weight_Free3, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight_Free3（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free3">备注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free3(string weight_Free3, int top_, TransactionManager tm_)
		{
			return GetByWeight_Free3(weight_Free3, top_, string.Empty, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free3Async(string weight_Free3, int top_, TransactionManager tm_)
		{
			return await GetByWeight_Free3Async(weight_Free3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Free3（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free3">备注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free3(string weight_Free3, string sort_)
		{
			return GetByWeight_Free3(weight_Free3, 0, sort_, null);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free3Async(string weight_Free3, string sort_)
		{
			return await GetByWeight_Free3Async(weight_Free3, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Weight_Free3（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free3">备注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free3(string weight_Free3, string sort_, TransactionManager tm_)
		{
			return GetByWeight_Free3(weight_Free3, 0, sort_, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free3Async(string weight_Free3, string sort_, TransactionManager tm_)
		{
			return await GetByWeight_Free3Async(weight_Free3, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Free3（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free3">备注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free3(string weight_Free3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight_Free3` = @Weight_Free3", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Free3", weight_Free3, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free3Async(string weight_Free3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight_Free3` = @Weight_Free3", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Free3", weight_Free3, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		#endregion // GetByWeight_Free3
		#region GetByWeight_Free2
		
		/// <summary>
		/// 按 Weight_Free2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free2(string weight_Free2)
		{
			return GetByWeight_Free2(weight_Free2, 0, string.Empty, null);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free2Async(string weight_Free2)
		{
			return await GetByWeight_Free2Async(weight_Free2, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight_Free2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free2(string weight_Free2, TransactionManager tm_)
		{
			return GetByWeight_Free2(weight_Free2, 0, string.Empty, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free2Async(string weight_Free2, TransactionManager tm_)
		{
			return await GetByWeight_Free2Async(weight_Free2, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Free2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free2(string weight_Free2, int top_)
		{
			return GetByWeight_Free2(weight_Free2, top_, string.Empty, null);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free2Async(string weight_Free2, int top_)
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
		public List<Big_config_tagEO> GetByWeight_Free2(string weight_Free2, int top_, TransactionManager tm_)
		{
			return GetByWeight_Free2(weight_Free2, top_, string.Empty, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free2Async(string weight_Free2, int top_, TransactionManager tm_)
		{
			return await GetByWeight_Free2Async(weight_Free2, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Free2（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Free2">小玩法轴1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_config_tagEO> GetByWeight_Free2(string weight_Free2, string sort_)
		{
			return GetByWeight_Free2(weight_Free2, 0, sort_, null);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free2Async(string weight_Free2, string sort_)
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
		public List<Big_config_tagEO> GetByWeight_Free2(string weight_Free2, string sort_, TransactionManager tm_)
		{
			return GetByWeight_Free2(weight_Free2, 0, sort_, tm_);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free2Async(string weight_Free2, string sort_, TransactionManager tm_)
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
		public List<Big_config_tagEO> GetByWeight_Free2(string weight_Free2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight_Free2` = @Weight_Free2", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Free2", weight_Free2, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		public async Task<List<Big_config_tagEO>> GetByWeight_Free2Async(string weight_Free2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight_Free2` = @Weight_Free2", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Free2", weight_Free2, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_config_tagEO.MapDataReader);
		}
		#endregion // GetByWeight_Free2
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
