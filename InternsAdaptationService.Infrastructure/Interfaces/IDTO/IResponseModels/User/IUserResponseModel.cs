using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.User;

namespace InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.User;

public interface IUserResponseModel : IUserRequestModel, IBaseResponseModel
{
    public string Role { get; }

    public string Email { get; }
}
