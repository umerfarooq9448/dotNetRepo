using CQRS_Movie.Data_Access;
using CQRS_Movie.Models;

namespace CQRS_Movie.Repositories
{
    public class AdminRepository : IAdminInterface
    {
        private readonly MoviesContext _contextMovie;

        public AdminRepository(MoviesContext contextMovie)
        {
            _contextMovie = contextMovie;
        }


        //to add new movies
        public List<Tmovie> addNewMovie(Tmovie movie)
        {
            try
            {
                _contextMovie.Add(movie);
                _contextMovie.SaveChanges();
                return _contextMovie.Tmovies.ToList();

            }
            catch (Exception ex)
            {
                throw new InvalidDataException("Unable to add new movie");
            }
            
        }


        // delete a movie
        public string deleteMovie(int MovieId)
        {
            var data = _contextMovie.Tmovies.FirstOrDefault(x => x.MovieId == MovieId);


            try {

                if (data != null)
                {

                    _contextMovie.Tmovies.Remove(data);
                    _contextMovie.SaveChanges();
                }

            }catch(Exception ex)
            {
                throw new InvalidDataException("cant delete this sorry");
            }

            return "deleted";
        }


        //returne the list of all the movies
        public List<Tmovie> getAllMovies()
        {
            try
            {
                return _contextMovie.Tmovies.ToList();

            }
            catch(Exception ex)
            {
                throw new InvalidDataException("unable to retrive data");
            }
            
        }


        public List<Tmovie> getMovieByGenresId(int GenresId)
        {
            throw new NotImplementedException();
        }

        public List<Tmovie> getMovieByMovieId(int MovieId)
        {
            throw new NotImplementedException();
        }


        //to update a movie
        public List<Tmovie> updateMovie(Tmovie movie)
        {
            try
            {
                var findMovie = _contextMovie.Tmovies.Find(movie.MovieId);
                findMovie.MovieName = movie.MovieName;
                findMovie.GenresId = movie.GenresId;
                _contextMovie.SaveChanges();

                return _contextMovie.Tmovies.ToList();

            }
            catch(Exception ex)
            {
                throw new InvalidDataException("unable to delete");
            }
            
        }
    }
}
