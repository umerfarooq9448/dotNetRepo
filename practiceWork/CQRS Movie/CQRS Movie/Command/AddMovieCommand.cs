using CQRS_Movie.Models;
using MediatR;

namespace CQRS_Movie.Command
{
    public record AddMovieCommand(Tmovie movie):IRequest<List<Tmovie>>;
    
}
