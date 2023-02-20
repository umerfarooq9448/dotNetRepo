using MediatR;
using SecurityMovie.Models;

namespace SecurityMovie.Queries
{
    public record getAllMoviesqQuery: IRequest<List<MovieInfoTable>>;
}
