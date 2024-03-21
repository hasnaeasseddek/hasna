using microservice.Auth.Models;
using microservice.Auth.service.Iservice;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace microservice.Auth.service
{
    public class test : Itest
    {
        private readonly JwtOptions _jwtOptions;
        public test(IOptions<JwtOptions> jwtOptions)
        {
            _jwtOptions = jwtOptions.Value;
            
        }

        public string generateToken(ApplicationUser applicationuser)
        {
            var tokenhandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtOptions.Secret);
            var claim = new List<Claim>
            {
                new Claim(ClaimTypes.Email,applicationuser.Email),
                new Claim(ClaimTypes.NameIdentifier,applicationuser.Id),
                new Claim(ClaimTypes.Name,applicationuser.Name)


            };
            var tokeDescription = new SecurityTokenDescriptor
            {
                Audience = _jwtOptions.Audience,
                Issuer = _jwtOptions.Issuer,
                Subject = new ClaimsIdentity(claim),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenhandler.CreateToken(tokeDescription);
            return tokenhandler.WriteToken(token);
        }
    }
}
