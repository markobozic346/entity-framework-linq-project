using DataLayer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OrderDetailsBL
    {
        private readonly OrderDetailsDL _orderDetailsDl;

        public OrderDetailsBL()
        {
            _orderDetailsDl = new OrderDetailsDL();
        }

        public void Save(OrderDetailsDTO orderDetailsDTO)
        {
            _orderDetailsDl.Save(orderDetailsDTO);
        }
        public void Insert(OrderDetailsDTO oDTO)
        {
            _orderDetailsDl.Insert(oDTO);
        }

        public void Delete(int empId)
        {
            _orderDetailsDl.Delete(empId);
        }

        public OrderDetailsDTO GetOrderDetail (int empId)
        {
            return _orderDetailsDl.GetSingle(empId);
        }
    }
}
