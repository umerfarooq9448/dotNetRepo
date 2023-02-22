using MediatR;
using MilestonePractice.Models;

namespace MilestonePractice.Queries.AdminQueries
{
    public record getAllUsersQuery:IRequest<List<UserInfoTable>>;
   
}
