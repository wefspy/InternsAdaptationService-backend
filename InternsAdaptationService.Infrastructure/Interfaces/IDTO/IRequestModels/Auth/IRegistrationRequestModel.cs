namespace InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Auth;

public interface IRegistrationRequestModel : ISignInRequestModel, IBaseRequestModel
{
    public string Name { get; }

    public string Surname { get; }

    public string MiddleName { get; }

    public string Role { get; }

}
