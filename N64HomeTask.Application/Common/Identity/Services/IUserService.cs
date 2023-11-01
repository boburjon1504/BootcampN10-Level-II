using N64HomeTask.Application.Common.Identity.Models;
using N64HomeTask.Domain.Entities;

namespace N64HomeTask.Application.Common.Identity.Services;

public interface IUserService
{
    ValueTask<User> Create(User newUser);
    ValueTask<User> GetByEmail(string email);
}
