using DesafioTecnicoSenai.Application.Models;
using DesafioTecnicoSenai.InfraFramework.Dependency;

namespace DesafioTecnicoSenai.Application.Interfaces.Services
{
    public interface IColaboradorService : IScopedDependency
    {
        Task CriarColaboradorAsync(CriarColaboradorDto dto);
    }
}
