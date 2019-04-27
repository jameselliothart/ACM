using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order
        /// </summary>
        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 25, 8, 45, 0,
                                                        new TimeSpan(7, 0, 0));
            }
            return order;
        }

        /// <summary>
        /// Save the current order
        /// </summary>
        public bool Save(Product order)
        {
            var success = true;

            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
                    {
                        // insert
                    }
                    else
                    {
                        // update
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
