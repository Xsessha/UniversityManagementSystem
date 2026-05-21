using Xunit;
using UniversityManagement.Core.Models;
using UniversityManagement.Core.Enums; // Залишив, оскільки він був у твоєму фрагменті

namespace UniversityManagement.Tests
{
    public class StudentTests
    {
        // Відновлений перший тест
        [Fact]
        public void Student_FirstName_Should_Not_Be_Null()
        {
            var student = new Student
            {
                FirstName = "Anna"
            };

            Assert.NotNull(student.FirstName);
        }

        [Fact]
        public void Student_LastName_Should_Not_Be_Null()
        {
            var student = new Student
            {
                LastName = "White"
            };

            Assert.NotNull(student.LastName);
        }

        [Fact]
        public void Student_Email_Should_Contain_At()
        {
            var student = new Student
            {
                Email = "anna@test.com"
            };

            Assert.Contains("@", student.Email);
        }

        [Fact]
        public void Student_Grades_Should_Start_Empty()
        {
            var student = new Student();

            Assert.Empty(student.Grades);
        }

        [Fact]
        public void Student_Attendances_Should_Start_Empty()
        {
            var student = new Student();

            Assert.Empty(student.Attendances);
        }

        [Fact]
        public void Student_FullName_Should_Contain_FirstName()
        {
            var student = new Student
            {
                FirstName = "Tom",
                LastName = "Walker"
            };

            Assert.Contains("Tom", student.FullName);
        }

        [Fact]
        public void Student_FullName_Should_Contain_LastName()
        {
            var student = new Student
            {
                FirstName = "Tom",
                LastName = "Walker"
            };

            Assert.Contains("Walker", student.FullName);
        }
    }
}