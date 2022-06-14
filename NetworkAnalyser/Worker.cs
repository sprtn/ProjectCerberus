using Shared.ProjectClasses;
using NetworkService.Util;

namespace NetworkService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> Log;
        private readonly IConfiguration _cfg;
        private readonly ReleaseVersion _releaseVersion;
        private readonly NetworkAnalyzer Analyzer;

        public Worker(ILogger<Worker> logger, IConfiguration cfg)
        {
            Log = logger;
            _cfg = cfg;
            _releaseVersion = new ReleaseVersion();

            try
            {
                var releaseVersion = _cfg.GetSection("Version");
                _releaseVersion = new ReleaseVersion(releaseVersion.GetValue<int>("Major"), releaseVersion.GetValue<int>("Minor"));
            }
            catch
            {
                /// TODO: Could add smoother error handling with retry
                Log.LogInformation("Error. Please verify appsettings configuration setting validity and restart the service to load settings properly.");
            }
            
            Analyzer = new(logger, cfg, _cfg.GetValue<int>("SampleSize"));
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Log.LogInformation($"Running version {_releaseVersion}");
            Log.LogInformation($"Worker running at: {DateTimeOffset.Now}");

            while (!stoppingToken.IsCancellationRequested)
            {
                if (DateTime.Now.Second % _cfg.GetValue<int>("RunInterval") == 0)
                {
                    Log.LogInformation($"Worker running at: {DateTimeOffset.Now}");
                    foreach (var item in await Analyzer.PingAllHosts())
                    {
                        switch (item.status)
                        {
                            case System.Net.NetworkInformation.IPStatus.Success:
                                Log.LogInformation($"Host: {item.host}: Average MS over {Analyzer.GetNumSamplesForHost(item.host)} samples is {Analyzer.GetAverageMSForHost(item.host):0.00}. Average success rate is {(Analyzer.GetSuccessForHostPercentile(item.host) * 100):0.00}%");
                                break;
                            default:
                                Log.LogInformation($"Ping to Host {item.host} failed. Status: {item.status}. ");
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