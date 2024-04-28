using InternsAdaptationService.Data.Enums;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Auth;

public class RegistrationRequestModel: SignInRequestModel
{
    public string Name { get; }

    public string Surname { get; }

    public string MiddleName { get; }

    public string Role { get; }

    public RegistrationRequestModel(string email, string password, string name, string surname, string middleName, string role):
        base(email, password)
    {
        Name = name;
        Surname = surname;
        MiddleName = middleName;
        Role = role;
    }
}
