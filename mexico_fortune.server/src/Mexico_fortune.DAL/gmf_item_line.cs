using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("gmf_item_line")]
    public partial class Gmf_item_linePO
    {
           public Gmf_item_linePO(){

            this.HitNum =0;
            this.Multip =0;

           }
           /// <summary>
           /// Desc:项编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long ItemID {get;set;}

           /// <summary>
           /// Desc:线编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int LineId {get;set;}

           /// <summary>
           /// Desc:Symbol编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int HitId {get;set;}

           /// <summary>
           /// Desc:重复数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int HitNum {get;set;}

           /// <summary>
           /// Desc:倍率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Multip {get;set;}

    }
}
