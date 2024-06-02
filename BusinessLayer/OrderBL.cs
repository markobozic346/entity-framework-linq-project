using DataLayer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OrderBL
    {
        private readonly OrderDL _orderDl;

        public OrderBL()
        {
            _orderDl = new OrderDL();
        }

        public int Insert(OrderDTO oDTO)
        {
            return _orderDl.Insert(oDTO);
        }

        public void Save(OrderDTO oDTO)
        {
            _orderDl.Save(oDTO);
        }

        public void Delete(int empId)
        {
            _orderDl.Delete(empId);
        }

        public OrderDTO GetOrder(int ordId)
        {
            return _orderDl.GetSingle(ordId);
        }

        public List<OrderDTO> GetAllOrders()
        {
            return _orderDl.GetAll();
        }
    }
}
