using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Auth;

public class SignInRequestModel: IBaseRequestModel
{
    public string Password { get; }

    public string Email { get; }

    public SignInRequestModel(string email, string password)
    {
        Password = password;
        Email = email;
    }
}
