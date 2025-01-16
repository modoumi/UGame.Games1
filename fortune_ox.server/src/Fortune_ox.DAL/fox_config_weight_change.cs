using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Fortune_ox.DAL
{
    ///<summary>
    ///不中奖牌面
    ///</summary>
    [SugarTable("fox_config_weight_change")]
    public partial class Fox_config_weight_changePO
    {
           public Fox_config_weight_changePO(){


           }
           /// <summary>
           /// Desc:轴1
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Y1 {get;set;}

           /// <summary>
           /// Desc:轴2
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Y2 {get;set;}

           /// <summary>
           /// Desc:轴3
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Y3 {get;set;}

    }
}
