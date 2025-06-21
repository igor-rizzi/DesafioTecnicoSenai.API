using DesafioTecnicoSenai.Domain.Common;
using DesafioTecnicoSenai.InfraFramework.Dependency;

namespace DesafioTecnicoSenai.Application
{
    public interface ICrudService<TEntity> : IScopedDependency where TEntity : Entity
    {
        Task<TEntity> GetFirstAsync();

        Task<TEntity> GetByIdAsync(long id);

        Task<TEntity> Insert(TEntity entity);

        Task SaveChangesAsync();

        Task<TEntity> UpdateAndSaveAsync(TEntity entities);

        Task<IEnumerable<TEntity>> UpdateAndSaveAsync(IEnumerable<TEntity> entities);

        Task<TEntity> Save(TEntity entity);

        Task DeleteAndSaveAsync(long id);

        IQueryable<TEntity> GetAll();

        IEnumerable<TEntity> Listar();

        TEntity Get(long id);

        TEntity GetAsNoTracking(long id);

        Task<TEntity> GetAsNoTrackingAsync(long id);
    }
}
