using UniversityManagement.Services;

namespace UniversityManagement.Web.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection RegisterApplicationServices(
        this IServiceCollection services)
    {
        services.AddScoped<StudentService>();
        services.AddScoped<TeacherService>();
        services.AddScoped<CourseService>();
        services.AddScoped<GroupService>();
        services.AddScoped<FacultyService>();
        services.AddScoped<ScheduleService>();
        services.AddScoped<RatingService>();
        services.AddScoped<AttendanceService>();
        services.AddScoped<NotificationService>();
        services.AddScoped<DashboardService>();

        services.AddSignalR();

        return services;
    }
}
