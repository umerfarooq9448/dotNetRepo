using CQRS_Movie.Data_Access;
using CQRS_Movie.Models;
using CQRS_Movie.Queries;
using MediatR;

namespace CQRS_Movie.Handlers
{
    
    public class getMovieHandler : IRequestHandler<getMovieQuery, List<DisplayMoviesWithGenres>>

    {
        private readonly IUserInterface _context;

        public getMovieHandler(IUserInterface context)
        {
            _context = context;
        }

        public async Task<List<DisplayMoviesWithGenres>> Handle(getMovieQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.getMoviesByGenresId());
        }
    }
}
