using SecurityMovie.Models;

namespace SecurityMovie.Data_Access
{
    public interface IUserService
    {
        public List<UserInfoTable> getUser();
        //public UserInfoTable get(UserLogin userLogin);
        public string updateUser(UserInfoTable newuser);
        public string deleteUser(int id);

        public List<UserInfoTable> addUser(UserInfoTable user);

    }
}
