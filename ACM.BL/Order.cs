﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        
        /// <summary>
        /// Retrieve all products
        /// </summary>
        public List<Order> Retrieve()
        {
            // TODO retrieve all products

            return new List<Order>();
        }

        /// <summary>
        /// Save the current order
        /// </summary>
        public bool Save()
        {
            // TODO save the defined order

            return true;
        }

        /// <summary>
        /// Validates the order data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}