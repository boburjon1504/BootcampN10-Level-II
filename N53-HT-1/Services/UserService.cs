using N53_HT_1.Models;

namespace N53_HT_1.Services;

public class UserService
{
    private readonly List<User> _users = new List<User>();
    public User? GetById(int id) => _users.FirstOrDefault(user => user.Id == id);
    public List<User> Get() => _users;
    public User Create(User user)
    {
        _users.Add(user);
        return user;
    }
}
