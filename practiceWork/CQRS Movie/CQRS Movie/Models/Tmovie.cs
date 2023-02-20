using System;
using System.Collections.Generic;

namespace CQRS_Movie.Models
{
    public partial class Tmovie
    {
        public int MovieId { get; set; }
        public string? MovieName { get; set; }
        public int? GenresId { get; set; }

        public virtual Tgenre? Genres { get; set; }
    }
}
