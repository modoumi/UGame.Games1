using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_bingo_weightPO
    {
        #region tinyfx
        public static implicit operator Gmf_bingo_weightEO(Gmf_bingo_weightPO value)
        {
            if (value==null) return null;
            return new Gmf_bingo_weightEO
            {
		        JPPoolID = value.JPPoolID,
		        Name = value.Name,
		        Multip = value.Multip,
		        Weight = value.Weight,
            };
        }
        public static implicit operator Gmf_bingo_weightPO(Gmf_bingo_weightEO value)
        {
            if (value==null) return null;
            return new Gmf_bingo_weightPO
            {
		        JPPoolID = value.JPPoolID,
		        Name = value.Name,
		        Multip = value.Multip,
		        Weight = value.Weight,
            };
        }
        #endregion
    }
}