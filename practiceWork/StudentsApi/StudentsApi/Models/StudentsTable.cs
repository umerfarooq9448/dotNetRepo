using System;
using System.Collections.Generic;

namespace StudentsApi.Models
{
    public partial class StudentsTable
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? Address { get; set; }
        public int? CourseId { get; set; }

        public virtual CourseTable? Course { get; set; }
    }
}
