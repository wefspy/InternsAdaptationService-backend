using InternsAdaptationService.Data.Entities.Files;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Files;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Files;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Files;
using Microsoft.AspNetCore.Http;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Files;

public class FileMapper : IFileMapper
{
    public FileEntity ToNewEntity(Guid taskId, IFormFile file)
    {
        var name = Path.GetFileNameWithoutExtension(file.FileName);
        var extension = Path.GetExtension(file.FileName);
        var id = Guid.NewGuid();
        var url = $"http://localhost:5045/uploads/{id}/{file.FileName}";

        return new FileEntity
        {
            Id = id,
            TaskId = taskId,
            Name = name,
            Extension = extension,
            Url = url,
            UploadTime = DateTime.UtcNow,
        };
    }

    public IFileResponseModel ToResponse(FileEntity file)
    {
        return new FileResponseModel(file.Id, file.TaskId, file.Name, file.Extension, file.Url, file.UploadTime);
    }
}
