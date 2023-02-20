using System;
using System.Collections.Generic;

namespace SecurityMovie.Models
{
    public partial class MovieInfoTable
    {
        public int MovieId { get; set; }
        public string? MovieName { get; set; }
        public string? MovieType { get; set; }
        public int? MovieRating { get; set; }
    }
}
