
using N43_HT_1.Models;

namespace N43_HT_1.Services;

public class UserService
{
    private readonly List<User> _users;
    public UserService()=>_users = new List<User>();
    public User Create(User user)
    {
        _users.Add(user);
        return user;
    }
    public async ValueTask<User> GetById(Guid id) => await Task.Run(()=>_users.FirstOrDefault(user => user.Id == id));
}
