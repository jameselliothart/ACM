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
    }
}
