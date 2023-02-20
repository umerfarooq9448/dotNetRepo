using CQRS_Movie.Command;
using CQRS_Movie.Data_Access;
using MediatR;

namespace CQRS_Movie.Handlers
{
    public class DeleteMovieHandler : IRequestHandler<deleteMovieCommand,string>
    {
        private readonly IAdminInterface _context;

        public DeleteMovieHandler(IAdminInterface context)
        {
            _context = context;
        }
        public async Task<string> Handle(deleteMovieCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.deleteMovie(request.id));
        }
    }
}
