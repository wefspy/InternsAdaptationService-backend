using InternsAdaptationService.Data.Enums;
using InternsAdaptationService.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InternsAdaptationService.Data.Context;

public class InternsAdaptationServiceDbContext: IdentityDbContext<User, Role, Guid>
{
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<PatternPlan> PatternPlans { get; set; }
    public DbSet<PatternTask> PatternTasks { get; set; }
    public DbSet<PatternPlanTask> PatternPlanTasks { get; set; }
    public DbSet<PatternSubtask> PatternSubtasks { get; set; }
    public DbSet<MentorIntern> MentorInterns { get; set; }
    public DbSet<InternshipTask> InternshipTasks { get; set; }
    public DbSet<InternshipSubtask> InternshipSubtasks { get; set; }



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
        base.OnModelCreating(modelBuilder);
    }
}
