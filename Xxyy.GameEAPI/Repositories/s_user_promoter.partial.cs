using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Xxyy.DAL
{
    public partial class S_user_promoterPO
    {
        #region tinyfx
        public static implicit operator S_user_promoterEO(S_user_promoterPO value)
        {
            if (value==null) return null;
            return new S_user_promoterEO
            {
		        PUserID = value.PUserID,
		        IUserID = value.IUserID,
		        PromoteTime = value.PromoteTime,
		        UserKind = value.UserKind,
		        OperatorID = value.OperatorID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        CurrencyType = value.CurrencyType,
            };
        }
        public static implicit operator S_user_promoterPO(S_user_promoterEO value)
        {
            if (value==null) return null;
            return new S_user_promoterPO
            {
		        PUserID = value.PUserID,
		        IUserID = value.IUserID,
		        PromoteTime = value.PromoteTime,
		        UserKind = value.UserKind,
		        OperatorID = value.OperatorID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        CountryID = value.CountryID,
		        CurrencyID = value.CurrencyID,
		        CurrencyType = value.CurrencyType,
            };
        }
        #endregion
    }
}