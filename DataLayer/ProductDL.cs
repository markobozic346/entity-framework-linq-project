using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProductDL
    {
        private readonly northwindEntities _context;

        public ProductDL()
        {
            _context = new northwindEntities();
        }
        public ProductDTO GetSingle(int productID)
        {
            var product = _context.Products.Where(od => od.ProductID == productID).ToList();

            return Mapper.MapToDTO(product[0]);

        }

        public List<ProductDTO> GetAllProducts()
        {
            var products = _context.Products.ToList();

            return Mapper.convertToList(products);
        }
    }
}
