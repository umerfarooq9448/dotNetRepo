using MediatR;

namespace CQRS_Movie.Command
{
    public record deleteMovieCommand(int id):IRequest<string>;
    
}
