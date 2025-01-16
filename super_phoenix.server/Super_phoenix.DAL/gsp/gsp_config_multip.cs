/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-14 21: 25:31
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

namespace Super_phoenix.DAL
{
	#region EO
	/// <summary>
	/// 倍率表
	/// 【表 gsp_config_multip 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Gsp_config_multipEO : IRowMapper<Gsp_config_multipEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Gsp_config_multipEO()
		{
			this.Multip3 = 0;
			this.Multip4 = 0;
			this.Multip5 = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalItemID;
		/// <summary>
		/// 【数据库中的原始主键 ItemID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalItemID
		{
			get { return _originalItemID; }
			set { HasOriginal = true; _originalItemID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ItemID", ItemID }, };
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
		public int ItemID { get; set; }
		/// <summary>
		/// icon类型1-普通,2-万能,3-scatter
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int IconType { get; set; }
		/// <summary>
		/// x3倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int Multip3 { get; set; }
		/// <summary>
		/// x4倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int Multip4 { get; set; }
		/// <summary>
		/// x5倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int Multip5 { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Gsp_config_multipEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Gsp_config_multipEO MapDataReader(IDataReader reader)
		{
		    Gsp_config_multipEO ret = new Gsp_config_multipEO();
			ret.ItemID = reader.ToInt32("ItemID");
			ret.OriginalItemID = ret.ItemID;
			ret.IconType = reader.ToInt32("IconType");
			ret.Multip3 = reader.ToInt32("Multip3");
			ret.Multip4 = reader.ToInt32("Multip4");
			ret.Multip5 = reader.ToInt32("Multip5");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 倍率表
	/// 【表 gsp_config_multip 的操作类】
	/// </summary>
	[Obsolete]
	public class Gsp_config_multipMO : MySqlTableMO<Gsp_config_multipEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`gsp_config_multip`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Gsp_config_multipMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Gsp_config_multipMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Gsp_config_multipMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Gsp_config_multipEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Gsp_config_multipEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Gsp_config_multipEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ItemID`, `IconType`, `Multip3`, `Multip4`, `Multip5`) VALUE (@ItemID, @IconType, @Multip3, @Multip4, @Multip5);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", item.IconType, MySqlDbType.Int32),
				Database.CreateInParameter("@Multip3", item.Multip3, MySqlDbType.Int32),
				Database.CreateInParameter("@Multip4", item.Multip4, MySqlDbType.Int32),
				Database.CreateInParameter("@Multip5", item.Multip5, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Gsp_config_multipEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Gsp_config_multipEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gsp_config_multipEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ItemID`, `IconType`, `Multip3`, `Multip4`, `Multip5`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.ItemID},{item.IconType},{item.Multip3},{item.Multip4},{item.Multip5}),");
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
		/// /// <param name = "itemID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int itemID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int itemID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Gsp_config_multipEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ItemID, tm_);
		}
		public async Task<int> RemoveAsync(Gsp_config_multipEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ItemID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByIconType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIconType(int iconType, TransactionManager tm_ = null)
		{
			RepairRemoveByIconTypeData(iconType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIconTypeAsync(int iconType, TransactionManager tm_ = null)
		{
			RepairRemoveByIconTypeData(iconType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIconTypeData(int iconType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IconType` = @IconType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32));
		}
		#endregion // RemoveByIconType
		#region RemoveByMultip3
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "multip3">x3倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMultip3(int multip3, TransactionManager tm_ = null)
		{
			RepairRemoveByMultip3Data(multip3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMultip3Async(int multip3, TransactionManager tm_ = null)
		{
			RepairRemoveByMultip3Data(multip3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMultip3Data(int multip3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Multip3` = @Multip3";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip3", multip3, MySqlDbType.Int32));
		}
		#endregion // RemoveByMultip3
		#region RemoveByMultip4
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "multip4">x4倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMultip4(int multip4, TransactionManager tm_ = null)
		{
			RepairRemoveByMultip4Data(multip4, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMultip4Async(int multip4, TransactionManager tm_ = null)
		{
			RepairRemoveByMultip4Data(multip4, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMultip4Data(int multip4, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Multip4` = @Multip4";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip4", multip4, MySqlDbType.Int32));
		}
		#endregion // RemoveByMultip4
		#region RemoveByMultip5
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "multip5">x5倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMultip5(int multip5, TransactionManager tm_ = null)
		{
			RepairRemoveByMultip5Data(multip5, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMultip5Async(int multip5, TransactionManager tm_ = null)
		{
			RepairRemoveByMultip5Data(multip5, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMultip5Data(int multip5, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Multip5` = @Multip5";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip5", multip5, MySqlDbType.Int32));
		}
		#endregion // RemoveByMultip5
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
		public int Put(Gsp_config_multipEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Gsp_config_multipEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Gsp_config_multipEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID, `IconType` = @IconType, `Multip3` = @Multip3, `Multip4` = @Multip4, `Multip5` = @Multip5 WHERE `ItemID` = @ItemID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", item.IconType, MySqlDbType.Int32),
				Database.CreateInParameter("@Multip3", item.Multip3, MySqlDbType.Int32),
				Database.CreateInParameter("@Multip4", item.Multip4, MySqlDbType.Int32),
				Database.CreateInParameter("@Multip5", item.Multip5, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID_Original", item.HasOriginal ? item.OriginalItemID : item.ItemID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Gsp_config_multipEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Gsp_config_multipEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "itemID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string set_, params object[] values_)
		{
			return Put(set_, "`ItemID` = @ItemID", ConcatValues(values_, itemID));
		}
		public async Task<int> PutByPKAsync(int itemID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemID` = @ItemID", ConcatValues(values_, itemID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ItemID` = @ItemID", tm_, ConcatValues(values_, itemID));
		}
		public async Task<int> PutByPKAsync(int itemID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemID` = @ItemID", tm_, ConcatValues(values_, itemID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
	        };
			return Put(set_, "`ItemID` = @ItemID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int itemID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`ItemID` = @ItemID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutIconType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIconTypeByPK(int itemID, int iconType, TransactionManager tm_ = null)
		{
			RepairPutIconTypeByPKData(itemID, iconType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIconTypeByPKAsync(int itemID, int iconType, TransactionManager tm_ = null)
		{
			RepairPutIconTypeByPKData(itemID, iconType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIconTypeByPKData(int itemID, int iconType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IconType` = @IconType  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIconType(int iconType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IconType` = @IconType";
			var parameter_ = Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIconTypeAsync(int iconType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IconType` = @IconType";
			var parameter_ = Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIconType
		#region PutMultip3
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "multip3">x3倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultip3ByPK(int itemID, int multip3, TransactionManager tm_ = null)
		{
			RepairPutMultip3ByPKData(itemID, multip3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMultip3ByPKAsync(int itemID, int multip3, TransactionManager tm_ = null)
		{
			RepairPutMultip3ByPKData(itemID, multip3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMultip3ByPKData(int itemID, int multip3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Multip3` = @Multip3  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Multip3", multip3, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "multip3">x3倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultip3(int multip3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multip3` = @Multip3";
			var parameter_ = Database.CreateInParameter("@Multip3", multip3, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMultip3Async(int multip3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multip3` = @Multip3";
			var parameter_ = Database.CreateInParameter("@Multip3", multip3, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMultip3
		#region PutMultip4
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "multip4">x4倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultip4ByPK(int itemID, int multip4, TransactionManager tm_ = null)
		{
			RepairPutMultip4ByPKData(itemID, multip4, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMultip4ByPKAsync(int itemID, int multip4, TransactionManager tm_ = null)
		{
			RepairPutMultip4ByPKData(itemID, multip4, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMultip4ByPKData(int itemID, int multip4, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Multip4` = @Multip4  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Multip4", multip4, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "multip4">x4倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultip4(int multip4, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multip4` = @Multip4";
			var parameter_ = Database.CreateInParameter("@Multip4", multip4, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMultip4Async(int multip4, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multip4` = @Multip4";
			var parameter_ = Database.CreateInParameter("@Multip4", multip4, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMultip4
		#region PutMultip5
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "multip5">x5倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultip5ByPK(int itemID, int multip5, TransactionManager tm_ = null)
		{
			RepairPutMultip5ByPKData(itemID, multip5, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMultip5ByPKAsync(int itemID, int multip5, TransactionManager tm_ = null)
		{
			RepairPutMultip5ByPKData(itemID, multip5, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMultip5ByPKData(int itemID, int multip5, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Multip5` = @Multip5  WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Multip5", multip5, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "multip5">x5倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultip5(int multip5, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multip5` = @Multip5";
			var parameter_ = Database.CreateInParameter("@Multip5", multip5, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMultip5Async(int multip5, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multip5` = @Multip5";
			var parameter_ = Database.CreateInParameter("@Multip5", multip5, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMultip5
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Gsp_config_multipEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemID) == null)
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
		public async Task<bool> SetAsync(Gsp_config_multipEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemID) == null)
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
		/// /// <param name = "itemID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Gsp_config_multipEO GetByPK(int itemID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Gsp_config_multipEO.MapDataReader);
		}
		public async Task<Gsp_config_multipEO> GetByPKAsync(int itemID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gsp_config_multipEO.MapDataReader);
		}
		private void RepairGetByPKData(int itemID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ItemID` = @ItemID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 IconType（字段）
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetIconTypeByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`IconType`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<int> GetIconTypeByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`IconType`", "`ItemID` = @ItemID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Multip3（字段）
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMultip3ByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Multip3`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<int> GetMultip3ByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Multip3`", "`ItemID` = @ItemID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Multip4（字段）
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMultip4ByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Multip4`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<int> GetMultip4ByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Multip4`", "`ItemID` = @ItemID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Multip5（字段）
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMultip5ByPK(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Multip5`", "`ItemID` = @ItemID", paras_, tm_);
		}
		public async Task<int> GetMultip5ByPKAsync(int itemID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Multip5`", "`ItemID` = @ItemID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByIconType
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByIconType(int iconType)
		{
			return GetByIconType(iconType, 0, string.Empty, null);
		}
		public async Task<List<Gsp_config_multipEO>> GetByIconTypeAsync(int iconType)
		{
			return await GetByIconTypeAsync(iconType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByIconType(int iconType, TransactionManager tm_)
		{
			return GetByIconType(iconType, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_multipEO>> GetByIconTypeAsync(int iconType, TransactionManager tm_)
		{
			return await GetByIconTypeAsync(iconType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByIconType(int iconType, int top_)
		{
			return GetByIconType(iconType, top_, string.Empty, null);
		}
		public async Task<List<Gsp_config_multipEO>> GetByIconTypeAsync(int iconType, int top_)
		{
			return await GetByIconTypeAsync(iconType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByIconType(int iconType, int top_, TransactionManager tm_)
		{
			return GetByIconType(iconType, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_multipEO>> GetByIconTypeAsync(int iconType, int top_, TransactionManager tm_)
		{
			return await GetByIconTypeAsync(iconType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByIconType(int iconType, string sort_)
		{
			return GetByIconType(iconType, 0, sort_, null);
		}
		public async Task<List<Gsp_config_multipEO>> GetByIconTypeAsync(int iconType, string sort_)
		{
			return await GetByIconTypeAsync(iconType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByIconType(int iconType, string sort_, TransactionManager tm_)
		{
			return GetByIconType(iconType, 0, sort_, tm_);
		}
		public async Task<List<Gsp_config_multipEO>> GetByIconTypeAsync(int iconType, string sort_, TransactionManager tm_)
		{
			return await GetByIconTypeAsync(iconType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByIconType(int iconType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IconType` = @IconType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_config_multipEO.MapDataReader);
		}
		public async Task<List<Gsp_config_multipEO>> GetByIconTypeAsync(int iconType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IconType` = @IconType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_config_multipEO.MapDataReader);
		}
		#endregion // GetByIconType
		#region GetByMultip3
		
		/// <summary>
		/// 按 Multip3（字段） 查询
		/// </summary>
		/// /// <param name = "multip3">x3倍数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip3(int multip3)
		{
			return GetByMultip3(multip3, 0, string.Empty, null);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip3Async(int multip3)
		{
			return await GetByMultip3Async(multip3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multip3（字段） 查询
		/// </summary>
		/// /// <param name = "multip3">x3倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip3(int multip3, TransactionManager tm_)
		{
			return GetByMultip3(multip3, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip3Async(int multip3, TransactionManager tm_)
		{
			return await GetByMultip3Async(multip3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multip3（字段） 查询
		/// </summary>
		/// /// <param name = "multip3">x3倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip3(int multip3, int top_)
		{
			return GetByMultip3(multip3, top_, string.Empty, null);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip3Async(int multip3, int top_)
		{
			return await GetByMultip3Async(multip3, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multip3（字段） 查询
		/// </summary>
		/// /// <param name = "multip3">x3倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip3(int multip3, int top_, TransactionManager tm_)
		{
			return GetByMultip3(multip3, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip3Async(int multip3, int top_, TransactionManager tm_)
		{
			return await GetByMultip3Async(multip3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multip3（字段） 查询
		/// </summary>
		/// /// <param name = "multip3">x3倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip3(int multip3, string sort_)
		{
			return GetByMultip3(multip3, 0, sort_, null);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip3Async(int multip3, string sort_)
		{
			return await GetByMultip3Async(multip3, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Multip3（字段） 查询
		/// </summary>
		/// /// <param name = "multip3">x3倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip3(int multip3, string sort_, TransactionManager tm_)
		{
			return GetByMultip3(multip3, 0, sort_, tm_);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip3Async(int multip3, string sort_, TransactionManager tm_)
		{
			return await GetByMultip3Async(multip3, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Multip3（字段） 查询
		/// </summary>
		/// /// <param name = "multip3">x3倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip3(int multip3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multip3` = @Multip3", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip3", multip3, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_config_multipEO.MapDataReader);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip3Async(int multip3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multip3` = @Multip3", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip3", multip3, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_config_multipEO.MapDataReader);
		}
		#endregion // GetByMultip3
		#region GetByMultip4
		
		/// <summary>
		/// 按 Multip4（字段） 查询
		/// </summary>
		/// /// <param name = "multip4">x4倍数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip4(int multip4)
		{
			return GetByMultip4(multip4, 0, string.Empty, null);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip4Async(int multip4)
		{
			return await GetByMultip4Async(multip4, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multip4（字段） 查询
		/// </summary>
		/// /// <param name = "multip4">x4倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip4(int multip4, TransactionManager tm_)
		{
			return GetByMultip4(multip4, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip4Async(int multip4, TransactionManager tm_)
		{
			return await GetByMultip4Async(multip4, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multip4（字段） 查询
		/// </summary>
		/// /// <param name = "multip4">x4倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip4(int multip4, int top_)
		{
			return GetByMultip4(multip4, top_, string.Empty, null);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip4Async(int multip4, int top_)
		{
			return await GetByMultip4Async(multip4, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multip4（字段） 查询
		/// </summary>
		/// /// <param name = "multip4">x4倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip4(int multip4, int top_, TransactionManager tm_)
		{
			return GetByMultip4(multip4, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip4Async(int multip4, int top_, TransactionManager tm_)
		{
			return await GetByMultip4Async(multip4, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multip4（字段） 查询
		/// </summary>
		/// /// <param name = "multip4">x4倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip4(int multip4, string sort_)
		{
			return GetByMultip4(multip4, 0, sort_, null);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip4Async(int multip4, string sort_)
		{
			return await GetByMultip4Async(multip4, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Multip4（字段） 查询
		/// </summary>
		/// /// <param name = "multip4">x4倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip4(int multip4, string sort_, TransactionManager tm_)
		{
			return GetByMultip4(multip4, 0, sort_, tm_);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip4Async(int multip4, string sort_, TransactionManager tm_)
		{
			return await GetByMultip4Async(multip4, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Multip4（字段） 查询
		/// </summary>
		/// /// <param name = "multip4">x4倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip4(int multip4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multip4` = @Multip4", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip4", multip4, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_config_multipEO.MapDataReader);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip4Async(int multip4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multip4` = @Multip4", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip4", multip4, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_config_multipEO.MapDataReader);
		}
		#endregion // GetByMultip4
		#region GetByMultip5
		
		/// <summary>
		/// 按 Multip5（字段） 查询
		/// </summary>
		/// /// <param name = "multip5">x5倍数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip5(int multip5)
		{
			return GetByMultip5(multip5, 0, string.Empty, null);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip5Async(int multip5)
		{
			return await GetByMultip5Async(multip5, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multip5（字段） 查询
		/// </summary>
		/// /// <param name = "multip5">x5倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip5(int multip5, TransactionManager tm_)
		{
			return GetByMultip5(multip5, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip5Async(int multip5, TransactionManager tm_)
		{
			return await GetByMultip5Async(multip5, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multip5（字段） 查询
		/// </summary>
		/// /// <param name = "multip5">x5倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip5(int multip5, int top_)
		{
			return GetByMultip5(multip5, top_, string.Empty, null);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip5Async(int multip5, int top_)
		{
			return await GetByMultip5Async(multip5, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multip5（字段） 查询
		/// </summary>
		/// /// <param name = "multip5">x5倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip5(int multip5, int top_, TransactionManager tm_)
		{
			return GetByMultip5(multip5, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip5Async(int multip5, int top_, TransactionManager tm_)
		{
			return await GetByMultip5Async(multip5, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multip5（字段） 查询
		/// </summary>
		/// /// <param name = "multip5">x5倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip5(int multip5, string sort_)
		{
			return GetByMultip5(multip5, 0, sort_, null);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip5Async(int multip5, string sort_)
		{
			return await GetByMultip5Async(multip5, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Multip5（字段） 查询
		/// </summary>
		/// /// <param name = "multip5">x5倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip5(int multip5, string sort_, TransactionManager tm_)
		{
			return GetByMultip5(multip5, 0, sort_, tm_);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip5Async(int multip5, string sort_, TransactionManager tm_)
		{
			return await GetByMultip5Async(multip5, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Multip5（字段） 查询
		/// </summary>
		/// /// <param name = "multip5">x5倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_multipEO> GetByMultip5(int multip5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multip5` = @Multip5", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip5", multip5, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_config_multipEO.MapDataReader);
		}
		public async Task<List<Gsp_config_multipEO>> GetByMultip5Async(int multip5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multip5` = @Multip5", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip5", multip5, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_config_multipEO.MapDataReader);
		}
		#endregion // GetByMultip5
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
