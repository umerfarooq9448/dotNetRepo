using CQRS_Movie.Command;
using CQRS_Movie.Data_Access;
using CQRS_Movie.Models;
using MediatR;

namespace CQRS_Movie.Handlers
{
    public class AddMovieHandler : IRequestHandler<AddMovieCommand, List<Tmovie>>
    {
        private readonly IAdminInterface _context;

        public AddMovieHandler(IAdminInterface context)
        {
            _context = context;
        }
        public async Task<List<Tmovie>> Handle(AddMovieCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.addNewMovie(request.movie));
            
        }
    }
}
