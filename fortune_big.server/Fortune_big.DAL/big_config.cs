using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_big.DAL
{
    ///<summary>
    ///初始基础配置
    ///</summary>
    [SugarTable("big_config")]
    public partial class Big_configPO
    {
           public Big_configPO(){

            this.IncomeRatio =0d;
            this.FreeSpinNum =0;
            this.RespinNum =0;

           }
           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:货币编码（ISO 4217大写）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:税收分配
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public double IncomeRatio {get;set;}

           /// <summary>
           /// Desc:初始牌面
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string DefaultSlotArray {get;set;}

           /// <summary>
           /// Desc:倍率集合
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MultipleArray {get;set;}

           /// <summary>
           /// Desc:单线下注集合
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SingleBetArray {get;set;}

           /// <summary>
           /// Desc:FreeSpinNum
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FreeSpinNum {get;set;}

           /// <summary>
           /// Desc:RespinNum
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RespinNum {get;set;}

    }
}
