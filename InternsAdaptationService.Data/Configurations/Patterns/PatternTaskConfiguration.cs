using InternsAdaptationService.Data.Entities.Patterns;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternsAdaptationService.Data.Configurations.Patterns;

public class PatternTaskConfiguration : IEntityTypeConfiguration<PatternTaskEntity>
{
    public void Configure(EntityTypeBuilder<PatternTaskEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(patternTask => patternTask.Mentor)
            .WithMany(user => user.PatternTasks)
            .HasPrincipalKey(user => user.Id)
            .HasForeignKey(patternTask => patternTask.MentorId);

        builder.HasMany(patternTask => patternTask.PlanTasks)
            .WithOne(planTask => planTask.PatternTask)
            .HasForeignKey(planTask => planTask.PlanId)
            .HasPrincipalKey(patternTask => patternTask.Id);

        builder.HasMany(patternTask => patternTask.Subtasks)
            .WithOne(patternSubtask => patternSubtask.PatternTask)
            .HasForeignKey(patternSubtask => patternSubtask.TaskId)
            .HasPrincipalKey(patternTask => patternTask.Id);
    }
}
