using MediatR;
using MilestonePractice.Commands.AdminCommands;
using MilestonePractice.Data_Access;
using MilestonePractice.Models;

namespace MilestonePractice.Handler.AdminHandler
{
    public class AddNewMovieHandler:IRequestHandler<AddNewMovieCommand,List<MovieInfoTable>>
    {
        private readonly IAdmin _admin;

        public AddNewMovieHandler(IAdmin admin)
        {
                _admin = admin;
        }

        public async Task<List<MovieInfoTable>> Handle(AddNewMovieCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_admin.addNewMovie(request.movie));
        }
    }
}
