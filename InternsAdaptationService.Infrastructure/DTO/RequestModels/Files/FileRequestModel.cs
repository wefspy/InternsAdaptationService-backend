using InternsAdaptationService.Data.Entities.Files;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Files;
using Microsoft.AspNetCore.Http;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.Files;

public class FileRequestModel : IFileRequestModel
{
    public FileEntity Entity { get; }

    public IFormFile File { get; }

    public FileRequestModel(FileEntity entity, IFormFile file)
    {
        Entity = entity;
        File = file;
    }
}
