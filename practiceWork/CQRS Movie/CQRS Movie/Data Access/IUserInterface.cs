using CQRS_Movie.Models;

namespace CQRS_Movie.Data_Access
{
    // User interface contains the method definition that is only relevent to users
    public interface IUserInterface
    {   
        public List<DisplayMoviesWithGenres>getMoviesByGenresId();

        public List<DisplayMoviesWithGenres> getMoviesByGenresName(int id);

        public string getMovieById(int id);
    }
}
