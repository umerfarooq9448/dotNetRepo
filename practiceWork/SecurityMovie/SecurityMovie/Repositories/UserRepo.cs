using SecurityMovie.Data_Access;
using SecurityMovie.Models;

namespace SecurityMovie.Repositories
{
    public class UserRepo : IUserService
    {
        private readonly MovieDbContext _context;

        public UserRepo(MovieDbContext context)
        {
            _context = context;
        }


        public List<UserInfoTable> getUser()
        {
            return _context.UserInfoTables.ToList();
        }
        //public UserInfoTable get(UserLogin userLogin)
        //{
        //    UserInfoTable user = getUser().FirstOrDefault(o => o.UserName.Equals(userLogin.userName, StringComparison.OrdinalIgnoreCase) && o.UserPassword.Equals(userLogin.userpassword));
        //    return user;
        //}

        public List<UserInfoTable> addUser(UserInfoTable user)
        {

            try
            {
                _context.UserInfoTables.Add(user);
                _context.SaveChanges();
                return _context.UserInfoTables.ToList();

            }
            catch(Exception ex)
            {
                throw new InvalidDataException("Unable to add User");
            }
            
            
        }



        public string deleteUser(int id)
        {
            try
            {
                var data = _context.UserInfoTables.Find(id);
                if (data != null)
                {
                    _context.UserInfoTables.Remove(data);
                    return "deleted";
                }
                return null;

            }
            catch(Exception ex)
            {
                throw new InvalidDataException("Unable to delete");
            }
            


        }

        public string updateUser(UserInfoTable newuser)
        {
            var user = _context.UserInfoTables.Find(newuser.UserId);
            if (user != null)
            {
                user.UserName = newuser.UserName;
                user.UserEmail = newuser.UserEmail;
                user.UserPassword = newuser.UserPassword;
                user.Role = newuser.Role;
                user.Name = newuser.Name;

                _context.SaveChanges();

                return "updated";
            }
            return "unable to update";
        }

        
    }
}
