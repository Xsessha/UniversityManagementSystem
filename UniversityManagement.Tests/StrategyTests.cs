using UniversityManagement.Core.Enums;
using UniversityManagement.Core.Models;
using UniversityManagement.Patterns.Strategy;
using Xunit;

namespace UniversityManagement.Tests;

public class StrategyTests
{
    [Fact]
    public void ScholarshipStrategy_Should_Calculate()
    {
        var student = new Student();

        student.Grades.Add(new Grade
        {
            Value = 90
        });

        var strategy =
            new ScholarshipRatingStrategy();

        var result =
            strategy.CalculateRating(student);

        Assert.Equal(90, result);
    }

    [Fact]
    public void AttendanceStrategy_Should_Calculate()
    {
        var student = new Student();

        student.Attendances.Add(new Attendance
        {
            Status = AttendanceStatus.Present
        });

        var strategy =
            new AttendanceRatingStrategy();

        var result =
            strategy.CalculateRating(student);

        Assert.Equal(100, result);
    }
}