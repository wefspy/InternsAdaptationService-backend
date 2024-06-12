using InternsAdaptationService.Infrastructure.DTO.RequestModels.User;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.User;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.User;

public class UserResponseModel : UserRequestModel, IUserResponseModel
{
    public Guid Id { get; }

    public string Role { get; }

    public string Email { get; }

    public UserResponseModel(Guid id, string role, string email, string name, string surname, string? middleName, string? url, string? desciptionProfile, string? telegram, string? vk) :
        base(name, surname, middleName, url, desciptionProfile, telegram, vk)
    {
        Id = id;
        Role = role;
        Email = email;
    }
}
