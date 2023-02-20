using MediatR;
using SecurityMovie.Command;
using SecurityMovie.Data_Access;
using SecurityMovie.Models;

namespace SecurityMovie.Handler
{
    public class UpdateMovieHandler : IRequestHandler<UpdateMovieCommand, List<MovieInfoTable>>
    {
        private readonly Imovie _context;

        public UpdateMovieHandler(Imovie context) {
            _context = context;    
        }
        public async Task<List<MovieInfoTable>> Handle(UpdateMovieCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.updateMovie(request.movie));
        }
    }
}
