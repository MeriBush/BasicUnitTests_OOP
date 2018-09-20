using System;
using _03_OOP_Defining_Classes_Exercise_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_OOP_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class Exercise_1_CarTests
    {
        [TestMethod]
        public void Car_CarMake_ShouldBeSetToString()
        {
            //-- Arrange
            Car car = new Car("Honda", "CRV", 2005);

            //-- Act
            string actual = car.CarMake;
            string expected = "Honda";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Car_CarModel_ShouldBeSetToString()
        {
            //-- Arrange
            Car car = new Car("Honda", "CRV", 2005);

            //-- Act
            string actual = car.CarModel;
            string expected = "CRV";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Car_CarYear_ShouldBeCorrectInt()
        {
            //-- Arrange
            Car car = new Car("Honda", "CRV", 2005);

            //-- Act
            int actual = car.CarYear;
            int expected = 2005;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
