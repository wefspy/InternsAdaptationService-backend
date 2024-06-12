using InternsAdaptationService.Application.Interfaces.IServices.Files;
using InternsAdaptationService.Data.Entities.Files;
using InternsAdaptationService.Data.Interfaces.IRepositories.Files;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Files;
using Microsoft.AspNetCore.Hosting;

namespace InternsAdaptationService.Application.Services.Files;

public class FileService : IFileService
{
    private readonly IFileRepository _fileRepository;
    private readonly IWebHostEnvironment _webHostEnvironment;

    public FileService(IFileRepository fileRepository, IWebHostEnvironment webHostEnvironment)
    {
        _fileRepository = fileRepository;
        _webHostEnvironment = webHostEnvironment;
    }

    public async Task<FileEntity> CreateAsync(IFileRequestModel request)
    {   
        var uploadsFolder = Path.Combine(_webHostEnvironment.ContentRootPath, "uploads", request.Entity.Id.ToString());
        Directory.CreateDirectory(uploadsFolder);
        var filePath = Path.Combine(uploadsFolder, request.File.FileName);
        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await request.File.CopyToAsync(stream);
        }

        return await _fileRepository.CreateAsync(request.Entity);
    }

    public IEnumerable<FileEntity> CreateRangeAsync(IEnumerable<IFileRequestModel> requests)
    {
        return requests.Select(request => CreateAsync(request).Result);
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);

        _fileRepository.DeleteAsync(entity);

        var uploadsFolder = Path.Combine(_webHostEnvironment.ContentRootPath, "uploads", entity.Id.ToString());
        var filePath = Path.Combine(uploadsFolder, entity.Name + entity.Extension);
        File.Delete(filePath);
    }

    public async Task DeleteRangeAsync(IEnumerable<Guid> ids)
    {
        var entities = ids
            .Select(id => GetByIdAsync(id).Result);

        await _fileRepository.DeleteRangeAsync(entities);

        foreach (var entity in entities)
        {
            var uploadsFolder = Path.Combine(_webHostEnvironment.ContentRootPath, "uploads", entity.Id.ToString());
            var filePath = Path.Combine(uploadsFolder, entity.Name + "." + entity.Extension);
            File.Delete(filePath);
        }
    }

    public async Task<IEnumerable<FileEntity>> GetAllAsync()
    {
        return await _fileRepository.GetAllAsync();
    }

    public async Task<FileEntity> GetByIdAsync(Guid id)
    {
        return await _fileRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<FileEntity>> GetByTaskId(Guid id)
    {
        return await _fileRepository.GetByTaskId(id);
    }

    public async Task SaveAsync()
    {
        await _fileRepository.SaveAsync();
    }
}
