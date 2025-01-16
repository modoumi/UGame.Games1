using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///symbol定义
    ///</summary>
    [SugarTable("gmf_symbol")]
    public partial class Gmf_symbolPO
    {
           public Gmf_symbolPO(){

            this.Type =0;
            this.IsNormal =false;
            this.IsWild =false;
            this.IsBonus =false;
            this.IsBingo =false;

           }
           /// <summary>
           /// Desc:Symbol编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int SymbolID {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Name {get;set;}

           /// <summary>
           /// Desc:1-normal,2-wild,3-bonus 4-bingo 5-andFreeSpin
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Type {get;set;}

           /// <summary>
           /// Desc:是否普通Symbol
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsNormal {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsWild {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsBonus {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsBingo {get;set;}

    }
}
