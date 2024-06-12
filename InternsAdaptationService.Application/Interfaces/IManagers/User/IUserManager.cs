

using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.User;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.User;

namespace InternsAdaptationService.Application.Interfaces.IManagers.User;

public interface IUserManager
{
    public Task<IUserResponseModel> GetByIdAsync(Guid id);

    public Task<IEnumerable<IUserResponseModel>> GetAllAsync();

    public Task<IEnumerable<IUserResponseModel>> GetInRoleAsync(string roleEnum);

    public Task UpdateAsync(Guid id, IUserRequestModel request);

    public Task UpdateUrlAsync(Guid id, string url);

    public Task DeleteAsync(Guid id);
}
