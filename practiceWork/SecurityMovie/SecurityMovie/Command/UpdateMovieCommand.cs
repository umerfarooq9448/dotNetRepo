using MediatR;
using SecurityMovie.Models;

namespace SecurityMovie.Command
{
    public record UpdateMovieCommand(MovieInfoTable movie): IRequest<List<MovieInfoTable>>;
    
}
