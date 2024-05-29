using InternsAdaptationService.Infrastructure.DTO.RequestModels.User;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.User;
using Microsoft.AspNetCore.Identity;

namespace InternsAdaptationService.Infrastructure.Interfaces.IManagers.User;

public interface IUserManager
{
    public Task<UserResponseModel> GetByIdAsync(Guid id);

    public Task<IEnumerable<UserResponseModel>> GetAllAsync();

    public Task<IEnumerable<UserResponseModel>> GetInRoleAsync(string roleEnum);

    public Task UpdateAsync(Guid id, UserRequestModel request);

    public Task DeleteAsync(Guid id);
}
