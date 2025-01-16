using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_multip_weightPO
    {
        #region tinyfx
        public static implicit operator Gmf_multip_weightEO(Gmf_multip_weightPO value)
        {
            if (value==null) return null;
            return new Gmf_multip_weightEO
            {
		        SNum = value.SNum,
		        Multip = value.Multip,
		        Weight = value.Weight,
		        HitRatio = value.HitRatio,
            };
        }
        public static implicit operator Gmf_multip_weightPO(Gmf_multip_weightEO value)
        {
            if (value==null) return null;
            return new Gmf_multip_weightPO
            {
		        SNum = value.SNum,
		        Multip = value.Multip,
		        Weight = value.Weight,
		        HitRatio = value.HitRatio,
            };
        }
        #endregion
    }
}