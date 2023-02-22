using MediatR;
using MilestonePractice.Models;

namespace MilestonePractice.Queries.UserQueries
{
    public record LoginQuery(UserLogin user):IRequest<String>;
    
}
