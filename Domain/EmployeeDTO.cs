using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    public class EmployeeDTO
    {
        public int EmployeeID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        public string Title { get; set; }

        public string TitleOfCourtesy { get; set; }

        public System.Nullable<System.DateTime> BirthDate { get; set; }

        public System.Nullable<System.DateTime> HireDate { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string HomePhone { get; set; }

        public string Extension { get; set; }

        public string Notes { get; set; }

        public System.Nullable<int> ReportsTo { get; set; }

        public string PhotoPath { get; set; }

    }
}
