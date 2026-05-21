using UniversityManagement.Core.Models;
using UniversityManagement.Services;
using Xunit;

namespace UniversityManagement.Tests;

public class RatingTests
{
    [Fact]
    public void Rating_Should_Be_Calculated()
    {
        var student = new Student();

        student.Grades.Add(new Grade { Value = 100 });
        student.Grades.Add(new Grade { Value = 80 });

        var service = new RatingService();

        var result = service.CalculateRating(student);

        Assert.Equal(90, result);
    }

    [Fact]
    public void Rating_Should_Return_Zero_Without_Grades()
    {
        var student = new Student();

        var service = new RatingService();

        var result = service.CalculateRating(student);

        Assert.Equal(0, result);
    }

    [Fact]
    public void Rating_Should_Handle_One_Grade()
    {
        var student = new Student();

        student.Grades.Add(new Grade { Value = 75 });

        var service = new RatingService();

        Assert.Equal(75,
            service.CalculateRating(student));
    }

    [Fact]
    public void Rating_Should_Handle_Max_Values()
    {
        var student = new Student();

        student.Grades.Add(new Grade { Value = 100 });
        student.Grades.Add(new Grade { Value = 100 });

        var service = new RatingService();

        Assert.Equal(100,
            service.CalculateRating(student));
    }

    [Fact]
    public void Rating_Should_Handle_Min_Values()
    {
        var student = new Student();

        student.Grades.Add(new Grade { Value = 0 });

        var service = new RatingService();

        Assert.Equal(0,
            service.CalculateRating(student));
    }

}