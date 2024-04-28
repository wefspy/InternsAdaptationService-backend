using InternsAdaptationService.Data.Models;

namespace InternsAdaptationService.Infrastructure.Interfaces.IServices;

public interface IAuthService
{
    public Task RegisterWithEmailAndPasswordAsync(User user, string role, string password);

    public Task<(User, string)> SigninWithEmailAndPasswordAsync(string email, string password);

    public Task SignOutAsync();
}
