using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_rabbit.DAL
{
    ///<summary>
    ///初始基础配置
    ///</summary>
    [SugarTable("fra_config")]
    public partial class Fra_configPO
    {
           public Fra_configPO(){

            this.IncomeRatio =0d;
            this.SpecialModeRatio =0d;
            this.SpecialModeTurnNum =0;

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
           /// Desc:特殊玩法进入概率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public double SpecialModeRatio {get;set;}

           /// <summary>
           /// Desc:特殊模式下的配置[y1,y2,y3]
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string SpecialModeArray {get;set;}

           /// <summary>
           /// Desc:特殊玩法转动次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SpecialModeTurnNum {get;set;}

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
           public string MultipArray {get;set;}

    }
}
