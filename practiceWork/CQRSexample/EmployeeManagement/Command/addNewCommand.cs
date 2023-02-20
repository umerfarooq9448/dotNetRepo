using EmployeeManagement.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Command
{
    public class addNewCommand: IRequest<List<TEmployees>>
    {
        
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public int EmployeeSalary { get; set; }
        public string Address { get; set; }


    }
}
