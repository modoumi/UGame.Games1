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
	/// 倍率表
	/// 【表 slot_config_item_weight_group 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Slot_config_item_weight_groupEO : IRowMapper<Slot_config_item_weight_groupEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Slot_config_item_weight_groupEO()
		{
			this.FristLineNum = 0;
			this.IconNum = 0;
			this.IconGroup = "0";
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalIconGroup;
		/// <summary>
		/// 【数据库中的原始主键 IconGroup 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalIconGroup
		{
			get { return _originalIconGroup; }
			set { HasOriginal = true; _originalIconGroup = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "IconGroup", IconGroup }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 中了几条线
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int LineNum { get; set; }
		/// <summary>
		/// 线ID集合
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string LineNoArr { get; set; }
		/// <summary>
		/// 第一此出N条线
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int FristLineNum { get; set; }
		/// <summary>
		/// 图标个数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int IconNum { get; set; }
		/// <summary>
		/// 图标组合
		/// 【主键 varchar(255)】
		/// </summary>
		[DataMember(Order = 5)]
		public string IconGroup { get; set; }
		/// <summary>
		/// 权重
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int Weight { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Slot_config_item_weight_groupEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Slot_config_item_weight_groupEO MapDataReader(IDataReader reader)
		{
		    Slot_config_item_weight_groupEO ret = new Slot_config_item_weight_groupEO();
			ret.LineNum = reader.ToInt32("LineNum");
			ret.LineNoArr = reader.ToString("LineNoArr");
			ret.FristLineNum = reader.ToInt32("FristLineNum");
			ret.IconNum = reader.ToInt32("IconNum");
			ret.IconGroup = reader.ToString("IconGroup");
			ret.OriginalIconGroup = ret.IconGroup;
			ret.Weight = reader.ToInt32("Weight");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 倍率表
	/// 【表 slot_config_item_weight_group 的操作类】
	/// </summary>
	[Obsolete]
	public class Slot_config_item_weight_groupMO : MySqlTableMO<Slot_config_item_weight_groupEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`slot_config_item_weight_group`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Slot_config_item_weight_groupMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Slot_config_item_weight_groupMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Slot_config_item_weight_groupMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Slot_config_item_weight_groupEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Slot_config_item_weight_groupEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Slot_config_item_weight_groupEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`LineNum`, `LineNoArr`, `FristLineNum`, `IconNum`, `IconGroup`, `Weight`) VALUE (@LineNum, @LineNoArr, @FristLineNum, @IconNum, @IconGroup, @Weight);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LineNum", item.LineNum, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNoArr", item.LineNoArr, MySqlDbType.VarChar),
				Database.CreateInParameter("@FristLineNum", item.FristLineNum, MySqlDbType.Int32),
				Database.CreateInParameter("@IconNum", item.IconNum, MySqlDbType.Int32),
				Database.CreateInParameter("@IconGroup", item.IconGroup, MySqlDbType.VarChar),
				Database.CreateInParameter("@Weight", item.Weight, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Slot_config_item_weight_groupEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Slot_config_item_weight_groupEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Slot_config_item_weight_groupEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`LineNum`, `LineNoArr`, `FristLineNum`, `IconNum`, `IconGroup`, `Weight`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.LineNum},'{item.LineNoArr}',{item.FristLineNum},{item.IconNum},'{item.IconGroup}',{item.Weight}),");
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
		/// /// <param name = "iconGroup">图标组合</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string iconGroup, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(iconGroup, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string iconGroup, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(iconGroup, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string iconGroup, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IconGroup` = @IconGroup";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Slot_config_item_weight_groupEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.IconGroup, tm_);
		}
		public async Task<int> RemoveAsync(Slot_config_item_weight_groupEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.IconGroup, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByLineNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lineNum">中了几条线</param>
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
		#region RemoveByLineNoArr
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lineNoArr">线ID集合</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLineNoArr(string lineNoArr, TransactionManager tm_ = null)
		{
			RepairRemoveByLineNoArrData(lineNoArr, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLineNoArrAsync(string lineNoArr, TransactionManager tm_ = null)
		{
			RepairRemoveByLineNoArrData(lineNoArr, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLineNoArrData(string lineNoArr, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LineNoArr` = @LineNoArr";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNoArr", lineNoArr, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLineNoArr
		#region RemoveByFristLineNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "fristLineNum">第一此出N条线</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFristLineNum(int fristLineNum, TransactionManager tm_ = null)
		{
			RepairRemoveByFristLineNumData(fristLineNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFristLineNumAsync(int fristLineNum, TransactionManager tm_ = null)
		{
			RepairRemoveByFristLineNumData(fristLineNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFristLineNumData(int fristLineNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FristLineNum` = @FristLineNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FristLineNum", fristLineNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByFristLineNum
		#region RemoveByIconNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "iconNum">图标个数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIconNum(int iconNum, TransactionManager tm_ = null)
		{
			RepairRemoveByIconNumData(iconNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIconNumAsync(int iconNum, TransactionManager tm_ = null)
		{
			RepairRemoveByIconNumData(iconNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIconNumData(int iconNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IconNum` = @IconNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IconNum", iconNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByIconNum
		#region RemoveByWeight
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight">权重</param>
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
		public int Put(Slot_config_item_weight_groupEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Slot_config_item_weight_groupEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Slot_config_item_weight_groupEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LineNum` = @LineNum, `LineNoArr` = @LineNoArr, `FristLineNum` = @FristLineNum, `IconNum` = @IconNum, `IconGroup` = @IconGroup, `Weight` = @Weight WHERE `IconGroup` = @IconGroup_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LineNum", item.LineNum, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNoArr", item.LineNoArr, MySqlDbType.VarChar),
				Database.CreateInParameter("@FristLineNum", item.FristLineNum, MySqlDbType.Int32),
				Database.CreateInParameter("@IconNum", item.IconNum, MySqlDbType.Int32),
				Database.CreateInParameter("@IconGroup", item.IconGroup, MySqlDbType.VarChar),
				Database.CreateInParameter("@Weight", item.Weight, MySqlDbType.Int32),
				Database.CreateInParameter("@IconGroup_Original", item.HasOriginal ? item.OriginalIconGroup : item.IconGroup, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Slot_config_item_weight_groupEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Slot_config_item_weight_groupEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "iconGroup">图标组合</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string iconGroup, string set_, params object[] values_)
		{
			return Put(set_, "`IconGroup` = @IconGroup", ConcatValues(values_, iconGroup));
		}
		public async Task<int> PutByPKAsync(string iconGroup, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`IconGroup` = @IconGroup", ConcatValues(values_, iconGroup));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "iconGroup">图标组合</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string iconGroup, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`IconGroup` = @IconGroup", tm_, ConcatValues(values_, iconGroup));
		}
		public async Task<int> PutByPKAsync(string iconGroup, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`IconGroup` = @IconGroup", tm_, ConcatValues(values_, iconGroup));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "iconGroup">图标组合</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string iconGroup, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
	        };
			return Put(set_, "`IconGroup` = @IconGroup", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string iconGroup, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`IconGroup` = @IconGroup", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutLineNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "iconGroup">图标组合</param>
		/// /// <param name = "lineNum">中了几条线</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLineNumByPK(string iconGroup, int lineNum, TransactionManager tm_ = null)
		{
			RepairPutLineNumByPKData(iconGroup, lineNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLineNumByPKAsync(string iconGroup, int lineNum, TransactionManager tm_ = null)
		{
			RepairPutLineNumByPKData(iconGroup, lineNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLineNumByPKData(string iconGroup, int lineNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LineNum` = @LineNum  WHERE `IconGroup` = @IconGroup";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32),
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lineNum">中了几条线</param>
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
		#region PutLineNoArr
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "iconGroup">图标组合</param>
		/// /// <param name = "lineNoArr">线ID集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLineNoArrByPK(string iconGroup, string lineNoArr, TransactionManager tm_ = null)
		{
			RepairPutLineNoArrByPKData(iconGroup, lineNoArr, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLineNoArrByPKAsync(string iconGroup, string lineNoArr, TransactionManager tm_ = null)
		{
			RepairPutLineNoArrByPKData(iconGroup, lineNoArr, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLineNoArrByPKData(string iconGroup, string lineNoArr, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LineNoArr` = @LineNoArr  WHERE `IconGroup` = @IconGroup";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LineNoArr", lineNoArr, MySqlDbType.VarChar),
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lineNoArr">线ID集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLineNoArr(string lineNoArr, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LineNoArr` = @LineNoArr";
			var parameter_ = Database.CreateInParameter("@LineNoArr", lineNoArr, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLineNoArrAsync(string lineNoArr, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LineNoArr` = @LineNoArr";
			var parameter_ = Database.CreateInParameter("@LineNoArr", lineNoArr, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLineNoArr
		#region PutFristLineNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "iconGroup">图标组合</param>
		/// /// <param name = "fristLineNum">第一此出N条线</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFristLineNumByPK(string iconGroup, int fristLineNum, TransactionManager tm_ = null)
		{
			RepairPutFristLineNumByPKData(iconGroup, fristLineNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFristLineNumByPKAsync(string iconGroup, int fristLineNum, TransactionManager tm_ = null)
		{
			RepairPutFristLineNumByPKData(iconGroup, fristLineNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFristLineNumByPKData(string iconGroup, int fristLineNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FristLineNum` = @FristLineNum  WHERE `IconGroup` = @IconGroup";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FristLineNum", fristLineNum, MySqlDbType.Int32),
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "fristLineNum">第一此出N条线</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFristLineNum(int fristLineNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FristLineNum` = @FristLineNum";
			var parameter_ = Database.CreateInParameter("@FristLineNum", fristLineNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFristLineNumAsync(int fristLineNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FristLineNum` = @FristLineNum";
			var parameter_ = Database.CreateInParameter("@FristLineNum", fristLineNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFristLineNum
		#region PutIconNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "iconGroup">图标组合</param>
		/// /// <param name = "iconNum">图标个数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIconNumByPK(string iconGroup, int iconNum, TransactionManager tm_ = null)
		{
			RepairPutIconNumByPKData(iconGroup, iconNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIconNumByPKAsync(string iconGroup, int iconNum, TransactionManager tm_ = null)
		{
			RepairPutIconNumByPKData(iconGroup, iconNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIconNumByPKData(string iconGroup, int iconNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IconNum` = @IconNum  WHERE `IconGroup` = @IconGroup";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IconNum", iconNum, MySqlDbType.Int32),
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "iconNum">图标个数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIconNum(int iconNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IconNum` = @IconNum";
			var parameter_ = Database.CreateInParameter("@IconNum", iconNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIconNumAsync(int iconNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IconNum` = @IconNum";
			var parameter_ = Database.CreateInParameter("@IconNum", iconNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIconNum
		#region PutWeight
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "iconGroup">图标组合</param>
		/// /// <param name = "weight">权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeightByPK(string iconGroup, int weight, TransactionManager tm_ = null)
		{
			RepairPutWeightByPKData(iconGroup, weight, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeightByPKAsync(string iconGroup, int weight, TransactionManager tm_ = null)
		{
			RepairPutWeightByPKData(iconGroup, weight, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeightByPKData(string iconGroup, int weight, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight` = @Weight  WHERE `IconGroup` = @IconGroup";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32),
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight">权重</param>
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
		public bool Set(Slot_config_item_weight_groupEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.IconGroup) == null)
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
		public async Task<bool> SetAsync(Slot_config_item_weight_groupEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.IconGroup) == null)
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
		/// /// <param name = "iconGroup">图标组合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Slot_config_item_weight_groupEO GetByPK(string iconGroup, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(iconGroup, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Slot_config_item_weight_groupEO.MapDataReader);
		}
		public async Task<Slot_config_item_weight_groupEO> GetByPKAsync(string iconGroup, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(iconGroup, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Slot_config_item_weight_groupEO.MapDataReader);
		}
		private void RepairGetByPKData(string iconGroup, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`IconGroup` = @IconGroup", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 LineNum（字段）
		/// </summary>
		/// /// <param name = "iconGroup">图标组合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLineNumByPK(string iconGroup, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`LineNum`", "`IconGroup` = @IconGroup", paras_, tm_);
		}
		public async Task<int> GetLineNumByPKAsync(string iconGroup, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`LineNum`", "`IconGroup` = @IconGroup", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LineNoArr（字段）
		/// </summary>
		/// /// <param name = "iconGroup">图标组合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLineNoArrByPK(string iconGroup, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LineNoArr`", "`IconGroup` = @IconGroup", paras_, tm_);
		}
		public async Task<string> GetLineNoArrByPKAsync(string iconGroup, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LineNoArr`", "`IconGroup` = @IconGroup", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FristLineNum（字段）
		/// </summary>
		/// /// <param name = "iconGroup">图标组合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFristLineNumByPK(string iconGroup, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FristLineNum`", "`IconGroup` = @IconGroup", paras_, tm_);
		}
		public async Task<int> GetFristLineNumByPKAsync(string iconGroup, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FristLineNum`", "`IconGroup` = @IconGroup", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IconNum（字段）
		/// </summary>
		/// /// <param name = "iconGroup">图标组合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetIconNumByPK(string iconGroup, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`IconNum`", "`IconGroup` = @IconGroup", paras_, tm_);
		}
		public async Task<int> GetIconNumByPKAsync(string iconGroup, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`IconNum`", "`IconGroup` = @IconGroup", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight（字段）
		/// </summary>
		/// /// <param name = "iconGroup">图标组合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeightByPK(string iconGroup, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Weight`", "`IconGroup` = @IconGroup", paras_, tm_);
		}
		public async Task<int> GetWeightByPKAsync(string iconGroup, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Weight`", "`IconGroup` = @IconGroup", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByLineNum
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">中了几条线</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByLineNum(int lineNum)
		{
			return GetByLineNum(lineNum, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByLineNumAsync(int lineNum)
		{
			return await GetByLineNumAsync(lineNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">中了几条线</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByLineNum(int lineNum, TransactionManager tm_)
		{
			return GetByLineNum(lineNum, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByLineNumAsync(int lineNum, TransactionManager tm_)
		{
			return await GetByLineNumAsync(lineNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">中了几条线</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByLineNum(int lineNum, int top_)
		{
			return GetByLineNum(lineNum, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByLineNumAsync(int lineNum, int top_)
		{
			return await GetByLineNumAsync(lineNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">中了几条线</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByLineNum(int lineNum, int top_, TransactionManager tm_)
		{
			return GetByLineNum(lineNum, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByLineNumAsync(int lineNum, int top_, TransactionManager tm_)
		{
			return await GetByLineNumAsync(lineNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">中了几条线</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByLineNum(int lineNum, string sort_)
		{
			return GetByLineNum(lineNum, 0, sort_, null);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByLineNumAsync(int lineNum, string sort_)
		{
			return await GetByLineNumAsync(lineNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">中了几条线</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByLineNum(int lineNum, string sort_, TransactionManager tm_)
		{
			return GetByLineNum(lineNum, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByLineNumAsync(int lineNum, string sort_, TransactionManager tm_)
		{
			return await GetByLineNumAsync(lineNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">中了几条线</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByLineNum(int lineNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LineNum` = @LineNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_item_weight_groupEO.MapDataReader);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByLineNumAsync(int lineNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LineNum` = @LineNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_item_weight_groupEO.MapDataReader);
		}
		#endregion // GetByLineNum
		#region GetByLineNoArr
		
		/// <summary>
		/// 按 LineNoArr（字段） 查询
		/// </summary>
		/// /// <param name = "lineNoArr">线ID集合</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByLineNoArr(string lineNoArr)
		{
			return GetByLineNoArr(lineNoArr, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByLineNoArrAsync(string lineNoArr)
		{
			return await GetByLineNoArrAsync(lineNoArr, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LineNoArr（字段） 查询
		/// </summary>
		/// /// <param name = "lineNoArr">线ID集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByLineNoArr(string lineNoArr, TransactionManager tm_)
		{
			return GetByLineNoArr(lineNoArr, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByLineNoArrAsync(string lineNoArr, TransactionManager tm_)
		{
			return await GetByLineNoArrAsync(lineNoArr, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LineNoArr（字段） 查询
		/// </summary>
		/// /// <param name = "lineNoArr">线ID集合</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByLineNoArr(string lineNoArr, int top_)
		{
			return GetByLineNoArr(lineNoArr, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByLineNoArrAsync(string lineNoArr, int top_)
		{
			return await GetByLineNoArrAsync(lineNoArr, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LineNoArr（字段） 查询
		/// </summary>
		/// /// <param name = "lineNoArr">线ID集合</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByLineNoArr(string lineNoArr, int top_, TransactionManager tm_)
		{
			return GetByLineNoArr(lineNoArr, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByLineNoArrAsync(string lineNoArr, int top_, TransactionManager tm_)
		{
			return await GetByLineNoArrAsync(lineNoArr, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LineNoArr（字段） 查询
		/// </summary>
		/// /// <param name = "lineNoArr">线ID集合</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByLineNoArr(string lineNoArr, string sort_)
		{
			return GetByLineNoArr(lineNoArr, 0, sort_, null);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByLineNoArrAsync(string lineNoArr, string sort_)
		{
			return await GetByLineNoArrAsync(lineNoArr, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LineNoArr（字段） 查询
		/// </summary>
		/// /// <param name = "lineNoArr">线ID集合</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByLineNoArr(string lineNoArr, string sort_, TransactionManager tm_)
		{
			return GetByLineNoArr(lineNoArr, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByLineNoArrAsync(string lineNoArr, string sort_, TransactionManager tm_)
		{
			return await GetByLineNoArrAsync(lineNoArr, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LineNoArr（字段） 查询
		/// </summary>
		/// /// <param name = "lineNoArr">线ID集合</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByLineNoArr(string lineNoArr, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LineNoArr` = @LineNoArr", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNoArr", lineNoArr, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_item_weight_groupEO.MapDataReader);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByLineNoArrAsync(string lineNoArr, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LineNoArr` = @LineNoArr", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNoArr", lineNoArr, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_item_weight_groupEO.MapDataReader);
		}
		#endregion // GetByLineNoArr
		#region GetByFristLineNum
		
		/// <summary>
		/// 按 FristLineNum（字段） 查询
		/// </summary>
		/// /// <param name = "fristLineNum">第一此出N条线</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByFristLineNum(int fristLineNum)
		{
			return GetByFristLineNum(fristLineNum, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByFristLineNumAsync(int fristLineNum)
		{
			return await GetByFristLineNumAsync(fristLineNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FristLineNum（字段） 查询
		/// </summary>
		/// /// <param name = "fristLineNum">第一此出N条线</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByFristLineNum(int fristLineNum, TransactionManager tm_)
		{
			return GetByFristLineNum(fristLineNum, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByFristLineNumAsync(int fristLineNum, TransactionManager tm_)
		{
			return await GetByFristLineNumAsync(fristLineNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FristLineNum（字段） 查询
		/// </summary>
		/// /// <param name = "fristLineNum">第一此出N条线</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByFristLineNum(int fristLineNum, int top_)
		{
			return GetByFristLineNum(fristLineNum, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByFristLineNumAsync(int fristLineNum, int top_)
		{
			return await GetByFristLineNumAsync(fristLineNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FristLineNum（字段） 查询
		/// </summary>
		/// /// <param name = "fristLineNum">第一此出N条线</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByFristLineNum(int fristLineNum, int top_, TransactionManager tm_)
		{
			return GetByFristLineNum(fristLineNum, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByFristLineNumAsync(int fristLineNum, int top_, TransactionManager tm_)
		{
			return await GetByFristLineNumAsync(fristLineNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FristLineNum（字段） 查询
		/// </summary>
		/// /// <param name = "fristLineNum">第一此出N条线</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByFristLineNum(int fristLineNum, string sort_)
		{
			return GetByFristLineNum(fristLineNum, 0, sort_, null);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByFristLineNumAsync(int fristLineNum, string sort_)
		{
			return await GetByFristLineNumAsync(fristLineNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FristLineNum（字段） 查询
		/// </summary>
		/// /// <param name = "fristLineNum">第一此出N条线</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByFristLineNum(int fristLineNum, string sort_, TransactionManager tm_)
		{
			return GetByFristLineNum(fristLineNum, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByFristLineNumAsync(int fristLineNum, string sort_, TransactionManager tm_)
		{
			return await GetByFristLineNumAsync(fristLineNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FristLineNum（字段） 查询
		/// </summary>
		/// /// <param name = "fristLineNum">第一此出N条线</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByFristLineNum(int fristLineNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FristLineNum` = @FristLineNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FristLineNum", fristLineNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_item_weight_groupEO.MapDataReader);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByFristLineNumAsync(int fristLineNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FristLineNum` = @FristLineNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FristLineNum", fristLineNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_item_weight_groupEO.MapDataReader);
		}
		#endregion // GetByFristLineNum
		#region GetByIconNum
		
		/// <summary>
		/// 按 IconNum（字段） 查询
		/// </summary>
		/// /// <param name = "iconNum">图标个数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByIconNum(int iconNum)
		{
			return GetByIconNum(iconNum, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByIconNumAsync(int iconNum)
		{
			return await GetByIconNumAsync(iconNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IconNum（字段） 查询
		/// </summary>
		/// /// <param name = "iconNum">图标个数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByIconNum(int iconNum, TransactionManager tm_)
		{
			return GetByIconNum(iconNum, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByIconNumAsync(int iconNum, TransactionManager tm_)
		{
			return await GetByIconNumAsync(iconNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IconNum（字段） 查询
		/// </summary>
		/// /// <param name = "iconNum">图标个数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByIconNum(int iconNum, int top_)
		{
			return GetByIconNum(iconNum, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByIconNumAsync(int iconNum, int top_)
		{
			return await GetByIconNumAsync(iconNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IconNum（字段） 查询
		/// </summary>
		/// /// <param name = "iconNum">图标个数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByIconNum(int iconNum, int top_, TransactionManager tm_)
		{
			return GetByIconNum(iconNum, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByIconNumAsync(int iconNum, int top_, TransactionManager tm_)
		{
			return await GetByIconNumAsync(iconNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IconNum（字段） 查询
		/// </summary>
		/// /// <param name = "iconNum">图标个数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByIconNum(int iconNum, string sort_)
		{
			return GetByIconNum(iconNum, 0, sort_, null);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByIconNumAsync(int iconNum, string sort_)
		{
			return await GetByIconNumAsync(iconNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IconNum（字段） 查询
		/// </summary>
		/// /// <param name = "iconNum">图标个数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByIconNum(int iconNum, string sort_, TransactionManager tm_)
		{
			return GetByIconNum(iconNum, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByIconNumAsync(int iconNum, string sort_, TransactionManager tm_)
		{
			return await GetByIconNumAsync(iconNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IconNum（字段） 查询
		/// </summary>
		/// /// <param name = "iconNum">图标个数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByIconNum(int iconNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IconNum` = @IconNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IconNum", iconNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_item_weight_groupEO.MapDataReader);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByIconNumAsync(int iconNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IconNum` = @IconNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IconNum", iconNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_item_weight_groupEO.MapDataReader);
		}
		#endregion // GetByIconNum
		#region GetByWeight
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByWeight(int weight)
		{
			return GetByWeight(weight, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByWeightAsync(int weight)
		{
			return await GetByWeightAsync(weight, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByWeight(int weight, TransactionManager tm_)
		{
			return GetByWeight(weight, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByWeightAsync(int weight, TransactionManager tm_)
		{
			return await GetByWeightAsync(weight, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByWeight(int weight, int top_)
		{
			return GetByWeight(weight, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByWeightAsync(int weight, int top_)
		{
			return await GetByWeightAsync(weight, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByWeight(int weight, int top_, TransactionManager tm_)
		{
			return GetByWeight(weight, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByWeightAsync(int weight, int top_, TransactionManager tm_)
		{
			return await GetByWeightAsync(weight, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByWeight(int weight, string sort_)
		{
			return GetByWeight(weight, 0, sort_, null);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByWeightAsync(int weight, string sort_)
		{
			return await GetByWeightAsync(weight, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByWeight(int weight, string sort_, TransactionManager tm_)
		{
			return GetByWeight(weight, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByWeightAsync(int weight, string sort_, TransactionManager tm_)
		{
			return await GetByWeightAsync(weight, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_item_weight_groupEO> GetByWeight(int weight, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight` = @Weight", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_item_weight_groupEO.MapDataReader);
		}
		public async Task<List<Slot_config_item_weight_groupEO>> GetByWeightAsync(int weight, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight` = @Weight", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_item_weight_groupEO.MapDataReader);
		}
		#endregion // GetByWeight
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
