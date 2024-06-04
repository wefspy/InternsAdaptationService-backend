using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels;

namespace InternsAdaptationService.Application.Interfaces.IManagers.Abstracts;

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
