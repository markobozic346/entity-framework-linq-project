using DataLayer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EmployeeBL
    {
        private readonly EmployeeDL _employeeDL;

        public EmployeeBL()
        {
            _employeeDL = new EmployeeDL();
        }

        public List<EmployeeDTO> GetAllEmployees()
        {
            return _employeeDL.GetEmployees();
        }

        public void Save(EmployeeDTO eDTO)
        {
            _employeeDL.Save(eDTO);
        }

        public void Insert(EmployeeDTO eDTO)
        {
            _employeeDL.Insert(eDTO);
        }

        public void Delete(int empId)
        {
            _employeeDL.Delete(empId);
        }

        public void InsertList(List<EmployeeDTO> emps)
        {
            _employeeDL.InsertList(emps);
        }
    }
}
