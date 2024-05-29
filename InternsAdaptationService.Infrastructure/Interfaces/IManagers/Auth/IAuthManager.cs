using InternsAdaptationService.Infrastructure.DTO.RequestModels.Auth;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.User;

namespace InternsAdaptationService.Infrastructure.Interfaces.IManagers.Auth;

public interface IAuthManager
{
    public Task<UserResponseModel> RegisterWithEmailAndPasswordAsync(RegistrationRequestModel request);

    public Task<UserResponseModel> SignInWithEmailAndPasswordAsync(SignInRequestModel request);

    public Task SignOutAsync();
}
