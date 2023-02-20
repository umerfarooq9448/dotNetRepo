using aspdotnetcoreex.Interfaces;
using aspdotnetcoreex.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace aspdotnetcoreex.Repositories
{
    public class EmployeeRepository: IEmployee
    {
        private readonly EmployeeContext _employeeContext;

        public EmployeeRepository(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public List<TEmployee> Create(TEmployee employee)
        {
          _employeeContext.TEmployees.Add(employee);
            _employeeContext.SaveChanges();
            return _employeeContext.TEmployees.ToList();
        }

        public string Delete(int id)
        {
            var data = _employeeContext.TEmployees.Find(id);

            if (data != null)
            {

                _employeeContext.TEmployees.Remove(data);
                _employeeContext.SaveChanges();
            }

            return "Deleted";


        }

        public List<TEmployee> update(TEmployee employee)
        {

            var findEmp = _employeeContext.TEmployees.Find(employee.EmployeeId);
            findEmp.EmployeeName = employee.EmployeeName;
            findEmp.EmployeeSalary = employee.EmployeeSalary;
            findEmp.Address = employee.Address;
            findEmp.EmployeeAge = employee.EmployeeAge;
            _employeeContext.SaveChanges();

            return _employeeContext.TEmployees.ToList();

         }
        
        public List<TEmployee> getAllEmployees()
        {
            return _employeeContext.TEmployees.ToList();
        }

        
    }
}
