To use the Mqtt Pub/Sub function, add the following configuration to the appsettings file:


"RabbitMq": {
    "Server": "serverhost",
    "User": "username",
    "Pass": "password"

And ensure the RabbitMq broker is set up properly

Add this library to the program that needs Mqtt handling, and add a consumer:

services.AddMqConsumer(mq =>
{
    mq.AddQueue<IncomingHandler>("ServiceName.Incomming");
});

The IncomingHandler in this context contains the class:

public async Task Consume(ConsumeContext<ParameterListReceived2> context)
{
    // Do stuff here
}

MassTransit may be required(?)