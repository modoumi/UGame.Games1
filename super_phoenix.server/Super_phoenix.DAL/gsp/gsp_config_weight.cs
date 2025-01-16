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
	/// 所有奖池权重
	/// 【表 gsp_config_weight 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Gsp_config_weightEO : IRowMapper<Gsp_config_weightEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Gsp_config_weightEO()
		{
			this.Weight1 = 0;
			this.Weight2 = 0;
			this.Weight3 = 0;
			this.Weight4 = 0;
			this.Weight5 = 0;
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
		
		private int _originalItemType;
		/// <summary>
		/// 【数据库中的原始主键 ItemType 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalItemType
		{
			get { return _originalItemType; }
			set { HasOriginal = true; _originalItemType = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ItemID", ItemID },  { "ItemType", ItemType }, };
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
		/// 权重类型列0-2列,1-3列,2-4列,3-主游戏
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int ItemType { get; set; }
		/// <summary>
		/// icon类型1-普通,2-万能,3-scatter
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int IconType { get; set; }
		/// <summary>
		/// 轴1权重
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int Weight1 { get; set; }
		/// <summary>
		/// 轴2权重
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int Weight2 { get; set; }
		/// <summary>
		/// 轴3权重
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int Weight3 { get; set; }
		/// <summary>
		/// 轴4权重
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int Weight4 { get; set; }
		/// <summary>
		/// 轴5权重
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int Weight5 { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Gsp_config_weightEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Gsp_config_weightEO MapDataReader(IDataReader reader)
		{
		    Gsp_config_weightEO ret = new Gsp_config_weightEO();
			ret.ItemID = reader.ToInt32("ItemID");
			ret.OriginalItemID = ret.ItemID;
			ret.ItemType = reader.ToInt32("ItemType");
			ret.OriginalItemType = ret.ItemType;
			ret.IconType = reader.ToInt32("IconType");
			ret.Weight1 = reader.ToInt32("Weight1");
			ret.Weight2 = reader.ToInt32("Weight2");
			ret.Weight3 = reader.ToInt32("Weight3");
			ret.Weight4 = reader.ToInt32("Weight4");
			ret.Weight5 = reader.ToInt32("Weight5");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 所有奖池权重
	/// 【表 gsp_config_weight 的操作类】
	/// </summary>
	[Obsolete]
	public class Gsp_config_weightMO : MySqlTableMO<Gsp_config_weightEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`gsp_config_weight`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Gsp_config_weightMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Gsp_config_weightMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Gsp_config_weightMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Gsp_config_weightEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Gsp_config_weightEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Gsp_config_weightEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ItemID`, `ItemType`, `IconType`, `Weight1`, `Weight2`, `Weight3`, `Weight4`, `Weight5`) VALUE (@ItemID, @ItemType, @IconType, @Weight1, @Weight2, @Weight3, @Weight4, @Weight5);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", item.ItemType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", item.IconType, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight1", item.Weight1, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight2", item.Weight2, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight3", item.Weight3, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight4", item.Weight4, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight5", item.Weight5, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Gsp_config_weightEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Gsp_config_weightEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gsp_config_weightEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ItemID`, `ItemType`, `IconType`, `Weight1`, `Weight2`, `Weight3`, `Weight4`, `Weight5`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.ItemID},{item.ItemType},{item.IconType},{item.Weight1},{item.Weight2},{item.Weight3},{item.Weight4},{item.Weight5}),");
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
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int itemID, int itemType, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemID, itemType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int itemID, int itemType, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(itemID, itemType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int itemID, int itemType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemID` = @ItemID AND `ItemType` = @ItemType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Gsp_config_weightEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ItemID, item.ItemType, tm_);
		}
		public async Task<int> RemoveAsync(Gsp_config_weightEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ItemID, item.ItemType, tm_);
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
		#region RemoveByItemType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByItemType(int itemType, TransactionManager tm_ = null)
		{
			RepairRemoveByItemTypeData(itemType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByItemTypeAsync(int itemType, TransactionManager tm_ = null)
		{
			RepairRemoveByItemTypeData(itemType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByItemTypeData(int itemType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ItemType` = @ItemType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32));
		}
		#endregion // RemoveByItemType
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
		#region RemoveByWeight1
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight1">轴1权重</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeight1(int weight1, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight1Data(weight1, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeight1Async(int weight1, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight1Data(weight1, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeight1Data(int weight1, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Weight1` = @Weight1";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight1", weight1, MySqlDbType.Int32));
		}
		#endregion // RemoveByWeight1
		#region RemoveByWeight2
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight2">轴2权重</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeight2(int weight2, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight2Data(weight2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeight2Async(int weight2, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight2Data(weight2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeight2Data(int weight2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Weight2` = @Weight2";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight2", weight2, MySqlDbType.Int32));
		}
		#endregion // RemoveByWeight2
		#region RemoveByWeight3
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight3">轴3权重</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeight3(int weight3, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight3Data(weight3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeight3Async(int weight3, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight3Data(weight3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeight3Data(int weight3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Weight3` = @Weight3";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight3", weight3, MySqlDbType.Int32));
		}
		#endregion // RemoveByWeight3
		#region RemoveByWeight4
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight4">轴4权重</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeight4(int weight4, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight4Data(weight4, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeight4Async(int weight4, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight4Data(weight4, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeight4Data(int weight4, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Weight4` = @Weight4";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight4", weight4, MySqlDbType.Int32));
		}
		#endregion // RemoveByWeight4
		#region RemoveByWeight5
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight5">轴5权重</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeight5(int weight5, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight5Data(weight5, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeight5Async(int weight5, TransactionManager tm_ = null)
		{
			RepairRemoveByWeight5Data(weight5, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeight5Data(int weight5, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Weight5` = @Weight5";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight5", weight5, MySqlDbType.Int32));
		}
		#endregion // RemoveByWeight5
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
		public int Put(Gsp_config_weightEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Gsp_config_weightEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Gsp_config_weightEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ItemID` = @ItemID, `ItemType` = @ItemType, `IconType` = @IconType, `Weight1` = @Weight1, `Weight2` = @Weight2, `Weight3` = @Weight3, `Weight4` = @Weight4, `Weight5` = @Weight5 WHERE `ItemID` = @ItemID_Original AND `ItemType` = @ItemType_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", item.ItemType, MySqlDbType.Int32),
				Database.CreateInParameter("@IconType", item.IconType, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight1", item.Weight1, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight2", item.Weight2, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight3", item.Weight3, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight4", item.Weight4, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight5", item.Weight5, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID_Original", item.HasOriginal ? item.OriginalItemID : item.ItemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType_Original", item.HasOriginal ? item.OriginalItemType : item.ItemType, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Gsp_config_weightEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Gsp_config_weightEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, int itemType, string set_, params object[] values_)
		{
			return Put(set_, "`ItemID` = @ItemID AND `ItemType` = @ItemType", ConcatValues(values_, itemID, itemType));
		}
		public async Task<int> PutByPKAsync(int itemID, int itemType, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemID` = @ItemID AND `ItemType` = @ItemType", ConcatValues(values_, itemID, itemType));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, int itemType, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ItemID` = @ItemID AND `ItemType` = @ItemType", tm_, ConcatValues(values_, itemID, itemType));
		}
		public async Task<int> PutByPKAsync(int itemID, int itemType, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ItemID` = @ItemID AND `ItemType` = @ItemType", tm_, ConcatValues(values_, itemID, itemType));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int itemID, int itemType, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
	        };
			return Put(set_, "`ItemID` = @ItemID AND `ItemType` = @ItemType", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int itemID, int itemType, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`ItemID` = @ItemID AND `ItemType` = @ItemType", ConcatParameters(paras_, newParas_), tm_);
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
		#region PutItemType
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutItemType(int itemType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemType` = @ItemType";
			var parameter_ = Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutItemTypeAsync(int itemType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ItemType` = @ItemType";
			var parameter_ = Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutItemType
		#region PutIconType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIconTypeByPK(int itemID, int itemType, int iconType, TransactionManager tm_ = null)
		{
			RepairPutIconTypeByPKData(itemID, itemType, iconType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIconTypeByPKAsync(int itemID, int itemType, int iconType, TransactionManager tm_ = null)
		{
			RepairPutIconTypeByPKData(itemID, itemType, iconType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIconTypeByPKData(int itemID, int itemType, int iconType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IconType` = @IconType  WHERE `ItemID` = @ItemID AND `ItemType` = @ItemType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
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
		#region PutWeight1
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// /// <param name = "weight1">轴1权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight1ByPK(int itemID, int itemType, int weight1, TransactionManager tm_ = null)
		{
			RepairPutWeight1ByPKData(itemID, itemType, weight1, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeight1ByPKAsync(int itemID, int itemType, int weight1, TransactionManager tm_ = null)
		{
			RepairPutWeight1ByPKData(itemID, itemType, weight1, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeight1ByPKData(int itemID, int itemType, int weight1, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight1` = @Weight1  WHERE `ItemID` = @ItemID AND `ItemType` = @ItemType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight1", weight1, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight1">轴1权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight1(int weight1, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight1` = @Weight1";
			var parameter_ = Database.CreateInParameter("@Weight1", weight1, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeight1Async(int weight1, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight1` = @Weight1";
			var parameter_ = Database.CreateInParameter("@Weight1", weight1, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWeight1
		#region PutWeight2
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// /// <param name = "weight2">轴2权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight2ByPK(int itemID, int itemType, int weight2, TransactionManager tm_ = null)
		{
			RepairPutWeight2ByPKData(itemID, itemType, weight2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeight2ByPKAsync(int itemID, int itemType, int weight2, TransactionManager tm_ = null)
		{
			RepairPutWeight2ByPKData(itemID, itemType, weight2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeight2ByPKData(int itemID, int itemType, int weight2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight2` = @Weight2  WHERE `ItemID` = @ItemID AND `ItemType` = @ItemType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight2", weight2, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight2">轴2权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight2(int weight2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight2` = @Weight2";
			var parameter_ = Database.CreateInParameter("@Weight2", weight2, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeight2Async(int weight2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight2` = @Weight2";
			var parameter_ = Database.CreateInParameter("@Weight2", weight2, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWeight2
		#region PutWeight3
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// /// <param name = "weight3">轴3权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight3ByPK(int itemID, int itemType, int weight3, TransactionManager tm_ = null)
		{
			RepairPutWeight3ByPKData(itemID, itemType, weight3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeight3ByPKAsync(int itemID, int itemType, int weight3, TransactionManager tm_ = null)
		{
			RepairPutWeight3ByPKData(itemID, itemType, weight3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeight3ByPKData(int itemID, int itemType, int weight3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight3` = @Weight3  WHERE `ItemID` = @ItemID AND `ItemType` = @ItemType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight3", weight3, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight3">轴3权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight3(int weight3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight3` = @Weight3";
			var parameter_ = Database.CreateInParameter("@Weight3", weight3, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeight3Async(int weight3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight3` = @Weight3";
			var parameter_ = Database.CreateInParameter("@Weight3", weight3, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWeight3
		#region PutWeight4
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// /// <param name = "weight4">轴4权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight4ByPK(int itemID, int itemType, int weight4, TransactionManager tm_ = null)
		{
			RepairPutWeight4ByPKData(itemID, itemType, weight4, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeight4ByPKAsync(int itemID, int itemType, int weight4, TransactionManager tm_ = null)
		{
			RepairPutWeight4ByPKData(itemID, itemType, weight4, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeight4ByPKData(int itemID, int itemType, int weight4, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight4` = @Weight4  WHERE `ItemID` = @ItemID AND `ItemType` = @ItemType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight4", weight4, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight4">轴4权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight4(int weight4, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight4` = @Weight4";
			var parameter_ = Database.CreateInParameter("@Weight4", weight4, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeight4Async(int weight4, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight4` = @Weight4";
			var parameter_ = Database.CreateInParameter("@Weight4", weight4, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWeight4
		#region PutWeight5
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// /// <param name = "weight5">轴5权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight5ByPK(int itemID, int itemType, int weight5, TransactionManager tm_ = null)
		{
			RepairPutWeight5ByPKData(itemID, itemType, weight5, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeight5ByPKAsync(int itemID, int itemType, int weight5, TransactionManager tm_ = null)
		{
			RepairPutWeight5ByPKData(itemID, itemType, weight5, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeight5ByPKData(int itemID, int itemType, int weight5, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight5` = @Weight5  WHERE `ItemID` = @ItemID AND `ItemType` = @ItemType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight5", weight5, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight5">轴5权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight5(int weight5, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight5` = @Weight5";
			var parameter_ = Database.CreateInParameter("@Weight5", weight5, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeight5Async(int weight5, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight5` = @Weight5";
			var parameter_ = Database.CreateInParameter("@Weight5", weight5, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWeight5
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Gsp_config_weightEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemID, item.ItemType) == null)
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
		public async Task<bool> SetAsync(Gsp_config_weightEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ItemID, item.ItemType) == null)
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
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Gsp_config_weightEO GetByPK(int itemID, int itemType, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, itemType, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		public async Task<Gsp_config_weightEO> GetByPKAsync(int itemID, int itemType, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(itemID, itemType, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		private void RepairGetByPKData(int itemID, int itemType, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ItemID` = @ItemID AND `ItemType` = @ItemType", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 ItemID（字段）
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetItemIDByPK(int itemID, int itemType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`ItemID`", "`ItemID` = @ItemID AND `ItemType` = @ItemType", paras_, tm_);
		}
		public async Task<int> GetItemIDByPKAsync(int itemID, int itemType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`ItemID`", "`ItemID` = @ItemID AND `ItemType` = @ItemType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ItemType（字段）
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetItemTypeByPK(int itemID, int itemType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`ItemType`", "`ItemID` = @ItemID AND `ItemType` = @ItemType", paras_, tm_);
		}
		public async Task<int> GetItemTypeByPKAsync(int itemID, int itemType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`ItemType`", "`ItemID` = @ItemID AND `ItemType` = @ItemType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IconType（字段）
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetIconTypeByPK(int itemID, int itemType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`IconType`", "`ItemID` = @ItemID AND `ItemType` = @ItemType", paras_, tm_);
		}
		public async Task<int> GetIconTypeByPKAsync(int itemID, int itemType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`IconType`", "`ItemID` = @ItemID AND `ItemType` = @ItemType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight1（字段）
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeight1ByPK(int itemID, int itemType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Weight1`", "`ItemID` = @ItemID AND `ItemType` = @ItemType", paras_, tm_);
		}
		public async Task<int> GetWeight1ByPKAsync(int itemID, int itemType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Weight1`", "`ItemID` = @ItemID AND `ItemType` = @ItemType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight2（字段）
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeight2ByPK(int itemID, int itemType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Weight2`", "`ItemID` = @ItemID AND `ItemType` = @ItemType", paras_, tm_);
		}
		public async Task<int> GetWeight2ByPKAsync(int itemID, int itemType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Weight2`", "`ItemID` = @ItemID AND `ItemType` = @ItemType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight3（字段）
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeight3ByPK(int itemID, int itemType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Weight3`", "`ItemID` = @ItemID AND `ItemType` = @ItemType", paras_, tm_);
		}
		public async Task<int> GetWeight3ByPKAsync(int itemID, int itemType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Weight3`", "`ItemID` = @ItemID AND `ItemType` = @ItemType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight4（字段）
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeight4ByPK(int itemID, int itemType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Weight4`", "`ItemID` = @ItemID AND `ItemType` = @ItemType", paras_, tm_);
		}
		public async Task<int> GetWeight4ByPKAsync(int itemID, int itemType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Weight4`", "`ItemID` = @ItemID AND `ItemType` = @ItemType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight5（字段）
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeight5ByPK(int itemID, int itemType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Weight5`", "`ItemID` = @ItemID AND `ItemType` = @ItemType", paras_, tm_);
		}
		public async Task<int> GetWeight5ByPKAsync(int itemID, int itemType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32),
				Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Weight5`", "`ItemID` = @ItemID AND `ItemType` = @ItemType", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByItemID
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByItemID(int itemID)
		{
			return GetByItemID(itemID, 0, string.Empty, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByItemIDAsync(int itemID)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByItemID(int itemID, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByItemIDAsync(int itemID, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByItemID(int itemID, int top_)
		{
			return GetByItemID(itemID, top_, string.Empty, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByItemIDAsync(int itemID, int top_)
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
		public List<Gsp_config_weightEO> GetByItemID(int itemID, int top_, TransactionManager tm_)
		{
			return GetByItemID(itemID, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByItemIDAsync(int itemID, int top_, TransactionManager tm_)
		{
			return await GetByItemIDAsync(itemID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemID（字段） 查询
		/// </summary>
		/// /// <param name = "itemID">主键</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByItemID(int itemID, string sort_)
		{
			return GetByItemID(itemID, 0, sort_, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByItemIDAsync(int itemID, string sort_)
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
		public List<Gsp_config_weightEO> GetByItemID(int itemID, string sort_, TransactionManager tm_)
		{
			return GetByItemID(itemID, 0, sort_, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByItemIDAsync(int itemID, string sort_, TransactionManager tm_)
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
		public List<Gsp_config_weightEO> GetByItemID(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		public async Task<List<Gsp_config_weightEO>> GetByItemIDAsync(int itemID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemID` = @ItemID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemID", itemID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		#endregion // GetByItemID
		#region GetByItemType
		
		/// <summary>
		/// 按 ItemType（字段） 查询
		/// </summary>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByItemType(int itemType)
		{
			return GetByItemType(itemType, 0, string.Empty, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByItemTypeAsync(int itemType)
		{
			return await GetByItemTypeAsync(itemType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemType（字段） 查询
		/// </summary>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByItemType(int itemType, TransactionManager tm_)
		{
			return GetByItemType(itemType, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByItemTypeAsync(int itemType, TransactionManager tm_)
		{
			return await GetByItemTypeAsync(itemType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemType（字段） 查询
		/// </summary>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByItemType(int itemType, int top_)
		{
			return GetByItemType(itemType, top_, string.Empty, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByItemTypeAsync(int itemType, int top_)
		{
			return await GetByItemTypeAsync(itemType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ItemType（字段） 查询
		/// </summary>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByItemType(int itemType, int top_, TransactionManager tm_)
		{
			return GetByItemType(itemType, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByItemTypeAsync(int itemType, int top_, TransactionManager tm_)
		{
			return await GetByItemTypeAsync(itemType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ItemType（字段） 查询
		/// </summary>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByItemType(int itemType, string sort_)
		{
			return GetByItemType(itemType, 0, sort_, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByItemTypeAsync(int itemType, string sort_)
		{
			return await GetByItemTypeAsync(itemType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ItemType（字段） 查询
		/// </summary>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByItemType(int itemType, string sort_, TransactionManager tm_)
		{
			return GetByItemType(itemType, 0, sort_, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByItemTypeAsync(int itemType, string sort_, TransactionManager tm_)
		{
			return await GetByItemTypeAsync(itemType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ItemType（字段） 查询
		/// </summary>
		/// /// <param name = "itemType">权重类型列0-2列,1-3列,2-4列,3-主游戏</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByItemType(int itemType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemType` = @ItemType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		public async Task<List<Gsp_config_weightEO>> GetByItemTypeAsync(int itemType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ItemType` = @ItemType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ItemType", itemType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		#endregion // GetByItemType
		#region GetByIconType
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByIconType(int iconType)
		{
			return GetByIconType(iconType, 0, string.Empty, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByIconTypeAsync(int iconType)
		{
			return await GetByIconTypeAsync(iconType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByIconType(int iconType, TransactionManager tm_)
		{
			return GetByIconType(iconType, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByIconTypeAsync(int iconType, TransactionManager tm_)
		{
			return await GetByIconTypeAsync(iconType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByIconType(int iconType, int top_)
		{
			return GetByIconType(iconType, top_, string.Empty, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByIconTypeAsync(int iconType, int top_)
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
		public List<Gsp_config_weightEO> GetByIconType(int iconType, int top_, TransactionManager tm_)
		{
			return GetByIconType(iconType, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByIconTypeAsync(int iconType, int top_, TransactionManager tm_)
		{
			return await GetByIconTypeAsync(iconType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IconType（字段） 查询
		/// </summary>
		/// /// <param name = "iconType">icon类型1-普通,2-万能,3-scatter</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByIconType(int iconType, string sort_)
		{
			return GetByIconType(iconType, 0, sort_, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByIconTypeAsync(int iconType, string sort_)
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
		public List<Gsp_config_weightEO> GetByIconType(int iconType, string sort_, TransactionManager tm_)
		{
			return GetByIconType(iconType, 0, sort_, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByIconTypeAsync(int iconType, string sort_, TransactionManager tm_)
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
		public List<Gsp_config_weightEO> GetByIconType(int iconType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IconType` = @IconType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		public async Task<List<Gsp_config_weightEO>> GetByIconTypeAsync(int iconType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IconType` = @IconType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IconType", iconType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		#endregion // GetByIconType
		#region GetByWeight1
		
		/// <summary>
		/// 按 Weight1（字段） 查询
		/// </summary>
		/// /// <param name = "weight1">轴1权重</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight1(int weight1)
		{
			return GetByWeight1(weight1, 0, string.Empty, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight1Async(int weight1)
		{
			return await GetByWeight1Async(weight1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight1（字段） 查询
		/// </summary>
		/// /// <param name = "weight1">轴1权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight1(int weight1, TransactionManager tm_)
		{
			return GetByWeight1(weight1, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight1Async(int weight1, TransactionManager tm_)
		{
			return await GetByWeight1Async(weight1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight1（字段） 查询
		/// </summary>
		/// /// <param name = "weight1">轴1权重</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight1(int weight1, int top_)
		{
			return GetByWeight1(weight1, top_, string.Empty, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight1Async(int weight1, int top_)
		{
			return await GetByWeight1Async(weight1, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight1（字段） 查询
		/// </summary>
		/// /// <param name = "weight1">轴1权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight1(int weight1, int top_, TransactionManager tm_)
		{
			return GetByWeight1(weight1, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight1Async(int weight1, int top_, TransactionManager tm_)
		{
			return await GetByWeight1Async(weight1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight1（字段） 查询
		/// </summary>
		/// /// <param name = "weight1">轴1权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight1(int weight1, string sort_)
		{
			return GetByWeight1(weight1, 0, sort_, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight1Async(int weight1, string sort_)
		{
			return await GetByWeight1Async(weight1, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Weight1（字段） 查询
		/// </summary>
		/// /// <param name = "weight1">轴1权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight1(int weight1, string sort_, TransactionManager tm_)
		{
			return GetByWeight1(weight1, 0, sort_, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight1Async(int weight1, string sort_, TransactionManager tm_)
		{
			return await GetByWeight1Async(weight1, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Weight1（字段） 查询
		/// </summary>
		/// /// <param name = "weight1">轴1权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight1(int weight1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight1` = @Weight1", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight1", weight1, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight1Async(int weight1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight1` = @Weight1", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight1", weight1, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		#endregion // GetByWeight1
		#region GetByWeight2
		
		/// <summary>
		/// 按 Weight2（字段） 查询
		/// </summary>
		/// /// <param name = "weight2">轴2权重</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight2(int weight2)
		{
			return GetByWeight2(weight2, 0, string.Empty, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight2Async(int weight2)
		{
			return await GetByWeight2Async(weight2, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight2（字段） 查询
		/// </summary>
		/// /// <param name = "weight2">轴2权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight2(int weight2, TransactionManager tm_)
		{
			return GetByWeight2(weight2, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight2Async(int weight2, TransactionManager tm_)
		{
			return await GetByWeight2Async(weight2, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight2（字段） 查询
		/// </summary>
		/// /// <param name = "weight2">轴2权重</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight2(int weight2, int top_)
		{
			return GetByWeight2(weight2, top_, string.Empty, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight2Async(int weight2, int top_)
		{
			return await GetByWeight2Async(weight2, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight2（字段） 查询
		/// </summary>
		/// /// <param name = "weight2">轴2权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight2(int weight2, int top_, TransactionManager tm_)
		{
			return GetByWeight2(weight2, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight2Async(int weight2, int top_, TransactionManager tm_)
		{
			return await GetByWeight2Async(weight2, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight2（字段） 查询
		/// </summary>
		/// /// <param name = "weight2">轴2权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight2(int weight2, string sort_)
		{
			return GetByWeight2(weight2, 0, sort_, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight2Async(int weight2, string sort_)
		{
			return await GetByWeight2Async(weight2, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Weight2（字段） 查询
		/// </summary>
		/// /// <param name = "weight2">轴2权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight2(int weight2, string sort_, TransactionManager tm_)
		{
			return GetByWeight2(weight2, 0, sort_, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight2Async(int weight2, string sort_, TransactionManager tm_)
		{
			return await GetByWeight2Async(weight2, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Weight2（字段） 查询
		/// </summary>
		/// /// <param name = "weight2">轴2权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight2(int weight2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight2` = @Weight2", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight2", weight2, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight2Async(int weight2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight2` = @Weight2", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight2", weight2, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		#endregion // GetByWeight2
		#region GetByWeight3
		
		/// <summary>
		/// 按 Weight3（字段） 查询
		/// </summary>
		/// /// <param name = "weight3">轴3权重</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight3(int weight3)
		{
			return GetByWeight3(weight3, 0, string.Empty, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight3Async(int weight3)
		{
			return await GetByWeight3Async(weight3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight3（字段） 查询
		/// </summary>
		/// /// <param name = "weight3">轴3权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight3(int weight3, TransactionManager tm_)
		{
			return GetByWeight3(weight3, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight3Async(int weight3, TransactionManager tm_)
		{
			return await GetByWeight3Async(weight3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight3（字段） 查询
		/// </summary>
		/// /// <param name = "weight3">轴3权重</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight3(int weight3, int top_)
		{
			return GetByWeight3(weight3, top_, string.Empty, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight3Async(int weight3, int top_)
		{
			return await GetByWeight3Async(weight3, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight3（字段） 查询
		/// </summary>
		/// /// <param name = "weight3">轴3权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight3(int weight3, int top_, TransactionManager tm_)
		{
			return GetByWeight3(weight3, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight3Async(int weight3, int top_, TransactionManager tm_)
		{
			return await GetByWeight3Async(weight3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight3（字段） 查询
		/// </summary>
		/// /// <param name = "weight3">轴3权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight3(int weight3, string sort_)
		{
			return GetByWeight3(weight3, 0, sort_, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight3Async(int weight3, string sort_)
		{
			return await GetByWeight3Async(weight3, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Weight3（字段） 查询
		/// </summary>
		/// /// <param name = "weight3">轴3权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight3(int weight3, string sort_, TransactionManager tm_)
		{
			return GetByWeight3(weight3, 0, sort_, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight3Async(int weight3, string sort_, TransactionManager tm_)
		{
			return await GetByWeight3Async(weight3, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Weight3（字段） 查询
		/// </summary>
		/// /// <param name = "weight3">轴3权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight3(int weight3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight3` = @Weight3", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight3", weight3, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight3Async(int weight3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight3` = @Weight3", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight3", weight3, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		#endregion // GetByWeight3
		#region GetByWeight4
		
		/// <summary>
		/// 按 Weight4（字段） 查询
		/// </summary>
		/// /// <param name = "weight4">轴4权重</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight4(int weight4)
		{
			return GetByWeight4(weight4, 0, string.Empty, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight4Async(int weight4)
		{
			return await GetByWeight4Async(weight4, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight4（字段） 查询
		/// </summary>
		/// /// <param name = "weight4">轴4权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight4(int weight4, TransactionManager tm_)
		{
			return GetByWeight4(weight4, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight4Async(int weight4, TransactionManager tm_)
		{
			return await GetByWeight4Async(weight4, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight4（字段） 查询
		/// </summary>
		/// /// <param name = "weight4">轴4权重</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight4(int weight4, int top_)
		{
			return GetByWeight4(weight4, top_, string.Empty, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight4Async(int weight4, int top_)
		{
			return await GetByWeight4Async(weight4, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight4（字段） 查询
		/// </summary>
		/// /// <param name = "weight4">轴4权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight4(int weight4, int top_, TransactionManager tm_)
		{
			return GetByWeight4(weight4, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight4Async(int weight4, int top_, TransactionManager tm_)
		{
			return await GetByWeight4Async(weight4, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight4（字段） 查询
		/// </summary>
		/// /// <param name = "weight4">轴4权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight4(int weight4, string sort_)
		{
			return GetByWeight4(weight4, 0, sort_, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight4Async(int weight4, string sort_)
		{
			return await GetByWeight4Async(weight4, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Weight4（字段） 查询
		/// </summary>
		/// /// <param name = "weight4">轴4权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight4(int weight4, string sort_, TransactionManager tm_)
		{
			return GetByWeight4(weight4, 0, sort_, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight4Async(int weight4, string sort_, TransactionManager tm_)
		{
			return await GetByWeight4Async(weight4, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Weight4（字段） 查询
		/// </summary>
		/// /// <param name = "weight4">轴4权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight4(int weight4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight4` = @Weight4", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight4", weight4, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight4Async(int weight4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight4` = @Weight4", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight4", weight4, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		#endregion // GetByWeight4
		#region GetByWeight5
		
		/// <summary>
		/// 按 Weight5（字段） 查询
		/// </summary>
		/// /// <param name = "weight5">轴5权重</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight5(int weight5)
		{
			return GetByWeight5(weight5, 0, string.Empty, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight5Async(int weight5)
		{
			return await GetByWeight5Async(weight5, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight5（字段） 查询
		/// </summary>
		/// /// <param name = "weight5">轴5权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight5(int weight5, TransactionManager tm_)
		{
			return GetByWeight5(weight5, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight5Async(int weight5, TransactionManager tm_)
		{
			return await GetByWeight5Async(weight5, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight5（字段） 查询
		/// </summary>
		/// /// <param name = "weight5">轴5权重</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight5(int weight5, int top_)
		{
			return GetByWeight5(weight5, top_, string.Empty, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight5Async(int weight5, int top_)
		{
			return await GetByWeight5Async(weight5, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight5（字段） 查询
		/// </summary>
		/// /// <param name = "weight5">轴5权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight5(int weight5, int top_, TransactionManager tm_)
		{
			return GetByWeight5(weight5, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight5Async(int weight5, int top_, TransactionManager tm_)
		{
			return await GetByWeight5Async(weight5, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight5（字段） 查询
		/// </summary>
		/// /// <param name = "weight5">轴5权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight5(int weight5, string sort_)
		{
			return GetByWeight5(weight5, 0, sort_, null);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight5Async(int weight5, string sort_)
		{
			return await GetByWeight5Async(weight5, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Weight5（字段） 查询
		/// </summary>
		/// /// <param name = "weight5">轴5权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight5(int weight5, string sort_, TransactionManager tm_)
		{
			return GetByWeight5(weight5, 0, sort_, tm_);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight5Async(int weight5, string sort_, TransactionManager tm_)
		{
			return await GetByWeight5Async(weight5, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Weight5（字段） 查询
		/// </summary>
		/// /// <param name = "weight5">轴5权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_config_weightEO> GetByWeight5(int weight5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight5` = @Weight5", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight5", weight5, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		public async Task<List<Gsp_config_weightEO>> GetByWeight5Async(int weight5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight5` = @Weight5", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight5", weight5, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_config_weightEO.MapDataReader);
		}
		#endregion // GetByWeight5
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
