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
	/// 初始基础配置
	/// 【表 slot_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Slot_configEO : IRowMapper<Slot_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Slot_configEO()
		{
			this.IncomeRatio = 0d;
			this.MEGA = 0;
			this.SUPER = 0;
			this.EPIC = 0;
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
	        return new Dictionary<string, object>() { { "AppID", AppID },  { "OperatorID", OperatorID },  { "CurrencyID", CurrencyID }, };
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
		/// 运营商编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 货币编码（ISO 4217大写）
		/// 【主键 varchar(5)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 税收分配
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 4)]
		public double IncomeRatio { get; set; }
		/// <summary>
		/// 跑马灯触发倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int BIG { get; set; }
		/// <summary>
		/// 跑马灯触发倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int MEGA { get; set; }
		/// <summary>
		/// 跑马灯触发倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int SUPER { get; set; }
		/// <summary>
		/// 跑马灯触发倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int EPIC { get; set; }
		/// <summary>
		/// 权重A面[小玩法权重,特效展示权重]
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 9)]
		public string WightA { get; set; }
		/// <summary>
		/// 权重B面[小玩法权重,特效展示权重]
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 10)]
		public string WightB { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Slot_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Slot_configEO MapDataReader(IDataReader reader)
		{
		    Slot_configEO ret = new Slot_configEO();
			ret.AppID = reader.ToString("AppID");
			ret.OriginalAppID = ret.AppID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.OriginalCurrencyID = ret.CurrencyID;
			ret.IncomeRatio = reader.ToDouble("IncomeRatio");
			ret.BIG = reader.ToInt32("BIG");
			ret.MEGA = reader.ToInt32("MEGA");
			ret.SUPER = reader.ToInt32("SUPER");
			ret.EPIC = reader.ToInt32("EPIC");
			ret.WightA = reader.ToString("WightA");
			ret.WightB = reader.ToString("WightB");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 初始基础配置
	/// 【表 slot_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Slot_configMO : MySqlTableMO<Slot_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`slot_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Slot_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Slot_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Slot_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Slot_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Slot_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Slot_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`AppID`, `OperatorID`, `CurrencyID`, `IncomeRatio`, `BIG`, `MEGA`, `SUPER`, `EPIC`, `WightA`, `WightB`) VALUE (@AppID, @OperatorID, @CurrencyID, @IncomeRatio, @BIG, @MEGA, @SUPER, @EPIC, @WightA, @WightB);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IncomeRatio", item.IncomeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@BIG", item.BIG, MySqlDbType.Int32),
				Database.CreateInParameter("@MEGA", item.MEGA, MySqlDbType.Int32),
				Database.CreateInParameter("@SUPER", item.SUPER, MySqlDbType.Int32),
				Database.CreateInParameter("@EPIC", item.EPIC, MySqlDbType.Int32),
				Database.CreateInParameter("@WightA", item.WightA, MySqlDbType.VarChar),
				Database.CreateInParameter("@WightB", item.WightB, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Slot_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Slot_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Slot_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`AppID`, `OperatorID`, `CurrencyID`, `IncomeRatio`, `BIG`, `MEGA`, `SUPER`, `EPIC`, `WightA`, `WightB`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.AppID}','{item.OperatorID}','{item.CurrencyID}',{item.IncomeRatio},{item.BIG},{item.MEGA},{item.SUPER},{item.EPIC},'{item.WightA}','{item.WightB}'),");
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(appID, operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(appID, operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string appID, string operatorID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
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
		public int Remove(Slot_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.AppID, item.OperatorID, item.CurrencyID, tm_);
		}
		public async Task<int> RemoveAsync(Slot_configEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.AppID, item.OperatorID, item.CurrencyID, tm_);
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
		#region RemoveByBIG
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bIG">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBIG(int bIG, TransactionManager tm_ = null)
		{
			RepairRemoveByBIGData(bIG, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBIGAsync(int bIG, TransactionManager tm_ = null)
		{
			RepairRemoveByBIGData(bIG, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBIGData(int bIG, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BIG` = @BIG";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BIG", bIG, MySqlDbType.Int32));
		}
		#endregion // RemoveByBIG
		#region RemoveByMEGA
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "mEGA">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMEGA(int mEGA, TransactionManager tm_ = null)
		{
			RepairRemoveByMEGAData(mEGA, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMEGAAsync(int mEGA, TransactionManager tm_ = null)
		{
			RepairRemoveByMEGAData(mEGA, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMEGAData(int mEGA, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MEGA` = @MEGA";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MEGA", mEGA, MySqlDbType.Int32));
		}
		#endregion // RemoveByMEGA
		#region RemoveBySUPER
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sUPER">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySUPER(int sUPER, TransactionManager tm_ = null)
		{
			RepairRemoveBySUPERData(sUPER, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySUPERAsync(int sUPER, TransactionManager tm_ = null)
		{
			RepairRemoveBySUPERData(sUPER, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySUPERData(int sUPER, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SUPER` = @SUPER";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SUPER", sUPER, MySqlDbType.Int32));
		}
		#endregion // RemoveBySUPER
		#region RemoveByEPIC
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "ePIC">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEPIC(int ePIC, TransactionManager tm_ = null)
		{
			RepairRemoveByEPICData(ePIC, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEPICAsync(int ePIC, TransactionManager tm_ = null)
		{
			RepairRemoveByEPICData(ePIC, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEPICData(int ePIC, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `EPIC` = @EPIC";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EPIC", ePIC, MySqlDbType.Int32));
		}
		#endregion // RemoveByEPIC
		#region RemoveByWightA
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "wightA">权重A面[小玩法权重,特效展示权重]</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWightA(string wightA, TransactionManager tm_ = null)
		{
			RepairRemoveByWightAData(wightA, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWightAAsync(string wightA, TransactionManager tm_ = null)
		{
			RepairRemoveByWightAData(wightA, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWightAData(string wightA, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WightA` = @WightA";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WightA", wightA, MySqlDbType.VarChar));
		}
		#endregion // RemoveByWightA
		#region RemoveByWightB
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "wightB">权重B面[小玩法权重,特效展示权重]</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWightB(string wightB, TransactionManager tm_ = null)
		{
			RepairRemoveByWightBData(wightB, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWightBAsync(string wightB, TransactionManager tm_ = null)
		{
			RepairRemoveByWightBData(wightB, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWightBData(string wightB, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WightB` = @WightB";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WightB", wightB, MySqlDbType.VarChar));
		}
		#endregion // RemoveByWightB
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
		public int Put(Slot_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Slot_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Slot_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID, `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `IncomeRatio` = @IncomeRatio, `BIG` = @BIG, `MEGA` = @MEGA, `SUPER` = @SUPER, `EPIC` = @EPIC, `WightA` = @WightA, `WightB` = @WightB WHERE `AppID` = @AppID_Original AND `OperatorID` = @OperatorID_Original AND `CurrencyID` = @CurrencyID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IncomeRatio", item.IncomeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@BIG", item.BIG, MySqlDbType.Int32),
				Database.CreateInParameter("@MEGA", item.MEGA, MySqlDbType.Int32),
				Database.CreateInParameter("@SUPER", item.SUPER, MySqlDbType.Int32),
				Database.CreateInParameter("@EPIC", item.EPIC, MySqlDbType.Int32),
				Database.CreateInParameter("@WightA", item.WightA, MySqlDbType.VarChar),
				Database.CreateInParameter("@WightB", item.WightB, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID_Original", item.HasOriginal ? item.OriginalAppID : item.AppID, MySqlDbType.VarChar),
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
		public int Put(IEnumerable<Slot_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Slot_configEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, string operatorID, string currencyID, string set_, params object[] values_)
		{
			return Put(set_, "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatValues(values_, appID, operatorID, currencyID));
		}
		public async Task<int> PutByPKAsync(string appID, string operatorID, string currencyID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatValues(values_, appID, operatorID, currencyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, string operatorID, string currencyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, appID, operatorID, currencyID));
		}
		public async Task<int> PutByPKAsync(string appID, string operatorID, string currencyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, appID, operatorID, currencyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, string operatorID, string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string appID, string operatorID, string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
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
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIncomeRatioByPK(string appID, string operatorID, string currencyID, double incomeRatio, TransactionManager tm_ = null)
		{
			RepairPutIncomeRatioByPKData(appID, operatorID, currencyID, incomeRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIncomeRatioByPKAsync(string appID, string operatorID, string currencyID, double incomeRatio, TransactionManager tm_ = null)
		{
			RepairPutIncomeRatioByPKData(appID, operatorID, currencyID, incomeRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIncomeRatioByPKData(string appID, string operatorID, string currencyID, double incomeRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IncomeRatio` = @IncomeRatio  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
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
		#region PutBIG
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "bIG">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBIGByPK(string appID, string operatorID, string currencyID, int bIG, TransactionManager tm_ = null)
		{
			RepairPutBIGByPKData(appID, operatorID, currencyID, bIG, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBIGByPKAsync(string appID, string operatorID, string currencyID, int bIG, TransactionManager tm_ = null)
		{
			RepairPutBIGByPKData(appID, operatorID, currencyID, bIG, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBIGByPKData(string appID, string operatorID, string currencyID, int bIG, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BIG` = @BIG  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BIG", bIG, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bIG">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBIG(int bIG, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BIG` = @BIG";
			var parameter_ = Database.CreateInParameter("@BIG", bIG, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBIGAsync(int bIG, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BIG` = @BIG";
			var parameter_ = Database.CreateInParameter("@BIG", bIG, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBIG
		#region PutMEGA
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "mEGA">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMEGAByPK(string appID, string operatorID, string currencyID, int mEGA, TransactionManager tm_ = null)
		{
			RepairPutMEGAByPKData(appID, operatorID, currencyID, mEGA, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMEGAByPKAsync(string appID, string operatorID, string currencyID, int mEGA, TransactionManager tm_ = null)
		{
			RepairPutMEGAByPKData(appID, operatorID, currencyID, mEGA, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMEGAByPKData(string appID, string operatorID, string currencyID, int mEGA, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MEGA` = @MEGA  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MEGA", mEGA, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "mEGA">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMEGA(int mEGA, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MEGA` = @MEGA";
			var parameter_ = Database.CreateInParameter("@MEGA", mEGA, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMEGAAsync(int mEGA, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MEGA` = @MEGA";
			var parameter_ = Database.CreateInParameter("@MEGA", mEGA, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMEGA
		#region PutSUPER
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "sUPER">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSUPERByPK(string appID, string operatorID, string currencyID, int sUPER, TransactionManager tm_ = null)
		{
			RepairPutSUPERByPKData(appID, operatorID, currencyID, sUPER, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSUPERByPKAsync(string appID, string operatorID, string currencyID, int sUPER, TransactionManager tm_ = null)
		{
			RepairPutSUPERByPKData(appID, operatorID, currencyID, sUPER, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSUPERByPKData(string appID, string operatorID, string currencyID, int sUPER, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SUPER` = @SUPER  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SUPER", sUPER, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sUPER">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSUPER(int sUPER, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SUPER` = @SUPER";
			var parameter_ = Database.CreateInParameter("@SUPER", sUPER, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSUPERAsync(int sUPER, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SUPER` = @SUPER";
			var parameter_ = Database.CreateInParameter("@SUPER", sUPER, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSUPER
		#region PutEPIC
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "ePIC">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEPICByPK(string appID, string operatorID, string currencyID, int ePIC, TransactionManager tm_ = null)
		{
			RepairPutEPICByPKData(appID, operatorID, currencyID, ePIC, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEPICByPKAsync(string appID, string operatorID, string currencyID, int ePIC, TransactionManager tm_ = null)
		{
			RepairPutEPICByPKData(appID, operatorID, currencyID, ePIC, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEPICByPKData(string appID, string operatorID, string currencyID, int ePIC, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EPIC` = @EPIC  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EPIC", ePIC, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "ePIC">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEPIC(int ePIC, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EPIC` = @EPIC";
			var parameter_ = Database.CreateInParameter("@EPIC", ePIC, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEPICAsync(int ePIC, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EPIC` = @EPIC";
			var parameter_ = Database.CreateInParameter("@EPIC", ePIC, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEPIC
		#region PutWightA
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "wightA">权重A面[小玩法权重,特效展示权重]</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWightAByPK(string appID, string operatorID, string currencyID, string wightA, TransactionManager tm_ = null)
		{
			RepairPutWightAByPKData(appID, operatorID, currencyID, wightA, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWightAByPKAsync(string appID, string operatorID, string currencyID, string wightA, TransactionManager tm_ = null)
		{
			RepairPutWightAByPKData(appID, operatorID, currencyID, wightA, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWightAByPKData(string appID, string operatorID, string currencyID, string wightA, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WightA` = @WightA  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WightA", wightA, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "wightA">权重A面[小玩法权重,特效展示权重]</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWightA(string wightA, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WightA` = @WightA";
			var parameter_ = Database.CreateInParameter("@WightA", wightA, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWightAAsync(string wightA, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WightA` = @WightA";
			var parameter_ = Database.CreateInParameter("@WightA", wightA, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWightA
		#region PutWightB
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "wightB">权重B面[小玩法权重,特效展示权重]</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWightBByPK(string appID, string operatorID, string currencyID, string wightB, TransactionManager tm_ = null)
		{
			RepairPutWightBByPKData(appID, operatorID, currencyID, wightB, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWightBByPKAsync(string appID, string operatorID, string currencyID, string wightB, TransactionManager tm_ = null)
		{
			RepairPutWightBByPKData(appID, operatorID, currencyID, wightB, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWightBByPKData(string appID, string operatorID, string currencyID, string wightB, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WightB` = @WightB  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WightB", wightB, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "wightB">权重B面[小玩法权重,特效展示权重]</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWightB(string wightB, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WightB` = @WightB";
			var parameter_ = Database.CreateInParameter("@WightB", wightB, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWightBAsync(string wightB, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WightB` = @WightB";
			var parameter_ = Database.CreateInParameter("@WightB", wightB, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWightB
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Slot_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AppID, item.OperatorID, item.CurrencyID) == null)
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
		public async Task<bool> SetAsync(Slot_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AppID, item.OperatorID, item.CurrencyID) == null)
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Slot_configEO GetByPK(string appID, string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(appID, operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		public async Task<Slot_configEO> GetByPKAsync(string appID, string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(appID, operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		private void RepairGetByPKData(string appID, string operatorID, string currencyID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IncomeRatio（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetIncomeRatioByPK(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)GetScalar("`IncomeRatio`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<double> GetIncomeRatioByPKAsync(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)await GetScalarAsync("`IncomeRatio`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BIG（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetBIGByPK(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`BIG`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetBIGByPKAsync(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`BIG`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MEGA（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMEGAByPK(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`MEGA`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetMEGAByPKAsync(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`MEGA`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SUPER（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSUPERByPK(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`SUPER`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetSUPERByPKAsync(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`SUPER`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EPIC（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetEPICByPK(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`EPIC`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetEPICByPKAsync(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`EPIC`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WightA（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetWightAByPK(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`WightA`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetWightAByPKAsync(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`WightA`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WightB（字段）
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetWightBByPK(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`WightB`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetWightBByPKAsync(string appID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`WightB`", "`AppID` = @AppID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByAppIDAsync(string appID, int top_)
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
		public List<Slot_configEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<Slot_configEO>> GetByAppIDAsync(string appID, string sort_)
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
		public List<Slot_configEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<Slot_configEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
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
		public List<Slot_configEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		public async Task<List<Slot_configEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Slot_configEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Slot_configEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Slot_configEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Slot_configEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Slot_configEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		public async Task<List<Slot_configEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Slot_configEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Slot_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Slot_configEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Slot_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Slot_configEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		public async Task<List<Slot_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByIncomeRatio
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByIncomeRatio(double incomeRatio)
		{
			return GetByIncomeRatio(incomeRatio, 0, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByIncomeRatioAsync(double incomeRatio)
		{
			return await GetByIncomeRatioAsync(incomeRatio, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByIncomeRatio(double incomeRatio, TransactionManager tm_)
		{
			return GetByIncomeRatio(incomeRatio, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByIncomeRatioAsync(double incomeRatio, TransactionManager tm_)
		{
			return await GetByIncomeRatioAsync(incomeRatio, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByIncomeRatio(double incomeRatio, int top_)
		{
			return GetByIncomeRatio(incomeRatio, top_, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByIncomeRatioAsync(double incomeRatio, int top_)
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
		public List<Slot_configEO> GetByIncomeRatio(double incomeRatio, int top_, TransactionManager tm_)
		{
			return GetByIncomeRatio(incomeRatio, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByIncomeRatioAsync(double incomeRatio, int top_, TransactionManager tm_)
		{
			return await GetByIncomeRatioAsync(incomeRatio, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByIncomeRatio(double incomeRatio, string sort_)
		{
			return GetByIncomeRatio(incomeRatio, 0, sort_, null);
		}
		public async Task<List<Slot_configEO>> GetByIncomeRatioAsync(double incomeRatio, string sort_)
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
		public List<Slot_configEO> GetByIncomeRatio(double incomeRatio, string sort_, TransactionManager tm_)
		{
			return GetByIncomeRatio(incomeRatio, 0, sort_, tm_);
		}
		public async Task<List<Slot_configEO>> GetByIncomeRatioAsync(double incomeRatio, string sort_, TransactionManager tm_)
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
		public List<Slot_configEO> GetByIncomeRatio(double incomeRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IncomeRatio` = @IncomeRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		public async Task<List<Slot_configEO>> GetByIncomeRatioAsync(double incomeRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IncomeRatio` = @IncomeRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		#endregion // GetByIncomeRatio
		#region GetByBIG
		
		/// <summary>
		/// 按 BIG（字段） 查询
		/// </summary>
		/// /// <param name = "bIG">跑马灯触发倍数</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByBIG(int bIG)
		{
			return GetByBIG(bIG, 0, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByBIGAsync(int bIG)
		{
			return await GetByBIGAsync(bIG, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BIG（字段） 查询
		/// </summary>
		/// /// <param name = "bIG">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByBIG(int bIG, TransactionManager tm_)
		{
			return GetByBIG(bIG, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByBIGAsync(int bIG, TransactionManager tm_)
		{
			return await GetByBIGAsync(bIG, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BIG（字段） 查询
		/// </summary>
		/// /// <param name = "bIG">跑马灯触发倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByBIG(int bIG, int top_)
		{
			return GetByBIG(bIG, top_, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByBIGAsync(int bIG, int top_)
		{
			return await GetByBIGAsync(bIG, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BIG（字段） 查询
		/// </summary>
		/// /// <param name = "bIG">跑马灯触发倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByBIG(int bIG, int top_, TransactionManager tm_)
		{
			return GetByBIG(bIG, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByBIGAsync(int bIG, int top_, TransactionManager tm_)
		{
			return await GetByBIGAsync(bIG, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BIG（字段） 查询
		/// </summary>
		/// /// <param name = "bIG">跑马灯触发倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByBIG(int bIG, string sort_)
		{
			return GetByBIG(bIG, 0, sort_, null);
		}
		public async Task<List<Slot_configEO>> GetByBIGAsync(int bIG, string sort_)
		{
			return await GetByBIGAsync(bIG, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BIG（字段） 查询
		/// </summary>
		/// /// <param name = "bIG">跑马灯触发倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByBIG(int bIG, string sort_, TransactionManager tm_)
		{
			return GetByBIG(bIG, 0, sort_, tm_);
		}
		public async Task<List<Slot_configEO>> GetByBIGAsync(int bIG, string sort_, TransactionManager tm_)
		{
			return await GetByBIGAsync(bIG, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BIG（字段） 查询
		/// </summary>
		/// /// <param name = "bIG">跑马灯触发倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByBIG(int bIG, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BIG` = @BIG", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BIG", bIG, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		public async Task<List<Slot_configEO>> GetByBIGAsync(int bIG, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BIG` = @BIG", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BIG", bIG, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		#endregion // GetByBIG
		#region GetByMEGA
		
		/// <summary>
		/// 按 MEGA（字段） 查询
		/// </summary>
		/// /// <param name = "mEGA">跑马灯触发倍数</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByMEGA(int mEGA)
		{
			return GetByMEGA(mEGA, 0, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByMEGAAsync(int mEGA)
		{
			return await GetByMEGAAsync(mEGA, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MEGA（字段） 查询
		/// </summary>
		/// /// <param name = "mEGA">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByMEGA(int mEGA, TransactionManager tm_)
		{
			return GetByMEGA(mEGA, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByMEGAAsync(int mEGA, TransactionManager tm_)
		{
			return await GetByMEGAAsync(mEGA, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MEGA（字段） 查询
		/// </summary>
		/// /// <param name = "mEGA">跑马灯触发倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByMEGA(int mEGA, int top_)
		{
			return GetByMEGA(mEGA, top_, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByMEGAAsync(int mEGA, int top_)
		{
			return await GetByMEGAAsync(mEGA, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MEGA（字段） 查询
		/// </summary>
		/// /// <param name = "mEGA">跑马灯触发倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByMEGA(int mEGA, int top_, TransactionManager tm_)
		{
			return GetByMEGA(mEGA, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByMEGAAsync(int mEGA, int top_, TransactionManager tm_)
		{
			return await GetByMEGAAsync(mEGA, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MEGA（字段） 查询
		/// </summary>
		/// /// <param name = "mEGA">跑马灯触发倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByMEGA(int mEGA, string sort_)
		{
			return GetByMEGA(mEGA, 0, sort_, null);
		}
		public async Task<List<Slot_configEO>> GetByMEGAAsync(int mEGA, string sort_)
		{
			return await GetByMEGAAsync(mEGA, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MEGA（字段） 查询
		/// </summary>
		/// /// <param name = "mEGA">跑马灯触发倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByMEGA(int mEGA, string sort_, TransactionManager tm_)
		{
			return GetByMEGA(mEGA, 0, sort_, tm_);
		}
		public async Task<List<Slot_configEO>> GetByMEGAAsync(int mEGA, string sort_, TransactionManager tm_)
		{
			return await GetByMEGAAsync(mEGA, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MEGA（字段） 查询
		/// </summary>
		/// /// <param name = "mEGA">跑马灯触发倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByMEGA(int mEGA, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MEGA` = @MEGA", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MEGA", mEGA, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		public async Task<List<Slot_configEO>> GetByMEGAAsync(int mEGA, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MEGA` = @MEGA", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MEGA", mEGA, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		#endregion // GetByMEGA
		#region GetBySUPER
		
		/// <summary>
		/// 按 SUPER（字段） 查询
		/// </summary>
		/// /// <param name = "sUPER">跑马灯触发倍数</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetBySUPER(int sUPER)
		{
			return GetBySUPER(sUPER, 0, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetBySUPERAsync(int sUPER)
		{
			return await GetBySUPERAsync(sUPER, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SUPER（字段） 查询
		/// </summary>
		/// /// <param name = "sUPER">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetBySUPER(int sUPER, TransactionManager tm_)
		{
			return GetBySUPER(sUPER, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetBySUPERAsync(int sUPER, TransactionManager tm_)
		{
			return await GetBySUPERAsync(sUPER, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SUPER（字段） 查询
		/// </summary>
		/// /// <param name = "sUPER">跑马灯触发倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetBySUPER(int sUPER, int top_)
		{
			return GetBySUPER(sUPER, top_, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetBySUPERAsync(int sUPER, int top_)
		{
			return await GetBySUPERAsync(sUPER, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SUPER（字段） 查询
		/// </summary>
		/// /// <param name = "sUPER">跑马灯触发倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetBySUPER(int sUPER, int top_, TransactionManager tm_)
		{
			return GetBySUPER(sUPER, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetBySUPERAsync(int sUPER, int top_, TransactionManager tm_)
		{
			return await GetBySUPERAsync(sUPER, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SUPER（字段） 查询
		/// </summary>
		/// /// <param name = "sUPER">跑马灯触发倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetBySUPER(int sUPER, string sort_)
		{
			return GetBySUPER(sUPER, 0, sort_, null);
		}
		public async Task<List<Slot_configEO>> GetBySUPERAsync(int sUPER, string sort_)
		{
			return await GetBySUPERAsync(sUPER, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SUPER（字段） 查询
		/// </summary>
		/// /// <param name = "sUPER">跑马灯触发倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetBySUPER(int sUPER, string sort_, TransactionManager tm_)
		{
			return GetBySUPER(sUPER, 0, sort_, tm_);
		}
		public async Task<List<Slot_configEO>> GetBySUPERAsync(int sUPER, string sort_, TransactionManager tm_)
		{
			return await GetBySUPERAsync(sUPER, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SUPER（字段） 查询
		/// </summary>
		/// /// <param name = "sUPER">跑马灯触发倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetBySUPER(int sUPER, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SUPER` = @SUPER", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SUPER", sUPER, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		public async Task<List<Slot_configEO>> GetBySUPERAsync(int sUPER, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SUPER` = @SUPER", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SUPER", sUPER, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		#endregion // GetBySUPER
		#region GetByEPIC
		
		/// <summary>
		/// 按 EPIC（字段） 查询
		/// </summary>
		/// /// <param name = "ePIC">跑马灯触发倍数</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByEPIC(int ePIC)
		{
			return GetByEPIC(ePIC, 0, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByEPICAsync(int ePIC)
		{
			return await GetByEPICAsync(ePIC, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EPIC（字段） 查询
		/// </summary>
		/// /// <param name = "ePIC">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByEPIC(int ePIC, TransactionManager tm_)
		{
			return GetByEPIC(ePIC, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByEPICAsync(int ePIC, TransactionManager tm_)
		{
			return await GetByEPICAsync(ePIC, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EPIC（字段） 查询
		/// </summary>
		/// /// <param name = "ePIC">跑马灯触发倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByEPIC(int ePIC, int top_)
		{
			return GetByEPIC(ePIC, top_, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByEPICAsync(int ePIC, int top_)
		{
			return await GetByEPICAsync(ePIC, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EPIC（字段） 查询
		/// </summary>
		/// /// <param name = "ePIC">跑马灯触发倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByEPIC(int ePIC, int top_, TransactionManager tm_)
		{
			return GetByEPIC(ePIC, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByEPICAsync(int ePIC, int top_, TransactionManager tm_)
		{
			return await GetByEPICAsync(ePIC, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EPIC（字段） 查询
		/// </summary>
		/// /// <param name = "ePIC">跑马灯触发倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByEPIC(int ePIC, string sort_)
		{
			return GetByEPIC(ePIC, 0, sort_, null);
		}
		public async Task<List<Slot_configEO>> GetByEPICAsync(int ePIC, string sort_)
		{
			return await GetByEPICAsync(ePIC, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 EPIC（字段） 查询
		/// </summary>
		/// /// <param name = "ePIC">跑马灯触发倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByEPIC(int ePIC, string sort_, TransactionManager tm_)
		{
			return GetByEPIC(ePIC, 0, sort_, tm_);
		}
		public async Task<List<Slot_configEO>> GetByEPICAsync(int ePIC, string sort_, TransactionManager tm_)
		{
			return await GetByEPICAsync(ePIC, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 EPIC（字段） 查询
		/// </summary>
		/// /// <param name = "ePIC">跑马灯触发倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByEPIC(int ePIC, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EPIC` = @EPIC", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EPIC", ePIC, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		public async Task<List<Slot_configEO>> GetByEPICAsync(int ePIC, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EPIC` = @EPIC", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EPIC", ePIC, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		#endregion // GetByEPIC
		#region GetByWightA
		
		/// <summary>
		/// 按 WightA（字段） 查询
		/// </summary>
		/// /// <param name = "wightA">权重A面[小玩法权重,特效展示权重]</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByWightA(string wightA)
		{
			return GetByWightA(wightA, 0, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByWightAAsync(string wightA)
		{
			return await GetByWightAAsync(wightA, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WightA（字段） 查询
		/// </summary>
		/// /// <param name = "wightA">权重A面[小玩法权重,特效展示权重]</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByWightA(string wightA, TransactionManager tm_)
		{
			return GetByWightA(wightA, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByWightAAsync(string wightA, TransactionManager tm_)
		{
			return await GetByWightAAsync(wightA, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WightA（字段） 查询
		/// </summary>
		/// /// <param name = "wightA">权重A面[小玩法权重,特效展示权重]</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByWightA(string wightA, int top_)
		{
			return GetByWightA(wightA, top_, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByWightAAsync(string wightA, int top_)
		{
			return await GetByWightAAsync(wightA, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WightA（字段） 查询
		/// </summary>
		/// /// <param name = "wightA">权重A面[小玩法权重,特效展示权重]</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByWightA(string wightA, int top_, TransactionManager tm_)
		{
			return GetByWightA(wightA, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByWightAAsync(string wightA, int top_, TransactionManager tm_)
		{
			return await GetByWightAAsync(wightA, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WightA（字段） 查询
		/// </summary>
		/// /// <param name = "wightA">权重A面[小玩法权重,特效展示权重]</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByWightA(string wightA, string sort_)
		{
			return GetByWightA(wightA, 0, sort_, null);
		}
		public async Task<List<Slot_configEO>> GetByWightAAsync(string wightA, string sort_)
		{
			return await GetByWightAAsync(wightA, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WightA（字段） 查询
		/// </summary>
		/// /// <param name = "wightA">权重A面[小玩法权重,特效展示权重]</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByWightA(string wightA, string sort_, TransactionManager tm_)
		{
			return GetByWightA(wightA, 0, sort_, tm_);
		}
		public async Task<List<Slot_configEO>> GetByWightAAsync(string wightA, string sort_, TransactionManager tm_)
		{
			return await GetByWightAAsync(wightA, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WightA（字段） 查询
		/// </summary>
		/// /// <param name = "wightA">权重A面[小玩法权重,特效展示权重]</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByWightA(string wightA, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WightA` = @WightA", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WightA", wightA, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		public async Task<List<Slot_configEO>> GetByWightAAsync(string wightA, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WightA` = @WightA", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WightA", wightA, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		#endregion // GetByWightA
		#region GetByWightB
		
		/// <summary>
		/// 按 WightB（字段） 查询
		/// </summary>
		/// /// <param name = "wightB">权重B面[小玩法权重,特效展示权重]</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByWightB(string wightB)
		{
			return GetByWightB(wightB, 0, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByWightBAsync(string wightB)
		{
			return await GetByWightBAsync(wightB, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WightB（字段） 查询
		/// </summary>
		/// /// <param name = "wightB">权重B面[小玩法权重,特效展示权重]</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByWightB(string wightB, TransactionManager tm_)
		{
			return GetByWightB(wightB, 0, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByWightBAsync(string wightB, TransactionManager tm_)
		{
			return await GetByWightBAsync(wightB, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WightB（字段） 查询
		/// </summary>
		/// /// <param name = "wightB">权重B面[小玩法权重,特效展示权重]</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByWightB(string wightB, int top_)
		{
			return GetByWightB(wightB, top_, string.Empty, null);
		}
		public async Task<List<Slot_configEO>> GetByWightBAsync(string wightB, int top_)
		{
			return await GetByWightBAsync(wightB, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WightB（字段） 查询
		/// </summary>
		/// /// <param name = "wightB">权重B面[小玩法权重,特效展示权重]</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByWightB(string wightB, int top_, TransactionManager tm_)
		{
			return GetByWightB(wightB, top_, string.Empty, tm_);
		}
		public async Task<List<Slot_configEO>> GetByWightBAsync(string wightB, int top_, TransactionManager tm_)
		{
			return await GetByWightBAsync(wightB, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WightB（字段） 查询
		/// </summary>
		/// /// <param name = "wightB">权重B面[小玩法权重,特效展示权重]</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByWightB(string wightB, string sort_)
		{
			return GetByWightB(wightB, 0, sort_, null);
		}
		public async Task<List<Slot_configEO>> GetByWightBAsync(string wightB, string sort_)
		{
			return await GetByWightBAsync(wightB, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WightB（字段） 查询
		/// </summary>
		/// /// <param name = "wightB">权重B面[小玩法权重,特效展示权重]</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByWightB(string wightB, string sort_, TransactionManager tm_)
		{
			return GetByWightB(wightB, 0, sort_, tm_);
		}
		public async Task<List<Slot_configEO>> GetByWightBAsync(string wightB, string sort_, TransactionManager tm_)
		{
			return await GetByWightBAsync(wightB, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WightB（字段） 查询
		/// </summary>
		/// /// <param name = "wightB">权重B面[小玩法权重,特效展示权重]</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Slot_configEO> GetByWightB(string wightB, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WightB` = @WightB", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WightB", wightB, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		public async Task<List<Slot_configEO>> GetByWightBAsync(string wightB, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WightB` = @WightB", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WightB", wightB, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Slot_configEO.MapDataReader);
		}
		#endregion // GetByWightB
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
