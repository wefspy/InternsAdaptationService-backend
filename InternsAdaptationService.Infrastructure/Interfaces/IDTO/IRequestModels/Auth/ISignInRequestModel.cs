namespace InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Auth;

public interface ISignInRequestModel : IBaseRequestModel
{
    public string Password { get; }

    public string Email { get; }
}
