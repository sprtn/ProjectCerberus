using Shared.ProjectClasses;
using NetworkService.Util;

namespace NetworkService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> Log;
        private readonly IConfiguration _cfg;
        private readonly ReleaseVersion _releaseVersion;
        private NetworkAnalyzer Analyzer;

        public Worker(ILogger<Worker> logger, IConfiguration cfg)
        {
            Log = logger;
            _cfg = cfg;

            try
            {
                var releaseVersion = _cfg.GetSection("Version");
                _releaseVersion = new ReleaseVersion(releaseVersion.GetValue<int>("Major"), releaseVersion.GetValue<int>("Minor"));
            }
            catch (Exception e)
            {
                /// TODO: Add smoother error handling with retry
                Log.LogInformation("Fatal Error. Please verify appsettings configuration settings and restart the service.");
            }
            
            Analyzer = new(logger, cfg);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Log.LogInformation("Running version {version}", _releaseVersion.ToString());
            Log.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            while (!stoppingToken.IsCancellationRequested)
            {
                if (DateTime.Now.Second % _cfg.GetValue<int>("RunInterval") == 0)
                {
                    Log.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                    foreach (var item in await Analyzer.PingAllHosts())
                    {
                        switch (item.status)
                        {
                            case System.Net.NetworkInformation.IPStatus.Success:
                                Log.LogInformation($"Host {item.host} ping: {item.ms}ms");
                                break;
                            default:
                                Log.LogInformation($"Ping to Host {item.host} failed. Status: {item.status.ToString()}");
                                break;
                        }

                        /// Submit status to Loki / Prometheus statistics db
                    }
                }

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}