using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public System.Nullable<decimal> UnitPrice { get; set; }
        public System.Nullable<short> UnitsInStock { get; set; }
        public System.Nullable<short> UnitsOnOrder { get; set; }
        public System.Nullable<short> ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}
