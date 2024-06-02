using DataLayer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductBL
    {
        private readonly ProductDL _productDl;

        public ProductBL()
        {
            _productDl = new ProductDL();
        }
        public ProductDTO getProduct(int productId)
        {
            return _productDl.GetSingle(productId);
        }

        public List<ProductDTO> getAllProducts()
        {
            return _productDl.GetAllProducts();
        }

    }
}
