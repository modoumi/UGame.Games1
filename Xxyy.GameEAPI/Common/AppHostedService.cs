using Microsoft.Extensions.Hosting;
using TinyFx.Common;
using TinyFx.Configuration;
using TinyFx.Logging;
using Xxyy.GameEAPI.Caching;

namespace Xxyy.GameEAPI.Common
{
    public class AppHostedService<TSection> : BackgroundService
            where TSection : AppSectionBase, new()
    {
        protected TSection Section { get; }
        protected AppDCache AppDCache { get; set; }
      //  protected MultiTimerWorks TimerWorks { get; }
        public AppHostedService()
        {
            Section = DIUtil.GetRequiredService<TSection>();
            AppDCache = AppDCache.Create(Section.AppId);
            //TimerWorks = new MultiTimerWorks()
            //{
            //    WaitTasksTimeout = Section.ShutdownTimeout,
            //};
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            LogUtil.Info("{0} 服务准备启动...serverId: {1} appId: {2} serverUrl: {3}"
              , ConfigUtil.Project.ProjectId, Section.ServerId, Section.AppId, Section.ServerUrl);
            try
            {
               // var _ = TimerWorks.StartAsync(stoppingToken);
                await DoStartAsync(stoppingToken);//执行子类启动初始化

                // 注册GameServer服务
                // AppServerApiUrlDCache.Create().SetServerUrl(Section.AppId, Section.ServerType, null, Section.ServerUrl);
                LogUtil.Info("{0} 服务已经启动...serverId: {1} appId: {2} serverUrl: {3} env: {4}"
                  , ConfigUtil.Project.ProjectId, Section.ServerId, Section.AppId, Section.ServerUrl, ConfigUtil.Environment.Name);
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "{0} 执行时出现未处理异常...serverId: {1} appId: {2} serverUrl: {3} env: {4}"
                  , ConfigUtil.Project.ProjectId, Section.ServerId, Section.AppId, Section.ServerUrl, ConfigUtil.Environment.Name);
            }
        }
        protected virtual Task DoStartAsync(CancellationToken stoppingToken)
        { return Task.CompletedTask; }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            LogUtil.Info("{0} 服务准备停止...serverId: {1} appId: {2} serverUrl: {3}"
              , ConfigUtil.Project.ProjectId, Section.ServerId, Section.AppId, Section.ServerUrl);
            try
            {
                //await TimerWorks.StopAsync(cancellationToken); //结束TimerWorks任务
                // 执行子类停止方法
                await DoStartAsync(cancellationToken);
                await base.StopAsync(cancellationToken);
                LogUtil.Info("{0} 服务已经停止...serverId: {1} appId: {2} serverUrl: {3}"
                  , ConfigUtil.Project.ProjectId, Section.ServerId, Section.AppId, Section.ServerUrl);
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "{0} 停止时出现未处理异常...serverId: {1} appId: {2} serverUrl: {3}"
                  , ConfigUtil.Project.ProjectId, Section.ServerId, Section.AppId, Section.ServerUrl);
            }
        }
        protected virtual Task DoStopAsync(CancellationToken cancellationToken)
        { return Task.CompletedTask; }
    }
}
