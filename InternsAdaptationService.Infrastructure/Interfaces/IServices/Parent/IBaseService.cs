namespace InternsAdaptationService.Infrastructure.Interfaces.IServices.Parent;

public interface IBaseService<TEntity> where TEntity : class
{
    public Task<TEntity> CreateAsync(TEntity entity);

    public Task UpdateAsync(TEntity entity);

    public Task<IEnumerable<TEntity>> GetAllAsync();

    public Task<TEntity> GetByIdAsync(Guid id);

    public Task DeleteAsync(Guid id);
}
