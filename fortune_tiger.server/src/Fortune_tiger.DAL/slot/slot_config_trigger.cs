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
	/// 【表 slot_config_trigger 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Slot_config_triggerEO : IRowMapper<Slot_config_triggerEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Slot_config_triggerEO()
		{
			this.TriggerRate = 0d;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalRound;
		/// <summary>
		/// 【数据库中的原始主键 Round 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalRound
		{
			get { return _originalRound; }
			set { HasOriginal = true; _originalRound = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "Round", Round }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 1-N，手数，在离开newRefundRound的限制之后，不断积累，每一次触发不管最后是否扣除次数真实发奖，都会将round重置下一次继续从1开始
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int Round { get; set; }
		/// <summary>
		/// 0-1，触发几率，1=100%触发，用户每一次游戏
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 2)]
		public double TriggerRate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Slot_config_triggerEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Slot_config_triggerEO MapDataReader(IDataReader reader)
		{
		    Slot_config_triggerEO ret = new Slot_config_triggerEO();
			ret.Round = reader.ToInt32("Round");
			ret.OriginalRound = ret.Round;
			ret.TriggerRate = reader.ToDouble("TriggerRate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// Atest用户标签配置
	/// 【表 slot_config_trigger 的操作类】
	/// </summary>
	[Obsolete]
	public class Slot_config_triggerMO : MySqlTableMO<Slot_config_triggerEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`slot_config_trigger`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Slot_config_triggerMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Slot_config_triggerMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Slot_config_triggerMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Slot_config_triggerEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Slot_config_triggerEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Slot_config_triggerEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`Round`, `TriggerRate`) VALUE (@Round, @TriggerRate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Round", item.Round, MySqlDbType.Int32),
				Database.CreateInParameter("@TriggerRate", item.TriggerRate, MySqlDbType.Double),
			};
		}
		public int AddByBatch(IEnumerable<Slot_config_triggerEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Slot_config_triggerEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Slot_config_triggerEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`Round`, `TriggerRate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.Round},{item.TriggerRate}),");
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
		/// /// <param name = "round">1-N，手数，在离开newRefundRound的限制之后，不断积累，每一次触发不管最后是否扣除次数真实发奖，都会将round重置下一次继续从1开始</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int round, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(round, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int round, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(round, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int round, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Round` = @Round";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Round", round, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Slot_config_triggerEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.Round, tm_);
		}
		public async Task<int> RemoveAsync(Slot_config_triggerEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.Round, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByTriggerRate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "triggerRate">0-1，触发几率，1=100%触发，用户每一次游戏</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTriggerRate(double triggerRate, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerRateData(triggerRate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTriggerRateAsync(double triggerRate, TransactionManager tm_ = null)
		{
			RepairRemoveByTriggerRateData(triggerRate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTriggerRateData(double triggerRate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TriggerRate` = @TriggerRate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerRate", triggerRate, MySqlDbType.Double));
		}
		#endregion // RemoveByTriggerRate
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
		public int Put(Slot_config_triggerEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Slot_config_triggerEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Slot_config_triggerEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Round` = @Round, `TriggerRate` = @TriggerRate WHERE `Round` = @Round_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Round", item.Round, MySqlDbType.Int32),
				Database.CreateInParameter("@TriggerRate", item.TriggerRate, MySqlDbType.Double),
				Database.CreateInParameter("@Round_Original", item.HasOriginal ? item.OriginalRound : item.Round, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Slot_config_triggerEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Slot_config_triggerEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "round">1-N，手数，在离开newRefundRound的限制之后，不断积累，每一次触发不管最后是否扣除次数真实发奖，都会将round重置下一次继续从1开始</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int round, string set_, params object[] values_)
		{
			return Put(set_, "`Round` = @Round", ConcatValues(values_, round));
		}
		public async Task<int> PutByPKAsync(int round, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`Round` = @Round", ConcatValues(values_, round));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "round">1-N，手数，在离开newRefundRound的限制之后，不断积累，每一次触发不管最后是否扣除次数真实发奖，都会将round重置下一次继续从1开始</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int round, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`Round` = @Round", tm_, ConcatValues(values_, round));
		}
		public async Task<int> PutByPKAsync(int round, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`Round` = @Round", tm_, ConcatValues(values_, round));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "round">1-N，手数，在离开newRefundRound的限制之后，不断积累，每一次触发不管最后是否扣除次数真实发奖，都会将round重置下一次继续从1开始</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int round, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@Round", round, MySqlDbType.Int32),
	        };
			return Put(set_, "`Round` = @Round", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int round, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@Round", round, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`Round` = @Round", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutTriggerRate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "round">1-N，手数，在离开newRefundRound的限制之后，不断积累，每一次触发不管最后是否扣除次数真实发奖，都会将round重置下一次继续从1开始</param>
		/// /// <param name = "triggerRate">0-1，触发几率，1=100%触发，用户每一次游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerRateByPK(int round, double triggerRate, TransactionManager tm_ = null)
		{
			RepairPutTriggerRateByPKData(round, triggerRate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTriggerRateByPKAsync(int round, double triggerRate, TransactionManager tm_ = null)
		{
			RepairPutTriggerRateByPKData(round, triggerRate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTriggerRateByPKData(int round, double triggerRate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TriggerRate` = @TriggerRate  WHERE `Round` = @Round";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TriggerRate", triggerRate, MySqlDbType.Double),
				Database.CreateInParameter("@Round", round, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "triggerRate">0-1，触发几率，1=100%触发，用户每一次游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTriggerRate(double triggerRate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerRate` = @TriggerRate";
			var parameter_ = Database.CreateInParameter("@TriggerRate", triggerRate, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTriggerRateAsync(double triggerRate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TriggerRate` = @TriggerRate";
			var parameter_ = Database.CreateInParameter("@TriggerRate", triggerRate, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTriggerRate
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Slot_config_triggerEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.Round) == null)
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
		public async Task<bool> SetAsync(Slot_config_triggerEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.Round) == null)
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
		/// /// <param name = "round">1-N，手数，在离开newRefundRound的限制之后，不断积累，每一次触发不管最后是否扣除次数真实发奖，都会将round重置下一次继续从1开始</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Slot_config_triggerEO GetByPK(int round, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(round, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Slot_config_triggerEO.MapDataReader);
		}
		public async Task<Slot_config_triggerEO> GetByPKAsync(int round, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(round, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Slot_config_triggerEO.MapDataReader);
		}
		private void RepairGetByPKData(int round, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`Round` = @Round", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Round", round, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 TriggerRate（字段）
		/// </summary>
		/// /// <param name = "round">1-N，手数，在离开newRefundRound的限制之后，不断积累，每一次触发不管最后是否扣除次数真实发奖，都会将round重置下一次继续从1开始</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetTriggerRateByPK(int round, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Round", round, MySqlDbType.Int32),
			};
			return (double)GetScalar("`TriggerRate`", "`Round` = @Round", paras_, tm_);
		}
		public async Task<double> GetTriggerRateByPKAsync(int round, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Round", round, MySqlDbType.Int32),
			};
			return (double)await GetScalarAsync("`TriggerRate`", "`Round` = @Round", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByTriggerRate
		
		/// <summary>
		/// 按 TriggerRate（字段） 查询
		/// </summary>
		/// /// <param name = "triggerRate">0-1，触发几率，1=100%触发，用户每一次游戏</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_triggerEO> GetByTriggerRate(double triggerRate)
		{
			return GetByTriggerRate(triggerRate, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_triggerEO>> GetByTriggerRateAsync(double triggerRate)
		{
			return await GetByTriggerRateAsync(triggerRate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerRate（字段） 查询
		/// </summary>
		/// /// <param name = "triggerRate">0-1，触发几率，1=100%触发，用户每一次游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_triggerEO> GetByTriggerRate(double triggerRate, TransactionManager tm_)
		{
			return GetByTriggerRate(triggerRate, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_triggerEO>> GetByTriggerRateAsync(double triggerRate, TransactionManager tm_)
		{
			return await GetByTriggerRateAsync(triggerRate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerRate（字段） 查询
		/// </summary>
		/// /// <param name = "triggerRate">0-1，触发几率，1=100%触发，用户每一次游戏</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_triggerEO> GetByTriggerRate(double triggerRate, int top_)
		{
			return GetByTriggerRate(triggerRate, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_triggerEO>> GetByTriggerRateAsync(double triggerRate, int top_)
		{
			return await GetByTriggerRateAsync(triggerRate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TriggerRate（字段） 查询
		/// </summary>
		/// /// <param name = "triggerRate">0-1，触发几率，1=100%触发，用户每一次游戏</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_triggerEO> GetByTriggerRate(double triggerRate, int top_, TransactionManager tm_)
		{
			return GetByTriggerRate(triggerRate, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_triggerEO>> GetByTriggerRateAsync(double triggerRate, int top_, TransactionManager tm_)
		{
			return await GetByTriggerRateAsync(triggerRate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TriggerRate（字段） 查询
		/// </summary>
		/// /// <param name = "triggerRate">0-1，触发几率，1=100%触发，用户每一次游戏</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_triggerEO> GetByTriggerRate(double triggerRate, string sort_)
		{
			return GetByTriggerRate(triggerRate, 0, sort_, null);
		}
		public async Task<List<Slot_config_triggerEO>> GetByTriggerRateAsync(double triggerRate, string sort_)
		{
			return await GetByTriggerRateAsync(triggerRate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TriggerRate（字段） 查询
		/// </summary>
		/// /// <param name = "triggerRate">0-1，触发几率，1=100%触发，用户每一次游戏</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_triggerEO> GetByTriggerRate(double triggerRate, string sort_, TransactionManager tm_)
		{
			return GetByTriggerRate(triggerRate, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_triggerEO>> GetByTriggerRateAsync(double triggerRate, string sort_, TransactionManager tm_)
		{
			return await GetByTriggerRateAsync(triggerRate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TriggerRate（字段） 查询
		/// </summary>
		/// /// <param name = "triggerRate">0-1，触发几率，1=100%触发，用户每一次游戏</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_triggerEO> GetByTriggerRate(double triggerRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerRate` = @TriggerRate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerRate", triggerRate, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_triggerEO.MapDataReader);
		}
		public async Task<List<Slot_config_triggerEO>> GetByTriggerRateAsync(double triggerRate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TriggerRate` = @TriggerRate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TriggerRate", triggerRate, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_triggerEO.MapDataReader);
		}
		#endregion // GetByTriggerRate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
