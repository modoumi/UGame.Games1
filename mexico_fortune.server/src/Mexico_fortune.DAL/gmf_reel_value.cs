using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mexico_fortune.DAL
{
    ///<summary>
    ///轴数据定义(1开始0为空)
    ///</summary>
    [SugarTable("gmf_reel_value")]
    public partial class Gmf_reel_valuePO
    {
           public Gmf_reel_valuePO(){

            this.Reel1 =0;
            this.Reel2 =0;
            this.Reel3 =0;
            this.Reel4 =0;
            this.Reel5 =0;

           }
           /// <summary>
           /// Desc:行编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int RValueID {get;set;}

           /// <summary>
           /// Desc:轴1
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Reel1 {get;set;}

           /// <summary>
           /// Desc:轴2
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Reel2 {get;set;}

           /// <summary>
           /// Desc:轴3
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Reel3 {get;set;}

           /// <summary>
           /// Desc:轴4
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Reel4 {get;set;}

           /// <summary>
           /// Desc:轴5
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Reel5 {get;set;}

    }
}
