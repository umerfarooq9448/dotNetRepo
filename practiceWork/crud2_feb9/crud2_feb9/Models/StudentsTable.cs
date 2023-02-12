using System;
using System.Collections.Generic;

namespace crud2_feb9.Models
{
    public partial class StudentsTable
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? Address { get; set; }
        public int? CourseId { get; set; }

        public virtual CourseTable? Course { get; set; }


        //public StudentsTable()
        //{

        //    CourseTable = new HashSet<CourseTable>();
        //}
        //public ICollection<CourseTable> CourseTable { get; set; }



    }
}
