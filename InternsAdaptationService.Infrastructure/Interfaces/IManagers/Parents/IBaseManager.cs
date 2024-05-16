namespace InternsAdaptationService.Infrastructure.Interfaces.IManagers.Parents;

public interface IBaseManager<TRequestModel, TResponseModel> 
    where TRequestModel : class
    where TResponseModel : class
{
    public Task<TResponseModel> CreateAsync(TRequestModel request);

    public Task UpdateAsync(Guid id, TRequestModel request);

    public Task<IEnumerable<TResponseModel>> GetAllAsync();

    public Task<TResponseModel> GetByIdAsync(Guid id);

    public Task DeleteAsync(Guid id);
}
