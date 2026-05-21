using System.Text;
using UniversityManagement.Core.Models;

namespace UniversityManagement.Patterns.Visitor;

public class ReportVisitor : IVisitor
{
    public StringBuilder Report
        = new();

    public void Visit(Student student)
    {
        Report.AppendLine(
            $"Student: {student.FullName} | Rating: {student.Rating}");
    }

    public void Visit(Group group)
    {
        Report.AppendLine(
            $"Group: {group.Name}");

        foreach (var student in group.Students)
        {
            Visit(student);
        }
    }

    public void Visit(Faculty faculty)
    {
        Report.AppendLine(
            $"Faculty: {faculty.Name}");

        foreach (var group in faculty.Groups)
        {
            Visit(group);
        }
    }
}