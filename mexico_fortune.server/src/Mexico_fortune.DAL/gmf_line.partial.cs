using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_linePO
    {
        #region tinyfx
        public static implicit operator Gmf_lineEO(Gmf_linePO value)
        {
            if (value==null) return null;
            return new Gmf_lineEO
            {
		        LineID = value.LineID,
		        Row1 = value.Row1,
		        Row2 = value.Row2,
		        Row3 = value.Row3,
		        Row4 = value.Row4,
		        Row5 = value.Row5,
            };
        }
        public static implicit operator Gmf_linePO(Gmf_lineEO value)
        {
            if (value==null) return null;
            return new Gmf_linePO
            {
		        LineID = value.LineID,
		        Row1 = value.Row1,
		        Row2 = value.Row2,
		        Row3 = value.Row3,
		        Row4 = value.Row4,
		        Row5 = value.Row5,
            };
        }
        #endregion
    }
}