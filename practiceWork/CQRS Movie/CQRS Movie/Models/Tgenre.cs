using System;
using System.Collections.Generic;

namespace CQRS_Movie.Models
{
    public partial class Tgenre
    {
        public Tgenre()
        {
            Tmovies = new HashSet<Tmovie>();
        }

        public int GenresId { get; set; }
        public string? GenresName { get; set; }

        public virtual ICollection<Tmovie> Tmovies { get; set; }
    }
}
