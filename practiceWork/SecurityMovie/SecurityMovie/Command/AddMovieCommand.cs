using MediatR;
using SecurityMovie.Models;

namespace SecurityMovie.Command
{
    public record AddMovieCommand(MovieInfoTable newMovie ):IRequest<List<MovieInfoTable>>;
    
}
