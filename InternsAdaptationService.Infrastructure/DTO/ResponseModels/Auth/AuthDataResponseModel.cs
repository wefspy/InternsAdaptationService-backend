using InternsAdaptationService.Infrastructure.DTO.TransferModels;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Auth;

public class AuthDataResponseModel: UserTransferModel
{
    public Guid Id { get; }

    public string Role { get; }

    public AuthDataResponseModel(Guid id, string role, string name, string surname, string middleName, string desciptionProfile, string telegram, string vk) :
        base(name, surname, middleName, desciptionProfile, telegram, vk)
    {
        Id = id;
        Role = role;
    }
}
