using Admin.Api.Dtos;
using Admin.Api.Repositories.Interfaces;
using Admin.Api.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Admin.Api.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;
        private readonly IUserRepository _userRepository;
        public TokenService(IConfiguration configuration, IUserRepository userRepository)
        {
            _configuration = configuration;
            _userRepository = userRepository;
        }

        public string GenerateToken(LoginDto user)
        {
            var _userDatabase = _userRepository.GetByUserName(user.UserName);

            if (_userDatabase == null || user.UserName != _userDatabase.UserName || user.Password != _userDatabase.Password)
                return string.Empty;

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"] ?? string.Empty));
            var issuer = _configuration["Jwt:Issuer"] ?? string.Empty;
            var audience = _configuration["Jwt:Audience"] ?? string.Empty;

            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var tokenOptions = new JwtSecurityToken
            (
                issuer: issuer,
                audience: audience,
                claims: new[]
                {
                    new Claim(ClaimTypes.Name, _userDatabase.UserName),
                    new Claim(ClaimTypes.Role, _userDatabase.Role),
                },
                expires: DateTime.Now.AddHours(2),
                signingCredentials: signingCredentials
            );

            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return token;
        }
    }
}
