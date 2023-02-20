using System;
using System.Collections.Generic;

namespace LibraryManagementSystemMilestone1.Models
{
    //This class provides the data fields needed to collect books Details
    public partial class Book
    {
        public Book()
        {
            Borrows = new HashSet<Borrow>();
        }

        public int BookId { get; set; }
        public string? BookName { get; set; }
        public int? PageCount { get; set; }
        public int? AuthorId { get; set; }

        public virtual Author? Author { get; set; }
        public virtual ICollection<Borrow> Borrows { get; set; }
    }
}
