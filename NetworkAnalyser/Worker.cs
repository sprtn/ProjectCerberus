using Shared.ProjectClasses;

namespace NetworkAnalyser
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _configuration;
        private readonly ReleaseVersion _releaseVersion;

        public Worker(ILogger<Worker> logger, IConfiguration iconfig)
        {
            _logger = logger;
            _configuration = iconfig;
            var releaseVersion = _configuration.GetSection("Version");

            var version = _configuration.GetSection("Version");
            _releaseVersion = new ReleaseVersion(releaseVersion.GetValue<int>("Major"), releaseVersion.GetValue<int>("Minor"));
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Running version {version}", _releaseVersion.ToString());
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            while (!stoppingToken.IsCancellationRequested)
            {
                if (DateTime.Now.Second == 0)
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}