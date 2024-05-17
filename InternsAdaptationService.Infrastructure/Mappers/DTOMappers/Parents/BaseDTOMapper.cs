using InternsAdaptationService.Data.Entities.ParentEntities;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Parents;

public abstract class BaseDTOMapper<TEntity, TRequestModel, TResponseModel>
    where TEntity : BaseEntity
    where TRequestModel : class
    where TResponseModel : class
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

