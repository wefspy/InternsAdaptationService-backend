using InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels.Internships;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Internships;

public class InternshipTaskResponseModel : InternshipTaskRequestModel, IInternshipTaskResponseModel
{
    public Guid Id { get; }

    public InternshipTaskResponseModel(Guid id, Guid internId, string title, string description,
        DateTime startDate, DateTime endDate, DateTime? completionDate, Guid authorId,
        string? mentorReview, int progress) :
        base(internId, title, description, startDate, endDate, completionDate, authorId,
            mentorReview, progress)
    {
        Id = id;
    }
}
