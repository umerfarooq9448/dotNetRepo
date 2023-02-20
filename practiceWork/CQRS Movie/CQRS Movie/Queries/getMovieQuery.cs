using CQRS_Movie.Models;
using MediatR;

namespace CQRS_Movie.Queries
{
    public record getMovieQuery: IRequest<List<DisplayMoviesWithGenres>>;
    
}
