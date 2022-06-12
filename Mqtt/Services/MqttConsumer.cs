using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Mqtt.Services
{
    public class MqConsumer : IHostedService
    {
        private readonly IBusControl BusControl;
        private readonly ILogger<MqConsumer> Log;

        public MqConsumer(IConfiguration config, ILogger<MqConsumer> log, IOptions<ConsumerOptions> options, IServiceProvider services)
        {
            Log = log;
            //MassTransit.Context.LogContext.ConfigureCurrentLogContext(Log);

            BusControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                Log.LogInformation("Connecting to rabbitmq: {server}", config["RabbitMq:Server"]);

                cfg.Durable = true;
                cfg.Host("rabbitmq://" + config["RabbitMq:Server"], (hostcfg) =>
                {
                    hostcfg.Username(config["RabbitMq:User"]);
                    hostcfg.Password(config["RabbitMq:Pass"]);
                });

                Log?.LogInformation("Connected to rabbitmq consumer: {server}", config["RabbitMq:Server"]);

                foreach (var action in options.Value.Actions)
                    action(services, cfg);
            });
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await BusControl.StartAsync();
            Log?.LogInformation("Connection to rabbitmq consumer started");
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await BusControl.StopAsync();
            Log?.LogInformation("Connection to rabbitmq consumer stopped");
        }
    }
}
