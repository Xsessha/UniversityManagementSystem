using UniversityManagement.Core.Enums;
using UniversityManagement.Core.Models;

namespace UniversityManagement.Patterns.Factory;

public class Lecture : Lesson
{
    public Lecture()
    {
        LessonType = LessonType.Lecture;
    }
}