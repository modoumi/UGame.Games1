using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_retrigger_weightPO
    {
        #region tinyfx
        public static implicit operator Gmf_retrigger_weightEO(Gmf_retrigger_weightPO value)
        {
            if (value==null) return null;
            return new Gmf_retrigger_weightEO
            {
		        RetriggerNum = value.RetriggerNum,
		        Weight = value.Weight,
            };
        }
        public static implicit operator Gmf_retrigger_weightPO(Gmf_retrigger_weightEO value)
        {
            if (value==null) return null;
            return new Gmf_retrigger_weightPO
            {
		        RetriggerNum = value.RetriggerNum,
		        Weight = value.Weight,
            };
        }
        #endregion
    }
}