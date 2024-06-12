using InternsAdaptationService.Data.Entities.Files;
using Microsoft.AspNetCore.Http;

namespace InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Files;

public interface IFileRequestModel : IBaseRequestModel
{
    public FileEntity Entity { get; }

    public IFormFile File { get; }
}
