using DataLayer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ShipperBL
    {
        internal readonly ShipperDL _shipperDl;

        public ShipperBL()
        {
            _shipperDl = new ShipperDL();
        }
   

        public List<ShipperDTO> getAllShippers()
        {
            return _shipperDl.getAllShippers();
        }
    }
}
