using UniversityManagement.Core.Enums;
using UniversityManagement.Patterns.Factory;
using Xunit;

namespace UniversityManagement.Tests;

public class FactoryTests
{
    [Fact]
    public void LectureFactory_Should_Create_Lecture()
    {
        var factory = new LectureFactory();

        var lesson =
            factory.CreateLesson(
                "Math",
                DateTime.Now);

        Assert.Equal(
            LessonType.Lecture,
            lesson.LessonType);
    }

    [Fact]
    public void SeminarFactory_Should_Create_Seminar()
    {
        var factory = new SeminarFactory();

        var lesson =
            factory.CreateLesson(
                "Physics",
                DateTime.Now);

        Assert.Equal(
            LessonType.Seminar,
            lesson.LessonType);
    }

    [Fact]
    public void LaboratoryFactory_Should_Create_Laboratory()
    {
        var factory = new LaboratoryFactory();

        var lesson =
            factory.CreateLesson(
                "Programming",
                DateTime.Now);

        Assert.Equal(
            LessonType.Laboratory,
            lesson.LessonType);
    }
}