using CQRS_Movie.Data_Access;
using CQRS_Movie.Models;
using CQRS_Movie.Queries;
using MediatR;

namespace CQRS_Movie.Handlers
{
    public class GetAllMoviesAdminHandler : IRequestHandler<GetMoviesForAdmin ,List<Tmovie>>
    {
        private readonly IAdminInterface _context;

        public GetAllMoviesAdminHandler(IAdminInterface context)
        {
            _context = context;
        }

        public async Task<List<Tmovie>> Handle(GetMoviesForAdmin request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.getAllMovies());
        }

        
       

       
    }
}
