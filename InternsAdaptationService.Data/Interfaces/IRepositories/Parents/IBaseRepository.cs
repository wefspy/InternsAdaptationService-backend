using InternsAdaptationService.Data.Interfaces.IEntities.Parents;

namespace InternsAdaptationService.Data.Interfaces.IRepositories.Parents;

public interface IBaseRepository<TEntity> 
    where TEntity : IBaseEntity
{
    public Task<TEntity> CreateAsync(TEntity request);

    public Task UpdateAsync(TEntity request);

    public Task<IEnumerable<TEntity>> GetAllAsync();

    public Task<TEntity> GetByIdAsync(Guid id);

    public Task DeleteAsync(TEntity requst);
}
