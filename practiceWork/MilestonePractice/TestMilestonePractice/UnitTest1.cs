using AutoFixture;
using MediatR;
using MilestonePractice.Controllers;
using MilestonePractice.Handler.AdminHandler;
using MilestonePractice.Handler.UserHandler;
using MilestonePractice.Models;
using MilestonePractice.Queries.UserQueries;
using MilestonePractice.Repositories;
using Moq;
using System.Security.Cryptography.X509Certificates;

namespace TestMilestonePractice
{
    public class UnitTest1
    {
        private Mock<UserRepository> _movieRepo;
        private IMediator _mediator;
        private UserController _controller;
        public UnitTest1(IMediator mediator) {
            MovieTestRepository movie = new MovieTestRepository();

            _movieRepo = movie.getUserRepository();

            _mediator = mediator;


        }
        

        
        [Fact]
        public void Test1()
        {

            //Arrange

            var _mediator = new Mock<IMediator>();
            //_mediator.Setup(m => m.Send(It.IsAny<GetAllMoviesQuery>(), It.IsAny<CancellationToken>()))
            //   .Callback<GetAllMoviesQuery, CancellationToken>((notification, cToken) =>
            //      GetAllMoviesHandler().Handle(notification, cToken));





            
            var handler = new GetAllMoviesHandler(_movieRepo.Object);

            var result = handler.Handle(new GetAllMoviesQuery(), CancellationToken.None);

            _mediator.Verify();
            
            _controller = new UserController(_mediator.Object);

            var res = _controller.getAllMovies();

            
            Fixture fix = new Fixture();

            var movieList = fix.CreateMany<MovieInfoTable>(3).ToList();



            //Assert.Equal(movieList,res);

            


            ////Act

            //Assert.Equal(result, );
            

        }
    }
}