using MilestonePractice.Models;

namespace MilestonePractice.Data_Access
{
    public interface IUserLogin
    {
        public string Login(UserLogin user);
        public UserInfoTable authenticate(UserLogin user);

        public string generate(UserInfoTable user);
    }
}
