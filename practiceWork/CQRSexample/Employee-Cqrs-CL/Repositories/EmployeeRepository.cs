using Employee_Cqrs_CL.Data_Access;
using Employee_Cqrs_CL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Cqrs_CL.Repositories
{
    public class EmployeeRepository : Iemployee
    {

        private readonly EmployeeContext _employeeContext;


        public EmployeeRepository(EmployeeContext employee)
        {
            _employeeContext = employee;
        }

        public List<TEmployees> Create(TEmployees employee)
        {
            _employeeContext.TEmployees.Add(employee);
            _employeeContext.SaveChanges();
            return _employeeContext.TEmployees.ToList();
        }

        public void Delete(int id)
        {
            
                var data = _employeeContext.TEmployees.FirstOrDefault(x => x.EmployeeId == id);

                if (data != null)
                {

                    _employeeContext.TEmployees.Remove(data);
                    _employeeContext.SaveChanges();
                }

             
        }

        public List<TEmployees> getAllEmployees()
        {
            return _employeeContext.TEmployees.ToList();
        }

        public List<TEmployees> update(TEmployees employee)
        {
            var findEmp = _employeeContext.TEmployees.Find(employee.EmployeeId);
            findEmp.EmployeeName = employee.EmployeeName;
            findEmp.EmployeeSalary = employee.EmployeeSalary;
            findEmp.Address = employee.Address;
            findEmp.EmployeeAge = employee.EmployeeAge;
            _employeeContext.SaveChanges();

            return _employeeContext.TEmployees.ToList();
        }

        string Iemployee.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
