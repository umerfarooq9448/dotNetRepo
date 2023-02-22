using MediatR;
using MilestonePractice.Data_Access;
using MilestonePractice.Queries.UserQueries;

namespace MilestonePractice.Handler.UserHandler
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery, string>
    {
        private readonly IUserLogin _userLogin;

        public LoginQueryHandler(IUserLogin userLogin)
        {
            _userLogin = userLogin;
        }
        public async Task<string> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_userLogin.Login(request.user));
        }
    }
}
