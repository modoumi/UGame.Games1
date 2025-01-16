using Xxyy.GameEAPI;

namespace Mexico_fortune.BLL
{
    public class GameServer : GameServerBase<GameSection>
    {
        protected override Task DoStartAsync(CancellationToken stoppingToken)
        {
            return Task.CompletedTask;
        }

        protected override Task DoStopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
