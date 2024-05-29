using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;
using InternsAdaptationService.Infrastructure.Interfaces.IResponseModels.Parents;

namespace InternsAdaptationService.Infrastructure.Interfaces.IManagers.Abstracts;

public interface IBaseManager<TRequestModel, TResponseModel>
    where TRequestModel : IBaseRequestModel
    where TResponseModel : IBaseResponseModel
{
    public Task<TResponseModel> CreateAsync(TRequestModel request);

    public Task CreateRangeAsync(IEnumerable<TRequestModel> requests);

    public Task UpdateAsync(Guid id, TRequestModel request);

    public Task<IEnumerable<TResponseModel>> GetAllAsync();

    public Task<TResponseModel> GetByIdAsync(Guid id);

    public Task DeleteAsync(Guid id);

    public Task DeleteRangeAsync(IEnumerable<Guid> ids);
}
