using UniversityManagement.Core.Interfaces;
using UniversityManagement.Core.Models;

namespace UniversityManagement.Patterns.Strategy;

public class ScholarshipRatingStrategy
    : IRatingStrategy
{
    public double CalculateRating(
        Student student)
    {
        return student.Grades.Any()
            ? student.Grades.Average(x => x.Value)
            : 0;
    }
}