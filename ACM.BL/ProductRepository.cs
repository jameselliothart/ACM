using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {

        /// <summary>
        /// Retrieve one product
        /// </summary>
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            // Temporary hard-coded value to return populated product
            if (productId == 2)
            {
                product.ProductName = "Ansible";
                product.Description = "Instantaneous communication device";
                product.CurrentPrice = 999.99M;
            }
            return product;
        }

        /// <summary>
        /// Save the current product
        /// </summary>
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
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
