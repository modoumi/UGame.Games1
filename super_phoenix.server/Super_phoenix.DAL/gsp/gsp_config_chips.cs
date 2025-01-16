/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-14 21: 25:31
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
	/// 下注筹码表
	/// 【表 gsp_config_chips 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Gsp_config_chipsEO : IRowMapper<Gsp_config_chipsEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Gsp_config_chipsEO()
		{
			this.BetAmount = 0;
			this.SingleAmount = 0;
			this.LineNum = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalChipsID;
		/// <summary>
		/// 【数据库中的原始主键 ChipsID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalChipsID
		{
			get { return _originalChipsID; }
			set { HasOriginal = true; _originalChipsID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ChipsID", ChipsID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 筹码编码
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int ChipsID { get; set; }
		/// <summary>
		/// 下注金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 2)]
		public long BetAmount { get; set; }
		/// <summary>
		/// 单线下注金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 3)]
		public long SingleAmount { get; set; }
		/// <summary>
		/// 线数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int LineNum { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Gsp_config_chipsEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Gsp_config_chipsEO MapDataReader(IDataReader reader)
		{
		    Gsp_config_chipsEO ret = new Gsp_config_chipsEO();
			ret.ChipsID = reader.ToInt32("ChipsID");
			ret.OriginalChipsID = ret.ChipsID;
			ret.BetAmount = reader.ToInt64("BetAmount");
			ret.SingleAmount = reader.ToInt64("SingleAmount");
			ret.LineNum = reader.ToInt32("LineNum");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 下注筹码表
	/// 【表 gsp_config_chips 的操作类】
	/// </summary>
	[Obsolete]
	public class Gsp_config_chipsMO : MySqlTableMO<Gsp_config_chipsEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`gsp_config_chips`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Gsp_config_chipsMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Gsp_config_chipsMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Gsp_config_chipsMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Gsp_config_chipsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Gsp_config_chipsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Gsp_config_chipsEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ChipsID`, `BetAmount`, `SingleAmount`, `LineNum`) VALUE (@ChipsID, @BetAmount, @SingleAmount, @LineNum);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@SingleAmount", item.SingleAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@LineNum", item.LineNum, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Gsp_config_chipsEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Gsp_config_chipsEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gsp_config_chipsEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ChipsID`, `BetAmount`, `SingleAmount`, `LineNum`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.ChipsID},{item.BetAmount},{item.SingleAmount},{item.LineNum}),");
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
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int chipsID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(chipsID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int chipsID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(chipsID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int chipsID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ChipsID` = @ChipsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Gsp_config_chipsEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ChipsID, tm_);
		}
		public async Task<int> RemoveAsync(Gsp_config_chipsEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ChipsID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByBetAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
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
		#region RemoveBySingleAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "singleAmount">单线下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySingleAmount(long singleAmount, TransactionManager tm_ = null)
		{
			RepairRemoveBySingleAmountData(singleAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySingleAmountAsync(long singleAmount, TransactionManager tm_ = null)
		{
			RepairRemoveBySingleAmountData(singleAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySingleAmountData(long singleAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SingleAmount` = @SingleAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SingleAmount", singleAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveBySingleAmount
		#region RemoveByLineNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lineNum">线数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLineNum(int lineNum, TransactionManager tm_ = null)
		{
			RepairRemoveByLineNumData(lineNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLineNumAsync(int lineNum, TransactionManager tm_ = null)
		{
			RepairRemoveByLineNumData(lineNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLineNumData(int lineNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LineNum` = @LineNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByLineNum
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
		public int Put(Gsp_config_chipsEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Gsp_config_chipsEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Gsp_config_chipsEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ChipsID` = @ChipsID, `BetAmount` = @BetAmount, `SingleAmount` = @SingleAmount, `LineNum` = @LineNum WHERE `ChipsID` = @ChipsID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@SingleAmount", item.SingleAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@LineNum", item.LineNum, MySqlDbType.Int32),
				Database.CreateInParameter("@ChipsID_Original", item.HasOriginal ? item.OriginalChipsID : item.ChipsID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Gsp_config_chipsEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Gsp_config_chipsEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int chipsID, string set_, params object[] values_)
		{
			return Put(set_, "`ChipsID` = @ChipsID", ConcatValues(values_, chipsID));
		}
		public async Task<int> PutByPKAsync(int chipsID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ChipsID` = @ChipsID", ConcatValues(values_, chipsID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int chipsID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ChipsID` = @ChipsID", tm_, ConcatValues(values_, chipsID));
		}
		public async Task<int> PutByPKAsync(int chipsID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ChipsID` = @ChipsID", tm_, ConcatValues(values_, chipsID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int chipsID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
	        };
			return Put(set_, "`ChipsID` = @ChipsID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int chipsID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`ChipsID` = @ChipsID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutBetAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// /// <param name = "betAmount">下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetAmountByPK(int chipsID, long betAmount, TransactionManager tm_ = null)
		{
			RepairPutBetAmountByPKData(chipsID, betAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetAmountByPKAsync(int chipsID, long betAmount, TransactionManager tm_ = null)
		{
			RepairPutBetAmountByPKData(chipsID, betAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetAmountByPKData(int chipsID, long betAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount  WHERE `ChipsID` = @ChipsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
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
		#region PutSingleAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// /// <param name = "singleAmount">单线下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSingleAmountByPK(int chipsID, long singleAmount, TransactionManager tm_ = null)
		{
			RepairPutSingleAmountByPKData(chipsID, singleAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSingleAmountByPKAsync(int chipsID, long singleAmount, TransactionManager tm_ = null)
		{
			RepairPutSingleAmountByPKData(chipsID, singleAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSingleAmountByPKData(int chipsID, long singleAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SingleAmount` = @SingleAmount  WHERE `ChipsID` = @ChipsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SingleAmount", singleAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "singleAmount">单线下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSingleAmount(long singleAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SingleAmount` = @SingleAmount";
			var parameter_ = Database.CreateInParameter("@SingleAmount", singleAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSingleAmountAsync(long singleAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SingleAmount` = @SingleAmount";
			var parameter_ = Database.CreateInParameter("@SingleAmount", singleAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSingleAmount
		#region PutLineNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// /// <param name = "lineNum">线数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLineNumByPK(int chipsID, int lineNum, TransactionManager tm_ = null)
		{
			RepairPutLineNumByPKData(chipsID, lineNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLineNumByPKAsync(int chipsID, int lineNum, TransactionManager tm_ = null)
		{
			RepairPutLineNumByPKData(chipsID, lineNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLineNumByPKData(int chipsID, int lineNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LineNum` = @LineNum  WHERE `ChipsID` = @ChipsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32),
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lineNum">线数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLineNum(int lineNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LineNum` = @LineNum";
			var parameter_ = Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLineNumAsync(int lineNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LineNum` = @LineNum";
			var parameter_ = Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLineNum
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Gsp_config_chipsEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ChipsID) == null)
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
		public async Task<bool> SetAsync(Gsp_config_chipsEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ChipsID) == null)
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
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Gsp_config_chipsEO GetByPK(int chipsID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(chipsID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Gsp_config_chipsEO.MapDataReader);
		}
		public async Task<Gsp_config_chipsEO> GetByPKAsync(int chipsID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(chipsID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gsp_config_chipsEO.MapDataReader);
		}
		private void RepairGetByPKData(int chipsID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 BetAmount（字段）
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetAmountByPK(int chipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
			return (long)GetScalar("`BetAmount`", "`ChipsID` = @ChipsID", paras_, tm_);
		}
		public async Task<long> GetBetAmountByPKAsync(int chipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`BetAmount`", "`ChipsID` = @ChipsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SingleAmount（字段）
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetSingleAmountByPK(int chipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
			return (long)GetScalar("`SingleAmount`", "`ChipsID` = @ChipsID", paras_, tm_);
		}
		public async Task<long> GetSingleAmountByPKAsync(int chipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`SingleAmount`", "`ChipsID` = @ChipsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LineNum（字段）
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLineNumByPK(int chipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`LineNum`", "`ChipsID` = @ChipsID", paras_, tm_);
		}
		public async Task<int> GetLineNumByPKAsync(int chipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`LineNum`", "`ChipsID` = @ChipsID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByBetAmount
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetByBetAmount(long betAmount)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, null);
		}
		public async Task<List<Gsp_config_chipsEO>> GetByBetAmountAsync(long betAmount)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetByBetAmount(long betAmount, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_chipsEO>> GetByBetAmountAsync(long betAmount, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetByBetAmount(long betAmount, int top_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, null);
		}
		public async Task<List<Gsp_config_chipsEO>> GetByBetAmountAsync(long betAmount, int top_)
		{
			return await GetByBetAmountAsync(betAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetByBetAmount(long betAmount, int top_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_chipsEO>> GetByBetAmountAsync(long betAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetByBetAmount(long betAmount, string sort_)
		{
			return GetByBetAmount(betAmount, 0, sort_, null);
		}
		public async Task<List<Gsp_config_chipsEO>> GetByBetAmountAsync(long betAmount, string sort_)
		{
			return await GetByBetAmountAsync(betAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetByBetAmount(long betAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, sort_, tm_);
		}
		public async Task<List<Gsp_config_chipsEO>> GetByBetAmountAsync(long betAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetByBetAmount(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_config_chipsEO.MapDataReader);
		}
		public async Task<List<Gsp_config_chipsEO>> GetByBetAmountAsync(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_config_chipsEO.MapDataReader);
		}
		#endregion // GetByBetAmount
		#region GetBySingleAmount
		
		/// <summary>
		/// 按 SingleAmount（字段） 查询
		/// </summary>
		/// /// <param name = "singleAmount">单线下注金额</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetBySingleAmount(long singleAmount)
		{
			return GetBySingleAmount(singleAmount, 0, string.Empty, null);
		}
		public async Task<List<Gsp_config_chipsEO>> GetBySingleAmountAsync(long singleAmount)
		{
			return await GetBySingleAmountAsync(singleAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SingleAmount（字段） 查询
		/// </summary>
		/// /// <param name = "singleAmount">单线下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetBySingleAmount(long singleAmount, TransactionManager tm_)
		{
			return GetBySingleAmount(singleAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_chipsEO>> GetBySingleAmountAsync(long singleAmount, TransactionManager tm_)
		{
			return await GetBySingleAmountAsync(singleAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SingleAmount（字段） 查询
		/// </summary>
		/// /// <param name = "singleAmount">单线下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetBySingleAmount(long singleAmount, int top_)
		{
			return GetBySingleAmount(singleAmount, top_, string.Empty, null);
		}
		public async Task<List<Gsp_config_chipsEO>> GetBySingleAmountAsync(long singleAmount, int top_)
		{
			return await GetBySingleAmountAsync(singleAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SingleAmount（字段） 查询
		/// </summary>
		/// /// <param name = "singleAmount">单线下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetBySingleAmount(long singleAmount, int top_, TransactionManager tm_)
		{
			return GetBySingleAmount(singleAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_chipsEO>> GetBySingleAmountAsync(long singleAmount, int top_, TransactionManager tm_)
		{
			return await GetBySingleAmountAsync(singleAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SingleAmount（字段） 查询
		/// </summary>
		/// /// <param name = "singleAmount">单线下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetBySingleAmount(long singleAmount, string sort_)
		{
			return GetBySingleAmount(singleAmount, 0, sort_, null);
		}
		public async Task<List<Gsp_config_chipsEO>> GetBySingleAmountAsync(long singleAmount, string sort_)
		{
			return await GetBySingleAmountAsync(singleAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SingleAmount（字段） 查询
		/// </summary>
		/// /// <param name = "singleAmount">单线下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetBySingleAmount(long singleAmount, string sort_, TransactionManager tm_)
		{
			return GetBySingleAmount(singleAmount, 0, sort_, tm_);
		}
		public async Task<List<Gsp_config_chipsEO>> GetBySingleAmountAsync(long singleAmount, string sort_, TransactionManager tm_)
		{
			return await GetBySingleAmountAsync(singleAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SingleAmount（字段） 查询
		/// </summary>
		/// /// <param name = "singleAmount">单线下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetBySingleAmount(long singleAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SingleAmount` = @SingleAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SingleAmount", singleAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_config_chipsEO.MapDataReader);
		}
		public async Task<List<Gsp_config_chipsEO>> GetBySingleAmountAsync(long singleAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SingleAmount` = @SingleAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SingleAmount", singleAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_config_chipsEO.MapDataReader);
		}
		#endregion // GetBySingleAmount
		#region GetByLineNum
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">线数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetByLineNum(int lineNum)
		{
			return GetByLineNum(lineNum, 0, string.Empty, null);
		}
		public async Task<List<Gsp_config_chipsEO>> GetByLineNumAsync(int lineNum)
		{
			return await GetByLineNumAsync(lineNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">线数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetByLineNum(int lineNum, TransactionManager tm_)
		{
			return GetByLineNum(lineNum, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_chipsEO>> GetByLineNumAsync(int lineNum, TransactionManager tm_)
		{
			return await GetByLineNumAsync(lineNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">线数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetByLineNum(int lineNum, int top_)
		{
			return GetByLineNum(lineNum, top_, string.Empty, null);
		}
		public async Task<List<Gsp_config_chipsEO>> GetByLineNumAsync(int lineNum, int top_)
		{
			return await GetByLineNumAsync(lineNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">线数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetByLineNum(int lineNum, int top_, TransactionManager tm_)
		{
			return GetByLineNum(lineNum, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_chipsEO>> GetByLineNumAsync(int lineNum, int top_, TransactionManager tm_)
		{
			return await GetByLineNumAsync(lineNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">线数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetByLineNum(int lineNum, string sort_)
		{
			return GetByLineNum(lineNum, 0, sort_, null);
		}
		public async Task<List<Gsp_config_chipsEO>> GetByLineNumAsync(int lineNum, string sort_)
		{
			return await GetByLineNumAsync(lineNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">线数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetByLineNum(int lineNum, string sort_, TransactionManager tm_)
		{
			return GetByLineNum(lineNum, 0, sort_, tm_);
		}
		public async Task<List<Gsp_config_chipsEO>> GetByLineNumAsync(int lineNum, string sort_, TransactionManager tm_)
		{
			return await GetByLineNumAsync(lineNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">线数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_chipsEO> GetByLineNum(int lineNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LineNum` = @LineNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_config_chipsEO.MapDataReader);
		}
		public async Task<List<Gsp_config_chipsEO>> GetByLineNumAsync(int lineNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LineNum` = @LineNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_config_chipsEO.MapDataReader);
		}
		#endregion // GetByLineNum
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
