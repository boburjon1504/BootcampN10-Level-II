

using N62_HT_1.Models;

namespace N62_HT_1.Services.Interfaces;

public interface IUserService
{
    ValueTask<User> Create(User newUser);
    ValueTask<User> GetByEmail(string email);
}
