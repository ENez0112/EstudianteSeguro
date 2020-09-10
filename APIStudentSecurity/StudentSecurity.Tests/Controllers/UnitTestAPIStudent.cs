namespace StudentSecurity.Tests.Controllers
{
    using APIStudentSecurity.Controllers;
    using APIStudentSecurity.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Web.Http;
    using System.Web.Http.Results;

    [TestClass]
    public class UnitTestAPIStudent
    {
        [TestMethod]
        public void TestGetStudent()
        {
            // ARRANGE
            StudentsController studentsController = new StudentsController();
            // ACT
            var listaEstudiantes = studentsController.GetStudents();
            // ASSERT
            Assert.IsNotNull(listaEstudiantes);
        }
        // POST
        [TestMethod]
        public void TestPostStudent()
        {
            // ARRANGE
            StudentsController studentsController = new StudentsController();
            Student expected = new Student()
            {
                StudentID = 7,
                LastName = "Ferrufino",
                FirstName = "Miguel",
                EnrollmentDate = DateTime.Now
            };
            // ACT
            IHttpActionResult actionResult = studentsController.PostStudent(expected);
            var createdResult = actionResult as CreatedAtRouteNegotiatedContentResult<Student>;
            
            // ASSERT
            Assert.IsNotNull(createdResult);
            Assert.AreEqual("DefaultApi", createdResult.RouteName);
            Assert.IsNotNull(createdResult.RouteValues["id"]);
        }
        // UPDATE
        [TestMethod]
        public void TestUpdateStudent()
        {
            // ARRANGE

            // ACT

            // ASSERT
        }
        // DELETE
        [TestMethod]
        public void TestDeleteStudent()
        {
            // ARRANGE

            // ACT

            // ASSERT
        }
    }
}
