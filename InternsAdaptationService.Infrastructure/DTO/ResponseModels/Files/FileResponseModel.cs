using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Files;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Files;

public class FileResponseModel : IFileResponseModel
{
    public Guid Id { get; }

    public Guid TaskId { get; }

    public string Name { get; }

    public string Extension { get; }

    public string Url { get; }

    public DateTime UploadTime { get; }

    public FileResponseModel (Guid id, Guid taskId, string name, string extension, string url, DateTime uploadTime)
    {
        Id = id;
        TaskId = taskId;
        Name = name;
        Url = url;
        UploadTime = uploadTime;
        Extension = extension;
    }
}
