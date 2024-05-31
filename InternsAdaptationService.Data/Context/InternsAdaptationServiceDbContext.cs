using InternsAdaptationService.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InternsAdaptationService.Data.Entities.Auth;
using InternsAdaptationService.Data.Entities.Patterns;
using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Data.Configurations.Auth;
using InternsAdaptationService.Data.Configurations.Patterns;
using InternsAdaptationService.Data.Configurations.Internships;

namespace InternsAdaptationService.Data.Context;

public class InternsAdaptationServiceDbContext: IdentityDbContext<UserEntity, RoleEntity, Guid>
{
    public DbSet<RoleEntity> Roles { get; set; }
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<PatternPlanEntity> PatternPlans { get; set; }
    public DbSet<PatternTaskEntity> PatternTasks { get; set; }
    public DbSet<PatternPlanTaskEntity> PatternPlanTasks { get; set; }
    public DbSet<PatternSubtaskEntity> PatternSubtasks { get; set; }
    public DbSet<MentorInternEntity> MentorInterns { get; set; }
    public DbSet<InternshipTaskEntity> InternshipTasks { get; set; }
    public DbSet<InternshipSubtaskEntity> InternshipSubtasks { get; set; }



    public InternsAdaptationServiceDbContext(DbContextOptions<InternsAdaptationServiceDbContext> options): base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());

        modelBuilder.ApplyConfiguration(new PatternPlanConfiguration());
        modelBuilder.ApplyConfiguration(new PatternTaskConfiguration());
        modelBuilder.ApplyConfiguration(new PatternPlanTaskConfiguration());
        modelBuilder.ApplyConfiguration(new PatternSubtaskConfiguration());

        modelBuilder.ApplyConfiguration(new MentorInternConfiguration());
        modelBuilder.ApplyConfiguration(new InternshipTaskConfiguration());
        modelBuilder.ApplyConfiguration(new InternshipSubtaskConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
