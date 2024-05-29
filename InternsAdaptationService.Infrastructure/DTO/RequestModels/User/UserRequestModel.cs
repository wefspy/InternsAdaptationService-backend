using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.User;

public class UserRequestModel : IBaseRequestModel
{
    public string Name { get; }

    public string Surname { get; }

    public string? MiddleName { get; }

    public string? DesciptionProfile { get; }

    public string? Telegram { get; }

    public string? VK { get; }

    public UserRequestModel(string name, string surname, string? middleName, string? desciptionProfile, string? telegram, string? vk)
    {
        Name = name;
        Surname = surname;
        MiddleName = middleName;
        DesciptionProfile = desciptionProfile;
        Telegram = telegram;
        VK = vk;
    }
}
