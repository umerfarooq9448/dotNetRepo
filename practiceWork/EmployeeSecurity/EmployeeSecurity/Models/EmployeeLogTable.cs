using System;
using System.Collections.Generic;

namespace EmployeeSecurity.Models
{
    public partial class EmployeeLogTable
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? Password { get; set; }
        public string? Designation { get; set; }
        public string? Token { get; set; }
        public string? UserMessage { get; set; }
    }
}
