using InternsAdaptationService.Data.Entities.Auth;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Auth;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.User;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.User;

public interface IUserMapper
{
    public IUserResponseModel ToResponse(UserEntity user);

    public UserEntity ToNewEntity(IRegistrationRequestModel requestModel);
}
