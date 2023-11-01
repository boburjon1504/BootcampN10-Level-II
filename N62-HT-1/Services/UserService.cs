using N62_HT_1.Models;
using N62_HT_1.Services.Interfaces;

namespace N62_HT_1.Services;

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
