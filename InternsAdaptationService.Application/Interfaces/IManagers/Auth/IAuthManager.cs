using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Auth;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.User;

namespace InternsAdaptationService.Application.Interfaces.IManagers.Auth;

public interface IAuthManager
{
    public Task<IUserResponseModel> RegisterWithEmailAndPasswordAsync(IRegistrationRequestModel request);

    public Task<IUserResponseModel> SignInWithEmailAndPasswordAsync(ISignInRequestModel request);

    public Task SignOutAsync();

    public Task ChangePasswordAsync(Guid id, string oldPassword, string newPassword);
}
