using UniversityManagement.Core.Enums;

namespace UniversityManagement.Patterns.Factory;

public static class LessonFactoryProvider
{
    public static ILessonFactory GetFactory(
        LessonType type)
    {
        return type switch
        {
            LessonType.Lecture =>
                new LectureFactory(),

            LessonType.Seminar =>
                new SeminarFactory(),

            LessonType.Laboratory =>
                new LaboratoryFactory(),

            _ => throw new Exception(
                "Factory not found")
        };
    }
}