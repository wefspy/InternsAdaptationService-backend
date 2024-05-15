namespace InternsAdaptationService.Data.Interfaces.IRepositories.Parents;

public interface IRepository<T>
{
    public Task<T> CreateAsync(T request);

    public Task UpdateAsync(T request);

    public Task<IEnumerable<T>> GetAllAsync();

    public Task<T> GetByIdAsync(Guid id);

    public Task DeleteAsync(T requst);
}
