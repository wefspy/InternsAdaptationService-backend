namespace InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.User;

public interface IUserRequestModel : IBaseRequestModel
{
    public string Name { get; }

    public string Surname { get; }

    public string? MiddleName { get; }

    public string? DesciptionProfile { get; }

    public string? Telegram { get; }

    public string? VK { get; }

}
