using InternsAdaptationService.Data.Entities.Auth;
using InternsAdaptationService.Data.Interfaces.IRepositories.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace InternsAdaptationService.Infrastructure.Services.User;

public class UserService : UserManager<UserEntity>
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository, IUserStore<UserEntity> store, IOptions<IdentityOptions> optionsAccessor,
                             IPasswordHasher<UserEntity> passwordHasher, IEnumerable<IUserValidator<UserEntity>> userValidators,
                             IEnumerable<IPasswordValidator<UserEntity>> passwordValidators, ILookupNormalizer keyNormalizer,
                             IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<UserEntity>> logger)
        : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
    {
        _userRepository = userRepository;
    }

    public async Task<UserEntity> GetUserByIdAsync(Guid id)
    {
        return await _userRepository.GetByIdAsync(id);
    }
}
