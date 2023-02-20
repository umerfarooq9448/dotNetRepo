using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SecurityMovie.Data_Access;
using SecurityMovie.Models;
using SecurityMovie.Repositories;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SecurityMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;

        private IUserService _userRepo;

        public LoginController(IConfiguration config, IUserService userRepo)
        {
            _config = config;
            _userRepo = userRepo;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] UserLogin userlogin)
        {
            var user = Authenticate(userlogin);
            if (user != null)
            {
                var token = generate(user);
                return Ok(token);
            }

            return NotFound("User not found");
        }

        private string generate(UserInfoTable user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["jwt:key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserName),
                new Claim(ClaimTypes.Email, user.UserEmail),
                new Claim(ClaimTypes.Role, user.Role)

            };

            var tokens = new JwtSecurityToken(_config["jwt:Issuer"],
                _config["jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(tokens);
        }



        private UserInfoTable Authenticate(UserLogin userlogin)
        {

            var currentUser = _userRepo.getUser().FirstOrDefault(o => o.UserName.Equals(userlogin.userName, StringComparison.OrdinalIgnoreCase)
            && o.UserPassword.Equals(userlogin.userpassword));

            if (currentUser != null)
            {
                return currentUser;

            }

            return null;



        }


        private UserInfoTable getCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {

                var userClaims = identity.Claims;

                return new UserInfoTable
                {
                    UserName = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier)?.Value,
                    UserEmail = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Email)?.Value,
                    Role = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.Role)?.Value
                };
            }
            return null;
        }




    }
}
