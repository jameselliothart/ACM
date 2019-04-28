using System;
using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceShould
    {
        [TestMethod]
        public void WriteToFile()
        {
            // Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "ewiggin@earth.co",
                FirstName = "Ender",
                LastName = "Wiggin",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Ansible",
                Description = "Instantaneous communication device",
                CurrentPrice = 1000M
            };
            changedItems.Add(product);

            // Act
            LoggingService.WriteToFile(changedItems);

            // Assert
            // Nothing here to assert
        }
    }
}
