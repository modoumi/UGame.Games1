using Microsoft.Extensions.DependencyInjection;
using TinyFx.Configuration;
using Xxyy.GameEAPI;
using Xxyy.GameEAPI.Common;

namespace Microsoft.Extensions.Hosting
{
    public static class GameHostBuilderExtensions
    {
        public static IHostBuilder UseXxyyCommonServer<TSection>(this IHostBuilder builder)
          where TSection : AppSectionBase, new()
        {
            return builder.UseXxyyCommonServer<TSection, AppHostedService<TSection>>();
        }
        public static IHostBuilder UseXxyyCommonServer<TSection, TServer>(this IHostBuilder builder)
            where TSection : AppSectionBase, new()
            where TServer : AppHostedService<TSection>, new()
        {
            builder.ConfigureServices(services =>
            {
                var section = ConfigUtil.GetSection<TSection>();
                if (section == null)
                    throw new Exception("配置AppOptions不存在");
                services.AddSingleton<AppSectionBase>(section);
                services.AddSingleton(section);

                services.AddSingleton<TServer>();
                services.AddHostedService(provider => provider.GetRequiredService<TServer>());
            });
            return builder;
        }

        public static IHostBuilder UseApiGameServer<TSection, TServer>(this IHostBuilder builder)
            where TSection : GameSectionBase, new()
            where TServer : GameServerBase<TSection>, new()
        {
            builder.UseXxyyCommonServer<TSection, TServer>();
            var section = DIUtil.GetRequiredService<TSection>();
            builder.ConfigureHostOptions(opts =>
            {
                opts.ShutdownTimeout = TimeSpan.FromSeconds(section.ShutdownTimeout);
            });
            builder.ConfigureServices(services =>
            {
                services.AddSingleton<GameSectionBase>(section);
            });
            return builder;
        }

    }
}
