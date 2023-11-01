using Microsoft.IdentityModel.Tokens;
using Security.Application.Common.Services;
using Security.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Security.Infrastructure.Common;

public class TokenGeneratorService : ITokenGeneratorService
{
    public string SecurityKey = "5DC21DA7-42DE-4130-A2F2-F8A978E2244F";
    public string GetToken(User user)
    {
        var jwtToken = GetJwtToken(user);
        var token = new JwtSecurityTokenHandler().WriteToken(jwtToken);
        return token;
    }
    public JwtSecurityToken GetJwtToken(User user)
    {
        var claims = GetClaims(user);
        var jwtToken = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecurityKey));
        var credentials = new SigningCredentials(jwtToken, SecurityAlgorithms.HmacSha256);
        return new JwtSecurityToken(
            issuer: "UserToken.App",
            audience:"UserToken.ClientApp",
            notBefore: DateTime.Now,
            expires: DateTime.Now.AddDays(1),
            claims:claims,
            signingCredentials:credentials);
    }

    public List<Claim> GetClaims(User user) =>
        new List<Claim>
        {
            new(ClaimTypes.Email,user.EmailAddress)
        };
}
