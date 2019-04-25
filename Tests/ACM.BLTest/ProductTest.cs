using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ShouldNotValidateInvalidData()
        {
            // Arrange
            var product = new Product
            {
                ProductName = "Fancy Product"
            };
            bool expected = false;

            // Act
            bool actual = product.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
