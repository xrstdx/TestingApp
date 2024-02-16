using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TestingApp.Application.Interfaces;
using TestingApp.Domain.Entities;
using TestingApp.Infrastructure.Settings;

namespace TestingApp.Infrastructure.Services;

public class JwtProvider : IJwtProvider
{
    private readonly JwtSettings _options;

    public JwtProvider(IOptions<JwtSettings> options)
    {
        _options = options.Value;
    }

    public string GenerateToken(User user)
    {
        {
            var claims = new Claim[]
            {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.UserName),
            };

            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_options.SecretKey)),
                SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                _options.Issuer,
                _options.Audience,
                claims,
                null,
                DateTime.UtcNow.AddHours(1),
                signingCredentials);

            string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

            return tokenValue;
        }
    }

}
