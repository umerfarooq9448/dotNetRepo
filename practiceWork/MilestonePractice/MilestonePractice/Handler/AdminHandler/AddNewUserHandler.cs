using MediatR;
using MilestonePractice.Commands.AdminCommands;
using MilestonePractice.Data_Access;
using MilestonePractice.Models;

namespace MilestonePractice.Handler.AdminHandler
{
    public class AddNewUserHandler : IRequestHandler<AddNewUserCommand, List<UserInfoTable>>
    {
        private readonly IAdmin _admin;

        public AddNewUserHandler(IAdmin admin)
        {
            _admin = admin;
        }

        public async Task<List<UserInfoTable>> Handle(AddNewUserCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_admin.addNewUser(request.user));
        }
    }
}
