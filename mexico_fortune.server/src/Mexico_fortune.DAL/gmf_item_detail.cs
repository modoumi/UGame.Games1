using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///明细
    ///</summary>
    [SugarTable("gmf_item_detail")]
    public partial class Gmf_item_detailPO
    {
           public Gmf_item_detailPO(){

            this.S1 =0;
            this.S2 =0;
            this.S3 =0;
            this.S4 =0;
            this.S5 =0;

           }
           /// <summary>
           /// Desc:项编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long ItemID {get;set;}

           /// <summary>
           /// Desc:行编码012
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int RowIndex {get;set;}

           /// <summary>
           /// Desc:轴1
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int S1 {get;set;}

           /// <summary>
           /// Desc:轴2
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int S2 {get;set;}

           /// <summary>
           /// Desc:轴3
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int S3 {get;set;}

           /// <summary>
           /// Desc:轴4
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int S4 {get;set;}

           /// <summary>
           /// Desc:轴5
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int S5 {get;set;}

    }
}
