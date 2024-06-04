using InternsAdaptationService.Application.Interfaces.IServices.Abstracts;
using InternsAdaptationService.Data.Interfaces.IEntities.Parents;
using InternsAdaptationService.Data.Interfaces.IRepositories.Abstracts;


namespace InternsAdaptationService.Application.Services.Abstracts;

public abstract class BaseService<TEntity> : IBaseService<TEntity>
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

    public virtual async Task CreateRangeAsync(IEnumerable<TEntity> entities)
    {
        await _repository.CreateRangeAsync(entities);
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

    public virtual async Task DeleteRangeAsync(IEnumerable<Guid> ids)
    {
        var entities = ids
            .Select(id => GetByIdAsync(id).Result);

        await _repository.DeleteRangeAsync(entities);
    }

    public virtual async Task SaveAsync()
    {
        await _repository.SaveAsync();
    }
}
