using AutoFixture;
using MilestonePractice.Models;
using MilestonePractice.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMilestonePractice
{
    public  class MovieTestRepository
    {
        Fixture fix;
        public MovieTestRepository() {
            fix = new Fixture();

        }
        
        public  Mock<UserRepository> getUserRepository()
        {
            var movieList = fix.CreateMany<MovieInfoTable>(3).ToList();
            var mockRepo = new Mock<UserRepository>();
            mockRepo.Setup(r=>r.getAllMovies()).Returns(movieList);
            return mockRepo;
        }
    }
}
