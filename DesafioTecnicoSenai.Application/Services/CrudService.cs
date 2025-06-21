using DesafioTecnicoSenai.Application.Interfaces.Repositorios;
using DesafioTecnicoSenai.Application.Interfaces.Services;
using DesafioTecnicoSenai.Domain.Common;

namespace DesafioTecnicoSenai.Application.Services
{
    public class CrudService<TEntity> : BaseCrudService<TEntity>, ICrudService<TEntity> where TEntity : Entity
    {
        public CrudService(IBaseRepository<TEntity> repository) : base(repository)
        {
        }
    }
}
