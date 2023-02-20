using SecurityMovie.Models;

namespace SecurityMovie.Data_Access
{
    public interface Imovie
    {
        //to get all list of movies
        public List<MovieInfoTable> getAllMovies();

        // to get movies by movieId
        public string getMovieById(int movieId);

        


        // to add new movie
        public List<MovieInfoTable> addNewMovie(MovieInfoTable movie);


        // to update a movie
        public List<MovieInfoTable> updateMovie(MovieInfoTable movie);


        //to delete a movie
        public string deleteMovie(int MovieId);
    }
}
