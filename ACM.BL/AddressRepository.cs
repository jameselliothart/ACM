using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve one address
        /// </summary>
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);

            // Temporary hard-coded value to return populated address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "123 Fake St";
                address.StreetLine2 = "Apt 789";
                address.City = "Neverland";
                address.State = "Dream";
                address.Country = "Unconscious";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            var address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "123 Fake St",
                StreetLine2 = "Apt 789",
                City = "Neverland",
                State = "Dream",
                Country = "Unconscious",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "456 Real Ln",
                StreetLine2 = "Apt 314",
                City = "Actuality",
                State = "Being",
                Country = "Conscious",
                PostalCode = "42"
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Save the current address
        /// </summary>
        public bool Save(Address address)
        {
            // TODO save the defined address

            return true;
        }
    }
}
