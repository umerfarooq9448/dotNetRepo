using MediatR;
using MilestonePractice.Data_Access;
using MilestonePractice.Models;
using MilestonePractice.Queries.AdminQueries;

namespace MilestonePractice.Handler.AdminHandler
{
    public class GetAllUsersHandler : IRequestHandler<getAllUsersQuery, List<UserInfoTable>>
    {
        private readonly IAdmin _admin;

        public GetAllUsersHandler(IAdmin admin)
        {
            _admin = admin;
        }
        public async Task<List<UserInfoTable>> Handle(getAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_admin.getAllUsers());
        }
    }
}
