using Identity.Application.Common.Identity.Models;

namespace Identity.Application.Common.Identity.Services;

public interface IAuthService
{
    ValueTask<bool> RegisterAsync(RegistrationDetails registrationDetails);
    ValueTask<string> LoginAsync(LoginDetails loginDetails);
}
