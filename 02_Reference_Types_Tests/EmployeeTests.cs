using System;
using _02_Reference_Types_Demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Reference_Types_Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Employee_EmployeeID_ShouldBeCorrectInt()
        {
            //-- Arrange
            Employee employee = new Employee();
            employee.EmployeeID = 12345;

            //-- Act
            int actual = employee.EmployeeID;
            int expected = 12345;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Employee_FirstName_ShouldBeSetToString()
        {
            //-- Arrange
            Employee employee = new Employee();
            employee.FirstName = "Ferdinand";

            //-- Act
            string actual = employee.FirstName;
            string expected = "Ferdinand";

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Employee_LastName_ShouldBeSetToString()
        {
            //Arrange
            Employee employee = new Employee();
            employee.LastName = "theBull";

            //Act
            string actual = employee.LastName;
            string expected = "theBull";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Employee_Age_ShouldBeCorrectInt()
        {
            //Arrange
            Employee employee = new Employee();
            employee.Age = 30;

            //Act
            int actual = employee.Age;
            int expected = 30;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Employee_YearsExperience_ShouldBeCorrectInt()
        {
            //-- Arrange
            Employee employee = new Employee();
            employee.YearsExperience = 3;

            //-- Act
            int actual = employee.YearsExperience;
            int expected = 3;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Employee_GetFullName_ShouldBeConcatenatedString()
        {
            //-- Arrange
            Employee employee = new Employee();
            employee.FirstName = "Kenn";
            employee.LastName = "Pascascio";

            //-- Act
            string actual = employee.GetFullName();  //Methods must have ()
            string expected = "Kenn Pascascio";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
