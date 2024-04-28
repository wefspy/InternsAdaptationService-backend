using InternsAdaptationService.Data.Enums;
using InternsAdaptationService.Data.Models;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Auth;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Auth;

namespace InternsAdaptationService.Infrastructure.Mappers;

public static class UserMapper
{
    public static AuthDataResponseModel ToAuthDataResponseModel(User user, string role)
    {
        return new AuthDataResponseModel(user.Id, role, user.Name, user.Surname, user.MiddleName, user.DesciptionProfile, user.Telegram, user.VK);
    }

    public static User ToUserModel(RegistrationRequestModel requestModel)
    {
        return new User
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
