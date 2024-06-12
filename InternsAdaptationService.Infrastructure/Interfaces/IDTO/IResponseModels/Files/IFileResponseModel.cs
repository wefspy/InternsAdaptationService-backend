namespace InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Files;

public interface IFileResponseModel : IBaseResponseModel
{
    public Guid TaskId { get; }

    public string Name { get; }

    public string Extension { get; }

    public string Url { get; }

    public DateTime UploadTime { get; }
}
