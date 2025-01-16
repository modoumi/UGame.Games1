using Microsoft.Extensions.Configuration;
using Xxyy.GameEAPI;

namespace Fortune_tiger.BLL
{
    public class GameSection : GameSectionBase
    {
        public override void Bind(IConfiguration configuration)
        {
            base.Bind(configuration);
        }
    }
}
