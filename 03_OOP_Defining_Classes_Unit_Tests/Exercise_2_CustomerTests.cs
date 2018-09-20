using System;
using _03_OOP_Defining__Classes_Exercise_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_OOP_Defining_Classes_Unit_Tests
{
    [TestClass]
    public class Exercise_2_CustomerTests
    {
        [TestMethod]
        public void Customer_SendMessage_ShouldReturnString()
        {
            //-- Arrange
            Customer customer = new Customer(1, "Boillot", "Cody", 6);

            //-- Act
            string actual = customer.SendCustomerMessage();
            string expected = "Thank you for being a Gold Level member!";

            //--Assert
            Assert.AreEqual(expected, actual);
        }
         

        [TestMethod]
        public void Customer_SendMessageLessThanFive_ShouldReturnString()
        {
            //-- Arrange
            Customer customer = new Customer(1, "Boillot", "Cody", 4);

            //-- Act
            string actual = customer.SendCustomerMessage();
            string expected = "Thank you for being a member!";

            //--Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Customer_CustomerID_ShouldBeCorrectInt()
        {
            //-- Arrange
            Customer customer = new Customer(1, "Smith", "John", 5);

            //-- Act
            int actual = customer.ID;
            int expected = 1;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception),"Customer ID cannot be negative or zero.")]
        public void Customer_CustomerID_ShouldThrowException()
        {
            //-- Arrange
            Customer customer = new Customer(-1, "Tom", "Jones", 15);

            //No Act or Assert necessary to test a reception.
        }


        [TestMethod]
        public void Customer_CustomerLastName_ShouldBeSetToString()
        {
            //-- Arrange
            Customer customer = new Customer(150, "Smith", "John", 5);

            //-- Act
            string actual = customer.LastName;
            string expected = "Smith";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception),"You must enter a valid last name.")]
        public void Customer_CustomerLastName_ShouldThrowException()
        {
            //-- Arrange
            Customer customer = new Customer(1, null, "Tom", 15);
        }


        [TestMethod]
        public void Customer_CustomerFirstName_ShouldBeSetToString()
        {
            //-- Arrange
            Customer customer = new Customer(150, "Smith", "John", 5);

            //-- Act
            string actual = customer.FirstName;
            string expected = "John";

            //-- Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception), "You must enter a customer name.")]
        public void Customer_CustomerFirstName_ShouldThrowException()
        {
            //-- Arrange
            Customer customer = new Customer(1, "Jones", " ", 15);
            Customer customertwo = new Customer(1, "Jones", null, 15);
        }


        [TestMethod]
        public void Customer_CustomerYears_ShouldBeCorrectInt()
        {
            //-- Arrange
            Customer customer = new Customer(150, "Smith", "John", 5);

            //-- Act
            int actual = customer.Years;
            int expected = 5;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception), "Please enter a number equal to or higher than zero.")]
        public void Customer_CustomerYears_ShouldThrowException()
        {
            //-- Arrange
            Customer customer = new Customer(1, "Jones", "Tom", -1);
        }
    }
}
