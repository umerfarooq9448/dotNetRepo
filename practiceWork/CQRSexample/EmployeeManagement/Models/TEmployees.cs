using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeManagement.Models
{
    public partial class TEmployees
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? EmployeeAge { get; set; }
        public int? EmployeeSalary { get; set; }
        public string Address { get; set; }
    }
}
