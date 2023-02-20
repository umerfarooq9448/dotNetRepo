using Employee_Cqrs_CL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Cqrs_CL.Data_Access
{
    public interface Iemployee
    {
         List<TEmployees> Create(TEmployees employee);
          
        List<TEmployees> update(TEmployees employee);
        List<TEmployees >getAllEmployees();

        string Delete(int id);

    }
}
