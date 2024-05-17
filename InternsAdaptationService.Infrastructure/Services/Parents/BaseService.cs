using InternsAdaptationService.Data.Interfaces.IEntities.Parents;
using InternsAdaptationService.Data.Interfaces.IRepositories.Parents;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Parents;

namespace InternsAdaptationService.Infrastructure.Services.Parents;

public class BaseService<TEntity> : IBaseService<TEntity> 
    where TEntity : IBaseEntity
{
    private readonly IBaseRepository<TEntity> _repository;

    public BaseService(IBaseRepository<TEntity> repository)
    {
        _repository = repository;
    }

    public virtual async Task<TEntity> CreateAsync(TEntity entity)
    {
        return await _repository.CreateAsync(entity);
    }

    public virtual async Task UpdateAsync(TEntity entity)
    {
        await _repository.UpdateAsync(entity);
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public virtual async Task<TEntity> GetByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        var existEntity = await GetByIdAsync(id);

        await _repository.DeleteAsync(existEntity);
    }
}
