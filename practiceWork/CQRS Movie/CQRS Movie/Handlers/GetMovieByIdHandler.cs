using CQRS_Movie.Data_Access;
using CQRS_Movie.Queries;
using MediatR;

namespace CQRS_Movie.Handlers
{
    public class GetMovieByIdHandler : IRequestHandler<GetMovieById, string>
    {
        private readonly IUserInterface _context;

        public GetMovieByIdHandler(IUserInterface context)
        {
                _context = context;
        }

        public async Task<string> Handle(GetMovieById request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.getMovieById(request.id));
        }
    }
}
