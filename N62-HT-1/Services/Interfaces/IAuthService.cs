
using N62_HT_1.Models;

namespace N62_HT_1.Services.Interfaces;

public interface IAuthService
{
    ValueTask<bool> RegisterAsync(RegistrationDetails newUser);
    ValueTask<string> LoginAsync(LoginDetails loginDetails);

}
