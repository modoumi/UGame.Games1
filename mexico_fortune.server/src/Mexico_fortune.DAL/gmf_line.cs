using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///bingo中奖线
    ///</summary>
    [SugarTable("gmf_line")]
    public partial class Gmf_linePO
    {
           public Gmf_linePO(){

            this.Row1 =0;
            this.Row2 =0;
            this.Row3 =0;
            this.Row4 =0;
            this.Row5 =0;

           }
           /// <summary>
           /// Desc:线编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int LineID {get;set;}

           /// <summary>
           /// Desc:行1
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Row1 {get;set;}

           /// <summary>
           /// Desc:行2
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Row2 {get;set;}

           /// <summary>
           /// Desc:行3
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Row3 {get;set;}

           /// <summary>
           /// Desc:行4
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Row4 {get;set;}

           /// <summary>
           /// Desc:行5
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Row5 {get;set;}

    }
}
