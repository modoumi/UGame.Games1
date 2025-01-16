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
	/// Btest 小玩法配置
	/// 【表 slot_config_base_other 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Slot_config_base_otherEO : IRowMapper<Slot_config_base_otherEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Slot_config_base_otherEO()
		{
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalItemId;
		/// <summary>
		/// 【数据库中的原始主键 ItemId 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalItemId
		{
			get { return _originalItemId; }
			set { HasOriginal = true; _originalItemId = value; }
		}
		
		private int _originalLineNum;
		/// <summary>
		/// 【数据库中的原始主键 LineNum 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalLineNum
		{
			get { return _originalLineNum; }
			set { HasOriginal = true; _originalLineNum = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ItemId", ItemId },  { "LineNum", LineNum }, };
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
		public int ItemId { get; set; }
		/// <summary>
		/// 
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int LineNum { get; set; }
		/// <summary>
		/// 
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int Weight { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Slot_config_base_otherEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Slot_config_base_otherEO MapDataReader(IDataReader reader)
		{
		    Slot_config_base_otherEO ret = new Slot_config_base_otherEO();
			ret.ItemId = reader.ToInt32("ItemId");
			ret.OriginalItemId = ret.ItemId;
			ret.LineNum = reader.ToInt32("LineNum");
			ret.OriginalLineNum = ret.LineNum;
			ret.Weight = reader.ToInt32("Weight");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// Btest 小玩法配置
	/// 【表 slot_config_base_other 的操作类】
	/// </summary>
	[Obsolete]
	public class Slot_config_base_otherMO : MySqlTableMO<Slot_config_base_otherEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`slot_config_base_other`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Slot_config_base_otherMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Slot_config_base_otherMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Slot_config_base_otherMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Slot_config_base_otherEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Slot_config_base_otherEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Slot_config_base_otherEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ItemId`, `LineNum`, `Weight`) VALUE (@ItemId, @LineNum, @Weight);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemId", item.ItemId, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNum", item.LineNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight", item.Weight, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Slot_config_base_otherEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Slot_config_base_otherEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Slot_config_base_otherEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ItemId`, `LineNum`, `Weight`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.ItemId},{item.LineNum},{item.Weight}),");
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
		/// /// <param name = "itemId"></param>
		/// /// <param name = "lineNum"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int itemId, int lineNum, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemId, lineNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int itemId, int lineNum, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemId, lineNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int itemId, int lineNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemId` = @ItemId AND `LineNum` = @LineNum";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemId", itemId, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Slot_config_base_otherEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ItemId, item.LineNum, tm_);
		}
		public async Task<int> RemoveAsync(Slot_config_base_otherEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ItemId, item.LineNum, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByItemId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "itemId"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByItemId(int itemId, TransactionManager tm_ = null)
		{
			RepairRemoveByItemIdData(itemId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByItemIdAsync(int itemId, TransactionManager tm_ = null)
		{
			RepairRemoveByItemIdData(itemId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByItemIdData(int itemId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemId` = @ItemId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemId", itemId, MySqlDbType.Int32));
		}
		#endregion // RemoveByItemId
		#region RemoveByLineNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lineNum"></param>
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
		#region RemoveByWeight
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight"></param>
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
		public int Put(Slot_config_base_otherEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Slot_config_base_otherEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Slot_config_base_otherEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemId` = @ItemId, `LineNum` = @LineNum, `Weight` = @Weight WHERE `ItemId` = @ItemId_Original AND `LineNum` = @LineNum_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemId", item.ItemId, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNum", item.LineNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight", item.Weight, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemId_Original", item.HasOriginal ? item.OriginalItemId : item.ItemId, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNum_Original", item.HasOriginal ? item.OriginalLineNum : item.LineNum, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Slot_config_base_otherEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Slot_config_base_otherEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "itemId"></param>
		/// /// <param name = "lineNum"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemId, int lineNum, string set_, params object[] values_)
		{
			return Put(set_, "`ItemId` = @ItemId AND `LineNum` = @LineNum", ConcatValues(values_, itemId, lineNum));
		}
		public async Task<int> PutByPKAsync(int itemId, int lineNum, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemId` = @ItemId AND `LineNum` = @LineNum", ConcatValues(values_, itemId, lineNum));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemId"></param>
		/// /// <param name = "lineNum"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemId, int lineNum, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ItemId` = @ItemId AND `LineNum` = @LineNum", tm_, ConcatValues(values_, itemId, lineNum));
		}
		public async Task<int> PutByPKAsync(int itemId, int lineNum, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemId` = @ItemId AND `LineNum` = @LineNum", tm_, ConcatValues(values_, itemId, lineNum));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemId"></param>
		/// /// <param name = "lineNum"></param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemId, int lineNum, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemId", itemId, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32),
	        };
			return Put(set_, "`ItemId` = @ItemId AND `LineNum` = @LineNum", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int itemId, int lineNum, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemId", itemId, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`ItemId` = @ItemId AND `LineNum` = @LineNum", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutItemId
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "itemId"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutItemId(int itemId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemId` = @ItemId";
			var parameter_ = Database.CreateInParameter("@ItemId", itemId, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutItemIdAsync(int itemId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemId` = @ItemId";
			var parameter_ = Database.CreateInParameter("@ItemId", itemId, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutItemId
		#region PutLineNum
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lineNum"></param>
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
		#region PutWeight
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemId"></param>
		/// /// <param name = "lineNum"></param>
		/// /// <param name = "weight"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeightByPK(int itemId, int lineNum, int weight, TransactionManager tm_ = null)
		{
			RepairPutWeightByPKData(itemId, lineNum, weight, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeightByPKAsync(int itemId, int lineNum, int weight, TransactionManager tm_ = null)
		{
			RepairPutWeightByPKData(itemId, lineNum, weight, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeightByPKData(int itemId, int lineNum, int weight, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight` = @Weight  WHERE `ItemId` = @ItemId AND `LineNum` = @LineNum";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemId", itemId, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight"></param>
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Slot_config_base_otherEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemId, item.LineNum) == null)
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
		public async Task<bool> SetAsync(Slot_config_base_otherEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemId, item.LineNum) == null)
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
		/// /// <param name = "itemId"></param>
		/// /// <param name = "lineNum"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Slot_config_base_otherEO GetByPK(int itemId, int lineNum, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemId, lineNum, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Slot_config_base_otherEO.MapDataReader);
		}
		public async Task<Slot_config_base_otherEO> GetByPKAsync(int itemId, int lineNum, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemId, lineNum, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Slot_config_base_otherEO.MapDataReader);
		}
		private void RepairGetByPKData(int itemId, int lineNum, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ItemId` = @ItemId AND `LineNum` = @LineNum", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemId", itemId, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 ItemId（字段）
		/// </summary>
		/// /// <param name = "itemId"></param>
		/// /// <param name = "lineNum"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetItemIdByPK(int itemId, int lineNum, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemId", itemId, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32),
			};
			return (int)GetScalar("`ItemId`", "`ItemId` = @ItemId AND `LineNum` = @LineNum", paras_, tm_);
		}
		public async Task<int> GetItemIdByPKAsync(int itemId, int lineNum, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemId", itemId, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`ItemId`", "`ItemId` = @ItemId AND `LineNum` = @LineNum", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LineNum（字段）
		/// </summary>
		/// /// <param name = "itemId"></param>
		/// /// <param name = "lineNum"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLineNumByPK(int itemId, int lineNum, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemId", itemId, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32),
			};
			return (int)GetScalar("`LineNum`", "`ItemId` = @ItemId AND `LineNum` = @LineNum", paras_, tm_);
		}
		public async Task<int> GetLineNumByPKAsync(int itemId, int lineNum, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemId", itemId, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`LineNum`", "`ItemId` = @ItemId AND `LineNum` = @LineNum", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight（字段）
		/// </summary>
		/// /// <param name = "itemId"></param>
		/// /// <param name = "lineNum"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeightByPK(int itemId, int lineNum, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemId", itemId, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Weight`", "`ItemId` = @ItemId AND `LineNum` = @LineNum", paras_, tm_);
		}
		public async Task<int> GetWeightByPKAsync(int itemId, int lineNum, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemId", itemId, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Weight`", "`ItemId` = @ItemId AND `LineNum` = @LineNum", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByItemId
		
		/// <summary>
		/// 按 ItemId（字段） 查询
		/// </summary>
		/// /// <param name = "itemId"></param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByItemId(int itemId)
		{
			return GetByItemId(itemId, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByItemIdAsync(int itemId)
		{
			return await GetByItemIdAsync(itemId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemId（字段） 查询
		/// </summary>
		/// /// <param name = "itemId"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByItemId(int itemId, TransactionManager tm_)
		{
			return GetByItemId(itemId, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByItemIdAsync(int itemId, TransactionManager tm_)
		{
			return await GetByItemIdAsync(itemId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemId（字段） 查询
		/// </summary>
		/// /// <param name = "itemId"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByItemId(int itemId, int top_)
		{
			return GetByItemId(itemId, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByItemIdAsync(int itemId, int top_)
		{
			return await GetByItemIdAsync(itemId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemId（字段） 查询
		/// </summary>
		/// /// <param name = "itemId"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByItemId(int itemId, int top_, TransactionManager tm_)
		{
			return GetByItemId(itemId, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByItemIdAsync(int itemId, int top_, TransactionManager tm_)
		{
			return await GetByItemIdAsync(itemId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemId（字段） 查询
		/// </summary>
		/// /// <param name = "itemId"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByItemId(int itemId, string sort_)
		{
			return GetByItemId(itemId, 0, sort_, null);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByItemIdAsync(int itemId, string sort_)
		{
			return await GetByItemIdAsync(itemId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ItemId（字段） 查询
		/// </summary>
		/// /// <param name = "itemId"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByItemId(int itemId, string sort_, TransactionManager tm_)
		{
			return GetByItemId(itemId, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByItemIdAsync(int itemId, string sort_, TransactionManager tm_)
		{
			return await GetByItemIdAsync(itemId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ItemId（字段） 查询
		/// </summary>
		/// /// <param name = "itemId"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByItemId(int itemId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemId` = @ItemId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemId", itemId, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_base_otherEO.MapDataReader);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByItemIdAsync(int itemId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemId` = @ItemId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemId", itemId, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_base_otherEO.MapDataReader);
		}
		#endregion // GetByItemId
		#region GetByLineNum
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum"></param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByLineNum(int lineNum)
		{
			return GetByLineNum(lineNum, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByLineNumAsync(int lineNum)
		{
			return await GetByLineNumAsync(lineNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByLineNum(int lineNum, TransactionManager tm_)
		{
			return GetByLineNum(lineNum, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByLineNumAsync(int lineNum, TransactionManager tm_)
		{
			return await GetByLineNumAsync(lineNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByLineNum(int lineNum, int top_)
		{
			return GetByLineNum(lineNum, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByLineNumAsync(int lineNum, int top_)
		{
			return await GetByLineNumAsync(lineNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByLineNum(int lineNum, int top_, TransactionManager tm_)
		{
			return GetByLineNum(lineNum, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByLineNumAsync(int lineNum, int top_, TransactionManager tm_)
		{
			return await GetByLineNumAsync(lineNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByLineNum(int lineNum, string sort_)
		{
			return GetByLineNum(lineNum, 0, sort_, null);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByLineNumAsync(int lineNum, string sort_)
		{
			return await GetByLineNumAsync(lineNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByLineNum(int lineNum, string sort_, TransactionManager tm_)
		{
			return GetByLineNum(lineNum, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByLineNumAsync(int lineNum, string sort_, TransactionManager tm_)
		{
			return await GetByLineNumAsync(lineNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByLineNum(int lineNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LineNum` = @LineNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_base_otherEO.MapDataReader);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByLineNumAsync(int lineNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LineNum` = @LineNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_base_otherEO.MapDataReader);
		}
		#endregion // GetByLineNum
		#region GetByWeight
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight"></param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByWeight(int weight)
		{
			return GetByWeight(weight, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByWeightAsync(int weight)
		{
			return await GetByWeightAsync(weight, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByWeight(int weight, TransactionManager tm_)
		{
			return GetByWeight(weight, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByWeightAsync(int weight, TransactionManager tm_)
		{
			return await GetByWeightAsync(weight, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByWeight(int weight, int top_)
		{
			return GetByWeight(weight, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByWeightAsync(int weight, int top_)
		{
			return await GetByWeightAsync(weight, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByWeight(int weight, int top_, TransactionManager tm_)
		{
			return GetByWeight(weight, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByWeightAsync(int weight, int top_, TransactionManager tm_)
		{
			return await GetByWeightAsync(weight, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByWeight(int weight, string sort_)
		{
			return GetByWeight(weight, 0, sort_, null);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByWeightAsync(int weight, string sort_)
		{
			return await GetByWeightAsync(weight, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByWeight(int weight, string sort_, TransactionManager tm_)
		{
			return GetByWeight(weight, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByWeightAsync(int weight, string sort_, TransactionManager tm_)
		{
			return await GetByWeightAsync(weight, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_base_otherEO> GetByWeight(int weight, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight` = @Weight", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_base_otherEO.MapDataReader);
		}
		public async Task<List<Slot_config_base_otherEO>> GetByWeightAsync(int weight, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight` = @Weight", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_base_otherEO.MapDataReader);
		}
		#endregion // GetByWeight
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
