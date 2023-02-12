using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Models
{
    public partial class Student
    {
        public Student()
        {
            Borrows = new HashSet<Borrow>();
        }

        public int StudentId { get; set; }
        public string? StudentFirstName { get; set; }
        public string? StudentLastName { get; set; }
        public string? Gender { get; set; }
        public string? Class { get; set; }

        public virtual ICollection<Borrow> Borrows { get; set; }
    }
}
