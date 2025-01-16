using Xxyy.GameEAPI.Common;

namespace Xxyy.GameEAPI
{
    public abstract class GameServerBase<TSection> : AppHostedService<TSection>
        where TSection : GameSectionBase, new()
    {
        public GameServerBase()
        {
        }
    }
}
