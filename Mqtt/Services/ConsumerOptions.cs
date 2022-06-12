using MassTransit;
using MassTransit.RabbitMqTransport;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mqtt.Services
{
    public class ConsumerOptions
    {
        internal List<Action<IServiceProvider, IRabbitMqBusFactoryConfigurator>> Actions { get; set; } = new List<Action<IServiceProvider, IRabbitMqBusFactoryConfigurator>>();

        public void AddQueue<THandler>(string queueName, bool durable = true, bool autoDelete = false, int? concurrencyLimit = null, ushort? prefetchCount = null, int? retries = null, int? retryIntervalS = null) where THandler : class, IConsumer
        {
            Actions.Add((services, a) =>
            {
                a.ReceiveEndpoint(queueName, ep =>
                {
                    ep.AutoDelete = autoDelete;
                    ep.Durable = durable;
                    if (prefetchCount.HasValue)
                        ep.PrefetchCount = prefetchCount.Value;

                    if (retries.HasValue)
                        ep.UseMessageRetry(r => r.Interval(retries.Value, TimeSpan.FromSeconds(retryIntervalS ?? 30)));

                    if (concurrencyLimit != null)
                        ep.UseConcurrencyLimit(concurrencyLimit.Value);

                    THandler GetHandler() => (THandler)ActivatorUtilities.GetServiceOrCreateInstance(services, typeof(THandler));
                    ep.Consumer<THandler>(GetHandler);
                });
            });
        }
    }
}
