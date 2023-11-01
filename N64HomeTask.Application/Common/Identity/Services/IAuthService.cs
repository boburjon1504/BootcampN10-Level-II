using N64HomeTask.Application.Common.Identity.Models;

namespace N64HomeTask.Application.Common.Identity.Services;

public interface IAuthService
{
    ValueTask<bool> RegisterAsync(RegistrationDetails newUser);
    ValueTask<string> LoginAsync(LoginDetails loginDetails);

}
