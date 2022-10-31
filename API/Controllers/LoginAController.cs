using employeerepositorylayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Modellayer;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LoginAController : Controller
    {
        private readonly AppContextDB data_Context;
        private readonly IConfiguration _config;
        public LoginAController(AppContextDB dContext, IConfiguration config)
        {
            data_Context = dContext;
            _config = config;
        }
        public static LoginVerify verify = new LoginVerify();
        [HttpPost("register")]
        public async Task<IActionResult> Register(Login request)
        {
            if (data_Context.Login.Any(u => u.username == request.username))
            {
                return BadRequest("User already exist");
            }

            CreatePasswordHash(request.password
                , out byte[] passwordHash
                , out byte[] passwordSalt);

            var verify = new LoginVerify
            {
                username = request.username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
               
            };

            data_Context.Login.Add(verify);
            await data_Context.SaveChangesAsync();

            return Ok("user Succesfully created");

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(Login request1)
        {

            var user = await data_Context.Login.FirstOrDefaultAsync(u => u.username == request1.username);
            if (user == null)
            {
                return BadRequest("User not found");
            }

            if (!VerifyPasswordHash(request1.password, user.PasswordHash, user.PasswordSalt))
            {
                return BadRequest("Password is Incorrect");
            }

            string token = CreateToken( user);

            return Ok(token);

        }
        private string CreateToken(LoginVerify user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.username),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
        
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.
                    ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.
                    ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);

            }
        }

   
    }

}
    
