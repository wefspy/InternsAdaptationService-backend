using InternsAdaptationService.Application.Interfaces.IManagers.Files;
using InternsAdaptationService.Application.Interfaces.IServices.Files;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Files;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Files;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Files;
using Microsoft.AspNetCore.Http;

namespace InternsAdaptationService.Application.Managers.Files;

public class FileManager : IFileManager
{
    private readonly IFileService _fileService;
    private readonly IFileMapper _fileMapper;

    public FileManager(IFileService fileService, IFileMapper fileMapper)
    {
        _fileService = fileService;
        _fileMapper = fileMapper;
    }

    public async Task<IFileResponseModel> CreateAsync(Guid taskId, IFormFile file)
    {
        var entity = _fileMapper.ToNewEntity(taskId, file);
        var request = new FileRequestModel(entity, file);

        var createdEntity = await _fileService.CreateAsync(request);

        await _fileService.SaveAsync();

        return _fileMapper.ToResponse(createdEntity);
    }

    public async Task<IEnumerable<IFileResponseModel>> CreateRangeAsync(Guid taskId, IEnumerable<IFormFile> files)
    {
        var requests = files.Select(file => 
        {
            var entity = _fileMapper.ToNewEntity(taskId, file);
            return new FileRequestModel(entity, file);
        });

        var createdEntities = _fileService.CreateRangeAsync(requests);

        await _fileService.SaveAsync();

        return createdEntities.Select(entity => _fileMapper.ToResponse(entity));
    }

    public async Task DeleteAsync(Guid id)
    {
        await _fileService.DeleteAsync(id);

        await _fileService.SaveAsync();
    }

    public async Task DeleteRangeAsync(IEnumerable<Guid> ids)
    {
        await _fileService.DeleteRangeAsync(ids);

        await _fileService.SaveAsync();
    }

    public async Task<IEnumerable<IFileResponseModel>> GetAllAsync()
    {
        var entities = await _fileService.GetAllAsync();

        return entities.Select(entity => _fileMapper.ToResponse(entity));
    }

    public async Task<IFileResponseModel> GetByIdAsync(Guid id)
    {
        var entity = await _fileService.GetByIdAsync(id);

        return _fileMapper.ToResponse(entity);
    }

    public async Task<IEnumerable<IFileResponseModel>> GetByTaskId(Guid id)
    {
        var entities = await _fileService.GetByTaskId(id);

        return entities.Select(entities => _fileMapper.ToResponse(entities));
    }
}
