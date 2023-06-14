using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AnimeCommence.Models;
using AnimeShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace AnimeShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public AccountController(UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] Register model)
        {
            try
            {
                var user = new ApplicationUser
                {
                    Email = model.Email,
                    UserName = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    City = model.City,
                    State = model.State,
                    PostalCode = model.PostalCode,
                    Country = model.Country,
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    // Return Ok or a Token
                    return Ok(); // temporary Ok() for now
                }

                // Handle failure and return the errors
                return BadRequest(result.Errors);
            }
            catch(Exception ex)
            {
                // Log the exception
                // You could use a logging framework like Serilog, NLog etc. for better logging.
                Console.WriteLine(ex.Message);

                // Return a generic error message
                return BadRequest("An error occurred while registering the user.");
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] Login userModel)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var user = await _userManager.FindByEmailAsync(userModel.Email);
                if(user != null && 
                    await _userManager.CheckPasswordAsync(user, userModel.Password))
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.Id),
                        new Claim(ClaimTypes.Name, user.UserName),
                    };

                    var token = GenerateJwtToken(claims); 

                    return Ok(new { Token = token });
                }
                else
                {
                    return BadRequest("Invalid UserName or Password");
                }
            }
            catch(Exception ex)
            {
                // Log the exception
                Console.WriteLine(ex.Message);

                // Return a generic error message
                return BadRequest("An error occurred while logging in.");
            }
        }

        private string GenerateJwtToken(List<Claim> claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["Jwt:ExpireDays"]));

            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Issuer"],
                claims,
                expires: expires,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
