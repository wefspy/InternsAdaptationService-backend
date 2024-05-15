using InternsAdaptationService.Data.Interfaces.IRepositories.Parents;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Parent;

namespace InternsAdaptationService.Infrastructure.Services.Pattern;

public class BaseService<TEntity>: IBaseService<TEntity> where TEntity : class
{
    private readonly IBaseRepository<TEntity> _repository;

    public BaseService(IBaseRepository<TEntity> repository)
    {
        _repository = repository;
    }

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        return await _repository.CreateAsync(entity);
    }

    public async Task UpdateAsync(TEntity entity)
    {
        await _repository.UpdateAsync(entity);
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<TEntity> GetByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task DeleteAsync(Guid id)
    {
        var existEntity = await GetByIdAsync(id);

        await _repository.DeleteAsync(existEntity);
    }
}
