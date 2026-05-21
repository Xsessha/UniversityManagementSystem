using UniversityManagement.Core.Models;

namespace UniversityManagement.Patterns.Visitor;

public class RatingVisitor : IVisitor
{
    public void Visit(Student student)
    {
        student.Rating =
            student.Grades.Any()
            ? student.Grades.Average(x => x.Value)
            : 0;
    }

    public void Visit(Group group)
    {
        foreach (var student in group.Students)
        {
            Visit(student);
        }
    }

    public void Visit(Faculty faculty)
    {
        foreach (var group in faculty.Groups)
        {
            Visit(group);
        }
    }
}