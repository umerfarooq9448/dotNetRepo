using CQRS_Movie.Models;
using MediatR;

namespace CQRS_Movie.Command
{
    public record UpdateMovieCommand(Tmovie movie): IRequest<List<Tmovie>>;
    
}
