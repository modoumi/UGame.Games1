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
	/// 线配置表
	/// 【表 big_config_line 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Big_config_lineEO : IRowMapper<Big_config_lineEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Big_config_lineEO()
		{
			this.LineID = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalLineID;
		/// <summary>
		/// 【数据库中的原始主键 LineID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalLineID
		{
			get { return _originalLineID; }
			set { HasOriginal = true; _originalLineID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "LineID", LineID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 线序号
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int LineID { get; set; }
		/// <summary>
		/// 线坐标
		/// 【字段 varchar(12)】
		/// </summary>
		[DataMember(Order = 2)]
		public string Line { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Big_config_lineEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Big_config_lineEO MapDataReader(IDataReader reader)
		{
		    Big_config_lineEO ret = new Big_config_lineEO();
			ret.LineID = reader.ToInt32("LineID");
			ret.OriginalLineID = ret.LineID;
			ret.Line = reader.ToString("Line");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 线配置表
	/// 【表 big_config_line 的操作类】
	/// </summary>
	[Obsolete]
	public class Big_config_lineMO : MySqlTableMO<Big_config_lineEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`big_config_line`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Big_config_lineMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Big_config_lineMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Big_config_lineMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Big_config_lineEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Big_config_lineEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Big_config_lineEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`LineID`, `Line`) VALUE (@LineID, @Line);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LineID", item.LineID, MySqlDbType.Int32),
				Database.CreateInParameter("@Line", item.Line, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Big_config_lineEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Big_config_lineEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Big_config_lineEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`LineID`, `Line`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.LineID},'{item.Line}'),");
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
		/// /// <param name = "lineID">线序号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int lineID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(lineID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int lineID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(lineID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int lineID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LineID` = @LineID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Big_config_lineEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.LineID, tm_);
		}
		public async Task<int> RemoveAsync(Big_config_lineEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.LineID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByLine
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "line">线坐标</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLine(string line, TransactionManager tm_ = null)
		{
			RepairRemoveByLineData(line, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLineAsync(string line, TransactionManager tm_ = null)
		{
			RepairRemoveByLineData(line, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLineData(string line, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Line` = @Line";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Line", line, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLine
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
		public int Put(Big_config_lineEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Big_config_lineEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Big_config_lineEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LineID` = @LineID, `Line` = @Line WHERE `LineID` = @LineID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LineID", item.LineID, MySqlDbType.Int32),
				Database.CreateInParameter("@Line", item.Line, MySqlDbType.VarChar),
				Database.CreateInParameter("@LineID_Original", item.HasOriginal ? item.OriginalLineID : item.LineID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Big_config_lineEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Big_config_lineEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "lineID">线序号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int lineID, string set_, params object[] values_)
		{
			return Put(set_, "`LineID` = @LineID", ConcatValues(values_, lineID));
		}
		public async Task<int> PutByPKAsync(int lineID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`LineID` = @LineID", ConcatValues(values_, lineID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "lineID">线序号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int lineID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`LineID` = @LineID", tm_, ConcatValues(values_, lineID));
		}
		public async Task<int> PutByPKAsync(int lineID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`LineID` = @LineID", tm_, ConcatValues(values_, lineID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "lineID">线序号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int lineID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
	        };
			return Put(set_, "`LineID` = @LineID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int lineID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`LineID` = @LineID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutLine
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "lineID">线序号</param>
		/// /// <param name = "line">线坐标</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLineByPK(int lineID, string line, TransactionManager tm_ = null)
		{
			RepairPutLineByPKData(lineID, line, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLineByPKAsync(int lineID, string line, TransactionManager tm_ = null)
		{
			RepairPutLineByPKData(lineID, line, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLineByPKData(int lineID, string line, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Line` = @Line  WHERE `LineID` = @LineID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Line", line, MySqlDbType.VarChar),
				Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "line">线坐标</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLine(string line, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Line` = @Line";
			var parameter_ = Database.CreateInParameter("@Line", line, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLineAsync(string line, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Line` = @Line";
			var parameter_ = Database.CreateInParameter("@Line", line, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLine
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Big_config_lineEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.LineID) == null)
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
		public async Task<bool> SetAsync(Big_config_lineEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.LineID) == null)
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
		/// /// <param name = "lineID">线序号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Big_config_lineEO GetByPK(int lineID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(lineID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Big_config_lineEO.MapDataReader);
		}
		public async Task<Big_config_lineEO> GetByPKAsync(int lineID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(lineID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Big_config_lineEO.MapDataReader);
		}
		private void RepairGetByPKData(int lineID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`LineID` = @LineID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 Line（字段）
		/// </summary>
		/// /// <param name = "lineID">线序号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLineByPK(int lineID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`Line`", "`LineID` = @LineID", paras_, tm_);
		}
		public async Task<string> GetLineByPKAsync(int lineID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LineID", lineID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`Line`", "`LineID` = @LineID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByLine
		
		/// <summary>
		/// 按 Line（字段） 查询
		/// </summary>
		/// /// <param name = "line">线坐标</param>
		/// <return>实体对象集合</return>
		public List<Big_config_lineEO> GetByLine(string line)
		{
			return GetByLine(line, 0, string.Empty, null);
		}
		public async Task<List<Big_config_lineEO>> GetByLineAsync(string line)
		{
			return await GetByLineAsync(line, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Line（字段） 查询
		/// </summary>
		/// /// <param name = "line">线坐标</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_lineEO> GetByLine(string line, TransactionManager tm_)
		{
			return GetByLine(line, 0, string.Empty, tm_);
		}
		public async Task<List<Big_config_lineEO>> GetByLineAsync(string line, TransactionManager tm_)
		{
			return await GetByLineAsync(line, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Line（字段） 查询
		/// </summary>
		/// /// <param name = "line">线坐标</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_config_lineEO> GetByLine(string line, int top_)
		{
			return GetByLine(line, top_, string.Empty, null);
		}
		public async Task<List<Big_config_lineEO>> GetByLineAsync(string line, int top_)
		{
			return await GetByLineAsync(line, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Line（字段） 查询
		/// </summary>
		/// /// <param name = "line">线坐标</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_lineEO> GetByLine(string line, int top_, TransactionManager tm_)
		{
			return GetByLine(line, top_, string.Empty, tm_);
		}
		public async Task<List<Big_config_lineEO>> GetByLineAsync(string line, int top_, TransactionManager tm_)
		{
			return await GetByLineAsync(line, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Line（字段） 查询
		/// </summary>
		/// /// <param name = "line">线坐标</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_config_lineEO> GetByLine(string line, string sort_)
		{
			return GetByLine(line, 0, sort_, null);
		}
		public async Task<List<Big_config_lineEO>> GetByLineAsync(string line, string sort_)
		{
			return await GetByLineAsync(line, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Line（字段） 查询
		/// </summary>
		/// /// <param name = "line">线坐标</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_lineEO> GetByLine(string line, string sort_, TransactionManager tm_)
		{
			return GetByLine(line, 0, sort_, tm_);
		}
		public async Task<List<Big_config_lineEO>> GetByLineAsync(string line, string sort_, TransactionManager tm_)
		{
			return await GetByLineAsync(line, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Line（字段） 查询
		/// </summary>
		/// /// <param name = "line">线坐标</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_lineEO> GetByLine(string line, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Line` = @Line", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Line", line, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_config_lineEO.MapDataReader);
		}
		public async Task<List<Big_config_lineEO>> GetByLineAsync(string line, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Line` = @Line", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Line", line, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_config_lineEO.MapDataReader);
		}
		#endregion // GetByLine
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
