using InternsAdaptationService.Data.Entities;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Auth;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Auth;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers;

public interface IUserMapper
{
    public AuthDataResponseModel ToAuthDataResponseModel(UserEntity user, string role);

    public UserEntity ToUserEntity(RegistrationRequestModel requestModel);
}
