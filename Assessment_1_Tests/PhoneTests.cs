using System;
using Assessment_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment_1_Tests
{
    [TestClass]
    public class PhoneTests
    {
        [TestMethod]
        public void Phone_Maker_ShouldBeSetToString()
        {
            //-- Arrange
            Phone phone = new Phone("Samsung", "Android", 200.00m);

            //-- Act
            string actual = phone.Maker;
            string expected = "Samsung";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Phone_Model_ShouldBeSetToString()
        {
            //-- Arrange
            Phone phone = new Phone("Samsung", "Android", 200.00m);

            //-- Act
            string actual = phone.Model;
            string expected = "Android";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Phone_SendMessage_ShouldBeCorrectDecimal()
        {
            //-- Arrange
            Phone phone = new Phone("Samsung", "Android", 200.00m);

            //-- Act
            decimal actual = phone.Value;
            decimal expected = 200.00m;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
