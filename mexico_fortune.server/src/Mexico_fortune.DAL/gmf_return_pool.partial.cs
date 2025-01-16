using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_return_poolPO
    {
        #region tinyfx
        public static implicit operator Gmf_return_poolEO(Gmf_return_poolPO value)
        {
            if (value==null) return null;
            return new Gmf_return_poolEO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        Value = value.Value,
            };
        }
        public static implicit operator Gmf_return_poolPO(Gmf_return_poolEO value)
        {
            if (value==null) return null;
            return new Gmf_return_poolPO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        Value = value.Value,
            };
        }
        #endregion
    }
}