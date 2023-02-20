using MediatR;
using SecurityMovie.Data_Access;
using SecurityMovie.Models;
using SecurityMovie.Queries;

namespace SecurityMovie.Handler
{
    public class getAllMoviesHandler: IRequestHandler<getAllMoviesqQuery,List<MovieInfoTable>>
    {
        private readonly Imovie _context;

        public getAllMoviesHandler(Imovie context)
        {
                _context = context;
        }

        public async Task<List<MovieInfoTable>> Handle(getAllMoviesqQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.getAllMovies());
        }
    }
}
