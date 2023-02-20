using System;
using System.Collections.Generic;

namespace LibraryManagementSystemMilestone1.Models
{
    //This class provides the data fields needed to collect Borrow Details
    public partial class Borrow
    {
        public int BorrowId { get; set; }
        public int? StudentId { get; set; }
        public int? BookId { get; set; }
        public DateTime? TakenDate { get; set; }
        public DateTime? BroughtDate { get; set; }

        public virtual Book? Book { get; set; }
        public virtual Student? Student { get; set; }
    }
}
