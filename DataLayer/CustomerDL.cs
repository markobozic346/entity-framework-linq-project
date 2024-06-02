using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CustomerDL
    {
        private readonly northwindEntities _context;

        public CustomerDL()
        {
            _context = new northwindEntities();
        }

        public List<CustomerDTO> GetAllCustomers()
        {
            var customers = _context.Customers.ToList();

            return Mapper.convertToList(customers);
        }
    }
}
