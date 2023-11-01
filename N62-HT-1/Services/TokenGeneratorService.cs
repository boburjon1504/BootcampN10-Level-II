using Microsoft.IdentityModel.Tokens;
using N62_HT_1.Models;
using N62_HT_1.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace N62_HT_1.Services;

public class TokenGeneratorService : ITokenGeneratorService
{
    public string SecurityKey = "08526C4F-2457-453C-934D-60CEFC3BC59A";
    public string GetToken(User user)
    {
        var jwtToken = GetJwtToken(user);
        return new JwtSecurityTokenHandler().WriteToken(jwtToken);
    }

    public JwtSecurityToken GetJwtToken(User user)
    {
        var claims = GetClaims(user);

        var security = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecurityKey));
        var credentials = new SigningCredentials(security, SecurityAlgorithms.HmacSha256);

        return new JwtSecurityToken(
            issuer: "Tugadi.App",
            audience: "Tugadi.ClientApp",
            claims: claims,
            notBefore: DateTime.Now,
            signingCredentials: credentials);
    }
    public List<Claim> GetClaims(User user) => new List<Claim>
    {
        new(ClaimTypes.Email,user.Email),
    };
}
