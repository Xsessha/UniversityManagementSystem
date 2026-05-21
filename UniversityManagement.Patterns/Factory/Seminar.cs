using UniversityManagement.Core.Enums;
using UniversityManagement.Core.Models;

namespace UniversityManagement.Patterns.Factory;

public class Seminar : Lesson
{
    public Seminar()
    {
        LessonType = LessonType.Seminar;
    }
}