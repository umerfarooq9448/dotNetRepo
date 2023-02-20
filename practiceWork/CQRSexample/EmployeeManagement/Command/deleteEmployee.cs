using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Command
{
    internal class deleteEmployee:IRequest<int>
    {
        //public string EmployeeName { get; set; }
        //public int EmployeeAge { get; set; }
        // public int EmployeeSalary { get; set; }
        public int EmployeeId { get; set; }
        //public string Address { get; set; }
    }
}
