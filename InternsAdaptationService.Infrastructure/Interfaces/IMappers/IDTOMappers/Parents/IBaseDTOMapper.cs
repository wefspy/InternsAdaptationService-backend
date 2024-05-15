namespace InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Parents;

public interface IBaseDTOMapper<Entity, Request, Response>
{
    public Entity ToNewEntity(Request request);

    public Entity ToExistEntity(Guid id, Request request);

    public Response ToResponse(Entity entity);
}
