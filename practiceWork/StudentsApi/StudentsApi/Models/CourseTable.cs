using System;
using System.Collections.Generic;

namespace StudentsApi.Models
{
    public partial class CourseTable
    {
        public CourseTable()
        {
            StudentsTables = new HashSet<StudentsTable>();
        }

        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? Fee { get; set; }

        public virtual ICollection<StudentsTable> StudentsTables { get; set; }
    }
}
