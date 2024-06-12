using InternsAdaptationService.Data.Entities.Files;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Files;
using Microsoft.AspNetCore.Http;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Files;

public interface IFileMapper
{
    public FileEntity ToNewEntity(Guid taskId, IFormFile file);

    public IFileResponseModel ToResponse(FileEntity file);
}
