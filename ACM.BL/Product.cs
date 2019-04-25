using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {

        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Retrieve one product
        /// </summary>
        public Product Retrieve(int productName)
        {
            // TODO retrieve defined product

            return new Product();
        }

        /// <summary>
        /// Retrieve all products
        /// </summary>
        public List<Product> Retrieve()
        {
            // TODO retrieve all products

            return new List<Product>();
        }

        /// <summary>
        /// Save the current product
        /// </summary>
        public bool Save()
        {
            // TODO save the defined product

            return true;
        }

        /// <summary>
        /// Validates the product data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

    }
}
