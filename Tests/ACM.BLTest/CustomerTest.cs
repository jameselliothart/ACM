using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void ShouldHaveValidFullName()
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
        public void ShouldHandleFirstNameEmpty()
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
        public void ShouldHandleLastNameEmpty()
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
    }
}
