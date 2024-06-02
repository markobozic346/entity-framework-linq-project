using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OrderDetailsDL
    {
        private readonly northwindEntities _context;

        public OrderDetailsDL()
        {
            _context = new northwindEntities();
        }

        public void Insert(OrderDetailsDTO oDTO)
        {
            var orderDetail = Mapper.MapToEntity(oDTO);
            _context.Order_Details.Add(orderDetail);
            _context.SaveChanges();
        }

        public void Save(OrderDetailsDTO oDTO)
        {
            var order = _context.Order_Details.Find(oDTO.OrderID, oDTO.ProductID);
            if (order != null)
            {

                order.OrderID = oDTO.OrderID;
               order.ProductID = oDTO.ProductID;
               order.UnitPrice = oDTO.UnitPrice;
               order.Quantity = oDTO.Quantity;
               order.Discount = oDTO.Discount;

                _context.SaveChanges();
            }
        }

        public void Delete(int OrderId)
        {
            var orderDetails = _context.Order_Details.Where(od => od.OrderID == OrderId).ToList();

            _context.Order_Details.RemoveRange(orderDetails);
            _context.SaveChanges();
        }

        public OrderDetailsDTO GetSingle(int OrderId)
        {
            var orderDetails = _context.Order_Details.Where(od => od.OrderID == OrderId).ToList();

            return Mapper.MapToDTO(orderDetails[0]);

        }
    }
}
