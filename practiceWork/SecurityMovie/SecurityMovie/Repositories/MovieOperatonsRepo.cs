using SecurityMovie.Data_Access;
using SecurityMovie.Models;

namespace SecurityMovie.Repositories
{
    
    public class MovieOperatonsRepo : Imovie
    {

        private readonly MovieDbContext _contextMovie;

        public MovieOperatonsRepo(MovieDbContext contextMovie)
        {
            _contextMovie = contextMovie;
        }
            public List<MovieInfoTable> addNewMovie(MovieInfoTable movie)
        {
            try
            {
                _contextMovie.Add(movie);
                _contextMovie.SaveChanges();
                return _contextMovie.MovieInfoTables.ToList();
            }
            catch(Exception ex) 
            {
                throw new InvalidDataException("Unable to add new movie");

            }
            
        }

        public string deleteMovie(int MovieId)
        {
            var data = _contextMovie.MovieInfoTables.FirstOrDefault(x => x.MovieId == MovieId);
            try
            {
                if (data != null)
                {

                    _contextMovie.MovieInfoTables.Remove(data);
                    _contextMovie.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new InvalidDataException("cant delete this sorry");

            }
            return "deleted";
        }

        public List<MovieInfoTable> getAllMovies()
        {
            try
            {
                return _contextMovie.MovieInfoTables.ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidDataException("unable to retrive data");

            }
        }

        public string getMovieById(int movieId)
        {
            try
            {
                var data = _contextMovie.MovieInfoTables.Where(p => p.MovieId == movieId).Select(p => p.MovieName).ToString();
                return data;
            }
            catch (Exception ex)
            {
                throw new InvalidDataException("unable to retrive data");

            }
        }

     

        public List<MovieInfoTable> updateMovie(MovieInfoTable movie)
        {
            try
            {
                var findMovie = _contextMovie.MovieInfoTables.Find(movie.MovieId);
                findMovie.MovieName = movie.MovieName;
                findMovie.MovieType = movie.MovieType;
                findMovie.MovieRating = movie.MovieRating;
                
                _contextMovie.SaveChanges();

                return _contextMovie.MovieInfoTables.ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidDataException("unable to update movie");

            }
        }
    }
}
