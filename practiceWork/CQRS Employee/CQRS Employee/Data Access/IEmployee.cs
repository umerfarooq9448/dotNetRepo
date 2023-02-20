using CQRS_Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Employee.Data_Access
{
    public interface IEmployee
    {
        List<TEmployee> addNewEmployee(TEmployee employee);

        List<TEmployee> updateEmployee(TEmployee employee);
        List<TEmployee> getAllEmployees();

        string deleteEmployee(int id);
    }
}
