using UniversityManagement.Core.Interfaces;
using UniversityManagement.Core.Models;

namespace UniversityManagement.Patterns.Strategy;

public class ExamRatingStrategy
    : IRatingStrategy
{
    public double CalculateRating(
        Student student)
    {
        var exams =
            student.Grades
            .Where(x => x.Value >= 60);

        return exams.Any()
            ? exams.Average(x => x.Value)
            : 0;
    }
}