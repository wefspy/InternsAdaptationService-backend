using InternsAdaptationService.Data.Entities.Auth;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.User;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Auth;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.User;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.User;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Auth;

public class UserMapper : IUserMapper
{
    public IUserResponseModel ToResponse(UserEntity user)
    {
        return new UserResponseModel(user.Id, user.Role, user.Email!, user.Name, user.Surname, user.MiddleName, user.DesciptionProfile,
            user.Telegram, user.VK);
    }

    public UserEntity ToNewEntity(IRegistrationRequestModel requestModel)
    {
        return new UserEntity
        {
            Id = Guid.NewGuid(),
            UserName = requestModel.Email,
            Email = requestModel.Email,
            Role = requestModel.Role,
            Name = requestModel.Name,
            Surname = requestModel.Surname,
            MiddleName = requestModel.MiddleName,
        };
    }
}
