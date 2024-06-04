using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Auth;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Auth;

public class SignInRequestModel: ISignInRequestModel
{
    public string Password { get; }

    public string Email { get; }

    public SignInRequestModel(string email, string password)
    {
        Password = password;
        Email = email;
    }
}
