using MilestonePractice.Data_Access;
using MilestonePractice.Models;

namespace MilestonePractice.Repositories
{
    public class AdminRepository : IAdmin
    {
        private readonly MovieDbContext _contextMovie;

        public AdminRepository(MovieDbContext contextMovie)
        {
            _contextMovie = contextMovie;
        }

        public List<MovieInfoTable> addNewMovie(MovieInfoTable movie)
        {
            _contextMovie.MovieInfoTables.Add(movie);
            _contextMovie.SaveChanges();
            return _contextMovie.MovieInfoTables.ToList();
        }

        public List<UserInfoTable> addNewUser(UserInfoTable user)
        {
            _contextMovie.UserInfoTables.Add(user);
            _contextMovie.SaveChanges();
            return _contextMovie.UserInfoTables.ToList();
        }

        public string deleteMovieById(int id)
        {
            var movie = _contextMovie.MovieInfoTables.Find(id);
            if (movie != null)
            {
                _contextMovie.MovieInfoTables.Remove(movie);
                _contextMovie.SaveChanges();
                return "deleted";
            }
            return "not deleted";
        }

        public string deleteUserById(int id)
        {
            var user = _contextMovie.UserInfoTables.Find(id);
            if (user != null)
            {
                _contextMovie.UserInfoTables.Remove(user);
                _contextMovie.SaveChanges();
                return "deleted";
            }
            return "not able to delete";
        }

        public List<MovieInfoTable> getAllMovies()
        {
            return _contextMovie.MovieInfoTables.ToList();
        }

        public List<UserInfoTable> getAllUsers()
        {
            return _contextMovie.UserInfoTables.ToList();
        }

        public string getMovieById(int id)
        {
            var movie = _contextMovie.MovieInfoTables.Where(o => o.MovieId == id).Select(o => o.MovieName).FirstOrDefault();
            return movie;
        }

        public string updateMovie(MovieInfoTable movie)
        {
            var newmovie = _contextMovie.MovieInfoTables.Find(movie.MovieId);
            newmovie.MovieName = movie.MovieName;
            newmovie.MovieType= movie.MovieType;
            newmovie.MovieRating = movie.MovieRating;
            _contextMovie.SaveChanges();
            return "Updated Boss";


        }

        public string updateUser(UserInfoTable user)
        {
            var newuser = _contextMovie.UserInfoTables.Find(user.UserId);
            newuser.UserName = user.UserName;
            newuser.UserEmail = user.UserEmail;
            newuser.UserPassword = user.UserPassword;
            newuser.Role = user.Role;
            _contextMovie.SaveChanges();
            return "Updated Boss";

        }

        // method implementations for operations on movie


        //method to add a new Movie
        //public List<MovieInfoTable> addNewMovie(MovieInfoTable movie)
        //{

        //    try
        //    {
        //        _contextMovie.Add(movie);
        //        _contextMovie.SaveChanges();
        //        return _contextMovie.MovieInfoTables.ToList();

        //    }
        //    catch(Exception ex)
        //    {
        //        throw new InvalidDataException("Unable to add the movie");
        //    }

        //}
        ////method to delete movie by id
        //public string deleteMovieById(int id)
        //{
        //    try
        //    {
        //        var movie = _contextMovie.MovieInfoTables.FirstOrDefault(x => x.MovieId == id);
        //        if(movie != null)
        //        {
        //            _contextMovie.Remove(movie);
        //            _contextMovie.SaveChanges();
        //            return "deleted";

        //        }
        //        return "Movie Not Present";


        //    }catch(Exception ex)
        //    {
        //        throw new InvalidDataException("Unable to delete");

        //    }

        //}


        ////method to retrive all the list of movies
        //public List<MovieInfoTable> getAllMovies()
        //{
        //    try
        //    {
        //        return _contextMovie.MovieInfoTables.ToList();

        //    }
        //    catch(Exception ex)
        //    {
        //        throw new InvalidDataException("unable to retrive the data");

        //    }

        //}

        ////method to update a movie
        //public string updateMovie(MovieInfoTable movie)
        //{

        //    try
        //    {
        //        var findMovie = _contextMovie.MovieInfoTables.Find(movie.MovieId);
        //        findMovie.MovieName = movie.MovieName;
        //        findMovie.MovieType = movie.MovieType;
        //        findMovie.MovieRating = movie.MovieRating;
        //        _contextMovie.SaveChanges();
        //        return "Updated";

        //    }
        //    catch(Exception ex)
        //    {
        //        throw new InvalidDataException("Unable to update");
        //    }

        //}


        ////Method to get a movie by id

        //public string getMovieById(int id)
        //{
        //    try
        //    {

        //        var movie = _contextMovie.MovieInfoTables.Find(id).ToString();
        //        return movie;
        //    }
        //    catch(Exception ex)
        //    {
        //        throw new InvalidDataException("Unable to get the Movie");

        //    }

        //}




        //public List<UserInfoTable> addNewUser(UserInfoTable user)
        //{
        //    try
        //    {
        //        _contextMovie.UserInfoTables.Add(user);
        //        _contextMovie.SaveChanges();
        //        return _contextMovie.UserInfoTables.ToList();

        //    }
        //    catch(Exception ex)
        //    {
        //        throw new InvalidDataException();
        //    }

        //}



        //public string deleteUserById(int id)
        //{
        //    try
        //    {
        //        var user = _contextMovie.UserInfoTables.Find(id);

        //        if(user != null)
        //        {
        //            _contextMovie.Remove(user);
        //            _contextMovie.SaveChanges();
        //            return "User deleted";
        //        }
        //        return "Unable to find the user";
        //    }catch(Exception ex)
        //    {
        //        throw new InvalidDataException("Unable to delete the user");
        //    }
        //}



        //public List<UserInfoTable> getAllUsers()
        //{
        //    try
        //    {
        //        return _contextMovie.UserInfoTables.ToList();

        //    }catch(Exception ex)
        //    {
        //        throw new InvalidDataException("unable to fetch the lsit");
        //    }
        //}



        //public string updateUser(UserInfoTable user)
        //{
        //    try
        //    {
        //        var findUser = _contextMovie.UserInfoTables.Find(user.UserId);
        //        findUser.UserName = user.UserName;
        //        findUser.UserEmail = user.UserEmail;    
        //        findUser.UserPassword = user.UserPassword;
        //        findUser.Role = user.Role;
        //        _contextMovie.SaveChanges();
        //        return "Updated";
        //    }catch(Exception ex)
        //    {
        //        throw new InvalidDataException("Unable to update the user");
        //    }
        //}
    }
}
