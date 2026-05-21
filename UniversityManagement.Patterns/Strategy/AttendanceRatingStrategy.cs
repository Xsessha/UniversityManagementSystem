using UniversityManagement.Core.Enums;
using UniversityManagement.Core.Interfaces;
using UniversityManagement.Core.Models;

namespace UniversityManagement.Patterns.Strategy;

public class AttendanceRatingStrategy
    : IRatingStrategy
{
    public double CalculateRating(
        Student student)
    {
        if (!student.Attendances.Any())
            return 0;

        var present =
            student.Attendances.Count(x =>
                x.Status == AttendanceStatus.Present);

        return (double)present /
               student.Attendances.Count * 100;
    }
}