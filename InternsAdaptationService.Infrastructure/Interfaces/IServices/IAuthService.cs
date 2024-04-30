using InternsAdaptationService.Data.Entities;

namespace InternsAdaptationService.Infrastructure.Interfaces.IServices;

public interface IAuthService
{
    public Task<(UserEntity userEntity, string userRole)> RegisterWithEmailAndPasswordAsync(UserEntity user, string role, string password);

    public Task<(UserEntity userEntity, string userRole)> SigninWithEmailAndPasswordAsync(string email, string password);

    public Task SignOutAsync();
}
