using CQRS_Example2.Data_Access;
using CQRS_Example2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Example2.Repositories
{
    public class EmployeeRepository:IEmployee
    {
        private readonly EmployeeContext _employeeContext;


        public EmployeeRepository(EmployeeContext employee)
        {
            _employeeContext = employee;
        }

        public List<TEmployee> addNewEmployee(TEmployee employee)
        {
            _employeeContext.TEmployees.Add(employee);
            _employeeContext.SaveChanges();
            return _employeeContext.TEmployees.ToList();
        }

        public string deleteEmployee(int id)
        {
            var data = _employeeContext.TEmployees.FirstOrDefault(x => x.EmployeeId == id);

            if (data != null)
            {

                _employeeContext.TEmployees.Remove(data);
                _employeeContext.SaveChanges();
            }
            return "done";
        }

        public List<TEmployee> getAllEmployees()
        {
            return _employeeContext.TEmployees.ToList();
        }

        public List<TEmployee> updateEmployee(TEmployee employee)
        {
            var findEmp = _employeeContext.TEmployees.Find(employee.EmployeeId);
            findEmp.EmployeeName = employee.EmployeeName;
            findEmp.EmployeeSalary = employee.EmployeeSalary;
            findEmp.Address = employee.Address;
            findEmp.EmployeeAge = employee.EmployeeAge;
            _employeeContext.SaveChanges();

            return _employeeContext.TEmployees.ToList();
        }

        //List<TEmployee> IEmployee.getAllEmployees()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
