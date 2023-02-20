using CQRS_Movie.Models;

namespace CQRS_Movie.Data_Access
{
    // User interface contains the method definition that is  relevent to Admin
    public interface IAdminInterface
    {

        //to get all list of movies
        public List<Tmovie> getAllMovies();

        // to get movies by genresid
        public List<Tmovie> getMovieByGenresId(int GenresId);

        //to get list of movies by movie id
        public List<Tmovie> getMovieByMovieId(int MovieId);


        // to add new movie
        public List<Tmovie> addNewMovie(Tmovie movie);


        // to update a movie
        public List<Tmovie> updateMovie(Tmovie movie);


        //to delete a movie
        public string deleteMovie(int MovieId);
    }
}
