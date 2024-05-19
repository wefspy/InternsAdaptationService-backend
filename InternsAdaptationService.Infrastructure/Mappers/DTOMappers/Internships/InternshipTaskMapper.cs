using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Internships;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Internships;

public class InternshipTaskMapper : BaseDTOMapper<InternshipTaskEntity, InternshipTaskRequestModel, InternshipTaskResponseModel>,
    IInternshipTaskMapper
{
    protected override InternshipTaskEntity ToEntity(InternshipTaskRequestModel request)
    {
        return new InternshipTaskEntity
        {
            InternId = request.InternId,
            Title = request.Title,
            Description = request.Description,
            StartDate = request.StartDate,
            EndDate = request.EndDate,
            CompletionDate = request.CompletionDate,
            AuthorId = request.AuthorId,
            MentorReview = request.MentorReview,
            Progress = request.Progress,
        };
    }

    public override InternshipTaskResponseModel ToResponse(InternshipTaskEntity entity)
    {
        return new InternshipTaskResponseModel(entity.Id, entity.InternId, entity.Title, entity.Description,
            entity.StartDate, entity.EndDate, entity.CompletionDate, entity.AuthorId, entity.MentorReview, entity.Progress);
    }
}
