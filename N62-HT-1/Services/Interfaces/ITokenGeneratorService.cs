using N62_HT_1.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace N62_HT_1.Services.Interfaces;

public interface ITokenGeneratorService
{
    string GetToken(User user);

    JwtSecurityToken GetJwtToken(User user);

    List<Claim> GetClaims(User user);

}
