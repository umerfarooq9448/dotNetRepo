using MilestonePractice.Models;

namespace MilestonePractice.Data_Access
{   
    //contains all the method definitions for operations related to Admin
    public interface IAdmin
    {
        public List<UserInfoTable> getAllUsers();
        public string deleteMovieById(int id);

        public string updateMovie(MovieInfoTable movie);

        public List<MovieInfoTable> addNewMovie(MovieInfoTable movie);
        public string getMovieById(int id);


        public List<MovieInfoTable> getAllMovies();
        public string deleteUserById(int id);

        public string updateUser(UserInfoTable user);

        public List<UserInfoTable> addNewUser(UserInfoTable user);
    }
}
