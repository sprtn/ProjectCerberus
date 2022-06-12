using EnvoMq;
using EnvoMq.Services;
using Microsoft.Extensions.DependencyInjection;
using Mqtt.Services;
using System;

namespace Mqtt
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddMqPublisher(this IServiceCollection services)
        {
            return services.AddSingleton<IMqttPublisher, MqttPublisher>();
        }

        public static IServiceCollection AddMqConsumer(this IServiceCollection services, Action<ConsumerOptions> options)
        {
            return services.Configure<ConsumerOptions>(options).AddHostedService<MqConsumer>();
        }
    }
}