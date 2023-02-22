using MediatR;
using Microsoft.AspNetCore.Identity;
using MilestonePractice.Models;

namespace MilestonePractice.Commands.AdminCommands
{
    public record AddNewUserCommand(UserInfoTable user):IRequest<List<UserInfoTable>>;
    
}
