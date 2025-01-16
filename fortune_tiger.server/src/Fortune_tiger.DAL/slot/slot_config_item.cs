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
	/// 图标ICON权重表
	/// 【表 slot_config_item 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Slot_config_itemEO : IRowMapper<Slot_config_itemEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Slot_config_itemEO()
		{
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
		
		private int _originalItemID;
		/// <summary>
		/// 【数据库中的原始主键 ItemID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalItemID
		{
			get { return _originalItemID; }
			set { HasOriginal = true; _originalItemID = value; }
		}
		
		private int _originalPoolType;
		/// <summary>
		/// 【数据库中的原始主键 PoolType 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalPoolType
		{
			get { return _originalPoolType; }
			set { HasOriginal = true; _originalPoolType = value; }
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
	        return new Dictionary<string, object>() { { "AppID", AppID },  { "ItemID", ItemID },  { "PoolType", PoolType },  { "IconType", IconType }, };
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
		/// 主键
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int ItemID { get; set; }
		/// <summary>
		/// 奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int PoolType { get; set; }
		/// <summary>
		/// 1-普通,2-万能
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int IconType { get; set; }
		/// <summary>
		/// 图标名字
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 5)]
		public string ItemName { get; set; }
		/// <summary>
		/// 图标ICON权重
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int ItemWeight { get; set; }
		/// <summary>
		/// 图标ICON基础倍率
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int ItemBaseMultip { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Slot_config_itemEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Slot_config_itemEO MapDataReader(IDataReader reader)
		{
		    Slot_config_itemEO ret = new Slot_config_itemEO();
			ret.AppID = reader.ToString("AppID");
			ret.OriginalAppID = ret.AppID;
			ret.ItemID = reader.ToInt32("ItemID");
			ret.OriginalItemID = ret.ItemID;
			ret.PoolType = reader.ToInt32("PoolType");
			ret.OriginalPoolType = ret.PoolType;
			ret.IconType = reader.ToInt32("IconType");
			ret.OriginalIconType = ret.IconType;
			ret.ItemName = reader.ToString("ItemName");
			ret.ItemWeight = reader.ToInt32("ItemWeight");
			ret.ItemBaseMultip = reader.ToInt32("ItemBaseMultip");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 图标ICON权重表
	/// 【表 slot_config_item 的操作类】
	/// </summary>
	[Obsolete]
	public class Slot_config_itemMO : MySqlTableMO<Slot_config_itemEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`slot_config_item`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Slot_config_itemMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Slot_config_itemMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Slot_config_itemMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Slot_config_itemEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Slot_config_itemEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Slot_config_itemEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`AppID`, `ItemID`, `PoolType`, `IconType`, `ItemName`, `ItemWeight`, `ItemBaseMultip`) VALUE (@AppID, @ItemID, @PoolType, @IconType, @ItemName, @ItemWeight, @ItemBaseMultip);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", item.PoolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", item.IconType, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemName", item.ItemName, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemWeight", item.ItemWeight, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemBaseMultip", item.ItemBaseMultip, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Slot_config_itemEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Slot_config_itemEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Slot_config_itemEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`AppID`, `ItemID`, `PoolType`, `IconType`, `ItemName`, `ItemWeight`, `ItemBaseMultip`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.AppID}',{item.ItemID},{item.PoolType},{item.IconType},'{item.ItemName}',{item.ItemWeight},{item.ItemBaseMultip}),");
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
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(appID, itemID, poolType, iconType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(appID, itemID, poolType, iconType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string appID, int itemID, int poolType, int iconType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Slot_config_itemEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.AppID, item.ItemID, item.PoolType, item.IconType, tm_);
		}
		public async Task<int> RemoveAsync(Slot_config_itemEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.AppID, item.ItemID, item.PoolType, item.IconType, tm_);
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
		#region RemoveByPoolType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPoolType(int poolType, TransactionManager tm_ = null)
		{
			RepairRemoveByPoolTypeData(poolType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPoolTypeAsync(int poolType, TransactionManager tm_ = null)
		{
			RepairRemoveByPoolTypeData(poolType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPoolTypeData(int poolType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PoolType` = @PoolType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32));
		}
		#endregion // RemoveByPoolType
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
		#region RemoveByItemWeight
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "itemWeight">图标ICON权重</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByItemWeight(int itemWeight, TransactionManager tm_ = null)
		{
			RepairRemoveByItemWeightData(itemWeight, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByItemWeightAsync(int itemWeight, TransactionManager tm_ = null)
		{
			RepairRemoveByItemWeightData(itemWeight, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByItemWeightData(int itemWeight, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemWeight` = @ItemWeight";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemWeight", itemWeight, MySqlDbType.Int32));
		}
		#endregion // RemoveByItemWeight
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
		public int Put(Slot_config_itemEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Slot_config_itemEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Slot_config_itemEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID, `ItemID` = @ItemID, `PoolType` = @PoolType, `IconType` = @IconType, `ItemName` = @ItemName, `ItemWeight` = @ItemWeight, `ItemBaseMultip` = @ItemBaseMultip WHERE `AppID` = @AppID_Original AND `ItemID` = @ItemID_Original AND `PoolType` = @PoolType_Original AND `IconType` = @IconType_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", item.PoolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", item.IconType, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemName", item.ItemName, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemWeight", item.ItemWeight, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemBaseMultip", item.ItemBaseMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID_Original", item.HasOriginal ? item.OriginalAppID : item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID_Original", item.HasOriginal ? item.OriginalItemID : item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType_Original", item.HasOriginal ? item.OriginalPoolType : item.PoolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType_Original", item.HasOriginal ? item.OriginalIconType : item.IconType, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Slot_config_itemEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Slot_config_itemEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, int itemID, int poolType, int iconType, string set_, params object[] values_)
		{
			return Put(set_, "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", ConcatValues(values_, appID, itemID, poolType, iconType));
		}
		public async Task<int> PutByPKAsync(string appID, int itemID, int poolType, int iconType, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", ConcatValues(values_, appID, itemID, poolType, iconType));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, int itemID, int poolType, int iconType, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", tm_, ConcatValues(values_, appID, itemID, poolType, iconType));
		}
		public async Task<int> PutByPKAsync(string appID, int itemID, int poolType, int iconType, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", tm_, ConcatValues(values_, appID, itemID, poolType, iconType));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, int itemID, int poolType, int iconType, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
	        };
			return Put(set_, "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string appID, int itemID, int poolType, int iconType, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", ConcatParameters(paras_, newParas_), tm_);
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
		#region PutPoolType
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPoolType(int poolType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PoolType` = @PoolType";
			var parameter_ = Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPoolTypeAsync(int poolType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PoolType` = @PoolType";
			var parameter_ = Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPoolType
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
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// /// <param name = "itemName">图标名字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutItemNameByPK(string appID, int itemID, int poolType, int iconType, string itemName, TransactionManager tm_ = null)
		{
			RepairPutItemNameByPKData(appID, itemID, poolType, iconType, itemName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutItemNameByPKAsync(string appID, int itemID, int poolType, int iconType, string itemName, TransactionManager tm_ = null)
		{
			RepairPutItemNameByPKData(appID, itemID, poolType, iconType, itemName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutItemNameByPKData(string appID, int itemID, int poolType, int iconType, string itemName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemName` = @ItemName  WHERE `AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemName", itemName, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
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
		#region PutItemWeight
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// /// <param name = "itemWeight">图标ICON权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutItemWeightByPK(string appID, int itemID, int poolType, int iconType, int itemWeight, TransactionManager tm_ = null)
		{
			RepairPutItemWeightByPKData(appID, itemID, poolType, iconType, itemWeight, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutItemWeightByPKAsync(string appID, int itemID, int poolType, int iconType, int itemWeight, TransactionManager tm_ = null)
		{
			RepairPutItemWeightByPKData(appID, itemID, poolType, iconType, itemWeight, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutItemWeightByPKData(string appID, int itemID, int poolType, int iconType, int itemWeight, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemWeight` = @ItemWeight  WHERE `AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemWeight", itemWeight, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "itemWeight">图标ICON权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutItemWeight(int itemWeight, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemWeight` = @ItemWeight";
			var parameter_ = Database.CreateInParameter("@ItemWeight", itemWeight, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutItemWeightAsync(int itemWeight, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemWeight` = @ItemWeight";
			var parameter_ = Database.CreateInParameter("@ItemWeight", itemWeight, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutItemWeight
		#region PutItemBaseMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// /// <param name = "itemBaseMultip">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutItemBaseMultipByPK(string appID, int itemID, int poolType, int iconType, int itemBaseMultip, TransactionManager tm_ = null)
		{
			RepairPutItemBaseMultipByPKData(appID, itemID, poolType, iconType, itemBaseMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutItemBaseMultipByPKAsync(string appID, int itemID, int poolType, int iconType, int itemBaseMultip, TransactionManager tm_ = null)
		{
			RepairPutItemBaseMultipByPKData(appID, itemID, poolType, iconType, itemBaseMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutItemBaseMultipByPKData(string appID, int itemID, int poolType, int iconType, int itemBaseMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemBaseMultip` = @ItemBaseMultip  WHERE `AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemBaseMultip", itemBaseMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
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
		public bool Set(Slot_config_itemEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AppID, item.ItemID, item.PoolType, item.IconType) == null)
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
		public async Task<bool> SetAsync(Slot_config_itemEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AppID, item.ItemID, item.PoolType, item.IconType) == null)
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
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Slot_config_itemEO GetByPK(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(appID, itemID, poolType, iconType, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Slot_config_itemEO.MapDataReader);
		}
		public async Task<Slot_config_itemEO> GetByPKAsync(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(appID, itemID, poolType, iconType, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Slot_config_itemEO.MapDataReader);
		}
		private void RepairGetByPKData(string appID, int itemID, int poolType, int iconType, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (string)GetScalar("`AppID`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`AppID`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ItemID（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetItemIDByPK(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`ItemID`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", paras_, tm_);
		}
		public async Task<int> GetItemIDByPKAsync(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`ItemID`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PoolType（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPoolTypeByPK(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`PoolType`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", paras_, tm_);
		}
		public async Task<int> GetPoolTypeByPKAsync(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`PoolType`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IconType（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetIconTypeByPK(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`IconType`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", paras_, tm_);
		}
		public async Task<int> GetIconTypeByPKAsync(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`IconType`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ItemName（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetItemNameByPK(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (string)GetScalar("`ItemName`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", paras_, tm_);
		}
		public async Task<string> GetItemNameByPKAsync(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`ItemName`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ItemWeight（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetItemWeightByPK(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`ItemWeight`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", paras_, tm_);
		}
		public async Task<int> GetItemWeightByPKAsync(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`ItemWeight`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ItemBaseMultip（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetItemBaseMultipByPK(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`ItemBaseMultip`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", paras_, tm_);
		}
		public async Task<int> GetItemBaseMultipByPKAsync(string appID, int itemID, int poolType, int iconType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`ItemBaseMultip`", "`AppID` = @AppID AND `ItemID` = @ItemID AND `PoolType` = @PoolType AND `IconType` = @IconType", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByAppIDAsync(string appID, int top_)
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
		public List<Slot_config_itemEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByAppIDAsync(string appID, string sort_)
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
		public List<Slot_config_itemEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
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
		public List<Slot_config_itemEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_itemEO.MapDataReader);
		}
		public async Task<List<Slot_config_itemEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_itemEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByItemID
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemID(int itemID)
		{
			return GetByItemID(itemID, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemIDAsync(int itemID)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemID(int itemID, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemIDAsync(int itemID, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemID(int itemID, int top_)
		{
			return GetByItemID(itemID, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemIDAsync(int itemID, int top_)
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
		public List<Slot_config_itemEO> GetByItemID(int itemID, int top_, TransactionManager tm_)
		{
			return GetByItemID(itemID, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemIDAsync(int itemID, int top_, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemID(int itemID, string sort_)
		{
			return GetByItemID(itemID, 0, sort_, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemIDAsync(int itemID, string sort_)
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
		public List<Slot_config_itemEO> GetByItemID(int itemID, string sort_, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemIDAsync(int itemID, string sort_, TransactionManager tm_)
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
		public List<Slot_config_itemEO> GetByItemID(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_itemEO.MapDataReader);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemIDAsync(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_itemEO.MapDataReader);
		}
		#endregion // GetByItemID
		#region GetByPoolType
		
		/// <summary>
		/// 按 PoolType（字段） 查询
		/// </summary>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByPoolType(int poolType)
		{
			return GetByPoolType(poolType, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByPoolTypeAsync(int poolType)
		{
			return await GetByPoolTypeAsync(poolType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PoolType（字段） 查询
		/// </summary>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByPoolType(int poolType, TransactionManager tm_)
		{
			return GetByPoolType(poolType, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByPoolTypeAsync(int poolType, TransactionManager tm_)
		{
			return await GetByPoolTypeAsync(poolType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PoolType（字段） 查询
		/// </summary>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByPoolType(int poolType, int top_)
		{
			return GetByPoolType(poolType, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByPoolTypeAsync(int poolType, int top_)
		{
			return await GetByPoolTypeAsync(poolType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PoolType（字段） 查询
		/// </summary>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByPoolType(int poolType, int top_, TransactionManager tm_)
		{
			return GetByPoolType(poolType, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByPoolTypeAsync(int poolType, int top_, TransactionManager tm_)
		{
			return await GetByPoolTypeAsync(poolType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PoolType（字段） 查询
		/// </summary>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByPoolType(int poolType, string sort_)
		{
			return GetByPoolType(poolType, 0, sort_, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByPoolTypeAsync(int poolType, string sort_)
		{
			return await GetByPoolTypeAsync(poolType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PoolType（字段） 查询
		/// </summary>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByPoolType(int poolType, string sort_, TransactionManager tm_)
		{
			return GetByPoolType(poolType, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByPoolTypeAsync(int poolType, string sort_, TransactionManager tm_)
		{
			return await GetByPoolTypeAsync(poolType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PoolType（字段） 查询
		/// </summary>
		/// /// <param name = "poolType">奖池类型1-[0-3000],2-[3001-30000],3-[3万以上]</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByPoolType(int poolType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PoolType` = @PoolType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_itemEO.MapDataReader);
		}
		public async Task<List<Slot_config_itemEO>> GetByPoolTypeAsync(int poolType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PoolType` = @PoolType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PoolType", poolType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_itemEO.MapDataReader);
		}
		#endregion // GetByPoolType
		#region GetByIconType
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByIconType(int iconType)
		{
			return GetByIconType(iconType, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByIconTypeAsync(int iconType)
		{
			return await GetByIconTypeAsync(iconType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByIconType(int iconType, TransactionManager tm_)
		{
			return GetByIconType(iconType, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByIconTypeAsync(int iconType, TransactionManager tm_)
		{
			return await GetByIconTypeAsync(iconType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByIconType(int iconType, int top_)
		{
			return GetByIconType(iconType, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByIconTypeAsync(int iconType, int top_)
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
		public List<Slot_config_itemEO> GetByIconType(int iconType, int top_, TransactionManager tm_)
		{
			return GetByIconType(iconType, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByIconTypeAsync(int iconType, int top_, TransactionManager tm_)
		{
			return await GetByIconTypeAsync(iconType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">1-普通,2-万能</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByIconType(int iconType, string sort_)
		{
			return GetByIconType(iconType, 0, sort_, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByIconTypeAsync(int iconType, string sort_)
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
		public List<Slot_config_itemEO> GetByIconType(int iconType, string sort_, TransactionManager tm_)
		{
			return GetByIconType(iconType, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByIconTypeAsync(int iconType, string sort_, TransactionManager tm_)
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
		public List<Slot_config_itemEO> GetByIconType(int iconType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IconType` = @IconType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_itemEO.MapDataReader);
		}
		public async Task<List<Slot_config_itemEO>> GetByIconTypeAsync(int iconType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IconType` = @IconType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_itemEO.MapDataReader);
		}
		#endregion // GetByIconType
		#region GetByItemName
		
		/// <summary>
		/// 按 ItemName（字段） 查询
		/// </summary>
		/// /// <param name = "itemName">图标名字</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemName(string itemName)
		{
			return GetByItemName(itemName, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemNameAsync(string itemName)
		{
			return await GetByItemNameAsync(itemName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemName（字段） 查询
		/// </summary>
		/// /// <param name = "itemName">图标名字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemName(string itemName, TransactionManager tm_)
		{
			return GetByItemName(itemName, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemNameAsync(string itemName, TransactionManager tm_)
		{
			return await GetByItemNameAsync(itemName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemName（字段） 查询
		/// </summary>
		/// /// <param name = "itemName">图标名字</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemName(string itemName, int top_)
		{
			return GetByItemName(itemName, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemNameAsync(string itemName, int top_)
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
		public List<Slot_config_itemEO> GetByItemName(string itemName, int top_, TransactionManager tm_)
		{
			return GetByItemName(itemName, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemNameAsync(string itemName, int top_, TransactionManager tm_)
		{
			return await GetByItemNameAsync(itemName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemName（字段） 查询
		/// </summary>
		/// /// <param name = "itemName">图标名字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemName(string itemName, string sort_)
		{
			return GetByItemName(itemName, 0, sort_, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemNameAsync(string itemName, string sort_)
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
		public List<Slot_config_itemEO> GetByItemName(string itemName, string sort_, TransactionManager tm_)
		{
			return GetByItemName(itemName, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemNameAsync(string itemName, string sort_, TransactionManager tm_)
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
		public List<Slot_config_itemEO> GetByItemName(string itemName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemName` = @ItemName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemName", itemName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_itemEO.MapDataReader);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemNameAsync(string itemName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemName` = @ItemName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemName", itemName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_itemEO.MapDataReader);
		}
		#endregion // GetByItemName
		#region GetByItemWeight
		
		/// <summary>
		/// 按 ItemWeight（字段） 查询
		/// </summary>
		/// /// <param name = "itemWeight">图标ICON权重</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemWeight(int itemWeight)
		{
			return GetByItemWeight(itemWeight, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemWeightAsync(int itemWeight)
		{
			return await GetByItemWeightAsync(itemWeight, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemWeight（字段） 查询
		/// </summary>
		/// /// <param name = "itemWeight">图标ICON权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemWeight(int itemWeight, TransactionManager tm_)
		{
			return GetByItemWeight(itemWeight, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemWeightAsync(int itemWeight, TransactionManager tm_)
		{
			return await GetByItemWeightAsync(itemWeight, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemWeight（字段） 查询
		/// </summary>
		/// /// <param name = "itemWeight">图标ICON权重</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemWeight(int itemWeight, int top_)
		{
			return GetByItemWeight(itemWeight, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemWeightAsync(int itemWeight, int top_)
		{
			return await GetByItemWeightAsync(itemWeight, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemWeight（字段） 查询
		/// </summary>
		/// /// <param name = "itemWeight">图标ICON权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemWeight(int itemWeight, int top_, TransactionManager tm_)
		{
			return GetByItemWeight(itemWeight, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemWeightAsync(int itemWeight, int top_, TransactionManager tm_)
		{
			return await GetByItemWeightAsync(itemWeight, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemWeight（字段） 查询
		/// </summary>
		/// /// <param name = "itemWeight">图标ICON权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemWeight(int itemWeight, string sort_)
		{
			return GetByItemWeight(itemWeight, 0, sort_, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemWeightAsync(int itemWeight, string sort_)
		{
			return await GetByItemWeightAsync(itemWeight, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ItemWeight（字段） 查询
		/// </summary>
		/// /// <param name = "itemWeight">图标ICON权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemWeight(int itemWeight, string sort_, TransactionManager tm_)
		{
			return GetByItemWeight(itemWeight, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemWeightAsync(int itemWeight, string sort_, TransactionManager tm_)
		{
			return await GetByItemWeightAsync(itemWeight, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ItemWeight（字段） 查询
		/// </summary>
		/// /// <param name = "itemWeight">图标ICON权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemWeight(int itemWeight, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemWeight` = @ItemWeight", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemWeight", itemWeight, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_itemEO.MapDataReader);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemWeightAsync(int itemWeight, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemWeight` = @ItemWeight", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemWeight", itemWeight, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_itemEO.MapDataReader);
		}
		#endregion // GetByItemWeight
		#region GetByItemBaseMultip
		
		/// <summary>
		/// 按 ItemBaseMultip（字段） 查询
		/// </summary>
		/// /// <param name = "itemBaseMultip">图标ICON基础倍率</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemBaseMultip(int itemBaseMultip)
		{
			return GetByItemBaseMultip(itemBaseMultip, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemBaseMultipAsync(int itemBaseMultip)
		{
			return await GetByItemBaseMultipAsync(itemBaseMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemBaseMultip（字段） 查询
		/// </summary>
		/// /// <param name = "itemBaseMultip">图标ICON基础倍率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemBaseMultip(int itemBaseMultip, TransactionManager tm_)
		{
			return GetByItemBaseMultip(itemBaseMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemBaseMultipAsync(int itemBaseMultip, TransactionManager tm_)
		{
			return await GetByItemBaseMultipAsync(itemBaseMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemBaseMultip（字段） 查询
		/// </summary>
		/// /// <param name = "itemBaseMultip">图标ICON基础倍率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemBaseMultip(int itemBaseMultip, int top_)
		{
			return GetByItemBaseMultip(itemBaseMultip, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemBaseMultipAsync(int itemBaseMultip, int top_)
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
		public List<Slot_config_itemEO> GetByItemBaseMultip(int itemBaseMultip, int top_, TransactionManager tm_)
		{
			return GetByItemBaseMultip(itemBaseMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemBaseMultipAsync(int itemBaseMultip, int top_, TransactionManager tm_)
		{
			return await GetByItemBaseMultipAsync(itemBaseMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemBaseMultip（字段） 查询
		/// </summary>
		/// /// <param name = "itemBaseMultip">图标ICON基础倍率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_itemEO> GetByItemBaseMultip(int itemBaseMultip, string sort_)
		{
			return GetByItemBaseMultip(itemBaseMultip, 0, sort_, null);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemBaseMultipAsync(int itemBaseMultip, string sort_)
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
		public List<Slot_config_itemEO> GetByItemBaseMultip(int itemBaseMultip, string sort_, TransactionManager tm_)
		{
			return GetByItemBaseMultip(itemBaseMultip, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemBaseMultipAsync(int itemBaseMultip, string sort_, TransactionManager tm_)
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
		public List<Slot_config_itemEO> GetByItemBaseMultip(int itemBaseMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemBaseMultip` = @ItemBaseMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemBaseMultip", itemBaseMultip, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_itemEO.MapDataReader);
		}
		public async Task<List<Slot_config_itemEO>> GetByItemBaseMultipAsync(int itemBaseMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemBaseMultip` = @ItemBaseMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemBaseMultip", itemBaseMultip, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_itemEO.MapDataReader);
		}
		#endregion // GetByItemBaseMultip
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
