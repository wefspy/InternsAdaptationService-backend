using InternsAdaptationService.Data.Enums;
using InternsAdaptationService.Data.Entities;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Auth;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Auth;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers;

public class UserMapper : IUserMapper
{
    public AuthDataResponseModel ToResponse(UserEntity user, string role)
    {
        return new AuthDataResponseModel(user.Id, role, user.Name, user.Surname, user.MiddleName, user.DesciptionProfile, user.Telegram, user.VK);
    }

    public UserEntity ToEntity(RegistrationRequestModel requestModel)
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
}
