using EmailWorker.Models;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace EmailWorker.Services
{
    public class RabbitMqService : IRabbitMqService
    {
        private readonly RabbitSettings _settings;

        public RabbitMqService(IOptions<RabbitSettings> options)
        {
            _settings = options.Value;
        }

        public async Task ConsumirFila(Func<string, Task> onMessageReceived)
        {
            var factory = new ConnectionFactory
            {
                HostName = _settings.Host,
                Port = _settings.Port,
                UserName = _settings.User,
                Password = _settings.Password
            };

            var connection = await factory.CreateConnectionAsync("EmailWorker");
            var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(_settings.QueueName, durable: true, exclusive: false, autoDelete: false);

            var consumer = new AsyncEventingBasicConsumer(channel);
            consumer.ReceivedAsync += async (_, ea) =>
            {
                var body = Encoding.UTF8.GetString(ea.Body.ToArray());
                await onMessageReceived(body);

                await channel.BasicAckAsync(ea.DeliveryTag, multiple: false);
            };

            await channel.BasicConsumeAsync(queue: _settings.QueueName, autoAck: false, consumer: consumer);
        }
    }
}
