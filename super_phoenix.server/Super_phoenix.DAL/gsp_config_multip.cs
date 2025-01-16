using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Super_phoenix.DAL
{
    ///<summary>
    ///倍率表
    ///</summary>
    [SugarTable("gsp_config_multip")]
    public partial class Gsp_config_multipPO
    {
           public Gsp_config_multipPO(){

            this.Multip3 =0;
            this.Multip4 =0;
            this.Multip5 =0;

           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ItemID {get;set;}

           /// <summary>
           /// Desc:icon类型1-普通,2-万能,3-scatter
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int IconType {get;set;}

           /// <summary>
           /// Desc:x3倍数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Multip3 {get;set;}

           /// <summary>
           /// Desc:x4倍数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Multip4 {get;set;}

           /// <summary>
           /// Desc:x5倍数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Multip5 {get;set;}

    }
}
