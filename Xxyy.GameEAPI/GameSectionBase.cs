using Microsoft.Extensions.Configuration;
using Xxyy.GameEAPI.Common;

namespace Xxyy.GameEAPI
{
    public class GameSectionBase : AppSectionBase
    {
        #region 环境变量可配置d
        public override bool IsWSService => false;
        #endregion

        public override void Bind(IConfiguration configuration)
        {
            base.Bind(configuration);
        }
    }
}
