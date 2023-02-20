using MediatR;
using SecurityMovie.Command;
using SecurityMovie.Data_Access;
using SecurityMovie.Models;

namespace SecurityMovie.Handler
{
    public class AddMovieHandler : IRequestHandler<AddMovieCommand, List<MovieInfoTable>>
    {

        private readonly Imovie _context;

        public AddMovieHandler(Imovie context)
        {
            _context = context;
        }

        public async Task<List<MovieInfoTable>> Handle(AddMovieCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.addNewMovie(request.newMovie));
        }
    }
}
