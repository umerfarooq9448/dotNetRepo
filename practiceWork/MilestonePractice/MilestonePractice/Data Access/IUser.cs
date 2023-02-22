using MilestonePractice.Models;

namespace MilestonePractice.Data_Access
{   
    //contains all the method definitions related to the user
    public interface IUser
    {
        public List<MovieInfoTable> getAllMovies();
    }
}
