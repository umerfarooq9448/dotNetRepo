using MediatR;
using SecurityMovie.Data_Access;
using SecurityMovie.Models;
using SecurityMovie.Queries;

namespace SecurityMovie.Handler
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<UserInfoTable>>
    {
        private readonly IUserService _context;

        public GetAllUsersHandler(IUserService context) { 
            
            

            _context = context;
        }


        public async Task<List<UserInfoTable>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_context.getUser());
        }
    }
}
