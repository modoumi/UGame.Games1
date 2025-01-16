/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-11 17: 14:07
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
	/// 初始基础配置
	/// 【表 fra_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Fra_configEO : IRowMapper<Fra_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Fra_configEO()
		{
			this.IncomeRatio = 0d;
			this.SpecialModeRatio = 0d;
			this.SpecialModeTurnNum = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalOperatorID;
		/// <summary>
		/// 【数据库中的原始主键 OperatorID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalOperatorID
		{
			get { return _originalOperatorID; }
			set { HasOriginal = true; _originalOperatorID = value; }
		}
		
		private string _originalCurrencyID;
		/// <summary>
		/// 【数据库中的原始主键 CurrencyID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalCurrencyID
		{
			get { return _originalCurrencyID; }
			set { HasOriginal = true; _originalCurrencyID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "OperatorID", OperatorID },  { "CurrencyID", CurrencyID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 运营商编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 货币编码（ISO 4217大写）
		/// 【主键 varchar(5)】
		/// </summary>
		[DataMember(Order = 2)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 税收分配
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 3)]
		public double IncomeRatio { get; set; }
		/// <summary>
		/// 特殊玩法进入概率
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 4)]
		public double SpecialModeRatio { get; set; }
		/// <summary>
		/// 特殊模式下的配置[y1,y2,y3]
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 5)]
		public string SpecialModeArray { get; set; }
		/// <summary>
		/// 特殊玩法转动次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int SpecialModeTurnNum { get; set; }
		/// <summary>
		/// 初始牌面
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 7)]
		public string DefaultSlotArray { get; set; }
		/// <summary>
		/// 倍率集合
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 8)]
		public string MultipArray { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Fra_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Fra_configEO MapDataReader(IDataReader reader)
		{
		    Fra_configEO ret = new Fra_configEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.OriginalCurrencyID = ret.CurrencyID;
			ret.IncomeRatio = reader.ToDouble("IncomeRatio");
			ret.SpecialModeRatio = reader.ToDouble("SpecialModeRatio");
			ret.SpecialModeArray = reader.ToString("SpecialModeArray");
			ret.SpecialModeTurnNum = reader.ToInt32("SpecialModeTurnNum");
			ret.DefaultSlotArray = reader.ToString("DefaultSlotArray");
			ret.MultipArray = reader.ToString("MultipArray");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 初始基础配置
	/// 【表 fra_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Fra_configMO : MySqlTableMO<Fra_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`fra_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Fra_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Fra_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Fra_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Fra_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Fra_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Fra_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `CurrencyID`, `IncomeRatio`, `SpecialModeRatio`, `SpecialModeArray`, `SpecialModeTurnNum`, `DefaultSlotArray`, `MultipArray`) VALUE (@OperatorID, @CurrencyID, @IncomeRatio, @SpecialModeRatio, @SpecialModeArray, @SpecialModeTurnNum, @DefaultSlotArray, @MultipArray);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IncomeRatio", item.IncomeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@SpecialModeRatio", item.SpecialModeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@SpecialModeArray", item.SpecialModeArray, MySqlDbType.VarChar),
				Database.CreateInParameter("@SpecialModeTurnNum", item.SpecialModeTurnNum, MySqlDbType.Int32),
				Database.CreateInParameter("@DefaultSlotArray", item.DefaultSlotArray, MySqlDbType.VarChar),
				Database.CreateInParameter("@MultipArray", item.MultipArray, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Fra_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Fra_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Fra_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorID`, `CurrencyID`, `IncomeRatio`, `SpecialModeRatio`, `SpecialModeArray`, `SpecialModeTurnNum`, `DefaultSlotArray`, `MultipArray`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorID}','{item.CurrencyID}',{item.IncomeRatio},{item.SpecialModeRatio},'{item.SpecialModeArray}',{item.SpecialModeTurnNum},'{item.DefaultSlotArray}','{item.MultipArray}'),");
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string operatorID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Fra_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorID, item.CurrencyID, tm_);
		}
		public async Task<int> RemoveAsync(Fra_configEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.OperatorID, item.CurrencyID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByOperatorID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorIDData(string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorID
		#region RemoveByCurrencyID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCurrencyIDData(string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCurrencyID
		#region RemoveByIncomeRatio
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIncomeRatio(double incomeRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByIncomeRatioData(incomeRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIncomeRatioAsync(double incomeRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByIncomeRatioData(incomeRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIncomeRatioData(double incomeRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IncomeRatio` = @IncomeRatio";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double));
		}
		#endregion // RemoveByIncomeRatio
		#region RemoveBySpecialModeRatio
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySpecialModeRatio(double specialModeRatio, TransactionManager tm_ = null)
		{
			RepairRemoveBySpecialModeRatioData(specialModeRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySpecialModeRatioAsync(double specialModeRatio, TransactionManager tm_ = null)
		{
			RepairRemoveBySpecialModeRatioData(specialModeRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySpecialModeRatioData(double specialModeRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SpecialModeRatio` = @SpecialModeRatio";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SpecialModeRatio", specialModeRatio, MySqlDbType.Double));
		}
		#endregion // RemoveBySpecialModeRatio
		#region RemoveBySpecialModeArray
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "specialModeArray">特殊模式下的配置[y1,y2,y3]</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySpecialModeArray(string specialModeArray, TransactionManager tm_ = null)
		{
			RepairRemoveBySpecialModeArrayData(specialModeArray, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySpecialModeArrayAsync(string specialModeArray, TransactionManager tm_ = null)
		{
			RepairRemoveBySpecialModeArrayData(specialModeArray, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySpecialModeArrayData(string specialModeArray, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SpecialModeArray` = @SpecialModeArray";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SpecialModeArray", specialModeArray, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySpecialModeArray
		#region RemoveBySpecialModeTurnNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "specialModeTurnNum">特殊玩法转动次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySpecialModeTurnNum(int specialModeTurnNum, TransactionManager tm_ = null)
		{
			RepairRemoveBySpecialModeTurnNumData(specialModeTurnNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySpecialModeTurnNumAsync(int specialModeTurnNum, TransactionManager tm_ = null)
		{
			RepairRemoveBySpecialModeTurnNumData(specialModeTurnNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySpecialModeTurnNumData(int specialModeTurnNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SpecialModeTurnNum` = @SpecialModeTurnNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SpecialModeTurnNum", specialModeTurnNum, MySqlDbType.Int32));
		}
		#endregion // RemoveBySpecialModeTurnNum
		#region RemoveByDefaultSlotArray
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "defaultSlotArray">初始牌面</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDefaultSlotArray(string defaultSlotArray, TransactionManager tm_ = null)
		{
			RepairRemoveByDefaultSlotArrayData(defaultSlotArray, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDefaultSlotArrayAsync(string defaultSlotArray, TransactionManager tm_ = null)
		{
			RepairRemoveByDefaultSlotArrayData(defaultSlotArray, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDefaultSlotArrayData(string defaultSlotArray, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DefaultSlotArray` = @DefaultSlotArray";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DefaultSlotArray", defaultSlotArray, MySqlDbType.VarChar));
		}
		#endregion // RemoveByDefaultSlotArray
		#region RemoveByMultipArray
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "multipArray">倍率集合</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMultipArray(string multipArray, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipArrayData(multipArray, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMultipArrayAsync(string multipArray, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipArrayData(multipArray, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMultipArrayData(string multipArray, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MultipArray` = @MultipArray";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MultipArray", multipArray, MySqlDbType.VarChar));
		}
		#endregion // RemoveByMultipArray
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
		public int Put(Fra_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Fra_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Fra_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `IncomeRatio` = @IncomeRatio, `SpecialModeRatio` = @SpecialModeRatio, `SpecialModeArray` = @SpecialModeArray, `SpecialModeTurnNum` = @SpecialModeTurnNum, `DefaultSlotArray` = @DefaultSlotArray, `MultipArray` = @MultipArray WHERE `OperatorID` = @OperatorID_Original AND `CurrencyID` = @CurrencyID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IncomeRatio", item.IncomeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@SpecialModeRatio", item.SpecialModeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@SpecialModeArray", item.SpecialModeArray, MySqlDbType.VarChar),
				Database.CreateInParameter("@SpecialModeTurnNum", item.SpecialModeTurnNum, MySqlDbType.Int32),
				Database.CreateInParameter("@DefaultSlotArray", item.DefaultSlotArray, MySqlDbType.VarChar),
				Database.CreateInParameter("@MultipArray", item.MultipArray, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID_Original", item.HasOriginal ? item.OriginalCurrencyID : item.CurrencyID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Fra_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Fra_configEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string currencyID, string set_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatValues(values_, operatorID, currencyID));
		}
		public async Task<int> PutByPKAsync(string operatorID, string currencyID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatValues(values_, operatorID, currencyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string currencyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, operatorID, currencyID));
		}
		public async Task<int> PutByPKAsync(string operatorID, string currencyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, operatorID, currencyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string operatorID, string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorID
		#region PutCurrencyID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrencyID
		#region PutIncomeRatio
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIncomeRatioByPK(string operatorID, string currencyID, double incomeRatio, TransactionManager tm_ = null)
		{
			RepairPutIncomeRatioByPKData(operatorID, currencyID, incomeRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIncomeRatioByPKAsync(string operatorID, string currencyID, double incomeRatio, TransactionManager tm_ = null)
		{
			RepairPutIncomeRatioByPKData(operatorID, currencyID, incomeRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIncomeRatioByPKData(string operatorID, string currencyID, double incomeRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IncomeRatio` = @IncomeRatio  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIncomeRatio(double incomeRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IncomeRatio` = @IncomeRatio";
			var parameter_ = Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIncomeRatioAsync(double incomeRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IncomeRatio` = @IncomeRatio";
			var parameter_ = Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIncomeRatio
		#region PutSpecialModeRatio
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSpecialModeRatioByPK(string operatorID, string currencyID, double specialModeRatio, TransactionManager tm_ = null)
		{
			RepairPutSpecialModeRatioByPKData(operatorID, currencyID, specialModeRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSpecialModeRatioByPKAsync(string operatorID, string currencyID, double specialModeRatio, TransactionManager tm_ = null)
		{
			RepairPutSpecialModeRatioByPKData(operatorID, currencyID, specialModeRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSpecialModeRatioByPKData(string operatorID, string currencyID, double specialModeRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SpecialModeRatio` = @SpecialModeRatio  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SpecialModeRatio", specialModeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSpecialModeRatio(double specialModeRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SpecialModeRatio` = @SpecialModeRatio";
			var parameter_ = Database.CreateInParameter("@SpecialModeRatio", specialModeRatio, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSpecialModeRatioAsync(double specialModeRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SpecialModeRatio` = @SpecialModeRatio";
			var parameter_ = Database.CreateInParameter("@SpecialModeRatio", specialModeRatio, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSpecialModeRatio
		#region PutSpecialModeArray
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "specialModeArray">特殊模式下的配置[y1,y2,y3]</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSpecialModeArrayByPK(string operatorID, string currencyID, string specialModeArray, TransactionManager tm_ = null)
		{
			RepairPutSpecialModeArrayByPKData(operatorID, currencyID, specialModeArray, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSpecialModeArrayByPKAsync(string operatorID, string currencyID, string specialModeArray, TransactionManager tm_ = null)
		{
			RepairPutSpecialModeArrayByPKData(operatorID, currencyID, specialModeArray, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSpecialModeArrayByPKData(string operatorID, string currencyID, string specialModeArray, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SpecialModeArray` = @SpecialModeArray  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SpecialModeArray", specialModeArray, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "specialModeArray">特殊模式下的配置[y1,y2,y3]</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSpecialModeArray(string specialModeArray, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SpecialModeArray` = @SpecialModeArray";
			var parameter_ = Database.CreateInParameter("@SpecialModeArray", specialModeArray, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSpecialModeArrayAsync(string specialModeArray, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SpecialModeArray` = @SpecialModeArray";
			var parameter_ = Database.CreateInParameter("@SpecialModeArray", specialModeArray, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSpecialModeArray
		#region PutSpecialModeTurnNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "specialModeTurnNum">特殊玩法转动次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSpecialModeTurnNumByPK(string operatorID, string currencyID, int specialModeTurnNum, TransactionManager tm_ = null)
		{
			RepairPutSpecialModeTurnNumByPKData(operatorID, currencyID, specialModeTurnNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSpecialModeTurnNumByPKAsync(string operatorID, string currencyID, int specialModeTurnNum, TransactionManager tm_ = null)
		{
			RepairPutSpecialModeTurnNumByPKData(operatorID, currencyID, specialModeTurnNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSpecialModeTurnNumByPKData(string operatorID, string currencyID, int specialModeTurnNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SpecialModeTurnNum` = @SpecialModeTurnNum  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SpecialModeTurnNum", specialModeTurnNum, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "specialModeTurnNum">特殊玩法转动次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSpecialModeTurnNum(int specialModeTurnNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SpecialModeTurnNum` = @SpecialModeTurnNum";
			var parameter_ = Database.CreateInParameter("@SpecialModeTurnNum", specialModeTurnNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSpecialModeTurnNumAsync(int specialModeTurnNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SpecialModeTurnNum` = @SpecialModeTurnNum";
			var parameter_ = Database.CreateInParameter("@SpecialModeTurnNum", specialModeTurnNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSpecialModeTurnNum
		#region PutDefaultSlotArray
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "defaultSlotArray">初始牌面</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDefaultSlotArrayByPK(string operatorID, string currencyID, string defaultSlotArray, TransactionManager tm_ = null)
		{
			RepairPutDefaultSlotArrayByPKData(operatorID, currencyID, defaultSlotArray, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDefaultSlotArrayByPKAsync(string operatorID, string currencyID, string defaultSlotArray, TransactionManager tm_ = null)
		{
			RepairPutDefaultSlotArrayByPKData(operatorID, currencyID, defaultSlotArray, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDefaultSlotArrayByPKData(string operatorID, string currencyID, string defaultSlotArray, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DefaultSlotArray` = @DefaultSlotArray  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DefaultSlotArray", defaultSlotArray, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "defaultSlotArray">初始牌面</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDefaultSlotArray(string defaultSlotArray, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DefaultSlotArray` = @DefaultSlotArray";
			var parameter_ = Database.CreateInParameter("@DefaultSlotArray", defaultSlotArray, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDefaultSlotArrayAsync(string defaultSlotArray, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DefaultSlotArray` = @DefaultSlotArray";
			var parameter_ = Database.CreateInParameter("@DefaultSlotArray", defaultSlotArray, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDefaultSlotArray
		#region PutMultipArray
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "multipArray">倍率集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultipArrayByPK(string operatorID, string currencyID, string multipArray, TransactionManager tm_ = null)
		{
			RepairPutMultipArrayByPKData(operatorID, currencyID, multipArray, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMultipArrayByPKAsync(string operatorID, string currencyID, string multipArray, TransactionManager tm_ = null)
		{
			RepairPutMultipArrayByPKData(operatorID, currencyID, multipArray, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMultipArrayByPKData(string operatorID, string currencyID, string multipArray, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MultipArray` = @MultipArray  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MultipArray", multipArray, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "multipArray">倍率集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultipArray(string multipArray, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MultipArray` = @MultipArray";
			var parameter_ = Database.CreateInParameter("@MultipArray", multipArray, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMultipArrayAsync(string multipArray, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MultipArray` = @MultipArray";
			var parameter_ = Database.CreateInParameter("@MultipArray", multipArray, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMultipArray
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Fra_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID, item.CurrencyID) == null)
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
		public async Task<bool> SetAsync(Fra_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID, item.CurrencyID) == null)
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Fra_configEO GetByPK(string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		public async Task<Fra_configEO> GetByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		private void RepairGetByPKData(string operatorID, string currencyID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IncomeRatio（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetIncomeRatioByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)GetScalar("`IncomeRatio`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<double> GetIncomeRatioByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)await GetScalarAsync("`IncomeRatio`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SpecialModeRatio（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetSpecialModeRatioByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)GetScalar("`SpecialModeRatio`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<double> GetSpecialModeRatioByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)await GetScalarAsync("`SpecialModeRatio`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SpecialModeArray（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSpecialModeArrayByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SpecialModeArray`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetSpecialModeArrayByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SpecialModeArray`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SpecialModeTurnNum（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSpecialModeTurnNumByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`SpecialModeTurnNum`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetSpecialModeTurnNumByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`SpecialModeTurnNum`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DefaultSlotArray（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetDefaultSlotArrayByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`DefaultSlotArray`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetDefaultSlotArrayByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`DefaultSlotArray`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MultipArray（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMultipArrayByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`MultipArray`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetMultipArrayByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`MultipArray`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Fra_configEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_configEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Fra_configEO>> GetByOperatorIDAsync(string operatorID, int top_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_configEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Fra_configEO>> GetByOperatorIDAsync(string operatorID, string sort_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Fra_configEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		public async Task<List<Fra_configEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Fra_configEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_configEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Fra_configEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Fra_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Fra_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		public async Task<List<Fra_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByIncomeRatio
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByIncomeRatio(double incomeRatio)
		{
			return GetByIncomeRatio(incomeRatio, 0, string.Empty, null);
		}
		public async Task<List<Fra_configEO>> GetByIncomeRatioAsync(double incomeRatio)
		{
			return await GetByIncomeRatioAsync(incomeRatio, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByIncomeRatio(double incomeRatio, TransactionManager tm_)
		{
			return GetByIncomeRatio(incomeRatio, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_configEO>> GetByIncomeRatioAsync(double incomeRatio, TransactionManager tm_)
		{
			return await GetByIncomeRatioAsync(incomeRatio, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByIncomeRatio(double incomeRatio, int top_)
		{
			return GetByIncomeRatio(incomeRatio, top_, string.Empty, null);
		}
		public async Task<List<Fra_configEO>> GetByIncomeRatioAsync(double incomeRatio, int top_)
		{
			return await GetByIncomeRatioAsync(incomeRatio, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByIncomeRatio(double incomeRatio, int top_, TransactionManager tm_)
		{
			return GetByIncomeRatio(incomeRatio, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_configEO>> GetByIncomeRatioAsync(double incomeRatio, int top_, TransactionManager tm_)
		{
			return await GetByIncomeRatioAsync(incomeRatio, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByIncomeRatio(double incomeRatio, string sort_)
		{
			return GetByIncomeRatio(incomeRatio, 0, sort_, null);
		}
		public async Task<List<Fra_configEO>> GetByIncomeRatioAsync(double incomeRatio, string sort_)
		{
			return await GetByIncomeRatioAsync(incomeRatio, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByIncomeRatio(double incomeRatio, string sort_, TransactionManager tm_)
		{
			return GetByIncomeRatio(incomeRatio, 0, sort_, tm_);
		}
		public async Task<List<Fra_configEO>> GetByIncomeRatioAsync(double incomeRatio, string sort_, TransactionManager tm_)
		{
			return await GetByIncomeRatioAsync(incomeRatio, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByIncomeRatio(double incomeRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IncomeRatio` = @IncomeRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		public async Task<List<Fra_configEO>> GetByIncomeRatioAsync(double incomeRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IncomeRatio` = @IncomeRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		#endregion // GetByIncomeRatio
		#region GetBySpecialModeRatio
		
		/// <summary>
		/// 按 SpecialModeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeRatio(double specialModeRatio)
		{
			return GetBySpecialModeRatio(specialModeRatio, 0, string.Empty, null);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeRatioAsync(double specialModeRatio)
		{
			return await GetBySpecialModeRatioAsync(specialModeRatio, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SpecialModeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeRatio(double specialModeRatio, TransactionManager tm_)
		{
			return GetBySpecialModeRatio(specialModeRatio, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeRatioAsync(double specialModeRatio, TransactionManager tm_)
		{
			return await GetBySpecialModeRatioAsync(specialModeRatio, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SpecialModeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeRatio(double specialModeRatio, int top_)
		{
			return GetBySpecialModeRatio(specialModeRatio, top_, string.Empty, null);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeRatioAsync(double specialModeRatio, int top_)
		{
			return await GetBySpecialModeRatioAsync(specialModeRatio, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SpecialModeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeRatio(double specialModeRatio, int top_, TransactionManager tm_)
		{
			return GetBySpecialModeRatio(specialModeRatio, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeRatioAsync(double specialModeRatio, int top_, TransactionManager tm_)
		{
			return await GetBySpecialModeRatioAsync(specialModeRatio, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SpecialModeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeRatio(double specialModeRatio, string sort_)
		{
			return GetBySpecialModeRatio(specialModeRatio, 0, sort_, null);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeRatioAsync(double specialModeRatio, string sort_)
		{
			return await GetBySpecialModeRatioAsync(specialModeRatio, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SpecialModeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeRatio(double specialModeRatio, string sort_, TransactionManager tm_)
		{
			return GetBySpecialModeRatio(specialModeRatio, 0, sort_, tm_);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeRatioAsync(double specialModeRatio, string sort_, TransactionManager tm_)
		{
			return await GetBySpecialModeRatioAsync(specialModeRatio, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SpecialModeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeRatio">特殊玩法进入概率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeRatio(double specialModeRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SpecialModeRatio` = @SpecialModeRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SpecialModeRatio", specialModeRatio, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeRatioAsync(double specialModeRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SpecialModeRatio` = @SpecialModeRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SpecialModeRatio", specialModeRatio, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		#endregion // GetBySpecialModeRatio
		#region GetBySpecialModeArray
		
		/// <summary>
		/// 按 SpecialModeArray（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeArray">特殊模式下的配置[y1,y2,y3]</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeArray(string specialModeArray)
		{
			return GetBySpecialModeArray(specialModeArray, 0, string.Empty, null);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeArrayAsync(string specialModeArray)
		{
			return await GetBySpecialModeArrayAsync(specialModeArray, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SpecialModeArray（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeArray">特殊模式下的配置[y1,y2,y3]</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeArray(string specialModeArray, TransactionManager tm_)
		{
			return GetBySpecialModeArray(specialModeArray, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeArrayAsync(string specialModeArray, TransactionManager tm_)
		{
			return await GetBySpecialModeArrayAsync(specialModeArray, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SpecialModeArray（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeArray">特殊模式下的配置[y1,y2,y3]</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeArray(string specialModeArray, int top_)
		{
			return GetBySpecialModeArray(specialModeArray, top_, string.Empty, null);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeArrayAsync(string specialModeArray, int top_)
		{
			return await GetBySpecialModeArrayAsync(specialModeArray, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SpecialModeArray（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeArray">特殊模式下的配置[y1,y2,y3]</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeArray(string specialModeArray, int top_, TransactionManager tm_)
		{
			return GetBySpecialModeArray(specialModeArray, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeArrayAsync(string specialModeArray, int top_, TransactionManager tm_)
		{
			return await GetBySpecialModeArrayAsync(specialModeArray, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SpecialModeArray（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeArray">特殊模式下的配置[y1,y2,y3]</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeArray(string specialModeArray, string sort_)
		{
			return GetBySpecialModeArray(specialModeArray, 0, sort_, null);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeArrayAsync(string specialModeArray, string sort_)
		{
			return await GetBySpecialModeArrayAsync(specialModeArray, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SpecialModeArray（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeArray">特殊模式下的配置[y1,y2,y3]</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeArray(string specialModeArray, string sort_, TransactionManager tm_)
		{
			return GetBySpecialModeArray(specialModeArray, 0, sort_, tm_);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeArrayAsync(string specialModeArray, string sort_, TransactionManager tm_)
		{
			return await GetBySpecialModeArrayAsync(specialModeArray, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SpecialModeArray（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeArray">特殊模式下的配置[y1,y2,y3]</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeArray(string specialModeArray, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SpecialModeArray` = @SpecialModeArray", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SpecialModeArray", specialModeArray, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeArrayAsync(string specialModeArray, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SpecialModeArray` = @SpecialModeArray", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SpecialModeArray", specialModeArray, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		#endregion // GetBySpecialModeArray
		#region GetBySpecialModeTurnNum
		
		/// <summary>
		/// 按 SpecialModeTurnNum（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeTurnNum">特殊玩法转动次数</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeTurnNum(int specialModeTurnNum)
		{
			return GetBySpecialModeTurnNum(specialModeTurnNum, 0, string.Empty, null);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeTurnNumAsync(int specialModeTurnNum)
		{
			return await GetBySpecialModeTurnNumAsync(specialModeTurnNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SpecialModeTurnNum（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeTurnNum">特殊玩法转动次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeTurnNum(int specialModeTurnNum, TransactionManager tm_)
		{
			return GetBySpecialModeTurnNum(specialModeTurnNum, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeTurnNumAsync(int specialModeTurnNum, TransactionManager tm_)
		{
			return await GetBySpecialModeTurnNumAsync(specialModeTurnNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SpecialModeTurnNum（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeTurnNum">特殊玩法转动次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeTurnNum(int specialModeTurnNum, int top_)
		{
			return GetBySpecialModeTurnNum(specialModeTurnNum, top_, string.Empty, null);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeTurnNumAsync(int specialModeTurnNum, int top_)
		{
			return await GetBySpecialModeTurnNumAsync(specialModeTurnNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SpecialModeTurnNum（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeTurnNum">特殊玩法转动次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeTurnNum(int specialModeTurnNum, int top_, TransactionManager tm_)
		{
			return GetBySpecialModeTurnNum(specialModeTurnNum, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeTurnNumAsync(int specialModeTurnNum, int top_, TransactionManager tm_)
		{
			return await GetBySpecialModeTurnNumAsync(specialModeTurnNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SpecialModeTurnNum（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeTurnNum">特殊玩法转动次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeTurnNum(int specialModeTurnNum, string sort_)
		{
			return GetBySpecialModeTurnNum(specialModeTurnNum, 0, sort_, null);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeTurnNumAsync(int specialModeTurnNum, string sort_)
		{
			return await GetBySpecialModeTurnNumAsync(specialModeTurnNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SpecialModeTurnNum（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeTurnNum">特殊玩法转动次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeTurnNum(int specialModeTurnNum, string sort_, TransactionManager tm_)
		{
			return GetBySpecialModeTurnNum(specialModeTurnNum, 0, sort_, tm_);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeTurnNumAsync(int specialModeTurnNum, string sort_, TransactionManager tm_)
		{
			return await GetBySpecialModeTurnNumAsync(specialModeTurnNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SpecialModeTurnNum（字段） 查询
		/// </summary>
		/// /// <param name = "specialModeTurnNum">特殊玩法转动次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetBySpecialModeTurnNum(int specialModeTurnNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SpecialModeTurnNum` = @SpecialModeTurnNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SpecialModeTurnNum", specialModeTurnNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		public async Task<List<Fra_configEO>> GetBySpecialModeTurnNumAsync(int specialModeTurnNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SpecialModeTurnNum` = @SpecialModeTurnNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SpecialModeTurnNum", specialModeTurnNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		#endregion // GetBySpecialModeTurnNum
		#region GetByDefaultSlotArray
		
		/// <summary>
		/// 按 DefaultSlotArray（字段） 查询
		/// </summary>
		/// /// <param name = "defaultSlotArray">初始牌面</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByDefaultSlotArray(string defaultSlotArray)
		{
			return GetByDefaultSlotArray(defaultSlotArray, 0, string.Empty, null);
		}
		public async Task<List<Fra_configEO>> GetByDefaultSlotArrayAsync(string defaultSlotArray)
		{
			return await GetByDefaultSlotArrayAsync(defaultSlotArray, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DefaultSlotArray（字段） 查询
		/// </summary>
		/// /// <param name = "defaultSlotArray">初始牌面</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByDefaultSlotArray(string defaultSlotArray, TransactionManager tm_)
		{
			return GetByDefaultSlotArray(defaultSlotArray, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_configEO>> GetByDefaultSlotArrayAsync(string defaultSlotArray, TransactionManager tm_)
		{
			return await GetByDefaultSlotArrayAsync(defaultSlotArray, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DefaultSlotArray（字段） 查询
		/// </summary>
		/// /// <param name = "defaultSlotArray">初始牌面</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByDefaultSlotArray(string defaultSlotArray, int top_)
		{
			return GetByDefaultSlotArray(defaultSlotArray, top_, string.Empty, null);
		}
		public async Task<List<Fra_configEO>> GetByDefaultSlotArrayAsync(string defaultSlotArray, int top_)
		{
			return await GetByDefaultSlotArrayAsync(defaultSlotArray, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DefaultSlotArray（字段） 查询
		/// </summary>
		/// /// <param name = "defaultSlotArray">初始牌面</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByDefaultSlotArray(string defaultSlotArray, int top_, TransactionManager tm_)
		{
			return GetByDefaultSlotArray(defaultSlotArray, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_configEO>> GetByDefaultSlotArrayAsync(string defaultSlotArray, int top_, TransactionManager tm_)
		{
			return await GetByDefaultSlotArrayAsync(defaultSlotArray, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DefaultSlotArray（字段） 查询
		/// </summary>
		/// /// <param name = "defaultSlotArray">初始牌面</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByDefaultSlotArray(string defaultSlotArray, string sort_)
		{
			return GetByDefaultSlotArray(defaultSlotArray, 0, sort_, null);
		}
		public async Task<List<Fra_configEO>> GetByDefaultSlotArrayAsync(string defaultSlotArray, string sort_)
		{
			return await GetByDefaultSlotArrayAsync(defaultSlotArray, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DefaultSlotArray（字段） 查询
		/// </summary>
		/// /// <param name = "defaultSlotArray">初始牌面</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByDefaultSlotArray(string defaultSlotArray, string sort_, TransactionManager tm_)
		{
			return GetByDefaultSlotArray(defaultSlotArray, 0, sort_, tm_);
		}
		public async Task<List<Fra_configEO>> GetByDefaultSlotArrayAsync(string defaultSlotArray, string sort_, TransactionManager tm_)
		{
			return await GetByDefaultSlotArrayAsync(defaultSlotArray, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DefaultSlotArray（字段） 查询
		/// </summary>
		/// /// <param name = "defaultSlotArray">初始牌面</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByDefaultSlotArray(string defaultSlotArray, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DefaultSlotArray` = @DefaultSlotArray", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DefaultSlotArray", defaultSlotArray, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		public async Task<List<Fra_configEO>> GetByDefaultSlotArrayAsync(string defaultSlotArray, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DefaultSlotArray` = @DefaultSlotArray", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DefaultSlotArray", defaultSlotArray, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		#endregion // GetByDefaultSlotArray
		#region GetByMultipArray
		
		/// <summary>
		/// 按 MultipArray（字段） 查询
		/// </summary>
		/// /// <param name = "multipArray">倍率集合</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByMultipArray(string multipArray)
		{
			return GetByMultipArray(multipArray, 0, string.Empty, null);
		}
		public async Task<List<Fra_configEO>> GetByMultipArrayAsync(string multipArray)
		{
			return await GetByMultipArrayAsync(multipArray, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MultipArray（字段） 查询
		/// </summary>
		/// /// <param name = "multipArray">倍率集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByMultipArray(string multipArray, TransactionManager tm_)
		{
			return GetByMultipArray(multipArray, 0, string.Empty, tm_);
		}
		public async Task<List<Fra_configEO>> GetByMultipArrayAsync(string multipArray, TransactionManager tm_)
		{
			return await GetByMultipArrayAsync(multipArray, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MultipArray（字段） 查询
		/// </summary>
		/// /// <param name = "multipArray">倍率集合</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByMultipArray(string multipArray, int top_)
		{
			return GetByMultipArray(multipArray, top_, string.Empty, null);
		}
		public async Task<List<Fra_configEO>> GetByMultipArrayAsync(string multipArray, int top_)
		{
			return await GetByMultipArrayAsync(multipArray, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MultipArray（字段） 查询
		/// </summary>
		/// /// <param name = "multipArray">倍率集合</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByMultipArray(string multipArray, int top_, TransactionManager tm_)
		{
			return GetByMultipArray(multipArray, top_, string.Empty, tm_);
		}
		public async Task<List<Fra_configEO>> GetByMultipArrayAsync(string multipArray, int top_, TransactionManager tm_)
		{
			return await GetByMultipArrayAsync(multipArray, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MultipArray（字段） 查询
		/// </summary>
		/// /// <param name = "multipArray">倍率集合</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByMultipArray(string multipArray, string sort_)
		{
			return GetByMultipArray(multipArray, 0, sort_, null);
		}
		public async Task<List<Fra_configEO>> GetByMultipArrayAsync(string multipArray, string sort_)
		{
			return await GetByMultipArrayAsync(multipArray, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MultipArray（字段） 查询
		/// </summary>
		/// /// <param name = "multipArray">倍率集合</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByMultipArray(string multipArray, string sort_, TransactionManager tm_)
		{
			return GetByMultipArray(multipArray, 0, sort_, tm_);
		}
		public async Task<List<Fra_configEO>> GetByMultipArrayAsync(string multipArray, string sort_, TransactionManager tm_)
		{
			return await GetByMultipArrayAsync(multipArray, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MultipArray（字段） 查询
		/// </summary>
		/// /// <param name = "multipArray">倍率集合</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fra_configEO> GetByMultipArray(string multipArray, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MultipArray` = @MultipArray", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MultipArray", multipArray, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		public async Task<List<Fra_configEO>> GetByMultipArrayAsync(string multipArray, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MultipArray` = @MultipArray", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MultipArray", multipArray, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fra_configEO.MapDataReader);
		}
		#endregion // GetByMultipArray
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
