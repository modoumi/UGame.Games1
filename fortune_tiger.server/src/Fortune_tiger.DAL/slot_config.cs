using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_tiger.DAL
{
    ///<summary>
    ///初始基础配置
    ///</summary>
    [SugarTable("slot_config")]
    public partial class Slot_configPO
    {
           public Slot_configPO(){

            this.IncomeRatio =0d;
            this.MEGA =0;
            this.SUPER =0;
            this.EPIC =0;

           }
           /// <summary>
           /// Desc:appid
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string AppID {get;set;}

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

           /// <summary>
           /// Desc:权重A面[小玩法权重,特效展示权重]
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string WightA {get;set;}

           /// <summary>
           /// Desc:权重B面[小玩法权重,特效展示权重]
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string WightB {get;set;}

    }
}
