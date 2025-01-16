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
	/// 初始基础配置
	/// 【表 gsp_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Gsp_configEO : IRowMapper<Gsp_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Gsp_configEO()
		{
			this.IncomeRatio = 0d;
			this.MiniGameRatio = 0d;
			this.FreeSpinCount = 0;
			this.FreeSpinTrigger = 0;
			this.MEGA = 0;
			this.SUPER = 0;
			this.EPIC = 0;
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
		/// 小游戏分配
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 4)]
		public double MiniGameRatio { get; set; }
		/// <summary>
		/// freespin初始值
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int FreeSpinCount { get; set; }
		/// <summary>
		/// freespin触发值
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int FreeSpinTrigger { get; set; }
		/// <summary>
		/// 跑马灯触发倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int BIG { get; set; }
		/// <summary>
		/// 跑马灯触发倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int MEGA { get; set; }
		/// <summary>
		/// 跑马灯触发倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int SUPER { get; set; }
		/// <summary>
		/// 跑马灯触发倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 10)]
		public int EPIC { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Gsp_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Gsp_configEO MapDataReader(IDataReader reader)
		{
		    Gsp_configEO ret = new Gsp_configEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.OriginalCurrencyID = ret.CurrencyID;
			ret.IncomeRatio = reader.ToDouble("IncomeRatio");
			ret.MiniGameRatio = reader.ToDouble("MiniGameRatio");
			ret.FreeSpinCount = reader.ToInt32("FreeSpinCount");
			ret.FreeSpinTrigger = reader.ToInt32("FreeSpinTrigger");
			ret.BIG = reader.ToInt32("BIG");
			ret.MEGA = reader.ToInt32("MEGA");
			ret.SUPER = reader.ToInt32("SUPER");
			ret.EPIC = reader.ToInt32("EPIC");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 初始基础配置
	/// 【表 gsp_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Gsp_configMO : MySqlTableMO<Gsp_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`gsp_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Gsp_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Gsp_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Gsp_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Gsp_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Gsp_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Gsp_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `CurrencyID`, `IncomeRatio`, `MiniGameRatio`, `FreeSpinCount`, `FreeSpinTrigger`, `BIG`, `MEGA`, `SUPER`, `EPIC`) VALUE (@OperatorID, @CurrencyID, @IncomeRatio, @MiniGameRatio, @FreeSpinCount, @FreeSpinTrigger, @BIG, @MEGA, @SUPER, @EPIC);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IncomeRatio", item.IncomeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@MiniGameRatio", item.MiniGameRatio, MySqlDbType.Double),
				Database.CreateInParameter("@FreeSpinCount", item.FreeSpinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@FreeSpinTrigger", item.FreeSpinTrigger, MySqlDbType.Int32),
				Database.CreateInParameter("@BIG", item.BIG, MySqlDbType.Int32),
				Database.CreateInParameter("@MEGA", item.MEGA, MySqlDbType.Int32),
				Database.CreateInParameter("@SUPER", item.SUPER, MySqlDbType.Int32),
				Database.CreateInParameter("@EPIC", item.EPIC, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Gsp_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Gsp_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gsp_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorID`, `CurrencyID`, `IncomeRatio`, `MiniGameRatio`, `FreeSpinCount`, `FreeSpinTrigger`, `BIG`, `MEGA`, `SUPER`, `EPIC`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorID}','{item.CurrencyID}',{item.IncomeRatio},{item.MiniGameRatio},{item.FreeSpinCount},{item.FreeSpinTrigger},{item.BIG},{item.MEGA},{item.SUPER},{item.EPIC}),");
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
		public int Remove(Gsp_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorID, item.CurrencyID, tm_);
		}
		public async Task<int> RemoveAsync(Gsp_configEO item, TransactionManager tm_ = null)
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
		#region RemoveByMiniGameRatio
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "miniGameRatio">小游戏分配</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMiniGameRatio(double miniGameRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByMiniGameRatioData(miniGameRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMiniGameRatioAsync(double miniGameRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByMiniGameRatioData(miniGameRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMiniGameRatioData(double miniGameRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MiniGameRatio` = @MiniGameRatio";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MiniGameRatio", miniGameRatio, MySqlDbType.Double));
		}
		#endregion // RemoveByMiniGameRatio
		#region RemoveByFreeSpinCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "freeSpinCount">freespin初始值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFreeSpinCount(int freeSpinCount, TransactionManager tm_ = null)
		{
			RepairRemoveByFreeSpinCountData(freeSpinCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFreeSpinCountAsync(int freeSpinCount, TransactionManager tm_ = null)
		{
			RepairRemoveByFreeSpinCountData(freeSpinCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFreeSpinCountData(int freeSpinCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FreeSpinCount` = @FreeSpinCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByFreeSpinCount
		#region RemoveByFreeSpinTrigger
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "freeSpinTrigger">freespin触发值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFreeSpinTrigger(int freeSpinTrigger, TransactionManager tm_ = null)
		{
			RepairRemoveByFreeSpinTriggerData(freeSpinTrigger, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFreeSpinTriggerAsync(int freeSpinTrigger, TransactionManager tm_ = null)
		{
			RepairRemoveByFreeSpinTriggerData(freeSpinTrigger, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFreeSpinTriggerData(int freeSpinTrigger, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FreeSpinTrigger` = @FreeSpinTrigger";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreeSpinTrigger", freeSpinTrigger, MySqlDbType.Int32));
		}
		#endregion // RemoveByFreeSpinTrigger
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
		public int Put(Gsp_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Gsp_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Gsp_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `IncomeRatio` = @IncomeRatio, `MiniGameRatio` = @MiniGameRatio, `FreeSpinCount` = @FreeSpinCount, `FreeSpinTrigger` = @FreeSpinTrigger, `BIG` = @BIG, `MEGA` = @MEGA, `SUPER` = @SUPER, `EPIC` = @EPIC WHERE `OperatorID` = @OperatorID_Original AND `CurrencyID` = @CurrencyID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IncomeRatio", item.IncomeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@MiniGameRatio", item.MiniGameRatio, MySqlDbType.Double),
				Database.CreateInParameter("@FreeSpinCount", item.FreeSpinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@FreeSpinTrigger", item.FreeSpinTrigger, MySqlDbType.Int32),
				Database.CreateInParameter("@BIG", item.BIG, MySqlDbType.Int32),
				Database.CreateInParameter("@MEGA", item.MEGA, MySqlDbType.Int32),
				Database.CreateInParameter("@SUPER", item.SUPER, MySqlDbType.Int32),
				Database.CreateInParameter("@EPIC", item.EPIC, MySqlDbType.Int32),
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
		public int Put(IEnumerable<Gsp_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Gsp_configEO> items, TransactionManager tm_ = null)
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
		#region PutMiniGameRatio
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "miniGameRatio">小游戏分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMiniGameRatioByPK(string operatorID, string currencyID, double miniGameRatio, TransactionManager tm_ = null)
		{
			RepairPutMiniGameRatioByPKData(operatorID, currencyID, miniGameRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMiniGameRatioByPKAsync(string operatorID, string currencyID, double miniGameRatio, TransactionManager tm_ = null)
		{
			RepairPutMiniGameRatioByPKData(operatorID, currencyID, miniGameRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMiniGameRatioByPKData(string operatorID, string currencyID, double miniGameRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MiniGameRatio` = @MiniGameRatio  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MiniGameRatio", miniGameRatio, MySqlDbType.Double),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "miniGameRatio">小游戏分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMiniGameRatio(double miniGameRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MiniGameRatio` = @MiniGameRatio";
			var parameter_ = Database.CreateInParameter("@MiniGameRatio", miniGameRatio, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMiniGameRatioAsync(double miniGameRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MiniGameRatio` = @MiniGameRatio";
			var parameter_ = Database.CreateInParameter("@MiniGameRatio", miniGameRatio, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMiniGameRatio
		#region PutFreeSpinCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "freeSpinCount">freespin初始值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreeSpinCountByPK(string operatorID, string currencyID, int freeSpinCount, TransactionManager tm_ = null)
		{
			RepairPutFreeSpinCountByPKData(operatorID, currencyID, freeSpinCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFreeSpinCountByPKAsync(string operatorID, string currencyID, int freeSpinCount, TransactionManager tm_ = null)
		{
			RepairPutFreeSpinCountByPKData(operatorID, currencyID, freeSpinCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFreeSpinCountByPKData(string operatorID, string currencyID, int freeSpinCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FreeSpinCount` = @FreeSpinCount  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "freeSpinCount">freespin初始值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreeSpinCount(int freeSpinCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FreeSpinCount` = @FreeSpinCount";
			var parameter_ = Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFreeSpinCountAsync(int freeSpinCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FreeSpinCount` = @FreeSpinCount";
			var parameter_ = Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFreeSpinCount
		#region PutFreeSpinTrigger
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "freeSpinTrigger">freespin触发值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreeSpinTriggerByPK(string operatorID, string currencyID, int freeSpinTrigger, TransactionManager tm_ = null)
		{
			RepairPutFreeSpinTriggerByPKData(operatorID, currencyID, freeSpinTrigger, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFreeSpinTriggerByPKAsync(string operatorID, string currencyID, int freeSpinTrigger, TransactionManager tm_ = null)
		{
			RepairPutFreeSpinTriggerByPKData(operatorID, currencyID, freeSpinTrigger, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFreeSpinTriggerByPKData(string operatorID, string currencyID, int freeSpinTrigger, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FreeSpinTrigger` = @FreeSpinTrigger  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FreeSpinTrigger", freeSpinTrigger, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "freeSpinTrigger">freespin触发值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreeSpinTrigger(int freeSpinTrigger, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FreeSpinTrigger` = @FreeSpinTrigger";
			var parameter_ = Database.CreateInParameter("@FreeSpinTrigger", freeSpinTrigger, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFreeSpinTriggerAsync(int freeSpinTrigger, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FreeSpinTrigger` = @FreeSpinTrigger";
			var parameter_ = Database.CreateInParameter("@FreeSpinTrigger", freeSpinTrigger, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFreeSpinTrigger
		#region PutBIG
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "bIG">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBIGByPK(string operatorID, string currencyID, int bIG, TransactionManager tm_ = null)
		{
			RepairPutBIGByPKData(operatorID, currencyID, bIG, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBIGByPKAsync(string operatorID, string currencyID, int bIG, TransactionManager tm_ = null)
		{
			RepairPutBIGByPKData(operatorID, currencyID, bIG, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBIGByPKData(string operatorID, string currencyID, int bIG, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BIG` = @BIG  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BIG", bIG, MySqlDbType.Int32),
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "mEGA">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMEGAByPK(string operatorID, string currencyID, int mEGA, TransactionManager tm_ = null)
		{
			RepairPutMEGAByPKData(operatorID, currencyID, mEGA, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMEGAByPKAsync(string operatorID, string currencyID, int mEGA, TransactionManager tm_ = null)
		{
			RepairPutMEGAByPKData(operatorID, currencyID, mEGA, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMEGAByPKData(string operatorID, string currencyID, int mEGA, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MEGA` = @MEGA  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MEGA", mEGA, MySqlDbType.Int32),
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "sUPER">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSUPERByPK(string operatorID, string currencyID, int sUPER, TransactionManager tm_ = null)
		{
			RepairPutSUPERByPKData(operatorID, currencyID, sUPER, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSUPERByPKAsync(string operatorID, string currencyID, int sUPER, TransactionManager tm_ = null)
		{
			RepairPutSUPERByPKData(operatorID, currencyID, sUPER, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSUPERByPKData(string operatorID, string currencyID, int sUPER, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SUPER` = @SUPER  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SUPER", sUPER, MySqlDbType.Int32),
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "ePIC">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEPICByPK(string operatorID, string currencyID, int ePIC, TransactionManager tm_ = null)
		{
			RepairPutEPICByPKData(operatorID, currencyID, ePIC, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEPICByPKAsync(string operatorID, string currencyID, int ePIC, TransactionManager tm_ = null)
		{
			RepairPutEPICByPKData(operatorID, currencyID, ePIC, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEPICByPKData(string operatorID, string currencyID, int ePIC, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EPIC` = @EPIC  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EPIC", ePIC, MySqlDbType.Int32),
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Gsp_configEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Gsp_configEO item, TransactionManager tm = null)
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
		public Gsp_configEO GetByPK(string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		public async Task<Gsp_configEO> GetByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
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
		/// 按主键查询 MiniGameRatio（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetMiniGameRatioByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)GetScalar("`MiniGameRatio`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<double> GetMiniGameRatioByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)await GetScalarAsync("`MiniGameRatio`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FreeSpinCount（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFreeSpinCountByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FreeSpinCount`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetFreeSpinCountByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FreeSpinCount`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FreeSpinTrigger（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFreeSpinTriggerByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FreeSpinTrigger`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetFreeSpinTriggerByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FreeSpinTrigger`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BIG（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetBIGByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`BIG`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetBIGByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`BIG`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MEGA（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMEGAByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`MEGA`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetMEGAByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`MEGA`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SUPER（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSUPERByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`SUPER`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetSUPERByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`SUPER`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EPIC（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetEPICByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`EPIC`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetEPICByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`EPIC`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Gsp_configEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Gsp_configEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Gsp_configEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Gsp_configEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		public async Task<List<Gsp_configEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Gsp_configEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Gsp_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Gsp_configEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Gsp_configEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		public async Task<List<Gsp_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByIncomeRatio
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByIncomeRatio(double incomeRatio)
		{
			return GetByIncomeRatio(incomeRatio, 0, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByIncomeRatioAsync(double incomeRatio)
		{
			return await GetByIncomeRatioAsync(incomeRatio, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByIncomeRatio(double incomeRatio, TransactionManager tm_)
		{
			return GetByIncomeRatio(incomeRatio, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByIncomeRatioAsync(double incomeRatio, TransactionManager tm_)
		{
			return await GetByIncomeRatioAsync(incomeRatio, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByIncomeRatio(double incomeRatio, int top_)
		{
			return GetByIncomeRatio(incomeRatio, top_, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByIncomeRatioAsync(double incomeRatio, int top_)
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
		public List<Gsp_configEO> GetByIncomeRatio(double incomeRatio, int top_, TransactionManager tm_)
		{
			return GetByIncomeRatio(incomeRatio, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByIncomeRatioAsync(double incomeRatio, int top_, TransactionManager tm_)
		{
			return await GetByIncomeRatioAsync(incomeRatio, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByIncomeRatio(double incomeRatio, string sort_)
		{
			return GetByIncomeRatio(incomeRatio, 0, sort_, null);
		}
		public async Task<List<Gsp_configEO>> GetByIncomeRatioAsync(double incomeRatio, string sort_)
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
		public List<Gsp_configEO> GetByIncomeRatio(double incomeRatio, string sort_, TransactionManager tm_)
		{
			return GetByIncomeRatio(incomeRatio, 0, sort_, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByIncomeRatioAsync(double incomeRatio, string sort_, TransactionManager tm_)
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
		public List<Gsp_configEO> GetByIncomeRatio(double incomeRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IncomeRatio` = @IncomeRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		public async Task<List<Gsp_configEO>> GetByIncomeRatioAsync(double incomeRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IncomeRatio` = @IncomeRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		#endregion // GetByIncomeRatio
		#region GetByMiniGameRatio
		
		/// <summary>
		/// 按 MiniGameRatio（字段） 查询
		/// </summary>
		/// /// <param name = "miniGameRatio">小游戏分配</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByMiniGameRatio(double miniGameRatio)
		{
			return GetByMiniGameRatio(miniGameRatio, 0, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByMiniGameRatioAsync(double miniGameRatio)
		{
			return await GetByMiniGameRatioAsync(miniGameRatio, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MiniGameRatio（字段） 查询
		/// </summary>
		/// /// <param name = "miniGameRatio">小游戏分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByMiniGameRatio(double miniGameRatio, TransactionManager tm_)
		{
			return GetByMiniGameRatio(miniGameRatio, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByMiniGameRatioAsync(double miniGameRatio, TransactionManager tm_)
		{
			return await GetByMiniGameRatioAsync(miniGameRatio, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MiniGameRatio（字段） 查询
		/// </summary>
		/// /// <param name = "miniGameRatio">小游戏分配</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByMiniGameRatio(double miniGameRatio, int top_)
		{
			return GetByMiniGameRatio(miniGameRatio, top_, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByMiniGameRatioAsync(double miniGameRatio, int top_)
		{
			return await GetByMiniGameRatioAsync(miniGameRatio, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MiniGameRatio（字段） 查询
		/// </summary>
		/// /// <param name = "miniGameRatio">小游戏分配</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByMiniGameRatio(double miniGameRatio, int top_, TransactionManager tm_)
		{
			return GetByMiniGameRatio(miniGameRatio, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByMiniGameRatioAsync(double miniGameRatio, int top_, TransactionManager tm_)
		{
			return await GetByMiniGameRatioAsync(miniGameRatio, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MiniGameRatio（字段） 查询
		/// </summary>
		/// /// <param name = "miniGameRatio">小游戏分配</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByMiniGameRatio(double miniGameRatio, string sort_)
		{
			return GetByMiniGameRatio(miniGameRatio, 0, sort_, null);
		}
		public async Task<List<Gsp_configEO>> GetByMiniGameRatioAsync(double miniGameRatio, string sort_)
		{
			return await GetByMiniGameRatioAsync(miniGameRatio, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MiniGameRatio（字段） 查询
		/// </summary>
		/// /// <param name = "miniGameRatio">小游戏分配</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByMiniGameRatio(double miniGameRatio, string sort_, TransactionManager tm_)
		{
			return GetByMiniGameRatio(miniGameRatio, 0, sort_, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByMiniGameRatioAsync(double miniGameRatio, string sort_, TransactionManager tm_)
		{
			return await GetByMiniGameRatioAsync(miniGameRatio, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MiniGameRatio（字段） 查询
		/// </summary>
		/// /// <param name = "miniGameRatio">小游戏分配</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByMiniGameRatio(double miniGameRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MiniGameRatio` = @MiniGameRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MiniGameRatio", miniGameRatio, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		public async Task<List<Gsp_configEO>> GetByMiniGameRatioAsync(double miniGameRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MiniGameRatio` = @MiniGameRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MiniGameRatio", miniGameRatio, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		#endregion // GetByMiniGameRatio
		#region GetByFreeSpinCount
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">freespin初始值</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByFreeSpinCount(int freeSpinCount)
		{
			return GetByFreeSpinCount(freeSpinCount, 0, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByFreeSpinCountAsync(int freeSpinCount)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">freespin初始值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByFreeSpinCount(int freeSpinCount, TransactionManager tm_)
		{
			return GetByFreeSpinCount(freeSpinCount, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByFreeSpinCountAsync(int freeSpinCount, TransactionManager tm_)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">freespin初始值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByFreeSpinCount(int freeSpinCount, int top_)
		{
			return GetByFreeSpinCount(freeSpinCount, top_, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByFreeSpinCountAsync(int freeSpinCount, int top_)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">freespin初始值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByFreeSpinCount(int freeSpinCount, int top_, TransactionManager tm_)
		{
			return GetByFreeSpinCount(freeSpinCount, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByFreeSpinCountAsync(int freeSpinCount, int top_, TransactionManager tm_)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">freespin初始值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByFreeSpinCount(int freeSpinCount, string sort_)
		{
			return GetByFreeSpinCount(freeSpinCount, 0, sort_, null);
		}
		public async Task<List<Gsp_configEO>> GetByFreeSpinCountAsync(int freeSpinCount, string sort_)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">freespin初始值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByFreeSpinCount(int freeSpinCount, string sort_, TransactionManager tm_)
		{
			return GetByFreeSpinCount(freeSpinCount, 0, sort_, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByFreeSpinCountAsync(int freeSpinCount, string sort_, TransactionManager tm_)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">freespin初始值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByFreeSpinCount(int freeSpinCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FreeSpinCount` = @FreeSpinCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		public async Task<List<Gsp_configEO>> GetByFreeSpinCountAsync(int freeSpinCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FreeSpinCount` = @FreeSpinCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		#endregion // GetByFreeSpinCount
		#region GetByFreeSpinTrigger
		
		/// <summary>
		/// 按 FreeSpinTrigger（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinTrigger">freespin触发值</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByFreeSpinTrigger(int freeSpinTrigger)
		{
			return GetByFreeSpinTrigger(freeSpinTrigger, 0, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByFreeSpinTriggerAsync(int freeSpinTrigger)
		{
			return await GetByFreeSpinTriggerAsync(freeSpinTrigger, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FreeSpinTrigger（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinTrigger">freespin触发值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByFreeSpinTrigger(int freeSpinTrigger, TransactionManager tm_)
		{
			return GetByFreeSpinTrigger(freeSpinTrigger, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByFreeSpinTriggerAsync(int freeSpinTrigger, TransactionManager tm_)
		{
			return await GetByFreeSpinTriggerAsync(freeSpinTrigger, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FreeSpinTrigger（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinTrigger">freespin触发值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByFreeSpinTrigger(int freeSpinTrigger, int top_)
		{
			return GetByFreeSpinTrigger(freeSpinTrigger, top_, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByFreeSpinTriggerAsync(int freeSpinTrigger, int top_)
		{
			return await GetByFreeSpinTriggerAsync(freeSpinTrigger, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FreeSpinTrigger（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinTrigger">freespin触发值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByFreeSpinTrigger(int freeSpinTrigger, int top_, TransactionManager tm_)
		{
			return GetByFreeSpinTrigger(freeSpinTrigger, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByFreeSpinTriggerAsync(int freeSpinTrigger, int top_, TransactionManager tm_)
		{
			return await GetByFreeSpinTriggerAsync(freeSpinTrigger, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FreeSpinTrigger（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinTrigger">freespin触发值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByFreeSpinTrigger(int freeSpinTrigger, string sort_)
		{
			return GetByFreeSpinTrigger(freeSpinTrigger, 0, sort_, null);
		}
		public async Task<List<Gsp_configEO>> GetByFreeSpinTriggerAsync(int freeSpinTrigger, string sort_)
		{
			return await GetByFreeSpinTriggerAsync(freeSpinTrigger, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FreeSpinTrigger（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinTrigger">freespin触发值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByFreeSpinTrigger(int freeSpinTrigger, string sort_, TransactionManager tm_)
		{
			return GetByFreeSpinTrigger(freeSpinTrigger, 0, sort_, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByFreeSpinTriggerAsync(int freeSpinTrigger, string sort_, TransactionManager tm_)
		{
			return await GetByFreeSpinTriggerAsync(freeSpinTrigger, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FreeSpinTrigger（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinTrigger">freespin触发值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByFreeSpinTrigger(int freeSpinTrigger, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FreeSpinTrigger` = @FreeSpinTrigger", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreeSpinTrigger", freeSpinTrigger, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		public async Task<List<Gsp_configEO>> GetByFreeSpinTriggerAsync(int freeSpinTrigger, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FreeSpinTrigger` = @FreeSpinTrigger", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreeSpinTrigger", freeSpinTrigger, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		#endregion // GetByFreeSpinTrigger
		#region GetByBIG
		
		/// <summary>
		/// 按 BIG（字段） 查询
		/// </summary>
		/// /// <param name = "bIG">跑马灯触发倍数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByBIG(int bIG)
		{
			return GetByBIG(bIG, 0, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByBIGAsync(int bIG)
		{
			return await GetByBIGAsync(bIG, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BIG（字段） 查询
		/// </summary>
		/// /// <param name = "bIG">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByBIG(int bIG, TransactionManager tm_)
		{
			return GetByBIG(bIG, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByBIGAsync(int bIG, TransactionManager tm_)
		{
			return await GetByBIGAsync(bIG, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BIG（字段） 查询
		/// </summary>
		/// /// <param name = "bIG">跑马灯触发倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByBIG(int bIG, int top_)
		{
			return GetByBIG(bIG, top_, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByBIGAsync(int bIG, int top_)
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
		public List<Gsp_configEO> GetByBIG(int bIG, int top_, TransactionManager tm_)
		{
			return GetByBIG(bIG, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByBIGAsync(int bIG, int top_, TransactionManager tm_)
		{
			return await GetByBIGAsync(bIG, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BIG（字段） 查询
		/// </summary>
		/// /// <param name = "bIG">跑马灯触发倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByBIG(int bIG, string sort_)
		{
			return GetByBIG(bIG, 0, sort_, null);
		}
		public async Task<List<Gsp_configEO>> GetByBIGAsync(int bIG, string sort_)
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
		public List<Gsp_configEO> GetByBIG(int bIG, string sort_, TransactionManager tm_)
		{
			return GetByBIG(bIG, 0, sort_, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByBIGAsync(int bIG, string sort_, TransactionManager tm_)
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
		public List<Gsp_configEO> GetByBIG(int bIG, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BIG` = @BIG", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BIG", bIG, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		public async Task<List<Gsp_configEO>> GetByBIGAsync(int bIG, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BIG` = @BIG", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BIG", bIG, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		#endregion // GetByBIG
		#region GetByMEGA
		
		/// <summary>
		/// 按 MEGA（字段） 查询
		/// </summary>
		/// /// <param name = "mEGA">跑马灯触发倍数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByMEGA(int mEGA)
		{
			return GetByMEGA(mEGA, 0, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByMEGAAsync(int mEGA)
		{
			return await GetByMEGAAsync(mEGA, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MEGA（字段） 查询
		/// </summary>
		/// /// <param name = "mEGA">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByMEGA(int mEGA, TransactionManager tm_)
		{
			return GetByMEGA(mEGA, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByMEGAAsync(int mEGA, TransactionManager tm_)
		{
			return await GetByMEGAAsync(mEGA, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MEGA（字段） 查询
		/// </summary>
		/// /// <param name = "mEGA">跑马灯触发倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByMEGA(int mEGA, int top_)
		{
			return GetByMEGA(mEGA, top_, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByMEGAAsync(int mEGA, int top_)
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
		public List<Gsp_configEO> GetByMEGA(int mEGA, int top_, TransactionManager tm_)
		{
			return GetByMEGA(mEGA, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByMEGAAsync(int mEGA, int top_, TransactionManager tm_)
		{
			return await GetByMEGAAsync(mEGA, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MEGA（字段） 查询
		/// </summary>
		/// /// <param name = "mEGA">跑马灯触发倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByMEGA(int mEGA, string sort_)
		{
			return GetByMEGA(mEGA, 0, sort_, null);
		}
		public async Task<List<Gsp_configEO>> GetByMEGAAsync(int mEGA, string sort_)
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
		public List<Gsp_configEO> GetByMEGA(int mEGA, string sort_, TransactionManager tm_)
		{
			return GetByMEGA(mEGA, 0, sort_, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByMEGAAsync(int mEGA, string sort_, TransactionManager tm_)
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
		public List<Gsp_configEO> GetByMEGA(int mEGA, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MEGA` = @MEGA", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MEGA", mEGA, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		public async Task<List<Gsp_configEO>> GetByMEGAAsync(int mEGA, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MEGA` = @MEGA", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MEGA", mEGA, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		#endregion // GetByMEGA
		#region GetBySUPER
		
		/// <summary>
		/// 按 SUPER（字段） 查询
		/// </summary>
		/// /// <param name = "sUPER">跑马灯触发倍数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetBySUPER(int sUPER)
		{
			return GetBySUPER(sUPER, 0, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetBySUPERAsync(int sUPER)
		{
			return await GetBySUPERAsync(sUPER, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SUPER（字段） 查询
		/// </summary>
		/// /// <param name = "sUPER">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetBySUPER(int sUPER, TransactionManager tm_)
		{
			return GetBySUPER(sUPER, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetBySUPERAsync(int sUPER, TransactionManager tm_)
		{
			return await GetBySUPERAsync(sUPER, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SUPER（字段） 查询
		/// </summary>
		/// /// <param name = "sUPER">跑马灯触发倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetBySUPER(int sUPER, int top_)
		{
			return GetBySUPER(sUPER, top_, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetBySUPERAsync(int sUPER, int top_)
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
		public List<Gsp_configEO> GetBySUPER(int sUPER, int top_, TransactionManager tm_)
		{
			return GetBySUPER(sUPER, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetBySUPERAsync(int sUPER, int top_, TransactionManager tm_)
		{
			return await GetBySUPERAsync(sUPER, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SUPER（字段） 查询
		/// </summary>
		/// /// <param name = "sUPER">跑马灯触发倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetBySUPER(int sUPER, string sort_)
		{
			return GetBySUPER(sUPER, 0, sort_, null);
		}
		public async Task<List<Gsp_configEO>> GetBySUPERAsync(int sUPER, string sort_)
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
		public List<Gsp_configEO> GetBySUPER(int sUPER, string sort_, TransactionManager tm_)
		{
			return GetBySUPER(sUPER, 0, sort_, tm_);
		}
		public async Task<List<Gsp_configEO>> GetBySUPERAsync(int sUPER, string sort_, TransactionManager tm_)
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
		public List<Gsp_configEO> GetBySUPER(int sUPER, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SUPER` = @SUPER", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SUPER", sUPER, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		public async Task<List<Gsp_configEO>> GetBySUPERAsync(int sUPER, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SUPER` = @SUPER", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SUPER", sUPER, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		#endregion // GetBySUPER
		#region GetByEPIC
		
		/// <summary>
		/// 按 EPIC（字段） 查询
		/// </summary>
		/// /// <param name = "ePIC">跑马灯触发倍数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByEPIC(int ePIC)
		{
			return GetByEPIC(ePIC, 0, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByEPICAsync(int ePIC)
		{
			return await GetByEPICAsync(ePIC, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EPIC（字段） 查询
		/// </summary>
		/// /// <param name = "ePIC">跑马灯触发倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByEPIC(int ePIC, TransactionManager tm_)
		{
			return GetByEPIC(ePIC, 0, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByEPICAsync(int ePIC, TransactionManager tm_)
		{
			return await GetByEPICAsync(ePIC, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EPIC（字段） 查询
		/// </summary>
		/// /// <param name = "ePIC">跑马灯触发倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByEPIC(int ePIC, int top_)
		{
			return GetByEPIC(ePIC, top_, string.Empty, null);
		}
		public async Task<List<Gsp_configEO>> GetByEPICAsync(int ePIC, int top_)
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
		public List<Gsp_configEO> GetByEPIC(int ePIC, int top_, TransactionManager tm_)
		{
			return GetByEPIC(ePIC, top_, string.Empty, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByEPICAsync(int ePIC, int top_, TransactionManager tm_)
		{
			return await GetByEPICAsync(ePIC, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EPIC（字段） 查询
		/// </summary>
		/// /// <param name = "ePIC">跑马灯触发倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gsp_configEO> GetByEPIC(int ePIC, string sort_)
		{
			return GetByEPIC(ePIC, 0, sort_, null);
		}
		public async Task<List<Gsp_configEO>> GetByEPICAsync(int ePIC, string sort_)
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
		public List<Gsp_configEO> GetByEPIC(int ePIC, string sort_, TransactionManager tm_)
		{
			return GetByEPIC(ePIC, 0, sort_, tm_);
		}
		public async Task<List<Gsp_configEO>> GetByEPICAsync(int ePIC, string sort_, TransactionManager tm_)
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
		public List<Gsp_configEO> GetByEPIC(int ePIC, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EPIC` = @EPIC", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EPIC", ePIC, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		public async Task<List<Gsp_configEO>> GetByEPICAsync(int ePIC, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EPIC` = @EPIC", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EPIC", ePIC, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gsp_configEO.MapDataReader);
		}
		#endregion // GetByEPIC
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
