using EmailWorker.Models;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;

namespace EmailWorker.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailSettings _settings;

        public EmailSender(IOptions<EmailSettings> settings)
        {
            _settings = settings.Value;
        }

        public async Task EnviarAsync(EmailMessageDto mensagem)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_settings.Remetente));
            email.To.Add(MailboxAddress.Parse(mensagem.Para));
            email.Subject = mensagem.Assunto;

            var builder = new BodyBuilder
            {
                HtmlBody = mensagem.CorpoHtml
            };

            email.Body = builder.ToMessageBody();

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(_settings.SmtpHost, _settings.SmtpPort, MailKit.Security.SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_settings.Usuario, _settings.Senha);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
    }
}
