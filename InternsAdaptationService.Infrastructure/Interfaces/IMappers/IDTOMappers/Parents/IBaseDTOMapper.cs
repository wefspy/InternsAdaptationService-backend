namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Parents;

public interface IBaseDTOMapper<TEntity, TRequestModel, TResponseModel>
    where TEntity : class
    where TRequestModel : class
    where TResponseModel : class
{
    public TEntity ToNewEntity(TRequestModel request);

    public TEntity ToExistEntity(Guid id, TRequestModel request);

    public TResponseModel ToResponse(TEntity entity);
}
