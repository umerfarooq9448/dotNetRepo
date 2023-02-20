using CQRS_Example2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Example2.Data_Access
{
    public interface IEmployee
    {
        List<TEmployee> addNewEmployee(TEmployee employee);

        List<TEmployee> updateEmployee(TEmployee employee);
        List<TEmployee> getAllEmployees();

        string deleteEmployee(int id);
    }
}
