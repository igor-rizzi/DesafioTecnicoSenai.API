using DesafioTecnicoSenai.Application.Interfaces.Repositorios;
using DesafioTecnicoSenai.Domain.Common;

namespace DesafioTecnicoSenai.Application.Services
{
    public class CrudService<TEntity> : ICrudService<TEntity> where TEntity : Entity
    {
        private readonly IRepository<TEntity> _repository;

        public CrudService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual async Task<TEntity> GetByIdAsync(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public virtual async Task<TEntity> GetFirstAsync()
        {
            return await _repository.GetFirstAsync();
        }

        public virtual async Task<TEntity> Insert(TEntity entity)
        {

            _repository.Add(entity);

            await _repository.SaveChangesAsync();

            return entity;
        }

        public async Task SaveChangesAsync()
        {
            await _repository.SaveChangesAsync();
        }
        
        public virtual async Task<TEntity> Save(TEntity entity)
        {
            if (entity.Id > 0)
                return await Update(entity);

            return await Insert(entity);
        }

        public virtual async Task DeleteAndSaveAsync(long id)
        {
            try
            {

                _repository.Remove(id);

                await _repository.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro ao remover o registro, entre em contato com a administração.");
            }
        }

        public virtual async Task Delete(TEntity entity)
        {
            try
            {
                _repository.Remove(entity);
                await _repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao remover o registro, entre em contato com a administração.");
            }

        }

        public virtual IQueryable<TEntity> GetAll()
        {
            var retorno = _repository.GetAll();
            return retorno;
        }

        public virtual IEnumerable<TEntity> Listar()
        {
            return GetAll();
        }

        public virtual TEntity Get(long id)
        {
            return _repository.Get(id);
        }

        public virtual TEntity GetAsNoTracking(long id)
        {
            return _repository.GetIdAsNoTracking(id);
        }

        public virtual async Task<TEntity> GetAsNoTrackingAsync(long id)
        {
            return await _repository.GetIdAsNoTrackingAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> UpdateAndSaveAsync(IEnumerable<TEntity> entities)
        {
            _repository.Update(entities);
            await _repository.SaveChangesAsync();

            return entities;
        }

        public virtual async Task<TEntity> Update(TEntity entity)
        {
            _repository.Update(entity);

            await _repository.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> UpdateAndSaveAsync(TEntity entities)
        {
            _repository.Update(entities);

            await _repository.SaveChangesAsync();

            return entities;
        }
    }
}
