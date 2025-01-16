/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-25 14: 03:03
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

namespace Fortune_ox.DAL
{
	#region EO
	/// <summary>
	/// 不中奖牌面
	/// 【表 fox_config_weight_change 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Fox_config_weight_changeEO : IRowMapper<Fox_config_weight_changeEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Fox_config_weight_changeEO()
		{
		}
		#region 主键原始值 & 主键集合
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
			return null;
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 轴1
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int Y1 { get; set; }
		/// <summary>
		/// 轴2
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int Y2 { get; set; }
		/// <summary>
		/// 轴3
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int Y3 { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Fox_config_weight_changeEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Fox_config_weight_changeEO MapDataReader(IDataReader reader)
		{
		    Fox_config_weight_changeEO ret = new Fox_config_weight_changeEO();
			ret.Y1 = reader.ToInt32("y1");
			ret.Y2 = reader.ToInt32("y2");
			ret.Y3 = reader.ToInt32("y3");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 不中奖牌面
	/// 【表 fox_config_weight_change 的操作类】
	/// </summary>
	[Obsolete]
	public class Fox_config_weight_changeMO : MySqlTableMO<Fox_config_weight_changeEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`fox_config_weight_change`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Fox_config_weight_changeMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Fox_config_weight_changeMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Fox_config_weight_changeMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Fox_config_weight_changeEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Fox_config_weight_changeEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Fox_config_weight_changeEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`y1`, `y2`, `y3`) VALUE (@y1, @y2, @y3);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@y1", item.Y1, MySqlDbType.Int32),
				Database.CreateInParameter("@y2", item.Y2, MySqlDbType.Int32),
				Database.CreateInParameter("@y3", item.Y3, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Fox_config_weight_changeEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Fox_config_weight_changeEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Fox_config_weight_changeEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`y1`, `y2`, `y3`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.Y1},{item.Y2},{item.Y3}),");
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
		
		#region RemoveByXXX
		#region RemoveByY1
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "y1">轴1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByY1(int y1, TransactionManager tm_ = null)
		{
			RepairRemoveByY1Data(y1, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByY1Async(int y1, TransactionManager tm_ = null)
		{
			RepairRemoveByY1Data(y1, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByY1Data(int y1, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `y1` = @y1";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@y1", y1, MySqlDbType.Int32));
		}
		#endregion // RemoveByY1
		#region RemoveByY2
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "y2">轴2</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByY2(int y2, TransactionManager tm_ = null)
		{
			RepairRemoveByY2Data(y2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByY2Async(int y2, TransactionManager tm_ = null)
		{
			RepairRemoveByY2Data(y2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByY2Data(int y2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `y2` = @y2";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@y2", y2, MySqlDbType.Int32));
		}
		#endregion // RemoveByY2
		#region RemoveByY3
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "y3">轴3</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByY3(int y3, TransactionManager tm_ = null)
		{
			RepairRemoveByY3Data(y3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByY3Async(int y3, TransactionManager tm_ = null)
		{
			RepairRemoveByY3Data(y3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByY3Data(int y3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `y3` = @y3";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@y3", y3, MySqlDbType.Int32));
		}
		#endregion // RemoveByY3
		#endregion // RemoveByXXX
	    
		#region RemoveByFKOrUnique
		#endregion // RemoveByFKOrUnique
		#endregion //Remove
	    
		#region Put
		
		#region PutXXX
		#region PutY1
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "y1">轴1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutY1(int y1, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `y1` = @y1";
			var parameter_ = Database.CreateInParameter("@y1", y1, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutY1Async(int y1, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `y1` = @y1";
			var parameter_ = Database.CreateInParameter("@y1", y1, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutY1
		#region PutY2
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "y2">轴2</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutY2(int y2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `y2` = @y2";
			var parameter_ = Database.CreateInParameter("@y2", y2, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutY2Async(int y2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `y2` = @y2";
			var parameter_ = Database.CreateInParameter("@y2", y2, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutY2
		#region PutY3
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "y3">轴3</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutY3(int y3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `y3` = @y3";
			var parameter_ = Database.CreateInParameter("@y3", y3, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutY3Async(int y3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `y3` = @y3";
			var parameter_ = Database.CreateInParameter("@y3", y3, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutY3
		#endregion // PutXXX
		#endregion // Put
	   
		
		#region Get
		
		#region GetByXXX
		#region GetByY1
		
		/// <summary>
		/// 按 y1（字段） 查询
		/// </summary>
		/// /// <param name = "y1">轴1</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY1(int y1)
		{
			return GetByY1(y1, 0, string.Empty, null);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY1Async(int y1)
		{
			return await GetByY1Async(y1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 y1（字段） 查询
		/// </summary>
		/// /// <param name = "y1">轴1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY1(int y1, TransactionManager tm_)
		{
			return GetByY1(y1, 0, string.Empty, tm_);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY1Async(int y1, TransactionManager tm_)
		{
			return await GetByY1Async(y1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 y1（字段） 查询
		/// </summary>
		/// /// <param name = "y1">轴1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY1(int y1, int top_)
		{
			return GetByY1(y1, top_, string.Empty, null);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY1Async(int y1, int top_)
		{
			return await GetByY1Async(y1, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 y1（字段） 查询
		/// </summary>
		/// /// <param name = "y1">轴1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY1(int y1, int top_, TransactionManager tm_)
		{
			return GetByY1(y1, top_, string.Empty, tm_);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY1Async(int y1, int top_, TransactionManager tm_)
		{
			return await GetByY1Async(y1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 y1（字段） 查询
		/// </summary>
		/// /// <param name = "y1">轴1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY1(int y1, string sort_)
		{
			return GetByY1(y1, 0, sort_, null);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY1Async(int y1, string sort_)
		{
			return await GetByY1Async(y1, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 y1（字段） 查询
		/// </summary>
		/// /// <param name = "y1">轴1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY1(int y1, string sort_, TransactionManager tm_)
		{
			return GetByY1(y1, 0, sort_, tm_);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY1Async(int y1, string sort_, TransactionManager tm_)
		{
			return await GetByY1Async(y1, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 y1（字段） 查询
		/// </summary>
		/// /// <param name = "y1">轴1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY1(int y1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`y1` = @y1", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@y1", y1, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fox_config_weight_changeEO.MapDataReader);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY1Async(int y1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`y1` = @y1", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@y1", y1, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fox_config_weight_changeEO.MapDataReader);
		}
		#endregion // GetByY1
		#region GetByY2
		
		/// <summary>
		/// 按 y2（字段） 查询
		/// </summary>
		/// /// <param name = "y2">轴2</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY2(int y2)
		{
			return GetByY2(y2, 0, string.Empty, null);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY2Async(int y2)
		{
			return await GetByY2Async(y2, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 y2（字段） 查询
		/// </summary>
		/// /// <param name = "y2">轴2</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY2(int y2, TransactionManager tm_)
		{
			return GetByY2(y2, 0, string.Empty, tm_);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY2Async(int y2, TransactionManager tm_)
		{
			return await GetByY2Async(y2, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 y2（字段） 查询
		/// </summary>
		/// /// <param name = "y2">轴2</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY2(int y2, int top_)
		{
			return GetByY2(y2, top_, string.Empty, null);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY2Async(int y2, int top_)
		{
			return await GetByY2Async(y2, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 y2（字段） 查询
		/// </summary>
		/// /// <param name = "y2">轴2</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY2(int y2, int top_, TransactionManager tm_)
		{
			return GetByY2(y2, top_, string.Empty, tm_);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY2Async(int y2, int top_, TransactionManager tm_)
		{
			return await GetByY2Async(y2, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 y2（字段） 查询
		/// </summary>
		/// /// <param name = "y2">轴2</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY2(int y2, string sort_)
		{
			return GetByY2(y2, 0, sort_, null);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY2Async(int y2, string sort_)
		{
			return await GetByY2Async(y2, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 y2（字段） 查询
		/// </summary>
		/// /// <param name = "y2">轴2</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY2(int y2, string sort_, TransactionManager tm_)
		{
			return GetByY2(y2, 0, sort_, tm_);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY2Async(int y2, string sort_, TransactionManager tm_)
		{
			return await GetByY2Async(y2, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 y2（字段） 查询
		/// </summary>
		/// /// <param name = "y2">轴2</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY2(int y2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`y2` = @y2", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@y2", y2, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fox_config_weight_changeEO.MapDataReader);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY2Async(int y2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`y2` = @y2", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@y2", y2, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fox_config_weight_changeEO.MapDataReader);
		}
		#endregion // GetByY2
		#region GetByY3
		
		/// <summary>
		/// 按 y3（字段） 查询
		/// </summary>
		/// /// <param name = "y3">轴3</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY3(int y3)
		{
			return GetByY3(y3, 0, string.Empty, null);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY3Async(int y3)
		{
			return await GetByY3Async(y3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 y3（字段） 查询
		/// </summary>
		/// /// <param name = "y3">轴3</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY3(int y3, TransactionManager tm_)
		{
			return GetByY3(y3, 0, string.Empty, tm_);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY3Async(int y3, TransactionManager tm_)
		{
			return await GetByY3Async(y3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 y3（字段） 查询
		/// </summary>
		/// /// <param name = "y3">轴3</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY3(int y3, int top_)
		{
			return GetByY3(y3, top_, string.Empty, null);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY3Async(int y3, int top_)
		{
			return await GetByY3Async(y3, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 y3（字段） 查询
		/// </summary>
		/// /// <param name = "y3">轴3</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY3(int y3, int top_, TransactionManager tm_)
		{
			return GetByY3(y3, top_, string.Empty, tm_);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY3Async(int y3, int top_, TransactionManager tm_)
		{
			return await GetByY3Async(y3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 y3（字段） 查询
		/// </summary>
		/// /// <param name = "y3">轴3</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY3(int y3, string sort_)
		{
			return GetByY3(y3, 0, sort_, null);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY3Async(int y3, string sort_)
		{
			return await GetByY3Async(y3, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 y3（字段） 查询
		/// </summary>
		/// /// <param name = "y3">轴3</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY3(int y3, string sort_, TransactionManager tm_)
		{
			return GetByY3(y3, 0, sort_, tm_);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY3Async(int y3, string sort_, TransactionManager tm_)
		{
			return await GetByY3Async(y3, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 y3（字段） 查询
		/// </summary>
		/// /// <param name = "y3">轴3</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_config_weight_changeEO> GetByY3(int y3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`y3` = @y3", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@y3", y3, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fox_config_weight_changeEO.MapDataReader);
		}
		public async Task<List<Fox_config_weight_changeEO>> GetByY3Async(int y3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`y3` = @y3", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@y3", y3, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fox_config_weight_changeEO.MapDataReader);
		}
		#endregion // GetByY3
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
