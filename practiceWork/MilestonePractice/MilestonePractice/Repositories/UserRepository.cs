using MilestonePractice.Data_Access;
using MilestonePractice.Models;

namespace MilestonePractice.Repositories
{
    public class UserRepository : IUser
    {
        MovieDbContext _context;

        public UserRepository(MovieDbContext context)
        {
            _context = context;
        }
        public List<MovieInfoTable> getAllMovies()
        {
            try
            {
                return _context.MovieInfoTables.ToList();


            }catch(Exception ex)
            {
                throw new InvalidDataException("Unable to get the movies");
            }
        }
    }
}
