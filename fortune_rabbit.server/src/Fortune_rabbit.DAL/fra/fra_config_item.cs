/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-11 17: 14:06
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
	/// 图标ICON权重表
	/// 【表 fra_config_item 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Fra_config_itemEO : IRowMapper<Fra_config_itemEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Fra_config_itemEO()
		{
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
		
		private int _originalIconType;
		/// <summary>
		/// 【数据库中的原始主键 IconType 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalIconType
		{
			get { return _originalIconType; }
			set { HasOriginal = true; _originalIconType = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ItemID", ItemID },  { "IconType", IconType }, };
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
		/// 1-普通,2-万能
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int IconType { get; set; }
		/// <summary>
		/// 图标名字
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string ItemName { get; set; }
		/// <summary>
		/// 图标ICON基础倍率
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int ItemBaseMultip { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Fra_config_itemEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Fra_config_itemEO MapDataReader(IDataReader reader)
		{
		    Fra_config_itemEO ret = new Fra_config_itemEO();
			ret.ItemID = reader.ToInt32("ItemID");
			ret.OriginalItemID = ret.ItemID;
			ret.IconType = reader.ToInt32("IconType");
			ret.OriginalIconType = ret.IconType;
			ret.ItemName = reader.ToString("ItemName");
			ret.ItemBaseMultip = reader.ToInt32("ItemBaseMultip");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 图标ICON权重表
	/// 【表 fra_config_item 的操作类】
	/// </summary>
	[Obsolete]
	public class Fra_config_itemMO : MySqlTableMO<Fra_config_itemEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`fra_config_item`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Fra_config_itemMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Fra_config_itemMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Fra_config_itemMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Fra_config_itemEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Fra_config_itemEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Fra_config_itemEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ItemID`, `IconType`, `ItemName`, `ItemBaseMultip`) VALUE (@ItemID, @IconType, @ItemName, @ItemBaseMultip);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", item.IconType, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemName", item.ItemName, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemBaseMultip", item.ItemBaseMultip, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Fra_config_itemEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Fra_config_itemEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Fra_config_itemEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ItemID`, `IconType`, `ItemName`, `ItemBaseMultip`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.ItemID},{item.IconType},'{item.ItemName}',{item.ItemBaseMultip}),");
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
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int itemID, int iconType, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemID, iconType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int itemID, int iconType, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemID, iconType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int itemID, int iconType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemID` = @ItemID AND `IconType` = @IconType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Fra_config_itemEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ItemID, item.IconType, tm_);
		}
		public async Task<int> RemoveAsync(Fra_config_itemEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ItemID, item.IconType, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByItemID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByItemID(int itemID, TransactionManager tm_ = null)
		{
			RepairRemoveByItemIDData(itemID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByItemIDAsync(int itemID, TransactionManager tm_ = null)
		{
			RepairRemoveByItemIDData(itemID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByItemIDData(int itemID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemID` = @ItemID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
		}
		#endregion // RemoveByItemID
		#region RemoveByIconType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "iconType">1-普通,2-万能</param>
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
		#region RemoveByItemName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "itemName">图标名字</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByItemName(string itemName, TransactionManager tm_ = null)
		{
			RepairRemoveByItemNameData(itemName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByItemNameAsync(string itemName, TransactionManager tm_ = null)
		{
			RepairRemoveByItemNameData(itemName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByItemNameData(string itemName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemName` = @ItemName";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemName", itemName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByItemName
		#region RemoveByItemBaseMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "itemBaseMultip">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByItemBaseMultip(int itemBaseMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByItemBaseMultipData(itemBaseMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByItemBaseMultipAsync(int itemBaseMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByItemBaseMultipData(itemBaseMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByItemBaseMultipData(int itemBaseMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemBaseMultip` = @ItemBaseMultip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemBaseMultip", itemBaseMultip, MySqlDbType.Int32));
		}
		#endregion // RemoveByItemBaseMultip
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
		public int Put(Fra_config_itemEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Fra_config_itemEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Fra_config_itemEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID, `IconType` = @IconType, `ItemName` = @ItemName, `ItemBaseMultip` = @ItemBaseMultip WHERE `ItemID` = @ItemID_Original AND `IconType` = @IconType_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", item.IconType, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemName", item.ItemName, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemBaseMultip", item.ItemBaseMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID_Original", item.HasOriginal ? item.OriginalItemID : item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType_Original", item.HasOriginal ? item.OriginalIconType : item.IconType, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Fra_config_itemEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Fra_config_itemEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, int iconType, string set_, params object[] values_)
		{
			return Put(set_, "`ItemID` = @ItemID AND `IconType` = @IconType", ConcatValues(values_, itemID, iconType));
		}
		public async Task<int> PutByPKAsync(int itemID, int iconType, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemID` = @ItemID AND `IconType` = @IconType", ConcatValues(values_, itemID, iconType));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, int iconType, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ItemID` = @ItemID AND `IconType` = @IconType", tm_, ConcatValues(values_, itemID, iconType));
		}
		public async Task<int> PutByPKAsync(int itemID, int iconType, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemID` = @ItemID AND `IconType` = @IconType", tm_, ConcatValues(values_, itemID, iconType));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, int iconType, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
	        };
			return Put(set_, "`ItemID` = @ItemID AND `IconType` = @IconType", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int itemID, int iconType, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`ItemID` = @ItemID AND `IconType` = @IconType", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutItemID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutItemID(int itemID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID";
			var parameter_ = Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutItemIDAsync(int itemID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID";
			var parameter_ = Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutItemID
		#region PutIconType
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "iconType">1-普通,2-万能</param>
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
		#region PutItemName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// /// <param name = "itemName">图标名字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutItemNameByPK(int itemID, int iconType, string itemName, TransactionManager tm_ = null)
		{
			RepairPutItemNameByPKData(itemID, iconType, itemName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutItemNameByPKAsync(int itemID, int iconType, string itemName, TransactionManager tm_ = null)
		{
			RepairPutItemNameByPKData(itemID, iconType, itemName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutItemNameByPKData(int itemID, int iconType, string itemName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemName` = @ItemName  WHERE `ItemID` = @ItemID AND `IconType` = @IconType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemName", itemName, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "itemName">图标名字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutItemName(string itemName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemName` = @ItemName";
			var parameter_ = Database.CreateInParameter("@ItemName", itemName, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutItemNameAsync(string itemName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemName` = @ItemName";
			var parameter_ = Database.CreateInParameter("@ItemName", itemName, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutItemName
		#region PutItemBaseMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// /// <param name = "itemBaseMultip">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutItemBaseMultipByPK(int itemID, int iconType, int itemBaseMultip, TransactionManager tm_ = null)
		{
			RepairPutItemBaseMultipByPKData(itemID, iconType, itemBaseMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutItemBaseMultipByPKAsync(int itemID, int iconType, int itemBaseMultip, TransactionManager tm_ = null)
		{
			RepairPutItemBaseMultipByPKData(itemID, iconType, itemBaseMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutItemBaseMultipByPKData(int itemID, int iconType, int itemBaseMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemBaseMultip` = @ItemBaseMultip  WHERE `ItemID` = @ItemID AND `IconType` = @IconType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemBaseMultip", itemBaseMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "itemBaseMultip">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutItemBaseMultip(int itemBaseMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemBaseMultip` = @ItemBaseMultip";
			var parameter_ = Database.CreateInParameter("@ItemBaseMultip", itemBaseMultip, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutItemBaseMultipAsync(int itemBaseMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemBaseMultip` = @ItemBaseMultip";
			var parameter_ = Database.CreateInParameter("@ItemBaseMultip", itemBaseMultip, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutItemBaseMultip
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Fra_config_itemEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemID, item.IconType) == null)
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
		public async Task<bool> SetAsync(Fra_config_itemEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemID, item.IconType) == null)
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
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Fra_config_itemEO GetByPK(int itemID, int iconType, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, iconType, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Fra_config_itemEO.MapDataReader);
		}
		public async Task<Fra_config_itemEO> GetByPKAsync(int itemID, int iconType, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, iconType, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Fra_config_itemEO.MapDataReader);
		}
		private void RepairGetByPKData(int itemID, int iconType, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ItemID` = @ItemID AND `IconType` = @IconType", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 ItemID（字段）
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetItemIDByPK(int itemID, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`ItemID`", "`ItemID` = @ItemID AND `IconType` = @IconType", paras_, tm_);
		}
		public async Task<int> GetItemIDByPKAsync(int itemID, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`ItemID`", "`ItemID` = @ItemID AND `IconType` = @IconType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IconType（字段）
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetIconTypeByPK(int itemID, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`IconType`", "`ItemID` = @ItemID AND `IconType` = @IconType", paras_, tm_);
		}
		public async Task<int> GetIconTypeByPKAsync(int itemID, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`IconType`", "`ItemID` = @ItemID AND `IconType` = @IconType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ItemName（字段）
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetItemNameByPK(int itemID, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (string)GetScalar("`ItemName`", "`ItemID` = @ItemID AND `IconType` = @IconType", paras_, tm_);
		}
		public async Task<string> GetItemNameByPKAsync(int itemID, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`ItemName`", "`ItemID` = @ItemID AND `IconType` = @IconType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ItemBaseMultip（字段）
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetItemBaseMultipByPK(int itemID, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`ItemBaseMultip`", "`ItemID` = @ItemID AND `IconType` = @IconType", paras_, tm_);
		}
		public async Task<int> GetItemBaseMultipByPKAsync(int itemID, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`ItemBaseMultip`", "`ItemID` = @ItemID AND `IconType` = @IconType", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByItemID
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemID(int itemID)
		{
			return GetByItemID(itemID, 0, string.Empty, null);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemIDAsync(int itemID)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemID(int itemID, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemIDAsync(int itemID, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemID(int itemID, int top_)
		{
			return GetByItemID(itemID, top_, string.Empty, null);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemIDAsync(int itemID, int top_)
		{
			return await GetByItemIDAsync(itemID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemID(int itemID, int top_, TransactionManager tm_)
		{
			return GetByItemID(itemID, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemIDAsync(int itemID, int top_, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemID(int itemID, string sort_)
		{
			return GetByItemID(itemID, 0, sort_, null);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemIDAsync(int itemID, string sort_)
		{
			return await GetByItemIDAsync(itemID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemID(int itemID, string sort_, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, sort_, tm_);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemIDAsync(int itemID, string sort_, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemID(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_config_itemEO.MapDataReader);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemIDAsync(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_config_itemEO.MapDataReader);
		}
		#endregion // GetByItemID
		#region GetByIconType
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByIconType(int iconType)
		{
			return GetByIconType(iconType, 0, string.Empty, null);
		}
		public async Task<List<Fra_config_itemEO>> GetByIconTypeAsync(int iconType)
		{
			return await GetByIconTypeAsync(iconType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByIconType(int iconType, TransactionManager tm_)
		{
			return GetByIconType(iconType, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_config_itemEO>> GetByIconTypeAsync(int iconType, TransactionManager tm_)
		{
			return await GetByIconTypeAsync(iconType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByIconType(int iconType, int top_)
		{
			return GetByIconType(iconType, top_, string.Empty, null);
		}
		public async Task<List<Fra_config_itemEO>> GetByIconTypeAsync(int iconType, int top_)
		{
			return await GetByIconTypeAsync(iconType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByIconType(int iconType, int top_, TransactionManager tm_)
		{
			return GetByIconType(iconType, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_config_itemEO>> GetByIconTypeAsync(int iconType, int top_, TransactionManager tm_)
		{
			return await GetByIconTypeAsync(iconType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByIconType(int iconType, string sort_)
		{
			return GetByIconType(iconType, 0, sort_, null);
		}
		public async Task<List<Fra_config_itemEO>> GetByIconTypeAsync(int iconType, string sort_)
		{
			return await GetByIconTypeAsync(iconType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByIconType(int iconType, string sort_, TransactionManager tm_)
		{
			return GetByIconType(iconType, 0, sort_, tm_);
		}
		public async Task<List<Fra_config_itemEO>> GetByIconTypeAsync(int iconType, string sort_, TransactionManager tm_)
		{
			return await GetByIconTypeAsync(iconType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByIconType(int iconType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IconType` = @IconType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_config_itemEO.MapDataReader);
		}
		public async Task<List<Fra_config_itemEO>> GetByIconTypeAsync(int iconType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IconType` = @IconType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_config_itemEO.MapDataReader);
		}
		#endregion // GetByIconType
		#region GetByItemName
		
		/// <summary>
		/// 按 ItemName（字段） 查询
		/// </summary>
		/// /// <param name = "itemName">图标名字</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemName(string itemName)
		{
			return GetByItemName(itemName, 0, string.Empty, null);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemNameAsync(string itemName)
		{
			return await GetByItemNameAsync(itemName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemName（字段） 查询
		/// </summary>
		/// /// <param name = "itemName">图标名字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemName(string itemName, TransactionManager tm_)
		{
			return GetByItemName(itemName, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemNameAsync(string itemName, TransactionManager tm_)
		{
			return await GetByItemNameAsync(itemName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemName（字段） 查询
		/// </summary>
		/// /// <param name = "itemName">图标名字</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemName(string itemName, int top_)
		{
			return GetByItemName(itemName, top_, string.Empty, null);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemNameAsync(string itemName, int top_)
		{
			return await GetByItemNameAsync(itemName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemName（字段） 查询
		/// </summary>
		/// /// <param name = "itemName">图标名字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemName(string itemName, int top_, TransactionManager tm_)
		{
			return GetByItemName(itemName, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemNameAsync(string itemName, int top_, TransactionManager tm_)
		{
			return await GetByItemNameAsync(itemName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemName（字段） 查询
		/// </summary>
		/// /// <param name = "itemName">图标名字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemName(string itemName, string sort_)
		{
			return GetByItemName(itemName, 0, sort_, null);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemNameAsync(string itemName, string sort_)
		{
			return await GetByItemNameAsync(itemName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ItemName（字段） 查询
		/// </summary>
		/// /// <param name = "itemName">图标名字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemName(string itemName, string sort_, TransactionManager tm_)
		{
			return GetByItemName(itemName, 0, sort_, tm_);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemNameAsync(string itemName, string sort_, TransactionManager tm_)
		{
			return await GetByItemNameAsync(itemName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ItemName（字段） 查询
		/// </summary>
		/// /// <param name = "itemName">图标名字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemName(string itemName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemName` = @ItemName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemName", itemName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_config_itemEO.MapDataReader);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemNameAsync(string itemName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemName` = @ItemName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemName", itemName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_config_itemEO.MapDataReader);
		}
		#endregion // GetByItemName
		#region GetByItemBaseMultip
		
		/// <summary>
		/// 按 ItemBaseMultip（字段） 查询
		/// </summary>
		/// /// <param name = "itemBaseMultip">图标ICON基础倍率</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemBaseMultip(int itemBaseMultip)
		{
			return GetByItemBaseMultip(itemBaseMultip, 0, string.Empty, null);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemBaseMultipAsync(int itemBaseMultip)
		{
			return await GetByItemBaseMultipAsync(itemBaseMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemBaseMultip（字段） 查询
		/// </summary>
		/// /// <param name = "itemBaseMultip">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemBaseMultip(int itemBaseMultip, TransactionManager tm_)
		{
			return GetByItemBaseMultip(itemBaseMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemBaseMultipAsync(int itemBaseMultip, TransactionManager tm_)
		{
			return await GetByItemBaseMultipAsync(itemBaseMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemBaseMultip（字段） 查询
		/// </summary>
		/// /// <param name = "itemBaseMultip">图标ICON基础倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemBaseMultip(int itemBaseMultip, int top_)
		{
			return GetByItemBaseMultip(itemBaseMultip, top_, string.Empty, null);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemBaseMultipAsync(int itemBaseMultip, int top_)
		{
			return await GetByItemBaseMultipAsync(itemBaseMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemBaseMultip（字段） 查询
		/// </summary>
		/// /// <param name = "itemBaseMultip">图标ICON基础倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemBaseMultip(int itemBaseMultip, int top_, TransactionManager tm_)
		{
			return GetByItemBaseMultip(itemBaseMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemBaseMultipAsync(int itemBaseMultip, int top_, TransactionManager tm_)
		{
			return await GetByItemBaseMultipAsync(itemBaseMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemBaseMultip（字段） 查询
		/// </summary>
		/// /// <param name = "itemBaseMultip">图标ICON基础倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemBaseMultip(int itemBaseMultip, string sort_)
		{
			return GetByItemBaseMultip(itemBaseMultip, 0, sort_, null);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemBaseMultipAsync(int itemBaseMultip, string sort_)
		{
			return await GetByItemBaseMultipAsync(itemBaseMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ItemBaseMultip（字段） 查询
		/// </summary>
		/// /// <param name = "itemBaseMultip">图标ICON基础倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemBaseMultip(int itemBaseMultip, string sort_, TransactionManager tm_)
		{
			return GetByItemBaseMultip(itemBaseMultip, 0, sort_, tm_);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemBaseMultipAsync(int itemBaseMultip, string sort_, TransactionManager tm_)
		{
			return await GetByItemBaseMultipAsync(itemBaseMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ItemBaseMultip（字段） 查询
		/// </summary>
		/// /// <param name = "itemBaseMultip">图标ICON基础倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_config_itemEO> GetByItemBaseMultip(int itemBaseMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemBaseMultip` = @ItemBaseMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemBaseMultip", itemBaseMultip, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_config_itemEO.MapDataReader);
		}
		public async Task<List<Fra_config_itemEO>> GetByItemBaseMultipAsync(int itemBaseMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemBaseMultip` = @ItemBaseMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemBaseMultip", itemBaseMultip, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_config_itemEO.MapDataReader);
		}
		#endregion // GetByItemBaseMultip
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
