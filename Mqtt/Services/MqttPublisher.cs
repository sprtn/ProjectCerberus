using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EnvoMq.Services
{
    public interface IMqttPublisher
    {
        Task Publish<T>(T message);
    }

    public class MqttPublisher : IDisposable, IMqttPublisher
    {
        private readonly IBusControl BusControl;
        private readonly ILogger<MqttPublisher> Log;

        public MqttPublisher(IConfiguration config, ILogger<MqttPublisher> log) : this(log, config["RabbitMq:Server"], config["RabbitMq:User"], config["RabbitMq:Pass"])
        {
        }

        public MqttPublisher(string server, string user, string pass) : this(null, server, user, pass)
        {
        }

        public MqttPublisher(ILogger<MqttPublisher> log, string server, string user, string pass)
        {
            if (log != null)
            {
                Log = log;
                //MassTransit.Context.LogContext.ConfigureCurrentLogContext(Log);
            }

            BusControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                Log?.LogInformation("Connecting to rabbitmq publisher: {server}", server);

                cfg.Host("rabbitmq://" + server, (hostcfg) =>
                {
                    hostcfg.Username(user);
                    hostcfg.Password(pass);
                });
            });

            StartBus(server);
        }

        private void StartBus(string server)
        {
            Log?.LogInformation("Starting buscontrol rabbitmq publisher: {server}", server);

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    BusControl.Start(new TimeSpan(0, 1, 0));

                    Log?.LogInformation("Connected to rabbitmq publisher: {server}", server);
                    return;
                }
                catch (Exception e)
                {
                    Log?.LogError(e, "MqPublisher BusControl not started! Server={server}, count={attempts}", server, i);
                }
            }

            Log?.LogCritical("MqPublisher BusControl not started! Server={server}", server);
            throw new ConnectionException("BusControl failed to establish connection with RabbitMq publisher!");
        }

        public void Dispose()
        {
            BusControl?.Stop();
            Log?.LogInformation("Stopped RabbitMQ publisher connection");
        }

        public async Task Publish<T>(T message)
        {
            if (message != null)
                await BusControl.Publish(message);
        }
    }
}
