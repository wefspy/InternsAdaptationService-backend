using InternsAdaptationService.Data.Entities.Abstracts;

namespace InternsAdaptationService.Data.Entities.Files;

public class FileEntity : BaseEntity
{
    public required Guid TaskId { get; set; }

    public required string Name { get; set; }

    public required string Extension { get; set; }

    public required string Url { get; set; }

    public required DateTime UploadTime { get; set; }
}