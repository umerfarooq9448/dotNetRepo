using CQRS_Movie.Data_Access;
using CQRS_Movie.Models;
using CQRS_Movie.Queries;
using MediatR;

namespace CQRS_Movie.Handlers
{
    public class GetMovieByGenreIdHandler : IRequestHandler<getMovieByGenreQuerycs, List<DisplayMoviesWithGenres>>
    {
        private readonly IUserInterface _context;

        public GetMovieByGenreIdHandler(IUserInterface context)
        {
            _context = context;
        }

        public async Task<List<DisplayMoviesWithGenres>> Handle(getMovieByGenreQuerycs request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.getMoviesByGenresName(request.id));
        }
    }
}
