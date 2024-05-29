using InternsAdaptationService.Data.Entities.Auth;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Auth;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.User;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.User;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.User;

public interface IUserMapper
{
    public UserResponseModel ToResponse(UserEntity user, string role);

    public UserEntity ToNewEntity(RegistrationRequestModel requestModel);

    public UserEntity ToExistEntity(Guid id, UserRequestModel request);
}
