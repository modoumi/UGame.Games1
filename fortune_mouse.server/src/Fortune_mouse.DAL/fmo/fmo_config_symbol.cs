/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-19 16: 34:39
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

namespace Fortune_mouse.DAL
{
	#region EO
	/// <summary>
	/// 图标ICON权重表
	/// 【表 fmo_config_symbol 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Fmo_config_symbolEO : IRowMapper<Fmo_config_symbolEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Fmo_config_symbolEO()
		{
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalSymbolID;
		/// <summary>
		/// 【数据库中的原始主键 SymbolID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalSymbolID
		{
			get { return _originalSymbolID; }
			set { HasOriginal = true; _originalSymbolID = value; }
		}
		
		private int _originalSymbolType;
		/// <summary>
		/// 【数据库中的原始主键 SymbolType 值的副本，用于主键值更新】
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
		/// 图标ICON权重
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int Weight { get; set; }
		/// <summary>
		/// 图标ICON基础倍率
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int Multip { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Fmo_config_symbolEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Fmo_config_symbolEO MapDataReader(IDataReader reader)
		{
		    Fmo_config_symbolEO ret = new Fmo_config_symbolEO();
			ret.SymbolID = reader.ToInt32("SymbolID");
			ret.OriginalSymbolID = ret.SymbolID;
			ret.SymbolType = reader.ToInt32("SymbolType");
			ret.OriginalSymbolType = ret.SymbolType;
			ret.SymbolName = reader.ToString("SymbolName");
			ret.Weight = reader.ToInt32("Weight");
			ret.Multip = reader.ToInt32("Multip");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 图标ICON权重表
	/// 【表 fmo_config_symbol 的操作类】
	/// </summary>
	[Obsolete]
	public class Fmo_config_symbolMO : MySqlTableMO<Fmo_config_symbolEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`fmo_config_symbol`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Fmo_config_symbolMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Fmo_config_symbolMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Fmo_config_symbolMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Fmo_config_symbolEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Fmo_config_symbolEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Fmo_config_symbolEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`SymbolID`, `SymbolType`, `SymbolName`, `Weight`, `Multip`) VALUE (@SymbolID, @SymbolType, @SymbolName, @Weight, @Multip);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SymbolID", item.SymbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", item.SymbolType, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolName", item.SymbolName, MySqlDbType.VarChar),
				Database.CreateInParameter("@Weight", item.Weight, MySqlDbType.Int32),
				Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Fmo_config_symbolEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Fmo_config_symbolEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Fmo_config_symbolEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`SymbolID`, `SymbolType`, `SymbolName`, `Weight`, `Multip`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.SymbolID},{item.SymbolType},'{item.SymbolName}',{item.Weight},{item.Multip}),");
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
			sql_ = $"DELETE FROM {TableName} WHERE `SymbolID` = @SymbolID AND `SymbolType` = @SymbolType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Fmo_config_symbolEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.SymbolID, item.SymbolType, tm_);
		}
		public async Task<int> RemoveAsync(Fmo_config_symbolEO item, TransactionManager tm_ = null)
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
			sql_ = $"DELETE FROM {TableName} WHERE `SymbolID` = @SymbolID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32));
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
			sql_ = $"DELETE FROM {TableName} WHERE `SymbolType` = @SymbolType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32));
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
			sql_ = $"DELETE FROM {TableName} WHERE `SymbolName` = @SymbolName";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SymbolName", symbolName, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySymbolName
		#region RemoveByWeight
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight">图标ICON权重</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeight(int weight, TransactionManager tm_ = null)
		{
			RepairRemoveByWeightData(weight, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeightAsync(int weight, TransactionManager tm_ = null)
		{
			RepairRemoveByWeightData(weight, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeightData(int weight, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Weight` = @Weight";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
		}
		#endregion // RemoveByWeight
		#region RemoveByMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "multip">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMultip(int multip, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipData(multip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMultipAsync(int multip, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipData(multip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMultipData(int multip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Multip` = @Multip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
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
		public int Put(Fmo_config_symbolEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Fmo_config_symbolEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Fmo_config_symbolEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SymbolID` = @SymbolID, `SymbolType` = @SymbolType, `SymbolName` = @SymbolName, `Weight` = @Weight, `Multip` = @Multip WHERE `SymbolID` = @SymbolID_Original AND `SymbolType` = @SymbolType_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SymbolID", item.SymbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", item.SymbolType, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolName", item.SymbolName, MySqlDbType.VarChar),
				Database.CreateInParameter("@Weight", item.Weight, MySqlDbType.Int32),
				Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolID_Original", item.HasOriginal ? item.OriginalSymbolID : item.SymbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType_Original", item.HasOriginal ? item.OriginalSymbolType : item.SymbolType, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Fmo_config_symbolEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Fmo_config_symbolEO> items, TransactionManager tm_ = null)
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
			return Put(set_, "`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", ConcatValues(values_, symbolID, symbolType));
		}
		public async Task<int> PutByPKAsync(int symbolID, int symbolType, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", ConcatValues(values_, symbolID, symbolType));
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
			return Put(set_, "`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", tm_, ConcatValues(values_, symbolID, symbolType));
		}
		public async Task<int> PutByPKAsync(int symbolID, int symbolType, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", tm_, ConcatValues(values_, symbolID, symbolType));
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
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
	        };
			return Put(set_, "`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int symbolID, int symbolType, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", ConcatParameters(paras_, newParas_), tm_);
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
			string sql_ = $"UPDATE {TableName} SET `SymbolID` = @SymbolID";
			var parameter_ = Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSymbolIDAsync(int symbolID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SymbolID` = @SymbolID";
			var parameter_ = Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32);
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
			string sql_ = $"UPDATE {TableName} SET `SymbolType` = @SymbolType";
			var parameter_ = Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSymbolTypeAsync(int symbolType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SymbolType` = @SymbolType";
			var parameter_ = Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32);
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
			sql_ = $"UPDATE {TableName} SET `SymbolName` = @SymbolName  WHERE `SymbolID` = @SymbolID AND `SymbolType` = @SymbolType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SymbolName", symbolName, MySqlDbType.VarChar),
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
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
			string sql_ = $"UPDATE {TableName} SET `SymbolName` = @SymbolName";
			var parameter_ = Database.CreateInParameter("@SymbolName", symbolName, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSymbolNameAsync(string symbolName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SymbolName` = @SymbolName";
			var parameter_ = Database.CreateInParameter("@SymbolName", symbolName, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSymbolName
		#region PutWeight
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// /// <param name = "weight">图标ICON权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeightByPK(int symbolID, int symbolType, int weight, TransactionManager tm_ = null)
		{
			RepairPutWeightByPKData(symbolID, symbolType, weight, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeightByPKAsync(int symbolID, int symbolType, int weight, TransactionManager tm_ = null)
		{
			RepairPutWeightByPKData(symbolID, symbolType, weight, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeightByPKData(int symbolID, int symbolType, int weight, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight` = @Weight  WHERE `SymbolID` = @SymbolID AND `SymbolType` = @SymbolType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight">图标ICON权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight(int weight, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight` = @Weight";
			var parameter_ = Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeightAsync(int weight, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight` = @Weight";
			var parameter_ = Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWeight
		#region PutMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// /// <param name = "multip">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultipByPK(int symbolID, int symbolType, int multip, TransactionManager tm_ = null)
		{
			RepairPutMultipByPKData(symbolID, symbolType, multip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMultipByPKAsync(int symbolID, int symbolType, int multip, TransactionManager tm_ = null)
		{
			RepairPutMultipByPKData(symbolID, symbolType, multip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMultipByPKData(int symbolID, int symbolType, int multip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Multip` = @Multip  WHERE `SymbolID` = @SymbolID AND `SymbolType` = @SymbolType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "multip">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultip(int multip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multip` = @Multip";
			var parameter_ = Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMultipAsync(int multip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multip` = @Multip";
			var parameter_ = Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32);
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
		public bool Set(Fmo_config_symbolEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Fmo_config_symbolEO item, TransactionManager tm = null)
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
		public Fmo_config_symbolEO GetByPK(int symbolID, int symbolType, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(symbolID, symbolType, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Fmo_config_symbolEO.MapDataReader);
		}
		public async Task<Fmo_config_symbolEO> GetByPKAsync(int symbolID, int symbolType, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(symbolID, symbolType, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Fmo_config_symbolEO.MapDataReader);
		}
		private void RepairGetByPKData(int symbolID, int symbolType, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 SymbolID（字段）
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSymbolIDByPK(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`SymbolID`", "`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", paras_, tm_);
		}
		public async Task<int> GetSymbolIDByPKAsync(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`SymbolID`", "`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SymbolType（字段）
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSymbolTypeByPK(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`SymbolType`", "`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", paras_, tm_);
		}
		public async Task<int> GetSymbolTypeByPKAsync(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`SymbolType`", "`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SymbolName（字段）
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSymbolNameByPK(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
			};
			return (string)GetScalar("`SymbolName`", "`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", paras_, tm_);
		}
		public async Task<string> GetSymbolNameByPKAsync(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`SymbolName`", "`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight（字段）
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeightByPK(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Weight`", "`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", paras_, tm_);
		}
		public async Task<int> GetWeightByPKAsync(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Weight`", "`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Multip（字段）
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMultipByPK(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Multip`", "`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", paras_, tm_);
		}
		public async Task<int> GetMultipByPKAsync(int symbolID, int symbolType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32),
				Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Multip`", "`SymbolID` = @SymbolID AND `SymbolType` = @SymbolType", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetBySymbolID
		
		/// <summary>
		/// 按 SymbolID（字段） 查询
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolID(int symbolID)
		{
			return GetBySymbolID(symbolID, 0, string.Empty, null);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolIDAsync(int symbolID)
		{
			return await GetBySymbolIDAsync(symbolID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SymbolID（字段） 查询
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolID(int symbolID, TransactionManager tm_)
		{
			return GetBySymbolID(symbolID, 0, string.Empty, tm_);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolIDAsync(int symbolID, TransactionManager tm_)
		{
			return await GetBySymbolIDAsync(symbolID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SymbolID（字段） 查询
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolID(int symbolID, int top_)
		{
			return GetBySymbolID(symbolID, top_, string.Empty, null);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolIDAsync(int symbolID, int top_)
		{
			return await GetBySymbolIDAsync(symbolID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SymbolID（字段） 查询
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolID(int symbolID, int top_, TransactionManager tm_)
		{
			return GetBySymbolID(symbolID, top_, string.Empty, tm_);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolIDAsync(int symbolID, int top_, TransactionManager tm_)
		{
			return await GetBySymbolIDAsync(symbolID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SymbolID（字段） 查询
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolID(int symbolID, string sort_)
		{
			return GetBySymbolID(symbolID, 0, sort_, null);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolIDAsync(int symbolID, string sort_)
		{
			return await GetBySymbolIDAsync(symbolID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SymbolID（字段） 查询
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolID(int symbolID, string sort_, TransactionManager tm_)
		{
			return GetBySymbolID(symbolID, 0, sort_, tm_);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolIDAsync(int symbolID, string sort_, TransactionManager tm_)
		{
			return await GetBySymbolIDAsync(symbolID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SymbolID（字段） 查询
		/// </summary>
		/// /// <param name = "symbolID">主键</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolID(int symbolID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SymbolID` = @SymbolID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fmo_config_symbolEO.MapDataReader);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolIDAsync(int symbolID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SymbolID` = @SymbolID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SymbolID", symbolID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fmo_config_symbolEO.MapDataReader);
		}
		#endregion // GetBySymbolID
		#region GetBySymbolType
		
		/// <summary>
		/// 按 SymbolType（字段） 查询
		/// </summary>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolType(int symbolType)
		{
			return GetBySymbolType(symbolType, 0, string.Empty, null);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolTypeAsync(int symbolType)
		{
			return await GetBySymbolTypeAsync(symbolType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SymbolType（字段） 查询
		/// </summary>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolType(int symbolType, TransactionManager tm_)
		{
			return GetBySymbolType(symbolType, 0, string.Empty, tm_);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolTypeAsync(int symbolType, TransactionManager tm_)
		{
			return await GetBySymbolTypeAsync(symbolType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SymbolType（字段） 查询
		/// </summary>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolType(int symbolType, int top_)
		{
			return GetBySymbolType(symbolType, top_, string.Empty, null);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolTypeAsync(int symbolType, int top_)
		{
			return await GetBySymbolTypeAsync(symbolType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SymbolType（字段） 查询
		/// </summary>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolType(int symbolType, int top_, TransactionManager tm_)
		{
			return GetBySymbolType(symbolType, top_, string.Empty, tm_);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolTypeAsync(int symbolType, int top_, TransactionManager tm_)
		{
			return await GetBySymbolTypeAsync(symbolType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SymbolType（字段） 查询
		/// </summary>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolType(int symbolType, string sort_)
		{
			return GetBySymbolType(symbolType, 0, sort_, null);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolTypeAsync(int symbolType, string sort_)
		{
			return await GetBySymbolTypeAsync(symbolType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SymbolType（字段） 查询
		/// </summary>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolType(int symbolType, string sort_, TransactionManager tm_)
		{
			return GetBySymbolType(symbolType, 0, sort_, tm_);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolTypeAsync(int symbolType, string sort_, TransactionManager tm_)
		{
			return await GetBySymbolTypeAsync(symbolType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SymbolType（字段） 查询
		/// </summary>
		/// /// <param name = "symbolType">1-普通,2-万能</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolType(int symbolType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SymbolType` = @SymbolType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fmo_config_symbolEO.MapDataReader);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolTypeAsync(int symbolType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SymbolType` = @SymbolType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SymbolType", symbolType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fmo_config_symbolEO.MapDataReader);
		}
		#endregion // GetBySymbolType
		#region GetBySymbolName
		
		/// <summary>
		/// 按 SymbolName（字段） 查询
		/// </summary>
		/// /// <param name = "symbolName">图标名字</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolName(string symbolName)
		{
			return GetBySymbolName(symbolName, 0, string.Empty, null);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolNameAsync(string symbolName)
		{
			return await GetBySymbolNameAsync(symbolName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SymbolName（字段） 查询
		/// </summary>
		/// /// <param name = "symbolName">图标名字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolName(string symbolName, TransactionManager tm_)
		{
			return GetBySymbolName(symbolName, 0, string.Empty, tm_);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolNameAsync(string symbolName, TransactionManager tm_)
		{
			return await GetBySymbolNameAsync(symbolName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SymbolName（字段） 查询
		/// </summary>
		/// /// <param name = "symbolName">图标名字</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolName(string symbolName, int top_)
		{
			return GetBySymbolName(symbolName, top_, string.Empty, null);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolNameAsync(string symbolName, int top_)
		{
			return await GetBySymbolNameAsync(symbolName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SymbolName（字段） 查询
		/// </summary>
		/// /// <param name = "symbolName">图标名字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolName(string symbolName, int top_, TransactionManager tm_)
		{
			return GetBySymbolName(symbolName, top_, string.Empty, tm_);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolNameAsync(string symbolName, int top_, TransactionManager tm_)
		{
			return await GetBySymbolNameAsync(symbolName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SymbolName（字段） 查询
		/// </summary>
		/// /// <param name = "symbolName">图标名字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolName(string symbolName, string sort_)
		{
			return GetBySymbolName(symbolName, 0, sort_, null);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolNameAsync(string symbolName, string sort_)
		{
			return await GetBySymbolNameAsync(symbolName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SymbolName（字段） 查询
		/// </summary>
		/// /// <param name = "symbolName">图标名字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolName(string symbolName, string sort_, TransactionManager tm_)
		{
			return GetBySymbolName(symbolName, 0, sort_, tm_);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolNameAsync(string symbolName, string sort_, TransactionManager tm_)
		{
			return await GetBySymbolNameAsync(symbolName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SymbolName（字段） 查询
		/// </summary>
		/// /// <param name = "symbolName">图标名字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetBySymbolName(string symbolName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SymbolName` = @SymbolName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SymbolName", symbolName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fmo_config_symbolEO.MapDataReader);
		}
		public async Task<List<Fmo_config_symbolEO>> GetBySymbolNameAsync(string symbolName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SymbolName` = @SymbolName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SymbolName", symbolName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fmo_config_symbolEO.MapDataReader);
		}
		#endregion // GetBySymbolName
		#region GetByWeight
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">图标ICON权重</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetByWeight(int weight)
		{
			return GetByWeight(weight, 0, string.Empty, null);
		}
		public async Task<List<Fmo_config_symbolEO>> GetByWeightAsync(int weight)
		{
			return await GetByWeightAsync(weight, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">图标ICON权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetByWeight(int weight, TransactionManager tm_)
		{
			return GetByWeight(weight, 0, string.Empty, tm_);
		}
		public async Task<List<Fmo_config_symbolEO>> GetByWeightAsync(int weight, TransactionManager tm_)
		{
			return await GetByWeightAsync(weight, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">图标ICON权重</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetByWeight(int weight, int top_)
		{
			return GetByWeight(weight, top_, string.Empty, null);
		}
		public async Task<List<Fmo_config_symbolEO>> GetByWeightAsync(int weight, int top_)
		{
			return await GetByWeightAsync(weight, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">图标ICON权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetByWeight(int weight, int top_, TransactionManager tm_)
		{
			return GetByWeight(weight, top_, string.Empty, tm_);
		}
		public async Task<List<Fmo_config_symbolEO>> GetByWeightAsync(int weight, int top_, TransactionManager tm_)
		{
			return await GetByWeightAsync(weight, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">图标ICON权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetByWeight(int weight, string sort_)
		{
			return GetByWeight(weight, 0, sort_, null);
		}
		public async Task<List<Fmo_config_symbolEO>> GetByWeightAsync(int weight, string sort_)
		{
			return await GetByWeightAsync(weight, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">图标ICON权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetByWeight(int weight, string sort_, TransactionManager tm_)
		{
			return GetByWeight(weight, 0, sort_, tm_);
		}
		public async Task<List<Fmo_config_symbolEO>> GetByWeightAsync(int weight, string sort_, TransactionManager tm_)
		{
			return await GetByWeightAsync(weight, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">图标ICON权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetByWeight(int weight, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight` = @Weight", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fmo_config_symbolEO.MapDataReader);
		}
		public async Task<List<Fmo_config_symbolEO>> GetByWeightAsync(int weight, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight` = @Weight", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fmo_config_symbolEO.MapDataReader);
		}
		#endregion // GetByWeight
		#region GetByMultip
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">图标ICON基础倍率</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetByMultip(int multip)
		{
			return GetByMultip(multip, 0, string.Empty, null);
		}
		public async Task<List<Fmo_config_symbolEO>> GetByMultipAsync(int multip)
		{
			return await GetByMultipAsync(multip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetByMultip(int multip, TransactionManager tm_)
		{
			return GetByMultip(multip, 0, string.Empty, tm_);
		}
		public async Task<List<Fmo_config_symbolEO>> GetByMultipAsync(int multip, TransactionManager tm_)
		{
			return await GetByMultipAsync(multip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">图标ICON基础倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetByMultip(int multip, int top_)
		{
			return GetByMultip(multip, top_, string.Empty, null);
		}
		public async Task<List<Fmo_config_symbolEO>> GetByMultipAsync(int multip, int top_)
		{
			return await GetByMultipAsync(multip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">图标ICON基础倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetByMultip(int multip, int top_, TransactionManager tm_)
		{
			return GetByMultip(multip, top_, string.Empty, tm_);
		}
		public async Task<List<Fmo_config_symbolEO>> GetByMultipAsync(int multip, int top_, TransactionManager tm_)
		{
			return await GetByMultipAsync(multip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">图标ICON基础倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetByMultip(int multip, string sort_)
		{
			return GetByMultip(multip, 0, sort_, null);
		}
		public async Task<List<Fmo_config_symbolEO>> GetByMultipAsync(int multip, string sort_)
		{
			return await GetByMultipAsync(multip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">图标ICON基础倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetByMultip(int multip, string sort_, TransactionManager tm_)
		{
			return GetByMultip(multip, 0, sort_, tm_);
		}
		public async Task<List<Fmo_config_symbolEO>> GetByMultipAsync(int multip, string sort_, TransactionManager tm_)
		{
			return await GetByMultipAsync(multip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">图标ICON基础倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fmo_config_symbolEO> GetByMultip(int multip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fmo_config_symbolEO.MapDataReader);
		}
		public async Task<List<Fmo_config_symbolEO>> GetByMultipAsync(int multip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fmo_config_symbolEO.MapDataReader);
		}
		#endregion // GetByMultip
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
