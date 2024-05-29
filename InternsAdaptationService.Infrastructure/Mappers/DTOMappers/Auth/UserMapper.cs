using InternsAdaptationService.Infrastructure.DTO.RequestModels.Auth;
using InternsAdaptationService.Data.Entities.Auth;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.User;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.User;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.User;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Auth;

public class UserMapper : IUserMapper
{
    public UserResponseModel ToResponse(UserEntity user, string role)
    {
        return new UserResponseModel(user.Id, role, user.Email, user.Name, user.Surname, user.MiddleName, user.DesciptionProfile, user.Telegram, user.VK);
    }

    public UserEntity ToNewEntity(RegistrationRequestModel requestModel)
    {
        return new UserEntity
        {
            Id = Guid.NewGuid(),
            UserName = requestModel.Email,
            Email = requestModel.Email,
            Name = requestModel.Name,
            Surname = requestModel.Surname,
            MiddleName = requestModel.MiddleName,
        };
    }

    public UserEntity ToExistEntity(Guid id, UserRequestModel request)
    {
        return new UserEntity
        {
            Id = id,
            SecurityStamp = Guid.NewGuid().ToString(),
            Name = request.Name,
            Surname = request.Surname,
            MiddleName = request.MiddleName,
            DesciptionProfile = request.DesciptionProfile,
            Telegram = request.Telegram,
            VK = request.VK,
        };
    }
}
