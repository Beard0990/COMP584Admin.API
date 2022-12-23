using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using COMP584.API.StudentsController;
using COMP584.API.StudentAdminPortalDb;
using COMP584.API.DataModels.Student;
using Xunit;

namespace WorldCitiesAPI.Tests
{
    public class StudentsController_Tests
    {
        /// <summary>
        /// Test the GetCity() method
        /// </summary>
        [Fact]
        public async Task GetStudent()
        {
            // Arrange
            // todo: define the required assets
            // Act
            // todo: invoke the test
            // Assert
            // todo: verify that conditions are met.

            var options = new DbContextOptionsBuilder<StudentAdminPortalDb>()
                .UseInMemoryDatabase(databaseName: "COMP584")
                .Options;
            using var context = new StudentAdminPortalDb(options);
            context.Add(new Student()
            {
                Id = 1,
                FirstName = "Sam",
                LastName = "Sai",
                DateOfBirth = "1/1/1995",
                Email = "sam.sai@gmail.com",
                Mobile = "585342543",
                ProfileImageUrl = "safagvzv2345625.net",
                GenderId = 242,
            });
            context.SaveChanges();
            var StudentsController_Tests = new StudentsController(context);
            Student.Id? Student_existing = null;
            Student.Id? Student_notExisting = null;

            // Act
            Student_existing = (await StudentsController_Tests.GetStudent(1)).Value;
            Student_notExisting = (await StudentsController_Tests.GetStudent(2)).Value;

            // Assert
            Assert.NotNull(Student_existing);
            Assert.Null(Student_notExisting);
        }
    }
}