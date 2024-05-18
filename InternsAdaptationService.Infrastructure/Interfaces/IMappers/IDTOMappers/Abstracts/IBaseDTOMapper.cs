using InternsAdaptationService.Data.Interfaces.IEntities.Parents;
using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;
using InternsAdaptationService.Infrastructure.Interfaces.IResponseModels.Parents;

namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Abstracts;

public interface IBaseDTOMapper<TEntity, TRequestModel, TResponseModel>
    where TEntity : IBaseEntity
    where TRequestModel : IBaseRequestModel
    where TResponseModel : IBaseResponseModel
{
    public TEntity ToNewEntity(TRequestModel request);

    public TEntity ToExistEntity(Guid id, TRequestModel request);

    public TResponseModel ToResponse(TEntity entity);
}
