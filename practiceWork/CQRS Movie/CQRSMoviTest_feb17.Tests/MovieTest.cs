
using CQRS_Movie.Models;
using CQRS_Movie.Controllers;
using CQRS_Movie.Data_Access;
using Moq;


namespace CQRSMoviTest_feb17.Tests
{
   
    public class MovieTest
    {
        public Mock<IUserInterface> mock = new Mock<IUserInterface>();

        public Mock<IAdminInterface> mocka = new Mock<IAdminInterface>();
        [Fact]
        public void Test1()
        {


        }

        [Fact] public void getMovieById() 
        {
            // arrange

            mock.Setup(p => p.getMovieById(1)).Returns("umer");
            UserMovieController movie = new UserMovieController(mock.Object);

            
                //act
            var result = movie.getMovieById(1);

            //assert

            Assert.Equal(result, "umer");
        
        }

        [Fact] public void addMovie() {

            // arrange
            Tmovie movie = new Tmovie();
            List<Tmovie> m = new List<Tmovie>();
            mocka.Setup(p=>p.addNewMovie(movie));

            AdminController ad = new AdminController(mocka.Object);

            //act

            var result = ad.addMovie(movie);


            //assert

            Assert.Equal(result, m);

            
        
        
        
        }
    }
}