using InternsAdaptationService.Data.Entities.Patterns;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternsAdaptationService.Data.Configurations.Patterns;

public class PatternPlanTaskConfiguration : IEntityTypeConfiguration<PatternPlanTaskEntity>
{
    public void Configure(EntityTypeBuilder<PatternPlanTaskEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(planTask => planTask.PatternPlan)
            .WithMany(patternPlan => patternPlan.PlanTasks)
            .HasPrincipalKey(patternPlan => patternPlan.Id)
            .HasForeignKey(planTask => planTask.PlanId);

        builder.HasOne(planTask => planTask.PatternTask)
            .WithMany(patternTask => patternTask.PlanTasks)
            .HasPrincipalKey(patternTask => patternTask.Id)
            .HasForeignKey(planTask => planTask.TaskId);
    }
}
