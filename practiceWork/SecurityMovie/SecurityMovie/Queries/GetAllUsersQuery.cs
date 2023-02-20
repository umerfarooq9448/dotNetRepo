using MediatR;
using SecurityMovie.Models;

namespace SecurityMovie.Queries
{
    public record GetAllUsersQuery : IRequest<List<UserInfoTable>>;
    
}
