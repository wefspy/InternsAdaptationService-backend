using InternsAdaptationService.Data.Entities.Internships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternsAdaptationService.Data.Configurations.Internships;

public class MentorInternConfiguration : IEntityTypeConfiguration<MentorInternEntity>
{
    public void Configure(EntityTypeBuilder<MentorInternEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(mentorIntern => mentorIntern.Intern)
            .WithMany(user => user.InternRelations)
            .HasForeignKey(mentorIntern => mentorIntern.InternId)
            .HasPrincipalKey(user => user.Id);

        builder.HasOne(mentorIntern => mentorIntern.Mentor)
            .WithMany(user => user.MentorRelations)
            .HasForeignKey(mentorIntern => mentorIntern.MentorId)
            .HasPrincipalKey(user => user.Id);
    }
}
