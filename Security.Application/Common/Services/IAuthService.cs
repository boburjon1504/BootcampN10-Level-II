using Security.Domain.Dtos;
using Security.Domain.Entities;

namespace Security.Application.Common.Services;

public interface IAuthService
{
    ValueTask<UserViewModel> RegisterAsync(RegistrationDetails user);
    ValueTask<string> LoginAsync(LoginDetails user);
}
