using MediatR;
using MilestonePractice.Models;

namespace MilestonePractice.Commands.AdminCommands
{
    public record AddNewMovieCommand(MovieInfoTable movie):IRequest<List<MovieInfoTable>>;
    
}
