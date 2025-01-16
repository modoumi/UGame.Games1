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
	/// 所有奖池权重
	/// 【表 fra_config_weight_t 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Fra_config_weight_tEO : IRowMapper<Fra_config_weight_tEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Fra_config_weight_tEO()
		{
			this.Weight_Main = 0;
			this.Weight_SM = 0;
			this.Multip = 0f;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalTID;
		/// <summary>
		/// 【数据库中的原始主键 TID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalTID
		{
			get { return _originalTID; }
			set { HasOriginal = true; _originalTID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "TID", TID }, };
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
		public int TID { get; set; }
		/// <summary>
		/// 普通玩法权重
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int Weight_Main { get; set; }
		/// <summary>
		/// 特殊玩法权重
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int Weight_SM { get; set; }
		/// <summary>
		/// 倍率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 4)]
		public float Multip { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Fra_config_weight_tEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Fra_config_weight_tEO MapDataReader(IDataReader reader)
		{
		    Fra_config_weight_tEO ret = new Fra_config_weight_tEO();
			ret.TID = reader.ToInt32("TID");
			ret.OriginalTID = ret.TID;
			ret.Weight_Main = reader.ToInt32("Weight_Main");
			ret.Weight_SM = reader.ToInt32("Weight_SM");
			ret.Multip = reader.ToSingle("Multip");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 所有奖池权重
	/// 【表 fra_config_weight_t 的操作类】
	/// </summary>
	[Obsolete]
	public class Fra_config_weight_tMO : MySqlTableMO<Fra_config_weight_tEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`fra_config_weight_t`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Fra_config_weight_tMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Fra_config_weight_tMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Fra_config_weight_tMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Fra_config_weight_tEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Fra_config_weight_tEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Fra_config_weight_tEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`TID`, `Weight_Main`, `Weight_SM`, `Multip`) VALUE (@TID, @Weight_Main, @Weight_SM, @Multip);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TID", item.TID, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight_Main", item.Weight_Main, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight_SM", item.Weight_SM, MySqlDbType.Int32),
				Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Float),
			};
		}
		public int AddByBatch(IEnumerable<Fra_config_weight_tEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Fra_config_weight_tEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Fra_config_weight_tEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`TID`, `Weight_Main`, `Weight_SM`, `Multip`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.TID},{item.Weight_Main},{item.Weight_SM},{item.Multip}),");
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
		/// /// <param name = "tID"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int tID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(tID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int tID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(tID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int tID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TID` = @TID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TID", tID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Fra_config_weight_tEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.TID, tm_);
		}
		public async Task<int> RemoveAsync(Fra_config_weight_tEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.TID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByWeight_Main
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight_Main">普通玩法权重</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeight_Main(int weight_Main, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight_MainData(weight_Main, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeight_MainAsync(int weight_Main, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight_MainData(weight_Main, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeight_MainData(int weight_Main, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Weight_Main` = @Weight_Main";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Main", weight_Main, MySqlDbType.Int32));
		}
		#endregion // RemoveByWeight_Main
		#region RemoveByWeight_SM
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight_SM">特殊玩法权重</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeight_SM(int weight_SM, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight_SMData(weight_SM, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeight_SMAsync(int weight_SM, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight_SMData(weight_SM, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeight_SMData(int weight_SM, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Weight_SM` = @Weight_SM";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_SM", weight_SM, MySqlDbType.Int32));
		}
		#endregion // RemoveByWeight_SM
		#region RemoveByMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "multip">倍率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMultip(float multip, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipData(multip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMultipAsync(float multip, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipData(multip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMultipData(float multip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Multip` = @Multip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Float));
		}
		#endregion // RemoveByMultip
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
		public int Put(Fra_config_weight_tEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Fra_config_weight_tEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Fra_config_weight_tEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TID` = @TID, `Weight_Main` = @Weight_Main, `Weight_SM` = @Weight_SM, `Multip` = @Multip WHERE `TID` = @TID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TID", item.TID, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight_Main", item.Weight_Main, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight_SM", item.Weight_SM, MySqlDbType.Int32),
				Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Float),
				Database.CreateInParameter("@TID_Original", item.HasOriginal ? item.OriginalTID : item.TID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Fra_config_weight_tEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Fra_config_weight_tEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "tID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int tID, string set_, params object[] values_)
		{
			return Put(set_, "`TID` = @TID", ConcatValues(values_, tID));
		}
		public async Task<int> PutByPKAsync(int tID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`TID` = @TID", ConcatValues(values_, tID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "tID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int tID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`TID` = @TID", tm_, ConcatValues(values_, tID));
		}
		public async Task<int> PutByPKAsync(int tID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`TID` = @TID", tm_, ConcatValues(values_, tID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "tID"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int tID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@TID", tID, MySqlDbType.Int32),
	        };
			return Put(set_, "`TID` = @TID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int tID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@TID", tID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`TID` = @TID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutWeight_Main
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "tID"></param>
		/// /// <param name = "weight_Main">普通玩法权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight_MainByPK(int tID, int weight_Main, TransactionManager tm_ = null)
		{
			RepairPutWeight_MainByPKData(tID, weight_Main, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeight_MainByPKAsync(int tID, int weight_Main, TransactionManager tm_ = null)
		{
			RepairPutWeight_MainByPKData(tID, weight_Main, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeight_MainByPKData(int tID, int weight_Main, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight_Main` = @Weight_Main  WHERE `TID` = @TID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight_Main", weight_Main, MySqlDbType.Int32),
				Database.CreateInParameter("@TID", tID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight_Main">普通玩法权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight_Main(int weight_Main, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight_Main` = @Weight_Main";
			var parameter_ = Database.CreateInParameter("@Weight_Main", weight_Main, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeight_MainAsync(int weight_Main, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight_Main` = @Weight_Main";
			var parameter_ = Database.CreateInParameter("@Weight_Main", weight_Main, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWeight_Main
		#region PutWeight_SM
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "tID"></param>
		/// /// <param name = "weight_SM">特殊玩法权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight_SMByPK(int tID, int weight_SM, TransactionManager tm_ = null)
		{
			RepairPutWeight_SMByPKData(tID, weight_SM, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeight_SMByPKAsync(int tID, int weight_SM, TransactionManager tm_ = null)
		{
			RepairPutWeight_SMByPKData(tID, weight_SM, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeight_SMByPKData(int tID, int weight_SM, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight_SM` = @Weight_SM  WHERE `TID` = @TID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight_SM", weight_SM, MySqlDbType.Int32),
				Database.CreateInParameter("@TID", tID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight_SM">特殊玩法权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight_SM(int weight_SM, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight_SM` = @Weight_SM";
			var parameter_ = Database.CreateInParameter("@Weight_SM", weight_SM, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeight_SMAsync(int weight_SM, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight_SM` = @Weight_SM";
			var parameter_ = Database.CreateInParameter("@Weight_SM", weight_SM, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWeight_SM
		#region PutMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "tID"></param>
		/// /// <param name = "multip">倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultipByPK(int tID, float multip, TransactionManager tm_ = null)
		{
			RepairPutMultipByPKData(tID, multip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMultipByPKAsync(int tID, float multip, TransactionManager tm_ = null)
		{
			RepairPutMultipByPKData(tID, multip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMultipByPKData(int tID, float multip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Multip` = @Multip  WHERE `TID` = @TID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Multip", multip, MySqlDbType.Float),
				Database.CreateInParameter("@TID", tID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "multip">倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultip(float multip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multip` = @Multip";
			var parameter_ = Database.CreateInParameter("@Multip", multip, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMultipAsync(float multip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multip` = @Multip";
			var parameter_ = Database.CreateInParameter("@Multip", multip, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMultip
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Fra_config_weight_tEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.TID) == null)
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
		public async Task<bool> SetAsync(Fra_config_weight_tEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.TID) == null)
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
		/// /// <param name = "tID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Fra_config_weight_tEO GetByPK(int tID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(tID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Fra_config_weight_tEO.MapDataReader);
		}
		public async Task<Fra_config_weight_tEO> GetByPKAsync(int tID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(tID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Fra_config_weight_tEO.MapDataReader);
		}
		private void RepairGetByPKData(int tID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`TID` = @TID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TID", tID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 Weight_Main（字段）
		/// </summary>
		/// /// <param name = "tID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeight_MainByPK(int tID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TID", tID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Weight_Main`", "`TID` = @TID", paras_, tm_);
		}
		public async Task<int> GetWeight_MainByPKAsync(int tID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TID", tID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Weight_Main`", "`TID` = @TID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight_SM（字段）
		/// </summary>
		/// /// <param name = "tID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeight_SMByPK(int tID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TID", tID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Weight_SM`", "`TID` = @TID", paras_, tm_);
		}
		public async Task<int> GetWeight_SMByPKAsync(int tID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TID", tID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Weight_SM`", "`TID` = @TID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Multip（字段）
		/// </summary>
		/// /// <param name = "tID"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetMultipByPK(int tID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TID", tID, MySqlDbType.Int32),
			};
			return (float)GetScalar("`Multip`", "`TID` = @TID", paras_, tm_);
		}
		public async Task<float> GetMultipByPKAsync(int tID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TID", tID, MySqlDbType.Int32),
			};
			return (float)await GetScalarAsync("`Multip`", "`TID` = @TID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByWeight_Main
		
		/// <summary>
		/// 按 Weight_Main（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main">普通玩法权重</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByWeight_Main(int weight_Main)
		{
			return GetByWeight_Main(weight_Main, 0, string.Empty, null);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByWeight_MainAsync(int weight_Main)
		{
			return await GetByWeight_MainAsync(weight_Main, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight_Main（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main">普通玩法权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByWeight_Main(int weight_Main, TransactionManager tm_)
		{
			return GetByWeight_Main(weight_Main, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByWeight_MainAsync(int weight_Main, TransactionManager tm_)
		{
			return await GetByWeight_MainAsync(weight_Main, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Main（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main">普通玩法权重</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByWeight_Main(int weight_Main, int top_)
		{
			return GetByWeight_Main(weight_Main, top_, string.Empty, null);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByWeight_MainAsync(int weight_Main, int top_)
		{
			return await GetByWeight_MainAsync(weight_Main, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight_Main（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main">普通玩法权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByWeight_Main(int weight_Main, int top_, TransactionManager tm_)
		{
			return GetByWeight_Main(weight_Main, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByWeight_MainAsync(int weight_Main, int top_, TransactionManager tm_)
		{
			return await GetByWeight_MainAsync(weight_Main, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Main（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main">普通玩法权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByWeight_Main(int weight_Main, string sort_)
		{
			return GetByWeight_Main(weight_Main, 0, sort_, null);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByWeight_MainAsync(int weight_Main, string sort_)
		{
			return await GetByWeight_MainAsync(weight_Main, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Weight_Main（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main">普通玩法权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByWeight_Main(int weight_Main, string sort_, TransactionManager tm_)
		{
			return GetByWeight_Main(weight_Main, 0, sort_, tm_);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByWeight_MainAsync(int weight_Main, string sort_, TransactionManager tm_)
		{
			return await GetByWeight_MainAsync(weight_Main, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Weight_Main（字段） 查询
		/// </summary>
		/// /// <param name = "weight_Main">普通玩法权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByWeight_Main(int weight_Main, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight_Main` = @Weight_Main", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Main", weight_Main, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_config_weight_tEO.MapDataReader);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByWeight_MainAsync(int weight_Main, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight_Main` = @Weight_Main", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_Main", weight_Main, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_config_weight_tEO.MapDataReader);
		}
		#endregion // GetByWeight_Main
		#region GetByWeight_SM
		
		/// <summary>
		/// 按 Weight_SM（字段） 查询
		/// </summary>
		/// /// <param name = "weight_SM">特殊玩法权重</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByWeight_SM(int weight_SM)
		{
			return GetByWeight_SM(weight_SM, 0, string.Empty, null);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByWeight_SMAsync(int weight_SM)
		{
			return await GetByWeight_SMAsync(weight_SM, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight_SM（字段） 查询
		/// </summary>
		/// /// <param name = "weight_SM">特殊玩法权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByWeight_SM(int weight_SM, TransactionManager tm_)
		{
			return GetByWeight_SM(weight_SM, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByWeight_SMAsync(int weight_SM, TransactionManager tm_)
		{
			return await GetByWeight_SMAsync(weight_SM, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight_SM（字段） 查询
		/// </summary>
		/// /// <param name = "weight_SM">特殊玩法权重</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByWeight_SM(int weight_SM, int top_)
		{
			return GetByWeight_SM(weight_SM, top_, string.Empty, null);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByWeight_SMAsync(int weight_SM, int top_)
		{
			return await GetByWeight_SMAsync(weight_SM, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight_SM（字段） 查询
		/// </summary>
		/// /// <param name = "weight_SM">特殊玩法权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByWeight_SM(int weight_SM, int top_, TransactionManager tm_)
		{
			return GetByWeight_SM(weight_SM, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByWeight_SMAsync(int weight_SM, int top_, TransactionManager tm_)
		{
			return await GetByWeight_SMAsync(weight_SM, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight_SM（字段） 查询
		/// </summary>
		/// /// <param name = "weight_SM">特殊玩法权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByWeight_SM(int weight_SM, string sort_)
		{
			return GetByWeight_SM(weight_SM, 0, sort_, null);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByWeight_SMAsync(int weight_SM, string sort_)
		{
			return await GetByWeight_SMAsync(weight_SM, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Weight_SM（字段） 查询
		/// </summary>
		/// /// <param name = "weight_SM">特殊玩法权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByWeight_SM(int weight_SM, string sort_, TransactionManager tm_)
		{
			return GetByWeight_SM(weight_SM, 0, sort_, tm_);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByWeight_SMAsync(int weight_SM, string sort_, TransactionManager tm_)
		{
			return await GetByWeight_SMAsync(weight_SM, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Weight_SM（字段） 查询
		/// </summary>
		/// /// <param name = "weight_SM">特殊玩法权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByWeight_SM(int weight_SM, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight_SM` = @Weight_SM", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_SM", weight_SM, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_config_weight_tEO.MapDataReader);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByWeight_SMAsync(int weight_SM, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight_SM` = @Weight_SM", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight_SM", weight_SM, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_config_weight_tEO.MapDataReader);
		}
		#endregion // GetByWeight_SM
		#region GetByMultip
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">倍率</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByMultip(float multip)
		{
			return GetByMultip(multip, 0, string.Empty, null);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByMultipAsync(float multip)
		{
			return await GetByMultipAsync(multip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByMultip(float multip, TransactionManager tm_)
		{
			return GetByMultip(multip, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByMultipAsync(float multip, TransactionManager tm_)
		{
			return await GetByMultipAsync(multip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByMultip(float multip, int top_)
		{
			return GetByMultip(multip, top_, string.Empty, null);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByMultipAsync(float multip, int top_)
		{
			return await GetByMultipAsync(multip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByMultip(float multip, int top_, TransactionManager tm_)
		{
			return GetByMultip(multip, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByMultipAsync(float multip, int top_, TransactionManager tm_)
		{
			return await GetByMultipAsync(multip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByMultip(float multip, string sort_)
		{
			return GetByMultip(multip, 0, sort_, null);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByMultipAsync(float multip, string sort_)
		{
			return await GetByMultipAsync(multip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByMultip(float multip, string sort_, TransactionManager tm_)
		{
			return GetByMultip(multip, 0, sort_, tm_);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByMultipAsync(float multip, string sort_, TransactionManager tm_)
		{
			return await GetByMultipAsync(multip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_weight_tEO> GetByMultip(float multip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_config_weight_tEO.MapDataReader);
		}
		public async Task<List<Fra_config_weight_tEO>> GetByMultipAsync(float multip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_config_weight_tEO.MapDataReader);
		}
		#endregion // GetByMultip
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
