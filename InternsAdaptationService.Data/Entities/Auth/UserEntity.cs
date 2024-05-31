using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Data.Entities.Patterns;
using Microsoft.AspNetCore.Identity;

namespace InternsAdaptationService.Data.Entities.Auth;

public class UserEntity : IdentityUser<Guid>
{
    public required string Name { get; set; }

    public required string Surname { get; set; }

    public string? MiddleName { get; set; }

    public string? DesciptionProfile { get; set; }

    public string? Telegram { get; set; }

    public string? VK { get; set; }

    public virtual IEnumerable<PatternPlanEntity> PatternPlans { get; set; }

    public virtual IEnumerable<PatternTaskEntity> PatternTasks { get; set; }

    public virtual IEnumerable<MentorInternEntity> MentorRelations { get; set; }

    public virtual IEnumerable<MentorInternEntity> InternRelations { get; set; }

    public virtual IEnumerable<InternshipTaskEntity> InternshipTasks { get; set; }
}
