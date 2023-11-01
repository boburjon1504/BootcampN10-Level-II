using N64HomeTask.Application.Common.Identity.Models;
using N64HomeTask.Application.Common.Identity.Services;
using N64HomeTask.Domain.Entities;

namespace N64HomeTask.Infrastructure.Common.Identity.Services;

public class AuthService : IAuthService
{
    private readonly IUserService userService;
    private readonly ITokenGeneratorService tokenGeneratorService;

    public AuthService(IUserService userService, ITokenGeneratorService tokenGeneratorService)
    {
        this.userService = userService;
        this.tokenGeneratorService = tokenGeneratorService;
    }

    public async ValueTask<string> LoginAsync(LoginDetails loginDetails)
    {
        var user = await userService.GetByEmail(loginDetails.Email);

        return tokenGeneratorService.GetToken(user);
    }

    public async ValueTask<bool> RegisterAsync(RegistrationDetails newUser)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            FirstName = newUser.FirstName,
            LastName = newUser.LastName,
            Email = newUser.Email,
            Password = newUser.Password,
        };

        var a = await userService.Create(user);

        return true;

    }
}
