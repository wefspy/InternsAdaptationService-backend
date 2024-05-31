using InternsAdaptationService.Data.Entities.Internships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternsAdaptationService.Data.Configurations.Internships;

public class InternshipSubtaskConfiguration : IEntityTypeConfiguration<InternshipSubtaskEntity>
{
    public void Configure(EntityTypeBuilder<InternshipSubtaskEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(its => its.InternshipTask)
            .WithMany(it => it.InternshipSubtasks)
            .HasForeignKey(its => its.TaskId)
            .HasPrincipalKey(it => it.Id);
    }
}
