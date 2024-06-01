using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GetOrdersResultDTO
    {
        public int OrderID { get; set; }
        public System.Nullable<System.DateTime> OrderDate { get; set; }
        public string CompanyName { get; set; }
        public string Customer { get; set; }
        public System.Nullable<decimal> TotalPrice { get; set; }
    }
}
