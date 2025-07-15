using EmailWorker.Models;
using EmailWorker.Services;
using System.Text.Json;

namespace EmailWorker
{
    public class EmailWorkerService : BackgroundService
    {
        private readonly IRabbitMqService _rabbitMqService;
        private readonly IEmailSender _emailSender;

        public EmailWorkerService(IRabbitMqService rabbitMqService, IEmailSender emailSender)
        {
            _rabbitMqService = rabbitMqService;
            _emailSender = emailSender;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await _rabbitMqService.ConsumirFila(async (mensagem) =>
            {
                var email = JsonSerializer.Deserialize<EmailMessageDto>(mensagem);
                if (email is not null)
                {
                    await _emailSender.EnviarAsync(email);
                    Console.WriteLine($"[x] Email enviado para {email.Para}");
                }
            });
        }
    }
}
