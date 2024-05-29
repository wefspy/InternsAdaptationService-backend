using InternsAdaptationService.Data.Entities.Auth;

namespace InternsAdaptationService.Infrastructure.Interfaces.IServices.Auth;

public interface IAuthService
{
    public Task<(UserEntity userEntity, string userRole)> RegisterWithEmailAndPasswordAsync(UserEntity user, string role, string password);

    public Task<(UserEntity userEntity, string userRole)> SigninWithEmailAndPasswordAsync(string email, string password);

    public Task SignOutAsync();

    public Task ChangePasswordAsync(Guid id, string oldPassword, string newPassword);
}
