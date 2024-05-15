using InternsAdaptationService.Data.Entities;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Auth;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Auth;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Auth;

public interface IUserMapper
{
    public AuthDataResponseModel ToResponse(UserEntity user, string role);

    public UserEntity ToEntity(RegistrationRequestModel requestModel);
}
