/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2024-04-09 14: 13:20
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
	/// 图标ICON权重表
	/// 【表 big_config_symbol 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Big_config_symbolEO : IRowMapper<Big_config_symbolEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Big_config_symbolEO()
		{
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalSymbolID;
		/// <summary>
		/// 【数据库中的原始主键 symbolID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalSymbolID
		{
			get { return _originalSymbolID; }
			set { HasOriginal = true; _originalSymbolID = value; }
		}
		
		private int _originalSymbolType;
		/// <summary>
		/// 【数据库中的原始主键 symbolType 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalSymbolType
		{
			get { return _originalSymbolType; }
			set { HasOriginal = true; _originalSymbolType = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "SymbolID", SymbolID },  { "SymbolType", SymbolType }, };
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
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int SymbolID { get; set; }
		/// <summary>
		/// 1-普通,2-万能
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int SymbolType { get; set; }
		/// <summary>
		/// 图标名字
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string SymbolName { get; set; }
		/// <summary>
		/// 图标ICON基础倍率
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int SymbolMultiple3 { get; set; }
		/// <summary>
		/// 图标ICON基础倍率
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int SymbolMultiple4 { get; set; }
		/// <summary>
		/// 图标ICON基础倍率
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int SymbolMultiple5 { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Big_config_symbolEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Big_config_symbolEO MapDataReader(IDataReader reader)
		{
		    Big_config_symbolEO ret = new Big_config_symbolEO();
			ret.SymbolID = reader.ToInt32("symbolID");
			ret.OriginalSymbolID = ret.SymbolID;
			ret.SymbolType = reader.ToInt32("symbolType");
			ret.OriginalSymbolType = ret.SymbolType;
			ret.SymbolName = reader.ToString("symbolName");
			ret.SymbolMultiple3 = reader.ToInt32("symbolMultiple3");
			ret.SymbolMultiple4 = reader.ToInt32("symbolMultiple4");
			ret.SymbolMultiple5 = reader.ToInt32("symbolMultiple5");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 图标ICON权重表
	/// 【表 big_config_symbol 的操作类】
	/// </summary>
	[Obsolete]
	public class Big_config_symbolMO : MySqlTableMO<Big_config_symbolEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`big_config_symbol`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Big_config_symbolMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Big_config_symbolMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Big_config_symbolMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Big_config_symbolEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Big_config_symbolEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Big_config_symbolEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`symbolID`, `symbolType`, `symbolName`, `symbolMultiple3`, `symbolMultiple4`, `symbolMultiple5`) VALUE (@symbolID, @symbolType, @symbolName, @symbolMultiple3, @symbolMultiple4, @symbolMultiple5);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolID", item.SymbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", item.SymbolType, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolName", item.SymbolName, MySqlDbType.VarChar),
				Database.CreateInParameter("@symbolMultiple3", item.SymbolMultiple3, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolMultiple4", item.SymbolMultiple4, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolMultiple5", item.SymbolMultiple5, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Big_config_symbolEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Big_config_symbolEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Big_config_symbolEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`symbolID`, `symbolType`, `symbolName`, `symbolMultiple3`, `symbolMultiple4`, `symbolMultiple5`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.SymbolID},{item.SymbolType},'{item.SymbolName}',{item.SymbolMultiple3},{item.SymbolMultiple4},{item.SymbolMultiple5}),");
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
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(symbolID, symbolType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(symbolID, symbolType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int symbolID, int symbolType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `symbolID` = @symbolID AND `symbolType` = @symbolType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Big_config_symbolEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.SymbolID, item.SymbolType, tm_);
		}
		public async Task<int> RemoveAsync(Big_config_symbolEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.SymbolID, item.SymbolType, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveBySymbolID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySymbolID(int symbolID, TransactionManager tm_ = null)
		{
			RepairRemoveBySymbolIDData(symbolID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySymbolIDAsync(int symbolID, TransactionManager tm_ = null)
		{
			RepairRemoveBySymbolIDData(symbolID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySymbolIDData(int symbolID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `symbolID` = @symbolID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32));
		}
		#endregion // RemoveBySymbolID
		#region RemoveBySymbolType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySymbolType(int symbolType, TransactionManager tm_ = null)
		{
			RepairRemoveBySymbolTypeData(symbolType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySymbolTypeAsync(int symbolType, TransactionManager tm_ = null)
		{
			RepairRemoveBySymbolTypeData(symbolType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySymbolTypeData(int symbolType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `symbolType` = @symbolType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32));
		}
		#endregion // RemoveBySymbolType
		#region RemoveBySymbolName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "symbolName">图标名字</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySymbolName(string symbolName, TransactionManager tm_ = null)
		{
			RepairRemoveBySymbolNameData(symbolName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySymbolNameAsync(string symbolName, TransactionManager tm_ = null)
		{
			RepairRemoveBySymbolNameData(symbolName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySymbolNameData(string symbolName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `symbolName` = @symbolName";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolName", symbolName, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySymbolName
		#region RemoveBySymbolMultiple3
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "symbolMultiple3">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySymbolMultiple3(int symbolMultiple3, TransactionManager tm_ = null)
		{
			RepairRemoveBySymbolMultiple3Data(symbolMultiple3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySymbolMultiple3Async(int symbolMultiple3, TransactionManager tm_ = null)
		{
			RepairRemoveBySymbolMultiple3Data(symbolMultiple3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySymbolMultiple3Data(int symbolMultiple3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `symbolMultiple3` = @symbolMultiple3";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolMultiple3", symbolMultiple3, MySqlDbType.Int32));
		}
		#endregion // RemoveBySymbolMultiple3
		#region RemoveBySymbolMultiple4
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "symbolMultiple4">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySymbolMultiple4(int symbolMultiple4, TransactionManager tm_ = null)
		{
			RepairRemoveBySymbolMultiple4Data(symbolMultiple4, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySymbolMultiple4Async(int symbolMultiple4, TransactionManager tm_ = null)
		{
			RepairRemoveBySymbolMultiple4Data(symbolMultiple4, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySymbolMultiple4Data(int symbolMultiple4, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `symbolMultiple4` = @symbolMultiple4";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolMultiple4", symbolMultiple4, MySqlDbType.Int32));
		}
		#endregion // RemoveBySymbolMultiple4
		#region RemoveBySymbolMultiple5
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "symbolMultiple5">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySymbolMultiple5(int symbolMultiple5, TransactionManager tm_ = null)
		{
			RepairRemoveBySymbolMultiple5Data(symbolMultiple5, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySymbolMultiple5Async(int symbolMultiple5, TransactionManager tm_ = null)
		{
			RepairRemoveBySymbolMultiple5Data(symbolMultiple5, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySymbolMultiple5Data(int symbolMultiple5, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `symbolMultiple5` = @symbolMultiple5";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolMultiple5", symbolMultiple5, MySqlDbType.Int32));
		}
		#endregion // RemoveBySymbolMultiple5
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
		public int Put(Big_config_symbolEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Big_config_symbolEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Big_config_symbolEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `symbolID` = @symbolID, `symbolType` = @symbolType, `symbolName` = @symbolName, `symbolMultiple3` = @symbolMultiple3, `symbolMultiple4` = @symbolMultiple4, `symbolMultiple5` = @symbolMultiple5 WHERE `symbolID` = @symbolID_Original AND `symbolType` = @symbolType_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolID", item.SymbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", item.SymbolType, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolName", item.SymbolName, MySqlDbType.VarChar),
				Database.CreateInParameter("@symbolMultiple3", item.SymbolMultiple3, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolMultiple4", item.SymbolMultiple4, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolMultiple5", item.SymbolMultiple5, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolID_Original", item.HasOriginal ? item.OriginalSymbolID : item.SymbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType_Original", item.HasOriginal ? item.OriginalSymbolType : item.SymbolType, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Big_config_symbolEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Big_config_symbolEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int symbolID, int symbolType, string set_, params object[] values_)
		{
			return Put(set_, "`symbolID` = @symbolID AND `symbolType` = @symbolType", ConcatValues(values_, symbolID, symbolType));
		}
		public async Task<int> PutByPKAsync(int symbolID, int symbolType, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`symbolID` = @symbolID AND `symbolType` = @symbolType", ConcatValues(values_, symbolID, symbolType));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int symbolID, int symbolType, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`symbolID` = @symbolID AND `symbolType` = @symbolType", tm_, ConcatValues(values_, symbolID, symbolType));
		}
		public async Task<int> PutByPKAsync(int symbolID, int symbolType, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`symbolID` = @symbolID AND `symbolType` = @symbolType", tm_, ConcatValues(values_, symbolID, symbolType));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int symbolID, int symbolType, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
	        };
			return Put(set_, "`symbolID` = @symbolID AND `symbolType` = @symbolType", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int symbolID, int symbolType, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`symbolID` = @symbolID AND `symbolType` = @symbolType", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutSymbolID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSymbolID(int symbolID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `symbolID` = @symbolID";
			var parameter_ = Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSymbolIDAsync(int symbolID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `symbolID` = @symbolID";
			var parameter_ = Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSymbolID
		#region PutSymbolType
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSymbolType(int symbolType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `symbolType` = @symbolType";
			var parameter_ = Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSymbolTypeAsync(int symbolType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `symbolType` = @symbolType";
			var parameter_ = Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSymbolType
		#region PutSymbolName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// /// <param name = "symbolName">图标名字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSymbolNameByPK(int symbolID, int symbolType, string symbolName, TransactionManager tm_ = null)
		{
			RepairPutSymbolNameByPKData(symbolID, symbolType, symbolName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSymbolNameByPKAsync(int symbolID, int symbolType, string symbolName, TransactionManager tm_ = null)
		{
			RepairPutSymbolNameByPKData(symbolID, symbolType, symbolName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSymbolNameByPKData(int symbolID, int symbolType, string symbolName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `symbolName` = @symbolName  WHERE `symbolID` = @symbolID AND `symbolType` = @symbolType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolName", symbolName, MySqlDbType.VarChar),
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "symbolName">图标名字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSymbolName(string symbolName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `symbolName` = @symbolName";
			var parameter_ = Database.CreateInParameter("@symbolName", symbolName, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSymbolNameAsync(string symbolName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `symbolName` = @symbolName";
			var parameter_ = Database.CreateInParameter("@symbolName", symbolName, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSymbolName
		#region PutSymbolMultiple3
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// /// <param name = "symbolMultiple3">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSymbolMultiple3ByPK(int symbolID, int symbolType, int symbolMultiple3, TransactionManager tm_ = null)
		{
			RepairPutSymbolMultiple3ByPKData(symbolID, symbolType, symbolMultiple3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSymbolMultiple3ByPKAsync(int symbolID, int symbolType, int symbolMultiple3, TransactionManager tm_ = null)
		{
			RepairPutSymbolMultiple3ByPKData(symbolID, symbolType, symbolMultiple3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSymbolMultiple3ByPKData(int symbolID, int symbolType, int symbolMultiple3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `symbolMultiple3` = @symbolMultiple3  WHERE `symbolID` = @symbolID AND `symbolType` = @symbolType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolMultiple3", symbolMultiple3, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "symbolMultiple3">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSymbolMultiple3(int symbolMultiple3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `symbolMultiple3` = @symbolMultiple3";
			var parameter_ = Database.CreateInParameter("@symbolMultiple3", symbolMultiple3, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSymbolMultiple3Async(int symbolMultiple3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `symbolMultiple3` = @symbolMultiple3";
			var parameter_ = Database.CreateInParameter("@symbolMultiple3", symbolMultiple3, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSymbolMultiple3
		#region PutSymbolMultiple4
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// /// <param name = "symbolMultiple4">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSymbolMultiple4ByPK(int symbolID, int symbolType, int symbolMultiple4, TransactionManager tm_ = null)
		{
			RepairPutSymbolMultiple4ByPKData(symbolID, symbolType, symbolMultiple4, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSymbolMultiple4ByPKAsync(int symbolID, int symbolType, int symbolMultiple4, TransactionManager tm_ = null)
		{
			RepairPutSymbolMultiple4ByPKData(symbolID, symbolType, symbolMultiple4, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSymbolMultiple4ByPKData(int symbolID, int symbolType, int symbolMultiple4, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `symbolMultiple4` = @symbolMultiple4  WHERE `symbolID` = @symbolID AND `symbolType` = @symbolType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolMultiple4", symbolMultiple4, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "symbolMultiple4">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSymbolMultiple4(int symbolMultiple4, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `symbolMultiple4` = @symbolMultiple4";
			var parameter_ = Database.CreateInParameter("@symbolMultiple4", symbolMultiple4, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSymbolMultiple4Async(int symbolMultiple4, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `symbolMultiple4` = @symbolMultiple4";
			var parameter_ = Database.CreateInParameter("@symbolMultiple4", symbolMultiple4, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSymbolMultiple4
		#region PutSymbolMultiple5
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// /// <param name = "symbolMultiple5">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSymbolMultiple5ByPK(int symbolID, int symbolType, int symbolMultiple5, TransactionManager tm_ = null)
		{
			RepairPutSymbolMultiple5ByPKData(symbolID, symbolType, symbolMultiple5, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSymbolMultiple5ByPKAsync(int symbolID, int symbolType, int symbolMultiple5, TransactionManager tm_ = null)
		{
			RepairPutSymbolMultiple5ByPKData(symbolID, symbolType, symbolMultiple5, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSymbolMultiple5ByPKData(int symbolID, int symbolType, int symbolMultiple5, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `symbolMultiple5` = @symbolMultiple5  WHERE `symbolID` = @symbolID AND `symbolType` = @symbolType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolMultiple5", symbolMultiple5, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "symbolMultiple5">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSymbolMultiple5(int symbolMultiple5, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `symbolMultiple5` = @symbolMultiple5";
			var parameter_ = Database.CreateInParameter("@symbolMultiple5", symbolMultiple5, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSymbolMultiple5Async(int symbolMultiple5, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `symbolMultiple5` = @symbolMultiple5";
			var parameter_ = Database.CreateInParameter("@symbolMultiple5", symbolMultiple5, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSymbolMultiple5
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Big_config_symbolEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.SymbolID, item.SymbolType) == null)
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
		public async Task<bool> SetAsync(Big_config_symbolEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.SymbolID, item.SymbolType) == null)
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
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Big_config_symbolEO GetByPK(int symbolID, int symbolType, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(symbolID, symbolType, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Big_config_symbolEO.MapDataReader);
		}
		public async Task<Big_config_symbolEO> GetByPKAsync(int symbolID, int symbolType, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(symbolID, symbolType, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Big_config_symbolEO.MapDataReader);
		}
		private void RepairGetByPKData(int symbolID, int symbolType, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`symbolID` = @symbolID AND `symbolType` = @symbolType", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 symbolID（字段）
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSymbolIDByPK(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`symbolID`", "`symbolID` = @symbolID AND `symbolType` = @symbolType", paras_, tm_);
		}
		public async Task<int> GetSymbolIDByPKAsync(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`symbolID`", "`symbolID` = @symbolID AND `symbolType` = @symbolType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 symbolType（字段）
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSymbolTypeByPK(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`symbolType`", "`symbolID` = @symbolID AND `symbolType` = @symbolType", paras_, tm_);
		}
		public async Task<int> GetSymbolTypeByPKAsync(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`symbolType`", "`symbolID` = @symbolID AND `symbolType` = @symbolType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 symbolName（字段）
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSymbolNameByPK(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
			return (string)GetScalar("`symbolName`", "`symbolID` = @symbolID AND `symbolType` = @symbolType", paras_, tm_);
		}
		public async Task<string> GetSymbolNameByPKAsync(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`symbolName`", "`symbolID` = @symbolID AND `symbolType` = @symbolType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 symbolMultiple3（字段）
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSymbolMultiple3ByPK(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`symbolMultiple3`", "`symbolID` = @symbolID AND `symbolType` = @symbolType", paras_, tm_);
		}
		public async Task<int> GetSymbolMultiple3ByPKAsync(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`symbolMultiple3`", "`symbolID` = @symbolID AND `symbolType` = @symbolType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 symbolMultiple4（字段）
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSymbolMultiple4ByPK(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`symbolMultiple4`", "`symbolID` = @symbolID AND `symbolType` = @symbolType", paras_, tm_);
		}
		public async Task<int> GetSymbolMultiple4ByPKAsync(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`symbolMultiple4`", "`symbolID` = @symbolID AND `symbolType` = @symbolType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 symbolMultiple5（字段）
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSymbolMultiple5ByPK(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`symbolMultiple5`", "`symbolID` = @symbolID AND `symbolType` = @symbolType", paras_, tm_);
		}
		public async Task<int> GetSymbolMultiple5ByPKAsync(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`symbolMultiple5`", "`symbolID` = @symbolID AND `symbolType` = @symbolType", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetBySymbolID
		
		/// <summary>
		/// 按 symbolID（字段） 查询
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolID(int symbolID)
		{
			return GetBySymbolID(symbolID, 0, string.Empty, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolIDAsync(int symbolID)
		{
			return await GetBySymbolIDAsync(symbolID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 symbolID（字段） 查询
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolID(int symbolID, TransactionManager tm_)
		{
			return GetBySymbolID(symbolID, 0, string.Empty, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolIDAsync(int symbolID, TransactionManager tm_)
		{
			return await GetBySymbolIDAsync(symbolID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 symbolID（字段） 查询
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolID(int symbolID, int top_)
		{
			return GetBySymbolID(symbolID, top_, string.Empty, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolIDAsync(int symbolID, int top_)
		{
			return await GetBySymbolIDAsync(symbolID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 symbolID（字段） 查询
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolID(int symbolID, int top_, TransactionManager tm_)
		{
			return GetBySymbolID(symbolID, top_, string.Empty, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolIDAsync(int symbolID, int top_, TransactionManager tm_)
		{
			return await GetBySymbolIDAsync(symbolID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 symbolID（字段） 查询
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolID(int symbolID, string sort_)
		{
			return GetBySymbolID(symbolID, 0, sort_, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolIDAsync(int symbolID, string sort_)
		{
			return await GetBySymbolIDAsync(symbolID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 symbolID（字段） 查询
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolID(int symbolID, string sort_, TransactionManager tm_)
		{
			return GetBySymbolID(symbolID, 0, sort_, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolIDAsync(int symbolID, string sort_, TransactionManager tm_)
		{
			return await GetBySymbolIDAsync(symbolID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 symbolID（字段） 查询
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolID(int symbolID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`symbolID` = @symbolID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_config_symbolEO.MapDataReader);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolIDAsync(int symbolID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`symbolID` = @symbolID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolID", symbolID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_config_symbolEO.MapDataReader);
		}
		#endregion // GetBySymbolID
		#region GetBySymbolType
		
		/// <summary>
		/// 按 symbolType（字段） 查询
		/// </summary>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolType(int symbolType)
		{
			return GetBySymbolType(symbolType, 0, string.Empty, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolTypeAsync(int symbolType)
		{
			return await GetBySymbolTypeAsync(symbolType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 symbolType（字段） 查询
		/// </summary>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolType(int symbolType, TransactionManager tm_)
		{
			return GetBySymbolType(symbolType, 0, string.Empty, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolTypeAsync(int symbolType, TransactionManager tm_)
		{
			return await GetBySymbolTypeAsync(symbolType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 symbolType（字段） 查询
		/// </summary>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolType(int symbolType, int top_)
		{
			return GetBySymbolType(symbolType, top_, string.Empty, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolTypeAsync(int symbolType, int top_)
		{
			return await GetBySymbolTypeAsync(symbolType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 symbolType（字段） 查询
		/// </summary>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolType(int symbolType, int top_, TransactionManager tm_)
		{
			return GetBySymbolType(symbolType, top_, string.Empty, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolTypeAsync(int symbolType, int top_, TransactionManager tm_)
		{
			return await GetBySymbolTypeAsync(symbolType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 symbolType（字段） 查询
		/// </summary>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolType(int symbolType, string sort_)
		{
			return GetBySymbolType(symbolType, 0, sort_, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolTypeAsync(int symbolType, string sort_)
		{
			return await GetBySymbolTypeAsync(symbolType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 symbolType（字段） 查询
		/// </summary>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolType(int symbolType, string sort_, TransactionManager tm_)
		{
			return GetBySymbolType(symbolType, 0, sort_, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolTypeAsync(int symbolType, string sort_, TransactionManager tm_)
		{
			return await GetBySymbolTypeAsync(symbolType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 symbolType（字段） 查询
		/// </summary>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolType(int symbolType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`symbolType` = @symbolType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_config_symbolEO.MapDataReader);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolTypeAsync(int symbolType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`symbolType` = @symbolType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolType", symbolType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_config_symbolEO.MapDataReader);
		}
		#endregion // GetBySymbolType
		#region GetBySymbolName
		
		/// <summary>
		/// 按 symbolName（字段） 查询
		/// </summary>
		/// /// <param name = "symbolName">图标名字</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolName(string symbolName)
		{
			return GetBySymbolName(symbolName, 0, string.Empty, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolNameAsync(string symbolName)
		{
			return await GetBySymbolNameAsync(symbolName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 symbolName（字段） 查询
		/// </summary>
		/// /// <param name = "symbolName">图标名字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolName(string symbolName, TransactionManager tm_)
		{
			return GetBySymbolName(symbolName, 0, string.Empty, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolNameAsync(string symbolName, TransactionManager tm_)
		{
			return await GetBySymbolNameAsync(symbolName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 symbolName（字段） 查询
		/// </summary>
		/// /// <param name = "symbolName">图标名字</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolName(string symbolName, int top_)
		{
			return GetBySymbolName(symbolName, top_, string.Empty, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolNameAsync(string symbolName, int top_)
		{
			return await GetBySymbolNameAsync(symbolName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 symbolName（字段） 查询
		/// </summary>
		/// /// <param name = "symbolName">图标名字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolName(string symbolName, int top_, TransactionManager tm_)
		{
			return GetBySymbolName(symbolName, top_, string.Empty, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolNameAsync(string symbolName, int top_, TransactionManager tm_)
		{
			return await GetBySymbolNameAsync(symbolName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 symbolName（字段） 查询
		/// </summary>
		/// /// <param name = "symbolName">图标名字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolName(string symbolName, string sort_)
		{
			return GetBySymbolName(symbolName, 0, sort_, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolNameAsync(string symbolName, string sort_)
		{
			return await GetBySymbolNameAsync(symbolName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 symbolName（字段） 查询
		/// </summary>
		/// /// <param name = "symbolName">图标名字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolName(string symbolName, string sort_, TransactionManager tm_)
		{
			return GetBySymbolName(symbolName, 0, sort_, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolNameAsync(string symbolName, string sort_, TransactionManager tm_)
		{
			return await GetBySymbolNameAsync(symbolName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 symbolName（字段） 查询
		/// </summary>
		/// /// <param name = "symbolName">图标名字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolName(string symbolName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`symbolName` = @symbolName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolName", symbolName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_config_symbolEO.MapDataReader);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolNameAsync(string symbolName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`symbolName` = @symbolName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolName", symbolName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_config_symbolEO.MapDataReader);
		}
		#endregion // GetBySymbolName
		#region GetBySymbolMultiple3
		
		/// <summary>
		/// 按 symbolMultiple3（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple3">图标ICON基础倍率</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple3(int symbolMultiple3)
		{
			return GetBySymbolMultiple3(symbolMultiple3, 0, string.Empty, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple3Async(int symbolMultiple3)
		{
			return await GetBySymbolMultiple3Async(symbolMultiple3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 symbolMultiple3（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple3">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple3(int symbolMultiple3, TransactionManager tm_)
		{
			return GetBySymbolMultiple3(symbolMultiple3, 0, string.Empty, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple3Async(int symbolMultiple3, TransactionManager tm_)
		{
			return await GetBySymbolMultiple3Async(symbolMultiple3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 symbolMultiple3（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple3">图标ICON基础倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple3(int symbolMultiple3, int top_)
		{
			return GetBySymbolMultiple3(symbolMultiple3, top_, string.Empty, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple3Async(int symbolMultiple3, int top_)
		{
			return await GetBySymbolMultiple3Async(symbolMultiple3, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 symbolMultiple3（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple3">图标ICON基础倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple3(int symbolMultiple3, int top_, TransactionManager tm_)
		{
			return GetBySymbolMultiple3(symbolMultiple3, top_, string.Empty, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple3Async(int symbolMultiple3, int top_, TransactionManager tm_)
		{
			return await GetBySymbolMultiple3Async(symbolMultiple3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 symbolMultiple3（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple3">图标ICON基础倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple3(int symbolMultiple3, string sort_)
		{
			return GetBySymbolMultiple3(symbolMultiple3, 0, sort_, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple3Async(int symbolMultiple3, string sort_)
		{
			return await GetBySymbolMultiple3Async(symbolMultiple3, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 symbolMultiple3（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple3">图标ICON基础倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple3(int symbolMultiple3, string sort_, TransactionManager tm_)
		{
			return GetBySymbolMultiple3(symbolMultiple3, 0, sort_, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple3Async(int symbolMultiple3, string sort_, TransactionManager tm_)
		{
			return await GetBySymbolMultiple3Async(symbolMultiple3, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 symbolMultiple3（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple3">图标ICON基础倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple3(int symbolMultiple3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`symbolMultiple3` = @symbolMultiple3", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolMultiple3", symbolMultiple3, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_config_symbolEO.MapDataReader);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple3Async(int symbolMultiple3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`symbolMultiple3` = @symbolMultiple3", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolMultiple3", symbolMultiple3, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_config_symbolEO.MapDataReader);
		}
		#endregion // GetBySymbolMultiple3
		#region GetBySymbolMultiple4
		
		/// <summary>
		/// 按 symbolMultiple4（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple4">图标ICON基础倍率</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple4(int symbolMultiple4)
		{
			return GetBySymbolMultiple4(symbolMultiple4, 0, string.Empty, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple4Async(int symbolMultiple4)
		{
			return await GetBySymbolMultiple4Async(symbolMultiple4, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 symbolMultiple4（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple4">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple4(int symbolMultiple4, TransactionManager tm_)
		{
			return GetBySymbolMultiple4(symbolMultiple4, 0, string.Empty, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple4Async(int symbolMultiple4, TransactionManager tm_)
		{
			return await GetBySymbolMultiple4Async(symbolMultiple4, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 symbolMultiple4（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple4">图标ICON基础倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple4(int symbolMultiple4, int top_)
		{
			return GetBySymbolMultiple4(symbolMultiple4, top_, string.Empty, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple4Async(int symbolMultiple4, int top_)
		{
			return await GetBySymbolMultiple4Async(symbolMultiple4, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 symbolMultiple4（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple4">图标ICON基础倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple4(int symbolMultiple4, int top_, TransactionManager tm_)
		{
			return GetBySymbolMultiple4(symbolMultiple4, top_, string.Empty, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple4Async(int symbolMultiple4, int top_, TransactionManager tm_)
		{
			return await GetBySymbolMultiple4Async(symbolMultiple4, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 symbolMultiple4（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple4">图标ICON基础倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple4(int symbolMultiple4, string sort_)
		{
			return GetBySymbolMultiple4(symbolMultiple4, 0, sort_, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple4Async(int symbolMultiple4, string sort_)
		{
			return await GetBySymbolMultiple4Async(symbolMultiple4, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 symbolMultiple4（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple4">图标ICON基础倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple4(int symbolMultiple4, string sort_, TransactionManager tm_)
		{
			return GetBySymbolMultiple4(symbolMultiple4, 0, sort_, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple4Async(int symbolMultiple4, string sort_, TransactionManager tm_)
		{
			return await GetBySymbolMultiple4Async(symbolMultiple4, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 symbolMultiple4（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple4">图标ICON基础倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple4(int symbolMultiple4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`symbolMultiple4` = @symbolMultiple4", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolMultiple4", symbolMultiple4, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_config_symbolEO.MapDataReader);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple4Async(int symbolMultiple4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`symbolMultiple4` = @symbolMultiple4", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolMultiple4", symbolMultiple4, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_config_symbolEO.MapDataReader);
		}
		#endregion // GetBySymbolMultiple4
		#region GetBySymbolMultiple5
		
		/// <summary>
		/// 按 symbolMultiple5（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple5">图标ICON基础倍率</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple5(int symbolMultiple5)
		{
			return GetBySymbolMultiple5(symbolMultiple5, 0, string.Empty, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple5Async(int symbolMultiple5)
		{
			return await GetBySymbolMultiple5Async(symbolMultiple5, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 symbolMultiple5（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple5">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple5(int symbolMultiple5, TransactionManager tm_)
		{
			return GetBySymbolMultiple5(symbolMultiple5, 0, string.Empty, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple5Async(int symbolMultiple5, TransactionManager tm_)
		{
			return await GetBySymbolMultiple5Async(symbolMultiple5, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 symbolMultiple5（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple5">图标ICON基础倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple5(int symbolMultiple5, int top_)
		{
			return GetBySymbolMultiple5(symbolMultiple5, top_, string.Empty, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple5Async(int symbolMultiple5, int top_)
		{
			return await GetBySymbolMultiple5Async(symbolMultiple5, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 symbolMultiple5（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple5">图标ICON基础倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple5(int symbolMultiple5, int top_, TransactionManager tm_)
		{
			return GetBySymbolMultiple5(symbolMultiple5, top_, string.Empty, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple5Async(int symbolMultiple5, int top_, TransactionManager tm_)
		{
			return await GetBySymbolMultiple5Async(symbolMultiple5, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 symbolMultiple5（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple5">图标ICON基础倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple5(int symbolMultiple5, string sort_)
		{
			return GetBySymbolMultiple5(symbolMultiple5, 0, sort_, null);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple5Async(int symbolMultiple5, string sort_)
		{
			return await GetBySymbolMultiple5Async(symbolMultiple5, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 symbolMultiple5（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple5">图标ICON基础倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple5(int symbolMultiple5, string sort_, TransactionManager tm_)
		{
			return GetBySymbolMultiple5(symbolMultiple5, 0, sort_, tm_);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple5Async(int symbolMultiple5, string sort_, TransactionManager tm_)
		{
			return await GetBySymbolMultiple5Async(symbolMultiple5, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 symbolMultiple5（字段） 查询
		/// </summary>
		/// /// <param name = "symbolMultiple5">图标ICON基础倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Big_config_symbolEO> GetBySymbolMultiple5(int symbolMultiple5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`symbolMultiple5` = @symbolMultiple5", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolMultiple5", symbolMultiple5, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Big_config_symbolEO.MapDataReader);
		}
		public async Task<List<Big_config_symbolEO>> GetBySymbolMultiple5Async(int symbolMultiple5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`symbolMultiple5` = @symbolMultiple5", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@symbolMultiple5", symbolMultiple5, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Big_config_symbolEO.MapDataReader);
		}
		#endregion // GetBySymbolMultiple5
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
