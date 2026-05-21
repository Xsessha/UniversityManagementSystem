
using UniversityManagement.Core.Models;
using Xunit;

namespace UniversityManagement.Tests;

public class CourseTests
{
    [Fact]
    public void Course_Should_Have_Name()
    {
        var course = new Course
        {
            Name = "ASP.NET Core"
        };

        Assert.Equal("ASP.NET Core", course.Name);
    }

    [Fact]
    public void Course_Should_Have_Credits()
    {
        var course = new Course
        {
            Credits = 5
        };

        Assert.Equal(5, course.Credits);
    }

    [Fact]
    public void Course_Should_Have_Description()
    {
        var course = new Course
        {
            Description = "Web development"
        };

        Assert.Contains("Web", course.Description);
    }

    [Fact]
    public void Course_Should_Assign_Teacher()
    {
        var teacher = new Teacher
        {
            FullName = "Dr. Smith"
        };

        var course = new Course
        {
            Teacher = teacher
        };

        Assert.Equal("Dr. Smith", course.Teacher.FullName);
    }

    [Fact]
    public void Course_Should_Contain_Students()
    {
        var course = new Course();

        course.Students.Add(new Student());

        Assert.Single(course.Students);
    }

    [Fact]
    public void Course_Should_Contain_Lessons()
    {
        var course = new Course();

        course.Lessons.Add(new Lesson());

        Assert.Single(course.Lessons);
    }

    [Fact]
    public void Course_Students_Should_Start_Empty()
    {
        var course = new Course();

        Assert.Empty(course.Students);
    }

    [Fact]
    public void Course_Lessons_Should_Start_Empty()
    {
        var course = new Course();

        Assert.Empty(course.Lessons);
    }

    [Fact]
    public void Course_Should_Have_Id()
    {
        var course = new Course
        {
            Id = 10
        };

        Assert.Equal(10, course.Id);
    }

    [Fact]
    public void Course_Name_Should_Not_Be_Empty()
    {
        var course = new Course
        {
            Name = "Databases"
        };

        Assert.NotEmpty(course.Name);
    }

    [Fact]
    public void Course_Should_Store_Multiple_Students()
    {
        var course = new Course();

        course.Students.Add(new Student());
        course.Students.Add(new Student());

        Assert.Equal(2, course.Students.Count);
    }

    [Fact]
    public void Course_Should_Store_Multiple_Lessons()
    {
        var course = new Course();

        course.Lessons.Add(new Lesson());
        course.Lessons.Add(new Lesson());

        Assert.Equal(2, course.Lessons.Count);
    }

    [Fact]
    public void Course_Teacher_Should_Not_Be_Null()
    {
        var course = new Course
        {
            Teacher = new Teacher()
        };

        Assert.NotNull(course.Teacher);
    }

    [Fact]
    public void Course_Should_Create_Instance()
    {
        var course = new Course();

        Assert.NotNull(course);
    }

    [Fact]
    public void Course_Credits_Should_Be_Positive()
    {
        var course = new Course
        {
            Credits = 4
        };

        Assert.True(course.Credits > 0);
    }

    [Fact]
    public void Course_Should_Assign_Student()
    {
        var student = new Student
        {
            FirstName = "Anna"
        };

        var course = new Course();

        course.Students.Add(student);

        Assert.Contains(student, course.Students);
    }

    [Fact]
    public void Course_Should_Assign_Lesson()
    {
        var lesson = new Lesson
        {
            Topic = "Intro"
        };

        var course = new Course();

        course.Lessons.Add(lesson);

        Assert.Contains(lesson, course.Lessons);
    }

    [Fact]
    public void Course_Description_Should_Not_Be_Null()
    {
        var course = new Course
        {
            Description = "Description"
        };

        Assert.NotNull(course.Description);
    }

    [Fact]
    public void Course_Should_Contain_Topic()
    {
        var course = new Course
        {
            Name = "Algorithms"
        };

        Assert.Contains("Algo", course.Name);
    }

    [Fact]
    public void Course_Should_Set_TeacherId()
    {
        var course = new Course
        {
            TeacherId = 3
        };

        Assert.Equal(3, course.TeacherId);
    }
}