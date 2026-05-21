using UniversityManagement.Core.Enums;
using UniversityManagement.Core.Models;

namespace UniversityManagement.Patterns.Factory;

public class SeminarFactory
    : ILessonFactory
{
    public Lesson CreateLesson(
        string topic,
        DateTime date)
    {
        return new Lesson
        {
            Topic = topic,
            Date = date,
            LessonType = LessonType.Seminar
        };
    }
}