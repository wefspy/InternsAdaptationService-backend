using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Internships;
using InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Mappers.DTOMappers.Internships;

public class InternshipTaskMapper : BaseDTOMapper<InternshipTaskEntity, IInternshipTaskRequestModel, IInternshipTaskResponseModel>,
    IInternshipTaskMapper
{
    protected override InternshipTaskEntity ToEntity(IInternshipTaskRequestModel request)
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

    public override IInternshipTaskResponseModel ToResponse(InternshipTaskEntity entity)
    {
        return new InternshipTaskResponseModel(entity.Id, entity.InternId, entity.Title, entity.Description, entity.StartDate, entity.EndDate,
            entity.CompletionDate, entity.AuthorId, entity.MentorReview, entity.Progress);
    }

    public InternshipTaskEntity ToNewEntity(Guid internId, DateTime startDateInternship, PatternPlanTaskEntity planTask, PatternTaskEntity task)
    {
        startDateInternship = startDateInternship.ToUniversalTime();
        var startDate = startDateInternship.AddDays(planTask.StartDate);
        var endDate = startDateInternship.AddDays(planTask.EndDate);

        var request = new InternshipTaskRequestModel(internId, task.Title, task.Description, startDate, endDate, null, task.MentorId, null, 0);
        return ToNewEntity(request);
    } 
}
