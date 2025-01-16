using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_reel_valuePO
    {
        #region tinyfx
        public static implicit operator Gmf_reel_valueEO(Gmf_reel_valuePO value)
        {
            if (value==null) return null;
            return new Gmf_reel_valueEO
            {
		        RValueID = value.RValueID,
		        Reel1 = value.Reel1,
		        Reel2 = value.Reel2,
		        Reel3 = value.Reel3,
		        Reel4 = value.Reel4,
		        Reel5 = value.Reel5,
            };
        }
        public static implicit operator Gmf_reel_valuePO(Gmf_reel_valueEO value)
        {
            if (value==null) return null;
            return new Gmf_reel_valuePO
            {
		        RValueID = value.RValueID,
		        Reel1 = value.Reel1,
		        Reel2 = value.Reel2,
		        Reel3 = value.Reel3,
		        Reel4 = value.Reel4,
		        Reel5 = value.Reel5,
            };
        }
        #endregion
    }
}