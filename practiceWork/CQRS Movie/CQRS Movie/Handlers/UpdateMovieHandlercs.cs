using CQRS_Movie.Command;
using CQRS_Movie.Data_Access;
using CQRS_Movie.Models;
using MediatR;

namespace CQRS_Movie.Handlers
{
    public class UpdateMovieHandlercs : IRequestHandler<UpdateMovieCommand, List<Tmovie>>
    {
        private readonly IAdminInterface _context;

        public UpdateMovieHandlercs(IAdminInterface context)
        {
            _context = context;
        }

       

        public async Task<List<Tmovie>> Handle(UpdateMovieCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.updateMovie(request.movie));
        }
    }
}
