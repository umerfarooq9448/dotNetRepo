using System;
using System.Collections.Generic;

namespace MilestonePractice.Models
{
    public partial class MovieInfoTable
    {
        public int MovieId { get; set; }
        public string? MovieName { get; set; }
        public string? MovieType { get; set; }
        public int? MovieRating { get; set; }
    }
}
