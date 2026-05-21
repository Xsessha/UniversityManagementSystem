using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UniversityManagement.Core.Models;
using UniversityManagement.Data.Context;
using UniversityManagement.Data.Repositories;
using UniversityManagement.Data.Seed;
using UniversityManagement.Patterns.Factory;
using UniversityManagement.Patterns.Observer;
using UniversityManagement.Patterns.Strategy;
using UniversityManagement.Services;
using UniversityManagement.Web.Extensions;
using UniversityManagement.Web.Hubs;
using UniversityManagement.Web.Middleware;

var builder = WebApplication.CreateBuilder(args);

// DATABASE

builder.Services.AddDbContext<UniversityDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// IDENTITY

builder.Services
    .AddIdentity<ApplicationUser, IdentityRole>(options =>
    {
        options.Password.RequireDigit = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequiredLength = 4;

        options.User.RequireUniqueEmail = true;
    })
    .AddEntityFrameworkStores<UniversityDbContext>()
    .AddDefaultTokenProviders();

// COOKIE

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";

    options.Cookie.HttpOnly = true;

    options.ExpireTimeSpan =
        TimeSpan.FromMinutes(60);

    options.SlidingExpiration = true;
});

// MVC

builder.Services.AddControllersWithViews();

// SIGNALR

builder.Services.AddSignalR();

// SESSION

builder.Services.AddSession(options =>
{
    options.IdleTimeout =
        TimeSpan.FromMinutes(30);

    options.Cookie.HttpOnly = true;

    options.Cookie.IsEssential = true;
});

// CACHE

builder.Services.AddMemoryCache();

builder.Services.AddHttpContextAccessor();

// REPOSITORIES

builder.Services.AddScoped<StudentRepository>();
builder.Services.AddScoped<TeacherRepository>();
builder.Services.AddScoped<CourseRepository>();
builder.Services.AddScoped<FacultyRepository>();
builder.Services.AddScoped<GroupRepository>();

// SERVICES

builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<TeacherService>();
builder.Services.AddScoped<CourseService>();
builder.Services.AddScoped<FacultyService>();
builder.Services.AddScoped<GroupService>();
builder.Services.AddScoped<RatingService>();
builder.Services.AddScoped<AttendanceService>();
builder.Services.AddScoped<ScheduleService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<DashboardService>();
builder.Services.AddScoped<ReportService>();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<StatisticsService>();

// STRATEGY

builder.Services.AddScoped<ScholarshipRatingStrategy>();
builder.Services.AddScoped<AttendanceRatingStrategy>();
builder.Services.AddScoped<ExamRatingStrategy>();

// OBSERVER

builder.Services.AddSingleton<NotificationManager>();

// FACTORY

builder.Services.AddScoped<LectureFactory>();
builder.Services.AddScoped<SeminarFactory>();
builder.Services.AddScoped<LaboratoryFactory>();

// EXTENSIONS

builder.Services.RegisterApplicationServices();

// SWAGGER

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// MIDDLEWARE

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseMiddleware<ExceptionMiddleware>();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthentication();

app.UseAuthorization();

// SWAGGER

app.UseSwagger();

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint(
        "/swagger/v1/swagger.json",
        "University Management API V1");

    options.RoutePrefix = "swagger";
});

// SIGNALR

app.MapHub<NotificationHub>(
    "/notificationHub");

// ROUTES

app.MapControllerRoute(
    name: "default",
    pattern:
    "{controller=Home}/{action=Index}/{id?}");

// DATABASE

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        var context =
            services.GetRequiredService
                <UniversityDbContext>();

        context.Database.Migrate();

        await SeedData.InitializeAsync(context);
    }
    catch (Exception ex)
    {
        Console.WriteLine(
            $"Database error: {ex.Message}");
    }
}

app.Run();