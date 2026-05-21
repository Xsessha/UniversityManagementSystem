using UniversityManagement.Core.Enums;
using UniversityManagement.Core.Models;
using UniversityManagement.Data.Context;

namespace UniversityManagement.Data.Seed;

public static class SeedData
{
    public static async Task InitializeAsync(
        UniversityDbContext context)
    {
        if (context.Students.Any())
            return;

        var faculty = new Faculty
        {
            Name = "Computer Science"
        };

        var group = new Group
        {
            Name = "CS-21",
            Faculty = faculty
        };

        var teacher = new Teacher
        {
            FullName = "Dr. John Smith",
            Department = "Software Engineering",
            Email = "john@university.com"
        };

        var course = new Course
        {
            Name = "ASP.NET Core",
            Credits = 5,
            Teacher = teacher
        };

        var student = new Student
        {
            FirstName = "Emma",
            LastName = "Brown",
            Email = "emma@student.com",
            Rating = 95,
            Status = StudentStatus.Active,
            Group = group
        };

        context.Faculties.Add(faculty);
        context.Groups.Add(group);
        context.Teachers.Add(teacher);
        context.Courses.Add(course);
        context.Students.Add(student);

        await context.SaveChangesAsync();
    }
}