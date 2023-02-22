using MediatR;
using MilestonePractice.Data_Access;
using MilestonePractice.Models;
using MilestonePractice.Queries.UserQueries;

namespace MilestonePractice.Handler.UserHandler
{
    public class GetAllMoviesHandler:IRequestHandler<GetAllMoviesQuery,List<MovieInfoTable>>
    {
        private readonly IUser _userContext;

        public GetAllMoviesHandler(IUser userContext)
        {
            _userContext = userContext;
        }

        public async Task<List<MovieInfoTable>> Handle(GetAllMoviesQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_userContext.getAllMovies());
        }
    }
}
