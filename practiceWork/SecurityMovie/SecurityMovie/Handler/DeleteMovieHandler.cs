using MediatR;
using SecurityMovie.Command;
using SecurityMovie.Data_Access;

namespace SecurityMovie.Handler
{
    public class DeleteMovieHandler : IRequestHandler<DeleteMovieCommand, string>
    {
        private readonly Imovie _context;

        public DeleteMovieHandler(Imovie context)
        {
                _context = context;
        }


        public async Task<string> Handle(DeleteMovieCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.deleteMovie(request.id));
        }
    }
}
