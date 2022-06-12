using Shared.Helpers.Maths;
using System.Net.NetworkInformation;

namespace NetworkService.Util
{
    public class NetworkAnalyzer
    {
        private readonly ILogger<Worker> Log;
        private readonly List<string> _hostsArr;
        private readonly int _timeout;

        public NetworkAnalyzer(ILogger<Worker> logger, IConfiguration cfg)
        {
            Log = logger;
            try
            {
                _hostsArr = cfg.GetSection("Hosts").Get<List<string>>();
                //_hostsArr = cfg.GetValue<string[]>("Hosts");
                if (_hostsArr == null)
                    throw new ArgumentException("No hosts found: Configuration issue in appsettings");
                if (_hostsArr.Count == 0)
                    throw new ArgumentException("No hosts found: Empty list.");

                _timeout = cfg.GetValue<int>("Timeout");
            }
            catch (Exception e)
            {
                Log?.LogError(e, "Could not retrieve list of hosts from application configuration. Please verify Hosts under appsettings.");
            }
        }

        public async Task<List<(string host, IPStatus status, int ms)>> PingAllHosts()
        {
            List<(string host, IPStatus status, int ms)> responses = new();
            foreach (var item in _hostsArr)
                responses.Add(await PingHost(item));

            return responses;
        }

        public async Task<(string host, IPStatus status, int ms)> PingHost(string host)
        {
            var ping = new Ping();
            var reply = await ping.SendPingAsync(host, _timeout);

            return (host, reply.Status, (int)reply.RoundtripTime);
        }
    }
}
