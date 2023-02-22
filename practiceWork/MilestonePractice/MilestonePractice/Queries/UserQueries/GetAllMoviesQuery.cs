using MediatR;
using MilestonePractice.Models;

namespace MilestonePractice.Queries.UserQueries
{
    public record GetAllMoviesQuery:IRequest<List<MovieInfoTable>>;
    
}
