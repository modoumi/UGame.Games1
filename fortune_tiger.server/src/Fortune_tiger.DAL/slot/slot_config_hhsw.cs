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
	/// 【表 slot_config_hhsw 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Slot_config_hhswEO : IRowMapper<Slot_config_hhswEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Slot_config_hhswEO()
		{
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalHhswID;
		/// <summary>
		/// 【数据库中的原始主键 HhswID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalHhswID
		{
			get { return _originalHhswID; }
			set { HasOriginal = true; _originalHhswID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "HhswID", HhswID }, };
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
		public int HhswID { get; set; }
		/// <summary>
		/// 中了几条线
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int LineNum { get; set; }
		/// <summary>
		/// 线ID集合
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string LineNoArr { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 4)]
		public string IconGroup { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(4000)】
		/// </summary>
		[DataMember(Order = 5)]
		public string Memo { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Slot_config_hhswEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Slot_config_hhswEO MapDataReader(IDataReader reader)
		{
		    Slot_config_hhswEO ret = new Slot_config_hhswEO();
			ret.HhswID = reader.ToInt32("HhswID");
			ret.OriginalHhswID = ret.HhswID;
			ret.LineNum = reader.ToInt32("LineNum");
			ret.LineNoArr = reader.ToString("LineNoArr");
			ret.IconGroup = reader.ToString("IconGroup");
			ret.Memo = reader.ToString("Memo");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 倍率表
	/// 【表 slot_config_hhsw 的操作类】
	/// </summary>
	[Obsolete]
	public class Slot_config_hhswMO : MySqlTableMO<Slot_config_hhswEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`slot_config_hhsw`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Slot_config_hhswMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Slot_config_hhswMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Slot_config_hhswMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Slot_config_hhswEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			item.HhswID = Database.ExecSqlScalar<int>(sql_, paras_, tm_); 
			return 1;
		}
		public override async Task<int> AddAsync(Slot_config_hhswEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			item.HhswID = await Database.ExecSqlScalarAsync<int>(sql_, paras_, tm_); 
	        return 1;
		}
	    private void RepairAddData(Slot_config_hhswEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`LineNum`, `LineNoArr`, `IconGroup`, `Memo`) VALUE (@LineNum, @LineNoArr, @IconGroup, @Memo);SELECT LAST_INSERT_ID();";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LineNum", item.LineNum, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNoArr", item.LineNoArr, MySqlDbType.VarChar),
				Database.CreateInParameter("@IconGroup", item.IconGroup != null ? item.IconGroup : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Memo", item.Memo != null ? item.Memo : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Slot_config_hhswEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Slot_config_hhswEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Slot_config_hhswEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`HhswID`, `LineNum`, `LineNoArr`, `IconGroup`, `Memo`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.HhswID},{item.LineNum},'{item.LineNoArr}','{item.IconGroup}','{item.Memo}'),");
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
		/// /// <param name = "hhswID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int hhswID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(hhswID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int hhswID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(hhswID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int hhswID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HhswID` = @HhswID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HhswID", hhswID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Slot_config_hhswEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.HhswID, tm_);
		}
		public async Task<int> RemoveAsync(Slot_config_hhswEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.HhswID, tm_);
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
		#region RemoveByIconGroup
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "iconGroup"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIconGroup(string iconGroup, TransactionManager tm_ = null)
		{
			RepairRemoveByIconGroupData(iconGroup, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIconGroupAsync(string iconGroup, TransactionManager tm_ = null)
		{
			RepairRemoveByIconGroupData(iconGroup, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIconGroupData(string iconGroup, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (iconGroup != null ? "`IconGroup` = @IconGroup" : "`IconGroup` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (iconGroup != null)
				paras_.Add(Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar));
		}
		#endregion // RemoveByIconGroup
		#region RemoveByMemo
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "memo"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMemo(string memo, TransactionManager tm_ = null)
		{
			RepairRemoveByMemoData(memo, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMemoAsync(string memo, TransactionManager tm_ = null)
		{
			RepairRemoveByMemoData(memo, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMemoData(string memo, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (memo != null ? "`Memo` = @Memo" : "`Memo` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (memo != null)
				paras_.Add(Database.CreateInParameter("@Memo", memo, MySqlDbType.VarChar));
		}
		#endregion // RemoveByMemo
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
		public int Put(Slot_config_hhswEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Slot_config_hhswEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Slot_config_hhswEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LineNum` = @LineNum, `LineNoArr` = @LineNoArr, `IconGroup` = @IconGroup, `Memo` = @Memo WHERE `HhswID` = @HhswID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LineNum", item.LineNum, MySqlDbType.Int32),
				Database.CreateInParameter("@LineNoArr", item.LineNoArr, MySqlDbType.VarChar),
				Database.CreateInParameter("@IconGroup", item.IconGroup != null ? item.IconGroup : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Memo", item.Memo != null ? item.Memo : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@HhswID_Original", item.HasOriginal ? item.OriginalHhswID : item.HhswID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Slot_config_hhswEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Slot_config_hhswEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "hhswID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int hhswID, string set_, params object[] values_)
		{
			return Put(set_, "`HhswID` = @HhswID", ConcatValues(values_, hhswID));
		}
		public async Task<int> PutByPKAsync(int hhswID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`HhswID` = @HhswID", ConcatValues(values_, hhswID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "hhswID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int hhswID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`HhswID` = @HhswID", tm_, ConcatValues(values_, hhswID));
		}
		public async Task<int> PutByPKAsync(int hhswID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`HhswID` = @HhswID", tm_, ConcatValues(values_, hhswID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "hhswID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int hhswID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@HhswID", hhswID, MySqlDbType.Int32),
	        };
			return Put(set_, "`HhswID` = @HhswID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int hhswID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@HhswID", hhswID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`HhswID` = @HhswID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutLineNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "hhswID">主键</param>
		/// /// <param name = "lineNum">中了几条线</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLineNumByPK(int hhswID, int lineNum, TransactionManager tm_ = null)
		{
			RepairPutLineNumByPKData(hhswID, lineNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLineNumByPKAsync(int hhswID, int lineNum, TransactionManager tm_ = null)
		{
			RepairPutLineNumByPKData(hhswID, lineNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLineNumByPKData(int hhswID, int lineNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LineNum` = @LineNum  WHERE `HhswID` = @HhswID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32),
				Database.CreateInParameter("@HhswID", hhswID, MySqlDbType.Int32),
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
		/// /// <param name = "hhswID">主键</param>
		/// /// <param name = "lineNoArr">线ID集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLineNoArrByPK(int hhswID, string lineNoArr, TransactionManager tm_ = null)
		{
			RepairPutLineNoArrByPKData(hhswID, lineNoArr, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLineNoArrByPKAsync(int hhswID, string lineNoArr, TransactionManager tm_ = null)
		{
			RepairPutLineNoArrByPKData(hhswID, lineNoArr, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLineNoArrByPKData(int hhswID, string lineNoArr, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LineNoArr` = @LineNoArr  WHERE `HhswID` = @HhswID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LineNoArr", lineNoArr, MySqlDbType.VarChar),
				Database.CreateInParameter("@HhswID", hhswID, MySqlDbType.Int32),
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
		#region PutIconGroup
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "hhswID">主键</param>
		/// /// <param name = "iconGroup"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIconGroupByPK(int hhswID, string iconGroup, TransactionManager tm_ = null)
		{
			RepairPutIconGroupByPKData(hhswID, iconGroup, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIconGroupByPKAsync(int hhswID, string iconGroup, TransactionManager tm_ = null)
		{
			RepairPutIconGroupByPKData(hhswID, iconGroup, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIconGroupByPKData(int hhswID, string iconGroup, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IconGroup` = @IconGroup  WHERE `HhswID` = @HhswID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IconGroup", iconGroup != null ? iconGroup : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@HhswID", hhswID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "iconGroup"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIconGroup(string iconGroup, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IconGroup` = @IconGroup";
			var parameter_ = Database.CreateInParameter("@IconGroup", iconGroup != null ? iconGroup : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIconGroupAsync(string iconGroup, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IconGroup` = @IconGroup";
			var parameter_ = Database.CreateInParameter("@IconGroup", iconGroup != null ? iconGroup : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIconGroup
		#region PutMemo
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "hhswID">主键</param>
		/// /// <param name = "memo"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMemoByPK(int hhswID, string memo, TransactionManager tm_ = null)
		{
			RepairPutMemoByPKData(hhswID, memo, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMemoByPKAsync(int hhswID, string memo, TransactionManager tm_ = null)
		{
			RepairPutMemoByPKData(hhswID, memo, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMemoByPKData(int hhswID, string memo, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Memo` = @Memo  WHERE `HhswID` = @HhswID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Memo", memo != null ? memo : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@HhswID", hhswID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "memo"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMemo(string memo, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Memo` = @Memo";
			var parameter_ = Database.CreateInParameter("@Memo", memo != null ? memo : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMemoAsync(string memo, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Memo` = @Memo";
			var parameter_ = Database.CreateInParameter("@Memo", memo != null ? memo : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMemo
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Slot_config_hhswEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.HhswID) == null)
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
		public async Task<bool> SetAsync(Slot_config_hhswEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.HhswID) == null)
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
		/// /// <param name = "hhswID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Slot_config_hhswEO GetByPK(int hhswID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(hhswID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Slot_config_hhswEO.MapDataReader);
		}
		public async Task<Slot_config_hhswEO> GetByPKAsync(int hhswID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(hhswID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Slot_config_hhswEO.MapDataReader);
		}
		private void RepairGetByPKData(int hhswID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`HhswID` = @HhswID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HhswID", hhswID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 LineNum（字段）
		/// </summary>
		/// /// <param name = "hhswID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLineNumByPK(int hhswID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HhswID", hhswID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`LineNum`", "`HhswID` = @HhswID", paras_, tm_);
		}
		public async Task<int> GetLineNumByPKAsync(int hhswID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HhswID", hhswID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`LineNum`", "`HhswID` = @HhswID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LineNoArr（字段）
		/// </summary>
		/// /// <param name = "hhswID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLineNoArrByPK(int hhswID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HhswID", hhswID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`LineNoArr`", "`HhswID` = @HhswID", paras_, tm_);
		}
		public async Task<string> GetLineNoArrByPKAsync(int hhswID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HhswID", hhswID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`LineNoArr`", "`HhswID` = @HhswID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IconGroup（字段）
		/// </summary>
		/// /// <param name = "hhswID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetIconGroupByPK(int hhswID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HhswID", hhswID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`IconGroup`", "`HhswID` = @HhswID", paras_, tm_);
		}
		public async Task<string> GetIconGroupByPKAsync(int hhswID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HhswID", hhswID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`IconGroup`", "`HhswID` = @HhswID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Memo（字段）
		/// </summary>
		/// /// <param name = "hhswID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMemoByPK(int hhswID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HhswID", hhswID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`Memo`", "`HhswID` = @HhswID", paras_, tm_);
		}
		public async Task<string> GetMemoByPKAsync(int hhswID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HhswID", hhswID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`Memo`", "`HhswID` = @HhswID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByLineNum
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">中了几条线</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByLineNum(int lineNum)
		{
			return GetByLineNum(lineNum, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_hhswEO>> GetByLineNumAsync(int lineNum)
		{
			return await GetByLineNumAsync(lineNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">中了几条线</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByLineNum(int lineNum, TransactionManager tm_)
		{
			return GetByLineNum(lineNum, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_hhswEO>> GetByLineNumAsync(int lineNum, TransactionManager tm_)
		{
			return await GetByLineNumAsync(lineNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">中了几条线</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByLineNum(int lineNum, int top_)
		{
			return GetByLineNum(lineNum, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_hhswEO>> GetByLineNumAsync(int lineNum, int top_)
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
		public List<Slot_config_hhswEO> GetByLineNum(int lineNum, int top_, TransactionManager tm_)
		{
			return GetByLineNum(lineNum, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_hhswEO>> GetByLineNumAsync(int lineNum, int top_, TransactionManager tm_)
		{
			return await GetByLineNumAsync(lineNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LineNum（字段） 查询
		/// </summary>
		/// /// <param name = "lineNum">中了几条线</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByLineNum(int lineNum, string sort_)
		{
			return GetByLineNum(lineNum, 0, sort_, null);
		}
		public async Task<List<Slot_config_hhswEO>> GetByLineNumAsync(int lineNum, string sort_)
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
		public List<Slot_config_hhswEO> GetByLineNum(int lineNum, string sort_, TransactionManager tm_)
		{
			return GetByLineNum(lineNum, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_hhswEO>> GetByLineNumAsync(int lineNum, string sort_, TransactionManager tm_)
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
		public List<Slot_config_hhswEO> GetByLineNum(int lineNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LineNum` = @LineNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_hhswEO.MapDataReader);
		}
		public async Task<List<Slot_config_hhswEO>> GetByLineNumAsync(int lineNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LineNum` = @LineNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNum", lineNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_hhswEO.MapDataReader);
		}
		#endregion // GetByLineNum
		#region GetByLineNoArr
		
		/// <summary>
		/// 按 LineNoArr（字段） 查询
		/// </summary>
		/// /// <param name = "lineNoArr">线ID集合</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByLineNoArr(string lineNoArr)
		{
			return GetByLineNoArr(lineNoArr, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_hhswEO>> GetByLineNoArrAsync(string lineNoArr)
		{
			return await GetByLineNoArrAsync(lineNoArr, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LineNoArr（字段） 查询
		/// </summary>
		/// /// <param name = "lineNoArr">线ID集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByLineNoArr(string lineNoArr, TransactionManager tm_)
		{
			return GetByLineNoArr(lineNoArr, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_hhswEO>> GetByLineNoArrAsync(string lineNoArr, TransactionManager tm_)
		{
			return await GetByLineNoArrAsync(lineNoArr, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LineNoArr（字段） 查询
		/// </summary>
		/// /// <param name = "lineNoArr">线ID集合</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByLineNoArr(string lineNoArr, int top_)
		{
			return GetByLineNoArr(lineNoArr, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_hhswEO>> GetByLineNoArrAsync(string lineNoArr, int top_)
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
		public List<Slot_config_hhswEO> GetByLineNoArr(string lineNoArr, int top_, TransactionManager tm_)
		{
			return GetByLineNoArr(lineNoArr, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_hhswEO>> GetByLineNoArrAsync(string lineNoArr, int top_, TransactionManager tm_)
		{
			return await GetByLineNoArrAsync(lineNoArr, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LineNoArr（字段） 查询
		/// </summary>
		/// /// <param name = "lineNoArr">线ID集合</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByLineNoArr(string lineNoArr, string sort_)
		{
			return GetByLineNoArr(lineNoArr, 0, sort_, null);
		}
		public async Task<List<Slot_config_hhswEO>> GetByLineNoArrAsync(string lineNoArr, string sort_)
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
		public List<Slot_config_hhswEO> GetByLineNoArr(string lineNoArr, string sort_, TransactionManager tm_)
		{
			return GetByLineNoArr(lineNoArr, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_hhswEO>> GetByLineNoArrAsync(string lineNoArr, string sort_, TransactionManager tm_)
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
		public List<Slot_config_hhswEO> GetByLineNoArr(string lineNoArr, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LineNoArr` = @LineNoArr", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNoArr", lineNoArr, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_hhswEO.MapDataReader);
		}
		public async Task<List<Slot_config_hhswEO>> GetByLineNoArrAsync(string lineNoArr, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LineNoArr` = @LineNoArr", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LineNoArr", lineNoArr, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_hhswEO.MapDataReader);
		}
		#endregion // GetByLineNoArr
		#region GetByIconGroup
		
		/// <summary>
		/// 按 IconGroup（字段） 查询
		/// </summary>
		/// /// <param name = "iconGroup"></param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByIconGroup(string iconGroup)
		{
			return GetByIconGroup(iconGroup, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_hhswEO>> GetByIconGroupAsync(string iconGroup)
		{
			return await GetByIconGroupAsync(iconGroup, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IconGroup（字段） 查询
		/// </summary>
		/// /// <param name = "iconGroup"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByIconGroup(string iconGroup, TransactionManager tm_)
		{
			return GetByIconGroup(iconGroup, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_hhswEO>> GetByIconGroupAsync(string iconGroup, TransactionManager tm_)
		{
			return await GetByIconGroupAsync(iconGroup, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IconGroup（字段） 查询
		/// </summary>
		/// /// <param name = "iconGroup"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByIconGroup(string iconGroup, int top_)
		{
			return GetByIconGroup(iconGroup, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_hhswEO>> GetByIconGroupAsync(string iconGroup, int top_)
		{
			return await GetByIconGroupAsync(iconGroup, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IconGroup（字段） 查询
		/// </summary>
		/// /// <param name = "iconGroup"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByIconGroup(string iconGroup, int top_, TransactionManager tm_)
		{
			return GetByIconGroup(iconGroup, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_hhswEO>> GetByIconGroupAsync(string iconGroup, int top_, TransactionManager tm_)
		{
			return await GetByIconGroupAsync(iconGroup, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IconGroup（字段） 查询
		/// </summary>
		/// /// <param name = "iconGroup"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByIconGroup(string iconGroup, string sort_)
		{
			return GetByIconGroup(iconGroup, 0, sort_, null);
		}
		public async Task<List<Slot_config_hhswEO>> GetByIconGroupAsync(string iconGroup, string sort_)
		{
			return await GetByIconGroupAsync(iconGroup, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IconGroup（字段） 查询
		/// </summary>
		/// /// <param name = "iconGroup"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByIconGroup(string iconGroup, string sort_, TransactionManager tm_)
		{
			return GetByIconGroup(iconGroup, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_hhswEO>> GetByIconGroupAsync(string iconGroup, string sort_, TransactionManager tm_)
		{
			return await GetByIconGroupAsync(iconGroup, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IconGroup（字段） 查询
		/// </summary>
		/// /// <param name = "iconGroup"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByIconGroup(string iconGroup, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(iconGroup != null ? "`IconGroup` = @IconGroup" : "`IconGroup` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (iconGroup != null)
				paras_.Add(Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_hhswEO.MapDataReader);
		}
		public async Task<List<Slot_config_hhswEO>> GetByIconGroupAsync(string iconGroup, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(iconGroup != null ? "`IconGroup` = @IconGroup" : "`IconGroup` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (iconGroup != null)
				paras_.Add(Database.CreateInParameter("@IconGroup", iconGroup, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_hhswEO.MapDataReader);
		}
		#endregion // GetByIconGroup
		#region GetByMemo
		
		/// <summary>
		/// 按 Memo（字段） 查询
		/// </summary>
		/// /// <param name = "memo"></param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByMemo(string memo)
		{
			return GetByMemo(memo, 0, string.Empty, null);
		}
		public async Task<List<Slot_config_hhswEO>> GetByMemoAsync(string memo)
		{
			return await GetByMemoAsync(memo, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Memo（字段） 查询
		/// </summary>
		/// /// <param name = "memo"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByMemo(string memo, TransactionManager tm_)
		{
			return GetByMemo(memo, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_config_hhswEO>> GetByMemoAsync(string memo, TransactionManager tm_)
		{
			return await GetByMemoAsync(memo, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Memo（字段） 查询
		/// </summary>
		/// /// <param name = "memo"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByMemo(string memo, int top_)
		{
			return GetByMemo(memo, top_, string.Empty, null);
		}
		public async Task<List<Slot_config_hhswEO>> GetByMemoAsync(string memo, int top_)
		{
			return await GetByMemoAsync(memo, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Memo（字段） 查询
		/// </summary>
		/// /// <param name = "memo"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByMemo(string memo, int top_, TransactionManager tm_)
		{
			return GetByMemo(memo, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_config_hhswEO>> GetByMemoAsync(string memo, int top_, TransactionManager tm_)
		{
			return await GetByMemoAsync(memo, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Memo（字段） 查询
		/// </summary>
		/// /// <param name = "memo"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByMemo(string memo, string sort_)
		{
			return GetByMemo(memo, 0, sort_, null);
		}
		public async Task<List<Slot_config_hhswEO>> GetByMemoAsync(string memo, string sort_)
		{
			return await GetByMemoAsync(memo, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Memo（字段） 查询
		/// </summary>
		/// /// <param name = "memo"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByMemo(string memo, string sort_, TransactionManager tm_)
		{
			return GetByMemo(memo, 0, sort_, tm_);
		}
		public async Task<List<Slot_config_hhswEO>> GetByMemoAsync(string memo, string sort_, TransactionManager tm_)
		{
			return await GetByMemoAsync(memo, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Memo（字段） 查询
		/// </summary>
		/// /// <param name = "memo"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_config_hhswEO> GetByMemo(string memo, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(memo != null ? "`Memo` = @Memo" : "`Memo` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (memo != null)
				paras_.Add(Database.CreateInParameter("@Memo", memo, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_config_hhswEO.MapDataReader);
		}
		public async Task<List<Slot_config_hhswEO>> GetByMemoAsync(string memo, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(memo != null ? "`Memo` = @Memo" : "`Memo` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (memo != null)
				paras_.Add(Database.CreateInParameter("@Memo", memo, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_config_hhswEO.MapDataReader);
		}
		#endregion // GetByMemo
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
