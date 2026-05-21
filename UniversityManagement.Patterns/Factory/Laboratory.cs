using UniversityManagement.Core.Enums;
using UniversityManagement.Core.Models;

namespace UniversityManagement.Patterns.Factory;

public class Laboratory : Lesson
{
    public Laboratory()
    {
        LessonType = LessonType.Laboratory;
    }
}