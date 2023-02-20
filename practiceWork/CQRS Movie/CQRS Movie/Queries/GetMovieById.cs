using MediatR;

namespace CQRS_Movie.Queries
{
    public record GetMovieById(int id): IRequest<string>;
    
}
