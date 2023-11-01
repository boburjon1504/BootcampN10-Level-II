using N64HomeTask.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace N64HomeTask.Application.Common.Identity.Services;

public interface ITokenGeneratorService
{
    string GetToken(User user);

    JwtSecurityToken GetJwtToken(User user);

    List<Claim> GetClaims(User user);

}
