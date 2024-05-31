using InternsAdaptationService.Data.Entities.Patterns;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternsAdaptationService.Data.Configurations.Patterns;

public class PatternSubtaskConfiguration : IEntityTypeConfiguration<PatternSubtaskEntity>
{
    public void Configure(EntityTypeBuilder<PatternSubtaskEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(patternSubtask => patternSubtask.PatternTask)
            .WithMany(patternTask => patternTask.Subtasks)
            .HasPrincipalKey(patternTask => patternTask.Id)
            .HasForeignKey(patternSubtask => patternSubtask.TaskId);
    }
}
