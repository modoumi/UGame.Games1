﻿using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_ox.DAL
{
    ///<summary>
    ///初始基础配置
    ///</summary>
    [SugarTable("fox_config")]
    public partial class Fox_configPO
    {
           public Fox_configPO(){

            this.IncomeRatio =0d;
            this.HHSWRatio =0d;

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
           /// Desc:小玩法进入概率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public double HHSWRatio {get;set;}

           /// <summary>
           /// Desc:跑马灯触发倍数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TriggerLampMultip {get;set;}

           /// <summary>
           /// Desc:初始牌面
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? DefaultSlotArray {get;set;}

           /// <summary>
           /// Desc:倍率集合
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? MultipArray {get;set;}

    }
}
