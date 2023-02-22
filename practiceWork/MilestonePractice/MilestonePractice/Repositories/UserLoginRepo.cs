using Microsoft.IdentityModel.Tokens;
using MilestonePractice.Data_Access;
using MilestonePractice.Models;
using System;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MilestonePractice.Repositories
{
    public class UserLoginRepo : IUserLogin
    {
        private readonly MovieDbContext _context;
        private readonly IConfiguration _configuration;

        public UserLoginRepo(MovieDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration= configuration;
        }


        public string Login(UserLogin user)
        {
           var nowuser = authenticate(user);
            if (nowuser != null)
            {
                return generate(nowuser);
            }
            return null;
        }


        public UserInfoTable authenticate(UserLogin user)
        {
            var currentUser = _context.UserInfoTables.Where(o => o.UserName == user.userName && o.UserPassword == user.userPassword).FirstOrDefault();
            if(currentUser!=null)
            {
                return currentUser;
            }
            return null;
        }

        public string generate(UserInfoTable user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Name),
                new Claim(ClaimTypes.Email, user.UserEmail),
                new  Claim(ClaimTypes.Role,user.Role),
            };

            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires:DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        
    }
}
