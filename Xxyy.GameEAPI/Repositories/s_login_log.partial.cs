using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Xxyy.DAL
{
    public partial class S_login_logPO
    {
        #region tinyfx
        public static implicit operator S_login_logEO(S_login_logPO value)
        {
            if (value==null) return null;
            return new S_login_logEO
            {
		        LogID = value.LogID,
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        AppID = value.AppID,
		        LoginDate = value.LoginDate,
		        LogoutDate = value.LogoutDate,
		        VersionID = value.VersionID,
		        LangID = value.LangID,
		        IsMobile = value.IsMobile,
		        OS = value.OS,
		        Browser = value.Browser,
		        Status = value.Status,
		        Message = value.Message,
		        UserIp = value.UserIp,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator S_login_logPO(S_login_logEO value)
        {
            if (value==null) return null;
            return new S_login_logPO
            {
		        LogID = value.LogID,
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        AppID = value.AppID,
		        LoginDate = value.LoginDate,
		        LogoutDate = value.LogoutDate,
		        VersionID = value.VersionID,
		        LangID = value.LangID,
		        IsMobile = value.IsMobile,
		        OS = value.OS,
		        Browser = value.Browser,
		        Status = value.Status,
		        Message = value.Message,
		        UserIp = value.UserIp,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}