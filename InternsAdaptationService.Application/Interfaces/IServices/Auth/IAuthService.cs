using InternsAdaptationService.Data.Entities.Auth;

namespace InternsAdaptationService.Application.Interfaces.IServices.Auth;

public interface IAuthService
{
    public Task<UserEntity> RegisterWithEmailAndPasswordAsync(UserEntity user, string password);

    public Task<UserEntity> SigninWithEmailAndPasswordAsync(string email, string password);

    public Task SignOutAsync();

    public Task ChangePasswordAsync(Guid id, string oldPassword, string newPassword);
}

