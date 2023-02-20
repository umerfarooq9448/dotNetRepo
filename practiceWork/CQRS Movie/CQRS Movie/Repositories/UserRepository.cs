using CQRS_Movie.Data_Access;
using CQRS_Movie.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Movie.Repositories
{
    public class UserRepository : IUserInterface
    {   
        private readonly MoviesContext _context;

        public UserRepository(MoviesContext context) { 
            
         _context= context;
        }

        public string getMovieById(int id)
        {
            var movie = _context.Tmovies.Where(x => x.MovieId == id).Select(f => f.MovieName).FirstOrDefaultAsync().ToString();
            return movie;
            
        }

        public List<DisplayMoviesWithGenres> getMoviesByGenresId()
        {

            var movieList = (from st in _context.Tmovies
                               join Genres in _context.Tgenres on st.GenresId equals Genres.GenresId
                               select new DisplayMoviesWithGenres()
                               {    
                                   movieId = st.MovieId,
                                   MovieName = st.MovieName,
                                   genreId = Genres.GenresId,
                                   GenreName = Genres.GenresName


                               }).ToList();
            
            
            
            return movieList;
        }

        public List<DisplayMoviesWithGenres> getMoviesByGenresName(int id)
        {
            List<DisplayMoviesWithGenres> searchBasedOnGenre = new List<DisplayMoviesWithGenres>();
            var movieList = (from st in _context.Tmovies
                             join Genres in _context.Tgenres on st.GenresId equals Genres.GenresId
                             select new DisplayMoviesWithGenres()
                             {
                                 movieId = st.MovieId,
                                 MovieName = st.MovieName,
                                 genreId = Genres.GenresId,
                                 GenreName = Genres.GenresName


                             }).ToList();

            
            foreach(var movie in movieList)
            {
                if(movie.genreId == id)
                {
                    searchBasedOnGenre.Add(movie);
                }
                
            }
            return searchBasedOnGenre;

        }
    }
}
