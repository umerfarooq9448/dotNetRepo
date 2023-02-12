﻿using System;
using System.Collections.Generic;

namespace lib_feb10.Models
{
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
