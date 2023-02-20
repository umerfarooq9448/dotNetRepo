using CQRS_Movie.Models;
using MediatR;

namespace CQRS_Movie.Queries
{
    public record getMovieByGenreQuerycs(int id): IRequest<List<DisplayMoviesWithGenres>>;
    
}
