using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Assessment.Application.Entities;
using Assessment.Application.Services;
using Assessment.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assessment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IApplicationUserService _applicationUserService;
        private readonly IPasswordService _passwordService;

        public TokenController(IConfiguration configuration, IApplicationUserService applicationUserService, IPasswordService passwordService)
        {
            _configuration = configuration;
            _applicationUserService = applicationUserService;
            _passwordService = passwordService;
        }

        [HttpPost]
        public async Task<IActionResult> Authentication(ApplicationUserLogin login)
        {
            //if it is a valid user
            var validation = await IsValidUser(login);
            if (validation.Item1)
            {
                var token = GenerateToken(validation.Item2);
                return Ok(new { token });
            }

            return NotFound();
        }

        private async Task<(bool, ApplicationUser)> IsValidUser(ApplicationUserLogin login)
        {
            var user = await _applicationUserService.GetLoginByCredentials(login);
            var isValid = _passwordService.Check(user.Password, login.Password);
            return (isValid, user);
        }

        private string GenerateToken(ApplicationUser applicationUser)
        {
            //Header
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:SecretKey"]));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var header = new JwtHeader(signingCredentials);

            //Claims
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, applicationUser.UserName),
                new Claim("User", applicationUser.UserName),
                new Claim(ClaimTypes.Role, applicationUser.Role.ToString()),
            };

            //Payload
            var payload = new JwtPayload
            (
                _configuration["Authentication:Issuer"],
                _configuration["Authentication:Audience"],
                claims,
                DateTime.Now,
                DateTime.UtcNow.AddMinutes(10)
            );

            var token = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
