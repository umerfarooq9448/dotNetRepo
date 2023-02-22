using EmployeeSecurity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using JwtRegisteredClaimNames = System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames;

namespace EmployeeSecurity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginControllerNew : ControllerBase
    {
        private readonly IConfiguration configuration;

        EmployeeLogContext context;
        
        
        public LoginControllerNew(IConfiguration configuration, EmployeeLogContext context)
        {
            this.configuration = configuration;
            this.context = context;
        }
        [HttpPost]
        [Route("/PostLoginDetails")]
        public async Task<IActionResult>LoginDetails(EmployeeLogTable user)
        {
            if (user != null)
            {
                var LoginCheck = context.EmployeeLogTables.Where(a => a.UserId == user.UserId && a.Password == user.Password).FirstOrDefault();
                if (LoginCheck != null)
                {
                    user.UserMessage = "Success";
                    var Token = GetToken(user);
                    return Ok(Token);
                }
                else
                {
                    return null;
                }
                
            }

            else
            {
                return null;
            }
        }

        private string GetToken(EmployeeLogTable user1)
        {
            // extra layer of protection using claims
            var tokenClaims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, configuration["Jwt:Register"]),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                new Claim("UserId", user1.UserId.ToString() ),
                new Claim("UserMessage",user1.UserMessage.ToString())

            };


            
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:key"]));
            var signin = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
            var token  = new JwtSecurityToken(configuration["jwt:Issuer"],
                configuration["jwt:Audience"],
                tokenClaims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: signin);

           return new JwtSecurityTokenHandler().WriteToken(token);
            
        }


        
    }
}
