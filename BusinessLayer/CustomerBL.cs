using DataLayer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerBL
    {
        private readonly CustomerDL _customerDl;

        public CustomerBL()
        {
            _customerDl = new CustomerDL();
        }
  

        public List<CustomerDTO> getAllCustomers()
        {
            return _customerDl.GetAllCustomers();
        }
    }
}
