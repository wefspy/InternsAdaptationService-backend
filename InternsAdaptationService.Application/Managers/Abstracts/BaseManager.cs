using InternsAdaptationService.Application.Interfaces.IManagers.Abstracts;
using InternsAdaptationService.Application.Interfaces.IServices.Abstracts;
using InternsAdaptationService.Data.Interfaces.IEntities.Parents;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Abstracts;

namespace InternsAdaptationService.Application.Managers.Abstracts;

public abstract class BaseManager<TEntity, TRequestModel, TResponseModel> : IBaseManager<TRequestModel, TResponseModel>
        where TEntity : IBaseEntity
        where TRequestModel : IBaseRequestModel
        where TResponseModel : IBaseResponseModel
{
    private readonly IBaseService<TEntity> _service;
    private readonly IBaseDTOMapper<TEntity, TRequestModel, TResponseModel> _mapper;

    protected BaseManager(IBaseService<TEntity> service, IBaseDTOMapper<TEntity, TRequestModel, TResponseModel> mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public virtual async Task<TResponseModel> CreateAsync(TRequestModel request)
    {
        var newEntity = _mapper.ToNewEntity(request);

        var created = await _service.CreateAsync(newEntity);

        await _service.SaveAsync();

        return _mapper.ToResponse(created);

    }

    public virtual async Task CreateRangeAsync(IEnumerable<TRequestModel> requests)
    {
        var entities = requests.Select(request => _mapper.ToNewEntity(request));

        await _service.CreateRangeAsync(entities);

        await _service.SaveAsync();
    }

    public virtual async Task UpdateAsync(Guid id, TRequestModel request)
    {
        var existEntity = _mapper.ToExistEntity(id, request);

        await _service.UpdateAsync(existEntity);

        await _service.SaveAsync();
    }

    public virtual async Task<IEnumerable<TResponseModel>> GetAllAsync()
    {
        var entities = await _service.GetAllAsync();

        return entities.Select(entity => _mapper.ToResponse(entity));
    }

    public virtual async Task<TResponseModel> GetByIdAsync(Guid id)
    {
        var entity = await _service.GetByIdAsync(id);

        return _mapper.ToResponse(entity);
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        await _service.DeleteAsync(id);

        await _service.SaveAsync();
    }

    public async Task DeleteRangeAsync(IEnumerable<Guid> ids)
    {
        await _service.DeleteRangeAsync(ids);

        await _service.SaveAsync();
    }
}
