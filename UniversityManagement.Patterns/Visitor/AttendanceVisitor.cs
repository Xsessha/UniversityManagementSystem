using UniversityManagement.Core.Enums;
using UniversityManagement.Core.Models;

namespace UniversityManagement.Patterns.Visitor;

public class AttendanceVisitor : IVisitor
{
    public double AttendancePercent
    {
        get;
        private set;
    }

    public void Visit(Student student)
    {
        if (!student.Attendances.Any())
        {
            AttendancePercent = 0;
            return;
        }

        var present =
            student.Attendances.Count(x =>
                x.Status == AttendanceStatus.Present);

        AttendancePercent =
            (double)present /
            student.Attendances.Count * 100;
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