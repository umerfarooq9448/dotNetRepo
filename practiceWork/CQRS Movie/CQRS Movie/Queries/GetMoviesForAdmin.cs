using CQRS_Movie.Models;
using MediatR;

namespace CQRS_Movie.Queries
{
    public record GetMoviesForAdmin: IRequest<List<Tmovie>>;
    
}
