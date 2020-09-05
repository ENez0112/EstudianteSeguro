using System;
using System.Collections.Generic;
using APIStudentSecurity.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudentSecurity.Tests.Controllers
{
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
    }
}
