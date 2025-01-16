using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Super_phoenix.DAL
{
    ///<summary>
    ///初始基础配置
    ///</summary>
    [SugarTable("gsp_config")]
    public partial class Gsp_configPO
    {
           public Gsp_configPO(){

            this.IncomeRatio =0d;
            this.MiniGameRatio =0d;
            this.FreeSpinCount =0;
            this.FreeSpinTrigger =0;
            this.MEGA =0;
            this.SUPER =0;
            this.EPIC =0;

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
           /// Desc:小游戏分配
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public double MiniGameRatio {get;set;}

           /// <summary>
           /// Desc:freespin初始值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FreeSpinCount {get;set;}

           /// <summary>
           /// Desc:freespin触发值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FreeSpinTrigger {get;set;}

           /// <summary>
           /// Desc:跑马灯触发倍数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int BIG {get;set;}

           /// <summary>
           /// Desc:跑马灯触发倍数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int MEGA {get;set;}

           /// <summary>
           /// Desc:跑马灯触发倍数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SUPER {get;set;}

           /// <summary>
           /// Desc:跑马灯触发倍数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int EPIC {get;set;}

    }
}
