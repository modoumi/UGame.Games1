using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mexico_fortune.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gmf_bingo_num_weightPO
    {
        #region tinyfx
        public static implicit operator Gmf_bingo_num_weightEO(Gmf_bingo_num_weightPO value)
        {
            if (value==null) return null;
            return new Gmf_bingo_num_weightEO
            {
		        BingoNum = value.BingoNum,
		        Weight = value.Weight,
            };
        }
        public static implicit operator Gmf_bingo_num_weightPO(Gmf_bingo_num_weightEO value)
        {
            if (value==null) return null;
            return new Gmf_bingo_num_weightPO
            {
		        BingoNum = value.BingoNum,
		        Weight = value.Weight,
            };
        }
        #endregion
    }
}