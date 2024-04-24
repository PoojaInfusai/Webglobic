using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using Webglobic.Services;
using Webglobic.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Webglobic.Models;



namespace Webglobic.Controllers
{
    [Route("api/[controller]")]
    public class TokenController : ControllerBase
    {


        private readonly StorageBroker _context;
        private IConfiguration _config;

        public TokenController(StorageBroker context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost("odata/token")]
        public IActionResult Login([FromBody] User data)
        {
            IActionResult response = Unauthorized();
            var user = AuthenticateUser(data);
            if (user != null)
            {
                var tokenString = GenerateJSONWebToken(user);
                response = Ok(new { Token = tokenString, Message = "Success" });
            }
            return response;

        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("odata/GetAccessToken")]
        public async Task<IActionResult> Get()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");
            var currentUser = HttpContext.User;
            var Jti = "";
            var Username = "";
            if (currentUser.HasClaim(c => c.Type == "jti"))
            {
                Jti = currentUser.Claims.FirstOrDefault(c => c.Type == "jti").Value;

            }
            if (currentUser.HasClaim(c => c.Type == "Username"))
            {
                Username = currentUser.Claims.FirstOrDefault(c => c.Type == "Username").Value;

            }
            return Ok(new { Token = accessToken, Jti = Jti, Username = Username });
        }


        private string GenerateJSONWebToken(User userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
            new Claim(JwtRegisteredClaimNames.Email, userInfo.UserName),
            //new Claim(JwtRegisteredClaimNames.Email, userInfo.EmailAddress),
            new Claim("Username", userInfo.UserName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              claims,
              expires: DateTime.Now.AddMinutes(10),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private User AuthenticateUser(User login)
        {
            User user = null;
            // await Task.Delay(0);
            if (login.UserName == "odata")
            {
                user = new User { UserName = "odata", Password = "odata123" };
            }
            return user;
        }
    }
}

