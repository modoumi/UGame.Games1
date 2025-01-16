using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Xxyy.DAL
{
    public partial class S_channel_themesPO
    {
        #region tinyfx
        public static implicit operator S_channel_themesEO(S_channel_themesPO value)
        {
            if (value==null) return null;
            return new S_channel_themesEO
            {
		        ThemesID = value.ThemesID,
		        FlagType = value.FlagType,
		        FlagValue = value.FlagValue,
		        LogoUrl = value.LogoUrl,
            };
        }
        public static implicit operator S_channel_themesPO(S_channel_themesEO value)
        {
            if (value==null) return null;
            return new S_channel_themesPO
            {
		        ThemesID = value.ThemesID,
		        FlagType = value.FlagType,
		        FlagValue = value.FlagValue,
		        LogoUrl = value.LogoUrl,
            };
        }
        #endregion
    }
}