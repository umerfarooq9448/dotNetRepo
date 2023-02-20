namespace CQRS_Movie.Models
{
    public class DisplayMoviesWithGenres
    {
        public string MovieName { get; set; }
        public string GenreName { get; set; }

        public int genreId { get; set; }


        public int movieId { get; set; }
    }
}
