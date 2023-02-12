using System;
using System.Collections.Generic;

namespace crudexample.Models
{
    public partial class TEmployee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public int? EmployeeAge { get; set; }
        public int? EmployeeSalary { get; set; }
        public string? Address { get; set; }
    }
}
