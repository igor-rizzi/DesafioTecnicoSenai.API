using DesafioTecnicoSenai.Application.Models;
using DesafioTecnicoSenai.InfraFramework.Dependency;

namespace DesafioTecnicoSenai.Application.Interfaces.Services
{
    public interface IEmailQueueService : IScopedDependency
    {

        Task EnviarParaFilaAsync(EmailMessageDto mensagem);
    }
}
