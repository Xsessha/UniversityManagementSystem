using UniversityManagement.Core.Models;
using UniversityManagement.Patterns.Visitor;
using Xunit;

namespace UniversityManagement.Tests;

public class VisitorTests
{
    [Fact]
    public void RatingVisitor_Should_Update_Rating()
    {
        var student = new Student();

        student.Grades.Add(new Grade
        {
            Value = 100
        });

        var visitor = new RatingVisitor();

        visitor.Visit(student);

        Assert.Equal(100, student.Rating);
    }

    [Fact]
    public void StatisticsVisitor_Should_Count_Students()
    {
        var group = new Group();

        group.Students.Add(new Student());

        var visitor = new StatisticsVisitor();

        visitor.Visit(group);

        Assert.Equal(1, visitor.StudentCount);
    }

}