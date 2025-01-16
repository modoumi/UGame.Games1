using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_tiger.DAL
{
    ///<summary>
    ///Btest 主轴配置
    ///</summary>
    [SugarTable("slot_config_base")]
    public partial class Slot_config_basePO
    {
           public Slot_config_basePO(){

            this.BaseName ="0";

           }
           /// <summary>
           /// Desc:SheelName
           /// Default:0
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string BaseName {get;set;}

           /// <summary>
           /// Desc:第几列
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int BaseColumn {get;set;}

           /// <summary>
           /// Desc:权重值
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string BaseText {get;set;}

    }
}
