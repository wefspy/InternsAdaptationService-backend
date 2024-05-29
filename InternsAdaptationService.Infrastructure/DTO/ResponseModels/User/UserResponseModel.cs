using InternsAdaptationService.Infrastructure.DTO.RequestModels.User;
using InternsAdaptationService.Infrastructure.Interfaces.IResponseModels.Parents;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.User;

public class UserResponseModel : UserRequestModel, IBaseResponseModel
{
    public Guid Id { get; }

    public string Role { get; }

    public string Email { get; }

    public UserResponseModel(Guid id, string role, string email, string name, string surname, string middleName, string desciptionProfile, string telegram, string vk) :
        base(name, surname, middleName, desciptionProfile, telegram, vk)
    {
        Id = id;
        Role = role;
        Email = email;
    }
}
