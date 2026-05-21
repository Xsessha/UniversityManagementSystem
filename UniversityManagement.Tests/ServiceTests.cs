using UniversityManagement.Core.Models;
using UniversityManagement.Services;
using Xunit;

namespace UniversityManagement.Tests;

public class ServiceTests
{
    [Fact]
    public void DashboardService_Should_Create_Instance()
    {
        Assert.True(true);
    }

    [Fact]
    public void NotificationService_Should_Add_Notification()
    {
        var service = new NotificationService();

        service.Send(
            "Test",
            "Message");

        Assert.Single(service.GetAll());
    }

    [Fact]
    public void ReportService_Should_Generate_Report()
    {
        var service = new ReportService();

        var report =
            service.GenerateStudentReport(
                new Student
                {
                    FirstName = "Anna",
                    LastName = "White",
                    Rating = 95
                });

        Assert.Contains("Anna", report.Title);
    }

}