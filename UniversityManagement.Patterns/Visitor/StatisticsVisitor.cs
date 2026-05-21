using UniversityManagement.Core.Models;

namespace UniversityManagement.Patterns.Visitor;

public class StatisticsVisitor : IVisitor
{
    public int StudentCount { get; private set; }

    public void Visit(Student student)
    {
        StudentCount++;
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