using InternsAdaptationService.Data.Interfaces.IEntities.Parents;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Parents;
using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;
using InternsAdaptationService.Infrastructure.Interfaces.IResponseModels.Parents;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Parents;

public abstract class BaseDTOMapper<TEntity, TRequestModel, TResponseModel> : IBaseDTOMapper<TEntity, TRequestModel, TResponseModel>
    where TEntity : IBaseEntity
    where TRequestModel : IBaseRequestModel
    where TResponseModel : IBaseResponseModel
{
    public virtual TEntity ToNewEntity(TRequestModel request)
    {
        var entity = ToEntity(request);
        entity.Id = Guid.NewGuid();

        return entity;
    }

    public virtual TEntity ToExistEntity(Guid id, TRequestModel request)
    {
        var entity = ToEntity(request);
        entity.Id = id;

        return entity;
    }

    protected abstract TEntity ToEntity(TRequestModel request);

    public abstract TResponseModel ToResponse(TEntity entity);
}

