using EmailWorker.Models;

namespace EmailWorker.Services
{
    public interface IEmailSender
    {
        Task EnviarAsync(EmailMessageDto mensagem);
    }
}
