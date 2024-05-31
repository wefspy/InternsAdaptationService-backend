using InternsAdaptationService.Data.Entities.Internships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternsAdaptationService.Data.Configurations.Internships;

public class InternshipTaskConfiguration : IEntityTypeConfiguration<InternshipTaskEntity>
{
    public void Configure(EntityTypeBuilder<InternshipTaskEntity> builder)
    {
        builder.HasKey(it => it.Id);

        builder.HasOne(it => it.Intern)
            .WithMany(user => user.InternshipTasks)
            .HasForeignKey(it => it.InternId)
            .HasPrincipalKey(user => user.Id);

        builder.HasMany(it => it.InternshipSubtasks)
            .WithOne(ist => ist.InternshipTask)
            .HasForeignKey(ist => ist.TaskId)
            .HasPrincipalKey(it => it.Id);
    }
}
