using InternsAdaptationService.Data.Interfaces.IEntities.Parents;

namespace InternsAdaptationService.Infrastructure.Interfaces.IServices.Parents;

public interface IBaseService<TEntity> 
    where TEntity : IBaseEntity
{
    public Task<TEntity> CreateAsync(TEntity entity);

    public Task UpdateAsync(TEntity entity);

    public Task<IEnumerable<TEntity>> GetAllAsync();

    public Task<TEntity> GetByIdAsync(Guid id);

    public Task DeleteAsync(Guid id);
}
