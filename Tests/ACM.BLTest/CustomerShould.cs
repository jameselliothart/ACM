using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerShould
    {
        [TestMethod]
        public void HaveValidFullName()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Foo",
                LastName = "Bar"
            };
            string expected = "Bar, Foo";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HandleFirstNameEmpty()
        {
            // Arrange
            var customer = new Customer
            {
                LastName = "Bar"
            };
            string expected = "Bar";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HandleLastNameEmpty()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Foo"
            };
            string expected = "Foo";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer() { FirstName = "Ender" };
            Customer.InstanceCount += 1;

            var c2 = new Customer() { FirstName = "Bean" };
            Customer.InstanceCount += 1;

            var c3 = new Customer() { FirstName = "Peter" };
            Customer.InstanceCount += 1;

            // Act

            // Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValidData()
        {
            // Arrange
            var customer = new Customer()
            {
                LastName = "Wiggins",
                EmailAddress = "ewiggins@earth.co"
            };
            var expected = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotValidateInvalidData()
        {
            // Arrange
            var customer = new Customer()
            {
                EmailAddress = "ewiggins@earth.co"
            };
            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
