using Security.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Security.Application.Common.Services;

public interface ITokenGeneratorService
{
    string GetToken(User user);
    JwtSecurityToken GetJwtToken(User User);
    List<Claim> GetClaims(User User);


}
