using DesafioTecnicoSenai.Domain.Common;

namespace DesafioTecnicoSenai.Application.Interfaces.Services
{
    public interface ICrudService<TEntity> : IBaseCrudService<TEntity>
        where TEntity : Entity
    {
    }
}
