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
	/// Btest 主轴配置
	/// 【表 slot_config_base 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Slot_config_baseEO : IRowMapper<Slot_config_baseEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Slot_config_baseEO()
		{
			this.BaseName = "0";
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalBaseName;
		/// <summary>
		/// 【数据库中的原始主键 BaseName 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalBaseName
		{
			get { return _originalBaseName; }
			set { HasOriginal = true; _originalBaseName = value; }
		}
		
		private int _originalBaseColumn;
		/// <summary>
		/// 【数据库中的原始主键 BaseColumn 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalBaseColumn
		{
			get { return _originalBaseColumn; }
			set { HasOriginal = true; _originalBaseColumn = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "BaseName", BaseName },  { "BaseColumn", BaseColumn }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// SheelName
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string BaseName { get; set; }
		/// <summary>
		/// 第几列
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int BaseColumn { get; set; }
		/// <summary>
		/// 权重值
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 3)]
		public string BaseText { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Slot_config_baseEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Slot_config_baseEO MapDataReader(IDataReader reader)
		{
		    Slot_config_baseEO ret = new Slot_config_baseEO();
			ret.BaseName = reader.ToString("BaseName");
			ret.OriginalBaseName = ret.BaseName;
			ret.BaseColumn = reader.ToInt32("BaseColumn");
			ret.OriginalBaseColumn = ret.BaseColumn;
			ret.BaseText = reader.ToString("BaseText");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// Btest 主轴配置
	/// 【表 slot_config_base 的操作类】
	/// </summary>
	[Obsolete]
	public class Slot_config_baseMO : MySqlTableMO<Slot_config_baseEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`slot_config_base`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Slot_config_baseMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Slot_config_baseMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Slot_config_baseMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Slot_config_baseEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Slot_config_baseEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Slot_config_baseEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`BaseName`, `BaseColumn`, `BaseText`) VALUE (@BaseName, @BaseColumn, @BaseText);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BaseName", item.BaseName, MySqlDbType.VarChar),
				Database.CreateInParameter("@BaseColumn", item.BaseColumn, MySqlDbType.Int32),
				Database.CreateInParameter("@BaseText", item.BaseText, MySqlDbType.Text),
			};
		}
		public int AddByBatch(IEnumerable<Slot_config_baseEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Slot_config_baseEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Slot_config_baseEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`BaseName`, `BaseColumn`, `BaseText`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.BaseName}',{item.BaseColumn},'{item.BaseText}'),");
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
		/// /// <param name = "baseName">SheelName</param>
		/// /// <param name = "baseColumn">第几列</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string baseName, int baseColumn, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(baseName, baseColumn, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string baseName, int baseColumn, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(baseName, baseColumn, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string baseName, int baseColumn, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BaseName` = @BaseName AND `BaseColumn` = @BaseColumn";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BaseName", baseName, MySqlDbType.VarChar),
				Database.CreateInParameter("@BaseColumn", baseColumn, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Slot_config_baseEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.BaseName, item.BaseColumn, tm_);
		}
		public async Task<int> RemoveAsync(Slot_config_baseEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.BaseName, item.BaseColumn, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByBaseName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "baseName">SheelName</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBaseName(string baseName, TransactionManager tm_ = null)
		{
			RepairRemoveByBaseNameData(baseName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBaseNameAsync(string baseName, TransactionManager tm_ = null)
		{
			RepairRemoveByBaseNameData(baseName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBaseNameData(string baseName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BaseName` = @BaseName";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BaseName", baseName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByBaseName
		#region RemoveByBaseColumn
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "baseColumn">第几列</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBaseColumn(int baseColumn, TransactionManager tm_ = null)
		{
			RepairRemoveByBaseColumnData(baseColumn, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBaseColumnAsync(int baseColumn, TransactionManager tm_ = null)
		{
			RepairRemoveByBaseColumnData(baseColumn, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBaseColumnData(int baseColumn, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BaseColumn` = @BaseColumn";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BaseColumn", baseColumn, MySqlDbType.Int32));
		}
		#endregion // RemoveByBaseColumn
		#region RemoveByBaseText
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "baseText">权重值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBaseText(string baseText, TransactionManager tm_ = null)
		{
			RepairRemoveByBaseTextData(baseText, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBaseTextAsync(string baseText, TransactionManager tm_ = null)
		{
			RepairRemoveByBaseTextData(baseText, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBaseTextData(string baseText, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BaseText` = @BaseText";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BaseText", baseText, MySqlDbType.Text));
		}
		#endregion // RemoveByBaseText
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
		public int Put(Slot_config_baseEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Slot_config_baseEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Slot_config_baseEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BaseName` = @BaseName, `BaseColumn` = @BaseColumn, `BaseText` = @BaseText WHERE `BaseName` = @BaseName_Original AND `BaseColumn` = @BaseColumn_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BaseName", item.BaseName, MySqlDbType.VarChar),
				Database.CreateInParameter("@BaseColumn", item.BaseColumn, MySqlDbType.Int32),
				Database.CreateInParameter("@BaseText", item.BaseText, MySqlDbType.Text),
				Database.CreateInParameter("@BaseName_Original", item.HasOriginal ? item.OriginalBaseName : item.BaseName, MySqlDbType.VarChar),
				Database.CreateInParameter("@BaseColumn_Original", item.HasOriginal ? item.OriginalBaseColumn : item.BaseColumn, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Slot_config_baseEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Slot_config_baseEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "baseName">SheelName</param>
		/// /// <param name = "baseColumn">第几列</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string baseName, int baseColumn, string set_, params object[] values_)
		{
			return Put(set_, "`BaseName` = @BaseName AND `BaseColumn` = @BaseColumn", ConcatValues(values_, baseName, baseColumn));
		}
		public async Task<int> PutByPKAsync(string baseName, int baseColumn, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`BaseName` = @BaseName AND `BaseColumn` = @BaseColumn", ConcatValues(values_, baseName, baseColumn));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "baseName">SheelName</param>
		/// /// <param name = "baseColumn">第几列</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string baseName, int baseColumn, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`BaseName` = @BaseName AND `BaseColumn` = @BaseColumn", tm_, ConcatValues(values_, baseName, baseColumn));
		}
		public async Task<int> PutByPKAsync(string baseName, int baseColumn, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`BaseName` = @BaseName AND `BaseColumn` = @BaseColumn", tm_, ConcatValues(values_, baseName, baseColumn));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "baseName">SheelName</param>
		/// /// <param name = "baseColumn">第几列</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string baseName, int baseColumn, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@BaseName", baseName, MySqlDbType.VarChar),
				Database.CreateInParameter("@BaseColumn", baseColumn, MySqlDbType.Int32),
	        };
			return Put(set_, "`BaseName` = @BaseName AND `BaseColumn` = @BaseColumn", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string baseName, int baseColumn, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@BaseName", baseName, MySqlDbType.VarChar),
				Database.CreateInParameter("@BaseColumn", baseColumn, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`BaseName` = @BaseName AND `BaseColumn` = @BaseColumn", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutBaseName
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "baseName">SheelName</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBaseName(string baseName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BaseName` = @BaseName";
			var parameter_ = Database.CreateInParameter("@BaseName", baseName, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBaseNameAsync(string baseName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BaseName` = @BaseName";
			var parameter_ = Database.CreateInParameter("@BaseName", baseName, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBaseName
		#region PutBaseColumn
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "baseColumn">第几列</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBaseColumn(int baseColumn, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BaseColumn` = @BaseColumn";
			var parameter_ = Database.CreateInParameter("@BaseColumn", baseColumn, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBaseColumnAsync(int baseColumn, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BaseColumn` = @BaseColumn";
			var parameter_ = Database.CreateInParameter("@BaseColumn", baseColumn, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBaseColumn
		#region PutBaseText
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "baseName">SheelName</param>
		/// /// <param name = "baseColumn">第几列</param>
		/// /// <param name = "baseText">权重值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBaseTextByPK(string baseName, int baseColumn, string baseText, TransactionManager tm_ = null)
		{
			RepairPutBaseTextByPKData(baseName, baseColumn, baseText, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBaseTextByPKAsync(string baseName, int baseColumn, string baseText, TransactionManager tm_ = null)
		{
			RepairPutBaseTextByPKData(baseName, baseColumn, baseText, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBaseTextByPKData(string baseName, int baseColumn, string baseText, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BaseText` = @BaseText  WHERE `BaseName` = @BaseName AND `BaseColumn` = @BaseColumn";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BaseText", baseText, MySqlDbType.Text),
				Database.CreateInParameter("@BaseName", baseName, MySqlDbType.VarChar),
				Database.CreateInParameter("@BaseColumn", baseColumn, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "baseText">权重值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBaseText(string baseText, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BaseText` = @BaseText";
			var parameter_ = Database.CreateInParameter("@BaseText", baseText, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBaseTextAsync(string baseText, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BaseText` = @BaseText";
			var parameter_ = Database.CreateInParameter("@BaseText", baseText, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBaseText
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Slot_config_baseEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.BaseName, item.BaseColumn) == null)
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
		public async Task<bool> SetAsync(Slot_config_baseEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.BaseName, item.BaseColumn) == null)
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
		/// /// <param name = "baseName">SheelName</param>
		/// /// <param name = "baseColumn">第几列</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Slot_config_baseEO GetByPK(string baseName, int baseColumn, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(baseName, baseColumn, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Slot_config_baseEO.MapDataReader);
		}
		public async Task<Slot_config_baseEO> GetByPKAsync(string baseName, int baseColumn, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(baseName, baseColumn, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Slot_config_baseEO.MapDataReader);
		}
		private void RepairGetByPKData(string baseName, int baseColumn, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`BaseName` = @BaseName AND `BaseColumn` = @BaseColumn", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BaseName", baseName, MySqlDbType.VarChar),
				Database.CreateInParameter("@BaseColumn", baseColumn, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 BaseName（字段）
		/// </summary>
		/// /// <param name = "baseName">SheelName</param>
		/// /// <param name = "baseColumn">第几列</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBaseNameByPK(string baseName, int baseColumn, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BaseName", baseName, MySqlDbType.VarChar),
				Database.CreateInParameter("@BaseColumn", baseColumn, MySqlDbType.Int32),
			};
			return (string)GetScalar("`BaseName`", "`BaseName` = @BaseName AND `BaseColumn` = @BaseColumn", paras_, tm_);
		}
		public async Task<string> GetBaseNameByPKAsync(string baseName, int baseColumn, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BaseName", baseName, MySqlDbType.VarChar),
				Database.CreateInParameter("@BaseColumn", baseColumn, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`BaseName`", "`BaseName` = @BaseName AND `BaseColumn` = @BaseColumn", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BaseColumn（字段）
		/// </summary>
		/// /// <param name = "baseName">SheelName</param>
		/// /// <param name = "baseColumn">第几列</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetBaseColumnByPK(string baseName, int baseColumn, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BaseName", baseName, MySqlDbType.VarChar),
				Database.CreateInParameter("@BaseColumn", baseColumn, MySqlDbType.Int32),
			};
			return (int)GetScalar("`BaseColumn`", "`BaseName` = @BaseName AND `BaseColumn` = @BaseColumn", paras_, tm_);
		}
		public async Task<int> GetBaseColumnByPKAsync(string baseName, int baseColumn, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BaseName", baseName, MySqlDbType.VarChar),
				Database.CreateInParameter("@BaseColumn", baseColumn, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`BaseColumn`", "`BaseName` = @BaseName AND `BaseColumn` = @BaseColumn", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BaseText（字段）
		/// </summary>
		/// /// <param name = "baseName">SheelName</param>
		/// /// <param name = "baseColumn">第几列</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBaseTextByPK(string baseName, int baseColumn, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BaseName", baseName, MySqlDbType.VarChar),
				Database.CreateInParameter("@BaseColumn", baseColumn, MySqlDbType.Int32),
			};
			return (string)GetScalar("`BaseText`", "`BaseName` = @BaseName AND `BaseColumn` = @BaseColumn", paras_, tm_);
		}
		public async Task<string> GetBaseTextByPKAsync(string baseName, int baseColumn, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BaseName", baseName, MySqlDbType.VarChar),
				Database.CreateInParameter("@BaseColumn", baseColumn, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`BaseText`", "`BaseName` = @BaseName AND `BaseColumn` = @BaseColumn", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByBaseName
		
		/// <summary>
		/// 按 BaseName（字段） 查询
		/// </summary>
		/// /// <param name = "baseName">SheelName</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseName(string baseName)
		{
			return GetByBaseName(baseName, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseNameAsync(string baseName)
		{
			return await GetByBaseNameAsync(baseName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BaseName（字段） 查询
		/// </summary>
		/// /// <param name = "baseName">SheelName</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseName(string baseName, TransactionManager tm_)
		{
			return GetByBaseName(baseName, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseNameAsync(string baseName, TransactionManager tm_)
		{
			return await GetByBaseNameAsync(baseName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BaseName（字段） 查询
		/// </summary>
		/// /// <param name = "baseName">SheelName</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseName(string baseName, int top_)
		{
			return GetByBaseName(baseName, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseNameAsync(string baseName, int top_)
		{
			return await GetByBaseNameAsync(baseName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BaseName（字段） 查询
		/// </summary>
		/// /// <param name = "baseName">SheelName</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseName(string baseName, int top_, TransactionManager tm_)
		{
			return GetByBaseName(baseName, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseNameAsync(string baseName, int top_, TransactionManager tm_)
		{
			return await GetByBaseNameAsync(baseName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BaseName（字段） 查询
		/// </summary>
		/// /// <param name = "baseName">SheelName</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseName(string baseName, string sort_)
		{
			return GetByBaseName(baseName, 0, sort_, null);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseNameAsync(string baseName, string sort_)
		{
			return await GetByBaseNameAsync(baseName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BaseName（字段） 查询
		/// </summary>
		/// /// <param name = "baseName">SheelName</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseName(string baseName, string sort_, TransactionManager tm_)
		{
			return GetByBaseName(baseName, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseNameAsync(string baseName, string sort_, TransactionManager tm_)
		{
			return await GetByBaseNameAsync(baseName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BaseName（字段） 查询
		/// </summary>
		/// /// <param name = "baseName">SheelName</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseName(string baseName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BaseName` = @BaseName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BaseName", baseName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_baseEO.MapDataReader);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseNameAsync(string baseName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BaseName` = @BaseName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BaseName", baseName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_baseEO.MapDataReader);
		}
		#endregion // GetByBaseName
		#region GetByBaseColumn
		
		/// <summary>
		/// 按 BaseColumn（字段） 查询
		/// </summary>
		/// /// <param name = "baseColumn">第几列</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseColumn(int baseColumn)
		{
			return GetByBaseColumn(baseColumn, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseColumnAsync(int baseColumn)
		{
			return await GetByBaseColumnAsync(baseColumn, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BaseColumn（字段） 查询
		/// </summary>
		/// /// <param name = "baseColumn">第几列</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseColumn(int baseColumn, TransactionManager tm_)
		{
			return GetByBaseColumn(baseColumn, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseColumnAsync(int baseColumn, TransactionManager tm_)
		{
			return await GetByBaseColumnAsync(baseColumn, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BaseColumn（字段） 查询
		/// </summary>
		/// /// <param name = "baseColumn">第几列</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseColumn(int baseColumn, int top_)
		{
			return GetByBaseColumn(baseColumn, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseColumnAsync(int baseColumn, int top_)
		{
			return await GetByBaseColumnAsync(baseColumn, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BaseColumn（字段） 查询
		/// </summary>
		/// /// <param name = "baseColumn">第几列</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseColumn(int baseColumn, int top_, TransactionManager tm_)
		{
			return GetByBaseColumn(baseColumn, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseColumnAsync(int baseColumn, int top_, TransactionManager tm_)
		{
			return await GetByBaseColumnAsync(baseColumn, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BaseColumn（字段） 查询
		/// </summary>
		/// /// <param name = "baseColumn">第几列</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseColumn(int baseColumn, string sort_)
		{
			return GetByBaseColumn(baseColumn, 0, sort_, null);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseColumnAsync(int baseColumn, string sort_)
		{
			return await GetByBaseColumnAsync(baseColumn, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BaseColumn（字段） 查询
		/// </summary>
		/// /// <param name = "baseColumn">第几列</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseColumn(int baseColumn, string sort_, TransactionManager tm_)
		{
			return GetByBaseColumn(baseColumn, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseColumnAsync(int baseColumn, string sort_, TransactionManager tm_)
		{
			return await GetByBaseColumnAsync(baseColumn, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BaseColumn（字段） 查询
		/// </summary>
		/// /// <param name = "baseColumn">第几列</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseColumn(int baseColumn, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BaseColumn` = @BaseColumn", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BaseColumn", baseColumn, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_baseEO.MapDataReader);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseColumnAsync(int baseColumn, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BaseColumn` = @BaseColumn", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BaseColumn", baseColumn, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_baseEO.MapDataReader);
		}
		#endregion // GetByBaseColumn
		#region GetByBaseText
		
		/// <summary>
		/// 按 BaseText（字段） 查询
		/// </summary>
		/// /// <param name = "baseText">权重值</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseText(string baseText)
		{
			return GetByBaseText(baseText, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseTextAsync(string baseText)
		{
			return await GetByBaseTextAsync(baseText, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BaseText（字段） 查询
		/// </summary>
		/// /// <param name = "baseText">权重值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseText(string baseText, TransactionManager tm_)
		{
			return GetByBaseText(baseText, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseTextAsync(string baseText, TransactionManager tm_)
		{
			return await GetByBaseTextAsync(baseText, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BaseText（字段） 查询
		/// </summary>
		/// /// <param name = "baseText">权重值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseText(string baseText, int top_)
		{
			return GetByBaseText(baseText, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseTextAsync(string baseText, int top_)
		{
			return await GetByBaseTextAsync(baseText, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BaseText（字段） 查询
		/// </summary>
		/// /// <param name = "baseText">权重值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseText(string baseText, int top_, TransactionManager tm_)
		{
			return GetByBaseText(baseText, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseTextAsync(string baseText, int top_, TransactionManager tm_)
		{
			return await GetByBaseTextAsync(baseText, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BaseText（字段） 查询
		/// </summary>
		/// /// <param name = "baseText">权重值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseText(string baseText, string sort_)
		{
			return GetByBaseText(baseText, 0, sort_, null);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseTextAsync(string baseText, string sort_)
		{
			return await GetByBaseTextAsync(baseText, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BaseText（字段） 查询
		/// </summary>
		/// /// <param name = "baseText">权重值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseText(string baseText, string sort_, TransactionManager tm_)
		{
			return GetByBaseText(baseText, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseTextAsync(string baseText, string sort_, TransactionManager tm_)
		{
			return await GetByBaseTextAsync(baseText, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BaseText（字段） 查询
		/// </summary>
		/// /// <param name = "baseText">权重值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_baseEO> GetByBaseText(string baseText, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BaseText` = @BaseText", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BaseText", baseText, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_baseEO.MapDataReader);
		}
		public async Task<List<Slot_config_baseEO>> GetByBaseTextAsync(string baseText, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BaseText` = @BaseText", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BaseText", baseText, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_baseEO.MapDataReader);
		}
		#endregion // GetByBaseText
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
