/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-25 14: 03:01
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

namespace Fortune_ox.DAL
{
	#region EO
	/// <summary>
	/// 跑马灯
	/// 【表 fox_user_lamp 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Fox_user_lampEO : IRowMapper<Fox_user_lampEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Fox_user_lampEO()
		{
			this.PlayerName = "0";
			this.Reward = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalLampID;
		/// <summary>
		/// 【数据库中的原始主键 LampID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalLampID
		{
			get { return _originalLampID; }
			set { HasOriginal = true; _originalLampID = value; }
		}
		
		private string _originalAppID;
		/// <summary>
		/// 【数据库中的原始主键 AppID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalAppID
		{
			get { return _originalAppID; }
			set { HasOriginal = true; _originalAppID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "LampID", LampID },  { "AppID", AppID }, };
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
		public int LampID { get; set; }
		/// <summary>
		/// appid
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string AppID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 货币编码（ISO 4217大写）
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 中奖昵称
		/// 【字段 varchar(16)】
		/// </summary>
		[DataMember(Order = 5)]
		public string PlayerName { get; set; }
		/// <summary>
		/// 中奖金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long Reward { get; set; }
		/// <summary>
		/// 中奖总倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int Multip { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 8)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Fox_user_lampEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Fox_user_lampEO MapDataReader(IDataReader reader)
		{
		    Fox_user_lampEO ret = new Fox_user_lampEO();
			ret.LampID = reader.ToInt32("LampID");
			ret.OriginalLampID = ret.LampID;
			ret.AppID = reader.ToString("AppID");
			ret.OriginalAppID = ret.AppID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.PlayerName = reader.ToString("PlayerName");
			ret.Reward = reader.ToInt64("Reward");
			ret.Multip = reader.ToInt32("Multip");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 跑马灯
	/// 【表 fox_user_lamp 的操作类】
	/// </summary>
	[Obsolete]
	public class Fox_user_lampMO : MySqlTableMO<Fox_user_lampEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`fox_user_lamp`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Fox_user_lampMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Fox_user_lampMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Fox_user_lampMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Fox_user_lampEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			item.LampID = Database.ExecSqlScalar<int>(sql_, paras_, tm_); 
			return 1;
		}
		public override async Task<int> AddAsync(Fox_user_lampEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			item.LampID = await Database.ExecSqlScalarAsync<int>(sql_, paras_, tm_); 
	        return 1;
		}
	    private void RepairAddData(Fox_user_lampEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`AppID`, `OperatorID`, `CurrencyID`, `PlayerName`, `Reward`, `Multip`, `RecDate`) VALUE (@AppID, @OperatorID, @CurrencyID, @PlayerName, @Reward, @Multip, @RecDate);SELECT LAST_INSERT_ID();";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PlayerName", item.PlayerName, MySqlDbType.VarChar),
				Database.CreateInParameter("@Reward", item.Reward, MySqlDbType.Int64),
				Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Fox_user_lampEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Fox_user_lampEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Fox_user_lampEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`LampID`, `AppID`, `OperatorID`, `CurrencyID`, `PlayerName`, `Reward`, `Multip`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.LampID},'{item.AppID}','{item.OperatorID}','{item.CurrencyID}','{item.PlayerName}',{item.Reward},{item.Multip},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int lampID, string appID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(lampID, appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int lampID, string appID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(lampID, appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int lampID, string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LampID` = @LampID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Fox_user_lampEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.LampID, item.AppID, tm_);
		}
		public async Task<int> RemoveAsync(Fox_user_lampEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.LampID, item.AppID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByLampID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLampID(int lampID, TransactionManager tm_ = null)
		{
			RepairRemoveByLampIDData(lampID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLampIDAsync(int lampID, TransactionManager tm_ = null)
		{
			RepairRemoveByLampIDData(lampID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLampIDData(int lampID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LampID` = @LampID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32));
		}
		#endregion // RemoveByLampID
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
		#region RemoveByPlayerName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "playerName">中奖昵称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPlayerName(string playerName, TransactionManager tm_ = null)
		{
			RepairRemoveByPlayerNameData(playerName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPlayerNameAsync(string playerName, TransactionManager tm_ = null)
		{
			RepairRemoveByPlayerNameData(playerName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPlayerNameData(string playerName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PlayerName` = @PlayerName";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlayerName", playerName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByPlayerName
		#region RemoveByReward
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "reward">中奖金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByReward(long reward, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardData(reward, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRewardAsync(long reward, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardData(reward, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRewardData(long reward, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Reward` = @Reward";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Reward", reward, MySqlDbType.Int64));
		}
		#endregion // RemoveByReward
		#region RemoveByMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "multip">中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMultip(int multip, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipData(multip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMultipAsync(int multip, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipData(multip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMultipData(int multip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Multip` = @Multip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
		}
		#endregion // RemoveByMultip
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecDateData(DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RecDate` = @RecDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRecDate
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
		public int Put(Fox_user_lampEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Fox_user_lampEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Fox_user_lampEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID, `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `PlayerName` = @PlayerName, `Reward` = @Reward, `Multip` = @Multip WHERE `LampID` = @LampID_Original AND `AppID` = @AppID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PlayerName", item.PlayerName, MySqlDbType.VarChar),
				Database.CreateInParameter("@Reward", item.Reward, MySqlDbType.Int64),
				Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Int32),
				Database.CreateInParameter("@LampID_Original", item.HasOriginal ? item.OriginalLampID : item.LampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID_Original", item.HasOriginal ? item.OriginalAppID : item.AppID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Fox_user_lampEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Fox_user_lampEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int lampID, string appID, string set_, params object[] values_)
		{
			return Put(set_, "`LampID` = @LampID AND `AppID` = @AppID", ConcatValues(values_, lampID, appID));
		}
		public async Task<int> PutByPKAsync(int lampID, string appID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`LampID` = @LampID AND `AppID` = @AppID", ConcatValues(values_, lampID, appID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int lampID, string appID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`LampID` = @LampID AND `AppID` = @AppID", tm_, ConcatValues(values_, lampID, appID));
		}
		public async Task<int> PutByPKAsync(int lampID, string appID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`LampID` = @LampID AND `AppID` = @AppID", tm_, ConcatValues(values_, lampID, appID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int lampID, string appID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`LampID` = @LampID AND `AppID` = @AppID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int lampID, string appID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`LampID` = @LampID AND `AppID` = @AppID", ConcatParameters(paras_, newParas_), tm_);
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
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(int lampID, string appID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(lampID, appID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(int lampID, string appID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(lampID, appID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(int lampID, string appID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `LampID` = @LampID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
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
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(int lampID, string appID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(lampID, appID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(int lampID, string appID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(lampID, appID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(int lampID, string appID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `LampID` = @LampID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
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
		#region PutPlayerName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "playerName">中奖昵称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPlayerNameByPK(int lampID, string appID, string playerName, TransactionManager tm_ = null)
		{
			RepairPutPlayerNameByPKData(lampID, appID, playerName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPlayerNameByPKAsync(int lampID, string appID, string playerName, TransactionManager tm_ = null)
		{
			RepairPutPlayerNameByPKData(lampID, appID, playerName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPlayerNameByPKData(int lampID, string appID, string playerName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PlayerName` = @PlayerName  WHERE `LampID` = @LampID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PlayerName", playerName, MySqlDbType.VarChar),
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "playerName">中奖昵称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPlayerName(string playerName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PlayerName` = @PlayerName";
			var parameter_ = Database.CreateInParameter("@PlayerName", playerName, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPlayerNameAsync(string playerName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PlayerName` = @PlayerName";
			var parameter_ = Database.CreateInParameter("@PlayerName", playerName, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPlayerName
		#region PutReward
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "reward">中奖金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardByPK(int lampID, string appID, long reward, TransactionManager tm_ = null)
		{
			RepairPutRewardByPKData(lampID, appID, reward, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardByPKAsync(int lampID, string appID, long reward, TransactionManager tm_ = null)
		{
			RepairPutRewardByPKData(lampID, appID, reward, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardByPKData(int lampID, string appID, long reward, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Reward` = @Reward  WHERE `LampID` = @LampID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Reward", reward, MySqlDbType.Int64),
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "reward">中奖金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReward(long reward, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Reward` = @Reward";
			var parameter_ = Database.CreateInParameter("@Reward", reward, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRewardAsync(long reward, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Reward` = @Reward";
			var parameter_ = Database.CreateInParameter("@Reward", reward, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutReward
		#region PutMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "multip">中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultipByPK(int lampID, string appID, int multip, TransactionManager tm_ = null)
		{
			RepairPutMultipByPKData(lampID, appID, multip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMultipByPKAsync(int lampID, string appID, int multip, TransactionManager tm_ = null)
		{
			RepairPutMultipByPKData(lampID, appID, multip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMultipByPKData(int lampID, string appID, int multip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Multip` = @Multip  WHERE `LampID` = @LampID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32),
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "multip">中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultip(int multip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multip` = @Multip";
			var parameter_ = Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMultipAsync(int multip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multip` = @Multip";
			var parameter_ = Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMultip
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(int lampID, string appID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(lampID, appID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(int lampID, string appID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(lampID, appID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(int lampID, string appID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `LampID` = @LampID AND `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRecDate
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Fox_user_lampEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.LampID, item.AppID) == null)
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
		public async Task<bool> SetAsync(Fox_user_lampEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.LampID, item.AppID) == null)
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
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Fox_user_lampEO GetByPK(int lampID, string appID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(lampID, appID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		public async Task<Fox_user_lampEO> GetByPKAsync(int lampID, string appID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(lampID, appID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		private void RepairGetByPKData(int lampID, string appID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`LampID` = @LampID AND `AppID` = @AppID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 LampID（字段）
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLampIDByPK(int lampID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`LampID`", "`LampID` = @LampID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<int> GetLampIDByPKAsync(int lampID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`LampID`", "`LampID` = @LampID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(int lampID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`LampID` = @LampID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(int lampID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`LampID` = @LampID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(int lampID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`LampID` = @LampID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(int lampID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`LampID` = @LampID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(int lampID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`LampID` = @LampID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(int lampID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`LampID` = @LampID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PlayerName（字段）
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPlayerNameByPK(int lampID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`PlayerName`", "`LampID` = @LampID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetPlayerNameByPKAsync(int lampID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`PlayerName`", "`LampID` = @LampID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Reward（字段）
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetRewardByPK(int lampID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Reward`", "`LampID` = @LampID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<long> GetRewardByPKAsync(int lampID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Reward`", "`LampID` = @LampID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Multip（字段）
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMultipByPK(int lampID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Multip`", "`LampID` = @LampID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<int> GetMultipByPKAsync(int lampID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Multip`", "`LampID` = @LampID AND `AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(int lampID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`LampID` = @LampID AND `AppID` = @AppID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(int lampID, string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`LampID` = @LampID AND `AppID` = @AppID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByLampID
		
		/// <summary>
		/// 按 LampID（字段） 查询
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByLampID(int lampID)
		{
			return GetByLampID(lampID, 0, string.Empty, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByLampIDAsync(int lampID)
		{
			return await GetByLampIDAsync(lampID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LampID（字段） 查询
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByLampID(int lampID, TransactionManager tm_)
		{
			return GetByLampID(lampID, 0, string.Empty, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByLampIDAsync(int lampID, TransactionManager tm_)
		{
			return await GetByLampIDAsync(lampID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LampID（字段） 查询
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByLampID(int lampID, int top_)
		{
			return GetByLampID(lampID, top_, string.Empty, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByLampIDAsync(int lampID, int top_)
		{
			return await GetByLampIDAsync(lampID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LampID（字段） 查询
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByLampID(int lampID, int top_, TransactionManager tm_)
		{
			return GetByLampID(lampID, top_, string.Empty, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByLampIDAsync(int lampID, int top_, TransactionManager tm_)
		{
			return await GetByLampIDAsync(lampID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LampID（字段） 查询
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByLampID(int lampID, string sort_)
		{
			return GetByLampID(lampID, 0, sort_, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByLampIDAsync(int lampID, string sort_)
		{
			return await GetByLampIDAsync(lampID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LampID（字段） 查询
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByLampID(int lampID, string sort_, TransactionManager tm_)
		{
			return GetByLampID(lampID, 0, sort_, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByLampIDAsync(int lampID, string sort_, TransactionManager tm_)
		{
			return await GetByLampIDAsync(lampID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LampID（字段） 查询
		/// </summary>
		/// /// <param name = "lampID">主键</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByLampID(int lampID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LampID` = @LampID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		public async Task<List<Fox_user_lampEO>> GetByLampIDAsync(int lampID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LampID` = @LampID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LampID", lampID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		#endregion // GetByLampID
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByAppIDAsync(string appID, int top_)
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
		public List<Fox_user_lampEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">appid</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByAppIDAsync(string appID, string sort_)
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
		public List<Fox_user_lampEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
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
		public List<Fox_user_lampEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		public async Task<List<Fox_user_lampEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Fox_user_lampEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Fox_user_lampEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Fox_user_lampEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		public async Task<List<Fox_user_lampEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Fox_user_lampEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Fox_user_lampEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Fox_user_lampEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		public async Task<List<Fox_user_lampEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByPlayerName
		
		/// <summary>
		/// 按 PlayerName（字段） 查询
		/// </summary>
		/// /// <param name = "playerName">中奖昵称</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByPlayerName(string playerName)
		{
			return GetByPlayerName(playerName, 0, string.Empty, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByPlayerNameAsync(string playerName)
		{
			return await GetByPlayerNameAsync(playerName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PlayerName（字段） 查询
		/// </summary>
		/// /// <param name = "playerName">中奖昵称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByPlayerName(string playerName, TransactionManager tm_)
		{
			return GetByPlayerName(playerName, 0, string.Empty, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByPlayerNameAsync(string playerName, TransactionManager tm_)
		{
			return await GetByPlayerNameAsync(playerName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PlayerName（字段） 查询
		/// </summary>
		/// /// <param name = "playerName">中奖昵称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByPlayerName(string playerName, int top_)
		{
			return GetByPlayerName(playerName, top_, string.Empty, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByPlayerNameAsync(string playerName, int top_)
		{
			return await GetByPlayerNameAsync(playerName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PlayerName（字段） 查询
		/// </summary>
		/// /// <param name = "playerName">中奖昵称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByPlayerName(string playerName, int top_, TransactionManager tm_)
		{
			return GetByPlayerName(playerName, top_, string.Empty, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByPlayerNameAsync(string playerName, int top_, TransactionManager tm_)
		{
			return await GetByPlayerNameAsync(playerName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PlayerName（字段） 查询
		/// </summary>
		/// /// <param name = "playerName">中奖昵称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByPlayerName(string playerName, string sort_)
		{
			return GetByPlayerName(playerName, 0, sort_, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByPlayerNameAsync(string playerName, string sort_)
		{
			return await GetByPlayerNameAsync(playerName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PlayerName（字段） 查询
		/// </summary>
		/// /// <param name = "playerName">中奖昵称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByPlayerName(string playerName, string sort_, TransactionManager tm_)
		{
			return GetByPlayerName(playerName, 0, sort_, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByPlayerNameAsync(string playerName, string sort_, TransactionManager tm_)
		{
			return await GetByPlayerNameAsync(playerName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PlayerName（字段） 查询
		/// </summary>
		/// /// <param name = "playerName">中奖昵称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByPlayerName(string playerName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PlayerName` = @PlayerName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlayerName", playerName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		public async Task<List<Fox_user_lampEO>> GetByPlayerNameAsync(string playerName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PlayerName` = @PlayerName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PlayerName", playerName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		#endregion // GetByPlayerName
		#region GetByReward
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">中奖金额</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByReward(long reward)
		{
			return GetByReward(reward, 0, string.Empty, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByRewardAsync(long reward)
		{
			return await GetByRewardAsync(reward, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">中奖金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByReward(long reward, TransactionManager tm_)
		{
			return GetByReward(reward, 0, string.Empty, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByRewardAsync(long reward, TransactionManager tm_)
		{
			return await GetByRewardAsync(reward, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">中奖金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByReward(long reward, int top_)
		{
			return GetByReward(reward, top_, string.Empty, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByRewardAsync(long reward, int top_)
		{
			return await GetByRewardAsync(reward, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">中奖金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByReward(long reward, int top_, TransactionManager tm_)
		{
			return GetByReward(reward, top_, string.Empty, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByRewardAsync(long reward, int top_, TransactionManager tm_)
		{
			return await GetByRewardAsync(reward, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">中奖金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByReward(long reward, string sort_)
		{
			return GetByReward(reward, 0, sort_, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByRewardAsync(long reward, string sort_)
		{
			return await GetByRewardAsync(reward, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">中奖金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByReward(long reward, string sort_, TransactionManager tm_)
		{
			return GetByReward(reward, 0, sort_, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByRewardAsync(long reward, string sort_, TransactionManager tm_)
		{
			return await GetByRewardAsync(reward, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Reward（字段） 查询
		/// </summary>
		/// /// <param name = "reward">中奖金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByReward(long reward, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Reward` = @Reward", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Reward", reward, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		public async Task<List<Fox_user_lampEO>> GetByRewardAsync(long reward, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Reward` = @Reward", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Reward", reward, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		#endregion // GetByReward
		#region GetByMultip
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">中奖总倍数</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByMultip(int multip)
		{
			return GetByMultip(multip, 0, string.Empty, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByMultipAsync(int multip)
		{
			return await GetByMultipAsync(multip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">中奖总倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByMultip(int multip, TransactionManager tm_)
		{
			return GetByMultip(multip, 0, string.Empty, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByMultipAsync(int multip, TransactionManager tm_)
		{
			return await GetByMultipAsync(multip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">中奖总倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByMultip(int multip, int top_)
		{
			return GetByMultip(multip, top_, string.Empty, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByMultipAsync(int multip, int top_)
		{
			return await GetByMultipAsync(multip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">中奖总倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByMultip(int multip, int top_, TransactionManager tm_)
		{
			return GetByMultip(multip, top_, string.Empty, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByMultipAsync(int multip, int top_, TransactionManager tm_)
		{
			return await GetByMultipAsync(multip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">中奖总倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByMultip(int multip, string sort_)
		{
			return GetByMultip(multip, 0, sort_, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByMultipAsync(int multip, string sort_)
		{
			return await GetByMultipAsync(multip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">中奖总倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByMultip(int multip, string sort_, TransactionManager tm_)
		{
			return GetByMultip(multip, 0, sort_, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByMultipAsync(int multip, string sort_, TransactionManager tm_)
		{
			return await GetByMultipAsync(multip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">中奖总倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByMultip(int multip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		public async Task<List<Fox_user_lampEO>> GetByMultipAsync(int multip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		#endregion // GetByMultip
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Fox_user_lampEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Fox_user_lampEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Fox_user_lampEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		public async Task<List<Fox_user_lampEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Fox_user_lampEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
