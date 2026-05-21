using System.Collections.Generic;
using Xunit;
using UniversityManagement.Core.Models;

namespace UniversityManagement.Tests
{
    public class TeacherTests
    {
        [Fact]
        public void Teacher_Course_Should_Have_Correct_Name()
        {
            var teacher = new Teacher();
            teacher.Courses.Add(new Course { Name = "Algorithms" });

            Assert.Equal("Algorithms", teacher.Courses[0].Name);
        }

        [Fact]
        public void Teacher_Should_Allow_Long_Names()
        {
            var teacher = new Teacher
            {
                FullName = "Professor Alexander Robertson"
            };

            Assert.Contains("Alexander", teacher.FullName);
        }

        [Fact]
        public void Teacher_Should_Have_Default_Courses_List()
        {
            var teacher = new Teacher();

            Assert.IsType<List<Course>>(teacher.Courses);
        }

        [Fact]
        public void Teacher_Email_Should_Contain_Domain()
        {
            var teacher = new Teacher
            {
                Email = "teacher@gmail.com"
            };

            Assert.Contains("gmail", teacher.Email);
        }

        [Fact]
        public void Teacher_Should_Set_Image_Path()
        {
            var teacher = new Teacher
            {
                ImageUrl = "teacher.png"
            };

            Assert.EndsWith(".png", teacher.ImageUrl);
        }

        [Fact]
        public void Teacher_Should_Create_Instance()
        {
            var teacher = new Teacher();

            Assert.NotNull(teacher);
        }

        [Fact]
        public void Teacher_Should_Assign_Course()
        {
            var course = new Course
            {
                Name = "Databases"
            };

            var teacher = new Teacher();

            teacher.Courses.Add(course);

            Assert.Contains(course, teacher.Courses);
        }

        [Fact]
        public void Teacher_Should_Have_Valid_Email_Format()
        {
            var teacher = new Teacher
            {
                Email = "test@university.com"
            };

            Assert.True(teacher.Email.Contains("@"));
        }
    }
}