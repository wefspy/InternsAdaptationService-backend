using InternsAdaptationService.Data.Entities.Auth;
using InternsAdaptationService.Data.Entities.Patterns;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternsAdaptationService.Data.Configurations.Patterns;

public class PatternPlanConfiguration : IEntityTypeConfiguration<PatternPlanEntity>
{
    public void Configure(EntityTypeBuilder<PatternPlanEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(patternPlan => patternPlan.Mentor)
            .WithMany(user => user.PatternPlans)
            .HasForeignKey(patternPlan => patternPlan.MentorId)
            .HasPrincipalKey(user => user.Id);
    }
}
