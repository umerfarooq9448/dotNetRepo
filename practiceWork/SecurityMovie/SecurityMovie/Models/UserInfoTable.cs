using System;
using System.Collections.Generic;

namespace SecurityMovie.Models
{
    public partial class UserInfoTable
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? UserPassword { get; set; }
        public string? UserEmail { get; set; }
        public string? Role { get; set; }
    }
}
