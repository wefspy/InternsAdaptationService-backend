using InternsAdaptationService.Data.Entities.Auth;

namespace InternsAdaptationService.Data.Interfaces.IRepositories.User;

public interface IUserRepository
{
    public Task<UserEntity> GetByIdAsync(Guid id);

    public Task<IEnumerable<UserEntity>> GetAllAsync();
}
