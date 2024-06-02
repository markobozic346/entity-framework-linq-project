using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EmployeeDL
    {
        private readonly northwindEntities _context;

        public EmployeeDL()
        {
            _context = new northwindEntities();
        }

        public List<EmployeeDTO> GetEmployees()
        {
            var employees = _context.Employees.ToList();
            return Mapper.convertToList(employees);
        }

        public void Save(EmployeeDTO eDTO)
        {
            var emp = _context.Employees.Find(eDTO.EmployeeID);
            if (emp != null)
            {
                emp.FirstName = eDTO.FirstName;
                emp.LastName = eDTO.LastName;
                emp.Title = eDTO.Title;
                emp.TitleOfCourtesy = eDTO.TitleOfCourtesy;
                emp.BirthDate = eDTO.BirthDate;
                emp.HireDate = eDTO.HireDate;

                _context.SaveChanges();
            }
        }

        public void Insert(EmployeeDTO eDTO)
        {
            var emp = Mapper.MapToEntity(eDTO);
            _context.Employees.Add(emp);
            _context.SaveChanges();
        }

        public void Delete(int empId)
        {
            var emp = _context.Employees.Find(empId);
            if (emp != null)
            {
                _context.Employees.Remove(emp);
                try
                {
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public void InsertList(List<EmployeeDTO> emps)
        {
            foreach (var e in emps)
            {
                Insert(e);
            }
        }
    }
}
