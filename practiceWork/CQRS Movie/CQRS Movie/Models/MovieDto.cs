namespace CQRS_Movie.Models
{
    public class MovieDto
    {
        public int MovieId { get; set; }
        public string? MovieName { get; set; }
        public int? GenresId { get; set; }
    }
}
