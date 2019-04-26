using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryShould
    {
        [TestMethod]
        public void RetrieveData()
        {
            // Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Ansible",
                Description = "Instantaneous communication device",
                CurrentPrice = 999.99M
            };

            // Act
            var actual = productRepository.Retrieve(2);

            // Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.Description, actual.Description);
        }
    }
}
