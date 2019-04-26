using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        /// <summary>
        /// Retrieve one customer
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);

            // Temporary hard-coded value to return populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "ewiggin@earth.co";
                customer.FirstName = "Ender";
                customer.LastName = "Wiggin";
            }
            return customer;
        }

        /// <summary>
        /// Save the current customer
        /// </summary>
        public bool Save(Customer customer)
        {
            // TODO save the defined customer

            return true;
        }
    }
}
