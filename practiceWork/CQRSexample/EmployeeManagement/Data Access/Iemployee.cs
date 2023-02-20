using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Data_Access
{
    internal interface Iemployee
    {
         List<TEmployees> Create(TEmployees employee);
         int Delete(int id);
        List<TEmployees> update(TEmployees employee);
        List<TEmployees >getAllEmployees();

    }
}
