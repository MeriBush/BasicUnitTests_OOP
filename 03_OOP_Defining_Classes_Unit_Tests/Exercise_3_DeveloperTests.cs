using System;
using _03_OOP_Defining_Classes_Exercise_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_OOP_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class Exercise_3_DeveloperTests
    {
        [TestMethod]
        public void Developer_DeveloperID_ShouldBeCorrectInt()
        {
            //-- Arrange
            Developer developer = new Developer(101, "Smith", true);

            //-- Act
            int actual = developer.DeveloperID;
            int expected = 101;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Developer_DeveloperID_ShouldReturnString()
        {
            //-- Arrange
            Developer developer = new Developer(101, "Smith", true);

            //-- Act
            string actual = developer.LastName;
            string expected = "Smith";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Developer_DeveloperID_ShouldBeCorrectBool()
        {
            //-- Arrange
            Developer developer = new Developer(101, "Smith", true);

            //-- Act
            bool actual = developer.HasAccount;
            bool expected = true;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
