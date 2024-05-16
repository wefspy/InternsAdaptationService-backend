using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Parents;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Parents;

namespace InternsAdaptationService.Infrastructure.Managers.Parents;

public abstract class BaseManager<TEntity, TRequestModel, TResponseModel>
        where TEntity : class
        where TRequestModel : class
        where TResponseModel : class
{
    private readonly IBaseService<TEntity> _service;
    private readonly IBaseDTOMapper<TEntity, TRequestModel, TResponseModel> _mapper;

    protected BaseManager(IBaseService<TEntity> service, IBaseDTOMapper<TEntity, TRequestModel, TResponseModel> mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public async Task<TResponseModel> CreateAsync(TRequestModel request)
    {
        var newEntity = _mapper.ToNewEntity(request);

        var created = await _service.CreateAsync(newEntity);

        return _mapper.ToResponse(created);
    }

    public async Task UpdateAsync(Guid id, TRequestModel request)
    {
        var existEntity = _mapper.ToExistEntity(id, request);

        await _service.UpdateAsync(existEntity);
    }

    public async Task<IEnumerable<TResponseModel>> GetAllAsync()
    {
        var entities = await _service.GetAllAsync();

        return entities.Select(entity => _mapper.ToResponse(entity));
    }

    public async Task<TResponseModel> GetByIdAsync(Guid id)
    {
        var entity = await _service.GetByIdAsync(id);

        return _mapper.ToResponse(entity);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _service.DeleteAsync(id);
    }
}
