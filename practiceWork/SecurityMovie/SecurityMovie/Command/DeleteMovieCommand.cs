using MediatR;

namespace SecurityMovie.Command
{
    public record DeleteMovieCommand(int id): IRequest<string>;
    
}
