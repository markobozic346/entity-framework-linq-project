using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ShipperDL
    {
        private readonly northwindEntities _context;

        public ShipperDL()
        {
            _context = new northwindEntities();
        }

        public List<ShipperDTO> getAllShippers()
        {
            var shippers = _context.Shippers.ToList();

            return Mapper.convertToList(shippers);
        }
    }
}
