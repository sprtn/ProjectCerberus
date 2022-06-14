using Shared.Helpers.Maths;
using System.Net.NetworkInformation;

namespace NetworkService.Util
{
    public class NetworkAnalyzer
    {
        private readonly ILogger<Worker> Log;
        private readonly List<string> _hostsArr;
        private Dictionary<string, List<int>> PingResultMsDictionary = new Dictionary<string, List<int>>();
        private Dictionary<string, List<bool>> PingResultStatusDictionary = new Dictionary<string, List<bool>>();
        private readonly int _timeout;
        public int SampleSize;

        public NetworkAnalyzer(ILogger<Worker> logger, IConfiguration cfg, int sampleSize)
        {
            Log = logger;
            _hostsArr = new List<string>();
            SampleSize = sampleSize;

            try
            {
                _hostsArr = cfg.GetSection("Hosts").Get<List<string>>();
                if (_hostsArr == null)
                    throw new ArgumentException("No hosts found: Configuration issue in appsettings");
                if (_hostsArr.Count == 0)
                    throw new ArgumentException("No hosts found: Empty list.");

                foreach (string host in _hostsArr)
                {
                    PingResultStatusDictionary.Add(host, new List<bool>());
                    PingResultMsDictionary.Add(host, new List<int>());
                }

                _timeout = cfg.GetValue<int>("Timeout");
            }
            catch (Exception e)
            {
                Log.LogError(e, "Could not retrieve list of hosts from application configuration. Please verify Hosts under appsettings.");
            }
        }

        public async Task<List<(string host, IPStatus status, int ms)>> PingAllHosts()
        {
            List<(string host, IPStatus status, int ms)> responses = new();
            foreach (var host in _hostsArr)
            {
                var result = await PingHost(host);
                responses.Add(result);

                if ((PingResultMsDictionary[host]?.Count ?? 0) > SampleSize)
                    PingResultMsDictionary[host].RemoveAt(0);
                PingResultMsDictionary[host].Add(result.ms);

                if (PingResultStatusDictionary[host].Count > SampleSize)
                    PingResultStatusDictionary[host].RemoveAt(0);
                PingResultStatusDictionary[host].Add(result.status == IPStatus.Success);
            }

            return responses;
        }

        public async Task<(string host, IPStatus status, int ms)> PingHost(string host)
        {
            var ping = new Ping();
            var reply = await ping.SendPingAsync(host, _timeout);

            return (host, reply.Status, (int)reply.RoundtripTime);
        }

        public double GetAverageMSForHost(string host) => PingResultMsDictionary?[host]?.Average() ?? 0;
        public double GetSuccessForHostPercentile(string host)
        {
            if (PingResultStatusDictionary.Count == 0)
                return 0.5;

            int numSuccess = PingResultStatusDictionary[host].Where(s => s.Equals(true)).Count();
            double returnVal = (double)numSuccess / (double)PingResultStatusDictionary[host].Count;
            return returnVal;
        }

        public int GetNumSamplesForHost(string host) => PingResultMsDictionary?[host]?.Count ?? 0;
    }
}
