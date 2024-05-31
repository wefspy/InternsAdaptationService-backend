using InternsAdaptationService.Data.Entities.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternsAdaptationService.Data.Configurations.Auth;

public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(user => user.PatternPlans)
            .WithOne(patternPlan => patternPlan.Mentor)
            .HasPrincipalKey(user => user.Id)
            .HasForeignKey(patternPlan => patternPlan.MentorId);

        builder.HasMany(user => user.PatternTasks)
            .WithOne(patternTask => patternTask.Mentor)
            .HasPrincipalKey(user => user.Id)
            .HasForeignKey(patternTask => patternTask.MentorId);

        builder.HasMany(user => user.MentorRelations)
            .WithOne(mentorIntern => mentorIntern.Mentor)
            .HasPrincipalKey(user => user.Id)
            .HasForeignKey(mentorIntern => mentorIntern.MentorId);
        builder.HasMany(user => user.InternRelations)
            .WithOne(mentorIntern => mentorIntern.Intern)
            .HasPrincipalKey(user => user.Id)
            .HasForeignKey(mentorIntern => mentorIntern.InternId);

        builder.HasMany(user => user.InternshipTasks)
            .WithOne(internshipTask => internshipTask.Intern)
            .HasPrincipalKey(user => user.Id)
            .HasForeignKey(internshipTask => internshipTask.InternId);

    }
}
