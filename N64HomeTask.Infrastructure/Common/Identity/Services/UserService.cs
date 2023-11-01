using N64HomeTask.Application.Common.Identity.Services;
using N64HomeTask.Domain.Entities;

namespace N64HomeTask.Infrastructure.Common.Identity.Services;

public class UserService : IUserService
{
    private static List<User> _users = new List<User>();
    public ValueTask<User> Create(User newUser)
    {
        _users.Add(newUser);

        return new(newUser);
    }

    public ValueTask<User> GetByEmail(string email) =>
        new(_users.FirstOrDefault(user => user.Email == email));
}
