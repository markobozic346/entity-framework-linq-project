using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OrderDTO
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public System.Nullable<int> EmployeeID { get; set; }
        public System.Nullable<System.DateTime> OrderDate { get; set; }
        public System.Nullable<System.DateTime> RequiredDate { get; set; }
        public System.Nullable<System.DateTime> ShippedDate { get; set; }
        public System.Nullable<int> ShipVia { get; set; }
        public System.Nullable<decimal> Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
    }
}
