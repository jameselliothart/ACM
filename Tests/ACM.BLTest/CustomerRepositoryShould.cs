using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryShould
    {
        [TestMethod]
        public void RetrieveData()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "ewiggin@earth.co",
                FirstName = "Ender",
                LastName = "Wiggin"
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "ewiggin@earth.co",
                FirstName = "Ender",
                LastName = "Wiggin",
                AddressList = new List<Address>()
                            {
                                new Address()
                                {
                                    AddressType = 1,
                                    StreetLine1 = "123 Fake St",
                                    StreetLine2 = "Apt 789",
                                    City = "Neverland",
                                    State = "Dream",
                                    Country = "Unconscious",
                                    PostalCode = "144"
                                },
                                new Address()
                                {
                                    AddressType = 2,
                                    StreetLine1 = "456 Real Ln",
                                    StreetLine2 = "Apt 314",
                                    City = "Actuality",
                                    State = "Being",
                                    Country = "Conscious",
                                    PostalCode = "42"
                                }
                            }
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            Assert.AreEqual(expected.AddressList.Count, actual.AddressList.Count);
            for (int i = 0; i < expected.AddressList.Count; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
