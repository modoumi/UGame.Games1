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
	/// 线配置表
	/// 【表 slot_config_line 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Slot_config_lineEO : IRowMapper<Slot_config_lineEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Slot_config_lineEO()
		{
			this.LineNo = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalAppID;
		/// <summary>
		/// 【数据库中的原始主键 AppID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalAppID
		{
			get { return _originalAppID; }
			set { HasOriginal = true; _originalAppID = value; }
		}
		
		private int _originalLineNo;
		/// <summary>
		/// 【数据库中的原始主键 LineNo 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalLineNo
		{
			get { return _originalLineNo; }
			set { HasOriginal = true; _originalLineNo = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "AppID", AppID },  { "LineNo", LineNo }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// appid
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string AppID { get; set; }
		/// <summary>
		/// 线序号
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int LineNo { get; set; }
		/// <summary>
		/// 线坐标
		/// 【字段 varchar(12)】
		/// </summary>
		[DataMember(Order = 3)]
		public string Line { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Slot_config_lineEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Slot_config_lineEO MapDataReader(IDataReader reader)
		{
		    Slot_config_lineEO ret = new Slot_config_lineEO();
			ret.AppID = reader.ToString("AppID");
			ret.OriginalAppID = ret.AppID;
			ret.LineNo = reader.ToInt32("LineNo");
			ret.OriginalLineNo = ret.LineNo;
			ret.Line = reader.ToString("Line");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 线配置表
	/// 【表 slot_config_line 的操作类】
	/// </summary>
	[Obsolete]
	public class Slot_config_lineMO : MySqlTableMO<Slot_config_lineEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`slot_config_line`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Slot_config_lineMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Slot_config_lineMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Slot_config_lineMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Slot_config_lineEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Slot_config_lineEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Slot_config_lineEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`AppID`, `LineNo`, `Line`) VALUE (@AppID, @LineNo, @Line);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LineNo", item.LineNo, MySqlDbType.Int32),
				Database.CreateInParameter("@Line", item.Line, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Slot_config_lineEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Slot_config_lineEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Slot_config_lineEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`AppID`, `LineNo`, `Line`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.AppID}',{item.LineNo},'{item.Line}'),");
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
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "lineNo">线序号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string appID, int lineNo, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(appID, lineNo, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string appID, int lineNo, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(appID, lineNo, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string appID, int lineNo, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AppID` = @AppID AND `LineNo` = @LineNo";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LineNo", lineNo, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Slot_config_lineEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.AppID, item.LineNo, tm_);
		}
		public async Task<int> RemoveAsync(Slot_config_lineEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.AppID, item.LineNo, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
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
		#region RemoveByLineNo
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lineNo">线序号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLineNo(int lineNo, TransactionManager tm_ = null)
		{
			RepairRemoveByLineNoData(lineNo, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLineNoAsync(int lineNo, TransactionManager tm_ = null)
		{
			RepairRemoveByLineNoData(lineNo, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLineNoData(int lineNo, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LineNo` = @LineNo";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNo", lineNo, MySqlDbType.Int32));
		}
		#endregion // RemoveByLineNo
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
		public int Put(Slot_config_lineEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Slot_config_lineEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Slot_config_lineEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID, `LineNo` = @LineNo, `Line` = @Line WHERE `AppID` = @AppID_Original AND `LineNo` = @LineNo_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LineNo", item.LineNo, MySqlDbType.Int32),
				Database.CreateInParameter("@Line", item.Line, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID_Original", item.HasOriginal ? item.OriginalAppID : item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LineNo_Original", item.HasOriginal ? item.OriginalLineNo : item.LineNo, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Slot_config_lineEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Slot_config_lineEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "lineNo">线序号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, int lineNo, string set_, params object[] values_)
		{
			return Put(set_, "`AppID` = @AppID AND `LineNo` = @LineNo", ConcatValues(values_, appID, lineNo));
		}
		public async Task<int> PutByPKAsync(string appID, int lineNo, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`AppID` = @AppID AND `LineNo` = @LineNo", ConcatValues(values_, appID, lineNo));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "lineNo">线序号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, int lineNo, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`AppID` = @AppID AND `LineNo` = @LineNo", tm_, ConcatValues(values_, appID, lineNo));
		}
		public async Task<int> PutByPKAsync(string appID, int lineNo, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`AppID` = @AppID AND `LineNo` = @LineNo", tm_, ConcatValues(values_, appID, lineNo));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "lineNo">线序号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, int lineNo, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LineNo", lineNo, MySqlDbType.Int32),
	        };
			return Put(set_, "`AppID` = @AppID AND `LineNo` = @LineNo", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string appID, int lineNo, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LineNo", lineNo, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`AppID` = @AppID AND `LineNo` = @LineNo", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutAppID
	 
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
		#region PutLineNo
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lineNo">线序号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLineNo(int lineNo, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LineNo` = @LineNo";
			var parameter_ = Database.CreateInParameter("@LineNo", lineNo, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLineNoAsync(int lineNo, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LineNo` = @LineNo";
			var parameter_ = Database.CreateInParameter("@LineNo", lineNo, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLineNo
		#region PutLine
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "lineNo">线序号</param>
		/// /// <param name = "line">线坐标</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLineByPK(string appID, int lineNo, string line, TransactionManager tm_ = null)
		{
			RepairPutLineByPKData(appID, lineNo, line, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLineByPKAsync(string appID, int lineNo, string line, TransactionManager tm_ = null)
		{
			RepairPutLineByPKData(appID, lineNo, line, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLineByPKData(string appID, int lineNo, string line, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Line` = @Line  WHERE `AppID` = @AppID AND `LineNo` = @LineNo";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Line", line, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LineNo", lineNo, MySqlDbType.Int32),
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
		public bool Set(Slot_config_lineEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AppID, item.LineNo) == null)
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
		public async Task<bool> SetAsync(Slot_config_lineEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AppID, item.LineNo) == null)
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
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "lineNo">线序号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Slot_config_lineEO GetByPK(string appID, int lineNo, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(appID, lineNo, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Slot_config_lineEO.MapDataReader);
		}
		public async Task<Slot_config_lineEO> GetByPKAsync(string appID, int lineNo, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(appID, lineNo, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Slot_config_lineEO.MapDataReader);
		}
		private void RepairGetByPKData(string appID, int lineNo, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`AppID` = @AppID AND `LineNo` = @LineNo", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LineNo", lineNo, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "lineNo">线序号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string appID, int lineNo, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LineNo", lineNo, MySqlDbType.Int32),
			};
			return (string)GetScalar("`AppID`", "`AppID` = @AppID AND `LineNo` = @LineNo", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string appID, int lineNo, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LineNo", lineNo, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`AppID`", "`AppID` = @AppID AND `LineNo` = @LineNo", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LineNo（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "lineNo">线序号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLineNoByPK(string appID, int lineNo, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LineNo", lineNo, MySqlDbType.Int32),
			};
			return (int)GetScalar("`LineNo`", "`AppID` = @AppID AND `LineNo` = @LineNo", paras_, tm_);
		}
		public async Task<int> GetLineNoByPKAsync(string appID, int lineNo, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LineNo", lineNo, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`LineNo`", "`AppID` = @AppID AND `LineNo` = @LineNo", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Line（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "lineNo">线序号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLineByPK(string appID, int lineNo, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LineNo", lineNo, MySqlDbType.Int32),
			};
			return (string)GetScalar("`Line`", "`AppID` = @AppID AND `LineNo` = @LineNo", paras_, tm_);
		}
		public async Task<string> GetLineByPKAsync(string appID, int lineNo, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LineNo", lineNo, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`Line`", "`AppID` = @AppID AND `LineNo` = @LineNo", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lineEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_lineEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lineEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lineEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lineEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_lineEO>> GetByAppIDAsync(string appID, int top_)
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
		public List<Slot_config_lineEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lineEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lineEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<Slot_config_lineEO>> GetByAppIDAsync(string appID, string sort_)
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
		public List<Slot_config_lineEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_lineEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
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
		public List<Slot_config_lineEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_lineEO.MapDataReader);
		}
		public async Task<List<Slot_config_lineEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_lineEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByLineNo
		
		/// <summary>
		/// 按 LineNo（字段） 查询
		/// </summary>
		/// /// <param name = "lineNo">线序号</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lineEO> GetByLineNo(int lineNo)
		{
			return GetByLineNo(lineNo, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_lineEO>> GetByLineNoAsync(int lineNo)
		{
			return await GetByLineNoAsync(lineNo, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LineNo（字段） 查询
		/// </summary>
		/// /// <param name = "lineNo">线序号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lineEO> GetByLineNo(int lineNo, TransactionManager tm_)
		{
			return GetByLineNo(lineNo, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lineEO>> GetByLineNoAsync(int lineNo, TransactionManager tm_)
		{
			return await GetByLineNoAsync(lineNo, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LineNo（字段） 查询
		/// </summary>
		/// /// <param name = "lineNo">线序号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lineEO> GetByLineNo(int lineNo, int top_)
		{
			return GetByLineNo(lineNo, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_lineEO>> GetByLineNoAsync(int lineNo, int top_)
		{
			return await GetByLineNoAsync(lineNo, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LineNo（字段） 查询
		/// </summary>
		/// /// <param name = "lineNo">线序号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lineEO> GetByLineNo(int lineNo, int top_, TransactionManager tm_)
		{
			return GetByLineNo(lineNo, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lineEO>> GetByLineNoAsync(int lineNo, int top_, TransactionManager tm_)
		{
			return await GetByLineNoAsync(lineNo, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LineNo（字段） 查询
		/// </summary>
		/// /// <param name = "lineNo">线序号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lineEO> GetByLineNo(int lineNo, string sort_)
		{
			return GetByLineNo(lineNo, 0, sort_, null);
		}
		public async Task<List<Slot_config_lineEO>> GetByLineNoAsync(int lineNo, string sort_)
		{
			return await GetByLineNoAsync(lineNo, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LineNo（字段） 查询
		/// </summary>
		/// /// <param name = "lineNo">线序号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lineEO> GetByLineNo(int lineNo, string sort_, TransactionManager tm_)
		{
			return GetByLineNo(lineNo, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_lineEO>> GetByLineNoAsync(int lineNo, string sort_, TransactionManager tm_)
		{
			return await GetByLineNoAsync(lineNo, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LineNo（字段） 查询
		/// </summary>
		/// /// <param name = "lineNo">线序号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lineEO> GetByLineNo(int lineNo, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LineNo` = @LineNo", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNo", lineNo, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_lineEO.MapDataReader);
		}
		public async Task<List<Slot_config_lineEO>> GetByLineNoAsync(int lineNo, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LineNo` = @LineNo", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNo", lineNo, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_lineEO.MapDataReader);
		}
		#endregion // GetByLineNo
		#region GetByLine
		
		/// <summary>
		/// 按 Line（字段） 查询
		/// </summary>
		/// /// <param name = "line">线坐标</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lineEO> GetByLine(string line)
		{
			return GetByLine(line, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_lineEO>> GetByLineAsync(string line)
		{
			return await GetByLineAsync(line, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Line（字段） 查询
		/// </summary>
		/// /// <param name = "line">线坐标</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lineEO> GetByLine(string line, TransactionManager tm_)
		{
			return GetByLine(line, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lineEO>> GetByLineAsync(string line, TransactionManager tm_)
		{
			return await GetByLineAsync(line, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Line（字段） 查询
		/// </summary>
		/// /// <param name = "line">线坐标</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lineEO> GetByLine(string line, int top_)
		{
			return GetByLine(line, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_lineEO>> GetByLineAsync(string line, int top_)
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
		public List<Slot_config_lineEO> GetByLine(string line, int top_, TransactionManager tm_)
		{
			return GetByLine(line, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_lineEO>> GetByLineAsync(string line, int top_, TransactionManager tm_)
		{
			return await GetByLineAsync(line, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Line（字段） 查询
		/// </summary>
		/// /// <param name = "line">线坐标</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_lineEO> GetByLine(string line, string sort_)
		{
			return GetByLine(line, 0, sort_, null);
		}
		public async Task<List<Slot_config_lineEO>> GetByLineAsync(string line, string sort_)
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
		public List<Slot_config_lineEO> GetByLine(string line, string sort_, TransactionManager tm_)
		{
			return GetByLine(line, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_lineEO>> GetByLineAsync(string line, string sort_, TransactionManager tm_)
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
		public List<Slot_config_lineEO> GetByLine(string line, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Line` = @Line", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Line", line, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_lineEO.MapDataReader);
		}
		public async Task<List<Slot_config_lineEO>> GetByLineAsync(string line, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Line` = @Line", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Line", line, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_lineEO.MapDataReader);
		}
		#endregion // GetByLine
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
