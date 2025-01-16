using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Xxyy.DAL
{
    public partial class S_app_langPO
    {
        #region tinyfx
        public static implicit operator S_app_langEO(S_app_langPO value)
        {
            if (value==null) return null;
            return new S_app_langEO
            {
		        AppID = value.AppID,
		        LangID = value.LangID,
		        IsSupport = value.IsSupport,
		        AppName = value.AppName,
		        AppDesc = value.AppDesc,
            };
        }
        public static implicit operator S_app_langPO(S_app_langEO value)
        {
            if (value==null) return null;
            return new S_app_langPO
            {
		        AppID = value.AppID,
		        LangID = value.LangID,
		        IsSupport = value.IsSupport,
		        AppName = value.AppName,
		        AppDesc = value.AppDesc,
            };
        }
        #endregion
    }
}