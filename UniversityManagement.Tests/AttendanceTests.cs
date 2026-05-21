using UniversityManagement.Core.Enums;
using UniversityManagement.Core.Models;
using UniversityManagement.Services;
using Xunit;

namespace UniversityManagement.Tests;

public class AttendanceTests
{
    [Fact]
    public void Attendance_Should_Calculate_Percentage()
    {
        var student = new Student();

        student.Attendances.Add(new Attendance
        {
            Status = AttendanceStatus.Present
        });

        student.Attendances.Add(new Attendance
        {
            Status = AttendanceStatus.Absent
        });

        var service = new AttendanceService();

        var result =
            service.CalculateAttendancePercent(student);

        Assert.Equal(50, result);
    }

    [Fact]
    public void Attendance_Should_Return_Zero_Without_Data()
    {
        var service = new AttendanceService();

        var result =
            service.CalculateAttendancePercent(
                new Student());

        Assert.Equal(0, result);
    }

}