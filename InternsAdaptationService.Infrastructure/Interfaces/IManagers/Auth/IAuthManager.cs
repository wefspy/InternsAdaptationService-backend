using InternsAdaptationService.Infrastructure.DTO.RequestModels.Auth;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Auth;

namespace InternsAdaptationService.Infrastructure.Interfaces.IManagers.Auth;

public interface IAuthManager
{
    public Task<AuthDataResponseModel> RegisterWithEmailAndPasswordAsync(RegistrationRequestModel request);

    public Task<AuthDataResponseModel> SignInWithEmailAndPasswordAsync(SignInRequestModel request);

    public Task SignOutAsync();
}
