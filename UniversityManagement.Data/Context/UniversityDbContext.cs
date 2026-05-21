using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UniversityManagement.Core.Models;

namespace UniversityManagement.Data.Context;

public class UniversityDbContext
    : IdentityDbContext<ApplicationUser>
{
    public UniversityDbContext(
        DbContextOptions<UniversityDbContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students => Set<Student>();

    public DbSet<Teacher> Teachers => Set<Teacher>();

    public DbSet<Course> Courses => Set<Course>();

    public DbSet<Group> Groups => Set<Group>();

    public DbSet<Faculty> Faculties => Set<Faculty>();

    public DbSet<Lesson> Lessons => Set<Lesson>();

    public DbSet<Attendance> Attendances => Set<Attendance>();

    public DbSet<Grade> Grades => Set<Grade>();

    public DbSet<Schedule> Schedules => Set<Schedule>();

    public DbSet<Notification> Notifications => Set<Notification>();

    protected override void OnModelCreating(
        ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(
            typeof(UniversityDbContext).Assembly);
    }
}