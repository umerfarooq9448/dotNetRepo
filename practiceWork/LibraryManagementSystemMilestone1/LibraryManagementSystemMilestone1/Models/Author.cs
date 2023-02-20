using System;
using System.Collections.Generic;

namespace LibraryManagementSystemMilestone1.Models
{
    //This class provides the data fields needed to collect Author Details
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int AuthorId { get; set; }
        public string? AuthorName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
